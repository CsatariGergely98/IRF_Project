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
    public partial class TevekenysegForm : Form
    {
        public TevekenysegForm()
        {
            InitializeComponent();
            tevekenysegDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            tevekenysegDataGridView.EnableHeadersVisualStyles = false;
        }

        private void TevekenysegBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tevekenysegBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.IRFDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba az adatok mentésekor: " + ex.Message);
            }
           

        }

        private void TevekenysegForm_Load(object sender, EventArgs e)
        {           
            this.tevekenysegTableAdapter.Fill(this.IRFDataSet.Tevekenyseg);
        }
    }
}
