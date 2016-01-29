<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Site1.Master" AutoEventWireup="true" CodeBehind="OptionChooserForm.aspx.cs" Inherits="PresentationLayer.WebForms.OptionChooserForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
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
          <h3 class="panel-title">Selectare Optiune</h3>
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
          </div>
            <div class="form-group">
            <div class="row">
              <div class="col-xs-8">
                <label for="txtPriority">
                  Selecteaza Prioritatea</label>
                  <asp:DropDownList ID="ddlPriority" 
                       CssClass="form-control"
                      runat="server" AutoPostBack="True"  ViewStateMode="Enabled" >
                       <asp:ListItem Text="1" Value="1" />
                       <asp:ListItem Text="2" Value="2" />
                       <asp:ListItem Text="3" Value="3" />
                       <asp:ListItem Text="4" Value="4" />
                       <asp:ListItem Text="5" Value="5" />
                  </asp:DropDownList>
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
