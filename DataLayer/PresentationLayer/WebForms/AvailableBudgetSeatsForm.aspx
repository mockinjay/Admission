<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Site1.Master" AutoEventWireup="true" CodeBehind="AvailableBudgetSeatsForm.aspx.cs" Inherits="PresentationLayer.WebForms.LocuriBuget" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="../css/PagerStyle.css" rel="stylesheet" type="text/css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     
   <div class="row">
    <div class="col-md-6 center-block">
      <asp:ValidationSummary ID="valSummary"
        CssClass="text-danger valSummary"
        runat="server" />
    </div>
  </div>
  <div class="row">
    <div class="col-md-6 center-block">
      <asp:Label ID="lblError" runat="server" />
    </div>
  </div>
  <div class="row">
    <div class="col-md-6 center-block">
      <div class="panel panel-default">
        <div class="panel-heading">
          <h3 class="panel-title">Locuri Buget</h3>
        </div>
        <div class="panel-body">
          <div class="form-group">
            <div class="row">
              <div class="col-xs-8">
                <label for="txtFaculty">
                  Selecteaza Facultatea</label>
                  <asp:DropDownList ID="ddlFaculty" runat="server" 
                       CssClass="form-control"   OnInit="ddlFaculty_Init" AutoPostBack="True" ViewStateMode="Enabled"></asp:DropDownList>
              </div>
            </div>
          </div>
            <div class="form-group">
            <div class="row">
              <div class="col-xs-8">
                <label for="txtDepartment">
                  Selecteaza Departamentul</label>
                  <asp:DropDownList ID="ddlDepartment" 
                       CssClass="form-control"
                      runat="server"  AutoPostBack="True"  ViewStateMode="Enabled"></asp:DropDownList>
              </div>
            </div>
          </div>
            <div class="form-group">
            <div class="row">
              <div class="col-xs-8">
                <label for="txtSpecialization">
                  Selecteaza Specializarea</label>
                  <asp:DropDownList ID="ddlSpecialization" 
                       CssClass="form-control"
                      runat="server" AutoPostBack="True"  ViewStateMode="Enabled" ></asp:DropDownList>
              </div>
            </div>
            <div class="form-group">
            <div class="row">
              <div class="col-xs-8">
                <label for="txtBeneficiary">
                  Selecteaza Beneficiarul</label>
                  <asp:DropDownList ID="ddlBeneficiary" 
                       CssClass="form-control"
                      runat="server" AutoPostBack="True"  ViewStateMode="Enabled" ></asp:DropDownList>
              </div>
            </div>
         
               
             <div class="form-group">
          <div class="row">
            <div class="col-xs-12">
              <div id="divMessageArea" 
                   runat="server" 
                   visible="false">
                <div class="well">
                  <asp:Label ID="lblMessage" runat="server"
                    CssClass="text-warning"
                    Text="Area to display messages." />
                </div>
              </div>
            </div>
          </div>
        </div>
            
            </div>
          </div>
        </div>
      </div>
         </div>
  </div>
    </asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="EndOfPageContent" runat="server">
</asp:Content>
