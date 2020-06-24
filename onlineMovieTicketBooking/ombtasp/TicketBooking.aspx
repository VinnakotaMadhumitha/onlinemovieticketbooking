<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TicketBooking.aspx.cs" Inherits="ombtasp.TicketBooking" %>

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
                        MovieId
                    </td>
                    <td>
               <asp:TextBox ID="TxtMId" runat="server"></asp:TextBox>
                    </td>
                </tr>
                   <tr>
                    <td>
                        MovieName
                    </td>
                    <td>
               <asp:TextBox ID="TxtMName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td>
                        Number of Tickets
                    </td>
                    <td>
               <asp:TextBox ID="TxtNOT" runat="server"></asp:TextBox>
                    </td>
                </tr>
                  <tr>
                    <td>
                        Amount
                    </td>
                    <td>
               <asp:TextBox ID="TxtAmt" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td>
                        Seat Number
                    </td>
                    <td>
               <asp:TextBox ID="TxtSn" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td rowspan ="1">
                        <asp:Button ID="btnBook" runat="server" Text="Book" ForeColor="#006600" OnClick="btnSubmit_Click" OnClientClick ="Validate()" />
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
