using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bulofnaia.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ResetButtonColors(Button selectedButton)
        {
            Button[] buttons = {newRequestPageButton, queuePageButton, availableResourcesPageButton, addResourcesPageButton};
            foreach (var button in buttons)
            {
                button.BackColor = Color.White;
                button.ForeColor = Color.Black;
            }
            selectedButton.BackColor = Color.FromArgb(255, 255,182,137);
            selectedButton.ForeColor = Color.White;
        }
        
        private void newRequestPageButton_Click(object sender, EventArgs e)
        {
            Navigation.NavigateNewRequest(createRequestLayout, appLayout);
            ResetButtonColors((Button)sender);
        }

        private void queuePageButton_Click(object sender, EventArgs e)
        {
            LoadContent.LoadQueue(queueTable);
            Navigation.NavigateNewRequest(queueLayout, appLayout);
            ResetButtonColors((Button)sender);
        }

        private void availableResourcesPageButton_Click(object sender, EventArgs e)
        {
            Navigation.NavigateNewRequest(availableResourceLayout, appLayout);
            ResetButtonColors((Button)sender);
        }

        private void addResourcesPageButton_Click(object sender, EventArgs e)
        {
            Navigation.NavigateNewRequest(addResourceLayout, appLayout);
            ResetButtonColors((Button)sender);
        }
    }
}
