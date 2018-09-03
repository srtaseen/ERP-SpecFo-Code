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

public partial class Master_Setup_frmMainCategory : System.Web.UI.Page
{
    private BLLInventory _blInventoru = new BLLInventory();
    //protected Button btnClear;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    private DALInventory dlinventory = new DALInventory();
    //protected DropDownList drpMasterCategory;
    //protected HtmlForm form1;
    //protected GridView GridView1;
    //protected HtmlHead Head1;
    //protected Label Label3;
    //protected Label Label4;
    //protected Label lblErrormsg;
    //protected Label lblid;
    private DAL mycls = new DAL();
    //protected RequiredFieldValidator RequiredFieldValidator3;
    //protected ValidatorCalloutExtender RequiredFieldValidator3_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator4;
    //protected ValidatorCalloutExtender RequiredFieldValidator4_ValidatorCalloutExtender;
    //protected ScriptManager ScriptManager1;
    //protected TextBox txtMainCategory;
    //protected UpdatePanel UpdatePanel1;

    public void bindgrid()
    {
        this.GridView1.DataSource = this._blInventoru.get_InformationdataTable("SELECT [nMainCategory_ID], [cMainCategory], [cMasterCategory], [cEntUser], [dEntdt] FROM [View_Smt_Maincategory] where nMasterCategory_ID='" + this.drpMasterCategory.SelectedValue + "' ORDER BY [cMasterCategory]");
        this.GridView1.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.lblErrormsg.Text = "";
        this.txtMainCategory.Text = "";
        this.drpMasterCategory.SelectedValue = "";
        this.lblErrormsg.Text = "";
        this.btnSave.Text = "Save";
        this.btnSave.ToolTip = "Save";
        this.lblid.Text = "";
        this.GridView1.DataSource = null;
        this.GridView1.DataBind();
        this.btnSave.CssClass = "button";
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(this.lblid.Text))
        {
            this.dlinventory.Save_MainCategory(this.txtMainCategory.Text.Trim(), int.Parse(this.drpMasterCategory.SelectedValue), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        else
        {
            this.dlinventory.Update_MainCategory(int.Parse(this.lblid.Text), this.txtMainCategory.Text.Trim(), int.Parse(this.drpMasterCategory.SelectedValue), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        if (this.lblErrormsg.Text != "Already Exist")
        {
            this.txtMainCategory.Text = "";
            this.lblid.Text = "";
            this.bindgrid();
        }
    }

    protected void drpMasterCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.bindgrid();
        this.txtMainCategory.Text = "";
        this.txtMainCategory.Focus();
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        this.lblErrormsg.Text = "";
        this.GridView1.PageIndex = e.NewPageIndex;
        this.bindgrid();
    }

    protected void GridView1_PreRender(object sender, EventArgs e)
    {
        MergeRow(this.GridView1);
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Select")
        {
            int num = int.Parse(e.CommandArgument.ToString());
            Label label = (Label)this.GridView1.Rows[num].FindControl("lblid");
            string statement = "select nMainCategory_ID,cMainCategory,nMasterCategory_ID from Smt_MainCategory where nMainCategory_ID='" + label.Text + "'";
            DataTable table = this.dlinventory.get_Alltbl(statement);
            this.txtMainCategory.Text = table.Rows[0]["cMainCategory"].ToString();
            this.drpMasterCategory.SelectedValue = table.Rows[0]["nMasterCategory_ID"].ToString();
            this.lblid.Text = table.Rows[0]["nMainCategory_ID"].ToString();
            this.btnSave.Text = "Update";
            this.btnSave.ToolTip = "Update";
            this.lblErrormsg.Text = "";
            if (this.txtMainCategory.Text == "-")
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

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Cells[0].Enabled = false;
            e.Row.Cells[3].Attributes.Add("style", "text-align:center");
        }
    }

    public static void MergeRow(GridView gridView)
    {
        for (int i = gridView.Rows.Count - 2; i >= 0; i--)
        {
            GridViewRow row = gridView.Rows[i];
            GridViewRow row2 = gridView.Rows[i + 1];
            if (row.Cells[3].Text == row2.Cells[3].Text)
            {
                row.Cells[3].RowSpan = (row2.Cells[3].RowSpan < 2) ? 2 : (row2.Cells[3].RowSpan + 1);
                row2.Cells[3].Visible = false;
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
                this.txtMainCategory.Focus();
                this.mycls.drp_MasterCategory(this.drpMasterCategory);
            }
            Thread.Sleep(200);
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
