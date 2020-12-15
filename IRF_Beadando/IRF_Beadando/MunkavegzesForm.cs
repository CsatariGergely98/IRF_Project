using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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


        private void MunkavegzesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tKTEGJ_IRFDataSet.Munkavegzes' table. You can move, or remove it, as needed.
            //this.munkavegzesTableAdapter.Fill(this.tKTEGJ_IRFDataSet.Munkavegzes.Select("DolgozoId="+MainForm.aktdolg.Id.ToString()));
            this.munkavegzesTableAdapter.FillByDolgozo(this.tKTEGJ_IRFDataSet.Munkavegzes, MainForm.aktdolg.Id);
            // TODO: This line of code loads data into the 'tKTEGJ_IRFDataSet.Tevekenyseg' table. You can move, or remove it, as needed.
            this.tevekenysegTableAdapter.Fill(this.tKTEGJ_IRFDataSet.Tevekenyseg);
            cbTevekenyseg.Text = "";

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
            int minsDiff = ((TimeSpan)(DateTime.Now - kezdoido)).Minutes;
            if (minsDiff<1)
            {
                MessageBox.Show("Minimum 1 percet kell egy tevékenységre fordítani");
                return;
            }
            timer1.Stop();
            Munkavegzes m = new MunkavegzesEpito()
                .Create(MainForm.aktdolg.Id, (int)cbTevekenyseg.SelectedValue, kezdoido, DateTime.Now)
                .Megjegyzes(tbMegj.Text)
                .Ugyfelazonosito(tbUgyfazo.Text)
                .Ikatoszam(tbiktatoszam.Text)
                .IktatottOldalszam((int)nudiktold.Value)
                .Build();
            MainForm.context.Munkavegzes.Add(m);
            MainForm.context.SaveChanges();
            this.munkavegzesTableAdapter.FillByDolgozo(this.tKTEGJ_IRFDataSet.Munkavegzes,MainForm.aktdolg.Id);
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
            if(dgvmunkavegzes.Rows.Count ==0)
            {
                MessageBox.Show("Üres napot nem lehet lezárni");
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    IRF_Beadando.TKTEGJ_IRFDataSet.MunkavegzesDataTable dt = new TKTEGJ_IRFDataSet.MunkavegzesDataTable();
                    this.munkavegzesTableAdapter.FillByDolgozo(dt, MainForm.aktdolg.Id);                   
                    CsvExporter ce = new CsvExporter();
                    List<Munkavegzes> ml = ConvertDataTable<Munkavegzes>(dt);
                    foreach (var item in ml)
                    {
                        item.Dolgozo = MainForm.aktdolg;
                        item.Tevekenyseg = MainForm.context.Tevekenyseg.Find(item.TevekenysegId);
                    }

                    ce.Export(saveFileDialog.FileName,ml);
                    MessageBox.Show("Sikeres mentés");
                    Close();
                }
            }
              
        }
        private static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }
    }
}
