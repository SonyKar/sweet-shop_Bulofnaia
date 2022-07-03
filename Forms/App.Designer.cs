using System.Drawing;
using System.Windows.Forms;

namespace Bulofnaia.Forms
{
    partial class App
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.appLayout = new System.Windows.Forms.TableLayoutPanel();
            this.menuLayout = new System.Windows.Forms.TableLayoutPanel();
            this.newRequestPageButton = new System.Windows.Forms.Button();
            this.queuePageButton = new System.Windows.Forms.Button();
            this.menuHeaderLabel = new System.Windows.Forms.Label();
            this.availableResourcesPageButton = new System.Windows.Forms.Button();
            this.addResourcesPageButton = new System.Windows.Forms.Button();
            this.createRequestLayout = new System.Windows.Forms.TableLayoutPanel();
            this.createRequestButton = new System.Windows.Forms.Button();
            this.requestName = new System.Windows.Forms.TextBox();
            this.addResourceToRequestButton = new System.Windows.Forms.Button();
            this.createRequestHeaderLabel = new System.Windows.Forms.Label();
            this.requestDatePicker = new System.Windows.Forms.DateTimePicker();
            this.resourceSelect = new System.Windows.Forms.TableLayoutPanel();
            this.queueLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.queueHeaderLabel = new System.Windows.Forms.Label();
            this.queueTable = new System.Windows.Forms.TableLayoutPanel();
            this.dateQueueHeader = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.resourcesLable = new System.Windows.Forms.Label();
            this.actionLabel = new System.Windows.Forms.Label();
            this.addResourceLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.availableResourceLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.appLayout.SuspendLayout();
            this.menuLayout.SuspendLayout();
            this.createRequestLayout.SuspendLayout();
            this.queueLayout.SuspendLayout();
            this.queueTable.SuspendLayout();
            this.addResourceLayout.SuspendLayout();
            this.availableResourceLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // appLayout
            // 
            this.appLayout.AutoSize = true;
            this.appLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.appLayout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.appLayout.ColumnCount = 2;
            this.appLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.appLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.appLayout.Controls.Add(this.menuLayout, 0, 0);
            this.appLayout.Controls.Add(this.createRequestLayout, 1, 0);
            this.appLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.appLayout.Location = new System.Drawing.Point(0, 0);
            this.appLayout.Name = "appLayout";
            this.appLayout.RowCount = 1;
            this.appLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.appLayout.Size = new System.Drawing.Size(1182, 673);
            this.appLayout.TabIndex = 0;
            // 
            // menuLayout
            // 
            this.menuLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.menuLayout.ColumnCount = 1;
            this.menuLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menuLayout.Controls.Add(this.newRequestPageButton, 0, 1);
            this.menuLayout.Controls.Add(this.queuePageButton, 0, 2);
            this.menuLayout.Controls.Add(this.menuHeaderLabel, 0, 0);
            this.menuLayout.Controls.Add(this.availableResourcesPageButton, 0, 3);
            this.menuLayout.Controls.Add(this.addResourcesPageButton, 0, 4);
            this.menuLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuLayout.Location = new System.Drawing.Point(3, 3);
            this.menuLayout.Name = "menuLayout";
            this.menuLayout.Padding = new System.Windows.Forms.Padding(5);
            this.menuLayout.RowCount = 6;
            this.menuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.menuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.menuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.menuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.menuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.menuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.menuLayout.Size = new System.Drawing.Size(230, 667);
            this.menuLayout.TabIndex = 4;
            // 
            // newRequestPageButton
            // 
            this.newRequestPageButton.AutoSize = true;
            this.newRequestPageButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.newRequestPageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newRequestPageButton.FlatAppearance.BorderSize = 0;
            this.newRequestPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newRequestPageButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newRequestPageButton.Location = new System.Drawing.Point(8, 117);
            this.newRequestPageButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.newRequestPageButton.Name = "newRequestPageButton";
            this.newRequestPageButton.Size = new System.Drawing.Size(214, 86);
            this.newRequestPageButton.TabIndex = 1;
            this.newRequestPageButton.Text = "Добавить заявку";
            this.newRequestPageButton.UseVisualStyleBackColor = false;
            this.newRequestPageButton.Click += new System.EventHandler(this.newRequestPageButton_Click);
            // 
            // queuePageButton
            // 
            this.queuePageButton.BackColor = System.Drawing.Color.White;
            this.queuePageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queuePageButton.FlatAppearance.BorderSize = 0;
            this.queuePageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.queuePageButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queuePageButton.Location = new System.Drawing.Point(8, 226);
            this.queuePageButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.queuePageButton.Name = "queuePageButton";
            this.queuePageButton.Size = new System.Drawing.Size(214, 86);
            this.queuePageButton.TabIndex = 1;
            this.queuePageButton.Text = "Очередь";
            this.queuePageButton.UseVisualStyleBackColor = false;
            this.queuePageButton.Click += new System.EventHandler(this.queuePageButton_Click);
            // 
            // menuHeaderLabel
            // 
            this.menuHeaderLabel.AutoSize = true;
            this.menuHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuHeaderLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuHeaderLabel.Location = new System.Drawing.Point(8, 5);
            this.menuHeaderLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 40);
            this.menuHeaderLabel.Name = "menuHeaderLabel";
            this.menuHeaderLabel.Size = new System.Drawing.Size(214, 69);
            this.menuHeaderLabel.TabIndex = 0;
            this.menuHeaderLabel.Text = "Меню";
            this.menuHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // availableResourcesPageButton
            // 
            this.availableResourcesPageButton.BackColor = System.Drawing.Color.White;
            this.availableResourcesPageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.availableResourcesPageButton.FlatAppearance.BorderSize = 0;
            this.availableResourcesPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.availableResourcesPageButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableResourcesPageButton.Location = new System.Drawing.Point(8, 335);
            this.availableResourcesPageButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.availableResourcesPageButton.Name = "availableResourcesPageButton";
            this.availableResourcesPageButton.Size = new System.Drawing.Size(214, 86);
            this.availableResourcesPageButton.TabIndex = 1;
            this.availableResourcesPageButton.Text = "Доступные ресуры";
            this.availableResourcesPageButton.UseVisualStyleBackColor = false;
            this.availableResourcesPageButton.Click += new System.EventHandler(this.availableResourcesPageButton_Click);
            // 
            // addResourcesPageButton
            // 
            this.addResourcesPageButton.BackColor = System.Drawing.Color.White;
            this.addResourcesPageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addResourcesPageButton.FlatAppearance.BorderSize = 0;
            this.addResourcesPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addResourcesPageButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addResourcesPageButton.Location = new System.Drawing.Point(8, 444);
            this.addResourcesPageButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.addResourcesPageButton.Name = "addResourcesPageButton";
            this.addResourcesPageButton.Size = new System.Drawing.Size(214, 86);
            this.addResourcesPageButton.TabIndex = 1;
            this.addResourcesPageButton.Text = "Закуп";
            this.addResourcesPageButton.UseVisualStyleBackColor = false;
            this.addResourcesPageButton.Click += new System.EventHandler(this.addResourcesPageButton_Click);
            // 
            // createRequestLayout
            // 
            this.createRequestLayout.AutoScroll = true;
            this.createRequestLayout.ColumnCount = 2;
            this.createRequestLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.createRequestLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.createRequestLayout.Controls.Add(this.createRequestButton, 1, 4);
            this.createRequestLayout.Controls.Add(this.requestName, 0, 1);
            this.createRequestLayout.Controls.Add(this.addResourceToRequestButton, 1, 1);
            this.createRequestLayout.Controls.Add(this.createRequestHeaderLabel, 0, 0);
            this.createRequestLayout.Controls.Add(this.requestDatePicker, 0, 4);
            this.createRequestLayout.Controls.Add(this.resourceSelect, 0, 3);
            this.createRequestLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createRequestLayout.Location = new System.Drawing.Point(239, 3);
            this.createRequestLayout.Name = "createRequestLayout";
            this.createRequestLayout.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.createRequestLayout.RowCount = 5;
            this.createRequestLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.42017F));
            this.createRequestLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.57983F));
            this.createRequestLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.createRequestLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 482F));
            this.createRequestLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.createRequestLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.createRequestLayout.Size = new System.Drawing.Size(940, 667);
            this.createRequestLayout.TabIndex = 5;
            // 
            // createRequestButton
            // 
            this.createRequestButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.createRequestButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.createRequestButton.FlatAppearance.BorderSize = 0;
            this.createRequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createRequestButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createRequestButton.ForeColor = System.Drawing.Color.White;
            this.createRequestButton.Location = new System.Drawing.Point(522, 629);
            this.createRequestButton.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.createRequestButton.Name = "createRequestButton";
            this.createRequestButton.Size = new System.Drawing.Size(368, 32);
            this.createRequestButton.TabIndex = 8;
            this.createRequestButton.Text = "Создать заявку";
            this.createRequestButton.UseVisualStyleBackColor = false;
            this.createRequestButton.Click += new System.EventHandler(this.createRequestButton_Click);
            // 
            // requestName
            // 
            this.createRequestLayout.SetColumnSpan(this.requestName, 2);
            this.requestName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestName.Location = new System.Drawing.Point(15, 49);
            this.requestName.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.requestName.Name = "requestName";
            this.requestName.Size = new System.Drawing.Size(915, 32);
            this.requestName.TabIndex = 7;
            this.requestName.Text = "Название";
            // 
            // addResourceToRequestButton
            // 
            this.addResourceToRequestButton.AutoSize = true;
            this.addResourceToRequestButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addResourceToRequestButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.addResourceToRequestButton.FlatAppearance.BorderSize = 0;
            this.addResourceToRequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addResourceToRequestButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addResourceToRequestButton.ForeColor = System.Drawing.Color.White;
            this.addResourceToRequestButton.Location = new System.Drawing.Point(8, 94);
            this.addResourceToRequestButton.Name = "addResourceToRequestButton";
            this.addResourceToRequestButton.Size = new System.Drawing.Size(166, 34);
            this.addResourceToRequestButton.TabIndex = 3;
            this.addResourceToRequestButton.Text = "Добавить ресурс";
            this.addResourceToRequestButton.UseVisualStyleBackColor = false;
            this.addResourceToRequestButton.Click += new System.EventHandler(this.addResourceToRequestButton_Click);
            // 
            // createRequestHeaderLabel
            // 
            this.createRequestHeaderLabel.AutoSize = true;
            this.createRequestLayout.SetColumnSpan(this.createRequestHeaderLabel, 2);
            this.createRequestHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createRequestHeaderLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createRequestHeaderLabel.Location = new System.Drawing.Point(5, 0);
            this.createRequestHeaderLabel.Margin = new System.Windows.Forms.Padding(0);
            this.createRequestHeaderLabel.Name = "createRequestHeaderLabel";
            this.createRequestHeaderLabel.Size = new System.Drawing.Size(935, 46);
            this.createRequestHeaderLabel.TabIndex = 1;
            this.createRequestHeaderLabel.Text = "Добавить заявку";
            this.createRequestHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // requestDatePicker
            // 
            this.requestDatePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestDatePicker.Font = new System.Drawing.Font("Calibri", 12F);
            this.requestDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.requestDatePicker.Location = new System.Drawing.Point(55, 629);
            this.requestDatePicker.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.requestDatePicker.Name = "requestDatePicker";
            this.requestDatePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.requestDatePicker.Size = new System.Drawing.Size(367, 32);
            this.requestDatePicker.TabIndex = 2;
            this.requestDatePicker.Value = new System.DateTime(2022, 7, 3, 11, 56, 12, 0);
            // 
            // resourceSelect
            // 
            this.resourceSelect.AutoScroll = true;
            this.resourceSelect.AutoSize = true;
            this.resourceSelect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resourceSelect.ColumnCount = 4;
            this.createRequestLayout.SetColumnSpan(this.resourceSelect, 2);
            this.resourceSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.resourceSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.resourceSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.resourceSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 479F));
            this.resourceSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.resourceSelect.Location = new System.Drawing.Point(8, 147);
            this.resourceSelect.Name = "resourceSelect";
            this.resourceSelect.Size = new System.Drawing.Size(929, 0);
            this.resourceSelect.TabIndex = 4;
            // 
            // queueLayout
            // 
            this.queueLayout.AutoScroll = true;
            this.queueLayout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.queueLayout.Controls.Add(this.queueHeaderLabel);
            this.queueLayout.Controls.Add(this.queueTable);
            this.queueLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queueLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.queueLayout.Location = new System.Drawing.Point(239, 3);
            this.queueLayout.Name = "queueLayout";
            this.queueLayout.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.queueLayout.Size = new System.Drawing.Size(940, 667);
            this.queueLayout.TabIndex = 3;
            // 
            // queueHeaderLabel
            // 
            this.queueHeaderLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queueHeaderLabel.Location = new System.Drawing.Point(8, 10);
            this.queueHeaderLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 40);
            this.queueHeaderLabel.Name = "queueHeaderLabel";
            this.queueHeaderLabel.Size = new System.Drawing.Size(302, 46);
            this.queueHeaderLabel.TabIndex = 1;
            this.queueHeaderLabel.Text = "Заявки";
            this.queueHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // queueTable
            // 
            this.queueTable.AutoSize = true;
            this.queueTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.queueTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.queueTable.ColumnCount = 5;
            this.queueTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.65111F));
            this.queueTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.13936F));
            this.queueTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.72062F));
            this.queueTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.772F));
            this.queueTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.716908F));
            this.queueTable.Controls.Add(this.dateQueueHeader, 3, 0);
            this.queueTable.Controls.Add(this.idLabel, 0, 0);
            this.queueTable.Controls.Add(this.nameLabel, 1, 0);
            this.queueTable.Controls.Add(this.resourcesLable, 2, 0);
            this.queueTable.Controls.Add(this.actionLabel, 4, 0);
            this.queueTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.queueTable.Location = new System.Drawing.Point(8, 99);
            this.queueTable.Name = "queueTable";
            this.queueTable.RowCount = 1;
            this.queueTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.queueTable.Size = new System.Drawing.Size(929, 52);
            this.queueTable.TabIndex = 2;
            // 
            // dateQueueHeader
            // 
            this.dateQueueHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateQueueHeader.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.dateQueueHeader.Location = new System.Drawing.Point(712, 1);
            this.dateQueueHeader.Name = "dateQueueHeader";
            this.dateQueueHeader.Size = new System.Drawing.Size(121, 50);
            this.dateQueueHeader.TabIndex = 4;
            this.dateQueueHeader.Text = "Дата";
            this.dateQueueHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idLabel
            // 
            this.idLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idLabel.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(4, 1);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(64, 50);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.nameLabel.Location = new System.Drawing.Point(75, 1);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(226, 50);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Название";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resourcesLable
            // 
            this.resourcesLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourcesLable.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.resourcesLable.Location = new System.Drawing.Point(308, 1);
            this.resourcesLable.Name = "resourcesLable";
            this.resourcesLable.Size = new System.Drawing.Size(397, 50);
            this.resourcesLable.TabIndex = 2;
            this.resourcesLable.Text = "Ресуры";
            this.resourcesLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // actionLabel
            // 
            this.actionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionLabel.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.actionLabel.Location = new System.Drawing.Point(840, 1);
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(85, 50);
            this.actionLabel.TabIndex = 3;
            this.actionLabel.Text = "#";
            this.actionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addResourceLayout
            // 
            this.addResourceLayout.AutoScroll = true;
            this.addResourceLayout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addResourceLayout.Controls.Add(this.label4);
            this.addResourceLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addResourceLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.addResourceLayout.Location = new System.Drawing.Point(312, 3);
            this.addResourceLayout.Name = "addResourceLayout";
            this.addResourceLayout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.addResourceLayout.Size = new System.Drawing.Size(867, 667);
            this.addResourceLayout.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 46);
            this.label4.TabIndex = 1;
            this.label4.Text = "Закупка";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // availableResourceLayout
            // 
            this.availableResourceLayout.AutoScroll = true;
            this.availableResourceLayout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.availableResourceLayout.Controls.Add(this.label3);
            this.availableResourceLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.availableResourceLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.availableResourceLayout.Location = new System.Drawing.Point(312, 3);
            this.availableResourceLayout.Name = "availableResourceLayout";
            this.availableResourceLayout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.availableResourceLayout.Size = new System.Drawing.Size(867, 667);
            this.availableResourceLayout.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 46);
            this.label3.TabIndex = 1;
            this.label3.Text = "Доступные ресуры";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(605, 88);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1182, 673);
            this.Controls.Add(this.appLayout);
            this.Location = new System.Drawing.Point(15, 15);
            this.MinimumSize = new System.Drawing.Size(1200, 720);
            this.Name = "App";
            this.Text = "Bulofnaia";
            this.appLayout.ResumeLayout(false);
            this.menuLayout.ResumeLayout(false);
            this.menuLayout.PerformLayout();
            this.createRequestLayout.ResumeLayout(false);
            this.createRequestLayout.PerformLayout();
            this.queueLayout.ResumeLayout(false);
            this.queueLayout.PerformLayout();
            this.queueTable.ResumeLayout(false);
            this.addResourceLayout.ResumeLayout(false);
            this.availableResourceLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button createRequestButton;

        public System.Windows.Forms.TextBox requestName;

        public System.Windows.Forms.TableLayoutPanel resourceSelect;

        private System.Windows.Forms.Button addResourceToRequestButton;

        public System.Windows.Forms.DateTimePicker requestDatePicker;

        private System.Windows.Forms.Label createRequestHeaderLabel;

        private System.Windows.Forms.TableLayoutPanel createRequestLayout;

        private System.Windows.Forms.Label dateQueueHeader;

        private System.Windows.Forms.TableLayoutPanel menuLayout;

        private System.Windows.Forms.Button addResourcesPageButton;
        private System.Windows.Forms.Button availableResourcesPageButton;
        private System.Windows.Forms.Button queuePageButton;
        private System.Windows.Forms.Button newRequestPageButton;
        private System.Windows.Forms.Label menuHeaderLabel;

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label resourcesLable;
        private System.Windows.Forms.Label actionLabel;

        private System.Windows.Forms.TableLayoutPanel queueTable;

        private System.Windows.Forms.FlowLayoutPanel addResourceLayout;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.FlowLayoutPanel availableResourceLayout;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.FlowLayoutPanel queueLayout;
        private System.Windows.Forms.Label queueHeaderLabel;

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

        private System.Windows.Forms.TableLayoutPanel appLayout;

        #endregion
    }
}

