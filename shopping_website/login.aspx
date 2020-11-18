<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>登录</title>
    <style>
        * {
            box-sizing: border-box;
        }

        body {
            width: 100%;
            height: 100%;
            min-width: 800px;
            text-align: center;
            background-image: url(images/6.jpg);
            background-size: 101%;
        }

        .logo {
            position: relative;
            width: 100px;
            height: 105px;
            margin-top: 0px;
            margin-left: -90%;
        }


        .auto-style1 {
            position: relative;
            width: 450px;
            height: 300px;
            margin: 60px auto;
            font-size: larger;
            border: 2px solid black;
        }

        .auto-style2 {
            width: 81px;
            height: 55px;
            text-align: right;
        }

        .auto-style3 {
            width: 230px;
            height: 40px;
        }


        .auto-style4 {
            width: 230px;
            height: 32px;
            border: 2px solid black;
        }

        .auto-style5 {
            width: 98px;
            text-align: left;
        }

        .auto-style6 {
            font-family: KaiTi;
            font-size: 50px;
            width: 430px;
            height: 50px;
        }

        a {
            color: blue;
            /*text-decoration:solid;*/
        }

            a:hover {
                color: red;
                text-decoration: underline;
            }

        .auto-style8 {
            width: 200px;
            height: 60px;
        }

        .auto-style9 {
            width: 230px;
            height: 51px;
        }

        .auto-style10 {
            width: 98px;
            text-align: left;
            height: 51px;
        }

        .auto-style11 {
            width: 81px;
            height: 51px;
            text-align: right;
        }

        .auto-style12 {
            height: 2px;
        }

        .tipName {
            position:relative;
            width: 228px;
            height: 23px;
            top:-259px;
            left:644px;
            background-color: transparent;
        }
        .tipPWD{
            position:relative;
            width: 228px;
            height: 23px;
            top:-238px;
            left:644px;
            background-color: transparent;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ImageButton CssClass="logo" ID="ImageButton1" runat="server" Height="103px" ImageUrl="~/images/logo.png" Width="100px" />
        </div>
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style6" colspan="3">易购平台</td>
                </tr>
                <tr>
                    <td class="auto-style2">账号:</td>
                    <td class="auto-style3">
                        <%--<input id="Text1" class="auto-style4" type="text" /></td>--%>
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style4"></asp:TextBox>
                    </td>
                    <td class="auto-style5">
                        <%--<asp:HyperLink ID="HyperLink1" runat="server">注册</asp:HyperLink>--%>
                        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">注册</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">密码:</td>
                    <td class="auto-style3">
                        <%--<input id="Password1" class="auto-style4" type="password" />--%>
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style4" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="auto-style5">
                        <%--<asp:HyperLink ID="HyperLink2" runat="server">忘记密码</asp:HyperLink>--%>
                        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">忘记密码</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11"></td>
                    <td class="auto-style9">
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" Width="236px">
                            <asp:ListItem Selected="True">用户</asp:ListItem>
                            <asp:ListItem>商家</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    <td class="auto-style10"></td>
                </tr>
                <tr>
                    <td class="auto-style8" colspan="3">
                        <table style="width: 100%;">
                            <tr>
                                <th></th>
                                <td>
                                    <asp:Button ID="Button1" runat="server" Text="重置" Height="35px" Width="55px" BackColor="#00FF99" BorderColor="#99FFCC" OnClick="Button1_Click" />
                                </td>
                                <td>
                                    <asp:Button ID="Button2" runat="server" Text="登录" Height="35px" Width="55px" BackColor="#00FF99" BorderColor="#99FFCC" OnClick="Button2_Click" ValidationGroup="ValidataGroup1" />
                                </td>
                                <th>&nbsp;</th>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            <div class="tipName">
                <p>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="账号不能为空!!" ForeColor="Red" Font-Size="Medium" CssClass="" ValidationGroup="ValidataGroup1"></asp:RequiredFieldValidator>
                </p>
                
            </div>
            <div class="tipPWD">
                <p>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="密码不能为空!!" ForeColor="Red" Font-Size="Medium" CssClass="" ValidationGroup="ValidataGroup1"></asp:RequiredFieldValidator>
                </p>
            </div>
        </div>
    </form>
</body> 
</html>
