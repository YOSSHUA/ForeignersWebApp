<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="BajaAlumno.aspx.cs" Inherits="ForeignersWeb.BajaAlumno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Baja Alumno"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Correo"></asp:Label>
    <asp:TextBox ID="tbCorreo2" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Contraseña"></asp:Label>
    <asp:TextBox ID="tbContra2" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Baja" OnClick="Button1_Click" />
     <br />
    <asp:Label ID="lbResult" runat="server" Text=""></asp:Label>
</asp:Content>
