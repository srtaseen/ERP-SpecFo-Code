using AjaxControlToolkit;
using ASP;
using C1.Web.UI.Controls.C1GridView;
using C1.Web.UI.Controls.C1TabControl;
using System;
using System.Data;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Commercial_Smt_Com_PerfomaInvoice : System.Web.UI.Page
{
    private BLLInventory blinventory = new BLLInventory();
    //protected Button btnClear;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    //protected C1.Web.UI.Controls.C1TabControl.C1TabControl C1TabControl1;
    //protected C1TabPage C1TabPage1;
    //protected C1TabPage C1TabPage2;
    //protected ImageButton cal1;
    //protected ImageButton cal2;
    private ClsCommercial clsCommercial = new ClsCommercial();
    private DALInventory dlInventory = new DALInventory();
    //protected DropDownList drpCurrencyType;
    //protected DropDownList drpSupplier;
    //protected GridView grdAvailablePO;
    //protected C1.Web.UI.Controls.C1GridView.C1GridView grdEditview;
    //protected GridView grdItemDetail;
    //protected GridView grdSelectedPO;
    //protected Label Label1;
    //protected Label Label13;
    //protected Label Label14;
    //protected Label Label15;
    //protected Label Label16;
    //protected Label Label4;
    private BLL mybl = new BLL();
    private DAL mycls = new DAL();
    //protected Panel pnlAvailablePO;
    //protected Panel pnlSelectedPO;
    //protected RequiredFieldValidator RequiredFieldValidator1;
    //protected ValidatorCalloutExtender RequiredFieldValidator1_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator5;
    //protected ValidatorCalloutExtender RequiredFieldValidator5_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator6;
    //protected ValidatorCalloutExtender RequiredFieldValidator6_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator7;
    //protected ValidatorCalloutExtender RequiredFieldValidator7_ValidatorCalloutExtender;
    private decimal Totalval;
    //protected TextBox txtPIDate;
    //protected CalendarExtender txtPIDate_CalendarExtender;
    //protected MaskedEditExtender txtPIDate_MaskedEditExtender;
    //protected TextBox txtPIno;
    //protected TextBox txtShipmentDate;
    //protected CalendarExtender txtShipmentDate_CalendarExtender;
    //protected MaskedEditExtender txtShipmentDate_MaskedEditExtender;
    //protected TextBox txtTotalvalue;
    //protected FilteredTextBoxExtender txtTotalvalue_FilteredTextBoxExtender;
    //protected UpdatePanel UpdatePanel1;
    //protected UpdatePanel UpdatePanel2;
    //protected UpdatePanel updMain;

    public void bindgrid()
    {
        this.grdEditview.DataSource = this.blinventory.get_InformationdataTable("Sp_Smt_PIMaster_GetAll");
        this.grdEditview.DataBind();
    }

    public void bindgrid(int count, string PONO)
    {
        DataRow row;
        DataTable table = new DataTable();
        table.Columns.Add(new DataColumn("nPoNum", typeof(string)));
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
            row["nPoNum"] = PONO;
            table.Rows.Add(row);
        }
        else
        {
            row = table.NewRow();
            row["nPoNum"] = PONO;
            table.Rows.Add(row);
        }
        if (this.ViewState["CurrentData"] != null)
        {
            this.grdSelectedPO.DataSource = this.ViewState["CurrentData"];
            this.grdSelectedPO.DataBind();
        }
        else
        {
            this.grdSelectedPO.DataSource = table;
            this.grdSelectedPO.DataBind();
        }
        this.ViewState["CurrentData"] = table;
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.ClearAll();
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
    }

    protected void btnRemoveSelected_Click(object sender, ImageClickEventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.Totalval = 0M;
        string text = null;
        GridViewRow parent = ((ImageButton)sender).Parent.Parent as GridViewRow;
        Label label2 = (Label)parent.FindControl("lblSelectedPO");
        DataTable table = (DataTable)this.ViewState["AvailablePO"];
        DataRow row = table.NewRow();
        row["nPoNum"] = label2.Text;
        table.Rows.Add(row);
        this.grdAvailablePO.DataSource = table;
        this.grdAvailablePO.DataBind();
        DataTable table2 = (DataTable)this.ViewState["CurrentData"];
        table2.Rows.RemoveAt(parent.RowIndex);
        this.grdSelectedPO.DataSource = table2;
        this.grdSelectedPO.DataBind();
        if (this.grdSelectedPO.Rows.Count < 1)
        {
            this.ViewState["CurrentData"] = null;
        }
        for (int i = 0; i < this.grdSelectedPO.Rows.Count; i++)
        {
            Label label3 = (Label)this.grdSelectedPO.Rows[i].FindControl("lblSelectedPO");
            if (i == 0)
            {
                text = label3.Text;
            }
            else
            {
                text = text + " or nPoNum=" + label3.Text;
            }
        }
        if (text != null)
        {
            this.grdItemDetail.DataSource = this.blinventory.get_Informationdataset("SELECT nPoNum,cItemCode,cItemdes,cSize,cColour,cArt,cDimec,cUnit,nQty,nPrice,nVal FROM Smt_PODetails where nPoNum=" + text);
            this.grdItemDetail.DataBind();
        }
        else
        {
            this.grdItemDetail.DataSource = null;
            this.grdItemDetail.DataBind();
        }
        if (this.grdItemDetail.Rows.Count < 1)
        {
            this.txtTotalvalue.Text = "0";
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        Label lbl = (Label)base.Master.FindControl("lbltotalinfo");
        this.clsCommercial.Save_PIMaster(this.drpSupplier.SelectedValue, this.txtPIno.Text.Trim(), this.txtPIDate.Text, this.txtShipmentDate.Text, this.drpCurrencyType.SelectedItem.Text, this.Session["Uid"].ToString(), this.txtTotalvalue.Text.Trim(), lbl);
        this.clsCommercial.Delete_PIDetail(this.txtPIno.Text.Trim());
        if (this.grdItemDetail.Rows.Count > 0)
        {
            for (int i = 0; i < this.grdItemDetail.Rows.Count; i++)
            {
                Label label2 = (Label)this.grdItemDetail.Rows[i].FindControl("lblPONO");
                Label label3 = (Label)this.grdItemDetail.Rows[i].FindControl("lblItemID");
                Label label4 = (Label)this.grdItemDetail.Rows[i].FindControl("lblItemname");
                Label label5 = (Label)this.grdItemDetail.Rows[i].FindControl("lblSize");
                Label label6 = (Label)this.grdItemDetail.Rows[i].FindControl("lblColor");
                Label label7 = (Label)this.grdItemDetail.Rows[i].FindControl("lblArticle");
                Label label8 = (Label)this.grdItemDetail.Rows[i].FindControl("lblDimension");
                Label label9 = (Label)this.grdItemDetail.Rows[i].FindControl("lblUnit");
                Label label10 = (Label)this.grdItemDetail.Rows[i].FindControl("lblQuantity");
                Label label11 = (Label)this.grdItemDetail.Rows[i].FindControl("lblPrice");
                Label label12 = (Label)this.grdItemDetail.Rows[i].FindControl("lblValue");
                this.clsCommercial.Save_PIDetails(this.txtPIno.Text.Trim(), label2.Text, int.Parse(label3.Text), label4.Text, label5.Text.Trim(), label6.Text.Trim(), label7.Text.Trim(), label8.Text.Trim(), label9.Text.Trim(), label10.Text.Trim(), label11.Text.Trim(), label12.Text.Trim(), lbl);
            }
            if (this.grdAvailablePO.Rows.Count > 0)
            {
                for (int j = 0; j < this.grdAvailablePO.Rows.Count; j++)
                {
                    Label label13 = (Label)this.grdAvailablePO.Rows[j].FindControl("lblPOAvailable");
                    this.clsCommercial.Update_POfromPI(label13.Text.Trim());
                }
            }
            this.ClearAll();
        }
        else
        {
            lbl.Text = "Select PO First";
        }
    }

    protected void chkSelectAvailablePO_CheckedChanged(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.grdItemDetail.DataSource = null;
        this.grdItemDetail.DataBind();
        string text = null;
        GridViewRow parent = ((CheckBox)sender).Parent.Parent as GridViewRow;
        CheckBox box = (CheckBox)parent.FindControl("chkSelectAvailablePO");
        Label label2 = (Label)parent.FindControl("lblPOAvailable");
        if (box.Checked)
        {
            DataTable table = (DataTable)this.ViewState["AvailablePO"];
            if (this.ViewState["CurrentData"] != null)
            {
                DataTable table2 = (DataTable)this.ViewState["CurrentData"];
                int count = table2.Rows.Count;
                this.bindgrid(count, label2.Text);
                table.Rows.RemoveAt(parent.RowIndex);
            }
            else
            {
                this.bindgrid(1, label2.Text);
                table.Rows.RemoveAt(parent.RowIndex);
            }
            this.grdAvailablePO.DataSource = table;
            this.grdAvailablePO.DataBind();
        }
        for (int i = 0; i < this.grdSelectedPO.Rows.Count; i++)
        {
            Label label3 = (Label)this.grdSelectedPO.Rows[i].FindControl("lblSelectedPO");
            if (i == 0)
            {
                text = label3.Text;
            }
            else
            {
                text = text + " or nPoNum=" + label3.Text;
            }
        }
        this.grdItemDetail.DataSource = this.blinventory.get_Informationdataset("SELECT nPoNum,cItemCode,cItemdes,cSize,cColour,cArt,cDimec,cUnit,nQty,nPrice,nVal FROM Smt_PODetails where nPoNum=" + text);
        this.grdItemDetail.DataBind();
    }

    public void ClearAll()
    {
        this.drpSupplier.SelectedValue = "";
        this.drpCurrencyType.SelectedValue = "";
        this.txtPIDate.Text = "";
        this.txtPIno.Text = "";
        this.txtShipmentDate.Text = "";
        this.ViewState["AvailablePO"] = null;
        this.ViewState["CurrentData"] = null;
        this.SetInitialAvailablePO();
        this.grdSelectedPO.DataSource = null;
        this.grdSelectedPO.DataBind();
        this.grdItemDetail.DataSource = null;
        this.grdItemDetail.DataBind();
        this.drpSupplier.Enabled = true;
        this.txtPIno.Enabled = true;
        this.txtTotalvalue.Text = "";
        this.bindgrid();
        this.txtPIno.Focus();
    }

    protected void drpSupplier_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.ViewState["AvailablePO"] = null;
        this.ViewState["CurrentData"] = null;
        this.grdSelectedPO.DataSource = null;
        this.grdSelectedPO.DataBind();
        this.grdAvailablePO.DataSource = null;
        this.grdAvailablePO.DataBind();
        this.grdItemDetail.DataSource = null;
        this.grdItemDetail.DataBind();
        this.SetInitialAvailablePO();
        if (!string.IsNullOrEmpty(this.drpSupplier.SelectedValue))
        {
            DataTable table = this.blinventory.get_InformationdataTable("select nPoNum from Smt_POHedder where nSuplierID=" + this.drpSupplier.SelectedValue + " and POApproved=1 and PoRevised=0 and cPiNo is null order by nPoNum desc");
            this.grdAvailablePO.DataSource = table;
            this.grdAvailablePO.DataBind();
            this.ViewState["AvailablePO"] = table;
        }
    }

    public void GetSupplier()
    {
        DataTable table = this.blinventory.get_InformationdataTable("Sp_Smt_POHedder_GetSupplierForPI");
        this.drpSupplier.DataSource = table;
        this.drpSupplier.DataTextField = "cSupName";
        this.drpSupplier.DataValueField = "nSuplierID";
        this.drpSupplier.DataBind();
        this.drpSupplier.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpSupplier.SelectedIndex = 0;
    }

    protected void grdAvailablePO_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label label = (Label)e.Row.FindControl("lblPOAvailable");
            if (string.IsNullOrEmpty(label.Text))
            {
                e.Row.Visible = false;
            }
        }
    }

    protected void grdEditview_Filtering(object sender, C1GridViewFilterEventArgs e)
    {
        this.bindgrid();
    }

    protected void grdEditview_PageIndexChanging(object sender, C1GridViewPageEventArgs e)
    {
        this.grdEditview.PageIndex = e.NewPageIndex;
        this.bindgrid();
    }

    protected void grdEditview_RowCommand(object sender, C1GridViewCommandEventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        if (e.CommandName == "Select")
        {
            int num = int.Parse(e.CommandArgument.ToString());
            string text = this.grdEditview.Rows[num].Cells[1].Text;
            this.ViewState["AvailablePO"] = null;
            this.ViewState["CurrentData"] = null;
            this.grdAvailablePO.DataSource = null;
            this.grdAvailablePO.DataBind();
            this.grdSelectedPO.DataSource = null;
            this.grdSelectedPO.DataBind();
            this.grdItemDetail.DataSource = null;
            this.grdItemDetail.DataBind();
            this.drpSupplier.Enabled = true;
            DataSet set = this.blinventory.get_Informationdataset("select PI_ID,Supplier_ID,PI_No,PI_date,Shipment_Date,Currency,PI_Total from Smt_PIMaster where PI_No='" + text.Trim() + "'");
            if (set.Tables[0].Rows.Count > 0)
            {
                this.txtPIno.Text = text;
                this.txtPIno.Focus();
                this.drpSupplier.SelectedValue = set.Tables[0].Rows[0]["Supplier_ID"].ToString();
                this.txtPIDate.Text = set.Tables[0].Rows[0]["PI_date"].ToString();
                this.txtShipmentDate.Text = set.Tables[0].Rows[0]["Shipment_Date"].ToString();
                this.drpCurrencyType.SelectedValue = set.Tables[0].Rows[0]["Currency"].ToString();
                this.txtTotalvalue.Text = set.Tables[0].Rows[0]["PI_Total"].ToString();
                DataTable table = this.blinventory.get_InformationdataTable("select nPoNum from Smt_POHedder where nSuplierID=" + this.drpSupplier.SelectedValue + " and POApproved=1 and cPiNo is NULL order by nPoNum desc");
                this.ViewState["AvailablePO"] = table;
                DataTable table2 = this.blinventory.get_InformationdataTable("select distinct(PO_No) as nPoNum from Smt_PIDetails where PI_No='" + text.Trim() + "'");
                this.grdSelectedPO.DataSource = table2;
                this.grdSelectedPO.DataBind();
                this.ViewState["CurrentData"] = table2;
                DataTable table3 = (DataTable)this.ViewState["AvailablePO"];
                this.grdAvailablePO.DataSource = table3;
                this.grdAvailablePO.DataBind();
                this.ViewState["AvailablePO"] = table3;
                this.grdItemDetail.DataSource = this.blinventory.get_Informationdataset("Sp_Smt_PIDetails_GetByPINO '" + this.txtPIno.Text.Trim() + "'");
                this.grdItemDetail.DataBind();
                this.drpSupplier.Enabled = false;
                this.txtPIno.Enabled = false;
                this.C1TabControl1.MoveFirst();
            }
        }
    }

    protected void grdEditview_RowDataBound(object sender, C1GridViewRowEventArgs e)
    {
        e.Row.Cells[0].Width = 50;
    }

    protected void grdItemDetail_PreRender(object sender, EventArgs e)
    {
    }

    protected void grdItemDetail_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Cells[0].Attributes.Add("style", "text-align:center");
            Label label = (Label)e.Row.FindControl("lblValue");
            this.Totalval += decimal.Parse(label.Text);
            this.txtTotalvalue.Text = this.Totalval.ToString();
        }
        this.grdItemDetail.Columns[9].FooterText = this.Totalval.ToString();
    }

    protected void grdSelectedPO_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Cells[1].Width = 0x2d;
            e.Row.Cells[1].Attributes.Add("style", "text-align:center");
        }
    }

    public static void margeItemDescription(GridView gridView)
    {
        for (int i = gridView.Rows.Count - 2; i >= 0; i--)
        {
            GridViewRow row = gridView.Rows[i];
            GridViewRow row2 = gridView.Rows[i + 1];
            if (row.Cells[0].Text == row2.Cells[0].Text)
            {
                row.Cells[0].RowSpan = (row2.Cells[0].RowSpan < 2) ? 2 : (row2.Cells[0].RowSpan + 1);
                row2.Cells[0].Visible = false;
            }
        }
    }

    public static void MergeRowsPO(GridView gridView)
    {
        for (int i = gridView.Rows.Count - 2; i >= 0; i--)
        {
            GridViewRow row = gridView.Rows[i];
            GridViewRow row2 = gridView.Rows[i + 1];
            if (row.Cells[0].Text == row2.Cells[0].Text.ToString())
            {
                row.Cells[0].RowSpan = (row2.Cells[0].RowSpan < 2) ? 2 : (row2.Cells[0].RowSpan + 1);
                row2.Cells[0].Visible = false;
            }
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!base.IsPostBack)
        {
            this.dlInventory.drp_Currencytype(this.drpCurrencyType);
            this.GetSupplier();
            this.SetInitialAvailablePO();
            this.txtPIno.Focus();
            this.bindgrid();
        }
    }

    private void SetInitialAvailablePO()
    {
        DataTable table = new DataTable();
        DataRow row = null;
        table.Columns.Add(new DataColumn("nPoNum", typeof(string)));
        row = table.NewRow();
        row["nPoNum"] = string.Empty;
        table.Rows.Add(row);
        this.ViewState["AvailablePO"] = table;
        this.grdAvailablePO.DataSource = table;
        this.grdAvailablePO.DataBind();
    }

    protected void txtPIno_TextChanged(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.ViewState["AvailablePO"] = null;
        this.ViewState["CurrentData"] = null;
        this.grdAvailablePO.DataSource = null;
        this.grdAvailablePO.DataBind();
        this.grdSelectedPO.DataSource = null;
        this.grdSelectedPO.DataBind();
        this.grdItemDetail.DataSource = null;
        this.grdItemDetail.DataBind();
        this.drpSupplier.Enabled = true;
        this.drpSupplier.Focus();
        DataSet set = this.blinventory.get_Informationdataset("select PI_ID,Supplier_ID,PI_No,PI_date,Shipment_Date,Currency,PI_Total from Smt_PIMaster where PI_No='" + this.txtPIno.Text.Trim() + "'");
        if (set.Tables[0].Rows.Count > 0)
        {
            this.drpSupplier.SelectedValue = set.Tables[0].Rows[0]["Supplier_ID"].ToString();
            this.txtPIDate.Text = set.Tables[0].Rows[0]["PI_date"].ToString();
            this.txtShipmentDate.Text = set.Tables[0].Rows[0]["Shipment_Date"].ToString();
            this.drpCurrencyType.SelectedValue = set.Tables[0].Rows[0]["Currency"].ToString();
            this.txtTotalvalue.Text = set.Tables[0].Rows[0]["PI_Total"].ToString();
            DataTable table = this.blinventory.get_InformationdataTable("select nPoNum from Smt_POHedder where nSuplierID=" + this.drpSupplier.SelectedValue + " and POApproved=1 and cPiNo is NULL order by nPoNum desc");
            this.ViewState["AvailablePO"] = table;
            DataTable table2 = this.blinventory.get_InformationdataTable("select distinct(PO_No) as nPoNum from Smt_PIDetails where PI_No='" + this.txtPIno.Text.Trim() + "'");
            this.grdSelectedPO.DataSource = table2;
            this.grdSelectedPO.DataBind();
            this.ViewState["CurrentData"] = table2;
            DataTable table3 = (DataTable)this.ViewState["AvailablePO"];
            this.grdAvailablePO.DataSource = table3;
            this.grdAvailablePO.DataBind();
            this.ViewState["AvailablePO"] = table3;
            this.grdItemDetail.DataSource = this.blinventory.get_Informationdataset("Sp_Smt_PIDetails_GetByPINO '" + this.txtPIno.Text.Trim() + "'");
            this.grdItemDetail.DataBind();
            this.drpSupplier.Enabled = false;
            this.txtPIno.Enabled = false;
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
