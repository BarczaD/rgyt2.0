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
            labelMain = new Label();
            labelSecondary = new Label();
            label1 = new Label();
            usernameLabel = new Label();
            pwdTextBox = new TextBox();
            usernameTextBox = new TextBox();
            panel1 = new Panel();
            loginBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelMain
            // 
            labelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            labelMain.AutoSize = true;
            labelMain.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMain.Location = new Point(30, 18);
            labelMain.Name = "labelMain";
            labelMain.Size = new Size(524, 40);
            labelMain.TabIndex = 0;
            labelMain.Text = "Rendszeres Gyermekvédelmi Támogatás";
            labelMain.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelSecondary
            // 
            labelSecondary.Anchor = AnchorStyles.Top;
            labelSecondary.AutoSize = true;
            labelSecondary.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSecondary.Location = new Point(185, 58);
            labelSecondary.Name = "labelSecondary";
            labelSecondary.Size = new Size(214, 30);
            labelSecondary.TabIndex = 1;
            labelSecondary.Text = "Adatkinyerő Rendszer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(274, 172);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 5;
            label1.Text = "Jelszó";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
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
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel1.Controls.Add(loginBtn);
            panel1.Controls.Add(labelMain);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelSecondary);
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
            loginBtn.Location = new Point(255, 219);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 23);
            loginBtn.TabIndex = 6;
            loginBtn.Text = "Belépés";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtnClick;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 286);
            Controls.Add(panel1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bejelentkezés";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelMain;
        private Label labelSecondary;
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
    }
}