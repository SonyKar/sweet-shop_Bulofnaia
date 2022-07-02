using System;
using System.Collections;
using Bulofnaia.API.Entities;
using MySql.Data.MySqlClient;

namespace Bulofnaia.API.Repositories
{
    public class ResourceRepository
    {
        public static void AddResource(Resource resource)
        {
            DatabaseInitializer.RunQuery($"INSERT INTO resource (name, quantity, unit) VALUES ('{resource.Name}', '{resource.Quantity}', '{resource.Unit}')");
        }
        
        public static ArrayList GetAllResources()
        {
            string query = "SELECT res.id, res.name, res.quantity, res.unit FROM resource AS res";
            MySqlConnection connection = DatabaseInitializer.OpenConnection();
            var cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            ArrayList results = new ArrayList();
            Resource result = null;
            while (reader.Read())
            {
                result = new Resource();
                result.Id = (int)reader["id"];
                result.Name = (string)reader["name"];
                result.Unit = (int)reader["unit"];
                result.Quantity = (float)reader["quantity"];
                results.Add(result);
            }
            
            DatabaseInitializer.CloseConnection();
            return results;
        }

        public static void AddResourceSafe(Resource resource)
        {
            try
            {
                AddResource(resource);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}