<%@ Page Title="" Language="C#" MasterPageFile="~/UserHome.master" AutoEventWireup="true" CodeFile="ShoppingCart.aspx.cs" Inherits="ShoppingCart" %>

<%--注册自定义用户组件--%>
<%@ Register Src="~/ShopCart.ascx" TagPrefix="uc1" TagName="ShopCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        * {
            box-sizing: border-box;
        }
        .panel1{
            position:relative;
            top:-25px;
        }
        ul {
            position: relative;
            width: 1012px;
            height: 30px;
            top: -16px;
            background-color: white;
        }

            ul > li {
                position: relative;
                float: left;
                width: 130px;
                height: 30px;
                left: -40px;
                right: -50px;
                margin-right: 0px;
                padding: 0px;
                list-style: none;
                font-family: Microsoft Yahei;
                font-size: 20px;
                font-weight: 500;
                text-align: center;
                background-color: white;
                border-right: 2px solid black;
            }

        li:nth-child(1) {
            width: 75px;
        }

        li:nth-child(2) {
            width: 410px;
        }

        li:nth-child(4) {
            width: 130px;
        }

        li:nth-child(6) {
            width: 110px;
            margin-right: -50px;
            right: -20px;
            border-right: 2px solid transparent;
        }
        .purch{
            position:relative;
            width:50px;
            height:30px;
            top:-43px;
            left:750px;
            font-size:20px;
            background-color:orange;
            border: 1px solid transparent;
        }
        .totalP{
            position:relative;
            top:-40px;
            left:20px;
            font-size:25px;
            color:red;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="headLine">
        <ul>
            <li>
                <span>
                    <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" AutoPostBack="True" />全选
                </span>
            </li>
            <li>商品介绍</li>
            <li>商品单价</li>
            <li>商品数量</li>
            <li>商品总价</li>
            <li>操作</li>
        </ul>
    </div>
    <asp:Panel ID="Panel1" runat="server" Height="440px" ScrollBars="Vertical" Width="1012px" CssClass="panel1">
        <%--<uc1:ShopCart runat="server" id="ShopCart" />--%>
    </asp:Panel>
    <p>
        <asp:Label ID="Label1" runat="server" Text="总价:0.00元" CssClass="totalP"></asp:Label>
        <asp:Button ID="Button1" runat="server" Text="购买" CssClass="purch" OnClick="Button1_Click" />
    </p>
</asp:Content>

