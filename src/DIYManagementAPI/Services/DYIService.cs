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

        public async Task RegisterDIYEveningCustomer(DIYRegistration registration)
        {
            await _dao.RegisterDIYEveningCustomer(registration);
        }

        public async Task RegisterDIYFeedback(DIYFeedback feedback)
        {
            await _dao.RegisterDIYFeedback(feedback);
        }

        public async Task<List<DIYFeedback>> GetFeedbackAsync(int diyEveningId)
        {
            return await _dao.GetFeedbackByDIYEveningIdAsync(diyEveningId);
        }

        public async Task<List<DIYRegistration>> GetRegistrationAsync(int diyEveningId)
        {
            return await _dao.GetRegistrationByDIYEveningIdAsync(diyEveningId);
        }

        public async Task<bool> CancelDIYRegistration(int diyEveningId)
        {
            return await _dao.CancelDIYRegistration(diyEveningId);
        }
        
        public async Task<IEnumerable<DIYRegistration>> GetRegistrationsForDIYEvening(int diyEveningId)
        {
            return await _dao.GetRegistrationsForDIYEvening(diyEveningId);
        }
    }
}
