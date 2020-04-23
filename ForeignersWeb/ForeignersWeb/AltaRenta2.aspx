<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="AltaRenta2.aspx.cs" Inherits="ForeignersWeb.AltaRenta2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <script type="text/javascript">

        var counter = 0;

        function AddFileUpload() {
            if (counter < 5) {
                var div = document.createElement('DIV');

                div.innerHTML = '<input id="file' + counter + '" name = "file' + counter +

                    '" type="file" />' +

                    '<input id="Button' + counter + '" type="button" ' +

                    'value="Remove" onclick = "RemoveFileUpload(this)" />';

                document.getElementById("FileUploadContainer").appendChild(div);

                counter++;
            } else {
                alert("No se pueden subir mas de 5 fotos")
            }


        }

        function RemoveFileUpload(div) {

            document.getElementById("FileUploadContainer").removeChild(div.parentNode);

        }

    </script>
    
    <div >
        <span style="font-family: Arial">Click to add files</span>&nbsp;&nbsp;

        <input id="Button1" type="button" value="add" onclick="AddFileUpload()" />

        <br />
        <br />

        <div id="FileUploadContainer">

            <!--FileUpload Controls will be added here -->

        </div>

        <br />

        <asp:Button ID="btnUpload" runat="server"
            Text="Upload" OnClick="btnUpload_Click" />
        <br />
    </div>
</asp:Content>
