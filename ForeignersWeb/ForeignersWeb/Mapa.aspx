<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="Mapa.aspx.cs" Inherits="ForeignersWeb.Mapa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        /* Set the size of the div element that contains the map */
        #map {
            height: 400px; /* The height is 400 pixels */
            width: 100%; /* The width is the width of the web page */
        }
    </style>
    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
    <script async defer src="https://maps.googleapis.com/maps/api/js?key=AIzaSyASt_r2bn3WZMmgBVVQLluzFdstRqaMZzc&callback=initMap"></script>    
    <!--The div element for the map -->
    <div id="map"></div>
    <script type="text/javascript">
        function initMap() {
            var mapOptions = {
                center: new google.maps.LatLng(19.345442, -99.200090),
                zoom: 10,
                mapTypeId: google.maps.MapTypeId.ROADMAP
            };
            
            var markers = <%= _markers %>;
            var infoWindow = new google.maps.InfoWindow();
            var map = new google.maps.Map(document.getElementById("dvMap"), mapOptions);
            for (i = 0; i < markers.length; i++) {
                var data = markers[i]
                var myLatlng = new google.maps.LatLng(data.lat, data.lng);
                var marker = new google.maps.Marker({
                    position: myLatlng,
                    map: map,
                    title: data.title,
                    tel: data.tel,
                    description: data.description
                });
                (function (marker, data) {
                    google.maps.event.addListener(marker, "click", function (e) {
                        infoWindow.setContent(data.title + "\nDescripcion: " + data.description + "\n");
                        infoWindow.open(map, marker);
                    });
                })(marker, data);
            }

        }
    </script>
    <div id="dvMap" class="card" style="width: 100%; height: 400px">
    </div>
</asp:Content>
