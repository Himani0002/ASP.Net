<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="$_Dropdown_Transfer.aspx.cs" Inherits="WebApplication_A.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <asp:ListBox ID="lstSource" Width="100" Height="120" SelectionMode="Multiple" runat="server">
            <asp:ListItem Text="India"></asp:ListItem>
            <asp:ListItem Text="Australia"></asp:ListItem>
            <asp:ListItem Text="USA"></asp:ListItem>
            <asp:ListItem Text="UK"></asp:ListItem>
            <asp:ListItem Text="South Africa"></asp:ListItem>
            <asp:ListItem Text="West Indies"></asp:ListItem>
        </asp:ListBox>

        <asp:Button ID="btnFirst" runat="server" Text="|<<" OnClick="btnFirst_Click" />
        <asp:Button ID="btnPrevious" runat="server" Text="<<" OnClick="btnPrevious_Click" />
        <asp:Button ID="btnNext" runat="server" Text=">>" OnClick="btnNext_Click" />
        <asp:Button ID="btnLast" runat="server" Text=">>|" OnClick="btnLast_Click" />

        <asp:ListBox ID="lstDestination" Width="100" Height="120" SelectionMode="Multiple" runat="server"></asp:ListBox>
   
    </form>
</body>
</html>
