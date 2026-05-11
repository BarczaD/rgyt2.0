namespace rgyt2._0.Forms
{
    partial class PasswordChangeForm
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            newPasswordTextBox = new MaskedTextBox();
            confirmPasswordTextBox = new MaskedTextBox();
            okBtn = new Button();
            cancelBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cancelBtn);
            panel1.Controls.Add(okBtn);
            panel1.Controls.Add(confirmPasswordTextBox);
            panel1.Controls.Add(newPasswordTextBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 220);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 9);
            label1.Name = "label1";
            label1.Size = new Size(221, 32);
            label1.TabIndex = 0;
            label1.Text = "Jelszó módosítása";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 73);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Új jelszó";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 124);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 2;
            label3.Text = "Új jelszó újra";
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.Location = new Point(19, 91);
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.Size = new Size(221, 23);
            newPasswordTextBox.TabIndex = 1;
            newPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.Location = new Point(19, 142);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.Size = new Size(221, 23);
            confirmPasswordTextBox.TabIndex = 3;
            confirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // okBtn
            // 
            okBtn.Location = new Point(19, 179);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(75, 23);
            okBtn.TabIndex = 4;
            okBtn.Text = "Mentés";
            okBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(165, 179);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 5;
            cancelBtn.Text = "Mégsem";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // PasswordChangeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 220);
            Controls.Add(panel1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "PasswordChangeForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Jelszó módosítása";
            TopMost = true;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private MaskedTextBox confirmPasswordTextBox;
        private MaskedTextBox newPasswordTextBox;
        private Button cancelBtn;
        private Button okBtn;
    }
}