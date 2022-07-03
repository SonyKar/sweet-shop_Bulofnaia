using System;
using System.Collections;
using MySql.Data.MySqlClient;

namespace Bulofnaia.API.Repositories
{
    public static class RequestResourceRepository
    {
        public static Hashtable SelectAllResurcesIdToQuantityTableByRequestId(int id)
        {
            string query = $"SELECT reqres.resource_id, reqres.quantity FROM request_resource AS reqres WHERE reqres.request_id = {id}";
            MySqlCommand command = new MySqlCommand(query, DatabaseInitializer.OpenConnection());
            MySqlDataReader reader = command.ExecuteReader();

            Hashtable results = new Hashtable();
            while (reader.Read())
            {
                int resourceId = (int)reader["resource_id"];
                float quantity = (float)reader["quantity"];
                results[resourceId] = quantity;
            }

            DatabaseInitializer.CloseConnection();
            return results;
        }

        public static void InsertResourceRequest(int requestId, int resourceId, float quantity)
        {
            DatabaseInitializer.RunQuery($"INSERT INTO request_resource(request_id, resource_id, quantity) VALUES ({requestId},{resourceId},{quantity})");
        }

        public static void DeleteAllByRequestId(int requestId)
        {
            DatabaseInitializer.RunQuery($"DELETE FROM request_resource AS reqres WHERE reqres.request_id = {requestId}");
        }

        public static void InsertResourceRequestSafe(int requestId, int resourceId, float quantity)
        {
            try
            {
                InsertResourceRequest(requestId, resourceId, quantity);
            }
            catch (MySqlException e)
            {
                Console.Error.WriteLine(e.Message);
            }
        }
    }
}