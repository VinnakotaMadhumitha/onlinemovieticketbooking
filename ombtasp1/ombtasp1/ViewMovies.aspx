<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewMovies.aspx.cs" Inherits="ombtasp1.ViewMovies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="VM" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" AutoGenerateColumns="False" DataKeyNames="Movie_id" DataSourceID="SqlDataSource1">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <Columns>
                    <asp:BoundField DataField="Movie_id" HeaderText="Movie_id" ReadOnly="True" SortExpression="Movie_id" />
                    <asp:BoundField DataField="Movie_Name" HeaderText="Movie_Name" SortExpression="Movie_Name" />
                    <asp:BoundField DataField="showTimings" HeaderText="showTimings" SortExpression="showTimings" />
                    <asp:BoundField DataField="MLocation" HeaderText="MLocation" SortExpression="MLocation" />
                    <asp:BoundField DataField="MLanguage" HeaderText="MLanguage" SortExpression="MLanguage" />
                    <asp:BoundField DataField="Screeno" HeaderText="Screeno" SortExpression="Screeno" />
                    <asp:BoundField DataField="AvailableTickets" HeaderText="AvailableTickets" SortExpression="AvailableTickets" />
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
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ombt %>" SelectCommand="SELECT * FROM [Movie]"></asp:SqlDataSource>
            <asp:Button ID="Button1" runat="server" Text="Back" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
