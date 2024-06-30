<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="@_ListBox.aspx.cs" Inherits="WebApplication_A.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <asp:ListBox ID="lstCountries" runat="server" SelectionMode="Multiple" Height="120" Width="100">
            <asp:ListItem Text="India" Value="IN"></asp:ListItem>
            <asp:ListItem Text="Australia" Value="AU"></asp:ListItem>
            <asp:ListItem Text="USA" Value="US"></asp:ListItem>
            <asp:ListItem Text="UK" Value="UK"></asp:ListItem>
            <asp:ListItem Text="South Africa" Value="SA"></asp:ListItem>
            <asp:ListItem Text="West Indies" Value="WI"></asp:ListItem>
        </asp:ListBox>

        <asp:Label ID="lblMessage" runat="server"></asp:Label>

        <br />
        <br />

        <asp:Button ID="btnTotal" runat="server" 
            Text="Get Total Records" OnClick="btnTotal_Click" />
        <asp:Button ID="btnSelectedText" runat="server" 
            Text="Get Selected Text" OnClick="btnSelectedText_Click" />
        <asp:Button ID="btnSelectedIndex" runat="server" 
            Text="Get Selected Index" OnClick="btnSelectedIndex_Click" />
        <asp:Button ID="btnSelectedValue" runat="server" 
            Text="Get Selected Value" OnClick="btnSelectedValue_Click" />
        <asp:Button ID="btnIndexTextValue" runat="server" 
            Text="Get Index + Text + Value" OnClick="btnIndexTextValue_Click" />
        <asp:Button ID="btnAllSelected" runat="server" 
            Text="Get All Selected" OnClick="btnAllSelected_Click" />
        <asp:Button ID="btnSelect2ndItem" runat="server" 
            Text="Select 2nd Item" OnClick="btnSelect2ndItem_Click" />
    </form>
</body>
</html>
