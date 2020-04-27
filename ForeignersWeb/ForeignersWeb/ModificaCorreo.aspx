<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="ModificaCorreo.aspx.cs" Inherits="ForeignersWeb.ModificaCorreo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="wrapper row2">
    <section class="hoc container clear"> 
   
    <div class="sectiontitle">
    <h6 class="heading">Modifica correo</h6> 
    </div>
        <h2 style="">Cambia el correo que tienes registrado aquí</h2>
        <div style="align-content: center">
    <asp:ScriptManager runat="server" EnablePartialRendering="true"></asp:ScriptManager>

    <asp:Label ID="Label3" runat="server" Text="Correo actual"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;
    <asp:TextBox ID="tbCorreoActual" runat="server" ForeColor="Black"></asp:TextBox>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Correo nuevo"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="tbCorreoNuevo" runat="server" ForeColor="Black"></asp:TextBox>
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" Text="CAMBIAR MI CORREO" OnClick="Button2_Click" />
    
   
    

    </div>
  </section>
</div>
</asp:Content>
