using ASP;
using System;
using System.Text;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Smt_Dashboards : System.Web.UI.Page
{
    private BLLInventory _blInvent = new BLLInventory();
    private BLL _mybl = new BLL();
    //protected Button btnFactoryPurchasePO;
    //protected Button btnMerchantPurchasePO;
    //protected Button btnTnA;
    //protected Timer Timer1;
    //protected UpdatePanel UpdatePanel4;

    public void DshboardBind()
    {
        int num = int.Parse(((int)this._blInvent.get_InformationdataTable("Sp_Smt_PO_GetForApproveDshboard").Rows.Count).ToString());
        this.btnMerchantPurchasePO.Text = ("Merchant Purchase Pending PO (" + ((int)num) + ")");
        int num2 = int.Parse(((int)this._blInvent.get_InformationdataTable("Sp_Smt_FactoryPurchase_GetForApproval").Rows.Count).ToString());
        this.btnFactoryPurchasePO.Text =("Factory Purchase Pending PO (" + ((int)num2) + ")");
        int num3 = int.Parse(((int)this._mybl.get_InformationdataTable("Sp_Smt_TNA_TaskStatus_getPending").Rows.Count).ToString());
        this.btnTna.Text=("Pending Time and Action (" + ((int)num3) + ")");
    }

    private string getjQueryCode(string jsCodetoRun)
    {
        System.Text.StringBuilder builder = new System.Text.StringBuilder();
        builder.AppendLine("$(document).ready(function() {");
        builder.AppendLine(jsCodetoRun);
        builder.AppendLine(" });");
        return builder.ToString();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!base.IsPostBack)
        {
            this.DshboardBind();
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
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        this.runjQueryCode("lodhide();");
        this.DshboardBind();

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
}