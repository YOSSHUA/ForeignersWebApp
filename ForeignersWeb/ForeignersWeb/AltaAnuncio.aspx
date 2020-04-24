<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="AltaAnuncio.aspx.cs" Inherits="ForeignersWeb.AltaAnuncio" %>
<%@ Register assembly="EO.Web" namespace="EO.Web" tagprefix="eo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:Label ID="lblTit" runat="server" Text="Título del anuncio"></asp:Label><asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
    <br />
    <br />

    <asp:Label ID="Label1" runat="server" Text="Fecha de vigencia"></asp:Label> <eo:DatePicker ID="dtpFin" runat="server" ClientIDMode="AutoID" DisabledDates="" SelectedDates="" ControlSkinID="None" CssBlock="&lt;style type=&quot;text/css&quot;&gt;
.dtpFin11 {background-color:white;border-bottom-color:#7f9db9;border-bottom-style:solid;border-bottom-width:1px;border-left-color:#7f9db9;border-left-style:solid;border-left-width:1px;border-right-color:#7f9db9;border-right-style:solid;border-right-width:1px;border-top-color:#7f9db9;border-top-style:solid;border-top-width:1px;font-family:tahoma;font-size:9px;padding-bottom:4px;padding-left:4px;padding-right:4px;padding-top:4px}
.dtpFin12 {border-bottom-color:#aca899;border-bottom-style:solid;border-bottom-width:1px;font-family:tahoma;font-size:12px}
.dtpFin13 {border-bottom-color:white;border-bottom-style:solid;border-bottom-width:1px;border-left-color:white;border-left-style:solid;border-left-width:1px;border-right-color:white;border-right-style:solid;border-right-width:1px;border-top-color:white;border-top-style:solid;border-top-width:1px;font-family:tahoma;font-size:12px}
.dtpFin14 {border-bottom-color:#fbe694;border-bottom-style:solid;border-bottom-width:1px;border-left-color:#fbe694;border-left-style:solid;border-left-width:1px;border-right-color:#fbe694;border-right-style:solid;border-right-width:1px;border-top-color:#fbe694;border-top-style:solid;border-top-width:1px;font-family:tahoma;font-size:12px}
.dtpFin15 {border-bottom-color:#bb5503;border-bottom-style:solid;border-bottom-width:1px;border-left-color:#bb5503;border-left-style:solid;border-left-width:1px;border-right-color:#bb5503;border-right-style:solid;border-right-width:1px;border-top-color:#bb5503;border-top-style:solid;border-top-width:1px;font-family:tahoma;font-size:12px}
.dtpFin16 {border-bottom-color:white;border-bottom-style:solid;border-bottom-width:1px;border-left-color:white;border-left-style:solid;border-left-width:1px;border-right-color:white;border-right-style:solid;border-right-width:1px;border-top-color:white;border-top-style:solid;border-top-width:1px;color:gray;font-family:tahoma;font-size:12px}
.dtpFin17 {cursor:pointer;cursor:hand;font-family:tahoma;font-size:12px;margin-left:14px;margin-right:14px}
.dtpFin18 {background-color:#fbe694;border-bottom-color:white;border-bottom-style:solid;border-bottom-width:1px;border-left-color:white;border-left-style:solid;border-left-width:1px;border-right-color:white;border-right-style:solid;border-right-width:1px;border-top-color:white;border-top-style:solid;border-top-width:1px;font-family:tahoma;font-size:12px}
.dtpFin19 {cursor:pointer;cursor:hand}
.dtpFin110 {background-color:#9ebef5;font-family:Tahoma;font-size:12px;padding-bottom:2px;padding-left:6px;padding-right:6px;padding-top:2px}
&lt;/style&gt;"
        DayCellHeight="16" DayCellWidth="19" DayHeaderFormat="FirstLetter" OtherMonthDayVisible="True" TitleLeftArrowImageUrl="DefaultSubMenuIconRTL" TitleRightArrowImageUrl="DefaultSubMenuIcon" VisibleDate="2020-04-01">
        <PickerStyle CssText="font-family:Courier New; padding-left:5px; padding-right: 5px;" />
        <CalendarStyle CssClass="dtpFin11" />
        <TitleStyle CssClass="dtpFin110" />
        <TitleArrowStyle CssClass="dtpFin19" />
        <MonthStyle CssClass="dtpFin17" />
        <DayHeaderStyle CssClass="dtpFin12" />
        <DayStyle CssClass="dtpFin13" />
        <DayHoverStyle CssClass="dtpFin14" />
        <TodayStyle CssClass="dtpFin15" />
        <SelectedDayStyle CssClass="dtpFin18" />
        <DisabledDayStyle CssClass="dtpFin16" />
        <OtherMonthDayStyle CssClass="dtpFin16" />
    </eo:DatePicker>
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
    <asp:TextBox ID="txtDesc" runat="server" Text="" TextMode="MultiLine" Height="90px" Width="357px"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnAlta" runat="server" Text="Dar de alta" OnClick="btnAlta_Click" />
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


    

</asp:Content>
