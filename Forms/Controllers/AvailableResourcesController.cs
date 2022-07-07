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
            layout.Controls.Add(new TableInput(resource.Name + ", " + resource.UnitName), 1, lastRowNumber);
            layout.Controls.Add(new TableInput(resource.StorageCost + ""), 2, lastRowNumber); // storage price
            layout.Controls.Add(new TableInput(resource.BatchCost + ""), 3, lastRowNumber); // expenses
            layout.Controls.Add(new RemoveRowButton(this, "X"), 4, lastRowNumber);
            layout.RowCount++;
        }

        public void InitializeComponents()
        {
            _parent.availableResourceLayout.SuspendLayout();
            ClearTable(_parent.selectResourcePlace, false);

            object[] data;
            ArrayList resources = ResourceService.SelectResourcesWithUnitNames();
            bool emptyResources = resources.Count == 0;
            
            data = new object[emptyResources? 1 : resources.Count];

            if (emptyResources)
                data[0] = new ComboBoxItem("No elements", 0);
            else
            {
                int i = 0;
                foreach (Resource resource in resources)
                {
                    data[i++] = new ComboBoxItem(resource.Name + " " + resource.UnitName, resource.Id);
                }
            }
            
            _parent.selectResourcePlace.Controls.Add(new ResourceSelect(data));
            
            ClearTable(_parent.addStoragePricePlace, false);
            _parent.addStoragePricePlace.Controls.Add(new TableNumberTextBox("Цена за хранение"));
            
            ClearTable(_parent.addExpensesPlace, false);
            _parent.addExpensesPlace.Controls.Add(new TableNumberTextBox("Затраты"));
            
            ClearTable(_parent.editStoragePricePlace, false);
            _parent.editStoragePricePlace.Controls.Add(new TableNumberTextBox("Цена за хранение"));
            
            ClearTable(_parent.editExpensesPlace, false);
            _parent.editExpensesPlace.Controls.Add(new TableNumberTextBox("Затраты"));

            object[] unitsData;
            ArrayList units = UnitRepository.GetAllUnits();
            bool unitsEmpty = units.Count == 0;
            unitsData = new object[unitsEmpty ? 1 : units.Count];

            if (unitsEmpty)
            {
                unitsData[0] = new ComboBoxItem("No elements", 0);
            }
            else
            {
                int i = 0;
                foreach (Unit unit in units)
                {
                    unitsData[i++] = new ComboBoxItem(unit.Name, unit.Id);
                }
            }

            ClearTable(_parent.selectUnitPlace, false);
            _parent.selectUnitPlace.Controls.Add(new ResourceSelect(unitsData));
            
            Load(_parent.resourcesTable);
            _parent.availableResourceLayout.ResumeLayout();
        }

        public void EditResourceNumber()
        {
            TextBox storagePriceTextBox = (TextBox)_parent.editStoragePricePlace.GetControlFromPosition(0, 0);
            float storagePrice = float.Parse(storagePriceTextBox.Text);
            storagePriceTextBox.Dispose();
            
            TextBox expensesTextBox = (TextBox)_parent.editExpensesPlace.GetControlFromPosition(0, 0);
            float expenses = float.Parse(expensesTextBox.Text);
            expensesTextBox.Dispose();

            int resourceId = (int)((ComboBoxItem)((ComboBox)_parent.selectResourcePlace.GetControlFromPosition(0, 0)).SelectedItem).Value;

            // update in DB
            ResourceRepository.UpdateResourceBatchCostAndStorageCostById(resourceId, expenses, storagePrice);
        }

        public void CreateResource()
        {
            String resourceName = _parent.newResourceName.Text;
            _parent.newResourceName.Text = "Название";
            
            int unitId = ((ComboBox)_parent.selectUnitPlace.GetControlFromPosition(0, 0)).SelectedIndex + 1;

            float storagePrice = 0, expenses = 0;
            bool storageError = false, expensesError = false, error = false;
            
            try
            {
                TextBox storagePriceTextBox = (TextBox)_parent.addStoragePricePlace.GetControlFromPosition(0, 0);
                storagePrice = float.Parse(storagePriceTextBox.Text);
                storagePriceTextBox.Dispose();
            }
            catch (Exception e)
            {
                storageError = true;
                error = true;
            }

            try
            {
                TextBox expensesTextBox = (TextBox)_parent.addExpensesPlace.GetControlFromPosition(0, 0);
                expenses = float.Parse(expensesTextBox.Text);
                expensesTextBox.Dispose();
            }
            catch (Exception e)
            {
                expensesError = true;
                error = true;
            }

            if (error)
            {
                string text = "Неверно указана";
                if (storageError)
                    text += " цена хранения ";
                if (storageError && expensesError)
                    text += " и";
                if (expensesError)
                    text += " цена доставки";
                text += ".";

                MessageBox.Show(text, "Ошибка", MessageBoxButtons.OK);
                return;
            }
                
            
            // Add to DB
            try
            {
                ResourceRepository.InsertResource(new Resource()
                {
                    Name = resourceName,
                    Unit = unitId,
                    BatchCost = expenses,
                    StorageCost = storagePrice,
                });
            }
            catch (Exception e)
            {
                Console.Error.Write(e.Message);
                MessageBox.Show("Невозможно добавить. Возможно, ресурс уже существует.", "Ошибка", MessageBoxButtons.OK);
            }
            
        }

        public override void OnDeleteHandler(TableLayoutPanel table, int rowNumber)
        {
            int resourceId = Convert.ToInt32(table.GetControlFromPosition(0, rowNumber).Text);
            base.OnDeleteHandler(table, rowNumber);
            
            // Delete resource from DB
            ResourceService.DeleteResourceById(resourceId);
        }
    }
}