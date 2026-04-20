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
            form.Dock = DockStyle.None; // fontos!
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


        private void MainForm_Resize(object sender, EventArgs e)
        {
            UpdateWindowSizeStatus();
        }

        private void UpdateWindowSizeStatus()
        {
            widthStatusText.Text = $"w: {ClientSize.Width}px";
            heightStatusText.Text = $"h: {ClientSize.Height}px";
        }

    }
}
