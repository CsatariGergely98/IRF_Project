using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Configuration;
using System.Text.RegularExpressions;

namespace IRF_Beadando
{
    public partial class DolgozoForm : Form
    {
        public string email;
        Regex rx = new Regex(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$");
        public DolgozoForm()
        {
            InitializeComponent();
            dolgozoDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dolgozoDataGridView.EnableHeadersVisualStyles = false;
        }

        private void DolgozoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.dolgozoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.IRFDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba az adatok mentésekor: " + ex.Message);
            }
                
        }

        private void DolgozoForm_Load(object sender, EventArgs e)
        {           
            this.munkakorTableAdapter.Fill(this.IRFDataSet.Munkakor);
            this.dolgozoTableAdapter.Fill(this.IRFDataSet.Dolgozo);

        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztos, hogy új jelszót generál?", "Jóváhagyás", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

                mail.From = new MailAddress("gergely.csatari@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Jelszo";
                mail.Body = "Az ön új generált jelszava: 1234";
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings["smtpuser"], ConfigurationManager.AppSettings["smtppassword"]);
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.Send(mail);
                MessageBox.Show("Az új jelszó elküldve a dolgozó email címére.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Új jelszó legenerálva és eltárolva, de nem lehet elküldeni az email-t.");
            }
        }
    

        private void DolgozoDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
           
            if (dolgozoDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn4"].Value != null 
                && dolgozoDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn4"].Value.ToString() == "" 
                && dolgozoDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value != null
                 && dolgozoDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value.ToString() != ""
                && dolgozoDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].Value != null
                 && dolgozoDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].Value.ToString() != ""
                && dolgozoDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"].Value != null
                 && dolgozoDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"].Value.ToString() != "")
            {
                dolgozoDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn4"].Value = LoginForm.EncodePwd("1234");
                if (!rx.IsMatch(dolgozoDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"].Value.ToString()))
                {                    
                    MessageBox.Show("Kérem adjon meg valós e-mail cím formátumot.");
                    e.Cancel = true; 
                }
            }
        }

        private void DolgozoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            email = dolgozoDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"].Value.ToString();
        }

        private void DolgozoDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {           
           MessageBox.Show("Hibás adatrögzítés");            
        }
           
    }
}
