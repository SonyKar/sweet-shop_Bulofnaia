using System;
using System.Collections;
using Bulofnaia.API.Entities;
using MySql.Data.MySqlClient;

namespace Bulofnaia.API.Repositories
{
    public class ResourceRepository
    {
        public static void InsertResource(Resource resource)
        {
            if (resource.Name == null || resource.Name.Length > 255)
            {
                throw new Exception("Resource must have name and no longer than 255 characters");
            }

            
            DatabaseInitializer.RunQuery($"INSERT INTO resource (name, quantity, unit) VALUES ('{resource.Name}', '{resource.Quantity}', '{resource.Unit}')");
        }
        
        public static ArrayList SelectAllResources()
        {
            string query = "SELECT res.id, res.name, res.quantity, res.unit FROM resource AS res";
            MySqlConnection connection = DatabaseInitializer.OpenConnection();
            var cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            ArrayList results = new ArrayList();
            while (reader.Read())
            {
                var result = new Resource
                {
                    Id = (int)reader["id"],
                    Name = (string)reader["name"],
                    Unit = (int)reader["unit"],
                    Quantity = (float)reader["quantity"]
                };
                results.Add(result);
            }
            
            DatabaseInitializer.CloseConnection();
            return results;
        }

        public static Hashtable SelectAllResourcesIdToResourceTable()
        {
            Hashtable result = new Hashtable();
            ArrayList resources = SelectAllResources();
            foreach (Resource resource in resources)
            {
                result[resource.Id] = resource;
            }

            return result;
        }

        public static void UpdateQuantityById(int id, float quantity)
        {
            DatabaseInitializer.RunQuery($"UPDATE resource AS res SET quantity = {quantity} WHERE res.id = {id}");
        }

        public static void UpdateAddQuantityById(int id, float addedQuantity)
        {
            DatabaseInitializer.RunQuery($"UPDATE resource AS res SET res.quantity = res.quantity + {addedQuantity} WHERE res.id = {id}");
        }
        
        public static void UpdateSubstractQuantityById(int id, float substractedQuantity)
        {
            DatabaseInitializer.RunQuery($"UPDATE resource AS res SET res.quantity = res.quantity - {substractedQuantity} WHERE res.id = {id}");
        }

        public static void InsertResourceSafe(Resource resource)
        {
            try
            {
                InsertResource(resource);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}