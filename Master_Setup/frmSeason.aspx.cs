using AjaxControlToolkit;
using ASP;
using System;
using System.Data;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Master_Setup_frmSeason : System.Web.UI.Page
{
    private BLL _bll = new BLL();
    //protected Button btnClear;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    //protected HtmlForm form1;
    //protected GridView GridView1;
    //protected Label Label1;
    //protected Label lblErrormsg;
    //protected Label lblSeasonID;
    private DAL mycls = new DAL();
    //protected RequiredFieldValidator RequiredFieldValidator1;
    //protected ValidatorCalloutExtender RequiredFieldValidator1_ValidatorCalloutExtender;
    //protected ScriptManager ScriptManager1;
    //protected TextBox txtSeason;
    //protected UpdatePanel UpdatePanel1;

    public void bindgrid()
    {
        this.GridView1.DataSource = this._bll.get_InformationdataTable("SELECT [nSeason_ID], [cSeason_Name], [cEntUser], [cEntdt] FROM [Smt_Season] where cSeason_Name<>'-' ORDER BY [cSeason_Name] ");
        this.GridView1.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.lblErrormsg.Text = "";
        this.lblSeasonID.Text = "";
        this.txtSeason.Text = "";
        this.txtSeason.Focus();
        this.btnSave.Text = "Save";
        this.btnSave.ToolTip = "Save";
        this.bindgrid();
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(this.lblSeasonID.Text))
        {
            this.mycls.Save_Season(this.txtSeason.Text.Trim(), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        else
        {
            this.mycls.Update_Season(int.Parse(this.lblSeasonID.Text), this.txtSeason.Text.Trim(), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        if (this.lblErrormsg.Text != "Already Exist")
        {
            this.bindgrid();
            this.txtSeason.Text = "";
            this.txtSeason.Focus();
            this.btnSave.Text = "Save";
            this.btnSave.ToolTip = "Save";
        }
        this.txtSeason.Focus();
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
            Label label = (Label)this.GridView1.Rows[num].Cells[1].FindControl("lblid");
            string statement = "select nSeason_ID,cSeason_Name from Smt_Season where nSeason_ID='" + label.Text + "'";
            DataTable table = this.mycls.get_Alltbl(statement);
            this.txtSeason.Text = table.Rows[0]["cSeason_Name"].ToString();
            this.lblSeasonID.Text = table.Rows[0]["nSeason_ID"].ToString();
            this.btnSave.Text = "Update";
            this.btnSave.ToolTip = "Update";
            this.lblErrormsg.Text = "";
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!base.IsPostBack)
        {
            this.bindgrid();
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
