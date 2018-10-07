<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login2.aspx.cs" Inherits="OnlineCMSWebsite.login2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        #Reset1 {
            width: 65px;
            height: 33px;
        }
        .auto-style2 {
            width: 174px;
        }
        .auto-style3 {
            width: 230px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-top: 100px; margin-right: 250px; margin-left: 250px; background-color: #009999; border-radius:20px">

        <table class="auto-style1" style="border-bottom-style: solid; border-bottom-width: 2px; border-bottom-color: #FFFFCC">
            <tr>
                <td class="auto-style3" style="padding-left: 60px; padding-top: 10px; text-align: right;">
                    <asp:Image ID="Image1" runat="server" Height="117px" ImageUrl="~/Images/10.png" Width="129px" />
                </td>
                <td style="font-family: 'Agency FB'; color: #FFFF99; font-weight: bold; font-size: 60px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Log in</td>
            </tr>
        </table>
        <br />
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" style="padding-left: 15px; font-family: Arial; font-weight: bold; text-align: right;">User Name :&nbsp;&nbsp; </td>
                <td style="text-align: center">
                    <asp:TextBox ID="UserNameTextBox" runat="server" Height="20px" Width="250px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="UserNameTextBox" ErrorMessage="*Please Enter your User Name" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" style="padding-left: 15px; font-family: Arial; font-weight: bold; text-align: right;">Password :&nbsp;&nbsp; </td>
                <td style="text-align: center">
                    <asp:TextBox ID="PasswordTextBox" runat="server" Height="20px" Width="250px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="PasswordTextBox" ErrorMessage="*Please Enter your Password" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td style="text-align: center">
                    <asp:Button ID="LoginButton" runat="server" BackColor="#6666FF" BorderColor="#6666FF" Font-Bold="True" Font-Size="13pt" ForeColor="White" Height="33px" OnClick="LoginButton_Click" Text="Login" Width="79px" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <input id="Reset1" type="reset" value="reset" /></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Label ID="UserPasswordLabel" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
    </div>
    </form>
</body>
</html>
