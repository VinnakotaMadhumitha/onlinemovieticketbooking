<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignupCustomer.aspx.cs" Inherits="ombtasp1.SignupCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        // phonenumber validation
        function Validate() {
            var msg = "";
            msg += MobileNumberValidation();
            if (msg != "") {
                alert(msg);
                return false;
            } 
            else {
                alert("Please Login to Continue");
                return true;
            }
        }
        function MobileNumberValidation() {
            var id;
            var controlId = document.getElementById("<%=TxtPhno.ClientID %>");
            id = controlId.value;
            var val;
            val = /^[1-9]{1}[0-9]{9}$/;
            if (id == "") {
                return ("Please Enter Mobile Number" + "\n");
            }
            else if (val.test(id)) {
                return "";
            }
            else {
                return ("Mobile Number should be Valid" + "\n");
            }
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <p>Welcome to Online Movie Ticket Booking</p>
        <div>
            <table>
                <tr>
                    <td>
                        Name
                    </td>
                    <td>
               <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
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
                    <td>
                        Amount
                    </td>
                    <td>
               <asp:TextBox ID="Txtamt" runat="server"></asp:TextBox>
                    </td>
                </tr>
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
                        Address
                    </td>
                    <td>
               <asp:TextBox ID="TxtAdd" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td rowspan ="1">
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" ForeColor="#006600" OnClick="btnSubmit_Click" OnClientClick ="Validate()" />
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
