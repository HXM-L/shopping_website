using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class registert : System.Web.UI.Page
{
    public static string con = ConfigurationManager.ConnectionStrings["Shopping_platformConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)  //判断是否首次加载
        {
           
        }
    }


    //取消
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");
    }

    //登录
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");
    }

    //确定修改
    protected void Button3_Click(object sender, EventArgs e)
    {
        try
        {
            SqlConnection conn = new SqlConnection(con);
            conn.Open();
            string SqlID = $"select [userTell] from [user_table] where userID='{TextBox1.Text.Trim()}'";
            SqlDataAdapter tempData = new SqlDataAdapter(SqlID, conn);
            DataTable tempTable = new DataTable();
            tempData.Fill(tempTable);
            string temptel = tempTable.Rows[0]["userTell"].ToString();
            if (TextBox2.Text == temptel.Trim())
            {
                string sqlUpate = $"update [user_table] set [userPwd]='{TextBox4.Text.Trim()}' where [userID]='" + TextBox1.Text.Trim() + "'";
                SqlCommand sqlcom1 = new SqlCommand(sqlUpate, conn);
                sqlcom1.ExecuteNonQuery();
                conn.Close();
                Response.Write("<script>alert('修改成功！');location.href='modifyPWD.aspx'</script>");
            }
            else
            {
                Response.Write("<script>alert('手机号错误或不存在！');location.href='modifyPWD.aspx'</script>");
            }
        }
        catch (SqlException sqlex)
        {
            Response.Write("<script>alert('账号不存在或手机号错误！');location.href='modifyPWD.aspx'</script>");
            if (sqlex.ErrorCode.ToString() != "")
            {
                Response.Write("<script>alert('" + sqlex.Message.ToString() + "');location.href='modifyPWD.aspx'</script>");
            }
        }
    }
}