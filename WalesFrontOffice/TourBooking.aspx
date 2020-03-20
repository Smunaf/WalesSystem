<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TourBooking.aspx.cs" Inherits="TourBooking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 29px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTourName" runat="server" style="z-index: 1; left: 239px; top: 66px; position: absolute; width: 112px; bottom: 592px;" Text="Tour Name"></asp:Label>
        </div>
        <asp:Label ID="lblLocation" runat="server" style="z-index: 1; left: 241px; top: 136px; position: absolute" Text="Location"></asp:Label>
        <asp:Label ID="lblTime" runat="server" style="z-index: 1; left: 242px; top: 203px; position: absolute" Text="Time"></asp:Label>
        <asp:Label ID="lblCapacity" runat="server" style="z-index: 1; left: 240px; top: 268px; position: absolute" Text="Capacity"></asp:Label>
        <asp:TextBox ID="txtTourName" runat="server" style="z-index: 1; left: 238px; top: 98px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtLocation" runat="server" style="z-index: 1; left: 238px; top: 170px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtTime" runat="server" style="z-index: 1; left: 240px; top: 237px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCapacity" runat="server" style="z-index: 1; left: 239px; top: 301px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 241px; top: 371px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 241px; top: 341px; position: absolute" Text="Price"></asp:Label>
        <asp:Button ID="btnBack" runat="server" style="z-index: 1; left: 275px; top: 516px; position: absolute" Text="Back" />
        <p>
            &nbsp;</p>
        <p>
        <asp:Button ID="btnCustDetails" runat="server" OnClick="btnCustDetails_Click" style="z-index: 1; left: 239px; top: 471px; position: absolute; width: 111px;" Text="Next" />
        </p>
        <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 239px; top: 430px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
