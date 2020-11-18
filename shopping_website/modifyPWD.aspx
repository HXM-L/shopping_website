<%@ Page Language="C#" AutoEventWireup="true" CodeFile="modifyPWD.aspx.cs" Inherits="registert" %>

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

        .modyfypwd {
            position: relative;
            width: 205px;
            height: 28px;
            text-align: left;
            top: 60px;
            left: 230px;
            background-color: transparent;
            z-index: 1;
        }

        .txtsty {
            font-size: 23px;
            width: 200px;
            height: 30px;
            border: 2px solid black;
        }

        .modbutton {
            position: relative;
            width: 70px;
            height: 30px;
            font-size: 23px;
            top: 400px;
            margin-right:80px;
            margin-left:60px;
            z-index: 5;
        }

        .checkPWD {
            position: relative;
            width: 235px;
            height: 28px;
            top: 262px;
            left: 745px;
            background-color: transparent;
            z-index: 1;
        }
        .checkTELL {
            position: relative;
            width: 235px;
            height: 28px;
            top: 98px;
            left: 725px;
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
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="密码与确认密码不一致!!!" Font-Size="Medium" ForeColor="#FF3300" ControlToCompare="TextBox4" ControlToValidate="TextBox5" ValidationGroup="ValidataGroup1" Display="Dynamic"></asp:CompareValidator>
            </div>
            <div class="checkTELL">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="手机号格式不正确!!" ControlToValidate="TextBox2" Display="Dynamic" Font-Size="Medium" ForeColor="#FF3300" ValidationExpression="^1[3|4|5|7|8][0-9]{9}$" ValidationGroup="ValidataGroup1">
                </asp:RegularExpressionValidator>
            </div>
            <div style="height: 580px; width: 670px; margin: -65px auto; background-color: #FFFFFF; position: relative; border: 1px solid transparent">
                <div class="modyfypwd">
                    <p>
                        账号:<asp:TextBox ID="TextBox1" runat="server" CssClass="txtsty"></asp:TextBox>
                    </p>
                    <p>
                        手机号:<asp:TextBox ID="TextBox2" runat="server" CssClass="txtsty"></asp:TextBox>
                    </p>
                    <p>
                        密码:<asp:TextBox ID="TextBox4" runat="server" CssClass="txtsty" TextMode="Password"></asp:TextBox>
                    </p>
                    <p>
                        确认密码:<asp:TextBox ID="TextBox5" runat="server" CssClass="txtsty" TextMode="Password"></asp:TextBox>
                    </p>
                </div>
                <asp:Button ID="Button1" runat="server" Text="登录" BackColor="#99FF99" ValidationGroup="ValidataGroup1" CssClass="modbutton" OnClick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" Text="取消" BackColor="#99FF99" CssClass="modbutton" OnClick="Button2_Click" />
                 <asp:Button ID="Button3" runat="server" Text="确定" BackColor="#99FF99"  ValidationGroup="ValidataGroup1" CssClass="modbutton" OnClick="Button3_Click" />
            </div>
        </div>
    </form>
</body>
</html>
