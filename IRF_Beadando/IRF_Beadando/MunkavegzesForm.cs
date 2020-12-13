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
            cbTevekenyseg.Text = "";
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
            if (cbTevekenyseg.Text == "")
            {
                MessageBox.Show("A tevékenység megadása kötelező!");
                return;
            }
            cbTevekenyseg.Enabled = false;

            bStop.Enabled = true;
            bStart.Enabled = false;
            lbOra.Visible = true;
            kezdoido = DateTime.Now;
            chbnapzar.Enabled = false;
            timer1.Start();
        }

        private void BStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Munkavegzes m = new MunkavegzesEpito()
                .Create(MainForm.aktdolg.Id, (int)cbTevekenyseg.SelectedValue, kezdoido, DateTime.Now)
                .Megjegyzes(tbMegj.Text)
                .Ugyfelazonosito(tbUgyfazo.Text)
                .Ikatoszam(tbiktatoszam.Text)
                .IktatottOldalszam((int)nudiktold.Value)
                .build();
            MainForm.context.Munkavegzes.Add(m);
            MainForm.context.SaveChanges();
            this.munkavegzesTableAdapter.Fill(this.tKTEGJ_IRFDataSet.Munkavegzes);
            cbTevekenyseg.Enabled = true;
            cbTevekenyseg.Text = "";
            tbiktatoszam.Text = "";
            tbMegj.Text = "";
            tbUgyfazo.Text = "";
            nudiktold.Value = 0;
            bStop.Enabled = false;
            bStart.Enabled = true;
            lbOra.Visible = false;
            chbnapzar.Enabled = true;
        }

        private void MunkavegzesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bStop.Enabled)
            {
                MessageBox.Show("A tevékenység futása alatt a kilépés nem lehetséges.");
                e.Cancel = true;
            }
        }

        private void Chbnapzar_CheckedChanged(object sender, EventArgs e)
        {
            bNapzar.Enabled = chbnapzar.Checked;
        }

        private void BNapzar_Click(object sender, EventArgs e)
        {

            //todo export
            Close();


        }
    }
}
