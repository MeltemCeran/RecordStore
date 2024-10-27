using Microsoft.EntityFrameworkCore;
using RecordStore.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStore.DAL.Repositories.Abstract
{
    public abstract class Repository<TEntity>: IRepository<TEntity> where TEntity : BaseEntity
    {
        private protected DbContext _dbContext;
        private protected DbSet<TEntity> _entities;
        private bool disposed = false;

        protected Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _entities = _dbContext.Set<TEntity>();
        }

        public virtual void Add(TEntity entity)
        {
            _entities.Add(entity);
        }

        public void Update(TEntity entity)
        {
            _entities.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            entity.DeletedDate = DateTime.Now;
            _entities.Update(entity);
        }

        public void Delete(int id)
        {
            TEntity? entity = _entities.AsNoTracking().Where(s => s.Id == id).ToList().SingleOrDefault();

            Delete(entity);
        }

        public TEntity Get(int id)
        {
            return _entities.AsNoTracking().Where(e => e.Id == id).SingleOrDefault();
        }

        public ICollection<TEntity> GetAll()
        {
            return _entities.AsNoTracking().ToList();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


    }
}

