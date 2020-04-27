<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="IndexClient.aspx.cs" Inherits="ForeignersWeb.Page1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="wrapper row2">
    <section class="hoc container clear"> 
   
    <div class="sectiontitle">
    <h6 class="heading">Cliente</h6></div>
        
    <div style="align-content: center">
    

    <asp:LinkButton ID="lkBtnAltaAnuncio" runat="server" OnClick="lkBtnAltaAnuncio_Click">Alta anuncio</asp:LinkButton>
        &nbsp;|
    <asp:LinkButton ID="lkBtnAltaEst" runat="server" OnClick="lkBtnAltaEst_Click">Alta establecimiento</asp:LinkButton>
    &nbsp;|

    <asp:LinkButton ID="lkBtnAltaRenta" runat="server" OnClick="lkBtnAltaRenta_Click">Alta renta</asp:LinkButton>
    &nbsp;|
    <asp:LinkButton ID="lkBajaAnuncio" runat="server" OnClick="lkBajaAnuncio_Click">Baja anuncio</asp:LinkButton>
    &nbsp;|
    <asp:LinkButton ID="lkBajaCliente" runat="server" OnClick="lkBajaCliente_Click">Baja cliente</asp:LinkButton>
    &nbsp;|&nbsp;<asp:LinkButton ID="lkBtnModiEstab" runat="server" OnClick="lkBtnModiEstab_Click">Modificar Establecimiento</asp:LinkButton>
    &nbsp;|
        <asp:LinkButton ID="lkBtnModiAn" runat="server" OnClick="lkBtnModiAnun_Click">Modificar anuncio</asp:LinkButton>
    &nbsp;| <asp:LinkButton ID="lkBtnModMail" runat="server" OnClick="lkBtnModMail_Click">Modificar correo</asp:LinkButton>
    &nbsp;| <asp:LinkButton ID="lkBtnModRenta" runat="server" OnClick="lkBtnModRenta_Click" >Modificar inmueble</asp:LinkButton>
    </div>
        <label>Tus establecimientos </label>
        <asp:GridView ID="gvEst" runat="server"></asp:GridView>
        <label>Tus inmuebles </label>
        <asp:GridView ID="gvInm" runat="server"></asp:GridView>
        <label>Tus anuncios </label>
        <asp:GridView ID="gvAnuncios" runat="server"></asp:GridView>        
  </section>
         
</div>
</asp:Content>
