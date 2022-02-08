Namespace WebStyleRowSelection

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.icbShowCheckBoxSelectorInHeader = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.icbShowCheckBoxSelectorInGroupRow = New DevExpress.XtraEditors.ImageComboBoxEdit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.icbShowCheckBoxSelectorInHeader.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbShowCheckBoxSelectorInGroupRow.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 79)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(559, 348)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.labelControl2)
            Me.panelControl1.Controls.Add(Me.labelControl1)
            Me.panelControl1.Controls.Add(Me.icbShowCheckBoxSelectorInHeader)
            Me.panelControl1.Controls.Add(Me.icbShowCheckBoxSelectorInGroupRow)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(559, 79)
            Me.panelControl1.TabIndex = 1
            ' 
            ' labelControl2
            ' 
            Me.labelControl2.Location = New System.Drawing.Point(15, 45)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(214, 13)
            Me.labelControl2.TabIndex = 13
            Me.labelControl2.Text = "Show Check Box Selector In Column Header:"
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Location = New System.Drawing.Point(15, 17)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(194, 13)
            Me.labelControl1.TabIndex = 12
            Me.labelControl1.Text = "Show Check Box Selector In Group Row:"
            ' 
            ' icbShowCheckBoxSelectorInHeader
            ' 
            Me.icbShowCheckBoxSelectorInHeader.Location = New System.Drawing.Point(250, 42)
            Me.icbShowCheckBoxSelectorInHeader.Name = "icbShowCheckBoxSelectorInHeader"
            Me.icbShowCheckBoxSelectorInHeader.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbShowCheckBoxSelectorInHeader.Size = New System.Drawing.Size(136, 20)
            Me.icbShowCheckBoxSelectorInHeader.TabIndex = 11
            AddHandler Me.icbShowCheckBoxSelectorInHeader.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbShowCheckBoxSelectorInHeader_SelectedIndexChanged)
            ' 
            ' icbShowCheckBoxSelectorInGroupRow
            ' 
            Me.icbShowCheckBoxSelectorInGroupRow.Location = New System.Drawing.Point(250, 14)
            Me.icbShowCheckBoxSelectorInGroupRow.Name = "icbShowCheckBoxSelectorInGroupRow"
            Me.icbShowCheckBoxSelectorInGroupRow.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbShowCheckBoxSelectorInGroupRow.Size = New System.Drawing.Size(136, 20)
            Me.icbShowCheckBoxSelectorInGroupRow.TabIndex = 10
            AddHandler Me.icbShowCheckBoxSelectorInGroupRow.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbShowCheckBoxSelectorInGroupRow_SelectedIndexChanged)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(559, 427)
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            CType((Me.icbShowCheckBoxSelectorInHeader.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbShowCheckBoxSelectorInGroupRow.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private labelControl2 As DevExpress.XtraEditors.LabelControl

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private icbShowCheckBoxSelectorInHeader As DevExpress.XtraEditors.ImageComboBoxEdit

        Private icbShowCheckBoxSelectorInGroupRow As DevExpress.XtraEditors.ImageComboBoxEdit
    End Class
End Namespace
