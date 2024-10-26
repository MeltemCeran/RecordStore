using RecordStore.DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStore.DAL.Services.Concrete
{
    public class AlbumService<TModel> :Abstract.Service<TModel,Album>
    where TModel : class
    {
        public AlbumService() 
        {
            _repository = _unitOfWork.Albums;
        }
    }
}
