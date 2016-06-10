<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mainpage.aspx.cs" Inherits="HotelManagementSystem.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Delonix Regia Hotel Management System</title>
    <style type="text/css">

 p.MsoNormal
	{margin-bottom:.0001pt;
	font-size:12.0pt;
	font-family:"Times New Roman",serif;
	        margin-left: 0cm;
            margin-right: 0cm;
            margin-top: 0cm;
        }
        .auto-style1 {
            width: 83%;
        }
        .auto-style2 {
            width: 283px;
        }
        .auto-style3 {
            width: 187px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        
        <p class="MsoNormal">
            <span lang="EN-GB" style="font-size:14.0pt">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Delonix Regia</span><span lang="EN-GB" style="font-size:14.0pt;mso-bidi-font-size:12.0pt"> Hotel Management </span><span lang="EN-GB" style="font-size:14.0pt">System <o:p></o:p>
            </span>
        </p>

        <div>
           <%-- <script type="text/javascript">
                function ShowCurrentTime() {
                var dt = new Date();
                document.getElementById("lblTime").innerHTML = dt.toLocaleTimeString();
                window.setTimeout("ShowCurrentTime()", 1000); // Here 1000(milliseconds) means one 1 Sec  
                }
            </script>--%>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server"></asp:UpdatePanel>
            <ContentTemplate>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    <asp:Timer ID="Timer1" runat="server" Interval ="1000" OnTick="Timer1_Tick"></asp:Timer>
            </ContentTemplate>
            </div>
        <p class="MsoNormal">
            &nbsp;</p>
        <p class="MsoNormal">
            &nbsp;</p>
        <p class="MsoNormal">
            &nbsp;</p>
        <p class="MsoNormal">
            <o:p>Please select function</o:p></p>
        <p class="MsoNormal">
            <o:p></o:p>
        </p>
        <o:p></o:p>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Modules</td>
                <td class="auto-style3">Functions</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Booking Management</td>
                <td class="auto-style3">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/CustomerRegister.aspx">Create New Booking</asp:HyperLink>
                    <br />
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/CustomerDisplay.aspx">Show Guest Records</asp:HyperLink>
                    <br />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Room Status and Staff Management</td>
                <td class="auto-style3">
                    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/RegisterNewStaff.aspx">Create New Staff</asp:HyperLink>
                    <br />
                    <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/DisplayStaff.aspx">Display Staff Record</asp:HyperLink>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Reports</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
