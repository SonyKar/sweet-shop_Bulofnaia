using System.Collections;
using System.Windows.Forms;
using Bulofnaia.API.Entities;
using Bulofnaia.API.Services;
using Bulofnaia.Forms.Components.Table;
using Bulofnaia.Forms.Entity;

namespace Bulofnaia.Forms.Controllers
{
    public class UnmetResourcesController : TableController
    {
        public void Load(TableLayoutPanel layout)
        {
            Hashtable unmetResources = ResourceService.SelectAllUnmetResourceRequirements();

            layout.SuspendLayout();
            ClearTable(layout);
            
            foreach (Resource data in unmetResources.Values)
            {
                int lastRowNumber = layout.RowCount;

                layout.Controls.Add(new TableInput(data.Name), 0, lastRowNumber);
                layout.Controls.Add(new TableInput(data.Quantity + " " + data.UnitName), 1, lastRowNumber);
                layout.RowCount++;
            }
            layout.ResumeLayout();
        }
    }
}