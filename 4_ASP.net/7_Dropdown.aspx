<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="7_Dropdown.aspx.cs" Inherits="WebApplication1.Longin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            Country without value :

            <asp:DropDownList ID="lstCountry1" runat="server">

                <asp:ListItem Text="Select Country"></asp:ListItem>
                <asp:ListItem Text="Usa"></asp:ListItem>
                <asp:ListItem Text="La"></asp:ListItem>
                <asp:ListItem Text="Chaina"></asp:ListItem>
                <asp:ListItem Text="Japan"></asp:ListItem>
                <asp:ListItem Text="Australia"></asp:ListItem>

            </asp:DropDownList>
            
            <br />
            <br />


            Country with value :

            <asp:DropDownList ID="lsrCountry2" runat="server">

                <asp:ListItem Text="Select Country" value="1"></asp:ListItem>
                <asp:ListItem Text="Usa" value="2"></asp:ListItem>
                <asp:ListItem Text="La" value="3"></asp:ListItem>
                <asp:ListItem Text="Chaina" value="4"></asp:ListItem>
                <asp:ListItem Text="Japan" Value="5"></asp:ListItem>
                <asp:ListItem Text="Australia" Value="6"></asp:ListItem>

            </asp:DropDownList>
            

            <br />
            <br />

            Country without value OnLoad :
            <asp:DropDownList ID="lstCountry3" runat="server"></asp:DropDownList>
            
            <br />
            <br />

            Country with value OnLoad :
            
            <asp:DropDownList ID="lstCountry4" runat="server"></asp:DropDownList>
            

        </div>
    </form>
</body>
</html>
