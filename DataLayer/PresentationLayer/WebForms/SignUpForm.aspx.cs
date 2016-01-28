using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentationLayer.WebForms
{
    public partial class SignUpForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            //UserData entity = new UserData();

            //entity.FirstName = txtFirst.Text;
            //entity.LastName = txtLast.Text;
            //entity.Email = txtEmail.Text;
            //entity.Password = txtPassword.Text;
            //entity.IsAgreeToTermsChecked = true;

            // Show the message area
            //
            if(txtPassword.Text.ToString().Equals(txtConfirmPassword.Text.ToString())==false)
            {
                divMessageArea.Visible = true;
                lblMessage.Text = "Va rugam sa reconfirmati parola.";
                txtConfirmPassword.Text = string.Empty;
            }
            else if(txtCNP.Text.Length!=13 || txtCNP.Text.Any(x => char.IsLetter(x)))
            {
                divMessageArea.Visible = true;
                lblMessage.Text = "CNP-ul nu este valid.";
            }
            else
            {
                divMessageArea.Visible = true;
                lblMessage.Text = "Inregistrarea s-a efectuat cu succes.";
            }
            System.Diagnostics.Debugger.Break();
        }
    }
}