using System;
using System.Windows.Forms;

namespace Bulofnaia.Forms.Components.Queue
{
    public sealed class LabelInput : Label
    {
        public LabelInput(String text)
        {
            Dock = DockStyle.Fill;
            Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Text = text;
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }
    }
}