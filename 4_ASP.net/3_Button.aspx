<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="3_Button.aspx.cs" Inherits="WebApplication1.Btn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server"

                        Text = "Welcome"

                        BackColor="Pink"
                        ForeColor="#CCCCCC"

                        BorderColor="#CCCCCC"
                        BorderStyle="Solid"
                        
                        Enabled="true"
                        ReadOnly="false"

                        Font-Bold="false"
                        Font-Italic="false"
                        Font-Strikeout="false"
                        Font-Underline="false"                        
                        Font-Size="14pt"
            
                        Height="20"
                        Width="100"

                        ToolTip="Sample Text Box"
                        Visible="true"

                        TextMode="SingleLine"  
                        Wrap="true"
       
            />
      
        </div>
    </form>
</body>
</html>
