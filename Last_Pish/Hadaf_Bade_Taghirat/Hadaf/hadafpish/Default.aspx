<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="hadafpish.Default" %>
<%@ Register src="webcontrol/Captcha.ascx" tagname="Captcha" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 82px;
            width: 494px;
        }
        .auto-style2 {
            width: 168px;
        }
        .auto-style3 {
            height: 82px;
            width: 168px;
        }
    .auto-style4 {
        height: 64px;
            width: 494px;
        }
    .auto-style5 {
        height: 64px;
        width: 168px;
    }
    .auto-style6 {
        height: 55px;
            width: 494px;
        }
    .auto-style7 {
        width: 168px;
        height: 55px;
    }
        .auto-style8 {
            width: 494px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style=" width:1000px;  margin-left:auto;margin-right:auto">
       
       <table>
           <tr>
               <td style="width: 166px">

               </td>
               <td>
                    <table style="border: 1px groove #000000; width:500px">
                <tr>
                    <td colspan="2" align="center" style="border: 1px groove #5D9FE1; background-color: #4A94DD;" >
                        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Arabic Typesetting" Font-Size="XX-Large" Text="پیش انتخاب واحد"></asp:Label>
                    </td>
                </tr>
               
                <tr>
                    <td dir="rtl" class="auto-style4">
                         <asp:TextBox ID="tbxUsername" runat="server" CssClass="textbox" MaxLength="20" Font-Size="12pt"></asp:TextBox>
                         <%--<asp:Label ID="Label3" runat="server" Text="<%$ Resources:DashboardText,Username %>" ></asp:Label>--%>
                        
                    </td>
                    <td class="auto-style5" dir="rtl">
                       <asp:Label ID="lblusername" runat="server" Text="نام کاربری" CssClass="font_custom14" Font-Bold="True"></asp:Label>
                        :</td>
                </tr>
                <tr>
                    <td dir="rtl" class="auto-style6">
                        <%--<asp:Label ID="Label4" runat="server" Text="<%$ Resources:DashboardText,Password %>" CssClass="font_custom14"></asp:Label>--%>
                         <asp:TextBox ID="tbxPassword" runat="server" CssClass="textbox" MaxLength="20" TextMode="Password" Font-Size="12pt"></asp:TextBox>
                    </td>
                    <td class="auto-style7" dir="rtl">
                       
                        <asp:Label ID="Label1" runat="server" Text="رمز عبور" CssClass="font_custom14" Font-Bold="True"></asp:Label>
                        :</td>
                </tr>
               <tr>
                    <td dir="rtl" class="auto-style1">
                        <%--<asp:Label ID="Label4" runat="server" Text="<%$ Resources:DashboardText,Password %>" CssClass="font_custom14"></asp:Label>--%>
                        <asp:DropDownList ID="DropDownList1" runat="server"  CssClass="font_custom12" Font-Names="B Nazanin" Font-Size="12pt">
                            <asp:ListItem Value="1">کارشناسی ناپیوسته کامپیوتر</asp:ListItem>
                            <asp:ListItem Value="2">کارشناسی پیوسته کامپیوتر</asp:ListItem>
                            <asp:ListItem Value="3">فناوری اطلاعات</asp:ListItem>
                            <asp:ListItem Value="4">کاردانی نرم افزار</asp:ListItem>
                            <asp:ListItem Value="5">کاردانی پیوسته الکتروتکنیک-برق صنعتی</asp:ListItem>
                            <asp:ListItem Value="6">کاردانی قدرت</asp:ListItem>
                            <asp:ListItem Value="7">کاردانی الکترونیک عمومی</asp:ListItem>
                            <asp:ListItem Value="8">کاردانی ناپیوسته الکترونیک</asp:ListItem>
                            <asp:ListItem Value="9">کاردانی پیوسته الکتروتکنیک-تاسیسات الکتریکی</asp:ListItem>
                            <asp:ListItem Value="10">کارشناسی ناپیوسته کنترل</asp:ListItem>
                            <asp:ListItem Value="11">کارشناسی ناپیوسته الکترونیک</asp:ListItem>
                            <asp:ListItem Value="12">کارشناسی ناپیوسته قدرت</asp:ListItem>
                            <asp:ListItem Value="13">کارشناسی ناپیوسته مهندسی برق-شبکه های انتقال و توزیع</asp:ListItem>
                            <asp:ListItem Value="14">کارشناسی پیوسته الکترونیک</asp:ListItem>
                            <asp:ListItem Value="15">کارشناسی پیوسته قدرت</asp:ListItem>
                            <asp:ListItem Value="16">کارشناسی پیوسته صنایع</asp:ListItem>
                            <asp:ListItem Value="17">کاردانی معماری</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style3" dir="rtl">
                       
                        <asp:Label ID="Label2" runat="server" Text="نام رشته تحصیلی " CssClass="font_custom14" Font-Bold="True"></asp:Label>
                    </td>
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
               </td>
               <td style="width: 300px; font-family: 'B Nazanin'; font-size: 18px;" dir="rtl">
                       <asp:Label ID="lblusername0" runat="server" Text="به نکات زیر توجه کنید" Font-Bold="True" Font-Size="Large"></asp:Label>
                       :<br />
                    <br />
                   1- نام کاربری --&gt; شماره دانشجویی<br />
                   2- رمز عبور--&gt; کد ملی<br />
                   3- در انتخاب&nbsp; &quot;رشته تحصیلی&quot; خود دقت فرمایید.<br />
                   4- تنها یکبار امکان پیش انتخاب واحد وجود دارد.</td>
           </tr>
       </table>
       
     </div>
</asp:Content>
