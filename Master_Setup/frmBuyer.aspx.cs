using AjaxControlToolkit;
using ASP;
using System;
using System.Data;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Master_Setup_frmBuyer : System.Web.UI.Page
{
    private BLL _bl = new BLL();
    //protected Button btnClear;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    //protected HtmlForm form1;
    //protected GridView GridView2;
    //protected Label Label1;
    //protected Label Label2;
    //protected Label Label3;
    //protected Label Label4;
    //protected Label Label5;
    //protected Label Label6;
    //protected Label Label7;
    //protected Label lblBuyerID;
    //protected Label lblErrormsg;
    private DAL mycls = new DAL();
    //protected RequiredFieldValidator RequiredFieldValidator2;
    //protected ValidatorCalloutExtender RequiredFieldValidator2_ValidatorCalloutExtender;
    //protected ScriptManager ScriptManager1;
    //protected TextBox txtAd1;
    //protected TextBox txtAd2;
    //protected TextBox txtBName;
    //protected TextBox txtCont;
    //protected TextBox txtEmail;
    //protected TextBox txtFx;
    //protected TextBox txtPh;
    //protected UpdatePanel UpdatePanel1;

    public void bindgrid()
    {
        this.GridView2.DataSource = this._bl.get_InformationdataTable("SELECT [nBuyer_ID], [cBuyer_Name] FROM [Smt_BuyerName] where cBuyer_Name<>'-' ");
        this.GridView2.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.clearall();
        this.lblBuyerID.Text = "0";
        this.lblErrormsg.Text = "";
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        this.lblErrormsg.Text = "";
        this.mycls.Save_Buyer(this.txtBName.Text.Trim(), this.Session["Uid"].ToString(), this.txtAd1.Text.Trim(), this.txtAd2.Text.Trim(), this.txtPh.Text.Trim(), this.txtCont.Text.Trim(), this.txtEmail.Text.Trim(), this.txtFx.Text.Trim(), int.Parse(this.lblBuyerID.Text.Trim()), this.lblErrormsg);
        if (this.lblErrormsg.Text != "Already Exist")
        {
            this.clearall();
        }
    }

    public void clearall()
    {
        this.bindgrid();
        this.txtBName.Focus();
        this.txtBName.Text = "";
        this.lblBuyerID.Text = "0";
        this.txtPh.Text = "";
        this.txtFx.Text = "";
        this.txtEmail.Text = "";
        this.txtCont.Text = "";
        this.txtAd2.Text = "";
        this.txtAd1.Text = "";
    }

    protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        this.lblErrormsg.Text = "";
        this.GridView2.PageIndex = e.NewPageIndex;
        this.bindgrid();
    }

    protected void lnkSelect_Click(object sender, EventArgs e)
    {
        GridViewRow parent = ((LinkButton)sender).Parent.Parent as GridViewRow;
        LinkButton button = (LinkButton)parent.FindControl("lnkSelect");
        DataTable table = this._bl.get_InformationdataTable("select nBuyer_ID,cBuyer_Name,Address1,Address2,Phone_No,Cont_Person,Email,Fax from Smt_BuyerName where nBuyer_ID='" + button.CommandArgument.Trim() + "'");
        this.lblBuyerID.Text = table.Rows[0]["nBuyer_ID"].ToString();
        this.txtBName.Text = table.Rows[0]["cBuyer_Name"].ToString();
        this.txtAd1.Text = table.Rows[0]["Address1"].ToString();
        this.txtAd2.Text = table.Rows[0]["Address2"].ToString();
        this.txtPh.Text = table.Rows[0]["Phone_No"].ToString();
        this.txtFx.Text = table.Rows[0]["Fax"].ToString();
        this.txtCont.Text = table.Rows[0]["Cont_Person"].ToString();
        this.txtEmail.Text = table.Rows[0]["Email"].ToString();
        this.lblErrormsg.Text = "";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.Session["Uid"] == null)
        {
            base.Response.Redirect("../Smt_Login.aspx", false);
        }
        else if (!base.IsPostBack)
        {
            this.bindgrid();
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
