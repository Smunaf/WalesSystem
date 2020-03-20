<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ABooking.aspx.cs" Inherits="ABooking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerNo" runat="server" style="z-index: 1; left: 13px; top: 77px; position: absolute; width: 121px" Text="Customer Number"></asp:Label>
        <asp:TextBox ID="txtCustomerNo" runat="server" style="z-index: 1; left: 136px; top: 75px; position: absolute; width: 229px;"></asp:TextBox>
        <asp:TextBox ID="txtTourNo" runat="server" style="z-index: 1; left: 137px; top: 127px; position: absolute; width: 227px;"></asp:TextBox>
        <asp:Label ID="lblTourNo" runat="server" style="z-index: 1; left: 18px; top: 129px; position: absolute; width: 109px" Text="Tour Number"></asp:Label>
        <p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 148px; top: 314px; position: absolute; height: 26px; width: 59px;" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 266px; top: 313px; position: absolute" Text="Cancel" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 83px; top: 269px; position: absolute; width: 265px"></asp:Label>
            <asp:TextBox ID="txtDateandTime" runat="server" style="z-index: 1; left: 137px; top: 220px; position: absolute; width: 225px"></asp:TextBox>
            <asp:Label ID="lblDateandTime" runat="server" style="z-index: 1; left: 20px; top: 220px; position: absolute; width: 104px" Text="Date And Time"></asp:Label>
            <asp:Label ID="lblPassengerCount" runat="server" style="z-index: 1; left: 19px; top: 172px; position: absolute" Text="Passenger Count"></asp:Label>
            <asp:TextBox ID="txtPassengerCount" runat="server" style="z-index: 1; left: 137px; top: 173px; position: absolute; width: 227px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
