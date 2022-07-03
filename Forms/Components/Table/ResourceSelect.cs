using System;
using System.Windows.Forms;
using Bulofnaia.Forms.Controllers;

namespace Bulofnaia.Forms.Components.Table
{
    public sealed class ResourceSelect : ComboBox
    {
        public ResourceSelect(object[] data)
        {
            Dock = DockStyle.Fill;
            DropDownStyle = ComboBoxStyle.DropDownList;
            Font = new System.Drawing.Font("Calibri", 12F);
            Items.AddRange(data);
            Margin = new Padding(10, 3, 10, 3);
            SelectedIndex = 0;
            SelectedIndexChanged += ResourceSelectionChangeHandler;
        }
        
        private void ResourceSelectionChangeHandler(object sender, EventArgs e)
        {
            CreateRequestController controller = new CreateRequestController();
            TableLayoutPanel parent = (TableLayoutPanel)((ResourceSelect)sender).Parent;
            if (SelectedIndex == 0 && parent.RowCount > 1)
            {
                controller.OnDeleteHandler(parent, parent.GetRow((ResourceSelect)sender));
            }
        }
    }
}