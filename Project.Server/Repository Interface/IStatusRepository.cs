using Project.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Server.Repository_Interface
{
   public interface IStatusRepository
    {
        Task<IEnumerable<Status>> GetStatuse();
        Task<Status> GetStatus(int statusId);
    }
}
