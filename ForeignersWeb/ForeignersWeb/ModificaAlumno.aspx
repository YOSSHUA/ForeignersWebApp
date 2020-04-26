<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="ModificaAlumno.aspx.cs" Inherits="ForeignersWeb.ModificaAluno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapper row2">
    <section class="hoc container clear"> 
   
    <div class="sectiontitle>
    <h6 class="heading">Modifica alumno</h6> 
    </div>
        <h2 style="">Cambia algunos de tus datos aquí</h2>
    <div style="align-content: center">
    <asp:Label ID="Label1" runat="server" Text="Modificaciones Alumno"></asp:Label>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Correo"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;
    <asp:TextBox ID="tbCorreo" runat="server" ForeColor="Black"></asp:TextBox>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Contra"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="tbContra" runat="server" ForeColor="Black"></asp:TextBox>
    <br />
        <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Cambiar Universidad"></asp:Label>
    <br />
    <asp:Label ID="Label5" runat="server" Text="Nueva Universidad"></asp:Label>
    &nbsp;&nbsp;
    <asp:DropDownList ID="ddlUni" runat="server" ForeColor="Black"></asp:DropDownList>
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" Text="CAMBIAR MI UNIVERSIDAD" OnClick="Button2_Click" />
    <br />
        <br />
    <br />
    <asp:Label ID="Label6" runat="server" Text="Modificar Foto"></asp:Label>
    <br />
    <asp:Label ID="Label7" runat="server" Text="Seleccionar foto"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:FileUpload ID="FileUpload1" runat="server" ForeColor="Black" />
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="CAMBIAR FOTO" OnClick="Button1_Click" />
    <br />
    <asp:Label ID="lbResult" runat="server" Text=""></asp:Label>

    </div>
  </section>
</div>

</asp:Content>
