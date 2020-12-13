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
            this.chbnapzar = new System.Windows.Forms.CheckBox();
            this.bNapzar = new System.Windows.Forms.Button();
            this.tbiktatoszam = new System.Windows.Forms.TextBox();
            this.tbUgyfazo = new System.Windows.Forms.TextBox();
            this.nudiktold = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMegj = new System.Windows.Forms.TextBox();
            this.lbOra = new System.Windows.Forms.Label();
            this.bStop = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.cbTevekenyseg = new System.Windows.Forms.ComboBox();
            this.tevekenysegBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tKTEGJ_IRFDataSet = new IRF_Beadando.TKTEGJ_IRFDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvmunkavegzes = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dolgozoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tevekenysegIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kezdodatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vegdatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ledolgozottDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.megjegyzesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ugyfelazonositoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iktatoszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iktatottoldalszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.munkavegzesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tevekenysegTableAdapter = new IRF_Beadando.TKTEGJ_IRFDataSetTableAdapters.TevekenysegTableAdapter();
            this.tableAdapterManager = new IRF_Beadando.TKTEGJ_IRFDataSetTableAdapters.TableAdapterManager();
            this.munkavegzesTableAdapter = new IRF_Beadando.TKTEGJ_IRFDataSetTableAdapters.MunkavegzesTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudiktold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tevekenysegBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKTEGJ_IRFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmunkavegzes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.munkavegzesBindingSource)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.chbnapzar);
            this.splitContainer1.Panel1.Controls.Add(this.bNapzar);
            this.splitContainer1.Panel1.Controls.Add(this.tbiktatoszam);
            this.splitContainer1.Panel1.Controls.Add(this.tbUgyfazo);
            this.splitContainer1.Panel1.Controls.Add(this.nudiktold);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.tbMegj);
            this.splitContainer1.Panel1.Controls.Add(this.lbOra);
            this.splitContainer1.Panel1.Controls.Add(this.bStop);
            this.splitContainer1.Panel1.Controls.Add(this.bStart);
            this.splitContainer1.Panel1.Controls.Add(this.cbTevekenyseg);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.dgvmunkavegzes);
            this.splitContainer1.Size = new System.Drawing.Size(1007, 450);
            this.splitContainer1.SplitterDistance = 226;
            this.splitContainer1.TabIndex = 0;
            // 
            // chbnapzar
            // 
            this.chbnapzar.AutoSize = true;
            this.chbnapzar.Location = new System.Drawing.Point(711, 183);
            this.chbnapzar.Name = "chbnapzar";
            this.chbnapzar.Size = new System.Drawing.Size(105, 17);
            this.chbnapzar.TabIndex = 14;
            this.chbnapzar.Text = "Lezárom a napot";
            this.chbnapzar.UseVisualStyleBackColor = true;
            this.chbnapzar.CheckedChanged += new System.EventHandler(this.Chbnapzar_CheckedChanged);
            // 
            // bNapzar
            // 
            this.bNapzar.Enabled = false;
            this.bNapzar.Location = new System.Drawing.Point(839, 169);
            this.bNapzar.Name = "bNapzar";
            this.bNapzar.Size = new System.Drawing.Size(75, 42);
            this.bNapzar.TabIndex = 13;
            this.bNapzar.Text = "Nap zárása (.csv export)";
            this.bNapzar.UseVisualStyleBackColor = true;
            this.bNapzar.Click += new System.EventHandler(this.BNapzar_Click);
            // 
            // tbiktatoszam
            // 
            this.tbiktatoszam.Location = new System.Drawing.Point(601, 49);
            this.tbiktatoszam.Name = "tbiktatoszam";
            this.tbiktatoszam.Size = new System.Drawing.Size(100, 20);
            this.tbiktatoszam.TabIndex = 12;
            // 
            // tbUgyfazo
            // 
            this.tbUgyfazo.Location = new System.Drawing.Point(617, 19);
            this.tbUgyfazo.Name = "tbUgyfazo";
            this.tbUgyfazo.Size = new System.Drawing.Size(100, 20);
            this.tbUgyfazo.TabIndex = 11;
            // 
            // nudiktold
            // 
            this.nudiktold.Location = new System.Drawing.Point(590, 96);
            this.nudiktold.Name = "nudiktold";
            this.nudiktold.Size = new System.Drawing.Size(120, 20);
            this.nudiktold.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(514, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Iktatott oldalak";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(511, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Iktatószám";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ugyfélazonosító";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Megjegyzés";
            // 
            // tbMegj
            // 
            this.tbMegj.Location = new System.Drawing.Point(145, 49);
            this.tbMegj.Multiline = true;
            this.tbMegj.Name = "tbMegj";
            this.tbMegj.Size = new System.Drawing.Size(330, 63);
            this.tbMegj.TabIndex = 5;
            // 
            // lbOra
            // 
            this.lbOra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOra.AutoSize = true;
            this.lbOra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbOra.Location = new System.Drawing.Point(928, 13);
            this.lbOra.Name = "lbOra";
            this.lbOra.Size = new System.Drawing.Size(0, 20);
            this.lbOra.TabIndex = 4;
            this.lbOra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bStop
            // 
            this.bStop.BackColor = System.Drawing.Color.Red;
            this.bStop.Enabled = false;
            this.bStop.FlatAppearance.BorderSize = 0;
            this.bStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bStop.Location = new System.Drawing.Point(372, 145);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(75, 31);
            this.bStop.TabIndex = 3;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = false;
            this.bStop.Click += new System.EventHandler(this.BStop_Click);
            // 
            // bStart
            // 
            this.bStart.BackColor = System.Drawing.Color.Chartreuse;
            this.bStart.FlatAppearance.BorderSize = 0;
            this.bStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bStart.Location = new System.Drawing.Point(198, 145);
            this.bStart.Margin = new System.Windows.Forms.Padding(0);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(75, 31);
            this.bStart.TabIndex = 2;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = false;
            this.bStart.Click += new System.EventHandler(this.BStart_Click);
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
            // tevekenysegBindingSource
            // 
            this.tevekenysegBindingSource.DataMember = "Tevekenyseg";
            this.tevekenysegBindingSource.DataSource = this.tKTEGJ_IRFDataSet;
            // 
            // tKTEGJ_IRFDataSet
            // 
            this.tKTEGJ_IRFDataSet.DataSetName = "TKTEGJ_IRFDataSet";
            this.tKTEGJ_IRFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dgvmunkavegzes
            // 
            this.dgvmunkavegzes.AutoGenerateColumns = false;
            this.dgvmunkavegzes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmunkavegzes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dolgozoIdDataGridViewTextBoxColumn,
            this.tevekenysegIdDataGridViewTextBoxColumn,
            this.kezdodatumDataGridViewTextBoxColumn,
            this.vegdatumDataGridViewTextBoxColumn,
            this.ledolgozottDataGridViewTextBoxColumn,
            this.megjegyzesDataGridViewTextBoxColumn,
            this.ugyfelazonositoDataGridViewTextBoxColumn,
            this.iktatoszamDataGridViewTextBoxColumn,
            this.iktatottoldalszamDataGridViewTextBoxColumn});
            this.dgvmunkavegzes.DataSource = this.munkavegzesBindingSource;
            this.dgvmunkavegzes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvmunkavegzes.Location = new System.Drawing.Point(0, 0);
            this.dgvmunkavegzes.Name = "dgvmunkavegzes";
            this.dgvmunkavegzes.Size = new System.Drawing.Size(1007, 220);
            this.dgvmunkavegzes.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // dolgozoIdDataGridViewTextBoxColumn
            // 
            this.dolgozoIdDataGridViewTextBoxColumn.DataPropertyName = "DolgozoId";
            this.dolgozoIdDataGridViewTextBoxColumn.HeaderText = "DolgozoId";
            this.dolgozoIdDataGridViewTextBoxColumn.Name = "dolgozoIdDataGridViewTextBoxColumn";
            this.dolgozoIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // tevekenysegIdDataGridViewTextBoxColumn
            // 
            this.tevekenysegIdDataGridViewTextBoxColumn.DataPropertyName = "TevekenysegId";
            this.tevekenysegIdDataGridViewTextBoxColumn.DataSource = this.tevekenysegBindingSource;
            this.tevekenysegIdDataGridViewTextBoxColumn.DisplayMember = "Megnevezes";
            this.tevekenysegIdDataGridViewTextBoxColumn.HeaderText = "Tevekenyseg";
            this.tevekenysegIdDataGridViewTextBoxColumn.Name = "tevekenysegIdDataGridViewTextBoxColumn";
            this.tevekenysegIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.tevekenysegIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tevekenysegIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tevekenysegIdDataGridViewTextBoxColumn.ValueMember = "Id";
            this.tevekenysegIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // kezdodatumDataGridViewTextBoxColumn
            // 
            this.kezdodatumDataGridViewTextBoxColumn.DataPropertyName = "Kezdodatum";
            this.kezdodatumDataGridViewTextBoxColumn.HeaderText = "Kezdodatum";
            this.kezdodatumDataGridViewTextBoxColumn.Name = "kezdodatumDataGridViewTextBoxColumn";
            this.kezdodatumDataGridViewTextBoxColumn.Width = 120;
            // 
            // vegdatumDataGridViewTextBoxColumn
            // 
            this.vegdatumDataGridViewTextBoxColumn.DataPropertyName = "Vegdatum";
            this.vegdatumDataGridViewTextBoxColumn.HeaderText = "Vegdatum";
            this.vegdatumDataGridViewTextBoxColumn.Name = "vegdatumDataGridViewTextBoxColumn";
            this.vegdatumDataGridViewTextBoxColumn.Width = 120;
            // 
            // ledolgozottDataGridViewTextBoxColumn
            // 
            this.ledolgozottDataGridViewTextBoxColumn.DataPropertyName = "Ledolgozott";
            this.ledolgozottDataGridViewTextBoxColumn.HeaderText = "Ledolgozott (perc)";
            this.ledolgozottDataGridViewTextBoxColumn.Name = "ledolgozottDataGridViewTextBoxColumn";
            this.ledolgozottDataGridViewTextBoxColumn.ReadOnly = true;
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
            // munkavegzesBindingSource
            // 
            this.munkavegzesBindingSource.DataMember = "Munkavegzes";
            this.munkavegzesBindingSource.DataSource = this.tKTEGJ_IRFDataSet;
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
            // timer1
            // 
            this.timer1.Interval = 999;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // MunkavegzesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 450);
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
            ((System.ComponentModel.ISupportInitialize)(this.nudiktold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tevekenysegBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKTEGJ_IRFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmunkavegzes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.munkavegzesBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvmunkavegzes;
        private System.Windows.Forms.Label lbOra;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbiktatoszam;
        private System.Windows.Forms.TextBox tbUgyfazo;
        private System.Windows.Forms.NumericUpDown nudiktold;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMegj;
        private System.Windows.Forms.CheckBox chbnapzar;
        private System.Windows.Forms.Button bNapzar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dolgozoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tevekenysegIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kezdodatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vegdatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ledolgozottDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn megjegyzesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ugyfelazonositoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iktatoszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iktatottoldalszamDataGridViewTextBoxColumn;
    }
}