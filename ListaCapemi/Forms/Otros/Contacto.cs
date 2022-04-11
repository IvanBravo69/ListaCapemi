using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaCapemi.Forms.Otros
{
    public partial class frmContacto : Form
    {
        public frmContacto()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            this.txtNombreContacto.Text = "";
            this.txtEmailContacto.Text = "";
            this.txtEmpresaContacto.Text = "";
            this.txtTelContacto.Text = "";
            this.txtMensaje.Text = "";

        }


        private void btnEnviarMail_Click(object sender, EventArgs e)
        {
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();
            mmsg.To.Add(txtEmailContacto.Text);
            mmsg.Subject = txtMensaje.Text;
            mmsg.Subject = txtNombreContacto.Text;
            mmsg.Subject = txtTelContacto.Text;
            mmsg.Subject = txtEmpresaContacto.Text;

            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;

            mmsg.Body = txtMensaje.Text;
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;




            mmsg.From = new System.Net.Mail.MailAddress("ivanbravo1993@gmail.com");

            System.Net.Mail.SmtpClient cli = new System.Net.Mail.SmtpClient();

            cli.Credentials = new System.Net.NetworkCredential("ivanbravo1993@gmail.com", "Flor1201.");
            cli.Port = 587;
            cli.EnableSsl = true;
            cli.Host = "smtp.gmail.com";
            try
            {
                cli.Send(mmsg);
                MessageBox.Show("El mensaje se envio correctamente");
                limpiar();
            }
            catch(Exception)
            {
                MessageBox.Show("Error al enviar");
            }
        }
    }
}
