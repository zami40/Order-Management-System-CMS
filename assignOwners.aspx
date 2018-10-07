<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="assignOwners.aspx.cs" Inherits="OnlineCMSWebsite.assignOwners" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Assign Owners</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 301px;
        }
        .auto-style3 {
            width: 184px;
        }
        .auto-style4 {
            width: 245px;
        }
    </style>
</head>
<body style="margin: 0px">
    <form id="form1" runat="server">
    <p style="font-size: 50px; font-weight: bold; font-family: 'Agency FB'; color: #FFFF00; background-color: #000066; margin: 0px; padding: 30px 0px 30px 0px; text-align: center;">
        <asp:Label ID="StoreNameLabel" runat="server" Text="StoreName"></asp:Label>
        </p>

        <table class="auto-style1">
            <tr>
                <td class="auto-style2" style="background-color: #FF9966; text-align: center; font-size: 30px; font-weight: bold; color: #FFFFFF; font-family: 'Agency FB'">Storage Owners</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:ListBox ID="ownersNameListBox" runat="server" AutoPostBack="True" BackColor="#660066" Font-Bold="True" Font-Size="Larger" ForeColor="White" Height="353px" Width="300px" OnSelectedIndexChanged="ownersNameListBox_Click"></asp:ListBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="errorMsg" runat="server" Font-Size="16pt" ForeColor="Red" Text="* Please select a item" Visible="False"></asp:Label>
                    <asp:SqlDataSource ID="SqlDataSourceOwnersName" runat="server" ConnectionString="<%$ ConnectionStrings:CMSConnectionString %>" SelectCommand="SELECT [OwnerName] FROM [storageownerinformation]"></asp:SqlDataSource>
                </td>
                <td>
                    <table class="auto-style1">
                        <tr>
                            <td style="text-align: right" class="auto-style4">&nbsp;</td>
                            <td class="auto-style3">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="text-align: right" class="auto-style4">Select a Owner :</td>
                            <td class="auto-style3">
                                <asp:DropDownList ID="ownersDropDownList" runat="server" AutoPostBack="True" style="margin-top: 0px" Width="220px" OnSelectedIndexChanged="ownersDropDownList_SelectedIndexChanged">
                                    <asp:ListItem> </asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:Label ID="dropDownerrorMsg" runat="server" Font-Size="16pt" ForeColor="Red" Text="* Please select a item" Visible="False"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">&nbsp;</td>
                            <td class="auto-style3">
                                <asp:Button ID="btnAssign" runat="server" Text="Assign" Width="90px" OnClick="btnAssign_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btnReject" runat="server" Text="Reject" Width="77px" OnClick="btnReject_Click" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style4">&nbsp;</td>
                            <td class="auto-style3">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style4">&nbsp;</td>
                            <td class="auto-style3">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>

        <footer style="font-family: 'Agency FB';text-align:center; font-weight: bold; font-size: x-large; margin: 0px; padding: 30px 0px 30px 0px; background-color: #666699">@ 2016 OrderSystemCMS | All Rights&nbsp; Reserved |
            <asp:LinkButton ID="btnDashboard" runat="server" ForeColor="#FFFFCC" OnClick="btnDashboard_Click">DashBoard</asp:LinkButton>
        </footer>
    
    </form>
</body>
</html>
