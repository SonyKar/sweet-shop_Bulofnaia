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

        public static void SelectAllRequestsWithResourceAvailabilitySortByDate()
        {
            Hashtable idToResource = ResourceRepository.SelectAllResourcesIdToResourceTable();
            ArrayList allRequests = RequestRepository.SelectAllRequests();

            foreach (Request request in allRequests)
            {
                Hashtable requirements = RequestResourceRepository.SelectAllResurcesIdToQuantityTableByRequestId(request.Id);

                foreach (DictionaryEntry entry in requirements)
                {
                    int resourceId = (int)entry.Key;
                    float quantity = (float)entry.Value;
                    
                    Resource resource = (Resource)idToResource[resourceId]; 
                    
                    resource.Quantity -= quantity;
                    
                    if (resource.Quantity < 0)
                        request.UnmetRequirements[resourceId] = -resource.Quantity;
                }
                
                Console.WriteLine(request);
            }
        }
    }
}