using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

public partial class StockManage : System.Web.UI.Page
{
    public static string constr = ConfigurationManager.ConnectionStrings["Shopping_platformConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)  //判断是否首次加载
        {
            loadData();
        }
    }

    void loadData()
    {
        SqlConnection conn = new SqlConnection(constr);
        conn.Open();
        string SqlStr1 = $"select [stockID] ,[comID] ,[comName] ,[stockSurplus] , CONVERT(varchar(10), [inDate], 120 ) inDate,CONVERT(varchar(10), [outDate], 120 ) outDate,[stockFlag] from [webStockTable]";
        SqlDataAdapter data1 = new SqlDataAdapter(SqlStr1, conn);
        DataSet dataset1 = new DataSet();
        data1.Fill(dataset1, "webStockTable");
        //绑定DataList控件
        GridView1.DataSource = dataset1;
        GridView1.DataKeyNames = new string[] { "stockID" };
        GridView1.DataBind();

        string SqlStr2 = $"select [stockID] ,[comID] ,[comName] ,[stockSurplus] , CONVERT(varchar(10), [inDate], 120 ) inDate,CONVERT(varchar(10), [outDate], 120 ) outDate,[stockFlag] from [webStockTable] where stockFlag='待入库'";
        SqlDataAdapter data2 = new SqlDataAdapter(SqlStr2, conn);
        DataSet dataset2 = new DataSet();
        data2.Fill(dataset2, "webStockTable");
        //绑定DataList控件
        GridView2.DataSource = dataset2;
        GridView2.DataKeyNames = new string[] { "stockID" };
        GridView2.DataBind();

        string SqlStr3 = $"select [stockID] ,[comID] ,[comName] ,[stockSurplus] , CONVERT(varchar(10), [inDate], 120 ) inDate,CONVERT(varchar(10), [outDate], 120 ) outDate,[stockFlag] from [webStockTable] where stockFlag='已入库'";
        SqlDataAdapter data3 = new SqlDataAdapter(SqlStr3, conn);
        DataSet dataset3 = new DataSet();
        data3.Fill(dataset3, "webStockTable");
        //绑定DataList控件
        GridView3.DataSource = dataset3;
        GridView3.DataKeyNames = new string[] { "stockID" };
        GridView3.DataBind();

        string SqlStr4 = $"select [stockID] ,[comID] ,[comName] ,[stockSurplus] , CONVERT(varchar(10), [inDate], 120 ) inDate,CONVERT(varchar(10), [outDate], 120 ) outDate,[stockFlag] from [webStockTable] where stockFlag='已出库'";
        SqlDataAdapter data4 = new SqlDataAdapter(SqlStr4, conn);
        DataSet dataset4 = new DataSet();
        data4.Fill(dataset4, "webStockTable");
        //绑定DataList控件
        GridView4.DataSource = dataset4;
        GridView4.DataKeyNames = new string[] { "stockID" };
        GridView4.DataBind();

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
        
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        SqlConnection conn = new SqlConnection(constr);
        conn.Open();
        string orderID = GridView1.DataKeys[e.RowIndex].Value.ToString();
        string SqlStr = $"delete from new_order where orderID=" + "'" + orderID + "'";
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
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        loadData();
        //GridView1.PageIndex = e.NewPageIndex;
        //GridView1.DataBind();
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        //索引编辑时
        this.GridView1.EditIndex = e.NewEditIndex;
        loadData();
    }

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
        loadData();
    }

    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        this.GridView1.EditIndex = -1;
        loadData();
    }
}