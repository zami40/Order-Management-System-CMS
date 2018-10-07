<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createOwners.aspx.cs" Inherits="OnlineCMSWebsite.createOwners" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Css/CssAll.css" />
    <style type="text/css">
        .auto-style1 {
            text-align: left;
        }
        .auto-style2 {
            text-align: right;
            width: 274px;
        }
        .auto-style3 {
            width: 274px;
        }
        .auto-style6 {
            text-align: center;
        }
        #Reset1 {
            height: 35px;
            width: 100px;
        }
        .auto-style7 {
            width: 298px;
        }
    </style>
</head>
<body style="margin: 0px">
    <form id="form1" runat="server">
    <p style="font-size: 50px; font-weight: bold; font-family: 'Agency FB'; color: #FFFF00; background-color: #000066; margin: 0px; padding: 30px 0px 30px 0px; text-align: center;">Order<span style="color: #00FF00">System</span><span style="color: #993399; font-family: 'Agency FB'; font-size: 50px; font-weight: bold">CMS</span></p>
   
                <table class="auto-style1">
                <tr>
                    <td class="auto-style7" style="color: #FFFFFF; font-size: 30px; font-family: 'Agency FB'; font-weight: bold; text-align: center; background-color: #FF9966;">
                        Storage Owners</td>
                    <td rowspan="2">
                        <table class="auto-style1" style="font-size: 20px; font-weight: bold">
                            <tr>
                                <td class="auto-style2">Owner Name :&nbsp;&nbsp;&nbsp; </td>
                                <td>
                                    <asp:TextBox ID="OwnerNameTextBox" runat="server" Width="250px" OnTextChanged="OwnerNameTextBox_TextChanged"></asp:TextBox>
                                </td>
                                <td style="text-align: left">
                        <asp:Label ID="ownerNameErrorMsg" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="Red" Text="* Please enter owner name" Visible="False"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">Address :&nbsp;&nbsp;&nbsp; </td>
                                <td>
                                    <asp:TextBox ID="AddressTextBox" runat="server" Width="250px" OnTextChanged="AddressTextBox_TextChanged"></asp:TextBox>
                                </td>
                                <td style="text-align: left">
                        <asp:Label ID="addressErrorMsg" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="Red" Text="* Please enter address" Visible="False"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">
                                    <asp:Label ID="UserIdLabel" runat="server" Text="User Id :&nbsp;&nbsp;&nbsp; "></asp:Label>
                                </td>
                                <td class="auto-style1">
                                    <asp:TextBox ID="UserIdTextBox" runat="server" Width="250px" OnTextChanged="UserIdTextBox_TextChanged"></asp:TextBox>
                                </td>
                                <td class="auto-style1">
                        <asp:Label ID="userIdErrorMsg" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="Red" Text="* Please enter user id" Visible="False"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">
                                    <asp:Label ID="PasswordLabel" runat="server" Text="Password :&nbsp;&nbsp;&nbsp; "></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="PasswordTextBox" runat="server" Width="250px" OnTextChanged="PasswordTextBox_TextChanged"></asp:TextBox>
                                </td>
                                <td>
                        <asp:Label ID="passwordErrorMsg" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="Red" Text="* Please enter password" Visible="False"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style3">
                                    &nbsp;</td>
                                <td class="auto-style6">
                                    <asp:Button ID="AddButton" runat="server" Font-Bold="True" Font-Size="14pt" Text="Add" Width="100px" OnClick="AddButton_Click" Height="35px" Font-Overline="False" Font-Underline="False" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Button ID="UpdateButton" runat="server" Font-Bold="True" Font-Size="13pt" Text="Update" Width="100px" OnClick="UpdateButton_Click" Height="35px" />
                                </td>
                                <td class="auto-style6"></td>
                            </tr>
                            <tr>
                                <td class="auto-style2">
                                    &nbsp;</td>
                                <td style="text-align: center">
                                    <asp:Button ID="DeleteButton" runat="server" OnClick="DeleteButton_Click" Text="Delete" Font-Bold="True" Font-Size="14pt" Height="35px" Width="100px" />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Button ID="btnReset" runat="server" Font-Bold="True" Font-Size="14pt" Height="35px" OnClick="btnReset_Click" Text="Reset" Width="100px" />
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style3">&nbsp;</td>
                                <td>
&nbsp;&nbsp;&nbsp;&nbsp;
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
                    <td class="auto-style7">
                        <asp:ListBox ID="ListBox1" runat="server" BackColor="#660066" Font-Bold="True" Font-Size="Larger" ForeColor="White" Height="353px" Width="300px" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" DataSourceID="SqlDataSourceOwnersName" DataTextField="OwnerName" DataValueField="OwnerName">
                        </asp:ListBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="errorMsg" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="Red" Text="* Please select a item" Visible="False"></asp:Label>
                        <asp:SqlDataSource ID="SqlDataSourceOwnersName" runat="server" ConnectionString="<%$ ConnectionStrings:CMSConnectionString %>" SelectCommand="SELECT [OwnerName] FROM [storageownerinformation]">
                        </asp:SqlDataSource>
                    </td>
                </tr>
        </table>

        <footer style="font-family: 'Agency FB';text-align:center; font-weight: bold; font-size: x-large; margin: 0px; padding: 30px 0px 30px 0px; background-color: #666699">@ 2016 OrderSystemCMS | All Rights&nbsp; Reserved |
            <asp:LinkButton ID="DashBoardLinkButton" runat="server" ForeColor="#FFFFCC" OnClick="DashBoardLinkButton_Click" CssClass="linkBtn" >DashBoard</asp:LinkButton>
        </footer>

    </form>
</body>
</html>
