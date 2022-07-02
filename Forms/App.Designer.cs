namespace Bulofnaia.Forms
{
    partial class Form1
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
            this.queueLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.queueHeaderLabel = new System.Windows.Forms.Label();
            this.queueTable = new System.Windows.Forms.TableLayoutPanel();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.resourcesLable = new System.Windows.Forms.Label();
            this.actionLabel = new System.Windows.Forms.Label();
            this.menuButtonLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.menuHeaderLabel = new System.Windows.Forms.Label();
            this.newRequestPageButton = new System.Windows.Forms.Button();
            this.queuePageButton = new System.Windows.Forms.Button();
            this.availableResourcesPageButton = new System.Windows.Forms.Button();
            this.addResourcesPageButton = new System.Windows.Forms.Button();
            this.addResourceLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.availableResourceLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.createRequestLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.createRequestHeaderLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.appLayout.SuspendLayout();
            this.queueLayout.SuspendLayout();
            this.queueTable.SuspendLayout();
            this.menuButtonLayout.SuspendLayout();
            this.addResourceLayout.SuspendLayout();
            this.availableResourceLayout.SuspendLayout();
            this.createRequestLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // appLayout
            // 
            this.appLayout.AutoSize = true;
            this.appLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.appLayout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.appLayout.ColumnCount = 2;
            this.appLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.14213F));
            this.appLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.85786F));
            this.appLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.appLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.appLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.appLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.appLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.appLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.appLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.appLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.appLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.appLayout.Controls.Add(this.queueLayout, 1, 0);
            this.appLayout.Controls.Add(this.menuButtonLayout, 0, 0);
            this.appLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.appLayout.Location = new System.Drawing.Point(0, 0);
            this.appLayout.Name = "appLayout";
            this.appLayout.RowCount = 1;
            this.appLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.appLayout.Size = new System.Drawing.Size(1182, 673);
            this.appLayout.TabIndex = 0;
            // 
            // queueLayout
            // 
            this.queueLayout.AutoScroll = true;
            this.queueLayout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.queueLayout.Controls.Add(this.queueHeaderLabel);
            this.queueLayout.Controls.Add(this.queueTable);
            this.queueLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queueLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.queueLayout.Location = new System.Drawing.Point(312, 3);
            this.queueLayout.Name = "queueLayout";
            this.queueLayout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.queueLayout.Size = new System.Drawing.Size(867, 667);
            this.queueLayout.TabIndex = 3;
            // 
            // queueHeaderLabel
            // 
            this.queueHeaderLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queueHeaderLabel.Location = new System.Drawing.Point(13, 10);
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
            this.queueTable.ColumnCount = 4;
            this.queueTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.queueTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.queueTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.queueTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.queueTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.queueTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.queueTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.queueTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.queueTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.queueTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.queueTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.queueTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.queueTable.Controls.Add(this.idLabel, 0, 0);
            this.queueTable.Controls.Add(this.nameLabel, 1, 0);
            this.queueTable.Controls.Add(this.resourcesLable, 2, 0);
            this.queueTable.Controls.Add(this.actionLabel, 3, 0);
            this.queueTable.Location = new System.Drawing.Point(13, 99);
            this.queueTable.Name = "queueTable";
            this.queueTable.RowCount = 1;
            this.queueTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.queueTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.queueTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.queueTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.queueTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.queueTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.queueTable.Size = new System.Drawing.Size(851, 52);
            this.queueTable.TabIndex = 2;
            // 
            // idLabel
            // 
            this.idLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idLabel.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(4, 1);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(53, 50);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.nameLabel.Location = new System.Drawing.Point(64, 1);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(188, 50);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Название";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resourcesLable
            // 
            this.resourcesLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourcesLable.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.resourcesLable.Location = new System.Drawing.Point(259, 1);
            this.resourcesLable.Name = "resourcesLable";
            this.resourcesLable.Size = new System.Drawing.Size(417, 50);
            this.resourcesLable.TabIndex = 2;
            this.resourcesLable.Text = "Ресуры";
            this.resourcesLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // actionLabel
            // 
            this.actionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionLabel.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.actionLabel.Location = new System.Drawing.Point(683, 1);
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(164, 50);
            this.actionLabel.TabIndex = 3;
            this.actionLabel.Text = "Действие";
            this.actionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuButtonLayout
            // 
            this.menuButtonLayout.AutoScroll = true;
            this.menuButtonLayout.AutoSize = true;
            this.menuButtonLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menuButtonLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.menuButtonLayout.Controls.Add(this.menuHeaderLabel);
            this.menuButtonLayout.Controls.Add(this.newRequestPageButton);
            this.menuButtonLayout.Controls.Add(this.queuePageButton);
            this.menuButtonLayout.Controls.Add(this.availableResourcesPageButton);
            this.menuButtonLayout.Controls.Add(this.addResourcesPageButton);
            this.menuButtonLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuButtonLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.menuButtonLayout.Location = new System.Drawing.Point(3, 3);
            this.menuButtonLayout.Name = "menuButtonLayout";
            this.menuButtonLayout.Size = new System.Drawing.Size(303, 667);
            this.menuButtonLayout.TabIndex = 1;
            this.menuButtonLayout.WrapContents = false;
            // 
            // menuHeaderLabel
            // 
            this.menuHeaderLabel.AutoSize = true;
            this.menuHeaderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuHeaderLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuHeaderLabel.Location = new System.Drawing.Point(3, 0);
            this.menuHeaderLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 40);
            this.menuHeaderLabel.Name = "menuHeaderLabel";
            this.menuHeaderLabel.Size = new System.Drawing.Size(163, 28);
            this.menuHeaderLabel.TabIndex = 0;
            this.menuHeaderLabel.Text = "Меню";
            this.menuHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newRequestPageButton
            // 
            this.newRequestPageButton.AutoSize = true;
            this.newRequestPageButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.newRequestPageButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.newRequestPageButton.FlatAppearance.BorderSize = 0;
            this.newRequestPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newRequestPageButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newRequestPageButton.Location = new System.Drawing.Point(3, 71);
            this.newRequestPageButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.newRequestPageButton.Name = "newRequestPageButton";
            this.newRequestPageButton.Size = new System.Drawing.Size(163, 64);
            this.newRequestPageButton.TabIndex = 1;
            this.newRequestPageButton.Text = "Добавить заявку";
            this.newRequestPageButton.UseVisualStyleBackColor = false;
            this.newRequestPageButton.Click += new System.EventHandler(this.newRequestPageButton_Click);
            // 
            // queuePageButton
            // 
            this.queuePageButton.BackColor = System.Drawing.Color.White;
            this.queuePageButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.queuePageButton.FlatAppearance.BorderSize = 0;
            this.queuePageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.queuePageButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queuePageButton.Location = new System.Drawing.Point(3, 158);
            this.queuePageButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.queuePageButton.Name = "queuePageButton";
            this.queuePageButton.Size = new System.Drawing.Size(163, 62);
            this.queuePageButton.TabIndex = 1;
            this.queuePageButton.Text = "Очередь";
            this.queuePageButton.UseVisualStyleBackColor = false;
            this.queuePageButton.Click += new System.EventHandler(this.queuePageButton_Click);
            // 
            // availableResourcesPageButton
            // 
            this.availableResourcesPageButton.BackColor = System.Drawing.Color.White;
            this.availableResourcesPageButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.availableResourcesPageButton.FlatAppearance.BorderSize = 0;
            this.availableResourcesPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.availableResourcesPageButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableResourcesPageButton.Location = new System.Drawing.Point(3, 243);
            this.availableResourcesPageButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.availableResourcesPageButton.Name = "availableResourcesPageButton";
            this.availableResourcesPageButton.Size = new System.Drawing.Size(163, 62);
            this.availableResourcesPageButton.TabIndex = 1;
            this.availableResourcesPageButton.Text = "Доступные ресуры";
            this.availableResourcesPageButton.UseVisualStyleBackColor = false;
            this.availableResourcesPageButton.Click += new System.EventHandler(this.availableResourcesPageButton_Click);
            // 
            // addResourcesPageButton
            // 
            this.addResourcesPageButton.BackColor = System.Drawing.Color.White;
            this.addResourcesPageButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addResourcesPageButton.FlatAppearance.BorderSize = 0;
            this.addResourcesPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addResourcesPageButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addResourcesPageButton.Location = new System.Drawing.Point(3, 328);
            this.addResourcesPageButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.addResourcesPageButton.Name = "addResourcesPageButton";
            this.addResourcesPageButton.Size = new System.Drawing.Size(163, 62);
            this.addResourcesPageButton.TabIndex = 1;
            this.addResourcesPageButton.Text = "Закуп";
            this.addResourcesPageButton.UseVisualStyleBackColor = false;
            this.addResourcesPageButton.Click += new System.EventHandler(this.addResourcesPageButton_Click);
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
            // createRequestLayout
            // 
            this.createRequestLayout.AutoScroll = true;
            this.createRequestLayout.Controls.Add(this.createRequestHeaderLabel);
            this.createRequestLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createRequestLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.createRequestLayout.Location = new System.Drawing.Point(305, 3);
            this.createRequestLayout.Name = "createRequestLayout";
            this.createRequestLayout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.createRequestLayout.Size = new System.Drawing.Size(850, 667);
            this.createRequestLayout.TabIndex = 2;
            // 
            // createRequestHeaderLabel
            // 
            this.createRequestHeaderLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createRequestHeaderLabel.Location = new System.Drawing.Point(13, 0);
            this.createRequestHeaderLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 40);
            this.createRequestHeaderLabel.Name = "createRequestHeaderLabel";
            this.createRequestHeaderLabel.Size = new System.Drawing.Size(302, 46);
            this.createRequestHeaderLabel.TabIndex = 1;
            this.createRequestHeaderLabel.Text = "Добавить заявку";
            this.createRequestHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(605, 88);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1182, 673);
            this.Controls.Add(this.appLayout);
            this.Location = new System.Drawing.Point(15, 15);
            this.MinimumSize = new System.Drawing.Size(1200, 720);
            this.Name = "Form1";
            this.appLayout.ResumeLayout(false);
            this.appLayout.PerformLayout();
            this.queueLayout.ResumeLayout(false);
            this.queueLayout.PerformLayout();
            this.queueTable.ResumeLayout(false);
            this.menuButtonLayout.ResumeLayout(false);
            this.menuButtonLayout.PerformLayout();
            this.addResourceLayout.ResumeLayout(false);
            this.availableResourceLayout.ResumeLayout(false);
            this.createRequestLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button addResourcesPageButton;
        private System.Windows.Forms.Button availableResourcesPageButton;
        private System.Windows.Forms.Button queuePageButton;
        private System.Windows.Forms.Button newRequestPageButton;
        private System.Windows.Forms.Label menuHeaderLabel;
        private System.Windows.Forms.FlowLayoutPanel menuButtonLayout;

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

        private System.Windows.Forms.FlowLayoutPanel createRequestLayout;

        private System.Windows.Forms.Label createRequestHeaderLabel;

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

        private System.Windows.Forms.TableLayoutPanel appLayout;

        #endregion
    }
}

