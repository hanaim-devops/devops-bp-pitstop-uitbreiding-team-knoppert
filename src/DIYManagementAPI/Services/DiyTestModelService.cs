using DIYManagementAPI.Data;
using DIYManagementAPI.Models;

namespace DIYManagementAPI.Services
{
    public class DiyTestModelService
    {
        private readonly DYIDAO _dao;
        public DiyTestModelService(DYIDAO dao)
        {
            _dao = dao;
        }

        public Task<IEnumerable<DiyTestModel>> GetTestResults()
        {
            return _dao.GetTestResults();
        }
    }
}
