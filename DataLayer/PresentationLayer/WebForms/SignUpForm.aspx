<%@ Page Title="Inregistrare" Language="C#" MasterPageFile="~/MasterPages/Site.Master" AutoEventWireup="true" CodeBehind="SignUpForm.aspx.cs" Inherits="PresentationLayer.WebForms.SignUpForm" %>

<%@ Register Src="../UserControls/TermsAndConditions.ascx" TagName="TermsAndConditions" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
  <script>
    function acceptTerms() {
      if (!($("#chkAgreeToTerms").prop('checked'))) {
        $("#chkAgreeToTerms").prop("checked", true);
      }
      $("#btnRegister").removeProp("disabled");
      $('#termsDialog').modal('hide');
    }

    function termsChecked() {
      if ($("#chkAgreeToTerms").prop('checked'))
        $("#btnRegister").removeProp("disabled");
      else
        $("#btnRegister").prop("disabled", "disabled");
    }
  </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  <div class="row">
    <div class="col-xs-12 col-md-6 center-block">
      <div class="modal fade"
           id="termsDialog" 
           role="dialog">
        <div class="modal-dialog">
          <div class="modal-content">
            <div class="modal-header">
              <button type="button" 
                      class="close" 
                      data-dismiss="modal">&times;</button>
              <h4 class="modal-title" id="termsLabel">Termeni si Conditii</h4>
            </div>
            <div class="modal-body">
              <uc1:TermsAndConditions ID="TermsAndConditions1" runat="server" />
            </div>
            <div class="modal-footer">
              <button type="button"
                      class="btn btn-default"
                      data-dismiss="modal">Nu accept</button>
              <button type="button" 
                      class="btn btn-primary"
                      onclick="acceptTerms();">Accept Termenii</button>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
  <div class="row">
    <div class="col-xs-12 col-md-6 center-block">
      <div class="panel panel-default">
        <div class="panel-heading">
          <h3 class="panel-title">Inregistrare</h3>
        </div>
        <div class="panel-body">
          <div class="form-group">
            <label for="txtName">Nume</label>
            <div class="row">
              <div class="col-xs-12 col-sm-8">
                <asp:TextBox ID="txtName" runat="server"
                  CssClass="form-control"
                  autofocus="autofocus"
                  required="required"
                  placeholder="Nume"
                  title="Nume"></asp:TextBox>
              </div>
            </div>
          </div>
          <div class="form-group">
            <label for="txtSurname">Prenume</label>
            <asp:TextBox ID="txtSurname" runat="server"
              CssClass="form-control"
              required="required"
              placeholder="Prenume"
              title="Prenume"></asp:TextBox>
          </div>
          <div class="form-group">
            <label for="txtEmail">Adresa de e-mail</label>
            <div class="input-group">
              <asp:TextBox ID="txtEmail" runat="server"
                TextMode="Email"
                CssClass="form-control"
                required="required"
                placeholder="Adresa de e-mail"
                title="Email"></asp:TextBox>
              <span class="input-group-addon">
                <i class="glyphicon glyphicon-envelope"></i>
              </span>
            </div>
          </div>
          <div class="form-group">
            <label for="txtPassword">Parola</label>
            <div class="row">
              <div class="col-xs-12 col-sm-8">
                <div class="input-group">
                  <asp:TextBox ID="txtPassword" runat="server"
                    TextMode="Password"
                    CssClass="form-control"
                    required="required"
                    placeholder="Password"
                    title="Password"></asp:TextBox>
                  <span class="input-group-addon">
                    <i class="glyphicon glyphicon-lock"></i>
                  </span>
                </div>
              </div>
            </div>
          </div>
          <div class="form-group">
            <label for="txtConfirmPassword">Confirmare Parola</label>
            <div class="row">
              <div class="col-xs-12 col-sm-8">
                <div class="input-group">
                  <asp:TextBox ID="txtConfirmPassword" runat="server"
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
            </div>
          </div>
          <div class="form-group">
            <label for="txtCNP">Cod Numeric Personal</label>
              <div class="row">
              <div class="col-xs-12 col-sm-8">
                <div class="input-group">
            <asp:TextBox ID="txtCNP" runat="server"
              CssClass="form-control"
              placeholder="CNP"
              title="CNP" TextMode="Phone"></asp:TextBox>
                    <span class="input-group-addon"><i class="text-info">(Optional)</i> </span>
                 </div>
                   </div>
              </div>
            </div>
          <div class="form-group">
            <!-- NOTE: Include columns here to give some margin to the Check box -->
            <div class="col-xs-12">
              <div class="checkbox">
                <label>
                  <input id="chkAgreeToTerms" type="checkbox" onchange="termsChecked();" />
                  Sunt de acord cu <a href="#" data-toggle="modal" data-target="#termsDialog">Termenii si conditiile site-ului.</a>
                </label>
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
          <asp:Button ID="btnRegister" runat="server"
            Enabled="false"
            Text="Register"
            CssClass="btn btn-primary"
            title="Register"
            OnClick="btnRegister_Click" />
        </div>
      </div>
    </div>
  </div>
</asp:Content>
