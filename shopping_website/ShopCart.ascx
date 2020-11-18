<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ShopCart.ascx.cs" Inherits="ShopCart" %>
<style>
    * {
        box-sizing: border-box;
    }
    .checkbox{
        position:relative;
        top:-30px;
        left:28px;
    }
    .img{
        position:relative;
        width:80px;
        height:88px;
        top:6px;
        left:58px;
    }
    .cartbody {
        position: relative;
        width: 995px;
        height: 100px;
        margin-top:-12px;
        background-color: transparent;
        /*border:2px solid #f   1775d;*/
    }
    .jiahao{
        position:relative;
        width:25px;
        height:25px;
        top:3px;
        font-size:20px;
        line-height:10px;
        background-color:white;
    }
    .jianhao{
        position:relative;
        width:25px;
        height:25px;
        top:2px;
        padding-bottom:20px;
        font-size:26px;
        text-align:center;
        line-height:15px;
        background-color:white;
    }
    .textbox{
        position:relative;
        width:45px;
        height:28px;
        text-align:center;
        border:2px solid black;
    }
    .information{
        position:relative;
        top:-35px;
        left:65px;
        background-color:transparent;
    }
    .price{
        position:relative;
        top:-30px;
        left:80px;
        font-size:22px;
        color:red;
    }
    .totalprice{
        position:relative;
        top:-119px;
        left:755px;
        font-size:22px;
        color:red;
        z-index:2;
    }
    .splus{
        display:block;
        position:relative;
        top:-88px;
        left:625px;
    }
    .delete{
        position:relative;
        float:right;
        width:70px;
        height:30px;
        top:-120px;
        right:20px;
        font-size:20px;
        outline: none;
        background-color:springgreen;
        border:1px solid #00ff21;
    }
    .delete:hover{
        color:#f10505;
    }
</style>
<div class="cartbody">
    <p>
        <asp:CheckBox ID="CheckBox1" runat="server" CssClass="checkbox" OnCheckedChanged="CheckBox1_CheckedChanged" AutoPostBack="True" OnInit="CheckBox1_CheckedChanged" />
        <asp:Image ID="Image1" runat="server" ImageUrl="~/WareListImg/001.png" CssClass="img" />
        <asp:Label ID="Label1" runat="server" Text="哒哒哒哒哒哒多多多多多多多多多多多多多" CssClass="information" Height="70px" Width="295px"></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="￥250.00" CssClass="price"></asp:Label>
        <span class="splus">
            <asp:Button ID="Button1" runat="server" Text="-" CssClass="jianhao" CausesValidation="False" OnClick="Button1_Click" />
            <asp:TextBox ID="TextBox1" runat="server" CssClass="textbox"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" Text="+" CssClass="jiahao" CausesValidation="False" OnClick="Button2_Click" />
        </span>
        <asp:Label ID="Label3" runat="server" Text="￥250.00" CssClass="totalprice"></asp:Label>
        <asp:Button ID="Button3" runat="server" Text="删除" CssClass="delete" OnClick="Button3_Click" />
    </p>
</div>
