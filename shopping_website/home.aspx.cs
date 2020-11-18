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
        if (!IsPostBack)
        {
            loadData();
        }
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

        ////获取商品ID存在image控件中
        //this.Image1.AlternateText = dataTable.Rows[0]["comID"].ToString();
        //this.Image2.AlternateText = dataTable.Rows[1]["comID"].ToString();
        //this.Image3.AlternateText = dataTable.Rows[2]["comID"].ToString();
        //this.Image4.AlternateText = dataTable.Rows[3]["comID"].ToString();
        //this.Image5.AlternateText = dataTable.Rows[4]["comID"].ToString();
        //this.Image6.AlternateText = dataTable.Rows[5]["comID"].ToString();
        //this.Image7.AlternateText = dataTable.Rows[6]["comID"].ToString();
        //this.Image8.AlternateText = dataTable.Rows[7]["comID"].ToString();
        //this.Image9.AlternateText = dataTable.Rows[8]["comID"].ToString();
        //this.Image10.AlternateText = dataTable.Rows[9]["comID"].ToString();

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

    //添加购物车
    void addShoppingCart(string comID, double price, string introduce, string imageUrl)
    {
        SqlConnection conn = new SqlConnection(constr);
        conn.Open();
        //判断购物车中是否已有商品
        string SqlStr1 = $"select [comName] from [WebCart] where [commID]='{comID}'";
        SqlDataAdapter data1 = new SqlDataAdapter(SqlStr1, conn);
        DataTable dataTable = new DataTable();
        data1.Fill(dataTable);
        if (dataTable.Rows.Count <= 0)  //购物车中没有该商品
        {
            string Sqlname = $"select [comName] from [commodity_table] where [comID]='{comID}'";
            SqlDataAdapter tempData = new SqlDataAdapter(Sqlname, conn);
            DataTable tempTable = new DataTable();
            tempData.Fill(tempTable);
            string cname = tempTable.Rows[0]["comName"].ToString();
            string sqlInsert = $"insert into [WebCart]([commID],[comName],[comIntroduction],[comPrice],[comSurplus],[imgUrl]) values('" + comID + "','" + cname + "','" + introduce + "','" + price + "','" + 1 + "','" + imageUrl + "')";
            SqlCommand sqlcom1 = new SqlCommand(sqlInsert, conn);
            int n = sqlcom1.ExecuteNonQuery();
            if (n > 0)
            {
                //这里要解决表单提交后页面自动刷新,(用location.href='your.aspx')
                Response.Write("<script>alert('已加入购物车！');location.href='home.aspx'</script>");
            }
            else
            {
                Response.Write("<script>alert('添加购物车失败！');location.href='home.aspx'</script>");
            }
        }
        else if (dataTable.Rows.Count > 0)  //购物车中已有该商品
        {
            string Sqlname = $"select [comSurplus] from [WebCart] where [commID]='{comID}'";
            SqlDataAdapter tempData = new SqlDataAdapter(Sqlname, conn);
            DataTable tempTable = new DataTable();
            tempData.Fill(tempTable);

            int splus = int.Parse(tempTable.Rows[0]["comSurplus"].ToString()) + 1;
            //string cname = dataTable.Rows[0]["comName"].ToString();
            string sqlInsert = $"update [WebCart] set [comSurplus]={splus} where [commID]='" + comID + "'";
            SqlCommand sqlcom1 = new SqlCommand(sqlInsert, conn);
            int n = sqlcom1.ExecuteNonQuery();
            if (n > 0)
            {
                Response.Write("<script>alert('已加入购物车！');location.href='home.aspx'</script>");

            }
            else
            {
                Response.Write("<script>alert('添加购物车失败！');location.href='home.aspx'</script>");
            }
        }
        conn.Close();
    }

    //添加到收藏夹
    void addFavour(string comID, double price, string introduce, string imageUrl)
    {
        SqlConnection conn = new SqlConnection(constr);
        conn.Open();
        //判断购物车中是否已有商品
        string SqlStr1 = $"select [comName] from [Favoury] where [commID]='{comID}'";
        SqlDataAdapter data1 = new SqlDataAdapter(SqlStr1, conn);
        DataTable dataTable = new DataTable();
        data1.Fill(dataTable);
        if (dataTable.Rows.Count <= 0)  //收藏夹中没有该商品
        {
            string Sqlname = $"select [comName] from [commodity_table] where [comID]='{comID}'";
            SqlDataAdapter tempData = new SqlDataAdapter(Sqlname, conn);
            DataTable tempTable = new DataTable();
            tempData.Fill(tempTable);
            string cname = tempTable.Rows[0]["comName"].ToString();
            string sqlInsert = $"insert into [Favoury]([commID],[comName],[comIntroduction],[comPrice],[imgUrl]) values('" + comID + "','" + cname + "','" + introduce + "','" + price + "','" + imageUrl + "')";
            SqlCommand sqlcom1 = new SqlCommand(sqlInsert, conn);
            int n = sqlcom1.ExecuteNonQuery();
            if (n > 0)
            {
                //这里要解决表单提交后页面自动刷新,(用location.href='your.aspx')
                Response.Write("<script>alert('已加入收藏夹！');location.href='home.aspx'</script>");
            }
            else
            {
                Response.Write("<script>alert('添加购物车失败！');location.href='home.aspx'</script>");
            }
        }
        else if (dataTable.Rows.Count > 0)  //购物车中已有该商品
        {

            Response.Write("<script>alert('商品已在收藏夹！');location.href='home.aspx'</script>");
        }
        conn.Close();
    }
    //加入购物车
    protected void Button1_Click(object sender, EventArgs e)
    {
        string tep = this.Image1.ImageUrl.ToString();
        string tempID = (tep.Substring(tep.Length - 7)).Substring(0, 3);
        string temp = (this.Label1.Text.ToString()).Replace("￥", ""); //获取单价
        double cprice = Convert.ToDouble(temp);
        addShoppingCart(tempID, cprice, this.Label2.Text, this.Image1.ImageUrl);
        //Response.Redirect("home.aspx");

    }

    
    //加入收藏
    protected void Button2_Click(object sender, EventArgs e)
    {
        string tep = this.Image1.ImageUrl.ToString();
        string tempID = (tep.Substring(tep.Length - 7)).Substring(0, 3);
        string temp = (this.Label3.Text.ToString()).Replace("￥", ""); //获取单价
        double cprice = Convert.ToDouble(temp);
        addFavour(tempID, cprice, this.Label2.Text, this.Image1.ImageUrl);

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        string tep = this.Image2.ImageUrl.ToString();
        string tempID = (tep.Substring(tep.Length - 7)).Substring(0, 3);
        string temp = (this.Label3.Text.ToString()).Replace("￥", ""); //获取单价
        double cprice = Convert.ToDouble(temp);
        addShoppingCart(tempID, cprice, this.Label4.Text, this.Image2.ImageUrl);
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        string tep = this.Image2.ImageUrl.ToString();
        string tempID = (tep.Substring(tep.Length - 7)).Substring(0, 3);
        string temp = (this.Label3.Text.ToString()).Replace("￥", ""); //获取单价
        double cprice = Convert.ToDouble(temp);
        addFavour(tempID, cprice, this.Label4.Text, this.Image2.ImageUrl);
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        string tep = this.Image3.ImageUrl.ToString();
        string tempID = (tep.Substring(tep.Length - 7)).Substring(0, 3);
        string temp = (this.Label5.Text.ToString()).Replace("￥", ""); //获取单价
        double cprice = Convert.ToDouble(temp);
        addShoppingCart(tempID, cprice, this.Label6.Text, this.Image3.ImageUrl);
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        string tep = this.Image3.ImageUrl.ToString();
        string tempID = (tep.Substring(tep.Length - 7)).Substring(0, 3);
        string temp = (this.Label3.Text.ToString()).Replace("￥", ""); //获取单价
        double cprice = Convert.ToDouble(temp);
        addFavour(tempID, cprice, this.Label6.Text, this.Image3.ImageUrl);
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        string tep = this.Image4.ImageUrl.ToString();
        string tempID = (tep.Substring(tep.Length - 7)).Substring(0, 3);
        string temp = (this.Label7.Text.ToString()).Replace("￥", ""); //获取单价
        double cprice = Convert.ToDouble(temp);
        addShoppingCart(tempID, cprice, this.Label8.Text, this.Image4.ImageUrl);
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        string tep = this.Image4.ImageUrl.ToString();
        string tempID = (tep.Substring(tep.Length - 7)).Substring(0, 3);
        string temp = (this.Label3.Text.ToString()).Replace("￥", ""); //获取单价
        double cprice = Convert.ToDouble(temp);
        addFavour(tempID, cprice, this.Label8.Text, this.Image4.ImageUrl);
    }

    protected void Button9_Click(object sender, EventArgs e)
    {
        string tep = this.Image5.ImageUrl.ToString();
        string tempID = (tep.Substring(tep.Length - 7)).Substring(0, 3);
        string temp = (this.Label9.Text.ToString()).Replace("￥", ""); //获取单价
        double cprice = Convert.ToDouble(temp);
        addShoppingCart(tempID, cprice, this.Label10.Text, this.Image5.ImageUrl);
    }

    protected void Button10_Click(object sender, EventArgs e)
    {
        string tep = this.Image5.ImageUrl.ToString();
        string tempID = (tep.Substring(tep.Length - 7)).Substring(0, 3);
        string temp = (this.Label3.Text.ToString()).Replace("￥", ""); //获取单价
        double cprice = Convert.ToDouble(temp);
        addFavour(tempID, cprice, this.Label10.Text, this.Image5.ImageUrl);
    }

    protected void Button11_Click(object sender, EventArgs e)
    {
        string tep = this.Image6.ImageUrl.ToString();
        string tempID = (tep.Substring(tep.Length - 7)).Substring(0, 3);
        string temp = (this.Label11.Text.ToString()).Replace("￥", ""); //获取单价
        double cprice = Convert.ToDouble(temp);
        addShoppingCart(tempID, cprice, this.Label12.Text, this.Image6.ImageUrl);
    }

    protected void Button12_Click(object sender, EventArgs e)
    {
        string tep = this.Image6.ImageUrl.ToString();
        string tempID = (tep.Substring(tep.Length - 7)).Substring(0, 3);
        string temp = (this.Label3.Text.ToString()).Replace("￥", ""); //获取单价
        double cprice = Convert.ToDouble(temp);
        addFavour(tempID, cprice, this.Label12.Text, this.Image6.ImageUrl);
    }

    protected void Button13_Click(object sender, EventArgs e)
    {
        string tep = this.Image7.ImageUrl.ToString();
        string tempID = (tep.Substring(tep.Length - 7)).Substring(0, 3);
        string temp = (this.Label13.Text.ToString()).Replace("￥", ""); //获取单价
        double cprice = Convert.ToDouble(temp);
        addShoppingCart(tempID, cprice, this.Label14.Text, this.Image7.ImageUrl);
    }

    protected void Button14_Click(object sender, EventArgs e)
    {
        string tep = this.Image7.ImageUrl.ToString();
        string tempID = (tep.Substring(tep.Length - 7)).Substring(0, 3);
        string temp = (this.Label3.Text.ToString()).Replace("￥", ""); //获取单价
        double cprice = Convert.ToDouble(temp);
        addFavour(tempID, cprice, this.Label14.Text, this.Image7.ImageUrl);
    }

    protected void Button15_Click(object sender, EventArgs e)
    {
        string tep = this.Image8.ImageUrl.ToString();
        string tempID = (tep.Substring(tep.Length - 7)).Substring(0, 3);
        string temp = (this.Label15.Text.ToString()).Replace("￥", ""); //获取单价
        double cprice = Convert.ToDouble(temp);
        addShoppingCart(tempID, cprice, this.Label6.Text, this.Image8.ImageUrl);
    }

    protected void Button16_Click(object sender, EventArgs e)
    {
        string tep = this.Image8.ImageUrl.ToString();
        string tempID = (tep.Substring(tep.Length - 7)).Substring(0, 3);
        string temp = (this.Label3.Text.ToString()).Replace("￥", ""); //获取单价
        double cprice = Convert.ToDouble(temp);
        addFavour(tempID, cprice, this.Label16.Text, this.Image8.ImageUrl);
    }

    protected void Button17_Click(object sender, EventArgs e)
    {
        string tep = this.Image9.ImageUrl.ToString();
        string tempID = (tep.Substring(tep.Length - 7)).Substring(0, 3);
        string temp = (this.Label17.Text.ToString()).Replace("￥", ""); //获取单价
        double cprice = Convert.ToDouble(temp);
        addShoppingCart(tempID, cprice, this.Label8.Text, this.Image9.ImageUrl);
    }

    protected void Button18_Click(object sender, EventArgs e)
    {
        string tep = this.Image9.ImageUrl.ToString();
        string tempID = (tep.Substring(tep.Length - 7)).Substring(0, 3);
        string temp = (this.Label3.Text.ToString()).Replace("￥", ""); //获取单价
        double cprice = Convert.ToDouble(temp);
        addFavour(tempID, cprice, this.Label18.Text, this.Image9.ImageUrl);
    }

    protected void Button19_Click(object sender, EventArgs e)
    {
        string tep = this.Image10.ImageUrl.ToString();
        string tempID = (tep.Substring(tep.Length - 7)).Substring(0, 3);
        string temp = (this.Label9.Text.ToString()).Replace("￥", ""); //获取单价
        double cprice = Convert.ToDouble(temp);
        addShoppingCart(tempID, cprice, this.Label20.Text, this.Image10.ImageUrl);
    }

    protected void Button20_Click(object sender, EventArgs e)
    {
        string tep = this.Image10.ImageUrl.ToString();
        string tempID = (tep.Substring(tep.Length - 7)).Substring(0, 3);
        string temp = (this.Label3.Text.ToString()).Replace("￥", ""); //获取单价
        double cprice = Convert.ToDouble(temp);
        addFavour(tempID, cprice, this.Label20.Text, this.Image10.ImageUrl);
    }
}