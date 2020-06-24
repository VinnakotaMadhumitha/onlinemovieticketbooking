<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCustomers.aspx.cs" Inherits="ombtasp1.ViewCustomers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="Vc" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="Customer_id" DataSourceID="SqlDataSource1" GridLines="Vertical">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <Columns>
                    <asp:BoundField DataField="Customer_id" HeaderText="Customer_id" ReadOnly="True" SortExpression="Customer_id" />
                    <asp:BoundField DataField="Customer_name" HeaderText="Customer_name" SortExpression="Customer_name" />
                    <asp:BoundField DataField="Customer_pwd" HeaderText="Customer_pwd" SortExpression="Customer_pwd" />
                    <asp:BoundField DataField="Wallet_amt" HeaderText="Wallet_amt" SortExpression="Wallet_amt" />
                    <asp:BoundField DataField="Customer_phno" HeaderText="Customer_phno" SortExpression="Customer_phno" />
                    <asp:BoundField DataField="Customer_Address" HeaderText="Customer_Address" SortExpression="Customer_Address" />
                </Columns>
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ombt %>" SelectCommand="SELECT * FROM [Customer]"></asp:SqlDataSource>
            <asp:Button ID="Button1" runat="server" Text="Back" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
