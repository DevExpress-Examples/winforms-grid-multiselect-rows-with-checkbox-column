using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;

namespace WebStyleRowSelection {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // load some sample data and configure demo columns
            new DevExpress.XtraGrid.Design.XViewsPrinting(gridControl1);

            gridView1.Columns["Category"].GroupIndex = 0;
            gridView1.ExpandAllGroups();

            gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            gridView1.OptionsSelection.MultiSelect = true;

            icbShowCheckBoxSelectorInGroupRow.Properties.Items.AddEnum(typeof(DefaultBoolean));
            icbShowCheckBoxSelectorInHeader.Properties.Items.AddEnum(typeof(DefaultBoolean));
                
            icbShowCheckBoxSelectorInGroupRow.EditValue = gridView1.OptionsSelection.ShowCheckBoxSelectorInGroupRow;
            icbShowCheckBoxSelectorInHeader.EditValue = gridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader;
        }

        private void icbShowCheckBoxSelectorInGroupRow_SelectedIndexChanged(object sender, EventArgs e) {
            gridView1.OptionsSelection.ShowCheckBoxSelectorInGroupRow = (DefaultBoolean)icbShowCheckBoxSelectorInGroupRow.EditValue;
        }

        private void icbShowCheckBoxSelectorInHeader_SelectedIndexChanged(object sender, EventArgs e) {
            gridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = (DefaultBoolean)icbShowCheckBoxSelectorInHeader.EditValue;
        }
    }
}
