using Pusaka.Library;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Pusaka.Services.DbContext
{
    public class ConnectionFactory
    {
        private readonly static Dictionary<DatabaseType, Type> dic = new Dictionary<DatabaseType, Type>
        {
            [DatabaseType.SqlServer] = typeof(SqlConnection)
        };

        private ConnectionOption _options;
        protected IDbConnection conn;

        public IDbConnection GetConnection()
        {
            conn.ConnectionString = Constants.ConnectionString;
            return conn;
        }
    }
}
