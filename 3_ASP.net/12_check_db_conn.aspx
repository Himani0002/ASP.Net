<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="12_check_db_conn.aspx.cs" Inherits="kriyal._12_check_db_conn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btnCheckDbCon" runat="server" Text="Open DB Connection" OnClick="btnCheckDbCon_Click" />
        <br />
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
    </form>
</body>
</html>
