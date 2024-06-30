<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EMP.aspx.cs" Inherits="WebApplication1.EMP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style type="text/css">
        @import url('https://fonts.googleapis.com/css2?family=Lobster&display=swap');
        .auto-style1 {
            width: 158px;
        }
        .Body{
            font-family: 'Lobster', cursive;
        }
    </style>
</head>
<body bgcolor="#E8DAEF" text="#633974" class="Body">
    <form id="form1" runat="server">
        <br />
        <br />
        <table>
            <tr>
                <td class="auto-style1"><strong>EId</strong></td>
                <td><strong><asp:TextBox ID="TxtEId" runat="server" Width="196px"></asp:TextBox></strong></td>
            </tr>
            <tr>
                <td class="auto-style1"><strong>EName</strong></td>
                <td><strong><asp:TextBox ID="TxtEName" runat="server" Width="196px"></asp:TextBox></strong></td>
            </tr>
             <tr>
                <td class="auto-style1"><strong>ESalary</strong></td>
                <td><strong><asp:TextBox ID="TxtESalary" runat="server" Width="196px"></asp:TextBox></strong></td>
            </tr> <tr>
                <td class="auto-style1"><strong>EHireDate</strong></td>
                <td><strong><asp:TextBox ID="TxtEHireDate" runat="server" Width="196px"></asp:TextBox></strong></td>
            </tr> <tr>
                <td class="auto-style1"><strong>EDeptNo</strong></td>
                <td><strong><asp:TextBox ID="TxtEDeptNo" runat="server" Width="196px"></asp:TextBox></strong></td>
            </tr>
        </table>
    </form>
</body>
</html>
