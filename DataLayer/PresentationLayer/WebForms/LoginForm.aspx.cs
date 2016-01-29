using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataLayer;
using DataLayer.Models;
namespace PresentationLayer.WebForms
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            DataTier dt = new DataTier();
            string result=dt.CheckUser(txtLoginEmail.Text, txtLoginPassword.Text);
            if(result.Equals("WrongUser"))
            {
                divMessageArea.Visible = true;
                lblMessage.Text = "Utilizatorul nu exista. Va rugam sa reincercati.";
            }
            else if (result.Equals("WrongPassword"))
            {
                divMessageArea.Visible = true;
                lblMessage.Text = "Parola nu este corecta. Va rugam sa reincercati.";
            }
            else if(result.Equals("Corect"))
            {
                this.Server.Transfer("MemberProfileForm.aspx");
            }
            
           
            System.Diagnostics.Debugger.Break();
        }
    }
}