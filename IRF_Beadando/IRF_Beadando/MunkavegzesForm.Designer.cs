namespace IRF_Beadando
{
    partial class MunkavegzesForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tKTEGJ_IRFDataSet = new IRF_Beadando.TKTEGJ_IRFDataSet();
            this.tevekenysegBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tevekenysegTableAdapter = new IRF_Beadando.TKTEGJ_IRFDataSetTableAdapters.TevekenysegTableAdapter();
            this.tableAdapterManager = new IRF_Beadando.TKTEGJ_IRFDataSetTableAdapters.TableAdapterManager();
            this.munkavegzesTableAdapter = new IRF_Beadando.TKTEGJ_IRFDataSetTableAdapters.MunkavegzesTableAdapter();
            this.munkavegzesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dolgozoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tevekenysegIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kezdodatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vegdatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.megjegyzesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ugyfelazonositoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iktatoszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iktatottoldalszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ledolgozottDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTevekenyseg = new System.Windows.Forms.ComboBox();
            this.bStart = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.lbOra = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tKTEGJ_IRFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tevekenysegBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.munkavegzesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbOra);
            this.splitContainer1.Panel1.Controls.Add(this.bStop);
            this.splitContainer1.Panel1.Controls.Add(this.bStart);
            this.splitContainer1.Panel1.Controls.Add(this.cbTevekenyseg);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 226;
            this.splitContainer1.TabIndex = 0;
            // 
            // tKTEGJ_IRFDataSet
            // 
            this.tKTEGJ_IRFDataSet.DataSetName = "TKTEGJ_IRFDataSet";
            this.tKTEGJ_IRFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tevekenysegBindingSource
            // 
            this.tevekenysegBindingSource.DataMember = "Tevekenyseg";
            this.tevekenysegBindingSource.DataSource = this.tKTEGJ_IRFDataSet;
            // 
            // tevekenysegTableAdapter
            // 
            this.tevekenysegTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DolgozoTableAdapter = null;
            this.tableAdapterManager.MunkakorTableAdapter = null;
            this.tableAdapterManager.MunkavegzesTableAdapter = this.munkavegzesTableAdapter;
            this.tableAdapterManager.TevekenysegTableAdapter = this.tevekenysegTableAdapter;
            this.tableAdapterManager.UpdateOrder = IRF_Beadando.TKTEGJ_IRFDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // munkavegzesTableAdapter
            // 
            this.munkavegzesTableAdapter.ClearBeforeFill = true;
            // 
            // munkavegzesBindingSource
            // 
            this.munkavegzesBindingSource.DataMember = "Munkavegzes";
            this.munkavegzesBindingSource.DataSource = this.tKTEGJ_IRFDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dolgozoIdDataGridViewTextBoxColumn,
            this.tevekenysegIdDataGridViewTextBoxColumn,
            this.kezdodatumDataGridViewTextBoxColumn,
            this.vegdatumDataGridViewTextBoxColumn,
            this.megjegyzesDataGridViewTextBoxColumn,
            this.ugyfelazonositoDataGridViewTextBoxColumn,
            this.iktatoszamDataGridViewTextBoxColumn,
            this.iktatottoldalszamDataGridViewTextBoxColumn,
            this.ledolgozottDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.munkavegzesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 220);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dolgozoIdDataGridViewTextBoxColumn
            // 
            this.dolgozoIdDataGridViewTextBoxColumn.DataPropertyName = "DolgozoId";
            this.dolgozoIdDataGridViewTextBoxColumn.HeaderText = "DolgozoId";
            this.dolgozoIdDataGridViewTextBoxColumn.Name = "dolgozoIdDataGridViewTextBoxColumn";
            // 
            // tevekenysegIdDataGridViewTextBoxColumn
            // 
            this.tevekenysegIdDataGridViewTextBoxColumn.DataPropertyName = "TevekenysegId";
            this.tevekenysegIdDataGridViewTextBoxColumn.HeaderText = "TevekenysegId";
            this.tevekenysegIdDataGridViewTextBoxColumn.Name = "tevekenysegIdDataGridViewTextBoxColumn";
            // 
            // kezdodatumDataGridViewTextBoxColumn
            // 
            this.kezdodatumDataGridViewTextBoxColumn.DataPropertyName = "Kezdodatum";
            this.kezdodatumDataGridViewTextBoxColumn.HeaderText = "Kezdodatum";
            this.kezdodatumDataGridViewTextBoxColumn.Name = "kezdodatumDataGridViewTextBoxColumn";
            // 
            // vegdatumDataGridViewTextBoxColumn
            // 
            this.vegdatumDataGridViewTextBoxColumn.DataPropertyName = "Vegdatum";
            this.vegdatumDataGridViewTextBoxColumn.HeaderText = "Vegdatum";
            this.vegdatumDataGridViewTextBoxColumn.Name = "vegdatumDataGridViewTextBoxColumn";
            // 
            // megjegyzesDataGridViewTextBoxColumn
            // 
            this.megjegyzesDataGridViewTextBoxColumn.DataPropertyName = "Megjegyzes";
            this.megjegyzesDataGridViewTextBoxColumn.HeaderText = "Megjegyzes";
            this.megjegyzesDataGridViewTextBoxColumn.Name = "megjegyzesDataGridViewTextBoxColumn";
            // 
            // ugyfelazonositoDataGridViewTextBoxColumn
            // 
            this.ugyfelazonositoDataGridViewTextBoxColumn.DataPropertyName = "Ugyfelazonosito";
            this.ugyfelazonositoDataGridViewTextBoxColumn.HeaderText = "Ugyfelazonosito";
            this.ugyfelazonositoDataGridViewTextBoxColumn.Name = "ugyfelazonositoDataGridViewTextBoxColumn";
            // 
            // iktatoszamDataGridViewTextBoxColumn
            // 
            this.iktatoszamDataGridViewTextBoxColumn.DataPropertyName = "Iktatoszam";
            this.iktatoszamDataGridViewTextBoxColumn.HeaderText = "Iktatoszam";
            this.iktatoszamDataGridViewTextBoxColumn.Name = "iktatoszamDataGridViewTextBoxColumn";
            // 
            // iktatottoldalszamDataGridViewTextBoxColumn
            // 
            this.iktatottoldalszamDataGridViewTextBoxColumn.DataPropertyName = "Iktatottoldalszam";
            this.iktatottoldalszamDataGridViewTextBoxColumn.HeaderText = "Iktatottoldalszam";
            this.iktatottoldalszamDataGridViewTextBoxColumn.Name = "iktatottoldalszamDataGridViewTextBoxColumn";
            // 
            // ledolgozottDataGridViewTextBoxColumn
            // 
            this.ledolgozottDataGridViewTextBoxColumn.DataPropertyName = "Ledolgozott";
            this.ledolgozottDataGridViewTextBoxColumn.HeaderText = "Ledolgozott";
            this.ledolgozottDataGridViewTextBoxColumn.Name = "ledolgozottDataGridViewTextBoxColumn";
            this.ledolgozottDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tevékenység";
            // 
            // cbTevekenyseg
            // 
            this.cbTevekenyseg.DataSource = this.tevekenysegBindingSource;
            this.cbTevekenyseg.DisplayMember = "Megnevezes";
            this.cbTevekenyseg.FormattingEnabled = true;
            this.cbTevekenyseg.Location = new System.Drawing.Point(145, 13);
            this.cbTevekenyseg.Name = "cbTevekenyseg";
            this.cbTevekenyseg.Size = new System.Drawing.Size(330, 21);
            this.cbTevekenyseg.TabIndex = 1;
            this.cbTevekenyseg.ValueMember = "Id";
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(145, 75);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(75, 23);
            this.bStart.TabIndex = 2;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.BStart_Click);
            // 
            // bStop
            // 
            this.bStop.Enabled = false;
            this.bStop.Location = new System.Drawing.Point(400, 75);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(75, 23);
            this.bStop.TabIndex = 3;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.BStop_Click);
            // 
            // lbOra
            // 
            this.lbOra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOra.AutoSize = true;
            this.lbOra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbOra.Location = new System.Drawing.Point(721, 13);
            this.lbOra.Name = "lbOra";
            this.lbOra.Size = new System.Drawing.Size(0, 20);
            this.lbOra.TabIndex = 4;
            this.lbOra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // MunkavegzesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MunkavegzesForm";
            this.Text = "MunkavegzesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MunkavegzesForm_FormClosing);
            this.Load += new System.EventHandler(this.MunkavegzesForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tKTEGJ_IRFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tevekenysegBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.munkavegzesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private TKTEGJ_IRFDataSet tKTEGJ_IRFDataSet;
        private System.Windows.Forms.BindingSource tevekenysegBindingSource;
        private TKTEGJ_IRFDataSetTableAdapters.TevekenysegTableAdapter tevekenysegTableAdapter;
        private TKTEGJ_IRFDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private TKTEGJ_IRFDataSetTableAdapters.MunkavegzesTableAdapter munkavegzesTableAdapter;
        private System.Windows.Forms.BindingSource munkavegzesBindingSource;
        private System.Windows.Forms.ComboBox cbTevekenyseg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dolgozoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tevekenysegIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kezdodatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vegdatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn megjegyzesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ugyfelazonositoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iktatoszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iktatottoldalszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ledolgozottDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbOra;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Timer timer1;
    }
}