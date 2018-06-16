<%@ Page Title="Login" Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MonteLibano.Login" %>

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
                <asp:TextBox runat="server" id="txtusername" class="form-control" type="email" name="username" placeholder="name@example.com" />
                <label for="password">Senha</label>
		        <asp:TextBox runat="server" id="txtpassword" class="form-control" type="password" name="password" placeholder="Senha" />
                <asp:Label ID="lblLoginInvalido" Text="LOGIN INVALIDO" Font-Bold="true" ForeColor="Red" runat="server" Visible="false"></asp:Label>
                <asp:Button ID="btnEntrar" CssClass="btn btn-primary btn-block" runat="server"  Text="Entrar" OnClick="btnEntrar_onClick"/>
                <hr />
                <asp:Button ID="btnCadastrar" CssClass="btn btn-secondary btn-block" Text="Cadastrar-se" runat="server" OnClick="btnCadastrar_onClick" /> 
                <asp:Button  ID="btnEsqueciSenha" CssClass="btn btn-dark btn-block" Text="Esqueci a senha" runat="server" /> 
            </form>
        </div>
    </div>
</body>
</html>
