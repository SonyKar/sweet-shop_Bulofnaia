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
            Button[] buttons = {newRequestPageButton, queuePageButton, availableResourcesPageButton, optimalRefillPageButton, profilesPageButton};
            foreach (var button in buttons)
            {
                button.BackColor = Color.White;
                button.ForeColor = Color.Black;
            }
            selectedButton.BackColor = Color.FromArgb(255, 255,182,137);
            selectedButton.ForeColor = Color.White;
        }

        private void authButton_Click(object sender, EventArgs e)
        {
	        if (usernameTextBox.Text.Trim() == "" || passwordTextBox.Text.Trim() == "")
	        {
		        authErrorLabel.Visible = true;
		        return;
	        }
	        Controls.Remove(authLayout);
            Controls.Add(appLayout);
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

        private void optimalRefillPageButton_Click(object sender, EventArgs e)
        {
            OptimalRefillController controller = new OptimalRefillController();
            controller.Load(optimalRefillDisplay);
            Navigation.NavigateNewRequest(optimalRefillLayout, appLayout);
            ResetButtonColors((Button)sender);
        }
        
        private void profilesPageButton_Click(object sender, EventArgs e)
        {
            ProfilesController controller = new ProfilesController();
            controller.Load(profilesDisplay);
            Navigation.NavigateNewRequest(profilesLayout, appLayout);
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

        private void editResourceButton_Click(object sender, EventArgs e)
        {
            AvailableResourcesController controller = new AvailableResourcesController(this);
            controller.EditResourceNumber();
            controller.InitializeComponents();
        }

        private void createProfileButton_Click(object sender, EventArgs e)
        {
            ProfilesController controller = new ProfilesController();

            String name = profileNameTextbox.Text;
            String surname = profileSurnameTextbox.Text;
            String position = profilePositionTextbox.Text;
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            profileNameTextbox.Text = "";
            profileSurnameTextbox.Text = "";
            profilePositionTextbox.Text = "";
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";

            controller.CreateProfile(name, surname, position, username, password);
        }
    }
}
