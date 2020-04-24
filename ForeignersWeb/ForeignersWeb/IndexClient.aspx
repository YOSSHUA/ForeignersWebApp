<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="IndexClient.aspx.cs" Inherits="ForeignersWeb.Page1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:LinkButton ID="lkBtnMap" runat="server" OnClick="lkBtn_Click">Ver mapa</asp:LinkButton>

    &nbsp;&nbsp;<asp:LinkButton ID="lkBtnAltaCliente" runat="server" OnClick="lkBtnAltaCliente_Click">Alta cliente</asp:LinkButton>
    &nbsp;
    <asp:LinkButton ID="lkBajaAnuncio" runat="server" OnClick="lkBajaAnuncio_Click">Baja anuncio</asp:LinkButton>
    &nbsp;
    <asp:LinkButton ID="lkBajaCliente" runat="server" OnClick="lkBajaCliente_Click">Baja cliente</asp:LinkButton>
    &nbsp;

    <asp:LinkButton ID="lkBtnAltaRenta" runat="server" OnClick="lkBtnAltaRenta_Click">Alta de inmueble en renta</asp:LinkButton>
    &nbsp;
    <asp:LinkButton ID="lkBtnAltaEst" runat="server" OnClick="lkBtnAltaEst_Click">Alta de establecimiento</asp:LinkButton>
    &nbsp;&nbsp;<asp:LinkButton ID="lkBtnModiEstab" runat="server" OnClick="lkBtnModiEstab_Click">Modificar Establecimientos</asp:LinkButton>
    &nbsp;
    <asp:LinkButton ID="lkBtnAltaAnuncio" runat="server" OnClick="lkBtnAltaAnuncio_Click">Alta de anuncio</asp:LinkButton>
</asp:Content>
