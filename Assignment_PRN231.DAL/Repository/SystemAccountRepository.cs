using Assignment_PRN231.DAL.Repository.IRepository;
using Assignment_PRN231.Model.Data;
using Assignment_PRN231.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_PRN231.DAL.Repository
{
    public class SystemAccountRepository : GenericRepository<SystemAccount>, ISystemAccountRepository
    {
        private readonly FunewsManagementSpring2025Context _context;

        public SystemAccountRepository(FunewsManagementSpring2025Context context) : base(context)
        {
            _context = context;
        }

        public async Task<SystemAccount> GetByEmailAsync(string email)
        {
            return await _context.SystemAccounts
                .FirstOrDefaultAsync(x => x.AccountEmail == email);
        }
    }
}
