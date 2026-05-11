using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rgyt2._0.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            using var form = new SettingsForm(
                Program.Config.Settings.Database.DbfFolder
            );

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                Program.Config.Settings.Database.DbfFolder =
                    form.SelectedDbfFolder;

                Program.Config.Save();

                Program.DbfContext = new DbfContext(
                    Program.Config.Settings.Database.DbfFolder
                );
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            userManagementBtn.Visible =
                Program.CurrentUser != null &&
                Program.CurrentUser.IsAdmin;
        }

        private void LoadContentForm(Form form)
        {
            if (_currentContentForm != null)
            {
                _currentContentForm.Close();
                _currentContentForm.Dispose();
            }

            _currentContentForm = form;

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.None;
            form.AutoSize = true;
            form.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(form);
            form.Show();
        }

        private void queryBtn_Click(object sender, EventArgs e)
        {
            LoadContentForm(new QueryForm());
        }

        private void menüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userManagementBtn_Click(object sender, EventArgs e)
        {
            LoadContentForm(new UserManagementForm());
        }

        private void segítségToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("helpdesk@hodmezovasarhely.hu\n240-es mellék");
        }

        private void passChangeBtn_Click(object sender, EventArgs e)
        {
            using var form = new PasswordChangeForm();
            form.ShowDialog(this);
        }
    }
}
