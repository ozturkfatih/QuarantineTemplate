using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuarantineWizard.ItemComponents.EntityClassComponent
{
    public partial class FormEntityClassComponet : MetroForm
    {
        public FormEntityClassComponet()
        {
            this.BorderStyle = MetroFormBorderStyle.FixedSingle;
            this.ShadowType = MetroFormShadowType.AeroShadow;
            InitializeComponent();
            FormInitialize();
        }
        private void FormInitialize()
        {
            metroStyleManager.Theme = MetroThemeStyle.Dark;
            metroStyleManager.Style = MetroColorStyle.Purple;
            cmbDataType.Items.Add("byte");
            cmbDataType.Items.Add("short");
            cmbDataType.Items.Add("int");
            cmbDataType.Items.Add("long");
            cmbDataType.Items.Add("char");
            cmbDataType.Items.Add("string");
            cmbDataType.Items.Add("object");
            cmbDataType.Items.Add("Guid");
        }

        public string StrEntityClassName
        {
            get => txbEntityName.Text;
            set => txbEntityName.Text = value;
        }
        public string StrEntitySchemaName
        {
            get => txbSchemaName.Text;
            set => txbSchemaName.Text = value;
        }
        public string StrEntityIdTypeName
        {
            get => cmbDataType.SelectedItem.ToString();
            set => cmbDataType.SelectedItem = value;
        }
        public string StrFormTitle
        {
            set => this.Text = value;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var confirmResult = MetroMessageBox.Show(this, "Are you sure to close this form ?", "Confirm Cancel!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, 120);
            if (confirmResult == DialogResult.Yes)
            {
                DialogResult = DialogResult.Yes;
                Close();
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            var confirmResult = MetroMessageBox.Show(this, "Are you sure to close this form ?", "Confirm Save!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, 120);
            if (confirmResult == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
