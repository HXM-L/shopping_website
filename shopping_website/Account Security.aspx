<%@ Page Title="" Language="C#" MasterPageFile="~/UserHome.master" AutoEventWireup="true" CodeFile="Account Security.aspx.cs" Inherits="Account_Security" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        * {
            box-sizing: border-box;
        }

        .mainbody {
            position: relative;
            width: 100%;
            height: 100%;
            background-color: aqua;
            border: 1px solid transparent;
        }
        .text{
            position:relative;
            top:200px;
            left:310px;
            font-size:35px;
        }
        .Abutton{
            position:relative;
            width:120px;
            height:30px;
            top:300px;
            left:360px;
            margin-right:100px;
            font-size:20px;
            background-color:orange;
            border: 1px solid transparent;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="mainbody">
        <h3 class="text">当前账号安全指数:☆☆☆☆☆</h3>
        <p>
            <asp:Button ID="Button1" runat="server" Text="注销账号" CssClass="Abutton" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="注册新账号" CssClass="Abutton" OnClick="Button2_Click" />
        </p>
    </div>
</asp:Content>

