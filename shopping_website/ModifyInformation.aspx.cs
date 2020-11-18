using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class ModifyInformation : System.Web.UI.Page
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
        this.TextBox7.Enabled = false;
        if (!IsPostBack)
        {
            HttpCookie cookie = Request.Cookies["UID"];
            if (cookie != null)
            {
                SqlConnection conn = new SqlConnection(constr);
                conn.Open();
                string SqlStr1 = $"select * from [shop_table] where shopID='{cookie.Value}'";
                SqlDataAdapter data1 = new SqlDataAdapter(SqlStr1, conn);
                DataTable dataTable = new DataTable();
                data1.Fill(dataTable);
                conn.Close();
                this.TextBox1.Text = cookie.Value;
                this.TextBox2.Text = dataTable.Rows[0]["lpersonName"].ToString();
                this.TextBox3.Text = dataTable.Rows[0]["shopName"].ToString();
                this.TextBox4.Text = dataTable.Rows[0]["shopTell"].ToString();
                this.TextBox5.Text = (dataTable.Rows[0]["registerDate"].ToString());
                this.TextBox6.Text = dataTable.Rows[0]["servicePhone"].ToString();
                this.TextBox7.Text = dataTable.Rows[0]["shopAddress"].ToString();

                if (this.TextBox5.Text != "")
                {
                    this.TextBox5.Text = this.TextBox5.Text.Substring(0, 10);
                }
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
        this.TextBox7.Enabled = true;
    }

    //保存
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(constr);
        conn.Open();

        string sqlInsert = $"update [shop_table] set [lpersonName]='{TextBox2.Text.Trim()}',[shopName]='{TextBox3.Text.Trim()}',[shopTell]='{TextBox4.Text.Trim()}',[registerDate]='{TextBox5.Text.Trim()}',[shopAddress]='{TextBox6.Text.Trim()}',[servicePhone]='{TextBox6.Text.Trim()}' where [shopID]='" + TextBox1.Text.Trim() + "'";
        SqlCommand sqlcom1 = new SqlCommand(sqlInsert, conn);
        int n = sqlcom1.ExecuteNonQuery();
        if (n > 0)
        {
            Response.Write("<script>alert('修改成功！');location.href='ModifyInformation.aspx'</script>");

        }
        else
        {
            Response.Write("<script>alert('修改失败！');location.href='ModifyInformation.aspx'</script>");
        }
        conn.Close();
    }
}