using ASP;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Production_Expqtysave : System.Web.UI.Page
{
    //protected Button btnSave;
    //protected DropDownList drpColor;
    //protected HtmlForm form1;
    //protected GridView GridView1;
    private DALInventory InventoryCls = new DALInventory();
    //protected Label lblerrmsg;
    //protected Label lblPO;
    //protected Label lblStyleID;
    private BLL mybll = new BLL();
    private DAL mycls = new DAL();
    //protected ScriptManager ScriptManager1;
    //protected TextBox txtPO;
    //protected TextBox txtPOQty;
    //protected TextBox txtStyle;
    //protected UpdatePanel UpdatePanel1;

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (this.GridView1.Rows.Count > 0)
        {
            SqlConnection specFoCon = GetWay.SpecFoCon;
            SqlTransaction transaction = null;
            if (specFoCon.State == ConnectionState.Closed)
            {
                specFoCon.Open();
            }
            transaction = specFoCon.BeginTransaction();
            try
            {
                for (int i = 0; i < this.GridView1.Rows.Count; i++)
                {
                    Label label = (Label)this.GridView1.Rows[i].FindControl("lblSizeid");
                    TextBox box = (TextBox)this.GridView1.Rows[i].FindControl("txtInputqty");
                    SqlCommand command = new SqlCommand("Export_Save", specFoCon, transaction)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    command.Parameters.AddWithValue("@StyleID", this.lblStyleID.Text);
                    command.Parameters.AddWithValue("@Lot", this.lblPO.Text);
                    command.Parameters.AddWithValue("@Colorid", this.drpColor.SelectedValue);
                    command.Parameters.AddWithValue("@SizeID", label.Text);
                    command.Parameters.AddWithValue("@ShpQty", string.IsNullOrEmpty(box.Text) ? "0" : box.Text);
                    command.Parameters.AddWithValue("@Entryby", this.Session["Uid"].ToString());
                    command.ExecuteNonQuery();
                }
                transaction.Commit();
                this.lblerrmsg.Text = "Saved Successfull";
                this.drpColor_SelectedIndexChanged(null, null);
            }
            catch (Exception exception)
            {
                this.lblerrmsg.Text = exception.Message;
                transaction.Rollback();
            }
            finally
            {
                if (specFoCon.State == ConnectionState.Open)
                {
                    specFoCon.Close();
                }
            }
        }
    }

    protected void drpColor_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.btnSave.Visible = false;
        this.GridView1.DataSource = null;
        this.GridView1.DataBind();
        try
        {
            if (!string.IsNullOrEmpty(this.drpColor.SelectedValue))
            {
                DataTable table = this.mybll.get_InformationdataTable("Export_GetSizebyColorID " + this.lblStyleID.Text + ",'" + this.lblPO.Text + "'," + this.drpColor.SelectedValue);
                this.GridView1.DataSource = table;
                this.GridView1.DataBind();
                if (this.GridView1.Rows.Count > 0)
                {
                    this.btnSave.Visible = true;
                }
            }
        }
        catch (Exception exception)
        {
            this.lblerrmsg.Text = exception.Message;
        }
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label label = (Label)e.Row.FindControl("lblSizeid");
            Label label2 = (Label)e.Row.FindControl("lblsize");
            TextBox box = (TextBox)e.Row.FindControl("txtQqty");
            TextBox box2 = (TextBox)e.Row.FindControl("txtQCqty");
            DataTable table = this.mybll.get_InformationdataTable("Export_getCummulative " + this.lblStyleID.Text + ",'" + this.lblPO.Text + "'," + this.drpColor.SelectedValue + "," + label.Text);
            if (table.Rows.Count > 0)
            {
                box.Text = table.Rows[0][0].ToString();
            }
            DataTable table2 = this.mybll.get_InformationdataTable("Export_getQcOutQty " + this.lblStyleID.Text + ",'" + this.lblPO.Text + "','" + this.drpColor.SelectedItem.Text + "','" + label2.Text + "'");
            if (table2.Rows.Count > 0)
            {
                box2.Text = table2.Rows[0][0].ToString();
            }
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!base.IsPostBack)
        {
            this.lblStyleID.Text = base.Request.QueryString["x"];
            this.lblPO.Text = base.Request.QueryString["y"];
            DataTable table = this.mybll.get_InformationdataTable("Assrt_Smt_OrdersMaster_getpoqty " + this.lblStyleID.Text + ",'" + this.lblPO.Text.Trim() + "'");
            if (table.Rows.Count > 0)
            {
                this.txtStyle.Text = table.Rows[0]["cStyleNo"].ToString();
                this.txtPO.Text = table.Rows[0]["cPoNum"].ToString();
                this.txtPOQty.Text = table.Rows[0]["nOrdQty"].ToString();
                this.drpColor.DataSource = this.mybll.get_InformationdataTable("SELECT distinct  Smt_PackContry.nCol, Smt_Colours.cColour  FROM  Smt_PackContry INNER JOIN Smt_Colours ON Smt_PackContry.nCol = Smt_Colours.nColNo where nstyCd=" + this.lblStyleID.Text + " and cShiId='" + this.lblPO.Text + "' order by cColour");
                this.drpColor.DataTextField = "cColour";
                this.drpColor.DataValueField = "nCol";
                this.drpColor.DataBind();
                this.drpColor.Items.Insert(0, string.Empty);
            }
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
