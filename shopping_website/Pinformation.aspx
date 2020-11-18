<%@ Page Title="" Language="C#" MasterPageFile="~/UserHome.master" AutoEventWireup="true" CodeFile="Pinformation.aspx.cs" Inherits="Pinformation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        * {
            box-sizing: border-box;
        }
        .infbody{
            position:relative;
            width:100%;
            height:100%;
            /*background-color: aqua;*/
            border: 1px solid transparent;
        }
        .headtitle{
            position:relative;
            margin:5px 425px;
            font-family:KaiTi;
            font-size:35px;
            font-weight:500;
        }
        p{
            position:relative;
            margin-bottom:-10px;
            padding-left:320px;
            font-family:KaiTi;
            font-size:25px;
            font-weight:500;
        }
        .textBox{
            position:relative;
            margin-left:5px;
            font-size:20px;
            border: 2px solid black;
        }
        .address{
            vertical-align: -15px;
            font-weight:600;
        }
        .Mbutton{
            position:relative;
            margin:40px 40px;
            font-size:20px;
        }
        .auto-style11 {
            left: -5px;
            top: 5px;
        }
        .auto-style12 {
            position: relative;
            margin-left: 5px;
            border: 2px solid black;
            left: 0px;
            top: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="infbody">
        <h3 class="headtitle">基本信息</h3>
        <p>
            账号:<asp:TextBox ID="TextBox1" runat="server" Height="30px" Width="250px" CssClass="textBox"></asp:TextBox>
        </p>
        <p>
            昵称:<asp:TextBox ID="TextBox2" runat="server" Height="30px" Width="250px" CssClass="textBox" ></asp:TextBox>
        </p>
        <p>
            电话:<asp:TextBox ID="TextBox3" runat="server" Height="30px" Width="250px" CssClass="textBox"></asp:TextBox>
        </p>
        <p>
            性别:<asp:TextBox ID="TextBox4" runat="server" Height="30px" Width="250px" CssClass="textBox"></asp:TextBox>
        </p>
        <p>
            生日:<asp:TextBox ID="TextBox5" runat="server" Height="30px" Width="250px" CssClass="textBox"></asp:TextBox>
        </p>
        <p>
            收货地址:<asp:TextBox ID="TextBox6" runat="server" Height="70px" Width="350px" CssClass="textBox address" TextMode="MultiLine"></asp:TextBox>
        </p>
        <p class="auto-style11">
            <asp:Button ID="Button1" runat="server" Text="修改" Height="35px" Width="80px" BackColor="#00FF99" CssClass="Mbutton" OnClick="Button1_Click"/>
            <asp:Button ID="Button2" runat="server" Text="保存" Height="35px" Width="80px" BackColor="#00FF99" CssClass="Mbutton" OnClick="Button2_Click" />
        </p>
    </div>
</asp:Content>

