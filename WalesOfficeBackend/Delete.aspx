<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDeleteConfirm" runat="server" style="z-index: 1; left: 95px; top: 113px; position: absolute; width: 332px" Text="Are you sure you want to remove this User?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 120px; top: 151px; position: absolute; width: 90px; height: 26px" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 236px; top: 151px; position: absolute; width: 90px; height: 26px" Text="No" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 101px; top: 196px; position: absolute; width: 188px"></asp:Label>
    </form>
</body>
</html>
