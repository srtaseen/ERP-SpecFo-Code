using AjaxControlToolkit;
using ASP;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Inventory_Smt_Inv_ReportAll : System.Web.UI.Page
{
    private BLLInventory _blInventory = new BLLInventory();
    private DALInventory _dlInventory = new DALInventory();
    private BLL _mybll = new BLL();
    //protected Button btnClear;
    //protected Button btnGenerate;
    //protected ImageButton cal1;
    //protected ImageButton cal2;
    //protected DropDownList drpCompany;
    //protected DropDownList drpMainCat;
    //protected DropDownList drpStyle;
    //protected DropDownList drpSubcat;
    //protected RadioButton grCmwisegrn;
    //protected Label Label10;
    //protected Label Label11;
    //protected Label Label6;
    //protected Label Label7;
    //protected Label Label8;
    //protected Label Label9;
    //protected Label lblinfo;
    //protected RadioButton rdDtwiseacrsrecvdtl;
    //protected RadioButton rdFactoryPurchase;
    //protected RadioButton rdGoodissued2d;
    //protected RadioButton rdMainCatwise;
    //protected RadioButton rdMonwisefabreq;
    //protected RadioButton rdReorder;
    //protected RadioButton rdRowmaterial;
    //protected RadioButton rdRowmaterialSupplierWise;
    //protected RadioButton rdStylewise;
    //protected RequiredFieldValidator RQFormdate;
    //protected ValidatorCalloutExtender RQFormdate_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RQMaincat;
    //protected ValidatorCalloutExtender RQMaincat_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RQStyleNo;
    //protected ValidatorCalloutExtender RQStyleNo_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RQTodate;
    //protected ValidatorCalloutExtender RQTodate_ValidatorCalloutExtender;
    //protected TextBox txtFormdate;
    //protected CalendarExtender txtFormdate_CalendarExtender;
    //protected TextBox txtTodate;
    //protected CalendarExtender txtTodate_CalendarExtender;
    //protected UpdatePanel UpdatePanel4;

    public void bindCompany()
    {
        this.drpCompany.DataSource = this._mybll.get_InformationdataTable("select nCompanyID,cCmpName from Smt_Company where cCmpName<>'-' order by cCmpName");
        this.drpCompany.DataTextField = "cCmpName";
        this.drpCompany.DataValueField = "nCompanyID";
        this.drpCompany.DataBind();
        this.drpCompany.Items.Insert(0, new ListItem("ALL", "0"));
        this.drpCompany.SelectedIndex = 0;
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.cal1.Enabled = false;
        this.cal2.Enabled = false;
        this.txtFormdate.Text = "";
        this.txtTodate.Text = "";
        this.drpMainCat.Items.Clear();
        this.drpMainCat.Enabled = false;
        this.drpStyle.Items.Clear();
        this.drpStyle.Enabled = false;
        this.drpSubcat.Items.Clear();
        this.drpSubcat.Enabled = false;
        this.RQFormdate.Enabled = false;
        this.RQMaincat.Enabled = false;
        this.RQStyleNo.Enabled = false;
        this.RQTodate.Enabled = false;
        this.btnGenerate.Enabled = false;
        this.btnGenerate.CssClass = "";
        this.rdFactoryPurchase.Checked = false;
        this.rdMainCatwise.Checked = false;
        this.rdRowmaterial.Checked = false;
        this.rdRowmaterialSupplierWise.Checked = false;
        this.rdStylewise.Checked = false;
        this.drpCompany.Items.Clear();
        this.drpCompany.Enabled = false;
    }

    protected void btnGenerate_Click(object sender, EventArgs e)
    {
        if (this.rdStylewise.Checked)
        {
            this.Session["Param"] = "StyleWise";
            this.Session["stid"] = this.drpStyle.SelectedValue;
            this._dlInventory.ExecReport(int.Parse(this.drpStyle.SelectedValue));
            this.runjQueryCode("window.open('Smt_Inv_ReportDisplay.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
        }
        if (this.rdMainCatwise.Checked)
        {
            this.Session["Param"] = "SB";
            this.Session["MCatID"] = this.drpMainCat.SelectedValue;
            this.Session["SubCatID"] = this.drpSubcat.SelectedValue;
            this.Session["mcat"] = this.drpMainCat.SelectedItem.ToString();
            this.Session["comid"] = this.drpCompany.SelectedValue;
            this.Session["comname"] = this.drpCompany.SelectedItem.ToString();
            this.runjQueryCode("window.open('Smt_Inv_ReportDisplay.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
        }
        if (this.rdRowmaterial.Checked)
        {
            this.Session["FDate"] = this.txtFormdate.Text;
            this.Session["Tdate"] = this.txtTodate.Text;
            this.Session["Param"] = "RM";
            string selectedValue = "0";
            if (!string.IsNullOrEmpty(this.drpMainCat.SelectedValue))
            {
                selectedValue = this.drpMainCat.SelectedValue;
            }
            this.Session["MCatID"] = selectedValue;
            this.runjQueryCode("window.open('Smt_Inv_ReportDisplay.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
        }
        if (this.rdRowmaterialSupplierWise.Checked)
        {
            this.Session["FDate"] = this.txtFormdate.Text;
            this.Session["Tdate"] = this.txtTodate.Text;
            this.Session["Param"] = "RMSup";
            string str2 = "0";
            if (!string.IsNullOrEmpty(this.drpMainCat.SelectedValue))
            {
                str2 = this.drpMainCat.SelectedValue;
            }
            this.Session["MCatID"] = str2;
            this.runjQueryCode("window.open('Smt_Inv_ReportDisplay.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
        }
        if (this.rdFactoryPurchase.Checked)
        {
            this.Session["FDate"] = this.txtFormdate.Text;
            this.Session["Tdate"] = this.txtTodate.Text;
            this.Session["Param"] = "FP";
            this.Session["comnm"] = this.drpCompany.SelectedItem.Text;
            if (this.drpCompany.SelectedValue != "0")
            {
                this.Session["comid"] = this.drpCompany.SelectedValue;
            }
            else
            {
                this.Session["comid"] = "";
            }
            if (this.drpMainCat.SelectedValue != "0")
            {
                this.Session["MCatID"] = this.drpMainCat.SelectedValue;
            }
            else
            {
                this.Session["MCatID"] = "";
            }
            if (this.drpSubcat.SelectedValue != "0")
            {
                this.Session["subcat"] = this.drpSubcat.SelectedValue;
            }
            else
            {
                this.Session["subcat"] = "";
            }
            this.runjQueryCode("window.open('Smt_Inv_ReportDisplay.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
        }
        if (this.rdGoodissued2d.Checked)
        {
            this.Session["FDate"] = this.txtFormdate.Text;
            this.Session["Tdate"] = this.txtTodate.Text;
            this.Session["Param"] = "GoodsIssueD2D";
            this.runjQueryCode("window.open('Smt_Inv_ReportDisplay.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
        }
        if (this.grCmwisegrn.Checked)
        {
            this.Session["FDate"] = this.txtFormdate.Text;
            this.Session["Tdate"] = this.txtTodate.Text;
            this.Session["Param"] = "GRNComwised2d";
            this.runjQueryCode("window.open('Smt_Inv_ReportDisplay.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
        }
        if (this.rdMonwisefabreq.Checked)
        {
            this.Session["FDate"] = this.txtFormdate.Text;
            this.Session["Tdate"] = this.txtTodate.Text;
            this.Session["Param"] = "mnwsefabreq";
            this.svrpt(this.txtFormdate.Text, this.txtTodate.Text, int.Parse(this.drpMainCat.SelectedValue));
            this.runjQueryCode("window.open('Smt_Inv_ReportDisplay.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
        }
        if (this.rdDtwiseacrsrecvdtl.Checked)
        {
            this.Session["FDate"] = this.txtFormdate.Text;
            this.Session["Tdate"] = this.txtTodate.Text;
            this.Session["Param"] = "DTGRNDTL";
            this.runjQueryCode("window.open('Smt_Inv_ReportDisplay.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
        }
        if (this.rdReorder.Checked)
        {
            this.Session["MCatID"] = this.drpMainCat.SelectedValue;
            this.Session["subcat"] = this.drpSubcat.SelectedValue;
            this.Session["mcatdesc"] = this.drpMainCat.SelectedItem.ToString();
            this.Session["Param"] = "ReOrdEr";
            this.runjQueryCode("window.open('Smt_Inv_ReportDisplay.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
        }
    }

    protected void drpMainCat_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.drpSubcat.Items.Clear();
        this.drpSubcat.Enabled = false;
        if (!string.IsNullOrEmpty(this.drpMainCat.SelectedValue))
        {
            this._dlInventory.drp_itemdescriptionbymaincat(this.drpMainCat, this.drpSubcat);
            this.drpSubcat.Items.Insert(0, new ListItem("All", "0"));
            this.drpSubcat.SelectedIndex = 0;
            this.drpSubcat.Enabled = true;
            this.drpCompany.Enabled = true;
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

    protected void grCmwisegrn_CheckedChanged(object sender, EventArgs e)
    {
        this.RQFormdate.Enabled = true;
        this.RQMaincat.Enabled = false;
        this.RQStyleNo.Enabled = false;
        this.RQTodate.Enabled = true;
        this.drpMainCat.Items.Clear();
        this.drpMainCat.Enabled = false;
        this.drpStyle.Items.Clear();
        this.drpStyle.Enabled = false;
        this.drpSubcat.Items.Clear();
        this.drpSubcat.Enabled = false;
        this.cal1.Enabled = true;
        this.cal2.Enabled = true;
        this.btnGenerate.Enabled = true;
        this.btnGenerate.CssClass = "button";
        this.drpCompany.Enabled = false;
        this.drpCompany.Items.Clear();
        this.txtFormdate.Text = "";
        this.txtTodate.Text = "";
        this.lblinfo.Text = this.grCmwisegrn.Text + "</br>Parameter : </br></br>1.From Date.</br>2.To Date.</br></br>-Click Generate Report Button";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!base.IsPostBack)
        {
            this.btnGenerate.Enabled = false;
            this.btnGenerate.CssClass = "";
        }
    }

    protected void rdDtwiseacrsrecvdtl_CheckedChanged(object sender, EventArgs e)
    {
        this.RQFormdate.Enabled = true;
        this.RQMaincat.Enabled = false;
        this.RQStyleNo.Enabled = false;
        this.RQTodate.Enabled = true;
        this.drpMainCat.Items.Clear();
        this.drpMainCat.Enabled = false;
        this.drpStyle.Items.Clear();
        this.drpStyle.Enabled = false;
        this.drpSubcat.Items.Clear();
        this.drpSubcat.Enabled = false;
        this.cal1.Enabled = true;
        this.cal2.Enabled = true;
        this.btnGenerate.Enabled = true;
        this.btnGenerate.CssClass = "button";
        this.drpCompany.Enabled = false;
        this.drpCompany.Items.Clear();
        this.txtFormdate.Text = "";
        this.txtTodate.Text = "";
        this.lblinfo.Text = this.rdDtwiseacrsrecvdtl.Text + "</br>Parameter : </br></br>1.From Date.</br>2.To Date.</br></br>-Click Generate Report Button";
    }

    protected void rdFactoryPurchase_CheckedChanged(object sender, EventArgs e)
    {
        this.cal1.Enabled = true;
        this.txtFormdate.Text = "";
        this.txtTodate.Text = "";
        this.cal2.Enabled = true;
        this.drpMainCat.Enabled = true;
        this.drpSubcat.Items.Clear();
        this.drpSubcat.Enabled = false;
        this.drpStyle.Items.Clear();
        this.drpStyle.Enabled = false;
        this.RQStyleNo.Enabled = false;
        this.drpMainCat.DataSource = this._blInventory.get_Informationdataset("Sp_Smt_GoodReceived_GetFactoryPurchaseMainCat");
        this.drpMainCat.DataTextField = "cMainCategory";
        this.drpMainCat.DataValueField = "nMainCategory_ID";
        this.drpMainCat.DataBind();
        this.drpMainCat.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpMainCat.SelectedIndex = 0;
        this.RQFormdate.Enabled = true;
        this.RQTodate.Enabled = true;
        this.btnGenerate.Enabled = true;
        this.btnGenerate.CssClass = "button";
        this.RQMaincat.Enabled = true;
        this.bindCompany();
        this.lblinfo.Text = this.rdFactoryPurchase.Text + "</br> Parameter : </br></br>1.From Date.</br>2.To Date.</br>3.Company.</br>4.Main Category</br></br>-Click Generate Report Button";
    }

    protected void rdGoodissued2d_CheckedChanged(object sender, EventArgs e)
    {
        this.RQFormdate.Enabled = true;
        this.RQMaincat.Enabled = false;
        this.RQStyleNo.Enabled = false;
        this.RQTodate.Enabled = true;
        this.drpMainCat.Items.Clear();
        this.drpMainCat.Enabled = false;
        this.drpStyle.Items.Clear();
        this.drpStyle.Enabled = false;
        this.drpSubcat.Items.Clear();
        this.drpSubcat.Enabled = false;
        this.cal1.Enabled = true;
        this.cal2.Enabled = true;
        this.btnGenerate.Enabled = true;
        this.btnGenerate.CssClass = "button";
        this.drpCompany.Enabled = false;
        this.drpCompany.Items.Clear();
        this.txtFormdate.Text = "";
        this.txtTodate.Text = "";
        this.lblinfo.Text = this.rdGoodissued2d.Text + "</br> Parameter : </br></br>1.From Date.</br>2.To Date.</br></br></br>-Click Generate Report Button";
    }

    protected void rdMainCatwise_CheckedChanged(object sender, EventArgs e)
    {
        this.txtFormdate.Text = "";
        this.txtTodate.Text = "";
        this.cal1.Enabled = false;
        this.cal2.Enabled = false;
        this.RQFormdate.Enabled = false;
        this.RQTodate.Enabled = false;
        this.RQStyleNo.Enabled = false;
        this.RQMaincat.Enabled = true;
        this.drpStyle.Items.Clear();
        this.drpStyle.Enabled = false;
        this.drpMainCat.Enabled = true;
        this.drpSubcat.Items.Clear();
        this.drpSubcat.Enabled = false;
        this.btnGenerate.Enabled = true;
        this.btnGenerate.CssClass = "button";
        this._dlInventory.drp_Maincategory(this.drpMainCat);
        this.bindCompany();
        this.drpCompany.Enabled = true;
        this.lblinfo.Text = this.rdMainCatwise.Text + "</br>Parameter : </br></br>1.Main Category</br>2.Sub Category.</br>3.Company.</br></br>-Click Generate Report Button";
    }

    protected void rdMonwisefabreq_CheckedChanged(object sender, EventArgs e)
    {
        this.RQFormdate.Enabled = true;
        this.RQMaincat.Enabled = true;
        this.RQStyleNo.Enabled = false;
        this.RQTodate.Enabled = true;
        this.drpMainCat.DataSource = this._blInventory.get_Informationdataset("Sp_Smt_GoodReceived_GetFactoryPurchaseMainCat");
        this.drpMainCat.DataTextField = "cMainCategory";
        this.drpMainCat.DataValueField = "nMainCategory_ID";
        this.drpMainCat.DataBind();
        this.drpMainCat.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpMainCat.SelectedIndex = 0;
        this.drpMainCat.Enabled = true;
        this.drpStyle.Items.Clear();
        this.drpStyle.Enabled = false;
        this.drpSubcat.Items.Clear();
        this.drpSubcat.Enabled = false;
        this.cal1.Enabled = true;
        this.cal2.Enabled = true;
        this.btnGenerate.Enabled = true;
        this.btnGenerate.CssClass = "button";
        this.drpCompany.Enabled = false;
        this.drpCompany.Items.Clear();
        this.txtFormdate.Text = "";
        this.txtTodate.Text = "";
        this.lblinfo.Text = this.rdMonwisefabreq.Text + "</br>Parameter : </br></br>1.From Date.</br>2.To Date.</br></br>-Click Generate Report Button";
    }

    protected void rdReorder_CheckedChanged(object sender, EventArgs e)
    {
        this.RQFormdate.Enabled = false;
        this.RQMaincat.Enabled = true;
        this.RQStyleNo.Enabled = false;
        this.RQTodate.Enabled = false;
        this.drpMainCat.Items.Clear();
        this.drpStyle.Items.Clear();
        this.drpStyle.Enabled = false;
        this.drpSubcat.Items.Clear();
        this.drpSubcat.Enabled = false;
        this.cal1.Enabled = false;
        this.cal2.Enabled = false;
        this.btnGenerate.Enabled = true;
        this.btnGenerate.CssClass = "button";
        this.drpCompany.Enabled = false;
        this.drpCompany.Items.Clear();
        this.txtFormdate.Text = "";
        this.txtTodate.Text = "";
        this._dlInventory.drp_Maincategory(this.drpMainCat);
        this.drpMainCat.Enabled = true;
        this.lblinfo.Text = this.rdReorder.Text + "</br>Parameter : </br></br>1.Main Category.</br>2.Sub Category.</br></br>-Click Generate Report Button";
    }

    protected void rdRowmaterial_CheckedChanged(object sender, EventArgs e)
    {
        this.cal1.Enabled = true;
        this.cal2.Enabled = true;
        this.drpMainCat.Enabled = true;
        this.drpMainCat.DataSource = this._blInventory.get_Informationdataset("Sp_Smt_GoodReceived_GetMerchantPurchaseMainCat");
        this.drpMainCat.DataTextField = "cMainCategory";
        this.drpMainCat.DataValueField = "nMainCategory_ID";
        this.drpMainCat.DataBind();
        this.drpMainCat.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpMainCat.SelectedIndex = 0;
        this.RQFormdate.Enabled = true;
        this.RQTodate.Enabled = true;
        this.RQStyleNo.Enabled = false;
        this.RQMaincat.Enabled = true;
        this.btnGenerate.Enabled = true;
        this.btnGenerate.CssClass = "button";
        this.drpStyle.Items.Clear();
        this.drpStyle.Enabled = false;
        this.drpSubcat.Items.Clear();
        this.drpSubcat.Enabled = false;
        this.drpCompany.Enabled = false;
        this.drpCompany.Items.Clear();
        this.lblinfo.Text = this.rdRowmaterial.Text + "</br>Parameter : </br></br>1.From Date.</br>2.To Date.</br>3.Main Category.</br></br>-Click Generate Report Button";
    }

    protected void rdRowmaterialSupplierWise_CheckedChanged(object sender, EventArgs e)
    {
        this.cal1.Enabled = true;
        this.txtFormdate.Text = "";
        this.txtTodate.Text = "";
        this.cal2.Enabled = true;
        this.drpMainCat.Enabled = true;
        this.drpSubcat.Items.Clear();
        this.drpSubcat.Enabled = false;
        this.drpStyle.Items.Clear();
        this.drpStyle.Enabled = false;
        this.drpMainCat.DataSource = this._blInventory.get_Informationdataset("Sp_Smt_GoodReceived_GetMerchantPurchaseMainCat");
        this.drpMainCat.DataTextField = "cMainCategory";
        this.drpMainCat.DataValueField = "nMainCategory_ID";
        this.drpMainCat.DataBind();
        this.drpMainCat.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpMainCat.SelectedIndex = 0;
        this.RQFormdate.Enabled = true;
        this.RQTodate.Enabled = true;
        this.RQStyleNo.Enabled = false;
        this.btnGenerate.Enabled = true;
        this.btnGenerate.CssClass = "button";
        this.drpCompany.Enabled = false;
        this.drpCompany.Items.Clear();
        this.lblinfo.Text = this.rdRowmaterialSupplierWise.Text + "</br>Parameter : </br></br>1.From Date.</br>2.To Date.</br>3.Main Category.</br></br></br>-Click Generate Report Button";
    }

    protected void rdStylewise_CheckedChanged(object sender, EventArgs e)
    {
        this.drpStyle.DataSource = this._blInventory.get_Informationdataset("Sp_Smt_PODetails_getStyleforInventoryStatus");
        this.drpStyle.DataTextField = "cStyleNo";
        this.drpStyle.DataValueField = "nstyCode";
        this.drpStyle.DataBind();
        this.drpStyle.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpStyle.SelectedIndex = 0;
        this.drpStyle.Enabled = true;
        this.drpMainCat.Items.Clear();
        this.drpMainCat.Enabled = false;
        this.drpSubcat.Items.Clear();
        this.drpSubcat.Enabled = false;
        this.RQMaincat.Enabled = false;
        this.txtFormdate.Text = "";
        this.txtTodate.Text = "";
        this.RQFormdate.Enabled = false;
        this.RQTodate.Enabled = false;
        this.cal1.Enabled = false;
        this.cal2.Enabled = false;
        this.RQStyleNo.Enabled = true;
        this.btnGenerate.Enabled = true;
        this.btnGenerate.CssClass = "button";
        this.drpCompany.Enabled = false;
        this.drpCompany.Items.Clear();
        this.lblinfo.Text = this.rdStylewise.Text + "</br>Parameter : </br></br>1.Style Number.</br></br>-Click Generate Report Button";
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

    public void svrpt(string formdate, string todate, int maincat)
    {
        SqlConnection specFoCon = GetWay.SpecFoCon;
        SqlCommand command = new SqlCommand("Sp_smt_monthwisefab_sv", specFoCon);
        specFoCon.Open();
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@strtdt", formdate);
        command.Parameters.AddWithValue("@enddt", todate);
        command.Parameters.AddWithValue("@maincatid", maincat);
        command.ExecuteNonQuery();
        specFoCon.Close();
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
