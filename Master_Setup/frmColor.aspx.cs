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

public partial class Master_Setup_frmColor : System.Web.UI.Page
{
    private BLL _bl = new BLL();
    //protected Button btnClear;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    //protected HtmlForm form1;
    //protected GridView GridView1;
    //protected HtmlHead Head1;
    //protected Label Label2;
    //protected Label lblColorid;
    //protected Label lblErrormsg;
    private DAL mycls = new DAL();
    //protected RequiredFieldValidator RequiredFieldValidator1;
    //protected ValidatorCalloutExtender RequiredFieldValidator1_ValidatorCalloutExtender;
    //protected ScriptManager ScriptManager1;
    //protected TextBox txtColor;
    //protected UpdatePanel UpdatePanel1;

    public void bindgrid()
    {
        this.GridView1.DataSource = this._bl.get_InformationdataTable("SELECT [nColNo], [cColour], [cEntUser], [dEntdt] FROM [Smt_Colours] where cColour<>'-' ORDER BY [cColour] ");
        this.GridView1.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.txtColor.Focus();
        this.txtColor.Text = "";
        this.lblErrormsg.Text = "";
        this.GridView1.DataSource = null;
        this.GridView1.DataBind();
        this.lblColorid.Text = "";
        this.btnSave.Text = "Save";
        this.btnSave.ToolTip = "Save";
        this.lblColorid.Text = "";
        this.txtColor.Enabled = true;
        this.btnSave.Enabled = true;
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(this.lblColorid.Text))
        {
            this.mycls.Save_Color(this.txtColor.Text.Trim(), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        else
        {
            this.mycls.Update_Color(int.Parse(this.lblColorid.Text), this.txtColor.Text.Trim(), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        if (this.lblErrormsg.Text != "Already Exist")
        {
            this.bindgrid();
            this.txtColor.Focus();
            this.txtColor.Text = "";
            this.lblColorid.Text = "";
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
            DataTable table = this._bl.get_InformationdataTable("select nColNo,cColour from Smt_Colours where nColNo=" + label.Text);
            this.txtColor.Text = table.Rows[0]["cColour"].ToString();
            this.lblColorid.Text = table.Rows[0]["nColNo"].ToString();
            if (this.txtColor.Text == "-")
            {
                this.txtColor.Enabled = false;
                this.btnSave.Enabled = false;
            }
            else
            {
                this.txtColor.Enabled = true;
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
            base.Response.Redirect("../Smt_Login.aspx", false);
        }
        else
        {
            if (!base.IsPostBack)
            {
                this.txtColor.Focus();
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
