<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #0066FF;
        }
        .auto-style2 {
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1 class="auto-style1">Welcome to Alex&#39;s vexology game</h1>
        <h3 class="auto-style2" style="font-size: large">This game tests your knowledge of different flags from around the world!</h3>
        <h3 style="font-size: large"><strong>Easy Flags</strong></h3>
        <p>
            <asp:Image ID="Image1" runat="server" Height="129px" Width="176px" ImageUrl="https://www.cia.gov/library/publications/the-world-factbook/graphics/flags/large/uk-lgflag.gif" />
        </p>
        <p>
            Which country has this flag?
        </p>
    
    </div>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>United Kingdom </asp:ListItem>
            <asp:ListItem>Ireland </asp:ListItem>
            <asp:ListItem>Scotland </asp:ListItem>
            <asp:ListItem>New Zealand</asp:ListItem>
        </asp:RadioButtonList>
        <p>
            <asp:Image ID="Image2" runat="server" Height="114px" ImageUrl="https://upload.wikimedia.org/wikipedia/en/thumb/c/c3/Flag_of_France.svg/800px-Flag_of_France.svg.png" Width="203px" />
        </p>
        <p>
            &nbsp;Which country has this flag?</p>
        <asp:RadioButtonList ID="RadioButtonList2" runat="server">
            <asp:ListItem>Greece</asp:ListItem>
            <asp:ListItem>Wales</asp:ListItem>
            <asp:ListItem>France</asp:ListItem>
            <asp:ListItem>Venice</asp:ListItem>
        </asp:RadioButtonList>
        <p>
            <asp:Image ID="Image3" runat="server" Height="114px" ImageUrl="https://upload.wikimedia.org/wikipedia/en/thumb/0/05/Flag_of_Brazil.svg/720px-Flag_of_Brazil.svg.png" Width="203px" />
        </p>
        <p>
            Which country has this flag?</p>
        <asp:RadioButtonList ID="RadioButtonList3" runat="server">
            <asp:ListItem>Portugal</asp:ListItem>
            <asp:ListItem>Brazil</asp:ListItem>
            <asp:ListItem>Malaysia</asp:ListItem>
            <asp:ListItem>Spain</asp:ListItem>
        </asp:RadioButtonList>
        <p>
            <asp:Image ID="Image4" runat="server" Height="114px" ImageUrl="https://upload.wikimedia.org/wikipedia/en/thumb/9/9a/Flag_of_Spain.svg/750px-Flag_of_Spain.svg.png" Width="203px" />
        </p>
        <p>
            Which country has this flag?</p>
        <asp:RadioButtonList ID="RadioButtonList4" runat="server">
            <asp:ListItem>Brazil</asp:ListItem>
            <asp:ListItem>Spain </asp:ListItem>
            <asp:ListItem>Venezuela</asp:ListItem>
            <asp:ListItem>Wales</asp:ListItem>
        </asp:RadioButtonList>
        <p>
            <asp:Image ID="Image5" runat="server" Height="114px" ImageUrl="https://upload.wikimedia.org/wikipedia/en/thumb/a/a4/Flag_of_the_United_States.svg/1235px-Flag_of_the_United_States.svg.png" Width="203px" />
        </p>
        <p>
            Which country has this flag?</p>
        <asp:RadioButtonList ID="RadioButtonList5" runat="server">
            <asp:ListItem>United States of America (USA)</asp:ListItem>
            <asp:ListItem>Liberia</asp:ListItem>
            <asp:ListItem>Hawii</asp:ListItem>
            <asp:ListItem>Lisbon </asp:ListItem>
        </asp:RadioButtonList>
        <p>
            <asp:Image ID="Image6" runat="server" Height="114px" ImageUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/a/a2/Flag_of_Russia_%28Kremlin.ru%29.svg/1024px-Flag_of_Russia_%28Kremlin.ru%29.svg.png" Width="203px" />
        </p>
        <p>
            Which country has this flag?</p>
        <asp:RadioButtonList ID="RadioButtonList6" runat="server">
            <asp:ListItem>France </asp:ListItem>
            <asp:ListItem>Russia</asp:ListItem>
            <asp:ListItem>Serbia</asp:ListItem>
            <asp:ListItem>Slovakia</asp:ListItem>
        </asp:RadioButtonList>
    </form>
</body>
</html>