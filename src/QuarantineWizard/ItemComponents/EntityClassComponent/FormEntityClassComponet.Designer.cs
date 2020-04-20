namespace QuarantineWizard.ItemComponents.EntityClassComponent
{
    partial class FormEntityClassComponet
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
            this.components = new System.ComponentModel.Container();
            this.tabEntityClass = new MetroFramework.Controls.MetroTabControl();
            this.tabEntityPage = new MetroFramework.Controls.MetroTabPage();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.cmbDataType = new MetroFramework.Controls.MetroComboBox();
            this.lblDataType = new MetroFramework.Controls.MetroLabel();
            this.txbSchemaName = new MetroFramework.Controls.MetroTextBox();
            this.lblSchemaName = new MetroFramework.Controls.MetroLabel();
            this.txbEntityName = new MetroFramework.Controls.MetroTextBox();
            this.lblEntityName = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tabEntityClass.SuspendLayout();
            this.tabEntityPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // tabEntityClass
            // 
            this.tabEntityClass.Controls.Add(this.tabEntityPage);
            this.tabEntityClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabEntityClass.Location = new System.Drawing.Point(20, 60);
            this.tabEntityClass.Name = "tabEntityClass";
            this.tabEntityClass.SelectedIndex = 0;
            this.tabEntityClass.Size = new System.Drawing.Size(445, 280);
            this.tabEntityClass.TabIndex = 0;
            this.tabEntityClass.UseSelectable = true;
            // 
            // tabEntityPage
            // 
            this.tabEntityPage.Controls.Add(this.btnAdd);
            this.tabEntityPage.Controls.Add(this.btnCancel);
            this.tabEntityPage.Controls.Add(this.cmbDataType);
            this.tabEntityPage.Controls.Add(this.lblDataType);
            this.tabEntityPage.Controls.Add(this.txbSchemaName);
            this.tabEntityPage.Controls.Add(this.lblSchemaName);
            this.tabEntityPage.Controls.Add(this.txbEntityName);
            this.tabEntityPage.Controls.Add(this.lblEntityName);
            this.tabEntityPage.HorizontalScrollbarBarColor = true;
            this.tabEntityPage.HorizontalScrollbarHighlightOnWheel = false;
            this.tabEntityPage.HorizontalScrollbarSize = 10;
            this.tabEntityPage.Location = new System.Drawing.Point(4, 38);
            this.tabEntityPage.Name = "tabEntityPage";
            this.tabEntityPage.Size = new System.Drawing.Size(437, 238);
            this.tabEntityPage.TabIndex = 0;
            this.tabEntityPage.Text = "Entity Class";
            this.tabEntityPage.VerticalScrollbarBarColor = true;
            this.tabEntityPage.VerticalScrollbarHighlightOnWheel = false;
            this.tabEntityPage.VerticalScrollbarSize = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Highlight = true;
            this.btnAdd.Location = new System.Drawing.Point(309, 211);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 24);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Highlight = true;
            this.btnCancel.Location = new System.Drawing.Point(375, 211);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 24);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbDataType
            // 
            this.cmbDataType.FormattingEnabled = true;
            this.cmbDataType.ItemHeight = 23;
            this.cmbDataType.Location = new System.Drawing.Point(135, 74);
            this.cmbDataType.Name = "cmbDataType";
            this.cmbDataType.Size = new System.Drawing.Size(300, 29);
            this.cmbDataType.TabIndex = 7;
            this.cmbDataType.UseSelectable = true;
            // 
            // lblDataType
            // 
            this.lblDataType.AutoSize = true;
            this.lblDataType.Location = new System.Drawing.Point(55, 74);
            this.lblDataType.Name = "lblDataType";
            this.lblDataType.Size = new System.Drawing.Size(74, 19);
            this.lblDataType.TabIndex = 6;
            this.lblDataType.Text = "Data Type :";
            // 
            // txbSchemaName
            // 
            // 
            // 
            // 
            this.txbSchemaName.CustomButton.Image = null;
            this.txbSchemaName.CustomButton.Location = new System.Drawing.Point(278, 2);
            this.txbSchemaName.CustomButton.Name = "";
            this.txbSchemaName.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txbSchemaName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbSchemaName.CustomButton.TabIndex = 1;
            this.txbSchemaName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbSchemaName.CustomButton.UseSelectable = true;
            this.txbSchemaName.CustomButton.Visible = false;
            this.txbSchemaName.Lines = new string[0];
            this.txbSchemaName.Location = new System.Drawing.Point(135, 44);
            this.txbSchemaName.MaxLength = 32767;
            this.txbSchemaName.Name = "txbSchemaName";
            this.txbSchemaName.PasswordChar = '\0';
            this.txbSchemaName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbSchemaName.SelectedText = "";
            this.txbSchemaName.SelectionLength = 0;
            this.txbSchemaName.SelectionStart = 0;
            this.txbSchemaName.ShortcutsEnabled = true;
            this.txbSchemaName.Size = new System.Drawing.Size(300, 24);
            this.txbSchemaName.TabIndex = 5;
            this.txbSchemaName.UseSelectable = true;
            this.txbSchemaName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbSchemaName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblSchemaName
            // 
            this.lblSchemaName.AutoSize = true;
            this.lblSchemaName.Location = new System.Drawing.Point(27, 44);
            this.lblSchemaName.Name = "lblSchemaName";
            this.lblSchemaName.Size = new System.Drawing.Size(102, 19);
            this.lblSchemaName.TabIndex = 4;
            this.lblSchemaName.Text = "Schema Name :";
            // 
            // txbEntityName
            // 
            // 
            // 
            // 
            this.txbEntityName.CustomButton.Image = null;
            this.txbEntityName.CustomButton.Location = new System.Drawing.Point(278, 2);
            this.txbEntityName.CustomButton.Name = "";
            this.txbEntityName.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txbEntityName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbEntityName.CustomButton.TabIndex = 1;
            this.txbEntityName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbEntityName.CustomButton.UseSelectable = true;
            this.txbEntityName.CustomButton.Visible = false;
            this.txbEntityName.DisplayIcon = true;
            this.txbEntityName.Lines = new string[0];
            this.txbEntityName.Location = new System.Drawing.Point(135, 14);
            this.txbEntityName.MaxLength = 32767;
            this.txbEntityName.Name = "txbEntityName";
            this.txbEntityName.PasswordChar = '\0';
            this.txbEntityName.ReadOnly = true;
            this.txbEntityName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbEntityName.SelectedText = "";
            this.txbEntityName.SelectionLength = 0;
            this.txbEntityName.SelectionStart = 0;
            this.txbEntityName.ShortcutsEnabled = true;
            this.txbEntityName.Size = new System.Drawing.Size(300, 24);
            this.txbEntityName.TabIndex = 3;
            this.txbEntityName.UseSelectable = true;
            this.txbEntityName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbEntityName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblEntityName
            // 
            this.lblEntityName.AutoSize = true;
            this.lblEntityName.Location = new System.Drawing.Point(42, 14);
            this.lblEntityName.Name = "lblEntityName";
            this.lblEntityName.Size = new System.Drawing.Size(87, 19);
            this.lblEntityName.TabIndex = 2;
            this.lblEntityName.Text = "Entity Name :";
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            this.metroStyleManager.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // FormEntityClassComponet
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImagePadding = new System.Windows.Forms.Padding(210, 20, 0, 0);
            this.BackMaxSize = 36;
            this.ClientSize = new System.Drawing.Size(485, 360);
            this.Controls.Add(this.tabEntityClass);
            this.Name = "FormEntityClassComponet";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Entity item template";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabEntityClass.ResumeLayout(false);
            this.tabEntityPage.ResumeLayout(false);
            this.tabEntityPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabEntityClass;
        private MetroFramework.Controls.MetroTabPage tabEntityPage;
        private MetroFramework.Controls.MetroComboBox cmbDataType;
        private MetroFramework.Controls.MetroLabel lblDataType;
        private MetroFramework.Controls.MetroTextBox txbSchemaName;
        private MetroFramework.Controls.MetroLabel lblSchemaName;
        private MetroFramework.Controls.MetroTextBox txbEntityName;
        private MetroFramework.Controls.MetroLabel lblEntityName;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnAdd;
    }
}