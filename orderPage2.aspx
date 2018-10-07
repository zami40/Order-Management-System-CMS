<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="orderPage2.aspx.cs" Inherits="OnlineCMSWebsite.orderPage2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Css/CssAll.css" />
    <style type="text/css">
        .auto-style1 {
            text-align: right;
        }
        .auto-style3 {
            width: 43px;
        }
        .auto-style4 {
            width: 104px;
        }
        .auto-style5 {
            width: 125px;
        }
        .auto-style6 {
            width: 228px;
        }
        .auto-style8 {
            width: 118px;
        }
        .auto-style9 {
            height: 10px;
        }
    </style>
</head>
<body style="margin: 0px">
    <form id="form1" runat="server">
     <p style="font-size: 50px; font-weight: bold; font-family: 'Agency FB'; color: #FFFF00; background-color: #000066; margin: 0px; padding: 30px 0px 30px 0px; text-align: center;">
            <asp:Label ID="StoreNameLabel" runat="server" Text="Store Name"></asp:Label>
        </p>
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style9"></td>
                <td class="auto-style9"></td>
            </tr>
            <tr>
                <td>
                    <p style="text-align: left; color: #660066; padding-left: 20px; font-size: 35px; font-weight: bold;">Customer&#39;s Details :</p>

                    <table class="auto-style1" style="padding-bottom: 150px">
                        <tr>
                            <td class="auto-style1">Customer Name :&nbsp;&nbsp;&nbsp; </td>
                            <td>
                                <asp:TextBox ID="CustomerNameTextBox" runat="server" Width="250px"></asp:TextBox>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style1">Credit Card Number :&nbsp;&nbsp;&nbsp; </td>
                            <td>
                                <asp:TextBox ID="CreditCardTextBox" runat="server" Width="250px"></asp:TextBox>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style1">&nbsp; Address :&nbsp;&nbsp;&nbsp; </td>
                            <td>
                                <asp:TextBox ID="AddressTextBox" runat="server" Width="250px"></asp:TextBox>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style1">Date :&nbsp;&nbsp;&nbsp; </td>
                            
                            <td>
                                <asp:TextBox ID="DateTextBox" runat="server" Width="250px"></asp:TextBox>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td></td>
                            <td style="text-align: center">
                                <asp:Button ID="SubmitButton" runat="server" OnClick="SubmitButton_Click" Text="Submit" Font-Bold="True" Font-Size="13pt" Height="34px" Width="96px" />
                                <br />
                                <br />
                    <asp:Label ID="CompleteLabel" runat="server" style="text-align: center" Font-Bold="True" Font-Size="20pt" ForeColor="#00CC00"></asp:Label>
                            </td>
                            <td></td>

                        </tr>
                    </table>
                </td>
                <td>
                    <table class="auto-style1" style="text-align: center; padding-left: 200px;">
                        <tr>
                            <td class="auto-style6" style="text-align: center">Product Name</td>
                            <td class="auto-style4" style="text-align: center">Price</td>
                            <td class="auto-style8" style="text-align: center">Quantity</td>
                            <td class="auto-style5" style="text-align: center">Items left</td>
                            <td class="auto-style3">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style6">
                                <asp:Label ID="PNLabel0" runat="server" Font-Size="10pt" ForeColor="#3366CC"></asp:Label>
                            </td>
                            <td class="auto-style4">
                        <asp:Label ID="PPLabel0" runat="server" ForeColor="Red"></asp:Label>
                            </td>
                            <td style="text-align: center" class="auto-style8">
                                <asp:TextBox ID="SampleTextBox0" runat="server" Width="35px" Visible="False"></asp:TextBox>
                            </td>
                            <td class="auto-style5">
                        <asp:Label ID="SampleLabel0" runat="server" ForeColor="#3366CC"></asp:Label>
                            </td>
                            <td style="text-align: left">
                                <asp:Label ID="quantityExceedLabel0" runat="server" Text="exceeded" Visible="False" ForeColor="Red"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style6">
                        <asp:Label ID="PNLabel1" runat="server" ForeColor="#3366CC" Font-Size="10pt"></asp:Label>
                            </td>
                            <td class="auto-style4">
                        <asp:Label ID="PPLabel1" runat="server" ForeColor="Red"></asp:Label>
                            </td>
                            <td style="text-align: center" class="auto-style8">
                                <asp:TextBox ID="SampleTextBox1" runat="server" Width="35px" Visible="False"></asp:TextBox>
                            </td>
                            <td class="auto-style5">
                        <asp:Label ID="SampleLabel1" runat="server" ForeColor="#3366CC"></asp:Label>
                            </td>
                            <td style="text-align: left">
                                <asp:Label ID="quantityExceedLabel1" runat="server" Text="exceeded" Visible="False" ForeColor="Red"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style6">
                        <asp:Label ID="PNLabel2" runat="server" ForeColor="#3366CC" Font-Size="10pt"></asp:Label>
                            </td>
                            <td class="auto-style4">
                        <asp:Label ID="PPLabel2" runat="server" ForeColor="Red"></asp:Label>
                            </td>
                            <td style="text-align: center" class="auto-style8">
                                <asp:TextBox ID="SampleTextBox2" runat="server" Width="35px" Visible="False"></asp:TextBox>
                            </td>
                            <td class="auto-style5">
                        <asp:Label ID="SampleLabel2" runat="server" ForeColor="#3366CC"></asp:Label>
                            </td>
                            <td style="text-align: left">
                                <asp:Label ID="quantityExceedLabel2" runat="server" Text="exceeded" Visible="False" ForeColor="Red"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style6">
                        <asp:Label ID="PNLabel3" runat="server" ForeColor="#3366CC" Font-Size="10pt"></asp:Label>
                            </td>
                            <td class="auto-style4">
                        <asp:Label ID="PPLabel3" runat="server" ForeColor="Red"></asp:Label>
                            </td>
                            <td style="text-align: center" class="auto-style8">
                                <asp:TextBox ID="SampleTextBox3" runat="server" Width="35px" Visible="False"></asp:TextBox>
                            </td>
                            <td class="auto-style5">
                        <asp:Label ID="SampleLabel3" runat="server" ForeColor="#3366CC"></asp:Label>
                            </td>
                            <td style="text-align: left">
                                <asp:Label ID="quantityExceedLabel3" runat="server" Text="exceeded" Visible="False" ForeColor="Red"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style6">
                        <asp:Label ID="PNLabel4" runat="server" ForeColor="#3366CC" Font-Size="10pt"></asp:Label>
                            </td>
                            <td class="auto-style4">
                        <asp:Label ID="PPLabel4" runat="server" ForeColor="Red"></asp:Label>
                            </td>
                            <td style="text-align: center" class="auto-style8">
                                <asp:TextBox ID="SampleTextBox4" runat="server" Width="35px" Visible="False"></asp:TextBox>
                            </td>
                            <td class="auto-style5">
                        <asp:Label ID="SampleLabel4" runat="server" ForeColor="#3366CC"></asp:Label>
                            </td>
                            <td style="text-align: left">
                                <asp:Label ID="quantityExceedLabel4" runat="server" Text="Quantity exceeded" Visible="False" ForeColor="Red"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style6">
                        <asp:Label ID="PNLabel5" runat="server" ForeColor="#3366CC" Font-Size="10pt"></asp:Label>
                            </td>
                            <td class="auto-style4">
                        <asp:Label ID="PPLabel5" runat="server" ForeColor="Red"></asp:Label>
                            </td>
                            <td style="text-align: center" class="auto-style8">
                                <asp:TextBox ID="SampleTextBox5" runat="server" Width="35px" Visible="False"></asp:TextBox>
                            </td>
                            <td class="auto-style5">
                        <asp:Label ID="SampleLabel5" runat="server" ForeColor="#3366CC"></asp:Label>
                            </td>
                            <td style="text-align: left">
                                <asp:Label ID="quantityExceedLabel5" runat="server" Text="Quantity exceeded" Visible="False" ForeColor="Red"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style6">
                        <asp:Label ID="PNLabel6" runat="server" ForeColor="#3366CC" Font-Size="10pt"></asp:Label>
                            </td>
                            <td class="auto-style4">
                        <asp:Label ID="PPLabel6" runat="server" ForeColor="Red"></asp:Label>
                            </td>
                            <td style="text-align: center" class="auto-style8">
                                <asp:TextBox ID="SampleTextBox6" runat="server" Width="35px" Visible="False"></asp:TextBox>
                            </td>
                            <td class="auto-style5">
                        <asp:Label ID="SampleLabel6" runat="server" ForeColor="#3366CC"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="quantityExceedLabel6" runat="server" Text="Quantity exceeded" Visible="False" ForeColor="Red"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style6">
                        <asp:Label ID="PNLabel7" runat="server" ForeColor="#3366CC" Font-Size="10pt"></asp:Label>
                            </td>
                            <td class="auto-style4">
                        <asp:Label ID="PPLabel7" runat="server" ForeColor="Red"></asp:Label>
                            </td>
                            <td style="text-align: center" class="auto-style8">
                                <asp:TextBox ID="SampleTextBox7" runat="server" Width="35px" Visible="False"></asp:TextBox>
                            </td>
                            <td class="auto-style5">
                        <asp:Label ID="SampleLabel7" runat="server" ForeColor="#3366CC"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="quantityExceedLabel7" runat="server" Text="Quantity exceeded" Visible="False" ForeColor="Red"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style6">
                        <asp:Label ID="PNLabel8" runat="server" ForeColor="#3366CC" Font-Size="10pt"></asp:Label>
                            </td>
                            <td class="auto-style4">
                        <asp:Label ID="PPLabel8" runat="server" ForeColor="Red"></asp:Label>
                            </td>
                            <td class="auto-style8">
                                <asp:TextBox ID="SampleTextBox8" runat="server" Width="35px" Visible="False"></asp:TextBox>
                            </td>
                            <td class="auto-style5">
                        <asp:Label ID="SampleLabel8" runat="server" ForeColor="#3366CC"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="quantityExceedLabel8" runat="server" Text="Quantity exceeded" Visible="False" ForeColor="Red"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style6">
                        <asp:Label ID="PNLabel9" runat="server" ForeColor="#3366CC" Font-Size="10pt"></asp:Label>
                            </td>
                            <td class="auto-style4">
                        <asp:Label ID="PPLabel9" runat="server" ForeColor="Red"></asp:Label>
                            </td>
                            <td class="auto-style8">
                                <asp:TextBox ID="SampleTextBox9" runat="server" Width="35px" Visible="False"></asp:TextBox>
                            </td>
                            <td class="auto-style5">
                        <asp:Label ID="SampleLabel9" runat="server" ForeColor="#3366CC"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="quantityExceedLabel9" runat="server" Text="Quantity exceeded" Visible="False" ForeColor="Red"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style6">
                        <asp:Label ID="PNLabel10" runat="server" ForeColor="#3366CC" Font-Size="10pt"></asp:Label>
                            </td>
                            <td class="auto-style4">
                        <asp:Label ID="PPLabel10" runat="server" ForeColor="Red"></asp:Label>
                            </td>
                            <td class="auto-style8">
                                <asp:TextBox ID="SampleTextBox10" runat="server" Width="35px" Visible="False"></asp:TextBox>
                            </td>
                            <td class="auto-style5">
                        <asp:Label ID="SampleLabel10" runat="server" ForeColor="#3366CC"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="quantityExceedLabel10" runat="server" Text="Quantity exceeded" Visible="False" ForeColor="Red"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style6">
                        <asp:Label ID="PNLabel11" runat="server" ForeColor="#3366CC" Font-Size="10pt"></asp:Label>
                            </td>
                            <td class="auto-style4">
                        <asp:Label ID="PPLabel11" runat="server" ForeColor="Red"></asp:Label>
                            </td>
                            <td class="auto-style8">
                                <asp:TextBox ID="SampleTextBox11" runat="server" Width="35px" Visible="False"></asp:TextBox>
                            </td>
                            <td class="auto-style5">
                        <asp:Label ID="SampleLabel11" runat="server" ForeColor="#3366CC"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="quantityExceedLabel11" runat="server" Text="Quantity exceeded" Visible="False" ForeColor="Red"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style6">
                        <asp:Label ID="PNLabel12" runat="server" ForeColor="#3366CC" Font-Size="10pt"></asp:Label>
                            </td>
                            <td class="auto-style4">
                        <asp:Label ID="PPLabel12" runat="server" ForeColor="Red"></asp:Label>
                            </td>
                            <td class="auto-style8">
                                <asp:TextBox ID="SampleTextBox12" runat="server" Width="35px" Visible="False"></asp:TextBox>
                            </td>
                            <td class="auto-style5">
                        <asp:Label ID="SampleLabel12" runat="server" ForeColor="#3366CC"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="quantityExceedLabel12" runat="server" Text="Quantity exceeded" Visible="False" ForeColor="Red"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style6">
                        <asp:Label ID="PNLabel13" runat="server" ForeColor="#3366CC" Font-Size="10pt"></asp:Label>
                            </td>
                            <td style="font-weight: bold" class="auto-style4"><asp:Label ID="PPLabel13" runat="server" ForeColor="Red" Font-Bold="False"></asp:Label>
                            </td>
                            <td class="auto-style8">
                                <asp:TextBox ID="SampleTextBox13" runat="server" Width="35px" Visible="False"></asp:TextBox>
                            </td>
                            <td class="auto-style5">
                        <asp:Label ID="SampleLabel13" runat="server" ForeColor="#3366CC"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="quantityExceedLabel13" runat="server" Text="Quantity exceeded" Visible="False" ForeColor="Red"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style6">
                        <asp:Label ID="PNLabel14" runat="server" ForeColor="#3366CC" Font-Size="10pt"></asp:Label>
                            </td>
                            <td class="auto-style4">
                        <asp:Label ID="PPLabel14" runat="server" ForeColor="Red"></asp:Label>
                            </td>
                            <td class="auto-style8">
                                <asp:TextBox ID="SampleTextBox14" runat="server" Width="35px" Visible="False"></asp:TextBox>
                            </td>
                            <td class="auto-style5">
                        <asp:Label ID="SampleLabel14" runat="server" ForeColor="#3366CC"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="quantityExceedLabel14" runat="server" Text="Quantity exceeded" Visible="False" ForeColor="Red"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                            
                            <td>Total Taka : </td>
                            <td class="auto-style8">
                                <asp:Label ID="TotalTakaLabel" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                                </td>
                            <td></td>

                        </tr>
                        <tr>
                            <td></td>
                            <td></td>
                            <td class="auto-style8">
                                <asp:Button ID="TakaButton" runat="server" OnClick="TakaButton_Click" Text="Show Taka" Font-Bold="True" />
                                </td>
                            <td></td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    
    </div>
         <footer style="font-family: 'Agency FB';text-align:center; font-weight: bold; font-size: x-large; margin: 0px; padding: 30px 0px 30px 0px; background-color: #666699">@&nbsp; 2016 OrderSystemCMS | All Rights&nbsp; Reserved&nbsp; |&nbsp; <asp:LinkButton ID="HomeLinkButton" runat="server" OnClick="HomeLinkButton_Click" ForeColor="#FFFFCC" CssClass="linkBtn">Home</asp:LinkButton>
        </footer>    
    
    </form>
</body>
</html>
