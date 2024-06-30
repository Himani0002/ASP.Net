<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmpFrom.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <title>Display Data from Database in HTML Table in asp.net</title>
    
    <style type="text/css">

            body { font-family: Arial;font-size: 10pt; }

            table {
                border: 1px solid #ccc;
                border-collapse: collapse;
            }

            table th {
                background-color: #F7F7F7;
                color: #333;
                font-weight: bold;
            }

            table th, table td {
                padding: 5px;
                border-color: #ccc;
            }
    </style>
</head>
    
  <body bgcolor="#E8DAEF" text="#633974">

    <form id="form2" runat="server">
        <div style="margin-left: auto; margin-right: auto; text-align: center;">
                <asp:PlaceHolder id="PlaceHolder1" runat="server"></asp:PlaceHolder>
        </div>
    </form>
</body>
</html>

