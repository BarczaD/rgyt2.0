namespace rgyt2._0.Forms
{
    partial class UserManagementForm
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
            usersGridView = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            submitBtn = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            isAdminCheckBox = new CheckBox();
            label1 = new Label();
            passwordConfirmPassTextBox = new TextBox();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)usersGridView).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // usersGridView
            // 
            usersGridView.AllowUserToAddRows = false;
            usersGridView.AllowUserToDeleteRows = false;
            usersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersGridView.Dock = DockStyle.Left;
            usersGridView.Location = new Point(0, 0);
            usersGridView.Name = "usersGridView";
            usersGridView.ReadOnly = true;
            usersGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            usersGridView.Size = new Size(456, 450);
            usersGridView.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(478, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 450);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(submitBtn);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(isAdminCheckBox);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(passwordConfirmPassTextBox);
            panel2.Controls.Add(passwordTextBox);
            panel2.Controls.Add(usernameTextBox);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(322, 450);
            panel2.TabIndex = 1;
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(96, 322);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(131, 23);
            submitBtn.TabIndex = 8;
            submitBtn.Text = "Létrehozás";
            submitBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(131, 227);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 7;
            label4.Text = "Jelszó újra";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 173);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 6;
            label3.Text = "Jelszó";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 116);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 5;
            label2.Text = "Felhasználónév";
            // 
            // isAdminCheckBox
            // 
            isAdminCheckBox.AutoSize = true;
            isAdminCheckBox.Location = new Point(128, 274);
            isAdminCheckBox.Name = "isAdminCheckBox";
            isAdminCheckBox.Size = new Size(67, 19);
            isAdminCheckBox.TabIndex = 4;
            isAdminCheckBox.Text = "Admin?";
            isAdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 38);
            label1.Name = "label1";
            label1.Size = new Size(266, 32);
            label1.TabIndex = 3;
            label1.Text = "Felhasználó létrehozása";
            // 
            // passwordConfirmPassTextBox
            // 
            passwordConfirmPassTextBox.Location = new Point(73, 245);
            passwordConfirmPassTextBox.Name = "passwordConfirmPassTextBox";
            passwordConfirmPassTextBox.Size = new Size(176, 23);
            passwordConfirmPassTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(73, 191);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(176, 23);
            passwordTextBox.TabIndex = 1;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(73, 134);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(176, 23);
            usernameTextBox.TabIndex = 0;
            // 
            // UserManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(usersGridView);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(800, 450);
            Name = "UserManagementForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "UserManagementForm";
            ((System.ComponentModel.ISupportInitialize)usersGridView).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView usersGridView;
        private Panel panel1;
        private TextBox usernameTextBox;
        private Panel panel2;
        private Label label1;
        private TextBox passwordConfirmPassTextBox;
        private TextBox passwordTextBox;
        private CheckBox isAdminCheckBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button submitBtn;
    }
}