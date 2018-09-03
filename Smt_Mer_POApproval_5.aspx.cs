using AjaxControlToolkit;
using ASP;
using C1.Web.UI.Controls.C1GridView;
using System;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Smt_Mer_POApproval_5 : System.Web.UI.Page
{
    private BLLInventory _blinv = new BLLInventory();
    //protected Button btnppgntpo;
    //protected ModalPopupExtender Button2_ModalPopupExtender;
    //protected C1.Web.UI.Controls.C1GridView.C1GridView grdPORevised;
    //protected UpdatePanel UpdatePanel1;

    public void bindrevised()
    {
        this.grdPORevised.DataSource = this._blinv.get_InformationdataTable("PO_GETREVISED '" + this.Session["Uid"].ToString() + "'");
        this.grdPORevised.DataBind();
    }

    protected void grdPORevised_Filtering(object sender, C1GridViewFilterEventArgs e)
    {
        this.bindrevised();
    }

    protected void grdPORevised_PageIndexChanging(object sender, C1GridViewPageEventArgs e)
    {
        this.grdPORevised.PageIndex = e.NewPageIndex;
        this.bindrevised();
    }

    protected void grdPORevised_RowDataBound(object sender, C1GridViewRowEventArgs e)
    {
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!base.IsPostBack)
        {
            this.bindrevised();
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
