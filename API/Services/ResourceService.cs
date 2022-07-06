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
            string query = "SELECT resource.id AS id, resource.name AS name, unit.name AS unit_name FROM (resource INNER JOIN unit ON resource.unit = unit.id)";

            ArrayList result = new ArrayList();
            MySqlCommand command = new MySqlCommand(query, DatabaseInitializer.OpenConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new Resource()
                {
                    Id = (int)reader["id"],
                    Name = (string)reader["name"],
                    UnitName = (string)reader["unit_name"]
                });
            }

            DatabaseInitializer.CloseConnection();
            return result;
        }

        public static void DeleteResourceById(int id)
        {
            string query =
                $"SELECT request.id AS id FROM (resource INNER JOIN (request INNER JOIN request_resource ON request.id = request_resource.request_id) ON resource.id = request_resource.resource_id) WHERE resource.id = {id}";
            MySqlCommand command = new MySqlCommand(query, DatabaseInitializer.OpenConnection());
            MySqlDataReader reader = command.ExecuteReader();

            ArrayList requestIds = new ArrayList();
            while (reader.Read())
            {
                int requestId = (int)reader["id"];
                requestIds.Add(requestId);
            }
            
            DatabaseInitializer.CloseConnection();

            foreach (int requestId in requestIds)
            {
                RequestService.RemoveRequestById(requestId);
            }
            
            ResourceRepository.DeleteResourceById(id);
        }
    }
}