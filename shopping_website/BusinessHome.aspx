<%@ Page Title="" Language="C#" MasterPageFile="~/MasterBusiness.master" AutoEventWireup="true" CodeFile="BusinessHome.aspx.cs" Inherits="BusinessHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        *{
            box-sizing: border-box;
        }
        .auto-style6 {
            width: 100%;
            height: 100%;
/*            border:2px solid red;*/

        }
        .auto-style7 {
            height: 280px;
/*            background-color:chartreuse*/
        }
        .auto-style8 {
            height: 38px;
/*            background-color:aquamarine;*/
        }
        .auto-style9 {
            width: 75%;
            height: 90px;
/*            background-color:blueviolet;*/
        }
        .auto-style10 {
            /*height: 215px;
            width: 373px;*/
            background-color:#dddcdc;
            background-repeat: no-repeat; 
            border:28px solid transparent;
            border-image: url("/images/border.png") 30 30 round;
/*            border:28px solid blue;*/
        }
        .auto-style11 {
            width: 20%;
            height: 280px;
        }
        .auto-style12 {
            width: 40%;
/*            background-color:cyan;*/
            padding-left:20px;
            height:  280px;
        }
         .auto-style13 {
             border-left:4px solid #999999;
            height:  280px;
        }
         .lab1{
             width:100%;
             height:80%;
             font-size:25px;
             text-align:center;
             background-color:aqua;
             margin-top:0px;
             margin-left:15px;
             padding-top:15px;
         }
         .lab2{
             width:80%;
             height:80%;
             font-size:25px;
             text-align:center;
             background-color:springgreen;
             margin-top:0px;
             margin-left:25px;
             padding-top:15px;
         }
         .lab3{
             width:100%;
             height:80%;
             font-size:25px;
             text-align:center;
             background-color:crimson;
             margin-top:0px;
             margin-left:15px;
             padding-top:15px;
         }
         .lab4{
             width:80%;
             height:80%;
             font-size:25px;
             text-align:center;
             background-color:coral;
             margin-top:0px;
             margin-left:25px;
             padding-top:15px;
         }
         .textlab{
             padding-bottom:10px;
         }
         .tip{
             width:25%;
             padding-left:90px;
         }
        .auto-style14 {
            width: 25%;
            padding-left: 90px;
            height: 50px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="width: 100%; height: 625px; background-color: white;padding-left:10px;margin-left:5px;">
        <table class="auto-style6">
            <tr>
                <td class="auto-style9">
                    <table style="border: 3px solid #FF0000; width:100%; height:100px">
                        <tr>
                            <td class="auto-style11">
                                <asp:Image ID="Image1" runat="server" Height="50%" ImageUrl="~/images/头像.jpg" Width="100%" />
                            </td>
                            <td class="auto-style12">
                                <asp:Label ID="Label2" runat="server" Font-Size="Smaller" Text="店铺ID:XXXXXXXXX"></asp:Label>
                                <br />
                                <asp:Label ID="Label3" runat="server" Font-Size="Smaller" Text="店铺名称:易购超市"></asp:Label>
                                <br />
                                <asp:Label ID="Label4" runat="server" Font-Size="Smaller" Text="上次登录时间:2020年10月31日"></asp:Label>
                                <br />
                                <asp:Label ID="Label5" runat="server" Font-Size="Smaller" Text="发货地址:"></asp:Label>
                                <br />
                                <asp:Label ID="Label6" runat="server" Font-Size="Smaller" Text="XXXXXXXXXXXXXXXX"></asp:Label>
                            </td>
                            <td class="auto-style13">
                                <table style="width: 100%; height: 90%">
                                    <tr>
                                        <td>
                                            <div class="lab1">
                                                今日访客:
                                                <br />
                                                <asp:Label ID="Label7" runat="server" Text="123人" ForeColor="White"></asp:Label>

                                            </div>
                                        </td>
                                        <td>
                                            <div class="lab2">今日交易金额:
                                                <br />
                                                <asp:Label ID="Label8" runat="server" Text="123人" ForeColor="White"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="lab3">今日订单数:
                                                <br />
                                                <asp:Label ID="Label9" runat="server" Text="123人" ForeColor="White"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="lab4">已过账金额:
                                                <br />
                                                <asp:Label ID="Label10" runat="server" Text="123人" ForeColor="White"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
                <td class="auto-style7">
                    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="250px" Width="340px">
                        <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                        <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                        <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                        <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                        <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                        <WeekendDayStyle BackColor="#CCCCFF" />
                    </asp:Calendar>
                </td>
            </tr>
            <tr>
                <td class="auto-style8" colspan="2">
                    <table>
                        <tr>
                            <td>
                                <asp:Image ID="Image2" runat="server" Height="32px" ImageUrl="~/images/温馨提示.png" Width="44px" /></td>
                            <td class="textlab">
                                <asp:Label ID="Label11" runat="server" Text="温馨提示" ForeColor="#0099FF"></asp:Label></td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td class="auto-style10" colspan="2">
                    <table style="width:93%;height:100%;padding-left:60px">
                        <tr>
                            <td class="tip">
                                <asp:Label ID="Label12" runat="server" Font-Size="X-Large" Text="订单&amp;商品"></asp:Label>
                            </td>
                            <td class="tip">
                                <asp:Label ID="Label13" runat="server" Font-Size="X-Large" Text="促销活动"></asp:Label>
                            </td>
                            <td class="tip">
                                <asp:Label ID="Label14" runat="server" Font-Size="X-Large" Text="售后处理"></asp:Label>
                            </td>
                            <td class="tip">
                                <asp:Label ID="Label15" runat="server" Font-Size="X-Large" Text="用户违规"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="tip">
                                <asp:Label ID="Label16" runat="server" Font-Size="Large" Text="待付款订单(2)"></asp:Label>
                            </td>
                            <td class="tip">
                                <asp:Label ID="Label17" runat="server" Font-Size="Large" Text="预备促销(0)"></asp:Label>
                            </td>
                            <td class="tip">
                                <asp:Label ID="Label18" runat="server" Font-Size="Large" Text="待处理工单(2)"></asp:Label>
                            </td>
                            <td class="tip">
                                <asp:Label ID="Label19" runat="server" Font-Size="Large" Text="一般违规(2)"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="tip">
                                <asp:Label ID="Label20" runat="server" Font-Size="Large" Text="待发货订单(2)"></asp:Label>
                            </td>
                            <td class="tip">
                                <asp:Label ID="Label21" runat="server" Font-Size="Large" Text="正在进行的促销(2)"></asp:Label>
                            </td>
                            <td class="tip">
                                <asp:Label ID="Label22" runat="server" Font-Size="Large" Text="待退款(2)"></asp:Label>
                            </td>
                            <td class="tip">
                                <asp:Label ID="Label23" runat="server" Font-Size="Large" Text="严重违规(2)"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style14">
                                <asp:Label ID="Label24" runat="server" Font-Size="Large" Text="已售罄商品(2)"></asp:Label>
                            </td>
                            <td class="auto-style14">
                                <asp:Label ID="Label25" runat="server" Font-Size="Large" Text="已过期促销(2)"></asp:Label>
                            </td>
                            <td class="auto-style14">
                                <asp:Label ID="Label26" runat="server" Font-Size="Large" Text="待退货(2)"></asp:Label>
                            </td>
                            <td class="auto-style14">
                                <asp:Label ID="Label27" runat="server" Font-Size="Large" Text="黑名单用户(2)"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

