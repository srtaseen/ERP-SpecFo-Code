using AjaxControlToolkit;
using ASP;
using C1.Web.UI.Controls.C1GridView;
using System;
using System.Data.SqlClient;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Smt_Mer_POApproval_2 : System.Web.UI.Page
{
    private BLLInventory _Blinv = new BLLInventory();
    private MC _mc = new MC();
    //protected Button btnApproved;
    //protected Button btnppgntpo;
    //protected Button btnRevise;
    //protected ModalPopupExtender Button2_ModalPopupExtender;
    private SqlConnection cn = GetWay.SpecFo_Inventorycon;
    //protected C1.Web.UI.Controls.C1GridView.C1GridView grdForApproval;
    private DAL mycls = new DAL();
    //protected UpdatePanel UpdatePanel1;


    public void bindforapproval()
    {
        this.grdForApproval.DataSource = this._Blinv.get_InformationdataTable("PO_GETFORAPPV '" + this.Session["Uid"].ToString() + "'");
        this.grdForApproval.DataBind();
    }

    protected void btnApproved_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        this.cn.Open();
        SqlTransaction tr = this.cn.BeginTransaction();
        try
        {
            if (this.grdForApproval.Rows.Count > 0)
            {
                for (int i = 0; i < this.grdForApproval.Rows.Count; i++)
                {
                    CheckBox box = (CheckBox)this.grdForApproval.Rows[i].FindControl("chkSelectforApp");
                    if (box.Checked)
                    {
                        Label label2 = (Label)this.grdForApproval.Rows[i].FindControl("lblPOno");
                        string[] normalparam = new string[] { "@PONO", "@cncluser" };
                        string[] normalprmval = new string[] { label2.Text, this.Session["Uid"].ToString() };
                        this._mc.MC_Save_nodt_tr("PO_FORAPPV", this.cn, tr, normalparam, normalprmval);
                    }
                }
            }
            tr.Commit();
            label.Text = "Approved Successfully";
            this.bindforapproval();
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

    protected void btnRevise_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        this.cn.Open();
        SqlTransaction tr = this.cn.BeginTransaction();
        try
        {
            if (this.grdForApproval.Rows.Count > 0)
            {
                for (int i = 0; i < this.grdForApproval.Rows.Count; i++)
                {
                    CheckBox box = (CheckBox)this.grdForApproval.Rows[i].FindControl("chkSelectforApp");
                    if (box.Checked)
                    {
                        string str = this.grdForApproval.Rows[i].Cells[3].Text.Trim();
                        string[] normalparam = new string[] { "@PONO", "@cncluser" };
                        string[] normalprmval = new string[] { str.Trim(), this.Session["Uid"].ToString() };
                        this._mc.MC_Save_nodt_tr("PO_PORevise", this.cn, tr, normalparam, normalprmval);
                    }
                }
            }
            tr.Commit();
            label.Text = "Revised Successfully";
            this.bindforapproval();
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

    protected void grdForApproval_Filtering(object sender, C1GridViewFilterEventArgs e)
    {
        this.bindforapproval();
    }

    protected void grdForApproval_PageIndexChanging(object sender, C1GridViewPageEventArgs e)
    {
        this.grdForApproval.PageIndex = e.NewPageIndex;
        this.bindforapproval();
    }

    protected void grdForApproval_RowDataBound(object sender, C1GridViewRowEventArgs e)
    {
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!base.IsPostBack)
        {
            this.bindforapproval();
            Control[] btnall = new Control[] { this.btnApproved, this.btnRevise };
            Control[] addbtn = new Control[0];
            this.mycls.SetBtnPermission(this.Session["Uid"].ToString(), btnall, addbtn, "Smt_Mer_POApproval_2.aspx");
        }
    }

    //protected global_asax ApplicationInstance =>
    //   ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}