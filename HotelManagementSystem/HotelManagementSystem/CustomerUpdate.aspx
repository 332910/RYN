<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerUpdate.aspx.cs" Inherits="HotelManagementSystem.CustomerUpdate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 101px;
        }
        .auto-style3 {
            width: 101px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
        }
        .auto-style5 {
            width: 101px;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
        }
    </style>
</head>
<body style="height: 60px">
    <form id="form1" runat="server">
    <div>
    
        Customer Particulars Update<br />
        <br />
        Customer Details<br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Guestid:</td>
                <td>
                    <asp:TextBox ID="tbxGuestidUpdate" runat="server" Width="192px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">First Name:</td>
                <td>
                    <asp:TextBox ID="tbxFirstNameUpdate" runat="server" Width="192px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Last Name:</td>
                <td>
                    <asp:TextBox ID="tbxLastNameUpdate" runat="server" Width="192px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Passport No:</td>
                <td>
                    <asp:TextBox ID="tbxPassportNoUpdate" runat="server" Width="192px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Gender:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="tbxGenderUpdate" runat="server" Width="192px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Phone no:</td>
                <td>
                    <asp:TextBox ID="tbxPhoneNoUpdate" runat="server" Width="192px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Email address:</td>
                <td>
                    <asp:TextBox ID="tbxEmailaddressUpdate" runat="server" Width="192px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Country:</td>
                <td>
                    <asp:TextBox ID="tbxCountryUpdate" runat="server" Width="192px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Nationality:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="tbxNationalityUpdate" runat="server" Width="192px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Street Name:</td>
                <td>
                    <asp:TextBox ID="tbxStreetNameUpdate" runat="server" Width="192px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Block:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="tbxBlockUpdate" runat="server" Width="192px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Unit No:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="tbxUnitNoUpdate" runat="server" Width="192px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Postal Code:</td>
                <td>
                    <asp:TextBox ID="tbxPostalCodeUpdate" runat="server" Width="192px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
                </td>
            </tr>
        </table>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
