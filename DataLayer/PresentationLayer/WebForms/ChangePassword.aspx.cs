using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentationLayer.WebForms
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnChangePasswd_Click(object sender, EventArgs e)
        {
            if(!txtNewPassword.Text.Equals(txtConfirmNewPassword.Text))
            {
                divMessageArea.Visible = true;
                lblMessage.Text = "Confirmarea parolei nu coincide cu parola. Va rugam reincercati.";
            }
            else
            {
                divMessageArea.Visible = true;
                lblMessage.Text = "Parola a fost schimbata cu succes.";
            }
        }
    }
}