<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerDisplay.aspx.cs" Inherits="HotelManagementSystem.CustomerDisplay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>All Customer List</div>
        <br />
        <asp:GridView ID="GridView2" runat="server" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDeleting="Gridview2_RowDeleting" OnRowCancelingEdit="GridView2_RowCancelingEdit" OnRowEditing="GridView2_RowEditing" OnRowUpdating="GridView2_RowUpdating" OnRowDataBound="GridView2_RowDataBound" AllowPaging="True" OnPageIndexChanging="GridView2_PageIndexChanging">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ButtonType="Link" ShowEditButton="True" />
                <asp:TemplateField ShowHeader="False">
                    <FooterTemplate>
                        <asp:TextBox ID="tbxSearchbox" runat="server"></asp:TextBox>
                        <asp:Button ID="btnSearch" runat="server" Text="Search" />
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" OnClientClick="return confirm('Are you sure you want to delete this guest profile?');" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Guestid">
                    <EditItemTemplate>
                        <asp:TextBox ID="tbxeGuestid" runat="server" ReadOnly="True" Text='<%# Bind("Guestid") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblGuestid" runat="server" Text='<%# Bind("Guestid") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="First Name">
                    <EditItemTemplate>
                        <asp:TextBox ID="tbxeFirstname" runat="server" Text='<%# Bind("Firstname") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblFirstname" runat="server" Text='<%# Bind("Firstname") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Last Name">
                    <EditItemTemplate>
                        <asp:TextBox ID="tbxeLastname" runat="server" Text='<%# Bind("Lastname") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblLastname" runat="server" Text='<%# Bind("Lastname") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Passport No">
                    <EditItemTemplate>
                        <asp:TextBox ID="tbxePassportno" runat="server" Text='<%# Bind("Passportno") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblPassportNo" runat="server" Text='<%# Bind("Passportno") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Gender">
                    <EditItemTemplate>
                        <asp:TextBox ID="tbxeGender" runat="server" Text='<%# Bind("Gender") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblGender" runat="server" Text='<%# Bind("Gender") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Phone Number">
                    <EditItemTemplate>
                        <asp:TextBox ID="tbxePhoneNumber" runat="server" Text='<%# Bind("Phonenumber") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblPhoneNumber" runat="server" Text='<%# Bind("Phonenumber") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Email Address">
                    <EditItemTemplate>
                        <asp:TextBox ID="tbxeEmailaddress" runat="server" Text='<%# Bind("Emailaddress") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblEmailAddress" runat="server" Text='<%# Bind("Emailaddress") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Country">
                    <EditItemTemplate>
                        <asp:TextBox ID="tbxeCountry" runat="server" Text='<%# Bind("Country") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblCountry" runat="server" Text='<%# Bind("Country") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Nationality">
                    <EditItemTemplate>
                        <asp:TextBox ID="tbxeNationality" runat="server" Text='<%# Bind("Nationality") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblNationality" runat="server" Text='<%# Bind("Nationality") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Streetname">
                    <EditItemTemplate>
                        <asp:TextBox ID="tbxeStreetname" runat="server" Text='<%# Bind("Streetname") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblStreetname" runat="server" Text='<%# Bind("Streetname") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Block">
                    <EditItemTemplate>
                        <asp:TextBox ID="tbxeBlock" runat="server" Text='<%# Bind("Block") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblBlock" runat="server" Text='<%# Bind("Block") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Unit No">
                    <EditItemTemplate>
                        <asp:TextBox ID="tbxeUnitno" runat="server" Text='<%# Bind("Unitno") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblUnitno" runat="server" Text='<%# Bind("Unitno") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Postal Code">
                    <EditItemTemplate>
                        <asp:TextBox ID="tbxePostalcode" runat="server" Text='<%# Bind("Postalcode") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblPostalCode" runat="server" Text='<%# Bind("Postalcode") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <p>
            <asp:TextBox ID="tbxSearchbox" runat="server" placeholder="Search" OnTextChanged="tbxSearchbox_TextChanged" ></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
        </p>
        <p>
            <asp:Button ID="btnExport" runat="server" OnClick="btnExport_Click" Text="Export" />
        </p>
        <p style="margin-left: 360px">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Mainpage.aspx">Main</asp:HyperLink>
        </p>
    </form>
</body>
</html>
