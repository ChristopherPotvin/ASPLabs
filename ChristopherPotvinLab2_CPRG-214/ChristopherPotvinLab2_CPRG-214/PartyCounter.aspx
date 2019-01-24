<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PartyCounter.aspx.cs" Inherits="ChristopherPotvinLab2_CPRG_214.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Current Party Date Results</h1>
        </div>
        <p>
            January 19th!<asp:TextBox ID="txtCount1" runat="server" Height="22px" Width="166px"></asp:TextBox>
        </p>
        <p>
            January 26th!<asp:TextBox ID="txtCount2" runat="server" Height="18px" Width="168px"></asp:TextBox>
        </p>
        <p>
            Febuary 2nd!
            <asp:TextBox ID="txtCount3" runat="server" Height="17px" Width="164px"></asp:TextBox>
        </p>
        <asp:Button ID="BtnReturn1" runat="server" Height="47px" OnClick="BtnReturn1_Click" Text="Back" Width="87px" />
    </form>
</body>
</html>
