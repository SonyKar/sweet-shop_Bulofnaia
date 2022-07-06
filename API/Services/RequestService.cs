using System;
using System.Collections;
using Bulofnaia.API.Entities;
using Bulofnaia.API.Repositories;
using MySql.Data.MySqlClient;

namespace Bulofnaia.API.Services
{
    public static class RequestService
    {
        public static void AddRequest(Request request)
        {
            RequestRepository.InsertRequest(request);

            int requestId = -1;
            MySqlCommand command = new MySqlCommand("SELECT LAST_INSERT_ID()", DatabaseInitializer.OpenConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                requestId = Int32.Parse(reader.GetString(0));
            }
            DatabaseInitializer.CloseConnection();
            
            foreach (DictionaryEntry dictionaryEntry in request.ResourceToQuantity)
            {
                RequestResourceRepository.InsertResourceRequest(requestId, (int)dictionaryEntry.Key, (float)dictionaryEntry.Value);
            }
        }

        public static void RemoveRequestById(int id)
        {
            RequestResourceRepository.DeleteAllByRequestId(id);
            RequestRepository.DeleteRequestById(id);
        }

        public static void MarkRequestAsAccomplishedById(int id)
        {
            Request request = RequestRepository.SelectRequestById(id);
            if (request == null)
            {
                Console.Error.WriteLine($"Could not find request with id {id}");
                return;
            }

            RemoveRequestById(request.Id);
        }

        public static Hashtable SelectAllRequestsWithResourcesToQuantitySortByDate()
        {
            Hashtable idToResourceTable = ResourceRepository.SelectAllResourcesIdToResourceTable();
            
            string query = "SELECT " +
                           "request.id AS request_id, request.name AS request_name, request.limit_date, " +
                           "request_resource.quantity, " +
                           "resource.name AS resource_name, resource.id AS resource_id, resource.batch_cost AS batch_cost, resource.storage_cost AS storage_cost, " +
                           "unit.name AS unit_name, unit.id AS unit_id " +
                           "FROM " +
                           "(" +
                           "(request LEFT JOIN request_resource ON request.id = request_resource.request_id) " +
                           "INNER JOIN " +
                           "(resource INNER JOIN unit ON unit.id = resource.unit) " +
                           "ON resource.id = request_resource.resource_id" +
                           ") " +
                           "ORDER BY request.limit_date, request.id";
            MySqlCommand command = new MySqlCommand(query, DatabaseInitializer.OpenConnection());
            MySqlDataReader reader = command.ExecuteReader();

            Hashtable idToRequestMap = new Hashtable();

            while (reader.Read())
            {
                int requestId = (int)reader["request_id"];
                string requestName = (string)reader["request_name"];
                DateTime limitDate = (DateTime)reader["limit_date"];

                int resourceId = 0, unitId = 0;
                float quantity = 0, batchCost = 0, storageCost = 0;
                string resourceName = "", unitName = "";

                bool resourceExists = true;

                try
                {
                    resourceId = (int)reader["resource_id"];
                    quantity = (float)reader["quantity"];
                    batchCost = (float)reader["batch_cost"];
                    storageCost = (float)reader["storage_cost"];
                    resourceName = (string)reader["resource_name"];
                    unitName = (string)reader["unit_name"];
                    unitId = (int)reader["unit_id"];
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e.Message);
                    resourceExists = false;
                }

                Request request;
                if (idToRequestMap[requestId] == null)
                {
                    idToRequestMap[requestId] = new Request();
                    request = (Request)idToRequestMap[requestId];
                    request.Id = requestId;
                    request.Name = requestName;
                    request.LimitDate = limitDate;
                }
                
                if (!resourceExists)
                    continue;

                request = (Request)idToRequestMap[requestId];

                Resource resource = new Resource
                {
                    Id = resourceId,
                    Name = resourceName,
                    UnitName = unitName,
                    BatchCost = batchCost,
                    StorageCost = storageCost,
                    Unit = unitId,
                };

                int daysDifference = (limitDate - DateTime.Now).Days;
                int optimalBatchSize = (int)Math.Ceiling(
                    Math.Sqrt(2 * batchCost * quantity / ((daysDifference - 3) * storageCost))
                );
                int optimalBatchInterval = (int)Math.Floor(optimalBatchSize * (daysDifference - 3) / quantity);
                
                request.ResourceToQuantity[resource] = quantity;
                request.ResourceToOptimalBatchSize[resource] = optimalBatchSize;
                request.ResourceToOptimalBatchInterval[resource] = optimalBatchInterval;
                
            }
            
            DatabaseInitializer.CloseConnection();
            return idToRequestMap;
        }
    }
}