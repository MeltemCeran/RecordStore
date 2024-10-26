using RecordStore.DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStore.DAL.Repositories.Abstract
{
    public interface IUserRepository : IRepository<User>, IDisposable
    {
    }
}
