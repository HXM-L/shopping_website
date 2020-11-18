using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Muser : System.Web.UI.MasterPage
{
    public static string constr = ConfigurationManager.ConnectionStrings["Shopping_platformConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        System.Text.Encoding enc = System.Text.Encoding.GetEncoding("gb2312");
        this.Label1.Text = "Hi," + Request.Cookies["Uname"].Value.Trim() + "!";
        if (!IsPostBack)  //判断是否首次加载
        {
            this.Image1.ImageUrl = HttpUtility.UrlDecode(Request.Cookies["imgURL"].Value, enc);

            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            string SqlID = $"select [userName] ,[userName],[imageURL] from [user_table] where userID='{Request.Cookies["UID"].Value.Trim()}'";
            SqlDataAdapter tempData = new SqlDataAdapter(SqlID, conn);
            DataTable tempTable = new DataTable();
            tempData.Fill(tempTable);
            if (tempTable.Rows.Count > 0)
            {
                this.Label1.Text = "Hi," + tempTable.Rows[0]["userName"].ToString() + "!";
            }
        }

    }
}
