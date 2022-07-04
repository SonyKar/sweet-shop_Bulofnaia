using System;
using System.Collections;
using System.Windows.Forms;
using Bulofnaia.API.Entities;
using Bulofnaia.API.Repositories;
using Bulofnaia.API.Services;
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

        private void Load(TableLayoutPanel layout)
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

        private void AddResourceToTable(TableLayoutPanel layout, Resource resource)
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
            
            ArrayList units = UnitRepository.GetAllUnits();

            object[] unitsData = new object[units.Count];

            i = 0;
            foreach (Unit unit in units)
            {
                unitsData[i++] = new ComboBoxItem(unit.Name, unit.Id);
            }
            
            ClearTable(_parent.selectUnitPlace);
            _parent.selectUnitPlace.Controls.Add(new ResourceSelect(unitsData));
            
            Load(_parent.resourcesTable);
        }

        public void EditResourceNumber()
        {
            TextBox quantityTextBox = (TextBox)_parent.numberTextboxPlace.GetControlFromPosition(0, 0);
            int quantity = Convert.ToInt32(quantityTextBox.Text);
            
            int resourceId = ((ComboBox)_parent.selectResourcePlace.GetControlFromPosition(0, 0)).SelectedIndex;
        }

        public void CreateResource()
        {
            String resourceName = _parent.newResourceName.Text;
            _parent.newResourceName.Text = "Название";
            
            int unitId = ((ComboBox)_parent.selectUnitPlace.GetControlFromPosition(0, 0)).SelectedIndex;
        }

        public override void OnDeleteHandler(TableLayoutPanel table, int rowNumber)
        {
            int resourceId = Convert.ToInt32(table.GetControlFromPosition(0, rowNumber).Text);
            base.OnDeleteHandler(table, rowNumber);
        }
    }
}