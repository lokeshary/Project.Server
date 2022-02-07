using Microsoft.EntityFrameworkCore;
using Project.Server.Repository_Interface;
using Project.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Server.Models
{
    public class StatusRepository : IStatusRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public StatusRepository(ApplicationDbContext _applicationDbContext)
        {
            this._applicationDbContext = _applicationDbContext;
        }

        public async Task<Status> GetStatus(int statusId)
        {
            return await _applicationDbContext.Statuse
                .FirstOrDefaultAsync(d => d.Sid == statusId);
        }

        public async Task<IEnumerable<Status>> GetStatuse()
        {
            return await _applicationDbContext.Statuse.ToListAsync();
        }
    }
}
