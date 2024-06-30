<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="11_inversedelete.aspx.cs" Inherits="kriyal._11_inversedelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstItems" runat="server" SelectionMode="Multiple" Height="170" Width="100" OnSelectedIndexChanged="lstItems_SelectedIndexChanged">
            <asp:ListItem Text="India"></asp:ListItem>
            <asp:ListItem Text="USA"></asp:ListItem>
            <asp:ListItem Text="UK"></asp:ListItem>
            <asp:ListItem Text="Australia"></asp:ListItem>
            <asp:ListItem Text="West Indies"></asp:ListItem>
            <asp:ListItem Text="UK"></asp:ListItem>
            <asp:ListItem Text="India"></asp:ListItem>
            <asp:ListItem Text="Australia"></asp:ListItem>
            <asp:ListItem Text="UK"></asp:ListItem>
        </asp:ListBox>

        <asp:TextBox ID="txtsearch" runat="server"></asp:TextBox>
        <asp:Button ID="btnResult" Text="Result" runat="server" OnClick="btnResult_Click"/>
        <asp:Button ID="btnSearch" Text="Search" runat="server" OnClick="btnSearch_Click" />

        <br />
        <asp:Label ID="lblMessage" runat="server"></asp:Label>

    </form>
</body>
</html>
