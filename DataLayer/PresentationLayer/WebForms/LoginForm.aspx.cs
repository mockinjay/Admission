using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentationLayer.WebForms
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            //UserData entity = new UserData();

            //entity.Email = txtLoginEmail.Text;
            //entity.Password = txtLoginPassword.Text;
            //entity.IsRememberMeChecked = chkRememberMe.Checked;

            // Show the message area
            //divMessageArea.Visible = true;
            // lblMessage.Text = "V-ati logat cu succes.";
            this.Server.Transfer("MemberProfileForm.aspx");
           // Response.Redirect("MemberProfileForm.aspx");
            System.Diagnostics.Debugger.Break();
        }
    }
}