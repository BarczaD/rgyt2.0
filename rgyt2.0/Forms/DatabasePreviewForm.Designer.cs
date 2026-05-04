namespace rgyt2._0.Forms
{
    partial class DatabasePreviewForm
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
            splitContainer1 = new SplitContainer();
            childGridView = new DataGridView();
            parentGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)childGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)parentGridView).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(childGridView);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(parentGridView);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 398;
            splitContainer1.TabIndex = 0;
            // 
            // childGridView
            // 
            childGridView.AllowUserToAddRows = false;
            childGridView.AllowUserToDeleteRows = false;
            childGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            childGridView.Dock = DockStyle.Fill;
            childGridView.Location = new Point(0, 0);
            childGridView.Name = "childGridView";
            childGridView.ReadOnly = true;
            childGridView.Size = new Size(398, 450);
            childGridView.TabIndex = 0;
            // 
            // parentGridView
            // 
            parentGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            parentGridView.Dock = DockStyle.Fill;
            parentGridView.Location = new Point(0, 0);
            parentGridView.Name = "parentGridView";
            parentGridView.Size = new Size(398, 450);
            parentGridView.TabIndex = 0;
            // 
            // DatabasePreviewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "DatabasePreviewForm";
            Text = "DatabasePreviewForm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)childGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)parentGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView childGridView;
        private DataGridView parentGridView;
    }
}