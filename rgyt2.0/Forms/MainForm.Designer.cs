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
            tabsPanel = new Panel();
            button2 = new Button();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            menüToolStripMenuItem = new ToolStripMenuItem();
            segítségToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            panel2 = new Panel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            button3 = new Button();
            tabsPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabsPanel
            // 
            tabsPanel.BackColor = Color.FromArgb(22, 50, 79);
            tabsPanel.BorderStyle = BorderStyle.FixedSingle;
            tabsPanel.Controls.Add(button3);
            tabsPanel.Controls.Add(button2);
            tabsPanel.Controls.Add(button1);
            tabsPanel.Location = new Point(15, 27);
            tabsPanel.Name = "tabsPanel";
            tabsPanel.Size = new Size(770, 30);
            tabsPanel.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(153, 3);
            button2.Name = "button2";
            button2.Size = new Size(144, 23);
            button2.TabIndex = 1;
            button2.Text = "Beállíltások";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(144, 23);
            button1.TabIndex = 0;
            button1.Text = "Adatlekérés";
            button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(234, 241, 247);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menüToolStripMenuItem, segítségToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            menüToolStripMenuItem.Size = new Size(56, 20);
            menüToolStripMenuItem.Text = "Kilépés";
            // 
            // segítségToolStripMenuItem
            // 
            segítségToolStripMenuItem.Name = "segítségToolStripMenuItem";
            segítségToolStripMenuItem.Size = new Size(63, 20);
            segítségToolStripMenuItem.Text = "Segítség";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(15, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 350);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(statusStrip1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 426);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 24);
            panel2.TabIndex = 3;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(234, 241, 247);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3, toolStripStatusLabel4 });
            statusStrip1.Location = new Point(0, 2);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.ForeColor = Color.FromArgb(91, 112, 131);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(267, 17);
            toolStripStatusLabel1.Text = "Hódmezővásárhely MJV Kabinetiroda Informatika";
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.ForeColor = Color.FromArgb(91, 112, 131);
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(105, 17);
            toolStripStatusLabel2.Text = "06 62 530 100 / 240";
            toolStripStatusLabel2.Click += toolStripStatusLabel2_Click;
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.ForeColor = Color.FromArgb(91, 112, 131);
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(181, 17);
            toolStripStatusLabel3.Text = "helpdesk@hodmezovasarhely.hu";
            toolStripStatusLabel3.Click += toolStripStatusLabel3_Click;
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(28, 17);
            toolStripStatusLabel4.Text = "v1.0";
            // 
            // button3
            // 
            button3.Location = new Point(303, 3);
            button3.Name = "button3";
            button3.Size = new Size(144, 23);
            button3.TabIndex = 2;
            button3.Text = "Jelszómódosítás";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 250, 253);
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(tabsPanel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "RGYT 2.0";
            tabsPanel.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel tabsPanel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menüToolStripMenuItem;
        private Button button1;
        private Panel panel1;
        private Button button2;
        private Panel panel2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripMenuItem segítségToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private Button button3;
    }
}