using System;
using System.Windows.Forms;
using Bulofnaia.Forms.Components.Queue;

namespace Bulofnaia.Forms
{
    public static class LoadContent
    {
        private static String[][] dummyQueueData =
        {
            new string[] { "1", "asd" },
            new string[] { "2", "asd" }
        };
        
        public static void LoadQueue(TableLayoutPanel queueTable)
        {
            queueTable.SuspendLayout();
            while (queueTable.Controls.Count > 4)
            {
                int index = queueTable.Controls.Count - 1;
                queueTable.Controls[index].Dispose();
            }

            foreach (var data in dummyQueueData)
            {
                int lastRowNumber = queueTable.RowCount;
                queueTable.Controls.Add(new LabelInput(data[0]), 0, lastRowNumber);
                queueTable.Controls.Add(new LabelInput(data[1]), 1, lastRowNumber);
                queueTable.Controls.Add(new LabelInput(data[0]), 2, lastRowNumber);
                queueTable.Controls.Add(new LabelInput(data[0]), 3, lastRowNumber);
            }
            queueTable.ResumeLayout();
        }
    }
}