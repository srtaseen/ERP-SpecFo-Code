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

public partial class Master_Setup_frmUnit : System.Web.UI.Page
{
    private BLLInventory blinventory = new BLLInventory();
    //protected Button btnClear;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    //protected HtmlForm form1;
    //protected GridView GridView1;
    //protected HtmlHead Head1;
    //protected Label Label2;
    //protected Label Label5;
    //protected Label Label6;
    //protected Label lblErrormsg;
    //protected Label lblunitid;
    private DALInventory mycls = new DALInventory();
    //protected RequiredFieldValidator RequiredFieldValidator5;
    //protected ValidatorCalloutExtender RequiredFieldValidator5_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator6;
    //protected ValidatorCalloutExtender RequiredFieldValidator6_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator7;
    //protected ValidatorCalloutExtender RequiredFieldValidator7_ValidatorCalloutExtender;
    //protected ScriptManager ScriptManager1;
    //protected TextBox txtCode;
    //protected TextBox txtName;
    //protected TextBox txtParameter;
    //protected FilteredTextBoxExtender txtParameter_FilteredTextBoxExtender;
    //protected UpdatePanel UpdatePanel1;

    public void bindgrid()
    {
        this.GridView1.DataSource = this.blinventory.get_InformationdataTable("SELECT [nUnitID], [cUnitCode], [cUnitDes], [nConPara] FROM [Smt_Unit] where cUnitCode<>'-' ORDER BY [cUnitDes]");
        this.GridView1.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.lblunitid.Text = "";
        this.lblErrormsg.Text = "";
        this.txtCode.Text = "";
        this.txtName.Text = "";
        this.txtParameter.Text = "";
        this.btnSave.Text = "Save";
        this.btnSave.ToolTip = "Save";
        this.bindgrid();
        this.txtCode.Enabled = true;
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(this.lblunitid.Text))
        {
            this.mycls.Save_Unit(this.txtCode.Text.Trim(), this.txtName.Text.Trim(), int.Parse(this.txtParameter.Text.Trim()), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        else
        {
            this.mycls.Update_Unit(int.Parse(this.lblunitid.Text), this.txtCode.Text.Trim(), this.txtName.Text.Trim(), int.Parse(this.txtParameter.Text.Trim()), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        if (this.lblErrormsg.Text != "Already Exist")
        {
            this.lblunitid.Text = "";
            this.txtCode.Text = "";
            this.txtName.Text = "";
            this.txtParameter.Text = "";
            this.txtCode.Focus();
            this.bindgrid();
            this.btnSave.Text = "Save";
            this.btnSave.ToolTip = "Save";
            this.txtCode.Enabled = true;
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
            string statement = "SELECT [nUnitID], [cUnitCode], [cUnitDes], [nConPara], [cEntUser], [dEntdt] FROM [Smt_Unit] where nUnitID='" + label.Text + "'";
            DataTable table = this.mycls.get_Alltbl(statement);
            this.txtCode.Text = table.Rows[0]["cUnitCode"].ToString();
            this.txtName.Text = table.Rows[0]["cUnitDes"].ToString();
            this.txtParameter.Text = table.Rows[0]["nConPara"].ToString();
            this.lblunitid.Text = table.Rows[0]["nUnitID"].ToString();
            this.txtCode.Enabled = false;
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
                this.txtCode.Focus();
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
