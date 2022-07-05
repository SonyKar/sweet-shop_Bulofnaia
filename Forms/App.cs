using System;
using System.Drawing;
using System.Windows.Forms;
using Bulofnaia.Forms.Controllers;

namespace Bulofnaia.Forms
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void ResetButtonColors(Button selectedButton)
        {
            Button[] buttons = {newRequestPageButton, queuePageButton, availableResourcesPageButton, unmetResourcePageButton};
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
            QueueController queueController = new QueueController();
            queueController.Load(queueTable);
            Navigation.NavigateNewRequest(queueLayout, appLayout);
            ResetButtonColors((Button)sender);
        }

        private void availableResourcesPageButton_Click(object sender, EventArgs e)
        {
            AvailableResourcesController controller = new AvailableResourcesController(this);
            controller.InitializeComponents();
            Navigation.NavigateNewRequest(availableResourceLayout, appLayout);
            ResetButtonColors((Button)sender);
        }

        private void unmetResourcesPageButton_Click(object sender, EventArgs e)
        {
            UnmetResourcesController controller = new UnmetResourcesController();
            controller.Load(unmetResourcesDisplay);
            Navigation.NavigateNewRequest(unmetResourceLayout, appLayout);
            ResetButtonColors((Button)sender);
        }
        
        private void createRequestButton_Click(object sender, EventArgs e)
        {
            CreateRequestController controller = new CreateRequestController(this);
            controller.CreateRequest();
        }

        private void addResourceToRequestButton_Click(object sender, EventArgs e)
        {
            CreateRequestController controller = new CreateRequestController();
            controller.AddResourceControl(resourceSelectLayout);
        }

        private void createResourceButton_Click(object sender, EventArgs e)
        {
            AvailableResourcesController controller = new AvailableResourcesController(this);
            controller.CreateResource();
            controller.InitializeComponents();
        }

        private void plusResourceButton_Click(object sender, EventArgs e)
        {
            AvailableResourcesController controller = new AvailableResourcesController(this);
            controller.EditResourceNumber(true);
            controller.InitializeComponents();
        }

        private void minusResourceButton_Click(object sender, EventArgs e)
        {
            AvailableResourcesController controller = new AvailableResourcesController(this);
            controller.EditResourceNumber(false);
            controller.InitializeComponents();
        }
    }
}
