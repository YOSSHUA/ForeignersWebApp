<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="ModificaAlumno.aspx.cs" Inherits="ForeignersWeb.ModificaAluno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapper row2">
    <section class="hoc container clear"> 
   
    <div class="sectiontitle">
    <h6 class="heading">Modifica alumno</h6> 
    </div>
        <h2 style="">Cambia algunos de tus datos aquí</h2>
    <div style="align-content: center">
    <asp:Label ID="Label1" runat="server" Text="Modificaciones Alumno"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Cambiar Universidad"></asp:Label><br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Nueva Universidad"></asp:Label>
    <asp:DropDownList ID="ddlUni" runat="server"></asp:DropDownList>
    <br />
    <br />
    <asp:Button ID="Button2" runat="server" Text="cambiar mi Universidad" OnClick="Button2_Click" />
    <br />
    <br />
    <asp:Label ID="Label6" runat="server" Text="modificar Foto"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label7" runat="server" Text="Seleccionar foto"></asp:Label>
    <asp:FileUpload ID="FileUpload1" runat="server" />
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="cambiar foto" OnClick="Button1_Click" />
    <br />
    <asp:Label ID="lbResult" runat="server" Text=""></asp:Label>

    </div>
  </section>
</div>

</asp:Content>
