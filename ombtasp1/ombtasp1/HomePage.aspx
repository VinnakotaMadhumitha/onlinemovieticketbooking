<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="ombtasp1.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p> "Welcome to online Movie Ticket Booking"</p>
            <asp:Button ID="btnSc" runat="server" Text="SignUp Customer" OnClick="btnSc_Click" />
            <asp:Button ID="btnSa" runat="server" Text="SignUp Admin" OnClick="btnSa_Click" />
            <asp:Button ID="btnLc" runat="server" Text="Login Customer" OnClick="btnLc_Click" />
            <asp:Button ID="btnLa" runat="server" Text="Login Admin" OnClick="btnLa_Click" />
        </div>
    </form>
</body>
</html>
