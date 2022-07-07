using System.Collections;
using System.Windows.Forms;
using Bulofnaia.API.Entities;
using Bulofnaia.API.Services;
using Bulofnaia.Forms.Components.Table;

namespace Bulofnaia.Forms.Controllers
{
    public class OptimalRefillController : TableController
    {
        public void Load(TableLayoutPanel layout)
        {
            // read from db
            Hashtable optimalRefillData = RequestService.SelectAllRequestsWithResourcesToQuantitySortByDate();

            layout.SuspendLayout();
            ClearTable(layout);
            
            foreach (Request requestData in optimalRefillData.Values)
            {
                foreach (DictionaryEntry entry in requestData.ResourceToOptimalBatchInterval)
                {
                    Resource resource = (Resource)entry.Key;
                    
                    int lastRowNumber = layout.RowCount;

                    layout.Controls.Add(new TableInput(requestData.Id.ToString()), 0, lastRowNumber); // id request
                    layout.Controls.Add(new TableInput(resource.Id.ToString()), 1, lastRowNumber); // id resource
                    layout.Controls.Add(new TableInput(resource.Name), 2, lastRowNumber); // name resource
                    layout.Controls.Add(new TableInput(requestData.ResourceToOptimalBatchSize[resource] + " " + resource.UnitName), 3, lastRowNumber); // оптимальный объем партии
                    layout.Controls.Add(new TableInput(requestData.ResourceToOptimalBatchInterval[resource] + " "), 4, lastRowNumber); // оптимальный интервал
                    layout.RowCount++;
                }
                
            }
            layout.ResumeLayout();
        }
    }
}