<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="AltaAlumno.aspx.cs" Inherits="ForeignersWeb.AltaAlumno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label10" runat="server" Text="Alta Alumno"></asp:Label>
     <br />
     <br />
    <asp:Label ID="Label1" runat="server" Text="correo"></asp:Label>      
    <asp:TextBox ID="tbCorreo" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label> 
    <asp:TextBox ID="tbContra" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="tbNombre" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Apellido Paterno"></asp:Label>
    <asp:TextBox ID="tbApellidoP" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label5" runat="server" Text="Apellido Materno"></asp:Label>
    <asp:TextBox ID="tbApellidoM" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label6" runat="server" Text="Fecha Nacimiento"></asp:Label>
    <asp:TextBox ID="tbFechaNac" runat="server"></asp:TextBox>
    <br />
    <br />
   
    <asp:Label ID="Label8" runat="server" Text="sexo"></asp:Label>
    <asp:TextBox ID="tbSexo" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label9" runat="server" Text="Universidad"></asp:Label>
    <asp:DropDownList ID="ddlUni" runat="server" OnSelectedIndexChanged="ddlUni_SelectedIndexChanged"></asp:DropDownList>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Registrar" OnClick="Button1_Click1" />
     <br />
    <asp:Label ID="lbResult" runat="server" Text=""></asp:Label>
</asp:Content>
