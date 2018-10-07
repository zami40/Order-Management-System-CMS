<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dashBoard.aspx.cs" Inherits="OnlineCMSWebsite.dashBoard" %>

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
            width: 270px;
        }
    </style>
</head>
<body style="margin: 0px">
    <form id="form1" runat="server">
   <p style="font-size: 50px; font-weight: bold; font-family: 'Agency FB'; color: #FFFF00; background-color: #000066; margin: 0px; padding: 30px 0px 30px 0px; text-align: center;">Order<span style="color: #00FF00">System</span><span style="color: #993399; font-family: 'Agency FB'; font-size: 50px; font-weight: bold">CMS</span></p>
        
        
       
        
        
        <table class="auto-style1" style="background-image: url('Images/1.JPG')">
            <tr>
                <td class="auto-style2" style="text-align: center; color: #FFFFFF; font-size: 30px; background-color: #FF9966; font-weight: bold;">All Storage</td>
                <td style="text-align: center; padding-right: 20px; color: #000000; font-size: 50px; font-weight: bold;">
                    &nbsp;Dash Board</td>
                <td style="text-align: right; padding-right: 20px;">
                    <asp:Label ID="SuperAdminNameLabel" runat="server" Font-Bold="True" Font-Size="20pt" Text="admin" ForeColor="Red"></asp:Label>
                    <br />
                    <asp:LinkButton ID="LogoutLinkButton" runat="server" Font-Bold="True" Font-Size="14pt" OnClick="LogoutLinkButton_Click" CssClass="linkBtn" >logout</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:ListBox ID="ListBox1" runat="server" BackColor="#660066" Font-Size="Larger" Height="353px" Width="300px" Font-Bold="True" ForeColor="White" DataSourceID="SqlDataSourceStorageNameList" DataTextField="StorageName" DataValueField="StorageName" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" CssClass="listBox">
                        <asp:ListItem>Fastrack</asp:ListItem>
                        <asp:ListItem>Bata</asp:ListItem>
                        <asp:ListItem>Apex</asp:ListItem>
                    </asp:ListBox>
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="errorMsg" runat="server" Font-Size="16pt" ForeColor="Red" Text="* Please select a item" Visible="False"></asp:Label>
                    <asp:SqlDataSource ID="SqlDataSourceStorageNameList" runat="server" ConnectionString="<%$ ConnectionStrings:CMSConnectionString %>" SelectCommand="SELECT [StorageName] FROM [storageinformation]"></asp:SqlDataSource>
                </td>
                <td style="padding-left: 200px" colspan="2">
                    <asp:Button ID="CreateStoreButton" runat="server" Font-Bold="True" Font-Size="15pt" Height="100px" OnClick="CreateStoreButton_Click" Text="Create a Store" Width="180px" CssClass="DashBoardBtn" BorderWidth="3px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnCreateOwners" runat="server" Font-Bold="True" Font-Size="15pt" Height="100px" OnClick="btnCreateOwners_Click" Text="Create Owners" Width="180px" CssClass="DashBoardBtn" BorderWidth="3px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;<asp:Button ID="AssignOwnersButton" runat="server" Font-Bold="True" Font-Size="15pt" Height="100px" OnClick="AssignOwnersButton_Click" Text="Assign Owners" Width="180px" CssClass="DashBoardBtn" BorderWidth="3px" />
                </td>
            </tr>
        </table>
    </form>
    <footer style="font-family: 'Agency FB';text-align:center; font-weight: bold; font-size: x-large; margin: 0px; padding: 30px 0px 30px 0px; background-color: #666699">@&nbsp;&nbsp; 2016 OrderSystemCMS | All Rights&nbsp; Reserved&nbsp; </footer>    
    
</body>
</html>
