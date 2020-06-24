<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ombtasp1.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                     <asp:Button ID="btnLoginA" runat="server" Text="AdminLogin" ForeColor="#CC0000" OnClick="btnCancel_Click" />
                </tr>
                  <tr>
                     <asp:Button ID="btnLoginC" runat="server" Text="CustomerLogin" ForeColor="#CC0000" OnClick="btnCancel_Click" />
                </tr>
                  <tr>
                     <asp:Button ID="SignupA" runat="server" Text="AdminSignUp" ForeColor="#006600" OnClick="btnCancel_Click" />
                </tr>
                  <tr>
                     <asp:Button ID="SignupC" runat="server" Text="CustomerSignUp" ForeColor="#006600" OnClick="btnCancel_Click" />
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
