using DIYManagementAPI.Models;
using DIYManagementAPI.Models.DTO;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Linq;

namespace DIYManagementAPI.Data
{
    public class DIYDAO
    {
        private readonly DatabaseContext _context;

        public DIYDAO(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<DIYEveningModel> CreateDIYEvening(DIYEveningModel diyEvening)
        {
            _context.DIYEvening.Add(diyEvening);
            await _context.SaveChangesAsync();

            return diyEvening;
        }

        public async Task<IEnumerable<DIYEveningModel>> GetDIYEvenings()
        {
            return await _context.DIYEvening.ToListAsync();
        }

        public async Task<IEnumerable<DIYEveningModel>> GetFutureDIYEvenings()
        {
            var now = DateTime.Now;
            return await _context.DIYEvening
                        .Where(x => x.EndDate.Date > now.Date ||
                              (x.EndDate.Date == now.Date && x.EndDate.TimeOfDay > now.TimeOfDay))
                        .OrderBy(e => e.StartDate)
                        .ToListAsync();
        }

        public async Task<DIYEveningModel> GetDIYEveningById(int id)
        {
            return await _context.DIYEvening.FindAsync(id);
        }

        public async Task RegisterDIYEveningCustomer(DIYRegistration registration)
        {
            _context.DIYRegistrations.Add(registration);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<DIYRegistration>> GetRegistrationsForDIYEvening(int diyEveningId)
        {
            return await _context.DIYRegistrations.Where(r => r.DIYEveningId == diyEveningId).ToListAsync();
        }

        public async Task<DIYEveningModel> CancelDIYEvening(int id)
        {
            var diyEvening = await _context.DIYEvening.FindAsync(id);
            if (diyEvening == null)
            {
                throw new Exception("DIY Evening not found");
            }

            diyEvening.Cancelled = true;
            await _context.SaveChangesAsync();

            return diyEvening;
        }

        public async Task<bool> CancelDIYRegistration(int diyRegistrationId)
        {
            var registration = await _context.DIYRegistrations.FindAsync(diyRegistrationId);

            if (registration == null)
            {
                return false;
            }

            _context.DIYRegistrations.Remove(registration);

            await _context.SaveChangesAsync();

            return true;
        }
        
        public async Task<DIYFeedback> RegisterDIYFeedback(DIYFeedback diyFeedback)
        {   
            _context.DIYFeedback.Add(diyFeedback);
            await _context.SaveChangesAsync();
            return diyFeedback;
        }

        public async Task<IEnumerable<DIYCustomerHistoryDTO>> GetCustomerHistory(string customerName)
        {
            var now = DateTime.Now;

            return await _context.DIYEvening
                .Join(_context.DIYRegistrations,
                      evening => evening.Id,
                      registration => registration.DIYEveningId,
                      (evening, registration) => new { evening, registration })
                .GroupJoin(_context.DIYFeedback,
                      combined => combined.evening.Id,
                      feedback => feedback.DIYEveningId,
                      (combined, feedbackGroup) => new { combined.evening, combined.registration, feedbackGroup })
                .SelectMany(x => x.feedbackGroup.DefaultIfEmpty(),
                      (x, feedback) => new { x.evening, x.registration, feedback })
                .Where(x => x.registration.CustomerName == customerName &&
                             (x.evening.EndDate.Date < now.Date ||
                              (x.evening.EndDate.Date == now.Date && x.evening.EndDate.TimeOfDay < now.TimeOfDay)))
                .Select(dto => new DIYCustomerHistoryDTO
                {
                    Id = dto.evening.Id,
                    Title = dto.evening.Title,
                    Reparations = dto.registration.Reparations,
                    StartDate = dto.evening.StartDate,
                    EndDate = dto.evening.EndDate,
                    Feedback = dto.feedback.Feedback
                })
                .OrderBy(dto => dto.StartDate)
                .ToListAsync();
        }

        public async Task<List<DIYFeedback>> GetFeedbackByDIYEveningIdAsync(int diyEveningId)
        {
            var feedback = await _context.DIYFeedback
            .Where(f => f.DIYEveningId == diyEveningId)
            .ToListAsync();

            return feedback ?? new List<DIYFeedback>();
        }
    }
}
