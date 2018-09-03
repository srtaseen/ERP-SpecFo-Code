using AjaxControlToolkit;
using ASP;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Profile;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Inventory_MasterPage : System.Web.UI.MasterPage
{
    //protected HtmlAnchor A1;
    //protected HtmlAnchor A10;
    //protected HtmlAnchor A11;
    //protected HtmlAnchor A12;
    //protected HtmlAnchor A13;
    //protected HtmlAnchor A14;
    //protected HtmlAnchor A15;
    //protected HtmlAnchor A2;
    //protected HtmlAnchor A23;
    //protected HtmlAnchor A24;
    //protected HtmlAnchor A25;
    //protected HtmlAnchor A26;
    //protected HtmlAnchor A27;
    //protected HtmlAnchor A28;
    //protected HtmlAnchor A29;
    //protected HtmlAnchor A3;
    //protected HtmlAnchor A30;
    //protected HtmlAnchor A31;
    //protected HtmlAnchor A32;
    //protected HtmlAnchor A33;
    //protected HtmlAnchor A34;
    //protected HtmlAnchor A36;
    //protected HtmlAnchor A37;
    //protected HtmlAnchor A4;
    //protected HtmlAnchor A5;
    //protected HtmlAnchor A6;
    //protected HtmlAnchor A7;
    //protected HtmlAnchor A8;
    //protected HtmlAnchor A9;
    //protected HtmlAnchor ACSTAPPV;
    //protected HtmlAnchor ACutRPT;
    //protected HtmlAnchor Adb;
    //protected HtmlAnchor ADV;
    //protected HtmlAnchor Aexp;
    //protected HtmlAnchor AFnisRpt;
    //protected HtmlAnchor AMRpt;
    //protected HtmlAnchor amrpt2;
    //protected HtmlAnchor ANC;
    //protected HtmlAnchor AOMS;
    //protected HtmlAnchor AOTS;
    //protected HtmlAnchor ASTT;
    //protected HtmlAnchor ASwnRpt;
    //protected ImageButton btncnclabt;
    //protected Button btnmnu;
    private SqlConnection cn = GetWay.SpecFoCon;
    //protected ContentPlaceHolder ContentPlaceHolder1;
    private string fnn;
    //protected HtmlForm form1;
    //protected ContentPlaceHolder head;
    //protected HoverMenuExtender HoverExforTopmenu;
    //protected Image Image1;
    //protected HtmlGenericControl L1;
    //protected HtmlGenericControl L10;
    //protected HtmlGenericControl L11;
    //protected HtmlGenericControl L12;
    //protected HtmlGenericControl L13;
    //protected HtmlGenericControl L14;
    //protected HtmlGenericControl L2;
    //protected HtmlGenericControl L23;
    //protected HtmlGenericControl L24;
    //protected HtmlGenericControl L25;
    //protected HtmlGenericControl L26;
    //protected HtmlGenericControl L27;
    //protected HtmlGenericControl L28;
    //protected HtmlGenericControl L29;
    //protected HtmlGenericControl L3;
    //protected HtmlGenericControl L30;
    //protected HtmlGenericControl L31;
    //protected HtmlGenericControl L32;
    //protected HtmlGenericControl L33;
    //protected HtmlGenericControl L34;
    //protected HtmlGenericControl L36;
    //protected HtmlGenericControl L5;
    //protected HtmlGenericControl L6;
    //protected HtmlGenericControl L7;
    //protected HtmlGenericControl L8;
    //protected HtmlGenericControl L9;
    //protected Label Label1;
    //protected Label Label3;
    //protected Label Label4;
    //protected LinkButton lbHelp;
    //protected Label lblComName;
    //protected Label lblCurrentpage;
    //protected Label lbltotalinfo;
    //protected HtmlGenericControl LCSTAPPV;
    //protected HtmlGenericControl LCutRPT;
    //protected HtmlGenericControl Ldb;
    //protected HtmlGenericControl LDV;
    //protected HtmlGenericControl lexp;
    //protected HtmlGenericControl LFnisRpt;
    //protected HtmlGenericControl Li1;
    //protected HtmlGenericControl Li2;
    //protected HtmlGenericControl Li3;
    //protected LinkButton LinkButton1;
    //protected ModalPopupExtender LinkButton1_ModalPopupExtender;
    //protected HtmlGenericControl LIOTS;
    //protected HtmlGenericControl LMRpt;
    //protected HtmlGenericControl lmrpt2;
    //protected HtmlGenericControl LNC;
    //protected LinkButton lnkUsrName;
    //protected HtmlGenericControl LOMS;
    //protected HtmlGenericControl LSTT;
    //protected HtmlGenericControl LSwnRpt;
    //protected ModalPopupExtender mpeProgress;
    private BLL mybll = new BLL();
    private DAL mycls = new DAL();
    //protected Panel pnlAbout;
    //protected Panel pnlFtr;
    //protected AlwaysVisibleControlExtender pnlFtr_AlwaysVisibleControlExtender;
    //protected Panel pnlProgress;
    //protected ScriptManager ScriptManager1;
    //protected UpdatePanel UpdatePanel1;
    //protected UpdatePanel UpdatePanel3;

    protected void Page_Load(object sender, EventArgs e)
    {
        string[] strArray = base.Request.FilePath.ToString().Split(new char[] { '/' });
        int index = strArray.Length - 1;
        string frm = strArray[index];
        if (base.Session["Uid"] == null)
        {
            base.Response.Redirect("~/Smt_Login.aspx", false);
        }
        else if (!base.IsPostBack)
        {
            this.lblCurrentpage.Text = this.Page.Title;
            this.lnkUsrName.Text = base.Session["UName"].ToString();
            HtmlAnchor[] anchorArray = new HtmlAnchor[] {
                this.A1, this.A2, this.A3, this.A5, this.A6, this.A7, this.A8, this.A9, this.A10, this.A11, this.A12, this.A13, this.A14, this.A23, this.A24, this.A25,
                this.A26, this.A27, this.A28, this.A29, this.A30, this.A31, this.A32, this.A33, this.A34, this.A36, this.AOMS, this.ASTT, this.ANC, this.ACutRPT, this.ASwnRpt, this.AFnisRpt,
                this.AMRpt, this.Adb, this.ACSTAPPV, this.ADV, this.Aexp, this.amrpt2
            };
            HtmlGenericControl[] controlArray = new HtmlGenericControl[] {
                this.L1, this.L2, this.L3, this.L5, this.L6, this.L7, this.L8, this.L9, this.L10, this.L11, this.L12, this.L13, this.L14, this.L23, this.L24, this.L25,
                this.L26, this.L27, this.L28, this.L29, this.L30, this.L31, this.L32, this.L33, this.L34, this.L36, this.LOMS, this.LSTT, this.LNC, this.LCutRPT, this.LSwnRpt, this.LFnisRpt,
                this.LMRpt, this.Ldb, this.LCSTAPPV, this.LDV, this.lexp, this.lmrpt2
            };
            DataTable table = this.mybll.get_InformationdataTable("select Permission_Status from Smt_Users where cUserName='" + base.Session["Uid"].ToString() + "'");
            if (((base.Session["UGroup"] != null) && (base.Session["UGroup"].ToString() != "1")) && (table.Rows.Count > 0))
            {
                if (table.Rows[0]["Permission_status"].ToString() == "U")
                {
                    for (int i = 0; i < anchorArray.Length; i++)
                    {
                        string innerText = anchorArray[i].InnerText;
                        if (this.mybll.get_InformationdataTable("select Form_Name from Smt_UserPermittedform where User_ID='" + base.Session["Uid"].ToString() + "' and Form_Name='" + innerText + "'").Rows.Count < 1)
                        {
                            controlArray[i].Visible = false;
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < anchorArray.Length; j++)
                    {
                        string str5 = anchorArray[j].InnerText;
                        if (this.mybll.get_InformationdataTable(string.Concat(new object[] { "select Form_Name from Smt_UserPermittedform where nUgroup=", int.Parse(base.Session["UGroup"].ToString()), " and Form_Name='", str5, "'" })).Rows.Count < 1)
                        {
                            controlArray[j].Visible = false;
                        }
                    }
                }
            }
            this.fnn = this.mycls.permissionformmasterload(base.Session["UGroup"].ToString(), base.Session["Uid"].ToString(), frm);
            if (base.Session["UGroup"].ToString() != "1")
            {
                this.fnn = this.mycls.permissionformmasterload(base.Session["UGroup"].ToString(), base.Session["Uid"].ToString(), frm);
                if (((frm != "Smt_Mainhome.aspx") && (frm != "frmChangepasword.aspx")) && (frm != "Smt_Setting.aspx"))
                {
                    if (string.IsNullOrEmpty(this.fnn))
                    {
                        base.Response.Redirect("~/Smt_Login.aspx");
                    }
                    else if (frm != this.fnn)
                    {
                        base.Response.Redirect("~/Smt_Login.aspx");
                    }
                }
            }
            DataSet set = this.mybll.get_Informationdataset("select cCmpName,cAdd1,cAdd2 from Smt_Company where Display_AS_Header=1");
            this.lblComName.Text = set.Tables[0].Rows[0]["cCmpName"].ToString();
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
