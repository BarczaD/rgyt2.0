namespace rgyt2._0.Forms
{
    partial class SettingsForm
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
            cancelBtn = new Button();
            okBtn = new Button();
            browseBtn = new Button();
            dbfPathTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cancelBtn);
            panel1.Controls.Add(okBtn);
            panel1.Controls.Add(browseBtn);
            panel1.Controls.Add(dbfPathTextBox);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 168);
            panel1.TabIndex = 0;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(197, 128);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 9;
            cancelBtn.Text = "Mégsem";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            okBtn.Location = new Point(46, 128);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(75, 23);
            okBtn.TabIndex = 8;
            okBtn.Text = "Mentés";
            okBtn.UseVisualStyleBackColor = true;
            // 
            // browseBtn
            // 
            browseBtn.Location = new Point(123, 90);
            browseBtn.Name = "browseBtn";
            browseBtn.Size = new Size(75, 23);
            browseBtn.TabIndex = 7;
            browseBtn.Text = "Tallózás";
            browseBtn.UseVisualStyleBackColor = true;
            // 
            // dbfPathTextBox
            // 
            dbfPathTextBox.Location = new Point(108, 61);
            dbfPathTextBox.Name = "dbfPathTextBox";
            dbfPathTextBox.ReadOnly = true;
            dbfPathTextBox.Size = new Size(201, 23);
            dbfPathTextBox.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 64);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 5;
            label1.Text = "DBF fájlok helye:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(92, 9);
            label2.Name = "label2";
            label2.Size = new Size(137, 32);
            label2.TabIndex = 10;
            label2.Text = "Beállítások";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 168);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Beállítások";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button cancelBtn;
        private Button okBtn;
        private Button browseBtn;
        private TextBox dbfPathTextBox;
        private Label label1;
        private Label label2;
    }
}