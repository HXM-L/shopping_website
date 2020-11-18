<%@ Page Title="" Language="C#" MasterPageFile="~/MasterBusiness.master" AutoEventWireup="true" CodeFile="AchievementManage.aspx.cs" Inherits="AchievementManage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        * {
            box-sizing: border-box;
        }

        .menuborder {
            position:relative;
            top:-30px;
            border: 0px;
            outline: none;
            cursor: pointer;
            border-color: transparent;
            border: none;
        }

        .data {
            margin-top: 10px;
            margin-left: 20px;
            font-size: 15px;
        }

        .addButton {
            position: relative;
            right: 180px;
            outline: none;
        }

        .gridview {
            position: relative;
            left: 3px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width: 100%; height: 625px; background-color: white">
        <div style="background-color: #CCCCCC;height:31px;">
            <asp:Menu ID="Menu1" runat="server" BackColor="#CCCCCC" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="0px" DisappearAfter="200" Orientation="Horizontal" RenderingMode="Table" Width="500px" CssClass="menuborder" ForeColor="#333333" OnMenuItemClick="Menu1_MenuItemClick">
                <Items>
                    <asp:MenuItem Text="全部销售记录" Value="0" Selected="True"></asp:MenuItem>
                </Items>
                <StaticHoverStyle Width="50px" />
                <StaticMenuItemStyle BackColor="#CCCCCC" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="0px" HorizontalPadding="20px" Width="20px" />
                <StaticMenuStyle BackColor="#CCCCCC" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="0px" Width="20px" HorizontalPadding="0px" />
                <StaticSelectedStyle BackColor="White" BorderColor="White" BorderStyle="None" />
            </asp:Menu>
        </div>
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">
                <div style="padding: 7px; text-align: center; vertical-align: middle; padding-right: 200px">
                    <asp:Button ID="Button3" runat="server" BackColor="#FF6600" BorderColor="White" Height="35px" Text="添加新项" Width="65px" CssClass="addButton" />
                    <asp:Label runat="server" Text="请选择" Font-Size="Smaller"></asp:Label>
                    <asp:DropDownList runat="server" Font-Size="Medium">
                        <asp:ListItem>订单号</asp:ListItem>
                        <asp:ListItem>用户ID</asp:ListItem>
                    </asp:DropDownList>
                    <input id="Text1" type="text" placeholder="请输入...." style="border: 2px solid #FF0000; width: 500px; height: 40px; margin: auto; outline: none;" />
                    <input id="Button1" type="button" value="搜索" style="width: 60px; height: 40px; vertical-align: bottom; margin: auto; background-color: #5da7fb; outline: none; border: none; font-family: 宋体; font-size: x-large; position: relative; right: 7px;" />
                </div>
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" Font-Size="Large" CssClass="data gridview" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" PageSize="15" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowDeleting="GridView1_RowDeleting">
                    <Columns>
                        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True">
                            <HeaderStyle Width="100px" />
                        </asp:CommandField>
                        <asp:BoundField DataField="ID" HeaderText="记录ID" />
                        <asp:BoundField DataField="comID" HeaderText="商品ID">
                        </asp:BoundField>
                        <asp:BoundField DataField="comName" HeaderText="商品名称">
                        </asp:BoundField>
                        <asp:BoundField DataField="purchPrice" HeaderText="进货价">
                        </asp:BoundField>
                        <asp:BoundField DataField="salePrice" HeaderText="售卖价">
                        </asp:BoundField>
                        <asp:BoundField DataField="saleSurplus" HeaderText="售卖数量">
                        </asp:BoundField>
                        <asp:BoundField DataField="purchSurplus" HeaderText="进货数量">
                        </asp:BoundField>
                        <asp:BoundField DataField="comSurplus" HeaderText="剩余量">
                        </asp:BoundField>
                        <asp:BoundField DataField="profitAmount" HeaderText="盈利金额">
                        </asp:BoundField>
                        <asp:BoundField DataField="tranDate" HeaderText="交易日期" />
                    </Columns>
                    <EditRowStyle Font-Size="Medium" Height="20px" HorizontalAlign="Center" VerticalAlign="Middle" Width="10px" Wrap="False" />
                    <EmptyDataRowStyle Font-Size="Medium" Height="20px" HorizontalAlign="Center" VerticalAlign="Middle" Width="20px" Wrap="False" />
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" Font-Size="Large" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" Width="50px" Wrap="False" />
                    <RowStyle ForeColor="#000066" Font-Size="Medium" Wrap="False" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#007DBB" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#00547E" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Shopping_platformConnectionString %>" SelectCommand="SELECT * FROM [order_table]"></asp:SqlDataSource>
            </asp:View>
        </asp:MultiView>
    </div>
</asp:Content>

