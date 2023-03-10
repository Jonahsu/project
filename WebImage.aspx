<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebImage.aspx.cs" Inherits="Q2image.WebImage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlItems" runat="server" AutoPostBack="true" 
                OnSelectedIndexChanged="ddlItems_SelectedIndexChanged">
                <asp:ListItem Text="Select an item" Value="0" />
                <asp:ListItem Text="Item 1" Value="1" />
                <asp:ListItem Text="Item 2" Value="2" />
                <asp:ListItem Text="Item 3" Value="3" />
            </asp:DropDownList>
            <br />
            <br />
            <asp:Image ID="imgItem" runat="server" Height="150" Width="150" />
            <br />
            <br />
            <asp:Button ID="btnCost" runat="server" Text="Get Cost" OnClick="btnCost_Click" />
            <br />
            <br />
            <asp:Label ID="lbCost" runat="server" />
        </div>
    </form>
</body>
</html>
