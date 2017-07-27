<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default2.aspx.vb" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Virtual Vexologist</title>
    <style type="text/css">
        form1 {
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
        .auto-style8 {
            height: 827px;
        }
        .auto-style10 {
            background-position: 131px 1px;
            width: 94px;
            height: 86px;
            background-image: url('great-britain-flag-1.gif');
            background-repeat: no-repeat;
        }
        .auto-style13 {
            color: #000000;
            text-align: center;
            height: 99px;
        }
        .auto-style14 {
            text-align: center;
            height: 97px;
        }
        .auto-style15 {
            font-size: large;
        }
        .auto-style17 {
            background-position: 131px 1px;
            width: 122px;
            height: 91px;
            background-image: url('great-britain-flag-1.gif');
            background-repeat: no-repeat;
        }
        .auto-style18 {
            text-align: left;
        }
        .auto-style19 {
            font-size: medium;
            color: #3399FF;
        }
        .auto-style20 {
            color: #3399FF;
        }
        </style>
</head>
<body style="width: 1336px; margin-left: 0px; margin-top: 0px">
    <form id="form1" runat="server" autocomplete="on" dir="auto" itemtype="~/wallpapers-light-shinee-backgrounds-animated-colour-background-color-original-shine-picture.jpg" style="background-image: url('wallpapers-light-shinee-backgrounds-animated-colour-background-color-original-shine-picture.jpg')" class="auto-style8">
        <div>
    <div class="auto-style2" itemtype="FreeVector-Multicolor-Background.jpg" style="background-image: url('wallpapers-light-shinee-backgrounds-animated-colour-background-color-original-shine-picture.jpg')">
    
            <h1 class="auto-style13" style="font-family: 'Comic Sans MS'; color: #3366FF;">
                <strong>
                <img alt="gb flag" class="auto-style10" src="great-britain-flag-1.gif" />Virtual Vexologist </strong>
                <img alt="gb flag" class="auto-style10" src="great-britain-flag-1.gif" /></h1>
            <strong property="og:image:type"><h2 class="auto-style14"><span class="auto-style15">&nbsp;<strong property="og:image:type"><img alt="" class="auto-style17" src="world_flags.gif" /></strong>Test your knowledge of different flags from all around the world! Some flags are easy and some are a bit more challenging</span><img alt="" class="auto-style17" src="world_flags.gif" /></h2>
            <h3><em>
                <asp:Label ID="Score" runat="server" Text="Score:"></asp:Label>
&nbsp;</em></h3>
            </strong><br />
    
            <asp:Image ID="flag" runat="server" Height="183px" Width="356px" ImageUrl="https://www.cia.gov/library/publications/the-world-factbook/graphics/flags/large/uk-lgflag.gif" CssClass="auto-style3" />
    
    </div>
        <h3>Which country does this flag belong to?</h3>
        </strong>
        <strong>
            <asp:RadioButton ID="RadioButton1" runat="server" CssClass="auto-style8" />
        </strong>
        <br />
        <strong>
            <asp:RadioButton ID="RadioButton2" runat="server" />
        </strong>
        <br />
        <strong>
            <asp:RadioButton ID="RadioButton3" runat="server" />
        </strong>
        <br />
        <strong>
            <asp:RadioButton ID="RadioButton4" runat="server" />
        </strong>
        <br />
        <br />
        <asp:Button ID="Next" runat="server" CssClass="auto-style4" PostBackUrl="~/Default2.aspx" Text="Next" Width="90px" Font-Bold="True" Font-Names="Comic Sans MS" Font-Size="Medium" />
            <br />
            <div class="auto-style18">
                <h2 class="auto-style20">Best Player</h2>
                <p>
                    <asp:Label ID="NameLabel" runat="server" CssClass="auto-style19" Font-Bold="True" Font-Size="Medium" Text="Player Name:"></asp:Label>
                </p>
                <br />
                <br />
                <br />
            </div>
        </div>
    </form>
</body>
</html>
