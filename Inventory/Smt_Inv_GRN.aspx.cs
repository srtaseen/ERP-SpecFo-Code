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

public partial class Inventory_Smt_Inv_GRN : System.Web.UI.Page
{
    private DAL _mycls = new DAL();
    private BLLInventory blinventory = new BLLInventory();
    //protected HtmlInputButton btnAddsupplier;
    //protected Button btnClear;
    //protected Button btnppadd;
    //protected ModalPopupExtender btnppadd_ModalPopupExtender;
    //protected Button btnReloadForapp;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    //protected C1.Web.UI.Controls.C1TabControl.C1TabControl C1TabControl2;
    //protected C1TabPage C1TabPage3;
    //protected C1TabPage C1TabPage4;
    private DALInventory dlinventory = new DALInventory();
    //protected DropDownList drpBuyer;
    //protected TextBox drpCurrenct;
    //protected DropDownList drpPendingPO;
    //protected DropDownList drpStyleNumber;
    //protected DropDownList drpSupplier;
    //protected C1.Web.UI.Controls.C1GridView.C1GridView grdConfirmToApprove;
    //protected GridView grdPurchaseOrderDtl;
    //protected Label Label10;
    //protected Label Label11;
    //protected Label Label12;
    //protected Label Label13;
    //protected Label Label5;
    //protected Label Label6;
    //protected Label Label7;
    //protected Panel Panel1;
    //protected RadioButton rdFactorygrn;
    //protected RadioButton rdMerchantgrn;
    //protected RequiredFieldValidator RequiredFieldValidator2;
    //protected ValidatorCalloutExtender RequiredFieldValidator2_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator3;
    //protected ValidatorCalloutExtender RequiredFieldValidator3_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator4;
    //protected ValidatorCalloutExtender RequiredFieldValidator4_ValidatorCalloutExtender;
    //protected TextBox txtChallan;
    //protected TextBox txtGRNNo;
    //protected UpdatePanel UpdatePanddd;
    //protected UpdatePanel UpdatePanel1;
    //protected UpdatePanel UpdatePanel4;

    public void bind()
    {
        this.drpPendingPO.DataSource = this.blinventory.get_Informationdataset("select distinct nPoNum from Smt_POHedder where POApproved=1 and GrnQtyfull=0 and PoRevised=0 and POCancel=0 order by nPoNum desc");
        this.drpPendingPO.DataTextField = "nPoNum";
        this.drpPendingPO.DataValueField = "nPoNum";
        this.drpPendingPO.DataBind();
        this.drpPendingPO.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpPendingPO.SelectedIndex = 0;
        this.drpBuyer.DataSource = this.blinventory.get_Informationdataset("select distinct nAcct,cBuyer_Name from View_Smt_GRN order by cBuyer_Name");
        this.drpBuyer.DataTextField = "cBuyer_Name";
        this.drpBuyer.DataValueField = "nAcct";
        this.drpBuyer.DataBind();
        this.drpBuyer.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpBuyer.SelectedIndex = 0;
        this.drpSupplier.DataSource = this.blinventory.get_Informationdataset("select distinct cSupName,nSuplierID from View_Smt_GRN order by cSupName");
        this.drpSupplier.DataTextField = "cSupName";
        this.drpSupplier.DataValueField = "nSuplierID";
        this.drpSupplier.DataBind();
        this.drpSupplier.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpSupplier.SelectedIndex = 0;
    }

    public void bindfactorygrn()
    {
        this.txtChallan.Text = "";
        this.drpSupplier.DataSource = this.blinventory.get_Informationdataset("Sp_Smt_FactoryPurchaseGRN_Getsupplier");
        this.drpSupplier.DataTextField = "cSupName";
        this.drpSupplier.DataValueField = "Supplier_ID";
        this.drpSupplier.DataBind();
        this.drpSupplier.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpSupplier.SelectedIndex = 0;
        this.drpBuyer.DataSource = "";
        this.drpBuyer.DataBind();
        this.drpBuyer.Enabled = false;
        this.drpStyleNumber.DataSource = "";
        this.drpStyleNumber.DataBind();
        this.drpStyleNumber.Enabled = false;
        this.grdPurchaseOrderDtl.DataSource = "";
        this.grdPurchaseOrderDtl.DataBind();
        this.drpPendingPO.DataSource = this.blinventory.get_Informationdataset("Sp_Smt_FactoryPurchaseGRN_GetPO");
        this.drpPendingPO.DataTextField = "PO_No";
        this.drpPendingPO.DataValueField = "PO_No";
        this.drpPendingPO.DataBind();
        this.drpPendingPO.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpPendingPO.SelectedIndex = 0;
        this.drpCurrenct.Text = "";
    }

    public void bindForapprove()
    {
        this.grdConfirmToApprove.DataSource = this.blinventory.get_InformationdataTable("Sp_Smt_GoodReceived_GetForApprove '" + this.Session["Uid"].ToString() + "'");
        this.grdConfirmToApprove.DataBind();
    }

    public void bindgrid()
    {
        this.grdConfirmToApprove.DataSource = this.blinventory.get_InformationdataTable("Smt_GoodReceived_GetAll");
        this.grdConfirmToApprove.DataBind();
    }

    public void bindStyle()
    {
        this.drpStyleNumber.DataSource = this.blinventory.get_Informationdataset("Sp_Smt_GoodReceived_GetStyle");
        this.drpStyleNumber.DataTextField = "cStyleNo";
        this.drpStyleNumber.DataValueField = "nstyCode";
        this.drpStyleNumber.DataBind();
        this.drpStyleNumber.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpStyleNumber.SelectedIndex = 0;
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.drpPendingPO.DataSource = this.blinventory.get_Informationdataset("select distinct nPoNum from Smt_POHedder where POApproved=1 and GrnQtyfull=0 and PoRevised=0 and POCancel=0 order by nPoNum desc");
        this.drpPendingPO.DataTextField = "nPoNum";
        this.drpPendingPO.DataValueField = "nPoNum";
        this.drpPendingPO.DataBind();
        this.drpPendingPO.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpPendingPO.SelectedIndex = 0;
        this.drpBuyer.DataSource = this.blinventory.get_Informationdataset("Sp_Smt_PODetails_GetBuyerforInv");
        this.drpBuyer.DataTextField = "cBuyer_Name";
        this.drpBuyer.DataValueField = "nAcct";
        this.drpBuyer.DataBind();
        this.drpBuyer.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpBuyer.SelectedIndex = 0;
        this.drpSupplier.DataSource = this.blinventory.get_Informationdataset("Sp_Smt_POHedder_GetSupplierforInv");
        this.drpSupplier.DataTextField = "cSupName";
        this.drpSupplier.DataValueField = "nSuplierID";
        this.drpSupplier.DataBind();
        this.drpSupplier.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpSupplier.SelectedIndex = 0;
        this.txtChallan.Text = "";
        this.drpCurrenct.Text = "";
        this.drpStyleNumber.SelectedValue = "";
        this.grdPurchaseOrderDtl.DataSource = null;
        this.grdPurchaseOrderDtl.DataBind();
        this.rdMerchantgrn.Checked = true;
        this.rdFactorygrn.Checked = false;
        this.txtChallan.Text = "";
        this.txtGRNNo.Text = "";
    }

    protected void btnlodsup_Click(object sender, ImageClickEventArgs e)
    {
        GridViewRow parent = ((ImageButton)sender).Parent.Parent as GridViewRow;
        DropDownList list = (DropDownList)parent.FindControl("drpnSupplier");
        Label label = (Label)parent.FindControl("lblMcatid");
        list.DataSource = this.blinventory.get_Informationdataset("Sp_Smt_SupSupManCat_getSuplierbyMcatid " + label.Text.Trim());
        list.DataTextField = "cSupName";
        list.DataValueField = "nCode";
        list.DataBind();
        list.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        list.SelectedIndex = 0;
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        Label lbl = (Label)base.Master.FindControl("lbltotalinfo");
        string recvtype = "M";
        if (this.rdFactorygrn.Checked)
        {
            recvtype = "F";
        }
        int num = 0;
        int num2 = 0;
        if (this.grdPurchaseOrderDtl.Rows.Count > 0)
        {
            for (int i = 0; i < this.grdPurchaseOrderDtl.Rows.Count; i++)
            {
                TextBox box = (TextBox)this.grdPurchaseOrderDtl.Rows[i].FindControl("txtGrnQty");
                if (!string.IsNullOrEmpty(box.Text) && (decimal.Parse(box.Text) > 0M))
                {
                    num++;
                }
            }
        }
        if (num > 0)
        {
            this.txtGRNNo.Text = (int.Parse(this.blinventory.get_Informationdataset("select nGRnLast from Smt_Parameters").Tables[0].Rows[0]["nGRnLast"].ToString()) + 1).ToString();
            for (int j = 0; j < this.grdPurchaseOrderDtl.Rows.Count; j++)
            {
                if (this.grdPurchaseOrderDtl.Rows[j].Enabled)
                {
                    Label label1 = (Label)this.grdPurchaseOrderDtl.Rows[j].FindControl("lblStyleno");
                    Label label2 = (Label)this.grdPurchaseOrderDtl.Rows[j].FindControl("lblStyleID");
                    Label label3 = (Label)this.grdPurchaseOrderDtl.Rows[j].FindControl("lblitmdesc");
                    Label label4 = (Label)this.grdPurchaseOrderDtl.Rows[j].FindControl("lblUnit");
                    TextBox box2 = (TextBox)this.grdPurchaseOrderDtl.Rows[j].FindControl("txtGrnQty");
                    TextBox box3 = (TextBox)this.grdPurchaseOrderDtl.Rows[j].FindControl("lblPrice");
                    TextBox box4 = (TextBox)this.grdPurchaseOrderDtl.Rows[j].FindControl("txtGRNValue");
                    Label label5 = (Label)this.grdPurchaseOrderDtl.Rows[j].FindControl("lblItemCode");
                    Label label6 = (Label)this.grdPurchaseOrderDtl.Rows[j].FindControl("lblSlno");
                    Label label7 = (Label)this.grdPurchaseOrderDtl.Rows[j].FindControl("lblSize");
                    Label label8 = (Label)this.grdPurchaseOrderDtl.Rows[j].FindControl("lblColor");
                    Label label9 = (Label)this.grdPurchaseOrderDtl.Rows[j].FindControl("lblArt");
                    Label label10 = (Label)this.grdPurchaseOrderDtl.Rows[j].FindControl("lblDimn");
                    TextBox box5 = (TextBox)this.grdPurchaseOrderDtl.Rows[j].FindControl("txtFocqty");
                    string selectedValue = this.drpSupplier.SelectedValue;
                    DropDownList list = (DropDownList)this.grdPurchaseOrderDtl.Rows[j].FindControl("drpnSupplier");
                    Label label11 = (Label)this.grdPurchaseOrderDtl.Rows[j].FindControl("lblbrandcode");
                    if (!string.IsNullOrEmpty(list.SelectedValue))
                    {
                        selectedValue = list.SelectedValue;
                    }
                    if (!string.IsNullOrEmpty(box2.Text) && (decimal.Parse(box2.Text) > 0M))
                    {
                        this.dlinventory.Save_GRN(int.Parse(this.txtGRNNo.Text), int.Parse(this.drpPendingPO.SelectedValue), int.Parse(label6.Text), int.Parse(label5.Text), label3.Text.Trim(), label7.Text.Trim(), label8.Text.Trim(), label9.Text.Trim(), label10.Text.Trim(), label4.Text.Trim(), box2.Text.Trim(), box5.Text.Trim(), box3.Text.Trim(), box4.Text.Trim(), this.Session["Uid"].ToString(), this.txtChallan.Text.Trim(), label2.Text.Trim(), this.drpCurrenct.Text.Trim(), recvtype, selectedValue, int.Parse(label11.Text.Trim()), lbl);
                        num2++;
                    }
                }
            }
            if (num2 > 0)
            {
                lbl.Text = "Saved Successfully";
                this.dlinventory.Update_ParameterForGRN(int.Parse(this.txtGRNNo.Text));
                this.dlinventory.Update_FPQtyfullgrn(int.Parse(this.drpPendingPO.SelectedValue), recvtype);
                if (this.rdFactorygrn.Checked)
                {
                    this.bindfactorygrn();
                }
                else
                {
                    this.bind();
                }
                this.grdPurchaseOrderDtl.DataSource = null;
                this.grdPurchaseOrderDtl.DataBind();
                this.bindgrid();
                this.txtChallan.Text = "";
                this.drpSupplier.SelectedIndex = 0;
                this.drpCurrenct.Text = "";
            }
            else
            {
                lbl.Text = "NO item Saved";
            }
        }
        else
        {
            lbl.Text = "NO item Saved";
        }
    }

    protected void drpBuyer_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.drpSupplier.DataSource = this.blinventory.get_Informationdataset("select distinct cSupName,nSuplierID from View_Smt_GRN where nAcct='" + this.drpBuyer.SelectedValue + "' order by cSupName");
        this.drpSupplier.DataTextField = "cSupName";
        this.drpSupplier.DataValueField = "nSuplierID";
        this.drpSupplier.DataBind();
        this.drpSupplier.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpSupplier.SelectedIndex = 0;
        this.drpPendingPO.DataSource = this.blinventory.get_Informationdataset("select distinct nPoNum from View_Smt_GRN where nAcct=" + this.drpBuyer.SelectedValue + " and POCancel=0 and GrnQtyfull=0 and PoRevised=0 order by nPoNum desc");
        this.drpPendingPO.DataTextField = "nPoNum";
        this.drpPendingPO.DataValueField = "nPoNum";
        this.drpPendingPO.DataBind();
        this.drpPendingPO.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpPendingPO.SelectedIndex = 0;
        this.grdPurchaseOrderDtl.DataSource = null;
        this.grdPurchaseOrderDtl.DataBind();
    }

    protected void drpPendingPO_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.txtGRNNo.Text = "";
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        if (!this.rdFactorygrn.Checked && !this.rdMerchantgrn.Checked)
        {
            label.Text = "Check Marchant GRN or Facatory GRN";
        }
        else
        {
            this.drpSupplier.SelectedValue = "";
            this.grdPurchaseOrderDtl.DataSource = null;
            this.grdPurchaseOrderDtl.DataBind();
            if (!string.IsNullOrEmpty(this.drpPendingPO.SelectedValue))
            {
                if (this.rdFactorygrn.Checked)
                {
                    DataSet set = this.blinventory.get_Informationdataset("Sp_Smt_FactoryPurchase_GetDtlForGRN " + this.drpPendingPO.SelectedValue);
                    this.grdPurchaseOrderDtl.DataSource = set;
                    this.grdPurchaseOrderDtl.DataBind();
                    DataSet set2 = this.blinventory.get_Informationdataset("select cCurType,Supplier_ID from Smt_FactoryPurchase where PO_No=" + this.drpPendingPO.SelectedValue);
                    this.drpCurrenct.Text = set2.Tables[0].Rows[0]["cCurType"].ToString();
                    this.drpSupplier.SelectedValue = set2.Tables[0].Rows[0]["Supplier_ID"].ToString();
                }
                else
                {
                    DataSet set3 = this.blinventory.get_Informationdataset("Sp_Smt_PODetails_GetForInventory " + this.drpPendingPO.SelectedValue);
                    this.grdPurchaseOrderDtl.DataSource = set3;
                    this.grdPurchaseOrderDtl.DataBind();
                    DataSet set4 = this.blinventory.get_Informationdataset("select cCurType,nSuplierID from Smt_POHedder where nPoNum=" + this.drpPendingPO.SelectedValue);
                    this.drpCurrenct.Text = set4.Tables[0].Rows[0]["cCurType"].ToString();
                    this.drpSupplier.SelectedValue = set4.Tables[0].Rows[0]["nSuplierID"].ToString();
                }
            }
        }
    }

    protected void drpStyleNumber_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.grdPurchaseOrderDtl.DataSource = null;
        this.grdPurchaseOrderDtl.DataBind();
        this.drpSupplier.SelectedValue = "";
        if (!string.IsNullOrEmpty(this.drpStyleNumber.SelectedValue))
        {
            this.drpPendingPO.Items.Clear();
            this.drpPendingPO.DataSource = this.blinventory.get_Informationdataset("Sp_Smt_GoodReceived_GetPOByStyle " + this.drpStyleNumber.SelectedValue);
            this.drpPendingPO.DataTextField = "nPoNum";
            this.drpPendingPO.DataValueField = "nPoNum";
            this.drpPendingPO.DataBind();
            this.drpPendingPO.Items.Insert(0, new ListItem(string.Empty, string.Empty));
            this.drpPendingPO.SelectedIndex = 0;
        }
        else
        {
            this.drpPendingPO.Items.Clear();
        }
    }

    protected void drpSupplier_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.grdPurchaseOrderDtl.DataSource = null;
        this.grdPurchaseOrderDtl.DataBind();
        if (!this.rdFactorygrn.Checked && !this.rdMerchantgrn.Checked)
        {
            label.Text = "Check Marchant GRN or Facatory GRN";
        }
        else
        {
            if (this.rdFactorygrn.Checked)
            {
                this.drpPendingPO.DataSource = this.blinventory.get_Informationdataset("select distinct PO_No as nPoNum from Smt_FactoryPurchase where Supplier_ID=" + this.drpSupplier.SelectedValue + " and PO_Approved=1 and GrnQtyfull=0 and PO_Cancel=0 order by PO_No desc");
            }
            else
            {
                this.drpPendingPO.DataSource = this.blinventory.get_Informationdataset("Sp_Smt_POHedder_getPOBySupplier " + this.drpSupplier.SelectedValue);
            }
            this.drpPendingPO.DataTextField = "nPoNum";
            this.drpPendingPO.DataValueField = "nPoNum";
            this.drpPendingPO.DataBind();
            this.drpPendingPO.Items.Insert(0, new ListItem(string.Empty, string.Empty));
            this.drpPendingPO.SelectedIndex = 0;
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

    protected void grdConfirmToApprove_Filtering(object sender, C1GridViewFilterEventArgs e)
    {
        this.bindgrid();
    }

    protected void grdConfirmToApprove_PageIndexChanging(object sender, C1GridViewPageEventArgs e)
    {
        this.grdConfirmToApprove.PageIndex = e.NewPageIndex;
        this.bindgrid();
    }

    protected void grdConfirmToApprove_RowDataBound(object sender, C1GridViewRowEventArgs e)
    {
        if (e.Row.RowType == C1GridViewRowType.DataRow)
        {
            Label label = (Label)e.Row.FindControl("lblGrnNo");
            HtmlAnchor anchor = (HtmlAnchor)e.Row.FindControl("ancvw");
            anchor.Attributes.Add("onclick", "javascript:viewgrndtl(" + label.Text.Trim() + ")");
        }
    }

    protected void grdConfirmToApprove_Sorting(object sender, C1GridViewSortEventArgs e)
    {
        this.bindgrid();
    }

    protected void grdPurchaseOrderDtl_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            HtmlAnchor anchor = (HtmlAnchor)e.Row.FindControl("ancpp");
            e.Row.Cells[10].Attributes.Add("style", "background-color:#F2D9E6;font-weight:bold");
            e.Row.Cells[11].Attributes.Add("style", "background-color:#CEFFFF;text-align:center");
            Label label = (Label)e.Row.FindControl("lblStyleID");
            Label label2 = (Label)e.Row.FindControl("lblItemCode");
            Label label3 = (Label)e.Row.FindControl("lblSlno");
            Label label4 = (Label)e.Row.FindControl("lblQty");
            Label label5 = (Label)e.Row.FindControl("lblRest");
            TextBox box = (TextBox)e.Row.FindControl("txtGRNValue");
            TextBox box2 = (TextBox)e.Row.FindControl("txtFocqty");
            TextBox box3 = (TextBox)e.Row.FindControl("txtGrnQty");
            Button button1 = (Button)e.Row.FindControl("btnLocation");
            DataTable table = this.blinventory.get_InformationdataTable("Sp_Smt_GoodReceived_GetGRNValue " + this.drpPendingPO.SelectedValue + "," + label3.Text + "," + label2.Text + "," + label.Text);
            if (table.Rows.Count > 0)
            {
                string str = table.Rows[0]["nQty"].ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    string str2 = table.Rows[0]["nFOC"].ToString();
                    string str3 = table.Rows[0]["nValue"].ToString();
                    label5.Text = (decimal.Parse(label4.Text) - decimal.Parse(str)).ToString();
                    if (decimal.Parse(label5.Text) == 0M)
                    {
                        e.Row.Enabled = false;
                        e.Row.BackColor = Color.Pink;
                        e.Row.ToolTip = "No Rest Quantity.Item is Blocked";
                        label5.Attributes.Add("style", "color:Red;font-weight:bold");
                        box3.Text = str;
                        box2.Text = str2;
                        box.Text = str3;
                        e.Row.Cells[11].Attributes.Add("style", "background-color:Transparent");
                        anchor.Visible = false;
                    }
                }
            }
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Label label6 = (Label)e.Row.FindControl("lblItemCode");
                anchor.Attributes.Add("onclick", "javascript:showItmloct(" + label6.Text.Trim() + ",'" + box3.ClientID + "')");
                TextBox box4 = (TextBox)e.Row.FindControl("lblPrice");
                TextBox box5 = (TextBox)e.Row.FindControl("txtGrnQty");
                TextBox box6 = (TextBox)e.Row.FindControl("txtGRNValue");
                TextBox box7 = (TextBox)e.Row.FindControl("txtFocqty");
                Label label7 = (Label)e.Row.FindControl("lblRest");
                box4.Attributes.Add("onkeyup", "CalculateGRNValue('" + box4.ClientID + "','" + box5.ClientID + "','" + box6.ClientID + "','" + label7.ClientID + "','" + box7.ClientID + "')");
                box5.Attributes.Add("onkeyup", "CalculateGRNValue('" + box4.ClientID + "','" + box5.ClientID + "','" + box6.ClientID + "','" + label7.ClientID + "','" + box7.ClientID + "')");
            }
            if (this.rdFactorygrn.Checked)
            {
                DropDownList list = (DropDownList)e.Row.FindControl("drpnSupplier");
                list.Enabled = true;
                Label label8 = (Label)e.Row.FindControl("lblMcatid");
                DataRowView dataItem = (DataRowView)e.Row.DataItem;
                label8.Text = dataItem["cManCode"].ToString();
                list.DataSource = this.blinventory.get_Informationdataset("Sp_Smt_SupSupManCat_getSuplierbyMcatid " + label8.Text.Trim());
                list.DataTextField = "cSupName";
                list.DataValueField = "nCode";
                list.DataBind();
                list.Items.Insert(0, new ListItem(string.Empty, string.Empty));
                list.SelectedIndex = 0;
            }
        }
    }

    protected void lnkprint_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        C1GridViewRow parent = ((LinkButton)sender).Parent.Parent as C1GridViewRow;
        LinkButton button = (LinkButton)parent.FindControl("lnkprint");
        this.Session["GRNNO"] = button.CommandArgument;
        this.Session["Param"] = "GRNNO";
        this.runjQueryCode("window.open('Smt_Inv_ReportDisplay.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.Session["Uid"] == null)
        {
            base.Response.Redirect("../Smt_Login.aspx", false);
        }
        else if (!base.IsPostBack)
        {
            this.bind();
            this.bindStyle();
            this.bindForapprove();
            Control[] btnall = new Control[] { this.btnSave };
            Control[] addbtn = new Control[0];
            HtmlInputButton[] htmlbtn = new HtmlInputButton[] { this.btnAddsupplier };
            this._mycls.SetBtnPermissionwithhtmlbtn(this.Session["Uid"].ToString(), btnall, addbtn, htmlbtn, "Smt_Inv_GRN.aspx");
        }
    }

    protected void rdFactorygrn_CheckedChanged(object sender, EventArgs e)
    {
        this.bindfactorygrn();
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.txtGRNNo.Text = "";
    }

    protected void rdMerchantgrn_CheckedChanged(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.bind();
        this.grdPurchaseOrderDtl.DataSource = null;
        this.grdPurchaseOrderDtl.DataBind();
        this.drpCurrenct.Text = "";
        this.drpBuyer.Enabled = true;
        this.drpStyleNumber.Enabled = true;
        this.bindStyle();
        this.txtGRNNo.Text = "";
    }

    protected void refGRN(object sender, EventArgs e)
    {
        this.bindForapprove();
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