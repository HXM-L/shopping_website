<%@ Page Language="C#" AutoEventWireup="true" CodeFile="registert.aspx.cs" Inherits="registert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>注册</title>
    <style>
        * {
            box-sizing: border-box;
        }

        body {
            width: 100%;
            height: 100%;
            min-width: 800px;
            text-align: center;
            background-image: url(images/13.png);
            background-size: 101%;
        }

        .logo {
            position: relative;
            width: 63px;
            height: 58px;
            margin-top: 0px;
            margin-left: -90%;
        }


        .lab1 {
            position: relative;
            margin: auto;
            top: -17px;
            Font-Size: 23px;
            text-align: center;
            z-index: 1;
        }

        .auto-style1 {
            width: 95%;
            position: relative;
            left: 13px;
            top: 0px;
        }

        .auto-style2 {
            width: 304px;
            text-align: left;
            height: 30px;
        }

        .auto-style3 {
            height: 30px;
            width: 279px;
            border-color: #000000;
            border-width: 2px;
            font-size: medium;
            font-weight: 500;
        }


        /* 头像*/
        .auto-style5 {
            position:relative;
            height: 135px;
            width: 135px;
            margin: auto;
            left:50px;
            border-radius: 50%;
            border: 2px solid black;
            background-size: cover;
            background-repeat: no-repeat;
            background-position: center;
        }


        .auto-style6 {
            width: 50px;
            height: 30px;
            text-align: center;
        }

        .auto-style7 {
            position: relative;
            margin: auto;
            top: 10px;
            width: 73%;
            height: 34px;
            left: 0px;
        }

        .auto-style9 {
            margin-left: 0px;
        }

        .auto-style10 {
            width: 430px;
            text-align: left;
            height: 30px;
        }

        .auto-style11 {
            width: 290px;
        }

        .auto-style12 {
            width: 290px;
            text-align: left;
            height: 30px;
        }

        .checkPWD {
            position: relative;
            width: 205px;
            height: 28px;
            top: 208px;
            left: 545px;
            background-color: transparent;
            z-index: 1;
        }

        .auto-style13 {
            border-color: #000000;
            border-width: 2px;
        }

        .checkTELL {
            position: relative;
            width: 205px;
            height: 28px;
            top: 272px;
            left: 545px;
            background-color: transparent;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ImageButton CssClass="logo" ID="ImageButton1" runat="server" Height="103px" ImageUrl="~/images/logo.png" Width="100px" />
            <div class="checkPWD" id="testD" runat="server">
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="密码与确认密码不一致!!!" Font-Size="Medium" ForeColor="#FF3300" ControlToCompare="TextBox3" ControlToValidate="TextBox4" ValidationGroup="ValidataGroup1" Display="Dynamic"></asp:CompareValidator>
            </div>
            <div class="checkTELL">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="手机号格式不正确!!" ControlToValidate="TextBox5" Display="Dynamic" Font-Size="Medium" ForeColor="#FF3300" ValidationExpression="^1[3|4|5|7|8][0-9]{9}$" ValidationGroup="ValidataGroup1"></asp:RegularExpressionValidator>
            </div>
            <div style="height: 580px; width: 670px; margin: -75px auto; background-color: #FFFFFF; position: relative; border: 1px solid transparent">
                <div style="border: 3px solid #FF0000; height: 535px; width: 630px; margin: 20px auto; background-color: #FFFFFF; position: relative; padding-right: 40px; font-weight: 700">
                    <asp:Label CssClass="lab1" ID="Label1" runat="server" BackColor="White" Enabled="False" Height="28px" Text="基本信息" Width="100px" Font-Overline="False"></asp:Label>
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style10">账号:</td>
                            <td class="auto-style12" rowspan="5">
                                <%--<div class="auto-style5" runat="server" id="head_portrait">
                                </div>--%>
                                <asp:Image ID="Image1" runat="server" CssClass="auto-style5" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style10">
                                <%--<input id="Text1" class="auto-style3" style="border-color: #000000; border-width: 2px" type="text" />--%>
                                <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style3"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style10">昵称:</td>
                        </tr>
                        <tr>
                            <td class="auto-style10">
                                <%--<input id="Text2" class="auto-style3" style="/*border-color: #000000; border-width: 2px*/" type="text" />--%>
                                <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style3"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style10">密码:</td>
                        </tr>
                        <tr>
                            <td class="auto-style10">
                                <%--<input id="Text3" class="auto-style3" style="border-color: #000000; border-width: 2px" type="password" />--%>
                                <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style3" TextMode="Password"></asp:TextBox>
                            </td>
                            <td class="auto-style11">
                                <table style="width: 100%;">
                                    <tr>
                                        <td>
                                            <asp:DropDownList ID="DropDownList1" runat="server" Height="28px" Width="235px" Style="border-color: black; border-width: 2px;" CssClass="auto-style9" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
                                                <asp:ListItem Selected="True">头像1</asp:ListItem>
                                                <asp:ListItem>头像2</asp:ListItem>
                                                <asp:ListItem>头像3</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style10">确认密码:</td>
                            <td class="auto-style12">性别:</td>
                        </tr>
                        <tr>
                            <td class="auto-style10">
                                <%--<input id="Text4" class="auto-style3" style="border-color: #000000; border-width: 2px" type="password" />--%>
                                <asp:TextBox ID="TextBox4" runat="server" CssClass="auto-style3" TextMode="Password"></asp:TextBox>
                            </td>
                            <td class="auto-style12">
                                <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                                    <asp:ListItem Selected="True">男</asp:ListItem>
                                    <asp:ListItem>女</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style10">手机号:</td>
                            <td class="auto-style12">账户类型:</td>
                        </tr>
                        <tr>
                            <td class="auto-style10">
                                <%--<input id="Text5" class="auto-style3" style="/*border-color: #000000; border-width: 2px*/" type="text" />--%>
                                <asp:TextBox ID="TextBox5" runat="server" CssClass="auto-style3"></asp:TextBox>
                            </td>
                            <td class="auto-style12">
                                <asp:RadioButtonList ID="RadioButtonList2" runat="server" RepeatDirection="Horizontal">
                                    <asp:ListItem Selected="True">普通用户</asp:ListItem>
                                    <asp:ListItem>商家</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style10">常用地址:</td>
                        </tr>
                        <tr>
                            <td class="auto-style2" colspan="2">
                                <%--<textarea id="TextArea1" class="auto-style4" name="S1" style="border-color: #000000; border-width: 2px"></textarea>--%>
                                <asp:TextBox ID="TextBox6" runat="server" CssClass="auto-style3" Height="61px" TextMode="MultiLine" Width="595px" Font-Bold="True" Font-Size="Large"></asp:TextBox>
                            </td>
                        </tr>

                    </table>
                    <table class="auto-style7">
                        <tr>
                            <td class="auto-style6">
                                <asp:Button ID="Button1" runat="server" Font-Bold="True" Height="37px" Text="登录" Width="50px" OnClick="Button1_Click" />
                            </td>
                            <td class="auto-style6">
                                <asp:Button ID="Button2" runat="server" Font-Bold="True" Height="38px" Text="重置" Width="50px" OnClick="Button2_Click" />
                            </td>
                            <td class="auto-style6">
                                <asp:Button ID="Button3" runat="server" Font-Bold="True" Height="38px" Text="注册" Width="50px" OnClick="Button3_Click" ValidationGroup="ValidataGroup1" />
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
