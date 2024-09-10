using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace model.Data
{
    public class DapperMapper
    {
        private string _connectionString =
            "Server=PTDELL0069\\SQLEXPRESS;Database=dateEntry;Trusted_Connection=True;TrustServerCertificate=True";

        public IDbConnection dbConnection;

        public DapperMapper()
        {
            dbConnection = new SqlConnection(_connectionString);
        }

        public T SingleRow<T>(string Sql)
        {
            T result = this.dbConnection.QuerySingle<T>(Sql);
            return result;
        }

        public IEnumerable<T> MultiRow<T>(string Sql)
        {
            IEnumerable<T> result = this.dbConnection.Query<T>(Sql);
            return result;
        }

        public int ExecuteQuery(string sql)
        {
            int NumberOfRecordsAffected = dbConnection.Execute(sql);
            return NumberOfRecordsAffected;
        }
    }
}
