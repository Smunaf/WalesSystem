<%@ Page Language="C#" AutoEventWireup="true" CodeFile="User.aspx.cs" Inherits="User" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:LIGHTSKYBLUE;">
    <form id="form1" style="background-color:LIGHTSKYBLUE;" runat="server">
        <div>
        </div>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 56px; top: 75px; position: absolute; width: 88px" Text="First Name:"></asp:Label>
        <asp:Label ID="lblSecondName" runat="server" style="z-index: 1; left: 56px; top: 122px; position: absolute" Text="Second Name:"></asp:Label>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 57px; top: 165px; position: absolute" Text="Address:"></asp:Label>
        <asp:Label ID="lblDOB" runat="server" style="z-index: 1; left: 60px; top: 211px; position: absolute" Text="Date of Birth:"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 42px; top: 274px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="background-color: LIGHTSTEELBLUE;z-index: 1; left: 162px; top: 75px; position: absolute; width: 142px"></asp:TextBox>
        <asp:TextBox ID="txtSecondName" runat="server" style="background-color: LIGHTSTEELBLUE;z-index: 1; left: 161px; top: 121px; position: absolute; width: 142px"></asp:TextBox>
        <asp:TextBox ID="txtAddress" runat="server" style="background-color: LIGHTSTEELBLUE;z-index: 1; left: 161px; top: 165px; position: absolute; width: 143px"></asp:TextBox>
        <asp:TextBox ID="txtDOB" runat="server" style="background-color: LIGHTSTEELBLUE;z-index: 1; left: 161px; top: 209px; position: absolute; width: 141px"></asp:TextBox>
        <asp:Label ID="lblTelephoneNumber" runat="server" style="z-index: 1; left: 387px; top: 76px; position: absolute" Text="Telephone Number:"></asp:Label>
        <asp:DropDownList ID="ddlRole" runat="server" style="background-color: LIGHTSTEELBLUE;z-index: 1; left: 530px; top: 120px; position: absolute; height: 21px; width: 112px">
        </asp:DropDownList>
        <asp:Label ID="lblRole" runat="server" style="z-index: 1; left: 388px; top: 122px; position: absolute" Text="Role:"></asp:Label>
        <asp:TextBox ID="txtTelephoneNumber" runat="server" style="background-color: LIGHTSTEELBLUE;z-index: 1; left: 528px; top: 77px; position: absolute; width: 177px"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 386px; top: 167px; position: absolute" Text="Email:"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="background-color: LIGHTSTEELBLUE;z-index: 1; left: 528px; top: 165px; position: absolute; width: 175px"></asp:TextBox>
        <asp:CheckBox ID="chkAdminPrivileges" runat="server" style="z-index: 1; left: 379px; top: 211px; position: absolute; margin-bottom: 0px" Text="Admin Privileges" />
        <asp:Button ID="btnConfirm" runat="server" OnClick="btnConfirm_Click" style="z-index: 1; left: 383px; top: 268px; position: absolute; height: 29px; width: 65px; margin-bottom: 0px" Text="Confirm" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 463px; top: 268px; position: absolute; height: 29px; width: 64px" Text="Cancel" />
    </form>
</body>
</html>
