using System;
using System.Linq;

namespace _42finance.Domain.Base.Intefaces.Data
{
    public interface IDbService
    {
        TCodigoType Insert<TCodigoType, TEntity>(TEntity entity) where TEntity : class;
        void Update<TEntity>(TEntity entity) where TEntity : class;
        void Remove<TEntity>(TEntity entity) where TEntity : class;
        IQueryable<TEntity> GetAll<TEntity>(bool nolock = false) where TEntity : class;
        TEntity GetById<TEntity>(Guid id, bool nolock = false) where TEntity : class;
        IQueryable<TResult> RawQuery<TResult>(IQuery<TResult> query) where TResult : class;
    }
}
