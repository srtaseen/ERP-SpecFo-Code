using AjaxControlToolkit;
using ASP;
using System;
using System.Data;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Master_Setup_frmPaymentMode : System.Web.UI.Page
{
    //protected Button btnClear1;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    private ClsCommercial csCom = new ClsCommercial();
    //protected HtmlForm form1;
    //protected GridView GridView1;
    //protected HtmlHead Head1;
    //protected Label Label1;
    //protected Label lblErrormsg;
    //protected Label lblFloorid;
    private BLL mybll = new BLL();
    private DAL mycls = new DAL();
    //protected RequiredFieldValidator RequiredFieldValidator2;
    //protected ValidatorCalloutExtender RequiredFieldValidator2_ValidatorCalloutExtender;
    //protected ScriptManager ScriptManager1;
    //protected TextBox txtFloor;
    //protected UpdatePanel UpdatePanel1;

    public void bindgrid()
    {
        this.GridView1.DataSource = this.mybll.get_InformationdataTable("SELECT [PM_NO], [Payment_Mode], [Created_User], [Created_Date] FROM [Smt_PaymentMode] where Payment_Mode<>'-' ORDER BY [Payment_Mode]");
        this.GridView1.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.lblErrormsg.Text = "";
        this.bindgrid();
        this.txtFloor.Focus();
        this.txtFloor.Text = "";
        this.lblFloorid.Text = "";
        this.btnSave.Text = "Save";
        this.btnSave.ToolTip = "Save";
        this.txtFloor.Enabled = true;
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(this.lblFloorid.Text))
        {
            this.csCom.Save_PaymentMode(this.txtFloor.Text.Trim(), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        else
        {
            this.csCom.Update_PaymentMode(int.Parse(this.lblFloorid.Text), this.txtFloor.Text.Trim(), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        if (this.lblErrormsg.Text != "Already Exist")
        {
            this.txtFloor.Text = "";
            this.lblFloorid.Text = "";
            this.bindgrid();
            this.btnSave.Text = "Save";
            this.btnSave.ToolTip = "Save";
        }
        this.txtFloor.Focus();
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
            this.txtFloor.Enabled = true;
            this.lblErrormsg.Text = "";
            int num = int.Parse(e.CommandArgument.ToString());
            Label label = (Label)this.GridView1.Rows[num].FindControl("lblid");
            string statement = "SELECT [PM_NO], [Payment_Mode], [Created_User], [Created_Date] FROM [Smt_PaymentMode] where PM_NO='" + label.Text + "'";
            DataTable table = this.mycls.get_Alltbl(statement);
            this.lblFloorid.Text = table.Rows[0]["PM_NO"].ToString();
            this.txtFloor.Text = table.Rows[0]["Payment_Mode"].ToString();
            this.btnSave.Text = "Update";
            this.btnSave.ToolTip = "Update";
            this.lblErrormsg.Text = "";
            if (this.txtFloor.Text == "-")
            {
                this.txtFloor.Enabled = false;
            }
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.Session["Uid"] == null)
        {
            base.Response.Redirect("~/Smt_Login.aspx", false);
        }
        else if (!base.IsPostBack)
        {
            this.mybll.ClearErrormsg(this, this.lblErrormsg);
            this.bindgrid();
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
