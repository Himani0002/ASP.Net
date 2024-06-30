<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1_Dropdown.aspx.cs" Inherits="testASP.Dhruvi_Kriyal._1_Dropdown" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Country with HTML:
        <asp:DropDownList ID="lstItems" runat="server">
            <asp:ListItem Text="India" Value="IN"></asp:ListItem>
            <asp:ListItem Text="Australia" Value="AU"></asp:ListItem>
            <asp:ListItem Text="USA" Value="US"></asp:ListItem>            
        </asp:DropDownList>

        <br />

        Country onLoad:
        <asp:DropDownList ID="lstCountry" runat="server">
        </asp:DropDownList>

        <br />

         States onClick:
        <asp:DropDownList ID="LstStates" runat="server">
        </asp:DropDownList>
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />

        
        <br />

         Names From Text Box:
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:Button ID="btnAddName" runat="server" Text="Add Name" OnClick="btnAddName_Click" />
        <br />
        <asp:DropDownList ID="lstNames" runat="server">
        </asp:DropDownList>
        
    </form>
</body>
</html>
