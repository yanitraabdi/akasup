using System;
using System.Collections.Generic;
using System.Text;

namespace Pusaka.Services.DbContext
{
    public class ConnectionOption
    {
        /// <summary>
        /// connection string
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// database type
        /// </summary>
        public DatabaseType DatabaseType { get; set; } = DatabaseType.SqlServer;
    }

    public enum DatabaseType
    {
        SqlServer,
        MySQL,
        SQLite
    }
}
