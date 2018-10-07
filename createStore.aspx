<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createStore.aspx.cs" Inherits="OnlineCMSWebsite.createStore" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Css/CssAll.css" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: right;
            width: 283px;
        }
        .auto-style3 {
            width: 283px;
        }
        .auto-style4 {
            width: 250px;
        }
        .auto-style5 {
            width: 204px;
        }
    </style>
</head>
<body style="padding: 0px; margin: 0px">
    <form id="form1" runat="server">
        <p style="font-size: 50px; font-weight: bold; font-family: 'Agency FB'; color: #FFFF00; background-color: #000066; margin: 0px; padding: 30px 0px 30px 0px; text-align: center;">Order<span style="color: #00FF00">System</span><span style="color: #993399; font-family: 'Agency FB'; font-size: 50px; font-weight: bold">CMS</span></p>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4" style="color: #FFFFFF; font-size: 30px; font-family: 'Agency FB'; font-weight: bold; text-align: center; background-color: #FF9966;">
                        All Storage</td>
                    <td rowspan="2">
                        <table class="auto-style1" style="font-size: 20px; font-weight: bold">
                            <tr>
                                <td class="auto-style2">Storage Name&nbsp; :&nbsp;&nbsp;&nbsp; </td>
                                <td class="auto-style5">
                                    <asp:TextBox ID="StorageNameTextBox" runat="server" Width="250px" OnTextChanged="StorageNameTextBox_TextChanged"></asp:TextBox>
                                </td>
                                <td>
                        <asp:Label ID="storageNameErrorMsg" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="Red" Text="* Please enter storage name" Visible="False"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: right">
                                    Icon :&nbsp;&nbsp;&nbsp;&nbsp;
                                </td>
                                <td class="auto-style5">
                                    <asp:FileUpload ID="ProductIconFileUpload" runat="server" Width="250px" />
                                </td>
                                <td style="text-align: left">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Image ID="Image2" runat="server" Height="54px" Width="70px" />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">
                                    <asp:Label ID="ItemSzLabel" runat="server" Text="Total Size :&nbsp;&nbsp;&nbsp; "></asp:Label>
                                </td>
                                <td class="auto-style5">
                                    <asp:CheckBox ID="ItemSz5CheckBox" runat="server" Text="5" OnCheckedChanged="ItemSz5CheckBox_CheckedChanged" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:CheckBox ID="ItemSz10CheckBox" runat="server" Text="10" OnCheckedChanged="ItemSz10CheckBox_CheckedChanged" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:CheckBox ID="ItemSz15CheckBox" runat="server" Text="15" OnCheckedChanged="ItemSz15CheckBox_CheckedChanged" />
                                </td>
                                <td style="text-align: left">
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="checkBoxErrorMsg" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="Red" Text="* Please select this" Visible="False"></asp:Label>
                                    &nbsp;&nbsp;&nbsp;
                                    <asp:Label ID="TltSzLabel" runat="server" Font-Bold="True" Font-Size="18pt" ForeColor="Blue"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;</td>
                                <td class="auto-style5">
                                    <asp:Button ID="CreateStoreButton" runat="server" Text="Create a Store" Font-Bold="True" OnClick="CreateStoreButton_Click" Height="40px" Width="110px" />
&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Button ID="EditStoreButton" runat="server" Text="Update Store" Width="110px" Font-Bold="True" OnClick="EditStoreButton_Click" Height="40px" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;</td>
                                <td style="text-align: center" class="auto-style5">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style2">
                                    &nbsp;</td>
                                <td class="auto-style5">
                                    &nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style3">&nbsp;</td>
                                <td class="auto-style5">
                                    &nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style3">&nbsp;</td>
                                <td class="auto-style5">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" BackColor="#660066" DataSourceID="StorageNameListBoxSqlDataSource" DataTextField="StorageName" DataValueField="StorageName" Font-Bold="True" Font-Size="Larger" ForeColor="White" Height="353px" Width="300px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged">
                            <asp:ListItem>ALL Storage</asp:ListItem>
                        </asp:ListBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="errorMsg" runat="server" Font-Size="16pt" ForeColor="Red" Text="* Please select a item" Visible="False"></asp:Label>
                        <asp:SqlDataSource ID="StorageNameListBoxSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:CMSConnectionString %>" SelectCommand="SELECT [StorageName] FROM [storageinformation]"></asp:SqlDataSource>
                    </td>
                </tr>
        </table>

        <footer style="font-family: 'Agency FB';text-align:center; font-weight: bold; font-size: x-large; margin: 0px; padding: 30px 0px 30px 0px; background-color: #666699">@ 2016 LightCMS | All Rights&nbsp; Reserved |
            <asp:LinkButton ID="DashBoardLinkButton" runat="server" ForeColor="#FFFFCC" OnClick="DashBoardLinkButton_Click" CssClass="linkBtn">DashBoard</asp:LinkButton>
        </footer>

            </form>
</body>
</html>
