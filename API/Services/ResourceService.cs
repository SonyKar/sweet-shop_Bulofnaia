using System.Collections;
using Bulofnaia.API.Entities;
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
    }
}