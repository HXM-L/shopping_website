<%@ Page Title="" Language="C#" MasterPageFile="~/MasterBusiness.master" AutoEventWireup="true" CodeFile="ModifyInformation.aspx.cs" Inherits="ModifyInformation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        * {
            box-sizing: border-box;
        }

        .background {
            background: url(./images/信息修改.png) no-repeat;
            background-size: 100% 96%;
            opacity: 0.9;
        }

        .auto-style6 {
            width: 60%;
            height: 325px;
            margin: 100px auto;
            font-size: 20px;
            font-weight: normal;
        }

        .auto-style7 {
            width: 118px;
        }

        .button {
            position: relative;
            top: -68px;
            left: 400px;
            margin-right: 300px;
        }
        .auto-style9 {
            width: 276px;
        }
        .auto-style10 {
            width: 109px;
        }
        .textBis{
            font-size:23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="width: 100%; height: 625px; background-color: white; position: relative; top: -10px" class="background">
        <h3 style="position: relative; left: 500px; top: 70px; font-family: 宋体; font-size: 35px; font-weight: 900;">商店基本信息</h3>
        <table class="auto-style6">
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label2" runat="server" Text="商店ID:"></asp:Label>

                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox1" runat="server" Height="30px" Width="200px" CssClass="textBis"></asp:TextBox>
                </td>
                <td class="auto-style10">
                    <asp:Label ID="Label1" runat="server" Text="法人姓名:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Height="30px" Width="200px" CssClass="textBis"></asp:TextBox>
                </td>

            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label5" runat="server" Text="商店名称:"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox3" runat="server" Height="30px" Width="200px" CssClass="textBis"></asp:TextBox>
                </td>
                <td class="auto-style10">
                    <asp:Label ID="Label6" runat="server" Text="联系电话:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server" Height="30px" Width="200px" CssClass="textBis"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label9" runat="server" Text="注册填日期:"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox5" runat="server" Height="30px" Width="200px" CssClass="textBis"></asp:TextBox>
                </td>
                <td class="auto-style10">
                    <asp:Label ID="Label10" runat="server" Text="商店地址:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox7" runat="server" Height="60px" Width="300px" CssClass="textBis"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label13" runat="server" Text="客服电话:"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox6" runat="server" Height="30px" Width="200px" CssClass="textBis"></asp:TextBox>
                </td>
                <td class="auto-style10">
                </td>
                <td>
                </td>
            </tr>
        </table>
        <asp:Button ID="Button1" runat="server" Height="40px" Text="修改" Width="85px" BackColor="Lime" CssClass="button" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Height="40px" Text="保存" Width="85px" BackColor="Lime" CssClass="button" OnClick="Button2_Click" />
    </div>
</asp:Content>

