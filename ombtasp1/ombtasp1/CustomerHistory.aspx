<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerHistory.aspx.cs" Inherits="ombtasp1.CustomerHistory" %>

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
                        CustomerId
                    </td>
                    <td>
               <asp:TextBox ID="TxtId" runat="server"></asp:TextBox>
                    </td>
                    </tr>
                   <tr>
                    <td rowspan ="1">
                        <asp:Button ID="btnLogin" runat="server" Text="ClickHere" ForeColor="#006600" OnClick="btnSubmit_Click" />
                    </td>
                    <td>
                        <asp:Button ID="btnCancel" runat="server" Text="Back" ForeColor="#CC0000" OnClick="btnCancel_Click" />
                    </td>
                </tr>
                </table>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
