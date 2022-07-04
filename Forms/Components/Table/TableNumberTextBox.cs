using System.Windows.Forms;

namespace Bulofnaia.Forms.Components.Table
{
    public sealed class TableNumberTextBox : TextBox
    {
        public TableNumberTextBox()
        {
            Dock = DockStyle.Fill;
            Font = new System.Drawing.Font("Calibri", 12F);
            Margin = new Padding(10, 3, 10, 3);
        }
    }
}