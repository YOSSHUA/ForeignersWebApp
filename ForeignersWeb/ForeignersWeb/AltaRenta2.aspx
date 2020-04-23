<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="AltaRenta2.aspx.cs" Inherits="ForeignersWeb.AltaRenta2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
            <asp:FileUpload ID="pic1" runat="server" />
            <br />
            <asp:FileUpload ID="pic2" runat="server" />
            <br />
            <asp:FileUpload ID="pic3" runat="server" />
            <br />
            <asp:FileUpload ID="pic4" runat="server" />
            <br />
            <asp:Button ID="btnUp" runat="server" Text="Subir fotos" OnClick="btnUp_Click" />
            <br />
       
</asp:Content>
