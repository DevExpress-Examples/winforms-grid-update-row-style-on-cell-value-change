Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Private r As New Random()
		Public Function GetRandomValue() As Integer
			Return r.Next(100) + 50
		End Function
		Private Function CreateTable(ByVal RowCount As Integer) As DataTable
			Dim tbl As New DataTable()
			tbl.Columns.Add("Name", GetType(String))
			tbl.Columns.Add("UseStyles", GetType(Boolean))
			tbl.Columns.Add("R", GetType(Integer))
			tbl.Columns.Add("G", GetType(Integer))
			tbl.Columns.Add("B", GetType(Integer))
			For i As Integer = 0 To RowCount - 1
				tbl.Rows.Add(New Object() { String.Format("Name{0}", i), False, GetRandomValue(), GetRandomValue(), GetRandomValue() })
			Next i
			Return tbl
		End Function


		Public Sub New()
			AppearanceObject.DefaultFont = New Font(AppearanceObject.DefaultFont.FontFamily, 14, FontStyle.Bold)
			InitializeComponent()
			gridControl1.DataSource = CreateTable(5)
			Dim riCheckEdit As New RepositoryItemCheckEdit()
			gridView1.Columns("UseStyles").ColumnEdit = riCheckEdit
			Dim riTrackBar As New RepositoryItemTrackBar()
			riTrackBar.Maximum = 255
			gridView1.Columns("R").ColumnEdit = riTrackBar
			gridView1.Columns("G").ColumnEdit = riTrackBar
			gridView1.Columns("B").ColumnEdit = riTrackBar
			AddHandler riCheckEdit.EditValueChanged, AddressOf OnEditValueChanged
			AddHandler riTrackBar.EditValueChanged, AddressOf OnEditValueChanged
			AddHandler gridView1.RowCellStyle, AddressOf gridView1_RowCellStyle
		End Sub

		Private Sub gridView1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs)
			If (Not True.Equals(gridView1.GetRowCellValue(e.RowHandle, "UseStyles"))) Then
				Return
			End If
			e.Appearance.BackColor = GetRowBackColor(e.RowHandle)
		End Sub

		Private Sub OnEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			gridView1.PostEditor()
		End Sub

		Private Function GetRowBackColor(ByVal rowHandle As Integer) As Color
			Return Color.FromArgb(GetColorValue(rowHandle, "R"), GetColorValue(rowHandle, "G"), GetColorValue(rowHandle, "B"))
		End Function
		Private Function GetColorValue(ByVal rowHandle As Integer, ByVal fieldName As String) As Integer
			Return CInt(Fix(gridView1.GetRowCellValue(rowHandle, fieldName)))
		End Function
	End Class
End Namespace