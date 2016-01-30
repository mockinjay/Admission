using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinessLayer;
using DataLayer.Models;
using DataLayer;


namespace PresentationLayer.WebForms
{
    public partial class LocuriBuget : System.Web.UI.Page
    {
        IEnumerable<Facultati> fac;
        Bussiness dt;
        public static string selFaculty = "2";
        public static string selDepartment = "2";
        public static string selBeneficiary = "2";
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
            if (!ddlBeneficiary.SelectedValue.Equals(selBeneficiary))
            {
                selBeneficiary = ddlBeneficiary.SelectedValue;
                ddlBeneficiary_SelectedIndexChanged(sender, e);

            }

            Locuri_buget lb = dt.getLocuriBuget(ddlSpecialization.SelectedItem.Text, ddlBeneficiary.SelectedItem.Text);
            if (lb != null)
                if (lb.Din_care_fete != null)
                    lblMessage.Text = "Numarul de locuri la buget este: " + lb.Nr_locuri.ToString() + ", dintre care fete: " + lb.Din_care_fete.ToString();
                else
                    lblMessage.Text = "Numarul de locuri la buget este: " + lb.Nr_locuri.ToString();
            else
                lblMessage.Text = "Nu exista locuri la beneficiarul " + ddlBeneficiary.SelectedItem + " pentru specializarea " + ddlSpecialization.SelectedItem + ".";
        }

        protected void ddlFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = ddlFaculty.SelectedValue;
            //var id= fac.First<Facultati>(x => x.Nume_facultate.Equals(txtFac)).ID_Facultate;
            var dep = dt.getDepartament(Int32.Parse(id));
            ddlDepartment.DataSource = dep;
            ddlDepartment.DataValueField = "ID_Departament";
            ddlDepartment.DataTextField = "Nume_departament";
            ddlDepartment.DataBind();

        }



        protected void ddlFaculty_Init(object sender, EventArgs e)
        {
            if (ddlFaculty.Items.Count == 0)
            {
                dt = new Bussiness();
                fac = dt.getFacultati();

                ddlFaculty.DataSource = fac;

                ddlFaculty.DataValueField = "ID_Facultate";
                ddlFaculty.DataTextField = "Nume_facultate";
                ddlFaculty.DataBind();
                ddlDepartment_Create();
                ddlSpecialization_Create();
                ddlBeneficiary_Create();
            }

        }

        protected void ddlDepartment_Create()
        {
            string id = selFaculty;
            //var id= fac.First<Facultati>(x => x.Nume_facultate.Equals(txtFac)).ID_Facultate;
            var dep = dt.getDepartament(Int32.Parse(id));
            ddlDepartment.DataSource = dep;
            ddlDepartment.DataValueField = "ID_Departament";
            ddlDepartment.DataTextField = "Nume_departament";
            ddlDepartment.DataBind();

        }

        protected void ddlDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

            string id = ddlDepartment.SelectedValue;
            //var id= fac.First<Facultati>(x => x.Nume_facultate.Equals(txtFac)).ID_Facultate;
            var spec = dt.getSpecializari(Int32.Parse(id));
            ddlSpecialization.DataSource = spec;
            ddlSpecialization.DataValueField = "ID_Specializare";
            ddlSpecialization.DataTextField = "Nume_specializare";
            ddlSpecialization.DataBind();

        }

        protected void ddlBeneficiary_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string id = ddlBeneficiary.SelectedValue;
            //var id= fac.First<Facultati>(x => x.Nume_facultate.Equals(txtFac)).ID_Facultate;
            var ben = dt.getBeneficiari();
            ddlBeneficiary.DataSource = ben;
            ddlBeneficiary.DataValueField = "ID_Beneficiar";
            ddlBeneficiary.DataTextField = "Nume_beneficiar";
            ddlBeneficiary.SelectedIndex = Int32.Parse(selBeneficiary)-1;
            ddlBeneficiary.DataBind();
        }

        protected void ddlSpecialization_Create()
        {
            string id = selDepartment;
            //var id= fac.First<Facultati>(x => x.Nume_facultate.Equals(txtFac)).ID_Facultate;
            var spec = dt.getSpecializari(Int32.Parse(id));
            ddlSpecialization.DataSource = spec;
            ddlSpecialization.DataValueField = "ID_Specializare";
            ddlSpecialization.DataTextField = "Nume_specializare";
            ddlSpecialization.DataBind();
        }

        protected void ddlBeneficiary_Create()
        {
            var ben = dt.getBeneficiari();
            ddlBeneficiary.DataSource = ben;
            ddlBeneficiary.DataValueField = "ID_Beneficiar";
            ddlBeneficiary.DataTextField = "Nume_beneficiar";
            ddlBeneficiary.SelectedIndex = Int32.Parse(selBeneficiary) - 1;
            ddlBeneficiary.DataBind();
            divMessageArea.Visible = true;
            
        }
    }
}