using AjaxControlToolkit;
using ASP;
using C1.Web.UI.Controls.C1GridView;
using C1.Web.UI.Controls.C1TabControl;
using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Inventory_Smt_Inv_Factoryreturn : System.Web.UI.Page
{
    private BLLInventory _blInventory = new BLLInventory();
    private DALInventory _dlInventory = new DALInventory();
    private BLL _mybl = new BLL();
    private DAL _mycls = new DAL();
    //protected Button btnAddItem;
    //protected Button btnClear;
    //protected ConfirmButtonExtender btnGeneratesingle_ConfirmButtonExtender;
    //protected Button btnppadd;
    //protected ModalPopupExtender btnppadd_ModalPopupExtender;
    //protected Button btnSave;
    //protected HtmlInputButton btnstockdtl;
    //protected C1.Web.UI.Controls.C1TabControl.C1TabControl C1Tabcontrol1;
    //protected C1TabPage C1Tabpage1;
    //protected C1TabPage C1Tabpage2;
    //protected DropDownList drpCompany;
    //protected RequiredFieldValidator drpCompany_RequiredFieldValidator5;
    //protected DropDownList drpdept;
    //protected RequiredFieldValidator drpdept_RequiredFieldValidator1;
    //protected ValidatorCalloutExtender drpdept_ValidatorCalloutExtender1;
    //protected DropDownList drpIssueunit;
    //protected DropDownList drpMaincat;
    //protected RequiredFieldValidator drpMaincat_RequiredFieldValidator1;
    //protected ValidatorCalloutExtender drpMaincat_ValidatorCalloutExtender2;
    //protected DropDownList drpSection;
    //protected RequiredFieldValidator drpSection_RequiredFieldValidator1;
    //protected DropDownList drpStyle;
    //protected DropDownList drpSubcat;
    //protected RequiredFieldValidator drpSubcat_RequiredFieldValidator1;
    //protected ValidatorCalloutExtender drpSubcat_ValidatorCalloutExtender2;
    //protected HtmlGenericControl dvtp;
    //protected GridView grdIssuedetails;
    //protected C1.Web.UI.Controls.C1GridView.C1GridView grdIssuegetAll;
    //protected ValidatorCalloutExtender RequiredFieldValidator5_ValidatorCalloutExtender;
    //protected TextBox txtArticle;
    //protected TextBox txtCalcqty;
    //protected TextBox TxtColor;
    //protected TextBox txtDimension;
    //protected TextBox txtIssueparam;
    //protected TextBox txtItemid;
    //protected TextBox txtItemunit;
    //protected TextBox txtQty;
    //protected FilteredTextBoxExtender txtQty_FilteredTextBoxExtender;
    //protected RequiredFieldValidator txtQty_RequiredFieldValidator1;
    //protected ValidatorCalloutExtender txtQty_ValidatorCalloutExtender2;
    //protected TextBox txtReturnNo;
    //protected TextBox txtSize;
    //protected TextBox txtStock;
    //protected RequiredFieldValidator txtStock_RequiredFieldValidator1;
    //protected TextBox txtunitid;
    //protected TextBox txtunitparam;
    //protected UpdatePanel UpdatePanel1;
    //protected ValidatorCalloutExtender ValidatorCalloutExtender1;
    //protected ValidatorCalloutExtender ValidatorCalloutExtender2;

    public void bindCompany()
    {
        this.drpCompany.DataSource = this._mybl.get_InformationdataTable("select nCompanyID,cCmpName from Smt_Company where cCmpName<>'-' order by cCmpName");
        this.drpCompany.DataTextField = "cCmpName";
        this.drpCompany.DataValueField = "nCompanyID";
        this.drpCompany.DataBind();
        this.drpCompany.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpCompany.SelectedIndex = 0;
    }

    public void BindDepartment()
    {
        DataSet set = this._blInventory.get_Informationdataset("Sp_Smt_FactoryPurchase_GetDepartment1 " + this.drpCompany.SelectedValue);
        this.drpdept.DataSource = set;
        this.drpdept.DataTextField = "cDeptname";
        this.drpdept.DataValueField = "nUserDept";
        this.drpdept.DataBind();
        this.drpdept.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpdept.SelectedIndex = 0;
    }

    public void bindgrid()
    {
        this.grdIssuegetAll.DataSource = this._blInventory.get_InformationdataTable("Sp_Smt_GoodsReturn_GetAll");
        this.grdIssuegetAll.DataBind();
    }

    public void bindgrid(int count, int Itemcode, string Maincat, string maincatid, string subcat, string subcatid, string size, string color, string art, string dimension, string unit, string unitid, string qty, string styleid)
    {
        DataRow row;
        DataTable table = new DataTable();
        table.Columns.Add(new DataColumn("ItemCode", typeof(string)));
        table.Columns.Add(new DataColumn("Maincat", typeof(string)));
        table.Columns.Add(new DataColumn("Maincatcode", typeof(string)));
        table.Columns.Add(new DataColumn("Subcat", typeof(string)));
        table.Columns.Add(new DataColumn("Subcatcode", typeof(string)));
        table.Columns.Add(new DataColumn("Size", typeof(string)));
        table.Columns.Add(new DataColumn("Color", typeof(string)));
        table.Columns.Add(new DataColumn("Article", typeof(string)));
        table.Columns.Add(new DataColumn("Dimension", typeof(string)));
        table.Columns.Add(new DataColumn("Unit", typeof(string)));
        table.Columns.Add(new DataColumn("unitID", typeof(string)));
        table.Columns.Add(new DataColumn("Qty", typeof(string)));
        table.Columns.Add(new DataColumn("stlID", typeof(string)));
        if (this.ViewState["CurrentData"] != null)
        {
            for (int i = 0; i < count; i++)
            {
                table = (DataTable)this.ViewState["CurrentData"];
                if (table.Rows.Count > 0)
                {
                    table.NewRow()[0] = table.Rows[0][0].ToString();
                }
            }
            row = table.NewRow();
            row["ItemCode"] = Itemcode;
            row["Maincat"] = Maincat;
            row["Maincatcode"] = maincatid;
            row["Subcat"] = subcat;
            row["Subcatcode"] = subcatid;
            row["Size"] = size;
            row["Color"] = color;
            row["Article"] = art;
            row["Dimension"] = dimension;
            row["Unit"] = unit;
            row["unitID"] = unitid;
            row["Qty"] = qty;
            row["stlID"] = styleid;
            table.Rows.Add(row);
        }
        else
        {
            row = table.NewRow();
            row["ItemCode"] = Itemcode;
            row["Maincat"] = Maincat;
            row["Maincatcode"] = maincatid;
            row["Subcat"] = subcat;
            row["Subcatcode"] = subcatid;
            row["Size"] = size;
            row["Color"] = color;
            row["Article"] = art;
            row["Dimension"] = dimension;
            row["Unit"] = unit;
            row["unitID"] = unitid;
            row["Qty"] = qty;
            row["stlID"] = styleid;
            table.Rows.Add(row);
        }
        if (this.ViewState["CurrentData"] != null)
        {
            this.grdIssuedetails.DataSource = this.ViewState["CurrentData"];
            this.grdIssuedetails.DataBind();
        }
        else
        {
            this.grdIssuedetails.DataSource = table;
            this.grdIssuedetails.DataBind();
        }
        this.ViewState["CurrentData"] = table;
    }

    public void BindMainCat(DropDownList drpMainCAt)
    {
        DataSet set = this._blInventory.get_Informationdataset("GoodsRutern_GetMaincat " + this.drpCompany.SelectedValue);
        drpMainCAt.DataSource = set;
        drpMainCAt.DataTextField = "cMainCategory";
        drpMainCAt.DataValueField = "nMainCategory_ID";
        drpMainCAt.DataBind();
        drpMainCAt.Items.Insert(0, string.Empty);
    }

    public void BindMainCatByStyle(DropDownList drpMainCAt)
    {
        DataSet set = this._blInventory.get_Informationdataset("Sp_Smt_GoodsIssu_GetMainCatbyStyle " + this.drpStyle.SelectedValue);
        drpMainCAt.DataSource = set;
        drpMainCAt.DataTextField = "cMainCategory";
        drpMainCAt.DataValueField = "nMainCategory_ID";
        drpMainCAt.DataBind();
        drpMainCAt.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        drpMainCAt.SelectedIndex = 0;
    }

    public void bindordunit()
    {
        DataTable table = this._blInventory.get_InformationdataTable("OrdUnit_getgroupunit " + this.drpSubcat.SelectedValue);
        this.drpIssueunit.DataSource = table;
        this.drpIssueunit.DataTextField = "cUnitDes";
        this.drpIssueunit.DataValueField = "nUnitID";
        this.drpIssueunit.DataBind();
    }

    public void BindSection()
    {
        DataSet set = this._blInventory.get_Informationdataset("Sp_Smt_FactoryPurchase_GetSection  " + this.drpdept.SelectedValue);
        this.drpSection.DataSource = set;
        this.drpSection.DataTextField = "cSection_Description";
        this.drpSection.DataValueField = "nSectionID";
        this.drpSection.DataBind();
        this.drpSection.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpSection.SelectedIndex = 0;
    }

    public void BindStyle()
    {
        DataSet set = this._blInventory.get_Informationdataset("GoodsRutern_GetStyle " + this.drpCompany.SelectedValue);
        this.drpStyle.DataSource = set;
        this.drpStyle.DataTextField = "cStyleNo";
        this.drpStyle.DataValueField = "nStyleID";
        this.drpStyle.DataBind();
        this.drpStyle.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpStyle.SelectedIndex = 0;
    }

    protected void btnAddItem_Click(object sender, EventArgs e)
    {
        string selectedValue;
        string str2;
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        if (!string.IsNullOrEmpty(this.drpIssueunit.SelectedValue))
        {
            selectedValue = this.drpIssueunit.SelectedValue;
            str2 = this.drpIssueunit.SelectedItem.ToString();
            this.txtIssueparam.Text.Trim();
        }
        else
        {
            selectedValue = this.txtunitid.Text.Trim();
            str2 = this.txtItemunit.Text.Trim();
            this.txtunitparam.Text.Trim();
        }
        DataTable table = (DataTable)this.ViewState["CurrentData"];
        int count = 1;
        int num2 = 0;
        if ((this.ViewState["CurrentData"] != null) && (table.Rows.Count > 0))
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (table.Rows[i]["ItemCode"].ToString() == this.txtItemid.Text.Trim())
                {
                    num2 = 1;
                    this.grdIssuedetails.Rows[i].BackColor = Color.Pink;
                }
            }
        }
        if (num2 < 1)
        {
            this.bindgrid(count, int.Parse(this.txtItemid.Text), this.drpMaincat.SelectedItem.ToString(), this.drpMaincat.SelectedValue, this.drpSubcat.SelectedItem.ToString(), this.drpSubcat.SelectedValue, this.txtSize.Text.Trim(), this.TxtColor.Text.Trim(), this.txtArticle.Text, this.txtDimension.Text, str2, selectedValue, this.txtQty.Text, this.drpStyle.SelectedValue.Trim());
            this.txtArticle.Text = "";
            this.txtCalcqty.Text = "";
            this.TxtColor.Text = "";
            this.txtDimension.Text = "";
            this.txtIssueparam.Text = "";
            this.txtItemid.Text = "";
            this.txtItemunit.Text = "";
            this.txtQty.Text = "";
            this.drpIssueunit.SelectedIndex = 0;
            this.txtSize.Text = "";
            this.txtStock.Text = "";
            this.txtunitid.Text = "";
            this.txtunitparam.Text = "";
        }
        else
        {
            label.Text = "Already Exists same Item";
        }
        if (this.grdIssuedetails.Rows.Count > 0)
        {
            this.dvtp.Attributes.Add("class", "pnlmainblock");
            this.drpCompany.Enabled = false;
            this.drpdept.Enabled = false;
            this.drpSection.Enabled = false;
            this.drpStyle.Enabled = false;
        }
        else
        {
            this.dvtp.Attributes.Add("class", "pnlmain");
            this.drpCompany.Enabled = true;
            this.drpdept.Enabled = true;
            this.drpSection.Enabled = true;
            this.drpStyle.Enabled = true;
        }
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.dvtp.Attributes.Add("class", "pnlmain");
        this.drpCompany.Enabled = true;
        this.drpdept.Enabled = true;
        this.drpSection.Enabled = true;
        this.drpStyle.Enabled = true;
        this.txtArticle.Text = "";
        this.txtCalcqty.Text = "";
        this.TxtColor.Text = "";
        this.txtDimension.Text = "";
        this.txtReturnNo.Text = "";
        this.txtIssueparam.Text = "";
        this.txtItemid.Text = "";
        this.txtItemunit.Text = "";
        this.txtQty.Text = "";
        this.txtSize.Text = "";
        this.txtStock.Text = "";
        this.txtunitparam.Text = "";
        this.BindMainCat(this.drpMaincat);
        this.drpdept.Items.Clear();
        this.drpSection.Items.Clear();
        this.drpStyle.SelectedIndex = 0;
        this.drpCompany.SelectedIndex = 0;
        this.drpIssueunit.SelectedIndex = 0;
        this.drpMaincat.SelectedIndex = 0;
        this.drpSubcat.Items.Clear();
        this.grdIssuedetails.DataSource = null;
        this.grdIssuedetails.DataBind();
        this.ViewState["CurrentData"] = null;
        this.btnstockdtl.Disabled = true;
        this.drpMaincat.Enabled = false;
        this.drpStyle.Enabled = false;
    }

    protected void btnPrintpoconfirm_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        C1GridViewRow parent = ((Button)sender).Parent.Parent as C1GridViewRow;
        Label label2 = (Label)parent.FindControl("lblIssueNo");
        this.Session["Param"] = "FR";
        this.Session["IssueNID"] = label2.Text.Trim();
        this.runjQueryCode("window.open('Smt_Inv_ReportDisplay.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        Label lbl = (Label)base.Master.FindControl("lbltotalinfo");
        lbl.Text = "";
        int goodsReturnNo = int.Parse(this._blInventory.get_Informationdataset("select GoodsReturnNo from Smt_Parameters").Tables[0].Rows[0]["GoodsReturnNo"].ToString()) + 1;
        int num2 = 0;
        string str2 = "FR";
        for (int i = 0; i < this.grdIssuedetails.Rows.Count; i++)
        {
            Label label2 = (Label)this.grdIssuedetails.Rows[i].FindControl("lblMaincatid");
            Label label3 = (Label)this.grdIssuedetails.Rows[i].FindControl("lblSubcatid");
            Label label4 = (Label)this.grdIssuedetails.Rows[i].FindControl("lblstyleID");
            Label label5 = (Label)this.grdIssuedetails.Rows[i].FindControl("lblItemid");
            Label label6 = (Label)this.grdIssuedetails.Rows[i].FindControl("lblUnitid");
            Label label7 = (Label)this.grdIssuedetails.Rows[i].FindControl("lblqty");
            if ((!string.IsNullOrEmpty(label3.Text.Trim()) && !string.IsNullOrEmpty(label5.Text.Trim())) && !string.IsNullOrEmpty(label7.Text.Trim()))
            {
                this._dlInventory.Save_ReturnNote(int.Parse(this.drpCompany.SelectedValue), int.Parse(this.drpdept.SelectedValue), int.Parse(this.drpSection.SelectedValue), str2, this.txtReturnNo.Text, int.Parse(label3.Text.Trim()), int.Parse(label5.Text), int.Parse(label6.Text.Trim()), label7.Text.Trim(), this.Session["Uid"].ToString(), label4.Text.Trim(), goodsReturnNo, int.Parse(label2.Text.Trim()), lbl);
                num2++;
            }
        }
        if (num2 > 0)
        {
            this.txtReturnNo.Text = goodsReturnNo.ToString();
            this._dlInventory.Update_ParameterFactoryReturn(goodsReturnNo);
            this.bindgrid();
            this.btnClear_Click(null, null);
            lbl.Text = "Saved Successfully";
        }
        else
        {
            lbl.Text = "No Item(s) Saved";
        }
    }

    protected void drpCompany_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.drpSection.Items.Clear();
        this.drpdept.Items.Clear();
        this.drpSubcat.Items.Clear();
        this.drpStyle.Items.Clear();
        this.drpMaincat.Items.Clear();
        this.txtArticle.Text = "";
        this.txtCalcqty.Text = "";
        this.TxtColor.Text = "";
        this.txtDimension.Text = "";
        this.txtIssueparam.Text = "";
        this.txtItemid.Text = "";
        this.txtItemunit.Text = "";
        this.txtQty.Text = "";
        this.txtSize.Text = "";
        this.txtStock.Text = "";
        this.txtunitid.Text = "";
        this.txtunitparam.Text = "";
        this.btnstockdtl.Visible = false;
        if (!string.IsNullOrEmpty(this.drpCompany.SelectedValue))
        {
            this.BindDepartment();
            this.BindMainCat(this.drpMaincat);
            this.BindStyle();
        }
    }

    protected void drpdept_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.drpSection.Items.Clear();
        if (!string.IsNullOrEmpty(this.drpdept.SelectedValue))
        {
            this.drpSection.Enabled = true;
            this.BindSection();
        }
        if (!string.IsNullOrEmpty(this.drpStyle.SelectedValue) && (this.drpStyle.SelectedItem.ToString() != "-"))
        {
            this.BindMainCatByStyle(this.drpMaincat);
        }
    }

    protected void drpMaincat_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.txtArticle.Text = "";
        this.txtCalcqty.Text = "";
        this.TxtColor.Text = "";
        this.txtDimension.Text = "";
        this.txtIssueparam.Text = "";
        this.txtItemid.Text = "";
        this.txtItemunit.Text = "";
        this.txtQty.Text = "";
        this.txtSize.Text = "";
        this.txtStock.Text = "";
        this.txtunitid.Text = "";
        this.txtunitparam.Text = "";
        this.drpIssueunit.Items.Clear();
        this.btnstockdtl.Visible = false;
        if (!string.IsNullOrEmpty(this.drpMaincat.SelectedValue))
        {
            this.drpSubcat.DataSource = this._blInventory.get_Informationdataset("GoodsRutern_GetSubcat " + this.drpCompany.SelectedValue + "," + this.drpMaincat.SelectedValue);
            this.drpSubcat.DataTextField = "cDes";
            this.drpSubcat.DataValueField = "cCode";
            this.drpSubcat.DataBind();
            if (this.drpSubcat.Items.Count > 0)
            {
                this.btnstockdtl.Visible = true;
                this.bindordunit();
            }
        }
    }

    protected void drpSubcat_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.txtArticle.Text = "";
        this.txtCalcqty.Text = "";
        this.TxtColor.Text = "";
        this.txtDimension.Text = "";
        this.txtIssueparam.Text = "";
        this.txtItemid.Text = "";
        this.txtItemunit.Text = "";
        this.txtQty.Text = "";
        this.txtSize.Text = "";
        this.txtStock.Text = "";
        this.txtunitid.Text = "";
        this.txtunitparam.Text = "";
        this.btnstockdtl.Visible = false;
        this.drpIssueunit.Items.Clear();
        if (!string.IsNullOrEmpty(this.drpSubcat.SelectedValue))
        {
            this.bindordunit();
            this.btnstockdtl.Visible = true;
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

    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.Session["Uid"] == null)
        {
            base.Response.Redirect("../Smt_Login.aspx", false);
        }
        else if (!base.IsPostBack)
        {
            this.bindCompany();
            this.bindgrid();
            Control[] btnall = new Control[] { this.btnSave };
            Control[] addbtn = new Control[0];
            this._mycls.SetBtnPermission(this.Session["Uid"].ToString(), btnall, addbtn, "Smt_Inv_Factoryreturn.aspx");
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