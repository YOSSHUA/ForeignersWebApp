<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="AltaCliente.aspx.cs" Inherits="ForeignersWeb.AltaCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <p>
        <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox ID="TextBox1Nombre" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblApePAt" runat="server" Text="Apellido Paterno"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txApePat" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblApeMat" runat="server" Text="Apellido Materno"></asp:Label>
        &nbsp;
        <asp:TextBox ID="TextBoxApeMat" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblCorreo" runat="server" Text="Correo"></asp:Label>
        &nbsp;
        <asp:TextBox ID="TextBoxCorreo" runat="server" TextMode="Email"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblContra" runat="server" Text="Contraseña"></asp:Label>
        &nbsp;
        <asp:TextBox ID="TextBoxContra" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblFechaN" runat="server" Text="Fecha de nacimiento"></asp:Label>
        &nbsp;
    </p>
    <p>
        <asp:Calendar ID="FechaNac" runat="server"></asp:Calendar>
    </p>
    <p>
        &nbsp;
    </p>
    <p>
        <asp:Button ID="btAgregar" runat="server" Text="Agregar" OnClick="btAgregar_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblRespuesta" runat="server" Text="Resultado"></asp:Label>
    </p>
    <p>
        &nbsp;
    </p>

</asp:Content>
