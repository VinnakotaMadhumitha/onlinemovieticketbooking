<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerDash.aspx.cs" Inherits="ombtasp1.CustomerDash" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Welcome </p>
            <asp:Button ID="btnVm" runat="server" Text="View Movies" OnClick="btnVm_Click" />
            <asp:Button ID="btnBt" runat="server" Text="Book Ticket" OnClick="btnBt_Click" />
            <asp:Button ID="btnVh" runat="server" Text="View Booking History" OnClick="btnVh_Click" />
            <asp:Button ID="btnVd" runat="server" Text="View Details" OnClick="btnVd_Click" />

        </div>
    </form>
</body>
</html>
