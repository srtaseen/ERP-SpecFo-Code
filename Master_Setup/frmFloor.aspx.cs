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

public partial class Master_Setup_frmFloor : System.Web.UI.Page
{
    //protected Button btnClear;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    //protected DropDownList drpCompany;
    //protected DropDownList drpUnit;
    //protected HtmlForm form1;
    //protected GridView GridView1;
    //protected HtmlHead Head1;
    //protected Label Label2;
    //protected Label Label5;
    //protected Label Label6;
    //protected Label lblErrormsg;
    //protected Label lblFloorid;
    private BLL mybll = new BLL();
    private DAL mycls = new DAL();
    //protected RequiredFieldValidator RequiredFieldValidator2;
    //protected ValidatorCalloutExtender RequiredFieldValidator2_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator3;
    //protected ValidatorCalloutExtender RequiredFieldValidator3_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator4;
    //protected ValidatorCalloutExtender RequiredFieldValidator4_ValidatorCalloutExtender;
    //protected ScriptManager ScriptManager1;
    //protected TextBox txtFloor;
    //protected UpdatePanel UpdatePanel1;

    public void bindgrid()
    {
        this.GridView1.DataSource = this.mybll.get_InformationdataTable("Sp_Smt_Floor_GetAll " + this.drpCompany.SelectedValue);
        this.GridView1.DataBind();
    }

    public void bindUnit()
    {
        this.drpUnit.DataSource = this.mybll.get_InformationdataTable("select Unit_Code,Unit_Name from Smt_BuildingUnit where Company_ID=" + this.drpCompany.SelectedValue + "  order by Unit_Name");
        this.drpUnit.DataTextField = "Unit_Name";
        this.drpUnit.DataValueField = "Unit_Code";
        this.drpUnit.DataBind();
        this.drpUnit.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpUnit.SelectedIndex = 0;
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.lblErrormsg.Text = "";
        this.bindgrid();
        this.txtFloor.Focus();
        this.txtFloor.Text = "";
        this.lblFloorid.Text = "";
        this.drpUnit.Items.Clear();
        this.drpCompany.SelectedIndex = 0;
        this.btnSave.Text = "Save";
        this.btnSave.ToolTip = "Save";
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(this.lblFloorid.Text))
        {
            this.mycls.Save_Floor(this.txtFloor.Text.Trim(), int.Parse(this.drpUnit.SelectedValue), int.Parse(this.drpCompany.SelectedValue), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        else
        {
            this.mycls.Update_Floor(int.Parse(this.lblFloorid.Text), this.txtFloor.Text.Trim(), int.Parse(this.drpUnit.SelectedValue), int.Parse(this.drpCompany.SelectedValue), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        if (this.lblErrormsg.Text != "Already Exist")
        {
            this.txtFloor.Text = "";
            this.lblFloorid.Text = "";
            this.bindgrid();
            this.drpUnit.SelectedIndex = 0;
        }
        this.txtFloor.Focus();
    }

    protected void drpCompany_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.drpUnit.Items.Clear();
        this.GridView1.DataSource = null;
        this.GridView1.DataBind();
        if (!string.IsNullOrEmpty(this.drpCompany.SelectedValue))
        {
            this.bindUnit();
            this.bindgrid();
        }
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        this.lblErrormsg.Text = "";
        this.GridView1.PageIndex = e.NewPageIndex;
        this.bindgrid();
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Select")
        {
            int num = int.Parse(e.CommandArgument.ToString());
            Label label = (Label)this.GridView1.Rows[num].FindControl("lblid");
            string statement = "select nFloor,cFloor_Descriptin,BuildingUID,CompanyID from Smt_Floor where nFloor='" + label.Text + "'";
            DataTable table = this.mycls.get_Alltbl(statement);
            this.lblFloorid.Text = table.Rows[0]["nFloor"].ToString();
            this.txtFloor.Text = table.Rows[0]["cFloor_Descriptin"].ToString();
            this.drpCompany.SelectedValue = table.Rows[0]["CompanyID"].ToString();
            this.bindUnit();
            this.drpUnit.SelectedValue = table.Rows[0]["BuildingUID"].ToString();
            this.btnSave.Text = "Update";
            this.btnSave.ToolTip = "Update";
            this.lblErrormsg.Text = "";
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.Session["Uid"] == null)
        {
            base.Response.Redirect("~/Smt_Login.aspx", false);
        }
        else
        {
            if (!base.IsPostBack)
            {
                this.mybll.ClearErrormsg(this, this.lblErrormsg);
                this.mycls.drp_Company(this.drpCompany);
            }
            Thread.Sleep(200);
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
