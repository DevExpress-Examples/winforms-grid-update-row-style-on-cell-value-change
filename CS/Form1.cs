using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        public int GetRandomValue()
        {
            return r.Next(100) + 50;
        }
        private DataTable CreateTable(int RowCount)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("UseStyles", typeof(bool));
            tbl.Columns.Add("R", typeof(int));
            tbl.Columns.Add("G", typeof(int));
            tbl.Columns.Add("B", typeof(int));
            for (int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { String.Format("Name{0}", i), false, GetRandomValue(), GetRandomValue(), GetRandomValue() });
            return tbl;
        }


        public Form1()
        {
            AppearanceObject.DefaultFont = new Font(AppearanceObject.DefaultFont.FontFamily, 14, FontStyle.Bold);
            InitializeComponent();
            gridControl1.DataSource = CreateTable(5);
            RepositoryItemCheckEdit riCheckEdit = new RepositoryItemCheckEdit();
            gridView1.Columns["UseStyles"].ColumnEdit = riCheckEdit;
            RepositoryItemTrackBar riTrackBar = new RepositoryItemTrackBar();
            riTrackBar.Maximum = 255;
            gridView1.Columns["R"].ColumnEdit = riTrackBar;
            gridView1.Columns["G"].ColumnEdit = riTrackBar;
            gridView1.Columns["B"].ColumnEdit = riTrackBar;
            riCheckEdit.EditValueChanged += OnEditValueChanged;
            riTrackBar.EditValueChanged += OnEditValueChanged;
            gridView1.RowCellStyle += new RowCellStyleEventHandler(gridView1_RowCellStyle);
        }

        void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (!true.Equals(gridView1.GetRowCellValue(e.RowHandle, "UseStyles")))
                return;
            e.Appearance.BackColor = GetRowBackColor(e.RowHandle);
        }

        void OnEditValueChanged(object sender, EventArgs e)
        {
            gridView1.PostEditor();
        }

        private Color GetRowBackColor(int rowHandle)
        {
            return Color.FromArgb(GetColorValue(rowHandle, "R"), GetColorValue(rowHandle, "G"), GetColorValue(rowHandle, "B"));
        }
        private int GetColorValue(int rowHandle, string fieldName)
        {
            return (int)gridView1.GetRowCellValue(rowHandle, fieldName);
        }
    }
}