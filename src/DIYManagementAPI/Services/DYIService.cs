using DIYManagementAPI.Data;
using DIYManagementAPI.Models;

namespace DIYManagementAPI.Services
{
    public class DYIService
    {
        private readonly DYIDAO _dao;
        public DYIService(DYIDAO dao)
        {
            _dao = dao;
        }

        public async Task<DIYAvondModel> CreateDIYAvond(DIYAvondModel diyAvond, List<int> reparateurIds)
        {
            return await _dao.CreateDIYAvond(diyAvond, reparateurIds);
        }
    }
}
