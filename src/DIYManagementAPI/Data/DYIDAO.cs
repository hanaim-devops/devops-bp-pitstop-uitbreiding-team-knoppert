﻿using DIYManagementAPI.Models;
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

        public async Task<DIYEveningModel> CreateDIYEvening(DIYEveningModel diyEvening)
        {
            // TODO: reparateurs ophalen uit de database en zetten
           
            _context.DIYEveningModels.Add(diyEvening);
            await _context.SaveChangesAsync();

            return diyEvening;
        }

        public async Task<IEnumerable<DIYEveningModel>> GetDIYEvenings()
        {
            return await _context.DIYEveningModels.ToListAsync();
        }
    }
}
