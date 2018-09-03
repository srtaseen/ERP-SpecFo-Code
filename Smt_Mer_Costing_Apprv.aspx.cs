using ASP;
using C1.Web.UI.Controls.C1GridView;
using C1.Web.UI.Controls.C1TabControl;
using System;
using System.Data.SqlClient;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Smt_Mer_Costing_Apprv : System.Web.UI.Page
{
    private BLLInventory _blinventory = new BLLInventory();
    private MC _mc = new MC();
    //protected Button btnApprove;
    //protected Button btnReject;
    //protected Button btnrework;
    //protected C1.Web.UI.Controls.C1TabControl.C1TabControl C1TabControl1;
    //protected C1TabPage C1TabPage1;
    //protected C1TabPage C1TabPage2;
    //protected C1TabPage C1TabPage3;
    private SqlConnection cn = GetWay.SpecFo_Inventorycon;
    //protected C1.Web.UI.Controls.C1GridView.C1GridView grdApproved;
    //protected C1.Web.UI.Controls.C1GridView.C1GridView grdCncl;
    //protected C1.Web.UI.Controls.C1GridView.C1GridView grdForapp;
    private DAL mycls = new DAL();
    //protected UpdatePanel updcostappv;

    public void bindAppv()
    {
        this.grdApproved.DataSource = this._blinventory.get_InformationdataTable("Sp_Smt_NZ_Cost_Mast_getApproved");
        this.grdApproved.DataBind();
    }

    public void bindcncl()
    {
        this.grdCncl.DataSource = this._blinventory.get_InformationdataTable("Sp_Smt_NZ_Cost_Mast_getRejected");
        this.grdCncl.DataBind();
    }

    public void bindforapp()
    {
        this.grdForapp.DataSource = this._blinventory.get_InformationdataTable("Sp_Smt_NZ_Cost_Mast_getAll");
        this.grdForapp.DataBind();
    }

    protected void btnApprove_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        this.cn.Open();
        SqlTransaction tr = this.cn.BeginTransaction();
        try
        {
            if (this.grdForapp.Rows.Count > 0)
            {
                for (int i = 0; i < this.grdForapp.Rows.Count; i++)
                {
                    Label label2 = (Label)this.grdForapp.Rows[i].FindControl("lblponoforapp");
                    CheckBox box = (CheckBox)this.grdForapp.Rows[i].FindControl("chkSelectforappv");
                    string[] normalparam = new string[] { "@StyleID", "@Usr" };
                    string[] normalprmval = new string[] { label2.Text.Trim(), this.Session["Uid"].ToString().ToUpper() };
                    if (box.Checked)
                    {
                        this._mc.MC_Save_nodt_tr("Sp_Smt_NZ_Cost_Mst_Appv", this.cn, tr, normalparam, normalprmval);
                    }
                }
            }
            tr.Commit();
            this.bindforapp();
            this.bindAppv();
            label.Text = "Approved Successfully";
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

    protected void btnReject_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        this.cn.Open();
        SqlTransaction tr = this.cn.BeginTransaction();
        try
        {
            if (this.grdForapp.Rows.Count > 0)
            {
                for (int i = 0; i < this.grdForapp.Rows.Count; i++)
                {
                    Label label2 = (Label)this.grdForapp.Rows[i].FindControl("lblponoforapp");
                    CheckBox box = (CheckBox)this.grdForapp.Rows[i].FindControl("chkSelectforappv");
                    string[] normalparam = new string[] { "@StyleID", "@Usr" };
                    string[] normalprmval = new string[] { label2.Text.Trim(), this.Session["Uid"].ToString().ToUpper() };
                    if (box.Checked)
                    {
                        this._mc.MC_Save_nodt_tr("Sp_Smt_NZ_Cost_Mst_Reject", this.cn, tr, normalparam, normalprmval);
                    }
                }
            }
            tr.Commit();
            this.bindforapp();
            this.bindAppv();
            this.bindcncl();
            label.Text = "Rejected";
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

    protected void btnrework_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        this.cn.Open();
        SqlTransaction tr = this.cn.BeginTransaction();
        try
        {
            if (this.grdApproved.Rows.Count > 0)
            {
                for (int i = 0; i < this.grdApproved.Rows.Count; i++)
                {
                    Label label2 = (Label)this.grdApproved.Rows[i].FindControl("lblstlidappv");
                    CheckBox box = (CheckBox)this.grdApproved.Rows[i].FindControl("chkSelectapv");
                    string[] normalparam = new string[] { "@StyleID", "@Usr" };
                    string[] normalprmval = new string[] { label2.Text.Trim(), this.Session["Uid"].ToString().ToUpper() };
                    if (box.Checked)
                    {
                        this._mc.MC_Save_nodt_tr("Sp_Smt_NZ_Cost_Mst_Rework", this.cn, tr, normalparam, normalprmval);
                    }
                }
            }
            tr.Commit();
            this.bindforapp();
            this.bindAppv();
            this.bindcncl();
            label.Text = "OK";
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

    protected void grdApproved_Filtering(object sender, C1GridViewFilterEventArgs e)
    {
        this.bindAppv();
    }

    protected void grdApproved_PageIndexChanging(object sender, C1GridViewPageEventArgs e)
    {
        this.grdApproved.PageIndex = e.NewPageIndex;
        this.bindAppv();
    }

    protected void grdCncl_Filtering(object sender, C1GridViewFilterEventArgs e)
    {
        this.bindcncl();
    }

    protected void grdCncl_PageIndexChanging(object sender, C1GridViewPageEventArgs e)
    {
        this.grdCncl.PageIndex = e.NewPageIndex;
        this.bindcncl();
    }

    protected void grdForapp_Filtering(object sender, C1GridViewFilterEventArgs e)
    {
        this.bindforapp();
    }

    protected void grdForapp_PageIndexChanging(object sender, C1GridViewPageEventArgs e)
    {
        this.grdForapp.PageIndex = e.NewPageIndex;
        this.bindforapp();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!base.IsPostBack)
        {
            this.bindforapp();
            this.bindAppv();
            this.bindcncl();
            Control[] btnall = new Control[] { this.btnApprove, this.btnReject, this.btnrework };
            Control[] addbtn = new Control[0];
            this.mycls.SetBtnPermission(this.Session["Uid"].ToString(), btnall, addbtn, "Smt_Mer_Costing_Apprv.aspx");
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
