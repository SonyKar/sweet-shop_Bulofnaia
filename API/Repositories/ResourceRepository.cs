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

            
            DatabaseInitializer.RunQuery($"INSERT INTO resource (name, unit, storage_cost, batch_cost) VALUES ('{resource.Name}', '{resource.Unit}', {resource.StorageCost}, {resource.BatchCost})");
        }
        
        public static ArrayList SelectAllResources()
        {
            string query = "SELECT res.id, res.name, res.unit, res.batch_cost, res.storage_cost FROM resource AS res";
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
                    BatchCost = (float)reader["batch_cost"],
                    StorageCost = (float)reader["storage_cost"],
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

        public static void DeleteResourceById(int id)
        {
            string query = $"DELETE FROM resource WHERE id = {id}";
            DatabaseInitializer.RunQuery(query);
        } 

        // public static void UpdateQuantityById(int id, float quantity)
        // {
        //     DatabaseInitializer.RunQuery($"UPDATE resource AS res SET quantity = {quantity} WHERE res.id = {id}");
        // }
        //
        // public static void UpdateAddQuantityById(int id, float addedQuantity)
        // {
        //     DatabaseInitializer.RunQuery($"UPDATE resource AS res SET res.quantity = res.quantity + {addedQuantity} WHERE res.id = {id}");
        // }
        //
        // public static void UpdateSubstractQuantityById(int id, float substractedQuantity)
        // {
        //     DatabaseInitializer.RunQuery($"UPDATE resource AS res SET res.quantity = res.quantity - {substractedQuantity} WHERE res.id = {id}");
        // }

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