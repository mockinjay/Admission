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
    public partial class AvailableTaxSeatsForm : System.Web.UI.Page
    {
        IEnumerable<Facultati> fac;
        DataTier dt;
        public static string selFaculty = "2";
        public static string selDepartment = "2";
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!ddlFaculty.SelectedValue.Equals(selFaculty))
            {
                selFaculty = ddlFaculty.SelectedValue;
                ddlFaculty_SelectedIndexChanged(sender, e);
            }
            if (!ddlDepartment.SelectedValue.Equals(selDepartment))
            {
                selDepartment = ddlDepartment.SelectedValue;
                ddlDepartment_SelectedIndexChanged(sender, e);

            }
            divMessageArea.Visible = true;
            Locuri_taxa lt = dt.ReadLocuriTaxa(ddlSpecialization.SelectedItem.Text);
            if (lt != null)
                lblMessage.Text = "Numarul de locuri la taxa este: " + lt.Nr_locuri.ToString();
            else
                lblMessage.Text = "Nu exista locuri la taxa pentru specializarea: " + ddlSpecialization.SelectedItem.Text + ".";
        }
        protected void ddlFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = ddlFaculty.SelectedValue;
            //var id= fac.First<Facultati>(x => x.Nume_facultate.Equals(txtFac)).ID_Facultate;
            var dep = dt.ReadDepartments(Int32.Parse(id));
            ddlDepartment.DataSource = dep;
            ddlDepartment.DataValueField = "ID_Departament";
            ddlDepartment.DataTextField = "Nume_departament";
            ddlDepartment.DataBind();

        }



        protected void ddlFaculty_Init(object sender, EventArgs e)
        {
            if (ddlFaculty.Items.Count == 0)
            {
                dt = new DataTier();
                fac = dt.ReadFaculties();

                ddlFaculty.DataSource = fac;

                ddlFaculty.DataValueField = "ID_Facultate";
                ddlFaculty.DataTextField = "Nume_facultate";
                ddlFaculty.DataBind();
                ddlDepartment_Create();
                ddlSpecialization_Create();

            }

        }

        protected void ddlDepartment_Create()
        {
            string id = selFaculty;
            //var id= fac.First<Facultati>(x => x.Nume_facultate.Equals(txtFac)).ID_Facultate;
            var dep = dt.ReadDepartments(Int32.Parse(id));
            ddlDepartment.DataSource = dep;
            ddlDepartment.DataValueField = "ID_Departament";
            ddlDepartment.DataTextField = "Nume_departament";
            ddlDepartment.DataBind();

        }
        protected void ddlSpecialization_Create()
        {
            string id = selDepartment;
            //var id= fac.First<Facultati>(x => x.Nume_facultate.Equals(txtFac)).ID_Facultate;
            var spec = dt.ReadSpecialization(Int32.Parse(id));
            ddlSpecialization.DataSource = spec;
            ddlSpecialization.DataValueField = "ID_Specializare";
            ddlSpecialization.DataTextField = "Nume_specializare";
            ddlSpecialization.DataBind();
        }

        protected void ddlDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

            string id = ddlDepartment.SelectedValue;
            //var id= fac.First<Facultati>(x => x.Nume_facultate.Equals(txtFac)).ID_Facultate;
            var spec = dt.ReadSpecialization(Int32.Parse(id));
            ddlSpecialization.DataSource = spec;
            ddlSpecialization.DataValueField = "ID_Specializare";
            ddlSpecialization.DataTextField = "Nume_specializare";
            ddlSpecialization.DataBind();

        }
    }
}
