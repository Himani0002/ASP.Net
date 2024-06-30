<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="17_Employees_data.aspx.cs" Inherits="kriyal._17_Employees_data" %>

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

        <asp:Label ID="lblEName" runat="server" Text="EName"></asp:Label>
        <asp:TextBox ID="txtEName" runat="server"></asp:TextBox>

        <br />
        <br />

        <asp:Label ID="lblSalary" runat="server" Text="ESalary"></asp:Label>
        <asp:TextBox ID="txtESalary" runat="server"></asp:TextBox>

        <br />
        <br />

        <asp:Label ID="lblEDOB" runat="server" Text="EDOB"></asp:Label>
        <asp:TextBox ID="txtEDOB" runat="server"></asp:TextBox>

        <br />
        <br />

        <asp:Label ID="lblECity" runat="server" Text="ECity"></asp:Label>
        <asp:TextBox ID="txtECity" runat="server"></asp:TextBox>

        <br />
        <br />

        <asp:Button ID="btnInsert" Text="Insert" runat="server" OnClick="btnInsert_Click"/>
        <asp:Button ID="btnUpdate" Text="Update" runat="server" OnClick="btnUpdate_Click"/>
        <asp:Button ID="btnDelete" Text="Delete" runat="server" OnClick="btnDelete_Click"/>
    </form>
</body>
</html>
