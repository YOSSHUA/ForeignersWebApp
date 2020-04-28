<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="ModificaRenta.aspx.cs" Inherits="ForeignersWeb.ModificaRenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <link rel="stylesheet" href="https://ajax.googleapis.com/ajax/libs/jqueryui/1.8.24/themes/start/jquery-ui.css" />
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.8.24/jquery-ui.min.js"></script>
    <script type="text/javascript">
    $(function () {
        $("#dialog").dialog({
            autoOpen: false,
            modal: true,
            height: 600,
            width: 600,
            title: "Zoomed Image"
        });
        $("[id*=gvImages] img").click(function () {
            $('#dialog').html('');
            $('#dialog').append($(this).clone());
            $('#dialog').dialog('open');
        });
    });
    </script>
      <div class="wrapper row2">
    <section class="hoc container clear"> 
   
    <div class="sectiontitle">
    <h6 class="heading">Modifica tus inmuebles registrados</h6> 
    </div>        
    <h2 style="">Modifica los datos de tu establecimiento aquí</h2>
    <div style="align-content: center">
        <asp:ScriptManager runat="server" EnablePartialRendering="true"></asp:ScriptManager>


        <div id="divDatos" runat="server">
            Primero debe escoger el id del establecimiento que desea modificar. Estos son tus establecimientos<br />
            <br />
            <asp:GridView ID="gvInm" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="btnSelectInm_Click" >
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                
                <Columns>
                </Columns>
            </asp:GridView>
            <br />
            Id del establecimiento que desea modificar&nbsp;
         <asp:TextBox ID="txtID" runat="server" Enabled="false" Font-Bold="true" ForeColor="Black" ></asp:TextBox>
                      
            <br />
            <asp:Label ID="lblDescripcion" runat="server" Text="Descripción"></asp:Label>
            
        <asp:TextBox ID="txtDesc" runat="server" MaxLength="290" Height="35px" TextMode="MultiLine" Width="213px" ForeColor="Black"></asp:TextBox>

            &nbsp;<asp:Button ID="btnActDesc" runat="server" Text="Actualizar" OnClick="btnActDesc_Click" />

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
        <br />

            <br />
            <asp:Label ID="lblHa" runat="server" Text="Precio" ></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox runat="server" ID="txtPrecio" Width="203px" ForeColor="Black" TextMode="Number"></asp:TextBox>&nbsp;
        <asp:Button ID="btnActP" runat="server" Text="Actualizar" OnClick="btnActP_Click"/>
            <br />
            <br />



            <asp:Label ID="Label1" runat="server" Text="No.de habitaciones"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox runat="server" ID="txtNH" TextMode="Number"  Width="200px" ForeColor="Black" ></asp:TextBox>

            &nbsp;
        <asp:Button ID="btnActNH" runat="server" Text="Actualizar" OnClick="btnActNH_Click"/>

            <br />
            &nbsp;&nbsp;
            <br />
            Telefono&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:TextBox runat="server" ID="txtTel"></asp:TextBox>

            &nbsp;&nbsp;<asp:Button runat="server" ID="btnActTel" Text="Actualizar" OnClick="btnActTel_Click"/>
        

            <br />
            <br />


            Esta es la foto actual<br />
            <asp:Table runat="server" >
                <asp:TableRow>
                    <asp:TableCell >
                        <asp:Image runat="server" ID="img" Height="210px" Width="212px" /><br />
                        <asp:TextBox runat="server" ID="txtIDPic" Enabled="false"> </asp:TextBox>
                        <br />
                        Seleccione una foto nueva
                        <asp:FileUpload runat="server" ID="fUp" Height="20px" Width="305px" ForeColor="Black" /> <br />
                        <asp:Button ID="btnActFoto" runat="server" Text="Actualizar foto" OnClick="btnActFoto_Click" />
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:GridView ID="gvPics" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gvPics_SelectedIndexChanged" AutoGenerateColumns="false" OnRowDataBound="gvPics_RowDataBound" >
                            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />

                            <Columns>
                                <asp:BoundField HeaderText="ID Foto" DataField="idFoto"></asp:BoundField>                                
                                <asp:TemplateField HeaderText="Imagen">                                
                                    <ItemTemplate>
                                        <asp:Image ID ="gvImg" runat="server"/>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="ID inmueble" DataField="idInm"></asp:BoundField>
                            </Columns>
                        </asp:GridView>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <div id="dialog" style="display: none">            

            </div>
        </div>
    </div>
  </section>
</div>
</asp:Content>
