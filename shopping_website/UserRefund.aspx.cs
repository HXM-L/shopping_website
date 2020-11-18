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
            
            loadData();
            //this.addrcord.Style["Display"] = "None"; //隐藏div
        }
    }
    void loadData()
    {
        SqlConnection conn = new SqlConnection(constr);
        conn.Open();
        string SqlStr1 = $"select [orderID] ,[userID] ,[shopID] ,[orderTotalPrice] ,[shipAddress] ,[payMethod] , CONVERT(varchar(10), [payDate], 120 ) payDate,CONVERT(varchar(10), [signDate], 120 ) signDate,[tranStatus] from [new_order] where tranStatus='已退货/退款' and [userID]='{Request.Cookies["UID"].Value.Trim()}'";
        SqlDataAdapter data1 = new SqlDataAdapter(SqlStr1, conn);
        DataSet dataset1 = new DataSet();
        data1.Fill(dataset1, "new_order");
        //绑定DataList控件
        GridView1.DataSource = dataset1;
        GridView1.DataKeyNames = new string[] { "orderID" };
        GridView1.DataBind();

        conn.Close();
    }

    protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
    {
        string tempSelcrt = e.Item.Value.ToString();
        switch (tempSelcrt)
        {
            case "退款记录":
                this.GridView1.Visible = true;
                break;
            default:
                break;
        }
    }
}