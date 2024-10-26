using RecordStore.DAL.Context;
using RecordStore.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStore.DAL.UnitOfWorks
{
    internal interface IUnitOfWork : IDisposable
    {
        RecordStoreDbContext DbContext { get; }

        IUserRepository Users { get; }
        IAlbumRepository Albums { get; }

        int Complete();

    }
}
