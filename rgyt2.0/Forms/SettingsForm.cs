using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rgyt2._0.Forms
{
    public partial class SettingsForm : Form
    {
        public string SelectedDbfFolder { get; private set; }

        public SettingsForm(string currentDbfFolder)
        {
            InitializeComponent();

            SelectedDbfFolder = currentDbfFolder;
            dbfPathTextBox.Text = currentDbfFolder;

            browseBtn.Click += browseBtn_Click;
            okBtn.Click += okBtn_Click;
            cancelBtn.Click += (s, e) => Close();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ApplyStyling();
        }

        private void ApplyStyling()
        {
            BackColor = Color.White;

            Font baseFont = new Font("Segoe UI", 9F);
            foreach (Control c in Controls)
                c.Font = baseFont;

            dbfPathTextBox.ReadOnly = true;
            dbfPathTextBox.Width = 260;
            dbfPathTextBox.BackColor = Color.White;

            browseBtn.FlatStyle = FlatStyle.Flat;
            browseBtn.FlatAppearance.BorderSize = 0;

            okBtn.FlatStyle = FlatStyle.Flat;
            okBtn.FlatAppearance.BorderSize = 0;
            okBtn.BackColor = Color.FromArgb(47, 110, 165);
            okBtn.ForeColor = Color.White;

            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.BackColor = Color.FromArgb(220, 220, 220);

            Text = "Beállítások";
        }

        private void browseBtn_Click(object? sender, EventArgs e)
        {
            using var dialog = new FolderBrowserDialog
            {
                Description = "Válaszd ki a DBF fájlok mappáját",
                SelectedPath = dbfPathTextBox.Text
            };

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                SelectedDbfFolder = dialog.SelectedPath;
                dbfPathTextBox.Text = dialog.SelectedPath;
            }
        }

        private void okBtn_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SelectedDbfFolder) ||
                !Directory.Exists(SelectedDbfFolder))
            {
                MessageBox.Show("Érvényes mappát válassz ki.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }

}
