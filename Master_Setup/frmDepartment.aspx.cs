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

public partial class Master_Setup_frmDepartment : System.Web.UI.Page
{
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    //protected DropDownList drpcompany;
    //protected HtmlForm form1;
    //protected GridView GridView1;
    //protected HtmlHead Head1;
    //protected Label Label1;
    //protected Label Label2;
    //protected Label lbldeptid;
    //protected Label lblErrormsg;
    private BLL mybll = new BLL();
    private DAL mycls = new DAL();
    //protected RequiredFieldValidator RequiredFieldValidator1;
    //protected ValidatorCalloutExtender RequiredFieldValidator1_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator2;
    //protected ValidatorCalloutExtender RequiredFieldValidator2_ValidatorCalloutExtender;
    //protected ScriptManager ScriptManager1;
    //protected TextBox txtDepartment;
    //protected UpdatePanel UpdatePanel1;

    public void bind()
    {
        this.GridView1.DataSource = this.mybll.get_Informationdataset("Sp_Smt_Department_Get '0'");
        this.GridView1.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.txtDepartment.Text = "";
        this.drpcompany.SelectedValue = "";
        this.lbldeptid.Text = "";
        this.GridView1.DataSource = null;
        this.GridView1.DataBind();
        this.btnSave.Text = "Save";
        this.btnSave.ToolTip = "Save";
        this.lblErrormsg.Text = "";
        this.btnSave.CssClass = "button";
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(this.lbldeptid.Text))
        {
            this.mycls.Save_Department(this.txtDepartment.Text.Trim(), int.Parse(this.drpcompany.SelectedValue), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        else
        {
            this.mycls.Update_Department(int.Parse(this.lbldeptid.Text), this.txtDepartment.Text.Trim(), int.Parse(this.drpcompany.SelectedValue), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        if (this.lblErrormsg.Text != "Already Exist")
        {
            this.txtDepartment.Text = "";
            this.lbldeptid.Text = "";
            this.btnSave.Text = "Save";
            this.btnSave.ToolTip = "Save";
            this.GridView1.DataSource = this.mybll.get_Informationdataset("Sp_Smt_Department_Get '" + this.drpcompany.SelectedValue + "'");
            this.GridView1.DataBind();
        }
        this.txtDepartment.Focus();
    }

    protected void drpcompany_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.GridView1.DataSource = this.mybll.get_Informationdataset("Sp_Smt_Department_Get '" + this.drpcompany.SelectedValue + "'");
        this.GridView1.DataBind();
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        this.GridView1.PageIndex = e.NewPageIndex;
        this.GridView1.DataSource = this.mybll.get_Informationdataset("Sp_Smt_Department_Get '" + this.drpcompany.SelectedValue + "'");
        this.GridView1.DataBind();
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Select")
        {
            int num = int.Parse(e.CommandArgument.ToString());
            Label label = (Label)this.GridView1.Rows[num].FindControl("lblid");
            string statement = "SELECT nUserDept,cDeptname,nCompanyID from Smt_Department where nUserDept='" + label.Text + "'";
            DataTable table = this.mycls.get_Alltbl(statement);
            this.lbldeptid.Text = table.Rows[0]["nUserDept"].ToString();
            this.txtDepartment.Text = table.Rows[0]["cDeptname"].ToString();
            this.drpcompany.SelectedValue = table.Rows[0]["nCompanyID"].ToString();
            this.btnSave.Text = "Update";
            this.btnSave.ToolTip = "Update";
            this.lblErrormsg.Text = "";
            if (this.txtDepartment.Text == "-")
            {
                this.btnSave.Enabled = false;
                this.btnSave.CssClass = "";
            }
            else
            {
                this.btnSave.Enabled = true;
                this.btnSave.CssClass = "button";
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
                this.txtDepartment.Focus();
                this.mycls.drp_Company(this.drpcompany);
                this.mybll.ClearErrormsg(this, this.lblErrormsg);
            }
            Thread.Sleep(200);
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
