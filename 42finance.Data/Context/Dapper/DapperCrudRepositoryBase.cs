using _42finance.Domain.Base.Intefaces.Data;
using System;
using System.Linq;

namespace inmasys.Data.Context.Dapper
{
    public abstract class DapperCrudRepositoryBase<TCodigoType, TEntity> : ICrudRepository<TCodigoType, TEntity> where TEntity : class
    {
        protected readonly IDbService _Context;
        public DapperCrudRepositoryBase(IDbService context)
        {
            _Context = context;
        }

        public IQueryable<TEntity> GetAll(bool nolock = false)
        {
            return _Context.GetAll<TEntity>();
        }

        public TEntity GetById(Guid id, bool nolock = false)
        {
            return _Context.GetById<TEntity>(id, nolock);
        }

        public TCodigoType Insert(TEntity entity)
        {
            return _Context.Insert<TCodigoType, TEntity>(entity);
        }

        public void Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }       
    }
}
