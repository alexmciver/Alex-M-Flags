<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default2.aspx.vb" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Alex's Flag Game</title>
    <style type="text/css">
        .auto-style1 {
            color: #0033CC;
            background-color: #FFFFFF;
        }
        #form1 {
            background-color: #FFFFFF;
            height: 521px;
        }
        .auto-style2 {
            background-color: #FFFFFF;
        }
    </style>
</head>
<body style="width: 1336px; margin-left: 0px; margin-top: 0px">
    <form id="form1" runat="server">
    <div class="auto-style2">
    
            <h1 class="auto-style1" style="margin-left: 40px">Alex&#39;s Flags Game</h1>
            <p>
                <strong>This game tests your knowledge of different flags from around the world!</strong></p>
            <br />
    
            <asp:Image ID="flag" runat="server" Height="162px" Width="293px" ImageUrl="https://www.cia.gov/library/publications/the-world-factbook/graphics/flags/large/uk-lgflag.gif" />
    
    </div>
        <p style="background-color: #FFFFFF">
            Which country has this flag?
        </p>
        <asp:RadioButton ID="RadioButton1" runat="server" />
        <br />
        <asp:RadioButton ID="RadioButton2" runat="server" />
        <br />
        <asp:RadioButton ID="RadioButton3" runat="server" />
        <br />
        <asp:RadioButton ID="RadioButton4" runat="server" />
    </form>
</body>
</html>
