<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="storeadminDashboard.aspx.cs" Inherits="OnlineCMSWebsite.storeadminDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dash Board</title>
    <link rel="stylesheet" href="Css/CssAll.css" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 276px;
        }
    </style>
</head>
<body style="margin: 0px">
    <form id="form1" runat="server">
    <p style="font-size: 50px; font-weight: bold; font-family: 'Agency FB'; color: #FFFF00; background-color: #000066; margin: 0px; padding: 30px 0px 30px 0px; text-align: center;">Order<span style="color: #00FF00">System</span><span style="color: #993399; font-family: 'Agency FB'; font-size: 50px; font-weight: bold">CMS</span></p>
    
        <div>
    
            <table class="auto-style1">
                <tr>
                    <td style="text-align: center; font-size: 30px; font-weight: bold; color: #FFFFFF; background-color: #FF9966;" class="auto-style2">All Storage</td>
                    <td style="font-size: 50px; font-weight: bold; text-align: center">Dash Board</td>
                    <td style="padding-right: 20px; text-align: right;">
                    <asp:Label ID="SuperAdminNameLabel" runat="server" Font-Bold="True" Font-Size="20pt" Text="admin" ForeColor="Red"></asp:Label>
                        <br />
                        <asp:LinkButton ID="btnLogout" runat="server" Font-Bold="True" Font-Size="14pt" OnClick="btnLogout_Click" style="text-align: right" ForeColor="Black" CssClass="linkBtn">logout</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:ListBox ID="StorageNameListBox" runat="server" AutoPostBack="True" Font-Overline="False" Font-Size="Larger" Height="353px" OnSelectedIndexChanged="StorageNameListBox_SelectedIndexChanged" Width="300px" Font-Bold="True" ForeColor="White" CssClass="strAdDblist" BackColor="#660066"></asp:ListBox>
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="errorMsg" runat="server" Font-Size="16pt" ForeColor="Red" Text="* Please select a item" Visible="False"></asp:Label>
                    </td>
                    <td style="padding-left: 200px" colspan="2">
                        <asp:Button ID="btnEditStore" runat="server" Height="100px" OnClick="btnEditStore_Click" Text="Edit Store" Width="180px" Font-Bold="True" Font-Size="18pt" CssClass="DashBoardBtn" BorderWidth="3px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnShowOrders" runat="server" Height="100px" Text="Show Orders" Width="180px" Font-Bold="True" Font-Size="17pt" OnClick="btnShowOrders_Click" CssClass="DashBoardBtn" BorderWidth="3px" />
                    </td>
                </tr>
            </table>
            <footer style="font-family: 'Agency FB';text-align:center; font-weight: bold; font-size: x-large; margin: 0px; padding: 30px 0px 30px 0px; background-color: #666699">@ 2016 LightCMS | All Rights&nbsp; Reserved</footer>

    
    </div>
    </form>
    </body>
</html>
