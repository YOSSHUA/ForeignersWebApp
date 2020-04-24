<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ForeignersWeb.Page1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:LinkButton ID="lkBtnMap" runat="server" OnClick="lkBtn_Click">Ver mapa</asp:LinkButton>

    &nbsp;&nbsp;<asp:LinkButton ID="lkBtnAltaCliente" runat="server" OnClick="lkBtnAltaCliente_Click">Alta cliente</asp:LinkButton>
    &nbsp;
    <asp:LinkButton ID="lkBajaAnuncio" runat="server" OnClick="lkBajaAnuncio_Click">Baja anuncio</asp:LinkButton>
    &nbsp;&nbsp;

    <asp:LinkButton ID="lkBtnAltaRenta" runat="server" OnClick="lkBtnAltaRenta_Click">Alta de inmueble en renta</asp:LinkButton>
     
</asp:Content>
