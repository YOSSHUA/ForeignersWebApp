<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="BajaAlumno.aspx.cs" Inherits="ForeignersWeb.BajaAlumno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="wrapper row2">
    <section class="hoc container clear"> 
   
    <div class="sectiontitle>
    <h6 class="heading">Baja alumno</h6> 
    </div>
        <h2 style="">No dejes de ser parte de nuestra familia, ¡te extrañaremos!</h2>
        <div style="align-content: center">
    <asp:Label ID="Label2" runat="server" Text="Correo"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="tbCorreo2" runat="server" ForeColor="Black"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Contraseña"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="tbContra2" runat="server" ForeColor="Black"></asp:TextBox>
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="BAJA" OnClick="Button1_Click" />
     <br />
    <asp:Label ID="lbResult" runat="server" Text=""></asp:Label>
        </div>
  </section>
</div>
</asp:Content>
