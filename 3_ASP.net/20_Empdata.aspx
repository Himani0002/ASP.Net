<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="20_Empdata.aspx.cs" Inherits="kriyal._20_Empdata" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DropDownList ID="ddlEmployees" runat="server" OnSelectedIndexChanged="ddlEmployees_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>

        <br />
        <br />

        <asp:Label ID="lblEID" runat="server" Text="EID"></asp:Label>
        <asp:TextBox ID="txtEID" runat="server"></asp:TextBox>

        <br />
        <br />
        
    </form>
</body>
</html>
