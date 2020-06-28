<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Captcha.ascx.cs" Inherits="OnlineMagWeb.Dashboard.WebControls.Captcha" %>

<table border="0" cellpadding="0" cellspacing="5" >
    
    <tr>
        <td style="font-size: 10pt; height: 16px">
            <asp:Image ID="imgCaptcha" runat="server" Height="92px" Width="305px" /></td>
    </tr>
    <tr>
        <td style="font-size: 10pt; height: 16px">
            <asp:TextBox ID="txtCaptcha" runat="server"
                CssClass="textbox"
                Width="298px">
            </asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="font-size: 10pt; height: 16px">
            <asp:Label ID="lblCMessage" runat="server" CssClass="font_custom14"></asp:Label></td>
    </tr>
    <tr>
        <td style="font-size: 10pt; height: 16px" align="center">
            <asp:Button ID="btnCSubmit" runat="server" CssClass="greenButton"
                Text="ورود" OnClick="btnSubmit_Click" />
        </td>
    </tr>
</table>
