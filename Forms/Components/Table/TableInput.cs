using System;
using System.Windows.Forms;

namespace Bulofnaia.Forms.Components.Table
{
    public sealed class TableInput : Label
    {
        public TableInput(String text)
        {
            Dock = DockStyle.Fill;
            Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Text = text;
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }
    }
}