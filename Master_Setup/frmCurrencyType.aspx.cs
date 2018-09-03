using AjaxControlToolkit;
using ASP;
using System;
using System.Data;
using System.Threading;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Master_Setup_frmCurrencyType : System.Web.UI.Page
{
    private BLLInventory _blInventory = new BLLInventory();
    //protected Button btnClear;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    //protected HtmlForm form1;
    //protected GridView GridView1;
    //protected HtmlHead Head1;
    //protected Label Label1;
    //protected Label Label2;
    //protected Label Label3;
    //protected Label lblErrormsg;
    private DALInventory mycls = new DALInventory();
    //protected RequiredFieldValidator RequiredFieldValidator1;
    //protected ValidatorCalloutExtender RequiredFieldValidator1_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator3;
    //protected ValidatorCalloutExtender RequiredFieldValidator3_ValidatorCalloutExtender;
    //protected ScriptManager ScriptManager1;
    //protected TextBox txtCode;
    //protected TextBox txtrate;
    //protected FilteredTextBoxExtender txtrate_FilteredTextBoxExtender;
    //protected TextBox txtType;
    //protected UpdatePanel UpdatePanel1;

    public void bindgrid()
    {
        this.GridView1.DataSource = this._blInventory.get_InformationdataTable("SELECT [cCurCode], [cCurdes], [nExgRate], [cuser], [cEntDAte] FROM [Smt_CurencyType] where cCurCode<>'-' ORDER BY [cCurCode] DESC");
        this.GridView1.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.GridView1.DataSource = null;
        this.GridView1.DataBind();
        this.txtCode.Text = "";
        this.txtrate.Text = "";
        this.txtType.Text = "";
        this.txtCode.Focus();
        this.lblErrormsg.Text = "";
        this.txtCode.Enabled = true;
        this.btnSave.Text = "Save";
        this.btnSave.ToolTip = "Save";
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        string s = "0";
        if (!string.IsNullOrEmpty(this.txtrate.Text))
        {
            s = this.txtrate.Text.Trim();
        }
        else
        {
            s = "0.00";
        }
        if (this.txtCode.Enabled)
        {
            this.mycls.Save_Currencytype(this.txtCode.Text.Trim(), this.txtType.Text, decimal.Parse(s), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        else
        {
            this.mycls.Update_Currencytype(this.txtCode.Text.Trim(), this.txtType.Text, decimal.Parse(s), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        if (this.lblErrormsg.Text != "Already Exist")
        {
            this.bindgrid();
            this.txtCode.Text = "";
            this.txtrate.Text = "";
            this.txtType.Text = "";
            this.btnSave.Text = "Save";
            this.btnSave.ToolTip = "Save";
            this.txtCode.Enabled = true;
        }
        this.txtCode.Focus();
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Select")
        {
            int num = int.Parse(e.CommandArgument.ToString());
            string text = this.GridView1.Rows[num].Cells[1].Text;
            string statement = "select cCurCode,cCurdes,nExgRate from Smt_CurencyType where cCurCode='" + text + "'";
            DataTable table = this.mycls.get_Alltbl(statement);
            this.txtCode.Text = table.Rows[0]["cCurCode"].ToString();
            this.txtType.Text = table.Rows[0]["cCurdes"].ToString();
            this.txtrate.Text = table.Rows[0]["nExgRate"].ToString();
            this.txtCode.Enabled = false;
            this.btnSave.Text = "Update";
            this.btnSave.ToolTip = "Update";
            this.lblErrormsg.Text = "";
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.Session["Uid"] == null)
        {
            base.Response.Redirect("../Smt_Login.aspx", false);
        }
        else
        {
            if (!base.IsPostBack)
            {
                this.txtCode.Focus();
                this.bindgrid();
            }
            Thread.Sleep(200);
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
