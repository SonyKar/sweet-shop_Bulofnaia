using System;
using Bulofnaia.API.Entities;
using Bulofnaia.API.Repositories;
using Bulofnaia.API.Services;

namespace Bulofnaia.API
{
    public class DatabaseTest
    {
        public static void Test()
        {
            foreach (Unit request in UnitRepository.GetAllUnits())
            {
                Console.WriteLine(request);
            }

            PopulateUnits();
            // PopulateResources();
            // PopulateRequests();
            // PopulateRequestResources();
            
            // ResourceService.DeleteResourceById(0);
            // ResourceService.DeleteResourceById(1);
            // ResourceService.DeleteResourceById(2);
            // ResourceService.DeleteResourceById(3);
            // ResourceService.DeleteResourceById(4);
            /*RequestService.SelectAllRequestsWithResourceAvailabilitySortByDate();
            for (int i = 0; i < 50; i++)
            {
                RequestService.MarkRequestAsAccomplishedById(i);
            }*/
        }
        
        private static void PopulateRequestResources()
        {
            RequestResourceRepository.InsertResourceRequestSafe(1,1,200);
            RequestResourceRepository.InsertResourceRequestSafe(2,1,200);
            RequestResourceRepository.InsertResourceRequestSafe(3,1,200);
            RequestResourceRepository.InsertResourceRequestSafe(3,2,200);
            RequestResourceRepository.InsertResourceRequestSafe(3,3,200);
            RequestResourceRepository.InsertResourceRequestSafe(4,1,200);
            RequestResourceRepository.InsertResourceRequestSafe(5,1,200);
            RequestResourceRepository.InsertResourceRequestSafe(11,1,200);
        }

        private static void PopulateRequests()
        {
            // for (int i = 0; i <= 10; i++)
            // {
            //     RequestRepository.AddRequest(new Request(i.ToString(), DateTime.Now));
            // }

            for (int i = 0; i < 50; i++)
            {
                Request req1 = new Request("Bulofca prikolnaia", DateTime.Now);
                req1.ResourceToQuantity.Add(2, 1000.00f);
                req1.ResourceToQuantity.Add(1, 5.0f);
                req1.ResourceToQuantity.Add(3, 3.0f);
                RequestService.AddRequest(req1);
                RequestService.RemoveRequestById(1);
            }
        }

        private static void PopulateUnits()
        {
            UnitRepository.AddUnitSafe(new Unit("gram"));
            UnitRepository.AddUnitSafe(new Unit("liter"));
            UnitRepository.AddUnitSafe(new Unit("bottle"));
        }

        private static void PopulateResources()
        {
            ResourceRepository.InsertResource(new Resource()
            {
                Name = "Sugar",
                Unit = UnitRepository.GetByName("gram").Id,
                BatchCost = 100,
                StorageCost = 200,
            });
            
            ResourceRepository.InsertResource(new Resource()
            {
                Name = "Tea",
                Unit = UnitRepository.GetByName("gram").Id,
                BatchCost = 106,
                StorageCost = 500,
            });
            
            ResourceRepository.InsertResource(new Resource()
            {
                Name = "Vodka",
                Unit = UnitRepository.GetByName("gram").Id,
                BatchCost = 100,
                StorageCost = 2,
            });
            
            ResourceRepository.InsertResource(new Resource()
            {
                Name = "Bulka",
                Unit = UnitRepository.GetByName("gram").Id,
                BatchCost = 1,
                StorageCost = 500,
            });
        }
    }
}