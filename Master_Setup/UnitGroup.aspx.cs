using ASP;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Master_Setup_UnitGroup : System.Web.UI.Page
{
    private BLLInventory _blinv = new BLLInventory();
    //protected Button btnSave;
    private SqlConnection cn = GetWay.SpecFo_Inventorycon;
    //protected HtmlForm form1;
    //protected GridView grdsaved;
    //protected GridView grdUnitlist;
    //protected HtmlHead Head1;
    //protected Label lblErrmsg;
    //protected ScriptManager ScriptManager1;
    //protected TextBox txtGroup;
    //protected UpdatePanel UpdatePanel1;

    public void BIND()
    {
        this.grdUnitlist.DataSource = this._blinv.get_InformationdataTable("OrdUnit_getforgroup");
        this.grdUnitlist.DataBind();
    }

    public void BINDsave()
    {
        this.grdsaved.DataSource = this._blinv.get_InformationdataTable("OrdUnitgrp_getsaved");
        this.grdsaved.DataBind();
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        SqlTransaction transaction = null;
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        transaction = this.cn.BeginTransaction();
        try
        {
            SqlCommand command = new SqlCommand("OrdUnitgrp_save", this.cn, transaction)
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@UNitGRoupName", this.txtGroup.Text.ToUpper().Trim());
            command.ExecuteNonQuery();
            for (int i = 0; i < this.grdUnitlist.Rows.Count; i++)
            {
                CheckBox box = (CheckBox)this.grdUnitlist.Rows[i].FindControl("chkselect");
                if (box.Checked)
                {
                    Label label = (Label)this.grdUnitlist.Rows[i].FindControl("lblUnitcode");
                    SqlCommand command2 = new SqlCommand("OrdUnit_Updategrp", this.cn, transaction)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    command2.Parameters.AddWithValue("@UNitGRoupName", this.txtGroup.Text.ToUpper().Trim());
                    command2.Parameters.AddWithValue("@UnitID", label.Text.Trim());
                    command2.ExecuteNonQuery();
                }
            }
            transaction.Commit();
            this.lblErrmsg.Text = "Saved Successfully";
            this.BIND();
            this.BINDsave();
            this.txtGroup.Text = "";
            this.txtGroup.Focus();
        }
        catch (Exception exception)
        {
            this.lblErrmsg.Text = exception.Message;
            transaction.Rollback();
        }
        finally
        {
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    protected void grdsaved_PreRender(object sender, EventArgs e)
    {
        MergeRowsColorsensitivity(this.grdsaved);
    }

    public static void MergeRowsColorsensitivity(GridView gridView)
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

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!base.IsPostBack)
        {
            this.BIND();
            this.BINDsave();
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}