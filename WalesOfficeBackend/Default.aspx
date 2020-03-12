<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstUsers" runat="server" style="z-index: 1; left: 51px; top: 80px; position: absolute; height: 212px; width: 375px; bottom: 372px"></asp:ListBox>
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 52px; top: 305px; position: absolute" Text="Please Enter the Users First Name here:"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 53px; top: 336px; position: absolute; width: 263px"></asp:TextBox>
        <p>
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 344px; top: 331px; position: absolute; width: 90px; height: 29px" Text="Apply" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 59px; top: 373px; position: absolute; width: 257px"></asp:Label>
        <asp:Button ID="btnDisplayAll" runat="server" OnClick="btnDisplayAll_Click" style="z-index: 1; left: 344px; top: 376px; position: absolute; width: 89px; height: 30px" Text="Display All" />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 56px; top: 409px; position: absolute; width: 72px; height: 29px" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 155px; top: 409px; position: absolute; width: 72px; height: 29px" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 254px; top: 409px; position: absolute; height: 29px; width: 72px" Text="Delete" />
    </form>
</body>
</html>
