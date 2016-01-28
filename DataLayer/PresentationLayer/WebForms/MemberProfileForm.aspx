<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Site1.Master" AutoEventWireup="true" CodeBehind="MemberProfileForm.aspx.cs" Inherits="PresentationLayer.WebForms.MemberProfileForm" %>

<%@ PreviousPageType VirtualPath="LoginForm.aspx" %> 

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript">
        function previewFile() {
            var preview = document.querySelector('#<%=Avatar.ClientID %>');
            var file = document.querySelector('#<%=avatarUpload.ClientID %>').files[0];
            var reader = new FileReader();

            reader.onloadend = function () {
                preview.src = reader.result;
            }

            if (file) {
                reader.readAsDataURL(file);
            } else {
                preview.src = "";
            }
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
    <div class="col-xs-12 col-md-6 center-block">
      <div class="panel panel-default">
        <div class="panel-heading">
          <h3 class="panel-title">Profilul tau</h3>
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
                    placeholder="Parola"
                    title="Parola"></asp:TextBox>
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
            <label for="txtSex">Sex</label>
              <div class="row">
              <div class="col-xs-12 col-sm-8">
                <div class="input-group">
            <asp:TextBox ID="txtSex" runat="server"
              CssClass="form-control"
              placeholder="M/F"
              title="Sex"></asp:TextBox>
                    <span class="input-group-addon"><i class="text-info">(Optional)</i> </span>
                 </div>
                   </div>
              </div>
            </div>
              <div class="form-group">
            <label for="txtAddress">Adresa</label>
              
                <div class="input-group">
            <asp:TextBox ID="txtAddress" runat="server"
              CssClass="form-control"
              placeholder="Adresa"
              title="Adresa"></asp:TextBox>
                    
                <asp:TextBox ID="txtCity" runat="server"
              CssClass="form-control"
              placeholder="Oras"
              title="Oras"></asp:TextBox> 
               <asp:TextBox ID="txtCounty" runat="server"
              CssClass="form-control"
              placeholder="Judet"
              title="Judet"></asp:TextBox> 
                    
                    <span class="input-group-addon"><i class="text-info">(Optional)</i> </span>
                </div>
                                
            </div>

             <div class="form-group">
            <label for="txtSex">Religie</label>
              <div class="row">
              <div class="col-xs-12 col-sm-8">
                <div class="input-group">
            <asp:TextBox ID="txtReligion" runat="server"
              CssClass="form-control"
              placeholder="Religie"
              title="Religie"></asp:TextBox>
                    <span class="input-group-addon"><i class="text-info">(Optional)</i> </span>
                 </div>
                   </div>
              </div>
            </div>
            <div class="form-group">
            <label for="txtSex">Nationalitate</label>
              <div class="row">
              <div class="col-xs-12 col-sm-8">
                <div class="input-group">
            <asp:TextBox ID="txtNationality" runat="server"
              CssClass="form-control"
              placeholder="Nationalitate"
              title="Nationalitate"></asp:TextBox>
                    <span class="input-group-addon"><i class="text-info">(Optional)</i> </span>
                 </div>
                   </div>
              </div>
            </div>
            <div class="form-group">
            <label for="txtSex">Avatar</label>
              <div class="row">
              <div class="col-xs-12 col-sm-8">
                <div class="input-group">
          <input ID="avatarUpload" type="file" name="file" onchange="previewFile()"  runat="server" />
           
            <asp:Button ID="btnUpload" runat="server" CssClass="btn btn-primary" Text="Upload" OnClick="Upload" />
            <asp:Image ID="Avatar" runat="server" Height="150px" ImageUrl="../Images/male.png" Width="150px" />
                    </div>
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
          <div class="row">
            <div class="col-xs-12">
              <asp:Button ID="btnSave" runat="server"
                Text="Save"
                CssClass="btn btn-primary"
                OnClick="btnSave_Click" />
              <asp:Button ID="btnCancel" runat="server"
                Text="Cancel"
                CssClass="btn btn-primary"
                formnovalidate="formnovalidate"
                OnClick="btnCancel_Click" />
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="EndOfPageContent" runat="server">
</asp:Content>
