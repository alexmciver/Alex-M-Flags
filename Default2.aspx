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
        .auto-style3 {
            margin-right: 2px;
        }
        .auto-style4 {
            margin-left: 147px;
        }
    </style>
</head>
<body style="width: 1336px; margin-left: 0px; margin-top: 0px">
    <form id="form1" runat="server">
    <div class="auto-style2">
    
            <h1 class="auto-style1" style="margin-left: 40px">Alex&#39;s Flags Game</h1>
            <p>
                <strong>This game tests your knowledge of different flags from all around the world! Some flags are easy and some are a bit more challenging </strong></p>
            <br />
    
            <asp:Image ID="flag" runat="server" Height="183px" Width="330px" ImageUrl="https://www.cia.gov/library/publications/the-world-factbook/graphics/flags/large/uk-lgflag.gif" CssClass="auto-style3" />
    
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
        <br />
        <br />
        <asp:Button ID="Next" runat="server" CssClass="auto-style4" PostBackUrl="~/Default2.aspx" Text="Next" Width="90px" />
    </form>
</body>
</html>
