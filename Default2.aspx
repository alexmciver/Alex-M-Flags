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
        .auto-style6 {
            width: 1024px;
            height: 860px;
        }
    </style>
</head>
<body style="width: 1336px; margin-left: 0px; margin-top: 0px">
    <form id="form1" runat="server" autocomplete="on" dir="auto" itemtype="~/FreeVector-Multicolor-Background.jpg">
    <div class="auto-style2">
    
            <h1 class="auto-style5">
                <strong>Alex&#39;s Flags Game</strong></h1>
            <asp:Menu ID="Menu1" runat="server" BackColor="#CCCCCC" BorderColor="#CCCCCC" BorderStyle="Groove" CssClass="icon" DynamicHorizontalOffset="2" EnableTheming="True" Font-Names="Verdana" Font-Size="Medium" ForeColor="#000000" StaticSubMenuIndent="10px">
                <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
                <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <DynamicMenuStyle BackColor="#B5C7DE" />
                <DynamicSelectedStyle BackColor="#507CD1" />
                <Items>
                    <asp:MenuItem NavigateUrl="~/Default2.aspx" Text="Guess the flag" Value="Guess the flag"></asp:MenuItem>
                </Items>
                <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
                <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <StaticSelectedStyle BackColor="#507CD1" />
            </asp:Menu>
            <asp:Menu ID="Menu2" runat="server" BackColor="#CCCCCC" BorderColor="#CCCCCC" BorderStyle="Groove" CssClass="icon" DynamicHorizontalOffset="2" EnableTheming="True" Font-Names="Verdana" Font-Size="Medium" ForeColor="#000000" StaticSubMenuIndent="10px">
                <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
                <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <DynamicMenuStyle BackColor="#B5C7DE" />
                <DynamicSelectedStyle BackColor="#507CD1" />
                <Items>
                    <asp:MenuItem NavigateUrl="~/map countries.aspx" Text="Guess the country on the map" Value="Guess the country on the map"></asp:MenuItem>
                </Items>
                <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
                <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <StaticSelectedStyle BackColor="#507CD1" />
            </asp:Menu>
               <strong property="og:image:type">
            <h2>This game tests your knowledge of different flags from all around the world! Some flags are easy and some are a bit more challenging</h2>
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
