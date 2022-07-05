using System.Windows.Forms;

namespace Bulofnaia.Forms.Components.Table
{
    public sealed class QueueResources : TableLayoutPanel
    {
        public QueueResources()
        {
            Dock = DockStyle.Fill;
            ColumnCount = 1;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
    }
}