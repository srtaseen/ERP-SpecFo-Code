using AjaxControlToolkit;
using ASP;
using C1.Web.UI.Controls.C1GridView;
using System;
using System.Data;
using System.Threading;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Master_Setup_frmSection : System.Web.UI.Page
{
    //protected Button btnClear;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    //protected C1.Web.UI.Controls.C1GridView.C1GridView C1GridView1;
    //protected DropDownList drpCompany;
    //protected DropDownList drpDepartment;
    //protected HtmlForm form1;
    //protected HtmlHead Head1;
    //protected Label Label1;
    //protected Label Label2;
    //protected Label Label3;
    //protected Label Label6;
    //protected Label Label7;
    //protected Label lblErrormsg;
    //protected Label lblsectid;
    private BLL mybll = new BLL();
    private DAL mycls = new DAL();
    //protected RequiredFieldValidator RequiredFieldValidator1;
    //protected ValidatorCalloutExtender RequiredFieldValidator1_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator2;
    //protected ValidatorCalloutExtender RequiredFieldValidator2_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator3;
    //protected ValidatorCalloutExtender RequiredFieldValidator3_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator4;
    //protected ValidatorCalloutExtender RequiredFieldValidator4_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator5;
    //protected ValidatorCalloutExtender RequiredFieldValidator5_ValidatorCalloutExtender;
    //protected ScriptManager ScriptManager1;
    //protected TextBox txtCarder;
    //protected FilteredTextBoxExtender txtCarder_FilteredTextBoxExtender;
    //protected TextBox txtSection;
    //protected TextBox txtSupervisor;
    //protected UpdatePanel UpdatePanel1;

    public void bindgrid()
    {
        this.C1GridView1.DataSource = this.mybll.get_InformationdataTable("SELECT [nSectionID], [cSection_Description], [cDeptname], [cCmpName],[cSupervisor] FROM [View_Smt_Section] where cSection_Description<>'-' ORDER BY [cSection_Description]");
        this.C1GridView1.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.lblErrormsg.Text = "";
        this.bindgrid();
        this.txtCarder.Text = "";
        this.txtSection.Text = "";
        this.txtSupervisor.Text = "";
        this.drpCompany.SelectedValue = "";
        this.drpDepartment.Items.Clear();
        this.drpDepartment.Focus();
        this.lblsectid.Text = "";
        this.btnSave.Text = "Save";
        this.btnSave.ToolTip = "Save";
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(this.lblsectid.Text))
        {
            this.mycls.Save_Section(this.txtSection.Text.Trim(), int.Parse(this.drpDepartment.SelectedValue), int.Parse(this.txtCarder.Text), int.Parse(this.drpCompany.SelectedValue), this.txtSupervisor.Text.Trim(), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        else
        {
            this.mycls.Update_Section(int.Parse(this.lblsectid.Text), this.txtSection.Text.Trim(), int.Parse(this.drpDepartment.SelectedValue), int.Parse(this.txtCarder.Text), int.Parse(this.drpCompany.SelectedValue), this.txtSupervisor.Text.Trim(), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        if (this.lblErrormsg.Text != "Already Exist")
        {
            this.bindgrid();
            this.txtCarder.Text = "";
            this.txtSection.Text = "";
            this.txtSupervisor.Text = "";
            this.drpCompany.SelectedValue = "";
            this.drpDepartment.Items.Clear();
            this.btnSave.Text = "Save";
            this.btnSave.ToolTip = "Save";
        }
    }

    protected void C1GridView1_PageIndexChanging(object sender, C1GridViewPageEventArgs e)
    {
        this.lblErrormsg.Text = "";
        this.C1GridView1.PageIndex = e.NewPageIndex;
        this.bindgrid();
    }

    protected void C1GridView1_RowCommand(object sender, C1GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Select")
        {
            int num = int.Parse(e.CommandArgument.ToString());
            Label label = (Label)this.C1GridView1.Rows[num].Cells[1].FindControl("lblid");
            string statement = "select * from Smt_Section where nSectionID=" + label.Text;
            DataTable table = this.mycls.get_Alltbl(statement);
            this.lblsectid.Text = table.Rows[0]["nSectionID"].ToString();
            this.drpCompany.SelectedValue = table.Rows[0]["nCompanyID"].ToString();
            this.drpDepartment.DataSource = this.mybll.get_Informationdataset("select nUserDept,cDeptname from Smt_Department where nCompanyID=" + this.drpCompany.SelectedValue + " order by cDeptname");
            this.drpDepartment.DataTextField = "cDeptname";
            this.drpDepartment.DataValueField = "nUserDept";
            this.drpDepartment.DataBind();
            this.drpDepartment.SelectedValue = table.Rows[0]["nUserDept"].ToString();
            this.txtCarder.Text = table.Rows[0]["nCarder"].ToString();
            this.txtSection.Text = table.Rows[0]["cSection_Description"].ToString();
            this.txtSupervisor.Text = table.Rows[0]["cSupervisor"].ToString();
            this.btnSave.Text = "Update";
            this.btnSave.ToolTip = "Update";
            this.lblErrormsg.Text = "";
        }
    }

    protected void C1GridView1_RowDataBound(object sender, C1GridViewRowEventArgs e)
    {
        e.Row.Cells[0].Width = 50;
    }

    protected void drpCompany_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.drpDepartment.Items.Clear();
        if (!string.IsNullOrEmpty(this.drpCompany.SelectedValue))
        {
            this.drpDepartment.DataSource = this.mybll.get_Informationdataset("select nUserDept,cDeptname from Smt_Department where nCompanyID=" + this.drpCompany.SelectedValue + " order by cDeptname");
            this.drpDepartment.DataTextField = "cDeptname";
            this.drpDepartment.DataValueField = "nUserDept";
            this.drpDepartment.DataBind();
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
                this.mycls.drp_Company(this.drpCompany);
                this.mybll.ClearErrormsg(this, this.lblErrormsg);
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