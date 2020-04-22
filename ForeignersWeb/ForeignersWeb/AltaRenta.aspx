<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="AltaRenta.aspx.cs" Inherits="ForeignersWeb.AltaRenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <meta name="viewport" content="initial-scale=1.0, user-scalable=no">
    <meta charset="utf-8">

    <script type="text/javascript">

        var counter = 0;

        function AddFileUpload() {

            var div = document.createElement('DIV');

            div.innerHTML = '<input id="file' + counter + '" name = "file' + counter +

                '" type="file" />' +

                '<input id="Button' + counter + '" type="button" ' +

                'value="Borrar foto" onclick = "RemoveFileUpload(this)" />';

            document.getElementById("FileUploadContainer").appendChild(div);

            counter++;

        }

        function RemoveFileUpload(div) {

            document.getElementById("FileUploadContainer").removeChild(div.parentNode);

        }

    </script>

    <div id="divDatos" runat="server">

        <asp:Label ID="lblDesc" runat="server" Text="Descripcion"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtDesc" runat="server" MaxLength="290"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblPrice" runat="server" Text="Precio"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblNH" runat="server" Text="No. de habitaciones"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtNumH" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblTel" runat="server" Text="Telefono"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtTel" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        Cocina incluida&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlCocina" runat="server">
            <asp:ListItem Text="Si" Value="1"></asp:ListItem>
            <asp:ListItem Text="No" Value="0"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />

    </div>



    <div runat="server" id="divDir">
        <asp:Label ID="lblCalle" runat="server" Text="Calle y numero"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCalle" runat="server" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblCol" runat="server" Text="Municipio"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtColDel" runat="server" />
        &nbsp;&nbsp;<br />
        <asp:Label ID="lblCp" runat="server" Text="Codigo postal"></asp:Label>
        &nbsp;&nbsp;&nbsp;        
        <asp:TextBox ID="txtCP" runat="server" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblEstado" runat="server" Text="Estado"></asp:Label>
        <asp:TextBox ID="txtEdo" runat="server" />
        <br>
        <asp:Label ID="lblPais" runat="server" Text="Pais"></asp:Label>
        <asp:DropDownList ID ="ddlPais" runat="server"></asp:DropDownList>
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
        <div id="map"></div>
        <script type="text/javascript">            

            var map;
            var mapcode;
            function initMap() {

                var lat0 = '<%= _lat%>';
                var lng0 = '<%= _lng%>';    
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






    <div id="div1" runat="server" enctype="multipart/form-data" method="post">

        <span style="font-family: Arial">Agregar foto</span>&nbsp;&nbsp;

    <input id="Button1" type="button" value="Agregar" onclick="AddFileUpload()" />

        <br />
        <br />

        <div id="FileUploadContainer">
        </div>

        <br />

        <asp:Button ID="btnUpload" runat="server"
            Text="Dar de alta" OnClick="btnUpload_Click" />


    </div>

</asp:Content>
