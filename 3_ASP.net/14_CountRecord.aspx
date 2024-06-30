<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="14_CountRecord.aspx.cs" Inherits="kriyal._14_CountRecord" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btnCount" runat="server" Text="Count Record" OnClick="btnCount_Click" />
        <br />
        <br />

        <asp:Label ID="lblMssage" runat="server"></asp:Label>
    </form>
</body>
</html>
