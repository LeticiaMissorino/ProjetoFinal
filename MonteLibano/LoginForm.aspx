<%@ Page Title="Cadastro de Login" Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="MonteLibano.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title><%: Page.Title %> - IrineuOM</title>

    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>

    <webopt:bundlereference runat="server" path="~/Content/css" />
    <link href="https://fonts.googleapis.com/css?family=Hind" rel="stylesheet" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
</head>
<body class="login-body">
    <div class="body-content login-background">
        <div class="jumbotron login">
            <div>
                <h3><%: Title %></h3>
            </div>
            <form runat="server" name="loginForm">
                <asp:ScriptManager runat="server">
                    <Scripts>
                        <%--To learn more about bundling scripts in ScriptManager see https://go.microsoft.com/fwlink/?LinkID=301884 --%>
                        <%--Framework Scripts--%>
                        <asp:ScriptReference Name="MsAjaxBundle" />
                        <asp:ScriptReference Name="jquery" />
                        <asp:ScriptReference Name="bootstrap" />
                        <asp:ScriptReference Name="respond" />
                        <asp:ScriptReference Name="WebForms.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebForms.js" />
                        <asp:ScriptReference Name="WebUIValidation.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebUIValidation.js" />
                        <asp:ScriptReference Name="MenuStandards.js" Assembly="System.Web" Path="~/Scripts/WebForms/MenuStandards.js" />
                        <asp:ScriptReference Name="GridView.js" Assembly="System.Web" Path="~/Scripts/WebForms/GridView.js" />
                        <asp:ScriptReference Name="DetailsView.js" Assembly="System.Web" Path="~/Scripts/WebForms/DetailsView.js" />
                        <asp:ScriptReference Name="TreeView.js" Assembly="System.Web" Path="~/Scripts/WebForms/TreeView.js" />
                        <asp:ScriptReference Name="WebParts.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebParts.js" />
                        <asp:ScriptReference Name="Focus.js" Assembly="System.Web" Path="~/Scripts/WebForms/Focus.js" />
                        <asp:ScriptReference Name="WebFormsBundle" />
                        <%--Site Scripts--%>
                    </Scripts>
                </asp:ScriptManager>
                <label for="username">Endereço de Email</label>
                <asp:TextBox  id="txtusername1" CssClass="form-control" runat="server" type="email"  placeholder="name@example.com" />
                <label for="password">Senha</label>
		        <asp:TextBox  id="txtpassword1" CssClass="form-control" runat="server" type="password" placeholder="Senha" />
                <label for="passwordrepeat">Repetir Senha</label>
		        <asp:TextBox id="txtpasswordrepeat1" CssClass="form-control" runat="server" type="password"  placeholder="Repetir Senha" />
                <p>
                    Ao realizar seu cadastro, você estará concordando com os <a href="#">Termos de Uso e Privacidade</a>. Leia com atenção.
                </p>
                <asp:Button ID="btnCadastrar2" CssClass="btn btn-primary btn-block"  runat="server"  Text="Cadastrar" OnClick="btnCadastrar2_onClick" />
            </form>
        </div>
    </div>
</body>
</html>

