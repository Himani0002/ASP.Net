<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="12_MoveItems.aspx.cs" Inherits="WebApplication1.MoveItems" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

    <asp:ListBox ID="LB1" Height="120px" Width="100px" SelectionMode="Multiple" runat="server"></asp:ListBox>

        <asp:Button ID="Btn1" Onclick="Btn1_Click" runat="server" Text=">" />
        <asp:Button ID="Btn2" Onclick="Btn2_Click" runat="server" Text=">>" />
        <asp:Button ID="Btn3" Onclick="Btn3_Click" runat="server" Text="<" />
        <asp:Button ID="Btn4" Onclick="Btn4_Click" runat="server" Text="<<" />

    <asp:ListBox ID="LB2" Height="120px" Width="100px" SelectionMode="Multiple" runat="server"></asp:ListBox>
    
    </form>
</body>
</html>
