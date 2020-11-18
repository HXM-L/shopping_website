<%@ Page Title="" Language="C#" MasterPageFile="~/UserHome.master" AutoEventWireup="true" CodeFile="UserRefund.aspx.cs" Inherits="UserOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        * {
            box-sizing: border-box;
        }

        .refundbody {
            position: relative;
            width: 100%;
            height: 100%;
            /*background-color: aqua;*/
            border: 1px solid transparent;
        }

        .menuDIV {
            position: relative;
            width: 100%;
            height: 31px;
            color: black;
            font-size: 25px;
            background-color: #CCCCCC;
        }

        .menuCSS {
            position: absolute;
            top: -1px;
            color: black;
        }

        .gridview {
            position: relative;
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="refundbody">
        <div class="menuDIV">
            <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" RenderingMode="Table" StaticEnableDefaultPopOutImage="False" CssClass="menuCSS" ForeColor="Black" OnMenuItemClick="Menu1_MenuItemClick">
                <Items>
                    <asp:MenuItem Text="退款记录" Value="退款记录" Selected="True"></asp:MenuItem>
                </Items>
                <StaticMenuItemStyle HorizontalPadding="8px" />
                <StaticMenuStyle Width="150px" />
                <StaticSelectedStyle BackColor="White" />
            </asp:Menu>
        </div>
        <div class="gridview">
            <asp:Panel ID="Panel1" runat="server" ScrollBars="Horizontal" Width="1010px">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AllowPaging="True" AllowSorting="True" CellPadding="4" ForeColor="#333333" GridLines="None" HorizontalAlign="Left" PageSize="7">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="orderID" HeaderText="订单号">
                            <ControlStyle Width="100px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="userID" HeaderText="用户ID" />
                        <asp:BoundField DataField="shopID" HeaderText="商家ID" />
                        <asp:BoundField DataField="orderTotalPrice" HeaderText="订单总价" />
                        <asp:BoundField DataField="shipAddress" HeaderText="收货地址" />
                        <asp:BoundField DataField="payMethod" HeaderText="付款方式" />
                        <asp:BoundField DataField="payDate" HeaderText="付款日期" />
                        <asp:BoundField DataField="signDate" HeaderText="签收日期" />
                        <asp:BoundField DataField="tranStatus" HeaderText="交易状态" />
                    </Columns>
                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                    <SortedAscendingCellStyle BackColor="#FDF5AC" />
                    <SortedAscendingHeaderStyle BackColor="#4D0000" />
                    <SortedDescendingCellStyle BackColor="#FCF6C0" />
                    <SortedDescendingHeaderStyle BackColor="#820000" />
                </asp:GridView>
            </asp:Panel>
        </div>
    </div>
</asp:Content>

