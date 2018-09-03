using AjaxControlToolkit;
using ASP;
using System;
using System.Data;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Master_Setup_frmLine : System.Web.UI.Page
{
    private BLL _bl = new BLL();
    //protected Button btnClear;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    //protected DropDownList drpCompany;
    //protected DropDownList drpDepartment;
    //protected DropDownList drpFloor;
    //protected DropDownList drpSection;
    //protected DropDownList DrpUnit;
    //protected HtmlForm form1;
    //protected GridView GridView1;
    //protected HtmlHead Head1;
    //protected Label Label1;
    //protected Label Label2;
    //protected Label Label3;
    //protected Label Label4;
    //protected Label Label5;
    //protected Label Label6;
    //protected Label Label7;
    //protected Label Label8;
    //protected Label lblErrormsg;
    //protected Label lbllineid;
    private DAL mycls = new DAL();
    //protected RequiredFieldValidator RequiredFieldValidator1;
    //protected ValidatorCalloutExtender RequiredFieldValidator1_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator2;
    //protected ValidatorCalloutExtender RequiredFieldValidator2_ValidatorCalloutExtender1;
    //protected RequiredFieldValidator RequiredFieldValidator3;
    //protected ValidatorCalloutExtender RequiredFieldValidator3_ValidatorCalloutExtender1;
    //protected RequiredFieldValidator RequiredFieldValidator4;
    //protected ValidatorCalloutExtender RequiredFieldValidator4_ValidatorCalloutExtender1;
    //protected RequiredFieldValidator RequiredFieldValidator5;
    //protected ValidatorCalloutExtender RequiredFieldValidator5_ValidatorCalloutExtender1;
    //protected RequiredFieldValidator RequiredFieldValidator6;
    //protected ValidatorCalloutExtender RequiredFieldValidator6_ValidatorCalloutExtender1;
    //protected ScriptManager ScriptManager1;
    //protected TextBox txtHelper;
    //protected FilteredTextBoxExtender txtHelper_FilteredTextBoxExtender;
    //protected TextBox txtLine;
    //protected TextBox txtOperator;
    //protected FilteredTextBoxExtender txtOperator_FilteredTextBoxExtender;
    //protected UpdatePanel UpdatePanel1;

    public void Binddept()
    {
        this.drpDepartment.DataSource = this._bl.get_Informationdataset("select nUserDept,cDeptname from Smt_Department where nCompanyID=" + this.drpCompany.SelectedValue + " order by cDeptname");
        this.drpDepartment.DataTextField = "cDeptname";
        this.drpDepartment.DataValueField = "nUserDept";
        this.drpDepartment.DataBind();
    }

    public void BindFloor()
    {
        this.drpFloor.DataSource = this._bl.get_Informationdataset("select nFloor,cFloor_Descriptin from Smt_Floor where BuildingUID=" + this.DrpUnit.SelectedValue + " order by cFloor_Descriptin");
        this.drpFloor.DataTextField = "cFloor_Descriptin";
        this.drpFloor.DataValueField = "nFloor";
        this.drpFloor.DataBind();
    }

    public void bindgrid()
    {
        this.GridView1.DataSource = this._bl.get_InformationdataTable("Sp_Smt_Line_getAll " + this.drpCompany.SelectedValue);
        this.GridView1.DataBind();
    }

    public void BindSection()
    {
        this.drpSection.DataSource = this._bl.get_Informationdataset("select nSectionID,cSection_Description from Smt_Section where nUserDept=" + this.drpDepartment.SelectedValue + " order by cSection_Description");
        this.drpSection.DataTextField = "cSection_Description";
        this.drpSection.DataValueField = "nSectionID";
        this.drpSection.DataBind();
    }

    public void bindunit()
    {
        this.DrpUnit.DataSource = this._bl.get_Informationdataset("select Unit_Code,Unit_Name from Smt_BuildingUnit where Company_ID=" + this.drpCompany.SelectedValue + " order by Unit_Name");
        this.DrpUnit.DataTextField = "Unit_Name";
        this.DrpUnit.DataValueField = "Unit_Code";
        this.DrpUnit.DataBind();
        this.DrpUnit.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.DrpUnit.SelectedIndex = 0;
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.DrpUnit.Items.Clear();
        this.drpSection.Items.Clear();
        this.drpFloor.Items.Clear();
        this.drpDepartment.Items.Clear();
        this.drpCompany.SelectedIndex = 0;
        this.txtHelper.Text = "";
        this.txtLine.Text = "";
        this.txtOperator.Text = "";
        this.lblErrormsg.Text = "";
        this.lbllineid.Text = "";
        this.GridView1.DataSource = null;
        this.GridView1.DataBind();
        this.btnSave.Text = "Save";
        this.btnSave.ToolTip = "Save";
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(this.lbllineid.Text))
        {
            this.mycls.Update_Line(int.Parse(this.lbllineid.Text), this.txtLine.Text, int.Parse(this.drpCompany.SelectedValue), int.Parse(this.drpDepartment.SelectedValue), int.Parse(this.drpSection.SelectedValue), int.Parse(this.DrpUnit.SelectedValue), int.Parse(this.drpFloor.SelectedValue), this.txtOperator.Text, this.txtHelper.Text, this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        else
        {
            this.mycls.Save_Line(this.txtLine.Text, int.Parse(this.drpCompany.SelectedValue), int.Parse(this.drpDepartment.SelectedValue), int.Parse(this.drpSection.SelectedValue), int.Parse(this.DrpUnit.SelectedValue), int.Parse(this.drpFloor.SelectedValue), this.txtOperator.Text, this.txtHelper.Text, this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        this.bindgrid();
    }

    protected void drpCompany_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.drpDepartment.Items.Clear();
        this.drpSection.Items.Clear();
        this.DrpUnit.Items.Clear();
        this.drpFloor.Items.Clear();
        if (!string.IsNullOrEmpty(this.drpCompany.SelectedValue))
        {
            this.Binddept();
            this.bindunit();
            this.bindgrid();
        }
    }

    protected void drpDepartment_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.drpSection.Items.Clear();
        if (!string.IsNullOrEmpty(this.drpDepartment.SelectedValue))
        {
            this.BindSection();
        }
    }

    protected void DrpUnit_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.drpFloor.Items.Clear();
        if (!string.IsNullOrEmpty(this.DrpUnit.SelectedValue))
        {
            this.BindFloor();
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
            Label label = (Label)this.GridView1.Rows[num].FindControl("lblLineID");
            DataTable table = this._bl.get_InformationdataTable("Sp_Smt_Line_getAllbyID " + label.Text);
            this.txtLine.Text = table.Rows[0]["Line_No"].ToString();
            this.lbllineid.Text = table.Rows[0]["Line_Code"].ToString();
            this.drpCompany.SelectedValue = table.Rows[0]["CompanyID"].ToString();
            this.Binddept();
            this.drpDepartment.SelectedValue = table.Rows[0]["DepartmentID"].ToString();
            this.bindunit();
            this.DrpUnit.SelectedValue = table.Rows[0]["BuildingUnitID"].ToString();
            this.BindSection();
            this.drpSection.SelectedValue = table.Rows[0]["SectionID"].ToString();
            this.BindFloor();
            this.drpFloor.SelectedValue = table.Rows[0]["FloorID"].ToString();
            this.txtHelper.Text = table.Rows[0]["nHelper"].ToString();
            this.txtOperator.Text = table.Rows[0]["nMachineOp"].ToString();
            this.lblErrormsg.Text = "";
            this.btnSave.Text = "Update";
            this.btnSave.ToolTip = "Update";
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!base.IsPostBack)
        {
            this.mycls.drp_Company(this.drpCompany);
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
