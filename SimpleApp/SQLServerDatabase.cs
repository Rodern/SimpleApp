using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace SimpleApp
{
    class SQLServerDatabase : DBInterface
    {
        private SqlConnection _Connection = null;
        private SqlCommand _Command = null;
        public IDbConnection Connection
        {
            get
            {
                if (_Connection == null)
                {
                    string ConnectionString = "Data Source=ALAIN-PC;" + "Initial Catalog=TestDB;" + "Integrated Security=True";
                    _Connection = new SqlConnection(ConnectionString);
                }
                return _Connection;
            }
        }
        public IDbCommand Command
        {
            get
            {
                if (_Command == null)
                {
                    _Command = new SqlCommand
                    {
                        Connection = (SqlConnection)Connection
                    };
                }
                return _Command;
            }
        }
    }
}
