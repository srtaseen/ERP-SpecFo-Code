using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Smt_Mainhome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.Session["Uid"]==null)
        {
            base.Response.Redirect("Smt_Login.aspx", false);
        }
    }
}