using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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
            this.button1 = new System.Windows.Forms.Button();
            this.newRequestPageButton = new System.Windows.Forms.Button();
            this.queuePageButton = new System.Windows.Forms.Button();
            this.menuHeaderLabel = new System.Windows.Forms.Label();
            this.availableResourcesPageButton = new System.Windows.Forms.Button();
            this.optimalRefillPageButton = new System.Windows.Forms.Button();
            this.optimalRefillLayout = new System.Windows.Forms.TableLayoutPanel();
            this.optimalRefillHeaderLayout = new System.Windows.Forms.Label();
            this.optimalRefillDisplay = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.availableResourceLayout = new System.Windows.Forms.TableLayoutPanel();
            this.addStoragePricePlace = new System.Windows.Forms.TableLayoutPanel();
            this.addExpensesPlace = new System.Windows.Forms.TableLayoutPanel();
            this.editExpensesPlace = new System.Windows.Forms.TableLayoutPanel();
            this.editResourceButton = new System.Windows.Forms.Button();
            this.createResourceButton = new System.Windows.Forms.Button();
            this.editStoragePricePlace = new System.Windows.Forms.TableLayoutPanel();
            this.selectResourcePlace = new System.Windows.Forms.TableLayoutPanel();
            this.resourcesHeaderLabel = new System.Windows.Forms.Label();
            this.editResourceHeaderLabel = new System.Windows.Forms.Label();
            this.createResourceHeaderLabel = new System.Windows.Forms.Label();
            this.newResourceName = new System.Windows.Forms.TextBox();
            this.selectUnitPlace = new System.Windows.Forms.TableLayoutPanel();
            this.resourcesTable = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.actionResourceLabel = new System.Windows.Forms.Label();
            this.idResourceLabel = new System.Windows.Forms.Label();
            this.nameResourceLabel = new System.Windows.Forms.Label();
            this.createRequestLayout = new System.Windows.Forms.TableLayoutPanel();
            this.createRequestHeaderLabel = new System.Windows.Forms.Label();
            this.requestName = new System.Windows.Forms.TextBox();
            this.addResourceToRequestButton = new System.Windows.Forms.Button();
            this.requestDatePicker = new System.Windows.Forms.DateTimePicker();
            this.createRequestButton = new System.Windows.Forms.Button();
            this.resourceSelectLayout = new System.Windows.Forms.TableLayoutPanel();
            this.queueLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.queueHeaderLabel = new System.Windows.Forms.Label();
            this.queueTable = new System.Windows.Forms.TableLayoutPanel();
            this.dateQueueHeader = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.resourcesLable = new System.Windows.Forms.Label();
            this.actionLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.appLayout.SuspendLayout();
            this.menuLayout.SuspendLayout();
            this.optimalRefillLayout.SuspendLayout();
            this.optimalRefillDisplay.SuspendLayout();
            this.availableResourceLayout.SuspendLayout();
            this.resourcesTable.SuspendLayout();
            this.createRequestLayout.SuspendLayout();
            this.queueLayout.SuspendLayout();
            this.queueTable.SuspendLayout();
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
            this.appLayout.Controls.Add(this.optimalRefillLayout);
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
            this.menuLayout.Controls.Add(this.button1, 0, 5);
            this.menuLayout.Controls.Add(this.newRequestPageButton, 0, 1);
            this.menuLayout.Controls.Add(this.queuePageButton, 0, 2);
            this.menuLayout.Controls.Add(this.menuHeaderLabel, 0, 0);
            this.menuLayout.Controls.Add(this.availableResourcesPageButton, 0, 3);
            this.menuLayout.Controls.Add(this.optimalRefillPageButton, 0, 4);
            this.menuLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuLayout.Location = new System.Drawing.Point(3, 3);
            this.menuLayout.Name = "menuLayout";
            this.menuLayout.Padding = new System.Windows.Forms.Padding(5);
            this.menuLayout.RowCount = 7;
            this.menuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.menuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.menuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.menuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.menuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.menuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.menuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.menuLayout.Size = new System.Drawing.Size(230, 667);
            this.menuLayout.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(8, 538);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 83);
            this.button1.TabIndex = 5;
            this.button1.Text = "Закуп";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // newRequestPageButton
            // 
            this.newRequestPageButton.AutoSize = true;
            this.newRequestPageButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.newRequestPageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newRequestPageButton.FlatAppearance.BorderSize = 0;
            this.newRequestPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newRequestPageButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newRequestPageButton.Location = new System.Drawing.Point(8, 114);
            this.newRequestPageButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.newRequestPageButton.Name = "newRequestPageButton";
            this.newRequestPageButton.Size = new System.Drawing.Size(214, 83);
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
            this.queuePageButton.Location = new System.Drawing.Point(8, 220);
            this.queuePageButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.queuePageButton.Name = "queuePageButton";
            this.queuePageButton.Size = new System.Drawing.Size(214, 83);
            this.queuePageButton.TabIndex = 2;
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
            this.menuHeaderLabel.Size = new System.Drawing.Size(214, 66);
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
            this.availableResourcesPageButton.Location = new System.Drawing.Point(8, 326);
            this.availableResourcesPageButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.availableResourcesPageButton.Name = "availableResourcesPageButton";
            this.availableResourcesPageButton.Size = new System.Drawing.Size(214, 83);
            this.availableResourcesPageButton.TabIndex = 3;
            this.availableResourcesPageButton.Text = "Доступные ресуры";
            this.availableResourcesPageButton.UseVisualStyleBackColor = false;
            this.availableResourcesPageButton.Click += new System.EventHandler(this.availableResourcesPageButton_Click);
            // 
            // optimalRefillPageButton
            // 
            this.optimalRefillPageButton.BackColor = System.Drawing.Color.White;
            this.optimalRefillPageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optimalRefillPageButton.FlatAppearance.BorderSize = 0;
            this.optimalRefillPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optimalRefillPageButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optimalRefillPageButton.Location = new System.Drawing.Point(8, 432);
            this.optimalRefillPageButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.optimalRefillPageButton.Name = "optimalRefillPageButton";
            this.optimalRefillPageButton.Size = new System.Drawing.Size(214, 83);
            this.optimalRefillPageButton.TabIndex = 4;
            this.optimalRefillPageButton.Text = "Закуп";
            this.optimalRefillPageButton.UseVisualStyleBackColor = false;
            this.optimalRefillPageButton.Click += new System.EventHandler(this.unmetResourcesPageButton_Click);
            // 
            // optimalRefillLayout
            // 
            this.optimalRefillLayout.AutoScroll = true;
            this.optimalRefillLayout.AutoSize = true;
            this.optimalRefillLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.optimalRefillLayout.ColumnCount = 1;
            this.optimalRefillLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.optimalRefillLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.optimalRefillLayout.Controls.Add(this.optimalRefillHeaderLayout, 0, 0);
            this.optimalRefillLayout.Controls.Add(this.optimalRefillDisplay, 0, 1);
            this.optimalRefillLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optimalRefillLayout.Location = new System.Drawing.Point(239, 3);
            this.optimalRefillLayout.Name = "optimalRefillLayout";
            this.optimalRefillLayout.RowCount = 2;
            this.optimalRefillLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.94453F));
            this.optimalRefillLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.05547F));
            this.optimalRefillLayout.Size = new System.Drawing.Size(940, 667);
            this.optimalRefillLayout.TabIndex = 5;
            // 
            // optimalRefillHeaderLayout
            // 
            this.optimalRefillHeaderLayout.AutoSize = true;
            this.optimalRefillHeaderLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optimalRefillHeaderLayout.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optimalRefillHeaderLayout.Location = new System.Drawing.Point(10, 3);
            this.optimalRefillHeaderLayout.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.optimalRefillHeaderLayout.Name = "optimalRefillHeaderLayout";
            this.optimalRefillHeaderLayout.Size = new System.Drawing.Size(927, 67);
            this.optimalRefillHeaderLayout.TabIndex = 1;
            this.optimalRefillHeaderLayout.Text = "Оптимальное пополнение";
            this.optimalRefillHeaderLayout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // optimalRefillDisplay
            // 
            this.optimalRefillDisplay.AutoSize = true;
            this.optimalRefillDisplay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.optimalRefillDisplay.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.optimalRefillDisplay.ColumnCount = 5;
            this.optimalRefillDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.optimalRefillDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.optimalRefillDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.optimalRefillDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.optimalRefillDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.optimalRefillDisplay.Controls.Add(this.label7, 4, 0);
            this.optimalRefillDisplay.Controls.Add(this.label6, 3, 0);
            this.optimalRefillDisplay.Controls.Add(this.label5, 2, 0);
            this.optimalRefillDisplay.Controls.Add(this.label2, 1, 0);
            this.optimalRefillDisplay.Controls.Add(this.label1, 0, 0);
            this.optimalRefillDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.optimalRefillDisplay.Location = new System.Drawing.Point(3, 76);
            this.optimalRefillDisplay.Name = "optimalRefillDisplay";
            this.optimalRefillDisplay.RowCount = 1;
            this.optimalRefillDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.optimalRefillDisplay.Size = new System.Drawing.Size(934, 80);
            this.optimalRefillDisplay.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(802, 4);
            this.label7.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 72);
            this.label7.TabIndex = 6;
            this.label7.Text = "Оптимальный интервал между партиями";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(662, 4);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 72);
            this.label6.TabIndex = 5;
            this.label6.Text = "Оптимальный объем партии";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(197, 4);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(451, 72);
            this.label5.TabIndex = 4;
            this.label5.Text = "Название ресурса";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 72);
            this.label2.TabIndex = 3;
            this.label2.Text = "id ресурса";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 72);
            this.label1.TabIndex = 2;
            this.label1.Text = "id заявки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // availableResourceLayout
            // 
            this.availableResourceLayout.ColumnCount = 5;
            this.availableResourceLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.73702F));
            this.availableResourceLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.55818F));
            this.availableResourceLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.71501F));
            this.availableResourceLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.availableResourceLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.availableResourceLayout.Controls.Add(this.addStoragePricePlace, 3, 1);
            this.availableResourceLayout.Controls.Add(this.addExpensesPlace, 2, 1);
            this.availableResourceLayout.Controls.Add(this.editExpensesPlace, 2, 3);
            this.availableResourceLayout.Controls.Add(this.editResourceButton, 4, 3);
            this.availableResourceLayout.Controls.Add(this.createResourceButton, 4, 1);
            this.availableResourceLayout.Controls.Add(this.editStoragePricePlace, 2, 3);
            this.availableResourceLayout.Controls.Add(this.selectResourcePlace, 0, 3);
            this.availableResourceLayout.Controls.Add(this.resourcesHeaderLabel, 0, 4);
            this.availableResourceLayout.Controls.Add(this.editResourceHeaderLabel, 0, 2);
            this.availableResourceLayout.Controls.Add(this.createResourceHeaderLabel, 0, 0);
            this.availableResourceLayout.Controls.Add(this.newResourceName, 0, 1);
            this.availableResourceLayout.Controls.Add(this.selectUnitPlace, 1, 1);
            this.availableResourceLayout.Controls.Add(this.resourcesTable, 0, 5);
            this.availableResourceLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.availableResourceLayout.Location = new System.Drawing.Point(246, 3);
            this.availableResourceLayout.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.availableResourceLayout.Name = "availableResourceLayout";
            this.availableResourceLayout.RowCount = 6;
            this.availableResourceLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.availableResourceLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.availableResourceLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.availableResourceLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.availableResourceLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.availableResourceLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.availableResourceLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.availableResourceLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.availableResourceLayout.Size = new System.Drawing.Size(926, 667);
            this.availableResourceLayout.TabIndex = 5;
            // 
            // addStoragePricePlace
            // 
            this.addStoragePricePlace.ColumnCount = 1;
            this.addStoragePricePlace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addStoragePricePlace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addStoragePricePlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addStoragePricePlace.Location = new System.Drawing.Point(587, 49);
            this.addStoragePricePlace.Name = "addStoragePricePlace";
            this.addStoragePricePlace.RowCount = 1;
            this.addStoragePricePlace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.addStoragePricePlace.Size = new System.Drawing.Size(171, 40);
            this.addStoragePricePlace.TabIndex = 15;
            // 
            // addExpensesPlace
            // 
            this.addExpensesPlace.ColumnCount = 1;
            this.addExpensesPlace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addExpensesPlace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addExpensesPlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addExpensesPlace.Location = new System.Drawing.Point(396, 49);
            this.addExpensesPlace.Name = "addExpensesPlace";
            this.addExpensesPlace.RowCount = 1;
            this.addExpensesPlace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.addExpensesPlace.Size = new System.Drawing.Size(185, 40);
            this.addExpensesPlace.TabIndex = 14;
            // 
            // editExpensesPlace
            // 
            this.editExpensesPlace.ColumnCount = 1;
            this.editExpensesPlace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.editExpensesPlace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.editExpensesPlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editExpensesPlace.Location = new System.Drawing.Point(396, 141);
            this.editExpensesPlace.Name = "editExpensesPlace";
            this.editExpensesPlace.RowCount = 1;
            this.editExpensesPlace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.editExpensesPlace.Size = new System.Drawing.Size(185, 40);
            this.editExpensesPlace.TabIndex = 13;
            // 
            // editResourceButton
            // 
            this.editResourceButton.AutoSize = true;
            this.editResourceButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.editResourceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editResourceButton.FlatAppearance.BorderSize = 0;
            this.editResourceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editResourceButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editResourceButton.ForeColor = System.Drawing.Color.White;
            this.editResourceButton.Location = new System.Drawing.Point(771, 141);
            this.editResourceButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.editResourceButton.Name = "editResourceButton";
            this.editResourceButton.Size = new System.Drawing.Size(145, 40);
            this.editResourceButton.TabIndex = 12;
            this.editResourceButton.Text = "Изменить";
            this.editResourceButton.UseVisualStyleBackColor = false;
            this.editResourceButton.Click += new System.EventHandler(this.editResourceButton_Click);
            // 
            // createResourceButton
            // 
            this.createResourceButton.AutoSize = true;
            this.createResourceButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.createResourceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createResourceButton.FlatAppearance.BorderSize = 0;
            this.createResourceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createResourceButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createResourceButton.ForeColor = System.Drawing.Color.White;
            this.createResourceButton.Location = new System.Drawing.Point(771, 49);
            this.createResourceButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.createResourceButton.Name = "createResourceButton";
            this.createResourceButton.Size = new System.Drawing.Size(145, 40);
            this.createResourceButton.TabIndex = 11;
            this.createResourceButton.Text = "Создать";
            this.createResourceButton.UseVisualStyleBackColor = false;
            this.createResourceButton.Click += new System.EventHandler(this.createResourceButton_Click);
            // 
            // editStoragePricePlace
            // 
            this.editStoragePricePlace.ColumnCount = 1;
            this.editStoragePricePlace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.editStoragePricePlace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.editStoragePricePlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editStoragePricePlace.Location = new System.Drawing.Point(587, 141);
            this.editStoragePricePlace.Name = "editStoragePricePlace";
            this.editStoragePricePlace.RowCount = 1;
            this.editStoragePricePlace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.editStoragePricePlace.Size = new System.Drawing.Size(171, 40);
            this.editStoragePricePlace.TabIndex = 10;
            // 
            // selectResourcePlace
            // 
            this.selectResourcePlace.ColumnCount = 1;
            this.availableResourceLayout.SetColumnSpan(this.selectResourcePlace, 2);
            this.selectResourcePlace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.selectResourcePlace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.selectResourcePlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectResourcePlace.Location = new System.Drawing.Point(3, 141);
            this.selectResourcePlace.Name = "selectResourcePlace";
            this.selectResourcePlace.RowCount = 1;
            this.selectResourcePlace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.selectResourcePlace.Size = new System.Drawing.Size(387, 40);
            this.selectResourcePlace.TabIndex = 9;
            // 
            // resourcesHeaderLabel
            // 
            this.resourcesHeaderLabel.AutoSize = true;
            this.availableResourceLayout.SetColumnSpan(this.resourcesHeaderLabel, 5);
            this.resourcesHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourcesHeaderLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resourcesHeaderLabel.Location = new System.Drawing.Point(3, 187);
            this.resourcesHeaderLabel.Margin = new System.Windows.Forms.Padding(3);
            this.resourcesHeaderLabel.Name = "resourcesHeaderLabel";
            this.resourcesHeaderLabel.Size = new System.Drawing.Size(920, 40);
            this.resourcesHeaderLabel.TabIndex = 3;
            this.resourcesHeaderLabel.Text = "Ресурсы";
            this.resourcesHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // editResourceHeaderLabel
            // 
            this.editResourceHeaderLabel.AutoSize = true;
            this.availableResourceLayout.SetColumnSpan(this.editResourceHeaderLabel, 5);
            this.editResourceHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editResourceHeaderLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editResourceHeaderLabel.Location = new System.Drawing.Point(3, 95);
            this.editResourceHeaderLabel.Margin = new System.Windows.Forms.Padding(3);
            this.editResourceHeaderLabel.Name = "editResourceHeaderLabel";
            this.editResourceHeaderLabel.Size = new System.Drawing.Size(920, 40);
            this.editResourceHeaderLabel.TabIndex = 2;
            this.editResourceHeaderLabel.Text = "Изменить ресурс";
            this.editResourceHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // createResourceHeaderLabel
            // 
            this.createResourceHeaderLabel.AutoSize = true;
            this.availableResourceLayout.SetColumnSpan(this.createResourceHeaderLabel, 5);
            this.createResourceHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createResourceHeaderLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createResourceHeaderLabel.Location = new System.Drawing.Point(3, 3);
            this.createResourceHeaderLabel.Margin = new System.Windows.Forms.Padding(3);
            this.createResourceHeaderLabel.Name = "createResourceHeaderLabel";
            this.createResourceHeaderLabel.Size = new System.Drawing.Size(920, 40);
            this.createResourceHeaderLabel.TabIndex = 1;
            this.createResourceHeaderLabel.Text = "Добавить ресурс";
            this.createResourceHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // newResourceName
            // 
            this.newResourceName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newResourceName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newResourceName.Location = new System.Drawing.Point(10, 49);
            this.newResourceName.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.newResourceName.Name = "newResourceName";
            this.newResourceName.Size = new System.Drawing.Size(177, 32);
            this.newResourceName.TabIndex = 5;
            this.newResourceName.Text = "Название ресурса";
            // 
            // selectUnitPlace
            // 
            this.selectUnitPlace.ColumnCount = 1;
            this.selectUnitPlace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.selectUnitPlace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.selectUnitPlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectUnitPlace.Location = new System.Drawing.Point(200, 49);
            this.selectUnitPlace.Name = "selectUnitPlace";
            this.selectUnitPlace.RowCount = 1;
            this.selectUnitPlace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.selectUnitPlace.Size = new System.Drawing.Size(190, 40);
            this.selectUnitPlace.TabIndex = 6;
            // 
            // resourcesTable
            // 
            this.resourcesTable.AutoSize = true;
            this.resourcesTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.resourcesTable.ColumnCount = 5;
            this.availableResourceLayout.SetColumnSpan(this.resourcesTable, 5);
            this.resourcesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.resourcesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.resourcesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.resourcesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.resourcesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.resourcesTable.Controls.Add(this.label4, 3, 0);
            this.resourcesTable.Controls.Add(this.label3, 2, 0);
            this.resourcesTable.Controls.Add(this.actionResourceLabel, 4, 0);
            this.resourcesTable.Controls.Add(this.idResourceLabel, 0, 0);
            this.resourcesTable.Controls.Add(this.nameResourceLabel, 1, 0);
            this.resourcesTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.resourcesTable.Location = new System.Drawing.Point(3, 233);
            this.resourcesTable.Name = "resourcesTable";
            this.resourcesTable.RowCount = 1;
            this.resourcesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.resourcesTable.Size = new System.Drawing.Size(920, 32);
            this.resourcesTable.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(645, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Затраты";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(462, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Цена за хранение";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // actionResourceLabel
            // 
            this.actionResourceLabel.AutoSize = true;
            this.actionResourceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionResourceLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.actionResourceLabel.Location = new System.Drawing.Point(828, 4);
            this.actionResourceLabel.Margin = new System.Windows.Forms.Padding(3);
            this.actionResourceLabel.Name = "actionResourceLabel";
            this.actionResourceLabel.Size = new System.Drawing.Size(88, 24);
            this.actionResourceLabel.TabIndex = 5;
            this.actionResourceLabel.Text = "#";
            this.actionResourceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idResourceLabel
            // 
            this.idResourceLabel.AutoSize = true;
            this.idResourceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idResourceLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idResourceLabel.Location = new System.Drawing.Point(4, 4);
            this.idResourceLabel.Margin = new System.Windows.Forms.Padding(3);
            this.idResourceLabel.Name = "idResourceLabel";
            this.idResourceLabel.Size = new System.Drawing.Size(85, 24);
            this.idResourceLabel.TabIndex = 4;
            this.idResourceLabel.Text = "ID";
            this.idResourceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameResourceLabel
            // 
            this.nameResourceLabel.AutoSize = true;
            this.nameResourceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameResourceLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.nameResourceLabel.Location = new System.Drawing.Point(96, 4);
            this.nameResourceLabel.Margin = new System.Windows.Forms.Padding(3);
            this.nameResourceLabel.Name = "nameResourceLabel";
            this.nameResourceLabel.Size = new System.Drawing.Size(359, 24);
            this.nameResourceLabel.TabIndex = 3;
            this.nameResourceLabel.Text = "Название";
            this.nameResourceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createRequestLayout
            // 
            this.createRequestLayout.AutoScroll = true;
            this.createRequestLayout.ColumnCount = 2;
            this.createRequestLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.createRequestLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.createRequestLayout.Controls.Add(this.createRequestHeaderLabel, 0, 0);
            this.createRequestLayout.Controls.Add(this.requestName, 0, 1);
            this.createRequestLayout.Controls.Add(this.addResourceToRequestButton, 1, 1);
            this.createRequestLayout.Controls.Add(this.requestDatePicker, 0, 4);
            this.createRequestLayout.Controls.Add(this.createRequestButton, 1, 4);
            this.createRequestLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createRequestLayout.Location = new System.Drawing.Point(239, 3);
            this.createRequestLayout.Name = "createRequestLayout";
            this.createRequestLayout.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.createRequestLayout.RowCount = 5;
            this.createRequestLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.createRequestLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.createRequestLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.createRequestLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.createRequestLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.createRequestLayout.Size = new System.Drawing.Size(940, 667);
            this.createRequestLayout.TabIndex = 5;
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
            this.createRequestHeaderLabel.Size = new System.Drawing.Size(935, 67);
            this.createRequestHeaderLabel.TabIndex = 1;
            this.createRequestHeaderLabel.Text = "Добавить заявку";
            this.createRequestHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // requestName
            // 
            this.createRequestLayout.SetColumnSpan(this.requestName, 2);
            this.requestName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestName.Location = new System.Drawing.Point(15, 70);
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
            this.addResourceToRequestButton.Location = new System.Drawing.Point(8, 117);
            this.addResourceToRequestButton.Name = "addResourceToRequestButton";
            this.addResourceToRequestButton.Size = new System.Drawing.Size(166, 34);
            this.addResourceToRequestButton.TabIndex = 3;
            this.addResourceToRequestButton.Text = "Добавить ресурс";
            this.addResourceToRequestButton.UseVisualStyleBackColor = false;
            this.addResourceToRequestButton.Click += new System.EventHandler(this.addResourceToRequestButton_Click);
            // 
            // requestDatePicker
            // 
            this.requestDatePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestDatePicker.Font = new System.Drawing.Font("Calibri", 12F);
            this.requestDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.requestDatePicker.Location = new System.Drawing.Point(55, 635);
            this.requestDatePicker.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.requestDatePicker.Name = "requestDatePicker";
            this.requestDatePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.requestDatePicker.Size = new System.Drawing.Size(367, 32);
            this.requestDatePicker.TabIndex = 2;
            this.requestDatePicker.Value = new System.DateTime(2022, 7, 3, 11, 56, 12, 0);
            // 
            // createRequestButton
            // 
            this.createRequestButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.createRequestButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.createRequestButton.FlatAppearance.BorderSize = 0;
            this.createRequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createRequestButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createRequestButton.ForeColor = System.Drawing.Color.White;
            this.createRequestButton.Location = new System.Drawing.Point(522, 635);
            this.createRequestButton.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.createRequestButton.Name = "createRequestButton";
            this.createRequestButton.Size = new System.Drawing.Size(368, 29);
            this.createRequestButton.TabIndex = 8;
            this.createRequestButton.Text = "Создать заявку";
            this.createRequestButton.UseVisualStyleBackColor = false;
            this.createRequestButton.Click += new System.EventHandler(this.createRequestButton_Click);
            // 
            // resourceSelectLayout
            // 
            this.resourceSelectLayout.AutoSize = true;
            this.resourceSelectLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resourceSelectLayout.ColumnCount = 3;
            this.resourceSelectLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.resourceSelectLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.resourceSelectLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.resourceSelectLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.resourceSelectLayout.Location = new System.Drawing.Point(8, 164);
            this.resourceSelectLayout.Name = "resourceSelectLayout";
            this.resourceSelectLayout.Size = new System.Drawing.Size(929, 0);
            this.resourceSelectLayout.TabIndex = 4;
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(605, 88);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel5.TabIndex = 0;
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
            this.appLayout.PerformLayout();
            this.menuLayout.ResumeLayout(false);
            this.menuLayout.PerformLayout();
            this.optimalRefillLayout.ResumeLayout(false);
            this.optimalRefillLayout.PerformLayout();
            this.optimalRefillDisplay.ResumeLayout(false);
            this.optimalRefillDisplay.PerformLayout();
            this.availableResourceLayout.ResumeLayout(false);
            this.availableResourceLayout.PerformLayout();
            this.resourcesTable.ResumeLayout(false);
            this.resourcesTable.PerformLayout();
            this.createRequestLayout.ResumeLayout(false);
            this.createRequestLayout.PerformLayout();
            this.queueLayout.ResumeLayout(false);
            this.queueLayout.PerformLayout();
            this.queueTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        public System.Windows.Forms.TableLayoutPanel addStoragePricePlace;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        public System.Windows.Forms.TableLayoutPanel editExpensesPlace;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;

        public System.Windows.Forms.TableLayoutPanel addExpensesPlace;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

        private System.Windows.Forms.Button editResourceButton;

        private System.Windows.Forms.Label nameResourceLabel;
        private System.Windows.Forms.Label idResourceLabel;
        private System.Windows.Forms.Label actionResourceLabel;

        private System.Windows.Forms.Button createResourceButton;

        public System.Windows.Forms.TableLayoutPanel editStoragePricePlace;
        public System.Windows.Forms.TableLayoutPanel selectResourcePlace;

        public System.Windows.Forms.TableLayoutPanel selectUnitPlace;

        public System.Windows.Forms.TableLayoutPanel resourcesTable;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        public System.Windows.Forms.TextBox newResourceName;

        private System.Windows.Forms.Label createResourceHeaderLabel;
        private System.Windows.Forms.Label editResourceHeaderLabel;
        private System.Windows.Forms.Label resourcesHeaderLabel;

        public System.Windows.Forms.TableLayoutPanel availableResourceLayout;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TableLayoutPanel optimalRefillLayout;

        private System.Windows.Forms.Label optimalRefillHeaderLayout;

        private System.Windows.Forms.TableLayoutPanel optimalRefillDisplay;

        private System.Windows.Forms.Button createRequestButton;

        public System.Windows.Forms.TextBox requestName;

        public System.Windows.Forms.TableLayoutPanel resourceSelectLayout;

        private System.Windows.Forms.Button addResourceToRequestButton;

        public System.Windows.Forms.DateTimePicker requestDatePicker;

        private System.Windows.Forms.Label createRequestHeaderLabel;

        private System.Windows.Forms.TableLayoutPanel createRequestLayout;

        private System.Windows.Forms.Label dateQueueHeader;

        private System.Windows.Forms.TableLayoutPanel menuLayout;

        private System.Windows.Forms.Button optimalRefillPageButton;
        private System.Windows.Forms.Button availableResourcesPageButton;
        private System.Windows.Forms.Button queuePageButton;
        private System.Windows.Forms.Button newRequestPageButton;
        private System.Windows.Forms.Label menuHeaderLabel;

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label resourcesLable;
        private System.Windows.Forms.Label actionLabel;

        private System.Windows.Forms.TableLayoutPanel queueTable;

        private System.Windows.Forms.FlowLayoutPanel queueLayout;
        private System.Windows.Forms.Label queueHeaderLabel;

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

        private System.Windows.Forms.TableLayoutPanel appLayout;

        #endregion
    }
}

