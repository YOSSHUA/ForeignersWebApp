<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="BajaCliente.aspx.cs" Inherits="ForeignersWeb.BajaCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapper row2">
    <section class="hoc container clear"> 
   
    <div class="sectiontitle">
      <h6 class="heading">Baja Alumno</h6>
      <p>¿Estás seguro que te quieres dar de baja? Te extrañaremos</p>
    </div>
        <h2 style="margin-left: 120px">Si deseas eliminar tu cuenta en Foreigners da click en aceptar</h2>
    
    <p style="margin-left: 440px">
        &nbsp &nbsp;<asp:Button ID="btAceptar" align="center" runat="server" Text="ACEPTAR" OnClick="btAceptar_Click" />
    </p>
   <div class="clear"></div>
  </section>
    </div>
</asp:Content>
