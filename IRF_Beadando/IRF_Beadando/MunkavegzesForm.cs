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
    public partial class MunkavegzesForm : Form
    {
        DateTime kezdoido;
        public MunkavegzesForm()
        {
            InitializeComponent();            
        }

        private void TevekenysegBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tevekenysegBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tKTEGJ_IRFDataSet);

        }

        private void MunkavegzesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tKTEGJ_IRFDataSet.Munkavegzes' table. You can move, or remove it, as needed.
            this.munkavegzesTableAdapter.Fill(this.tKTEGJ_IRFDataSet.Munkavegzes);
            // TODO: This line of code loads data into the 'tKTEGJ_IRFDataSet.Tevekenyseg' table. You can move, or remove it, as needed.
            this.tevekenysegTableAdapter.Fill(this.tKTEGJ_IRFDataSet.Tevekenyseg);

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbOra.Text = (DateTime.Now - kezdoido).ToString();
        }

        private void BStart_Click(object sender, EventArgs e)
        {
            bStop.Enabled = true;
            bStart.Enabled = false;
            lbOra.Visible = true;
            kezdoido = DateTime.Now;
            timer1.Start();
        }

        private void BStop_Click(object sender, EventArgs e)
        {
            bStop.Enabled = false;
            bStart.Enabled = true;
            lbOra.Visible = false;
            timer1.Stop();
        }

        private void MunkavegzesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(bStop.Enabled)
            {
                MessageBox.Show("A tevékenység futása alatt a kilépés nem lehetséges.");
                e.Cancel = true;
            }
        }
    }
}
