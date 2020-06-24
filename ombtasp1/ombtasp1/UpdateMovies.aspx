<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateMovies.aspx.cs" Inherits="ombtasp1.UpdateMovies" %>

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
                        MovieName
                    </td>
                    <td>
               <asp:TextBox ID="TxtMName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td>
                        ShowTimings
                        </td>
                     <td>
                   <asp:TextBox ID="TxtShowTime" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td>
                        Location
                    </td>
                    <td>
               <asp:TextBox ID="TxtLocation" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td>
                        Language
                    </td>
                    <td>
               <asp:TextBox ID="TxtLanguage" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td>
                        ScreenNo
                    </td>
                    <td>
               <asp:TextBox ID="TxtScreenNo" runat="server"></asp:TextBox>
                    </td>
                </tr>
                  <tr>
                    <td>
                        AvailableTicket
                    </td>
                    <td>
               <asp:TextBox ID="TxtAvailableTkt" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                      <td rowspan ="1">
                        <asp:Button ID="btnBook" runat="server" Text="Update" ForeColor="#006600" OnClick="btnSubmit_Click" OnClientClick ="Validate()" />
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
