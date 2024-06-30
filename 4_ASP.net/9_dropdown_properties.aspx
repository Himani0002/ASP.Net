<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="9_dropdown_properties.aspx.cs" Inherits="WebApplication1._9_dropdown_properties" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            
            Countries :
            <asp:DropDownList ID="DDl" runat="server">

                <asp:ListItem Text="Select Country " Value =""></asp:ListItem>
                <asp:ListItem Text="Usa" Value =""></asp:ListItem>
                <asp:ListItem Text="Nepal" Value =""></asp:ListItem>
                <asp:ListItem Text="China" Value =""></asp:ListItem>
                <asp:ListItem Text="Uk" Value =""></asp:ListItem>
                <asp:ListItem Text="England" Value =""></asp:ListItem>

            </asp:DropDownList>

        <br />
        <br />


        <sapn id="SapnMsg" runat="server" style="color:indigo;font-weight:bold;" ></sapn>
        
        <br />
        <br />

        <asp:Button ID="BtnTotal" runat="server" Onclick ="BTotal_Click" Text="Find Total" />
        <asp:Button ID="BtnGetSelected" runat="server" Text="Get Selected Item" OnClick="BtnGetSelected_Click" />
        <asp:Button ID="BtnGetSelectedIndex" runat="server" Text="Get Selected Index" Onclick="BtnGetSelectedIndex_Click"/>
        <asp:Button ID="BtnRemoveSelected" runat="server" Text="Remove Selected" OnClick="BtnRemoveSelected_Click" />
        <asp:Button ID="BtnRemoveAll" runat="server" Text="Remove All" Onclick="BtnRemoveAll_Click"/>
        
        <br />
        <br />

        Add Index : 

        <asp:TextBox ID="TxtIndex"  runat="server"></asp:TextBox>
        <asp:Button ID="BtnRemoveByIndex" runat="server" Text="Remove by Index" Onclick="BtnRemoveByIndex_Click" />

    </form>
</body>
</html>
