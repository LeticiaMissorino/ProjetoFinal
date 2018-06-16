<%@ Page Title="Cadastro de Usuário" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserForm.aspx.cs" Inherits="MonteLibano.UserForm" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron user">
        <div>
            <h3><%: Title %></h3>
        </div>
        <div class="form-group row">
            <div class="col-md-12">
                <label for="fullname">Nome Completo</label>
                <asp:TextBox id="fullname" class="form-control" runat="server" type="text" name="fullname" placeholder="Nome Completo" />
            </div>
        </div>
        <div class="form-group row">
            <div class="col-md-4">
                <label for="rg">RG</label>
                <asp:TextBox id="rg" class="form-control" runat="server" type="text" name="rg" placeholder="RG" />
            </div>
            <div class="col-md-4">
                <label for="cpf">CPF</label>
                <asp:TextBox id="cpf" class="form-control"  runat="server" ype="text" name="cpf" placeholder="CPF" />
            </div>
            <div class="col-md-4">
                <label for="nacionalidade">Nacionalidade</label>
                <asp:TextBox id="nacionalidade" class="form-control" runat="server" type="text" name="nacionalidade" placeholder="Nacionalidade" />
            </div>
        </div>
        <hr />
        <div class="form-group row">
            <div class="col-md-6">
                <label for="rg">CEP</label>
                <asp:TextBox id="cep" CssClass="form-control" runat="server" type="text" name="cep" placeholder="CEP" />
            </div>
        </div>
        <div class="form-group row">
            <div class="col-md-12">
                <label for="logradouro">Logradouro</label>
                <asp:TextBox id="logradouro" runat="server" CssClass="form-control" type="text" name="logradouro" placeholder="Logradouro" />
            </div>
        </div>
        <div class="form-group row">
            <div class="col-md-4">
                <label for="numero">Número</label>
                <asp:TextBox id="numero" class="form-control" runat="server" type="text" name="numero" placeholder="Número" />
            </div>
            <div class="col-md-4">
                <label for="complemento">Complemento</label>
                <asp:TextBox id="complemento" class="form-control" runat="server" type="text" name="complemento" placeholder="Complemento" />
            </div>
            <div class="col-md-4">
                <label for="bairro">Bairro</label>
                <asp:TextBox id="bairro" class="form-control" runat="server" type="text" name="bairro" placeholder="Bairro" />
            </div>
        </div>
        <div class="form-group row">
            <div class="col-md-5">
                <label for="cidade">Cidade</label>
                <asp:DropDownList runat="server" id="cidade" class="custom-select" name="cidade">
                    <asp:ListItem Text="ARARAQUARA"></asp:ListItem>
                    <asp:ListItem Text="São Carlos"></asp:ListItem>
                  <%--  <option disabled selected>Cidade</option>
                    <option>Araraquara</option>
                    <option>São Carlos</option>
                    <option>Belo Horizonte</option>--%>
                </asp:DropDownList>
            </div>
            <div class="col-md-2">
                <label for="uf">UF</label>
                <asp:DropDownList runat="server" id="uf" class="custom-select" name="uf">
                    <asp:ListItem Text="SP"></asp:ListItem>
                  <%--  <option disabled selected>UF</option>
                    <option>SP</option>
                    <option>MG</option>--%>
                </asp:DropDownList>
            </div>
            <div class="col-md-5">
                <label for="pais">País</label>
                <asp:DropDownList runat="server" id="pais" class="custom-select" name="pais">
                    <asp:ListItem Text="BRASIL"></asp:ListItem>
             <%--       <option disabled selected>País</option>
                    <option>Brasil</option>
                    <option>EUA</option>
                    <option>Alemanha</option>--%>
                </asp:DropDownList>
            </div>
        </div>
        <hr />
        <asp:Button runat="server" ID="btnSalvar" CssClass="btn btn-primary btn-block" OnClick="btnSalvar_Click"  Text="Salvar"/>
        <asp:Button runat="server" CssClass="btn btn-danger btn-block"  ID="btnCancelar" Text="Cancelar"/> 
    </div>

</asp:Content>
