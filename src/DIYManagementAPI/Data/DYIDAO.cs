using DIYManagementAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DIYManagementAPI.Data
{
    public class DYIDAO
    {
        private readonly DatabaseContext _context;

        public DYIDAO(DatabaseContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<DiyTestModel>> GetTestResults()
        {
            // creates a list of fake data 
            var results = new List<DiyTestModel>
            {
                new DiyTestModel { Name = "Test 1", Description = "This is a test" },
                new DiyTestModel { Name = "Test 2", Description = "This is a test" },
                new DiyTestModel { Name = "Test 3", Description = "This is a test" },
                new DiyTestModel { Name = "Test 4", Description = "This is a test" },
                new DiyTestModel { Name = "Test 5", Description = "This is a test" }
            };

            return Task.FromResult<IEnumerable<DiyTestModel>>(results);
        }

        public async Task<DIYAvondModel> CreateDIYAvond(DIYAvondModel diyAvond, List<int> reparateurIds)
        {
            //var newDiyAvond = new DIYAvondModel { Title = "Test 1", ExtraInfo = "This is a test" };
            //_context.DIYAvondModels.Add(newDiyAvond);

            //await _context.SaveChangesAsync();

            //return newDiyAvond;

            var reparateurs = await _context.Reparateurs
            .Where(r => reparateurIds.Contains(r.Id))
            .ToListAsync();

            // Koppel de reparateurs aan de DIYAvond
            diyAvond.Reparateurs = reparateurs;

            _context.DIYAvondModels.Add(diyAvond);
            await _context.SaveChangesAsync();

            return diyAvond;
        }
    }
}
