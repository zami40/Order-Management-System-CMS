<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="orderPage.aspx.cs" Inherits="OnlineCMSWebsite.orderPage" %>

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
            width: 150px;
        }
        .auto-style3 {
            height: 26px;
        }
        .auto-style4 {
            width: 150px;
            height: 26px;
        }
    </style>
</head>
<body style="margin: 0px">
    <form id="form1" runat="server">
        <p style="font-size: 50px; font-weight: bold; font-family: 'Agency FB'; color: #FFFF00; background-color: #000066; margin: 0px; padding: 30px 0px 30px 0px; text-align: center;">
            <asp:Label ID="StoreNameLabel" runat="server" Text="Store Name"></asp:Label>
        </p>

        
    <div>
    
        <table class="auto-style1" style="font-size: large; font-weight: bold; font-family: 'Agency FB'">
            <tr>
                <td style="padding-right: 20px">
                    <asp:Panel ID="Panel0" runat="server" style="text-align: left" Visible="False">
                        <asp:CheckBox ID="CheckBox0" runat="server" />
                        <br />
                        <asp:Image ID="Image0" runat="server" Height="120px" Width="180px" />
                        <br />
                        Product Name :
                        <asp:Label ID="PNLabel0" runat="server" Text="Label" ForeColor="Black"></asp:Label>
                        <br />
                        Price :
                        <asp:Label ID="PPLabel0" runat="server" Text="Label" ForeColor="Red"></asp:Label>
                        &nbsp;TK<br /> Quantity :
                        <asp:Label ID="QtyLabel0" runat="server" ForeColor="#00CC00" Text="Label"></asp:Label>
                    </asp:Panel>
                </td>
                <td style="padding-right: 20px">
                    <asp:Panel ID="Panel1" runat="server" style="text-align: left" Visible="False">
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                        <br />
                        <asp:Image ID="Image1" runat="server" Height="120px" Width="180px" />
                        <br />
                        Product Name :
                        <asp:Label ID="PNLabel1" runat="server" Text="Label" ForeColor="Black"></asp:Label>
                        <br />
                        Price :
                        <asp:Label ID="PPLabel1" runat="server" Text="Label" ForeColor="Red"></asp:Label>
                        &nbsp;TK<br /> Quantity :
                        <asp:Label ID="QtyLabel1" runat="server" ForeColor="#00CC00" Text="Label"></asp:Label>
                    </asp:Panel>
                </td>
                <td style="padding-right: 20px">
                    <asp:Panel ID="Panel2" runat="server" style="text-align: left" Visible="False">
                        <asp:CheckBox ID="CheckBox2" runat="server" />
                        <br />
                        <asp:Image ID="Image2" runat="server" Height="120px" Width="180px" />
                        <br />
                        Product Name :
                        <asp:Label ID="PNLabel2" runat="server" Text="Label" ForeColor="Black"></asp:Label>
                        <br />
                        Price :
                        <asp:Label ID="PPLabel2" runat="server" Text="Label" ForeColor="Red"></asp:Label>
                        &nbsp;TK<br /> Quantity :
                        <asp:Label ID="QtyLabel2" runat="server" ForeColor="#00CC00" Text="Label"></asp:Label>
                    </asp:Panel>
                </td>
                <td style="padding-right: 20px">
                    <asp:Panel ID="Panel3" runat="server" style="text-align: left" Visible="False">
                        <asp:CheckBox ID="CheckBox3" runat="server" />
                        <br />
                        <asp:Image ID="Image3" runat="server" Height="120px" Width="180px" />
                        <br />
                        Product Name :
                        <asp:Label ID="PNLabel3" runat="server" Text="Label" ForeColor="Black"></asp:Label>
                        <br />
                        Price :
                        <asp:Label ID="PPLabel3" runat="server" Text="Label" ForeColor="Red"></asp:Label>
                        &nbsp;TK<br /> Quantity :
                        <asp:Label ID="QtyLabel3" runat="server" ForeColor="#00CC00" Text="Label"></asp:Label>
                    </asp:Panel>
                </td>
                <td class="auto-style2"  style="padding-right: 20px">
                    <asp:Panel ID="Panel4" runat="server" style="text-align: left" Visible="False">
                        <asp:CheckBox ID="CheckBox4" runat="server" />
                        <br />
                        <asp:Image ID="Image4" runat="server" Height="120px" Width="180px" />
                        <br />
                        Product Name :
                        <asp:Label ID="PNLabel4" runat="server" Text="Label" ForeColor="Black"></asp:Label>
                        <br />
                        Price :
                        <asp:Label ID="PPLabel4" runat="server" Text="Label" ForeColor="Red"></asp:Label>
                        &nbsp;TK<br /> Quantity :
                        <asp:Label ID="QtyLabel4" runat="server" ForeColor="#00CC00" Text="Label"></asp:Label>
                    </asp:Panel>
                </td>
                </tr>
            <tr>
                <td  style="padding-right: 20px">
                    <asp:Panel ID="Panel5" runat="server" style="text-align: left" Visible="False">
                        <asp:CheckBox ID="CheckBox5" runat="server" />
                        <br />
                        <asp:Image ID="Image5" runat="server" Height="120px" Width="180px" />
                        <br />
                        Product Name :
                        <asp:Label ID="PNLabel5" runat="server" Text="Label" ForeColor="Black"></asp:Label>
                        <br />
                        Price :
                        <asp:Label ID="PPLabel5" runat="server" Text="Label" ForeColor="Red"></asp:Label>
                        &nbsp;TK<br /> Quantity :
                        <asp:Label ID="QtyLabel5" runat="server" ForeColor="#00CC00" Text="Label"></asp:Label>
                    </asp:Panel>
                </td>
                <td  style="padding-right: 20px">
                    <asp:Panel ID="Panel6" runat="server" style="text-align: left" Visible="False">
                        <asp:CheckBox ID="CheckBox6" runat="server" />
                        <br />
                        <asp:Image ID="Image6" runat="server" Height="120px" Width="180px" />
                        <br />
                        Product Name :
                        <asp:Label ID="PNLabel6" runat="server" Text="Label" ForeColor="Black"></asp:Label>
                        <br />
                        Price :
                        <asp:Label ID="PPLabel6" runat="server" Text="Label" ForeColor="Red"></asp:Label>
                        &nbsp;TK<br /> Quantity :
                        <asp:Label ID="QtyLabel6" runat="server" ForeColor="#00CC00" Text="Label"></asp:Label>
                    </asp:Panel>
                </td>
                <td  style="padding-right: 20px">
                    <asp:Panel ID="Panel7" runat="server" style="text-align: left" Visible="False">
                        <asp:CheckBox ID="CheckBox7" runat="server" />
                        <br />
                        <asp:Image ID="Image7" runat="server" Height="120px" Width="180px" />
                        <br />
                        Product Name :
                        <asp:Label ID="PNLabel7" runat="server" Text="Label" ForeColor="Black"></asp:Label>
                        <br />
                        Price :
                        <asp:Label ID="PPLabel7" runat="server" Text="Label" ForeColor="Red"></asp:Label>
                        &nbsp;TK<br /> Quantity :
                        <asp:Label ID="QtyLabel7" runat="server" ForeColor="#00CC00" Text="Label"></asp:Label>
                    </asp:Panel>
                </td>
                <td  style="padding-right: 20px">
                    <asp:Panel ID="Panel8" runat="server" style="text-align: left" Visible="False">
                        <asp:CheckBox ID="CheckBox8" runat="server" />
                        <br />
                        <asp:Image ID="Image8" runat="server" Height="120px" Width="180px" />
                        <br />
                        Product Name :
                        <asp:Label ID="PNLabel8" runat="server" Text="Label" ForeColor="Black"></asp:Label>
                        <br />
                        Price :
                        <asp:Label ID="PPLabel8" runat="server" Text="Label" ForeColor="Red"></asp:Label>
                        &nbsp;TK<br /> Quantity :
                        <asp:Label ID="QtyLabel8" runat="server" ForeColor="#00CC00" Text="Label"></asp:Label>
                    </asp:Panel>
                </td>
                <td class="auto-style2"  style="padding-right: 20px">
                    <asp:Panel ID="Panel9" runat="server" style="text-align: left" Visible="False">
                        <asp:CheckBox ID="CheckBox9" runat="server" />
                        <br />
                        <asp:Image ID="Image9" runat="server" Height="120px" Width="180px" />
                        <br />
                        Product Name :
                        <asp:Label ID="PNLabel9" runat="server" Text="Label" ForeColor="Black"></asp:Label>
                        <br />
                        Price :
                        <asp:Label ID="PPLabel9" runat="server" Text="Label" ForeColor="Red"></asp:Label>
                        &nbsp;TK<br /> Quantity :
                        <asp:Label ID="QtyLabel9" runat="server" ForeColor="#00CC00" Text="Label"></asp:Label>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td class="auto-style2"  style="padding-right: 20px">
                    <asp:Panel ID="Panel10" runat="server" style="text-align: left" Visible="False">
                        <asp:CheckBox ID="CheckBox10" runat="server" />
                        <br />
                        <asp:Image ID="Image10" runat="server" Height="120px" Width="180px" />
                        <br />
                        Product Name :
                        <asp:Label ID="PNLabel10" runat="server" Text="Label" ForeColor="Black"></asp:Label>
                        <br />
                        Price :
                        <asp:Label ID="PPLabel10" runat="server" Text="Label" ForeColor="Red"></asp:Label>
                        &nbsp;TK<br /> Quantity :
                        <asp:Label ID="QtyLabel10" runat="server" ForeColor="#00CC00" Text="Label"></asp:Label>
                    </asp:Panel>
                </td>
                <td class="auto-style2"  style="padding-right: 20px">
                    <asp:Panel ID="Panel11" runat="server" style="text-align: left" Visible="False">
                        <asp:CheckBox ID="CheckBox11" runat="server" />
                        <br />
                        <asp:Image ID="Image11" runat="server" Height="120px" Width="180px" />
                        <br />
                        Product Name :
                        <asp:Label ID="PNLabel11" runat="server" Text="Label" ForeColor="Black"></asp:Label>
                        <br />
                        Price :
                        <asp:Label ID="PPLabel11" runat="server" Text="Label" ForeColor="Red"></asp:Label>
                        &nbsp;TK<br /> Quantity :
                        <asp:Label ID="QtyLabel11" runat="server" ForeColor="#00CC00" Text="Label"></asp:Label>
                    </asp:Panel>
                </td>
                <td class="auto-style2"  style="padding-right: 20px">
                    <asp:Panel ID="Panel12" runat="server" style="text-align: left" Visible="False">
                        <asp:CheckBox ID="CheckBox12" runat="server" />
                        <br />
                        <asp:Image ID="Image12" runat="server" Height="120px" Width="180px" />
                        <br />
                        Product Name :
                        <asp:Label ID="PNLabel12" runat="server" Text="Label" ForeColor="Black"></asp:Label>
                        <br />
                        Price :
                        <asp:Label ID="PPLabel12" runat="server" Text="Label" ForeColor="Red"></asp:Label>
                        &nbsp;TK<br /> Quantity :
                        <asp:Label ID="QtyLabel12" runat="server" ForeColor="#00CC00" Text="Label"></asp:Label>
                    </asp:Panel>
                </td>
                <td class="auto-style2"  style="padding-right: 20px">
                    <asp:Panel ID="Panel13" runat="server" style="text-align: left" Visible="False">
                        <asp:CheckBox ID="CheckBox13" runat="server" />
                        <br />
                        <asp:Image ID="Image13" runat="server" Height="120px" Width="180px" />
                        <br />
                        Product Name :
                        <asp:Label ID="PNLabel13" runat="server" Text="Label" ForeColor="Black"></asp:Label>
                        <br />
                        Price :
                        <asp:Label ID="PPLabel13" runat="server" Text="Label" ForeColor="Red"></asp:Label>
                        &nbsp;TK<br /> Quantity :
                        <asp:Label ID="QtyLabel13" runat="server" ForeColor="#00CC00" Text="Label"></asp:Label>
                    </asp:Panel>
                </td>
                <td class="auto-style2"  style="padding-right: 20px">
                    <asp:Panel ID="Panel14" runat="server" style="text-align: left" Visible="False">
                        <asp:CheckBox ID="CheckBox14" runat="server" />
                        <br />
                        <asp:Image ID="Image14" runat="server" Height="120px" Width="180px" />
                        <br />
                        Product Name :
                        <asp:Label ID="PNLabel14" runat="server" Text="Label" ForeColor="Black"></asp:Label>
                        <br />
                        Price :
                        <asp:Label ID="PPLabel14" runat="server" Text="Label" ForeColor="Red"></asp:Label>
                        &nbsp;TK<br /> Quantity :
                        <asp:Label ID="QtyLabel14" runat="server" ForeColor="#00CC00" Text="Label"></asp:Label>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style3"></td>
                <td class="auto-style3"></td>
                <td class="auto-style3"></td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
        </table>
        <p style="text-align: center">
            <asp:Button ID="AddCartButton" runat="server" Height="35px" Text="Add Cart" Width="135px" OnClick="AddCartButton_Click" Font-Bold="True" Font-Size="16pt" />
        </p>
    
    </div>
     <footer style="font-family: 'Agency FB';text-align:center; font-weight: bold; font-size: x-large; margin: 0px; padding: 30px 0px 30px 0px; background-color: #666699">@&nbsp;&nbsp; 2016 OrderSystemCMS | All Rights&nbsp; Reserved&nbsp; || <asp:LinkButton ID="BackLinkButton" runat="server" ForeColor="White" OnClick="BackLinkButton_Click" CssClass="linkBtn">Back</asp:LinkButton>
        &nbsp;|
         <asp:LinkButton ID="btnLogin" runat="server" OnClick="btnLogin_Click" ForeColor="White" CssClass="linkBtn">login</asp:LinkButton>
        </footer>    
    
    </form>
         
</body>
</html>
