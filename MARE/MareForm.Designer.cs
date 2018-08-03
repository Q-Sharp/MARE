namespace MARE
{
    partial class MareForm
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
            if(disposing && (components != null))
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
            this.oDGV = new System.Windows.Forms.DataGridView();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kMDEnableInternalLargePageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.enableCrossFireAutoLinkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.enableUlpsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.oGFXDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oGFXDataSet = new MARE.GFXDataSet();
            this.oTBL = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.oExit = new System.Windows.Forms.Button();
            this.oSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.oDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oGFXDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oGFXDataSet)).BeginInit();
            this.oTBL.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // oDGV
            // 
            this.oDGV.AllowUserToAddRows = false;
            this.oDGV.AllowUserToDeleteRows = false;
            this.oDGV.AllowUserToResizeColumns = false;
            this.oDGV.AllowUserToResizeRows = false;
            this.oDGV.AutoGenerateColumns = false;
            this.oDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.oDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.oDGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.oDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn,
            this.descDataGridViewTextBoxColumn,
            this.kMDEnableInternalLargePageDataGridViewTextBoxColumn,
            this.enableCrossFireAutoLinkDataGridViewTextBoxColumn,
            this.enableUlpsDataGridViewTextBoxColumn});
            this.oDGV.DataSource = this.oGFXDataSetBindingSource;
            this.oDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oDGV.Location = new System.Drawing.Point(3, 3);
            this.oDGV.MultiSelect = false;
            this.oDGV.Name = "oDGV";
            this.oDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.oDGV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.oDGV.Size = new System.Drawing.Size(578, 319);
            this.oDGV.TabIndex = 0;
            this.oDGV.VirtualMode = true;
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            this.noDataGridViewTextBoxColumn.HeaderText = "No";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            this.noDataGridViewTextBoxColumn.ReadOnly = true;
            this.noDataGridViewTextBoxColumn.Width = 46;
            // 
            // descDataGridViewTextBoxColumn
            // 
            this.descDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descDataGridViewTextBoxColumn.DataPropertyName = "Desc";
            this.descDataGridViewTextBoxColumn.HeaderText = "Desc";
            this.descDataGridViewTextBoxColumn.Name = "descDataGridViewTextBoxColumn";
            this.descDataGridViewTextBoxColumn.ReadOnly = true;
            this.descDataGridViewTextBoxColumn.Width = 57;
            // 
            // kMDEnableInternalLargePageDataGridViewTextBoxColumn
            // 
            this.kMDEnableInternalLargePageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kMDEnableInternalLargePageDataGridViewTextBoxColumn.DataPropertyName = "KMD_EnableInternalLargePage";
            this.kMDEnableInternalLargePageDataGridViewTextBoxColumn.FalseValue = "0";
            this.kMDEnableInternalLargePageDataGridViewTextBoxColumn.HeaderText = "KMD_EnableInternalLargePage";
            this.kMDEnableInternalLargePageDataGridViewTextBoxColumn.IndeterminateValue = "1";
            this.kMDEnableInternalLargePageDataGridViewTextBoxColumn.Name = "kMDEnableInternalLargePageDataGridViewTextBoxColumn";
            this.kMDEnableInternalLargePageDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kMDEnableInternalLargePageDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.kMDEnableInternalLargePageDataGridViewTextBoxColumn.TrueValue = "2";
            // 
            // enableCrossFireAutoLinkDataGridViewTextBoxColumn
            // 
            this.enableCrossFireAutoLinkDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.enableCrossFireAutoLinkDataGridViewTextBoxColumn.DataPropertyName = "EnableCrossFireAutoLink";
            this.enableCrossFireAutoLinkDataGridViewTextBoxColumn.FalseValue = "0";
            this.enableCrossFireAutoLinkDataGridViewTextBoxColumn.HeaderText = "EnableCrossFireAutoLink";
            this.enableCrossFireAutoLinkDataGridViewTextBoxColumn.Name = "enableCrossFireAutoLinkDataGridViewTextBoxColumn";
            this.enableCrossFireAutoLinkDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.enableCrossFireAutoLinkDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.enableCrossFireAutoLinkDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // enableUlpsDataGridViewTextBoxColumn
            // 
            this.enableUlpsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.enableUlpsDataGridViewTextBoxColumn.DataPropertyName = "EnableUlps";
            this.enableUlpsDataGridViewTextBoxColumn.FalseValue = "0";
            this.enableUlpsDataGridViewTextBoxColumn.HeaderText = "EnableUlps";
            this.enableUlpsDataGridViewTextBoxColumn.Name = "enableUlpsDataGridViewTextBoxColumn";
            this.enableUlpsDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.enableUlpsDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.enableUlpsDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // oGFXDataSetBindingSource
            // 
            this.oGFXDataSetBindingSource.DataMember = "GFXDataTable";
            this.oGFXDataSetBindingSource.DataSource = this.oGFXDataSet;
            // 
            // oGFXDataSet
            // 
            this.oGFXDataSet.DataSetName = "GFXDataSet";
            this.oGFXDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oTBL
            // 
            this.oTBL.ColumnCount = 1;
            this.oTBL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.oTBL.Controls.Add(this.oDGV, 0, 0);
            this.oTBL.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.oTBL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oTBL.Location = new System.Drawing.Point(0, 0);
            this.oTBL.Name = "oTBL";
            this.oTBL.RowCount = 2;
            this.oTBL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.oTBL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.oTBL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.oTBL.Size = new System.Drawing.Size(584, 361);
            this.oTBL.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 325);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(584, 36);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(292, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(292, 36);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.oSave);
            this.flowLayoutPanel1.Controls.Add(this.oExit);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(89, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 30);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // oExit
            // 
            this.oExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.oExit.Location = new System.Drawing.Point(41, 3);
            this.oExit.Name = "oExit";
            this.oExit.Size = new System.Drawing.Size(75, 23);
            this.oExit.TabIndex = 1;
            this.oExit.Text = "Exit";
            this.oExit.UseVisualStyleBackColor = true;
            this.oExit.Click += new System.EventHandler(this.oExit_Click);
            // 
            // oSave
            // 
            this.oSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.oSave.Location = new System.Drawing.Point(122, 3);
            this.oSave.Name = "oSave";
            this.oSave.Size = new System.Drawing.Size(75, 23);
            this.oSave.TabIndex = 0;
            this.oSave.Text = "Save";
            this.oSave.UseVisualStyleBackColor = true;
            this.oSave.Click += new System.EventHandler(this.oSave_Click);
            // 
            // MareForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.oTBL);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "MareForm";
            this.ShowIcon = false;
            this.Text = "MARE";
            this.Load += new System.EventHandler(this.MareForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oGFXDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oGFXDataSet)).EndInit();
            this.oTBL.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView oDGV;
        private System.Windows.Forms.TableLayoutPanel oTBL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button oExit;
        private System.Windows.Forms.Button oSave;
        private System.Windows.Forms.BindingSource oGFXDataSetBindingSource;
        private GFXDataSet oGFXDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn kMDEnableInternalLargePageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enableCrossFireAutoLinkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enableUlpsDataGridViewTextBoxColumn;
    }
}

