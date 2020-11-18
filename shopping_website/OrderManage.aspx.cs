using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;


public partial class OrderManage : System.Web.UI.Page
{
    public static string constr = ConfigurationManager.ConnectionStrings["Shopping_platformConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        Random ran = new Random();
        this.TextBox1.Text = DateTime.Now.ToString("yyyyMMddhhmmss") + ran.Next(1000, 9999).ToString();
        this.TextBox1.Enabled = false;
        if (!IsPostBack)  //判断是否首次加载
        {
            loadData();
            this.addrcord.Style["Display"] = "None"; //隐藏div
        }
        //this.TextBox7.Text = this.DropDownList2.SelectedItem.Text;
    }

    //加载数据
    void loadData()
    {
        SqlConnection conn = new SqlConnection(constr);
        conn.Open();
        string SqlStr1 = "select [orderID] ,[userID] ,[shopID] ,[orderTotalPrice] ,[shipAddress] ,[payMethod] , CONVERT(varchar(10), [payDate], 120 ) payDate,CONVERT(varchar(10), [signDate], 120 ) signDate,[tranStatus] from [new_order]";
        SqlDataAdapter data1 = new SqlDataAdapter(SqlStr1, conn);
        DataSet dataset1 = new DataSet();
        data1.Fill(dataset1, "new_order");
        //绑定DataList控件
        GridView1.DataSource = dataset1;
        GridView1.DataKeyNames = new string[] { "orderID" };
        GridView1.DataBind();

        string SqlStr2 = "select [orderID] ,[userID] ,[shopID] ,[orderTotalPrice] ,[shipAddress] ,[payMethod] , CONVERT(varchar(10), [payDate], 120 ) payDate,CONVERT(varchar(10), [signDate], 120 ) signDate,[tranStatus] from [new_order] where tranStatus='待付款'";
        SqlDataAdapter data2 = new SqlDataAdapter(SqlStr2, conn);
        DataSet dataset2 = new DataSet();
        data2.Fill(dataset2, "new_order");
        //绑定DataList控件
        GridView2.DataSource = dataset2;
        GridView2.DataKeyNames = new string[] { "orderID" };
        GridView2.DataBind();

        string SqlStr3 = "select [orderID] ,[userID] ,[shopID] ,[orderTotalPrice] ,[shipAddress] ,[payMethod] , CONVERT(varchar(10), [payDate], 120 ) payDate,CONVERT(varchar(10), [signDate], 120 ) signDate,[tranStatus] from [new_order] where tranStatus='待发货'";
        SqlDataAdapter data3 = new SqlDataAdapter(SqlStr3, conn);
        DataSet dataset3 = new DataSet();
        data3.Fill(dataset3, "new_order");
        //绑定DataList控件
        GridView3.DataSource = dataset3;
        GridView3.DataKeyNames = new string[] { "orderID" };
        GridView3.DataBind();

        string SqlStr4 = "select [orderID] ,[userID] ,[shopID] ,[orderTotalPrice] ,[shipAddress] ,[payMethod] , CONVERT(varchar(10), [payDate], 120 ) payDate,CONVERT(varchar(10), [signDate], 120 ) signDate,[tranStatus] from [new_order] where tranStatus='退货/退款中'";
        SqlDataAdapter data4 = new SqlDataAdapter(SqlStr4, conn);
        DataSet dataset4 = new DataSet();
        data4.Fill(dataset4, "new_order");
        //绑定DataList控件
        GridView4.DataSource = dataset4;
        GridView4.DataKeyNames = new string[] { "orderID" };
        GridView4.DataBind();

        string SqlStr5 = "select [orderID] ,[userID] ,[shopID] ,[orderTotalPrice] ,[shipAddress] ,[payMethod] , CONVERT(varchar(10), [payDate], 120 ) payDate,CONVERT(varchar(10), [signDate], 120 ) signDate,[tranStatus] from [new_order] where tranStatus='已完成'";
        SqlDataAdapter data5 = new SqlDataAdapter(SqlStr5, conn);
        DataSet dataset5 = new DataSet();
        data5.Fill(dataset5, "new_order");
        //绑定DataList控件
        GridView5.DataSource = dataset5;
        GridView5.DataKeyNames = new string[] { "orderID" };
        GridView5.DataBind();

        string SqlStr6 = "select [orderID] ,[userID] ,[shopID] ,[orderTotalPrice] ,[shipAddress] ,[payMethod] , CONVERT(varchar(10), [payDate], 120 ) payDate,CONVERT(varchar(10), [signDate], 120 ) signDate,[tranStatus] from [new_order] where tranStatus='已取消'";
        SqlDataAdapter data6 = new SqlDataAdapter(SqlStr6, conn);
        DataSet dataset6 = new DataSet();
        data6.Fill(dataset6, "new_order");
        //绑定DataList控件
        GridView6.DataSource = dataset6;
        GridView6.DataKeyNames = new string[] { "orderID" };
        GridView6.DataBind();

        string SqlStr7 = "select [orderID] ,[userID] ,[shopID] ,[orderTotalPrice] ,[shipAddress] ,[payMethod] , CONVERT(varchar(10), [payDate], 120 ) payDate,CONVERT(varchar(10), [signDate], 120 ) signDate,[tranStatus] from [new_order] where tranStatus='已退货/退款'";
        SqlDataAdapter data7 = new SqlDataAdapter(SqlStr7, conn);
        DataSet dataset7 = new DataSet();
        data7.Fill(dataset7, "new_order");
        //绑定DataList控件
        GridView7.DataSource = dataset7;
        GridView7.DataKeyNames = new string[] { "orderID" };
        GridView7.DataBind();

        conn.Close();
    }

    protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
    {
        if (e.Item.Value == "0")
        {
            MultiView1.ActiveViewIndex = 0;
        }
        else if (e.Item.Value == "1")
        {
            MultiView1.ActiveViewIndex = 1;
        }
        else if (e.Item.Value == "2")
        {
            MultiView1.ActiveViewIndex = 2;
        }
        else if (e.Item.Value == "3")
        {
            MultiView1.ActiveViewIndex = 3;
        }
        else if (e.Item.Value == "4")
        {
            MultiView1.ActiveViewIndex = 4;
        }
        else if (e.Item.Value == "5")
        {
            MultiView1.ActiveViewIndex = 5;
        }
        else if (e.Item.Value == "6")
        {
            MultiView1.ActiveViewIndex = 6;
        }
        else if (e.Item.Value == "7")
        {
            MultiView1.ActiveViewIndex = 7;
        }
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {

    }


    //分页
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        loadData();
        //GridView1.PageIndex = e.NewPageIndex;
        //GridView1.DataBind();
    }

    //编辑
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        //索引编辑时
        this.GridView1.EditIndex = e.NewEditIndex;
        loadData();
    }


    //订单的修改
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        SqlConnection conn = new SqlConnection(constr);
        conn.Open();
        string orderID = GridView1.DataKeys[e.RowIndex].Value.ToString();
        string oTotalPrice = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text.ToString();
        string sAddress = ((TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0]).Text.ToString();
        string pMethod = ((TextBox)GridView1.Rows[e.RowIndex].Cells[6].Controls[0]).Text.Trim();
        string pDate = ((TextBox)GridView1.Rows[e.RowIndex].Cells[7].Controls[0]).Text.Trim();
        string siDate = ((TextBox)GridView1.Rows[e.RowIndex].Cells[8].Controls[0]).Text.Trim();
        string trStatus = ((TextBox)GridView1.Rows[e.RowIndex].Cells[9].Controls[0]).Text.Trim();
        string SqlStr = "";
        if (pDate == "" && siDate=="")
        {
            SqlStr = $"Update new_order set orderTotalPrice='" + oTotalPrice + "',shipAddress='" + sAddress + "',payMethod='" + pMethod + "',tranStatus='" + trStatus + "' where orderID=" + "'" + orderID + "'";
        }
        if (pDate != "" && siDate == "")
        {
            SqlStr = $"Update new_order set orderTotalPrice='" + oTotalPrice + "',shipAddress='" + sAddress + "',payMethod='" + pMethod + "',payDate='" + pDate + "',tranStatus='" + trStatus + "' where orderID=" + "'" + orderID + "'";
        }
        if (pDate == "" && siDate != "")
        {
            SqlStr = $"Update new_order set orderTotalPrice='" + oTotalPrice + "',shipAddress='" + sAddress + "',payMethod='" + pMethod + "',signDate='" + siDate + "',tranStatus='" + trStatus + "' where orderID=" + "'" + orderID + "'";
        }
        if (pDate != "" && siDate != "")
        {
            SqlStr = $"Update new_order set orderTotalPrice='" + oTotalPrice + "',shipAddress='" + sAddress + "',payMethod='" + pMethod + "',payDate='" + pDate + "',signDate='" + siDate + "',tranStatus='" + trStatus + "' where orderID=" + "'" + orderID + "'";
        }

        SqlCommand cmd = new SqlCommand(SqlStr, conn);
        int n = cmd.ExecuteNonQuery();
        if (n > 0)
        {
            conn.Close();
            GridView1.EditIndex = -1;
            Response.Write("<script language=javascript>alert('修改成功!');location='OrderManage.aspx' </script>");
        }
        else
        {
            conn.Close();
            GridView1.EditIndex = -1;
            Response.Write("<script language=javascript>alert('修改失败!!!');location='OrderManage.aspx' </script>");
        }
        loadData();
    }

    //取消编辑
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        this.GridView1.EditIndex = -1;
        loadData();
    }

    protected void GridView2_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        this.GridView2.EditIndex = -1;
        loadData();
    }

    protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
    {
        //索引编辑时
        this.GridView2.EditIndex = e.NewEditIndex;
        loadData();
    }

    protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView2.PageIndex = e.NewPageIndex;
        loadData();
        //GridView1.PageIndex = e.NewPageIndex;
        //GridView1.DataBind();
    }

    //更新
    protected void GridView2_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        SqlConnection conn = new SqlConnection(constr);
        conn.Open();
        string orderID = GridView2.DataKeys[e.RowIndex].Value.ToString();
        string oTotalPrice = ((TextBox)GridView2.Rows[e.RowIndex].Cells[4].Controls[0]).Text.ToString();
        string sAddress = ((TextBox)GridView2.Rows[e.RowIndex].Cells[5].Controls[0]).Text.ToString();
        string pMethod = ((TextBox)GridView2.Rows[e.RowIndex].Cells[6].Controls[0]).Text.Trim();
        string pDate = ((TextBox)GridView2.Rows[e.RowIndex].Cells[7].Controls[0]).Text.Trim();
        string siDate = ((TextBox)GridView2.Rows[e.RowIndex].Cells[8].Controls[0]).Text.Trim();
        string trStatus = ((TextBox)GridView2.Rows[e.RowIndex].Cells[9].Controls[0]).Text.Trim();
        string SqlStr = $"Update new_order set orderTotalPrice='" + oTotalPrice + "',shipAddress='" + sAddress + "',payMethod='" + pMethod + "',payDate='" + pDate + "',signDate='" + siDate + "',tranStatus='" + trStatus + "' where orderID=" + "'" + orderID + "'";
        SqlCommand cmd = new SqlCommand(SqlStr, conn);
        int n = cmd.ExecuteNonQuery();
        if (n > 0)
        {
            conn.Close();
            GridView1.EditIndex = -1;
            Response.Write("<script language=javascript>alert('修改成功!');location='OrderManage.aspx' </script>");
        }
        else
        {
            conn.Close();
            GridView1.EditIndex = -1;
            Response.Write("<script language=javascript>alert('修改失败!!!');location='OrderManage.aspx' </script>");
        }
    }

    //订单删除
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        SqlConnection conn = new SqlConnection(constr);
        conn.Open();
        string ID = GridView1.DataKeys[e.RowIndex].Value.ToString();
        string SqlStr = $"delete from [new_order] where [orderID]=" + "'" + ID + "'";
        SqlCommand cmd = new SqlCommand(SqlStr, conn);
        int n = cmd.ExecuteNonQuery();
        if (n > 0)
        {
            conn.Close();
            Response.Write("<script language=javascript>alert('删除成功!');location='OrderManage.aspx' </script>");
        }
        else
        {
            conn.Close();
            Response.Write("<script language=javascript>alert('删除失败!!!');location='OrderManage.aspx' </script>");
        }
        loadData();
    }

    protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        SqlConnection conn = new SqlConnection(constr);
        conn.Open();
        string ID = GridView2.DataKeys[e.RowIndex].Value.ToString();
        string SqlStr = $"delete from [new_order] where [orderID]=" + "'" + ID + "'";
        SqlCommand cmd = new SqlCommand(SqlStr, conn);
        int n = cmd.ExecuteNonQuery();
        if (n > 0)
        {
            conn.Close();
            Response.Write("<script language=javascript>alert('删除成功!');location='OrderManage.aspx' </script>");
        }
        else
        {
            conn.Close();
            Response.Write("<script language=javascript>alert('删除失败!!!');location='OrderManage.aspx' </script>");
        }
        loadData();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    //添加按钮
    protected void Button3_Click(object sender, EventArgs e)
    {
        this.GridView1.Visible = false;
        this.addrcord.Style["Display"] = "Block"; //显示div
    }

    //重置
    protected void Button15_Click(object sender, EventArgs e)
    {
        this.TextBox1.Text = "";
        this.TextBox2.Text = "";
        this.TextBox3.Text = "";
        this.TextBox4.Text = "";
        this.TextBox5.Text = "";
        this.TextBox6.Text = "";
        this.TextBox7.Text = "";
    }

    //取消
    protected void Button16_Click(object sender, EventArgs e)
    {
        this.GridView1.Visible = true;
        this.addrcord.Style["Display"] = "None"; //隐藏div
    }

    //商家手动添加订单添加
    protected void Button17_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(constr);
        conn.Open();
        string sqlInsert = "";
        if (TextBox5.Text == "" && TextBox6.Text == "")
        {
            sqlInsert = "insert into [new_order]([orderID],[userID],[shopID],[orderTotalPrice],[shipAddress],[payMethod],[tranStatus]) values('" + TextBox1.Text.Trim() + "','" + TextBox2.Text.Trim() + "','" + TextBox3.Text.Trim() + "','" + TextBox4.Text.Trim() + "','" + TextBox7.Text.Trim() + "', '" + DropDownList1.SelectedItem.Text + "','" + DropDownList2.SelectedItem.Text + "' )";
        }
        if (TextBox5.Text != "" && TextBox6.Text == "")
        {
            sqlInsert = "insert into [new_order]([orderID],[userID],[shopID],[orderTotalPrice],[shipAddress],[payMethod],[payDate],[tranStatus]) values('" + TextBox1.Text.Trim() + "','" + TextBox2.Text.Trim() + "','" + TextBox3.Text.Trim() + "','" + TextBox4.Text.Trim() + "','" + TextBox7.Text.Trim() + "', '" + DropDownList1.SelectedItem.Text + "', '" + TextBox5.Text.Trim() + "', '" + DropDownList2.SelectedItem.Text + "' )";
        }
        if (TextBox5.Text == "" && TextBox6.Text != "")
        {
            sqlInsert = "insert into [new_order]([orderID],[userID],[shopID],[orderTotalPrice],[shipAddress],[payMethod],[signDate],[tranStatus]) values('" + TextBox1.Text.Trim() + "','" + TextBox2.Text.Trim() + "','" + TextBox3.Text.Trim() + "','" + TextBox4.Text.Trim() + "','" + TextBox7.Text.Trim() + "', '" + DropDownList1.SelectedItem.Text + "', '" + TextBox6.Text.Trim() + "', '" + DropDownList2.SelectedItem.Text + "' )";
        }
        if (TextBox5.Text != "" && TextBox6.Text != "")
        {
            sqlInsert = "insert into [new_order]([orderID],[userID],[shopID],[orderTotalPrice],[shipAddress],[payMethod],[payDate],[signDate],[tranStatus]) values('" + TextBox1.Text.Trim() + "','" + TextBox2.Text.Trim() + "','" + TextBox4.Text.Trim() + "','" + TextBox4.Text.Trim() + "','" + TextBox7.Text.Trim() + "', '" + DropDownList1.SelectedItem.Text + "', '" + TextBox5.Text.Trim() + "', '" + TextBox6.Text.Trim() + "', '" + DropDownList2.SelectedItem.Text + "' )";
        }

        SqlCommand sqlcom1 = new SqlCommand(sqlInsert, conn);   
        sqlcom1.ExecuteNonQuery();
        conn.Close();
        Response.Write("<script>alert('订单添加成功！');location.href='OrderManage.aspx'</script>");
    }

    //搜索按钮
    protected void Button18_Click(object sender, EventArgs e)
    {
        if(this.DropDownList8.SelectedItem.Text== "订单号")
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            string SqlStr1 = $"select [orderID] ,[userID] ,[shopID] ,[orderTotalPrice] ,[shipAddress] ,[payMethod] , CONVERT(varchar(10), [payDate], 120 ) payDate,CONVERT(varchar(10), [signDate], 120 ) signDate,[tranStatus] from [new_order] where orderID= {this.TextBox8.Text.Trim()}";
            SqlDataAdapter data1 = new SqlDataAdapter(SqlStr1, conn);
            DataSet dataset1 = new DataSet();
            data1.Fill(dataset1, "new_order");
            //绑定DataList控件
            GridView1.DataSource = dataset1;
            GridView1.DataKeyNames = new string[] { "orderID" };
            GridView1.DataBind();
        }
        if (this.DropDownList8.SelectedItem.Text == "用户ID")
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            string SqlStr1 = $"select [orderID] ,[userID] ,[shopID] ,[orderTotalPrice] ,[shipAddress] ,[payMethod] , CONVERT(varchar(10), [payDate], 120 ) payDate,CONVERT(varchar(10), [signDate], 120 ) signDate,[tranStatus] from [new_order] where userID= {this.TextBox8.Text.Trim()}";
            SqlDataAdapter data1 = new SqlDataAdapter(SqlStr1, conn);
            DataSet dataset1 = new DataSet();
            data1.Fill(dataset1, "new_order");
            //绑定DataList控件
            GridView1.DataSource = dataset1;
            GridView1.DataKeyNames = new string[] { "orderID" };
            GridView1.DataBind();
        }
    }
}
