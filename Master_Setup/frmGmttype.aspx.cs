using AjaxControlToolkit;
using ASP;
using System;
using System.Data;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Master_Setup_frmGmttype : System.Web.UI.Page
{
    private BLL _bll = new BLL();
    //protected Button btnClear;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    //protected HtmlForm form1;
    //protected GridView GridView1;
    //protected HtmlHead Head1;
    //protected Label Label1;
    //protected Label lblErrormsg;
    //protected Label lblTypeID;
    private DAL mycls = new DAL();
    //protected RequiredFieldValidator RequiredFieldValidator2;
    //protected ValidatorCalloutExtender RequiredFieldValidator2_ValidatorCalloutExtender;
    //protected ScriptManager ScriptManager1;
    //protected TextBox txtType;
    //protected UpdatePanel UpdatePanel1;

    public void bindgrid()
    {
        this.GridView1.DataSource = this._bll.get_InformationdataTable("SELECT [nGmtCode], [cGmetDis], [cEntUser], [dEntDate] FROM [Smt_GmtType] where cGmetDis<>'-' ORDER BY [cGmtCd] DESC");
        this.GridView1.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.lblTypeID.Text = "";
        this.txtType.Text = "";
        this.txtType.Focus();
        this.btnSave.Text = "Save";
        this.btnSave.ToolTip = "Save";
        this.btnSave.Enabled = true;
        this.lblErrormsg.Text = "";
        this.bindgrid();
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(this.lblTypeID.Text))
        {
            this.mycls.Update_GarmentType(int.Parse(this.lblTypeID.Text), this.txtType.Text.Trim(), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        else
        {
            this.mycls.Save_GarmentType(this.txtType.Text.Trim(), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        if (this.lblErrormsg.Text != "Already Exist")
        {
            this.txtType.Text = "";
            this.lblTypeID.Text = "";
            this.bindgrid();
            this.btnSave.Text = "Save";
            this.btnSave.ToolTip = "Save";
        }
        this.txtType.Focus();
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
            string statement = "select nGmtCode,cGmetDis from Smt_GmtType where nGmtCode='" + int.Parse(label.Text) + "'";
            DataTable table = this.mycls.get_Alltbl(statement);
            this.txtType.Text = table.Rows[0]["cGmetDis"].ToString();
            this.lblTypeID.Text = table.Rows[0]["nGmtCode"].ToString();
            if (this.txtType.Text == "-")
            {
                this.txtType.Enabled = false;
                this.btnSave.Enabled = false;
            }
            else
            {
                this.txtType.Enabled = true;
                this.btnSave.Enabled = true;
            }
            this.btnSave.Text = "Update";
            this.btnSave.ToolTip = "Update";
            this.lblErrormsg.Text = "";
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!base.IsPostBack)
        {
            this.txtType.Focus();
            this.bindgrid();
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}