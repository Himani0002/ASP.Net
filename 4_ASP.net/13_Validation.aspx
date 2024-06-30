<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="13_Validation.aspx.cs" Inherits="WebApplication1.Validation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Validation</title>
</head>
<body bgcolor="#D7BDE2">
    <form id="form1" runat="server">
    
        <asp:Label ID="LFN" runat="server" Text="First Name : "></asp:Label>
        <asp:TextBox ID="TFN" runat="server"></asp:TextBox>
        <asp:Label ID="MSGFN" runat="server" ForeColor="Indigo"></asp:Label>

        <br />
        <br />


        <asp:Label ID="LBCTY" runat="server" Text="Country"></asp:Label>
        <asp:DropDownList ID="DDL" runat="server">
            <asp:ListItem Text="Select Country" Value=""></asp:ListItem>
            <asp:ListItem Text="India" Value=""></asp:ListItem>
            <asp:ListItem Text="Uk" Value=""></asp:ListItem>
            <asp:ListItem Text="China" Value=""></asp:ListItem>
            <asp:ListItem Text="Nepal" Value=""></asp:ListItem>
            <asp:ListItem Text="Usa" Value=""></asp:ListItem>
            <asp:ListItem Text="Australia" Value=""></asp:ListItem>
        </asp:DropDownList>

        <br />
        <br />
                
        <asp:CheckBox ID="chkAgree" runat="server" Text="Agree to terms" />
        <asp:Label ID="msgAgree" runat="server" ForeColor="Indigo"></asp:Label>

        

        <asp:Label ID="MSGCTY" runat="server" ForeColor="Indigo"></asp:Label>
        
        <br />
        <br />

        
        
        <asp:Button ID="BTNRegister" runat="server" Text="Register Now" OnClick="BTNRegister_Click" />
    
    </form>
</body>
</html>
