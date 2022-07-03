using System.Windows.Forms;

namespace Bulofnaia.Forms.Controllers
{
    public class TableController
    {
        public virtual void OnDeleteHandler(TableLayoutPanel table, int rowNumber)
        {
            DisposeRow(table, rowNumber);
        }
        public void ClearTable(TableLayoutPanel table, bool saveFirst = true)
        {
            int minimumCount = saveFirst ? table.ColumnCount : 0;
            while (table.Controls.Count > minimumCount)
            {
                int index = table.Controls.Count - 1;
                table.Controls[index].Dispose();
            }

            table.RowCount = saveFirst ? 1 : 0;
        }

        private void DisposeRow(TableLayoutPanel table, int rowNumber)
        {
            table.SuspendLayout();

            if (rowNumber >= table.RowCount)
            {
                return;
            }

            // delete all controls of row that we want to delete
            for (int i = 0; i < table.ColumnCount; i++)
            {
                var control = table.GetControlFromPosition(i, rowNumber);
                table.Controls.Remove(control);
            }

            // move up row controls that comes after row we want to remove
            for (int i = rowNumber + 1; i < table.RowCount; i++)
            {
                for (int j = 0; j < table.ColumnCount; j++)
                {
                    var control = table.GetControlFromPosition(j, i);
                    if (control != null)
                    {
                        table.SetRow(control, i - 1);
                    }
                }
            }

            var removeStyle = table.RowCount - 1;

            if (table.RowStyles.Count > removeStyle)
                table.RowStyles.RemoveAt(removeStyle);

            table.RowCount--;

            table.ResumeLayout();
        }
    }
}