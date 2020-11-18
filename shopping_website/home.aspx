<%@ Page Title="" Language="C#" MasterPageFile="~/Muser.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>易购商城</title>
    <style>
        * {
            box-sizing: border-box;
        }

        .mainbody {
            position: relative;
            width: 89%;
            height: 558px;
            margin: 20px auto;
            left: 10px;
            background-color: transparent;
            border: 1px solid transparent;
        }

        ul {
            padding: 0px;
        }

        p {
            position: relative;
            top: -10px;
        }

        ul > li {
            float: left;
            width: 223px;
            height: 259px;
            margin: 2px 18px 15px;
            padding: 5px;
            list-style: none;
            background-color: white;
            border: 1px solid black;
        }
        ul>li:hover{
            border: 2px solid red;
        }
        .imageCSS {
            position: relative;
            margin-left: 50px;
            border: 1px solid transparent;
        }

        .addScart {
            position: relative;
            top: -32px;
            left:10px;
            background:url(images/购物车1.png) no-repeat left; /*图片路径*/
            background-size:20px 20px;
            border: 1px solid transparent;
            outline: none;
        }

        .addCollection {
            position: relative;
            top: -32px;
            background:url(images/收藏夹.png) no-repeat left; /*图片路径*/
            background-size:22px 22px;
            border: 1px solid transparent;
            outline: none;
        }
        .addScart:active {
            color:orangered;
        }
        .addCollection:active{
            color:orangered;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="mainbody">
      <ul>
            <li>
                <asp:Image ID="Image1" runat="server" Height="130px" ImageUrl="~/WareListImg/001.png" Width="120px" CssClass="imageCSS" />
                <asp:Label ID="Label1" runat="server" Text="￥123.00" ForeColor="Red" Font-Size="Larger"></asp:Label>
                <p style="position:relative;top:-15px;">
                    <asp:Label ID="Label2" runat="server" Text="2020冬季新款女装时尚气质优雅设计感交叉系带显瘦灯笼袖皮草外套"></asp:Label>
                </p>
                <asp:Button ID="Button1" runat="server" Text="加购物车" CssClass="addScart" Height="30px" Width="100px" OnClick="Button1_Click"/>
                <asp:Button ID="Button2" runat="server" Text="加入收藏" CssClass="addCollection" Height="30" Width="100" OnClick="Button2_Click" />
            </li>
            <li>
                <asp:Image ID="Image2" runat="server" Height="130px" ImageUrl="~/WareListImg/002.png" Width="120px" CssClass="imageCSS" />
                <asp:Label ID="Label3" runat="server" Text="￥123.00" ForeColor="Red" Font-Size="Larger"></asp:Label>
                <p style="position:relative;top:-15px;">
                    <asp:Label ID="Label4" runat="server" Text="2020冬季新款女装时尚气质优雅设计感交叉系带显瘦灯笼袖皮草外套"></asp:Label>
                </p>
                <asp:Button ID="Button3" runat="server" Text="加购物车" CssClass="addScart" Height="30px" Width="100px" OnClick="Button3_Click"/>
                <asp:Button ID="Button4" runat="server" Text="加入收藏" CssClass="addCollection" Height="30" Width="100" OnClick="Button4_Click" />
            </li>
            <li>
                <asp:Image ID="Image3" runat="server" Height="130px" ImageUrl="~/WareListImg/003.png" Width="120px" CssClass="imageCSS" />
                <asp:Label ID="Label5" runat="server" Text="￥123.00" ForeColor="Red" Font-Size="Larger"></asp:Label>
                <p style="position:relative;top:-15px;">
                    <asp:Label ID="Label6" runat="server" Text="2020冬季新款女装时尚气质优雅设计感交叉系带显瘦灯笼袖皮草外套"></asp:Label>
                </p>
                <asp:Button ID="Button5" runat="server" Text="加购物车" CssClass="addScart" Height="30px" Width="100px" OnClick="Button5_Click"/>
                <asp:Button ID="Button6" runat="server" Text="加入收藏" CssClass="addCollection" Height="30" Width="100" OnClick="Button6_Click" />
            </li>
            <li>
                <asp:Image ID="Image4" runat="server" Height="130px" ImageUrl="~/WareListImg/004.png" Width="120px" CssClass="imageCSS" />
                <asp:Label ID="Label7" runat="server" Text="￥123.00" ForeColor="Red" Font-Size="Larger"></asp:Label>
                <p style="position:relative;top:-15px;">
                    <asp:Label ID="Label8" runat="server" Text="2020冬季新款女装时尚气质优雅设计感交叉系带显瘦灯笼袖皮草外套"></asp:Label>
                </p>
                <asp:Button ID="Button7" runat="server" Text="加购物车" CssClass="addScart" Height="30px" Width="100px" OnClick="Button7_Click"/>
                <asp:Button ID="Button8" runat="server" Text="加入收藏" CssClass="addCollection" Height="30" Width="100" OnClick="Button8_Click" />
            </li>
            <li>
                <asp:Image ID="Image5" runat="server" Height="130px" ImageUrl="~/WareListImg/005.png" Width="120px" CssClass="imageCSS" />
                <asp:Label ID="Label9" runat="server" Text="￥123.00" ForeColor="Red" Font-Size="Larger"></asp:Label>
                <p style="position:relative;top:-15px;">
                    <asp:Label ID="Label10" runat="server" Text="2020冬季新款女装时尚气质优雅设计感交叉系带显瘦灯笼袖皮草外套"></asp:Label>
                </p>
                <asp:Button ID="Button9" runat="server" Text="加购物车" CssClass="addScart" Height="30px" Width="100px" OnClick="Button9_Click"/>
                <asp:Button ID="Button10" runat="server" Text="加入收藏" CssClass="addCollection" Height="30" Width="100" OnClick="Button10_Click" />
            </li>
            <li>
                <asp:Image ID="Image6" runat="server" Height="130px" ImageUrl="~/WareListImg/006.png" Width="120px" CssClass="imageCSS" />
                <asp:Label ID="Label11" runat="server" Text="￥123.00" ForeColor="Red" Font-Size="Larger"></asp:Label>
                <p style="position:relative;top:-15px;">
                    <asp:Label ID="Label12" runat="server" Text="2020冬季新款女装时尚气质优雅设计感交叉系带显瘦灯笼袖皮草外套"></asp:Label>
                </p>
                <asp:Button ID="Button11" runat="server" Text="加购物车" CssClass="addScart" Height="30px" Width="100px" OnClick="Button11_Click"/>
                <asp:Button ID="Button12" runat="server" Text="加入收藏" CssClass="addCollection" Height="30" Width="100" OnClick="Button12_Click" />
            </li>
            <li>
                <asp:Image ID="Image7" runat="server" Height="130px" ImageUrl="~/WareListImg/007.png" Width="120px" CssClass="imageCSS" />
                <asp:Label ID="Label13" runat="server" Text="￥123.00" ForeColor="Red" Font-Size="Larger"></asp:Label>
                <p style="position:relative;top:-15px;">
                    <asp:Label ID="Label14" runat="server" Text="2020冬季新款女装时尚气质优雅设计感交叉系带显瘦灯笼袖皮草外套"></asp:Label>
                </p>
                <asp:Button ID="Button13" runat="server" Text="加购物车" CssClass="addScart" Height="30px" Width="100px" OnClick="Button13_Click"/>
                <asp:Button ID="Button14" runat="server" Text="加入收藏" CssClass="addCollection" Height="30" Width="100" OnClick="Button14_Click" />
            </li>
            <li>
                <asp:Image ID="Image8" runat="server" Height="130px" ImageUrl="~/WareListImg/008.png" Width="120px" CssClass="imageCSS" />
                <asp:Label ID="Label15" runat="server" Text="￥123.00" ForeColor="Red" Font-Size="Larger"></asp:Label>
                <p style="position:relative;top:-15px;">
                    <asp:Label ID="Label16" runat="server" Text="2020冬季新款女装时尚气质优雅设计感交叉系带显瘦灯笼袖皮草外套"></asp:Label>
                </p>
                <asp:Button ID="Button15" runat="server" Text="加购物车" CssClass="addScart" Height="30px" Width="100px" OnClick="Button15_Click"/>
                <asp:Button ID="Button16" runat="server" Text="加入收藏" CssClass="addCollection" Height="30" Width="100" OnClick="Button16_Click" />
            </li>
            <li>
                <asp:Image ID="Image9" runat="server" Height="130px" ImageUrl="~/WareListImg/009.png" Width="120px" CssClass="imageCSS" />
                <asp:Label ID="Label17" runat="server" Text="￥123.00" ForeColor="Red" Font-Size="Larger"></asp:Label>
                <p style="position:relative;top:-15px;">
                    <asp:Label ID="Label18" runat="server" Text="2020冬季新款女装时尚气质优雅设计感交叉系带显瘦灯笼袖皮草外套"></asp:Label>
                </p>
                <asp:Button ID="Button17" runat="server" Text="加购物车" CssClass="addScart" Height="30px" Width="100px" OnClick="Button17_Click"/>
                <asp:Button ID="Button18" runat="server" Text="加入收藏" CssClass="addCollection" Height="30" Width="100" OnClick="Button18_Click" />
            </li>
            <li>
                <asp:Image ID="Image10" runat="server" Height="130px" ImageUrl="~/WareListImg/010.png" Width="120px" CssClass="imageCSS" />
                <asp:Label ID="Label19" runat="server" Text="￥123.00" ForeColor="Red" Font-Size="Larger"></asp:Label>
                <p style="position:relative;top:-15px;">
                    <asp:Label ID="Label20" runat="server" Text="2020冬季新款女装时尚气质优雅设计感交叉系带显瘦灯笼袖皮草外套"></asp:Label>
                </p>
                <asp:Button ID="Button19" runat="server" Text="加购物车" CssClass="addScart" Height="30px" Width="100px" OnClick="Button19_Click"/>
                <asp:Button ID="Button20" runat="server" Text="加入收藏" CssClass="addCollection" Height="30" Width="100" OnClick="Button20_Click" />
            </li>
        </ul>
    </div>
</asp:Content>

