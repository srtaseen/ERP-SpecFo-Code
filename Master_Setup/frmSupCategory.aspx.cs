using AjaxControlToolkit;
using ASP;
using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Master_Setup_frmSupCategory : System.Web.UI.Page
{
    private BLLInventory _blinventory = new BLLInventory();
    //protected Button btnClear;
    //protected Button btnhide;
    //protected ConfirmButtonExtender btnhide_ConfirmButtonExtender;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    private DALInventory dlinventory = new DALInventory();
    //protected DropDownList drpmaincategory;
    //protected DropDownList drpUnit;
    //protected HtmlForm form1;
    //protected GridView GridView1;
    //protected HtmlHead Head1;
    //protected Label Label3;
    //protected Label Label4;
    //protected Label Label5;
    //protected Label lblColorid;
    //protected Label lblErrormsg;
    private BLL mybll = new BLL();
    private DAL mycls = new DAL();
    //protected RequiredFieldValidator RequiredFieldValidator4;
    //protected ValidatorCalloutExtender RequiredFieldValidator4_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator5;
    //protected ValidatorCalloutExtender RequiredFieldValidator5_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator6;
    //protected ValidatorCalloutExtender RequiredFieldValidator6_ValidatorCalloutExtender;
    //protected ScriptManager ScriptManager1;
    //protected TextBox txtItemname;
    //protected UpdatePanel UpdatePanel1;

    public void bindgrid()
    {
        this.GridView1.DataSource = this._blinventory.get_InformationdataTable("SELECT [cCode], [cDes], [cMainCategory], [cUnitCode], [nConPara],Act_sts FROM [View_Smt_Subcategory] where cManCode='" + this.drpmaincategory.SelectedValue + "' order by cDes");
        this.GridView1.DataBind();
    }

    public void BindMainCat(string Param)
    {
        DataSet set = this._blinventory.get_Informationdataset("Sp_Smt_FactoryPurchase_GetMainCat '" + Param + "'");
        this.drpmaincategory.DataSource = set;
        this.drpmaincategory.DataTextField = "cMainCategory";
        this.drpmaincategory.DataValueField = "nMainCategory_ID";
        this.drpmaincategory.DataBind();
        this.drpmaincategory.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpmaincategory.SelectedIndex = 0;
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.drpmaincategory.SelectedValue = "";
        this.drpUnit.SelectedValue = "";
        this.GridView1.DataSource = null;
        this.GridView1.DataBind();
        this.txtItemname.Text = "";
        this.lblErrormsg.Text = "";
        this.btnhide.Enabled = false;
        this.btnhide.CssClass = "buttonD";
    }

    protected void btnhide_Click(object sender, EventArgs e)
    {
        this.dlinventory.Subcat_hideun(this.drpmaincategory.SelectedValue);
        for (int i = 0; i < this.GridView1.Rows.Count; i++)
        {
            Label label = (Label)this.GridView1.Rows[i].FindControl("lblid");
            CheckBox box = (CheckBox)this.GridView1.Rows[i].FindControl("cbSelect");
            if (box.Checked)
            {
                this.dlinventory.Subcat_hide(this.drpmaincategory.SelectedValue, label.Text, this.lblErrormsg);
            }
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        this.dlinventory.Save_Newitem(this.txtItemname.Text.Trim(), this.drpmaincategory.SelectedValue, this.Session["Uid"].ToString(), this.drpUnit.SelectedValue, this.lblErrormsg);
        if (this.lblErrormsg.Text != "Already Exist")
        {
            this.bindgrid();
            this.drpUnit.SelectedValue = "";
            this.txtItemname.Text = "";
        }
    }

    protected void drpmaincategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.bindgrid();
        if (this.GridView1.Rows.Count > 0)
        {
            this.btnhide.Enabled = true;
            this.btnhide.CssClass = "button";
        }
        this.drpUnit.SelectedValue = "";
        this.txtItemname.Text = "";
        this.lblErrormsg.Text = "";
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        this.GridView1.PageIndex = e.NewPageIndex;
        this.bindgrid();
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            CheckBox box = (CheckBox)e.Row.FindControl("cbSelect");
            if (box.Checked)
            {
                e.Row.BackColor = Color.Pink;
                e.Row.ToolTip = "Item Status:Hide";
            }
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.Session["Uid"] == null)
        {
            base.Response.Redirect("Smt_Login.aspx", false);
        }
        else
        {
            if (!base.IsPostBack)
            {
                string str = base.Request.QueryString["C"];
                if (!string.IsNullOrEmpty(str))
                {
                    this.BindMainCat(str);
                }
                else
                {
                    this.dlinventory.drp_Maincategory(this.drpmaincategory);
                }
                this.btnhide.Enabled = false;
                this.btnhide.CssClass = "buttonD";
                this.dlinventory.drp_Unit(this.drpUnit);
            }
            Thread.Sleep(200);
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
