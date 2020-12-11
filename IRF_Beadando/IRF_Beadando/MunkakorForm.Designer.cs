namespace IRF_Beadando
{
    partial class MunkakorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MunkakorForm));
            this.IRFDataSet = new IRF_Beadando.TKTEGJ_IRFDataSet();
            this.munkakorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.munkakorTableAdapter = new IRF_Beadando.TKTEGJ_IRFDataSetTableAdapters.MunkakorTableAdapter();
            this.tableAdapterManager = new IRF_Beadando.TKTEGJ_IRFDataSetTableAdapters.TableAdapterManager();
            this.munkakorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.munkakorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.munkakorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.IRFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.munkakorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.munkakorBindingNavigator)).BeginInit();
            this.munkakorBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.munkakorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TKTEGJ_IRFDataSet
            // 
            this.IRFDataSet.DataSetName = "TKTEGJ_IRFDataSet";
            this.IRFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // munkakorBindingSource
            // 
            this.munkakorBindingSource.DataMember = "Munkakor";
            this.munkakorBindingSource.DataSource = this.IRFDataSet;
            // 
            // munkakorTableAdapter
            // 
            this.munkakorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;           
            this.tableAdapterManager.DolgozoTableAdapter = null;           
            this.tableAdapterManager.MunkakorTableAdapter = this.munkakorTableAdapter;
            this.tableAdapterManager.UpdateOrder = IRF_Beadando.TKTEGJ_IRFDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;

            // 
            // munkakorBindingNavigator
            // 
            this.munkakorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.munkakorBindingNavigator.BindingSource = this.munkakorBindingSource;
            this.munkakorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.munkakorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.munkakorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.munkakorBindingNavigatorSaveItem});
            this.munkakorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.munkakorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.munkakorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.munkakorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.munkakorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.munkakorBindingNavigator.Name = "munkakorBindingNavigator";
            this.munkakorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.munkakorBindingNavigator.Size = new System.Drawing.Size(374, 25);
            this.munkakorBindingNavigator.TabIndex = 0;
            this.munkakorBindingNavigator.Text = "bindingNavigator1";
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
            // munkakorBindingNavigatorSaveItem
            // 
            this.munkakorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.munkakorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("munkakorBindingNavigatorSaveItem.Image")));
            this.munkakorBindingNavigatorSaveItem.Name = "munkakorBindingNavigatorSaveItem";
            this.munkakorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.munkakorBindingNavigatorSaveItem.Text = "Save Data";
            this.munkakorBindingNavigatorSaveItem.Click += new System.EventHandler(this.MunkakorBindingNavigatorSaveItem_Click);
            // 
            // munkakorDataGridView
            // 
            this.munkakorDataGridView.AllowUserToAddRows = false;
            this.munkakorDataGridView.AutoGenerateColumns = false;
            this.munkakorDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.munkakorDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.munkakorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.munkakorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.munkakorDataGridView.DataSource = this.munkakorBindingSource;
            this.munkakorDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.munkakorDataGridView.Location = new System.Drawing.Point(0, 25);
            this.munkakorDataGridView.Name = "munkakorDataGridView";
            this.munkakorDataGridView.RowHeadersVisible = false;
            this.munkakorDataGridView.Size = new System.Drawing.Size(374, 431);
            this.munkakorDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Megnevezes";
            this.dataGridViewTextBoxColumn2.HeaderText = "Megnevezés";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // MunkakorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 456);
            this.Controls.Add(this.munkakorDataGridView);
            this.Controls.Add(this.munkakorBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MunkakorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Munkakör";
            this.Load += new System.EventHandler(this.MunkakorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IRFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.munkakorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.munkakorBindingNavigator)).EndInit();
            this.munkakorBindingNavigator.ResumeLayout(false);
            this.munkakorBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.munkakorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TKTEGJ_IRFDataSet IRFDataSet;
        private System.Windows.Forms.BindingSource munkakorBindingSource;
        private TKTEGJ_IRFDataSetTableAdapters.MunkakorTableAdapter munkakorTableAdapter;
        private TKTEGJ_IRFDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator munkakorBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton munkakorBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView munkakorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}