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

public partial class Master_Setup_frmGmtDept : System.Web.UI.Page
{
    private BLL _bll = new BLL();
    //protected Button btnClear;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    //protected HtmlForm form1;
    //protected GridView GridView1;
    //protected HtmlHead Head1;
    //protected Label Label2;
    //protected Label lblDeptid;
    //protected Label lblErrormsg;
    private DAL mycls = new DAL();
    //protected RequiredFieldValidator RequiredFieldValidator2;
    //protected ValidatorCalloutExtender RequiredFieldValidator2_ValidatorCalloutExtender;
    //protected ScriptManager ScriptManager1;
    //protected TextBox txtDepartment;
    //protected UpdatePanel UpdatePanel1;

    public void bindgrid()
    {
        this.GridView1.DataSource = this._bll.get_InformationdataTable("SELECT [nGmt_Dept_ID], [cGmt_Dept_Description], [cEntUser], [dEntdt] FROM [Smt_Gmt_Department] where cGmt_Dept_Description<>'-' ORDER BY [cGmt_Dept_Description] ");
        this.GridView1.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.bindgrid();
        this.txtDepartment.Focus();
        this.txtDepartment.Text = "";
        this.btnSave.Text = "Save";
        this.btnSave.ToolTip = "Save";
        this.lblDeptid.Text = "";
        this.lblErrormsg.Text = "";
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(this.lblDeptid.Text))
        {
            this.mycls.Save_Garmentdept(this.txtDepartment.Text.Trim(), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        else
        {
            this.mycls.Update_Garmentdept(int.Parse(this.lblDeptid.Text), this.txtDepartment.Text.Trim(), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        if (this.lblErrormsg.Text != "Already Exist")
        {
            this.bindgrid();
            this.txtDepartment.Focus();
            this.txtDepartment.Text = "";
            this.lblDeptid.Text = "";
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
            Label label = (Label)this.GridView1.Rows[num].Cells[1].FindControl("lblid");
            string statement = "select nGmt_Dept_ID,cGmt_Dept_Description from Smt_Gmt_Department where nGmt_Dept_ID='" + label.Text + "'";
            DataTable table = this.mycls.get_Alltbl(statement);
            this.txtDepartment.Text = table.Rows[0]["cGmt_Dept_Description"].ToString();
            this.lblDeptid.Text = table.Rows[0]["nGmt_Dept_ID"].ToString();
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
                this.txtDepartment.Focus();
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
