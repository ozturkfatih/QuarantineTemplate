namespace QuarantineWizard.ItemComponents.RepositoryClassComponet
{
    partial class FormRepositoryClassComponet
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
            this.lblRepositoryInterface = new MetroFramework.Controls.MetroLabel();
            this.lblRepositoryClass = new MetroFramework.Controls.MetroLabel();
            this.lblBaseRepositoryClass = new MetroFramework.Controls.MetroLabel();
            this.lblBaseRepositoryProject = new MetroFramework.Controls.MetroLabel();
            this.lblDbContextClass = new MetroFramework.Controls.MetroLabel();
            this.lblDbContextProject = new MetroFramework.Controls.MetroLabel();
            this.lblEntityName = new MetroFramework.Controls.MetroLabel();
            this.lblEntityProject = new MetroFramework.Controls.MetroLabel();
            this.cmbEntityClassName = new MetroFramework.Controls.MetroComboBox();
            this.cmbDbContextProject = new MetroFramework.Controls.MetroComboBox();
            this.cmbBaseRepositoryProject = new MetroFramework.Controls.MetroComboBox();
            this.cmbBaseRepositoryClass = new MetroFramework.Controls.MetroComboBox();
            this.cmbDbContextClassName = new MetroFramework.Controls.MetroComboBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.cmbEntityClassProject = new MetroFramework.Controls.MetroComboBox();
            this.txbRepositoryInterfaceName = new MetroFramework.Controls.MetroTextBox();
            this.tbRepositoryClassName = new MetroFramework.Controls.MetroTextBox();
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
            this.tabEntityClass.Size = new System.Drawing.Size(445, 351);
            this.tabEntityClass.TabIndex = 0;
            this.tabEntityClass.UseSelectable = true;
            // 
            // tabEntityPage
            // 
            this.tabEntityPage.Controls.Add(this.lblRepositoryInterface);
            this.tabEntityPage.Controls.Add(this.lblRepositoryClass);
            this.tabEntityPage.Controls.Add(this.lblBaseRepositoryClass);
            this.tabEntityPage.Controls.Add(this.lblBaseRepositoryProject);
            this.tabEntityPage.Controls.Add(this.lblDbContextClass);
            this.tabEntityPage.Controls.Add(this.lblDbContextProject);
            this.tabEntityPage.Controls.Add(this.lblEntityName);
            this.tabEntityPage.Controls.Add(this.lblEntityProject);
            this.tabEntityPage.Controls.Add(this.cmbEntityClassName);
            this.tabEntityPage.Controls.Add(this.cmbDbContextProject);
            this.tabEntityPage.Controls.Add(this.cmbBaseRepositoryProject);
            this.tabEntityPage.Controls.Add(this.cmbBaseRepositoryClass);
            this.tabEntityPage.Controls.Add(this.cmbDbContextClassName);
            this.tabEntityPage.Controls.Add(this.btnAdd);
            this.tabEntityPage.Controls.Add(this.btnCancel);
            this.tabEntityPage.Controls.Add(this.cmbEntityClassProject);
            this.tabEntityPage.Controls.Add(this.txbRepositoryInterfaceName);
            this.tabEntityPage.Controls.Add(this.tbRepositoryClassName);
            this.tabEntityPage.HorizontalScrollbarBarColor = true;
            this.tabEntityPage.HorizontalScrollbarHighlightOnWheel = false;
            this.tabEntityPage.HorizontalScrollbarSize = 10;
            this.tabEntityPage.Location = new System.Drawing.Point(4, 38);
            this.tabEntityPage.Name = "tabEntityPage";
            this.tabEntityPage.Size = new System.Drawing.Size(437, 309);
            this.tabEntityPage.TabIndex = 0;
            this.tabEntityPage.Text = "Entity Class";
            this.tabEntityPage.VerticalScrollbarBarColor = true;
            this.tabEntityPage.VerticalScrollbarHighlightOnWheel = false;
            this.tabEntityPage.VerticalScrollbarSize = 10;
            // 
            // lblRepositoryInterface
            // 
            this.lblRepositoryInterface.AutoSize = true;
            this.lblRepositoryInterface.Location = new System.Drawing.Point(12, 243);
            this.lblRepositoryInterface.Name = "lblRepositoryInterface";
            this.lblRepositoryInterface.Size = new System.Drawing.Size(116, 19);
            this.lblRepositoryInterface.TabIndex = 22;
            this.lblRepositoryInterface.Text = "IRepositoy Name :";
            this.lblRepositoryInterface.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRepositoryClass
            // 
            this.lblRepositoryClass.AutoSize = true;
            this.lblRepositoryClass.Location = new System.Drawing.Point(13, 213);
            this.lblRepositoryClass.Name = "lblRepositoryClass";
            this.lblRepositoryClass.Size = new System.Drawing.Size(115, 19);
            this.lblRepositoryClass.TabIndex = 21;
            this.lblRepositoryClass.Text = "Repository Name:";
            this.lblRepositoryClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBaseRepositoryClass
            // 
            this.lblBaseRepositoryClass.AutoSize = true;
            this.lblBaseRepositoryClass.Location = new System.Drawing.Point(10, 178);
            this.lblBaseRepositoryClass.Name = "lblBaseRepositoryClass";
            this.lblBaseRepositoryClass.Size = new System.Drawing.Size(118, 19);
            this.lblBaseRepositoryClass.TabIndex = 20;
            this.lblBaseRepositoryClass.Text = "Base Repo Name :";
            this.lblBaseRepositoryClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBaseRepositoryProject
            // 
            this.lblBaseRepositoryProject.AutoSize = true;
            this.lblBaseRepositoryProject.Location = new System.Drawing.Point(5, 143);
            this.lblBaseRepositoryProject.Name = "lblBaseRepositoryProject";
            this.lblBaseRepositoryProject.Size = new System.Drawing.Size(123, 19);
            this.lblBaseRepositoryProject.TabIndex = 19;
            this.lblBaseRepositoryProject.Text = "Base Repo Project :";
            this.lblBaseRepositoryProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDbContextClass
            // 
            this.lblDbContextClass.AutoSize = true;
            this.lblDbContextClass.Location = new System.Drawing.Point(46, 108);
            this.lblDbContextClass.Name = "lblDbContextClass";
            this.lblDbContextClass.Size = new System.Drawing.Size(78, 19);
            this.lblDbContextClass.TabIndex = 18;
            this.lblDbContextClass.Text = "DbContext :";
            this.lblDbContextClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDbContextProject
            // 
            this.lblDbContextProject.AutoSize = true;
            this.lblDbContextProject.Location = new System.Drawing.Point(5, 73);
            this.lblDbContextProject.Name = "lblDbContextProject";
            this.lblDbContextProject.Size = new System.Drawing.Size(123, 19);
            this.lblDbContextProject.TabIndex = 17;
            this.lblDbContextProject.Text = "DbContext Project :";
            this.lblDbContextProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEntityName
            // 
            this.lblEntityName.AutoSize = true;
            this.lblEntityName.Location = new System.Drawing.Point(41, 38);
            this.lblEntityName.Name = "lblEntityName";
            this.lblEntityName.Size = new System.Drawing.Size(87, 19);
            this.lblEntityName.TabIndex = 16;
            this.lblEntityName.Text = "Entity Name :";
            this.lblEntityName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEntityProject
            // 
            this.lblEntityProject.AutoSize = true;
            this.lblEntityProject.Location = new System.Drawing.Point(37, 3);
            this.lblEntityProject.Name = "lblEntityProject";
            this.lblEntityProject.Size = new System.Drawing.Size(92, 19);
            this.lblEntityProject.TabIndex = 15;
            this.lblEntityProject.Text = "Entity Project :";
            this.lblEntityProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbEntityClassName
            // 
            this.cmbEntityClassName.FormattingEnabled = true;
            this.cmbEntityClassName.ItemHeight = 23;
            this.cmbEntityClassName.Location = new System.Drawing.Point(134, 38);
            this.cmbEntityClassName.Name = "cmbEntityClassName";
            this.cmbEntityClassName.Size = new System.Drawing.Size(300, 29);
            this.cmbEntityClassName.TabIndex = 14;
            this.cmbEntityClassName.UseSelectable = true;
            this.cmbEntityClassName.SelectedIndexChanged += new System.EventHandler(this.cmbEntityClassName_SelectedIndexChanged);
            // 
            // cmbDbContextProject
            // 
            this.cmbDbContextProject.FormattingEnabled = true;
            this.cmbDbContextProject.ItemHeight = 23;
            this.cmbDbContextProject.Location = new System.Drawing.Point(134, 73);
            this.cmbDbContextProject.Name = "cmbDbContextProject";
            this.cmbDbContextProject.Size = new System.Drawing.Size(300, 29);
            this.cmbDbContextProject.TabIndex = 13;
            this.cmbDbContextProject.UseSelectable = true;
            this.cmbDbContextProject.SelectedIndexChanged += new System.EventHandler(this.cmbDbContextProject_SelectedIndexChanged);
            // 
            // cmbBaseRepositoryProject
            // 
            this.cmbBaseRepositoryProject.FormattingEnabled = true;
            this.cmbBaseRepositoryProject.ItemHeight = 23;
            this.cmbBaseRepositoryProject.Location = new System.Drawing.Point(134, 143);
            this.cmbBaseRepositoryProject.Name = "cmbBaseRepositoryProject";
            this.cmbBaseRepositoryProject.Size = new System.Drawing.Size(300, 29);
            this.cmbBaseRepositoryProject.TabIndex = 12;
            this.cmbBaseRepositoryProject.UseSelectable = true;
            this.cmbBaseRepositoryProject.SelectedIndexChanged += new System.EventHandler(this.cmbBaseRepositoryProject_SelectedIndexChanged);
            // 
            // cmbBaseRepositoryClass
            // 
            this.cmbBaseRepositoryClass.FormattingEnabled = true;
            this.cmbBaseRepositoryClass.ItemHeight = 23;
            this.cmbBaseRepositoryClass.Location = new System.Drawing.Point(134, 178);
            this.cmbBaseRepositoryClass.Name = "cmbBaseRepositoryClass";
            this.cmbBaseRepositoryClass.Size = new System.Drawing.Size(300, 29);
            this.cmbBaseRepositoryClass.TabIndex = 11;
            this.cmbBaseRepositoryClass.UseSelectable = true;
            this.cmbBaseRepositoryClass.SelectedIndexChanged += new System.EventHandler(this.cmbBaseRepositoryClass_SelectedIndexChanged);
            // 
            // cmbDbContextClassName
            // 
            this.cmbDbContextClassName.FormattingEnabled = true;
            this.cmbDbContextClassName.ItemHeight = 23;
            this.cmbDbContextClassName.Location = new System.Drawing.Point(134, 108);
            this.cmbDbContextClassName.Name = "cmbDbContextClassName";
            this.cmbDbContextClassName.Size = new System.Drawing.Size(300, 29);
            this.cmbDbContextClassName.TabIndex = 10;
            this.cmbDbContextClassName.UseSelectable = true;
            this.cmbDbContextClassName.SelectedIndexChanged += new System.EventHandler(this.cmbDbContextClassName_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Highlight = true;
            this.btnAdd.Location = new System.Drawing.Point(309, 282);
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
            this.btnCancel.Location = new System.Drawing.Point(375, 282);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 24);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbEntityClassProject
            // 
            this.cmbEntityClassProject.FormattingEnabled = true;
            this.cmbEntityClassProject.ItemHeight = 23;
            this.cmbEntityClassProject.Location = new System.Drawing.Point(135, 3);
            this.cmbEntityClassProject.Name = "cmbEntityClassProject";
            this.cmbEntityClassProject.Size = new System.Drawing.Size(300, 29);
            this.cmbEntityClassProject.TabIndex = 7;
            this.cmbEntityClassProject.UseSelectable = true;
            this.cmbEntityClassProject.SelectedIndexChanged += new System.EventHandler(this.cmbEntityClassProject_SelectedIndexChanged);
            // 
            // txbRepositoryInterfaceName
            // 
            // 
            // 
            // 
            this.txbRepositoryInterfaceName.CustomButton.Image = null;
            this.txbRepositoryInterfaceName.CustomButton.Location = new System.Drawing.Point(278, 2);
            this.txbRepositoryInterfaceName.CustomButton.Name = "";
            this.txbRepositoryInterfaceName.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txbRepositoryInterfaceName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbRepositoryInterfaceName.CustomButton.TabIndex = 1;
            this.txbRepositoryInterfaceName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbRepositoryInterfaceName.CustomButton.UseSelectable = true;
            this.txbRepositoryInterfaceName.CustomButton.Visible = false;
            this.txbRepositoryInterfaceName.Lines = new string[0];
            this.txbRepositoryInterfaceName.Location = new System.Drawing.Point(134, 243);
            this.txbRepositoryInterfaceName.MaxLength = 32767;
            this.txbRepositoryInterfaceName.Name = "txbRepositoryInterfaceName";
            this.txbRepositoryInterfaceName.PasswordChar = '\0';
            this.txbRepositoryInterfaceName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbRepositoryInterfaceName.SelectedText = "";
            this.txbRepositoryInterfaceName.SelectionLength = 0;
            this.txbRepositoryInterfaceName.SelectionStart = 0;
            this.txbRepositoryInterfaceName.ShortcutsEnabled = true;
            this.txbRepositoryInterfaceName.Size = new System.Drawing.Size(300, 24);
            this.txbRepositoryInterfaceName.TabIndex = 5;
            this.txbRepositoryInterfaceName.UseSelectable = true;
            this.txbRepositoryInterfaceName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbRepositoryInterfaceName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbRepositoryClassName
            // 
            // 
            // 
            // 
            this.tbRepositoryClassName.CustomButton.Image = null;
            this.tbRepositoryClassName.CustomButton.Location = new System.Drawing.Point(278, 2);
            this.tbRepositoryClassName.CustomButton.Name = "";
            this.tbRepositoryClassName.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tbRepositoryClassName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbRepositoryClassName.CustomButton.TabIndex = 1;
            this.tbRepositoryClassName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbRepositoryClassName.CustomButton.UseSelectable = true;
            this.tbRepositoryClassName.CustomButton.Visible = false;
            this.tbRepositoryClassName.DisplayIcon = true;
            this.tbRepositoryClassName.Lines = new string[0];
            this.tbRepositoryClassName.Location = new System.Drawing.Point(134, 213);
            this.tbRepositoryClassName.MaxLength = 32767;
            this.tbRepositoryClassName.Name = "tbRepositoryClassName";
            this.tbRepositoryClassName.PasswordChar = '\0';
            this.tbRepositoryClassName.ReadOnly = true;
            this.tbRepositoryClassName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbRepositoryClassName.SelectedText = "";
            this.tbRepositoryClassName.SelectionLength = 0;
            this.tbRepositoryClassName.SelectionStart = 0;
            this.tbRepositoryClassName.ShortcutsEnabled = true;
            this.tbRepositoryClassName.Size = new System.Drawing.Size(300, 24);
            this.tbRepositoryClassName.TabIndex = 3;
            this.tbRepositoryClassName.UseSelectable = true;
            this.tbRepositoryClassName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbRepositoryClassName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbRepositoryClassName.TextChanged += new System.EventHandler(this.tbRepositoryClassName_TextChanged);
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            this.metroStyleManager.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // FormRepositoryClassComponet
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImagePadding = new System.Windows.Forms.Padding(210, 20, 0, 0);
            this.BackMaxSize = 36;
            this.ClientSize = new System.Drawing.Size(485, 431);
            this.Controls.Add(this.tabEntityClass);
            this.Name = "FormRepositoryClassComponet";
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
        private MetroFramework.Controls.MetroComboBox cmbEntityClassProject;
        private MetroFramework.Controls.MetroTextBox txbRepositoryInterfaceName;
        private MetroFramework.Controls.MetroTextBox tbRepositoryClassName;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroComboBox cmbEntityClassName;
        private MetroFramework.Controls.MetroComboBox cmbDbContextProject;
        private MetroFramework.Controls.MetroComboBox cmbBaseRepositoryProject;
        private MetroFramework.Controls.MetroComboBox cmbBaseRepositoryClass;
        private MetroFramework.Controls.MetroComboBox cmbDbContextClassName;
        private MetroFramework.Controls.MetroLabel lblRepositoryInterface;
        private MetroFramework.Controls.MetroLabel lblRepositoryClass;
        private MetroFramework.Controls.MetroLabel lblBaseRepositoryClass;
        private MetroFramework.Controls.MetroLabel lblBaseRepositoryProject;
        private MetroFramework.Controls.MetroLabel lblDbContextClass;
        private MetroFramework.Controls.MetroLabel lblDbContextProject;
        private MetroFramework.Controls.MetroLabel lblEntityName;
        private MetroFramework.Controls.MetroLabel lblEntityProject;
    }
}