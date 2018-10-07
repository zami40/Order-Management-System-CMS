<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminLogin.aspx.cs" Inherits="OnlineCMSWebsite.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            text-align: right;
            width: 170px;
        }
        .auto-style4 {
            width: 212px;
        }
        .auto-style6 {
            width: 289px;
        }
        .auto-style7 {
            text-align: right;
            width: 212px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-top: 100px; margin-right: 250px; margin-left: 250px; background-color: #99CCFF; border-radius:20px">

        <table class="auto-style1" style="font-family: 'Agency FB'; font-size: xx-large; font-weight: bold; padding: 20px;border-width: 2px; border-bottom-style: solid; border-color: #FFFFCC">
            <tr>
                <td class="auto-style3" style="padding-left: 60px">
                    <asp:Image ID="Image1" runat="server" Height="117px" ImageUrl="~/Images/10.png" Width="129px" />
                </td>
                <td style="padding-left: 140px; font-size: 60px; color: #660066;">Log in </td>
            </tr>
        </table>
        <br />
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style7" style="padding: 15px; font-family: Arial; font-weight: bold">User Name :</td>
                <td class="auto-style6">
                    <asp:TextBox ID="UserNameTextBox" runat="server" Height="20px" Width="250px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="UserNameTextBox" ErrorMessage="*Please Enter your User Name" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style7" style="padding: 15px; font-family: Arial; font-weight: bold">Password :</td>
                <td class="auto-style6">
                    <asp:TextBox ID="PasswordTextBox" runat="server" Height="20px" Width="250px" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="PasswordTextBox" ErrorMessage="*Please Enter your Password" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td style="padding: 8px" class="auto-style6">
                    <asp:Button ID="Button1" runat="server" BackColor="#0099FF" BorderColor="#0099FF" Font-Bold="True" Font-Size="13pt" ForeColor="White" Height="32px" Text="Log in" Width="85px" OnClick="Button1_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <input id="Reset1" style="font-weight: bold; font-size: 13px; width: 84px; height: 31px;" type="reset" value="reset" /><br />
                    <br />
                    <asp:CheckBox ID="SuperAdminCheckBox" runat="server" Text="Super Admin" />
&nbsp;
                    <asp:CheckBox ID="StorageAdminCheckBox" runat="server" Text="Storage Admin" />
                </td>
                <td>
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style6">
                    <asp:Label ID="UserPasswordLabel" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>

        <br />
        <br />
    </div>
    </form>
</body>
</html>
