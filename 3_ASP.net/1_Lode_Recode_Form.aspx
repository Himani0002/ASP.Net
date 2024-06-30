<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1_Lode_Recode_Form.aspx.cs" Inherits="WebApplication1._1_Emp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="#EBDEF0">
    <form id="form1" runat="server">

        <asp:DropDownList ID="DDL1" runat="server" OnSelectedIndexChanged="DDL1_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
       
        <asp:Button Id="Btn1" runat="server" Onclick="Btn1_Click" Text="DataLode" style="margin-left: 9px" />
    
        <br />
        <br />
        <br />
        <br />
        

        <from runat="server" font-color="#6C3483">
            
            <table>

                    <tr>
                        <td>Id : </td>
                        <td><asp:TextBox ID="txtID" runat="server"></asp:TextBox></td>
                    </tr>
                
                    <tr>
                        <td>Name : </td>
                        <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
                    </tr>    
                
                    <tr>  
                        <td>Salary : </td>
                        <td><asp:TextBox ID="txtSalary" runat="server"></asp:TextBox></td>
                    </tr>   
                
                    <tr>
                        <td>HireDate :</td>
                        <td><asp:TextBox ID="txtHireDate" runat="server"></asp:TextBox></td>

                    </tr>

                    <tr>
                        <td>DeptNo :</td>
                        <td><asp:TextBox ID="txtDeptNo" runat="server"></asp:TextBox></td>
                   </tr>

                </table>
           
            </from>
    </form>
</body>
</html>
