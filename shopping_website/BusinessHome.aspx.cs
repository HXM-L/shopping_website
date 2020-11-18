using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class BusinessHome : System.Web.UI.Page
{
    public static string constr = ConfigurationManager.ConnectionStrings["Shopping_platformConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)  //判断是否首次加载
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            string SqlID = $"select * from [shop_table] where shopID='{Request.Cookies["UID"].Value.Trim()}'";
            SqlDataAdapter tempData = new SqlDataAdapter(SqlID, conn);
            DataTable tempTable = new DataTable();
            tempData.Fill(tempTable);
            if (tempTable.Rows.Count > 0)
            {
                this.Label2.Text = "店铺ID:" + tempTable.Rows[0]["shopID"].ToString() ;
                this.Label3.Text = "店铺名称:" + tempTable.Rows[0]["shopName"].ToString();
                this.Label3.Text = tempTable.Rows[0]["shopAddress"].ToString();
            }
        this.Label2.Text = "店铺ID:" + tempTable.Rows[0]["shopID"].ToString();
        this.Label3.Text = "店铺名称:" + tempTable.Rows[0]["shopName"].ToString();
        this.Label6.Text = tempTable.Rows[0]["shopAddress"].ToString();
        }
    }
}