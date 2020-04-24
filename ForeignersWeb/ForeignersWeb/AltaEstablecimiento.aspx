<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="AltaEstablecimiento.aspx.cs" Inherits="ForeignersWeb.AltaEstablecimiento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <meta name="viewport" content="initial-scale=1.0, user-scalable=no">
    <meta charset="utf-8">
    <asp:ScriptManager runat="server" EnablePartialRendering="true"></asp:ScriptManager>
    

    <div id="divDatos" runat="server">

        <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtNom" runat="server"></asp:TextBox>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblDesc" runat="server" Text="Descripcion"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtDesc" runat="server" MaxLength="290" Height="35px" TextMode="MultiLine" Width="213px"></asp:TextBox>
        
        <br />
        <asp:Label ID="lblHa" runat="server" Text="Hora de apertura" format="HH:mm"></asp:Label>
        &nbsp;&nbsp;&nbsp; <asp:TextBox runat="server" ID="txtHA" TextMode="Time"></asp:TextBox>
        
        
        
        &nbsp;<asp:Label ID="Label1" runat="server" Text="Hora de cierre" ></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox runat="server" ID="txtHC" TextMode="Time" format="HH:mm"></asp:TextBox>
        
        <br />
        <asp:Label ID="lblRedS" runat="server" Text="Ingrese el link de su pagina de facebook"></asp:Label><br />
        <asp:TextBox ID="txtRedS" runat="server" ></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        Tipo de establecimiento &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlTipoEst" runat="server" >           
        </asp:DropDownList>
        <br />
        <br />

    </div>



    <div runat="server" id="divDir">
        <asp:Label ID="lblCalle" runat="server" Text="Calle y numero"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCalle" runat="server" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblCol" runat="server" Text="Municipio/Delegación"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtColDel" runat="server" />
        &nbsp;&nbsp;<br />
        <asp:Label ID="lblCp" runat="server" Text="Codigo postal"></asp:Label>
        &nbsp;&nbsp;&nbsp;        
        <asp:TextBox ID="txtCP" runat="server" TextMode="Number"/>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblEstado" runat="server" Text="Estado"></asp:Label>
        <asp:TextBox ID="txtEdo" runat="server" />
        <br>
        <asp:Label ID="lblPais" runat="server" Text="Pais"></asp:Label>
        <asp:DropDownList ID="ddlPais" runat="server" AutoPostBack="true"></asp:DropDownList>
        &nbsp;
        <style>
        /* Set the size of the div element that contains the map */
        #map {
            height: 400px; /* The height is 400 pixels */
            width: 100%; /* The width is the width of the web page */
        }
        </style>
        <script src="//ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
        <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyASt_r2bn3WZMmgBVVQLluzFdstRqaMZzc"></script>
        <!--The div element for the map -->
        <asp:Button ID="btnBuscarDir" runat="server" Text="Buscar direccion" OnClick="btnBuscarDir_Click" />
        <asp:Label ID="lblLat" runat="server" Text="" Visible="false"></asp:Label>
        <asp:Label ID="lblLng" runat="server" Text="" Visible="false"></asp:Label>
        <div id="map"></div>
        <script type="text/javascript">            

            var map;
            var mapcode;
            function initMap() {

                var lat0 = '<%= _lat0 %>';
                var lng0 = '<%= _lng0 %>';    
                mapcode = new google.maps.Geocoder();
                var lnt = new google.maps.LatLng(lat0, lng0);
                var diagChoice = {
                    zoom: 12,
                    center: lnt,
                    diagId: google.maps.MapTypeId.ROADMAP
                }
                map = new google.maps.Map(
                    document.getElementById('map'), diagChoice);


                var infoWindow = new google.maps.InfoWindow();
                var marker = new google.maps.Marker({
                    position: lnt,
                    map: map,
                    title: "Este será el lugar que se mostrara"
                });

            }            

        </script>
    </div>
    Seleccione una foto<br />
    <asp:FileUpload runat="server" ID="fUp" /><br /><br />    
    <asp:Button ID="btnUpload" runat="server" Text="Registrar establecimiento" OnClick="btnUpload_Click" />
</asp:Content>
