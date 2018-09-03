using AjaxControlToolkit;
using ASP;
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

public partial class NazCostsheet : System.Web.UI.Page
{
    private BLL _bl = new BLL();
    private BLLInventory _blinv = new BLLInventory();
    private MC _mc = new MC();
    private decimal acrdz;
    private decimal acrinside;
    private decimal acroutside;
    private decimal acrttl;
    //protected Button btnAddbtbstatus;
    //protected Button btnAdditem;
    //protected Button btnClear;
    //protected HtmlInputButton btncpy;
    //protected Button btnppgntpo;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    //protected ModalPopupExtender Button2_ModalPopupExtender;
    private SqlConnection cn = GetWay.SpecFo_Inventorycon;
    private DALInventory dlinv = new DALInventory();
    //protected DropDownList drpConsunit;
    //protected DropDownList drpCurrency;
    //protected DropDownList drpOrderunit;
    //protected DropDownList drpStyle;
    //protected DropDownList drpSuppliertype;
    //protected DropDownList drpType;
    private decimal dyndz;
    private decimal dynInside;
    private decimal dynOutside;
    private decimal dynttl;
    private decimal embdz;
    private decimal embinside;
    private decimal emboutside;
    private decimal embttl;
    private decimal fabdz;
    private decimal fabinside;
    private decimal fabout;
    private decimal fabttl;
    //protected GridView grdBtbstatus;
    //protected GridView grdcolqty;
    //protected GridView grdcost;
    //protected System.Web.UI.WebControls.Image imgStyle;
    private decimal Knitdz;
    private decimal KnitInside;
    private decimal KnitOutside;
    private decimal Knitttl;
    //protected RequiredFieldValidator RequiredFieldValidator1;
    //protected ValidatorCalloutExtender RequiredFieldValidator1_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator10;
    //protected ValidatorCalloutExtender RequiredFieldValidator10_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator11;
    //protected ValidatorCalloutExtender RequiredFieldValidator11_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator12;
    //protected ValidatorCalloutExtender RequiredFieldValidator12_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator13;
    //protected ValidatorCalloutExtender RequiredFieldValidator13_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator2;
    //protected ValidatorCalloutExtender RequiredFieldValidator2_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator3;
    //protected ValidatorCalloutExtender RequiredFieldValidator3_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator4;
    //protected ValidatorCalloutExtender RequiredFieldValidator4_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator5;
    //protected ValidatorCalloutExtender RequiredFieldValidator5_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator7;
    //protected ValidatorCalloutExtender RequiredFieldValidator7_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator8;
    //protected ValidatorCalloutExtender RequiredFieldValidator8_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator9;
    //protected ValidatorCalloutExtender RequiredFieldValidator9_ValidatorCalloutExtender;
    //protected TextBox taccdz;
    //protected TextBox taccinside;
    //protected TextBox taccoutside;
    //protected TextBox taccttl;
    //protected TextBox tbblcinhand;
    //protected TextBox tbblcinhandprcnt;
    //protected TextBox tbblcttlval;
    //protected TextBox tbblcttlvalprcnt;
    //protected TextBox tBuyer;
    //protected TextBox tBuyercommission;
    //protected FilteredTextBoxExtender tBuyercommission_FilteredTextBoxExtender;
    //protected TextBox tBuyercommissionttl;
    //protected TextBox tcmperdz;
    //protected TextBox tcmperset;
    //protected TextBox tCnfamt;
    //protected FilteredTextBoxExtender tCnfamt_FilteredTextBoxExtender;
    //protected TextBox tCnfperdz;
    //protected TextBox tCnfttl;
    //protected TextBox tCommercialbnkamt;
    //protected FilteredTextBoxExtender tCommercialbnkamt_FilteredTextBoxExtender;
    //protected TextBox tCommercialbnkamtttl;
    //protected TextBox tCostofmacking;
    //protected FilteredTextBoxExtender tCostofmacking_FilteredTextBoxExtender;
    //protected TextBox tcostperdz;
    //protected TextBox tdyedfabdz;
    //protected TextBox tDyedfabkg;
    //protected TextBox tdyndz;
    //protected TextBox tdyninside;
    //protected TextBox tdynoutside;
    //protected TextBox tdynttl;
    //protected TextBox tembdz;
    //protected TextBox tembinside;
    //protected TextBox temboutside;
    //protected TextBox tembttl;
    //protected TextBox tExacccost;
    //protected FilteredTextBoxExtender tExacccost_FilteredTextBoxExtender;
    //protected TextBox tExfabcost;
    //protected FilteredTextBoxExtender tExfabcost_FilteredTextBoxExtender;
    //protected TextBox tFabconsumption;
    //protected FilteredTextBoxExtender tFabconsumption_FilteredTextBoxExtender;
    //protected TextBox tfabdz;
    //protected TextBox tfabinside;
    //protected TextBox tfabout;
    //protected TextBox tFabrication;
    //protected TextBox tfabttl;
    //protected TextBox Tfinaltotalcost;
    //protected TextBox tItem;
    //protected TextBox titemfabactcst;
    //protected FilteredTextBoxExtender titemfabactcst_FilteredTextBoxExtender;
    //protected TextBox titemfabfab;
    //protected FilteredTextBoxExtender titemfabfab_FilteredTextBoxExtender;
    //protected TextBox titmfab;
    //protected TextBox titmfabtcost;
    //protected FilteredTextBoxExtender titmfabtcost_FilteredTextBoxExtender;
    //protected TextBox titmfabunfab;
    //protected FilteredTextBoxExtender titmfabunfab_FilteredTextBoxExtender;
    //protected TextBox tknDz;
    //protected TextBox tknInside;
    //protected TextBox tknoutside;
    //protected TextBox tKnttl;
    //protected TextBox tLCaccessories;
    //protected TextBox tLCaccessoriesprcnt;
    //protected TextBox tLcbuyercommission;
    //protected TextBox tLcbuyercommissionprcnt;
    //protected TextBox tLCcnf;
    //protected TextBox tLCcnfprcnt;
    //protected TextBox tLCcommercialbnk;
    //protected TextBox tLCcommercialbnkprcnt;
    //protected TextBox tLCdyinginside;
    //protected TextBox tLCdyinginsideprcnt;
    //protected TextBox tLcdyingoutside;
    //protected TextBox tLcdyingoutsideprcnt;
    //protected TextBox tLcFabric;
    //protected TextBox tLcFabricprcent;
    //protected TextBox tLcknit;
    //protected TextBox tLcknitprcnt;
    //protected TextBox tLCNO;
    //protected TextBox tLCprintembdry;
    //protected TextBox tLCprintembdryprcnt;
    //protected TextBox tLctstingcharge;
    //protected TextBox tLctstingchargeprcnt;
    //protected TextBox tLcyarn;
    //protected TextBox tLcyarnprcnt;
    //protected TextBox tMasterlcval;
    //protected TextBox tOrderno;
    //protected TextBox tTestingchargeamt;
    //protected FilteredTextBoxExtender tTestingchargeamt_FilteredTextBoxExtender;
    //protected TextBox tTestingchargettl;
    //protected TextBox ttk;
    //protected FilteredTextBoxExtender ttk_FilteredTextBoxExtender;
    //protected TextBox ttkttl;
    //protected TextBox tTotalcostdyedfab;
    //protected TextBox tTotalcostdz;
    //protected TextBox tTotalinside;
    //protected TextBox tTotalinsideprcnt;
    //protected TextBox tTotaloutside;
    //protected TextBox tTotaloutsideprcnt;
    //protected TextBox tTtlgray;
    //protected TextBox tUnitprice;
    //protected FilteredTextBoxExtender tUnitprice_FilteredTextBoxExtender;
    //protected TextBox tUpriceperdz;
    //protected TextBox txtAmount;
    //protected TextBox txtCmDzmanual;
    //protected FilteredTextBoxExtender txtCmDzmanual_FilteredTextBoxExtender;
    //protected TextBox txtConsumption;
    //protected FilteredTextBoxExtender txtConsumption_FilteredTextBoxExtender;
    //protected TextBox txtDescription;
    //protected TextBox txtGmtQty;
    //protected TextBox txtimgslno;
    //protected TextBox txtOrdqty;
    //protected TextBox txtOtherchngs;
    //protected FilteredTextBoxExtender txtOtherchngs_FilteredTextBoxExtender1;
    //protected TextBox txtPercent;
    //protected FilteredTextBoxExtender txtPercent_FilteredTextBoxExtender;
    //protected TextBox txtRemarks;
    //protected TextBox txtReqqty;
    //protected TextBox txtTotalcost;
    //protected TextBox txtUnitprice;
    //protected FilteredTextBoxExtender txtUnitprice_FilteredTextBoxExtender;
    //protected TextBox tYarncostdz;
    //protected TextBox tYarncostttl;
    //protected TextBox tYarninside;
    //protected TextBox tYarnoutside;
    //protected UpdatePanel UpdatePanel1;
    private decimal Yrndz;
    private decimal YrnInside;
    private decimal YrnOutside;
    private decimal Yrnttl;


    public void bindgrid(int count, string type, string desc, string gmtqty, string consumption, string fabprcnt, string reqqty, string consmunit, string consmunitdesc, string uprice, string amnt, string supliertype, string totalCost)
    {
        DataRow row;
        DataTable table = new DataTable();
        table.Columns.Add(new DataColumn("MatType", typeof(string)));
        table.Columns.Add(new DataColumn("MatDesc", typeof(string)));
        table.Columns.Add(new DataColumn("GmtQty", typeof(decimal)));
        table.Columns.Add(new DataColumn("Comnsmption", typeof(decimal)));
        table.Columns.Add(new DataColumn("Prcent", typeof(string)));
        table.Columns.Add(new DataColumn("Reqqty", typeof(decimal)));
        table.Columns.Add(new DataColumn("ConsUnit", typeof(string)));
        table.Columns.Add(new DataColumn("cUnitDes", typeof(string)));
        table.Columns.Add(new DataColumn("Unitprice", typeof(decimal)));
        table.Columns.Add(new DataColumn("Amntdz", typeof(decimal)));
        table.Columns.Add(new DataColumn("SupplierType", typeof(string)));
        table.Columns.Add(new DataColumn("Costttl", typeof(decimal)));
        if (this.ViewState["ddata"] != null)
        {
            for (int i = 0; i < count; i++)
            {
                table = (DataTable)this.ViewState["ddata"];
                if (table.Rows.Count > 0)
                {
                    table.NewRow()[0] = table.Rows[0][0].ToString();
                }
            }
            row = table.NewRow();
            row["MatType"] = type;
            row["MatDesc"] = desc;
            row["GmtQty"] = gmtqty;
            row["Comnsmption"] = consumption;
            row["Prcent"] = fabprcnt;
            row["Reqqty"] = reqqty;
            row["ConsUnit"] = consmunit;
            row["cUnitDes"] = consmunitdesc;
            row["Unitprice"] = uprice;
            row["Amntdz"] = amnt;
            row["SupplierType"] = supliertype;
            row["Costttl"] = totalCost;
            table.Rows.Add(row);
        }
        else
        {
            row = table.NewRow();
            row["MatType"] = type;
            row["MatDesc"] = desc;
            row["GmtQty"] = gmtqty;
            row["Comnsmption"] = consumption;
            row["Prcent"] = fabprcnt;
            row["Reqqty"] = reqqty;
            row["ConsUnit"] = consmunit;
            row["cUnitDes"] = consmunitdesc;
            row["Unitprice"] = uprice;
            row["Amntdz"] = amnt;
            row["SupplierType"] = supliertype;
            row["Costttl"] = totalCost;
            table.Rows.Add(row);
        }
        if (this.ViewState["ddata"] != null)
        {
            this.grdcost.DataSource = this.ViewState["ddata"];
            this.grdcost.DataBind();
        }
        else
        {
            this.grdcost.DataSource = table;
            this.grdcost.DataBind();
        }
        this.ViewState["ddata"] = table;
    }

    public void bindStyleid()
    {
        DataTable table = this._bl.get_InformationdataTable("Sp_Smt_GetStyleID '" + this.Session["Uid"].ToString() + "','MC'");
        this.drpStyle.Items.Add(new ListItem("", ""));
        this.drpStyle.DataSource = table;
        this.drpStyle.DataTextField = "StyleNO";
        this.drpStyle.DataValueField = "StyleID";
        this.drpStyle.DataBind();
        this.drpStyle.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpStyle.SelectedIndex = 0;
    }

    public void bindunit()
    {
        DataTable table = this._blinv.get_InformationdataTable("select nUnitID,cUnitDes from Smt_Unit order by cUnitDes");
        this.drpConsunit.DataSource = table;
        this.drpConsunit.DataTextField = "cUnitDes";
        this.drpConsunit.DataValueField = "nUnitID";
        this.drpConsunit.DataBind();
    }

    public void bndbtbstatus(int count, string itm, string Tgtcst, string actcst, string fabcst, string ubfabcst, string rmrk)
    {
        DataRow row;
        DataTable table = new DataTable();
        table.Columns.Add(new DataColumn("Itemd", typeof(string)));
        table.Columns.Add(new DataColumn("Tcst", typeof(string)));
        table.Columns.Add(new DataColumn("Actcst", typeof(string)));
        table.Columns.Add(new DataColumn("Fabcst", typeof(string)));
        table.Columns.Add(new DataColumn("unfabcst", typeof(string)));
        table.Columns.Add(new DataColumn("rmrk", typeof(string)));
        if (this.ViewState["btb"] != null)
        {
            for (int i = 0; i < count; i++)
            {
                table = (DataTable)this.ViewState["btb"];
                if (table.Rows.Count > 0)
                {
                    table.NewRow()[0] = table.Rows[0][0].ToString();
                }
            }
            row = table.NewRow();
            row["Itemd"] = itm;
            row["Tcst"] = Tgtcst;
            row["Actcst"] = actcst;
            row["Fabcst"] = fabcst;
            row["unfabcst"] = ubfabcst;
            row["rmrk"] = rmrk;
            table.Rows.Add(row);
        }
        else
        {
            row = table.NewRow();
            row["Itemd"] = itm;
            row["Tcst"] = Tgtcst;
            row["Actcst"] = actcst;
            row["Fabcst"] = fabcst;
            row["unfabcst"] = ubfabcst;
            row["rmrk"] = rmrk;
            table.Rows.Add(row);
        }
        table.DefaultView.Sort = "Itemd ASC";
        if (this.ViewState["btb"] != null)
        {
            this.grdBtbstatus.DataSource = this.ViewState["btb"];
            this.grdBtbstatus.DataBind();
        }
        else
        {
            this.grdBtbstatus.DataSource = table;
            this.grdBtbstatus.DataBind();
        }
        this.ViewState["btb"] = table;
    }

    protected void btnAddbtbstatus_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        DataTable table = (DataTable)this.ViewState["btb"];
        int count = 1;
        int num2 = 0;
        if ((this.ViewState["btb"] != null) && (table.Rows.Count > 0))
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (table.Rows[i]["Itemd"].ToString() == this.titmfab.Text)
                {
                    num2 = 1;
                    this.grdBtbstatus.Rows[i].BackColor = Color.Pink;
                    label.Text = "Already Added Same Item";
                }
            }
        }
        if (num2 < 1)
        {
            this.bndbtbstatus(count, this.titmfab.Text, this.titmfabtcost.Text, this.titemfabactcst.Text, this.titemfabfab.Text, this.titmfabunfab.Text, this.txtRemarks.Text);
            this.titmfab.Text = "";
            this.titmfabtcost.Text = "";
            this.titemfabactcst.Text = "";
            this.titemfabfab.Text = "";
            this.titmfabunfab.Text = "";
        }
    }

    protected void btnAdditem_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        DataTable table = (DataTable)this.ViewState["ddata"];
        int count = 1;
        int num2 = 0;
        if ((this.ViewState["ddata"] != null) && (table.Rows.Count > 0))
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string str = table.Rows[i]["MatType"].ToString();
                string str2 = table.Rows[i]["MatDesc"].ToString();
                if ((str == this.drpType.SelectedValue) && (str2 == this.txtDescription.Text.Trim()))
                {
                    num2 = 1;
                    this.grdcost.Rows[i].BackColor = Color.Pink;
                    label.Text = "Already Added Same Item";
                }
            }
        }
        if (num2 < 1)
        {
            string gmtqty = string.IsNullOrEmpty(this.txtGmtQty.Text) ? "0.000" : this.txtGmtQty.Text;
            string consumption = string.IsNullOrEmpty(this.txtConsumption.Text) ? "0.000" : this.txtConsumption.Text;
            string reqqty = string.IsNullOrEmpty(this.txtReqqty.Text) ? "0.000" : this.txtReqqty.Text;
            string uprice = string.IsNullOrEmpty(this.txtUnitprice.Text) ? "0.000" : this.txtUnitprice.Text;
            string totalCost = string.IsNullOrEmpty(this.txtTotalcost.Text) ? "0.00" : this.txtTotalcost.Text;
            if (!string.IsNullOrEmpty(this.txtAmount.Text))
            {
                string text = this.txtAmount.Text;
            }
            try
            {
                this.bindgrid(count, this.drpType.SelectedValue, this.txtDescription.Text.Trim(), gmtqty, consumption, this.txtPercent.Text, reqqty, this.drpConsunit.SelectedValue, this.drpConsunit.SelectedItem.ToString(), uprice, this.txtAmount.Text.Trim(), this.drpSuppliertype.SelectedValue, totalCost);
            }
            catch (Exception exception)
            {
                label.Text = exception.Message;
            }
        }
        this.runjQueryCode("Allinone();");
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.clr();
        this.drpStyle.SelectedIndex = 0;
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.txtConsumption.Text = "";
        this.txtPercent.Text = "";
        this.txtReqqty.Text = "";
        this.drpConsunit.SelectedIndex = 0;
        this.txtUnitprice.Text = "";
        this.txtAmount.Text = "";
        this.txtTotalcost.Text = "";
        this.txtGmtQty.Text = "";
        this.txtDescription.Text = "";
        this.drpType.SelectedIndex = 0;
        this.titmfab.Text = "";
        this.titmfabtcost.Text = "";
        this.titemfabactcst.Text = "";
        this.titemfabfab.Text = "";
        this.titmfabunfab.Text = "";
    }

    protected void btnDelete_Click(object sender, ImageClickEventArgs e)
    {
        this.tLcyarn.Text = "";
        this.tLcyarnprcnt.Text = "";
        this.tLcknit.Text = "";
        this.tLcknitprcnt.Text = "";
        this.tLCaccessories.Text = "";
        this.tLCaccessoriesprcnt.Text = "";
        this.tLCdyinginside.Text = "";
        this.tLCdyinginsideprcnt.Text = "";
        this.tLcdyingoutside.Text = "";
        this.tLcdyingoutsideprcnt.Text = "";
        this.tLCprintembdry.Text = "";
        this.tLCprintembdryprcnt.Text = "";
        this.tYarncostdz.Text = "";
        this.tYarncostttl.Text = "";
        this.tYarninside.Text = "";
        this.tYarnoutside.Text = "";
        this.tknDz.Text = "";
        this.tKnttl.Text = "";
        this.tknInside.Text = "";
        this.tknoutside.Text = "";
        this.tdyndz.Text = "";
        this.tdynttl.Text = "";
        this.tdyninside.Text = "";
        this.tdynoutside.Text = "";
        this.tTtlgray.Text = "";
        this.tdyedfabdz.Text = "";
        this.tDyedfabkg.Text = "";
        this.tTotalcostdyedfab.Text = "";
        this.tfabdz.Text = "";
        this.tfabttl.Text = "";
        this.tfabinside.Text = "";
        this.tfabout.Text = "";
        this.tembdz.Text = "";
        this.tembttl.Text = "";
        this.tembinside.Text = "";
        this.temboutside.Text = "";
        this.taccdz.Text = "";
        this.taccttl.Text = "";
        this.taccinside.Text = "";
        this.taccoutside.Text = "";
        this.Tfinaltotalcost.Text = "";
        this.tTotalcostdz.Text = "";
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        GridViewRow parent = ((ImageButton)sender).Parent.Parent as GridViewRow;
        DataTable table = (DataTable)this.ViewState["ddata"];
        if (table.Rows.Count > 0)
        {
            table.Rows.RemoveAt(parent.RowIndex);
        }
        this.ViewState["ddata"] = table;
        this.grdcost.DataSource = table;
        this.grdcost.DataBind();
        this.runjQueryCode("Allinone();");
    }

    protected void btndltbtn_Click(object sender, ImageClickEventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        GridViewRow parent = ((ImageButton)sender).Parent.Parent as GridViewRow;
        DataTable table = (DataTable)this.ViewState["btb"];
        if (table.Rows.Count > 0)
        {
            table.Rows.RemoveAt(parent.RowIndex);
        }
        this.ViewState["btb"] = table;
        this.grdBtbstatus.DataSource = table;
        this.grdBtbstatus.DataBind();
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        this.cn.Open();
        SqlTransaction tr = this.cn.BeginTransaction();
        try
        {
            string[] normalparam = new string[] {
                "@StyleID", "@Orderno", "@LCNO", "@OrdQty", "@OrdUnit", "@UnitPrice", "@Yrncostdz", "@Yrnttl", "@YrnInside", "@YrnOut", "@Knitdz", "@Knitttl", "@KnitIN", "@KnitOut", "@DynDz", "@DynTtl",
                "@DynIN", "@DynOut", "@FabDz", "@Fabttl", "@FabIn", "@FabOut", "@EmbDz", "@EmbTtl", "@EmbIn", "@EmbOut", "@AccDz", "@Acc5prcnt", "@Accttl", "@AccIn", "@AccOut", "@Ttlgrayfab",
                "@DyedfabDz", "@Dyedfabkg", "@Dyedfabttlcost", "@Total_Cost", "@Total_Cost_DZ", "@Extrafab", "@ExtraAcc", "@Cm", "@Commbank", "@Cmbankttl", "@Bingcom", "@Bingcomttl", "@Testingchrg", "@Tstingchrgttl", "@Cnf", "@Cnfttl",
                "@Cnf_perdz", "@MstrLC", "@BBYarn", "@BByarnprcnt", "@BBknit", "@BBknitprcnt", "@BBacc", "@BBaccprcnt", "@BBdyIn", "@BBdyinprcnt", "@BBdynOut", "@BBdynoutprcnt", "@BBemb", "@BBembprcnt", "@BBtstingchrg", "@BBtstingchrgprcnt",
                "@BBcnf", "@BBcnfprcnt", "@BBbyncom", "@BBbyncomprcnt", "@bbcombank", "@BBcombankprcnt", "@BBtotalval", "@BBtotalvalprcnt", "@BBMlcInhand", "@BBMLcinhandprcnt", "@Unitprictdz", "@costdz", "@cmdz", "@cmsetusd", "@cmsettk", "@Tk",
                "@Sketch", "@Entby", "@fab_Consumption", "@BBFabric", "@BBFabricprcnt", "@Itemdesc", "@Fabrication", "@Ttl_Inside", "@Ttl_Inside_Prcnt", "@Ttl_Outside", "@Ttl_Outside_Prcnt", "@currencyid", "@OtherChrg", "@Cmdzmanual"
            };
            string[] normalprmval = new string[] {
                this.drpStyle.SelectedValue, this.tOrderno.Text, this.tLCNO.Text, this.txtOrdqty.Text, this.drpOrderunit.SelectedValue, this.tUnitprice.Text, this.tYarncostdz.Text, this.tYarncostttl.Text, this.tYarninside.Text, this.tYarnoutside.Text, this.tknDz.Text, this.tKnttl.Text, this.tknInside.Text, this.tknoutside.Text, this.tdyndz.Text, this.tdynttl.Text,
                this.tdyninside.Text, this.tdynoutside.Text, this.tfabdz.Text, this.tfabttl.Text, this.tfabinside.Text, this.tfabout.Text, this.tembdz.Text, this.tembttl.Text, this.tembinside.Text, this.temboutside.Text, this.taccdz.Text, "0", this.taccttl.Text, this.taccinside.Text, this.taccoutside.Text, this.tTtlgray.Text,
                this.tdyedfabdz.Text, this.tDyedfabkg.Text, this.tTotalcostdyedfab.Text, this.Tfinaltotalcost.Text, this.tTotalcostdz.Text, this.tExfabcost.Text, this.tExacccost.Text, this.tCostofmacking.Text, this.tCommercialbnkamt.Text, this.tCommercialbnkamtttl.Text, this.tBuyercommission.Text, this.tBuyercommissionttl.Text, this.tTestingchargeamt.Text, this.tTestingchargettl.Text, this.tCnfamt.Text, this.tCnfttl.Text,
                this.tCnfperdz.Text, this.tMasterlcval.Text, this.tLcyarn.Text, this.tLcyarnprcnt.Text, this.tLcknit.Text, this.tLcknitprcnt.Text, this.tLCaccessories.Text, this.tLCaccessoriesprcnt.Text, this.tLCdyinginside.Text, this.tLCdyinginsideprcnt.Text, this.tLcdyingoutside.Text, this.tLcdyingoutsideprcnt.Text, this.tLCprintembdry.Text, this.tLCprintembdryprcnt.Text, this.tLctstingcharge.Text, this.tLctstingchargeprcnt.Text,
                this.tLCcnf.Text, this.tLCcnfprcnt.Text, this.tLcbuyercommission.Text, this.tLcbuyercommissionprcnt.Text, this.tLCcommercialbnk.Text, this.tLCcommercialbnkprcnt.Text, this.tbblcttlval.Text, this.tbblcttlvalprcnt.Text, this.tbblcinhand.Text, this.tbblcinhandprcnt.Text, this.tUpriceperdz.Text, this.tcostperdz.Text, this.tcmperdz.Text, this.tcmperset.Text, this.ttkttl.Text, this.ttk.Text,
                this.txtimgslno.Text, this.Session["Uid"].ToString(), this.tFabconsumption.Text, this.tLcFabric.Text, this.tLcFabricprcent.Text, this.tItem.Text, this.tFabrication.Text, this.tTotalinside.Text, this.tTotalinsideprcnt.Text, this.tTotaloutside.Text, this.tTotaloutsideprcnt.Text, this.drpCurrency.SelectedValue, this.txtOtherchngs.Text.Trim(), this.txtCmDzmanual.Text.Trim()
            };
            this._mc.MC_Save_nodt_tr("Sp_Smt_NZ_Cost_Mst_Save", this.cn, tr, normalparam, normalprmval);
            if (this.grdcost.Rows.Count > 0)
            {
                for (int i = 0; i < this.grdcost.Rows.Count; i++)
                {
                    Label label2 = (Label)this.grdcost.Rows[i].FindControl("lblType");
                    Label label3 = (Label)this.grdcost.Rows[i].FindControl("lblitem");
                    Label label4 = (Label)this.grdcost.Rows[i].FindControl("lblGmtqty");
                    Label label5 = (Label)this.grdcost.Rows[i].FindControl("lblConsumption");
                    Label label6 = (Label)this.grdcost.Rows[i].FindControl("lblfabprcnt");
                    Label label7 = (Label)this.grdcost.Rows[i].FindControl("lblReqqty");
                    Label label8 = (Label)this.grdcost.Rows[i].FindControl("lblconsmptunit");
                    Label label9 = (Label)this.grdcost.Rows[i].FindControl("lbluprice");
                    Label label10 = (Label)this.grdcost.Rows[i].FindControl("lblamnt");
                    Label label11 = (Label)this.grdcost.Rows[i].FindControl("lblTotalcost");
                    Label label12 = (Label)this.grdcost.Rows[i].FindControl("lblsupatype");
                    string[] strArray3 = new string[] { "@StyleID", "@MatType", "@MatDesc", "@GmtQty", "@Comnsmption", "@Prcent", "@Reqqty", "@ConsUnit", "@Unitprice", "@Amntdz", "@Costttl", "@SupplierType" };
                    string[] strArray4 = new string[] { this.drpStyle.SelectedValue, label2.Text, label3.Text, label4.Text, label5.Text, label6.Text, label7.Text, label8.Text, label9.Text, label10.Text, label11.Text, label12.Text };
                    this._mc.MC_Save_nodt_tr("Sp_Smt_NZ_Cost_Dtl_Save", this.cn, tr, strArray3, strArray4);
                }
            }
            if (this.grdBtbstatus.Rows.Count > 0)
            {
                for (int j = 0; j < this.grdBtbstatus.Rows.Count; j++)
                {
                    Label label13 = (Label)this.grdBtbstatus.Rows[j].FindControl("lblItm");
                    Label label14 = (Label)this.grdBtbstatus.Rows[j].FindControl("lbltcst");
                    Label label15 = (Label)this.grdBtbstatus.Rows[j].FindControl("lblactcst");
                    Label label16 = (Label)this.grdBtbstatus.Rows[j].FindControl("lblfab");
                    Label label17 = (Label)this.grdBtbstatus.Rows[j].FindControl("lblunfab");
                    Label label18 = (Label)this.grdBtbstatus.Rows[j].FindControl("lbremark");
                    string[] strArray5 = new string[] { "@Styleid", "@Itemd", "@Tcst", "@Actcst", "@Fabcst", "@unfabcst", "@rmrk" };
                    string[] strArray6 = new string[] { this.drpStyle.SelectedValue, label13.Text, label14.Text, label15.Text, label16.Text, label17.Text, label18.Text };
                    this._mc.MC_Save_nodt_tr("Sp_Smt_NZ_Cost_Itm_Save", this.cn, tr, strArray5, strArray6);
                }
            }
            tr.Commit();
            label.Text = "Saved Successfully";
            this.clr();
            this.drpStyle.SelectedIndex = 0;
        }
        catch (Exception exception)
        {
            tr.Rollback();
            label.Text = exception.Message;
        }
        finally
        {
            this.cn.Close();
        }
    }

    public void clr()
    {
        this.tOrderno.Text = "";
        this.tLCNO.Text = "";
        this.txtOrdqty.Text = "";
        this.drpOrderunit.SelectedIndex = 0;
        this.tUnitprice.Text = "";
        this.tYarncostdz.Text = "";
        this.tYarncostttl.Text = "";
        this.tYarninside.Text = "";
        this.tYarnoutside.Text = "";
        this.tknDz.Text = "";
        this.tKnttl.Text = "";
        this.tknInside.Text = "";
        this.tknoutside.Text = "";
        this.tdyndz.Text = "";
        this.tdynttl.Text = "";
        this.tdyninside.Text = "";
        this.tdynoutside.Text = "";
        this.tfabdz.Text = "";
        this.tfabttl.Text = "";
        this.tfabinside.Text = "";
        this.tfabout.Text = "";
        this.tembdz.Text = "";
        this.tembttl.Text = "";
        this.tembinside.Text = "";
        this.temboutside.Text = "";
        this.taccdz.Text = "";
        this.taccttl.Text = "";
        this.taccinside.Text = "";
        this.taccoutside.Text = "";
        this.tTtlgray.Text = "";
        this.tdyedfabdz.Text = "";
        this.tDyedfabkg.Text = "";
        this.tTotalcostdyedfab.Text = "";
        this.Tfinaltotalcost.Text = "";
        this.tTotalcostdz.Text = "";
        this.tExfabcost.Text = "";
        this.tExacccost.Text = "";
        this.tCostofmacking.Text = "";
        this.tCommercialbnkamt.Text = "";
        this.tCommercialbnkamtttl.Text = "";
        this.tBuyercommission.Text = "";
        this.tBuyercommissionttl.Text = "";
        this.tTestingchargeamt.Text = "";
        this.tTestingchargettl.Text = "";
        this.tCnfamt.Text = "";
        this.tCnfttl.Text = "";
        this.tCnfperdz.Text = "";
        this.tMasterlcval.Text = "";
        this.tLcyarn.Text = "";
        this.tLcyarnprcnt.Text = "";
        this.tLcknit.Text = "";
        this.tLcknitprcnt.Text = "";
        this.tLCaccessories.Text = "";
        this.tLCaccessoriesprcnt.Text = "";
        this.tLCdyinginside.Text = "";
        this.tLCdyinginsideprcnt.Text = "";
        this.tLcdyingoutside.Text = "";
        this.tLcdyingoutsideprcnt.Text = "";
        this.tLCprintembdry.Text = "";
        this.tLCprintembdryprcnt.Text = "";
        this.tLctstingcharge.Text = "";
        this.tLctstingchargeprcnt.Text = "";
        this.tLCcnf.Text = "";
        this.tLCcnfprcnt.Text = "";
        this.tLcbuyercommission.Text = "";
        this.tLcbuyercommissionprcnt.Text = "";
        this.tLCcommercialbnk.Text = "";
        this.tLCcommercialbnkprcnt.Text = "";
        this.tbblcttlval.Text = "";
        this.tbblcttlvalprcnt.Text = "";
        this.tbblcinhand.Text = "";
        this.tbblcinhandprcnt.Text = "";
        this.tUpriceperdz.Text = "";
        this.tcostperdz.Text = "";
        this.tcmperdz.Text = "";
        this.tcmperset.Text = "";
        this.ttkttl.Text = "";
        this.ttk.Text = "";
        this.tTotalinside.Text = "";
        this.tTotalinsideprcnt.Text = "";
        this.tTotaloutside.Text = "";
        this.tTotaloutsideprcnt.Text = "";
        this.grdcost.DataSource = null;
        this.grdcost.DataBind();
        this.ViewState["ddata"] = null;
        this.tLcFabric.Text = "";
        this.tLcFabricprcent.Text = "";
        this.tItem.Text = "";
        this.tFabrication.Text = "";
        this.tBuyer.Text = "";
        this.txtimgslno.Text = "";
        this.imgStyle.ImageUrl = null;
        this.grdBtbstatus.DataSource = null;
        this.grdBtbstatus.DataBind();
        this.ViewState["btb"] = null;
        this.txtGmtQty.Text = "";
        this.btncpy.Visible = false;
        this.drpCurrency.SelectedIndex = 0;
    }

    protected void drpStyle_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.clr();
        if (!string.IsNullOrEmpty(this.drpStyle.SelectedValue))
        {
            DataTable table = this._bl.get_InformationdataTable("SELECT distinct Smt_BuyerName.cBuyer_Name  FROM Smt_StyleMaster INNER JOIN  Smt_BuyerName ON Smt_StyleMaster.nAcct = Smt_BuyerName.nBuyer_ID  where Smt_StyleMaster.nStyleID=" + this.drpStyle.SelectedValue);
            if (table.Rows.Count > 0)
            {
                this.tBuyer.Text = table.Rows[0]["cBuyer_Name"].ToString();
            }
            DataTable table2 = this._blinv.get_InformationdataTable("Sp_Smt_NZ_Cost_Itm_getall " + this.drpStyle.SelectedValue);
            if (table2.Rows.Count > 0)
            {
                this.grdBtbstatus.DataSource = table2;
                this.grdBtbstatus.DataBind();
                this.ViewState["btb"] = table2;
            }
            DataTable table3 = this._blinv.get_InformationdataTable("Sp_Smt_NZ_Cost_Mast_getbystyle " + this.drpStyle.SelectedValue);
            if (table3.Rows.Count > 0)
            {
                this.tOrderno.Text = table3.Rows[0]["Orderno"].ToString();
                this.tLCNO.Text = table3.Rows[0]["LCNO"].ToString();
                this.txtOrdqty.Text = table3.Rows[0]["OrdQty"].ToString();
                this.drpOrderunit.SelectedValue = table3.Rows[0]["OrdUnit"].ToString();
                this.tUnitprice.Text = table3.Rows[0]["UnitPrice"].ToString();
                this.tMasterlcval.Text = table3.Rows[0]["MstrLC"].ToString();
                this.drpCurrency.SelectedValue = table3.Rows[0]["currencyid"].ToString();
                this.ttk.Text = table3.Rows[0]["Tk"].ToString();
                this.tItem.Text = table3.Rows[0]["Itemdesc"].ToString();
                this.tFabrication.Text = table3.Rows[0]["Fabrication"].ToString();
                DataTable table4 = this._blinv.get_InformationdataTable("Sp_Smt_NZ_Cost_Dtl_getbystyleid " + this.drpStyle.SelectedValue);
                this.grdcost.DataSource = table4;
                this.grdcost.DataBind();
                this.ViewState["ddata"] = table4;
                this.tExfabcost.Text = table3.Rows[0]["Extrafab"].ToString();
                this.tExacccost.Text = table3.Rows[0]["ExtraAcc"].ToString();
                this.tCostofmacking.Text = table3.Rows[0]["Cm"].ToString();
                this.tCommercialbnkamt.Text = table3.Rows[0]["Commbank"].ToString();
                this.tCommercialbnkamtttl.Text = table3.Rows[0]["Cmbankttl"].ToString();
                this.tBuyercommission.Text = table3.Rows[0]["Bingcom"].ToString();
                this.tBuyercommissionttl.Text = table3.Rows[0]["Bingcomttl"].ToString();
                this.tTestingchargeamt.Text = table3.Rows[0]["Testingchrg"].ToString();
                this.tTestingchargettl.Text = table3.Rows[0]["Tstingchrgttl"].ToString();
                this.tCnfamt.Text = table3.Rows[0]["Cnf"].ToString();
                this.tCnfttl.Text = table3.Rows[0]["Cnfttl"].ToString();
                this.tCnfperdz.Text = table3.Rows[0]["Cnf_perdz"].ToString();
                this.tLctstingcharge.Text = table3.Rows[0]["BBtstingchrg"].ToString();
                this.tLctstingchargeprcnt.Text = table3.Rows[0]["BBtstingchrgprcnt"].ToString();
                this.tLCcnf.Text = table3.Rows[0]["BBcnf"].ToString();
                this.tLCcnfprcnt.Text = table3.Rows[0]["BBcnfprcnt"].ToString();
                this.tLcbuyercommission.Text = table3.Rows[0]["BBbyncom"].ToString();
                this.tLcbuyercommissionprcnt.Text = table3.Rows[0]["BBbyncomprcnt"].ToString();
                this.tLCcommercialbnk.Text = table3.Rows[0]["bbcombank"].ToString();
                this.tLCcommercialbnkprcnt.Text = table3.Rows[0]["BBcombankprcnt"].ToString();
                this.txtimgslno.Text = table3.Rows[0]["Sketch"].ToString();
                this.txtOtherchngs.Text = table3.Rows[0]["OtherChrg"].ToString();
                this.txtCmDzmanual.Text = table3.Rows[0]["Cmdzmanual"].ToString();
                this.imgStyle.ImageUrl = "StyleFile/" + this.txtimgslno.Text;
                this.btncpy.Visible = true;
            }
            this.grdcolqty.DataSource = this._blinv.get_InformationdataTable("Sp_Smt_NZ_Cost_getcolwiseqty " + this.drpStyle.SelectedValue);
            this.grdcolqty.DataBind();
            this.runjQueryCode("Allinone();");
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

    protected void grdcost_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label label = (Label)e.Row.FindControl("lblType");
            Label label2 = (Label)e.Row.FindControl("lblamnt");
            Label label3 = (Label)e.Row.FindControl("lblTotalcost");
            Label label4 = (Label)e.Row.FindControl("lblsupatype");
            if (label.Text == "YARN")
            {
                this.Yrndz += decimal.Parse(label2.Text);
                this.Yrnttl += decimal.Parse(label3.Text);
                if (label4.Text == "Inside")
                {
                    this.YrnInside += decimal.Parse(label3.Text);
                }
                if (label4.Text == "Outside")
                {
                    this.YrnOutside += decimal.Parse(label3.Text);
                }
            }
            if (label.Text == "KNITTING")
            {
                this.Knitdz += decimal.Parse(label2.Text);
                this.Knitttl += decimal.Parse(label3.Text);
                if (label4.Text == "Inside")
                {
                    this.KnitInside += decimal.Parse(label3.Text);
                }
                if (label4.Text == "Outside")
                {
                    this.KnitOutside += decimal.Parse(label3.Text);
                }
            }
            if (label.Text == "DYEING")
            {
                this.dyndz += decimal.Parse(label2.Text);
                this.dynttl += decimal.Parse(label3.Text);
                if (label4.Text == "Inside")
                {
                    this.dynInside += decimal.Parse(label3.Text);
                }
                if (label4.Text == "Outside")
                {
                    this.dynOutside += decimal.Parse(label3.Text);
                }
            }
            if (label.Text == "FABRIC")
            {
                this.fabdz += decimal.Parse(label2.Text);
                this.fabttl += decimal.Parse(label3.Text);
                if (label4.Text == "Inside")
                {
                    this.fabinside += decimal.Parse(label3.Text);
                }
                if (label4.Text == "Outside")
                {
                    this.fabout += decimal.Parse(label3.Text);
                }
            }
            if (label.Text == "PRINT & EMBROIDARY")
            {
                this.embdz += decimal.Parse(label2.Text);
                this.embttl += decimal.Parse(label3.Text);
                if (label4.Text == "Inside")
                {
                    this.embinside += decimal.Parse(label3.Text);
                }
                if (label4.Text == "Outside")
                {
                    this.emboutside += decimal.Parse(label3.Text);
                }
            }
            if (label.Text == "ACCESSORIES")
            {
                this.acrdz += decimal.Parse(label2.Text);
                this.acrttl += decimal.Parse(label3.Text);
                if (label4.Text == "Inside")
                {
                    this.acrinside += decimal.Parse(label3.Text);
                }
                if (label4.Text == "Outside")
                {
                    this.acroutside += decimal.Parse(label3.Text);
                }
            }
        }
        this.tYarncostttl.Text = this.Yrnttl.ToString();
        decimal num = decimal.Parse(this.txtOrdqty.Text.Trim());
        decimal d = (this.Yrnttl / num) * 12M;
        this.tYarncostdz.Text = Math.Round(d, 2).ToString();
        this.tYarninside.Text = this.YrnInside.ToString();
        this.tYarnoutside.Text = this.YrnOutside.ToString();
        this.tKnttl.Text = this.Knitttl.ToString();
        decimal num3 = (this.Knitttl / num) * 12M;
        this.tknDz.Text = Math.Round(num3, 2).ToString();
        this.tknInside.Text = this.KnitInside.ToString();
        this.tknoutside.Text = this.KnitOutside.ToString();
        this.tdynttl.Text = this.dynttl.ToString();
        decimal num4 = (this.dynttl / num) * 12M;
        this.tdyndz.Text = Math.Round(num4, 2).ToString();
        this.tdyninside.Text = this.dynInside.ToString();
        this.tdynoutside.Text = this.dynOutside.ToString();
        this.tfabttl.Text = this.fabttl.ToString();
        decimal num5 = (this.fabttl / num) * 12M;
        this.tfabdz.Text = Math.Round(num5, 2).ToString();
        this.tfabinside.Text = this.fabinside.ToString();
        this.tfabout.Text = this.fabout.ToString();
        this.tembttl.Text = this.embttl.ToString();
        decimal num6 = (this.embttl / num) * 12M;
        this.tembdz.Text = Math.Round(num6, 2).ToString();
        this.tembinside.Text = this.embinside.ToString();
        this.temboutside.Text = this.emboutside.ToString();
        this.taccttl.Text = this.acrttl.ToString();
        decimal num7 = (this.acrttl / num) * 12M;
        this.taccdz.Text = Math.Round(num7, 2).ToString();
        this.taccinside.Text = this.acrinside.ToString();
        this.taccoutside.Text = this.acroutside.ToString();
        this.tTtlgray.Text = (this.Yrnttl + this.Knitttl).ToString();
        this.tdyedfabdz.Text = ((this.Yrndz + this.Knitdz) + this.dyndz).ToString();
        this.tTotalcostdyedfab.Text = (decimal.Parse(this.tTtlgray.Text) + this.dynttl).ToString();
        decimal num8 = (decimal.Parse(this.tTotalcostdyedfab.Text) / num) * 12M;
        this.tdyedfabdz.Text = Math.Round(num8, 2).ToString();
        this.tLcyarn.Text = this.Yrnttl.ToString();
        this.tLcknit.Text = this.Knitttl.ToString();
        this.tLCdyinginside.Text = this.dynInside.ToString();
        this.tLcdyingoutside.Text = this.dynOutside.ToString();
        this.tLCaccessories.Text = this.acrttl.ToString();
        this.tLCprintembdry.Text = this.embttl.ToString();
        this.tLcFabric.Text = this.fabttl.ToString();
        decimal num9 = 0M;
        decimal num10 = 0M;
        decimal num11 = 0M;
        decimal num12 = 0M;
        decimal num13 = 0M;
        decimal num14 = 0M;
        decimal num15 = 0M;
        decimal num16 = 0M;
        if (!string.IsNullOrEmpty(this.tMasterlcval.Text))
        {
            num16 = decimal.Parse(this.tMasterlcval.Text);
            if (this.Yrnttl > 0M)
            {
                num9 = (this.Yrnttl / num16) * 100M;
                this.tLcyarnprcnt.Text = Math.Round(num9, 2).ToString();
            }
            if (this.Knitttl > 0M)
            {
                num10 = (this.Knitttl / num16) * 100M;
                this.tLcknitprcnt.Text = Math.Round(num10, 2).ToString();
            }
            if (this.dynInside > 0M)
            {
                num11 = (this.dynInside / num16) * 100M;
                this.tLCdyinginsideprcnt.Text = Math.Round(num11, 2).ToString();
            }
            if (this.dynOutside > 0M)
            {
                num12 = (this.dynOutside / num16) * 100M;
                this.tLcdyingoutsideprcnt.Text = Math.Round(num12, 2).ToString();
            }
            if (this.acrttl > 0M)
            {
                num13 = (this.acrttl / num16) * 100M;
                this.tLCaccessoriesprcnt.Text = Math.Round(num13, 2).ToString();
            }
            if (this.embttl > 0M)
            {
                num14 = (this.embttl / num16) * 100M;
                this.tLCprintembdryprcnt.Text = Math.Round(num14, 2).ToString();
            }
            if (this.fabttl > 0M)
            {
                num15 = (this.fabttl / num16) * 100M;
                this.tLcFabricprcent.Text = Math.Round(num15, 2).ToString();
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
            if (!base.IsPostBack && !base.IsPostBack)
            {
                this.dlinv.drp_Currencytype(this.drpCurrency);
                this.bindunit();
                this.bindStyleid();
                if (!string.IsNullOrEmpty(base.Request.QueryString["x"]))
                {
                    this.drpStyle.SelectedValue = base.Request.QueryString["x"];
                    this.drpStyle_SelectedIndexChanged(null, null);
                }
            }
            this.txtimgslno.Attributes["value"] = this.txtimgslno.Text;
            this.imgStyle.ImageUrl = "StyleFile/" + this.txtimgslno.Text;
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