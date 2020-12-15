using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Beadando
{
    public partial class LoginForm : Form
    {
        // max 3x probalhat
        int probak = 3;
        public LoginForm()
        {
            InitializeComponent();
            // admin bejelentkezés tesztelés miatt
            Logintb.Text = "admin";
            Jelszotb.Text = "Admin123";
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
        }

        private void bejelentkezes()
        {
            Dolgozo dolgozo = (Dolgozo)(from x in MainForm.context.Dolgozo
                                        where x.LoginNev == Logintb.Text
                                        select x).FirstOrDefault();
            //Logintb.Text = EncodePwd(Jelszotb.Text);
            if ((dolgozo != null) && (dolgozo.Jelszo == EncodePwd(Jelszotb.Text)))
            {
                DialogResult = DialogResult.OK;
                MainForm.aktdolg = dolgozo;
            }
            else
            {
                if (--probak > 0)
                {
                    MessageBox.Show("Hibás felhasználónév vagy jelszó! Még " + probak + " próbálkozása maradt.");
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bejelentkezes();
        }

        public static string EncodePwd(string jelszo)
        {
            var sha1 = new SHA1CryptoServiceProvider();
            return Convert.ToBase64String(new SHA1CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(jelszo)));
        }

        private void Logintb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bejelentkezes();
            }
        }

        private void Jelszotb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bejelentkezes();
            }
        }
    }
}
