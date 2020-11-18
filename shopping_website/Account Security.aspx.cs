using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Account_Security : System.Web.UI.Page
{
    public static string constr = ConfigurationManager.ConnectionStrings["Shopping_platformConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //注销账号
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(constr);
        conn.Open();
        string sqldelete = $"delete from [user_table] where [userID]=" + "'" + Request.Cookies["UID"].Value.Trim() + "'";
        SqlCommand sqlcom1 = new SqlCommand(sqldelete, conn);
        int n = sqlcom1.ExecuteNonQuery();
        conn.Close();
        if (n > 0)
        {
            //这里要解决表单提交后页面自动刷新,(用location.href='your.aspx')
            Response.Write("<script>alert('您的账号已注销成功!！');location.href='login.aspx'</script>");
        }
        else
        {
            Response.Write("<script>alert('账号注销失败！');location.href='Account_Security.aspx'</script>");
        }
    }

    //注册新账号
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("registert.aspx");
    }
}