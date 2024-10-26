using RecordStore.BLL.Managers.Abstract;
using RecordStore.BLL.Models.Concrete;
using RecordStore.DAL.Entities.Concrete;
using RecordStore.DAL.Services.Concrete;
using RecordStore.DAL.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStore.BLL.Managers.Concrete
{
    public class UserManager : Manager<UserModel, UserService<UserModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        
        public UserManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

    }
}
