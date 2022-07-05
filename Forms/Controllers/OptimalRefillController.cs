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
            Hashtable optimalRefillData = ResourceService.SelectAllUnmetResourceRequirements();

            layout.SuspendLayout();
            ClearTable(layout);
            
            foreach (Resource data in optimalRefillData.Values)
            {
                int lastRowNumber = layout.RowCount;

                layout.Controls.Add(new TableInput(data.Id.ToString()), 0, lastRowNumber); // id request
                layout.Controls.Add(new TableInput(data.Id.ToString()), 1, lastRowNumber); // id resource
                layout.Controls.Add(new TableInput(data.Name), 2, lastRowNumber); // name resource
                layout.Controls.Add(new TableInput(data.Quantity + " " + data.UnitName), 3, lastRowNumber); // оптимальный объем партии
                layout.Controls.Add(new TableInput(data.Quantity + " " + data.UnitName), 4, lastRowNumber); // оптимальный интервал
                layout.RowCount++;
            }
            layout.ResumeLayout();
        }
    }
}