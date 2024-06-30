<%@ Page Language="C#" AutoEventWireup="true" CodeFile="00_label.aspx.cs" Inherits="_00_Controls_Properties_00_label" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">             
<head runat="server">                                   
    <title></title>
</head>                                                 
<body>                                                 
    <form id="form1" runat="server">                                     
    <div>     
    

    <asp:Label  ID="txtName"                            

                Text="My Value"                     

                Enabled="true"                          

                BackColor="White"                       
                ForeColor="Black"                       

                BorderStyle="Solid"                     
                BorderWidth="1"                     
                BorderColor="Black"                         

                Font-Bold="false"                       
                Font-Italic="false"                     
                Font-Underline="false"                                 
                Font-Strikeout="false"                      
                Font-Overline="false"               
                        
                Font-Names="Arial"                      
                Font-Size="Medium"                      

                Height="25px"                       
                Width="300px"                       

                ToolTip="This is a label"           
                
                Visible="true"                      

                runat="server">     
        </asp:Label>
      
    </div>
    </form>
</body>
</html>
