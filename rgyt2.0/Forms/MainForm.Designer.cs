namespace rgyt2._0.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            menüToolStripMenuItem = new ToolStripMenuItem();
            segítségToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            panel1 = new Panel();
            contentPanel = new Panel();
            tabsPanel = new Panel();
            userManagementBtn = new Button();
            passChangeBtn = new Button();
            settingsBtn = new Button();
            queryBtn = new Button();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            tabsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(234, 241, 247);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menüToolStripMenuItem, segítségToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(804, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            menüToolStripMenuItem.Size = new Size(56, 20);
            menüToolStripMenuItem.Text = "Kilépés";
            menüToolStripMenuItem.Click += menüToolStripMenuItem_Click;
            // 
            // segítségToolStripMenuItem
            // 
            segítségToolStripMenuItem.Name = "segítségToolStripMenuItem";
            segítségToolStripMenuItem.Size = new Size(63, 20);
            segítségToolStripMenuItem.Text = "Segítség";
            segítségToolStripMenuItem.Click += segítségToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(statusStrip1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 512);
            panel2.Name = "panel2";
            panel2.Size = new Size(804, 24);
            panel2.TabIndex = 3;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(234, 241, 247);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3, toolStripStatusLabel4 });
            statusStrip1.Location = new Point(0, 2);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(804, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.ForeColor = Color.FromArgb(91, 112, 131);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(267, 17);
            toolStripStatusLabel1.Text = "Hódmezővásárhely MJV Kabinetiroda Informatika";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.ForeColor = Color.FromArgb(91, 112, 131);
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(105, 17);
            toolStripStatusLabel2.Text = "06 62 530 100 / 240";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.ForeColor = Color.FromArgb(91, 112, 131);
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(181, 17);
            toolStripStatusLabel3.Text = "helpdesk@hodmezovasarhely.hu";
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(28, 17);
            toolStripStatusLabel4.Text = "v1.0";
            // 
            // panel1
            // 
            panel1.Controls.Add(contentPanel);
            panel1.Controls.Add(tabsPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 488);
            panel1.TabIndex = 4;
            // 
            // contentPanel
            // 
            contentPanel.AutoSize = true;
            contentPanel.BorderStyle = BorderStyle.FixedSingle;
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 31);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(804, 457);
            contentPanel.TabIndex = 4;
            // 
            // tabsPanel
            // 
            tabsPanel.AutoSize = true;
            tabsPanel.BackColor = Color.FromArgb(22, 50, 79);
            tabsPanel.BorderStyle = BorderStyle.FixedSingle;
            tabsPanel.Controls.Add(userManagementBtn);
            tabsPanel.Controls.Add(passChangeBtn);
            tabsPanel.Controls.Add(settingsBtn);
            tabsPanel.Controls.Add(queryBtn);
            tabsPanel.Dock = DockStyle.Top;
            tabsPanel.Location = new Point(0, 0);
            tabsPanel.Name = "tabsPanel";
            tabsPanel.Size = new Size(804, 31);
            tabsPanel.TabIndex = 3;
            // 
            // userManagementBtn
            // 
            userManagementBtn.ForeColor = Color.FromArgb(91, 112, 131);
            userManagementBtn.Location = new Point(453, 3);
            userManagementBtn.Name = "userManagementBtn";
            userManagementBtn.Size = new Size(144, 23);
            userManagementBtn.TabIndex = 3;
            userManagementBtn.Text = "Felhasználókezelés";
            userManagementBtn.UseVisualStyleBackColor = true;
            userManagementBtn.Click += userManagementBtn_Click;
            // 
            // passChangeBtn
            // 
            passChangeBtn.ForeColor = Color.FromArgb(91, 112, 131);
            passChangeBtn.Location = new Point(303, 3);
            passChangeBtn.Name = "passChangeBtn";
            passChangeBtn.Size = new Size(144, 23);
            passChangeBtn.TabIndex = 2;
            passChangeBtn.Text = "Jelszómódosítás";
            passChangeBtn.UseVisualStyleBackColor = true;
            passChangeBtn.Click += passChangeBtn_Click;
            // 
            // settingsBtn
            // 
            settingsBtn.ForeColor = Color.FromArgb(91, 112, 131);
            settingsBtn.Location = new Point(153, 3);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(144, 23);
            settingsBtn.TabIndex = 1;
            settingsBtn.Text = "Beállíltások";
            settingsBtn.UseVisualStyleBackColor = true;
            settingsBtn.Click += settingsBtn_Click;
            // 
            // queryBtn
            // 
            queryBtn.ForeColor = Color.FromArgb(91, 112, 131);
            queryBtn.Location = new Point(3, 3);
            queryBtn.Name = "queryBtn";
            queryBtn.Size = new Size(144, 23);
            queryBtn.TabIndex = 0;
            queryBtn.Text = "Adatlekérés";
            queryBtn.UseVisualStyleBackColor = true;
            queryBtn.Click += queryBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 250, 253);
            ClientSize = new Size(804, 536);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(800, 525);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RGYT 2.0";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabsPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menüToolStripMenuItem;
        private Panel panel2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripMenuItem segítségToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private Panel panel1;
        private Panel contentPanel;
        private Panel tabsPanel;
        private Button passChangeBtn;
        private Button settingsBtn;
        private Button queryBtn;
            
        private Form? _currentContentForm;
        private Button userManagementBtn;
    }
}