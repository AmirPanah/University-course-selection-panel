<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="stdsearch.aspx.cs" Inherits="hadafpish.stdsearch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style=" width:500px;  margin-left:auto;margin-right:auto">
        <table style="border: 1px groove #000000; width:500px">
                <tr>
                    <td colspan="2" align="center" style="border: 1px groove #5D9FE1; background-color: #4A94DD">
                        <br />
                        <br />
                    </td>
                </tr>
               
                <tr>
                    <td dir="rtl" class="auto-style4">
                         <asp:TextBox ID="tbxUsername" runat="server" CssClass="textbox" MaxLength="20" Font-Size="12pt"></asp:TextBox>
                         <%--<asp:Label ID="Label3" runat="server" Text="<%$ Resources:DashboardText,Username %>" ></asp:Label>--%>
                        
                    </td>
                    <td class="auto-style5" dir="rtl">
                       <asp:Label ID="lblusername" runat="server" Text="شماره دانشجویی" CssClass="font_custom14"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td dir="rtl" class="auto-style6">
                        <%--<asp:Label ID="Label4" runat="server" Text="<%$ Resources:DashboardText,Password %>" CssClass="font_custom14"></asp:Label>--%>
                    </td>
                    <td class="auto-style7" dir="rtl">
                       
                        &nbsp;</td>
                </tr>

            <tr>
                    <td dir="rtl" class="auto-style8">
                        <%--<asp:Label ID="Label4" runat="server" Text="<%$ Resources:DashboardText,Password %>" CssClass="font_custom14"></asp:Label>--%>
                        <asp:Label ID="lblmessage" runat="server"></asp:Label>
                         <asp:Button ID="Button2" runat="server" Text="ورود" OnClick="Button2_Click" style="height: 26px" />
                    </td>
                    <td class="auto-style2">
                       
                        &nbsp;</td>
                </tr>
            </table>
</asp:Content>
