<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="storeadminpage.aspx.cs" Inherits="OnlineCMSWebsite.storeadminpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Css/CssAll.css" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        #Reset1 {
            height: 38px;
            width: 86px;
        }
        .auto-style2 {
            width: 475px;
        }
    </style>
</head>
<body style="padding: 0px; margin: 0px;">
    <form id="form1" runat="server">
    <p style="background-color: #000066; margin: 0px; padding: 30px 0px 30px 0px; text-align: center; font-family: 'Agency FB';">
        <asp:Label ID="StoreNameLabel" runat="server" Font-Bold="True" Font-Size="30pt" ForeColor="Yellow" Text="Store Name"></asp:Label>
        </p>
        <br />
        <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" ShowFooter="True" Visible="False">
            <Columns>
                <asp:BoundField DataField="SrlNo" HeaderText="Srl No" />
                <asp:BoundField DataField="DeliveryStatus" HeaderText="Delivery Status" />
                <asp:BoundField DataField="Date" HeaderText="Date" />
                <asp:BoundField DataField="CustomerName" HeaderText="Customer Name" />
                <asp:BoundField DataField="CreditCard" HeaderText="Credit Card Number" />
                <asp:BoundField DataField="Address" HeaderText="Address" />
                <asp:BoundField DataField="ProductName1" HeaderText="Product Name 01" />
                <asp:BoundField DataField="Quantity1" HeaderText="Quantity" />
                <asp:BoundField DataField="ProductName2" HeaderText="Product Name 02" />
                <asp:BoundField DataField="Quantity2" HeaderText="Quantity" />
                <asp:BoundField DataField="ProductName3" HeaderText="Product Name 03" />
                <asp:BoundField DataField="Quantity3" HeaderText="Quantity" />
                <asp:BoundField DataField="ProductName4" HeaderText="Product Name 04" />
                <asp:BoundField DataField="Quantity4" HeaderText="Quantity" />
                <asp:BoundField DataField="ProductName5" HeaderText="Product Name 05" />
                <asp:BoundField DataField="Quantity5" HeaderText="Quantity" />
                <asp:BoundField DataField="ProductName6" HeaderText="Product Name 06" />
                <asp:BoundField DataField="Quantity6" HeaderText="Quantity" />
                <asp:BoundField DataField="ProductName7" HeaderText="Product Name 07" />
                <asp:BoundField DataField="Quantity7" HeaderText="Quantity" />
                <asp:BoundField DataField="ProductName8" HeaderText="Product Name 08" />
                <asp:BoundField DataField="Quantity8" HeaderText="Quantity" />
                <asp:BoundField DataField="ProductName9" HeaderText="Product Name 09" />
                <asp:BoundField DataField="Quantity9" HeaderText="Quantity" />
                <asp:BoundField DataField="ProductName10" HeaderText="Product Name 10" />
                <asp:BoundField DataField="Quantity10" HeaderText="Quantity" />
                <asp:BoundField DataField="ProductName11" HeaderText="Product Name 11" />
                <asp:BoundField DataField="Quantity11" HeaderText="Quantity" />
                <asp:BoundField DataField="ProductName12" HeaderText="Product Name 12" />
                <asp:BoundField DataField="Quantity12" HeaderText="Quantity" />
                <asp:BoundField DataField="ProductName13" HeaderText="Product Name 13" />
                <asp:BoundField DataField="Quantity13" HeaderText="Quantity" />
                <asp:BoundField DataField="ProductName14" HeaderText="Product Name 14" />
                <asp:BoundField DataField="Quantity14" HeaderText="Quantity" />
                <asp:BoundField DataField="ProductName15" HeaderText="Product Name 15" />
                <asp:BoundField DataField="Quantity15" HeaderText="Quantity" />
                <asp:BoundField DataField="TotalTaka" HeaderText="Total Taka" />
            </Columns>
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
    
    </div>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" Visible="False">
            <Columns>
                <asp:BoundField DataField="SrlNo" HeaderText="SrlNo" />
                <asp:BoundField DataField="DeliveryStatus" HeaderText="Delivery Status" />
                <asp:BoundField DataField="Date" HeaderText="Date" />
                <asp:BoundField DataField="CustomerName" HeaderText="Customer Name" />
                <asp:BoundField DataField="CreditCard" HeaderText="Credit Card Number" />
                <asp:BoundField DataField="Address" HeaderText="Address" />
                <asp:BoundField DataField="ProductName1" HeaderText="Product Name 01" />
                <asp:BoundField DataField="Quantity1" HeaderText="Quantity" />
                <asp:BoundField DataField="ProductName2" HeaderText="Product Name 02" />
                <asp:BoundField DataField="Quantity2" HeaderText="Quantity" />
                <asp:BoundField DataField="ProductName3" HeaderText="Product Name 03" />
                <asp:BoundField DataField="Quantity3" HeaderText="Quantity" />
                <asp:BoundField DataField="ProductName4" HeaderText="Product Name 04" />
                <asp:BoundField DataField="Quantity4" HeaderText="Quantity" />
                <asp:BoundField DataField="ProductName5" HeaderText="Product Name 05" />
                <asp:BoundField DataField="Quantity5" HeaderText="Quantity" />
                <asp:BoundField DataField="ProductName6" HeaderText="Product Name 06" />
                <asp:BoundField DataField="Quantity6" HeaderText="Quantity" />
                <asp:BoundField DataField="ProductName7" HeaderText="Product Name 07" />
                <asp:BoundField DataField="Quantity7" HeaderText="Quantity" />
                <asp:BoundField DataField="ProductName8" HeaderText="Product Name 08" />
                <asp:BoundField DataField="Quantity8" HeaderText="Quantity" />
                <asp:BoundField DataField="ProductName9" HeaderText="Product Name 09" />
                <asp:BoundField DataField="Quantity9" HeaderText="Quantity" />
                <asp:BoundField DataField="ProductName10" HeaderText="Product Name 10" />
                <asp:BoundField DataField="Quantity10" HeaderText="Quantity" />
                <asp:BoundField DataField="TotalTaka" HeaderText="Total Taka" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#333333" />
            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#487575" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#275353" />
        </asp:GridView>
        <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Visible="False">
            <Columns>
                <asp:BoundField DataField="SrlNo" HeaderText="SrlNo" />
                <asp:BoundField DataField="DeliveryStatus" HeaderText="Delivery Status" />
                <asp:BoundField DataField="Date" HeaderText="Date" />
                <asp:BoundField DataField="CustomerName" HeaderText="Customer Name" />
                <asp:BoundField DataField="CreditCard" HeaderText="Credit Card Number" />
                <asp:BoundField DataField="Address" HeaderText="Address" />
                <asp:BoundField DataField="ProductName1" HeaderText="Product Name 01" />
                <asp:BoundField DataField="Quantity1" HeaderText="Quantity" />
                <asp:BoundField DataField="ProductName2" HeaderText="Product Name 02" />
                <asp:BoundField DataField="Quantity2" HeaderText="Quantity" />
                <asp:BoundField DataField="ProductName3" HeaderText="Product Name 03" />
                <asp:BoundField DataField="Quantity3" HeaderText="Quantity" />
                <asp:BoundField DataField="ProductName4" HeaderText="Product Name 04" />
                <asp:BoundField DataField="Quantity4" HeaderText="Quantity" />
                <asp:BoundField DataField="ProductName5" HeaderText="Product Name 05" />
                <asp:BoundField DataField="Quantity5" HeaderText="Quantity" />
                <asp:BoundField DataField="TotalTaka" HeaderText="Total Taka" />
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" style="text-align: right; font-size: large; font-weight: bold;">SrlNo :&nbsp;&nbsp;&nbsp; </td>
                <td style="text-align: left">
                    <asp:TextBox ID="SrlNoTextBox" runat="server" Width="206px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td style="text-align: left">
                    <asp:Button ID="DoneButton" runat="server" Height="37px" Text="Done" Width="90px" OnClick="DoneButton_Click" Font-Bold="True" Font-Size="16pt" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <input id="Reset1" type="reset" value="reset" style="font-size: 16px" /></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <footer style="font-family: 'Agency FB';text-align:center; font-weight: bold; font-size: x-large; margin: 0px; padding: 30px 0px 30px 0px; background-color: #666699">@ 2016 OrderSystemCMS | All Rights&nbsp; Reserved |
            <asp:LinkButton ID="btnDashboard" runat="server" ForeColor="White" OnClick="btnDashboard_Click" CssClass="linkBtn">DashBoard</asp:LinkButton>
        </footer>
    </form>
</body>
</html>
