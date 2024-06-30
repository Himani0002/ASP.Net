<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="6_ClickEvent.aspx.cs" Inherits="WebApplication1.ClickEvent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ClilckEvent</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

             <asp:Button ID="Btnsave" Text="Show Message"  OnClick="Btnsave_Click"  runat="server" ></asp:Button>
             <asp:Button ID="Btnclear" Text="Clear Message"  OnClick="Btnclear_Click"  runat="server" ></asp:Button>
        <br />
             <asp:Textbox ID ="txtMsg"  runat="server" ></asp:Textbox>


        </div>
    </form>
</body>
</html>
