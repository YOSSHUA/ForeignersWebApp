<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="IndexStudent.aspx.cs" Inherits="ForeignersWeb.IndexStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" Text="Alta Alumno"></asp:LinkButton><br />
    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" Text="Baja Alumno"></asp:LinkButton><br />
    <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click" Text="Modificar Alumno"></asp:LinkButton><br />
</asp:Content>
