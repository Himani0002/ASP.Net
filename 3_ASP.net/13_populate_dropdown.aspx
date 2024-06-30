<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="13_populate_dropdown.aspx.cs" Inherits="kriyal._13_populate_dropdown" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DropDownList ID="ddlDepartments" runat="server">

        </asp:DropDownList>

        <br />
        <asp:Button ID="btnTotal" runat="server" Text="Load Records" OnClick="btnTotal_Click" />
    </form>
</body>
</html>
