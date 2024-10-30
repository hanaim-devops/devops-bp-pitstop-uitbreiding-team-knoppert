﻿using DIYManagementAPI.Data;
using DIYManagementAPI.Models;
using DIYManagementAPI.Models.DTO;

namespace DIYManagementAPI.Services
{
    public class DIYService
    {
        private readonly DIYDAO _dao;
        public DIYService(DIYDAO dao)
        {
            _dao = dao;
        }

        public async Task<DIYEveningModel> CreateDIYEvening(DIYEveningCreateDto dto)
        {
            var diyEvening = new DIYEveningModel
            {
                Title = dto.Title,
                ExtraInfo = dto.ExtraInfo,
                StartDate = dto.StartDate,
                EndDate = dto.EndDate,
                Mechanic = dto.Mechanic
            };

            return await _dao.CreateDIYEvening(diyEvening);
        }

        public async Task<IEnumerable<DIYEveningModel>> GetDIYEvenings()
        {
            return await _dao.GetDIYEvenings();
        }

        public async Task<DIYEveningModel> GetDIYEveningById(int id)
        {
            return await _dao.GetDIYEveningById(id);
        }

        public async Task RegisterDIYEveningCustomer(DIYRegistrationCreateDto dto)
        {
            var registration = new DIYRegistration
            {
                DIYEveningId = dto.DIYEveningId,
                CustomerName = dto.CustomerName,
                Reparations = dto.Reparations
            };

            await _dao.RegisterDIYEveningCustomer(registration);
        }

        public async Task<IEnumerable<DIYRegistration>> GetRegistrationsForDIYEvening(int diyEveningId)
        {
            return await _dao.GetRegistrationsForDIYEvening(diyEveningId);
        }

        public async Task<DIYEveningModel> CancelDIYEvening(int id)
        {
            return await _dao.CancelDIYEvening(id);
        }

        public async Task<bool> CancelDIYRegistration(int diyEveningId)
        {
            return await _dao.CancelDIYRegistration(diyEveningId);
        }
        
        public async Task RegisterDIYFeedback(DIYFeedbackCreateDto dto)
        {
            var feedback = new DIYFeedback
            {
                DIYEveningId = dto.DIYEveningId,
                CustomerName = dto.CustomerName,
                Feedback = dto.Feedback
            };

            await _dao.RegisterDIYFeedback(feedback);
        }

        public async Task<IEnumerable<DIYCustomerHistoryDTO>> GetCustomerHistory(string customerName)
        {
            return await _dao.GetCustomerHistory(customerName);
        }

        public async Task<List<DIYFeedback>> GetFeedbackAsync(int diyEveningId)
        {
            var feedback = await _dao.GetFeedbackByDIYEveningIdAsync(diyEveningId);

            if (feedback == null || !feedback.Any())
            {
                return new List<DIYFeedback>();
            }
            
            return feedback;
        }
    }
}
