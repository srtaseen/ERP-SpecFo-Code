using AjaxControlToolkit;
using ASP;
using System;
using System.Data;
using System.Threading;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Master_Setup_frmCountry : System.Web.UI.Page
{
    private BLL _bll = new BLL();
    //protected Button btnClear;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    //protected HtmlForm form1;
    //protected GridView GridView1;
    //protected HtmlHead Head1;
    //protected Label Label1;
    //protected Label lblcid;
    //protected Label lblErrormsg;
    private DAL mycls = new DAL();
    //protected RequiredFieldValidator RequiredFieldValidator1;
    //protected ValidatorCalloutExtender RequiredFieldValidator1_ValidatorCalloutExtender;
    //protected ScriptManager ScriptManager1;
    //protected TextBox txtCountryname;
    //protected UpdatePanel UpdatePanel1;

    public void bindgrid()
    {
        this.GridView1.DataSource = this._bll.get_InformationdataTable("SELECT [nConCode], [cConDes], [dEntDate], [cCntcd] FROM [Smt_Counrys] where cConDes<>'-' ORDER BY [nConCode] DESC");
        this.GridView1.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.txtCountryname.Focus();
        this.txtCountryname.Text = "";
        this.GridView1.DataSource = null;
        this.GridView1.DataBind();
        this.lblcid.Text = "";
        this.btnSave.Text = "Save";
        this.btnSave.ToolTip = "Save";
        this.lblErrormsg.Text = "";
        this.btnSave.Enabled = true;
        this.txtCountryname.Enabled = true;
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(this.lblcid.Text))
        {
            this.mycls.Save_Country(this.txtCountryname.Text.Trim(), this.lblErrormsg);
        }
        else
        {
            this.mycls.Update_Country(int.Parse(this.lblcid.Text), this.txtCountryname.Text.Trim(), this.lblErrormsg);
        }
        if (this.lblErrormsg.Text != "Already Exist")
        {
            this.bindgrid();
            this.txtCountryname.Focus();
            this.txtCountryname.Text = "";
            this.lblcid.Text = "";
            this.btnSave.Text = "Save";
            this.btnSave.ToolTip = "Save";
        }
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        this.lblErrormsg.Text = "";
        this.GridView1.PageIndex = e.NewPageIndex;
        this.bindgrid();
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Select")
        {
            int num = int.Parse(e.CommandArgument.ToString());
            Label label = (Label)this.GridView1.Rows[num].FindControl("lblid");
            string statement = "select nConCode,cConDes from Smt_Counrys where nConCode='" + label.Text + "'";
            DataTable table = this.mycls.get_Alltbl(statement);
            this.txtCountryname.Text = table.Rows[0]["cConDes"].ToString();
            this.lblcid.Text = table.Rows[0]["nConCode"].ToString();
            if (this.txtCountryname.Text == "-")
            {
                this.txtCountryname.Enabled = false;
                this.btnSave.Enabled = false;
            }
            else
            {
                this.txtCountryname.Enabled = true;
                this.btnSave.Enabled = true;
            }
            this.btnSave.Text = "Update";
            this.btnSave.ToolTip = "Update";
            this.lblErrormsg.Text = "";
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
                this.txtCountryname.Focus();
                this.bindgrid();
            }
            Thread.Sleep(200);
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
