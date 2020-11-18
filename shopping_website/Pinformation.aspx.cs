using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Pinformation : System.Web.UI.Page
{
    public static string constr = ConfigurationManager.ConnectionStrings["Shopping_platformConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        this.TextBox1.Enabled = false;
        this.TextBox2.Enabled = false;
        this.TextBox3.Enabled = false;
        this.TextBox4.Enabled = false;
        this.TextBox5.Enabled = false;
        this.TextBox6.Enabled = false;
        if (!IsPostBack)
        {
            HttpCookie cookie = Request.Cookies["UID"];
            if (cookie != null)
            {
                SqlConnection conn = new SqlConnection(constr);
                conn.Open();
                string SqlStr1 = $"select [userName] ,[userTell] ,[userSex],[birthDay] ,[imageURL],[shipAddress] from [user_table] where userID='{cookie.Value}'";
                SqlDataAdapter data1 = new SqlDataAdapter(SqlStr1, conn);
                DataTable dataTable = new DataTable();
                data1.Fill(dataTable);
                conn.Close();
                this.TextBox1.Text = cookie.Value;
                this.TextBox2.Text = dataTable.Rows[0]["userName"].ToString();
                this.TextBox3.Text = dataTable.Rows[0]["userTell"].ToString();
                this.TextBox4.Text = dataTable.Rows[0]["userSex"].ToString();
                this.TextBox5.Text = (dataTable.Rows[0]["birthDay"].ToString());
                if (this.TextBox5.Text != "")
                {
                    this.TextBox5.Text= this.TextBox5.Text.Substring(0, 10);
                }
                this.TextBox6.Text = dataTable.Rows[0]["shipAddress"].ToString();
            }
        }
    }

    //修改
    protected void Button1_Click(object sender, EventArgs e)
    {
        this.TextBox2.Enabled = true;
        this.TextBox3.Enabled = true;
        this.TextBox4.Enabled = true;
        this.TextBox5.Enabled = true;
        this.TextBox6.Enabled = true;
    }

    //用户信息保存
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(constr);
        conn.Open();
        
        string sqlUpate = $"update [user_table] set [userName]='{TextBox2.Text.Trim()}',[userTell]='{TextBox3.Text.Trim()}',[userSex]='{TextBox4.Text.Trim()}',[birthDay]='{TextBox5.Text.Trim()}',[shipAddress]='{TextBox6.Text.Trim()}' where [userID]='" + TextBox1.Text.Trim() + "'";
        SqlCommand sqlcom1 = new SqlCommand(sqlUpate, conn);
        int n = sqlcom1.ExecuteNonQuery();
        if (n > 0)
        {
            Response.Write("<script>alert('修改成功！');location.href='Pinformation.aspx'</script>");
        }
        else
        {
            Response.Write("<script>alert('修改失败！');location.href='Pinformation.aspx'</script>");
        }
        conn.Close();
    }
}