<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="10_Auto_Image.aspx.cs" Inherits="kriyal._10_Auto_Image" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstImages" runat="server" Width="100" Height="180" AutoPostBack="true" OnSelectedIndexChanged="lstImages_SelectedIndexChanged" >
            <asp:ListItem Text="Image 1"  Value="images/1.jpg"></asp:ListItem>
            <asp:ListItem Text="Image 2"  Value="images/2.jpg"></asp:ListItem>
            <asp:ListItem Text="Image 3"  Value="images/3.jpg"></asp:ListItem>
            <asp:ListItem Text="Image 4"  Value="images/4.jpg"></asp:ListItem>
            <asp:ListItem Text="Image 5"  Value="images/5.jpg"></asp:ListItem>
            <asp:ListItem Text="Image 6"  Value="images/6.jpg"></asp:ListItem>
            <asp:ListItem Text="Image 7"  Value="images/7.jpg"></asp:ListItem>
            <asp:ListItem Text="Image 8"  Value="images/8.jpg"></asp:ListItem>
            <asp:ListItem Text="Image 9"  Value="images/9.jpg"></asp:ListItem>
            <asp:ListItem Text="Image 10"  Value="images/10.jpg"></asp:ListItem>
        </asp:ListBox>

        <asp:Image ID="img" runat="server" Width="400" Height="180"/>
    </form>
</body>
</html>
