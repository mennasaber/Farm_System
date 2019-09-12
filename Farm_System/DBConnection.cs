﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Farm_System
{
    class DBConnection
    {

            public MySqlConnection connection;
            private string server;
            private string database;
            private string uid;
            private string password;

            public DBConnection()
            {
                server = "localhost";
                database = "farm_system";
                uid = "root";
                password = "";
                string connectionString;
                connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

                connection = new MySqlConnection(connectionString);
            }
        
    }
}
