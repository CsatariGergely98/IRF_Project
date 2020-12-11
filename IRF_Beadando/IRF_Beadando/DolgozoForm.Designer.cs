namespace IRF_Beadando
{ 
    partial class DolgozoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DolgozoForm));
            this.IRFDataSet= new IRF_Beadando.TKTEGJ_IRFDataSet();
            this.dolgozoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dolgozoTableAdapter = new IRF_Beadando.TKTEGJ_IRFDataSetTableAdapters.DolgozoTableAdapter();
            this.tableAdapterManager = new IRF_Beadando.TKTEGJ_IRFDataSetTableAdapters.TableAdapterManager();
            this.munkakorTableAdapter = new IRF_Beadando.TKTEGJ_IRFDataSetTableAdapters.MunkakorTableAdapter();
            this.dolgozoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dolgozoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.jelszogeneralas = new System.Windows.Forms.ToolStripButton();
            this.dolgozoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.munkakorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.IRFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolgozoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolgozoBindingNavigator)).BeginInit();
            this.dolgozoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dolgozoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.munkakorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tKTEGJ_IRFDataSet
            // 
            this.IRFDataSet.DataSetName = "TKTEGJ_IRFDataSet";
            this.IRFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dolgozoBindingSource
            // 
            this.dolgozoBindingSource.DataMember = "Dolgozo";
            this.dolgozoBindingSource.DataSource = this.IRFDataSet;
            // 
            // dolgozoTableAdapter
            // 
            this.dolgozoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
          
            this.tableAdapterManager.DolgozoTableAdapter = this.dolgozoTableAdapter;
           
            this.tableAdapterManager.MunkakorTableAdapter = this.munkakorTableAdapter;
           
            this.tableAdapterManager.UpdateOrder = IRF_Beadando.TKTEGJ_IRFDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
           
            // 
            // munkakorTableAdapter
            // 
            this.munkakorTableAdapter.ClearBeforeFill = true;
            // 
            // dolgozoBindingNavigator
            // 
            this.dolgozoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dolgozoBindingNavigator.BindingSource = this.dolgozoBindingSource;
            this.dolgozoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dolgozoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dolgozoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.dolgozoBindingNavigatorSaveItem,
            this.jelszogeneralas});
            this.dolgozoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dolgozoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dolgozoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dolgozoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dolgozoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dolgozoBindingNavigator.Name = "dolgozoBindingNavigator";
            this.dolgozoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dolgozoBindingNavigator.Size = new System.Drawing.Size(420, 25);
            this.dolgozoBindingNavigator.TabIndex = 0;
            this.dolgozoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dolgozoBindingNavigatorSaveItem
            // 
            this.dolgozoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dolgozoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dolgozoBindingNavigatorSaveItem.Image")));
            this.dolgozoBindingNavigatorSaveItem.Name = "dolgozoBindingNavigatorSaveItem";
            this.dolgozoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dolgozoBindingNavigatorSaveItem.Text = "Save Data";
            this.dolgozoBindingNavigatorSaveItem.Click += new System.EventHandler(this.DolgozoBindingNavigatorSaveItem_Click);
            // 
            // jelszogeneralas
            // 
            this.jelszogeneralas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.jelszogeneralas.Image = ((System.Drawing.Image)(resources.GetObject("jelszogeneralas.Image")));
            this.jelszogeneralas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.jelszogeneralas.Name = "jelszogeneralas";
            this.jelszogeneralas.Size = new System.Drawing.Size(23, 22);
            this.jelszogeneralas.Text = "Jelszo generalas";
            this.jelszogeneralas.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // dolgozoDataGridView
            // 
            this.dolgozoDataGridView.AllowUserToAddRows = false;
            this.dolgozoDataGridView.AutoGenerateColumns = false;
            this.dolgozoDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dolgozoDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dolgozoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dolgozoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dolgozoDataGridView.DataSource = this.dolgozoBindingSource;
            this.dolgozoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dolgozoDataGridView.Location = new System.Drawing.Point(0, 25);
            this.dolgozoDataGridView.Name = "dolgozoDataGridView";
            this.dolgozoDataGridView.RowHeadersVisible = false;
            this.dolgozoDataGridView.Size = new System.Drawing.Size(420, 362);
            this.dolgozoDataGridView.TabIndex = 1;
            this.dolgozoDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DolgozoDataGridView_CellClick);
            this.dolgozoDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DolgozoDataGridView_DataError);
            this.dolgozoDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DolgozoDataGridView_RowValidating);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LoginNev";
            this.dataGridViewTextBoxColumn3.HeaderText = "Név";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MunkakorId";
            this.dataGridViewTextBoxColumn2.DataSource = this.munkakorBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Megnevezes";
            this.dataGridViewTextBoxColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewTextBoxColumn2.HeaderText = "Munkakör";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "Id";
            // 
            // munkakorBindingSource
            // 
            this.munkakorBindingSource.DataMember = "Munkakor";
            this.munkakorBindingSource.DataSource = this.IRFDataSet;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Jelszo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Jelszo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn5.HeaderText = "Email";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // DolgozoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(420, 387);
            this.Controls.Add(this.dolgozoDataGridView);
            this.Controls.Add(this.dolgozoBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DolgozoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dolgozók";
            this.Load += new System.EventHandler(this.DolgozoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IRFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolgozoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolgozoBindingNavigator)).EndInit();
            this.dolgozoBindingNavigator.ResumeLayout(false);
            this.dolgozoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dolgozoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.munkakorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TKTEGJ_IRFDataSet IRFDataSet;
        private System.Windows.Forms.BindingSource dolgozoBindingSource;
        private TKTEGJ_IRFDataSetTableAdapters.DolgozoTableAdapter dolgozoTableAdapter;
        private TKTEGJ_IRFDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dolgozoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton dolgozoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dolgozoDataGridView;
        private TKTEGJ_IRFDataSetTableAdapters.MunkakorTableAdapter munkakorTableAdapter;
        private System.Windows.Forms.BindingSource munkakorBindingSource;
        private System.Windows.Forms.ToolStripButton jelszogeneralas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}