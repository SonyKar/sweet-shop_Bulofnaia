using System;
using System.Collections;
using System.Windows.Forms;
using Bulofnaia.API.Entities;
using Bulofnaia.API.Services;
using Bulofnaia.Forms.Components.Table;
using Bulofnaia.Forms.Entity;

namespace Bulofnaia.Forms.Controllers
{
    public class CreateRequestController : TableController
    {
        private readonly App _parent;

        public CreateRequestController()
        {
        }

        public CreateRequestController(App parent)
        {
            _parent = parent;
        }

        public void AddResourceControl(TableLayoutPanel layout)
        {
            int lastRowNumber = layout.RowCount;
            
            ArrayList resources = ResourceService.SelectResourcesWithUnitNames();

            object[] data = new object[resources.Count + 1];

            int i = 1;
            data[0] = new ComboBoxItem("Ничего", 0);
            foreach (Resource resource in resources)
            {
                data[i++] = new ComboBoxItem(resource.Name + " " + resource.UnitName, resource.Id);
            }

            layout.Controls.Add(new ResourceSelect(data), 0, lastRowNumber);
            layout.Controls.Add(new TableNumberTextBox(), 1, lastRowNumber);
            layout.Controls.Add(new RemoveRowButton(null, "X"), 2, lastRowNumber);
            layout.RowCount++;
        }

        public void CreateRequest()
        {
            String requestName = _parent.requestName.Text;
            _parent.requestName.Text = "Название";
            DateTime requestDate = _parent.requestDatePicker.Value;
            _parent.requestDatePicker.Value = DateTime.Today;
            
            Hashtable resourceToQuantity = new Hashtable();
            for (int row = 0; row < _parent.resourceSelectLayout.RowCount; row++)
            {
                int resourceId = ((ComboBox)_parent.resourceSelectLayout.GetControlFromPosition(0, row)).SelectedIndex;
                String quantityText = _parent.resourceSelectLayout.GetControlFromPosition(1, row).Text;
                float quantity = 0;
                if (quantityText != "") quantity = float.Parse(quantityText);
                if (resourceId != 0 && quantity != 0) resourceToQuantity[resourceId] = quantity;
            }

            Request request = new Request() { Name = requestName, LimitDate = requestDate, ResourceToQuantity = resourceToQuantity };
            RequestService.AddRequest(request);
            
            ClearTable(_parent.resourceSelectLayout, false);
        }
    }
}