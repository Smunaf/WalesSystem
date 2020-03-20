<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblDelete" runat="server" Text="Are you sure you want to delete this customer"></asp:Label>
        </div>
        <asp:Button ID="btnYes" runat="server" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" Text="No" Width="48px" OnClick="btnNo_Click" />
    </form>
</body>
</html>
