using AjaxControlToolkit;
using ASP;
using System;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Master_Setup_frmLearningcurve : System.Web.UI.Page
{
    private BLL _bll = new BLL();
    //protected Button btnClear;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    //protected HtmlForm form1;
    //protected GridView GridView1;
    //protected HtmlHead Head1;
    //protected Label Label10;
    //protected Label Label2;
    //protected Label Label6;
    //protected Label Label7;
    //protected Label Label8;
    //protected Label Label9;
    //protected Label lblColorid;
    //protected Label lblErrormsg;
    private DAL mycls = new DAL();
    //protected RequiredFieldValidator RequiredFieldValidator3;
    //protected ValidatorCalloutExtender RequiredFieldValidator3_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator4;
    //protected ValidatorCalloutExtender RequiredFieldValidator4_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator5;
    //protected ValidatorCalloutExtender RequiredFieldValidator5_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator6;
    //protected ValidatorCalloutExtender RequiredFieldValidator6_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator7;
    //protected ValidatorCalloutExtender RequiredFieldValidator7_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator8;
    //protected ValidatorCalloutExtender RequiredFieldValidator8_ValidatorCalloutExtender;
    //protected ScriptManager ScriptManager1;
    //protected TextBox txtCurvename;
    //protected TextBox txtD1;
    //protected FilteredTextBoxExtender txtD1_FilteredTextBoxExtender;
    //protected TextBox txtD2;
    //protected FilteredTextBoxExtender txtD2_FilteredTextBoxExtender1;
    //protected TextBox txtD3;
    //protected FilteredTextBoxExtender txtD3_FilteredTextBoxExtender1;
    //protected TextBox txtD4;
    //protected FilteredTextBoxExtender txtD4_FilteredTextBoxExtender1;
    //protected TextBox txtD5;
    //protected FilteredTextBoxExtender txtD5_FilteredTextBoxExtender1;
    //protected UpdatePanel UpdatePanel1;

    public void bindgrid()
    {
        this.GridView1.DataSource = this._bll.get_InformationdataTable("SELECT [Curve_ID], [Curve_Name], [Day_1], [Day_2], [Day_3], [Day_4], [Day_5] FROM [Smt_Learningcurve]");
        this.GridView1.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.txtD5.Text = "";
        this.txtD4.Text = "";
        this.txtD3.Text = "";
        this.txtD2.Text = "";
        this.txtD1.Text = "";
        this.txtCurvename.Text = "";
        this.txtCurvename.Focus();
        this.lblErrormsg.Text = "";
        this.bindgrid();
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        string text = "0";
        string str2 = "0";
        string str3 = "0";
        string str4 = "0";
        string str5 = "0";
        if (!string.IsNullOrEmpty(this.txtD1.Text))
        {
            text = this.txtD1.Text;
        }
        if (!string.IsNullOrEmpty(this.txtD2.Text))
        {
            str2 = this.txtD2.Text;
        }
        if (!string.IsNullOrEmpty(this.txtD3.Text))
        {
            str3 = this.txtD3.Text;
        }
        if (!string.IsNullOrEmpty(this.txtD4.Text))
        {
            str4 = this.txtD4.Text;
        }
        if (!string.IsNullOrEmpty(this.txtD5.Text))
        {
            str5 = this.txtD5.Text;
        }
        string chkstatement = "select Curve_ID from Smt_Learningcurve where Day_1=" + text + " and Day_2=" + str2 + " and Day_3=" + str3 + " and Day_4=" + str4 + " and Day_5=" + str5;
        string[] pValue = new string[] { this.txtCurvename.Text, text, str2, str3, str4, str5, this.Session["Uid"].ToString() };
        this.mycls.Save_Learningcurve(pValue, chkstatement, this.lblErrormsg);
        if (this.lblErrormsg.Text != "Already Exists")
        {
            this.txtD5.Text = "";
            this.txtD4.Text = "";
            this.txtD3.Text = "";
            this.txtD2.Text = "";
            this.txtD1.Text = "";
            this.txtCurvename.Text = "";
            this.txtCurvename.Focus();
        }
        this.bindgrid();
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        this.lblErrormsg.Text = "";
        this.GridView1.PageIndex = e.NewPageIndex;
        this.bindgrid();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!base.IsPostBack)
        {
            this.bindgrid();
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
