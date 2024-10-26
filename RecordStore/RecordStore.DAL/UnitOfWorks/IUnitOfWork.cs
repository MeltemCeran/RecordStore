using RecordStore.DAL.Context;
using RecordStore.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStore.DAL.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        IAlbumRepository Albums { get; }
        int Complete();

    }
}
