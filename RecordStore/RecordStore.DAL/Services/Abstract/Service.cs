using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RecordStore.DAL.Context;
using RecordStore.DAL.Entities.Abstract;
using RecordStore.DAL.Repositories.Abstract;
using RecordStore.DAL.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStore.DAL.Services.Abstract
{
    public class Service<TModel, TEntity> : IDisposable, IService<TModel>

        where TModel : class
        where TEntity : BaseEntity
    {
        private protected readonly IUnitOfWork _unitOfWork;

        private protected IRepository<TEntity> _repository;

        private IConfigurationProvider _config;

        private protected IMapper _mapper;

        private bool disposed = false;



        public Service()
        {
            RecordStoreDbContext _dbContext = new RecordStoreDbContext();
            _unitOfWork = new UnitOfWork(_dbContext);
            _config = new MapperConfiguration(cfg => { cfg.CreateMap<TEntity, TModel>().ReverseMap(); });
            _mapper = new Mapper(_config);
        }

        public void Add(TModel model)

        {

            TEntity entity = _mapper.Map<TEntity>(model);

            _repository.Add(entity);

        }

        public void Update(TModel model)

        {

            TEntity entity = _mapper.Map<TEntity>(model);

            _repository.Update(entity);

        }

        public void Delete(TModel model)

        {

            TEntity entity = _mapper.Map<TEntity>(model);

            _repository.Delete(entity);

        }

        public void Delete(int id)

        {

            TEntity entity = _repository.Get(id);

            _repository.Delete(entity);

        }

        public TModel Get(int id)

        {

            TEntity entity = _repository.Get(id);

            TModel model = _mapper.Map<TModel>(entity);

            return model;

        }

        public ICollection<TModel> GetAll()

        {

            ICollection<TEntity> entities = _repository.GetAll();

            ICollection<TModel> models = _mapper.Map<ICollection<TModel>>(entities);

            return models;

        }

        public int Save()

        {

            return _unitOfWork.Complete();

        }

        protected virtual void Dispose(bool disposing)

        {

            if (!this.disposed)

            {

                if (disposing)

                {

                    _unitOfWork.Dispose();

                    _repository.Dispose();

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
