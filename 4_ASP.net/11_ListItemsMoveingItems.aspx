<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="11_ListItemsMoveingItems.aspx.cs" Inherits="WebApplication1.ListItems" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ListItems</title>
</head>
<body bgcolor="Indigo">

    <form id="form1" runat="server">

        
        <asp:TextBox ID="TB1" runat="server"></asp:TextBox>
        <br />
        <br />

        <asp:Button ID="TextBtn1" runat="server" Text="duplicatItmes" Onclick="TextBtn1_Click"/>
        <br />

        <asp:Button ID="SelecteBtn1" runat="server" Text="TextBoxItemsSelecte" Onclick="SeleteBtn1_Click"/>
        <br />
        <br />

        <asp:ListBox ID="LB1" runat="server" Height="150px" Width="150px" Selectionmode = "Multiple" >

            <asp:ListItem Text="C Lang" Value="C"></asp:ListItem>
            <asp:ListItem Text="C++" Value="CPP"></asp:ListItem>
            <asp:ListItem Text="Css" Value="Css"></asp:ListItem>
            <asp:ListItem Text="C#" Value="Cs"></asp:ListItem>
            <asp:ListItem Text="Css" Value="Css"></asp:ListItem>
            <asp:ListItem Text="Js" Value="Js"></asp:ListItem>
            <asp:ListItem Text="Java" Value="Java"></asp:ListItem>
            <asp:ListItem Text="Python" Value="Py"></asp:ListItem>
            <asp:ListItem Text="Css" Value="Css"></asp:ListItem>
            <asp:ListItem Text="Vb.Net" Value="VB"></asp:ListItem>
            <asp:ListItem Text="Css" Value="Css"></asp:ListItem>
            <asp:ListItem Text="PHP" Value="PhP"></asp:ListItem>
            <asp:ListItem Text="Java" Value="Java"></asp:ListItem>

        </asp:ListBox>

    <br />
    <br />
    
    <sapn id="SapnMsg" runat="server" style="color:#fff;font-weight:bold;" ></sapn>

    <br />
    <br />
    
    <asp:Button ID="Btn1" runat="server" Text="DeleteUnSeletedItems" Onclick="Btn1_Click"/>
    
    </form>
</body>
</html>
