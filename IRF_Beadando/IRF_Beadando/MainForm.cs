using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Beadando
{
    public partial class MainForm : Form
    {
        public static TKTEGJ_IRFEntities context = new TKTEGJ_IRFEntities();
        public static Dolgozo aktdolg;
        public MainForm()
        {
            InitializeComponent();
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;
            label1.Text += " " + version;

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            // adatbazis kapcsolat ellenorzes
            try
            {
                context.Database.SqlQuery<int>("select 1").FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nem sikerült kapcsolódni az adatbázishoz: " + ex.Message);
                Close();
            }
            // bejelentkeztetes
            LoginForm lf = new LoginForm();
            DialogResult dr = lf.ShowDialog();
            if (dr != DialogResult.OK)
                Close();
            else
            {
                dolgozóToolStripMenuItem.Enabled = aktdolg.Admin;
                Text += " - " + aktdolg.LoginNev;
            }
        }

        private void DolgozóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DolgozoForm df = new DolgozoForm();
            df.ShowDialog();
        }
        
        private void MunkakörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MunkakorForm().ShowDialog();
        }

        private void JelszóMódosításToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new JelszoModositasForm().ShowDialog();
        }
    }
}
