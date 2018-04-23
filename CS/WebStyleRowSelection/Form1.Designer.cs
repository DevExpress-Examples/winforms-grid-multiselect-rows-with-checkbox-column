namespace WebStyleRowSelection {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.icbShowCheckBoxSelectorInHeader = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.icbShowCheckBoxSelectorInGroupRow = new DevExpress.XtraEditors.ImageComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbShowCheckBoxSelectorInHeader.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbShowCheckBoxSelectorInGroupRow.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 79);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(559, 348);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.icbShowCheckBoxSelectorInHeader);
            this.panelControl1.Controls.Add(this.icbShowCheckBoxSelectorInGroupRow);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(559, 79);
            this.panelControl1.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 45);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(214, 13);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Show Check Box Selector In Column Header:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(194, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Show Check Box Selector In Group Row:";
            // 
            // icbShowCheckBoxSelectorInHeader
            // 
            this.icbShowCheckBoxSelectorInHeader.Location = new System.Drawing.Point(250, 42);
            this.icbShowCheckBoxSelectorInHeader.Name = "icbShowCheckBoxSelectorInHeader";
            this.icbShowCheckBoxSelectorInHeader.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbShowCheckBoxSelectorInHeader.Size = new System.Drawing.Size(136, 20);
            this.icbShowCheckBoxSelectorInHeader.TabIndex = 11;
            this.icbShowCheckBoxSelectorInHeader.SelectedIndexChanged += new System.EventHandler(this.icbShowCheckBoxSelectorInHeader_SelectedIndexChanged);
            // 
            // icbShowCheckBoxSelectorInGroupRow
            // 
            this.icbShowCheckBoxSelectorInGroupRow.Location = new System.Drawing.Point(250, 14);
            this.icbShowCheckBoxSelectorInGroupRow.Name = "icbShowCheckBoxSelectorInGroupRow";
            this.icbShowCheckBoxSelectorInGroupRow.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbShowCheckBoxSelectorInGroupRow.Size = new System.Drawing.Size(136, 20);
            this.icbShowCheckBoxSelectorInGroupRow.TabIndex = 10;
            this.icbShowCheckBoxSelectorInGroupRow.SelectedIndexChanged += new System.EventHandler(this.icbShowCheckBoxSelectorInGroupRow_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 427);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbShowCheckBoxSelectorInHeader.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbShowCheckBoxSelectorInGroupRow.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbShowCheckBoxSelectorInHeader;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbShowCheckBoxSelectorInGroupRow;
    }
}

