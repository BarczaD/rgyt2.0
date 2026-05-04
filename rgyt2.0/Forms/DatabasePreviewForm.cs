using rgyt2._0.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rgyt2._0.Forms
{
    public partial class DatabasePreviewForm : Form
    {

        public DatabasePreviewForm()
        {
            InitializeComponent();
            this.Shown += DatabasePreviewForm_Shown;
        }

        private void DatabasePreviewForm_Shown(object? sender, EventArgs e)
        {
            // UI már biztosan kész
            BeginInvoke(new Action(LoadDbfToGrids));
        }


        private void LoadDbfToGrids()
        {

            var children = new BindingList<Child>(Program.DbfContext.GetChildren().ToList());
            var parents = new BindingList<Parent>(Program.DbfContext.GetParents().ToList());


            // ---- Gyerek grid ----
            childGridView.SuspendLayout();
            childGridView.VirtualMode = false;
            childGridView.DataSource = null;
            childGridView.Columns.Clear();
            childGridView.AutoGenerateColumns = true;
            childGridView.DataSource = children;
            childGridView.ResumeLayout();

            // ---- Szülő grid ----
            parentGridView.SuspendLayout();
            parentGridView.VirtualMode = false;
            parentGridView.DataSource = null;
            parentGridView.Columns.Clear();
            parentGridView.AutoGenerateColumns = true;
            parentGridView.DataSource = new BindingSource { DataSource = parents };
            parentGridView.ResumeLayout();
            /*
            MessageBox.Show(
                $"Grid binding kész.\nGyerek: {children.Count}\nSzülő: {parents.Count}",
                "DBF betöltés OK"
            );
            */
        }
    }
}
