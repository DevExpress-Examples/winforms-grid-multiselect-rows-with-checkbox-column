Imports System.ComponentModel
Imports System.Text
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls

Namespace WebStyleRowSelection
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' load some sample data and configure demo columns
			Dim TempXViewsPrinting As DevExpress.XtraGrid.Design.XViewsPrinting = New DevExpress.XtraGrid.Design.XViewsPrinting(gridControl1)

			gridView1.Columns("Category").GroupIndex = 0
			gridView1.ExpandAllGroups()

			gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
			gridView1.OptionsSelection.MultiSelect = True

            icbShowCheckBoxSelectorInGroupRow.Properties.Items.AddEnum(GetType(DefaultBoolean))
            icbShowCheckBoxSelectorInHeader.Properties.Items.AddEnum(GetType(DefaultBoolean))
            
			icbShowCheckBoxSelectorInGroupRow.EditValue = gridView1.OptionsSelection.ShowCheckBoxSelectorInGroupRow
			icbShowCheckBoxSelectorInHeader.EditValue = gridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader
		End Sub

		Private Sub icbShowCheckBoxSelectorInGroupRow_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbShowCheckBoxSelectorInGroupRow.SelectedIndexChanged
			gridView1.OptionsSelection.ShowCheckBoxSelectorInGroupRow = CType(icbShowCheckBoxSelectorInGroupRow.EditValue, DefaultBoolean)
		End Sub

		Private Sub icbShowCheckBoxSelectorInHeader_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbShowCheckBoxSelectorInHeader.SelectedIndexChanged
			gridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = CType(icbShowCheckBoxSelectorInHeader.EditValue, DefaultBoolean)
		End Sub
	End Class
End Namespace
