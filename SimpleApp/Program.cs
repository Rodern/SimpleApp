using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace SimpleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DBInterface Database = DBFactory.CreateDatabase(DatabaseType.MySQL);
            IDbCommand Command = Database.Command;
            //IDbCommand command = Database.Command;
            /*string testString = null;
            Console.WriteLine("The specified string is - " + (testString ?? "not provided"));
            int? a = null;
            int b = 3;
            var output = a ?? b;
            Console.WriteLine($"Hello World!{b.GetType()}");*/

            //Command.CommandText = "INSERT INTO names VALUES (2, 'Kimbu')";
            //Command.CommandText = "insert into names(names) value('Kimbu');";
            //Command.CommandType = CommandType.Text;
            //Command.Connection.Open();

            //IDataReader reader = Command.ExecuteReader();
            //reader.Read();
            //reader.Close();


            //Command.Connection.Close();

            names names = new names();

            Command.CommandText = "select * from names";
            Command.CommandType = CommandType.Text;
            Command.Connection.Open();

            var read_data = Command.ExecuteReader();
                read_data.Read();
            names.id = 1;// read_data.GetInt32(0);
                names.name = read_data.GetString(0);
            Console.WriteLine($"ID: {names.id}, Name: {names.name}");
        }
    }
    class names
    {
        public int id;
        public string name;
    }
}

