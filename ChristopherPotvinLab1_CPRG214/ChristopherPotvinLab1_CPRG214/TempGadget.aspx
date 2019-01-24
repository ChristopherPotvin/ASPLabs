<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TempGadget.aspx.cs" Inherits="ChristopherPotvinLab1_CPRG214.TempGadget" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Temperature Conversion</title>
    <link href="Styles/bootstrap.css" rel="stylesheet" />
    <link href="Styles/MainStyleSheet.css" rel="stylesheet" />
    <style type="text/css">
    </style>
</head>
<body style="width: 838px; height: 465px">
    <form id="form1" runat="server">
        <div class="table">
            <h1 class="h1">What&#39;s my temperature?</h1>
            <img alt="Thermometer" class="imageStyle" src="Images/thermo.jpg" /><table class="tablestyle">
                <tr>
                    <td>
                        <asp:Label ID="LblFrom" runat="server" Text="From:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="LblTo" runat="server" Text="To:"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem Selected="True">Fahrenheit</asp:ListItem>
                            <asp:ListItem>Celsius</asp:ListItem>
                            <asp:ListItem>Kelvin</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList2" runat="server">
                            <asp:ListItem Selected="True">Celsius</asp:ListItem>
                            <asp:ListItem>Fahrenheit</asp:ListItem>
                            <asp:ListItem>Kelvin</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="LblTemp" runat="server" Text="What's the temperature?"></asp:Label>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtInputTemp" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Please enter a value</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtInputTemp" ErrorMessage="RangeValidator" ForeColor="Red" MaximumValue="1000" MinimumValue="-1000" SetFocusOnError="True" Type="Double">Please enter a value in the range of -1000 to 1000</asp:RangeValidator>
                        <asp:TextBox ID="txtInputTemp" runat="server" MaxLength="1000"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="templbl">
                        <asp:Label ID="Label2" runat="server" Text="Temperature Conversion:"></asp:Label>
                    </td>
                    <td class="templbl">
                        <asp:Label ID="LblConversion" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnConvert" runat="server" Height="24px" Text="Convert" Width="66px" OnClick="btnConvert_Click" />
                    </td>
                    <td>
                        <asp:Button ID="BtnClear" runat="server" Height="22px" Text="Clear" Width="72px" OnClick="BtnClear_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.6/umd/popper.min.js" integrity="sha384-wHAiFfRlMFy6i5SRaxvfOCifBUQy1xHdJ/yoi7FRNXMRBu5WHdZYu1hA6ZOblgut" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/js/bootstrap.min.js" integrity="sha384-B0UglyR+jN6CkvvICOB2joaf5I4l3gm9GU6Hc1og6Ls7i6U/mkkaduKaBhlAXv9k" crossorigin="anonymous"></script>
</body>
</html>
