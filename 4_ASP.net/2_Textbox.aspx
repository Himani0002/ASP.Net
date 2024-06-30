<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2_Textbox.aspx.cs" Inherits="WebApplication1.textbox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox    ID="txtText" runat="server"
                        Text = "Welcome"

                        BackColor="Pink"
                        ForeColor="Black"

                        BorderColor="#CCCCCC"
                        BorderStyle="Solid"
                        
                        Enabled="true"
                        ReadOnly="false"

                        Font-Bold="false"
                        Font-Italic="false"
                        Font-Strikeout="false"
                        Font-Underline="false"                        
                        Font-Size="10pt"
            
                        Height="20px"
                        Width="150px"

                        ToolTip="Sample Text Box"
                        Visible="true"

                        TextMode="SingleLine"  
                        Wrap="True"></asp:TextBox>
        </div>
        </form>
</body>
</html>
