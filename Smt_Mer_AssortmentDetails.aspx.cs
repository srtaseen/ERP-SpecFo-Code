using AjaxControlToolkit;
using ASP;
using System;
using System.Data;
using System.Drawing;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Smt_Mer_AssortmentDetails_New : System.Web.UI.Page
{
    //protected HtmlInputButton btcompleted0;
    //protected HtmlInputButton btnotstrt0;
    //protected Button btnppgntpo;
    //protected HtmlImage btnsrc;
    //protected HtmlInputButton btpartil0;
    //protected ModalPopupExtender Button2_ModalPopupExtender;
    //protected DropDownList drpstyle;
    //protected HtmlGenericControl Dvnull;
    //protected GridView grdpodtl;
    //protected ImageButton imgstyle;
    private DALInventory InventoryCls = new DALInventory();
    //protected Label lbleliverydtl;
    private BLL mybll = new BLL();
    private DAL mycls = new DAL();
    //protected Panel pnlindication;
    //protected TextBox txtBrand;
    //protected TextBox txtBuyer;
    //protected TextBox txtGmtdept;
    //protected TextBox txtGmttype;
    //protected TextBox txtLot;
    //protected TextBox txtSeason;
    //protected UpdatePanel UpdatePanel1;

    public void bindStyleid()
    {
        DataTable table = this.mybll.get_InformationdataTable("Sp_Smt_GetStyleID '" + this.Session["Uid"].ToString() + "','A'");
        this.drpstyle.Items.Add(new ListItem("", ""));
        this.drpstyle.DataSource = table;
        this.drpstyle.DataTextField = "StyleNO";
        this.drpstyle.DataValueField = "StyleID";
        this.drpstyle.DataBind();
        this.drpstyle.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpstyle.SelectedIndex = 0;
    }

    protected void drpstyle_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.lbleliverydtl.Text = "";
        this.grdpodtl.DataSource = null;
        this.grdpodtl.DataBind();
        this.Dvnull.Visible = false;
        this.imgstyle.Visible = false;
        this.txtBrand.Text = "";
        this.txtBuyer.Text = "";
        this.txtGmtdept.Text = "";
        this.txtGmttype.Text = "";
        this.txtLot.Text = "";
        this.txtSeason.Text = "";
        this.btnsrc.Visible = false;
        this.pnlindication.Visible = false;
        if (!string.IsNullOrEmpty(this.drpstyle.SelectedValue))
        {
            this.btnsrc.Visible = true;
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
                this.pnlindication.Visible = true;
            }
            else
            {
                this.Dvnull.Visible = true;
                this.lbleliverydtl.Text = "DELIVERY INFORMATION NOT AVAILABLE.";
            }
        }
    }

    protected void grdpodtl_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Cells[4].Width = 80;
            int num = int.Parse(e.Row.Cells[4].Text.Trim());
            if (num < 1)
            {
                e.Row.Cells[4].BackColor = Color.FromName("#ACF7F6");
                e.Row.Cells[3].BackColor = Color.FromName("#ACF7F6");
                e.Row.Cells[5].BackColor = Color.FromName("#ACF7F6");
            }
            int num2 = int.Parse(e.Row.Cells[5].Text.Trim());
            if (num2 < 1)
            {
                e.Row.Cells[3].BackColor = Color.FromName("#E5A0EF");
                e.Row.Cells[4].BackColor = Color.FromName("#E5A0EF");
                e.Row.Cells[5].BackColor = Color.FromName("#E5A0EF");
            }
            if ((num2 > 0) && (num > 0))
            {
                e.Row.Cells[3].BackColor = Color.FromName("#E1F2B1");
                e.Row.Cells[4].BackColor = Color.FromName("#E1F2B1");
                e.Row.Cells[5].BackColor = Color.FromName("#E1F2B1");
            }
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.Session["Uid"] == null)
        {
            base.Response.Redirect("Smt_Login.aspx", false);
        }
        else if (!base.IsPostBack)
        {
            this.bindStyleid();
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
