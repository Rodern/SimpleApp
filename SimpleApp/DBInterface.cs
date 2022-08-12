using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApp
{
    interface DBInterface
    {
        IDbConnection Connection { get; }
        IDbCommand Command { get; }
    }
}
