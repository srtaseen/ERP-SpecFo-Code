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

public partial class Master_Setup_frmArticle : System.Web.UI.Page
{
    private BLLInventory blInventory = new BLLInventory();
    //protected Button btnClear;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    private DALInventory dlInventory = new DALInventory();
    //protected DropDownList drpMaincategoryArticle;
    //protected HtmlForm form1;
    //protected GridView GridView1;
    //protected HtmlHead Head1;
    //protected Label Label1;
    //protected Label Label2;
    //protected Label lblArticleID;
    //protected Label lblErrormsg;
    private BLL mybll = new BLL();
    //protected RequiredFieldValidator RequiredFieldValidator1;
    //protected ValidatorCalloutExtender RequiredFieldValidator1_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator3;
    //protected ValidatorCalloutExtender RequiredFieldValidator3_ValidatorCalloutExtender;
    //protected ScriptManager ScriptManager1;
    //protected TextBox txtArticle;
    //protected FilteredTextBoxExtender txtArticle_FilteredTextBoxExtender;
    //protected UpdatePanel UpdatePanel1;

    public void bindgrid()
    {
        this.GridView1.DataSource = this.blInventory.get_InformationdataTable("SELECT [nArtCode], [cArticle], [cMainCategory] FROM [View_Smt_Article] where nMainCatID='" + this.drpMaincategoryArticle.SelectedValue + "' ORDER BY [nArtCode] DESC");
        this.GridView1.DataBind();
    }

    public void BindMainCat(string Param)
    {
        DataSet set = this.blInventory.get_Informationdataset("Sp_Smt_FactoryPurchase_GetMainCat '" + Param + "'");
        this.drpMaincategoryArticle.DataSource = set;
        this.drpMaincategoryArticle.DataTextField = "cMainCategory";
        this.drpMaincategoryArticle.DataValueField = "nMainCategory_ID";
        this.drpMaincategoryArticle.DataBind();
        this.drpMaincategoryArticle.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpMaincategoryArticle.SelectedIndex = 0;
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.txtArticle.Text = "";
        this.drpMaincategoryArticle.SelectedValue = "";
        this.GridView1.DataSource = null;
        this.GridView1.DataBind();
        this.lblErrormsg.Text = "";
        this.btnSave.Enabled = true;
        this.btnSave.Text = "Save";
        this.btnSave.ToolTip = "Save";
        this.lblArticleID.Text = "";
        this.btnSave.CssClass = "button";
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(this.lblArticleID.Text))
        {
            this.dlInventory.Update_Article(int.Parse(this.lblArticleID.Text), this.txtArticle.Text.Trim(), int.Parse(this.drpMaincategoryArticle.SelectedValue), this.drpMaincategoryArticle.SelectedItem.Text, this.lblErrormsg);
        }
        else
        {
            this.dlInventory.Save_Article(this.txtArticle.Text.Trim(), int.Parse(this.drpMaincategoryArticle.SelectedValue), this.drpMaincategoryArticle.SelectedItem.Text, this.lblErrormsg);
        }
        if (this.lblErrormsg.Text != "Already Exist")
        {
            this.bindgrid();
            this.txtArticle.Text = "";
            this.lblArticleID.Text = "";
        }
    }

    protected void drpMaincategoryArticle_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.bindgrid();
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        this.GridView1.PageIndex = e.NewPageIndex;
        this.bindgrid();
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Select")
        {
            int num = int.Parse(e.CommandArgument.ToString());
            Label label = (Label)this.GridView1.Rows[num].FindControl("lblid");
            string statement = "select nArtCode,cArticle,nMainCatID from Smt_Artcle where nArtCode='" + label.Text + "'";
            DataTable table = this.dlInventory.get_Alltbl(statement);
            this.drpMaincategoryArticle.SelectedValue = table.Rows[0]["nMainCatID"].ToString();
            this.lblArticleID.Text = table.Rows[0]["nArtCode"].ToString();
            this.txtArticle.Text = table.Rows[0]["cArticle"].ToString();
            this.lblErrormsg.Text = "";
            if (this.txtArticle.Text == "-")
            {
                this.btnSave.Enabled = false;
                this.btnSave.CssClass = "";
            }
            else
            {
                this.btnSave.Enabled = true;
                this.btnSave.CssClass = "button";
            }
            this.btnSave.Text = "Update";
            this.btnSave.ToolTip = "Update";
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.Session["Uid"] == null)
        {
            base.Response.Redirect("../Smt_Login.aspx", false);
        }
        else
        {
            if (!base.IsPostBack)
            {
                string str = base.Request.QueryString["C"];
                if (!string.IsNullOrEmpty(str))
                {
                    this.BindMainCat(str);
                }
                else
                {
                    this.dlInventory.drp_Maincategory(this.drpMaincategoryArticle);
                }
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