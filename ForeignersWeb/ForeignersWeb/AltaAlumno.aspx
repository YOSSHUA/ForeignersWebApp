<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="AltaAlumno.aspx.cs" Inherits="ForeignersWeb.AltaAlumno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapper row2">
    <section class="hoc container clear"> 
   
    <div class="sectiontitle">
    <h6 class="heading">Registrate</h6> 
    </div>
        <h2 style="">Ingresa tus datos aquí</h2>
    <div style="align-content: center">
    <asp:Label ID="Label10" runat="server" Text="Alta Alumno"></asp:Label>
     <br />
     <br />
    <asp:Label ID="Label1" runat="server" Text="Correo  "></asp:Label>      
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;      
    <asp:TextBox ID="tbCorreo" runat="server" ForeColor="Black"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label> 
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    <asp:TextBox ID="tbContra" runat="server" ForeColor="Black"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Nombre"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="tbNombre" runat="server" ForeColor="Black"></asp:TextBox>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Apellido Paterno"></asp:Label>
    &nbsp;&nbsp;
    <asp:TextBox ID="tbApellidoP" runat="server" ForeColor="Black"></asp:TextBox>
    <br />
    <asp:Label ID="Label5" runat="server" Text="Apellido Materno"></asp:Label>
    &nbsp;
    <asp:TextBox ID="tbApellidoM" runat="server" ForeColor="Black"></asp:TextBox>
    <br />
    <asp:Label ID="Label6" runat="server" Text="Fecha Nacimiento"></asp:Label>
    &nbsp;
    <asp:TextBox ID="tbFechaNac" runat="server" ForeColor="Black" TextMode="Date" format="dd/MM/yyyy"></asp:TextBox>
    <br />
   
    <asp:Label ID="Label8" runat="server" Text="Sexo"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList runat="server" ID="ddlSexo">
        <asp:ListItem Text="Masculino" Value="1" ></asp:ListItem>
        <asp:ListItem Text="Femenino" Value="0"></asp:ListItem>
        
    </asp:DropDownList>
        
    <br />
    <asp:Label ID="Label9" runat="server" Text="Universidad"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="ddlUni" runat="server"  Height="16px" Width="127px" ForeColor="Black"></asp:DropDownList>
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="REGISTRARSE" OnClick="Button1_Click1" />
        <br />
     <br />
    <asp:Label ID="lbResult" runat="server" Text=""></asp:Label>
        </div>
  </section>
</div>
</asp:Content>
