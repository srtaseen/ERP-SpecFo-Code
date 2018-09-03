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

public partial class Master_Setup_frmCompany : System.Web.UI.Page
{
    private BLL _bl = new BLL();
    //protected Button btnClear;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    //protected HtmlForm form1;
    //protected GridView GridView1;
    //protected HtmlHead Head1;
    //protected Label Label1;
    //protected Label Label2;
    //protected Label Label4;
    //protected Label lblErrormsg;
    //protected Label lblid;
    private DAL mycls = new DAL();
    //protected RequiredFieldValidator RequiredFieldValidator1;
    //protected ValidatorCalloutExtender RequiredFieldValidator1_ValidatorCalloutExtender;
    //protected ScriptManager ScriptManager1;
    //protected TextBox txtAddress1;
    //protected TextBox txtAddress2;
    //protected TextBox txtCompanyname;
    //protected UpdatePanel UpdatePanel1;

    public void bindgrid()
    {
        this.GridView1.DataSource = this._bl.get_InformationdataTable("SELECT [nCompanyID], [cCmpName], [cAdd1], [cAdd2] FROM [Smt_Company] where cCmpName<>'-' ORDER BY [cCmpName] ");
        this.GridView1.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.txtAddress1.Text = "";
        this.txtAddress2.Text = "";
        this.txtCompanyname.Text = "";
        this.txtCompanyname.Focus();
        this.GridView1.DataSource = null;
        this.GridView1.DataBind();
        this.lblid.Text = "";
        this.lblErrormsg.Text = "";
        this.btnSave.Text = "Save";
        this.btnSave.ToolTip = "Save";
        this.txtCompanyname.Enabled = true;
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(this.lblid.Text))
        {
            this.mycls.Save_CompanyInfo(this.txtCompanyname.Text.Trim(), this.txtAddress1.Text.Trim(), this.txtAddress2.Text.Trim(), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        else
        {
            this.mycls.Update_CompanyInfo(int.Parse(this.lblid.Text), this.txtCompanyname.Text.Trim(), this.txtAddress1.Text.Trim(), this.txtAddress2.Text.Trim(), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        if (this.lblErrormsg.Text != "Already Exist")
        {
            this.bindgrid();
            this.txtCompanyname.Text = "";
            this.txtAddress1.Text = "";
            this.txtAddress2.Text = "";
            this.btnSave.Text = "Save";
            this.btnSave.ToolTip = "Save";
            this.lblid.Text = "";
            this.txtCompanyname.Enabled = true;
        }
        this.txtCompanyname.Focus();
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
            string statement = "select nCompanyID,cCmpName,cAdd1,cAdd2 from Smt_Company where nCompanyID='" + label.Text + "'";
            DataTable table = this.mycls.get_Alltbl(statement);
            this.lblid.Text = table.Rows[0]["nCompanyID"].ToString();
            this.txtCompanyname.Text = table.Rows[0]["cCmpName"].ToString();
            this.txtCompanyname.Enabled = false;
            this.txtAddress1.Text = table.Rows[0]["cAdd1"].ToString();
            this.txtAddress2.Text = table.Rows[0]["cAdd2"].ToString();
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
                this.txtCompanyname.Focus();
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
