namespace rgyt2._0.Forms
{
    partial class temp
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
            panel6 = new Panel();
            panel2 = new Panel();
            exportBtn = new Button();
            resultClearBtn = new Button();
            panel1 = new Panel();
            panel4 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            adultChildQueryBtn = new Button();
            rgykChildSumBtn = new Button();
            hChildSumQueryBtn = new Button();
            rgykQueryBtn = new Button();
            hQueryBtn = new Button();
            queryProgressBar = new ProgressBar();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(184, 208, 234);
            panel6.Location = new Point(293, 107);
            panel6.Name = "panel6";
            panel6.Size = new Size(495, 279);
            panel6.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.Controls.Add(exportBtn);
            panel2.Controls.Add(resultClearBtn);
            panel2.Location = new Point(293, 392);
            panel2.Name = "panel2";
            panel2.Size = new Size(495, 46);
            panel2.TabIndex = 12;
            // 
            // exportBtn
            // 
            exportBtn.BackColor = Color.FromArgb(47, 110, 165);
            exportBtn.FlatStyle = FlatStyle.Popup;
            exportBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exportBtn.ForeColor = Color.White;
            exportBtn.Location = new Point(351, 10);
            exportBtn.Name = "exportBtn";
            exportBtn.Size = new Size(121, 23);
            exportBtn.TabIndex = 18;
            exportBtn.Text = "Exportálás";
            exportBtn.UseVisualStyleBackColor = false;
            // 
            // resultClearBtn
            // 
            resultClearBtn.BackColor = Color.FromArgb(192, 57, 43);
            resultClearBtn.FlatStyle = FlatStyle.Popup;
            resultClearBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultClearBtn.ForeColor = Color.White;
            resultClearBtn.Location = new Point(22, 10);
            resultClearBtn.Name = "resultClearBtn";
            resultClearBtn.Size = new Size(121, 23);
            resultClearBtn.TabIndex = 17;
            resultClearBtn.Text = "Ürítés";
            resultClearBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(queryProgressBar);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 426);
            panel1.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(22, 50, 79);
            panel4.Controls.Add(label2);
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(17, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(239, 67);
            panel4.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 15);
            label2.Name = "label2";
            label2.Size = new Size(177, 36);
            label2.TabIndex = 1;
            label2.Text = "Lekérdezések";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(adultChildQueryBtn);
            panel3.Controls.Add(rgykChildSumBtn);
            panel3.Controls.Add(hChildSumQueryBtn);
            panel3.Controls.Add(rgykQueryBtn);
            panel3.Controls.Add(hQueryBtn);
            panel3.Location = new Point(17, 95);
            panel3.Name = "panel3";
            panel3.Size = new Size(239, 250);
            panel3.TabIndex = 1;
            // 
            // adultChildQueryBtn
            // 
            adultChildQueryBtn.BackColor = Color.White;
            adultChildQueryBtn.FlatStyle = FlatStyle.Popup;
            adultChildQueryBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adultChildQueryBtn.ForeColor = Color.FromArgb(91, 112, 131);
            adultChildQueryBtn.Location = new Point(10, 170);
            adultChildQueryBtn.Name = "adultChildQueryBtn";
            adultChildQueryBtn.Size = new Size(220, 23);
            adultChildQueryBtn.TabIndex = 16;
            adultChildQueryBtn.Text = "Nagykorú gyermekes szülők";
            adultChildQueryBtn.UseVisualStyleBackColor = false;
            // 
            // rgykChildSumBtn
            // 
            rgykChildSumBtn.BackColor = Color.White;
            rgykChildSumBtn.FlatStyle = FlatStyle.Popup;
            rgykChildSumBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rgykChildSumBtn.ForeColor = Color.FromArgb(91, 112, 131);
            rgykChildSumBtn.Location = new Point(10, 141);
            rgykChildSumBtn.Name = "rgykChildSumBtn";
            rgykChildSumBtn.Size = new Size(220, 23);
            rgykChildSumBtn.TabIndex = 15;
            rgykChildSumBtn.Text = "Gyerekszám (csak RGYK)";
            rgykChildSumBtn.UseVisualStyleBackColor = false;
            // 
            // hChildSumQueryBtn
            // 
            hChildSumQueryBtn.BackColor = Color.White;
            hChildSumQueryBtn.FlatStyle = FlatStyle.Popup;
            hChildSumQueryBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hChildSumQueryBtn.ForeColor = Color.FromArgb(91, 112, 131);
            hChildSumQueryBtn.Location = new Point(10, 112);
            hChildSumQueryBtn.Name = "hChildSumQueryBtn";
            hChildSumQueryBtn.Size = new Size(220, 23);
            hChildSumQueryBtn.TabIndex = 14;
            hChildSumQueryBtn.Text = "Gyerekszám (H-sok)";
            hChildSumQueryBtn.UseVisualStyleBackColor = false;
            // 
            // rgykQueryBtn
            // 
            rgykQueryBtn.BackColor = Color.White;
            rgykQueryBtn.FlatStyle = FlatStyle.Popup;
            rgykQueryBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rgykQueryBtn.ForeColor = Color.FromArgb(91, 112, 131);
            rgykQueryBtn.Location = new Point(10, 83);
            rgykQueryBtn.Name = "rgykQueryBtn";
            rgykQueryBtn.Size = new Size(220, 23);
            rgykQueryBtn.TabIndex = 13;
            rgykQueryBtn.Text = "Csak RGYK";
            rgykQueryBtn.UseVisualStyleBackColor = false;
            // 
            // hQueryBtn
            // 
            hQueryBtn.BackColor = Color.White;
            hQueryBtn.FlatStyle = FlatStyle.Popup;
            hQueryBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hQueryBtn.ForeColor = Color.FromArgb(91, 112, 131);
            hQueryBtn.Location = new Point(10, 54);
            hQueryBtn.Name = "hQueryBtn";
            hQueryBtn.Size = new Size(220, 23);
            hQueryBtn.TabIndex = 12;
            hQueryBtn.Text = "H-sok";
            hQueryBtn.UseVisualStyleBackColor = false;
            // 
            // queryProgressBar
            // 
            queryProgressBar.Anchor = AnchorStyles.Top;
            queryProgressBar.BackColor = Color.White;
            queryProgressBar.ForeColor = Color.FromArgb(47, 110, 165);
            queryProgressBar.Location = new Point(54, 390);
            queryProgressBar.Name = "queryProgressBar";
            queryProgressBar.Size = new Size(239, 23);
            queryProgressBar.Style = ProgressBarStyle.Continuous;
            queryProgressBar.TabIndex = 0;
            // 
            // temp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "temp";
            Text = "temp";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel6;
        private Panel panel2;
        private Button exportBtn;
        private Button resultClearBtn;
        private Panel panel1;
        private Panel panel4;
        private Label label2;
        private Panel panel3;
        private Button adultChildQueryBtn;
        private Button rgykChildSumBtn;
        private Button hChildSumQueryBtn;
        private Button rgykQueryBtn;
        private Button hQueryBtn;
        private ProgressBar queryProgressBar;
    }
}