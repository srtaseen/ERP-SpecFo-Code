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
using System.Web.UI.WebControls;

public partial class Smt_Mer_OtherBooking : System.Web.UI.Page
{
    private BLLInventory blInventory = new BLLInventory();
    //protected Button btnAdd;
    //protected Button btnArticle;
    //protected Button btnClear;
    //protected Button btncolor;
    //protected Button btnDimension;
    //protected Button btnItem;
    //protected ImageButton btnLoadArticle;
    //protected ImageButton btnLoadColor;
    //protected ImageButton btnLoadDimension;
    //protected ImageButton btnLoadItem;
    //protected ImageButton btnLoadMainCat;
    //protected Button btnMaincat;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    //protected Button btnshowpp;
    //protected ModalPopupExtender btnshowpp_ModalPopupExtender;
    //protected C1.Web.UI.Controls.C1TabControl.C1TabControl C1TabControl1;
    //protected C1TabPage C1TabPage1;
    //protected C1TabPage C1TabPage2;
    //protected ImageButton cal1;
    private DALInventory dlinventory = new DALInventory();
    //protected DropDownList drpArticle;
    //protected DropDownList drpcolor;
    //protected DropDownList drpCurrencytype;
    //protected DropDownList drpDeliveryTo;
    //protected DropDownList drpDimension;
    //protected DropDownList drpMainCat;
    //protected DropDownList drpOrderType;
    //protected DropDownList drpPIIssue;
    //protected DropDownList drpPONo;
    //protected DropDownList drpSize;
    //protected DropDownList drpStyle;
    //protected DropDownList drpSubcategory;
    //protected DropDownList drpSupplier;
    //protected DropDownList drpUnit;
    //protected GridView grdBookingDtl;
    //protected C1.Web.UI.Controls.C1GridView.C1GridView grdView;
    //protected Label Label5;
    //protected Label lblrowindx;
    private BLL mybll = new BLL();
    private DAL mycls = new DAL();
    //protected RequiredFieldValidator REDLDT;
    //protected ValidatorCalloutExtender REDLDT_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RQARTICLE0;
    //protected ValidatorCalloutExtender RQARTICLE0_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RQCOLOR0;
    //protected ValidatorCalloutExtender RQCOLOR0_ValidatorCalloutExtender;
    //protected RequiredFieldValidator rqcreditda;
    //protected ValidatorCalloutExtender rqcreditda_ValidatorCalloutExtender;
    //protected RequiredFieldValidator rqcrncy;
    //protected ValidatorCalloutExtender rqcrncy_ValidatorCalloutExtender;
    //protected RequiredFieldValidator rqdeliveryto;
    //protected ValidatorCalloutExtender rqdeliveryto_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RQDIMENSION0;
    //protected ValidatorCalloutExtender RQDIMENSION0_ValidatorCalloutExtender;
    //protected RequiredFieldValidator rqissueto;
    //protected ValidatorCalloutExtender rqissueto_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RQMAINCAT0;
    //protected ValidatorCalloutExtender RQMAINCAT0_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RQORDERTP0;
    //protected ValidatorCalloutExtender RQORDERTP0_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RQQTY;
    //protected ValidatorCalloutExtender RQQTY_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RQRATE;
    //protected ValidatorCalloutExtender RQRATE_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RQSIZE0;
    //protected ValidatorCalloutExtender RQSIZE0_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RQSUBCAT0;
    //protected ValidatorCalloutExtender RQSUBCAT0_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RQSupplier;
    //protected ValidatorCalloutExtender RQSupplier_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RQUNIT0;
    //protected ValidatorCalloutExtender RQUNIT0_ValidatorCalloutExtender;
    //protected TextBox txtAttention;
    //protected TextBox txtCreditDays;
    //protected FilteredTextBoxExtender txtCreditDays_FilteredTextBoxExtender;
    //protected TextBox txtDeliverydt;
    //protected CalendarExtender txtDeliverydt_CalendarExtender;
    //protected TextBox txtPOno;
    //protected TextBox txtQuantity;
    //protected FilteredTextBoxExtender txtQuantity_FilteredTextBoxExtender;
    //protected TextBox txtRate;
    //protected FilteredTextBoxExtender txtRate_FilteredTextBoxExtender;
    //protected TextBox txtRemarks;
    //protected TextBoxWatermarkExtender txtRemarks_TextBoxWatermarkExtender;
    //protected TextBox txtValue;
    //protected UpdatePanel UpdatePanel1;

    public void bindgrid()
    {
        this.grdView.DataSource = this.blInventory.get_InformationdataTable("Sp_Smt_PO_GetOtherBooking '" + this.Session["Uid"].ToString() + "'");
        this.grdView.DataBind();
    }

    public void bindgrid(int count, string maincatid, string MainCat, string Item, string Color, string Size, string Article, string ArticleID, string Dimension, string DimensionID, string unit, string Qty, string Rate, string Value, string Styleno, string StyleID, string PONo, string mcatid, string subcatid, string lots)
    {
        DataRow row;
        DataTable table = new DataTable();
        table.Columns.Add(new DataColumn("MCatID", typeof(int)));
        table.Columns.Add(new DataColumn("cMainCategory", typeof(string)));
        table.Columns.Add(new DataColumn("cItemdes", typeof(string)));
        table.Columns.Add(new DataColumn("cColour", typeof(string)));
        table.Columns.Add(new DataColumn("cSize", typeof(string)));
        table.Columns.Add(new DataColumn("cArt", typeof(string)));
        table.Columns.Add(new DataColumn("ArticleID", typeof(int)));
        table.Columns.Add(new DataColumn("cDimec", typeof(string)));
        table.Columns.Add(new DataColumn("DimensionID", typeof(int)));
        table.Columns.Add(new DataColumn("cUnit", typeof(string)));
        table.Columns.Add(new DataColumn("nQty", typeof(decimal)));
        table.Columns.Add(new DataColumn("nPrice", typeof(decimal)));
        table.Columns.Add(new DataColumn("nVal", typeof(decimal)));
        table.Columns.Add(new DataColumn("cStyleNo", typeof(string)));
        table.Columns.Add(new DataColumn("nstyCode", typeof(int)));
        table.Columns.Add(new DataColumn("cPo", typeof(string)));
        table.Columns.Add(new DataColumn("SubcatID", typeof(int)));
        table.Columns.Add(new DataColumn("clots", typeof(string)));
        table.Columns.Add(new DataColumn("nDtlCode", typeof(int)));
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
            row["MCatID"] = maincatid;
            row["cMainCategory"] = MainCat;
            row["cItemdes"] = Item;
            row["cColour"] = Color;
            row["cSize"] = Size;
            row["cArt"] = Article;
            row["ArticleID"] = ArticleID;
            row["cDimec"] = Dimension;
            row["DimensionID"] = DimensionID;
            row["cUnit"] = unit;
            row["nQty"] = Qty;
            row["nPrice"] = Rate;
            row["nVal"] = Value;
            row["cStyleNo"] = Styleno;
            row["nstyCode"] = StyleID;
            row["cPo"] = PONo;
            row["McatID"] = mcatid;
            row["SubcatID"] = subcatid;
            row["clots"] = lots;
            row["nDtlCode"] = "0";
            table.Rows.Add(row);
        }
        else
        {
            row = table.NewRow();
            row["MCatID"] = maincatid;
            row["cMainCategory"] = MainCat;
            row["cItemdes"] = Item;
            row["cColour"] = Color;
            row["cSize"] = Size;
            row["cArt"] = Article;
            row["ArticleID"] = ArticleID;
            row["cDimec"] = Dimension;
            row["DimensionID"] = DimensionID;
            row["cUnit"] = unit;
            row["nQty"] = Qty;
            row["nPrice"] = Rate;
            row["nVal"] = Value;
            row["cStyleNo"] = Styleno;
            row["nstyCode"] = StyleID;
            row["cPo"] = PONo;
            row["McatID"] = mcatid;
            row["SubcatID"] = subcatid;
            row["clots"] = lots;
            row["nDtlCode"] = "0";
            table.Rows.Add(row);
        }
        if (this.ViewState["CurrentData"] != null)
        {
            this.grdBookingDtl.DataSource = this.ViewState["CurrentData"];
            this.grdBookingDtl.DataBind();
        }
        else
        {
            this.grdBookingDtl.DataSource = table;
            this.grdBookingDtl.DataBind();
        }
        this.ViewState["CurrentData"] = table;
    }

    public void bindordunit()
    {
        DataTable table = this.blInventory.get_InformationdataTable("OrdUnit_getgroupunit " + this.drpSubcategory.SelectedValue);
        this.drpUnit.DataSource = table;
        this.drpUnit.DataTextField = "cUnitDes";
        this.drpUnit.DataValueField = "nUnitID";
        this.drpUnit.DataBind();
        this.drpUnit.Items.Insert(0, string.Empty);
    }

    public void bindordunit(DropDownList drpsubcat, DropDownList drpordunt)
    {
        DataTable table = this.blInventory.get_InformationdataTable("OrdUnit_getgroupunit " + drpsubcat.SelectedValue);
        drpordunt.DataSource = table;
        drpordunt.DataTextField = "cUnitDes";
        drpordunt.DataValueField = "nUnitID";
        drpordunt.DataBind();
        drpordunt.Items.Insert(0, string.Empty);
    }

    public void bindstl()
    {
        DataSet set = this.mybll.get_Informationdataset("Sp_Smt_GetStyleIDForRename '" + this.Session["Uid"].ToString() + "'");
        this.drpStyle.DataSource = set;
        this.drpStyle.DataTextField = "StyleNO";
        this.drpStyle.DataValueField = "StyleID";
        this.drpStyle.DataBind();
        this.drpStyle.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpStyle.SelectedIndex = 0;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        DataTable table = (DataTable)this.ViewState["CurrentData"];
        if (!string.IsNullOrEmpty(this.lblrowindx.Text.Trim()))
        {
            if (table.Rows.Count > 0)
            {
                table.Rows.RemoveAt(int.Parse(this.lblrowindx.Text.Trim()));
            }
            this.ViewState["CurrentData"] = table;
        }
        string styleID = null;
        string styleno = null;
        string pONo = "";
        if (!string.IsNullOrEmpty(this.drpPONo.SelectedValue))
        {
            pONo = this.drpPONo.SelectedItem.ToString();
        }
        if (!string.IsNullOrEmpty(this.drpStyle.SelectedValue))
        {
            styleID = this.drpStyle.SelectedValue;
            styleno = this.drpStyle.SelectedItem.Text;
        }
        else
        {
            styleID = this.mybll.get_InformationdataTable("select nStyleID from  Smt_StyleMaster where cStyleNo='-'").Rows[0]["nStyleID"].ToString();
            styleno = "-";
        }
        int count = 1;
        if (table.Rows.Count > 0)
        {
            count = table.Rows.Count;
            this.drpCurrencytype.Enabled = false;
            this.drpDeliveryTo.Enabled = false;
            this.drpSupplier.Enabled = false;
            this.drpPIIssue.Enabled = false;
        }
        int num2 = 0;
        if (table.Rows.Count > 0)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string str4 = table.Rows[i]["MCatID"].ToString();
                string str5 = table.Rows[i]["subcatid"].ToString();
                string str6 = table.Rows[i]["cColour"].ToString();
                string str7 = table.Rows[i]["cSize"].ToString();
                string str8 = table.Rows[i]["ArticleID"].ToString();
                string str9 = table.Rows[i]["DimensionID"].ToString();
                table.Rows[i]["cStyleNo"].ToString();
                string str10 = table.Rows[i]["nstyCode"].ToString();
                string str11 = table.Rows[i]["clots"].ToString();
                if ((((str4 == this.drpMainCat.SelectedValue) && (str5 == this.drpSubcategory.SelectedValue)) && ((str8 == this.drpArticle.SelectedValue) && (str9 == this.drpDimension.SelectedValue))) && (((str6 == this.drpcolor.SelectedItem.Text.Trim()) && (str7 == this.drpSize.SelectedItem.Text.Trim())) && ((str10 == this.drpStyle.SelectedValue) && (str11 == this.drpPONo.SelectedValue))))
                {
                    label.Text = "Already Exists";
                    num2 = 1;
                    this.grdBookingDtl.Rows[i].BackColor = Color.Pink;
                }
            }
        }
        if (num2 < 1)
        {
            this.bindgrid(count, this.drpMainCat.SelectedValue, this.drpMainCat.SelectedItem.ToString(), this.drpSubcategory.SelectedItem.ToString(), this.drpcolor.SelectedItem.ToString(), this.drpSize.SelectedItem.ToString(), this.drpArticle.SelectedItem.ToString(), this.drpArticle.SelectedValue, this.drpDimension.SelectedItem.ToString(), this.drpDimension.SelectedValue, this.drpUnit.SelectedItem.ToString(), this.txtQuantity.Text.Trim(), this.txtRate.Text.Trim(), this.txtValue.Text.Trim(), styleno, styleID, pONo, this.drpMainCat.SelectedValue, this.drpSubcategory.SelectedValue, this.drpPONo.SelectedValue);
        }
        if (!string.IsNullOrEmpty(this.lblrowindx.Text))
        {
            this.drpPONo.Items.Clear();
            this.drpStyle.SelectedIndex = 0;
            this.drpSubcategory.Items.Clear();
            this.drpArticle.Items.Clear();
            this.drpDimension.Items.Clear();
            this.drpMainCat.SelectedIndex = 0;
            this.drpUnit.SelectedIndex = 0;
            this.drpcolor.SelectedIndex = 0;
            this.drpSize.SelectedIndex = 0;
            this.txtQuantity.Text = "";
            this.txtRate.Text = "";
            this.txtValue.Text = "";
        }
        this.lblrowindx.Text = "";
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.ClearAll();
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.txtPOno.Text = "";
    }

    protected void btnEdit_Click(object sender, ImageClickEventArgs e)
    {
        GridViewRow parent = ((ImageButton)sender).Parent.Parent as GridViewRow;
        Label label = (Label)parent.FindControl("lblpodtlsl");
        Label label2 = (Label)base.Master.FindControl("lbltotalinfo");
        label2.Text = "";
        this.drpUnit.Items.Clear();
        try
        {
            if (!string.IsNullOrEmpty(this.drpSupplier.SelectedValue))
            {
                this.drpMainCat.DataSource = this.blInventory.get_Informationdataset("Sp_POOtherBooking_GetMainCat " + this.drpSupplier.SelectedValue);
                this.drpMainCat.DataTextField = "cMainCategory";
                this.drpMainCat.DataValueField = "nMainCategory_ID";
                this.drpMainCat.DataBind();
                this.drpMainCat.Items.Insert(0, new ListItem(string.Empty, string.Empty));
                this.drpMainCat.SelectedIndex = 0;
                this.drpMainCat.Enabled = true;
            }
            DataTable table = this.blInventory.get_InformationdataTable("Sp_Smt_Otherbookingdtl_getbypono " + this.txtPOno.Text.Trim() + "," + label.Text);
            this.drpStyle.SelectedValue = table.Rows[0]["nstyCode"].ToString();
            this.drpStyle_SelectedIndexChanged(null, null);
            this.drpPONo.SelectedValue = table.Rows[0]["clots"].ToString();
            this.drpMainCat.SelectedValue = table.Rows[0]["MCatID"].ToString();
            this.drpMainCat_SelectedIndexChanged(null, null);
            this.drpSubcategory.SelectedValue = table.Rows[0]["SubcatID"].ToString();
            this.bindordunit(this.drpSubcategory, this.drpUnit);
            this.drpArticle.SelectedValue = table.Rows[0]["ArticleID"].ToString();
            this.drpDimension.SelectedValue = table.Rows[0]["DimensionID"].ToString();
            this.txtQuantity.Text = table.Rows[0]["nQty"].ToString();
            this.txtRate.Text = table.Rows[0]["nPrice"].ToString();
            this.txtValue.Text = table.Rows[0]["nVal"].ToString();
            this.drpcolor.SelectedValue = table.Rows[0]["nColNo"].ToString();
            this.drpSize.SelectedValue = table.Rows[0]["nCode"].ToString();
            string str = table.Rows[0]["nUnitID"].ToString();
            if (this.drpUnit.Items.FindByValue(str.Trim()).Value == str.Trim())
            {
                this.drpUnit.SelectedValue = table.Rows[0]["nUnitID"].ToString();
            }
            this.drpUnit.Enabled = true;
            this.lblrowindx.Text = parent.RowIndex.ToString();
            this.btnAdd.Text = "Edit";
        }
        catch (Exception exception)
        {
            label2.Text = exception.Message;
        }
    }

    protected void btnLoadArticle_Click(object sender, ImageClickEventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        if (!string.IsNullOrEmpty(this.drpMainCat.SelectedValue))
        {
            this.dlinventory.drp_ConstructionArticlebymaincategory(this.drpMainCat, this.drpArticle);
        }
        else
        {
            label.Text = "First Select Main Category";
        }
    }

    protected void btnLoadColor_Click(object sender, ImageClickEventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.mycls.drp_color(this.drpcolor);
    }

    protected void btnLoadDimension_Click(object sender, ImageClickEventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        if (!string.IsNullOrEmpty(this.drpMainCat.SelectedValue))
        {
            this.dlinventory.drp_Dimensionbymaincategory(this.drpMainCat, this.drpDimension);
        }
        else
        {
            label.Text = "First Select Main Category";
        }
    }

    protected void btnLoadItem_Click(object sender, ImageClickEventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.drpUnit.SelectedIndex = 0;
        if (!string.IsNullOrEmpty(this.drpMainCat.SelectedValue))
        {
            this.drpSubcategory.DataSource = this.blInventory.get_Informationdataset("Sp_Smt_SubCatagory_GetByMainCat " + this.drpMainCat.SelectedValue);
            this.drpSubcategory.DataTextField = "cItemDes";
            this.drpSubcategory.DataValueField = "nItemcode";
            this.drpSubcategory.DataBind();
            this.drpSubcategory.Items.Insert(0, new ListItem(string.Empty, string.Empty));
            this.drpSubcategory.SelectedIndex = 0;
        }
        else
        {
            label.Text = "First Select Main Category";
        }
    }

    protected void btnLoadMainCat_Click(object sender, ImageClickEventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.drpSubcategory.Items.Clear();
        this.drpArticle.Items.Clear();
        this.drpDimension.Items.Clear();
        if (!string.IsNullOrEmpty(this.drpSupplier.SelectedValue))
        {
            this.drpMainCat.DataSource = this.blInventory.get_Informationdataset("Sp_POOtherBooking_GetMainCat " + this.drpSupplier.SelectedValue);
            this.drpMainCat.DataTextField = "cMainCategory";
            this.drpMainCat.DataValueField = "nMainCategory_ID";
            this.drpMainCat.DataBind();
            this.drpMainCat.Items.Insert(0, new ListItem(string.Empty, string.Empty));
            this.drpMainCat.SelectedIndex = 0;
        }
        else
        {
            label.Text = "First Select Supplier";
        }
    }

    protected void btnPrintpoconfirm_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        C1GridViewRow parent = ((LinkButton)sender).Parent.Parent as C1GridViewRow;
        Label label2 = (Label)parent.FindControl("lblPONO");
        this.Session["Param"] = "PONO";
        this.Session["pono"] = label2.Text.Trim();
        this.runjQueryCode("window.open('Report_Merchandising/Smt_MerchandisingReport.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        string str = string.IsNullOrEmpty(this.txtPOno.Text) ? "0" : this.txtPOno.Text;
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        SqlConnection cn = GetWay.SpecFo_Inventorycon;
        MC mc = new MC();
        cn.Open();
        SqlTransaction tn = cn.BeginTransaction();
        try
        {
            string[] normalparam = new string[] { "@pono", "@nSuplierID", "@cCurType", "@cCredtDay", "@cuser", "@att", "@cRemark", "@Company_ID", "@nOrderType", "@nIssueTo" };
            string[] normalprmval = new string[] { str, this.drpSupplier.SelectedValue, this.drpCurrencytype.SelectedValue, this.txtCreditDays.Text, this.Session["Uid"].ToString(), this.txtAttention.Text, this.txtRemarks.Text, this.drpDeliveryTo.SelectedValue, this.drpOrderType.SelectedValue, this.drpPIIssue.SelectedValue };
            string[] dtmparam = new string[] { "@dDelevey" };
            string[] dtmparamval = new string[] { this.txtDeliverydt.Text.Trim() };
            mc.MC_Save_tr("Sp_Smt_Otherbookinghdr_save", cn, tn, normalparam, normalprmval, dtmparam, dtmparamval);
            for (int i = 0; i < this.grdBookingDtl.Rows.Count; i++)
            {
                Label label2 = (Label)this.grdBookingDtl.Rows[i].FindControl("lblSerial");
                Label label3 = (Label)this.grdBookingDtl.Rows[i].FindControl("lblStyleID");
                Label label4 = (Label)this.grdBookingDtl.Rows[i].FindControl("lblSize");
                Label label5 = (Label)this.grdBookingDtl.Rows[i].FindControl("lblColor");
                Label label6 = (Label)this.grdBookingDtl.Rows[i].FindControl("lblUnit");
                Label label7 = (Label)this.grdBookingDtl.Rows[i].FindControl("lblrate");
                Label label8 = (Label)this.grdBookingDtl.Rows[i].FindControl("lblQty");
                Label label9 = (Label)this.grdBookingDtl.Rows[i].FindControl("lblValue");
                Label label10 = (Label)this.grdBookingDtl.Rows[i].FindControl("lblPOno");
                Label label11 = (Label)this.grdBookingDtl.Rows[i].FindControl("lblArticleID");
                Label label12 = (Label)this.grdBookingDtl.Rows[i].FindControl("lblDimensionID");
                Label label13 = (Label)this.grdBookingDtl.Rows[i].FindControl("lblitem");
                Label label14 = (Label)this.grdBookingDtl.Rows[i].FindControl("lblmcatid");
                Label label15 = (Label)this.grdBookingDtl.Rows[i].FindControl("lblsubcatid");
                Label label16 = (Label)this.grdBookingDtl.Rows[i].FindControl("lbllot");
                string[] strArray5 = new string[] {
                    "@pono", "@nLnNo", "@Itemdes", "@Size", "@Colour", "@cUnit", "@nQty", "@nPrice", "@nVal", "@cUser", "@nStyCode", "@cPo", "@SubcatID", "@ArticleID", "@DmnsionID", "@MCatID",
                    "@clots"
                };
                string[] strArray6 = new string[] {
                    str, label2.Text, label13.Text, label4.Text, label5.Text, label6.Text, label8.Text, label7.Text, label9.Text, this.Session["Uid"].ToString(), label3.Text, label10.Text, label15.Text, label11.Text, label12.Text, label14.Text,
                    label16.Text
                };
                if (this.grdBookingDtl.Rows[i].Visible)
                {
                    mc.MC_Save_nodt_tr("Sp_Smt_OtherBookingdetail_Save", cn, tn, strArray5, strArray6);
                }
            }
            tn.Commit();
            label.Text = "Saved Successfully";
            this.bindgrid();
            this.ClearAll();
            if (string.IsNullOrEmpty(this.txtPOno.Text))
            {
                DataTable table = this.blInventory.get_InformationdataTable("select nPoLast from Smt_Parameters");
                this.txtPOno.Text = table.Rows[0]["nPoLast"].ToString();
            }
        }
        catch (Exception exception)
        {
            tn.Rollback();
            label.Text = exception.Message;
        }
        finally
        {
            cn.Close();
        }
    }

    public void ClearAll()
    {
        this.txtAttention.Text = "";
        this.txtCreditDays.Text = "";
        this.txtDeliverydt.Text = "";
        this.txtQuantity.Text = "";
        this.txtRate.Text = "";
        this.txtValue.Text = "";
        this.drpArticle.Enabled = false;
        this.drpArticle.Items.Clear();
        this.drpcolor.SelectedIndex = 0;
        this.drpCurrencytype.SelectedValue = "";
        this.drpDeliveryTo.SelectedValue = "";
        this.drpDimension.Items.Clear();
        this.drpDimension.Enabled = false;
        this.drpMainCat.Items.Clear();
        this.drpMainCat.Enabled = false;
        this.drpPONo.Items.Clear();
        this.drpPONo.Enabled = false;
        this.drpSize.SelectedIndex = 0;
        this.drpSubcategory.Items.Clear();
        this.drpSubcategory.Enabled = false;
        this.drpSupplier.SelectedValue = "";
        this.drpUnit.SelectedIndex = 0;
        this.drpUnit.Enabled = false;
        this.SetInitialAvailableStyle();
        this.drpSupplier.Enabled = true;
        this.drpCurrencytype.Enabled = true;
        this.drpDeliveryTo.Enabled = true;
        this.txtCreditDays.Enabled = true;
        this.txtRemarks.Text = "";
        this.drpOrderType.SelectedValue = "";
        this.drpPIIssue.Enabled = true;
        this.drpPIIssue.SelectedIndex = 0;
        this.drpStyle.SelectedIndex = 0;
        this.lblrowindx.Text = "";
    }

    protected void drpMainCat_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.drpDimension.Items.Clear();
        this.drpDimension.Enabled = false;
        this.drpArticle.Items.Clear();
        this.drpArticle.Enabled = false;
        this.drpSubcategory.Items.Clear();
        if (!string.IsNullOrEmpty(this.drpMainCat.SelectedValue))
        {
            this.drpSubcategory.DataSource = this.blInventory.get_Informationdataset("Sp_Smt_SubCatagory_GetByMainCat " + this.drpMainCat.SelectedValue);
            this.drpSubcategory.DataTextField = "cItemDes";
            this.drpSubcategory.DataValueField = "nItemcode";
            this.drpSubcategory.DataBind();
            this.drpSubcategory.Items.Insert(0, new ListItem(string.Empty, string.Empty));
            this.drpSubcategory.SelectedIndex = 0;
            this.drpUnit.Items.Clear();
            this.dlinventory.drp_ConstructionArticlebymaincategory(this.drpMainCat, this.drpArticle);
            this.dlinventory.drp_Dimensionbymaincategory(this.drpMainCat, this.drpDimension);
            this.drpArticle.Enabled = true;
            this.drpDimension.Enabled = true;
        }
    }

    protected void drpStyle_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.drpPONo.Items.Clear();
        if (!string.IsNullOrEmpty(this.drpStyle.SelectedValue))
        {
            this.drpPONo.DataSource = this.blInventory.get_InformationdataTable("Sp_Smt_POOtherBooking_GetPO " + this.drpStyle.SelectedValue);
            this.drpPONo.DataTextField = "cPoNum";
            this.drpPONo.DataValueField = "cOrderNu";
            this.drpPONo.DataBind();
            this.drpPONo.Enabled = true;
        }
    }

    protected void drpSubcategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.bindordunit(this.drpSubcategory, this.drpUnit);
        string str = this.blInventory.get_InformationdataTable("select cUnit from Smt_SubCatagory where cCode=" + this.drpSubcategory.SelectedValue).Rows[0]["cUnit"].ToString().Trim();
        this.drpUnit.SelectedValue = str;
        this.drpUnit.Enabled = true;
    }

    protected void drpSupplier_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.drpArticle.Items.Clear();
        this.drpArticle.Enabled = false;
        this.drpDimension.Items.Clear();
        this.drpDimension.Enabled = false;
        this.drpSubcategory.Items.Clear();
        this.drpMainCat.Enabled = true;
        this.txtPOno.Text = "";
        this.drpUnit.Items.Clear();
        this.ViewState["CurrentData"] = null;
        this.SetInitialAvailableStyle();
        if (!string.IsNullOrEmpty(this.drpSupplier.SelectedValue))
        {
            this.drpMainCat.DataSource = this.blInventory.get_Informationdataset("Sp_POOtherBooking_GetMainCat " + this.drpSupplier.SelectedValue);
            this.drpMainCat.DataTextField = "cMainCategory";
            this.drpMainCat.DataValueField = "nMainCategory_ID";
            this.drpMainCat.DataBind();
            this.drpMainCat.Items.Insert(0, new ListItem(string.Empty, string.Empty));
            this.drpMainCat.SelectedIndex = 0;
            this.drpMainCat.Enabled = true;
            DataTable table = this.blInventory.get_InformationdataTable("select cAtt from Smt_Suppliers where nCode='" + this.drpSupplier.SelectedValue + "'");
            this.txtAttention.Text = table.Rows[0]["cAtt"].ToString();
        }
    }

    protected void Editpo(object sender, EventArgs e)
    {
        this.lblrowindx.Text = "";
        C1GridViewRow parent = ((LinkButton)sender).Parent.Parent as C1GridViewRow;
        LinkButton button = (LinkButton)parent.FindControl("btnEdit");
        DataTable table = this.blInventory.get_InformationdataTable("Sp_Smt_Poheader_Viewpodtl " + button.CommandArgument);
        this.drpSupplier.SelectedValue = table.Rows[0]["nSuplierID"].ToString();
        this.drpOrderType.SelectedValue = table.Rows[0]["nOrderType"].ToString();
        this.txtAttention.Text = table.Rows[0]["cAtt"].ToString();
        this.drpDeliveryTo.SelectedValue = table.Rows[0]["Company_ID"].ToString();
        this.drpPIIssue.SelectedValue = table.Rows[0]["nIssueTo"].ToString();
        this.txtCreditDays.Text = table.Rows[0]["cCredtDay"].ToString();
        this.txtDeliverydt.Text = table.Rows[0]["dDelevey"].ToString();
        this.txtRemarks.Text = table.Rows[0]["cRemark"].ToString();
        this.txtPOno.Text = button.CommandArgument;
        this.drpCurrencytype.SelectedValue = table.Rows[0]["cCurType"].ToString();
        if (!string.IsNullOrEmpty(this.drpSupplier.SelectedValue))
        {
            this.drpMainCat.DataSource = this.blInventory.get_Informationdataset("Sp_POOtherBooking_GetMainCat " + this.drpSupplier.SelectedValue);
            this.drpMainCat.DataTextField = "cMainCategory";
            this.drpMainCat.DataValueField = "nMainCategory_ID";
            this.drpMainCat.DataBind();
            this.drpMainCat.Items.Insert(0, new ListItem(string.Empty, string.Empty));
            this.drpMainCat.SelectedIndex = 0;
            this.drpMainCat.Enabled = true;
            DataTable table2 = this.blInventory.get_InformationdataTable("select cAtt from Smt_Suppliers where nCode='" + this.drpSupplier.SelectedValue + "'");
            this.txtAttention.Text = table2.Rows[0]["cAtt"].ToString();
        }
        DataTable table3 = this.blInventory.get_InformationdataTable("Sp_Smt_PoDetails_Viewpodtl " + button.CommandArgument);
        this.grdBookingDtl.DataSource = table3;
        this.grdBookingDtl.DataBind();
        this.ViewState["CurrentData"] = table3;
        this.C1TabControl1.MoveFirst();
    }

    private string getjQueryCode(string jsCodetoRun)
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine("$(document).ready(function() {");
        builder.AppendLine(jsCodetoRun);
        builder.AppendLine(" });");
        return builder.ToString();
    }

    protected void grdBookingDtl_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label label = (Label)e.Row.FindControl("lblMainct");
            if (string.IsNullOrEmpty(label.Text.Trim()))
            {
                e.Row.Visible = false;
            }
        }
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label label2 = (Label)e.Row.FindControl("lblSerial");
            label2.Text = (e.Row.RowIndex + 1).ToString();
        }
    }

    protected void grdView_Filtering(object sender, C1GridViewFilterEventArgs e)
    {
        this.bindgrid();
    }

    protected void grdView_PageIndexChanging(object sender, C1GridViewPageEventArgs e)
    {
        this.grdView.PageIndex = e.NewPageIndex;
        this.bindgrid();
    }

    public void LoadSize()
    {
        this.drpSize.DataSource = this.blInventory.get_Informationdataset("select nCode,cSize1 from Smt_Sizes order by cSize1");
        this.drpSize.DataTextField = "cSize1";
        this.drpSize.DataValueField = "nCode";
        this.drpSize.DataBind();
    }

    public void LoadStyle()
    {
    }

    public void LoadSupplier()
    {
        this.drpSupplier.DataSource = this.blInventory.get_Informationdataset("select nCode,cSupName from Smt_Suppliers order by cSupName");
        this.drpSupplier.DataTextField = "cSupName";
        this.drpSupplier.DataValueField = "nCode";
        this.drpSupplier.DataBind();
        this.drpSupplier.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpSupplier.SelectedIndex = 0;
    }

    public void LoadUnit()
    {
        this.drpUnit.DataSource = this.blInventory.get_Informationdataset("select nUnitID,cUnitDes from Smt_Unit order by cUnitDes");
        this.drpUnit.DataTextField = "cUnitDes";
        this.drpUnit.DataValueField = "nUnitID";
        this.drpUnit.DataBind();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.Session["Uid"] == null)
        {
            base.Response.Redirect("Smt_Login.aspx", false);
        }
        else if (!base.IsPostBack)
        {
            this.LoadSupplier();
            this.LoadSize();
            this.mycls.drp_color(this.drpcolor);
            this.bindstl();
            this.dlinventory.drp_Currencytype(this.drpCurrencytype);
            this.mycls.drp_Company(this.drpDeliveryTo);
            this.mycls.drp_Company(this.drpPIIssue);
            this.SetInitialAvailableStyle();
            this.bindgrid();
        }
    }

    protected void Rowremove(object sender, ImageClickEventArgs e)
    {
        GridViewRow parent = ((ImageButton)sender).Parent.Parent as GridViewRow;
        DataTable table = (DataTable)this.ViewState["CurrentData"];
        if (table.Rows.Count > 0)
        {
            table.Rows.RemoveAt(parent.RowIndex);
        }
        this.ViewState["CurrentData"] = table;
        this.grdBookingDtl.DataSource = table;
        this.grdBookingDtl.DataBind();
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

    private void SetInitialAvailableStyle()
    {
        DataTable table = new DataTable();
        DataRow row = null;
        table.Columns.Add(new DataColumn("MCatID", typeof(int)));
        table.Columns.Add(new DataColumn("cMainCategory", typeof(string)));
        table.Columns.Add(new DataColumn("cItemdes", typeof(string)));
        table.Columns.Add(new DataColumn("cColour", typeof(string)));
        table.Columns.Add(new DataColumn("cSize", typeof(string)));
        table.Columns.Add(new DataColumn("cArt", typeof(string)));
        table.Columns.Add(new DataColumn("ArticleID", typeof(int)));
        table.Columns.Add(new DataColumn("cDimec", typeof(string)));
        table.Columns.Add(new DataColumn("DimensionID", typeof(int)));
        table.Columns.Add(new DataColumn("cUnit", typeof(string)));
        table.Columns.Add(new DataColumn("nQty", typeof(decimal)));
        table.Columns.Add(new DataColumn("nPrice", typeof(decimal)));
        table.Columns.Add(new DataColumn("nVal", typeof(decimal)));
        table.Columns.Add(new DataColumn("cStyleNo", typeof(string)));
        table.Columns.Add(new DataColumn("nstyCode", typeof(int)));
        table.Columns.Add(new DataColumn("cPo", typeof(string)));
        table.Columns.Add(new DataColumn("SubcatID", typeof(int)));
        table.Columns.Add(new DataColumn("clots", typeof(string)));
        table.Columns.Add(new DataColumn("nDtlCode", typeof(int)));
        row = table.NewRow();
        row["MCatID"] = 0;
        row["cMainCategory"] = string.Empty;
        row["cItemdes"] = string.Empty;
        row["cColour"] = string.Empty;
        row["cSize"] = string.Empty;
        row["cArt"] = string.Empty;
        row["ArticleID"] = 0;
        row["cDimec"] = string.Empty;
        row["DimensionID"] = 0;
        row["cUnit"] = string.Empty;
        row["nQty"] = 0;
        row["nPrice"] = 0;
        row["nVal"] = 0;
        row["cStyleNo"] = string.Empty;
        row["nstyCode"] = 0;
        row["cPo"] = string.Empty;
        row["SubcatID"] = 0;
        row["clots"] = string.Empty;
        row["nDtlCode"] = 0;
        table.Rows.Add(row);
        this.ViewState["CurrentData"] = table;
        this.grdBookingDtl.DataSource = table;
        this.grdBookingDtl.DataBind();
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}