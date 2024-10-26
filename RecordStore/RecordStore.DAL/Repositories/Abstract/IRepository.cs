using RecordStore.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStore.DAL.Repositories.Abstract
{
    public interface IRepository<TEntity> : IDisposable where TEntity : BaseEntity
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Delete(int id);

        TEntity Get(int id);
        ICollection<TEntity> GetAll();
    }
}
