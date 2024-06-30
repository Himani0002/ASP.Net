<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="3DropDown_Lodeing.aspx.cs" Inherits="WebApplication1._3DropDown_Lodeing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DropDown_Lodeing </title>
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Kaushan+Script&display=swap" rel="stylesheet">
    
    <style> 
        .body{
            font-family:'Satisfy';
        }
    </style>
</head>
<body bgcolor="#D7BDE2" class="body">
    <form id="form1" runat="server">
        
        <table style="width: 50%;">
            <tr>
                <td><h4>Country : </h4></td>
                <td> <asp:DropDownList ID="DDL1" runat="server" OnSelectedIndexChanged="DDL1_SelectedIndexChanged" DatavalueField="CId" DatatextField="CName" AutoPostBack="True" AppendDataBoundItems="true">
                    
                     </asp:DropDownList></td>
                
            </tr>
            <tr>
                <td><h4>States : </h4></td>
                <td><asp:DropDownList ID="DDL2" runat="server" OnSelectedIndexChanged="DDL2_SelectedIndexChanged"  DatavalueField="SId" DatatextField="SName"  AutoPostBack="True" AppendDataBoundItems="true">
                    
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td><h4>Citys : </h4></td>
                <td><asp:DropDownList ID="DDL3" runat="server"  DatavalueField="CId" DatatextField="CName" AutoPostBack="True" AppendDataBoundItems="true">
                    </asp:DropDownList></td>

            </tr>
        </table>
    </form>
</body>
</html>
