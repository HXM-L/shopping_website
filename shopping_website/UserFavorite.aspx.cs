using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class UserFavorite : System.Web.UI.Page
{
    public static string constr = ConfigurationManager.ConnectionStrings["Shopping_platformConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(constr);
        conn.Open();
        string SqlStr1 = $"select * from [Favoury]";
        SqlDataAdapter data1 = new SqlDataAdapter(SqlStr1, conn);
        DataTable dataTable = new DataTable();
        data1.Fill(dataTable);
        conn.Close();


        for (int i = 0; i < dataTable.Rows.Count; i++)
        {
            string CID = dataTable.Rows[i]["commID"].ToString();
            string information = dataTable.Rows[i]["comIntroduction"].ToString();
            string imgURL = dataTable.Rows[i]["imgUrl"].ToString();
            string temp = $"{dataTable.Rows[i]["comPrice"]:F2}";
            double Cprice = double.Parse(temp);

            //ShopCart shopCart = (ShopCart)LoadControl("~/ShopCart.ascx");
            UFavorite uFavorite = (UFavorite)this.Page.LoadControl("~/UFavorite.ascx");
            uFavorite.ID = "uFavorite" + i.ToString();
            uFavorite.InitFavour(CID, information, imgURL, Cprice);  //自定义用户控件的一个方法
            this.Panel1.Controls.Add(uFavorite);
        }
    }
}