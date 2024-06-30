<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="5_Calcuations.aspx.cs" Inherits="WebApplication1.Calcuations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="black" >
    <form id="form1" runat="server">
        <div>
            Value 1:

            <asp:TextBox Id="txtval1" runat="server"></asp:TextBox>
            <br />

            Value 2:

            <asp:TextBox Id="txtval2" runat="server"></asp:TextBox>
            <br />

            <asp:Button ID="btnAddition" text = "+" onclick="btnAddition_Click" runat="server" />
            <asp:Button ID="btnSubstraction" text = "_" onclick="btnSubstraction_Click" runat="server" />
            <asp:Button ID="btnMultiply" text = "x" onclick="btnMultiply_Click" runat="server" />
            <asp:Button ID="btnDivision" text = "/" onclick="btnDivision_Click" runat="server" />

            <br />

            Result :

            <asp:TextBox ID="txtresult" runat="server"></asp:TextBox>

        </div>

    </form>
</body>
</html>
