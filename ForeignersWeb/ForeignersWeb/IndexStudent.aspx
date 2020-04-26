<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="IndexStudent.aspx.cs" Inherits="ForeignersWeb.IndexStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapper row2">
    <section class="hoc container clear"> 
   
    <div class="sectiontitle>
    <h6 class="heading">Alumno</div>
        
    <div style="align-content: center">
    <asp:LinkButton ID="lkBtnMap" runat="server" OnClick="lkBtn_Click">Ver mapa</asp:LinkButton>

    &nbsp; | &nbsp;<a href="javascript:__doPostBack('lkBtnAltaAnuncio','')">Baja alumno</a>&nbsp; |&nbsp;
    <asp:LinkButton ID="lkBtnAltaEst" runat="server" OnClick="lkBtnAltaEst_Click">Modifica alumno</asp:LinkButton>
        &nbsp;

    </div>
  </section>
</div>
</asp:Content>
