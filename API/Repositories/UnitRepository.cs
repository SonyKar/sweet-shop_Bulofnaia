using System;
using System.Collections;
using Bulofnaia.API.Entities;
using MySql.Data.MySqlClient;

namespace Bulofnaia.API.Repositories
{
    public class UnitRepository
    {
        public static void AddUnit(Unit unit)
        {
            DatabaseInitializer.RunQuery($"INSERT INTO unit (name) VALUES ('{unit.Name}')");
        }

        public static Unit GetByName(string name)
        {
            var query = $"SELECT un.id, un.name FROM unit AS un WHERE un.name = '{name}'";
            return GetByQuery(query);
        }
        
        public static Unit GetById(int id)
        {
            var query = $"SELECT un.id, un.name FROM unit AS un WHERE un.id = {id}";
            return GetByQuery(query);
        }

        private static Unit GetByQuery(string query)
        {
            MySqlConnection connection = DatabaseInitializer.OpenConnection();
            var cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            Unit result = null;
            while (reader.Read())
            {
                result = new Unit();
                result.Id = (int)reader["id"];
                result.Name = (string)reader["name"];
                connection.Close();
                // return result;
                break;
            }

            DatabaseInitializer.CloseConnection();
            return result;
        }

        public static ArrayList GetAllUnits()
        {
            string query = "SELECT un.id, un.name FROM unit AS un";
            MySqlConnection connection = DatabaseInitializer.OpenConnection();
            var cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            ArrayList results = new ArrayList();
            while (reader.Read())
            {
                var result = new Unit();
                result.Id = (int)reader["id"];
                result.Name = (string)reader["name"];
                results.Add(result);
            }
            
            DatabaseInitializer.CloseConnection();
            return results;
        }

        public static void AddUnitSafe(Unit unit)
        {
            try
            {
                AddUnit(unit);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}