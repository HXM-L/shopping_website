using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class login : System.Web.UI.Page
{
    public static string con = ConfigurationManager.ConnectionStrings["Shopping_platformConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)  //判断是否首次加载
        {

        }
    }

    //重置按钮
    protected void Button1_Click(object sender, EventArgs e)
    {
        this.TextBox1.Text = "";
        this.TextBox2.Text = "";
    }

    //注册
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        this.RequiredFieldValidator1.Enabled = false;
        this.RequiredFieldValidator2.Enabled = false;
        Response.Redirect("registert.aspx");
    }

    //忘记密码
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("modifyPWD.aspx");
        //Response.Write("<script>alert('请联系管理员找回或修改密码！')</script>");
    }

    //登录按钮
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedValue.ToString() == "用户")
        {
            if (TextBox1.Text != "" && TextBox2.Text != "")
            {
                SqlConnection conn = new SqlConnection(con);
                conn.Open();
                string SqlID = $"select [userName],[imageURL],[shipAddress] from [user_table] where userID='{TextBox1.Text.Trim()}'";
                SqlDataAdapter tempData = new SqlDataAdapter(SqlID, conn);
                DataTable tempTable = new DataTable();
                tempData.Fill(tempTable);
                if (tempTable.Rows.Count>0)
                {
                    string url = tempTable.Rows[0]["imageURL"].ToString();
                    string tempname = tempTable.Rows[0]["userName"].ToString();
                    //这里要解决中文乱码
                    System.Text.Encoding enc = System.Text.Encoding.GetEncoding("gb2312");
                    //创建HttpCokie对象,利用cookie存储登录者的账号
                    HttpCookie cookie = new HttpCookie("UID");
                    HttpCookie cookieURL = new HttpCookie("imgURL");
                    HttpCookie cookieName = new HttpCookie("Uname");
                    HttpCookie cookieAddress = new HttpCookie("address");
                    //设置cookie的value属性
                    cookie.Value = TextBox1.Text.ToString();
                    cookieURL.Value = url;
                    cookieURL.Value = HttpUtility.UrlEncode(url, enc);
                    cookieName.Value= HttpUtility.UrlEncode(tempname, enc);
                    cookieAddress.Value= HttpUtility.UrlEncode(tempTable.Rows[0]["shipAddress"].ToString(), enc);
                    //将cookie的信息添加进去
                    Response.Cookies.Add(cookie);
                    Response.Cookies.Add(cookieURL);
                    Response.Cookies.Add(cookieName);

                    Response.Redirect("home.aspx");
                }
                else
                {
                    Response.Write("<script>alert('账号或密码错误!!!')</script>");
                }
                conn.Close();
            }
        }else if (RadioButtonList1.SelectedValue.ToString() == "商家")
        {
            if (TextBox1.Text != "" && TextBox2.Text != "")
            {
                SqlConnection conn = new SqlConnection(con);
                conn.Open();
                string SqlID = $"select [lpersonName] from [shop_table] where shopID='{TextBox1.Text.Trim()}'";
                SqlDataAdapter tempData = new SqlDataAdapter(SqlID, conn);
                DataTable tempTable = new DataTable();
                tempData.Fill(tempTable);
                if (tempTable.Rows.Count > 0)
                {
                    //string url = tempTable.Rows[0]["imageURL"].ToString();
                    string tempname = tempTable.Rows[0]["lpersonName"].ToString();
                    //这里要解决中文乱码
                    //System.Text.Encoding enc = System.Text.Encoding.GetEncoding("gb2312");
                    //创建HttpCokie对象,利用cookie存储登录者的账号
                    HttpCookie cookie = new HttpCookie("UID");
                    //HttpCookie cookieURL = new HttpCookie("imgURL");
                    HttpCookie cookieName = new HttpCookie("Uname");
                    //设置cookie的value属性
                    cookie.Value = TextBox1.Text.ToString();
                    //cookieURL.Value = url;
                    //cookieURL.Value = HttpUtility.UrlEncode(url, enc);
                    //cookieName.Value = HttpUtility.UrlEncode(tempname, enc);
                    cookieName.Value = tempname;
                    //将cookie的信息添加进去
                    Response.Cookies.Add(cookie);
                    //Response.Cookies.Add(cookieURL);
                    Response.Cookies.Add(cookieName);

                    Response.Redirect("BusinessHome.aspx");
                }
                else
                {
                    Response.Write("<script>alert('账号或密码错误!!!')</script>");
                }
                conn.Close();
            }
        }
    }
}