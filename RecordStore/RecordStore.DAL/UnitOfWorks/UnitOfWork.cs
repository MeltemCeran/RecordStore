using Microsoft.EntityFrameworkCore;
using RecordStore.DAL.Context;
using RecordStore.DAL.Repositories.Abstract;
using RecordStore.DAL.Repositories.Concrete;
using RecordStore.DAL.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStore.DAL.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private protected DbContext _dbContext;
        private bool disposed = false;

        public UnitOfWork(DbContext dbContext)
        {
           _dbContext = dbContext;
           
            Users = new UserRepository(_dbContext);
            Albums = new AlbumRepository(_dbContext);
        }

        public IUserRepository Users { get; private set; }
        public IAlbumRepository Albums { get; private set; }

        public int Complete()
        {
            int affectedRows = _dbContext.SaveChanges();

            return affectedRows;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                    Users.Dispose();
                    Albums.Dispose();
                   
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
