using System.Collections;
using Bulofnaia.API.Entities;
using Bulofnaia.API.Repositories;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace Bulofnaia.API.Services
{
    public static class ResourceService
    {
        public static ArrayList SelectResourcesWithUnitNames()
        {
            string query = "SELECT resource.id AS id, resource.name AS name, resource.quantity AS quantity, unit.name AS unit_name FROM (resource INNER JOIN unit ON resource.unit = unit.id)";

            ArrayList result = new ArrayList();
            MySqlCommand command = new MySqlCommand(query, DatabaseInitializer.OpenConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new Resource()
                {
                    Id = (int)reader["id"],
                    Name = (string)reader["name"],
                    Quantity = (float)reader["quantity"],
                    UnitName = (string)reader["unit_name"]
                });
            }

            DatabaseInitializer.CloseConnection();
            return result;
        }
        
        public static Hashtable SelectAllUnmetResourceRequirements()
        {
            Hashtable idToResourceTable = ResourceRepository.SelectAllResourcesIdToResourceTable();
            
            string query = "SELECT resource.id AS resource_id, resource.quantity, unit.name AS unit_name FROM (request_resource INNER JOIN (resource INNER JOIN unit ON unit.id = resource.unit ))";
            MySqlCommand command = new MySqlCommand(query, DatabaseInitializer.OpenConnection());
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int resourceId = (int)reader["resource_id"];
                float quantity = (float)reader["quantity"];
                string unitName = (string)reader["unit_name"];

                ((Resource)idToResourceTable[resourceId]).Quantity -= quantity;
                ((Resource)idToResourceTable[resourceId]).UnitName = unitName;
            }

            Hashtable results = new Hashtable();
            foreach (DictionaryEntry entry in idToResourceTable)
            {
                if (((Resource)entry.Value).Quantity < 0)
                {
                    results[entry.Key] = entry.Value;
                    ((Resource)results[entry.Key]).Quantity *= -1;
                }
            }
            return results;
        }
    }
}