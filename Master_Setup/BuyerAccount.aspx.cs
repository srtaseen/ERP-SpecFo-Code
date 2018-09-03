using AjaxControlToolkit;
using ASP;
using System;
using System.Data.SqlClient;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Master_Setup_BuyerAccount : System.Web.UI.Page
{
    private BLL _bl = new BLL();
    private MC _mc = new MC();
    //protected Button btnClear;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    private SqlConnection cn = GetWay.SpecFoCon;
    //protected CompareValidator CompareValidator1;
    //protected ValidatorCalloutExtender CompareValidator1_ValidatorCalloutExtender1;
    //protected DropDownList drpBrand;
    //protected DropDownList drpBuyer;
    //protected HtmlForm form1;
    //protected GridView GridView1;
    //protected HtmlHead Head1;
    //protected Label lblErrormsg;
    private DAL mycls = new DAL();
    //protected RequiredFieldValidator RequiredFieldValidator2;
    //protected ValidatorCalloutExtender RequiredFieldValidator2_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator3;
    //protected ValidatorCalloutExtender RequiredFieldValidator3_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator4;
    //protected ValidatorCalloutExtender RequiredFieldValidator4_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator5;
    //protected ValidatorCalloutExtender RequiredFieldValidator5_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator6;
    //protected ValidatorCalloutExtender RequiredFieldValidator6_ValidatorCalloutExtender;
    //protected ScriptManager ScriptManager1;
    //protected TextBox txtConfirmpass;
    //protected TextBox txtpass;
    //protected TextBox txtuserid;
    //protected UpdatePanel UpdatePanel1;

    public void bindbrand()
    {
        this.drpBrand.DataSource = this._bl.get_InformationdataTable("Sp_Smt_StyleMaster_getbrandforlogin " + this.drpBuyer.SelectedValue);
        this.drpBrand.DataTextField = "cBrand_Name";
        this.drpBrand.DataValueField = "nBrand_ID";
        this.drpBrand.DataBind();
        this.drpBrand.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpBrand.SelectedIndex = 0;
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.lblErrormsg.Text = "";
        this.drpBuyer.SelectedIndex = 0;
        this.drpBrand.Items.Clear();
        this.txtConfirmpass.Text = "";
        this.txtpass.Text = "";
        this.txtuserid.Text = "";
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        this.cn.Open();
        SqlTransaction tr = this.cn.BeginTransaction();
        try
        {
            string[] normalparam = new string[] { "@BuyerID", "@BrandID", "@UserId", "@B_Password", "@Crtby" };
            string[] normalprmval = new string[] { this.drpBuyer.SelectedValue, this.drpBrand.SelectedValue, this.txtuserid.Text.Trim(), this.txtpass.Text.Trim(), this.Session["Uid"].ToString() };
            this._mc.MC_Save_nodt_tr("Sp_Smt_UserBuyer_Sv", this.cn, tr, normalparam, normalprmval);
            tr.Commit();
            this.lblErrormsg.Text = "Saved Successfully";
            this.drpBuyer.SelectedIndex = 0;
            this.drpBrand.Items.Clear();
            this.txtConfirmpass.Text = "";
            this.txtpass.Text = "";
            this.txtuserid.Text = "";
        }
        catch (Exception exception)
        {
            tr.Rollback();
            this.lblErrormsg.Text = exception.Message;
        }
        finally
        {
            this.cn.Close();
        }
    }

    protected void drpBuyer_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.drpBrand.Items.Clear();
        if (!string.IsNullOrEmpty(this.drpBuyer.SelectedValue))
        {
            this.bindbrand();
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!base.IsPostBack)
        {
            this.mycls.drp_Buyer(this.drpBuyer);
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
