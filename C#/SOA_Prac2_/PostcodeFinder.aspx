<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostcodeFinder.aspx.cs" Inherits="INFS3204_Prac2.PostcodeFinder1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function GetPostCode() {
            var suburb = document.getElementById("suburbDropDownList").value;
            INFS3204_Prac2.PostcodeFinder.findPostcode(suburb, GetPostCodeSuccessCallback);
        }

        function GetPostCodeSuccessCallback(result) {
            var postcode = document.getElementById("postcodeLabel");
            postcode.innerHTML = result;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="~/PostcodeFinder.asmx" />
            </Services>
        </asp:ScriptManager>
    <div>
        Task 3: Postcode Finder<br />
        <br />
&nbsp;<asp:DropDownList ID="suburbDropDownList" runat="server">
            <asp:ListItem>Brisbane</asp:ListItem>
            <asp:ListItem>New Farm</asp:ListItem>
            <asp:ListItem>Bowen Hills</asp:ListItem>
            <asp:ListItem>Hamilton</asp:ListItem>
            <asp:ListItem>Eagle Farm</asp:ListItem>
            <asp:ListItem>Albion Bc</asp:ListItem>
            <asp:ListItem>Clayfield</asp:ListItem>
            <asp:ListItem>Lutwyche</asp:ListItem>
            <asp:ListItem>Alderley</asp:ListItem>
            <asp:ListItem>Kelvin Grove</asp:ListItem>
            <asp:ListItem>Ashgrove</asp:ListItem>
            <asp:ListItem>Milton</asp:ListItem>
            <asp:ListItem>Bardon</asp:ListItem>
            <asp:ListItem Selected="True">St Lucia</asp:ListItem>
            <asp:ListItem>Uni of Queensland</asp:ListItem>
            <asp:ListItem>Highgate Hill</asp:ListItem>
            <asp:ListItem>Dutton Park</asp:ListItem>
            <asp:ListItem>East Brisbane</asp:ListItem>
            <asp:ListItem>Cannon Hill</asp:ListItem>
            <asp:ListItem>Balmoral</asp:ListItem>
            <asp:ListItem>Murarrie</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
        <input id="showPostcodeButton" type="button" value="ShowPostCode" onclick="GetPostCode()" /><br />
        <asp:Label ID="postcodeLabel" runat="server"></asp:Label>
        <br />
        <asp:Label ID="timeLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
