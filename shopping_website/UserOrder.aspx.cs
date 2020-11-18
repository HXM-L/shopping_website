using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class UserOrder : System.Web.UI.Page
{
    public static string constr = ConfigurationManager.ConnectionStrings["Shopping_platformConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)  //判断是否首次加载
        {
            this.GridView1.Visible = true;
            this.GridView2.Visible = false;
            this.GridView3.Visible = false;
            this.GridView4.Visible = false;
            this.GridView5.Visible = false;
            this.GridView6.Visible = false;
            this.GridView7.Visible = false;

            loadData();
            //this.addrcord.Style["Display"] = "None"; //隐藏div
        }
    }
    void loadData()
    {
        SqlConnection conn = new SqlConnection(constr);
        conn.Open();
        string SqlStr1 = $"select [orderID] , [userID] ,[shopID] ,[orderTotalPrice] ,[shipAddress] ,[payMethod] , CONVERT(varchar(10), [payDate], 120 ) payDate,CONVERT(varchar(10), [signDate], 120 ) signDate,[tranStatus] from [new_order] where [userID]='{Request.Cookies["UID"].Value.Trim()}'";
        SqlDataAdapter data1 = new SqlDataAdapter(SqlStr1, conn);
        DataSet dataset1 = new DataSet();
        data1.Fill(dataset1, "new_order");
        //绑定DataList控件
        GridView1.DataSource = dataset1;
        GridView1.DataKeyNames = new string[] { "orderID" };
        GridView1.DataBind();

        string SqlStr2 = $"select [orderID] ,[userID] ,[shopID] ,[orderTotalPrice] ,[shipAddress] ,[payMethod] , CONVERT(varchar(10), [payDate], 120 ) payDate,CONVERT(varchar(10), [signDate], 120 ) signDate,[tranStatus] from [new_order] where tranStatus='待付款' and [userID]='{Request.Cookies["UID"].Value.Trim()}'";
        SqlDataAdapter data2 = new SqlDataAdapter(SqlStr2, conn);
        DataSet dataset2 = new DataSet();
        data2.Fill(dataset2, "new_order");
        //绑定DataList控件
        GridView2.DataSource = dataset2;
        GridView2.DataKeyNames = new string[] { "orderID" };
        GridView2.DataBind();

        string SqlStr3 = $"select [orderID] ,[userID] ,[shopID] ,[orderTotalPrice] ,[shipAddress] ,[payMethod] , CONVERT(varchar(10), [payDate], 120 ) payDate,CONVERT(varchar(10), [signDate], 120 ) signDate,[tranStatus] from [new_order] where tranStatus='待发货' and [userID]='{Request.Cookies["UID"].Value.Trim()}'";
        SqlDataAdapter data3 = new SqlDataAdapter(SqlStr3, conn);
        DataSet dataset3 = new DataSet();
        data3.Fill(dataset3, "new_order");
        //绑定DataList控件
        GridView3.DataSource = dataset3;
        GridView3.DataKeyNames = new string[] { "orderID" };
        GridView3.DataBind();

        string SqlStr4 = $"select [orderID] ,[userID] ,[shopID] ,[orderTotalPrice] ,[shipAddress] ,[payMethod] , CONVERT(varchar(10), [payDate], 120 ) payDate,CONVERT(varchar(10), [signDate], 120 ) signDate,[tranStatus] from [new_order] where tranStatus='退货/退款中' and [userID]='{Request.Cookies["UID"].Value.Trim()}'";
        SqlDataAdapter data4 = new SqlDataAdapter(SqlStr4, conn);
        DataSet dataset4 = new DataSet();
        data4.Fill(dataset4, "new_order");
        //绑定DataList控件
        GridView4.DataSource = dataset4;
        GridView4.DataKeyNames = new string[] { "orderID" };
        GridView4.DataBind();

        string SqlStr5 = $"select [orderID] ,[userID] ,[shopID] ,[orderTotalPrice] ,[shipAddress] ,[payMethod] , CONVERT(varchar(10), [payDate], 120 ) payDate,CONVERT(varchar(10), [signDate], 120 ) signDate,[tranStatus] from [new_order] where tranStatus='已完成' and [userID]='{Request.Cookies["UID"].Value.Trim()}'";
        SqlDataAdapter data5 = new SqlDataAdapter(SqlStr5, conn);
        DataSet dataset5 = new DataSet();
        data5.Fill(dataset5, "new_order");
        //绑定DataList控件
        GridView5.DataSource = dataset5;
        GridView5.DataKeyNames = new string[] { "orderID" };
        GridView5.DataBind();

        string SqlStr6 = $"select [orderID] ,[userID] ,[shopID] ,[orderTotalPrice] ,[shipAddress] ,[payMethod] , CONVERT(varchar(10), [payDate], 120 ) payDate,CONVERT(varchar(10), [signDate], 120 ) signDate,[tranStatus] from [new_order] where tranStatus='已取消' and [userID]='{Request.Cookies["UID"].Value.Trim()}'";
        SqlDataAdapter data6 = new SqlDataAdapter(SqlStr6, conn);
        DataSet dataset6 = new DataSet();
        data6.Fill(dataset6, "new_order");
        //绑定DataList控件
        GridView6.DataSource = dataset6;
        GridView6.DataKeyNames = new string[] { "orderID" };
        GridView6.DataBind();

        string SqlStr7 = $"select [orderID] ,[userID] ,[shopID] ,[orderTotalPrice] ,[shipAddress] ,[payMethod] , CONVERT(varchar(10), [payDate], 120 ) payDate,CONVERT(varchar(10), [signDate], 120 ) signDate,[tranStatus] from [new_order] where tranStatus='已退货/退款' and [userID]='{Request.Cookies["UID"].Value.Trim()}'";
        SqlDataAdapter data7 = new SqlDataAdapter(SqlStr7, conn);
        DataSet dataset7 = new DataSet();
        data7.Fill(dataset7, "new_order");
        //绑定DataList控件
        GridView7.DataSource = dataset7;
        GridView7.DataKeyNames = new string[] { "orderID" };
        GridView7.DataBind();

        conn.Close();
    }

    protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
    {
        string tempSelcrt = e.Item.Value.ToString();
        switch (tempSelcrt)
        {
            case "全部订单":
                this.GridView1.Visible = true;
                this.GridView2.Visible = false;
                this.GridView3.Visible = false;
                this.GridView4.Visible = false;
                this.GridView5.Visible = false;
                this.GridView6.Visible = false;
                this.GridView7.Visible = false;
                break;
            case "待付款":
                this.GridView1.Visible = false;
                this.GridView2.Visible = true;
                this.GridView3.Visible = false;
                this.GridView4.Visible = false;
                this.GridView5.Visible = false;
                this.GridView6.Visible = false;
                this.GridView7.Visible = false;
                break;
            case "待发货":
                this.GridView1.Visible = false;
                this.GridView2.Visible = false;
                this.GridView3.Visible = true;
                this.GridView4.Visible = false;
                this.GridView5.Visible = false;
                this.GridView6.Visible = false;
                this.GridView7.Visible = false;
                break;
            case "退货/退款中":
                this.GridView1.Visible = false;
                this.GridView2.Visible = false;
                this.GridView3.Visible = false;
                this.GridView4.Visible = true;
                this.GridView5.Visible = false;
                this.GridView6.Visible = false;
                this.GridView7.Visible = false;
                break;
            case "已完成":
                this.GridView1.Visible = false;
                this.GridView2.Visible = false;
                this.GridView3.Visible = false;
                this.GridView4.Visible = false;
                this.GridView5.Visible = true;
                this.GridView6.Visible = true;
                this.GridView7.Visible = false;
                break;
            case "已取消":
                this.GridView1.Visible = false;
                this.GridView2.Visible = false;
                this.GridView3.Visible = false;
                this.GridView4.Visible = false;
                this.GridView5.Visible = false;
                this.GridView6.Visible = true;
                this.GridView7.Visible = false;
                break;
            case "已退货/退款":
                this.GridView1.Visible = false;
                this.GridView2.Visible = false;
                this.GridView3.Visible = false;
                this.GridView4.Visible = false;
                this.GridView5.Visible = false;
                this.GridView6.Visible = false;
                this.GridView7.Visible = true;
                break;
            default:
                break;
        }
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        loadData();
    }

    protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView2.PageIndex = e.NewPageIndex;
        loadData();
    }

    protected void GridView3_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView3.PageIndex = e.NewPageIndex;
        loadData();
    }

    protected void GridView4_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView5.PageIndex = e.NewPageIndex;
        loadData();
    }

    protected void GridView6_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView6.PageIndex = e.NewPageIndex;
        loadData();
    }

    protected void GridView7_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView7.PageIndex = e.NewPageIndex;
        loadData();
    }
}