<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="4_Lable.aspx.cs" Inherits="WebApplication1.Lable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Label ID="Label1" runat="server" 
            
                        Text = "Welcome"

                        BackColor="Pink"
                        ForeColor="#123456"

                        BorderColor="#CCCCCC"
                        BorderStyle="Solid"
                        
                        Enabled="true"
                        ReadOnly="false"

                        Font-Bold="false"
                        Font-Italic="false"
                        Font-Strikeout="false"
                        Font-Underline="false"                        
                        Font-Size="10pt"

                        Height="20"
                        Width="100"

                        ToolTip="Sample Text Box"
                        Visible="true"

                        TextMode="SingleLine"  
                        Wrap="false"
       
            >




        </asp:Label>
        </div>
    </form>
</body>
</html>
