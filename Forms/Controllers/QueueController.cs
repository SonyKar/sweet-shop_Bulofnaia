using System;
using System.Collections;
using System.Windows.Forms;
using Bulofnaia.API.Entities;
using Bulofnaia.API.Services;
using Bulofnaia.Forms.Components.Queue;
using Bulofnaia.Forms.Components.Table;

namespace Bulofnaia.Forms.Controllers
{
    public class QueueController : TableController
    {
        public void Load(TableLayoutPanel queueTable)
        {
            ArrayList requests = RequestService.SelectAllRequestsWithResourceAvailabilitySortByDate();
            queueTable.SuspendLayout();
            ClearTable(queueTable);
            
            foreach (Request data in requests)
            {
                int lastRowNumber = queueTable.RowCount;
                QueueResources queueResources = new QueueResources();
                queueResources.Controls.Add(new TableInput("Молоко 1л"));
                queueResources.Controls.Add(new TableInput("Яйца 12шт"));
                queueResources.Controls.Add(new TableInput("Варенье 500г"));
                
                queueTable.Controls.Add(new TableInput(data.Id.ToString()), 0, lastRowNumber);
                queueTable.Controls.Add(new TableInput(data.Name), 1, lastRowNumber);
                queueTable.Controls.Add(queueResources, 2, lastRowNumber);
                queueTable.Controls.Add(new TableInput(data.LimitDate.ToShortDateString()), 3, lastRowNumber);
                queueTable.Controls.Add(new RemoveRowButton(this), 4, lastRowNumber);
                queueTable.RowCount++;
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