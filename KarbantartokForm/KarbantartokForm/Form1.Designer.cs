namespace KarbantartokForm
{
    partial class Form1
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
            this.bindingSourceAllData = new System.Windows.Forms.BindingSource(this.components);
            this.karbantartokDataSet = new KarbantartokForm.karbantartokDataSet();
            this.karbantartasokTableAdapter = new KarbantartokForm.karbantartokDataSetTableAdapters.karbantartasokTableAdapter();
            this.karbantartokTableAdapter = new KarbantartokForm.karbantartokDataSetTableAdapters.KarbantartokTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.megrendeloNeveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vegezettMunkaTipusaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szereloNeveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oradijDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAllData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karbantartokDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSourceAllData
            // 
            this.bindingSourceAllData.DataMember = "Karbantartok";
            this.bindingSourceAllData.DataSource = this.karbantartokDataSet;
            this.bindingSourceAllData.Sort = "SzereloNeve, datum desc";
            // 
            // karbantartokDataSet
            // 
            this.karbantartokDataSet.DataSetName = "karbantartokDataSet";
            this.karbantartokDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // karbantartasokTableAdapter
            // 
            this.karbantartasokTableAdapter.ClearBeforeFill = true;
            // 
            // karbantartokTableAdapter
            // 
            this.karbantartokTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.222222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.777778F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.TabStop = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(722, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.megrendeloNeveDataGridViewTextBoxColumn,
            this.cimDataGridViewTextBoxColumn,
            this.vegezettMunkaTipusaDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.szereloNeveDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.oradijDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourceAllData;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(693, 407);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // megrendeloNeveDataGridViewTextBoxColumn
            // 
            this.megrendeloNeveDataGridViewTextBoxColumn.DataPropertyName = "MegrendeloNeve";
            this.megrendeloNeveDataGridViewTextBoxColumn.HeaderText = "MegrendeloNeve";
            this.megrendeloNeveDataGridViewTextBoxColumn.Name = "megrendeloNeveDataGridViewTextBoxColumn";
            this.megrendeloNeveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cimDataGridViewTextBoxColumn
            // 
            this.cimDataGridViewTextBoxColumn.DataPropertyName = "Cim";
            this.cimDataGridViewTextBoxColumn.HeaderText = "Cim";
            this.cimDataGridViewTextBoxColumn.Name = "cimDataGridViewTextBoxColumn";
            this.cimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vegezettMunkaTipusaDataGridViewTextBoxColumn
            // 
            this.vegezettMunkaTipusaDataGridViewTextBoxColumn.DataPropertyName = "Vegezett munka tipusa";
            this.vegezettMunkaTipusaDataGridViewTextBoxColumn.HeaderText = "Vegezett munka tipusa";
            this.vegezettMunkaTipusaDataGridViewTextBoxColumn.Name = "vegezettMunkaTipusaDataGridViewTextBoxColumn";
            this.vegezettMunkaTipusaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Megrendelo telefonszama";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // szereloNeveDataGridViewTextBoxColumn
            // 
            this.szereloNeveDataGridViewTextBoxColumn.DataPropertyName = "SzereloNeve";
            this.szereloNeveDataGridViewTextBoxColumn.HeaderText = "SzereloNeve";
            this.szereloNeveDataGridViewTextBoxColumn.Name = "szereloNeveDataGridViewTextBoxColumn";
            this.szereloNeveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oradijDataGridViewTextBoxColumn
            // 
            this.oradijDataGridViewTextBoxColumn.DataPropertyName = "oradij";
            this.oradijDataGridViewTextBoxColumn.HeaderText = "Oradij";
            this.oradijDataGridViewTextBoxColumn.Name = "oradijDataGridViewTextBoxColumn";
            this.oradijDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAllData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karbantartokDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceAllData;
        private karbantartokDataSet karbantartokDataSet;
        private karbantartokDataSetTableAdapters.karbantartasokTableAdapter karbantartasokTableAdapter;
        private karbantartokDataSetTableAdapters.KarbantartokTableAdapter karbantartokTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn megrendeloNeveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vegezettMunkaTipusaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szereloNeveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oradijDataGridViewTextBoxColumn;
    }
}

