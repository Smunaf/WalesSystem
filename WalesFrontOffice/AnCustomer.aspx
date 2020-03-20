<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnCustomer.aspx.cs" Inherits="AnCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 621px">
    <form id="form1" runat="server">
        <div style="height: 53px">
            Sign Up</div>
        <p>
            <asp:Label ID="lblFirstName" runat="server" Text="FirstName"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblSecondName" runat="server" Text="SureName"></asp:Label>
        <asp:TextBox ID="txtSureName" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Address"></asp:Label>
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="D.O.B"></asp:Label>
            <asp:TextBox ID="txtdob" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Telephone"></asp:Label>
            <asp:TextBox ID="txtTelephone" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        </p>
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnOK_Click" Text="Submit" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
    </form>
</body>
</html>
