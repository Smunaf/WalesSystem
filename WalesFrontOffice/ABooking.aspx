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
        <asp:TextBox ID="txtBookingNo" runat="server" style="z-index: 1; left: 138px; top: 32px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblBookingNo" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; width: 111px; right: 1197px" Text="Booking Number"></asp:Label>
        <asp:Label ID="lblCustomerNo" runat="server" style="z-index: 1; left: 13px; top: 77px; position: absolute; width: 121px" Text="Customer Number"></asp:Label>
        <asp:TextBox ID="txtCustomerNo" runat="server" style="z-index: 1; left: 136px; top: 75px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtTourNo" runat="server" style="z-index: 1; left: 137px; top: 127px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 23px; top: 204px; position: absolute" Text="OK" />
        <asp:Label ID="lblTourNo" runat="server" style="z-index: 1; left: 18px; top: 129px; position: absolute; width: 109px" Text="Tour Number"></asp:Label>
    </form>
</body>
</html>
