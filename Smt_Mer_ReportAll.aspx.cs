using AjaxControlToolkit;
using ASP;
using System;
using System.Data;
using System.Text;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Smt_Mer_ReportAll : System.Web.UI.Page
{
    private BLL _bl = new BLL();
    //protected Button btnClear;
    //protected Button btnGenerate;
    //protected ImageButton cal1;
    //protected ImageButton cal2;
    //protected DropDownList drpBuyer;
    //protected DropDownList drpStyle;
    //protected Label Label12;
    //protected Label Label6;
    //protected Label Label7;
    //protected Label Label8;
    private DAL mycls = new DAL();
    //protected RadioButton rdActionStatus;
    //protected RadioButton rdBuyerWise;
    //protected RadioButton rdCostingsummery;
    //protected RadioButton rdD2D;
    //protected RadioButton rdGmtTypeWise;
    //protected RadioButton rdMbuyerorder;
    //protected RadioButton rdOrderInhand;
    //protected RadioButton rdStyleNO;
    //protected RadioButton rdWeeklybuyerorder;
    //protected RequiredFieldValidator RQFormdate;
    //protected ValidatorCalloutExtender RQFormdate_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RQStyleNo;
    //protected ValidatorCalloutExtender RQStyleNo_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RQTodate;
    //protected ValidatorCalloutExtender RQTodate_ValidatorCalloutExtender;
    //protected TextBox txtFormdate;
    //protected CalendarExtender txtFormdate_CalendarExtender;
    //protected TextBox txtTodate;
    //protected CalendarExtender txtTodate_CalendarExtender;
    //protected UpdatePanel updmerrpt;

    public void bind()
    {
        DataSet set = this._bl.get_Informationdataset("Sp_Smt_GetStyleIDForRename '" + this.Session["Uid"].ToString() + "'");
        this.drpStyle.DataSource = set;
        this.drpStyle.DataTextField = "StyleNO";
        this.drpStyle.DataValueField = "StyleID";
        this.drpStyle.DataBind();
        this.drpStyle.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpStyle.SelectedIndex = 0;
    }

    public void Bindstyle()
    {
        this.drpStyle.DataSource = this._bl.get_Informationdataset("Sp_Smt_TNA_GetStyle");
        this.drpStyle.DataTextField = "cStyleNo";
        this.drpStyle.DataValueField = "nStyleID";
        this.drpStyle.DataBind();
        this.drpStyle.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpStyle.SelectedIndex = 0;
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.RQFormdate.Enabled = false;
        this.RQTodate.Enabled = false;
        this.cal1.Enabled = false;
        this.cal2.Enabled = false;
        this.txtFormdate.Text = "";
        this.txtTodate.Text = "";
        this.rdBuyerWise.Checked = false;
        this.rdD2D.Checked = false;
        this.rdGmtTypeWise.Checked = false;
        this.RQStyleNo.Enabled = false;
        this.drpStyle.Enabled = false;
        this.rdStyleNO.Checked = false;
        this.drpStyle.Items.Clear();
        this.btnGenerate.Enabled = false;
        this.btnGenerate.CssClass = "";
        this.drpBuyer.Items.Clear();
        this.drpBuyer.Enabled = false;
        this.rdOrderInhand.Checked = false;
        this.rdCostingsummery.Checked = false;
    }

    protected void btnGenerate_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        if (this.rdD2D.Checked)
        {
            this.mycls.BuyerReport(this.txtFormdate.Text, this.txtTodate.Text);
            DateTime.Parse(this.txtFormdate.Text);
            DateTime.Parse(this.txtTodate.Text);
            this.Session["Param"] = "D2D";
            this.Session["dt1"] = this.txtFormdate.Text;
            this.Session["dt2"] = this.txtTodate.Text;
            this.runjQueryCode("window.open('Report_Merchandising/Smt_MerchandisingReport.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
        }
        if (this.rdBuyerWise.Checked)
        {
            DateTime.Parse(this.txtFormdate.Text);
            DateTime.Parse(this.txtTodate.Text);
            this.mycls.Report_Ordermaster_BuyerWise(this.txtFormdate.Text, this.txtTodate.Text);
            this.Session["Param"] = "BuyerWise";
            this.Session["dt1"] = this.txtFormdate.Text;
            this.Session["dt2"] = this.txtTodate.Text;
            this.runjQueryCode("window.open('Report_Merchandising/Smt_MerchandisingReport.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
        }
        if (this.rdGmtTypeWise.Checked)
        {
            this.mycls.Report_Ordermaster_GmtTypeWise(this.txtFormdate.Text, this.txtTodate.Text);
            DateTime.Parse(this.txtFormdate.Text);
            DateTime.Parse(this.txtTodate.Text);
            this.Session["Param"] = "GmtTyewise";
            this.Session["dt1"] = this.txtFormdate.Text;
            this.Session["dt2"] = this.txtTodate.Text;
            this.runjQueryCode("window.open('Report_Merchandising/Smt_MerchandisingReport.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
        }
        if (this.rdStyleNO.Checked)
        {
            this.Session["Param"] = "StyleNo";
            this.Session["stid"] = this.drpStyle.SelectedValue;
            this.runjQueryCode("window.open('Report_Merchandising/Smt_MerchandisingReport.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
        }
        if (this.rdActionStatus.Checked)
        {
            this.Session["Param"] = "TNA";
            this.Session["stid"] = this.drpStyle.SelectedValue;
            this.runjQueryCode("window.open('Report_Merchandising/Smt_MerchandisingReport.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
        }
        if (this.rdOrderInhand.Checked)
        {
            this.Session["Param"] = "OrdInhnd";
            this.Session["dtS"] = this.txtFormdate.Text;
            this.Session["dtE"] = this.txtTodate.Text;
            this.Session["BirID"] = this.drpBuyer.SelectedValue;
            this.runjQueryCode("window.open('Report_Merchandising/Smt_MerchandisingReport.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
        }
        if (this.rdMbuyerorder.Checked)
        {
            this.Session["Param"] = "BuyerOrder";
            this.Session["dtS"] = this.txtFormdate.Text;
            this.Session["dtE"] = this.txtTodate.Text;
            this.runjQueryCode("window.open('Report_Merchandising/Smt_MerchandisingReport.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
            this.Session["BirID"] = this.drpBuyer.SelectedValue;
        }
        if (this.rdCostingsummery.Checked)
        {
            this.Session["Param"] = "Prjordsm";
            this.Session["dtS"] = this.txtFormdate.Text;
            this.Session["dtE"] = this.txtTodate.Text;
            this.runjQueryCode("window.open('Report_Merchandising/Smt_MerchandisingReport.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
        }
        if (this.rdWeeklybuyerorder.Checked)
        {
            this.mycls.BuyerReportweekly(this.txtFormdate.Text, this.txtTodate.Text);
            this.Session["Param"] = "buyerweekly";
            this.Session["dtS"] = this.txtFormdate.Text;
            this.Session["dtE"] = this.txtTodate.Text;
            this.runjQueryCode("window.open('Report_Merchandising/Smt_MerchandisingReport.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
        }
    }

    public string dateformat(string datefiled)
    {
        string str = datefiled;
        char[] separator = new char[] { '/' };
        string[] strArray = str.Split(separator);
        string str2 = strArray[0];
        string str3 = strArray[1];
        string str4 = strArray[2];
        return (str3 + "/" + str2 + "/" + str4);
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
            this.btnGenerate.Enabled = false;
            this.btnGenerate.CssClass = "";
        }
    }

    protected void rdActionStatus_CheckedChanged(object sender, EventArgs e)
    {
        this.Bindstyle();
        this.RQFormdate.Enabled = false;
        this.RQTodate.Enabled = false;
        this.cal1.Enabled = false;
        this.cal2.Enabled = false;
        this.txtFormdate.Text = "";
        this.txtTodate.Text = "";
        this.drpStyle.Enabled = true;
        this.RQStyleNo.Enabled = true;
        this.btnGenerate.Enabled = true;
        this.btnGenerate.CssClass = "button";
    }

    protected void rdBuyerWise_CheckedChanged(object sender, EventArgs e)
    {
        this.RQFormdate.Enabled = true;
        this.RQTodate.Enabled = true;
        this.cal1.Enabled = true;
        this.cal2.Enabled = true;
        this.btnGenerate.Enabled = true;
        this.btnGenerate.CssClass = "button";
        this.txtFormdate.Text = "";
        this.txtTodate.Text = "";
        this.drpStyle.Items.Clear();
        this.drpStyle.Enabled = false;
        this.drpBuyer.Items.Clear();
        this.drpBuyer.Enabled = false;
    }

    protected void rdCostingsummery_CheckedChanged(object sender, EventArgs e)
    {
        this.RQFormdate.Enabled = true;
        this.RQTodate.Enabled = true;
        this.cal1.Enabled = true;
        this.cal2.Enabled = true;
        this.btnGenerate.Enabled = true;
        this.btnGenerate.CssClass = "button";
        this.txtFormdate.Text = "";
        this.txtTodate.Text = "";
        this.drpStyle.Items.Clear();
        this.drpStyle.Enabled = false;
        this.RQStyleNo.Enabled = false;
        this.drpBuyer.Enabled = false;
        this.drpBuyer.Items.Clear();
    }

    protected void rdD2D_CheckedChanged(object sender, EventArgs e)
    {
        this.RQFormdate.Enabled = true;
        this.RQTodate.Enabled = true;
        this.cal1.Enabled = true;
        this.cal2.Enabled = true;
        this.btnGenerate.Enabled = true;
        this.btnGenerate.CssClass = "button";
        this.txtFormdate.Text = "";
        this.txtTodate.Text = "";
        this.drpStyle.Items.Clear();
        this.drpStyle.Enabled = false;
        this.RQStyleNo.Enabled = false;
        this.drpBuyer.Items.Clear();
        this.drpBuyer.Enabled = false;
    }

    protected void rdGmtTypeWise_CheckedChanged(object sender, EventArgs e)
    {
        this.RQFormdate.Enabled = true;
        this.RQTodate.Enabled = true;
        this.cal1.Enabled = true;
        this.cal2.Enabled = true;
        this.btnGenerate.Enabled = true;
        this.btnGenerate.CssClass = "button";
        this.txtFormdate.Text = "";
        this.txtTodate.Text = "";
        this.drpStyle.Items.Clear();
        this.drpStyle.Enabled = false;
        this.RQStyleNo.Enabled = false;
        this.drpBuyer.Items.Clear();
        this.drpBuyer.Enabled = false;
    }

    protected void rdMbuyerorder_CheckedChanged(object sender, EventArgs e)
    {
        this.RQFormdate.Enabled = true;
        this.RQTodate.Enabled = true;
        this.cal1.Enabled = true;
        this.cal2.Enabled = true;
        this.btnGenerate.Enabled = true;
        this.btnGenerate.CssClass = "button";
        this.txtFormdate.Text = "";
        this.txtTodate.Text = "";
        this.drpStyle.Items.Clear();
        this.drpStyle.Enabled = false;
        this.RQStyleNo.Enabled = false;
        this.drpBuyer.Enabled = true;
        this.drpBuyer.DataSource = this._bl.get_InformationdataTable("select nBuyer_ID,cBuyer_Name from Smt_BuyerName where cBuyer_Name<>'-' order by cBuyer_Name");
        this.drpBuyer.DataTextField = "cBuyer_Name";
        this.drpBuyer.DataValueField = "nBuyer_ID";
        this.drpBuyer.DataBind();
        this.drpBuyer.Items.Insert(0, new ListItem("ALL", "0"));
        this.drpBuyer.SelectedIndex = 0;
    }

    protected void rdOrderInhand_CheckedChanged(object sender, EventArgs e)
    {
        this.RQFormdate.Enabled = true;
        this.RQTodate.Enabled = true;
        this.cal1.Enabled = true;
        this.cal2.Enabled = true;
        this.btnGenerate.Enabled = true;
        this.btnGenerate.CssClass = "button";
        this.txtFormdate.Text = "";
        this.txtTodate.Text = "";
        this.drpStyle.Items.Clear();
        this.drpStyle.Enabled = false;
        this.RQStyleNo.Enabled = false;
        this.drpBuyer.Enabled = true;
        this.drpBuyer.DataSource = this._bl.get_InformationdataTable("select nBuyer_ID,cBuyer_Name from Smt_BuyerName where cBuyer_Name<>'-' order by cBuyer_Name");
        this.drpBuyer.DataTextField = "cBuyer_Name";
        this.drpBuyer.DataValueField = "nBuyer_ID";
        this.drpBuyer.DataBind();
        this.drpBuyer.Items.Insert(0, new ListItem("ALL", "0"));
        this.drpBuyer.SelectedIndex = 0;
    }

    protected void rdStyleNO_CheckedChanged(object sender, EventArgs e)
    {
        this.RQFormdate.Enabled = false;
        this.RQTodate.Enabled = false;
        this.cal1.Enabled = false;
        this.cal2.Enabled = false;
        this.txtFormdate.Text = "";
        this.txtTodate.Text = "";
        this.bind();
        this.drpStyle.Enabled = true;
        this.RQStyleNo.Enabled = true;
        this.btnGenerate.Enabled = true;
        this.btnGenerate.CssClass = "button";
        this.drpBuyer.Items.Clear();
        this.drpBuyer.Enabled = false;
    }

    protected void rdWeeklybuyerorder_CheckedChanged(object sender, EventArgs e)
    {
        this.RQFormdate.Enabled = true;
        this.RQTodate.Enabled = true;
        this.cal1.Enabled = true;
        this.cal2.Enabled = true;
        this.btnGenerate.Enabled = true;
        this.btnGenerate.CssClass = "button";
        this.txtFormdate.Text = "";
        this.txtTodate.Text = "";
        this.drpStyle.Items.Clear();
        this.drpStyle.Enabled = false;
        this.RQStyleNo.Enabled = false;
        this.drpBuyer.Enabled = false;
        this.drpBuyer.Items.Clear();
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