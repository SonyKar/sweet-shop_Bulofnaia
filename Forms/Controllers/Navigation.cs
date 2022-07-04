using System.Windows.Forms;

namespace Bulofnaia.Forms.Controllers
{
    public static class Navigation
    {
        private static Control _currentDisplayedContent;
        
        private static void ChangeCurrentContent(Control control, TableLayoutPanel container)
        {
            container.SuspendLayout();
            container.Controls.Remove(_currentDisplayedContent);
            container.Controls.Add(control, 1, 0);
            _currentDisplayedContent = control;
            container.ResumeLayout();
        }

        public static void NavigateNewRequest(Control control, TableLayoutPanel container)
        {
            ChangeCurrentContent(control, container);
        }
    }
}