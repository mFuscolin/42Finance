using System;
using System.Linq;

namespace _42finance.Domain.Base.Intefaces.Data
{
    public interface ICrudRepository<TCodigoType,TEntity>
    {
        TCodigoType Insert(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        TEntity GetById(Guid id, bool nolock = false);
        IQueryable<TEntity> GetAll(bool nolock = false);
    }
}
