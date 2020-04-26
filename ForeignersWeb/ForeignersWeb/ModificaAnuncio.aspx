<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="ModificaAnuncio.aspx.cs" Inherits="ForeignersWeb.ModificaAnuncio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="wrapper row2">
    <section class="hoc container clear"> 
   
    <div class="sectiontitle>
    <h6 class="heading">Modifica anuncio</h6> 
    </div>
        <h2 style="">Cambia la vigencia de tus anuncios aquí</h2>
        <div style="align-content: center">
    <asp:ScriptManager runat="server" EnablePartialRendering="true" ID="ScriptManager1"></asp:ScriptManager>
    

    <div id="divDatos" runat="server">

         Primero debe escoger el id del anuncio que desea modificar. Estos son sus anuncios.<br />
         <br />
         <asp:GridView ID="gvAnun" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="btnSelectInm_Click">
             <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
         </asp:GridView>

            </div>
            <br />
         Id del establecimiento que desea modificar&nbsp;
         <asp:TextBox ID="txtID" runat="server" Enabled="false" Font-Bold="true" ForeColor="Black" OnTextChanged="txtID_TextChanged"></asp:TextBox>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Inserta nueva vigencia"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Calendar runat="server" ID="dtpF" OnDayRender="dtpF_DayRender" style="margin-top: 0px" OnSelectionChanged="dtpF_SelectionChanged"></asp:Calendar>
    &nbsp;<br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:Button ID="Button2" runat="server" Text="CAMBIAR LA VIGENCIA" OnClick="Button2_Click" />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />

    </div>
  </section>
</div>
</asp:Content>
