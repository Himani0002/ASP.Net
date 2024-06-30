<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="8_TextboxvalueAddInList.aspx.cs" Inherits="WebApplication1.TextboxvalueAddInList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            TextBox Value :

            <asp:TextBox ID="TB" runat="server"></asp:TextBox>

            <br />
            <br />

            <asp:Button ID="BTN" runat="server" OnClick="BTN_Click" Text="Button" />


            <br />
            <br />

            <asp:DropDownList ID="DDL" runat="server"></asp:DropDownList>


        </div>
    </form>
</body>
</html>
