<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PartyPicker.aspx.cs" Inherits="ChristopherPotvinLab2_CPRG_214.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Styles/bootstrap.css" rel="stylesheet" />
    <title></title>
    <style type="text/css">
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="jumbotron jumbotron-fluid" >
  <div class="container">
      <h1 class="text-center">Time to Party!</h1>
      <img src="Images/pexels-photo-1150988.jpg" />
  </div>
</div>
            <h1 class="text-center">Please select a date to ROCK and ROLL!!!</h1>
            <p class="text-center">
                <asp:Calendar ID="Calendar1" runat="server" CssClass="auto-style2" OnDayRender="DayRender" OnSelectionChanged="Calendar1_SelectionChanged">
                    <SelectedDayStyle BackColor="Aqua" />
                </asp:Calendar>
                
            </p>
            <p>
                <asp:Label ID="lblChanged" runat="server" CssClass="auto-style1"></asp:Label>
            </p>
            <p>
                <asp:Button ID="SubmitVote" runat="server" Height="51px" OnClick="SubmitVote_Click" Text="Submit Vote" Width="193px" />
            </p>
        </div>
    </form>
</body>
</html>
