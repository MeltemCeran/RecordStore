using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStore.DAL.Services.Abstract
{
    public interface IService<TModel> : IDisposable where TModel : class
    {
        void Add(TModel model);
        void Update(TModel model);
        void Delete(TModel model);
        void Delete(int id);

        TModel Get(int id);
        ICollection<TModel> GetAll();

        int Save();
    }
}
