using ASP;
using C1.Web.UI.Controls.C1GridView;
using System;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;

public partial class Smt_StylemasterOMS : System.Web.UI.Page
{
    private BLL _mybl = new BLL();
    //protected C1.Web.UI.Controls.C1GridView.C1GridView grdConfirmToApprove;

    public void bind()
    {
        this.grdConfirmToApprove.DataSource = this._mybl.get_InformationdataTable("Sp_Smt_StyleMaster_OMS");
        this.grdConfirmToApprove.DataBind();
    }

    protected void grdConfirmToApprove_Filtering(object sender, C1GridViewFilterEventArgs e)
    {
        this.bind();
    }

    protected void grdConfirmToApprove_PageIndexChanging(object sender, C1GridViewPageEventArgs e)
    {
        this.grdConfirmToApprove.PageIndex = e.NewPageIndex;
        this.bind();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!base.IsPostBack)
        {
            this.bind();
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
