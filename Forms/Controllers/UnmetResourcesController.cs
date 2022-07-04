using System.Windows.Forms;
using Bulofnaia.API.Entities;
using Bulofnaia.Forms.Components.Table;

namespace Bulofnaia.Forms.Controllers
{
    public class UnmetResourcesController : TableController
    {
        public void Load(TableLayoutPanel layout)
        {
            // read from db
            Resource[] dummyData =
            {
                new Resource()
            };
            
            layout.SuspendLayout();
            ClearTable(layout);
            
            foreach (Resource data in dummyData)
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