using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Beadando
{
    public partial class JelszoModositasForm : Form
    {
        // legyen benne kis és nagybetű meg szám 8-30 között magyar ékezetet nem 
        Regex rx = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9!\\#$%&''()*+,\-.\:;<=>?@\[\]^_`{|}~]{8,30}$");

        public JelszoModositasForm()
        {
            InitializeComponent();
            jelszolabel.Text = "A jelszónak legalább 8 karaktert, kis és nagy betűt és számot kell tartalmaznia.";
            regijelszotb.Focus();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Dolgozo dolgozo = (Dolgozo)(from x in MainForm.context.Dolgozo
                                        where x.Id == MainForm.aktdolg.Id
                                        select x).FirstOrDefault();

            
            if (dolgozo.Jelszo != LoginForm.EncodePwd(regijelszotb.Text))
            {
                regijelszotb.BackColor = Color.Red;
                MessageBox.Show("A jelenlegi jelszó nem megfelelő!");
                regijelszotb.Focus();
                return;
            }
            regijelszotb.BackColor = ujjelszotb.BackColor ;
            if (!rx.IsMatch(ujjelszotb.Text))
            {
                jelszolabel.Visible = true;
                MessageBox.Show("Az új jelszó nem elég bonyolult!");
                ujjelszotb.Focus();
                return;
            }
            if (ujjelszotb.Text!=ujjelszotb2.Text)
            {
                MessageBox.Show("Az új jelszó és megismétlése nem egyforma!");
                ujjelszotb2.Focus();
                return;
            }
            try
            {
                Dolgozo d = MainForm.context.Dolgozo.Find(dolgozo.Id);
                d.Jelszo = LoginForm.EncodePwd(ujjelszotb.Text);
                MainForm.context.SaveChanges();
                MessageBox.Show("Új jelszó sikeresen eltárolva.");
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Jelszó módosítás sikertelen: "+ex.Message);
            }
        }
        private void Ujjelszotb_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void Ujjelszotb_Validating(object sender, CancelEventArgs e)
        {
            if (!rx.IsMatch(ujjelszotb.Text))
            {
                jelszolabel.Visible = true;
            }
            else
                jelszolabel.Visible = false;
        }
    }
}
