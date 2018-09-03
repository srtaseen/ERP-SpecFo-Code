using ASP;
using System;
using System.Data;
using System.Drawing;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class StyleStatus : System.Web.UI.Page
{
    private BLLInventory blinventory = new BLLInventory();
    //protected CheckBox chkassort;
    //protected CheckBox chkbom;
    //protected CheckBox chkgrn;
    //protected CheckBox chkpo;
    //protected DropDownList drpStyleno;
    //protected GridView grdBOM;
    //protected GridView grdDelivery;
    //protected GridView grdgrn;
    //protected GridView grdPOPrintingDetail;
    //protected GridView grdStylesummery;
    //protected Label Label1;
    //protected Label Label15;
    //protected Label Label2;
    //protected Label Label3;
    //protected Label Label4;
    //protected Label Label5;
    //protected Label Label6;
    //protected Label Label7;
    private BLL mybll = new BLL();
    //protected Panel pnlassortment;
    //protected Panel pnlBOM;
    //protected Panel pnlDelivery;
    //protected Panel pnlGRN;
    //protected Panel pnlPOdtl;
    private int ttl;
    //protected TextBox txtBrand;
    //protected TextBox txtBuyer;
    //protected TextBox txtGarmentDpt;
    //protected TextBox txtGarmenttype;
    //protected TextBox txtOrdqtysum;
    //protected TextBox txtSeason;
    //protected TextBox txtStore;
    //protected UpdatePanel UpdatePanel1;

    public void bind()
    {
        DataSet set = this.mybll.get_Informationdataset("Sp_Smt_GetStyleIDForRename '" + this.Session["Uid"].ToString() + "'");
        this.drpStyleno.DataSource = set;
        this.drpStyleno.DataTextField = "StyleNO";
        this.drpStyleno.DataValueField = "StyleID";
        this.drpStyleno.DataBind();
        this.drpStyleno.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpStyleno.SelectedIndex = 0;
    }

    protected void drpStyleno_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.txtOrdqtysum.Text = "";
        this.txtBrand.Text = "";
        this.txtBuyer.Text = "";
        this.txtGarmentDpt.Text = "";
        this.txtGarmenttype.Text = "";
        this.txtSeason.Text = "";
        this.txtStore.Text = "";
        this.grdStylesummery.DataSource = null;
        this.grdStylesummery.DataBind();
        this.grdPOPrintingDetail.DataSource = null;
        this.grdPOPrintingDetail.DataBind();
        this.grdgrn.DataSource = null;
        this.grdgrn.DataBind();
        this.pnlPOdtl.Visible = false;
        this.pnlGRN.Visible = false;
        this.pnlassortment.Visible = false;
        this.chkassort.Checked = false;
        this.chkpo.Checked = false;
        this.chkbom.Checked = false;
        this.chkgrn.Checked = false;
        this.pnlBOM.Visible = false;
        this.chkbom.ForeColor = Color.Empty;
        this.chkassort.ForeColor = Color.Empty;
        this.chkpo.ForeColor = Color.Empty;
        this.chkgrn.ForeColor = Color.Empty;
        this.pnlDelivery.Visible = false;
        if (!string.IsNullOrEmpty(this.drpStyleno.SelectedValue))
        {
            string sqlstatement = "select cSeason_Name,cBuyer_Name,cBrand_Name,cStore_Name,cGmt_Dept_Description,cGmetDis,nTotOrdQty from Smt_View_Stylemaster where nStyleID=" + this.drpStyleno.SelectedValue;
            DataTable table = this.mybll.get_InformationdataTable(sqlstatement);
            this.txtBrand.Text = table.Rows[0]["cBrand_Name"].ToString();
            this.txtBuyer.Text = table.Rows[0]["cBuyer_Name"].ToString();
            this.txtGarmentDpt.Text = table.Rows[0]["cGmt_Dept_Description"].ToString();
            this.txtGarmenttype.Text = table.Rows[0]["cGmetDis"].ToString();
            this.txtSeason.Text = table.Rows[0]["cSeason_Name"].ToString();
            this.txtStore.Text = table.Rows[0]["cStore_Name"].ToString();
            this.txtOrdqtysum.Text = table.Rows[0]["nTotOrdQty"].ToString();
            this.grdDelivery.DataSource = this.mybll.get_InformationdataTable("Sp_Smt_OrdersMaster_getforstyledtl '" + this.drpStyleno.SelectedValue + "'");
            this.grdDelivery.DataBind();
            if (this.grdDelivery.Rows.Count > 0)
            {
                this.pnlDelivery.Visible = true;
            }
            this.grdBOM.DataSource = this.blinventory.get_InformationdataTable("Sp_Smt_BOM_getforstyledtl '" + this.drpStyleno.SelectedValue + "'");
            this.grdBOM.DataBind();
            if (this.grdBOM.Rows.Count > 0)
            {
                this.pnlBOM.Visible = true;
                this.chkbom.Checked = true;
                this.chkbom.ForeColor = Color.FromName("#19DD6F");
            }
            this.grdStylesummery.DataSource = this.mybll.get_InformationdataTable("Sp_Smt_GetAssortmentStylesummery1 '" + this.drpStyleno.SelectedValue + "'");
            this.grdStylesummery.DataBind();
            if (this.grdStylesummery.Rows.Count > 0)
            {
                this.pnlassortment.Visible = true;
                this.chkassort.Checked = true;
                this.chkassort.ForeColor = Color.FromName("#19DD6F");
            }
            DataSet set = this.blinventory.get_Informationdataset("Sp_Smt_BOMPORaised '" + this.drpStyleno.SelectedValue + "'");
            this.grdPOPrintingDetail.DataSource = set;
            this.grdPOPrintingDetail.DataBind();
            if (this.grdPOPrintingDetail.Rows.Count > 0)
            {
                this.pnlPOdtl.Visible = true;
                this.chkpo.Checked = true;
                this.chkpo.ForeColor = Color.FromName("#19DD6F");
            }
            this.grdgrn.DataSource = this.blinventory.get_InformationdataTable("Sp_Smt_GoodReceived_Getbystyleid '" + this.drpStyleno.SelectedValue + "'");
            this.grdgrn.DataBind();
            if (this.grdgrn.Rows.Count > 0)
            {
                this.pnlGRN.Visible = true;
                this.chkgrn.Checked = true;
                this.chkgrn.ForeColor = Color.FromName("#19DD6F");
            }
        }
    }

    protected void grdPOPrintingDetail_PreRender(object sender, EventArgs e)
    {
        margePORaise(this.grdPOPrintingDetail);
    }

    protected void grdPOPrintingDetail_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Cells[0].Attributes.Add("style", "text-align:center");
        }
    }

    protected void grdStylesummery_PreRender(object sender, EventArgs e)
    {
        margestylesummery(this.grdStylesummery);
    }

    protected void grdStylesummery_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Cells[0].Attributes.Add("style", "text-align:center");
            e.Row.Cells[1].Attributes.Add("style", "padding-left:5px");
            e.Row.Cells[2].Attributes.Add("style", "text-align:center;padding-right:5px");
            e.Row.Cells[3].Attributes.Add("style", "text-align:right;padding-right:5px");
            if (!string.IsNullOrEmpty(e.Row.Cells[3].Text))
            {
                int num = int.Parse(e.Row.Cells[3].Text);
                this.ttl += num;
            }
        }
        this.grdStylesummery.Columns[3].FooterText = "Total=" + this.ttl.ToString();
        if (e.Row.RowType == DataControlRowType.Footer)
        {
            e.Row.Cells[3].Attributes.Add("style", "text-align:right;padding-right:5px");
        }
    }

    public static void margePORaise(GridView gridView)
    {
        for (int i = gridView.Rows.Count - 2; i >= 0; i--)
        {
            GridViewRow row = gridView.Rows[i];
            GridViewRow row2 = gridView.Rows[i + 1];
            if (row.Cells[0].Text == row2.Cells[0].Text)
            {
                row.Cells[0].RowSpan = (row2.Cells[0].RowSpan < 2) ? 2 : (row2.Cells[0].RowSpan + 1);
                row2.Cells[0].Visible = false;
            }
        }
    }

    public static void margestylesummery(GridView gridView)
    {
        for (int i = gridView.Rows.Count - 2; i >= 0; i--)
        {
            GridViewRow row = gridView.Rows[i];
            GridViewRow row2 = gridView.Rows[i + 1];
            if (row.Cells[1].Text == row2.Cells[1].Text)
            {
                row.Cells[1].RowSpan = (row2.Cells[1].RowSpan < 2) ? 2 : (row2.Cells[1].RowSpan + 1);
                row2.Cells[1].Visible = false;
            }
            if (row.Cells[0].Text == row2.Cells[0].Text)
            {
                row.Cells[0].RowSpan = (row2.Cells[0].RowSpan < 2) ? 2 : (row2.Cells[0].RowSpan + 1);
                row2.Cells[0].Visible = false;
            }
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!base.IsPostBack)
        {
            this.bind();
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}