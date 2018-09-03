using AjaxControlToolkit;
using ASP;
using System;
using System.Text;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Production_DailyFinalrpt : System.Web.UI.Page
{
    //protected Button btnreport;
    //protected DropDownList drpCompany;
    private DAL mycls = new DAL();
    //protected RequiredFieldValidator RequiredFieldValidator1;
    //protected ValidatorCalloutExtender RequiredFieldValidator1_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator2;
    //protected ValidatorCalloutExtender RequiredFieldValidator2_ValidatorCalloutExtender;
    //protected TextBox txtDate;
    //protected CalendarExtender txtDate_CalendarExtender;
    //protected UpdatePanel UpdatePanel1;

    protected void btnreport_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        if (!string.IsNullOrEmpty(this.drpCompany.SelectedValue) && !string.IsNullOrEmpty(this.txtDate.Text))
        {
            this.Session["comp"] = this.drpCompany.SelectedValue;
            this.Session["dat"] = this.txtDate.Text;
            this.Session["cmpname"] = this.drpCompany.SelectedItem.Text;
            this.runjQueryCode("window.open('Dailyfinlrpt.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
        }
        else
        {
            label.Text = "First Select Style";
        }
    }

    protected void btnRmgsum_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        if (!string.IsNullOrEmpty(this.drpCompany.SelectedValue) && !string.IsNullOrEmpty(this.txtDate.Text))
        {
            this.Session["comp"] = this.drpCompany.SelectedValue;
            this.Session["dat"] = this.txtDate.Text;
            this.runjQueryCode("window.open('Rmgprodsum.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
        }
        else
        {
            label.Text = "First Select Style";
        }
    }

    private string getjQueryCode(string jsCodetoRun)
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine("$(document).ready(function() {");
        builder.AppendLine(jsCodetoRun);
        builder.AppendLine(" });");
        return builder.ToString();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!base.IsPostBack)
        {
            this.mycls.drp_Company(this.drpCompany);
        }
    }

    private void runjQueryCode(string jsCodetoRun)
    {
        ScriptManager current = ScriptManager.GetCurrent(this);
        if ((current != null) && current.IsInAsyncPostBack)
        {
            ScriptManager.RegisterClientScriptBlock((Page)this, typeof(Page), Guid.NewGuid().ToString(), this.getjQueryCode(jsCodetoRun), true);
        }
        else
        {
            base.ClientScript.RegisterClientScriptBlock(typeof(Page), Guid.NewGuid().ToString(), this.getjQueryCode(jsCodetoRun), true);
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
