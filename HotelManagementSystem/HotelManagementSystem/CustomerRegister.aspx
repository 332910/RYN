<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerRegister.aspx.cs" Inherits="HotelManagementSystem.RoomManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 109px;
        }
        .auto-style3 {
            width: 615px;
        }
        .auto-style4 {
            width: 109px;
            height: 26px;
        }
        .auto-style5 {
            width: 615px;
            height: 26px;
        }
        .auto-style6 {
            width: 109px;
            height: 27px;
        }
        .auto-style7 {
            width: 615px;
            height: 27px;
        }
        .auto-style8 {
            width: 109px;
            height: 32px;
        }
        .auto-style9 {
            width: 615px;
            height: 32px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Booking Management<br />
        <br />
        Customer Particulars</div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">First Name:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="tbxFirstName" runat="server" Width="207px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbxFirstName" ErrorMessage="*Required Field" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">Last Name:</td>
                <td class="auto-style9">
                    <asp:TextBox ID="tbxLastName" runat="server" Width="207px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbxLastName" ErrorMessage="*Required Field" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Passport No:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="tbxPassportNo" runat="server" Width="207px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tbxPassportNo" ErrorMessage="*Required Field" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Gender:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="tbxGender" runat="server" Width="207px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="tbxGender" ErrorMessage="*Required Field" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Phone Number:</td>
                <td class="auto-style7">
                    <asp:TextBox ID="tbxPhoneNumber" runat="server" Width="207px"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tbxPhoneNumber" ErrorMessage="Invalid phone number" SetFocusOnError="True" ValidationExpression="^\+[1-9]{1}[0-9]{3,14}$" ForeColor="Red"></asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="tbxPhoneNumber" ErrorMessage="*Required Field" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Email Address:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="tbxEmailAddress" runat="server" Width="207px"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="tbxEmailAddress" ErrorMessage="Invalid Email Address" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="Red"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Country:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="tbxCountry" runat="server" Width="207px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="tbxCountry" ErrorMessage="*Required Field" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Nationality:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="tbxNationality" runat="server" Width="207px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="tbxNationality" ErrorMessage="*Required Field" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Street Name:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="tbxStreetName" runat="server" Width="207px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="tbxStreetName" ErrorMessage="*Required Field" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Block:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="tbxBlock" runat="server" Width="207px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="tbxBlock" ErrorMessage="*Required Field" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Unit No:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="tbxUnitNo" runat="server" Width="207px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="tbxUnitNo" ErrorMessage="*Required Field" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Postal Code:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="tbxPostalCode" runat="server" Width="207px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="tbxPostalCode" ErrorMessage="*Required Field" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" OnSelecting="SqlDataSource1_Selecting" ConnectionString="<%$ ConnectionStrings:SWENConnectionString2 %>" SelectCommand="SELECT * FROM [CustomerDetails]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="btnCreate" runat="server" OnClick="btnCreate_Click" Text="Create" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Mainpage.aspx">Main</asp:HyperLink>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
