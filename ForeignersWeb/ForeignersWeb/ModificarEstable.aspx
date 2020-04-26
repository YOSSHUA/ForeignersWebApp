<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="ModificarEstable.aspx.cs" Inherits="ForeignersWeb.ModificarEstable" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <meta name="viewport" content="initial-scale=1.0, user-scalable=no">
    <meta charset="utf-8">
    <asp:ScriptManager runat="server" EnablePartialRendering="true"></asp:ScriptManager>
    

    <div id="divDatos" runat="server">

         Primero debe escoger el id del establecimiento que desea modificar. Estos son sus inmuebles.<br />
         <br />
         <asp:GridView ID="gvEst" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="btnSelectInm_Click">
             <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
         </asp:GridView>
         <br />
         Id del establecimiento que desea modificar&nbsp;
         <asp:TextBox ID="txtID" runat="server" Enabled="false" Font-Bold="true"></asp:TextBox>
         <br />
         <br />
         <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtNom" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;
      &nbsp;<asp:Button ID="btActNombre" runat="server" Text="Actualizar" OnClick="btActNombre_Click" />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
<asp:Label ID="lblDescripcion" runat="server" Text="Descripción"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtDesc" runat="server" MaxLength="290" Height="35px" TextMode="MultiLine" Width="213px"></asp:TextBox>
        
        &nbsp;<asp:Button ID="btnActDesc" runat="server" Text="Actualizar" OnClick="btnActDesc_Click" />
        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
        <br />
        
        <br />
        <asp:Label ID="lblHa" runat="server" Text="Hora de apertura" format="HH:mm"></asp:Label>
        &nbsp;&nbsp;&nbsp; <asp:TextBox runat="server" ID="txtHA" TextMode="Time"></asp:TextBox>&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnActHA" runat="server" Text="Actualizar" OnClick="btnActHA_Click" />
        <br />
        <br />
        
        
        
        <asp:Label ID="Label1" runat="server" Text="Hora de cierre" ></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox runat="server" ID="txtHC" TextMode="Time" format="HH:mm"></asp:TextBox>
        
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnActHC" runat="server" Text="Actualizar" OnClick="btnActHC_Click" />
        
        <br />
        
        <br />
        <asp:Label ID="lblRedS" runat="server" Text="Ingrese el link de su pagina de facebook"></asp:Label>&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtRedS" runat="server" ></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnActFb" runat="server" Text="Actualizar" OnClick="btnActFb_Click" />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        Tipo de establecimiento &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlTipoEst" runat="server" >           
        </asp:DropDownList>

            
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnAct" runat="server" Text="Actualizar" OnClick="btnAct_Click" />

            
        <br />
        <br />

            
         Esta es la foto actual<br />
         <asp:Image ID="img" runat="server" Height="300px" Width="260px" />
         <br />

            
    Seleccione una foto <asp:FileUpload runat="server" ID="fUp" Height="20px" Width="305px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Button ID="btnActFoto" runat="server" Text="Actualizar" OnClick="btnActFoto_Click" />
         <br />    
        <br />
        <br />

    </div>



   
                 

   

</asp:Content>
