using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QuarantineWizard.ItemComponents.RepositoryClassComponet
{
    public partial class FormRepositoryClassComponet : MetroForm
    {
        public FormRepositoryClassComponet()
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
        }

        public string RootDir { get; set; }
        public string StrRepositoryClassName
        {
            get => tbRepositoryClassName.Text;
            set => tbRepositoryClassName.Text = value;
        }
        public string StrRepositoryInterfaceName
        {
            get => txbRepositoryInterfaceName.Text;
            set => txbRepositoryInterfaceName.Text = value;
        }
        #region BaseRepository
        private Dictionary<string, DirectoryInfo> BaseRepositoryProject { get; set; } = new Dictionary<string, DirectoryInfo>();
        public string StrBaseRepositoryProjectName
        {
            get => cmbBaseRepositoryProject.SelectedItem.ToString();
            set
            {
                cmbBaseRepositoryProject.Items.Clear();
                foreach (var item in GetProjectList(value))
                {
                    BaseRepositoryProject.Add(Path.GetFileNameWithoutExtension(item.Name), item.Directory);
                    cmbBaseRepositoryProject.Items.Add(Path.GetFileNameWithoutExtension(item.Name));
                }
                cmbBaseRepositoryProject.SelectedItem = value;
            }
        }
        private Dictionary<string, string> BaseRepositoryClassList { get; set; } = new Dictionary<string, string>();
        private void cmbBaseRepositoryProject_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cmbBaseRepositoryProject.SelectedItem != null)
            {
                cmbBaseRepositoryClass.Items.Clear();
                var selectedItem = EntityClassProject.Where(c => c.Key == cmbBaseRepositoryProject.SelectedItem.ToString()).FirstOrDefault();
                var files = new DirectoryInfo(selectedItem.Value.FullName).GetFiles("*.cs", SearchOption.AllDirectories);
                foreach (var item in files)
                {
                    if (!item.DirectoryName.Contains("obj") && !item.DirectoryName.Contains("bin"))
                    {
                        var fileNamespace = selectedItem.Value.Name;
                        if (fileNamespace != item.Directory.Name)
                        {
                            fileNamespace = $"{fileNamespace}.{item.Directory.Name}";
                        }
                        BaseRepositoryClassList.Add(Path.GetFileNameWithoutExtension(item.Name), fileNamespace);
                        cmbBaseRepositoryClass.Items.Add(Path.GetFileNameWithoutExtension(item.Name));
                    }
                }
            }
        }
        public string StrBaseRepositoryClass { get; set; }
        public string StrBaseRepositoryNamespace { get; set; }
        private void cmbBaseRepositoryClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBaseRepositoryClass.SelectedItem != null)
            {
                var selectedItem = BaseRepositoryClassList.Where(c => c.Key == cmbBaseRepositoryClass.SelectedItem.ToString()).FirstOrDefault();
                StrBaseRepositoryClass = selectedItem.Key;
                StrBaseRepositoryNamespace = selectedItem.Value;
            }
        }
        #endregion

        #region Entity
        private Dictionary<string, DirectoryInfo> EntityClassProject { get; set; } = new Dictionary<string, DirectoryInfo>();
        public string StrEntityClassProject
        {
            get => cmbEntityClassProject.SelectedItem.ToString();
            set
            {
                cmbEntityClassProject.Items.Clear();
                foreach (var item in GetProjectList(value))
                {
                    EntityClassProject.Add(Path.GetFileNameWithoutExtension(item.Name), item.Directory);
                    cmbEntityClassProject.Items.Add(Path.GetFileNameWithoutExtension(item.Name));
                }
                cmbEntityClassProject.SelectedItem = value;
            }
        }
        private Dictionary<string, string> EntityClassList { get; set; } = new Dictionary<string, string>();
        private void cmbEntityClassProject_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cmbEntityClassProject.SelectedItem != null)
            {
                cmbEntityClassName.Items.Clear();
                var selectedItem = EntityClassProject.Where(c => c.Key == cmbEntityClassProject.SelectedItem.ToString()).FirstOrDefault();
                var files = new DirectoryInfo(selectedItem.Value.FullName).GetFiles("*.cs", SearchOption.AllDirectories);
                foreach (var item in files)
                {
                    if (!item.DirectoryName.Contains("obj") && !item.DirectoryName.Contains("bin"))
                    {
                        var fileNamespace = selectedItem.Value.Name;
                        if (fileNamespace != item.Directory.Name)
                        {
                            fileNamespace = $"{fileNamespace}.{item.Directory.Name}";
                        }
                        EntityClassList.Add(Path.GetFileNameWithoutExtension(item.Name), fileNamespace);
                        cmbEntityClassName.Items.Add(Path.GetFileNameWithoutExtension(item.Name));
                    }
                }
            }
        }
        public string StrEntityClass { get; set; }
        public string StrEntityNamespace { get; set; }
        private void cmbEntityClassName_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cmbEntityClassName.SelectedItem != null)
            {
                var selectedItem = EntityClassList.Where(c => c.Key == cmbEntityClassName.SelectedItem.ToString()).FirstOrDefault();
                StrEntityClass = selectedItem.Key;
                StrEntityNamespace = selectedItem.Value;
            }
        }
        #endregion

        #region DbContext
        private Dictionary<string, DirectoryInfo> DbContextProject { get; set; } = new Dictionary<string, DirectoryInfo>();
        public string StrDbContextProject
        {
            get => cmbDbContextProject.SelectedItem.ToString();
            set
            {
                cmbDbContextProject.Items.Clear();
                foreach (var item in GetProjectList(value))
                {
                    DbContextProject.Add(Path.GetFileNameWithoutExtension(item.Name), item.Directory);
                    cmbDbContextProject.Items.Add(Path.GetFileNameWithoutExtension(item.Name));
                }
                cmbDbContextProject.SelectedItem = value;
            }
        }
        private Dictionary<string, string> DbContextClassList { get; set; } = new Dictionary<string, string>();
        private void cmbDbContextProject_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cmbDbContextProject.SelectedItem != null)
            {
                cmbDbContextClassName.Items.Clear();
                var selectedItem = DbContextProject.Where(c => c.Key == cmbDbContextProject.SelectedItem.ToString()).FirstOrDefault();
                var files = new DirectoryInfo(selectedItem.Value.FullName).GetFiles("*.cs", SearchOption.AllDirectories);
                foreach (var item in files)
                {
                    if (!item.DirectoryName.Contains("obj") && !item.DirectoryName.Contains("bin"))
                    {
                        var fileNamespace = selectedItem.Value.Name;
                        if (fileNamespace != item.Directory.Name)
                        {
                            fileNamespace = $"{fileNamespace}.{item.Directory.Name}";
                        }
                        DbContextClassList.Add(Path.GetFileNameWithoutExtension(item.Name), fileNamespace);
                        cmbDbContextClassName.Items.Add(Path.GetFileNameWithoutExtension(item.Name));
                    }
                }
            }
        }
        public string StrDbContextClass { get; set; }
        public string StrDbContextNamespace { get; set; }
        private void cmbDbContextClassName_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cmbDbContextClassName.SelectedItem != null)
            {
                var selectedItem = DbContextClassList.Where(c => c.Key == cmbDbContextClassName.SelectedItem.ToString()).FirstOrDefault();
                StrDbContextClass = selectedItem.Key;
                StrDbContextNamespace = selectedItem.Value;
            }
        }
        #endregion
        public string StrFormTitle
        {
            set => this.Text = value;
        }
        private IEnumerable<FileInfo> GetProjectList(string root)
        {
            var directoryInfos = new DirectoryInfo(root).GetDirectories().Where(x => (x.Attributes & FileAttributes.Hidden) == 0);

            var list = new List<FileInfo>();

            foreach (var directoryInfo in directoryInfos)
            {
                var projects = new DirectoryInfo(directoryInfo.FullName).GetFiles("*.csproj", SearchOption.AllDirectories);
                list = projects.ToList();
            }

            return list;
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

        private void tbRepositoryClassName_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(tbRepositoryClassName.Text))
            {
                txbRepositoryInterfaceName.Text = $"I{tbRepositoryClassName.Text}";
            }
            if (tbRepositoryClassName.Text.Length <= 0)
            {
                txbRepositoryInterfaceName.Text = string.Empty;
            }
        }
    }
}
