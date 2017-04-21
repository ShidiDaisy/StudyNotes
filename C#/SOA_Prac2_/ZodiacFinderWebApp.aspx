<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ZodiacFinderWebApp.aspx.cs" Inherits="INFS3204_Prac2.ZodiacFinderWebApp" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server"><title></title></head>
    <body><form id="form1" runat="server">
    <div>
    
        <asp:Label ID="headerLabel" runat="server" Text="Task 1 &amp; 2: Zodiac Finder"></asp:Label>
   
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Find Date by Name:"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Name:"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="getDateButton" runat="server" Text="GetDate" OnClick="getDateButton_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Date: "></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="dateTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Find Name by Date"></asp:Label>

    
        <br />
        <asp:Label ID="Label5" runat="server" Text="Mon: "></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="monTextBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label6" runat="server" Text="Day:"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="dayTextBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="getNameButton" runat="server" Text="GetName" OnClick="getNameButton_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label7" runat="server" Text="Name:"></asp:Label>
&nbsp;
        <asp:TextBox ID="nameOutputTextBox" runat="server"></asp:TextBox>

    
    </div>
    </form>
</body>
</html>
