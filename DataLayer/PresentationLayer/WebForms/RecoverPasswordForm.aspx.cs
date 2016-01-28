using System;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace PresentationLayer.WebForms
{
    public partial class RecoverPasswordForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnResetPassword_Click(object sender, EventArgs e)
        {
            //UserData entity = new UserData();

            //entity.Email = txtLoginEmail.Text;

            // Show the message area
            try
            {
                SmtpClient client = new SmtpClient();
                client.Host = "smtp.mail.yahoo.com";
                client.Port = 587;
                client.UseDefaultCredentials = false;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("portal_admitere_atm@yahoo.com", "AdminPortal10");
                MailMessage mm = new MailMessage("portal_admitere_atm@yahoo.com", txtLoginEmail.Text, "test", "test");
                mm.BodyEncoding = UTF8Encoding.UTF8;
                mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                client.Send(mm);
            }
            catch(Exception ex)
            {
                divMessageArea.Visible = true;
                lblMessage.Text = ex.Message;
            }

            divMessageArea.Visible = true;
            lblMessage.Text = "Parola a fost trimisa cu succes. Va rugam sa asteptati 5-10 minute pana la primirea e-mailului.";
            System.Diagnostics.Debugger.Break();
        }
    }
}