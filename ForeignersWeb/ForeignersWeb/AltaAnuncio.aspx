<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="AltaAnuncio.aspx.cs" Inherits="ForeignersWeb.AltaAnuncio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:Label ID="lblTit" runat="server" Text="Título del anuncio"></asp:Label><asp:TextBox ID="txtTitle" runat="server"></asp:TextBox><br />
    <asp:Table runat="server" ID="Table1">
        <asp:TableRow>
            <asp:TableHeaderCell Text="Inmuebles" runat="server">
            <asp:TableCell Width="200" Height="200" runat="server">                
            </asp:TableCell>
            <asp:GridView ID="gvInm" runat="server"  AutoGenerateSelectButton="True" OnSelectedIndexChanged="btnSelectInm_Click">
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <Columns>
                    
                </Columns>
            </asp:GridView>
            </asp:TableHeaderCell>            
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableHeaderCell Text="Establecimientos" runat="server">                
            </asp:TableHeaderCell>
            <asp:TableCell Width="200" Height="200" runat="server">
                <asp:GridView ID="gvEst" runat="server"   AutoGenerateSelectButton="True" OnSelectedIndexChanged="btnSelectEst_Click">
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <Columns>                        
                    </Columns>
                </asp:GridView>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>

    <br />
    
    <asp:Label ID="lblDesc" runat="server" Text="Descripción"></asp:Label>
    <asp:TextBox ID="txtDesc" runat="server" Text="" Enabled="false"></asp:TextBox><br />
    <asp:Button ID="btnAlta" runat="server" Text="Dar de alta" />
    <br />


</asp:Content>
