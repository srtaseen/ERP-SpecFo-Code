using AjaxControlToolkit;
using ASP;
using System;
using System.Data;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Master_Setup_frmBrand : System.Web.UI.Page
{
    private BLL _bl = new BLL();
    //protected Button btnClear;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    //protected HtmlForm form1;
    //protected GridView GridView1;
    //protected Label Label1;
    //protected Label lblBrandID;
    //protected Label lblErrormsg;
    private DAL mycls = new DAL();
    //protected RequiredFieldValidator RequiredFieldValidator2;
    //protected ValidatorCalloutExtender RequiredFieldValidator2_ValidatorCalloutExtender;
    //protected ScriptManager ScriptManager1;
    //protected TextBox txtBrandName;
    //protected UpdatePanel UpdatePanel1;

    public void bindgrid()
    {
        this.GridView1.DataSource = this._bl.get_InformationdataTable("SELECT [nBrand_ID], [cBrand_Name], [cEntUser], [dEntdt] FROM [Smt_Brand] ORDER BY [cBrand_Name]");
        this.GridView1.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.txtBrandName.Text = "";
        this.txtBrandName.Focus();
        this.lblErrormsg.Text = "";
        this.lblBrandID.Text = "";
        this.btnSave.Text = "Save";
        this.btnSave.ToolTip = "Save";
        this.GridView1.DataSource = null;
        this.GridView1.DataBind();
        this.btnSave.CssClass = "button";
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(this.lblBrandID.Text))
        {
            this.mycls.Save_Brand(this.txtBrandName.Text.Trim(), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        else
        {
            this.mycls.Update_Brand(int.Parse(this.lblBrandID.Text), this.txtBrandName.Text.Trim(), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        if (this.lblErrormsg.Text != "Already Exist")
        {
            this.txtBrandName.Text = "";
            this.txtBrandName.Focus();
            this.lblBrandID.Text = "";
            this.btnSave.Text = "Save";
            this.btnSave.ToolTip = "Save";
            this.bindgrid();
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
            Label label = (Label)this.GridView1.Rows[num].Cells[1].FindControl("lblId");
            string statement = "select nBrand_ID,cBrand_Name from Smt_Brand where nBrand_ID='" + label.Text + "'";
            DataTable table = this.mycls.get_Alltbl(statement);
            this.txtBrandName.Text = table.Rows[0]["cBrand_Name"].ToString();
            this.lblBrandID.Text = table.Rows[0]["nBrand_ID"].ToString();
            this.btnSave.Text = "Update";
            this.btnSave.ToolTip = "Update";
            this.lblErrormsg.Text = "";
            if (this.txtBrandName.Text == "-")
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
