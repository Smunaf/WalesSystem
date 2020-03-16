<%@ Page Language="C#" AutoEventWireup="true" CodeFile="User.aspx.cs" Inherits="User" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 21px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblTourName" runat="server" style="z-index: 1; left: 56px; top: 75px; position: absolute; width: 88px; bottom: 570px;" Text="Tour Name:"></asp:Label>
        <asp:Label ID="lblLocation" runat="server" style="z-index: 1; left: 56px; top: 122px; position: absolute" Text="Location:"></asp:Label>
        <asp:Label ID="lblDate" runat="server" style="z-index: 1; left: 57px; top: 165px; position: absolute" Text="Date:"></asp:Label>
        <asp:Label ID="lblDeparture" runat="server" style="z-index: 1; left: 55px; top: 206px; position: absolute; height: 30px; width: 89px;" Text="Departure Time:"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 42px; top: 274px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtTourName" runat="server" style="z-index: 1; left: 162px; top: 75px; position: absolute; width: 142px"></asp:TextBox>
        <asp:TextBox ID="txtLocation" runat="server" style="z-index: 1; left: 161px; top: 121px; position: absolute; width: 142px"></asp:TextBox>
        <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 161px; top: 165px; position: absolute; width: 143px"></asp:TextBox>
        <asp:TextBox ID="txtDeparture" runat="server" style="z-index: 1; left: 161px; top: 209px; position: absolute; width: 141px"></asp:TextBox>
        <asp:Label ID="lblCapacity" runat="server" style="z-index: 1; left: 387px; top: 76px; position: absolute" Text="Capacity:"></asp:Label>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 388px; top: 122px; position: absolute" Text="Price:"></asp:Label>
        <asp:TextBox ID="txtCapacity" runat="server" style="z-index: 1; left: 528px; top: 77px; position: absolute; width: 177px" OnTextChanged="txtCapacity_TextChanged"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 527px; top: 119px; position: absolute; width: 141px"></asp:TextBox>
        <asp:Button ID="btnConfirm" runat="server" OnClick="btnConfirm_Click" style="z-index: 1; left: 383px; top: 268px; position: absolute; height: 29px; width: 65px; margin-bottom: 0px" Text="Confirm" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 463px; top: 268px; position: absolute; height: 29px; width: 64px" Text="Cancel" />
        <p>
            &nbsp;</p>
        <p>
        <asp:CheckBox ID="chkTourGuide" runat="server" style="z-index: 1; left: 387px; top: 162px; position: absolute; margin-bottom: 0px; width: 187px;" Text="Tour Guide Included?" />
        </p>
        <p>
            
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
