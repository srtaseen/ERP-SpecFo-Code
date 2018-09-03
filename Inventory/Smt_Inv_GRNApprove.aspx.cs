using AjaxControlToolkit;
using ASP;
using C1.Web.UI.Controls.C1GridView;
using C1.Web.UI.Controls.C1TabControl;
using System;
using System.Text;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Inventory_Smt_Inv_GRNApprove : System.Web.UI.Page
{
    private DAL _mycls = new DAL();
    private BLLInventory blinventory = new BLLInventory();
    //protected Button btnApprove;
    //protected ConfirmButtonExtender btnApprove_ConfirmButtonExtender;
    //protected Button btnCancel;
    //protected ConfirmButtonExtender btnCancel_ConfirmButtonExtender;
    //protected Button btnppgntpo;
    //protected Button btnRefreshforapp;
    //protected Button btnRevise;
    //protected ConfirmButtonExtender btnRevise_ConfirmButtonExtender;
    //protected ModalPopupExtender Button2_ModalPopupExtender;
    //protected C1.Web.UI.Controls.C1GridView.C1GridView C1GridView1;
    //protected C1.Web.UI.Controls.C1TabControl.C1TabControl C1TabControl1;
    //protected C1TabPage C1TabPage1;
    //protected C1TabPage C1TabPage2;
    //protected C1TabPage C1TabPage3;
    private DALInventory dlinventory = new DALInventory();
    //protected C1.Web.UI.Controls.C1GridView.C1GridView grdApproveGrn;
    //protected C1.Web.UI.Controls.C1GridView.C1GridView grdCancel;
    //protected UpdatePanel UpdatePanel1;
    //protected UpdatePanel UpdatePanel2;
    //protected UpdatePanel UpdatePanel3;
    //protected UpdatePanel UpdatePanel4;

    public void bindApproved()
    {
        this.C1GridView1.DataSource = this.blinventory.get_InformationdataTable("Sp_Smt_GoodReceived_GetApproved '" + this.Session["Uid"].ToString() + "'");
        this.C1GridView1.DataBind();
    }

    public void bindcancel()
    {
        this.grdCancel.DataSource = this.blinventory.get_InformationdataTable("Sp_Smt_GoodReceived_GetCancelled '" + this.Session["Uid"].ToString() + "'");
        this.grdCancel.DataBind();
    }

    public void bindForapprove()
    {
        this.grdApproveGrn.DataSource = this.blinventory.get_InformationdataTable("Sp_Smt_GoodReceived_GetForApprove '" + this.Session["Uid"].ToString() + "'");
        this.grdApproveGrn.DataBind();
    }

    protected void btnApprove_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        int num = 0;
        for (int i = 0; i < this.grdApproveGrn.Rows.Count; i++)
        {
            CheckBox box = (CheckBox)this.grdApproveGrn.Rows[i].FindControl("chkSelect");
            if (box.Checked)
            {
                Label label2 = (Label)this.grdApproveGrn.Rows[i].FindControl("lblGrnno");
                this.dlinventory.Save_GRNApproval(int.Parse(label2.Text), this.Session["Uid"].ToString());
                num++;
            }
        }
        if (num > 0)
        {
            label.Text = "Saved Successfully";
            this.bindForapprove();
            this.bindApproved();
        }
        else
        {
            label.Text = "First Select GRN No";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Label lbl = (Label)base.Master.FindControl("lbltotalinfo");
        int num = 0;
        for (int i = 0; i < this.grdApproveGrn.Rows.Count; i++)
        {
            CheckBox box = (CheckBox)this.grdApproveGrn.Rows[i].FindControl("chkSelect");
            Label label2 = (Label)this.grdApproveGrn.Rows[i].FindControl("lblPONO");
            if (box.Checked)
            {
                Label label3 = (Label)this.grdApproveGrn.Rows[i].FindControl("lblGrnno");
                this.dlinventory.Save_GRNCancel(int.Parse(label3.Text), this.Session["Uid"].ToString(), label2.Text.Trim(), lbl);
                num++;
            }
        }
        if (num > 0)
        {
            lbl.Text = "Cancelled Successfully";
            this.bindForapprove();
            this.bindcancel();
        }
        else
        {
            lbl.Text = "First Select GRN No";
        }
    }

    protected void btnRefreshforapp_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.bindForapprove();
    }

    protected void btnRevise_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        int num = 0;
        if (this.C1GridView1.Rows.Count > 0)
        {
            for (int i = 0; i < this.C1GridView1.Rows.Count; i++)
            {
                Label label2 = (Label)this.C1GridView1.Rows[i].FindControl("lblGrnnoApproved");
                Label label1 = (Label)this.C1GridView1.Rows[i].FindControl("lblpoappv");
                CheckBox box = (CheckBox)this.C1GridView1.Rows[i].FindControl("chkSelect");
                if (box.Checked)
                {
                    this.dlinventory.Save_GRNRevise(int.Parse(label2.Text), this.Session["Uid"].ToString());
                    num++;
                }
            }
        }
        if (num > 0)
        {
            label.Text = "Grn Revised Successfully";
            this.bindApproved();
            this.bindForapprove();
        }
        else
        {
            label.Text = "First Select GRN NO";
        }
    }

    protected void C1GridView1_Filtering(object sender, C1GridViewFilterEventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.bindApproved();
    }

    protected void C1GridView1_PageIndexChanging(object sender, C1GridViewPageEventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.C1GridView1.PageIndex = e.NewPageIndex;
        this.bindApproved();
    }

    protected void C1GridView1_RowDataBound(object sender, C1GridViewRowEventArgs e)
    {
        if (e.Row.RowType == C1GridViewRowType.DataRow)
        {
            Label label = (Label)e.Row.FindControl("lblGrnnoApproved");
            if (this.blinventory.get_InformationdataTable("select Recvtype from Smt_GoodReceived where nGrnNo=" + label.Text.Trim()).Rows[0]["Recvtype"].ToString() == "F")
            {
                e.Row.Attributes.Add("style", "background-color:#EDFAEB;border-bottom:1px solid #B8E9AF; border-top:1px solid #B8E9AF");
                e.Row.ToolTip = "Factory GRN";
            }
            else
            {
                e.Row.Attributes.Add("style", "color:Black");
                e.Row.ToolTip = "Merchant GRN";
            }
        }
    }

    protected void C1GridView1_Sorting(object sender, C1GridViewSortEventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.bindApproved();
    }

    private string getjQueryCode(string jsCodetoRun)
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine("$(document).ready(function() {");
        builder.AppendLine(jsCodetoRun);
        builder.AppendLine(" });");
        return builder.ToString();
    }

    protected void grdApproveGrn_Filtering(object sender, C1GridViewFilterEventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.bindForapprove();
    }

    protected void grdApproveGrn_PageIndexChanging(object sender, C1GridViewPageEventArgs e)
    {
        this.grdApproveGrn.PageIndex = e.NewPageIndex;
        this.bindForapprove();
    }

    protected void grdApproveGrn_RowDataBound(object sender, C1GridViewRowEventArgs e)
    {
        if (e.Row.RowType == C1GridViewRowType.DataRow)
        {
            Label label = (Label)e.Row.FindControl("lblGrnno");
            if (this.blinventory.get_InformationdataTable("select Recvtype from Smt_GoodReceived where nGrnNo=" + label.Text.Trim()).Rows[0]["Recvtype"].ToString() == "F")
            {
                e.Row.Attributes.Add("style", "background-color:#EDFAEB;border-bottom:1px solid #B8E9AF; border-top:1px solid #B8E9AF");
                e.Row.ToolTip = "Factory GRN";
            }
            else
            {
                e.Row.Attributes.Add("style", "color:Black");
                e.Row.ToolTip = "Merchant GRN";
            }
        }
    }

    protected void grdApproveGrn_Sorting(object sender, C1GridViewSortEventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.bindForapprove();
    }

    protected void grdCancel_Filtering(object sender, C1GridViewFilterEventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.bindcancel();
    }

    protected void grdCancel_PageIndexChanging(object sender, C1GridViewPageEventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.grdCancel.PageIndex = e.NewPageIndex;
        this.bindcancel();
    }

    protected void grdCancel_RowDataBound(object sender, C1GridViewRowEventArgs e)
    {
    }

    protected void grdCancel_Sorting(object sender, C1GridViewSortEventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.bindcancel();
    }

    protected void grdRevised_RowDataBound(object sender, C1GridViewRowEventArgs e)
    {
        if (e.Row.RowType == C1GridViewRowType.DataRow)
        {
            Label label = (Label)e.Row.FindControl("lblGrnnorevised");
            if (this.blinventory.get_InformationdataTable("select Recvtype from Smt_GoodReceived where nGrnNo=" + label.Text.Trim()).Rows[0]["Recvtype"].ToString() == "F")
            {
                e.Row.Attributes.Add("style", "color:green");
                e.Row.ToolTip = "Factory GRN";
            }
            else
            {
                e.Row.Attributes.Add("style", "color:Black");
                e.Row.ToolTip = "Merchant GRN";
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

    protected void lnkprintapproved_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        C1GridViewRow parent = ((LinkButton)sender).Parent.Parent as C1GridViewRow;
        LinkButton button = (LinkButton)parent.FindControl("lnkprintapproved");
        this.Session["GRNNO"] = button.CommandArgument;
        this.Session["Param"] = "GRNNO";
        this.runjQueryCode("window.open('Smt_Inv_ReportDisplay.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
    }

    protected void lnkprintrevised_Click(object sender, EventArgs e)
    {
        C1GridViewRow parent = ((LinkButton)sender).Parent.Parent as C1GridViewRow;
        LinkButton button = (LinkButton)parent.FindControl("lnkprintrevised");
        this.Session["GRNNO"] = button.CommandArgument;
        this.Session["Param"] = "GRNNO";
        this.runjQueryCode("window.open('Smt_Inv_ReportDisplay.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
    }

    public static void MergePOConfrimPODtl(GridView gridView)
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
            if (row.Cells[1].Text == row2.Cells[1].Text)
            {
                row.Cells[1].RowSpan = (row2.Cells[1].RowSpan < 2) ? 2 : (row2.Cells[1].RowSpan + 1);
                row2.Cells[1].Visible = false;
            }
            if (row.Cells[2].Text == row2.Cells[2].Text)
            {
                row.Cells[2].RowSpan = (row2.Cells[2].RowSpan < 2) ? 2 : (row2.Cells[2].RowSpan + 1);
                row2.Cells[2].Visible = false;
            }
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.Session["Uid"] == null)
        {
            base.Response.Redirect("../Smt_Login.aspx", false);
        }
        else if (!base.IsPostBack)
        {
            this.bindForapprove();
            this.bindApproved();
            Control[] btnall = new Control[] { this.btnApprove, this.btnRevise };
            Control[] addbtn = new Control[0];
            this.bindcancel();
            this._mycls.SetBtnPermission(this.Session["Uid"].ToString(), btnall, addbtn, "Smt_Inv_GRNApprove.aspx");
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