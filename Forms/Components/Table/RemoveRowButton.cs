using System;
using System.Windows.Forms;
using Bulofnaia.Forms.Controllers;

namespace Bulofnaia.Forms.Components.Table
{
    public sealed class RemoveRowButton : Button
    {
        private TableController _controller;
        public RemoveRowButton(TableController controller = null, String buttonText = @"✔")
        {
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = System.Drawing.Color.Transparent;
            Dock = DockStyle.Fill;
            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;
            Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Location = new System.Drawing.Point(8, 117);
            Name = "newRequestPageButton";
            Text = buttonText;
            UseVisualStyleBackColor = false;
            Click += CompleteRequestHandler;

            _controller = controller;
        }
        
        private void CompleteRequestHandler(object sender, EventArgs e)
        {
            TableLayoutPanel table = (TableLayoutPanel)((RemoveRowButton)sender).Parent;
            int rowNumber = table.GetRow((RemoveRowButton)sender);

            if (_controller == null) _controller = new TableController();
            
            _controller.OnDeleteHandler(table, rowNumber);
        }
    }
}