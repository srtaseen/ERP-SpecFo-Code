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

public partial class Master_Setup_frmDimension : System.Web.UI.Page
{
    private BLLInventory blInventory = new BLLInventory();
    //protected Button btnClear;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    private DALInventory dlInventory = new DALInventory();
    //protected DropDownList drpmainCat;
    //protected HtmlForm form1;
    //protected GridView GridView1;
    //protected HtmlHead Head1;
    //protected Label Label1;
    //protected Label Label2;
    //protected Label lblDimnID;
    //protected Label lblErrormsg;
    //protected RequiredFieldValidator RequiredFieldValidator1;
    //protected ValidatorCalloutExtender RequiredFieldValidator1_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator2;
    //protected ValidatorCalloutExtender RequiredFieldValidator2_ValidatorCalloutExtender;
    //protected ScriptManager ScriptManager1;
    //protected TextBox txtDimension;
    //protected FilteredTextBoxExtender txtDimension_FilteredTextBoxExtender;
    //protected UpdatePanel UpdatePanel1;

    public void bindgrid()
    {
        this.GridView1.DataSource = this.blInventory.get_InformationdataTable("SELECT [ndCode], [cDimen], [cMainCategory], [nLgth] FROM [View_Smt_Dimension] where nMainCatID='" + this.drpmainCat.SelectedValue + "' ORDER BY [cDimen]");
        this.GridView1.DataBind();
    }

    public void BindMainCat(string Param)
    {
        DataSet set = this.blInventory.get_Informationdataset("Sp_Smt_FactoryPurchase_GetMainCat '" + Param + "'");
        this.drpmainCat.DataSource = set;
        this.drpmainCat.DataTextField = "cMainCategory";
        this.drpmainCat.DataValueField = "nMainCategory_ID";
        this.drpmainCat.DataBind();
        this.drpmainCat.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpmainCat.SelectedIndex = 0;
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.txtDimension.Text = "";
        this.drpmainCat.SelectedValue = "";
        this.GridView1.DataSource = null;
        this.GridView1.DataBind();
        this.lblErrormsg.Text = "";
        this.btnSave.Enabled = true;
        this.btnSave.Text = "Save";
        this.btnSave.ToolTip = "Save";
        this.lblDimnID.Text = "";
        this.btnSave.CssClass = "button";
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(this.lblDimnID.Text))
        {
            this.dlInventory.Update_Dimension(int.Parse(this.lblDimnID.Text), this.txtDimension.Text.Trim(), this.drpmainCat.SelectedItem.Text, int.Parse(this.drpmainCat.SelectedValue), this.lblErrormsg);
        }
        else
        {
            this.dlInventory.Save_Dimension(this.txtDimension.Text.Trim(), this.drpmainCat.SelectedItem.Text, int.Parse(this.drpmainCat.SelectedValue), this.lblErrormsg);
        }
        if (this.lblErrormsg.Text != "Already Exist")
        {
            this.txtDimension.Text = "";
            this.bindgrid();
            this.lblDimnID.Text = "";
        }
    }

    protected void drpmainCat_SelectedIndexChanged(object sender, EventArgs e)
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
            string statement = "select ndCode,cDimen,nMainCatID from Smt_Dimension where ndCode='" + label.Text + "'";
            DataTable table = this.dlInventory.get_Alltbl(statement);
            this.drpmainCat.SelectedValue = table.Rows[0]["nMainCatID"].ToString();
            this.lblDimnID.Text = table.Rows[0]["ndCode"].ToString();
            this.txtDimension.Text = table.Rows[0]["cDimen"].ToString();
            this.lblErrormsg.Text = "";
            if (this.txtDimension.Text == "-")
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
        if (!base.IsPostBack)
        {
            string str = base.Request.QueryString["C"];
            if (!string.IsNullOrEmpty(str))
            {
                this.BindMainCat(str);
            }
            else
            {
                this.dlInventory.drp_Maincategory(this.drpmainCat);
            }
        }
        Thread.Sleep(200);
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
