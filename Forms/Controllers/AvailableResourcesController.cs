using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using Bulofnaia.API.Entities;
using Bulofnaia.API.Services;
using Bulofnaia.Forms.Components.Queue;
using Bulofnaia.Forms.Components.Table;
using Bulofnaia.Forms.Entity;

namespace Bulofnaia.Forms.Controllers
{
    public class AvailableResourcesController : TableController
    {
        private readonly App _parent;

        public AvailableResourcesController(App parent)
        {
            _parent = parent;
        }

        public void Load(TableLayoutPanel layout)
        {
            // read from db
            ArrayList resources = ResourceService.SelectResourcesWithUnitNames();
            
            layout.SuspendLayout();
            ClearTable(layout);
            
            foreach (Resource data in resources)
            {
                AddResourceToTable(layout, data);
            }
            layout.ResumeLayout();
        }

        public void AddResourceToTable(TableLayoutPanel layout, Resource resource)
        {
            int lastRowNumber = layout.RowCount;

            layout.Controls.Add(new TableInput(resource.Id.ToString()), 0, lastRowNumber);
            layout.Controls.Add(new TableInput(resource.Name), 1, lastRowNumber);
            layout.Controls.Add(new TableInput(resource.Quantity + " " + resource.UnitName), 2, lastRowNumber);
            layout.Controls.Add(new RemoveRowButton(this, "X"), 3, lastRowNumber);
            layout.RowCount++;
        }

        public void InitializeComponents()
        {
            ClearTable(_parent.selectResourcePlace);
            
            ArrayList resources = ResourceService.SelectResourcesWithUnitNames();

            object[] data = new object[resources.Count];

            int i = 0;
            foreach (Resource resource in resources)
            {
                data[i++] = new ComboBoxItem(resource.Name + " " + resource.UnitName, resource.Id);
            }
            
            _parent.selectResourcePlace.Controls.Add(new ResourceSelect(data));
            
            ClearTable(_parent.numberTextboxPlace);
            _parent.numberTextboxPlace.Controls.Add(new TableNumberTextBox());
            
            Load(_parent.resourcesTable);
        }
    }
}