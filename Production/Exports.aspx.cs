using AjaxControlToolkit;
using ASP;
using System;
using System.Data;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Production_Exports : System.Web.UI.Page
{
    //protected Button btnppgntpo;
    //protected ModalPopupExtender Button2_ModalPopupExtender;
    //protected ImageButton cal2;
    //protected DropDownList drpCompany;
    //protected DropDownList drpstyle;
    //protected GridView grdpodtl;
    //protected ImageButton imgstyle;
    private BLL mybll = new BLL();
    private DAL mycls = new DAL();
    //protected TextBox txtBrand;
    //protected TextBox txtBuyer;
    //protected TextBox txtExpdate;
    //protected CalendarExtender txtExpdate_CalendarExtender;
    //protected TextBox txtGmtdept;
    //protected TextBox txtGmttype;
    //protected TextBox txtLot;
    //protected TextBox txtSeason;
    //protected UpdatePanel UpdatePanel1;

    protected void drpCompany_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.drpstyle.Items.Clear();
        this.grdpodtl.DataSource = null;
        this.grdpodtl.DataBind();
        if (!string.IsNullOrEmpty(this.drpCompany.SelectedValue))
        {
            this.drpstyle.DataSource = this.mybll.get_InformationdataTable("Sp_Web_ProductionRunningStyles " + this.drpCompany.SelectedValue);
            this.drpstyle.DataTextField = "cStyleNo";
            this.drpstyle.DataValueField = "nStyleID";
            this.drpstyle.DataBind();
            this.drpstyle.Items.Insert(0, string.Empty);
        }
    }

    protected void drpstyle_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.grdpodtl.DataSource = null;
        this.grdpodtl.DataBind();
        this.txtBuyer.Text = "";
        this.txtBrand.Text = "";
        this.txtGmtdept.Text = "";
        this.txtGmttype.Text = "";
        this.txtSeason.Text = "";
        this.txtLot.Text = "";
        if (!string.IsNullOrEmpty(this.drpstyle.SelectedValue))
        {
            DataTable table = this.mybll.get_InformationdataTable("StyleMaster_getmasterinfo " + this.drpstyle.SelectedValue);
            if (table.Rows.Count > 0)
            {
                this.txtBuyer.Text = table.Rows[0]["cBuyer_Name"].ToString();
                this.txtBrand.Text = table.Rows[0]["cBrand_Name"].ToString();
                this.txtGmtdept.Text = table.Rows[0]["cGmt_Dept_Description"].ToString();
                this.txtGmttype.Text = table.Rows[0]["cGmetDis"].ToString();
                this.txtSeason.Text = table.Rows[0]["cSeason_Name"].ToString();
                DataTable table2 = this.mybll.get_InformationdataTable("select Fileno from Smt_StylemasterFile where StyleID=" + this.drpstyle.SelectedValue + " and Sketch=1");
                if (table2.Rows.Count > 0)
                {
                    this.imgstyle.ImageUrl = "StyleFile/" + table2.Rows[0]["Fileno"].ToString();
                    this.imgstyle.Visible = true;
                }
            }
            DataTable table3 = this.mybll.get_InformationdataTable("Assrt_PO_getall " + this.drpstyle.SelectedValue);
            if (table3.Rows.Count > 0)
            {
                this.grdpodtl.DataSource = table3;
                this.grdpodtl.DataBind();
            }
        }
    }

    protected void grdpodtl_RowDataBound(object sender, GridViewRowEventArgs e)
    {
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
