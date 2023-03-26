using System;
using System.Data.Common;
using Bulofnaia.API.Entities;
using Bulofnaia.API.Repositories;
using Bulofnaia.API.Services;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Bulofnaia.API
{
    public static class DatabaseInitializer
    {
        private static string serverName = "localhost";
        private static string databaseName = "bulofnaia";
        private static string connectionName = "bulofca";
        private static string connectionPassword = "spovidlom";

        private static MySqlConnection _connection = null;
        
        public static void Init()
        {
            _connection = OpenConnection();
            CreateNecessaryTables();

            PopulateNecessaryTables();
            // DatabaseTest.Test();
        }

        private static void PopulateNecessaryTables()
        {
            UnitRepository.AddUnitSafe(new Unit("шт."));
            UnitRepository.AddUnitSafe(new Unit("г."));
            UnitRepository.AddUnitSafe(new Unit("кг."));
            UnitRepository.AddUnitSafe(new Unit("т."));
            UnitRepository.AddUnitSafe(new Unit("мл."));
            UnitRepository.AddUnitSafe(new Unit("л."));
            UnitRepository.AddUnitSafe(new Unit("кв.м"));
            UnitRepository.AddUnitSafe(new Unit("куб.м"));

            UserRepository.InsertUser(new User("Иван", "Иванов", "заведующий складом", "ivan", "password"));
            UserRepository.InsertUser(new User("Александр", "Маслов", "кладовщик", "alex", "password"));
            UserRepository.InsertUser(new User("Пётр", "Васильев", "грузчик", "petr", "password"));
            UserRepository.InsertUser(new User("Владислав", "Цепеш", "фасовщик-упаковщик", "vlad", "password"));
        }

        public static MySqlConnection OpenConnection()
        {
            if (_connection == null)
            {
                NonNullOrEmptyRequired(databaseName, "Database name is required");
                NonNullOrEmptyRequired(serverName, "Server name is required");
                NonNullOrEmptyRequired(connectionName, "Connection name is required");
                //NonNullOrEmptyRequired(connectionPassword, "Connection password is required");

                string connstring = string.Format("Server={0}; database={1}; UID={2}; password={3}", serverName, databaseName, connectionName, connectionPassword);
                _connection = new MySqlConnection(connstring);
                _connection.Open();
            }
            
            return _connection;
        }

        public static void CloseConnection()
        {
            try
            {
                _connection.Close();
            }
            finally
            {
                _connection = null;
            }
        }

        private static void NonNullOrEmptyRequired(string arg, string message)
        {
            if (String.IsNullOrEmpty(arg))
                throw new ArgumentException(message);
        }

        private static void CreateNecessaryTables()
        {
            string query;

            query = GetUnitQuery();
            RunQuery(query);
            
            query = GetResourceTableQuery();
            RunQuery(query);

            query = GetRequestQuery();
            RunQuery(query);

            query = GetRequestResourceQuery();
            RunQuery(query);

            query = GetUserQuery();
            RunQuery(query);
        }

        public static void RunQuery(string query)
        {
            MySqlConnection connection = OpenConnection();
            
            Console.WriteLine("Running query: " + query);
            var cmd = new MySqlCommand(query, OpenConnection());
            var reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                string someStringFromColumnZero = reader.GetString(0);
                string someStringFromColumnOne = reader.GetString(1);
                Console.WriteLine(someStringFromColumnZero + "," + someStringFromColumnOne);
            }

            CloseConnection();
        }

        private static string GetRequestResourceQuery()
        {
            string query = "CREATE TABLE IF NOT EXISTS Request_resource" +
                           "(" +
                           "id INT(8) PRIMARY KEY AUTO_INCREMENT," +
                           "request_id INT(8) NOT NULL," +
                           "resource_id INT(8) NOT NULL," +
                           "quantity FLOAT(8) NOT NULL," +
                           "CONSTRAINT foreign_request_id FOREIGN KEY (request_id) REFERENCES request(id)," +
                           "CONSTRAINT foreign_resource_id FOREIGN KEY (resource_id) REFERENCES resource(id)," +
                           "CONSTRAINT unique_request_resource_pair UNIQUE (request_id, resource_id)" +
                           ")";
            
            return query;
        }

        private static string GetRequestQuery()
        {
            string query = "CREATE TABLE IF NOT EXISTS Request" +
                           "(" +
                           "id INT(8) PRIMARY KEY AUTO_INCREMENT," +
                           "name VARCHAR(255) NOT NULL," +
                           "limit_date DATETIME NOT NULL" +
                           ")";

            return query;
        }

        private static string GetUnitQuery()
        {
            string query = "CREATE TABLE IF NOT EXISTS Unit" +
                           "(" +
                           "id INT(8) PRIMARY KEY AUTO_INCREMENT," +
                           "name VARCHAR(255) NOT NULL," +
                           "CONSTRAINT unique_names UNIQUE(name)" +
                           ")";

            return query;
        }

        private static string GetResourceTableQuery()
        {
            string query = "CREATE TABLE IF NOT EXISTS Resource" +
                           "(" +
                           "id INT(8) PRIMARY KEY AUTO_INCREMENT," +
                           "name VARCHAR(255) NOT NULL," +
                           "batch_cost FLOAT(8) NOT NULL," +
                           "storage_cost FLOAT(8) NOT NULL," +
                           "unit INT(8) NOT NULL," +
                           "CONSTRAINT unique_names UNIQUE(name)," +
                           "CONSTRAINT foreign_key FOREIGN KEY (unit) REFERENCES unit(id)" +
                           ")";

            return query;
        }

        private static string GetUserQuery()
        {
            string query = "CREATE TABLE IF NOT EXISTS User" +
                           "(" +
                           "id INT(8) PRIMARY KEY AUTO_INCREMENT," +
                           "first_name VARCHAR(255) NOT NULL," +
                           "last_name VARCHAR(255) NOT NULL," +
                           "position VARCHAR(255) NOT NULL" +
                           "username VARCHAR(255) NOT NULL" +
                           "password VARCHAR(255) NOT NULL" +
                           ")";
            
            return query;

        }
        
    }
}