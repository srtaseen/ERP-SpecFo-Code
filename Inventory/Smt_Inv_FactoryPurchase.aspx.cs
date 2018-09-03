using AjaxControlToolkit;
using ASP;
using C1.Web.UI.Controls.C1GridView;
using C1.Web.UI.Controls.C1TabControl;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Inventory_Smt_Inv_FactoryPurchase : System.Web.UI.Page
{
    private BLLInventory _blInventory = new BLLInventory();
    private DALInventory _dlInventory = new DALInventory();
    private MC _mc = new MC();
    private BLL _mybll = new BLL();
    private DAL _mycls = new DAL();
    //protected Button btnAdd;
    //protected Button btnaddarticle;
    //protected Button btnaddcolor;
    //protected Button btnadddimension;
    //protected Button btnAddsubcat;
    //protected Button btnCancelapp;
    //protected ConfirmButtonExtender btnCancelapp_ConfirmButtonExtender1;
    //protected Button btnClear;
    //protected HtmlInputButton btnGenpo;
    //protected Button btnPOApprove;
    //protected ConfirmButtonExtender btnPOApprove_ConfirmButtonExtender;
    //protected Button btnPOCancel;
    //protected ConfirmButtonExtender btnPOCancel_ConfirmButtonExtender;
    //protected Button btnppgntpo;
    //protected Button btnRefreshGpotb;
    //protected Button btnReloadForapp;
    //protected Button btnReqApprove;
    //protected ConfirmButtonExtender btnReqApprove_ConfirmButtonExtender1;
    //protected Button btnReviseApprove;
    //protected ConfirmButtonExtender btnReviseApprove_ConfirmButtonExtender;
    //protected Button btnReviseforapp;
    //protected ConfirmButtonExtender btnReviseforapp_ConfirmButtonExtender1;
    //protected Button btnrf;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    //protected Button btnSearchReq;
    //protected Button btnshowstock;
    //protected Button btnUpdate;
    //protected ConfirmButtonExtender btnUpdate_ConfirmButtonExtender;
    //protected ModalPopupExtender Button2_ModalPopupExtender;
    //protected C1.Web.UI.Controls.C1TabControl.C1TabControl C1TabControl1;
    //protected C1TabPage C1TabPage1;
    //protected C1TabPage C1TabPage2;
    //protected C1TabPage C1TabPage3;
    //protected C1TabPage C1TabPage4;
    //protected C1TabPage C1TabPage5;
    //protected C1TabPage C1TabPage6;
    //protected ImageButton cal1;
    private SqlConnection cn = GetWay.SpecFo_Inventorycon;
    //protected DropDownList drpartcl;
    //protected DropDownList drpBrand;
    //protected DropDownList drpclr;
    //protected DropDownList drpcurrency;
    //protected DropDownList drpDepartment;
    //protected DropDownList drpdimnsn;
    //protected DropDownList drpFactory;
    //protected DropDownList drpmncat;
    //protected DropDownList drpsection;
    //protected DropDownList drpStyle;
    //protected DropDownList drpsubcat;
    //protected DropDownList drpsz;
    //protected DropDownList drpunit;
    //protected HtmlGenericControl dvtp;
    //protected C1.Web.UI.Controls.C1GridView.C1GridView grdForApproval;
    //protected C1.Web.UI.Controls.C1GridView.C1GridView grdGetApproved;
    //protected GridView grdLocalpurchase;
    //protected C1.Web.UI.Controls.C1GridView.C1GridView grdNewreq;
    //protected C1.Web.UI.Controls.C1GridView.C1GridView grdPOCanceled;
    //protected GridView GridView1;
    //protected Label Label19;
    //protected Label Label5;
    //protected Label Label6;
    //protected Label Label7;
    //protected Label Label8;
    //protected Label Label9;
    //protected Label lblStock;
    //protected Panel pnlfp;
    //protected RequiredFieldValidator RequiredFieldValidator1;
    //protected ValidatorCalloutExtender RequiredFieldValidator1_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator10;
    //protected ValidatorCalloutExtender RequiredFieldValidator10_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator16;
    //protected ValidatorCalloutExtender RequiredFieldValidator16_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator17;
    //protected ValidatorCalloutExtender RequiredFieldValidator17_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator18;
    //protected ValidatorCalloutExtender RequiredFieldValidator18_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator19;
    //protected ValidatorCalloutExtender RequiredFieldValidator19_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator2;
    //protected ValidatorCalloutExtender RequiredFieldValidator2_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator20;
    //protected ValidatorCalloutExtender RequiredFieldValidator20_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator21;
    //protected ValidatorCalloutExtender RequiredFieldValidator21_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator22;
    //protected ValidatorCalloutExtender RequiredFieldValidator22_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator23;
    //protected ValidatorCalloutExtender RequiredFieldValidator23_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator24;
    //protected ValidatorCalloutExtender RequiredFieldValidator24_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator25;
    //protected ValidatorCalloutExtender RequiredFieldValidator25_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator3;
    //protected ValidatorCalloutExtender RequiredFieldValidator3_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator4;
    //protected ValidatorCalloutExtender RequiredFieldValidator4_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator5;
    //protected ValidatorCalloutExtender RequiredFieldValidator5_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator6;
    //protected ValidatorCalloutExtender RequiredFieldValidator6_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator7;
    //protected ValidatorCalloutExtender RequiredFieldValidator7_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator8;
    //protected ValidatorCalloutExtender RequiredFieldValidator8_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator9;
    //protected ValidatorCalloutExtender RequiredFieldValidator9_ValidatorCalloutExtender;
    //protected TextBox txtcompany;
    //protected TextBox txtDate;
    //protected TextBox txtdept;
    //protected CalendarExtender txtoriginalrcvd_CalendarExtender;
    //protected TextBox txtprce;
    //protected FilteredTextBoxExtender txtprce_FilteredTextBoxExtender;
    //protected TextBox txtqty;
    //protected FilteredTextBoxExtender txtqty_FilteredTextBoxExtender;
    //protected TextBox txtRemarks;
    //protected TextBox txtremarkspoapprove;
    //protected TextBox txtreqappremrk;
    //protected TextBox txtReqNo;
    //protected TextBox txtReqNosrc;
    //protected FilteredTextBoxExtender txtReqNosrc_FilteredTextBoxExtender;
    //protected TextBox txtsection;
    //protected Label txtStock;
    //protected TextBox txtvalue;
    //protected UpdatePanel updfp;

    public void aaclir()
    {
        this.ViewState["CurrentData"] = null;
        this.drpDepartment.Items.Clear();
        this.Session["EditRo"] = null;
        this.drpcurrency.SelectedIndex = 0;
        this.drpFactory.Enabled = true;
        this.drpFactory.SelectedIndex = 0;
        this.drpDepartment.Enabled = true;
        this.drpsection.Items.Clear();
        this.drpsection.Enabled = true;
        this.btnSave.Visible = true;
        this.btnUpdate.Visible = false;
        this.txtReqNo.Text = "";
        this.grdLocalpurchase.DataSource = null;
        this.grdLocalpurchase.DataBind();
        this.drpmncat.SelectedIndex = 0;
        this.drpsubcat.Items.Clear();
        this.drpclr.SelectedIndex = 0;
        this.drpsz.SelectedIndex = 0;
        this.drpartcl.Items.Clear();
        this.drpdimnsn.Items.Clear();
        this.drpunit.SelectedIndex = 0;
        this.txtqty.Text = "";
        this.txtprce.Text = "";
        this.txtvalue.Text = "";
        this.dvtp.Attributes.Add("class", "pnlmain");
        this.drpcurrency.Enabled = true;
        this.txtStock.Text = "";
        this.txtRemarks.Text = "";
    }

    public void bindapp()
    {
        this.grdGetApproved.DataSource = this._blInventory.get_InformationdataTable("FactoryPurchase_GetPOAPPVED");
        this.grdGetApproved.DataBind();
    }

    public void bindbrand()
    {
        this.drpBrand.DataSource = this._mybll.get_InformationdataTable("select nBrand_ID,cBrand_Name from Smt_Brand order by cBrand_Name");
        this.drpBrand.DataTextField = "cBrand_Name";
        this.drpBrand.DataValueField = "nBrand_ID";
        this.drpBrand.DataBind();
    }

    public void bindColor(DropDownList drp)
    {
        drp.DataSource = this._mybll.get_Informationdataset("select nColNo,cColour from Smt_Colours order by cColour");
        drp.DataTextField = "cColour";
        drp.DataValueField = "nColNo";
        drp.DataBind();
    }

    public void bindCompany()
    {
        this.drpFactory.DataSource = this._mybll.get_InformationdataTable("select nCompanyID,cCmpName from Smt_Company where cCmpName<>'-' order by cCmpName");
        this.drpFactory.DataTextField = "cCmpName";
        this.drpFactory.DataValueField = "nCompanyID";
        this.drpFactory.DataBind();
        this.drpFactory.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpFactory.SelectedIndex = 0;
    }

    public void BindDepartment()
    {
        DataSet set = this._blInventory.get_Informationdataset("Sp_Smt_FactoryPurchase_GetDepartment1 " + this.drpFactory.SelectedValue);
        this.drpDepartment.DataSource = set;
        this.drpDepartment.DataTextField = "cDeptname";
        this.drpDepartment.DataValueField = "nUserDept";
        this.drpDepartment.DataBind();
        this.drpDepartment.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpDepartment.SelectedIndex = 0;
    }

    public void bindforapp()
    {
        this.grdForApproval.DataSource = this._blInventory.get_InformationdataTable("FactoryPurchase_GetPOFORAPPV");
        this.grdForApproval.DataBind();
    }

    public void bindgetcanceled()
    {
        this.grdPOCanceled.DataSource = this._blInventory.get_InformationdataTable("FactoryPurchase_GetPOCNCLED");
        this.grdPOCanceled.DataBind();
    }

    public void bindgetreqforpo()
    {
        this.GridView1.DataSource = this._blInventory.get_InformationdataTable("FactoryPurchase_GetAprvedReq");
        this.GridView1.DataBind();
    }

    public void bindgrid(int count, int MainCato, string mcat, int subcatid, string subcat, int colid, string col, int sideid, string siz, int artcleid, string artcl, int dimnid, string dimn, int unitid, string unit, string reqqty, string uprice, string value, string brandid, string brand)
    {
        DataRow row;
        DataTable table = new DataTable();
        table.Columns.Add(new DataColumn("nMainCat_ID", typeof(int)));
        table.Columns.Add(new DataColumn("cMainCategory", typeof(string)));
        table.Columns.Add(new DataColumn("nSubCat_ID", typeof(int)));
        table.Columns.Add(new DataColumn("cDes", typeof(string)));
        table.Columns.Add(new DataColumn("nColor_ID", typeof(int)));
        table.Columns.Add(new DataColumn("cColour", typeof(string)));
        table.Columns.Add(new DataColumn("SizeID", typeof(int)));
        table.Columns.Add(new DataColumn("cSize1", typeof(string)));
        table.Columns.Add(new DataColumn("nArticle_ID", typeof(int)));
        table.Columns.Add(new DataColumn("cArticle", typeof(string)));
        table.Columns.Add(new DataColumn("nDimension_ID", typeof(int)));
        table.Columns.Add(new DataColumn("cDimen", typeof(string)));
        table.Columns.Add(new DataColumn("nUnit_ID", typeof(int)));
        table.Columns.Add(new DataColumn("cUnitDes", typeof(string)));
        table.Columns.Add(new DataColumn("dReqQty", typeof(string)));
        table.Columns.Add(new DataColumn("dUnitPrice", typeof(string)));
        table.Columns.Add(new DataColumn("dValue", typeof(string)));
        table.Columns.Add(new DataColumn("BrandCode", typeof(string)));
        table.Columns.Add(new DataColumn("cBrand_Name", typeof(string)));
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
            row["nMainCat_ID"] = MainCato;
            row["cMainCategory"] = mcat;
            row["nSubCat_ID"] = subcatid;
            row["cDes"] = subcat;
            row["nColor_ID"] = colid;
            row["cColour"] = col;
            row["SizeID"] = sideid;
            row["cSize1"] = siz;
            row["nArticle_ID"] = artcleid;
            row["cArticle"] = artcl;
            row["nDimension_ID"] = dimnid;
            row["cDimen"] = dimn;
            row["nUnit_ID"] = unitid;
            row["cUnitDes"] = unit;
            row["dReqQty"] = reqqty;
            row["dUnitPrice"] = uprice;
            row["dValue"] = value;
            row["BrandCode"] = brandid;
            row["cBrand_Name"] = brand;
            table.Rows.Add(row);
        }
        else
        {
            row = table.NewRow();
            row["nMainCat_ID"] = MainCato;
            row["cMainCategory"] = mcat;
            row["nSubCat_ID"] = subcatid;
            row["cDes"] = subcat;
            row["nColor_ID"] = colid;
            row["cColour"] = col;
            row["SizeID"] = sideid;
            row["cSize1"] = siz;
            row["nArticle_ID"] = artcleid;
            row["cArticle"] = artcl;
            row["nDimension_ID"] = dimnid;
            row["cDimen"] = dimn;
            row["nUnit_ID"] = unitid;
            row["cUnitDes"] = unit;
            row["dReqQty"] = reqqty;
            row["dUnitPrice"] = uprice;
            row["dValue"] = value;
            row["BrandCode"] = brandid;
            row["cBrand_Name"] = brand;
            table.Rows.Add(row);
        }
        if (this.ViewState["CurrentData"] != null)
        {
            this.grdLocalpurchase.DataSource = this.ViewState["CurrentData"];
            this.grdLocalpurchase.DataBind();
        }
        else
        {
            this.grdLocalpurchase.DataSource = table;
            this.grdLocalpurchase.DataBind();
        }
        this.ViewState["CurrentData"] = table;
    }

    public void BindMainCat(DropDownList drp)
    {
        DataSet set = this._blInventory.get_Informationdataset("Sp_Smt_FactoryPurchase_GetMainCat 'L'");
        drp.DataSource = set;
        drp.DataTextField = "cMainCategory";
        drp.DataValueField = "nMainCategory_ID";
        drp.DataBind();
        drp.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        drp.SelectedIndex = 0;
    }

    public void bindnewreq()
    {
        this.grdNewreq.DataSource = this._blInventory.get_InformationdataTable("FactoryPurchase_GetNewReq");
        this.grdNewreq.DataBind();
    }

    public void bindordunit(DropDownList drpsubcat, DropDownList drpordunt)
    {
        DataTable table = this._blInventory.get_InformationdataTable("OrdUnit_getgroupunit " + drpsubcat.SelectedValue);
        drpordunt.DataSource = table;
        drpordunt.DataTextField = "cUnitDes";
        drpordunt.DataValueField = "nUnitID";
        drpordunt.DataBind();
        drpordunt.Items.Insert(0, string.Empty);
    }

    public void BindSection()
    {
        DataSet set = this._blInventory.get_Informationdataset("Sp_Smt_FactoryPurchase_GetSection  " + this.drpDepartment.SelectedValue);
        this.drpsection.DataSource = set;
        this.drpsection.DataTextField = "cSection_Description";
        this.drpsection.DataValueField = "nSectionID";
        this.drpsection.DataBind();
    }

    public void BindStyle()
    {
        DataSet set = this._blInventory.get_Informationdataset("Sp_Smt_FactoryPurchase_GetStyle");
        this.drpStyle.DataSource = set;
        this.drpStyle.DataTextField = "cStyleNo";
        this.drpStyle.DataValueField = "nStyleID";
        this.drpStyle.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        DataTable table = (DataTable)this.ViewState["CurrentData"];
        if (this.Session["EditRo"] != null)
        {
            int index = int.Parse(this.Session["EditRo"].ToString());
            table.Rows.RemoveAt(index);
            this.Session["EditRo"] = null;
        }
        DataTable table2 = (DataTable)this.ViewState["CurrentData"];
        int count = 1;
        int num3 = 0;
        if ((this.ViewState["CurrentData"] != null) && (table2.Rows.Count > 0))
        {
            for (int i = 0; i < table2.Rows.Count; i++)
            {
                string str = table2.Rows[i]["nMainCat_ID"].ToString();
                string str2 = table2.Rows[i]["nSubCat_ID"].ToString();
                string str3 = table2.Rows[i]["nColor_ID"].ToString();
                string str4 = table2.Rows[i]["SizeID"].ToString();
                string str5 = table2.Rows[i]["nArticle_ID"].ToString();
                string str6 = table2.Rows[i]["nDimension_ID"].ToString();
                if ((((str == this.drpmncat.SelectedValue) && (str2 == this.drpsubcat.SelectedValue)) && ((str5 == this.drpartcl.SelectedValue) && (str6 == this.drpdimnsn.SelectedValue))) && ((str3 == this.drpclr.SelectedValue) && (str4 == this.drpsz.SelectedValue)))
                {
                    num3 = 1;
                    this.grdLocalpurchase.Rows[i].BackColor = Color.Pink;
                    label.Text = "Already Added Same Item";
                }
            }
        }
        if (num3 < 1)
        {
            this.bindgrid(count, int.Parse(this.drpmncat.SelectedValue), this.drpmncat.SelectedItem.ToString(), int.Parse(this.drpsubcat.SelectedValue), this.drpsubcat.SelectedItem.ToString(), int.Parse(this.drpclr.SelectedValue), this.drpclr.SelectedItem.ToString(), int.Parse(this.drpsz.SelectedValue), this.drpsz.SelectedItem.ToString(), int.Parse(this.drpartcl.SelectedValue), this.drpartcl.SelectedItem.ToString(), int.Parse(this.drpdimnsn.SelectedValue), this.drpdimnsn.SelectedItem.ToString(), int.Parse(this.drpunit.SelectedValue), this.drpunit.SelectedItem.ToString(), this.txtqty.Text, this.txtprce.Text, this.txtvalue.Text, this.drpBrand.SelectedValue, this.drpBrand.SelectedItem.ToString());
        }
        else if (this.grdLocalpurchase.Rows.Count > 0)
        {
            this.drpDepartment.Enabled = false;
            this.drpcurrency.Enabled = false;
            this.drpFactory.Enabled = false;
            this.drpsection.Enabled = false;
            this.dvtp.Attributes.Add("class", "pnlmainblock");
        }
        else
        {
            this.drpDepartment.Enabled = true;
            this.drpcurrency.Enabled = true;
            this.drpFactory.Enabled = true;
            this.drpsection.Enabled = true;
            this.dvtp.Attributes.Add("class", "pnlmain");
        }
    }

    protected void btnCancelapp_Click(object sender, EventArgs e)
    {
        this.aaclir();
        Label lbl = (Label)base.Master.FindControl("lbltotalinfo");
        lbl.Text = "";
        int num = 0;
        for (int i = 0; i < this.grdGetApproved.Rows.Count; i++)
        {
            CheckBox box = (CheckBox)this.grdGetApproved.Rows[i].FindControl("chkforRevise");
            if (box.Checked)
            {
                Label label2 = (Label)this.grdGetApproved.Rows[i].FindControl("lblPOforEdit");
                this._dlInventory.FactoryPurchase_POCancel(this.Session["Uid"].ToString(), int.Parse(label2.Text.Trim()), lbl);
                num++;
            }
            else if (num < 1)
            {
                lbl.Text = "First Select PO";
            }
        }
        this.bindapp();
        this.bindgetcanceled();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.aaclir();
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
    }

    protected void btnEdit_Click(object sender, ImageClickEventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        GridViewRow parent = ((ImageButton)sender).Parent.Parent as GridViewRow;
        this.Session["EditRo"] = parent.RowIndex;
        Label label2 = (Label)parent.FindControl("lblrqmcatid");
        Label label3 = (Label)parent.FindControl("lblresubctid");
        Label label4 = (Label)parent.FindControl("lblreqcolid");
        Label label5 = (Label)parent.FindControl("lblreqszid");
        Label label6 = (Label)parent.FindControl("lblreqartid");
        Label label7 = (Label)parent.FindControl("lblreqdimnid");
        Label label8 = (Label)parent.FindControl("lblrequnitid");
        Label label9 = (Label)parent.FindControl("lblrqqty");
        Label label10 = (Label)parent.FindControl("lblrqunprice");
        Label label11 = (Label)parent.FindControl("lblrqval");
        Label label12 = (Label)parent.FindControl("lblbrandid");
        this.drpmncat.SelectedValue = label2.Text.Trim();
        parent.BackColor = Color.FromName("#0FB1FF");
        if (!string.IsNullOrEmpty(this.drpmncat.SelectedValue))
        {
            this.LoadArticle(this.drpmncat, this.drpartcl);
            this.LoadDimension(this.drpmncat, this.drpdimnsn);
            this.LoadSubCategoruy(this.drpmncat, this.drpsubcat);
            this.drpsubcat.SelectedValue = label3.Text.Trim();
            if (!string.IsNullOrEmpty(this.drpsubcat.SelectedValue))
            {
                this.bindordunit(this.drpsubcat, this.drpunit);
            }
            this.drpdimnsn.SelectedValue = label7.Text.Trim();
            this.drpartcl.SelectedValue = label6.Text.Trim();
            this.drpunit.SelectedValue = label8.Text.Trim();
            this.drpclr.SelectedValue = label4.Text.Trim();
            this.drpsz.SelectedValue = label5.Text.Trim();
            this.drpBrand.SelectedValue = label12.Text.Trim();
            this.txtqty.Text = label9.Text.Trim();
            this.txtprce.Text = label10.Text.Trim();
            this.txtvalue.Text = label11.Text.Trim();
        }
    }

    public void btngenpo()
    {
        if (this._mybll.get_InformationdataTable("select ButtonName from tst_permitterbtn where FormName='Smt_Inv_FactoryPurchase.aspx' and ButtonName='btnGenpo' and Permission=1 and UserName='" + this.Session["Uid"].ToString() + "'").Rows.Count <= 0)
        {
            this.btnGenpo.Visible = false;
        }
    }

    protected void btnLoadfp_Click(object sender, ImageClickEventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        GridViewRow parent = ((ImageButton)sender).Parent.Parent as GridViewRow;
        DropDownList drpMainCat = (DropDownList)parent.FindControl("drpreqmancat");
        DropDownList drpSubCat = (DropDownList)parent.FindControl("drpreqsubcat");
        DropDownList drpArticle = (DropDownList)parent.FindControl("drpreqarticle");
        DropDownList drpDimension = (DropDownList)parent.FindControl("drprqdimn");
        DropDownList drp = (DropDownList)parent.FindControl("drpreqcolor");
        DropDownList list6 = (DropDownList)parent.FindControl("drprequnit");
        string selectedValue = drpSubCat.SelectedValue;
        string str2 = drpArticle.SelectedValue;
        string str3 = drpDimension.SelectedValue;
        string str4 = drp.SelectedValue;
        this._mycls.drp_color(drp);
        if (!string.IsNullOrEmpty(str4))
        {
            drp.SelectedValue = str4;
        }
        if (!string.IsNullOrEmpty(drpMainCat.SelectedValue))
        {
            this.LoadArticle(drpMainCat, drpArticle);
            this.LoadDimension(drpMainCat, drpDimension);
            this.LoadSubCategoruy(drpMainCat, drpSubCat);
        }
        if (!string.IsNullOrEmpty(selectedValue))
        {
            drpSubCat.SelectedValue = selectedValue;
        }
        if (!string.IsNullOrEmpty(drpSubCat.SelectedValue))
        {
            string str5 = this._blInventory.get_InformationdataTable("select cUnit from Smt_SubCatagory where cCode=" + drpSubCat.SelectedValue).Rows[0]["cUnit"].ToString().Trim();
            list6.SelectedValue = str5;
        }
        if (!string.IsNullOrEmpty(str3))
        {
            drpDimension.SelectedValue = str3;
        }
        if (!string.IsNullOrEmpty(str2))
        {
            drpArticle.SelectedValue = str2;
        }
    }

    protected void btnPOApprove_Click(object sender, EventArgs e)
    {
        this.aaclir();
        Label lbl = (Label)base.Master.FindControl("lbltotalinfo");
        lbl.Text = "";
        int num = 0;
        for (int i = 0; i < this.grdForApproval.Rows.Count; i++)
        {
            CheckBox box = (CheckBox)this.grdForApproval.Rows[i].FindControl("chkSelect");
            if (box.Checked)
            {
                Label label2 = (Label)this.grdForApproval.Rows[i].FindControl("lblPOforEdit");
                this._dlInventory.FactoryPurchase_POApprove(this.Session["Uid"].ToString(), int.Parse(label2.Text.Trim()), this.txtremarkspoapprove.Text, lbl);
                num++;
            }
            else if (num < 1)
            {
                lbl.Text = "First Select PO";
            }
        }
        this.bindforapp();
        this.bindapp();
    }

    protected void btnPOCancel_Click(object sender, EventArgs e)
    {
        this.aaclir();
        Label lbl = (Label)base.Master.FindControl("lbltotalinfo");
        lbl.Text = "";
        int num = 0;
        for (int i = 0; i < this.grdForApproval.Rows.Count; i++)
        {
            CheckBox box = (CheckBox)this.grdForApproval.Rows[i].FindControl("chkSelect");
            if (box.Checked)
            {
                Label label2 = (Label)this.grdForApproval.Rows[i].FindControl("lblPOforEdit");
                this._dlInventory.FactoryPurchase_POCancel(this.Session["Uid"].ToString(), int.Parse(label2.Text.Trim()), lbl);
                num++;
            }
            else if (num < 1)
            {
                lbl.Text = "First Select PO";
            }
        }
        this.bindforapp();
        this.bindgetcanceled();
    }

    protected void btnRefreshGpotb_Click(object sender, EventArgs e)
    {
        this.bindgetreqforpo();
        this.bindforapp();
    }

    protected void btnReloadForapp_Click(object sender, EventArgs e)
    {
        this.aaclir();
        this.bindforapp();
    }

    protected void btnRemove_Click(object sender, ImageClickEventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        GridViewRow parent = ((ImageButton)sender).Parent.Parent as GridViewRow;
        DataTable table = (DataTable)this.ViewState["CurrentData"];
        if (table.Rows.Count > 0)
        {
            table.Rows.RemoveAt(parent.RowIndex);
        }
        this.ViewState["CurrentData"] = table;
        this.grdLocalpurchase.DataSource = table;
        this.grdLocalpurchase.DataBind();
        if (this.grdLocalpurchase.Rows.Count > 0)
        {
            this.drpDepartment.Enabled = false;
            this.drpcurrency.Enabled = false;
            this.drpFactory.Enabled = false;
            this.drpsection.Enabled = false;
            this.dvtp.Attributes.Add("class", "pnlmainblock");
        }
        else
        {
            this.drpDepartment.Enabled = true;
            this.drpcurrency.Enabled = true;
            this.drpFactory.Enabled = true;
            this.drpsection.Enabled = true;
            this.dvtp.Attributes.Add("class", "pnlmain");
        }
    }

    protected void btnReqApprove_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        SqlTransaction tr = this.cn.BeginTransaction();
        if (this.grdNewreq.Rows.Count > 0)
        {
            try
            {
                for (int i = 0; i < this.grdNewreq.Rows.Count; i++)
                {
                    CheckBox box = (CheckBox)this.grdNewreq.Rows[i].FindControl("chkSelect");
                    if (box.Checked)
                    {
                        Label label2 = (Label)this.grdNewreq.Rows[i].FindControl("lblRequestno");
                        string[] normalparam = new string[] { "@reqno", "@reqappby", "@remrk" };
                        string[] normalprmval = new string[] { label2.Text, this.Session["Uid"].ToString(), this.txtreqappremrk.Text };
                        this._mc.MC_Save_nodt_tr("FP_ReqAppv", this.cn, tr, normalparam, normalprmval);
                    }
                }
                tr.Commit();
                label.Text = "Request Approved ";
                this.bindnewreq();
                this.bindgetreqforpo();
            }
            catch (Exception exception)
            {
                tr.Rollback();
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

    protected void btnReviseApprove_Click(object sender, EventArgs e)
    {
        this.aaclir();
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        int num = 0;
        if (this.grdGetApproved.Rows.Count > 0)
        {
            for (int i = 0; i < this.grdGetApproved.Rows.Count; i++)
            {
                CheckBox box = (CheckBox)this.grdGetApproved.Rows[i].FindControl("chkforRevise");
                if (box.Checked)
                {
                    Label label2 = (Label)this.grdGetApproved.Rows[i].FindControl("lblRequestno");
                    Label label3 = (Label)this.grdGetApproved.Rows[i].FindControl("lblPOforEdit");
                    this._dlInventory.Factorypurchase_PORevise(int.Parse(label2.Text), int.Parse(label3.Text), this.Session["Uid"].ToString());
                    num++;
                }
            }
        }
        if (num > 0)
        {
            label.Text = "Done";
            this.bindforapp();
            this.bindapp();
            this.bindgetreqforpo();
        }
        else
        {
            label.Text = "Select PO First";
        }
    }

    protected void btnReviseforapp_Click(object sender, EventArgs e)
    {
        this.aaclir();
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        int num = 0;
        if (this.grdForApproval.Rows.Count > 0)
        {
            for (int i = 0; i < this.grdForApproval.Rows.Count; i++)
            {
                CheckBox box = (CheckBox)this.grdForApproval.Rows[i].FindControl("chkSelect");
                if (box.Checked)
                {
                    Label label2 = (Label)this.grdForApproval.Rows[i].FindControl("lblRequestno");
                    Label label3 = (Label)this.grdForApproval.Rows[i].FindControl("lblPOforEdit");
                    this._dlInventory.Factorypurchase_PORevise(int.Parse(label2.Text), int.Parse(label3.Text), this.Session["Uid"].ToString());
                    num++;
                }
            }
        }
        if (num > 0)
        {
            label.Text = "Done";
            this.bindforapp();
            this.bindapp();
            this.bindgetreqforpo();
        }
        else
        {
            label.Text = "Select PO First";
        }
    }

    protected void btnrf_Click(object sender, EventArgs e)
    {
        this.bindColor(this.drpclr);
        this.LoadArticle(this.drpmncat, this.drpartcl);
        this.LoadSubCategoruy(this.drpmncat, this.drpsubcat);
        this.LoadDimension(this.drpmncat, this.drpdimnsn);
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        this.txtReqNo.Text = (int.Parse(this._blInventory.get_Informationdataset("select Local_PurchaseReQNO from Smt_Parameters").Tables[0].Rows[0]["Local_PurchaseReQNO"].ToString()) + 1).ToString();
        this.cn.Open();
        SqlTransaction transaction = this.cn.BeginTransaction();
        try
        {
            for (int i = 0; i < this.grdLocalpurchase.Rows.Count; i++)
            {
                Label label2 = (Label)this.grdLocalpurchase.Rows[i].FindControl("lblrqmcatid");
                Label label3 = (Label)this.grdLocalpurchase.Rows[i].FindControl("lblresubctid");
                Label label4 = (Label)this.grdLocalpurchase.Rows[i].FindControl("lblrqsubcat");
                Label label5 = (Label)this.grdLocalpurchase.Rows[i].FindControl("lblreqcolid");
                Label label6 = (Label)this.grdLocalpurchase.Rows[i].FindControl("lblreqszid");
                Label label7 = (Label)this.grdLocalpurchase.Rows[i].FindControl("lblreqartid");
                Label label8 = (Label)this.grdLocalpurchase.Rows[i].FindControl("lblreqdimnid");
                Label label9 = (Label)this.grdLocalpurchase.Rows[i].FindControl("lblrequnitid");
                Label label10 = (Label)this.grdLocalpurchase.Rows[i].FindControl("lblrqqty");
                Label label11 = (Label)this.grdLocalpurchase.Rows[i].FindControl("lblrqunprice");
                Label label12 = (Label)this.grdLocalpurchase.Rows[i].FindControl("lblrqval");
                Label label13 = (Label)this.grdLocalpurchase.Rows[i].FindControl("lblbrandid");
                SqlCommand command = new SqlCommand("FactoryPurchase_Save", this.cn, transaction)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@nDepartment_ID", this.drpDepartment.SelectedValue);
                command.Parameters.AddWithValue("@nSection_ID", this.drpsection.SelectedValue);
                command.Parameters.AddWithValue("@nStyleID", this.drpStyle.SelectedValue);
                command.Parameters.AddWithValue("@cCurType", this.drpcurrency.SelectedValue);
                command.Parameters.AddWithValue("@nRequest_No", this.txtReqNo.Text.Trim());
                command.Parameters.AddWithValue("@nMainCat_ID", label2.Text.Trim());
                command.Parameters.AddWithValue("@nSubCat_ID", label3.Text.Trim());
                command.Parameters.AddWithValue("@nColor_ID", label5.Text.Trim());
                command.Parameters.AddWithValue("@nArticle_ID", label7.Text.Trim());
                command.Parameters.AddWithValue("@nDimension_ID", label8.Text.Trim());
                command.Parameters.AddWithValue("@nUnit_ID", label9.Text.Trim());
                command.Parameters.AddWithValue("@dReqQty", label10.Text.Trim());
                command.Parameters.AddWithValue("@dUnitPrice", label11.Text.Trim());
                command.Parameters.AddWithValue("@dValue", label12.Text.Trim());
                command.Parameters.AddWithValue("@dStock", "0");
                command.Parameters.AddWithValue("@Created_User", this.Session["Uid"].ToString());
                command.Parameters.AddWithValue("@SizeID", label6.Text.Trim());
                command.Parameters.AddWithValue("@ItemDescription", label4.Text);
                command.Parameters.AddWithValue("@LnNO", i.ToString());
                command.Parameters.AddWithValue("@nCompanyID", this.drpFactory.SelectedValue);
                command.Parameters.AddWithValue("@Remarks", this.txtRemarks.Text.Trim());
                command.Parameters.AddWithValue("@BrandCode", label13.Text.Trim());
                command.ExecuteNonQuery();
            }
            new SqlCommand("update Smt_Parameters set Local_PurchaseReQNO=" + this.txtReqNo.Text, this.cn, transaction) { CommandType = CommandType.Text }.ExecuteNonQuery();
            transaction.Commit();
            label.Text = "Saved Successfully";
            this.bindnewreq();
            this.ClrReq();
        }
        catch (Exception exception)
        {
            transaction.Rollback();
            label.Text = exception.Message;
        }
        finally
        {
            this.cn.Close();
        }
    }

    protected void btnSearchReq_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        string str = null;
        string[] strArray = new string[] { "cCmpName", "cDeptname", "cSection_Description", "nRequest_No" };
        string str2 = this.txtDate.Text.Trim();
        string[] strArray2 = new string[] { this.txtcompany.Text.Trim(), this.txtdept.Text.Trim(), this.txtsection.Text.Trim(), this.txtReqNosrc.Text.Trim() };
        int num = 0;
        for (int i = 0; i < strArray2.Length; i++)
        {
            string str3 = strArray2[i];
            if (!string.IsNullOrEmpty(str3))
            {
                num++;
                if (num == 1)
                {
                    str = str + strArray[i] + " Like ''" + str3 + "%''";
                }
                else
                {
                    str = str + "And " + strArray[i] + " Like''" + str3 + "%''";
                }
            }
        }
        if (!string.IsNullOrEmpty(str2))
        {
            if (!string.IsNullOrEmpty(str))
            {
                str = str + " And CONVERT(VARCHAR(10),Created_Date,103)=CONVERT(VARCHAR(10),''" + str2 + "'',103)";
            }
            else
            {
                str = "CONVERT(VARCHAR(10),Created_Date,103)=CONVERT(VARCHAR(10),''" + str2 + "'',103)";
            }
        }
        DataTable table = this._blInventory.get_InformationdataTable("Sp_Smt_FactoryPurchase_GetAllsrc '" + str + "'");
        this.GridView1.DataSource = table;
        this.GridView1.DataBind();
        label.Text = table.Rows.Count + " Request(s) Found";
    }

    protected void btnshowstock_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.lblStock.Text = "";
        this.lblStock.Text = "";
        if (((!string.IsNullOrEmpty(this.drpsubcat.SelectedValue) && !string.IsNullOrEmpty(this.drpartcl.SelectedValue)) && (!string.IsNullOrEmpty(this.drpdimnsn.SelectedValue) && !string.IsNullOrEmpty(this.drpclr.SelectedValue))) && !string.IsNullOrEmpty(this.drpsz.SelectedValue))
        {
            DataTable table = this._blInventory.get_InformationdataTable("Sp_Smt_ItemMaster_getStockforFP " + this.drpFactory.SelectedValue + "," + this.drpmncat.SelectedValue + "," + this.drpsubcat.SelectedValue + "," + this.drpclr.SelectedValue + "," + this.drpsz.SelectedValue + "," + this.drpartcl.SelectedValue + "," + this.drpdimnsn.SelectedValue);
            if (table.Rows.Count > 0)
            {
                this.txtprce.Text = table.Rows[0]["nPrice"].ToString();
                this.txtStock.Text = table.Rows[0]["nItemBalQty"].ToString();
                this.lblStock.Text = "Stock Balance : ";
            }
            else
            {
                label.Text = "No Item found";
                this.lblStock.Text = "No Item found";
            }
            if (!string.IsNullOrEmpty(this.txtqty.Text) && !string.IsNullOrEmpty(this.txtprce.Text))
            {
                this.txtvalue.Text = (decimal.Parse(this.txtqty.Text) * decimal.Parse(this.txtprce.Text)).ToString();
            }
        }
        else
        {
            label.Text = "First select Main Category,Item,Color,Size,Article,Dimension";
        }
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        this.cn.Open();
        SqlTransaction transaction = this.cn.BeginTransaction();
        try
        {
            SqlCommand command = new SqlCommand("Sp_Smt_FactoryPurchase_DeleteReqNew", this.cn, transaction)
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@nRequest_No", this.txtReqNo.Text.Trim());
            command.ExecuteNonQuery();
            for (int i = 0; i < this.grdLocalpurchase.Rows.Count; i++)
            {
                Label label2 = (Label)this.grdLocalpurchase.Rows[i].FindControl("lblrqmcatid");
                Label label3 = (Label)this.grdLocalpurchase.Rows[i].FindControl("lblresubctid");
                Label label4 = (Label)this.grdLocalpurchase.Rows[i].FindControl("lblrqsubcat");
                Label label5 = (Label)this.grdLocalpurchase.Rows[i].FindControl("lblreqcolid");
                Label label6 = (Label)this.grdLocalpurchase.Rows[i].FindControl("lblreqszid");
                Label label7 = (Label)this.grdLocalpurchase.Rows[i].FindControl("lblreqartid");
                Label label8 = (Label)this.grdLocalpurchase.Rows[i].FindControl("lblreqdimnid");
                Label label9 = (Label)this.grdLocalpurchase.Rows[i].FindControl("lblrequnitid");
                Label label10 = (Label)this.grdLocalpurchase.Rows[i].FindControl("lblrqqty");
                Label label11 = (Label)this.grdLocalpurchase.Rows[i].FindControl("lblrqunprice");
                Label label12 = (Label)this.grdLocalpurchase.Rows[i].FindControl("lblrqval");
                Label label13 = (Label)this.grdLocalpurchase.Rows[i].FindControl("lblbrandid");
                SqlCommand command2 = new SqlCommand("FactoryPurchase_Save", this.cn, transaction)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command2.Parameters.AddWithValue("@nDepartment_ID", this.drpDepartment.SelectedValue);
                command2.Parameters.AddWithValue("@nSection_ID", this.drpsection.SelectedValue);
                command2.Parameters.AddWithValue("@nStyleID", this.drpStyle.SelectedValue);
                command2.Parameters.AddWithValue("@cCurType", this.drpcurrency.SelectedValue);
                command2.Parameters.AddWithValue("@nRequest_No", this.txtReqNo.Text.Trim());
                command2.Parameters.AddWithValue("@nMainCat_ID", label2.Text.Trim());
                command2.Parameters.AddWithValue("@nSubCat_ID", label3.Text.Trim());
                command2.Parameters.AddWithValue("@nColor_ID", label5.Text.Trim());
                command2.Parameters.AddWithValue("@nArticle_ID", label7.Text.Trim());
                command2.Parameters.AddWithValue("@nDimension_ID", label8.Text.Trim());
                command2.Parameters.AddWithValue("@nUnit_ID", label9.Text.Trim());
                command2.Parameters.AddWithValue("@dReqQty", label10.Text.Trim());
                command2.Parameters.AddWithValue("@dUnitPrice", label11.Text.Trim());
                command2.Parameters.AddWithValue("@dValue", label12.Text.Trim());
                command2.Parameters.AddWithValue("@dStock", "0");
                command2.Parameters.AddWithValue("@Created_User", this.Session["Uid"].ToString());
                command2.Parameters.AddWithValue("@SizeID", label6.Text.Trim());
                command2.Parameters.AddWithValue("@ItemDescription", label4.Text);
                command2.Parameters.AddWithValue("@LnNO", i.ToString());
                command2.Parameters.AddWithValue("@nCompanyID", this.drpFactory.SelectedValue);
                command2.Parameters.AddWithValue("@Remarks", this.txtRemarks.Text.Trim());
                command2.Parameters.AddWithValue("@BrandCode", label13.Text.Trim());
                command2.ExecuteNonQuery();
            }
            transaction.Commit();
            label.Text = "Updated Successfully";
            this.bindnewreq();
            this.ClrReq();
        }
        catch (Exception exception)
        {
            transaction.Rollback();
            label.Text = exception.Message;
        }
        finally
        {
            this.cn.Close();
        }
    }

    public void ClrReq()
    {
        this.bindgetreqforpo();
        this.bindforapp();
        this.drpDepartment.Enabled = true;
        this.drpcurrency.Enabled = true;
        this.drpFactory.Enabled = true;
        this.drpsection.Enabled = true;
        this.dvtp.Attributes.Add("class", "pnlmain");
        this.drpFactory.SelectedIndex = 0;
        this.drpDepartment.Items.Clear();
        this.drpsection.Items.Clear();
        this.drpcurrency.SelectedIndex = 0;
        this.ViewState["CurrentData"] = null;
        this.btnSave.Visible = true;
        this.btnUpdate.Visible = false;
        this.drpmncat.SelectedIndex = 0;
        this.drpsubcat.Items.Clear();
        this.drpclr.SelectedIndex = 0;
        this.drpsz.SelectedIndex = 0;
        this.drpartcl.Items.Clear();
        this.drpdimnsn.Items.Clear();
        this.txtqty.Text = "";
        this.txtprce.Text = "";
        this.txtvalue.Text = "";
        this.drpunit.SelectedIndex = 0;
        this.grdLocalpurchase.DataSource = null;
        this.grdLocalpurchase.DataBind();
        this.txtRemarks.Text = "";
    }

    protected void drpDepartment_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.drpsection.Items.Clear();
        this.txtReqNo.Text = "";
        this.lblStock.Text = "";
        this.txtStock.Text = "";
        if (!string.IsNullOrEmpty(this.drpDepartment.SelectedValue))
        {
            this.BindSection();
        }
    }

    protected void drpFactory_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.lblStock.Text = "";
        this.txtStock.Text = "";
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.txtStock.Text = "";
        this.drpDepartment.Items.Clear();
        this.drpsection.Items.Clear();
        this.drpsection.Enabled = false;
        this.drpDepartment.Enabled = false;
        this.txtReqNo.Text = "";
        if (!string.IsNullOrEmpty(this.drpFactory.SelectedValue))
        {
            this.grdLocalpurchase.Enabled = true;
            this.drpsection.Enabled = true;
            this.BindDepartment();
            this.drpDepartment.Enabled = true;
        }
    }

    protected void drpmncat_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.lblStock.Text = "";
        this.txtStock.Text = "";
        this.drpsubcat.Items.Clear();
        this.drpartcl.Items.Clear();
        this.drpdimnsn.Items.Clear();
        this.drpunit.Items.Clear();
        if (!string.IsNullOrEmpty(this.drpmncat.SelectedValue))
        {
            this.LoadArticle(this.drpmncat, this.drpartcl);
            this.LoadDimension(this.drpmncat, this.drpdimnsn);
            this.LoadSubCategoruy(this.drpmncat, this.drpsubcat);
            if (!string.IsNullOrEmpty(this.drpsubcat.SelectedValue))
            {
                this.bindordunit(this.drpsubcat, this.drpunit);
                string str = this._blInventory.get_InformationdataTable("select cUnit from Smt_SubCatagory where cCode=" + this.drpsubcat.SelectedValue).Rows[0]["cUnit"].ToString().Trim();
                this.drpunit.SelectedValue = str;
            }
        }
    }

    protected void drpsubcat_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.lblStock.Text = "";
        this.txtStock.Text = "";
        this.txtStock.Text = "";
        this.drpunit.Items.Clear();
        if (!string.IsNullOrEmpty(this.drpsubcat.SelectedValue))
        {
            this.bindordunit(this.drpsubcat, this.drpunit);
            string str = this._blInventory.get_InformationdataTable("select cUnit from Smt_SubCatagory where cCode=" + this.drpsubcat.SelectedValue).Rows[0]["cUnit"].ToString().Trim();
            this.drpunit.SelectedValue = str;
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

    protected void grdForApproval_Filtering(object sender, C1GridViewFilterEventArgs e)
    {
        this.bindforapp();
    }

    protected void grdForApproval_PageIndexChanging(object sender, C1GridViewPageEventArgs e)
    {
        this.grdForApproval.PageIndex = e.NewPageIndex;
        this.bindforapp();
    }

    protected void grdForApproval_Sorting(object sender, C1GridViewSortEventArgs e)
    {
        this.bindforapp();
    }

    protected void grdGetApproved_Filtering(object sender, C1GridViewFilterEventArgs e)
    {
        this.bindapp();
    }

    protected void grdGetApproved_PageIndexChanging(object sender, C1GridViewPageEventArgs e)
    {
        this.grdGetApproved.PageIndex = e.NewPageIndex;
        this.bindapp();
    }

    protected void grdGetApproved_RowDataBound(object sender, C1GridViewRowEventArgs e)
    {
        if (e.Row.RowType == C1GridViewRowType.DataRow)
        {
            Label label = (Label)e.Row.FindControl("lblPOforEdit");
            if (this._blInventory.get_InformationdataTable("Sp_Smt_FactoryPurchase_chkpogrn " + label.Text.Trim()).Rows.Count > 0)
            {
                CheckBox box = (CheckBox)e.Row.FindControl("chkforRevise");
                box.Enabled = false;
                e.Row.Attributes.Add("style", "background-color:#F5FCE8; border-bottom:1px solid #C2EF72; border-top:1px solid #C2EF72");
            }
        }
    }

    protected void grdGetApproved_Sorting(object sender, C1GridViewSortEventArgs e)
    {
        this.bindapp();
    }

    protected void grdLocalpurchase_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label label = (Label)e.Row.FindControl("lblrqmcatid");
            if (string.IsNullOrEmpty(label.Text))
            {
                e.Row.Visible = false;
            }
            int num = e.Row.RowIndex + 1;
            if (e.Row.Enabled)
            {
                e.Row.Attributes.Add("onclick", string.Concat(new object[] { "javascript:gridrowcolor('", this.grdLocalpurchase.ClientID, "','", num, "')" }));
            }
        }
    }

    protected void grdNewreq_Filtering(object sender, C1GridViewFilterEventArgs e)
    {
        this.bindnewreq();
    }

    protected void grdNewreq_SelectedIndexChanging(object sender, C1GridViewSelectEventArgs e)
    {
        this.grdNewreq.PageIndex = e.NewSelectedIndex;
        this.bindnewreq();
    }

    protected void grdPOCanceled_Filtering(object sender, C1GridViewFilterEventArgs e)
    {
        this.bindgetcanceled();
    }

    protected void grdPOCanceled_PageIndexChanging(object sender, C1GridViewPageEventArgs e)
    {
        this.grdPOCanceled.PageIndex = e.NewPageIndex;
        this.bindgetcanceled();
    }

    protected void grdPOCanceled_Sorting(object sender, C1GridViewSortEventArgs e)
    {
        this.bindgetcanceled();
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
    }

    protected void lnkcancelpo_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        C1GridViewRow parent = ((LinkButton)sender).Parent.Parent as C1GridViewRow;
        LinkButton button = (LinkButton)parent.FindControl("lnkcancelpo");
        this.Session["pono"] = button.CommandArgument;
        this.Session["Param"] = "PONO";
        this.runjQueryCode("window.open('Smt_Inv_ReportDisplay.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
    }

    protected void lnkedit_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        try
        {
            C1GridViewRow parent = ((LinkButton)sender).Parent.Parent as C1GridViewRow;
            LinkButton button = (LinkButton)parent.FindControl("lnkedit");
            int num = int.Parse(button.CommandArgument);
            this.ViewState["CurrentData"] = null;
            DataTable table = this._blInventory.get_InformationdataTable("Sp_Smt_FactoryPurchase_getForEditReq " + num);
            DataTable table2 = this._blInventory.get_InformationdataTable("Sp_Smt_FactoryPurchase_getForEditReq1 " + num);
            this.grdLocalpurchase.DataSource = table2;
            this.grdLocalpurchase.DataBind();
            this.ViewState["CurrentData"] = table2;
            this.txtReqNo.Text = num.ToString();
            this.drpFactory.SelectedValue = table.Rows[0]["nCompanyID"].ToString();
            this.BindDepartment();
            this.drpDepartment.SelectedValue = table.Rows[0]["nDepartment_ID"].ToString();
            this.BindSection();
            this.drpsection.SelectedValue = table.Rows[0]["nSection_ID"].ToString();
            this.drpcurrency.SelectedValue = table.Rows[0]["cCurType"].ToString();
            this.txtRemarks.Text = table.Rows[0]["Remarks"].ToString();
            this.dvtp.Attributes.Add("class", "pnlmainblock");
            this.drpcurrency.Enabled = false;
            this.drpDepartment.Enabled = false;
            this.drpFactory.Enabled = false;
            this.drpsection.Enabled = false;
            this.btnSave.Visible = false;
            this.btnUpdate.Visible = true;
            this.C1TabControl1.MoveFirst();
        }
        catch (Exception exception)
        {
            label.Text = exception.Message;
        }
    }

    protected void lnkprint_Click(object sender, EventArgs e)
    {
        this.btnClear_Click(null, null);
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        C1GridViewRow parent = ((LinkButton)sender).Parent.Parent as C1GridViewRow;
        LinkButton button = (LinkButton)parent.FindControl("lnkprint");
        this.Session["pono"] = button.CommandArgument;
        this.Session["Param"] = "PONO";
        this.runjQueryCode("window.open('Smt_Inv_ReportDisplay.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
    }

    protected void lnkprintApproved_Click(object sender, EventArgs e)
    {
        this.aaclir();
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        C1GridViewRow parent = ((LinkButton)sender).Parent.Parent as C1GridViewRow;
        LinkButton button = (LinkButton)parent.FindControl("lnkprintApproved");
        this.Session["pono"] = button.CommandArgument;
        this.Session["Param"] = "PONO";
        this.runjQueryCode("window.open('Smt_Inv_ReportDisplay.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
    }

    public void LoadArticle(DropDownList drpMainCat, DropDownList drpArticle)
    {
        drpArticle.DataSource = this._blInventory.get_Informationdataset("select nArtCode,cArticle from Smt_Artcle where nMainCatID=" + drpMainCat.SelectedValue + " order by cArticle");
        drpArticle.DataTextField = "cArticle";
        drpArticle.DataValueField = "nArtCode";
        drpArticle.DataBind();
        drpArticle.SelectedIndex = 0;
    }

    public void LoadDimension(DropDownList drpMainCat, DropDownList drpDimension)
    {
        drpDimension.DataSource = this._blInventory.get_Informationdataset("select ndCode,cDimen from Smt_Dimension where nMainCatID=" + drpMainCat.SelectedValue + " order by cDimen");
        drpDimension.DataTextField = "cDimen";
        drpDimension.DataValueField = "ndCode";
        drpDimension.DataBind();
        drpDimension.SelectedIndex = 0;
    }

    public void LoadSize(DropDownList drpSize)
    {
        drpSize.DataSource = this._blInventory.get_Informationdataset("select nCode,cSize1 from Smt_Sizes order by cSize1");
        drpSize.DataTextField = "cSize1";
        drpSize.DataValueField = "nCode";
        drpSize.DataBind();
    }

    public void LoadSubCategoruy(DropDownList drpMainCat, DropDownList drpSubCat)
    {
        drpSubCat.DataSource = this._blInventory.get_Informationdataset("select cCode,cDes from Smt_SubCatagory where cManCode=" + drpMainCat.SelectedValue + " and Act_sts=0 order by cDes");
        drpSubCat.DataTextField = "cDes";
        drpSubCat.DataValueField = "cCode";
        drpSubCat.DataBind();
    }

    public void LoadUnit(DropDownList drpUnit)
    {
        drpUnit.DataSource = this._blInventory.get_Informationdataset("select nUnitID,cUnitDes from Smt_Unit order by cUnitDes");
        drpUnit.DataTextField = "cUnitDes";
        drpUnit.DataValueField = "nUnitID";
        drpUnit.DataBind();
        drpUnit.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        drpUnit.SelectedIndex = 0;
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
                this.Session["EditRo"] = null;
                this._dlInventory.drp_Currencytype(this.drpcurrency);
                this.bindCompany();
                this.BindStyle();
                this.bindgetreqforpo();
                this.bindforapp();
                this.bindbrand();
                this.bindnewreq();
                this.bindapp();
                this.bindgetcanceled();
                this.BindMainCat(this.drpmncat);
                this.LoadSize(this.drpsz);
                this.bindColor(this.drpclr);
                Control[] btnall = new Control[] { this.btnPOCancel, this.btnPOApprove, this.btnUpdate, this.btnSave, this.btnReviseApprove, this.btnReviseforapp, this.btnCancelapp, this.btnReqApprove };
                Control[] addbtn = new Control[] { this.btnAddsubcat, this.btnaddarticle, this.btnadddimension, this.btnaddcolor };
                this._mycls.SetBtnPermission(this.Session["Uid"].ToString(), btnall, addbtn, "Smt_Inv_FactoryPurchase.aspx");
                this.ViewState["CurrentData"] = null;
                if (this.Session["Uid"].ToString().ToUpper() != "ADMIN")
                {
                    this.btngenpo();
                }
            }
            this.txtqty.Attributes.Add("onkeyup", "javascript:calcval('" + this.txtqty.ClientID + "','" + this.txtprce.ClientID + "','" + this.txtvalue.ClientID + "')");
            this.txtprce.Attributes.Add("onkeyup", "javascript:calcval('" + this.txtqty.ClientID + "','" + this.txtprce.ClientID + "','" + this.txtvalue.ClientID + "')");
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
