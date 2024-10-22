﻿using DIYManagementAPI.Data;
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

        public async Task<DIYEveningModel> CreateDIYEvening(DIYEveningModel diyEvening)
        {
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

        public async Task RegisterDIYAvondCustomer(DIYRegistration registration)
        {
            await _dao.RegisterDIYAvondCustomer(registration);
        }

        public async Task<IEnumerable<DIYRegistration>> GetRegistrationsForDIYAvond(int diyEveningId)
        {
            return await _dao.GetRegistrationsForDIYAvond(diyEveningId);
        }
    }
}
