using Microsoft.Data.Sqlite;
using rgyt2._0.Models;
using rgyt2._0.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rgyt2._0.Forms
{


    public partial class UserManagementForm : Form
    {
        private readonly UserRepository _userRepository;
        private List<User> _users = new();

        public UserManagementForm()
        {
            InitializeComponent();


            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;


            _userRepository = new UserRepository(Program.SqliteContext);

            submitBtn.Click += submitBtn_Click;
            usersGridView.CellDoubleClick += usersGridView_CellDoubleClick;
            usersGridView.CellContentClick += usersGridView_CellContentClick;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadUsers();
            ApplyTheme();
        }

        private void ApplyCreateUserStyling()
        {
            panel1.BackColor = Color.FromArgb(240, 240, 240);
            panel2.BackColor = Color.White;

            Font titleFont = new Font("Segoe UI", 14F, FontStyle.Bold);
            Font baseFont = new Font("Segoe UI", 9F);

            label1.Font = titleFont;

            foreach (Control c in panel2.Controls)
                c.Font = baseFont;

            usernameTextBox.Width = 200;
            passwordTextBox.Width = 200;
            passwordConfirmPassTextBox.Width = 200;

            passwordTextBox.UseSystemPasswordChar = true;
            passwordConfirmPassTextBox.UseSystemPasswordChar = true;

            submitBtn.FlatStyle = FlatStyle.Flat;
            submitBtn.FlatAppearance.BorderSize = 0;
            submitBtn.BackColor = Color.FromArgb(47, 110, 165);
            submitBtn.ForeColor = Color.White;
        }


        private void LoadUsers()
        {
            _users = _userRepository.GetAll();

            usersGridView.DataSource = null;
            usersGridView.AutoGenerateColumns = true;
            usersGridView.DataSource = _users;

            if (usersGridView.Columns[nameof(User.Id)] != null)
                usersGridView.Columns[nameof(User.Id)].Visible = false;

            if (usersGridView.Columns[nameof(User.Username)] != null)
                usersGridView.Columns[nameof(User.Username)].HeaderText = "Felhasználónév";

            if (usersGridView.Columns[nameof(User.IsAdmin)] != null)
                usersGridView.Columns[nameof(User.IsAdmin)].HeaderText = "Admin";

            if (usersGridView.Columns[nameof(User.IsActive)] != null)
                usersGridView.Columns[nameof(User.IsActive)].HeaderText = "Aktív";

            AddResetPasswordColumn();
        }

        private void AddResetPasswordColumn()
        {
            if (usersGridView.Columns["ResetPassword"] != null)
                return;

            var btnCol = new DataGridViewButtonColumn
            {
                Name = "ResetPassword",
                HeaderText = "Jelszó",
                Text = "Reset",
                UseColumnTextForButtonValue = true
            };

            usersGridView.Columns.Add(btnCol);
        }


        private void ClearCreateUserForm()
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            passwordConfirmPassTextBox.Text = "";
            isAdminCheckBox.Checked = false;

            usernameTextBox.Focus();
        }
        private void submitBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text;
            string passwordConfirm = passwordConfirmPassTextBox.Text;
            bool isAdmin = isAdminCheckBox.Checked;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("A felhasználónév megadása kötelező.");
                usernameTextBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("A jelszó megadása kötelező.");
                passwordTextBox.Focus();
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("A jelszó legalább 6 karakter hosszú legyen.");
                passwordTextBox.Focus();
                return;
            }

            if (password != passwordConfirm)
            {
                MessageBox.Show("A két jelszó nem egyezik.");
                passwordConfirmPassTextBox.Focus();
                return;
            }

            try
            {
                _userRepository.CreateUser(
                    username,
                    password,
                    isAdmin,
                    isActive: true
                );

                MessageBox.Show("Felhasználó sikeresen létrehozva.");

                ClearCreateUserForm();
                LoadUsers();
            }
            catch (Microsoft.Data.Sqlite.SqliteException ex)
            {
                if (ex.SqliteErrorCode == 19)
                {
                    MessageBox.Show("Ez a felhasználónév már létezik.");
                }
                else
                {
                    MessageBox.Show($"Adatbázis hiba:\n{ex.Message}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt:\n{ex.Message}");
            }
        }

        private void usersGridView_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var column = usersGridView.Columns[e.ColumnIndex];
            var propertyName = column.DataPropertyName;

            if (propertyName != nameof(User.IsAdmin) &&
                propertyName != nameof(User.IsActive))
            {
                return;
            }

            var user = _users[e.RowIndex];

            if (propertyName == nameof(User.IsActive) &&
                user.Id == Program.CurrentUser?.Id)
            {
                MessageBox.Show(
                    "A saját felhasználódat nem inaktiválhatod.",
                    "Művelet tiltva",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (propertyName == nameof(User.IsAdmin))
            {
                user.IsAdmin = !user.IsAdmin;
            }
            else if (propertyName == nameof(User.IsActive))
            {
                user.IsActive = !user.IsActive;
            }

            _userRepository.UpdateFlags(
                user.Id,
                user.IsAdmin,
                user.IsActive
            );

            usersGridView.Refresh();
        }

        private void ApplyTheme()
        {
            Color formBack = ColorTranslator.FromHtml("#F4F8FC");
            Color panelBack = ColorTranslator.FromHtml("#F7FAFD");
            Color cardBack = Color.White;
            Color primaryBlue = ColorTranslator.FromHtml("#2F6EA5");
            Color primaryHover = ColorTranslator.FromHtml("#4C8DDA");
            Color borderBlue = ColorTranslator.FromHtml("#B8D0EA");
            Color textColor = ColorTranslator.FromHtml("#1F2D3D");
            Color secondaryText = ColorTranslator.FromHtml("#5B7083");

            BackColor = formBack;

            panel1.BackColor = panelBack;
            panel2.BackColor = cardBack;

            label1.ForeColor = textColor;
            label1.Font = new Font("Segoe UI", 15, FontStyle.Regular);

            label2.ForeColor = secondaryText;
            label3.ForeColor = secondaryText;
            label4.ForeColor = secondaryText;

            label2.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            label3.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            label4.Font = new Font("Segoe UI", 9, FontStyle.Regular);

            usernameTextBox.Font = new Font("Segoe UI", 10);
            passwordTextBox.Font = new Font("Segoe UI", 10);
            passwordConfirmPassTextBox.Font = new Font("Segoe UI", 10);

            isAdminCheckBox.ForeColor = textColor;
            isAdminCheckBox.Font = new Font("Segoe UI", 9);

            submitBtn.FlatStyle = FlatStyle.Flat;
            submitBtn.FlatAppearance.BorderSize = 0;
            submitBtn.BackColor = primaryBlue;
            submitBtn.ForeColor = Color.White;
            submitBtn.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            submitBtn.Cursor = Cursors.Hand;

            submitBtn.MouseEnter += (s, e) =>
            {
                submitBtn.BackColor = primaryHover;
            };

            submitBtn.MouseLeave += (s, e) =>
            {
                submitBtn.BackColor = primaryBlue;
            };
        }

        private void usersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (usersGridView.Columns[e.ColumnIndex].Name != "ResetPassword")
                return;

            var user = _users[e.RowIndex];

            var confirm = MessageBox.Show(
                $"Biztosan visszaállítod {user.Username} jelszavát?\n\nÚj jelszó: Jelszo123",
                "Jelszó visszaállítás",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
                return;

            _userRepository.ResetPasswordToDefault(user.Id);

            MessageBox.Show(
                "A jelszó sikeresen visszaállítva (Jelszo123).",
                "Kész",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }


        private void ConfigureGrid()
        {
            usersGridView.ReadOnly = true;
            usersGridView.AllowUserToAddRows = false;
            usersGridView.AllowUserToDeleteRows = false;
            usersGridView.AllowUserToResizeRows = false;
            usersGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            usersGridView.MultiSelect = false;
            usersGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            usersGridView.BackgroundColor = Color.White;
            usersGridView.BorderStyle = BorderStyle.None;
            usersGridView.GridColor = ColorTranslator.FromHtml("#D7E4F2");

            usersGridView.EnableHeadersVisualStyles = false;
            usersGridView.ColumnHeadersDefaultCellStyle.BackColor =
                ColorTranslator.FromHtml("#2F6EA5");
            usersGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            usersGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);

            usersGridView.DefaultCellStyle.Font =
                new Font("Segoe UI", 9, FontStyle.Regular);
            usersGridView.DefaultCellStyle.SelectionBackColor =
                ColorTranslator.FromHtml("#DCEAF7");
            usersGridView.DefaultCellStyle.SelectionForeColor =
                ColorTranslator.FromHtml("#1F2D3D");

            usersGridView.RowHeadersVisible = false;
        }
    }
}
