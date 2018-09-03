using AjaxControlToolkit;
using ASP;
using System;
using System.Data;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Master_Setup_Smt_Buildingunit : System.Web.UI.Page
{
    private BLL _bl = new BLL();
    //protected Button btnClear;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    //protected DropDownList drpSection;
    //protected HtmlForm form1;
    //protected GridView GridView1;
    //protected HtmlHead Head1;
    //protected Label Label2;
    //protected Label Label3;
    //protected Label lblColorid;
    //protected Label lblErrormsg;
    private DAL mycls = new DAL();
    //protected RequiredFieldValidator RequiredFieldValidator1;
    //protected ValidatorCalloutExtender RequiredFieldValidator1_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator2;
    //protected ValidatorCalloutExtender RequiredFieldValidator2_ValidatorCalloutExtender;
    //protected ScriptManager ScriptManager1;
    //protected TextBox txtBuildingUnit;
    //protected UpdatePanel UpdatePanel1;

    public void bindgrid()
    {
        this.GridView1.DataSource = this._bl.get_InformationdataTable("Sp_Smt_BuildingUnit_getAll " + this.drpSection.SelectedValue);
        this.GridView1.DataBind();
    }

    public void bindsection()
    {
        this.drpSection.DataSource = this._bl.get_InformationdataTable("select nCompanyID,cCmpName from Smt_Company");
        this.drpSection.DataTextField = "cCmpName";
        this.drpSection.DataValueField = "nCompanyID";
        this.drpSection.DataBind();
        this.drpSection.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpSection.SelectedIndex = 0;
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.bindgrid();
        this.txtBuildingUnit.Focus();
        this.drpSection.SelectedIndex = 0;
        this.lblColorid.Text = "";
        this.btnSave.Text = "Save";
        this.btnSave.ToolTip = "Save";
        this.lblErrormsg.Text = "";
        this.txtBuildingUnit.Text = "";
        this.drpSection.Focus();
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(this.lblColorid.Text))
        {
            this.mycls.Save_BuildingUnit(this.txtBuildingUnit.Text, int.Parse(this.drpSection.SelectedValue), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        else
        {
            this.mycls.Update_BuildingUnit(int.Parse(this.lblColorid.Text), this.txtBuildingUnit.Text, int.Parse(this.drpSection.SelectedValue), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        if (this.lblErrormsg.Text != "Already Exist")
        {
            this.bindgrid();
            this.txtBuildingUnit.Focus();
            this.drpSection.SelectedIndex = 0;
            this.lblColorid.Text = "";
            this.btnSave.Text = "Save";
            this.btnSave.ToolTip = "Save";
            this.txtBuildingUnit.Text = "";
        }
    }

    protected void drpSection_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.GridView1.DataSource = null;
        this.GridView1.DataBind();
        this.lblErrormsg.Text = "";
        this.txtBuildingUnit.Text = "";
        if (!string.IsNullOrEmpty(this.drpSection.SelectedValue))
        {
            this.bindgrid();
        }
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        this.GridView1.PageIndex = e.NewPageIndex;
        this.bindgrid();
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Select")
        {
            int num = int.Parse(e.CommandArgument.ToString());
            Label label = (Label)this.GridView1.Rows[num].FindControl("lblid");
            DataTable table = this._bl.get_InformationdataTable("select Unit_Name,Company_ID,Unit_Code from Smt_BuildingUnit where Unit_Code=" + int.Parse(label.Text));
            this.txtBuildingUnit.Text = table.Rows[0]["Unit_Name"].ToString();
            this.drpSection.SelectedValue = table.Rows[0]["Company_ID"].ToString();
            this.lblColorid.Text = table.Rows[0]["Unit_Code"].ToString();
            if (this.txtBuildingUnit.Text == "-")
            {
                this.txtBuildingUnit.Enabled = false;
                this.btnSave.Enabled = false;
            }
            else
            {
                this.txtBuildingUnit.Enabled = true;
                this.btnSave.Enabled = true;
            }
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
        else if (!base.IsPostBack)
        {
            this.drpSection.Focus();
            this.bindsection();
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
