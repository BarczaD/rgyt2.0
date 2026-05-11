using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rgyt2._0.Forms

{
    public partial class PasswordChangeForm : Form
    {
        public PasswordChangeForm()
        {
            InitializeComponent();

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

            newPasswordTextBox.UseSystemPasswordChar = true;
            confirmPasswordTextBox.UseSystemPasswordChar = true;

            newPasswordTextBox.Width = 220;
            confirmPasswordTextBox.Width = 220;

            okBtn.FlatStyle = FlatStyle.Flat;
            okBtn.FlatAppearance.BorderSize = 0;
            okBtn.BackColor = Color.FromArgb(47, 110, 165);
            okBtn.ForeColor = Color.White;

            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.BackColor = Color.FromArgb(220, 220, 220);

            Text = "Jelszó módosítása";
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            string newPassword = newPasswordTextBox.Text;
            string confirm = confirmPasswordTextBox.Text;

            // ---- Validáció ----
            if (string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Az új jelszó nem lehet üres.");
                return;
            }

            if (newPassword.Length < 6)
            {
                MessageBox.Show("Az új jelszó legalább 6 karakter hosszú legyen.");
                return;
            }

            if (newPassword != confirm)
            {
                MessageBox.Show("A két jelszó nem egyezik.");
                return;
            }

            // ---- Hash ----
            string hash = BCrypt.Net.BCrypt.HashPassword(newPassword);

            // ---- DB update ----
            using var conn = Program.SqliteContext.CreateConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = """
                UPDATE Users
                SET PasswordHash = @hash
                WHERE Id = @id
            """;

            cmd.Parameters.AddWithValue("@hash", hash);
            cmd.Parameters.AddWithValue("@id", Program.CurrentUser!.Id);

            cmd.ExecuteNonQuery();

            MessageBox.Show(
                "A jelszó sikeresen módosítva.",
                "Siker",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}