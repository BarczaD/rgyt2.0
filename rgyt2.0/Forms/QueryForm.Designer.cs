namespace rgyt2._0.Forms
{
    partial class QueryForm
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
            rootPanel = new Panel();
            leftPanel = new Panel();
            rightPanel = new Panel();
            actionsPanel = new Panel();
            gridViewPanel = new Panel();
            loadingBarPanel = new Panel();
            panel4 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            adultChildQueryBtn = new Button();
            rgykChildSumBtn = new Button();
            hChildSumQueryBtn = new Button();
            rgykQueryBtn = new Button();
            hQueryBtn = new Button();
            panel5 = new Panel();
            label1 = new Label();
            queryProgressBar = new ProgressBar();
            panel2 = new Panel();
            panel3 = new Panel();
            resultClearBtn = new Button();
            exportBtn = new Button();
            rootPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            actionsPanel.SuspendLayout();
            gridViewPanel.SuspendLayout();
            loadingBarPanel.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // rootPanel
            // 
            rootPanel.Controls.Add(rightPanel);
            rootPanel.Controls.Add(leftPanel);
            rootPanel.Location = new Point(12, 12);
            rootPanel.Name = "rootPanel";
            rootPanel.Size = new Size(776, 426);
            rootPanel.TabIndex = 0;
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(panel1);
            leftPanel.Controls.Add(panel4);
            leftPanel.Controls.Add(loadingBarPanel);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(220, 426);
            leftPanel.TabIndex = 0;
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(gridViewPanel);
            rightPanel.Controls.Add(actionsPanel);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(220, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(556, 426);
            rightPanel.TabIndex = 1;
            // 
            // actionsPanel
            // 
            actionsPanel.Controls.Add(panel3);
            actionsPanel.Controls.Add(panel2);
            actionsPanel.Dock = DockStyle.Bottom;
            actionsPanel.Location = new Point(0, 398);
            actionsPanel.Name = "actionsPanel";
            actionsPanel.Size = new Size(556, 28);
            actionsPanel.TabIndex = 1;
            // 
            // gridViewPanel
            // 
            gridViewPanel.BackColor = Color.FromArgb(184, 208, 234);
            gridViewPanel.Controls.Add(panel5);
            gridViewPanel.Dock = DockStyle.Fill;
            gridViewPanel.Location = new Point(0, 0);
            gridViewPanel.Name = "gridViewPanel";
            gridViewPanel.Size = new Size(556, 398);
            gridViewPanel.TabIndex = 2;
            // 
            // loadingBarPanel
            // 
            loadingBarPanel.Controls.Add(queryProgressBar);
            loadingBarPanel.Dock = DockStyle.Bottom;
            loadingBarPanel.Location = new Point(0, 398);
            loadingBarPanel.Name = "loadingBarPanel";
            loadingBarPanel.Size = new Size(220, 28);
            loadingBarPanel.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(22, 50, 79);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Top;
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(220, 67);
            panel4.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(22, 15);
            label2.Name = "label2";
            label2.Size = new Size(177, 36);
            label2.TabIndex = 1;
            label2.Text = "Lekérdezések";
            // 
            // panel1
            // 
            panel1.Controls.Add(adultChildQueryBtn);
            panel1.Controls.Add(hQueryBtn);
            panel1.Controls.Add(rgykChildSumBtn);
            panel1.Controls.Add(rgykQueryBtn);
            panel1.Controls.Add(hChildSumQueryBtn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 331);
            panel1.TabIndex = 11;
            // 
            // adultChildQueryBtn
            // 
            adultChildQueryBtn.BackColor = Color.White;
            adultChildQueryBtn.FlatStyle = FlatStyle.Popup;
            adultChildQueryBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adultChildQueryBtn.ForeColor = Color.FromArgb(91, 112, 131);
            adultChildQueryBtn.Location = new Point(6, 146);
            adultChildQueryBtn.Name = "adultChildQueryBtn";
            adultChildQueryBtn.Size = new Size(211, 23);
            adultChildQueryBtn.TabIndex = 26;
            adultChildQueryBtn.Text = "Nagykorú gyermekes szülők";
            adultChildQueryBtn.UseVisualStyleBackColor = false;
            // 
            // rgykChildSumBtn
            // 
            rgykChildSumBtn.BackColor = Color.White;
            rgykChildSumBtn.FlatStyle = FlatStyle.Popup;
            rgykChildSumBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rgykChildSumBtn.ForeColor = Color.FromArgb(91, 112, 131);
            rgykChildSumBtn.Location = new Point(6, 117);
            rgykChildSumBtn.Name = "rgykChildSumBtn";
            rgykChildSumBtn.Size = new Size(211, 23);
            rgykChildSumBtn.TabIndex = 25;
            rgykChildSumBtn.Text = "Gyerekszám (csak RGYK)";
            rgykChildSumBtn.UseVisualStyleBackColor = false;
            // 
            // hChildSumQueryBtn
            // 
            hChildSumQueryBtn.BackColor = Color.White;
            hChildSumQueryBtn.FlatStyle = FlatStyle.Popup;
            hChildSumQueryBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hChildSumQueryBtn.ForeColor = Color.FromArgb(91, 112, 131);
            hChildSumQueryBtn.Location = new Point(6, 88);
            hChildSumQueryBtn.Name = "hChildSumQueryBtn";
            hChildSumQueryBtn.Size = new Size(211, 23);
            hChildSumQueryBtn.TabIndex = 24;
            hChildSumQueryBtn.Text = "Gyerekszám (H-sok)";
            hChildSumQueryBtn.UseVisualStyleBackColor = false;
            // 
            // rgykQueryBtn
            // 
            rgykQueryBtn.BackColor = Color.White;
            rgykQueryBtn.FlatStyle = FlatStyle.Popup;
            rgykQueryBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rgykQueryBtn.ForeColor = Color.FromArgb(91, 112, 131);
            rgykQueryBtn.Location = new Point(6, 59);
            rgykQueryBtn.Name = "rgykQueryBtn";
            rgykQueryBtn.Size = new Size(211, 23);
            rgykQueryBtn.TabIndex = 23;
            rgykQueryBtn.Text = "Csak RGYK";
            rgykQueryBtn.UseVisualStyleBackColor = false;
            // 
            // hQueryBtn
            // 
            hQueryBtn.BackColor = Color.White;
            hQueryBtn.FlatStyle = FlatStyle.Popup;
            hQueryBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hQueryBtn.ForeColor = Color.FromArgb(91, 112, 131);
            hQueryBtn.Location = new Point(6, 30);
            hQueryBtn.Name = "hQueryBtn";
            hQueryBtn.Size = new Size(211, 23);
            hQueryBtn.TabIndex = 22;
            hQueryBtn.Text = "H-sok";
            hQueryBtn.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(22, 50, 79);
            panel5.Controls.Add(label1);
            panel5.Dock = DockStyle.Top;
            panel5.ForeColor = Color.White;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(556, 67);
            panel5.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(195, 15);
            label1.Name = "label1";
            label1.Size = new Size(166, 36);
            label1.TabIndex = 1;
            label1.Text = "Eredmények";
            // 
            // queryProgressBar
            // 
            queryProgressBar.BackColor = Color.White;
            queryProgressBar.Dock = DockStyle.Fill;
            queryProgressBar.ForeColor = Color.FromArgb(47, 110, 165);
            queryProgressBar.Location = new Point(0, 0);
            queryProgressBar.Name = "queryProgressBar";
            queryProgressBar.Size = new Size(220, 28);
            queryProgressBar.Style = ProgressBarStyle.Continuous;
            queryProgressBar.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(resultClearBtn);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 28);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(exportBtn);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(356, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 28);
            panel3.TabIndex = 1;
            // 
            // resultClearBtn
            // 
            resultClearBtn.BackColor = Color.FromArgb(192, 57, 43);
            resultClearBtn.FlatStyle = FlatStyle.Popup;
            resultClearBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultClearBtn.ForeColor = Color.White;
            resultClearBtn.Location = new Point(76, 2);
            resultClearBtn.Name = "resultClearBtn";
            resultClearBtn.Size = new Size(121, 23);
            resultClearBtn.TabIndex = 18;
            resultClearBtn.Text = "Ürítés";
            resultClearBtn.UseVisualStyleBackColor = false;
            // 
            // exportBtn
            // 
            exportBtn.BackColor = Color.FromArgb(47, 110, 165);
            exportBtn.FlatStyle = FlatStyle.Popup;
            exportBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exportBtn.ForeColor = Color.White;
            exportBtn.Location = new Point(3, 3);
            exportBtn.Name = "exportBtn";
            exportBtn.Size = new Size(121, 23);
            exportBtn.TabIndex = 19;
            exportBtn.Text = "Exportálás";
            exportBtn.UseVisualStyleBackColor = false;
            // 
            // QueryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(rootPanel);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "QueryForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "QueryForm";
            rootPanel.ResumeLayout(false);
            leftPanel.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            actionsPanel.ResumeLayout(false);
            gridViewPanel.ResumeLayout(false);
            loadingBarPanel.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel rightPanel;
        private Panel panel2;
        private ProgressBar queryProgressBar;
        private Button resultClearBtn;
        private Button exportBtn;
        private Panel panel4;
        private Panel panel5;
        private Label label1;
        private Panel panel6;
        private Panel rootPanel;
        private Panel leftPanel;
        private Panel gridViewPanel;
        private Panel actionsPanel;
        private Panel loadingBarPanel;
        private Label label2;
        private Panel panel1;
        private Button adultChildQueryBtn;
        private Button hQueryBtn;
        private Button rgykChildSumBtn;
        private Button rgykQueryBtn;
        private Button hChildSumQueryBtn;
        private Panel panel3;
    }
}