using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class registert : System.Web.UI.Page
{
    public static string con = ConfigurationManager.ConnectionStrings["Shopping_platformConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)  //判断是否首次加载
        {
            this.TextBox1.Text = "";
            this.TextBox2.Text = "";
            this.TextBox3.Text = "";
            this.TextBox4.Text = "";
            this.TextBox5.Text = "";
            this.TextBox6.Text = "";
            this.Image1.ImageUrl = "~/headPortrait/p1.jpg";
        }
    }

    //注册
    protected void Button3_Click(object sender, EventArgs e)
    {
        if (this.TextBox1.Text != "")
        {
            if (RadioButtonList2.SelectedValue == "普通用户")
            {
                try
                {
                    SqlConnection conn = new SqlConnection(con);
                    conn.Open();
                    string sqlInsert = "insert into [user_table]([userID],[userName],[userPwd],[userTell],[userSex],[shipAddress],[imageURL]) values('" + TextBox1.Text.Trim() + "','" + TextBox2.Text.Trim() + "','" + TextBox4.Text.Trim() + "','" + TextBox5.Text.Trim() + "','" + RadioButtonList1.SelectedValue.Trim() + "','" + TextBox6.Text.Trim() + "','" + Image1.ImageUrl.Trim() + "')";
                    SqlCommand sqlcom1 = new SqlCommand(sqlInsert, conn);
                    sqlcom1.ExecuteNonQuery();
                    conn.Close();
                    Response.Write("<script>alert('注册成功，欢迎您！')</script>");
                }
                catch (SqlException sqlex)
                {
                    Response.Write("<script>alert('账号已存在,不能重复注册！')</script>");
                    if (sqlex.ErrorCode.ToString() != "")
                    {
                        Response.Write("<script>alert('" + sqlex.Message.ToString() + "')</script>");
                    }
                }
            }
            else if (RadioButtonList2.SelectedValue == "商家")
            {
                try
                {
                    SqlConnection conn = new SqlConnection(con);
                    conn.Open();
                    string sqlInsert = "insert into [shop_table]([shopID],[shopName],[shopPwd],[shopTell],[shopSex],[registerDate],[imageURL]) values('" + TextBox1.Text.Trim() + "','" + TextBox2.Text.Trim() + "','" + TextBox4.Text.Trim() + "','" + TextBox5.Text.Trim() + "','" + RadioButtonList1.SelectedValue.Trim() + "','" + TextBox6.Text.Trim() + "','" + Image1.ImageUrl.Trim() + "')";
                    SqlCommand sqlcom1 = new SqlCommand(sqlInsert, conn);
                    sqlcom1.ExecuteNonQuery();
                    conn.Close();
                    Response.Write("<script>alert('注册成功，欢迎您！')</script>");
                }
                catch (SqlException sqlex)
                {
                    Response.Write("<script>alert('账号已存在,不能重复注册！')</script>");
                    if (sqlex.ErrorCode.ToString() !="")
                    {
                        Response.Write("<script>alert('" + sqlex.Message.ToString() + "')</script>");
                    }
                }
            }
        }
        else
        {
            Response.Write("<script>alert('请输入要注册的账号！')</script>");

        }
    }

    //重置
    protected void Button2_Click(object sender, EventArgs e)
    {
        this.TextBox1.Text = "";
        this.TextBox2.Text = "";
        this.TextBox3.Text = "";
        this.TextBox4.Text = "";
        this.TextBox5.Text = "";
        this.TextBox6.Text = "";
    }

    //登录
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");
    }

    //头像选择
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (this.DropDownList1.SelectedValue == "头像1")
        {
            this.Image1.ImageUrl = "~/headPortrait/p1.jpg";
        }
        else if (DropDownList1.SelectedValue == "头像2")
        {
            this.Image1.ImageUrl = "~/headPortrait/p2.png";
        }
        else if (DropDownList1.SelectedValue == "头像3")
        {
            this.Image1.ImageUrl = "~/headPortrait/p3.gif";
        }
    }
}