<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="10_Image.aspx.cs" Inherits="WebApplication1.Image" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="Indigo">
    <form id="form1" runat="server">
        <asp:Image ID="Img1" runat="server" 
            ImageUrl="~/Asp.net/Img6.jpg" width="400px" Height="400px" />
        
        <br />
        
        <asp:Image ID="Img2" runat="server" />
        <br />

        <asp:DropDownList ID="DDL" AutoPostBack="true" runat="server"
            OnSelectedIndexChanged="DDL_SelectedIndexChanged">
            <asp:ListItem Text="Image 1" Value="~/Asp.net/Img1.jpg"></asp:ListItem>
            <asp:ListItem Text="Image 2" Value="~/Asp.net/Img2.jpg"></asp:ListItem>
            <asp:ListItem Text="Image 3" Value="~/Asp.net/Img3.jpg"></asp:ListItem>
            <asp:ListItem Text="Image 4" Value="~/Asp.net/Img4.jpg"></asp:ListItem>
            <asp:ListItem Text="Image 5" Value="~/Asp.net/Img5.jpg"></asp:ListItem>
            <asp:ListItem Text="Image 6" Value="~/Asp.net/Img6.jpg"></asp:ListItem>
        </asp:DropDownList>
        
        <br />

        <asp:Image ID="Img3" runat="server" width="400px" Height="400px" />

    </form>
</body>
</html>
