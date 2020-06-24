<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDash.aspx.cs" Inherits="ombtasp1.AdminDash" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Welcome</p>
            <asp:Button ID="btnVcs" runat="server" Text="View Customers" OnClick="btnVcs_Click" />
            <asp:Button ID="btnVbh" runat="server" Text="View Booking History" OnClick="btnVbh_Click" />
            <asp:Button ID="btnUm" runat="server" Text="Update Movies" OnClick="btnUm_Click" />
        </div>
    </form>
</body>
</html>
