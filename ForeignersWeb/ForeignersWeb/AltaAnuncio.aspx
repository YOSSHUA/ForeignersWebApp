<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="AltaAnuncio.aspx.cs" Inherits="ForeignersWeb.AltaAnuncio" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapper row2">
    <section class="hoc container clear"> 
   
    <div class="sectiontitle">
    <h6 class="heading">Alta anuncio</h6> 
    </div>
        <h2 style="">Ingresa los datos del anuncio aquí</h2>
    <div style="align-content: center">
    <asp:Label ID="lblTit" runat="server" Text="Título del anuncio"></asp:Label><asp:TextBox ID="txtTitle" runat="server" ForeColor="Black"></asp:TextBox>
    <br />
    <br />    
    <asp:Label ID="Label1" runat="server" Text="Fecha de vigencia"></asp:Label> 
    <asp:Calendar runat="server" ID="dtpF" OnDayRender="dtpF_DayRender"></asp:Calendar>
    &nbsp;Tipo<br />
    <asp:RadioButtonList ID="rbList" ClientIDMode= "AutoID" runat="server" OnSelectedIndexChanged="rbList_SelectedIndexChanged" AutoPostBack="true">
        <asp:ListItem Text="Inmueble" Value="1" ></asp:ListItem>
        <asp:ListItem Text="Establecimiento" Value="2"></asp:ListItem>
        <asp:ListItem Text="Otro" Value="0" Selected="True"></asp:ListItem>
    </asp:RadioButtonList>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
    <asp:Label ID="lblDesc" runat="server" Text="Descripción"></asp:Label>
    <asp:TextBox ID="txtDesc" runat="server" Text="" TextMode="MultiLine" Height="90px" Width="357px" ForeColor="Black"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnAlta" runat="server" Text="DAR DE ALTA" OnClick="btnAlta_Click" />
    <br />
    <br />
    <br />

            <asp:Table runat="server" ID="tb1">
                <asp:TableRow Enabled="false" ID="rowInm">
                    <asp:TableHeaderCell Text="Inmuebles" runat="server">
                    <asp:TableCell Width="" Height="" runat="server">                
                    </asp:TableCell>
                    <asp:GridView ID="gvInm" runat="server"  AutoGenerateSelectButton="True" OnSelectedIndexChanged="btnSelectInm_Click" >
                        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                        <Columns>
                    
                        </Columns>
                    </asp:GridView>
                    </asp:TableHeaderCell>            
                </asp:TableRow>
                <asp:TableRow Enabled="false" ID="rowEst">
                    <asp:TableHeaderCell Text="Establecimientos" runat="server">                
                    </asp:TableHeaderCell>
                    <asp:TableCell Width="" Height="" runat="server">
                        <asp:GridView ID="gvEst" runat="server"   AutoGenerateSelectButton="True" OnSelectedIndexChanged="btnSelectEst_Click">
                            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />                    
                            <Columns>                                       
                            </Columns>
                        </asp:GridView>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
       

    <br />
       </div>  
  </section>
 </div>
</asp:Content>
