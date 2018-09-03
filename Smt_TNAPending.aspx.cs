using AjaxControlToolkit;
using ASP;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Smt_TNAPending : System.Web.UI.Page
{
    private BLL _bl = new BLL();
    private int _red;
    private int _ylo;
    //protected Button btnSearch;
    //protected ImageButton cal5;
    //protected ImageButton cal6;
    //protected CalendarExtender CalendarExtender1;
    //protected DropDownList drpActionType;
    //protected GridView grdstatus;
    //protected Label lblyellow;
    //protected TextBox txtdeptid;
    //protected TextBox txtFromdate;
    //protected CalendarExtender txtoriginalrcvd_CalendarExtender;
    //protected Label txtpending;
    //protected TextBox txtTodate;
    //protected UpdatePanel UpdatePanel4;

    public void acttype()
    {
        DataTable table = this._bl.get_InformationdataTable("select distinct Acttype_Code,Action_Type from Smt_ActionType order by Action_Type");
        this.drpActionType.DataSource = table;
        this.drpActionType.DataTextField = "Action_Type";
        this.drpActionType.DataValueField = "Acttype_Code";
        this.drpActionType.DataBind();
    }

    protected void btn1_clc(object sender, EventArgs e)
    {
        GridViewRow parent = ((Button)sender).Parent.Parent as GridViewRow;
        Button button = (Button)sender;
        string iD = button.ID;
        string commandArgument = button.CommandArgument;
        Button button1 = (Button)parent.FindControl(iD);
        Label label = (Label)parent.FindControl("lblStyleid");
        Label label2 = (Label)parent.FindControl("lblLot");
        string text = this.grdstatus.HeaderRow.Cells[int.Parse(commandArgument)].Text;
        Label label3 = (Label)base.Master.FindControl("lbltotalinfo");
        SqlConnection specFoCon = GetWay.SpecFoCon;
        try
        {
            SqlCommand command = new SqlCommand("Sp_Smt_OTS_updatestatus", specFoCon);
            if (specFoCon.State == ConnectionState.Closed)
            {
                specFoCon.Open();
            }
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@styleid", label.Text);
            command.Parameters.AddWithValue("@lot", label2.Text);
            command.Parameters.AddWithValue("@actiondesc", text);
            command.Parameters.AddWithValue("@userid", this.Session["Uid"].ToString());
            command.ExecuteNonQuery();
            label3.Text = "";
            this.btnSearch_Click(null, null);
        }
        catch (Exception exception)
        {
            label3.Text = exception.Message;
        }
        finally
        {
            if (specFoCon.State == ConnectionState.Open)
            {
                specFoCon.Close();
            }
        }
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        try
        {
            this.grdstatus.DataSource = null;
            this.grdstatus.DataBind();
            this.grdstatus.DataSource = this._bl.get_InformationdataTable("Sp_Smt_TnA_TaskDisplayRPT '" + this.txtFromdate.Text + "','" + this.txtTodate.Text + "'," + this.drpActionType.SelectedValue);
            this.grdstatus.DataBind();
            int count = this.grdstatus.Rows.Count;
        }
        catch (Exception exception)
        {
            label.Text = exception.Message;
        }
    }

    protected void grdstatus_PreRender(object sender, EventArgs e)
    {
        margePORaise(this.grdstatus);
    }

    protected void grdstatus_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.Header)
        {
            DataTable table = this._bl.get_InformationdataTable("Sp_Smt_TnA_TaskDisplayRPT '" + this.txtFromdate.Text + "','" + this.txtTodate.Text + "'," + this.drpActionType.SelectedValue);
            if (table.Rows.Count > 0)
            {
                for (int i = 2; i < (table.Columns.Count - 2); i++)
                {
                    e.Row.Cells[i].Text = table.Rows[0].Table.Columns[i + 2].ToString();
                }
            }
            int num2 = table.Columns.Count - 2;
            if (this.grdstatus.Columns.Count > num2)
            {
                for (int j = num2; j < this.grdstatus.Columns.Count; j++)
                {
                    this.grdstatus.Columns[j].Visible = false;
                }
            }
        }
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            DataRowView dataItem = (DataRowView)e.Row.DataItem;
            DataTable table2 = this._bl.get_InformationdataTable("Sp_Smt_TnA_TaskDisplayRPT '" + this.txtFromdate.Text + "','" + this.txtTodate.Text + "'," + this.drpActionType.SelectedValue);
            for (int k = 4; k < table2.Columns.Count; k++)
            {
                string id = "lbl" + (k - 3);
                Label label = (Label)e.Row.FindControl(id);
                label.Text = Convert.ToString(dataItem[k]);
            }
            Label label2 = (Label)e.Row.FindControl("lblStyleid");
            Label label3 = (Label)e.Row.FindControl("lblLot");
            for (int m = 2; m < table2.Columns.Count; m++)
            {
                string str2 = "lbla" + (m - 1);
                Label label4 = (Label)e.Row.FindControl(str2);
                string text = this.grdstatus.HeaderRow.Cells[m].Text;
                DataTable table3 = this._bl.get_InformationdataTable("Sp_smt_OTS_getactdt " + label2.Text + ",'" + label3.Text + "','" + text + "'");
                if (table3.Rows.Count > 0)
                {
                    label4.Text = table3.Rows[0]["Cmpltdt"].ToString();
                    if (!string.IsNullOrEmpty(label4.Text))
                    {
                        label4.Visible = true;
                    }
                    else
                    {
                        label4.Visible = true;
                        label4.Text = "Not Ok";
                    }
                }
            }
        }
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            for (int n = 2; n < this.grdstatus.Columns.Count; n++)
            {
                string str4 = "lbl" + (n - 1);
                Label label5 = (Label)e.Row.FindControl(str4);
                string str5 = "lbla" + (n - 1);
                Label label6 = (Label)e.Row.FindControl(str5);
                if (!string.IsNullOrEmpty(label5.Text) && (label6.Text == "Not Ok"))
                {
                    DateTime time = DateTime.Parse(label5.Text);
                    if (time < DateTime.Now)
                    {
                        label5.BackColor = Color.FromName("#F3B4DB");
                        this._red++;
                    }
                    DateTime time2 = DateTime.Now.AddDays(7.0);
                    if ((time >= DateTime.Now) && (time <= time2))
                    {
                        label5.BackColor = Color.FromName("#E3D01C");
                        this._ylo++;
                    }
                }
            }
        }
        this.txtpending.Text = this._red.ToString();
        this.lblyellow.Text = this._ylo.ToString();
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

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!base.IsPostBack)
        {
            this.acttype();
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
