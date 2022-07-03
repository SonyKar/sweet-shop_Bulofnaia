using System;
using System.Collections;
using Bulofnaia.API.Entities;
using MySql.Data.MySqlClient;

namespace Bulofnaia.API.Repositories
{
    public static class RequestRepository
    {
        public static Request SelectRequestById(int id)
        {
            var query = $"SELECT req.id, req.name, req.limit_date FROM request AS req WHERE req.id = {id}";
            var connection = DatabaseInitializer.OpenConnection();
            var cmd = new MySqlCommand(query, connection);

            var reader = cmd.ExecuteReader();

            Request result = null;
            while (reader.Read())
            {
                result = new Request
                {
                    Id = (int)reader["id"],
                    Name = (string)reader["name"],
                    LimitDate = (DateTime)reader["limit_date"]
                };
                break;
            }

            DatabaseInitializer.CloseConnection();
            return result;
        }

        public static void InsertRequest(Request request)
        {
            if (request.Name == null || request.Name.Length > 255)
            {
                throw new Exception(
                    "Name should be specified and no longer than 255 characters. Date must me specified");
            }

            DatabaseInitializer.RunQuery($"INSERT INTO request (name, limit_date) VALUES ('{request.Name}', '{request.DateMySQL}')");
        }

        public static void DeleteRequestById(int id)
        {
            string query = $"DELETE FROM request WHERE id = {id}";
            DatabaseInitializer.RunQuery(query);
        }

        public static ArrayList SelectAllRequests()
        {
            string query = "SELECT req.id, req.name, req.limit_date FROM request AS req ORDER BY req.limit_date";
            MySqlConnection connection = DatabaseInitializer.OpenConnection();
            var cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            ArrayList results = new ArrayList();
            while (reader.Read())
            {
                var result = new Request
                {
                    Id = (int)reader["id"],
                    Name = (string)reader["name"],
                    LimitDate = (DateTime)reader["limit_date"]
                };
                results.Add(result);
            }
            
            DatabaseInitializer.CloseConnection();
            return results;
        }

        public static Request FindRequestByIdSafe(int id)
        {
            Request result = null;
            try
            {
                result = SelectRequestById(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return result;
        }

        public static void AddRequestSafe(Request request)
        {
            try
            {
                InsertRequest(request);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        public static void DeleteRequestByIdSafe(int id)
        {
            try
            {
                DeleteRequestById(id);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static ArrayList SelectAllRequestsSafe()
        {
            ArrayList result = new ArrayList();
            try
            {
                result = SelectAllRequests();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }

            return result;
        }
    }
}