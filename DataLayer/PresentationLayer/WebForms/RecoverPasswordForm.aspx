<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Site.Master" AutoEventWireup="true" CodeBehind="RecoverPasswordForm.aspx.cs" Inherits="PresentationLayer.WebForms.RecoverPasswordForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  <div class="row">
    <div class="col-xs-12 col-md-6 center-block">
      <div class="panel panel-primary">
        <div class="panel-heading">
          <h3 class="panel-title">Recuperare parola</h3>
        </div>
        <div class="panel-body">
          <div class="row">
            <div class="col-xs-12">
              <div class="form-group">
                <label for="txtLoginEmail">
                  Adresa de e-mail folosita la inregistrare</label>
                <asp:TextBox ID="txtLoginEmail" runat="server"
                  TextMode="Email"
                  CssClass="form-control"
                  autofocus="autofocus"
                  required="required"
                  placeholder="Email"
                  title="Email"></asp:TextBox>
              </div>
            </div>
          </div>
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
        <div class="panel-footer">
          <asp:Button ID="btnResetPassword" runat="server"
            Text="Trimite parola"
            CssClass="btn btn-primary"
            OnClick="btnResetPassword_Click"
            title="Trimite" />
        </div>
      </div>
    </div>
  </div>
</asp:Content>
