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


public partial class Master_Setup_frmShade : System.Web.UI.Page
{
    //protected Button btnClear;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    //protected HtmlForm form1;
    //protected GridView GridView1;
    //protected HtmlHead Head1;
    //protected Label Label1;
    //protected Label lblErrormsg;
    //protected Label lblfabshadeid;
    private BLL mybll = new BLL();
    private DAL mycls = new DAL();
    //protected RequiredFieldValidator RequiredFieldValidator1;
    //protected ValidatorCalloutExtender RequiredFieldValidator1_ValidatorCalloutExtender;
    //protected ScriptManager ScriptManager1;
    //protected TextBox txtShade;
    //protected UpdatePanel UpdatePanel1;

    public void bindgrid()
    {
        this.GridView1.DataSource = this.mybll.get_InformationdataTable("SELECT [nshcode], [cShade], [cEntUser], [dEntDt] FROM [Smt_Fabshade] where cShade<>'-'");
        this.GridView1.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.lblfabshadeid.Text = "";
        this.txtShade.Text = "";
        this.txtShade.Focus();
        this.bindgrid();
        this.btnSave.Text = "Save";
        this.txtShade.Enabled = true;
        this.btnSave.Enabled = true;
        this.lblErrormsg.Text = "";
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(this.lblfabshadeid.Text))
        {
            this.mycls.Save_Fabeshade(this.txtShade.Text.Trim().ToUpper(), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        else
        {
            this.mycls.Update_Fabeshade(int.Parse(this.lblfabshadeid.Text), this.txtShade.Text.Trim().ToUpper(), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        if (this.lblErrormsg.Text != "Already Exist")
        {
            this.bindgrid();
            this.txtShade.Text = "";
            this.txtShade.Focus();
            this.lblfabshadeid.Text = "";
            this.btnSave.Text = "Save";
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
            Label label = (Label)this.GridView1.Rows[num].Cells[1].FindControl("lblid");
            DataSet set = this.mybll.get_Informationdataset("select nshcode,cShade from Smt_Fabshade where nshcode='" + int.Parse(label.Text) + "'");
            this.txtShade.Text = set.Tables[0].Rows[0]["cShade"].ToString();
            this.lblfabshadeid.Text = set.Tables[0].Rows[0]["nshcode"].ToString();
            if (this.txtShade.Text == "-")
            {
                this.txtShade.Enabled = false;
                this.btnSave.Enabled = false;
            }
            else
            {
                this.txtShade.Enabled = true;
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
                this.txtShade.Focus();
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
