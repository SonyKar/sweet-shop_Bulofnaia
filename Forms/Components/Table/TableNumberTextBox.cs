using System;
using System.Windows.Forms;

namespace Bulofnaia.Forms.Components.Table
{
    public sealed class TableNumberTextBox : TextBox
    {
        private bool isPlaceholder;
        public TableNumberTextBox()
        {
            TextNumberConfig();
            isPlaceholder = false;
        }
        
        public TableNumberTextBox(String placeholder)
        {
            TextNumberConfig();
            isPlaceholder = true;
            Text = placeholder;
            Click += TextNumber_Click;
        }

        private void TextNumberConfig()
        {
            Dock = DockStyle.Fill;
            Font = new System.Drawing.Font("Calibri", 12F);
            Margin = new Padding(10, 3, 10, 3);
        }
        
        private void TextNumber_Click(object sender, EventArgs e)
        {
            if (isPlaceholder) Text = "";
            isPlaceholder = false;
        }
    }
}