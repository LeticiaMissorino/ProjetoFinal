<%@ Page Title="Eventos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Event.aspx.cs" Inherits="MonteLibano.Event" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="jumbotron">
        <div>
            <h3><%: Title %></h3>
        </div>
      <%--  <div class="custom-control custom-radio">
          <input type="radio" id="evento1" name="customRadio" class="custom-control-input">
          <label class="custom-control-label" for="evento1">Ritual do Cachimbo - Monte Líbano - 13/06/2018</label>
        </div>
        <div class="custom-control custom-radio">
          <input type="radio" id="evento2" name="customRadio" class="custom-control-input">
          <label class="custom-control-label" for="evento2">Ritual Xamânico - Om Mani Padme Hum - 16/06/2018</label>
        </div>--%>
        <asp:DropDownList runat="server" ID="drop" CssClass="btn btn-secondary dropdown-toggle" DataSourceID="sdsevento" DataTextField="nome" DataValueField="Id">
        </asp:DropDownList>
        <asp:SqlDataSource ID="sdsevento" runat="server" ConnectionString="<%$ ConnectionStrings:SQLSERVER %>" SelectCommand="Select Id, Concat(Nome + '- ', convert(varchar(10), DtEvento)) as nome from evento "></asp:SqlDataSource>
        <hr />
        <asp:Button  ID="btnConfirmarPresenca" CssClass="btn btn-dark btn-block" Text="Confirmar Presenca" runat="server" OnClick="btnConfirmarPresenca_onClick" /> 
    </div>

</asp:Content>
