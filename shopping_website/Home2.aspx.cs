using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class home : System.Web.UI.Page
{
    public static string constr = ConfigurationManager.ConnectionStrings["Shopping_platformConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        loadData();
    }
    //加载数据
    void loadData()
    {
        SqlConnection conn = new SqlConnection(constr);
        conn.Open();
        string SqlStr1 = "select [comID] ,[comName] ,[comPrice] ,[comIntroduction] ,[imgUrl] from [commodity_table]";
        SqlDataAdapter data1 = new SqlDataAdapter(SqlStr1, conn);
        DataTable dataTable = new DataTable();
        data1.Fill(dataTable);
        conn.Close();

        //获取商品ID存在image控件中
        this.Image1.AlternateText = dataTable.Rows[0]["comID"].ToString();
        this.Image2.AlternateText = dataTable.Rows[1]["comID"].ToString();
        this.Image3.AlternateText = dataTable.Rows[2]["comID"].ToString();
        this.Image4.AlternateText = dataTable.Rows[3]["comID"].ToString();
        this.Image5.AlternateText = dataTable.Rows[4]["comID"].ToString();
        this.Image6.AlternateText = dataTable.Rows[5]["comID"].ToString();
        this.Image7.AlternateText = dataTable.Rows[6]["comID"].ToString();
        this.Image8.AlternateText = dataTable.Rows[7]["comID"].ToString();
        this.Image9.AlternateText = dataTable.Rows[8]["comID"].ToString();
        this.Image10.AlternateText = dataTable.Rows[9]["comID"].ToString();

        //获取图片路径
        this.Image1.AlternateText = dataTable.Rows[0]["imgUrl"].ToString();
        this.Image2.AlternateText = dataTable.Rows[1]["imgUrl"].ToString();
        this.Image3.AlternateText = dataTable.Rows[2]["imgUrl"].ToString();
        this.Image4.AlternateText = dataTable.Rows[3]["imgUrl"].ToString();
        this.Image5.AlternateText = dataTable.Rows[4]["imgUrl"].ToString();
        this.Image6.AlternateText = dataTable.Rows[5]["imgUrl"].ToString();
        this.Image7.AlternateText = dataTable.Rows[6]["imgUrl"].ToString();
        this.Image8.AlternateText = dataTable.Rows[7]["imgUrl"].ToString();
        this.Image9.AlternateText = dataTable.Rows[8]["imgUrl"].ToString();
        this.Image10.AlternateText = dataTable.Rows[9]["imgUrl"].ToString();

        //获取商品单价
        this.Label1.Text = $"￥{dataTable.Rows[0]["comPrice"]:F2}";
        this.Label3.Text = $"￥{dataTable.Rows[1]["comPrice"]:F2}";
        this.Label5.Text = $"￥{dataTable.Rows[2]["comPrice"]:F2}";
        this.Label7.Text = $"￥{dataTable.Rows[3]["comPrice"]:F2}";
        this.Label9.Text = $"￥{dataTable.Rows[4]["comPrice"]:F2}";
        this.Label11.Text = $"￥{dataTable.Rows[5]["comPrice"]:F2}";
        this.Label13.Text = $"￥{dataTable.Rows[6]["comPrice"]:F2}";
        this.Label15.Text = $"￥{dataTable.Rows[7]["comPrice"]:F2}";
        this.Label17.Text = $"￥{dataTable.Rows[8]["comPrice"]:F2}";
        this.Label19.Text = $"￥{dataTable.Rows[9]["comPrice"]:F2}";

        this.Label2.Text = dataTable.Rows[0]["comIntroduction"].ToString();
        this.Label4.Text = dataTable.Rows[1]["comIntroduction"].ToString();
        this.Label6.Text = dataTable.Rows[2]["comIntroduction"].ToString();
        this.Label8.Text = dataTable.Rows[3]["comIntroduction"].ToString();
        this.Label10.Text = dataTable.Rows[4]["comIntroduction"].ToString();
        this.Label12.Text = dataTable.Rows[5]["comIntroduction"].ToString();
        this.Label14.Text = dataTable.Rows[6]["comIntroduction"].ToString();
        this.Label16.Text = dataTable.Rows[7]["comIntroduction"].ToString();
        this.Label18.Text = dataTable.Rows[8]["comIntroduction"].ToString();
        this.Label20.Text = dataTable.Rows[9]["comIntroduction"].ToString();

    }
}