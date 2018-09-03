using AjaxControlToolkit;
using ASP;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Smt_Login : System.Web.UI.Page
{

    //protected Button btnLogin;
    private SqlConnection cn = GetWay.SpecFoCon;
    //protected HtmlForm form1;
    //protected Label Label1;
    //protected Label Label2;
    //protected Label Label3;
    //protected Label Label4;
    //protected Label lblBrowserinfo;
    //protected Label lblcname;
    //protected Label lblComName;
    //protected Label lblErrormsg;
    //protected Label lblJs;
    private BLL mybl = new BLL();
    //private DAL mycls = new DAL();
    //protected RequiredFieldValidator RequiredFieldValidator1;
    //protected ValidatorCalloutExtender RequiredFieldValidator1_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator2;
    //protected ValidatorCalloutExtender RequiredFieldValidator2_ValidatorCalloutExtender;
    //protected ScriptManager ScriptManager1;
    //protected TextBox txtPassword;
    //protected TextBox txtUserid;
    //protected UpdatePanel UpdatePanel1;
    //protected UpdateProgress updateProgress1;



    protected void btnLogin_Click(object sender, EventArgs e)
    {
        this.lblJs.Text = "";
        this.lblErrormsg.Text = "";
        if (string.IsNullOrEmpty(this.txtUserid.Text) || string.IsNullOrEmpty(this.txtPassword.Text))
        {
            this.lblErrormsg.Text = "Enter User ID and Password";
        }
        else
        {
            DataTable table = this.mybl.get_InformationdataTable("Sp_Smt_UserLogin '" + this.txtUserid.Text.Trim() + "','" + this.txtPassword.Text.Trim() + "'");
            if (table.Rows.Count > 0)
            {
                if (table.Rows[0]["Activity_status"].ToString() == "A")
                {
                    table.Rows[0]["cUserFullname"].ToString();
                    this.Session["UName"] = table.Rows[0]["cUserFullname"].ToString();
                    this.Session["Uid"] = this.txtUserid.Text.Trim();
                    this.Session["UGroup"] = table.Rows[0]["nUgroup"].ToString();
                    this.Session["UGroupName"] = table.Rows[0]["cGrpDescription"].ToString();
                    this.Session["CompID"] = table.Rows[0]["nCompanyID"].ToString();
                    this.Session["POPrint"] = null;
                    if (((this.Session["UGroupName"].ToString() == "Merchandising") || (this.Session["UGroupName"].ToString() == "MERCHANDISING")) || (this.Session["UGroupName"].ToString() == "merchandising"))
                    {
                        if (this.mybl.get_InformationdataTable("Sp_Smt_TNA_POwisetask_Merchntaction '" + this.Session["Uid"].ToString() + "'").Rows.Count > 0)
                        {
                            base.Response.Redirect("Smt_TNAMerchandising.aspx");
                        }
                        else
                        {
                            base.Response.Redirect("Smt_Mainhome.aspx");
                        }
                    }
                    else if ((this.Session["UGroupName"].ToString() == "Admin") || (this.Session["UGroupName"].ToString() == "ADMIN"))
                    {
                        base.Response.Redirect("Smt_Dashboards.aspx");
                    }
                    else
                    {
                        base.Response.Redirect("Smt_Mainhome.aspx");
                    }
                }
                else
                {
                    this.lblErrormsg.Text = "You are inactive user.Plseas contact with administrator";
                }
            }
            else
            {
                this.lblErrormsg.Text = "Invalid User";
            }
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!base.IsPostBack)
        {
            this.txtUserid.Focus();
            string str = base.Request.QueryString["x"];
            string str2 = base.Request.QueryString["xlof"];
            DataTable table = this.mybl.get_InformationdataTable("select cCmpName from Smt_Company where Display_AS_Header=1");
            if (table.Rows.Count > 0)
            {
                this.lblComName.Text = table.Rows[0]["cCmpName"].ToString();
            }
            if (str2 == "1")
            {
                this.Page.Response.Cache.SetCacheability(HttpCacheability.NoCache);
                this.lblJs.Text = "THANKS FOR VISITING SPECFO RMG SYSTEM";
                base.Response.Redirect("Smt_Login.aspx");
                this.Session["Uid"] = null;
                this.Session.Abandon();
            }
            if (str == "1")
            {
                this.lblJs.Text = "JavaScript Disabled.Please Enable JavaScript first";
            }
        }
        Thread.Sleep(200);
    }

    //protected global_asax ApplicationInstance
    //{
    //    get
    //    {
    //        return (global_asax)this.Context.ApplicationInstance;
    //    }
    //}

    //protected DefaultProfile Profile
    //{
    //    get
    //    {
    //        return (DefaultProfile)this.Context.Profile;
    //    }
    //}
}
