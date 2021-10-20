using _42finance.Domain.Base.Intefaces.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;

namespace _42finance.Data.Context.Dapper
{
   
    public class DapperDbServiceBase: IDbService
    {
        private readonly string _connString;

        public DapperDbServiceBase(IConfiguration configuration)
        {
            _connString = configuration.GetConnectionString("inmasys");
        }

        public IQueryable<TEntity> GetAll<TEntity>(bool nolock = false) where TEntity : class
        {
            using var db = new SqlConnection(_connString);

            return db.GetList<TEntity>().AsQueryable();
        }

        public TEntity GetById<TEntity>(Guid id, bool nolock = false) where TEntity : class
        {
            using var db = new SqlConnection(_connString);

            return db.Get<TEntity>(id);
        }

        public TCodigoType Insert<TCodigoType, TEntity>(TEntity entity) where TEntity : class
        {
            using var db = new SqlConnection(_connString);

           return db.Insert<TCodigoType, TEntity>(entity);
        }

        public IQueryable<TResult> RawQuery<TResult>(IQuery<TResult> query) where TResult : class
        {
            using var db = new SqlConnection(_connString);

            var sql = query.GetSql();
            var paramsObj = query.BuildObject();

            return db.Query<TResult>(sql, paramsObj).AsQueryable();
        }

        public void Remove<TEntity>(TEntity entity) where TEntity : class
        {
            using var db = new SqlConnection(_connString);

            db.Delete(entity);
        }

        public void Update<TEntity>(TEntity entity) where TEntity : class
        {
            using var db = new SqlConnection(_connString);

            db.Update(entity);
        }
    }
}
