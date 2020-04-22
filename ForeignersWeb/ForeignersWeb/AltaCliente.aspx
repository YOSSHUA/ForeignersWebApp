<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="AltaCliente.aspx.cs" Inherits="ForeignersWeb.AltaCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
        <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
    &nbsp;&nbsp;
        <asp:TextBox ID="txNombre" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    </p>
    <asp:Label ID="lblApePat" runat="server" Text="Apellido Paterno"></asp:Label>
    &nbsp;
    <asp:TextBox ID="txApPat" runat="server"></asp:TextBox>
&nbsp;<p>
        <asp:Label ID="lblApeMat" runat="server" Text="Apellido Materno"></asp:Label>
    &nbsp;<asp:TextBox ID="txApMAt" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblCorreo" runat="server" Text="Correo"></asp:Label>
    &nbsp;&nbsp;
        <asp:TextBox ID="txCorreo" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblContraseña" runat="server" Text="Contraseña"></asp:Label>
    &nbsp;&nbsp;
        <asp:TextBox ID="txContra" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblFechaNac" runat="server" Text="Fecha de nacimiento"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Calendar ID="FechaNac" runat="server"></asp:Calendar>
    </p>
    <p>
        <asp:Label ID="lblResultado" runat="server" Text="Resultado"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="btAgregar" runat="server" Text="Agregar" OnClick="btAgregar_Click" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
