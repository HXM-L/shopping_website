<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UFavorite.ascx.cs" Inherits="UFavorite" %>
<style>
    .img {
        position: relative;
        width: 105px;
        height: 110px;
        margin: 6px 48px;
    }

    .Fprice {
        display: block;
        font-size: 20px;
        color: red;
    }

    .Faddcart {
        position: relative;
        width:100px;
        top: -15px;
        left: 10px;
        background: url(images/购物车1.png) no-repeat left; /*图片路径*/
        background-size: 15px 15px;
        border: 0px solid transparent;
        outline: none;
    }
    .Fdelete{
        position: relative;
        width:95px;
        top: -15px;
        left: 0px;
        background: url(images/收藏夹.png) no-repeat left; /*图片路径*/
        background-size: 16px 16px;
        border: 0px solid transparent;
        outline: none;
    }
    .Faddcart:hover{
        color:orangered;
    }
    .Fdelete:hover{
        color:orangered;
    }
</style>
<div class="Favorite">
    <asp:Image ID="Image1" runat="server" ImageUrl="~/WareListImg/001.png" CssClass="img" />
    <asp:Label ID="Label1" runat="server" Text="￥250.00" CssClass="Fprice"></asp:Label>
    <asp:Label ID="Label2" runat="server" Text="哒哒哒哒多多多多"></asp:Label>
    <p>
        <asp:Button ID="Button1" runat="server" Text="加入购物车" CssClass="Faddcart" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="移出收藏" CssClass="Fdelete" OnClick="Button2_Click" />
    </p>
</div>
