namespace RGR_II.Forms
{
    partial class DataSeenEditForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dBDataSet = new RGR_II.DBDataSet();
            this.ruleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ruleTableAdapter = new RGR_II.DBDataSetTableAdapters.RuleTableAdapter();
            this.aOFFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aOFSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aOFTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ovKFFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ovKFSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arhFFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arhFSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bGFFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bGFSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bGFTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mGFFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mGFSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vTFFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vTFSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rFFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rFSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rFTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gFFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gFSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gFTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sZFFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sZFSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sZFTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHFFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHFSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tLFFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tLFSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aOFFDataGridViewTextBoxColumn,
            this.aOFSDataGridViewTextBoxColumn,
            this.aOFTDataGridViewTextBoxColumn,
            this.ovKFFDataGridViewTextBoxColumn,
            this.ovKFSDataGridViewTextBoxColumn,
            this.pDataGridViewTextBoxColumn,
            this.onPDataGridViewTextBoxColumn,
            this.arhFFDataGridViewTextBoxColumn,
            this.arhFSDataGridViewTextBoxColumn,
            this.bGFFDataGridViewTextBoxColumn,
            this.bGFSDataGridViewTextBoxColumn,
            this.bGFTDataGridViewTextBoxColumn,
            this.mGFFDataGridViewTextBoxColumn,
            this.mGFSDataGridViewTextBoxColumn,
            this.dDataGridViewTextBoxColumn,
            this.vTFFDataGridViewTextBoxColumn,
            this.vTFSDataGridViewTextBoxColumn,
            this.rFFDataGridViewTextBoxColumn,
            this.rFSDataGridViewTextBoxColumn,
            this.rFTDataGridViewTextBoxColumn,
            this.gFFDataGridViewTextBoxColumn,
            this.gFSDataGridViewTextBoxColumn,
            this.gFTDataGridViewTextBoxColumn,
            this.sZFFDataGridViewTextBoxColumn,
            this.sZFSDataGridViewTextBoxColumn,
            this.sZFTDataGridViewTextBoxColumn,
            this.tHFFDataGridViewTextBoxColumn,
            this.tHFSDataGridViewTextBoxColumn,
            this.tLFFDataGridViewTextBoxColumn,
            this.tLFSDataGridViewTextBoxColumn,
            this.tSDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ruleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 361);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ruleBindingSource
            // 
            this.ruleBindingSource.DataMember = "Rule";
            this.ruleBindingSource.DataSource = this.dBDataSet;
            // 
            // ruleTableAdapter
            // 
            this.ruleTableAdapter.ClearBeforeFill = true;
            // 
            // aOFFDataGridViewTextBoxColumn
            // 
            this.aOFFDataGridViewTextBoxColumn.DataPropertyName = "1_A_O_FF";
            this.aOFFDataGridViewTextBoxColumn.HeaderText = "1_A_O_FF";
            this.aOFFDataGridViewTextBoxColumn.Name = "aOFFDataGridViewTextBoxColumn";
            // 
            // aOFSDataGridViewTextBoxColumn
            // 
            this.aOFSDataGridViewTextBoxColumn.DataPropertyName = "1_A_O_FS";
            this.aOFSDataGridViewTextBoxColumn.HeaderText = "1_A_O_FS";
            this.aOFSDataGridViewTextBoxColumn.Name = "aOFSDataGridViewTextBoxColumn";
            // 
            // aOFTDataGridViewTextBoxColumn
            // 
            this.aOFTDataGridViewTextBoxColumn.DataPropertyName = "1_A_O_FT";
            this.aOFTDataGridViewTextBoxColumn.HeaderText = "1_A_O_FT";
            this.aOFTDataGridViewTextBoxColumn.Name = "aOFTDataGridViewTextBoxColumn";
            // 
            // ovKFFDataGridViewTextBoxColumn
            // 
            this.ovKFFDataGridViewTextBoxColumn.DataPropertyName = "2_O_vK_FF";
            this.ovKFFDataGridViewTextBoxColumn.HeaderText = "2_O_vK_FF";
            this.ovKFFDataGridViewTextBoxColumn.Name = "ovKFFDataGridViewTextBoxColumn";
            // 
            // ovKFSDataGridViewTextBoxColumn
            // 
            this.ovKFSDataGridViewTextBoxColumn.DataPropertyName = "2_O_vK_FS";
            this.ovKFSDataGridViewTextBoxColumn.HeaderText = "2_O_vK_FS";
            this.ovKFSDataGridViewTextBoxColumn.Name = "ovKFSDataGridViewTextBoxColumn";
            // 
            // pDataGridViewTextBoxColumn
            // 
            this.pDataGridViewTextBoxColumn.DataPropertyName = "3_P";
            this.pDataGridViewTextBoxColumn.HeaderText = "3_P";
            this.pDataGridViewTextBoxColumn.Name = "pDataGridViewTextBoxColumn";
            // 
            // onPDataGridViewTextBoxColumn
            // 
            this.onPDataGridViewTextBoxColumn.DataPropertyName = "4_O_nP";
            this.onPDataGridViewTextBoxColumn.HeaderText = "4_O_nP";
            this.onPDataGridViewTextBoxColumn.Name = "onPDataGridViewTextBoxColumn";
            // 
            // arhFFDataGridViewTextBoxColumn
            // 
            this.arhFFDataGridViewTextBoxColumn.DataPropertyName = "5_Arh_FF";
            this.arhFFDataGridViewTextBoxColumn.HeaderText = "5_Arh_FF";
            this.arhFFDataGridViewTextBoxColumn.Name = "arhFFDataGridViewTextBoxColumn";
            // 
            // arhFSDataGridViewTextBoxColumn
            // 
            this.arhFSDataGridViewTextBoxColumn.DataPropertyName = "5_Arh_FS";
            this.arhFSDataGridViewTextBoxColumn.HeaderText = "5_Arh_FS";
            this.arhFSDataGridViewTextBoxColumn.Name = "arhFSDataGridViewTextBoxColumn";
            // 
            // bGFFDataGridViewTextBoxColumn
            // 
            this.bGFFDataGridViewTextBoxColumn.DataPropertyName = "6_B_G_FF";
            this.bGFFDataGridViewTextBoxColumn.HeaderText = "6_B_G_FF";
            this.bGFFDataGridViewTextBoxColumn.Name = "bGFFDataGridViewTextBoxColumn";
            // 
            // bGFSDataGridViewTextBoxColumn
            // 
            this.bGFSDataGridViewTextBoxColumn.DataPropertyName = "6_B_G_FS";
            this.bGFSDataGridViewTextBoxColumn.HeaderText = "6_B_G_FS";
            this.bGFSDataGridViewTextBoxColumn.Name = "bGFSDataGridViewTextBoxColumn";
            // 
            // bGFTDataGridViewTextBoxColumn
            // 
            this.bGFTDataGridViewTextBoxColumn.DataPropertyName = "6_B_G_FT";
            this.bGFTDataGridViewTextBoxColumn.HeaderText = "6_B_G_FT";
            this.bGFTDataGridViewTextBoxColumn.Name = "bGFTDataGridViewTextBoxColumn";
            // 
            // mGFFDataGridViewTextBoxColumn
            // 
            this.mGFFDataGridViewTextBoxColumn.DataPropertyName = "7_M_G_FF";
            this.mGFFDataGridViewTextBoxColumn.HeaderText = "7_M_G_FF";
            this.mGFFDataGridViewTextBoxColumn.Name = "mGFFDataGridViewTextBoxColumn";
            // 
            // mGFSDataGridViewTextBoxColumn
            // 
            this.mGFSDataGridViewTextBoxColumn.DataPropertyName = "7_M_G_FS";
            this.mGFSDataGridViewTextBoxColumn.HeaderText = "7_M_G_FS";
            this.mGFSDataGridViewTextBoxColumn.Name = "mGFSDataGridViewTextBoxColumn";
            // 
            // dDataGridViewTextBoxColumn
            // 
            this.dDataGridViewTextBoxColumn.DataPropertyName = "8_D";
            this.dDataGridViewTextBoxColumn.HeaderText = "8_D";
            this.dDataGridViewTextBoxColumn.Name = "dDataGridViewTextBoxColumn";
            // 
            // vTFFDataGridViewTextBoxColumn
            // 
            this.vTFFDataGridViewTextBoxColumn.DataPropertyName = "9_V_T_FF";
            this.vTFFDataGridViewTextBoxColumn.HeaderText = "9_V_T_FF";
            this.vTFFDataGridViewTextBoxColumn.Name = "vTFFDataGridViewTextBoxColumn";
            // 
            // vTFSDataGridViewTextBoxColumn
            // 
            this.vTFSDataGridViewTextBoxColumn.DataPropertyName = "9_V_T_FS";
            this.vTFSDataGridViewTextBoxColumn.HeaderText = "9_V_T_FS";
            this.vTFSDataGridViewTextBoxColumn.Name = "vTFSDataGridViewTextBoxColumn";
            // 
            // rFFDataGridViewTextBoxColumn
            // 
            this.rFFDataGridViewTextBoxColumn.DataPropertyName = "10_R_FF";
            this.rFFDataGridViewTextBoxColumn.HeaderText = "10_R_FF";
            this.rFFDataGridViewTextBoxColumn.Name = "rFFDataGridViewTextBoxColumn";
            // 
            // rFSDataGridViewTextBoxColumn
            // 
            this.rFSDataGridViewTextBoxColumn.DataPropertyName = "10_R_FS";
            this.rFSDataGridViewTextBoxColumn.HeaderText = "10_R_FS";
            this.rFSDataGridViewTextBoxColumn.Name = "rFSDataGridViewTextBoxColumn";
            // 
            // rFTDataGridViewTextBoxColumn
            // 
            this.rFTDataGridViewTextBoxColumn.DataPropertyName = "10_R_FT";
            this.rFTDataGridViewTextBoxColumn.HeaderText = "10_R_FT";
            this.rFTDataGridViewTextBoxColumn.Name = "rFTDataGridViewTextBoxColumn";
            // 
            // gFFDataGridViewTextBoxColumn
            // 
            this.gFFDataGridViewTextBoxColumn.DataPropertyName = "11_G_FF";
            this.gFFDataGridViewTextBoxColumn.HeaderText = "11_G_FF";
            this.gFFDataGridViewTextBoxColumn.Name = "gFFDataGridViewTextBoxColumn";
            // 
            // gFSDataGridViewTextBoxColumn
            // 
            this.gFSDataGridViewTextBoxColumn.DataPropertyName = "11_G_FS";
            this.gFSDataGridViewTextBoxColumn.HeaderText = "11_G_FS";
            this.gFSDataGridViewTextBoxColumn.Name = "gFSDataGridViewTextBoxColumn";
            // 
            // gFTDataGridViewTextBoxColumn
            // 
            this.gFTDataGridViewTextBoxColumn.DataPropertyName = "11_G_FT";
            this.gFTDataGridViewTextBoxColumn.HeaderText = "11_G_FT";
            this.gFTDataGridViewTextBoxColumn.Name = "gFTDataGridViewTextBoxColumn";
            // 
            // sZFFDataGridViewTextBoxColumn
            // 
            this.sZFFDataGridViewTextBoxColumn.DataPropertyName = "12_S_Z_FF";
            this.sZFFDataGridViewTextBoxColumn.HeaderText = "12_S_Z_FF";
            this.sZFFDataGridViewTextBoxColumn.Name = "sZFFDataGridViewTextBoxColumn";
            // 
            // sZFSDataGridViewTextBoxColumn
            // 
            this.sZFSDataGridViewTextBoxColumn.DataPropertyName = "12_S_Z_FS";
            this.sZFSDataGridViewTextBoxColumn.HeaderText = "12_S_Z_FS";
            this.sZFSDataGridViewTextBoxColumn.Name = "sZFSDataGridViewTextBoxColumn";
            // 
            // sZFTDataGridViewTextBoxColumn
            // 
            this.sZFTDataGridViewTextBoxColumn.DataPropertyName = "12_S_Z_FT";
            this.sZFTDataGridViewTextBoxColumn.HeaderText = "12_S_Z_FT";
            this.sZFTDataGridViewTextBoxColumn.Name = "sZFTDataGridViewTextBoxColumn";
            // 
            // tHFFDataGridViewTextBoxColumn
            // 
            this.tHFFDataGridViewTextBoxColumn.DataPropertyName = "13_T_H_FF";
            this.tHFFDataGridViewTextBoxColumn.HeaderText = "13_T_H_FF";
            this.tHFFDataGridViewTextBoxColumn.Name = "tHFFDataGridViewTextBoxColumn";
            // 
            // tHFSDataGridViewTextBoxColumn
            // 
            this.tHFSDataGridViewTextBoxColumn.DataPropertyName = "13_T_H_FS";
            this.tHFSDataGridViewTextBoxColumn.HeaderText = "13_T_H_FS";
            this.tHFSDataGridViewTextBoxColumn.Name = "tHFSDataGridViewTextBoxColumn";
            // 
            // tLFFDataGridViewTextBoxColumn
            // 
            this.tLFFDataGridViewTextBoxColumn.DataPropertyName = "14_T_L_FF";
            this.tLFFDataGridViewTextBoxColumn.HeaderText = "14_T_L_FF";
            this.tLFFDataGridViewTextBoxColumn.Name = "tLFFDataGridViewTextBoxColumn";
            // 
            // tLFSDataGridViewTextBoxColumn
            // 
            this.tLFSDataGridViewTextBoxColumn.DataPropertyName = "14_T_L_FS";
            this.tLFSDataGridViewTextBoxColumn.HeaderText = "14_T_L_FS";
            this.tLFSDataGridViewTextBoxColumn.Name = "tLFSDataGridViewTextBoxColumn";
            // 
            // tSDataGridViewTextBoxColumn
            // 
            this.tSDataGridViewTextBoxColumn.DataPropertyName = "15_T_S";
            this.tSDataGridViewTextBoxColumn.HeaderText = "15_T_S";
            this.tSDataGridViewTextBoxColumn.Name = "tSDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // DataSeenEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 386);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataSeenEditForm";
            this.Text = "DataSeenEditForm";
            this.Load += new System.EventHandler(this.DataSeenEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource ruleBindingSource;
        private DBDataSetTableAdapters.RuleTableAdapter ruleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aOFFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aOFSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aOFTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ovKFFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ovKFSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn onPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arhFFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arhFSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bGFFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bGFSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bGFTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mGFFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mGFSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vTFFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vTFSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rFFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rFSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rFTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gFFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gFSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gFTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sZFFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sZFSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sZFTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHFFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHFSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tLFFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tLFSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}