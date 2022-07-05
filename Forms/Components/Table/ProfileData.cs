using System;
using System.Windows.Forms;

namespace Bulofnaia.Forms.Components.Table
{
    public sealed class ProfileData : TableLayoutPanel
    {
        public ProfileData(String id, String name, String position)
        {
            ColumnCount = 2;
            RowCount = 2;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));

            TableInput idInput = new TableInput(id);
            TableInput nameInput = new TableInput(name);
            TableInput positionInput = new TableInput(position);
            
            SetRowSpan(idInput, 2);
            Controls.Add(idInput, 0, 0);
            Controls.Add(nameInput, 1, 0);
            Controls.Add(positionInput, 1, 1);

            Margin = new Padding(0, 0, 0, 30);
        }
    }
}