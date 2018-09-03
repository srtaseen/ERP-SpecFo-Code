using AjaxControlToolkit;
using ASP;
using C1.Web.UI.Controls.C1GridView;
using System;
using System.Data.SqlClient;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Smt_Mer_POApproval_3 : System.Web.UI.Page
{
   private BLLInventory _blinv = new BLLInventory();
    private MC _mc = new MC();
    //protected Button btnppgntpo;
    //protected Button btnRevise;
    //protected ModalPopupExtender Button2_ModalPopupExtender;
    private SqlConnection cn = GetWay.SpecFo_Inventorycon;
    //protected C1.Web.UI.Controls.C1GridView.C1GridView grdApproved;
    private DAL mycls = new DAL();
    //protected UpdatePanel UpdatePanel1;

    public void bindapprove()
    {
        this.grdApproved.DataSource = this._blinv.get_InformationdataTable("PO_GETAPPROVED '" + this.Session["Uid"].ToString() + "'");
        this.grdApproved.DataBind();
    }

    protected void btnRevise_Click(object sender, EventArgs e)
    {
        Label label = (Label) base.Master.FindControl("lbltotalinfo");
        this.cn.Open();
        SqlTransaction tr = this.cn.BeginTransaction();
        try
        {
            if (this.grdApproved.Rows.Count > 0)
            {
                for (int i = 0; i < this.grdApproved.Rows.Count; i++)
                {
                    CheckBox box = (CheckBox) this.grdApproved.Rows[i].FindControl("chkSelect");
                    if (box.Checked)
                    {
                        Label label2 = (Label) this.grdApproved.Rows[i].FindControl("lblPO");
                        string[] normalparam = new string[] { "@PONO", "@cncluser" };
                        string[] normalprmval = new string[] { label2.Text, this.Session["Uid"].ToString() };
                        this._mc.MC_Save_nodt_tr("PO_PORevise", this.cn, tr, normalparam, normalprmval);
                    }
                }
            }
            tr.Commit();
            label.Text = "Revised Successfully";
            this.bindapprove();
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
        this.bindapprove();
    }

    protected void grdApproved_PageIndexChanging(object sender, C1GridViewPageEventArgs e)
    {
        this.grdApproved.PageIndex = e.NewPageIndex;
        this.bindapprove();
    }

    protected void grdApproved_RowDataBound(object sender, C1GridViewRowEventArgs e)
    {
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!base.IsPostBack)
        {
            Control[] btnall = new Control[] { this.btnRevise };
            Control[] addbtn = new Control[0];
            this.mycls.SetBtnPermission(this.Session["Uid"].ToString(), btnall, addbtn, "Smt_Mer_POApproval_3.aspx");
            this.bindapprove();
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax) this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile) this.Context.Profile);
}
