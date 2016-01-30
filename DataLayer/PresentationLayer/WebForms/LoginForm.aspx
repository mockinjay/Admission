<%@ Page Title="Login" Language="C#" MasterPageFile="~/MasterPages/Site.Master" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="PresentationLayer.WebForms.LoginForm" %>
<%@ MasterType  virtualPath="~/MasterPages/Site.Master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  <div class="row">
    <div class="col-xs-12 col-md-6 center-block">
      <div class="panel panel-primary">
        <div class="panel-heading">
          <h3 class="panel-title">Sign in</h3>
        </div>
        <div class="panel-body">
          <div class="form-group">
            <label for="LoginEmail">Adresa de e-mail</label>
            <div class="input-group">
              <asp:TextBox ID="txtLoginEmail" runat="server"
                TextMode="Email"
                CssClass="form-control"
                autofocus="autofocus"
                required="required"
                placeholder="E-mail"
                title="E-mail"></asp:TextBox>
              <span class="input-group-addon">
                <i class="glyphicon glyphicon-envelope"></i>
              </span>
            </div>
          </div>
          <div class="form-group">
            <label for="txtLoginPassword">Parola</label>
            <div class="input-group">
              <asp:TextBox ID="txtLoginPassword" runat="server"
                TextMode="Password"
                CssClass="form-control"
                required="required"
                placeholder="Parola"
                title="Parola"></asp:TextBox>
              <span class="input-group-addon">
                <i class="glyphicon glyphicon-lock"></i>
              </span>
            </div>
          </div>
          <div class="form-group">
            <a href="RecoverPasswordForm.aspx" 
               class="pull-right">Ati uitat parola?</a>
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
        <div class="panel-footer">
            
          <asp:Button ID="btnSignIn" runat="server"
            Text="Sign In"
            CssClass="btn btn-primary"
            title="Sign In"
            OnClick="btnSignIn_Click" />
        </div>
      </div>
    </div>
  </div>
    </div>
</asp:Content>