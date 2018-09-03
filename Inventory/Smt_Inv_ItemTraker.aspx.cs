using ASP;
using C1.Web.UI.Controls.C1GridView;
using System;
using System.Text;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Inventory_Smt_Inv_ItemTraker : System.Web.UI.Page
{
    private BLLInventory _blInventory = new BLLInventory();
    private DALInventory _dlinventory = new DALInventory();
    //protected DropDownList drpComp;
    //protected DropDownList drpMaincat;
    //protected DropDownList drpSubCat;
    //protected C1.Web.UI.Controls.C1GridView.C1GridView grdItemTracker;
    //protected UpdatePanel UpdatePanel1;

    public void bindcomp()
    {
        this.drpComp.DataSource = this._blInventory.get_InformationdataTable("goodstrnsfr_getcomp");
        this.drpComp.DataTextField = "cCmpName";
        this.drpComp.DataValueField = "nCompanyID";
        this.drpComp.DataBind();
        this.drpComp.Items.Insert(0, string.Empty);
    }

    public void bindgrid()
    {
        this.grdItemTracker.DataSource = this._blInventory.get_InformationdataTable("ItemTracket_getItem " + this.drpComp.SelectedValue + "," + this.drpMaincat.SelectedValue + "," + this.drpSubCat.SelectedValue);
        this.grdItemTracker.DataBind();
    }

    public void bindMcat()
    {
        this.drpMaincat.DataSource = this._blInventory.get_InformationdataTable("goodstrnsfr_getmcat " + this.drpComp.SelectedValue);
        this.drpMaincat.DataTextField = "cMainCategory";
        this.drpMaincat.DataValueField = "MCatid";
        this.drpMaincat.DataBind();
        this.drpMaincat.Items.Insert(0, string.Empty);
    }

    public void bindsubcat()
    {
        this.drpSubCat.DataSource = this._blInventory.get_InformationdataTable("goodstrnsfr_getsubcat " + this.drpComp.SelectedValue + "," + this.drpMaincat.SelectedValue);
        this.drpSubCat.DataTextField = "cDes";
        this.drpSubCat.DataValueField = "cCode";
        this.drpSubCat.DataBind();
        this.drpSubCat.Items.Insert(0, string.Empty);
    }

    protected void drpComp_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.drpMaincat.Items.Clear();
        this.drpSubCat.Items.Clear();
        this.grdItemTracker.DataSource = null;
        this.grdItemTracker.DataBind();
        if (!string.IsNullOrEmpty(this.drpComp.SelectedValue))
        {
            this.bindMcat();
        }
    }

    protected void drpMaincat_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.drpSubCat.Items.Clear();
        this.grdItemTracker.DataSource = null;
        this.grdItemTracker.DataBind();
        if (!string.IsNullOrEmpty(this.drpMaincat.SelectedValue))
        {
            this.bindsubcat();
        }
    }

    protected void drpSubCat_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.grdItemTracker.DataSource = null;
        this.grdItemTracker.DataBind();
        if (!string.IsNullOrEmpty(this.drpSubCat.SelectedValue))
        {
            this.bindgrid();
        }
    }

    private string getjQueryCode(string jsCodetoRun)
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine("$(document).ready(function() {");
        builder.AppendLine(jsCodetoRun);
        builder.AppendLine(" });");
        return builder.ToString();
    }

    protected void grdItemTracker_Filtering(object sender, C1GridViewFilterEventArgs e)
    {
        this.bindgrid();
    }

    protected void grdItemTracker_PageIndexChanging(object sender, C1GridViewPageEventArgs e)
    {
        this.grdItemTracker.PageIndex = e.NewPageIndex;
        this.bindgrid();
    }

    protected void grdItemTracker_RowDataBound(object sender, C1GridViewRowEventArgs e)
    {
        if (e.Row.RowType == C1GridViewRowType.DataRow)
        {
            e.Row.Cells[0].Width = 40;
        }
    }

    protected void lnkEBIN_Click(object sender, EventArgs e)
    {
        C1GridViewRow parent = ((LinkButton)sender).Parent.Parent as C1GridViewRow;
        LinkButton button = (LinkButton)parent.FindControl("lnkEBIN");
        string str = parent.Cells[4].Text.Trim();
        Label label = (Label)parent.FindControl("lblUnit");
        this._dlinventory.EbinRpt(int.Parse(button.CommandArgument));
        this.Session["Param"] = "EBIN";
        this.Session["itm"] = str;
        this.Session["Unit"] = label.Text.Trim();
        this.Session["Itmcode"] = button.CommandArgument;
        this.runjQueryCode("window.open('Smt_Inv_ReportDisplay.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
    }

    protected void lnkGrn_Click(object sender, EventArgs e)
    {
        C1GridViewRow parent = ((LinkButton)sender).Parent.Parent as C1GridViewRow;
        LinkButton button = (LinkButton)parent.FindControl("lnkGrn");
        this.Session["Itmcode"] = button.CommandArgument;
        this.runjQueryCode("window.open('Smt_Inv_ItemtrackingGrn.aspx','popup','location=1,status=1,left=100,top=100,scrollbars=1,width=820,height=480')");
    }

    protected void lnkIssue_Click(object sender, EventArgs e)
    {
        C1GridViewRow parent = ((LinkButton)sender).Parent.Parent as C1GridViewRow;
        LinkButton button = (LinkButton)parent.FindControl("lnkIssue");
        this.Session["Itmcode"] = button.CommandArgument;
        this.runjQueryCode("window.open('Smt_Inv_ItemtrackingIssue.aspx','popup','location=1,status=1,left=100,top=100,scrollbars=1,width=820,height=480')");
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!base.IsPostBack)
        {
            this.bindcomp();
        }
    }

    private void runjQueryCode(string jsCodetoRun)
    {
        ScriptManager current = ScriptManager.GetCurrent(this);
        if ((current != null) && current.IsInAsyncPostBack)
        {
            ScriptManager.RegisterClientScriptBlock((Page)this, typeof(Page), Guid.NewGuid().ToString(), this.getjQueryCode(jsCodetoRun), true);
        }
        else
        {
            base.ClientScript.RegisterClientScriptBlock(typeof(Page), Guid.NewGuid().ToString(), this.getjQueryCode(jsCodetoRun), true);
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
