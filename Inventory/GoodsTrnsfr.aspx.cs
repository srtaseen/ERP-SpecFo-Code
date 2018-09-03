using ASP;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Inventory_GoodsTrnsfr : System.Web.UI.Page
{
    private BLLInventory _blinv = new BLLInventory();
    //protected Button btnSave;
    //protected DropDownList drpComp;
    //protected DropDownList drpCompTo;
    //protected DropDownList drpMaincat;
    //protected DropDownList drpSubCat;
    //protected GridView GridView1;
    //protected UpdatePanel UpdatePanel1;

    public void bindcomp()
    {
        this.drpComp.DataSource = this._blinv.get_InformationdataTable("goodstrnsfr_getcomp");
        this.drpComp.DataTextField = "cCmpName";
        this.drpComp.DataValueField = "nCompanyID";
        this.drpComp.DataBind();
        this.drpComp.Items.Insert(0, string.Empty);
    }

    public void bindcompto()
    {
        this.drpCompTo.DataSource = this._blinv.get_InformationdataTable("goodstrnsfr_getcompTo " + this.drpComp.SelectedValue);
        this.drpCompTo.DataTextField = "cCmpName";
        this.drpCompTo.DataValueField = "nCompanyID";
        this.drpCompTo.DataBind();
        this.drpCompTo.Items.Insert(0, string.Empty);
    }

    public void bindMcat()
    {
        this.drpMaincat.DataSource = this._blinv.get_InformationdataTable("goodstrnsfr_getmcat " + this.drpComp.SelectedValue);
        this.drpMaincat.DataTextField = "cMainCategory";
        this.drpMaincat.DataValueField = "MCatid";
        this.drpMaincat.DataBind();
        this.drpMaincat.Items.Insert(0, string.Empty);
    }

    public void bindsubcat()
    {
        this.drpSubCat.DataSource = this._blinv.get_InformationdataTable("goodstrnsfr_getsubcat " + this.drpComp.SelectedValue + "," + this.drpMaincat.SelectedValue);
        this.drpSubCat.DataTextField = "cDes";
        this.drpSubCat.DataValueField = "cCode";
        this.drpSubCat.DataBind();
        this.drpSubCat.Items.Insert(0, string.Empty);
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        SqlConnection connection = GetWay.SpecFo_Inventorycon;
        SqlTransaction transaction = null;
        try
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            for (int i = 0; i < this.GridView1.Rows.Count; i++)
            {
                CheckBox box = (CheckBox)this.GridView1.Rows[i].FindControl("chkItem");
                if (box.Checked)
                {
                    Label label2 = (Label)this.GridView1.Rows[i].FindControl("lblItmcode");
                    TextBox box2 = (TextBox)this.GridView1.Rows[i].FindControl("txtTrnsQty");
                    SqlCommand command = new SqlCommand("", connection, transaction)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    command.Parameters.AddWithValue("@ItemCode", label2.Text.Trim());
                    command.Parameters.AddWithValue("@txtTrnsQty", box2.Text.Trim());
                    command.Parameters.AddWithValue("@param1", "aa");
                    command.Parameters.AddWithValue("@param1", "aa");
                    command.ExecuteNonQuery();
                }
            }
            transaction.Commit();
        }
        catch (Exception exception)
        {
            label.Text = exception.Message;
            transaction.Rollback();
        }
        finally
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }

    protected void drpComp_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.drpMaincat.Items.Clear();
        this.drpSubCat.Items.Clear();
        if (!string.IsNullOrEmpty(this.drpComp.SelectedValue))
        {
            this.bindMcat();
        }
    }

    protected void drpMaincat_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.drpSubCat.Items.Clear();
        if (!string.IsNullOrEmpty(this.drpMaincat.SelectedValue))
        {
            this.bindsubcat();
        }
    }

    protected void drpSubCat_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.GridView1.DataSource = this._blinv.get_InformationdataTable("goodstrnsfr_getitem " + this.drpComp.SelectedValue + "," + this.drpMaincat.SelectedValue + "," + this.drpSubCat.SelectedValue);
        this.GridView1.DataBind();
        this.bindcompto();
    }

    protected void GridView1_PreRender(object sender, EventArgs e)
    {
        margePORaise(this.GridView1);
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
            if ((row.Cells[0].Text == row2.Cells[0].Text) && (row.Cells[1].Text == row2.Cells[1].Text))
            {
                row.Cells[1].RowSpan = (row2.Cells[1].RowSpan < 2) ? 2 : (row2.Cells[1].RowSpan + 1);
                row2.Cells[1].Visible = false;
            }
            if (((row.Cells[0].Text == row2.Cells[0].Text) && (row.Cells[1].Text == row2.Cells[1].Text)) && (row.Cells[2].Text == row2.Cells[2].Text))
            {
                row.Cells[2].RowSpan = (row2.Cells[2].RowSpan < 2) ? 2 : (row2.Cells[2].RowSpan + 1);
                row2.Cells[2].Visible = false;
            }
            if (((row.Cells[0].Text == row2.Cells[0].Text) && (row.Cells[1].Text == row2.Cells[1].Text)) && ((row.Cells[2].Text == row2.Cells[2].Text) && (row.Cells[3].Text == row2.Cells[3].Text)))
            {
                row.Cells[3].RowSpan = (row2.Cells[3].RowSpan < 2) ? 2 : (row2.Cells[3].RowSpan + 1);
                row2.Cells[3].Visible = false;
            }
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!base.IsPostBack)
        {
            this.bindcomp();
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}