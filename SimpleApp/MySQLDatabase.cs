using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApp
{
    class MySQLDatabase: DBInterface
    {
        private MySqlConnection _Connection = null;
        private MySqlCommand _Command = null;
        public IDbConnection Connection
        {
            get
            {
                if (_Connection == null)
                {
                    string ConnectionString = "SERVER=localhost; DATABASE=testdb; UID=root; PASSWORD=root";
                    _Connection = new MySqlConnection(ConnectionString);
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
                    _Command = new MySqlCommand
                    {
                        Connection = (MySqlConnection)Connection
                    };
                }
                return _Command;
            }
        }
    }
}
