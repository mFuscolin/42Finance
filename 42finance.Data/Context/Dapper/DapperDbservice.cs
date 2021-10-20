using _42finance.Data.Context.Dapper;
using Microsoft.Extensions.Configuration;

namespace _42finance.Data.Context.Dapper
{
    public class DapperDbService : DapperDbServiceBase
    {
        public DapperDbService(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
