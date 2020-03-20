<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffBooking.aspx.cs" Inherits="StaffBooking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 577px; top: 343px; position: absolute" Text="Make New Booking" />
        </div>
        <asp:Button ID="btnDisplay" runat="server" OnClick="btnDisplay_Click" style="z-index: 1; left: 358px; top: 343px; position: absolute; right: 540px;" Text="Display Bookings" />
        <asp:ListBox ID="lstDisplay" runat="server" style="z-index: 1; left: 125px; top: 53px; position: absolute; height: 252px; width: 623px"></asp:ListBox>
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 130px; top: 343px; position: absolute" Text="Cancel Booking" />
    </form>
</body>
</html>
