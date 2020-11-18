<%@ Page Title="" Language="C#" MasterPageFile="~/UserHome.master" AutoEventWireup="true" CodeFile="UserFavorite.aspx.cs" Inherits="UserFavorite" %>

<%@ Register Src="~/UFavorite.ascx" TagPrefix="uc1" TagName="UFavorite" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        * {
            box-sizing: border-box;
        }
        /*样式名字不要用之前出现过的*/
        .Favbody{
            position:relative;
            width:1012px;
            height:520px;
            padding-top:4px;
            padding-left:13px;
            /*background-color:blue;*/
        }
        .Favorite{
            position:relative;
            float:left;
            margin:6px 15px;
            width:210px;
            height:240px;
            background-color:white;
            border: 1px solid black;
        }
        .Favorite:hover{
            border: 2px solid red;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="">
        <%--<uc1:UFavorite runat="server" ID="UFavorite" />--%>
        <asp:Panel ID="Panel1" runat="server" CssClass="Favbody" ScrollBars="Horizontal"></asp:Panel>
    </div>
</asp:Content>

