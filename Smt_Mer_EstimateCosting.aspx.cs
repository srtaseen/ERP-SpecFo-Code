using AjaxControlToolkit;
using ASP;
using C1.Web.UI.Controls.C1GridView;
using C1.Web.UI.Controls.C1TabControl;
using System;
using System.Data;
using System.Text;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Smt_Mer_EstimateCosting : System.Web.UI.Page
{
    private BLLInventory blinventory = new BLLInventory();
    //protected Button btnClear;
    //protected Button btnClearall;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    //protected C1.Web.UI.Controls.C1TabControl.C1TabControl C1TabControl1;
    //protected C1.Web.UI.Controls.C1TabControl.C1TabControl C1TabControl2;
    //protected C1TabPage C1TabPage1;
    //protected C1TabPage C1TabPage2;
    //protected C1TabPage C1TabPage3;
    //protected C1TabPage C1TabPage4;
    private DALInventory dlinventory = new DALInventory();
    //protected DropDownList drpStyleno;
    //protected C1.Web.UI.Controls.C1GridView.C1GridView grdEstimateCosting;
    //protected GridView grdMastercat;
    //protected Label Label1;
    //protected Label Label15;
    //protected Label Label18;
    //protected Label Label19;
    //protected Label Label2;
    //protected Label Label20;
    //protected Label Label21;
    //protected Label Label22;
    //protected Label Label23;
    //protected Label Label24;
    //protected Label Label25;
    //protected Label Label26;
    //protected Label Label27;
    //protected Label Label28;
    //protected Label Label29;
    //protected Label Label3;
    //protected Label Label30;
    //protected Label Label31;
    //protected Label Label32;
    //protected Label Label33;
    //protected Label Label34;
    //protected Label Label4;
    //protected Label Label5;
    //protected Label Label6;
    //protected Label Label7;
    private BLL mybll = new BLL();
    private DAL mycls = new DAL();
    //protected RequiredFieldValidator RequiredFieldValidator1;
    //protected ValidatorCalloutExtender RequiredFieldValidator1_ValidatorCalloutExtender;
    //protected HtmlTable tblDtl;
    //protected TextBox txtBrand;
    //protected TextBox txtBuyer;
    //protected TextBox txtCheckRow;
    //protected TextBox txtCMDz;
    //protected TextBox txtCMwithProfit;
    //protected TextBox txtcomissionDzn;
    //protected FilteredTextBoxExtender txtcomissionDzn_FilteredTextBoxExtender;
    //protected TextBox txtcomissionpcs;
    //protected FilteredTextBoxExtender txtcomissionpcs_FilteredTextBoxExtender;
    //protected TextBox txtComissionpercntg;
    //protected FilteredTextBoxExtender txtComissionpercntg_FilteredTextBoxExtender;
    //protected TextBox txtComissionttl;
    //protected TextBox txtCostPerminutesDollar;
    //protected FilteredTextBoxExtender txtCostPerminutesDollar_FilteredTextBoxExtender;
    //protected TextBox txtCostPerminutesPrcnt;
    //protected FilteredTextBoxExtender txtCostPerminutesPrcnt_FilteredTextBoxExtender;
    //protected TextBox txtembroidry;
    //protected FilteredTextBoxExtender txtembroidry_FilteredTextBoxExtender;
    //protected TextBox txtFobdzn;
    //protected FilteredTextBoxExtender txtFobdzn_FilteredTextBoxExtender;
    //protected TextBox txtfobpercntg;
    //protected TextBox txtFobperpcs;
    //protected FilteredTextBoxExtender txtFobperpcs_FilteredTextBoxExtender;
    //protected TextBox txtFobttl;
    //protected TextBox txtGarmentDpt;
    //protected TextBox txtGarmenttype;
    //protected TextBox txtGMT;
    //protected TextBox txtGrosscmpercntg;
    //protected FilteredTextBoxExtender txtGrosscmpercntg_FilteredTextBoxExtender;
    //protected TextBox txtGrossdzn;
    //protected FilteredTextBoxExtender txtGrossdzn_FilteredTextBoxExtender;
    //protected TextBox txtgrossperpcs;
    //protected FilteredTextBoxExtender txtgrossperpcs_FilteredTextBoxExtender;
    //protected TextBox txtGrossttl;
    //protected TextBox txtMachinecostperHour;
    //protected FilteredTextBoxExtender txtMachinecostperHour_FilteredTextBoxExtender;
    //protected TextBox txtmanufactCostDz;
    //protected TextBox txtmfgcostpercntg;
    //protected FilteredTextBoxExtender txtmfgcostpercntg_FilteredTextBoxExtender;
    //protected TextBox txtMfgdzn;
    //protected FilteredTextBoxExtender txtMfgdzn_FilteredTextBoxExtender;
    //protected TextBox txtmfgperpcs;
    //protected FilteredTextBoxExtender txtmfgperpcs_FilteredTextBoxExtender;
    //protected TextBox txtMfgttl;
    //protected TextBox txtnoOfmachineReq;
    //protected FilteredTextBoxExtender txtnoOfmachineReq_FilteredTextBoxExtender;
    //protected TextBox txtOrdqtysum;
    //protected TextBox txtOther;
    //protected FilteredTextBoxExtender txtOther_FilteredTextBoxExtender;
    //protected TextBox txtOverheaddzn;
    //protected FilteredTextBoxExtender txtOverheaddzn_FilteredTextBoxExtender;
    //protected TextBox txtOverheadpercntg;
    //protected FilteredTextBoxExtender txtOverheadpercntg_FilteredTextBoxExtender;
    //protected TextBox txtOverheadperpcs;
    //protected FilteredTextBoxExtender txtOverheadperpcs_FilteredTextBoxExtender;
    //protected TextBox txtOverheadttl;
    //protected TextBox txtPlaneffDollar;
    //protected TextBox txtPlaneffPercnt;
    //protected FilteredTextBoxExtender txtPlaneffPercnt_FilteredTextBoxExtender;
    //protected TextBox txtPrinting;
    //protected FilteredTextBoxExtender txtPrinting_FilteredTextBoxExtender;
    //protected TextBox txtPrinttype;
    //protected TextBox txtProdperhour;
    //protected FilteredTextBoxExtender txtProdperhour_FilteredTextBoxExtender;
    //protected TextBox txtProfitDz;
    //protected TextBox txtProfitMargin;
    //protected FilteredTextBoxExtender txtProfitMargin_FilteredTextBoxExtender;
    //protected TextBox txtProfitmargindzn;
    //protected FilteredTextBoxExtender txtProfitmargindzn_FilteredTextBoxExtender;
    //protected TextBox txtProfitmarginpcs;
    //protected FilteredTextBoxExtender txtProfitmarginpcs_FilteredTextBoxExtender;
    //protected TextBox txtProfitmarginpercntg;
    //protected FilteredTextBoxExtender txtProfitmarginpercntg_FilteredTextBoxExtender;
    //protected TextBox txtProfitmarginttl;
    //protected TextBox txtRate;
    //protected FilteredTextBoxExtender txtRate_FilteredTextBoxExtender;
    //protected TextBox txtRawmaterial;
    //protected FilteredTextBoxExtender txtRawmaterial_FilteredTextBoxExtender;
    //protected TextBox txtrowMat;
    //protected TextBox txtSeason;
    //protected TextBox txtSmv;
    //protected FilteredTextBoxExtender txtSmv_FilteredTextBoxExtender;
    //protected TextBox txtStore;
    //protected TextBox txtSubtotalpercntg;
    //protected TextBox txtSubttlDzn;
    //protected TextBox txtSubttlperpcs;
    //protected TextBox txtSubttlTtl;
    //protected TextBox txtTotalCostDzn;
    //protected FilteredTextBoxExtender txtTotalCostDzn_FilteredTextBoxExtender;
    //protected TextBox txtTotalcostpcs;
    //protected FilteredTextBoxExtender txtTotalcostpcs_FilteredTextBoxExtender;
    //protected TextBox txtTotalcostpercntg;
    //protected FilteredTextBoxExtender txtTotalcostpercntg_FilteredTextBoxExtender;
    //protected TextBox txtTotalcostttl;
    //protected TextBox txtWashing;
    //protected FilteredTextBoxExtender txtWashing_FilteredTextBoxExtender;
    //protected TextBox txtWashtype;
    //protected UpdatePanel UpdatePanel1;
    //protected UpdatePanel UpdatePanel2;
    //protected UpdatePanel UpdatePanel3;

    public void bindgrid()
    {
        this.grdEstimateCosting.DataSource = this.blinventory.get_InformationdataTable("Sp_Smt_EstimateCosting_getAll");
        this.grdEstimateCosting.DataBind();
    }

    public void bindStyleid()
    {
        DataTable table = this.mybll.get_InformationdataTable("Sp_Smt_GetStyleID '" + this.Session["Uid"].ToString() + "','EB'");
        this.drpStyleno.Items.Add(new ListItem("", ""));
        this.drpStyleno.DataSource = table;
        this.drpStyleno.DataTextField = "StyleNO";
        this.drpStyleno.DataValueField = "StyleID";
        this.drpStyleno.DataBind();
        this.drpStyleno.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpStyleno.SelectedIndex = 0;
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.ClearAllcontrol(this);
        this.grdMastercat.DataSource = null;
        this.grdMastercat.DataBind();
        this.drpStyleno.SelectedIndex = 0;
    }

    protected void btnClearall_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.ClearAllcontrol(this);
        this.grdMastercat.DataSource = null;
        this.grdMastercat.DataBind();
        this.drpStyleno.SelectedValue = "";
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        Label lbl = (Label)base.Master.FindControl("lbltotalinfo");
        lbl.Text = "";
        if (this.grdMastercat.Rows.Count > 0)
        {
            this.dlinventory.Delete_EstimateCosting_MCat(int.Parse(this.drpStyleno.SelectedValue));
            for (int i = 0; i < this.grdMastercat.Rows.Count; i++)
            {
                CheckBox box = (CheckBox)this.grdMastercat.Rows[i].FindControl("chkSelect");
                Label label2 = (Label)this.grdMastercat.Rows[i].FindControl("lblid");
                Label label3 = (Label)this.grdMastercat.Rows[i].FindControl("lblVal");
                if (box.Checked)
                {
                    this.dlinventory.Save_EstimatecostingItm(int.Parse(label2.Text.Trim()), label3.Text.Trim(), int.Parse(this.drpStyleno.SelectedValue));
                }
            }
        }
        this.dlinventory.Save_EstimateCosting(int.Parse(this.drpStyleno.SelectedValue), this.txtrowMat.Text.Trim(), this.txtembroidry.Text.Trim(), this.txtPrinting.Text.Trim(), this.txtWashing.Text.Trim(), this.txtOther.Text.Trim(), "0.00", this.txtPrinttype.Text.Trim(), this.txtWashtype.Text.Trim(), this.txtGMT.Text.Trim(), this.txtSubtotalpercntg.Text.Trim(), this.txtSubttlperpcs.Text.Trim(), this.txtSubttlDzn.Text.Trim(), this.txtSubttlTtl.Text.Trim(), this.txtfobpercntg.Text.Trim(), this.txtFobperpcs.Text.Trim(), this.txtFobdzn.Text.Trim(), this.txtFobttl.Text.Trim(), this.txtmfgcostpercntg.Text.Trim(), this.txtmfgperpcs.Text.Trim(), this.txtMfgdzn.Text.Trim(), this.txtMfgttl.Text.Trim(), this.txtOverheadpercntg.Text.Trim(), this.txtOverheadperpcs.Text.Trim(), this.txtOverheaddzn.Text.Trim(), this.txtOverheadttl.Text.Trim(), this.txtComissionpercntg.Text.Trim(), this.txtcomissionpcs.Text.Trim(), this.txtcomissionDzn.Text.Trim(), this.txtComissionttl.Text.Trim(), this.txtProfitmarginpercntg.Text.Trim(), this.txtProfitmarginpcs.Text.Trim(), this.txtProfitmargindzn.Text.Trim(), this.txtProfitmarginttl.Text.Trim(), this.Session["Uid"].ToString(), this.txtTotalcostpercntg.Text.Trim(), this.txtTotalcostpcs.Text.Trim(), this.txtTotalCostDzn.Text.Trim(), this.txtTotalcostttl.Text.Trim(), this.txtRawmaterial.Text.Trim(), lbl);
        this.ClearAllcontrol(this);
        this.grdMastercat.DataSource = null;
        this.grdMastercat.DataBind();
        this.drpStyleno.SelectedValue = "";
        this.bindgrid();
    }

    public void clearAll()
    {
        this.txtCMDz.Text = "";
        this.txtCMwithProfit.Text = "";
        this.txtcomissionDzn.Text = "";
        this.txtcomissionpcs.Text = "";
        this.txtComissionpercntg.Text = "";
        this.txtComissionttl.Text = "";
        this.txtCostPerminutesDollar.Text = "";
        this.txtCostPerminutesPrcnt.Text = "";
        this.txtembroidry.Text = "";
        this.txtFobdzn.Text = "";
        this.txtfobpercntg.Text = "";
        this.txtFobperpcs.Text = "";
        this.txtFobttl.Text = "";
        this.txtGarmentDpt.Text = "";
        this.txtGarmenttype.Text = "";
        this.txtGMT.Text = "";
        this.txtGrosscmpercntg.Text = "";
        this.txtGrossdzn.Text = "";
        this.txtgrossperpcs.Text = "";
        this.txtGrossttl.Text = "";
        this.txtMachinecostperHour.Text = "";
        this.txtmanufactCostDz.Text = "";
        this.txtmfgcostpercntg.Text = "";
        this.txtMfgdzn.Text = "";
        this.txtmfgperpcs.Text = "";
        this.txtMfgttl.Text = "";
        this.txtnoOfmachineReq.Text = "";
        this.txtOther.Text = "";
        this.txtOverheaddzn.Text = "";
        this.txtOverheadpercntg.Text = "";
        this.txtOverheadperpcs.Text = "";
        this.txtOverheadttl.Text = "";
        this.txtPlaneffDollar.Text = "";
        this.txtPlaneffPercnt.Text = "";
        this.txtPrinting.Text = "";
        this.txtPrinttype.Text = "";
        this.txtProdperhour.Text = "";
        this.txtProfitDz.Text = "";
        this.txtProfitMargin.Text = "";
        this.txtProfitmargindzn.Text = "";
        this.txtProfitmarginpcs.Text = "";
        this.txtProfitmarginpercntg.Text = "";
        this.txtProfitmarginttl.Text = "";
        this.txtRate.Text = "";
        this.txtRawmaterial.Text = "";
        this.txtSmv.Text = "";
        this.txtSubtotalpercntg.Text = "";
        this.txtSubttlDzn.Text = "";
        this.txtSubttlperpcs.Text = "";
        this.txtSubttlTtl.Text = "";
        this.txtTotalCostDzn.Text = "";
        this.txtTotalcostpcs.Text = "";
        this.txtTotalcostpercntg.Text = "";
        this.txtTotalcostttl.Text = "";
        this.txtWashing.Text = "";
        this.txtWashtype.Text = "";
    }

    public void ClearAllcontrol(Control parent)
    {
        foreach (Control control in parent.Controls)
        {
            if (control.Controls.Count > 0)
            {
                this.ClearAllcontrol(control);
            }
            else if (control is TextBox)
            {
                ((TextBox)control).Text = "";
            }
        }
    }

    public void DrpSelectValue()
    {
        this.ViewState["Ro"] = null;
        this.txtRawmaterial.Text = "";
        this.txtWashing.Text = "";
        this.txtPrinting.Text = "";
        this.txtembroidry.Text = "";
        this.txtSubttlperpcs.Text = "";
        this.txtSubttlDzn.Text = "";
        this.txtSubttlTtl.Text = "";
        this.ClearAllcontrol(this.Page);
        int num = 0;
        if (!string.IsNullOrEmpty(this.drpStyleno.SelectedValue))
        {
            string sqlstatement = "select cSeason_Name,cBuyer_Name,cBrand_Name,cStore_Name,cGmt_Dept_Description,cGmetDis from Smt_View_Stylemaster where nStyleID=" + this.drpStyleno.SelectedValue;
            DataSet set = this.mybll.get_Informationdataset(sqlstatement);
            this.txtBrand.Text = set.Tables[0].Rows[0]["cBrand_Name"].ToString();
            this.txtBuyer.Text = set.Tables[0].Rows[0]["cBuyer_Name"].ToString();
            this.txtGarmentDpt.Text = set.Tables[0].Rows[0]["cGmt_Dept_Description"].ToString();
            this.txtGarmenttype.Text = set.Tables[0].Rows[0]["cGmetDis"].ToString();
            this.txtSeason.Text = set.Tables[0].Rows[0]["cSeason_Name"].ToString();
            this.txtStore.Text = set.Tables[0].Rows[0]["cStore_Name"].ToString();
            DataSet set2 = this.mybll.get_Informationdataset("Sp_Smt_EstimateCosting_GetsumOrdQty " + this.drpStyleno.SelectedValue);
            this.txtOrdqtysum.Text = set2.Tables[0].Rows[0]["nOrdQty"].ToString();
            DataSet set3 = this.blinventory.get_Informationdataset("Sp_Smt_EstimateCosting_getMasterCategory " + this.drpStyleno.SelectedValue);
            this.grdMastercat.DataSource = set3;
            this.grdMastercat.DataBind();
            DataTable table = this.blinventory.get_InformationdataTable("Sp_Smt_EstimateCosting_GetByStyleID '" + this.drpStyleno.SelectedValue + "'");
            if (table.Rows.Count > 0)
            {
                this.txtrowMat.Text = table.Rows[0]["Row_Material"].ToString();
                this.txtembroidry.Text = table.Rows[0]["Embroidary"].ToString();
                this.txtPrinting.Text = table.Rows[0]["Printing"].ToString();
                this.txtWashing.Text = table.Rows[0]["Washing"].ToString();
                this.txtOther.Text = table.Rows[0]["Other"].ToString();
                this.txtRate.Text = table.Rows[0]["Rate"].ToString();
                this.txtPrinttype.Text = table.Rows[0]["Print_Type"].ToString();
                this.txtWashtype.Text = table.Rows[0]["Wash_Type"].ToString();
                this.txtGMT.Text = table.Rows[0]["Stitch"].ToString();
                this.txtSubtotalpercntg.Text = table.Rows[0]["Subttl_Percent"].ToString();
                this.txtSubttlperpcs.Text = table.Rows[0]["Subttl_Pc"].ToString();
                this.txtSubttlDzn.Text = table.Rows[0]["Subttl_Dz"].ToString();
                this.txtSubttlTtl.Text = table.Rows[0]["Subttl_Ttl"].ToString();
                this.txtfobpercntg.Text = table.Rows[0]["Fob_Percent"].ToString();
                this.txtFobperpcs.Text = table.Rows[0]["Fob_Pc"].ToString();
                this.txtFobdzn.Text = table.Rows[0]["Fob_Dz"].ToString();
                this.txtFobttl.Text = table.Rows[0]["Fob_Ttl"].ToString();
                this.txtmfgcostpercntg.Text = table.Rows[0]["Manuf_Percent"].ToString();
                this.txtmfgperpcs.Text = table.Rows[0]["Manuf_Pc"].ToString();
                this.txtMfgdzn.Text = table.Rows[0]["Manuf_Dz"].ToString();
                this.txtMfgttl.Text = table.Rows[0]["Manuf_Ttl"].ToString();
                this.txtOverheadpercntg.Text = table.Rows[0]["Overhead_Percent"].ToString();
                this.txtOverheadperpcs.Text = table.Rows[0]["Overhead_Pc"].ToString();
                this.txtOverheaddzn.Text = table.Rows[0]["Overhead_Dz"].ToString();
                this.txtOverheadttl.Text = table.Rows[0]["Overhead_Ttl"].ToString();
                this.txtComissionpercntg.Text = table.Rows[0]["Comission_Percent"].ToString();
                this.txtcomissionpcs.Text = table.Rows[0]["Comission_Pc"].ToString();
                this.txtcomissionDzn.Text = table.Rows[0]["Comission_Dz"].ToString();
                this.txtComissionttl.Text = table.Rows[0]["Comission_Ttl"].ToString();
                this.txtProfitmarginpercntg.Text = table.Rows[0]["ProfitMargin_Percent"].ToString();
                this.txtProfitmarginpcs.Text = table.Rows[0]["ProfitMargin_Pc"].ToString();
                this.txtProfitmargindzn.Text = table.Rows[0]["ProfitMargin_Dz"].ToString();
                this.txtProfitmarginttl.Text = table.Rows[0]["ProfitMargin_Ttl"].ToString();
                this.txtTotalcostpercntg.Text = table.Rows[0]["TotalCost_Percent"].ToString();
                this.txtTotalcostpcs.Text = table.Rows[0]["TotalCost_Pc"].ToString();
                this.txtTotalCostDzn.Text = table.Rows[0]["TotalCost_Dz"].ToString();
                this.txtTotalcostttl.Text = table.Rows[0]["TotalCost_Ttl"].ToString();
                this.txtRawmaterial.Text = table.Rows[0]["RowMaterialDz"].ToString();
                DataTable table2 = this.blinventory.get_InformationdataTable("select nMasterCategory_ID from Smt_EstimateCosting_MCat where nStyleID=" + this.drpStyleno.SelectedValue);
                if (table2.Rows.Count > 0)
                {
                    foreach (DataRow row in table2.Rows)
                    {
                        foreach (GridViewRow row2 in this.grdMastercat.Rows)
                        {
                            Label label = (Label)row2.FindControl("lblid");
                            if (label.Text.Trim() == row[0].ToString())
                            {
                                CheckBox box = (CheckBox)row2.FindControl("chkSelect");
                                box.Checked = true;
                                num++;
                            }
                        }
                    }
                }
            }
            else
            {
                if (set3.Tables[0].Rows.Count > 0)
                {
                    foreach (GridViewRow row3 in this.grdMastercat.Rows)
                    {
                        Label label1 = (Label)row3.FindControl("lblid");
                        Label label2 = (Label)row3.FindControl("lblVal");
                        CheckBox box2 = (CheckBox)row3.FindControl("chkSelect");
                        box2.Checked = true;
                        num++;
                        decimal num2 = 0M;
                        if (!string.IsNullOrEmpty(this.txtrowMat.Text.Trim()))
                        {
                            num2 = decimal.Parse(this.txtrowMat.Text);
                        }
                        if (!string.IsNullOrEmpty(label2.Text.Trim()))
                        {
                            this.txtrowMat.Text = (num2 + decimal.Parse(label2.Text.Trim())).ToString();
                        }
                    }
                }
                if (!string.IsNullOrEmpty(this.txtrowMat.Text))
                {
                    decimal d = (decimal.Parse(this.txtrowMat.Text) / decimal.Parse(this.txtOrdqtysum.Text)) * 12M;
                    this.txtRawmaterial.Text = Math.Round(d, 4).ToString();
                    if (!string.IsNullOrEmpty(this.txtRawmaterial.Text))
                    {
                        this.txtSubttlDzn.Text = decimal.Parse(this.txtRawmaterial.Text).ToString();
                        string s = (decimal.Parse(this.txtSubttlDzn.Text) / 12M).ToString();
                        this.txtSubttlperpcs.Text = Math.Round(decimal.Parse(s), 4).ToString();
                        string str3 = (decimal.Parse(this.txtSubttlperpcs.Text) * decimal.Parse(this.txtOrdqtysum.Text)).ToString();
                        this.txtSubttlTtl.Text = Math.Round(decimal.Parse(str3), 4).ToString();
                    }
                }
                DataTable table3 = this.blinventory.get_InformationdataTable("select Fobpc,FobDz,TotalFob,Manfcst from Smt_EstimateCosting_Quick where StyleNo='" + this.drpStyleno.SelectedItem.Text + "'");
                if (table3.Rows.Count > 0)
                {
                    this.txtFobperpcs.Text = table3.Rows[0]["Fobpc"].ToString();
                    this.txtFobdzn.Text = table3.Rows[0]["FobDz"].ToString();
                    this.txtFobttl.Text = table3.Rows[0]["TotalFob"].ToString();
                    this.txtMfgttl.Text = table3.Rows[0]["Manfcst"].ToString();
                    if (decimal.Parse(this.txtFobttl.Text) > 0M)
                    {
                        this.txtmfgcostpercntg.Text = Math.Round((decimal)((decimal.Parse(this.txtMfgttl.Text) / decimal.Parse(this.txtFobttl.Text)) * 100M), 4).ToString();
                        this.txtmfgperpcs.Text = Math.Round((decimal)(decimal.Parse(this.txtMfgttl.Text) / decimal.Parse(this.txtOrdqtysum.Text)), 4).ToString();
                        this.txtMfgdzn.Text = Math.Round((decimal)(decimal.Parse(this.txtmfgperpcs.Text) * 12M), 4).ToString();
                    }
                }
            }
        }
        else
        {
            this.txtGarmenttype.Text = "";
            this.txtOrdqtysum.Text = "";
            this.txtSeason.Text = "";
            this.txtStore.Text = "";
            this.txtBrand.Text = "";
            this.txtBuyer.Text = "";
            this.grdMastercat.DataSource = null;
            this.grdMastercat.DataBind();
        }
        this.txtfobpercntg.Text = "100";
        this.txtCheckRow.Text = num.ToString();
    }

    protected void drpStyleno_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.ClearAllcontrol(this);
        this.grdMastercat.DataSource = null;
        this.grdMastercat.DataBind();
        if (!string.IsNullOrEmpty(this.drpStyleno.SelectedValue))
        {
            this.DrpSelectValue();
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

    protected void grdEstimateCosting_PageIndexChanging(object sender, C1GridViewPageEventArgs e)
    {
        this.grdEstimateCosting.PageIndex = e.NewPageIndex;
        this.bindgrid();
    }

    protected void grdEstimateCosting_RowCommand(object sender, C1GridViewCommandEventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        if (e.CommandName == "Select")
        {
            int num = int.Parse(e.CommandArgument.ToString());
            Label label2 = (Label)this.grdEstimateCosting.Rows[num].FindControl("lblStyleid");
            this.drpStyleno.SelectedValue = label2.Text.Trim();
            this.DrpSelectValue();
            this.C1TabControl1.MoveFirst();
        }
    }

    protected void grdMastercat_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            CheckBox box = (CheckBox)e.Row.FindControl("chkSelect");
            Label label = (Label)e.Row.FindControl("lblVal");
            box.Attributes.Add("onclick", "javascript:MasterCatselect('" + box.ClientID + "','" + label.ClientID + "','" + this.txtRawmaterial.ClientID + "','" + this.txtembroidry.ClientID + "','" + this.txtPrinting.ClientID + "','" + this.txtWashing.ClientID + "','" + this.txtOther.ClientID + "','" + this.txtSubttlperpcs.ClientID + "','" + this.txtSubttlDzn.ClientID + "','" + this.txtSubttlTtl.ClientID + "','" + this.txtOrdqtysum.ClientID + "','" + this.txtSubtotalpercntg.ClientID + "','" + this.txtmfgcostpercntg.ClientID + "','" + this.txtOverheadpercntg.ClientID + "','" + this.txtComissionpercntg.ClientID + "','" + this.txtTotalcostpercntg.ClientID + "','" + this.txtmfgperpcs.ClientID + "','" + this.txtOverheadperpcs.ClientID + "','" + this.txtcomissionpcs.ClientID + "','" + this.txtTotalcostpcs.ClientID + "','" + this.txtSubttlDzn.ClientID + "','" + this.txtMfgdzn.ClientID + "','" + this.txtOverheaddzn.ClientID + "','" + this.txtcomissionDzn.ClientID + "','" + this.txtTotalCostDzn.ClientID + "','" + this.txtSubttlTtl.ClientID + "','" + this.txtMfgttl.ClientID + "','" + this.txtOverheadttl.ClientID + "','" + this.txtComissionttl.ClientID + "','" + this.txtTotalcostttl.ClientID + "','" + this.txtfobpercntg.ClientID + "','" + this.txtProfitmarginpercntg.ClientID + "','" + this.txtFobperpcs.ClientID + "','" + this.txtProfitmarginpcs.ClientID + "','" + this.txtFobdzn.ClientID + "','" + this.txtProfitmargindzn.ClientID + "','" + this.txtFobttl.ClientID + "','" + this.txtProfitmarginttl.ClientID + "','" + this.txtrowMat.ClientID + "')");
        }
    }

    protected void lbkrpt_Click(object sender, EventArgs e)
    {
        C1GridViewRow parent = ((LinkButton)sender).Parent.Parent as C1GridViewRow;
        LinkButton button = (LinkButton)parent.FindControl("lbkrpt");
        this.Session["stid"] = button.CommandArgument;
        this.Session["Param"] = "eCost";
        this.runjQueryCode("window.open('Report_Merchandising/Smt_MerchandisingReport.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.Session["Uid"] == null)
        {
            base.Response.Redirect("Smt_Login.aspx", false);
        }
        else
        {
            Label label1 = (Label)base.Master.FindControl("lbltotalinfo");
            if (!base.IsPostBack)
            {
                this.bindStyleid();
                this.bindgrid();
            }
            this.txtWashing.Attributes.Add("onkeyup", "javascript:Rowmaterial ('" + this.txtRawmaterial.ClientID + "','" + this.txtembroidry.ClientID + "','" + this.txtPrinting.ClientID + "','" + this.txtWashing.ClientID + "','" + this.txtOther.ClientID + "','" + this.txtSubttlperpcs.ClientID + "','" + this.txtSubttlDzn.ClientID + "','" + this.txtSubttlTtl.ClientID + "','" + this.txtOrdqtysum.ClientID + "','" + this.txtSubtotalpercntg.ClientID + "','" + this.txtmfgcostpercntg.ClientID + "','" + this.txtOverheadpercntg.ClientID + "','" + this.txtComissionpercntg.ClientID + "','" + this.txtTotalcostpercntg.ClientID + "','" + this.txtmfgperpcs.ClientID + "','" + this.txtOverheadperpcs.ClientID + "','" + this.txtcomissionpcs.ClientID + "','" + this.txtTotalcostpcs.ClientID + "','" + this.txtSubttlDzn.ClientID + "','" + this.txtMfgdzn.ClientID + "','" + this.txtOverheaddzn.ClientID + "','" + this.txtcomissionDzn.ClientID + "','" + this.txtTotalCostDzn.ClientID + "','" + this.txtSubttlTtl.ClientID + "','" + this.txtMfgttl.ClientID + "','" + this.txtOverheadttl.ClientID + "','" + this.txtComissionttl.ClientID + "','" + this.txtTotalcostttl.ClientID + "','" + this.txtfobpercntg.ClientID + "','" + this.txtProfitmarginpercntg.ClientID + "','" + this.txtFobperpcs.ClientID + "','" + this.txtProfitmarginpcs.ClientID + "','" + this.txtFobdzn.ClientID + "','" + this.txtProfitmargindzn.ClientID + "','" + this.txtFobttl.ClientID + "','" + this.txtProfitmarginttl.ClientID + "')");
            this.txtRawmaterial.Attributes.Add("onkeyup", "javascript:Rowmaterial ('" + this.txtRawmaterial.ClientID + "','" + this.txtembroidry.ClientID + "','" + this.txtPrinting.ClientID + "','" + this.txtWashing.ClientID + "','" + this.txtOther.ClientID + "','" + this.txtSubttlperpcs.ClientID + "','" + this.txtSubttlDzn.ClientID + "','" + this.txtSubttlTtl.ClientID + "','" + this.txtOrdqtysum.ClientID + "','" + this.txtSubtotalpercntg.ClientID + "','" + this.txtmfgcostpercntg.ClientID + "','" + this.txtOverheadpercntg.ClientID + "','" + this.txtComissionpercntg.ClientID + "','" + this.txtTotalcostpercntg.ClientID + "','" + this.txtmfgperpcs.ClientID + "','" + this.txtOverheadperpcs.ClientID + "','" + this.txtcomissionpcs.ClientID + "','" + this.txtTotalcostpcs.ClientID + "','" + this.txtSubttlDzn.ClientID + "','" + this.txtMfgdzn.ClientID + "','" + this.txtOverheaddzn.ClientID + "','" + this.txtcomissionDzn.ClientID + "','" + this.txtTotalCostDzn.ClientID + "','" + this.txtSubttlTtl.ClientID + "','" + this.txtMfgttl.ClientID + "','" + this.txtOverheadttl.ClientID + "','" + this.txtComissionttl.ClientID + "','" + this.txtTotalcostttl.ClientID + "','" + this.txtfobpercntg.ClientID + "','" + this.txtProfitmarginpercntg.ClientID + "','" + this.txtFobperpcs.ClientID + "','" + this.txtProfitmarginpcs.ClientID + "','" + this.txtFobdzn.ClientID + "','" + this.txtProfitmargindzn.ClientID + "','" + this.txtFobttl.ClientID + "','" + this.txtProfitmarginttl.ClientID + "')");
            this.txtPrinting.Attributes.Add("onkeyup", "javascript:Rowmaterial ('" + this.txtRawmaterial.ClientID + "','" + this.txtembroidry.ClientID + "','" + this.txtPrinting.ClientID + "','" + this.txtWashing.ClientID + "','" + this.txtOther.ClientID + "','" + this.txtSubttlperpcs.ClientID + "','" + this.txtSubttlDzn.ClientID + "','" + this.txtSubttlTtl.ClientID + "','" + this.txtOrdqtysum.ClientID + "','" + this.txtSubtotalpercntg.ClientID + "','" + this.txtmfgcostpercntg.ClientID + "','" + this.txtOverheadpercntg.ClientID + "','" + this.txtComissionpercntg.ClientID + "','" + this.txtTotalcostpercntg.ClientID + "','" + this.txtmfgperpcs.ClientID + "','" + this.txtOverheadperpcs.ClientID + "','" + this.txtcomissionpcs.ClientID + "','" + this.txtTotalcostpcs.ClientID + "','" + this.txtSubttlDzn.ClientID + "','" + this.txtMfgdzn.ClientID + "','" + this.txtOverheaddzn.ClientID + "','" + this.txtcomissionDzn.ClientID + "','" + this.txtTotalCostDzn.ClientID + "','" + this.txtSubttlTtl.ClientID + "','" + this.txtMfgttl.ClientID + "','" + this.txtOverheadttl.ClientID + "','" + this.txtComissionttl.ClientID + "','" + this.txtTotalcostttl.ClientID + "','" + this.txtfobpercntg.ClientID + "','" + this.txtProfitmarginpercntg.ClientID + "','" + this.txtFobperpcs.ClientID + "','" + this.txtProfitmarginpcs.ClientID + "','" + this.txtFobdzn.ClientID + "','" + this.txtProfitmargindzn.ClientID + "','" + this.txtFobttl.ClientID + "','" + this.txtProfitmarginttl.ClientID + "')");
            this.txtembroidry.Attributes.Add("onkeyup", "javascript:Rowmaterial ('" + this.txtRawmaterial.ClientID + "','" + this.txtembroidry.ClientID + "','" + this.txtPrinting.ClientID + "','" + this.txtWashing.ClientID + "','" + this.txtOther.ClientID + "','" + this.txtSubttlperpcs.ClientID + "','" + this.txtSubttlDzn.ClientID + "','" + this.txtSubttlTtl.ClientID + "','" + this.txtOrdqtysum.ClientID + "','" + this.txtSubtotalpercntg.ClientID + "','" + this.txtmfgcostpercntg.ClientID + "','" + this.txtOverheadpercntg.ClientID + "','" + this.txtComissionpercntg.ClientID + "','" + this.txtTotalcostpercntg.ClientID + "','" + this.txtmfgperpcs.ClientID + "','" + this.txtOverheadperpcs.ClientID + "','" + this.txtcomissionpcs.ClientID + "','" + this.txtTotalcostpcs.ClientID + "','" + this.txtSubttlDzn.ClientID + "','" + this.txtMfgdzn.ClientID + "','" + this.txtOverheaddzn.ClientID + "','" + this.txtcomissionDzn.ClientID + "','" + this.txtTotalCostDzn.ClientID + "','" + this.txtSubttlTtl.ClientID + "','" + this.txtMfgttl.ClientID + "','" + this.txtOverheadttl.ClientID + "','" + this.txtComissionttl.ClientID + "','" + this.txtTotalcostttl.ClientID + "','" + this.txtfobpercntg.ClientID + "','" + this.txtProfitmarginpercntg.ClientID + "','" + this.txtFobperpcs.ClientID + "','" + this.txtProfitmarginpcs.ClientID + "','" + this.txtFobdzn.ClientID + "','" + this.txtProfitmargindzn.ClientID + "','" + this.txtFobttl.ClientID + "','" + this.txtProfitmarginttl.ClientID + "')");
            this.txtOther.Attributes.Add("onkeyup", "javascript:Rowmaterial ('" + this.txtRawmaterial.ClientID + "','" + this.txtembroidry.ClientID + "','" + this.txtPrinting.ClientID + "','" + this.txtWashing.ClientID + "','" + this.txtOther.ClientID + "','" + this.txtSubttlperpcs.ClientID + "','" + this.txtSubttlDzn.ClientID + "','" + this.txtSubttlTtl.ClientID + "','" + this.txtOrdqtysum.ClientID + "','" + this.txtSubtotalpercntg.ClientID + "','" + this.txtmfgcostpercntg.ClientID + "','" + this.txtOverheadpercntg.ClientID + "','" + this.txtComissionpercntg.ClientID + "','" + this.txtTotalcostpercntg.ClientID + "','" + this.txtmfgperpcs.ClientID + "','" + this.txtOverheadperpcs.ClientID + "','" + this.txtcomissionpcs.ClientID + "','" + this.txtTotalcostpcs.ClientID + "','" + this.txtSubttlDzn.ClientID + "','" + this.txtMfgdzn.ClientID + "','" + this.txtOverheaddzn.ClientID + "','" + this.txtcomissionDzn.ClientID + "','" + this.txtTotalCostDzn.ClientID + "','" + this.txtSubttlTtl.ClientID + "','" + this.txtMfgttl.ClientID + "','" + this.txtOverheadttl.ClientID + "','" + this.txtComissionttl.ClientID + "','" + this.txtTotalcostttl.ClientID + "','" + this.txtfobpercntg.ClientID + "','" + this.txtProfitmarginpercntg.ClientID + "','" + this.txtFobperpcs.ClientID + "','" + this.txtProfitmarginpcs.ClientID + "','" + this.txtFobdzn.ClientID + "','" + this.txtProfitmargindzn.ClientID + "','" + this.txtFobttl.ClientID + "','" + this.txtProfitmarginttl.ClientID + "')");
            this.txtFobperpcs.Attributes.Add("onkeyup", "javascript:CalculateFOB ('" + this.txtFobperpcs.ClientID + "','" + this.txtFobdzn.ClientID + "','" + this.txtOrdqtysum.ClientID + "','" + this.txtFobttl.ClientID + "','" + this.txtSubttlTtl.ClientID + "','" + this.txtSubtotalpercntg.ClientID + "','" + this.txtSubtotalpercntg.ClientID + "','" + this.txtmfgcostpercntg.ClientID + "','" + this.txtOverheadpercntg.ClientID + "','" + this.txtComissionpercntg.ClientID + "','" + this.txtTotalcostpercntg.ClientID + "','" + this.txtSubttlperpcs.ClientID + "','" + this.txtmfgperpcs.ClientID + "','" + this.txtOverheadperpcs.ClientID + "','" + this.txtcomissionpcs.ClientID + "','" + this.txtTotalcostpcs.ClientID + "','" + this.txtSubttlDzn.ClientID + "','" + this.txtMfgdzn.ClientID + "','" + this.txtOverheaddzn.ClientID + "','" + this.txtcomissionDzn.ClientID + "','" + this.txtTotalCostDzn.ClientID + "','" + this.txtSubttlTtl.ClientID + "','" + this.txtMfgttl.ClientID + "','" + this.txtOverheadttl.ClientID + "','" + this.txtComissionttl.ClientID + "','" + this.txtTotalcostttl.ClientID + "','" + this.txtfobpercntg.ClientID + "','" + this.txtProfitmarginpercntg.ClientID + "','" + this.txtProfitmarginpcs.ClientID + "','" + this.txtProfitmargindzn.ClientID + "','" + this.txtProfitmarginttl.ClientID + "')");
            this.txtCMwithProfit.Attributes.Add("ondblclick", "javascript:CMTransfer('" + this.txtCMwithProfit.ClientID + "','" + this.txtOrdqtysum.ClientID + "','" + this.txtSubtotalpercntg.ClientID + "','" + this.txtmfgcostpercntg.ClientID + "','" + this.txtOverheadpercntg.ClientID + "','" + this.txtComissionpercntg.ClientID + "','" + this.txtTotalcostpercntg.ClientID + "','" + this.txtSubttlperpcs.ClientID + "','" + this.txtmfgperpcs.ClientID + "','" + this.txtOverheadperpcs.ClientID + "','" + this.txtcomissionpcs.ClientID + "','" + this.txtTotalcostpcs.ClientID + "','" + this.txtSubttlDzn.ClientID + "','" + this.txtMfgdzn.ClientID + "','" + this.txtOverheaddzn.ClientID + "','" + this.txtcomissionDzn.ClientID + "','" + this.txtTotalCostDzn.ClientID + "','" + this.txtSubttlTtl.ClientID + "','" + this.txtMfgttl.ClientID + "','" + this.txtOverheadttl.ClientID + "','" + this.txtComissionttl.ClientID + "','" + this.txtTotalcostttl.ClientID + "','" + this.txtFobttl.ClientID + "','" + this.txtfobpercntg.ClientID + "','" + this.txtProfitmarginpercntg.ClientID + "','" + this.txtFobperpcs.ClientID + "','" + this.txtProfitmarginpcs.ClientID + "','" + this.txtFobdzn.ClientID + "','" + this.txtProfitmargindzn.ClientID + "','" + this.txtProfitmarginttl.ClientID + "')");
            this.txtmanufactCostDz.Attributes.Add("ondblclick", "javascript:SecondMC('" + this.txtProdperhour.ClientID + "','" + this.txtnoOfmachineReq.ClientID + "','" + this.txtMachinecostperHour.ClientID + "','" + this.txtmanufactCostDz.ClientID + "','" + this.txtOrdqtysum.ClientID + "','" + this.txtSubtotalpercntg.ClientID + "','" + this.txtmfgcostpercntg.ClientID + "','" + this.txtOverheadpercntg.ClientID + "','" + this.txtComissionpercntg.ClientID + "','" + this.txtTotalcostpercntg.ClientID + "','" + this.txtSubttlperpcs.ClientID + "','" + this.txtmfgperpcs.ClientID + "','" + this.txtOverheadperpcs.ClientID + "','" + this.txtcomissionpcs.ClientID + "','" + this.txtTotalcostpcs.ClientID + "','" + this.txtSubttlDzn.ClientID + "','" + this.txtMfgdzn.ClientID + "','" + this.txtOverheaddzn.ClientID + "','" + this.txtcomissionDzn.ClientID + "','" + this.txtTotalCostDzn.ClientID + "','" + this.txtSubttlTtl.ClientID + "','" + this.txtMfgttl.ClientID + "','" + this.txtOverheadttl.ClientID + "','" + this.txtComissionttl.ClientID + "','" + this.txtTotalcostttl.ClientID + "','" + this.txtFobttl.ClientID + "','" + this.txtfobpercntg.ClientID + "','" + this.txtProfitmarginpercntg.ClientID + "','" + this.txtFobperpcs.ClientID + "','" + this.txtProfitmarginpcs.ClientID + "','" + this.txtFobdzn.ClientID + "','" + this.txtProfitmargindzn.ClientID + "','" + this.txtProfitmarginttl.ClientID + "')");
            this.txtProdperhour.Attributes.Add("onkeyup", "javascript:SecondMC('" + this.txtProdperhour.ClientID + "','" + this.txtnoOfmachineReq.ClientID + "','" + this.txtMachinecostperHour.ClientID + "','" + this.txtmanufactCostDz.ClientID + "')");
            this.txtnoOfmachineReq.Attributes.Add("onkeyup", "javascript:SecondMC('" + this.txtProdperhour.ClientID + "','" + this.txtnoOfmachineReq.ClientID + "','" + this.txtMachinecostperHour.ClientID + "','" + this.txtmanufactCostDz.ClientID + "')");
            this.txtMachinecostperHour.Attributes.Add("onkeyup", "javascript:SecondMC('" + this.txtProdperhour.ClientID + "','" + this.txtnoOfmachineReq.ClientID + "','" + this.txtMachinecostperHour.ClientID + "','" + this.txtmanufactCostDz.ClientID + "')");
            this.txtOverheadperpcs.Attributes.Add("onkeyup", "javascript:OverHeadCalculate('" + this.txtOrdqtysum.ClientID + "','" + this.txtFobttl.ClientID + "','" + this.txtSubtotalpercntg.ClientID + "','" + this.txtmfgcostpercntg.ClientID + "','" + this.txtOverheadpercntg.ClientID + "','" + this.txtComissionpercntg.ClientID + "','" + this.txtTotalcostpercntg.ClientID + "','" + this.txtSubttlperpcs.ClientID + "','" + this.txtmfgperpcs.ClientID + "','" + this.txtOverheadperpcs.ClientID + "','" + this.txtcomissionpcs.ClientID + "','" + this.txtTotalcostpcs.ClientID + "','" + this.txtSubttlDzn.ClientID + "','" + this.txtMfgdzn.ClientID + "','" + this.txtOverheaddzn.ClientID + "','" + this.txtcomissionDzn.ClientID + "','" + this.txtTotalCostDzn.ClientID + "','" + this.txtSubttlTtl.ClientID + "','" + this.txtMfgttl.ClientID + "','" + this.txtOverheadttl.ClientID + "','" + this.txtComissionttl.ClientID + "','" + this.txtTotalcostttl.ClientID + "','" + this.txtFobperpcs.ClientID + "','" + this.txtProfitmarginpercntg.ClientID + "','" + this.txtFobperpcs.ClientID + "','" + this.txtProfitmarginpcs.ClientID + "','" + this.txtFobdzn.ClientID + "','" + this.txtProfitmargindzn.ClientID + "','" + this.txtProfitmarginttl.ClientID + "')");
            this.txtMfgdzn.Attributes.Add("onkeyup", "javascript:MFCost('" + this.txtOrdqtysum.ClientID + "','" + this.txtFobttl.ClientID + "','" + this.txtSubtotalpercntg.ClientID + "','" + this.txtmfgcostpercntg.ClientID + "','" + this.txtOverheadpercntg.ClientID + "','" + this.txtComissionpercntg.ClientID + "','" + this.txtTotalcostpercntg.ClientID + "','" + this.txtSubttlperpcs.ClientID + "','" + this.txtmfgperpcs.ClientID + "','" + this.txtOverheadperpcs.ClientID + "','" + this.txtcomissionpcs.ClientID + "','" + this.txtTotalcostpcs.ClientID + "','" + this.txtSubttlDzn.ClientID + "','" + this.txtMfgdzn.ClientID + "','" + this.txtOverheaddzn.ClientID + "','" + this.txtcomissionDzn.ClientID + "','" + this.txtTotalCostDzn.ClientID + "','" + this.txtSubttlTtl.ClientID + "','" + this.txtMfgttl.ClientID + "','" + this.txtOverheadttl.ClientID + "','" + this.txtComissionttl.ClientID + "','" + this.txtTotalcostttl.ClientID + "','" + this.txtfobpercntg.ClientID + "','" + this.txtProfitmarginpercntg.ClientID + "','" + this.txtFobperpcs.ClientID + "','" + this.txtProfitmarginpcs.ClientID + "','" + this.txtFobdzn.ClientID + "','" + this.txtProfitmargindzn.ClientID + "','" + this.txtProfitmarginttl.ClientID + "')");
            this.txtComissionpercntg.Attributes.Add("onkeyup", "javascript:CommissionCalculate('" + this.txtFobperpcs.ClientID + "','" + this.txtOrdqtysum.ClientID + "','" + this.txtSubtotalpercntg.ClientID + "','" + this.txtmfgcostpercntg.ClientID + "','" + this.txtOverheadpercntg.ClientID + "','" + this.txtComissionpercntg.ClientID + "','" + this.txtTotalcostpercntg.ClientID + "','" + this.txtSubttlperpcs.ClientID + "','" + this.txtmfgperpcs.ClientID + "','" + this.txtOverheadperpcs.ClientID + "','" + this.txtcomissionpcs.ClientID + "','" + this.txtTotalcostpcs.ClientID + "','" + this.txtSubttlDzn.ClientID + "','" + this.txtMfgdzn.ClientID + "','" + this.txtOverheaddzn.ClientID + "','" + this.txtcomissionDzn.ClientID + "','" + this.txtTotalCostDzn.ClientID + "','" + this.txtSubttlTtl.ClientID + "','" + this.txtMfgttl.ClientID + "','" + this.txtOverheadttl.ClientID + "','" + this.txtComissionttl.ClientID + "','" + this.txtTotalcostttl.ClientID + "','" + this.txtfobpercntg.ClientID + "','" + this.txtProfitmarginpercntg.ClientID + "','" + this.txtFobperpcs.ClientID + "','" + this.txtProfitmarginpcs.ClientID + "','" + this.txtFobdzn.ClientID + "','" + this.txtProfitmargindzn.ClientID + "','" + this.txtFobttl.ClientID + "','" + this.txtProfitmarginttl.ClientID + "')");
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