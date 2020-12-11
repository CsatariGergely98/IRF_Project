using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Beadando
{
    public partial class MunkakorForm : Form
    {
        public MunkakorForm()
        {
            InitializeComponent();
            munkakorDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            munkakorDataGridView.EnableHeadersVisualStyles = false;
        }

        private void MunkakorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.munkakorBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.IRFDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba az adatok mentésekor: " + ex.Message);
            }
           

        }

        private void MunkakorForm_Load(object sender, EventArgs e)
        {           
            this.munkakorTableAdapter.Fill(this.IRFDataSet.Munkakor);
        }
    }
}
