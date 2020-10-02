using Dapper;
using FromZeroToHero.SharedKernel.Interfaces;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace FromZeroToHero.Infrastructure.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private string _connectionString;

        public UnitOfWork(IConfigurationService configurationService)
        {
            _connectionString = configurationService.GetDatabaseConnectionString();
        }

        public List<T> GetMany<T>(string sql, params object[] parameters) where T : class
        {
            using (var db = GetDbConnection())
            {
                return db.Query<T>(sql, parameters).ToList();
            }
        }

        public T GetOne<T>(string sql, params object[] parameters) where T : class
        {
            using (var db = GetDbConnection())
            {
                return db.QueryFirstOrDefault<T>(sql, parameters);
            }
        }

        private IDbConnection GetDbConnection()
        {
            var db = new SqlConnection(_connectionString);
            db.Open();
            return db;
        }
    }
}
