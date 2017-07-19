<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default2.aspx.vb" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Alex's Flag Game</title>
    <style type="text/css">
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
        .auto-style5 {
            text-align: left;
            color: #0000FF;
            width: 1231px;
            margin-left: 200px;
        }
        .auto-style7 {
            color: #FF3300;
        }
        .auto-style8 {
            margin-top: 3px;
        }
    </style>
</head>
<body style="width: 1336px; margin-left: 0px; margin-top: 0px">
    <form id="form1" runat="server" autocomplete="on" dir="auto" itemtype="~/FreeVector-Multicolor-Background.jpg">
    <div class="auto-style2">
    
            <h1 class="auto-style5">
                <strong>Alex&#39;s Flags Game</strong></h1>
               <strong property="og:image:type">
            <h2 class="auto-style7">This game tests your knowledge of different flags from all around the world! Some flags are easy and some are a bit more challenging</h2>
            <h3>
                <asp:Label ID="Label1" runat="server" Text="Time"></asp:Label>
                :
                <asp:Button ID="Button1" runat="server" CssClass="auto-style8" Height="28px" Text="Start" Width="54px" />
            </h3>
            <p class="auto-style7">
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <asp:Timer ID="Timer1" runat="server" Enabled="False" Interval="1000">
                </asp:Timer>
            </p>
            </strong><br />
    
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
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
