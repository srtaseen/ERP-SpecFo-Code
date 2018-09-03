using AjaxControlToolkit;
using ASP;
using C1.Web.UI.Controls.C1GridView;
using C1.Web.UI.Controls.C1TabControl;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net.Mime;
using System.Net.NetworkInformation;
using System.Text;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Smt_Mer_POApproval : System.Web.UI.Page
{
    private BLL _bll = new BLL();
    private MC _mc = new MC();
    private BLLInventory blInventory = new BLLInventory();
    protected Button btnCnfApprove;
    protected ConfirmButtonExtender btnCnfApprove_ConfirmButtonExtender;
    protected Button btnConCancel;
    protected Button btnRevised;
    protected Button btnReviseForApp;
    protected ConfirmButtonExtender btnReviseForApp_ConfirmButtonExtender2;
    protected C1.Web.UI.Controls.C1TabControl.C1TabControl C1TabControl1;
    protected C1TabPage C1TabPage1;
    protected C1TabPage C1TabPage2;
    protected C1TabPage C1TabPage3;
    protected C1TabPage C1TabPage4;
    protected C1TabPage C1TabPage5;
    private System.Data.SqlClient.SqlConnection cn = GetWay.SpecFo_Inventorycon;
    protected ConfirmButtonExtender ConfirmButtonExtender1;
    protected ConfirmButtonExtender confrev;
    private int ConfToApp;
    private DALInventory dlInventory = new DALInventory();
    private int forApp;
    protected C1.Web.UI.Controls.C1GridView.C1GridView grdApproved;
    protected C1.Web.UI.Controls.C1GridView.C1GridView grdCanceled;
    //protected C1.Web.UI.Controls.C1GridView.C1GridView grdConfirmToApprove;
    protected GridView grdDisPODtl;
    protected C1.Web.UI.Controls.C1GridView.C1GridView grdForApproval;
    protected C1.Web.UI.Controls.C1GridView.C1GridView grdPORevised;
    protected Label Label1;
    protected Label Label2;
    protected Label Label3;
    protected Label Label4;
    protected Label lblModlHdr;
    private DAL mycls = new DAL();
    private int revForApp;
    protected Button txtApproval;
    protected ConfirmButtonExtender txtApproval_ConfirmButtonExtender;
    //protected UpdatePanel UpdatePanel1;
    protected UpdatePanel UpdatePanel2;
    protected UpdatePanel UpdatePanel3;
    protected UpdatePanel UpdatePanel4;
    protected UpdatePanel UpdatePanel5;
    protected UpdatePanel UpdatePanel6;
    protected UpdatePanel updpnlQutantitybreakdown;
    protected UpdatePanel updPODtl;
    //public void bindapprove()
    //{
    //    this.grdApproved.DataSource = (this.blInventory.get_InformationdataTable("Sp_Smt_PO_GetApprove '" + this.Session["Uid"].ToString() + "'"));
    //    this.grdApproved.DataBind();
    //}

    //public void bindcanceled()
    //{
    //    this.grdCanceled.DataSource = (this.blInventory.get_InformationdataTable("Sp_Smt_PO_GetCanceled '" + this.Session["Uid"].ToString() + "'"));
    //    this.grdCanceled.DataBind();
    //}

    public void bindconfirmtoapprove()
    {
        this.grdConfirmToApprove.DataSource = (this.blInventory.get_InformationdataTable("Sp_Smt_PO_GetConfirmToApprove '" + this.Session["Uid"].ToString() + "'"));
        this.grdConfirmToApprove.DataBind();
    }

    //public void bindforapproval()
    //{
    //    this.grdForApproval.DataSource = (this.blInventory.get_InformationdataTable("Sp_Smt_PO_GetForApprove '" + this.Session["Uid"].ToString() + "'"));
    //    this.grdForApproval.DataBind();
    //}

    //public void bindrevised()
    //{
    //    this.grdPORevised.DataSource = (this.blInventory.get_InformationdataTable("Sp_Smt_PO_GetRevised '" + this.Session["Uid"].ToString() + "'"));
    //    this.grdPORevised.DataBind();
    //}

    protected void btnCnfApprove_Click(object sender, System.EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        if (this.grdConfirmToApprove.Rows.Count > 0)
        {
            for (int i = 0; i < this.grdConfirmToApprove.Rows.Count; i = (int)(i + 1))
            {
                //string str = this.grdConfirmToApprove.Rows.get_Item(i).Cells.get_Item(3).get_Text().Trim();
                string str = this.grdConfirmToApprove.Rows[i].Cells[3].Text.Trim();
                CheckBox box = (CheckBox)this.grdConfirmToApprove.Rows[i].FindControl("chkSelect");
                if (box.Checked)
                {
                    this.dlInventory.PO_ConfirmToApprove(int.Parse(str));
                    this.ConfToApp = (int)(this.ConfToApp + 1);
                }
            }
            if (this.ConfToApp > 0)
            {
                label.Text = ("Confirm To Approve " + ((int)this.ConfToApp) + " PO");
            }
            else
            {
                label.Text = ("Check PO First");
            }
        }
        this.bindconfirmtoapprove();
        this.grdConfirmToApprove.DataBind();
        //this.bindforapproval();
    }

    protected void btnCancel_Click(object sender, System.EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        this.cn.Open();
        System.Data.SqlClient.SqlTransaction transaction = this.cn.BeginTransaction();
        try
        {
            if (this.grdConfirmToApprove.Rows.Count > 0)
            {
                for (int i = 0; i < this.grdConfirmToApprove.Rows.Count; i = (int)(i + 1))
                {
                    CheckBox box = (CheckBox)this.grdConfirmToApprove.Rows[i].FindControl("chkSelect");
                    if (box.Checked)
                    {
                        string str = this.grdConfirmToApprove.Rows[i].Cells[3].Text.Trim();
                        string[] strArray = new string[] { "@PONO", "@cncluser" };
                        string[] strArray2 = new string[] { str.Trim(), this.Session["Uid"].ToString() };
                        this._mc.MC_Save_nodt_tr("Sp_Smt_BOM_POCancel", this.cn, transaction, strArray, strArray2);
                    }
                }
            }
            transaction.Commit();
            label.Text = ("Cancelled Successfully");
            this.bindconfirmtoapprove();
            //this.bindcanceled();
        }
        catch (System.Exception)
        {
            transaction.Rollback();
            label.Text = ("Unable to Cancel");
        }
        finally
        {
            this.cn.Close();
        }
    }

    protected void btnEmail_Click(object sender, System.EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        C1GridViewRow parent = ((LinkButton)sender).Parent.Parent as C1GridViewRow;
        LinkButton button1 = (LinkButton)parent.FindControl("btnEmail");
        Label label2 = (Label)parent.FindControl("lblSupplierID");
        Label label3 = (Label)parent.FindControl("lblPO");
        try
        {
            this.Sentmail_supplier(int.Parse(label3.Text), int.Parse(label2.Text));
            label.Text = ("Success");
        }
        catch (System.Exception exception)
        {
            label.Text = (exception.Message);
        }
    }

    protected void btnPODtlview_Click(object sender, System.EventArgs e)
    {
        //this.grdDisPODtl.set_DataSource(null);
        this.grdDisPODtl.DataSource = null;
        this.grdDisPODtl.DataBind();
        C1GridViewRow parent = ((LinkButton)sender).Parent.Parent as C1GridViewRow;
        string str = parent.Cells[3].Text.Trim();
        this.viewPODtl(int.Parse(str));
    }

    protected void btnPrintAprov_Click(object sender, System.EventArgs e)
    {
        C1GridViewRow parent = ((LinkButton)sender).Parent.Parent as C1GridViewRow;
        LinkButton button = (LinkButton)parent.FindControl("btnPrintAprov");
        this.Session["pono"] = button.CommandArgument;
        this.Session["Param"] = "PONO";
        this.runjQueryCode("window.open('Report_Merchandising/Smt_MerchandisingReport.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
    }

    protected void btnPrintCanceled_Click(object sender, System.EventArgs e)
    {
        C1GridViewRow parent = ((LinkButton)sender).Parent.Parent as C1GridViewRow;
        LinkButton button = (LinkButton)parent.FindControl("btnPrintCanceled");
        this.Session["pono"] = button.CommandArgument;
        this.Session["Param"] = "PONO";
        this.runjQueryCode("window.open('Report_Merchandising/Smt_MerchandisingReport.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
    }

    protected void btnPrintForApp_Click(object sender, System.EventArgs e)
    {
        C1GridViewRow parent = ((LinkButton)sender).Parent.Parent as C1GridViewRow;
        LinkButton button = (LinkButton)parent.FindControl("btnPrintForApp");
        this.Session["pono"] = button.CommandArgument;
        this.Session["Param"] = "PONO";
        this.runjQueryCode("window.open('Report_Merchandising/Smt_MerchandisingReport.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
    }

    protected void btnPrintpoconfirm_Click(object sender, System.EventArgs e)
    {
        C1GridViewRow parent = ((LinkButton)sender).Parent.Parent as C1GridViewRow;
        string str = parent.Cells[3].Text.Trim();
        this.Session["pono"] =  str;
        this.Session["Param"] = "PONO";
        this.runjQueryCode("window.open('Report_Merchandising/Smt_MerchandisingReport.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
    }

    protected void btnPrintRevised_Click(object sender, System.EventArgs e)
    {
        C1GridViewRow parent = ((LinkButton)sender).Parent.Parent as C1GridViewRow;
        LinkButton button = (LinkButton)parent.FindControl("btnPrintRevised");
        this.Session["pono"] = button.CommandArgument;
        this.Session["Param"] = "PONO";
        this.runjQueryCode("window.open('Report_Merchandising/Smt_MerchandisingReport.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
    }

    protected void btnRevised_Click(object sender, System.EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        this.cn.Open();
        System.Data.SqlClient.SqlTransaction transaction = this.cn.BeginTransaction();
        try
        {
            if (this.grdApproved.Rows.Count > 0)
            {
                for (int i = 0; i < this.grdApproved.Rows.Count; i = (int)(i + 1))
                {
                    CheckBox box = (CheckBox)this.grdApproved.Rows[i].FindControl("chkSelect");
                    if (box.Checked)
                    {
                        Label label2 = (Label)this.grdApproved.Rows[i].FindControl("lblPO");
                        string[] strArray = new string[] { "@PONO", "@revuser" };
                        string[] strArray2 = new string[] { label2.Text.Trim(), this.Session["Uid"].ToString() };
                        this._mc.MC_Save_nodt_tr("Sp_Smt_BOM_PORevise", this.cn, transaction, strArray, strArray2);
                    }
                }
            }
            transaction.Commit();
            label.Text = ("Revised Successfully");
            //this.bindapprove();
            //this.bindrevised();
        }
        catch (System.Exception exception)
        {
            transaction.Rollback();
            label.Text = (exception.Message);
        }
        finally
        {
            this.cn.Close();
        }
    }

    protected void btnReviseForApp_Click(object sender, System.EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        this.cn.Open();
        System.Data.SqlClient.SqlTransaction transaction = this.cn.BeginTransaction();
        try
        {
            if (this.grdForApproval.Rows.Count > 0)
            {
                for (int i = 0; i < this.grdForApproval.Rows.Count; i = (int)(i + 1))
                {
                    CheckBox box = (CheckBox)this.grdForApproval.Rows[i].FindControl("chkSelectforApp");
                    if (box.Checked)
                    {
                        string str = this.grdForApproval.Rows[i].Cells[3].Text.Trim();
                        string[] strArray = new string[] { "@PONO", "@revuser" };
                        string[] strArray2 = new string[] { str.Trim(), this.Session["Uid"].ToString() };
                        this._mc.MC_Save_nodt_tr("Sp_Smt_BOM_PORevise", this.cn, transaction, strArray, strArray2);
                    }
                }
            }
            transaction.Commit();
            label.Text = ("Revised Successfully");
            //this.bindforapproval();
            //this.bindapprove();
            //this.bindrevised();
        }
        catch (System.Exception)
        {
            transaction.Rollback();
            label.Text = ("Unable to Revise");
        }
        finally
        {
            this.cn.Close();
        }
    }

    protected void btnViewAprv_Click(object sender, System.EventArgs e)
    {
        this.grdDisPODtl.DataSource = null;
        this.grdDisPODtl.DataBind();
        C1GridViewRow parent = ((LinkButton)sender).Parent.Parent as C1GridViewRow;
        LinkButton button = (LinkButton)parent.FindControl("btnViewAprv");
        this.viewPODtl (int.Parse(button.CommandArgument));
    }

    protected void btnViewCanceled_Click(object sender, System.EventArgs e)
    {
        this.grdDisPODtl.DataSource =null;
        this.grdDisPODtl.DataBind();
        C1GridViewRow parent = ((LinkButton)sender).Parent.Parent as C1GridViewRow;
        LinkButton button = (LinkButton)parent.FindControl("btnViewCanceled");
        this.viewPODtl(int.Parse(button.CommandArgument));
    }

    protected void btnViewForApp_Click(object sender, System.EventArgs e)
    {
        this.grdDisPODtl.DataSource =null;
        this.grdDisPODtl.DataBind();
        C1GridViewRow parent = ((LinkButton)sender).Parent.Parent as C1GridViewRow;
        LinkButton button = (LinkButton)parent.FindControl("btnViewForApp");
        parent.Cells[3].Text.Trim();
        this.viewPODtl(int.Parse(button.CommandArgument));
    }

    protected void btnViewRevised_Click(object sender, System.EventArgs e)
    {
        this.grdDisPODtl.DataSource =null;
        this.grdDisPODtl.DataBind();
        C1GridViewRow parent = ((LinkButton)sender).Parent.Parent as C1GridViewRow;
        LinkButton button = (LinkButton)parent.FindControl("btnViewRevised");
        this.viewPODtl(int.Parse(button.CommandArgument));
    }

    public void execmail(string user, int pono, int supplier, string attachfile)
    {
        System.Data.SqlClient.SqlConnection connection = GetWay.SpecFo_Inventorycon;
        System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand("Sp_Smt_POHeader_Sendmail", connection);
        if (connection.State == System.Data.ConnectionState.Closed)
        {
            connection.Open();
        }
        command.CommandType = (System.Data.CommandType.StoredProcedure);
        command.Parameters.AddWithValue("@UserId", user);
        command.Parameters.AddWithValue("@PONO", (int)pono);
        command.Parameters.AddWithValue("@SupplierID", (int)supplier);
        command.Parameters.AddWithValue("@Attachfile", attachfile);
        command.ExecuteNonQuery();
        if (connection.State == System.Data.ConnectionState.Open)
        {
            connection.Close();
        }
    }

    private string getjQueryCode(string jsCodetoRun)
    {
        System.Text.StringBuilder builder = new System.Text.StringBuilder();
        builder.AppendLine("$(document).ready(function() {");
        builder.AppendLine(jsCodetoRun);
        builder.AppendLine(" });");
        return builder.ToString();
    }

    protected void grdApproved_Filtering(object sender, C1GridViewFilterEventArgs e)
    {
        //this.bindapprove();
    }

    protected void grdApproved_PageIndexChanging(object sender, C1GridViewPageEventArgs e)
    {
        this.grdApproved.PageIndex = (e.NewPageIndex);
        //this.bindapprove();
    }

    protected void grdApproved_RowDataBound(object sender, C1GridViewRowEventArgs e)
    {
        if (e.Row.RowType == C1GridViewRowType.DataRow)
        {
            Label label = (Label)e.Row.FindControl("lblPO");
            CheckBox box = (CheckBox)e.Row.FindControl("chkSelect");
            LinkButton button1 = (LinkButton)e.Row.FindControl("btnEmail");
            System.Data.DataTable table = this.blInventory.get_InformationdataTable("select nOrderType from Smt_POHedder where nPoNum=" + label.Text);
            if ((table.Rows.Count > 0) && !string.IsNullOrEmpty(table.Rows[0]["nOrderType"].ToString()))
            {
                e.Row.Attributes.Add("style", "color:#21BAF3;border:1px solid white;font-weight:bold;font-style:italic");
                e.Row.ToolTip = ("Other Booking");
            }
            if (this.blInventory.get_InformationdataTable("select nPoNum from Smt_GoodReceived where nPoNum=" + label.Text + " and bApp=1").Rows.Count > 0)
            {
                box.Enabled = (false);
                e.Row.ForeColor = (Color.Red);
                e.Row.ToolTip = ("GRN Completed for this PO");
            }
        }
    }

    protected void grdCanceled_Filtering(object sender, C1GridViewFilterEventArgs e)
    {
        //this.bindcanceled();
    }

    protected void grdCanceled_PageIndexChanging(object sender, C1GridViewPageEventArgs e)
    {
        this.grdCanceled.PageIndex = (e.NewPageIndex);
        //this.bindcanceled();
    }

    protected void grdCanceled_RowDataBound(object sender, C1GridViewRowEventArgs e)
    {
        if (e.Row.RowType == C1GridViewRowType.DataRow)
        {
            System.Data.DataTable table = this.blInventory.get_InformationdataTable("select nOrderType from Smt_POHedder where nPoNum=" + e.Row.Cells[2].Text.Trim());
            if ((table.Rows.Count > 0) && !string.IsNullOrEmpty(table.Rows[0]["nOrderType"].ToString()))
            {
                e.Row.Attributes.Add("style", "color:#21BAF3;border:1px solid white;font-weight:bold;font-style:italic");
                e.Row.ToolTip = ("Other Booking");
            }
        }
    }

    protected void grdConfirmToApprove_Filtering(object sender, C1GridViewFilterEventArgs e)
    {
        this.bindconfirmtoapprove();
    }

    protected void grdConfirmToApprove_PageIndexChanging(object sender, C1GridViewPageEventArgs e)
    {
        this.grdConfirmToApprove.PageIndex = (e.NewPageIndex);
        this.bindconfirmtoapprove();
    }

    protected void grdConfirmToApprove_RowDataBound(object sender, C1GridViewRowEventArgs e)
    {
        if (e.Row.RowType == C1GridViewRowType.DataRow)
        {
            System.Data.DataTable table = this.blInventory.get_InformationdataTable("select nOrderType from Smt_POHedder where nPoNum=" + e.Row.Cells[3].Text.Trim());
            if ((table.Rows.Count > 0) && !string.IsNullOrEmpty(table.Rows[0]["nOrderType"].ToString()))
            {
                e.Row.Attributes.Add("style", "color:#21BAF3;border:1px solid white;font-weight:bold;font-style:italic");
                e.Row.ToolTip = ("Other Booking");
            }
        }
    }

    protected void grdDisPODtl_PreRender(object sender, System.EventArgs e)
    {
        MergePOConfrimPODtl(this.grdDisPODtl);
    }

    protected void grdForApproval_Filtering(object sender, C1GridViewFilterEventArgs e)
    {
        //this.bindforapproval();
    }

    protected void grdForApproval_PageIndexChanging(object sender, C1GridViewPageEventArgs e)
    {
        this.grdForApproval.PageIndex = (e.NewPageIndex);
        //this.bindforapproval();
    }

    protected void grdForApproval_RowDataBound(object sender, C1GridViewRowEventArgs e)
    {
        if (e.Row.RowType == C1GridViewRowType.DataRow)
        {
            System.Data.DataTable table = this.blInventory.get_InformationdataTable("select nOrderType from Smt_POHedder where nPoNum=" + e.Row.Cells[3].Text.Trim());
            if ((table.Rows.Count > 0) && !string.IsNullOrEmpty(table.Rows[0]["nOrderType"].ToString()))
            {
                e.Row.Attributes.Add("style", "color:#21BAF3;border:1px solid white;font-weight:bold;font-style:italic");
                e.Row.ToolTip = ("Other Booking");
            }
        }
    }

    protected void grdPORevised_Filtering(object sender, C1GridViewFilterEventArgs e)
    {
        //this.bindrevised();
    }

    protected void grdPORevised_PageIndexChanging(object sender, C1GridViewPageEventArgs e)
    {
        this.grdPORevised.PageIndex = (e.NewPageIndex);
        //this.bindrevised();
    }

    protected void grdPORevised_RowDataBound(object sender, C1GridViewRowEventArgs e)
    {
        if (e.Row.RowType == C1GridViewRowType.DataRow)
        {
            System.Data.DataTable table = this.blInventory.get_InformationdataTable("select nOrderType from Smt_POHedder where nPoNum=" + e.Row.Cells[2].Text.Trim());
            if ((table.Rows.Count > 0) && !string.IsNullOrEmpty(table.Rows[0]["nOrderType"].ToString()))
            {
                e.Row.Attributes.Add("style", "color:#21BAF3;border:1px solid white;font-weight:bold;font-style:italic");
                e.Row.ToolTip = ("Other Booking");
            }
        }
    }

    public bool IsConnectedToInternet()
    {
        string str = "www.google.com";
        bool flag = false;
        Ping ping = new Ping();
        try
        {
            if (ping.Send(str, 0xbb8).Status == IPStatus.Success)
            {
                flag = true;
            }
        }
        catch
        {
        }
        return flag;
    }

    public static void MergePOConfrimPODtl(GridView gridView)
    {
        for (int i = (int)(gridView.Rows.Count - 2); i >= 0; i = (int)(i - 1))
        {
            GridViewRow row = gridView.Rows[i];
            GridViewRow row2 = gridView.Rows[(int)(i + 1)];
            if (row.Cells[0].Text == row2.Cells[0].Text)
            {
                row.Cells[0].RowSpan = ((row2.Cells[0].RowSpan < 2) ? ((int)2) : ((int)(row2.Cells[0].RowSpan + 1)));
                row2.Cells[0].Visible = false;
            }
            if (row.Cells[1].Text == row2.Cells[1].Text)
            {
                row.Cells[1].RowSpan = ((row2.Cells[1].RowSpan < 2) ? ((int)2) : ((int)(row2.Cells[1].RowSpan + 1)));
                row2.Cells[1].Visible = false;
            }
            if (row.Cells[2].Text == row2.Cells[2].Text)
            {
                row.Cells[2].RowSpan = ((row2.Cells[2].RowSpan < 2) ? ((int)2) : ((int)(row2.Cells[2].RowSpan + 1)));
                row2.Cells[2].Visible = false;
            }
        }
    }

    protected void Page_Load(object sender, System.EventArgs e)
    {
        if (this.Session["Uid"] == null)
        {
            base.Response.Redirect("Smt_Login.aspx", false);
        }
        else if (!base.IsPostBack)
        {
            Control[] controlArray = new Control[] { this.btnCnfApprove, this.btnConCancel, this.txtApproval, this.btnReviseForApp, this.btnRevised };
            Control[] controlArray2 = new Control[0];
            this.mycls.SetBtnPermission(this.Session["Uid"].ToString(), controlArray, controlArray2, "Smt_Mer_POApproval.aspx");
            this.bindconfirmtoapprove();
            //this.bindforapproval();
            //this.bindapprove();
            //this.bindrevised();
            //this.bindcanceled();
            //if (base.Request.QueryString["tb"] == "2")
            //{
            //    this.C1TabControl1.MoveNext();
            //}
        }
    }

    private void runjQueryCode(string jsCodetoRun)
    {
        ScriptManager current = ScriptManager.GetCurrent(this);
        if ((current != null) && current.IsInAsyncPostBack)
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(Page), System.Guid.NewGuid().ToString(), this.getjQueryCode(jsCodetoRun), true);
        }
        else
        {
            base.ClientScript.RegisterClientScriptBlock(typeof(Page), System.Guid.NewGuid().ToString(), this.getjQueryCode(jsCodetoRun), true);
        }
    }

    public void Sentmail_supplier(int PONO, int sup)
    {
        ReportDocument document = new ReportDocument();
        string str = base.Server.MapPath("rptsv/");
        Merchandising merchandising = new Merchandising();
        string val = this._bll.get_Informationdataset("select cCmpName from Smt_Company where Display_AS_Header=1").Tables[0].Rows[0]["cCmpName"].ToString();
        new System.Data.DataTable().TableName = "PO_Printing";
        System.Data.DataTable table = this.blInventory.get_InformationdataTable("Sp_Smt_POPrinting " + ((int)PONO));
        //merchandising.Tables.get_Item("PO_Printing").Merge(table);

        merchandising.Tables["PO_Printing"].Merge(table);

        document.Load(base.Server.MapPath("Report_Merchandising/CrystalReport2.rpt"));
        document.SetDataSource((System.Data.DataSet)merchandising);
        document.SetParameterValue("cCmpName", val);
        System.IO.MemoryStream stream1 = (System.IO.MemoryStream)document.ExportToStream(ExportFormatType.PortableDocFormat);
        base.Response.Clear();
        ContentType type = new ContentType();
        base.Response.Buffer = true;
        type.MediaType = ("application/pdf");
        string fileName = str + ((int)PONO) + ".pdf";
        document.ExportToDisk(ExportFormatType.PortableDocFormat, fileName);
        this.execmail(this.Session["Uid"].ToString(), PONO, sup, base.Server.MapPath("rptsv/") + ((int)PONO) + ".pdf");
        if (System.IO.File.Exists(fileName))
        {
            System.IO.File.Delete(fileName);
        }
    }

    public void Sm_Em_L(int PONO, string Supplieremail, string supname)
    {
        this._bll.get_InformationdataTable("select Email from Smt_Users where cUserName='" + this.Session["Uid"].ToString() + "'").Rows[0]["Email"].ToString();
        ReportDocument document = new ReportDocument();
        string str = base.Server.MapPath("rptsv/");
        Merchandising merchandising = new Merchandising();
        string val = this._bll.get_Informationdataset("select cCmpName from Smt_Company where Display_AS_Header=1").Tables[0].Rows[0]["cCmpName"].ToString();
        new System.Data.DataTable().TableName = ("PO_Printing");
        System.Data.DataTable table2 = this.blInventory.get_InformationdataTable("Sp_Smt_POPrinting " + ((int)PONO));
        merchandising.Tables["PO_Printing"].Merge(table2);
        document.Load(base.Server.MapPath("Report_Merchandising/CrystalReport2.rpt"));
        document.SetDataSource((System.Data.DataSet)merchandising);
        document.SetParameterValue("cCmpName", val);
        System.IO.MemoryStream stream1 = (System.IO.MemoryStream)document.ExportToStream(ExportFormatType.PortableDocFormat);
        base.Response.Clear();
        ContentType type = new ContentType();
        base.Response.Buffer = true;
        type.MediaType = ("application/pdf");
        string fileName = string.Concat((object[])new object[] { str, supname, "_", ((int)PONO), ".pdf" });
        if (System.IO.File.Exists(fileName))
        {
            System.IO.File.Delete(fileName);
        }
        document.ExportToDisk(ExportFormatType.PortableDocFormat, fileName);
    }

    protected void txtApproval_Click(object sender, System.EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        if (this.grdForApproval.Rows.Count > 0)
        {
            for (int i = 0; i < this.grdForApproval.Rows.Count; i = (int)(i + 1))
            {
                string str = this.grdForApproval.Rows[i].Cells[3].Text.Trim();
                CheckBox box = (CheckBox)this.grdForApproval.Rows[i].FindControl("chkSelectforApp");
                if (box.Checked)
                {
                    this.dlInventory.PO_ForApprove(int.Parse(str), this.Session["Uid"].ToString());
                    this.forApp = (int)(this.forApp + 1);
                }
            }
            if (this.forApp > 0)
            {
                label.Text = (((int)this.forApp) + " PO For Approve");
            }
            else
            {
                label.Text = ("First Check PO For Approve");
            }
        }
        //this.bindforapproval();
        ////this.bindapprove();
    }

    public void viewPODtl(int pono)
    {
        this.grdDisPODtl.DataSource = (this.blInventory.get_Informationdataset("Sp_Smt_POPrinting '" + ((int)pono) + "'"));
        this.grdDisPODtl.DataBind();
        this.lblModlHdr.Text = ("Purchase Order Detail - PO No " + ((int)pono).ToString());
        this.runjQueryCode("$('.poview').live('click', function (e) {");
        this.runjQueryCode("e.preventDefault();");
        this.runjQueryCode("$('.POPUPPanel').hide();");
        this.runjQueryCode("$('.POPUPPanel').toggle('slow');");
        this.runjQueryCode("return false;})");
    }

    //protected global_asax ApplicationInstance
    //{
    //    get
    //    {
    //        return (global_asax)this.Context.ApplicationInstance;
    //    }
    //}

    //protected DefaultProfile Profile
    //{
    //    get
    //    {
    //        return (DefaultProfile)this.Context.Profile;
    //    }
    //}

    protected void btnconfirmtoapp_Click(object sender, EventArgs e)
    {

    }
}
