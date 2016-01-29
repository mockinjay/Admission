<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Site1.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="PresentationLayer.WebForms.ChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <div class="row">
    <div class="col-xs-12 col-md-6 center-block">
      <div class="panel panel-primary">
        <div class="panel-heading">
          <h3 class="panel-title">Schimbare parola</h3>
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
            <label for="txtLoginPassword">Parola veche</label>
            <div class="input-group">
              <asp:TextBox ID="txtOldPassword" runat="server"
                TextMode="Password"
                CssClass="form-control"
                required="required"
                placeholder="Parola veche"
                title="Parola veche"></asp:TextBox>
              <span class="input-group-addon">
                <i class="glyphicon glyphicon-lock"></i>
              </span>
            </div>
          </div>
            
            <div class="form-group">
            <label for="txtLoginPassword">Parola noua</label>
            <div class="input-group">
              <asp:TextBox ID="txtNewPassword" runat="server"
                TextMode="Password"
                CssClass="form-control"
                required="required"
                placeholder="Confirmare Parola"
                title="Confirmare Parola"></asp:TextBox>
              <span class="input-group-addon">
                <i class="glyphicon glyphicon-lock"></i>
              </span>
            </div>
          </div>

            <div class="form-group">
            <label for="txtLoginPassword">Confirmare Parola Noua</label>
            <div class="input-group">
              <asp:TextBox ID="txtConfirmNewPassword" runat="server"
                TextMode="Password"
                CssClass="form-control"
                required="required"
                placeholder="Confirmare Parola Noua"
                title="Confirmare Parola Noua"></asp:TextBox>
              <span class="input-group-addon">
                <i class="glyphicon glyphicon-lock"></i>
              </span>
            </div>
          </div>
         
          <div class="form-group">
            <!-- NOTE: Include columns here to give some margin to the Check box -->
            
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
            
          <asp:Button ID="btnChangePasswd" runat="server"
            Text="Schimba parola"
            CssClass="btn btn-primary"
            title="Schimba parola"
            OnClick="btnChangePasswd_Click" />
        </div>
      </div>
    </div>
  </div>
         </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="EndOfPageContent" runat="server">
</asp:Content>
