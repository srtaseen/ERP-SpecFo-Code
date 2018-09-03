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

public partial class Master_Setup_frmDesignation : System.Web.UI.Page
{
    private BLL _bll = new BLL();
    //protected Button btnClear;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    //protected HtmlForm form1;
    //protected GridView GridView1;
    //protected HtmlHead Head1;
    //protected Label Label1;
    //protected Label lbldesiid;
    //protected Label lblErrormsg;
    private DAL mycls = new DAL();
    //protected RequiredFieldValidator RequiredFieldValidator2;
    //protected ValidatorCalloutExtender RequiredFieldValidator2_ValidatorCalloutExtender;
    //protected ScriptManager ScriptManager1;
    //protected TextBox txtDesignation;
    //protected UpdatePanel UpdatePanel1;

    public void bindgrid()
    {
        this.GridView1.DataSource = this._bll.get_InformationdataTable("SELECT [nDesignation_ID], [cDesignation], [cEntUser], [dEntdt] FROM [Smt_Designation] where cDesignation<>'-' ORDER BY [nDesignation_ID] DESC");
        this.GridView1.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.GridView1.DataSource = null;
        this.GridView1.DataBind();
        this.txtDesignation.Focus();
        this.txtDesignation.Text = "";
        this.lblErrormsg.Text = "";
        this.lbldesiid.Text = "";
        this.btnSave.Text = "Save";
        this.btnSave.ToolTip = "Save";
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(this.lbldesiid.Text))
        {
            this.mycls.Save_Desigantion(this.txtDesignation.Text.Trim(), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        else
        {
            this.mycls.Update_Desigantion(int.Parse(this.lbldesiid.Text), this.txtDesignation.Text.Trim(), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        if (this.lblErrormsg.Text != "Already Exist")
        {
            this.bindgrid();
            this.txtDesignation.Focus();
            this.txtDesignation.Text = "";
            this.lbldesiid.Text = "";
            this.btnSave.Text = "Save";
            this.btnSave.ToolTip = "Save";
        }
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Select")
        {
            int num = int.Parse(e.CommandArgument.ToString());
            Label label = (Label)this.GridView1.Rows[num].Cells[1].FindControl("lblid");
            string statement = "select nDesignation_ID,cDesignation from Smt_Designation where nDesignation_ID='" + label.Text + "'";
            DataTable table = this.mycls.get_Alltbl(statement);
            this.txtDesignation.Text = table.Rows[0]["cDesignation"].ToString();
            this.lbldesiid.Text = table.Rows[0]["nDesignation_ID"].ToString();
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
                this.txtDesignation.Focus();
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
