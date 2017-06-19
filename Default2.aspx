<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default2.aspx.vb" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
            <asp:Image ID="flag" runat="server" Height="129px" Width="176px" ImageUrl="https://www.cia.gov/library/publications/the-world-factbook/graphics/flags/large/uk-lgflag.gif" />
    
    </div>
        <p>
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
