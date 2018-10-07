<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="store.aspx.cs" Inherits="OnlineCMSWebsite.store" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Css/CssAll.css" />
    <style type="text/css">
        .auto-style1 {
            text-align: right;
        }
        .auto-style2 {
            text-align: right;
            width: 280px;
        }
        .auto-style3 {
            width: 280px;
        }
        .auto-style4 {
            text-align: left;
            width: 302px;
        }
    </style>
</head>
<body style="margin: 0px">
    <form id="form1" runat="server">
    <p style="background-color: #000066; margin: 0px; padding: 30px 0px 30px 0px; text-align: center; font-family: 'Agency FB';">
        <asp:Label ID="StoreNameLabel" runat="server" Font-Bold="True" Font-Size="30pt" ForeColor="Yellow" Text="Store Name"></asp:Label>
        </p>
        <table class="auto-style1">
                <tr>
                    <td class="auto-style4" style="color: #FFFFFF; font-size: 30px; font-family: 'Agency FB'; font-weight: bold; text-align: center; background-color: #FF9966;">
                        All Items</td>
                    <td rowspan="2">
                        <table class="auto-style1" style="font-size: 20px; font-weight: bold">
                            <tr>
                                <td class="auto-style2">Product Name&nbsp; :&nbsp;&nbsp;&nbsp; </td>
                                <td>
                                    <asp:TextBox ID="ProductNameTextBox" runat="server" Width="250px" OnTextChanged="ProductNameTextBox_TextChanged"></asp:TextBox>
                                </td>
                                <td style="text-align: left">
                        <asp:Label ID="productNameErrorMsg" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="Red" Text="* Please enter product name" Visible="False"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">Product Price :&nbsp;&nbsp;&nbsp; </td>
                                <td>
                                    <asp:TextBox ID="ProductPriceTextBox" runat="server" Width="250px" OnTextChanged="ProductPriceTextBox_TextChanged"></asp:TextBox>
                                </td>
                                <td style="text-align: left">
                        <asp:Label ID="productPriceErrorMsg" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="Red" Text="* Please enter product price" Visible="False"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">Icon :&nbsp;&nbsp;&nbsp; </td>
                                <td>
                                    <asp:FileUpload ID="ProductIconFileUpload" runat="server" Width="255px" />
                                </td>
                                <td style="text-align: left">
                                    <asp:Image ID="iconImage" runat="server" Height="65px" Width="78px" />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">
                                    Quantity :&nbsp;&nbsp;&nbsp;&nbsp; </td>
                                <td style="text-align: left">
                                    <asp:TextBox ID="QuantityTextBox" runat="server" Width="250px" OnTextChanged="QuantityTextBox_TextChanged"></asp:TextBox>
                                </td>
                                <td style="text-align: left">
                        <asp:Label ID="quantityErrorMsg" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="Red" Text="* Please enter quantity" Visible="False"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">
                                    &nbsp;</td>
                                <td style="text-align: left">
                                    <asp:Button ID="AddItemButton" runat="server" Font-Bold="True" Font-Size="16pt" Height="30px" style="text-align: center" Text="Add" Width="101px" OnClick="AddItemButton_Click" />
                                &nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Button ID="UpdateItemButton" runat="server" Font-Bold="True" Font-Size="16pt" Height="30px" style="text-align: center" Text="Update" Width="101px" OnClick="UpdateItemButton_Click" />
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style2">
                                    &nbsp;</td>
                                <td style="text-align: center">
                                    <asp:Button ID="DeleteButton" runat="server" Font-Bold="True" Font-Size="16pt" Height="31px" OnClick="DeleteButton_Click" Text="Delete" />
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style3">&nbsp;</td>
                                <td style="text-align: center">
                                    <asp:Label ID="ItemsizeLabel" runat="server" ForeColor="Red"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style3">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            
                        </table>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:ListBox ID="ListBox1" runat="server" BackColor="#660066" Font-Bold="True" Font-Size="Larger" ForeColor="White" Height="390px" Width="300px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" style="text-align: left" AutoPostBack="True">
                        </asp:ListBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="errorMsg" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="Red" Text="* Please select a item" Visible="False"></asp:Label>
                    </td>
                </tr>
        </table>
        
    <footer style="font-family: 'Agency FB';text-align:center; font-weight: bold; font-size: x-large; margin: 0px; padding: 30px 0px 30px 0px; background-color: #666699">@ 2016 OrderSystemCMS | All Rights&nbsp; Reserved |
        <asp:LinkButton ID="btnDashboard" runat="server" ForeColor="White" OnClick="btnDashboard_Click" CssClass="linkBtn">DashBoard</asp:LinkButton>
        </footer>
    
    </form>
        
    </body>
</html>
