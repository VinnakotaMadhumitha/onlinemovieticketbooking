<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="ombtasp1.AdminLogin" %>

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
                    <td>
                        PhoneNumber
                    </td>
                    <td>
               <asp:TextBox ID="TxtPhno" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td>
                        Password
                    </td>
                    <td>
               <asp:TextBox ID="TxtPwd" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td rowspan ="1">
                        <asp:Button ID="btnLogin" runat="server" Text="Login" ForeColor="#006600" OnClick="btnSubmit_Click" />
                    </td>
                    <td>
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" ForeColor="#CC0000" OnClick="btnCancel_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
