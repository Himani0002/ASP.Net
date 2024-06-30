<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Populate_Dropdown .aspx.cs" Inherits="WebApplication1.Database_connection2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <asp:DropDownList ID="DDL1" runat="server"></asp:DropDownList>

        <asp:Button ID="BTN1" runat="server" Text="Load Departments" OnClick="BTN1_Click" />
    
    </form>
</body>
</html>
