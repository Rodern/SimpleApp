using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApp
{
    public enum DatabaseType
    {
        SQLServer,
        MySQL
    }
    class DBFactory
    {
        public static DBInterface CreateDatabase(DatabaseType DbType)
        {
            return DbType switch
            {
                DatabaseType.MySQL => new MySQLDatabase(),
                DatabaseType.SQLServer => new SQLServerDatabase(),
                _ => new MySQLDatabase()
            };
        }
    }
}
