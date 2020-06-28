<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="adminpage.aspx.cs" Inherits="hadafpish.adminpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div style=" width:1000px;  margin-left:auto;margin-right:auto">
         <div style=" width:1000px;  margin-left:auto;margin-right:auto">
             <asp:Button ID="Button4" runat="server" Text="خروج" BackColor="#0066FF" Height="38px" OnClick="Button4_Click" Width="60px" />
             </div>
        <table style="border: 1px groove #000000; width:500px; margin-left:auto;margin-right:auto">
                <tr>
                    <td colspan="4" align="center" style="border: 1px groove #5D9FE1; background-color: #4A94DD; color: #FFFFFF; font-size: 26px; font-family: 'B Zar';">
                        صفحه مدیریت<br />
                    </td>
                </tr>
               
                <tr>
                    <td dir="rtl" class="auto-style4">
                         <%--<asp:Label ID="Label3" runat="server" Text="<%$ Resources:DashboardText,Username %>" ></asp:Label>--%>
                         <asp:Button ID="Button3" runat="server" Text="جستجو دانشجو" Height="51px" OnClick="Button3_Click" BackColor="Aqua" Font-Bold="True" Font-Size="14pt" />
                    </td>
                    <td>
 <asp:Button ID="Button5" runat="server" Text="دانشجویان ثبت نام نکرده " Height="51px" OnClick="Button5_Click" BackColor="Aqua" Font-Bold="True" Font-Size="14pt" />
                    </td>
                    <td class="auto-style5" dir="rtl">
                        
                         <asp:Button ID="Button2" runat="server" Text="افزودن دانشجو" Height="51px" OnClick="Button2_Click" Width="113px" BackColor="Aqua" Font-Bold="True" Font-Size="14pt" />
                    </td>
                    <td class="auto-style5" dir="rtl">

                        <asp:Button ID="Button1" runat="server" Text="گزارشات" Height="51px" OnClick="Button1_Click" Width="103px" BackColor="Aqua" Font-Bold="True" Font-Size="14pt" />

                    </td>
                </tr>
                </table>
    </div>

</asp:Content>
