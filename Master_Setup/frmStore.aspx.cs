using AjaxControlToolkit;
using ASP;
using System;
using System.Data;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Master_Setup_frmStore : System.Web.UI.Page
{
    private BLL _bll = new BLL();
    //protected Button btnClear;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    //protected DropDownList drpcountry;
    //protected HtmlForm form1;
    //protected GridView GridView1;
    //protected Label Label1;
    //protected Label Label3;
    //protected Label lblErrormsg;
    //protected Label lblStoreID;
    private DAL mycls = new DAL();
    //protected RequiredFieldValidator RequiredFieldValidator3;
    //protected ValidatorCalloutExtender RequiredFieldValidator3_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator4;
    //protected ValidatorCalloutExtender RequiredFieldValidator4_ValidatorCalloutExtender;
    //protected ScriptManager ScriptManager1;
    //protected TextBox txtStore;
    //protected UpdatePanel UpdatePanel1;

    public void bindgrid()
    {
        this.GridView1.DataSource = this._bll.get_InformationdataTable("SELECT [nStore_ID], [cStore_Name], [cConDes], [cEntUser], [dEntdt] FROM [View_Smt_Store] where nCountry_ID='" + this.drpcountry.SelectedValue + "'  ORDER BY [nStore_ID] DESC");
        this.GridView1.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.lblErrormsg.Text = "";
        this.txtStore.Focus();
        this.txtStore.Text = "";
        this.drpcountry.SelectedValue = "";
        this.GridView1.DataSource = null;
        this.GridView1.DataBind();
        this.lblStoreID.Text = "";
        this.btnSave.Text = "Save";
        this.btnSave.ToolTip = "Save";
        this.btnSave.Enabled = true;
        this.btnSave.CssClass = "button";
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(this.lblStoreID.Text))
        {
            this.mycls.Save_Store(this.txtStore.Text, int.Parse(this.drpcountry.SelectedValue), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        else
        {
            this.mycls.Update_Store(int.Parse(this.lblStoreID.Text), this.txtStore.Text, int.Parse(this.drpcountry.SelectedValue), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        if (this.lblErrormsg.Text != "Already Exist")
        {
            this.txtStore.Focus();
            this.txtStore.Text = "";
            this.lblStoreID.Text = "";
            this.btnSave.Text = "Save";
            this.btnSave.ToolTip = "Save";
            this.bindgrid();
        }
    }

    protected void drpcountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.bindgrid();
        if (this.drpcountry.SelectedItem.Text == "-")
        {
            this.btnSave.Enabled = false;
        }
        else
        {
            this.btnSave.Enabled = true;
        }
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Select")
        {
            int num = int.Parse(e.CommandArgument.ToString());
            Label label = (Label)this.GridView1.Rows[num].Cells[1].FindControl("lblid");
            string statement = "select nStore_ID,cStore_Name,nCountry_ID from Smt_Store where nStore_ID='" + label.Text + "'";
            DataTable table = this.mycls.get_Alltbl(statement);
            this.txtStore.Text = table.Rows[0]["cStore_Name"].ToString();
            this.drpcountry.SelectedValue = table.Rows[0]["nCountry_ID"].ToString();
            this.lblStoreID.Text = table.Rows[0]["nStore_ID"].ToString();
            this.btnSave.Text = "Update";
            this.btnSave.ToolTip = "Update";
            this.lblErrormsg.Text = "";
            if (this.txtStore.Text == "-")
            {
                this.btnSave.Enabled = false;
                this.btnSave.CssClass = "";
            }
            else
            {
                this.btnSave.Enabled = true;
                this.btnSave.CssClass = "button";
            }
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!base.IsPostBack)
        {
            this.txtStore.Focus();
            this.mycls.drp_Counrys(this.drpcountry);
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
