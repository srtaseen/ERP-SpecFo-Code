using AjaxControlToolkit;
using ASP;
using C1.Web.UI.Controls.C1GridView;
using C1.Web.UI.Controls.C1TabControl;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Inventory_Smt_Inv_GoodIssuing : System.Web.UI.Page
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
    //protected C1.Web.UI.Controls.C1TabControl.C1TabControl C1TabControl1;
    //protected C1TabPage C1TabPage1;
    //protected C1TabPage C1TabPage2;
    //protected CheckBox CheckBox1;
    private SqlConnection cn = GetWay.SpecFo_Inventorycon;
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
    //protected GridView grdIssuedetails;
    //protected C1.Web.UI.Controls.C1GridView.C1GridView grdIssuegetAll;
    //protected ValidatorCalloutExtender RequiredFieldValidator5_ValidatorCalloutExtender;
    //protected TextBox txtArticle;
    //protected TextBox txtBrand;
    //protected TextBox TxtColor;
    //protected TextBox txtDimension;
    //protected TextBox txtIssuenote;
    //protected TextBox txtIssueparam;
    //protected TextBox txtItemid;
    //protected TextBox txtItemunit;
    //protected TextBox txtQty;
    //protected FilteredTextBoxExtender txtQty_FilteredTextBoxExtender;
    //protected RequiredFieldValidator txtQty_RequiredFieldValidator1;
    //protected ValidatorCalloutExtender txtQty_ValidatorCalloutExtender2;
    //protected TextBox txtRemarks;
    //protected TextBox txtSize;
    //protected TextBox txtStcheck;
    //protected TextBox txtStock;
    //protected TextBox txtunitid;
    //protected TextBox txtunitparam;
    //protected UpdatePanel UpdatePanel1;
    //protected UpdatePanel UpdatePanel2;
    //protected UpdatePanel UpdatePanel3;
    //protected ValidatorCalloutExtender ValidatorCalloutExtender1;

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
        this.grdIssuegetAll.DataSource = this._blInventory.get_InformationdataTable("Sp_Smt_GoodsIssue_getAll");
        this.grdIssuegetAll.DataBind();
    }

    public void bindgrid(int count, int Itemcode, string Maincat, string maincatid, string subcat, string subcatid, string size, string color, string art, string dimension, string unit, string unitid, string qty, string unitparam, string brand, string styleid, string styleno)
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
        table.Columns.Add(new DataColumn("unitparam", typeof(string)));
        table.Columns.Add(new DataColumn("brnd", typeof(string)));
        table.Columns.Add(new DataColumn("styleid", typeof(string)));
        table.Columns.Add(new DataColumn("styleno", typeof(string)));
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
            row["unitparam"] = unitparam;
            row["brnd"] = brand;
            row["styleid"] = styleid;
            row["styleno"] = styleno;
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
            row["unitparam"] = unitparam;
            row["brnd"] = brand;
            row["styleid"] = styleid;
            row["styleno"] = styleno;
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

    public void bindMaincatbycomp()
    {
        this.drpMaincat.DataSource = this._blInventory.get_InformationdataTable("GoodsIssue_GetMaincatbycomp " + this.drpCompany.SelectedValue);
        this.drpMaincat.DataTextField = "cMainCategory";
        this.drpMaincat.DataValueField = "nMainCategory_ID";
        this.drpMaincat.DataBind();
        this.drpMaincat.Items.Insert(0, string.Empty);
    }

    public void bindMaincatbystyle()
    {
        this.drpMaincat.DataSource = this._blInventory.get_InformationdataTable("GoodsIssue_GetMaincatbystyle " + this.drpStyle.SelectedValue + "," + this.drpCompany.SelectedValue);
        this.drpMaincat.DataTextField = "cMainCategory";
        this.drpMaincat.DataValueField = "nMainCategory_ID";
        this.drpMaincat.DataBind();
        this.drpMaincat.Items.Insert(0, string.Empty);
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
        DataSet set = this._blInventory.get_Informationdataset("GoodsIssue_GetStyle " + this.drpCompany.SelectedValue);
        this.drpStyle.DataSource = set;
        this.drpStyle.DataTextField = "cStyleNo";
        this.drpStyle.DataValueField = "nstyCode";
        this.drpStyle.DataBind();
        this.drpStyle.Items.Insert(0, string.Empty);
    }

    protected void btnAddItem_Click(object sender, EventArgs e)
    {
        string selectedValue;
        string str3;
        string str4;
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        string styleid = "0";
        if (!string.IsNullOrEmpty(this.drpStyle.SelectedValue))
        {
            styleid = this.drpStyle.SelectedValue;
        }
        if (!string.IsNullOrEmpty(this.drpIssueunit.SelectedValue))
        {
            selectedValue = this.drpIssueunit.SelectedValue;
            str3 = this.drpIssueunit.SelectedItem.ToString();
            str4 = this.txtIssueparam.Text.Trim();
        }
        else
        {
            selectedValue = this.txtunitid.Text.Trim();
            str3 = this.txtItemunit.Text.Trim();
            str4 = this.txtunitparam.Text.Trim();
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
            this.bindgrid(count, int.Parse(this.txtItemid.Text), this.drpMaincat.SelectedItem.ToString(), this.drpMaincat.SelectedValue, this.drpSubcat.SelectedItem.ToString(), this.drpSubcat.SelectedValue, this.txtSize.Text.Trim(), this.TxtColor.Text.Trim(), this.txtArticle.Text, this.txtDimension.Text, str3, selectedValue, this.txtQty.Text, str4.Trim(), this.txtBrand.Text.Trim(), styleid, this.drpStyle.SelectedItem.ToString());
            this.txtArticle.Text = "";
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
            this.txtBrand.Text = "";
        }
        else
        {
            label.Text = "Already Exists same Item";
        }
        if (this.grdIssuedetails.Rows.Count > 0)
        {
            this.drpCompany.Enabled = false;
            this.drpdept.Enabled = false;
            this.drpSection.Enabled = false;
        }
        else
        {
            this.drpCompany.Enabled = true;
            this.drpdept.Enabled = true;
            this.drpSection.Enabled = true;
        }
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.drpCompany.Enabled = true;
        this.drpdept.Enabled = true;
        this.drpSection.Enabled = true;
        this.txtArticle.Text = "";
        this.TxtColor.Text = "";
        this.txtDimension.Text = "";
        this.txtIssuenote.Text = "";
        this.txtIssueparam.Text = "";
        this.txtItemid.Text = "";
        this.txtItemunit.Text = "";
        this.txtSize.Text = "";
        this.txtStock.Text = "";
        this.txtunitparam.Text = "";
        this.drpdept.Items.Clear();
        this.drpSection.Items.Clear();
        this.drpStyle.Items.Clear();
        this.drpCompany.SelectedIndex = 0;
        this.drpIssueunit.Items.Clear();
        this.drpMaincat.Items.Clear();
        this.drpSubcat.Items.Clear();
        this.grdIssuedetails.DataSource = null;
        this.grdIssuedetails.DataBind();
        this.ViewState["CurrentData"] = null;
        this.btnstockdtl.Visible = false;
        this.txtBrand.Text = "";
        this.txtRemarks.Text = "";
        this.txtQty.Text = "";
        this.CheckBox1.Checked = false;
        this.txtStcheck.Text = "N";
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        if (this.grdIssuedetails.Rows.Count > 0)
        {
            int num = int.Parse(this._blInventory.get_Informationdataset("select GoodsIssueNo from Smt_Parameters").Tables[0].Rows[0]["GoodsIssueNo"].ToString()) + 1;
            if (this.cn.State == ConnectionState.Closed)
            {
                this.cn.Open();
            }
            SqlTransaction transaction = this.cn.BeginTransaction();
            try
            {
                for (int i = 0; i < this.grdIssuedetails.Rows.Count; i++)
                {
                    Label label2 = (Label)this.grdIssuedetails.Rows[i].FindControl("lblSubcatid");
                    Label label3 = (Label)this.grdIssuedetails.Rows[i].FindControl("lblItemid");
                    Label label1 = (Label)this.grdIssuedetails.Rows[i].FindControl("lblunit");
                    Label label6 = (Label)this.grdIssuedetails.Rows[i].FindControl("lblunitparam");
                    Label label4 = (Label)this.grdIssuedetails.Rows[i].FindControl("lblqty");
                    Label label7 = (Label)this.grdIssuedetails.Rows[i].FindControl("lblUnitid");
                    Label label5 = (Label)this.grdIssuedetails.Rows[i].FindControl("lblStyle");
                    SqlCommand command = new SqlCommand("Sp_Smt_GoodsIssue_Save1", this.cn, transaction)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    command.Parameters.AddWithValue("@nIssNo", num);
                    command.Parameters.AddWithValue("@nlnNo", i);
                    command.Parameters.AddWithValue("@cSecCode", this.drpSection.SelectedValue);
                    command.Parameters.AddWithValue("@nSubCode", label2.Text);
                    command.Parameters.AddWithValue("@nItemcode", label3.Text);
                    command.Parameters.AddWithValue("@cUnit", this.txtunitid.Text.Trim());
                    command.Parameters.AddWithValue("@nIssQty", label4.Text);
                    command.Parameters.AddWithValue("@cuser", this.Session["Uid"].ToString());
                    command.Parameters.AddWithValue("@nstyCode", label5.Text);
                    command.Parameters.AddWithValue("@nPrice", "0");
                    command.Parameters.AddWithValue("@Value", "0");
                    command.Parameters.AddWithValue("@Department_Code", this.drpdept.SelectedValue);
                    command.Parameters.AddWithValue("@IssueNoteNO", this.txtIssuenote.Text);
                    command.Parameters.AddWithValue("@nCompanyID", this.drpCompany.SelectedValue);
                    command.Parameters.AddWithValue("@nEmployeeID", "");
                    command.Parameters.AddWithValue("@Remarks", this.txtRemarks.Text);
                    command.Parameters.AddWithValue("@IssueUnit", this.drpIssueunit.SelectedValue);
                    command.ExecuteNonQuery();
                }
                SqlCommand command2 = new SqlCommand("update Smt_Parameters set GoodsIssueNo=" + num, this.cn, transaction)
                {
                    CommandType = CommandType.Text
                };
                command2.Parameters.AddWithValue("@nIssNo", num);
                command2.ExecuteNonQuery();
                transaction.Commit();
                this.btnClear_Click(null, null);
                this.bindgrid();
                label.Text = "Saved Successfully";
            }
            catch (Exception exception)
            {
                transaction.Rollback();
                label.Text = exception.Message;
            }
            finally
            {
                if (this.cn.State == ConnectionState.Open)
                {
                    this.cn.Close();
                }
            }
        }
    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        this.drpMaincat.Items.Clear();
        this.bindMaincatbycomp();
        this.drpSubcat.Items.Clear();
        this.txtArticle.Text = "";
        this.txtBrand.Text = "";
        this.TxtColor.Text = "";
        this.txtDimension.Text = "";
        this.txtIssuenote.Text = "";
        this.txtIssueparam.Text = "";
        this.txtItemid.Text = "";
        this.txtItemunit.Text = "";
        this.txtRemarks.Text = "";
        this.txtSize.Text = "";
        this.txtStock.Text = "";
        this.txtunitid.Text = "";
        this.txtunitparam.Text = "";
        this.drpIssueunit.Items.Clear();
        this.btnstockdtl.Visible = false;
        this.txtStcheck.Text = "N";
        if (this.CheckBox1.Checked)
        {
            this.txtStcheck.Text = "Y";
            if (!string.IsNullOrEmpty(this.drpStyle.SelectedValue))
            {
                this.bindMaincatbystyle();
            }
        }
    }

    protected void drpCompany_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.txtStcheck.Text = "N";
        this.drpSection.Items.Clear();
        this.drpdept.Items.Clear();
        this.drpSubcat.Items.Clear();
        this.drpStyle.Items.Clear();
        this.drpMaincat.Items.Clear();
        this.txtArticle.Text = "";
        this.TxtColor.Text = "";
        this.txtDimension.Text = "";
        this.txtIssueparam.Text = "";
        this.txtItemid.Text = "";
        this.txtItemunit.Text = "";
        this.txtSize.Text = "";
        this.txtStock.Text = "";
        this.txtunitid.Text = "";
        this.txtunitparam.Text = "";
        this.txtRemarks.Text = "";
        this.btnstockdtl.Visible = false;
        this.txtBrand.Text = "";
        this.CheckBox1.Checked = false;
        if (!string.IsNullOrEmpty(this.drpCompany.SelectedValue))
        {
            this.BindDepartment();
            this.bindMaincatbycomp();
            this.BindStyle();
        }
    }

    protected void drpdept_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.BindSection();
    }

    protected void drpIssueunit_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.txtIssueparam.Text = "";
        if (!string.IsNullOrEmpty(this.drpIssueunit.SelectedValue))
        {
            DataSet set = this._blInventory.get_Informationdataset("select nConPara from Smt_Unit where nUnitID=" + this.drpIssueunit.SelectedValue);
            this.txtIssueparam.Text = set.Tables[0].Rows[0]["nConPara"].ToString();
        }
    }

    protected void drpMaincat_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.txtArticle.Text = "";
        this.txtBrand.Text = "";
        this.TxtColor.Text = "";
        this.txtDimension.Text = "";
        this.txtIssuenote.Text = "";
        this.txtIssueparam.Text = "";
        this.txtItemid.Text = "";
        this.txtItemunit.Text = "";
        this.txtSize.Text = "";
        this.txtStock.Text = "";
        this.txtunitid.Text = "";
        this.txtunitparam.Text = "";
        this.drpIssueunit.Items.Clear();
        this.drpSubcat.Items.Clear();
        this.btnstockdtl.Visible = false;
        if (!string.IsNullOrEmpty(this.drpMaincat.SelectedValue))
        {
            this.drpSubcat.DataSource = this._blInventory.get_Informationdataset("GoodsIssue_GetsubcatbyComp " + this.drpCompany.SelectedValue + "," + this.drpMaincat.SelectedValue);
            if (!string.IsNullOrEmpty(this.drpStyle.SelectedValue) && this.CheckBox1.Checked)
            {
                this.drpSubcat.DataSource = this._blInventory.get_Informationdataset("GoodsIssue_Getsubcatbystyle " + this.drpCompany.SelectedValue + "," + this.drpStyle.SelectedValue + "," + this.drpMaincat.SelectedValue);
            }
            this.drpSubcat.DataTextField = "cDes";
            this.drpSubcat.DataValueField = "cCode";
            this.drpSubcat.DataBind();
            if (this.drpSubcat.Items.Count > 0)
            {
                this.btnstockdtl.Visible = true;
                this.bindordunit();
                this.drpIssueunit_SelectedIndexChanged(null, null);
            }
        }
    }

    protected void drpStyle_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.drpMaincat.Items.Clear();
        this.drpSubcat.Items.Clear();
        this.txtArticle.Text = "";
        this.TxtColor.Text = "";
        this.txtDimension.Text = "";
        this.txtIssueparam.Text = "";
        this.txtItemid.Text = "";
        this.txtItemunit.Text = "";
        this.txtSize.Text = "";
        this.txtStock.Text = "";
        this.txtunitid.Text = "";
        this.txtunitparam.Text = "";
        this.txtRemarks.Text = "";
        this.btnstockdtl.Visible = false;
        this.txtBrand.Text = "";
        this.bindMaincatbycomp();
        if (!string.IsNullOrEmpty(this.drpStyle.SelectedValue) && this.CheckBox1.Checked)
        {
            this.bindMaincatbystyle();
        }
    }

    protected void drpSubcat_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    protected void grdIssuegetAll_Filtering(object sender, C1GridViewFilterEventArgs e)
    {
        this.bindgrid();
    }

    protected void grdIssuegetAll_PageIndexChanging(object sender, C1GridViewPageEventArgs e)
    {
        this.grdIssuegetAll.PageIndex = e.NewPageIndex;
        this.bindgrid();
    }

    protected void grdIssuegetAll_Sorting(object sender, C1GridViewSortEventArgs e)
    {
        this.bindgrid();
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
                this.btnstockdtl.Visible = false;
                this.bindCompany();
                this.bindgrid();
                Control[] btnall = new Control[] { this.btnSave };
                Control[] addbtn = new Control[0];
                this._mycls.SetBtnPermission(this.Session["Uid"].ToString(), btnall, addbtn, "Smt_Inv_GoodIssuing.aspx");
            }
            this.txtQty.Attributes.Add("onkeyup", "javascript:CalculateIssueValue('" + this.txtStock.ClientID + "','" + this.txtunitparam.ClientID + "','" + this.txtIssueparam.ClientID + "','" + this.txtQty.ClientID + "')");
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
