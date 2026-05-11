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
            rightPanel = new Panel();
            gridViewPanel = new Panel();
            queryResultGridView = new DataGridView();
            panel5 = new Panel();
            label1 = new Label();
            actionsPanel = new Panel();
            panel3 = new Panel();
            exportBtn = new Button();
            panel2 = new Panel();
            resultClearBtn = new Button();
            leftPanel = new Panel();
            panel1 = new Panel();
            yearIntervalTextBox = new TextBox();
            payoutPerChildTextField = new TextBox();
            adultChildQueryBtn = new Button();
            hQueryBtn = new Button();
            rgykChildSumBtn = new Button();
            rgykQueryBtn = new Button();
            hChildSumQueryBtn = new Button();
            panel4 = new Panel();
            label2 = new Label();
            loadingBarPanel = new Panel();
            queryProgressBar = new ProgressBar();
            rootPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            gridViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)queryResultGridView).BeginInit();
            panel5.SuspendLayout();
            actionsPanel.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            leftPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            loadingBarPanel.SuspendLayout();
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
            // gridViewPanel
            // 
            gridViewPanel.BackColor = Color.FromArgb(184, 208, 234);
            gridViewPanel.Controls.Add(queryResultGridView);
            gridViewPanel.Controls.Add(panel5);
            gridViewPanel.Dock = DockStyle.Fill;
            gridViewPanel.Location = new Point(0, 0);
            gridViewPanel.Name = "gridViewPanel";
            gridViewPanel.Size = new Size(556, 398);
            gridViewPanel.TabIndex = 2;
            // 
            // queryResultGridView
            // 
            queryResultGridView.AllowUserToAddRows = false;
            queryResultGridView.AllowUserToDeleteRows = false;
            queryResultGridView.BackgroundColor = SystemColors.AppWorkspace;
            queryResultGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            queryResultGridView.Dock = DockStyle.Fill;
            queryResultGridView.GridColor = Color.FromArgb(184, 208, 234);
            queryResultGridView.Location = new Point(0, 67);
            queryResultGridView.Name = "queryResultGridView";
            queryResultGridView.ReadOnly = true;
            queryResultGridView.Size = new Size(556, 331);
            queryResultGridView.TabIndex = 15;
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
            // panel3
            // 
            panel3.Controls.Add(exportBtn);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(356, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 28);
            panel3.TabIndex = 1;
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
            exportBtn.Click += exportBtn_Click;
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
            resultClearBtn.Click += resultClearBtn_Click;
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
            // panel1
            // 
            panel1.Controls.Add(yearIntervalTextBox);
            panel1.Controls.Add(payoutPerChildTextField);
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
            // yearIntervalTextBox
            // 
            yearIntervalTextBox.Location = new Point(3, 206);
            yearIntervalTextBox.Name = "yearIntervalTextBox";
            yearIntervalTextBox.Size = new Size(211, 23);
            yearIntervalTextBox.TabIndex = 28;
            yearIntervalTextBox.Text = "Születési év (pl. 2012 - 2020)";
            // 
            // payoutPerChildTextField
            // 
            payoutPerChildTextField.Location = new Point(6, 177);
            payoutPerChildTextField.Name = "payoutPerChildTextField";
            payoutPerChildTextField.Size = new Size(211, 23);
            payoutPerChildTextField.TabIndex = 27;
            payoutPerChildTextField.Text = "Kifizetés összege";
            // 
            // adultChildQueryBtn
            // 
            adultChildQueryBtn.BackColor = Color.White;
            adultChildQueryBtn.FlatStyle = FlatStyle.Popup;
            adultChildQueryBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adultChildQueryBtn.ForeColor = Color.FromArgb(91, 112, 131);
            adultChildQueryBtn.Location = new Point(6, 148);
            adultChildQueryBtn.Name = "adultChildQueryBtn";
            adultChildQueryBtn.Size = new Size(211, 23);
            adultChildQueryBtn.TabIndex = 26;
            adultChildQueryBtn.Text = "Nagykorú gyermekes szülők";
            adultChildQueryBtn.UseVisualStyleBackColor = false;
            adultChildQueryBtn.Click += adultChildQueryBtn_Click;
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
            hQueryBtn.Click += hQueryBtn_Click;
            // 
            // rgykChildSumBtn
            // 
            rgykChildSumBtn.BackColor = Color.White;
            rgykChildSumBtn.FlatStyle = FlatStyle.Popup;
            rgykChildSumBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rgykChildSumBtn.ForeColor = Color.FromArgb(91, 112, 131);
            rgykChildSumBtn.Location = new Point(6, 119);
            rgykChildSumBtn.Name = "rgykChildSumBtn";
            rgykChildSumBtn.Size = new Size(211, 23);
            rgykChildSumBtn.TabIndex = 25;
            rgykChildSumBtn.Text = "Gyerekszám (csak RGYK)";
            rgykChildSumBtn.UseVisualStyleBackColor = false;
            rgykChildSumBtn.Click += rgykChildSumBtn_Click;
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
            rgykQueryBtn.Click += rgykQueryBtn_Click;
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
            hChildSumQueryBtn.Click += hChildSumQueryBtn_Click;
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
            // loadingBarPanel
            // 
            loadingBarPanel.Controls.Add(queryProgressBar);
            loadingBarPanel.Dock = DockStyle.Bottom;
            loadingBarPanel.Location = new Point(0, 398);
            loadingBarPanel.Name = "loadingBarPanel";
            loadingBarPanel.Size = new Size(220, 28);
            loadingBarPanel.TabIndex = 0;
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
            rightPanel.ResumeLayout(false);
            gridViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)queryResultGridView).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            actionsPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            leftPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            loadingBarPanel.ResumeLayout(false);
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
        private DataGridView queryResultGridView;
        private TextBox payoutPerChildTextField;
        private TextBox yearIntervalTextBox;
    }
}