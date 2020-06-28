<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="adminsearch.aspx.cs" Inherits="hadafpish.adminsearch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div style="background-color: #4D95DD; width: 1022px; height: 45px; color: #FFFFFF; font-family: 'B Zar'; font-size: 20px;">
        &nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </div>
    <div style="background-color: #FFFFFF; width: 1022px; height: 32px;" dir="rtl">
  
    </div>
    <div dir="rtl">
        <table>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="نام رشته تحصیلی"></asp:Label>
                        <br />
                    <br />
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
                    
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="گزارش" />
                    <br />
                    
                </td>
                <td>
                     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" >
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                
                
                 <asp:BoundField DataField="CoursName" HeaderText="نام درس" >
                     <ItemStyle HorizontalAlign="Center" Width="200px" />
                        </asp:BoundField>
                <asp:BoundField DataField="dd" HeaderText="تعداد " >
                     <ItemStyle HorizontalAlign="Center" Width="50 px" />
                        </asp:BoundField>

                 
                
            </Columns>
           <%-- <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" Height="30px" CssClass="gridHeader" HorizontalAlign="Center" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" Height="30px"/>
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />--%>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
                </td>
                <td>
  
                     <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" >
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                
                
                 <asp:BoundField DataField="stdid" HeaderText="شماره دانشجویی" >
                     <ItemStyle HorizontalAlign="Center" Width="200px" />
                        </asp:BoundField>
               

                 
                
            </Columns>
           <%-- <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" Height="30px" CssClass="gridHeader" HorizontalAlign="Center" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" Height="30px"/>
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />--%>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
  
                </td>
            </tr>
        </table>
       
    </div>
</asp:Content>
