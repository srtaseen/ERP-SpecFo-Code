using AjaxControlToolkit;
using ASP;
using System;
using System.Data;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Master_Setup_frmBankInfo : System.Web.UI.Page
{
    private BLL _bll = new BLL();
    //protected Button btnClear;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    //protected DropDownList drpcountry;
    //protected HtmlForm form1;
    //protected GridView GridView1;
    //protected HtmlHead Head1;
    //protected Label Label10;
    //protected Label Label11;
    //protected Label Label12;
    //protected Label Label13;
    //protected Label Label8;
    //protected Label Label9;
    //protected Label lblBankCode;
    //protected Label lblErrormsg;
    private DAL mycls = new DAL();
    //protected RequiredFieldValidator RequiredFieldValidator4;
    //protected ValidatorCalloutExtender RequiredFieldValidator4_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator5;
    //protected ValidatorCalloutExtender RequiredFieldValidator5_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator6;
    //protected ValidatorCalloutExtender RequiredFieldValidator6_ValidatorCalloutExtender;
    //protected ScriptManager ScriptManager1;
    //protected TextBox txtAddress;
    //protected TextBox txtBankName;
    //protected TextBox txtFax;
    //protected TextBox txtSwiftCode;
    //protected TextBox txtTelephone;
    //protected UpdatePanel UpdatePanel1;

    public void bindgrid()
    {
        this.GridView1.DataSource = this._bll.get_InformationdataTable("SELECT [Bank_Code], [Bank_Name], [Bank_Address], [Telephone_No], [Fax], [Swift_Code] FROM [Smt_BankInfo] where Bank_Name<>'-' ORDER BY [Bank_Name]");
        this.GridView1.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.txtAddress.Text = "";
        this.txtBankName.Text = "";
        this.txtFax.Text = "";
        this.txtSwiftCode.Text = "";
        this.txtTelephone.Text = "";
        this.drpcountry.SelectedValue = "";
        this.lblBankCode.Text = "";
        this.lblErrormsg.Text = "";
        this.btnSave.Text = "Save";
        this.btnSave.ToolTip = "Save";
        this.txtBankName.Focus();
        this.txtBankName.Enabled = true;
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(this.lblBankCode.Text))
        {
            this.mycls.Update_BankInfo(int.Parse(this.lblBankCode.Text), this.txtBankName.Text, this.txtAddress.Text, this.txtTelephone.Text, this.txtFax.Text, this.drpcountry.SelectedValue, this.txtSwiftCode.Text, this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        else
        {
            this.mycls.Save_BankInfo(this.txtBankName.Text, this.txtAddress.Text, this.txtTelephone.Text, this.txtFax.Text, this.drpcountry.SelectedValue, this.txtSwiftCode.Text, this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        if (this.lblErrormsg.Text != "Already Exist")
        {
            this.txtAddress.Text = "";
            this.txtBankName.Text = "";
            this.txtFax.Text = "";
            this.txtSwiftCode.Text = "";
            this.txtTelephone.Text = "";
            this.drpcountry.SelectedValue = "";
            this.lblBankCode.Text = "";
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
            this.txtBankName.Enabled = true;
            int num = int.Parse(e.CommandArgument.ToString());
            Label label = (Label)this.GridView1.Rows[num].FindControl("lblBcode");
            string statement = "select Bank_Code,Bank_Name,Bank_Address,Telephone_No,Fax,Country_Code,Swift_Code from Smt_BankInfo where Bank_Code='" + label.Text + "'";
            DataTable table = this.mycls.get_Alltbl(statement);
            this.txtBankName.Text = table.Rows[0]["Bank_Name"].ToString();
            this.txtAddress.Text = table.Rows[0]["Bank_Address"].ToString();
            this.txtFax.Text = table.Rows[0]["Fax"].ToString();
            this.txtSwiftCode.Text = table.Rows[0]["Swift_Code"].ToString();
            this.txtTelephone.Text = table.Rows[0]["Telephone_No"].ToString();
            this.drpcountry.SelectedValue = table.Rows[0]["Country_Code"].ToString();
            this.lblBankCode.Text = table.Rows[0]["Bank_Code"].ToString();
            this.btnSave.Text = "Update";
            this.btnSave.ToolTip = "Update";
            this.lblErrormsg.Text = "";
            if (this.txtBankName.Text == "-")
            {
                this.txtBankName.Enabled = false;
            }
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
            this.mycls.drp_Counrys(this.drpcountry);
            this.bindgrid();
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
