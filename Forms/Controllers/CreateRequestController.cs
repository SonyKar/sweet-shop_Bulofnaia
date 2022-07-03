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
        private App parent;

        public CreateRequestController()
        {
        }

        public CreateRequestController(App parent)
        {
            this.parent = parent;
        }

        public void AddResourceControl(TableLayoutPanel layout)
        {
            int lastRowNumber = layout.RowCount;

            // read resources from db
            
            object[] dummyData = { 
                new ComboBoxItem("Ничего", 0),
                new ComboBoxItem("Молоко л", 1),
                new ComboBoxItem("Яйца шт", 2),
                new ComboBoxItem("Варенье л", 3)
            };
            
            layout.Controls.Add(new ResourceSelect(dummyData), 0, lastRowNumber);
            layout.Controls.Add(new TableNumberTextBox(), 1, lastRowNumber);
            layout.Controls.Add(new RemoveRowButton(null, "X"), 2, lastRowNumber);
            layout.RowCount++;
        }

        public void CreateRequest()
        {
            String requestName = parent.requestName.Text;
            parent.requestName.Text = "Название";
            DateTime requestDate = parent.requestDatePicker.Value;
            parent.requestDatePicker.Value = DateTime.Today;
            
            Hashtable resourceToQuantity = new Hashtable();
            for (int row = 0; row < parent.resourceSelect.RowCount; row++)
            {
                int resourceId = ((ComboBox)parent.resourceSelect.GetControlFromPosition(0, row)).SelectedIndex;
                String quantityText = parent.resourceSelect.GetControlFromPosition(1, row).Text;
                float quantity = 0;
                if (quantityText != "") quantity = float.Parse(quantityText);
                if (resourceId != 0 && quantity != 0) resourceToQuantity[resourceId] = quantity;
            }

            Request request = new Request() { Name = requestName, LimitDate = requestDate, ResourceToQuantity = resourceToQuantity };
            RequestService.AddRequest(request);
            
            ClearTable(parent.resourceSelect, false);
        }
    }
}