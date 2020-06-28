<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ok.aspx.cs" Inherits="hadafpish.ok" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 346px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width:1022px" dir="rtl">
        <table>
            <tr>
                <td class="auto-style1"></td>
                <td>
                     <asp:Label ID="Label1" runat="server" Text="پیش انتخاب واحد شما با موفقیت ثبت شده است" Font-Bold="True" Font-Size="16pt" Font-Strikeout="False" ForeColor="Red" Font-Names="B Nazanin"></asp:Label>
                </td>
                <td></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;&nbsp;&nbsp;
                    <br />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" BackColor="#33CCFF" Font-Bold="True" Font-Names="B Nazanin" Font-Size="16pt" Height="41px" OnClick="Button1_Click" Text="دریافت کارت ورود به جلسه" Width="263px" />
&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td></td>
            </tr>
            <tr>
                <td colspan="3">
                    <br />
                    <br />
                    قابل توجه دانشجویان گرامی:<br />
                    جهت پرینت از پبش انتخاب واحد خویش، به صفحه اول سامانه پیش انتخاب واحد مراجعه کرده، نام کاربری و رمز را وارد نموده و پس از ورود با استفاده از Ctrl+P از پیش انتخاب واحد خود پرینت بگیرید.</td>
            </tr>
        </table>
       
    </div>
</asp:Content>
