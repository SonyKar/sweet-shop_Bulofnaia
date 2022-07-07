using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using Bulofnaia.API.Entities;
using Bulofnaia.API.Services;
using Bulofnaia.Forms.Components.Table;

namespace Bulofnaia.Forms.Controllers
{
    public class QueueController : TableController
    {
        public void Load(TableLayoutPanel queueTable)
        {
            Hashtable requests = RequestService.SelectAllRequestsWithResourcesToQuantitySortByDate();
            queueTable.SuspendLayout();
            ClearTable(queueTable);
            
            foreach (Request request in requests.Values)
            {
                int lastRowNumber = queueTable.RowCount;
                QueueResources queueResources = new QueueResources();
                
                foreach (DictionaryEntry resourceToQuantity in request.ResourceToQuantity)
                {
                    Resource resource = (Resource)resourceToQuantity.Key;
                    float quantity = (float)resourceToQuantity.Value;
                    queueResources.Controls.Add(new TableInput(resource.Name + " " + quantity + resource.UnitName));
                }
            
                // bool isPossible = data.UnmetRequirements.Count == 0;
                RemoveRowButton button = new RemoveRowButton(this);
                // if (!isPossible) button.Enabled = false;
                
                queueTable.Controls.Add(new TableInput(request.Id.ToString()), 0, lastRowNumber);
                queueTable.Controls.Add(new TableInput(request.Name), 1, lastRowNumber);
                queueTable.Controls.Add(queueResources, 2, lastRowNumber);
                queueTable.Controls.Add(new TableInput(request.LimitDate.ToShortDateString()), 3, lastRowNumber);
                queueTable.Controls.Add(button, 4, lastRowNumber);
                queueTable.RowCount++;
                
                // if (isPossible)
                // {
                //     Color color = Color.FromArgb(170,234,191);
                //     queueTable.GetControlFromPosition(0, lastRowNumber).BackColor = color;
                //     queueTable.GetControlFromPosition(1, lastRowNumber).BackColor = color;
                //     queueTable.GetControlFromPosition(2, lastRowNumber).BackColor = color;
                //     queueTable.GetControlFromPosition(3, lastRowNumber).BackColor = color;
                //     queueTable.GetControlFromPosition(4, lastRowNumber).BackColor = color;
                // }
                // else
                // {
                //     Color color = Color.FromArgb(235,189,185);
                //     queueTable.GetControlFromPosition(0, lastRowNumber).BackColor = color;
                //     queueTable.GetControlFromPosition(1, lastRowNumber).BackColor = color;
                //     queueTable.GetControlFromPosition(2, lastRowNumber).BackColor = color;
                //     queueTable.GetControlFromPosition(3, lastRowNumber).BackColor = color;
                //     queueTable.GetControlFromPosition(4, lastRowNumber).BackColor = color;
                // }
            }
            queueTable.ResumeLayout();
        }

        public override void OnDeleteHandler(TableLayoutPanel table, int rowNumber)
        {
            int requestId = Convert.ToInt32(table.GetControlFromPosition(0, rowNumber).Text);
            base.OnDeleteHandler(table, rowNumber);
            RequestService.MarkRequestAsAccomplishedById(requestId);
        }
    }
}