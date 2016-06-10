<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterNewStaff.aspx.cs" Inherits="HotelManagementSystem.RegisterNewStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 133px;
        }
        .auto-style3 {
            width: 133px;
            height: 24px;
        }
        .auto-style4 {
            height: 24px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Staff Information<br />
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">First Name:</td>
                <td>
                    <asp:TextBox ID="txtFirstname" runat="server" Width="199px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Last Name:</td>
                <td>
                    <asp:TextBox ID="txtLastname" runat="server" Width="199px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Date of Birth:</td>
                <td>
                    <asp:TextBox ID="txtDateofbirth" runat="server" Width="199px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Address:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtAddress" runat="server" Width="199px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Phone Number:</td>
                <td>
                    <asp:TextBox ID="txtPhonenumber" runat="server" Width="199px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Bank Account:</td>
                <td>
                    <asp:TextBox ID="txtBankaccount" runat="server" Width="199px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="btnCreate" runat="server" OnClick="btnCreate_Click" Text="Create" />
                </td>
            </tr>
        </table>
    
    </div>
        <p>
            &nbsp;</p>
        <div style="margin-left: 360px">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Mainpage.aspx">Main</asp:HyperLink>
        </div>
    </form>
</body>
</html>
