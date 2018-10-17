<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TempService.aspx.cs" Inherits="WebForms.TempService" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 64%;
        }
        .auto-style2 {
            height: 32px;
        }
        .auto-style3 {
            height: 32px;
            width: 179px;
        }
        .auto-style4 {
            width: 179px;
        }
        .auto-style5 {
            height: 32px;
            width: 73px;
        }
        .auto-style6 {
            width: 73px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label1" runat="server" Text="Temperature (Fahrenheit) :"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtFaf" runat="server" Width="130px"></asp:TextBox>
                    </td>
                    <td class="auto-style2">
                        <asp:Button ID="btnConvert" runat="server" OnClick="btnConvert_Click" Text="Convert To Celsius" />
                    </td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label2" runat="server" Text="Temperature (Celsius) :"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtCel" runat="server" Width="130px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
        </div>
    </form>
</body>
</html>
