Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls

Namespace WebStyleRowSelection

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' load some sample data and configure demo columns
            Dim tmp_XViewsPrinting = New DevExpress.XtraGrid.Design.XViewsPrinting(gridControl1)
            gridView1.Columns("Category").GroupIndex = 0
            gridView1.ExpandAllGroups()
            gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
            gridView1.OptionsSelection.MultiSelect = True
            icbShowCheckBoxSelectorInGroupRow.Properties.Items.AddEnum(GetType(DefaultBoolean))
            icbShowCheckBoxSelectorInHeader.Properties.Items.AddEnum(GetType(DefaultBoolean))
            icbShowCheckBoxSelectorInGroupRow.EditValue = gridView1.OptionsSelection.ShowCheckBoxSelectorInGroupRow
            icbShowCheckBoxSelectorInHeader.EditValue = gridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader
        End Sub

        Private Sub icbShowCheckBoxSelectorInGroupRow_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            gridView1.OptionsSelection.ShowCheckBoxSelectorInGroupRow = CType(icbShowCheckBoxSelectorInGroupRow.EditValue, DefaultBoolean)
        End Sub

        Private Sub icbShowCheckBoxSelectorInHeader_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            gridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = CType(icbShowCheckBoxSelectorInHeader.EditValue, DefaultBoolean)
        End Sub
    End Class
End Namespace
