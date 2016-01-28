using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentationLayer.WebForms
{
    public partial class MemberProfileForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null)
            {
                TextBox tBox = (TextBox)FindControlRecursive(PreviousPage, "txtLoginEmail");
                if (tBox != null)
                {
                    txtEmail.Text = tBox.Text;
                }
            }
            //txtName.Text = "Adrian Matei";
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            path += "\\GitHub\\Admission\\DataLayer\\PresentationLayer\\Images\\";
            if (!string.IsNullOrEmpty(txtName.Text)) { 
            string[] files = System.IO.Directory.GetFiles(path, txtName.Text+"*");
            if (files.Length>0)
            {
                Image imgControl = (Image)FindControlRecursive(Page.Master, "imgChange");
                    path=files[0].Substring(files[0].LastIndexOf("\\")+1);
                imgControl.ImageUrl = "../Images/" + System.IO.Path.GetFileName(path);
            }
        }
        }
        public Control FindControlRecursive(Control control, string id)
        {
            if (control == null || control.ID == id) return control;

            foreach (Control c in control.Controls)
            {
                var found = FindControlRecursive(c,id);
                if (found != null) return found;
            }

            return null;
        }
        protected void Upload(object sender, EventArgs e)
        {
            int contentLength = avatarUpload.PostedFile.ContentLength;//You may need it for validation
            string contentType = avatarUpload.PostedFile.ContentType;//You may need it for validation
            string fileName = avatarUpload.PostedFile.FileName;
            
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            path += "\\GitHub\\Admission\\DataLayer\\PresentationLayer\\Images\\" + txtName.Text + System.IO.Path.GetExtension(avatarUpload.PostedFile.FileName);
            avatarUpload.PostedFile.SaveAs(@path );//Or code to save in the DataBase.
            Image imgControl =(Image) FindControlRecursive(Page.Master, "imgChange");
            imgControl.ImageUrl = "../Images/"+ txtName.Text+ System.IO.Path.GetExtension(avatarUpload.PostedFile.FileName);
            
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            //UserData entity = new UserData();

            //entity.FirstName = txtFirst.Text;
            //entity.LastName = txtLast.Text;
           // entity.Email = txtEmail.Text;
            //entity.Password = txtPassword.Text;
            //entity.Street1 = txtStreet1.Text;
            //entity.Apartment = txtApt.Text;
            //entity.City = txtCity.Text;
            //entity.State = ddlState.SelectedValue;
            //entity.BirthDay = Convert.ToInt32(ddlDays.SelectedValue);
            //entity.BirthMonth = Convert.ToInt32(ddlMonths.SelectedValue);
            //entity.BirthYear = Convert.ToInt32(ddlYears.SelectedValue);

            // Show the message area
            try
            {

            }
            catch(Exception ex)
            {
                divMessageArea.Visible = true;
                lblMessage.Text = ex.Message;
            }
            divMessageArea.Visible = true;
            lblMessage.Text = "Datele dumneavoastra au fost actualizate cu succes.";
            System.Diagnostics.Debugger.Break();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}