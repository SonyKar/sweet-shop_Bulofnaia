using System;
using System.Collections;
using Bulofnaia.API.Entities;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Ocsp;

namespace Bulofnaia.API.Repositories
{
    public class RequestRepository
    {
        public static Request FindRequestById(int id)
        {
            string query = "SELECT req.id, req.name, req.limit_date FROM request AS req WHERE req.id = " + id;
            MySqlConnection connection = DatabaseInitializer.OpenConnection();
            var cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            Request result = null;
            while (reader.Read())
            {
                result = new Request();
                result.Id = (int)reader["id"];
                result.Name = (string)reader["name"];
                result.LimitDate = (DateTime)reader["limit_date"];
                break;
            }

            DatabaseInitializer.CloseConnection();
            return result;
        }

        public static void AddRequest(Request request)
        {
            string reqName = request.Name;
            DateTime reqDate = request.LimitDate;
            DatabaseInitializer.RunQuery($"INSERT INTO request (name, limit_date) VALUES ('{reqName}', '{request.DateMySQL}')");
        }

        public static void RemoveRequestById(int id)
        {
            string query = $"DELETE FROM request WHERE id = {id}";
            DatabaseInitializer.RunQuery(query);
        }

        public static ArrayList GetAllRequests()
        {
            string query = "SELECT req.id, req.name, req.limit_date FROM request AS req";
            MySqlConnection connection = DatabaseInitializer.OpenConnection();
            var cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            ArrayList results = new ArrayList();
            Request result = null;
            while (reader.Read())
            {
                result = new Request();
                result.Id = (int)reader["id"];
                result.Name = (string)reader["name"];
                result.LimitDate = (DateTime)reader["limit_date"];
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
                result = FindRequestById(id);
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
                AddRequest(request);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        public static void RemoveRequestByIdSafe(int id)
        {
            try
            {
                RemoveRequestById(id);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static ArrayList GetAllRequestsSafe()
        {
            ArrayList result = new ArrayList();
            try
            {
                result = GetAllRequests();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }

            return result;
        }
    }
}