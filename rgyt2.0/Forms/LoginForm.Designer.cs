namespace rgyt2._0.Forms
{
    partial class LoginForm
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
            label1 = new Label();
            usernameLabel = new Label();
            pwdTextBox = new TextBox();
            usernameTextBox = new TextBox();
            panel1 = new Panel();
            loginBtn = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(91, 112, 131);
            label1.Location = new Point(274, 172);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 5;
            label1.Text = "Jelszó";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.ForeColor = Color.FromArgb(91, 112, 131);
            usernameLabel.Location = new Point(249, 118);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(87, 15);
            usernameLabel.TabIndex = 4;
            usernameLabel.Text = "Felhasználónév";
            // 
            // pwdTextBox
            // 
            pwdTextBox.Location = new Point(182, 190);
            pwdTextBox.Name = "pwdTextBox";
            pwdTextBox.Size = new Size(220, 23);
            pwdTextBox.TabIndex = 3;
            pwdTextBox.UseSystemPasswordChar = true;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(182, 136);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(220, 23);
            usernameTextBox.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(244, 248, 252);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(loginBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(usernameLabel);
            panel1.Controls.Add(usernameTextBox);
            panel1.Controls.Add(pwdTextBox);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 286);
            panel1.TabIndex = 6;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(47, 110, 165);
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(255, 223);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 23);
            loginBtn.TabIndex = 6;
            loginBtn.Text = "Belépés";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtnClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(22, 50, 79);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(584, 100);
            panel2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(42, 11);
            label2.Name = "label2";
            label2.Size = new Size(500, 36);
            label2.TabIndex = 0;
            label2.Text = "Rendszeres Gyermekvédelmi Támogatás";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.FromArgb(220, 234, 247);
            label3.Location = new Point(191, 49);
            label3.Name = "label3";
            label3.Size = new Size(202, 28);
            label3.TabIndex = 1;
            label3.Text = "Adatkinyerő Rendszer";
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, -86);
            panel3.Name = "panel3";
            panel3.Size = new Size(584, 186);
            panel3.TabIndex = 8;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(584, 286);
            Controls.Add(panel1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bejelentkezés";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox usernameTextBox;
        private Label label1;
        private Label usernameLabel;
        private TextBox pwdTextBox;
        private Panel panel1;
        private Button loginBtn;

        private void loginBtnClick(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = pwdTextBox.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Hiányzó felhasználónév vagy jelszó!");
                return;
            }

            MessageBox.Show("Sikeres Belépés! \nGyőződjetek meg róla, hogy senki sincs belépve a Fox-ba!");

            var mainForm = new MainForm();
            mainForm.Show();
            this.Hide();

        }

        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Label label3;
    }
}