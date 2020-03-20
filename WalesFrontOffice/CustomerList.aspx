<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="CustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 311px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstCustomerList" runat="server" Height="215px" Width="240px"></asp:ListBox>
        <div>
            <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        </div>
        <asp:TextBox ID="txtName" runat="server" Width="236px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Height="25px" Text="Apply" Width="73px" />
        <asp:Button ID="btnDisplayAll" runat="server" Text="Display All" />
        <p>
            &nbsp;</p>
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
    </form>
</body>
</html>
