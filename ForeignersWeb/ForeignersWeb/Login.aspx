<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ForeignersWeb.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapper row2">
    <section class="hoc container clear"> 
    <!-- ################################################################################################ -->
    <div class="sectiontitle">
      <h6 class="heading">INICIA SESIÓN</h6>
      <p>Si no tienes una cuenta registrate</p>
    </div>
        <h2 style="">Ingresa tus datos aquí</h2>
    <div text-align: center;">
        <asp:Label runat="server" Text="Usuario *"></asp:Label>
        &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtUser" runat="server" ForeColor="Black"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
        <asp:Label runat="server" Text="Contraseña *    "></asp:Label>
        <asp:TextBox ID="txtPass" runat="server" TextMode="Password" ForeColor="Black"></asp:TextBox> 
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnInit" runat="server" Text="INGRESAR" OnClick="btnInit_Click" />
        <br />        
 </div>
  <div class="clear"></div>
  </section>
  <h2>&nbsp;</h2>
        <div class="one_third first">
            &nbsp;</div>
          <div class="one_third">
            &nbsp;</div>
          <div class="block clear">
          </div>
                 
      </div>

</asp:Content>
