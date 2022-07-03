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
            Hashtable resourceIdToQuantity = RequestResourceRepository.SelectAllResurcesIdToQuantityTableByRequestId(request.Id);
            foreach (DictionaryEntry entry in resourceIdToQuantity)
            {
                int resourceId = (int)entry.Key;
                float quantity = (float)entry.Value;
                ResourceRepository.UpdateSubstractQuantityById(resourceId, quantity);
            }
            RemoveRequestById(request.Id);
        }

        public static Hashtable SelectAllRequestsWithResourceAvailabilitySortByDate()
        {
            Hashtable idToResourceTable = ResourceRepository.SelectAllResourcesIdToResourceTable();
            
            string query = "SELECT request.id AS request_id, request.name AS request_name, request.limit_date, request_resource.quantity, resource.name AS resource_name, unit.name AS unit_name, resource.id AS resource_id FROM ((request_resource INNER JOIN request ON request.id = request_resource.request_id) INNER JOIN (resource INNER JOIN unit ON unit.id = resource.unit) ON resource.id = request_resource.resource_id) ORDER BY request.limit_date, request.id";
            MySqlCommand command = new MySqlCommand(query, DatabaseInitializer.OpenConnection());
            MySqlDataReader reader = command.ExecuteReader();

            Hashtable idToRequestMap = new Hashtable();

            while (reader.Read())
            {
                int requestId = (int)reader["request_id"];
                int resourceId = (int)reader["resource_id"];
                string requestName = (string)reader["request_name"];
                DateTime limitDate = (DateTime)reader["limit_date"];
                float quantity = (float)reader["quantity"];
                string resourceName = (string)reader["resource_name"];
                string unitName = (string)reader["unit_name"];

                Request request;
                if (idToRequestMap[requestId] == null)
                {
                    idToRequestMap[requestId] = new Request();
                    request = (Request)idToRequestMap[requestId];
                    request.Id = requestId;
                    request.Name = requestName;
                    request.LimitDate = limitDate;
                }

                request = (Request)idToRequestMap[requestId];
                request.Resources.Add(new Resource
                {
                    Name = resourceName,
                    Quantity = quantity,
                    UnitName = unitName
                });

                ((Resource)idToResourceTable[resourceId]).Quantity -= quantity;
                if (((Resource)idToResourceTable[resourceId]).Quantity < 0)
                {
                    request.UnmetRequirements.Add(resourceId, ((Resource)idToResourceTable[resourceId]).Quantity);
                }

            }
            
            DatabaseInitializer.CloseConnection();
            return idToRequestMap;
        }
    }
}