using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterBusiness : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //System.Text.Encoding enc = System.Text.Encoding.GetEncoding("gb2312");
        this.Label1.Text = "欢迎商家" + Request.Cookies["Uname"].Value.Trim() + "!";
    }


    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {

    }
}
