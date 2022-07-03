using System.Windows.Forms;

namespace Bulofnaia.Forms.Components.Table
{
    public sealed class TableNumberTextBox : TextBox
    {
        public TableNumberTextBox()
        {
            Dock = System.Windows.Forms.DockStyle.Fill;
            Font = new System.Drawing.Font("Calibri", 12F);
            Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
        }
    }
}