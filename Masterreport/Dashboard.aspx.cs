using AjaxControlToolkit;
using ASP;
using System;
using System.Data;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Masterreport_Dashboard : System.Web.UI.Page
{
    private BLL _bl = new BLL();
    //protected Button btnSearch;
    //protected ImageButton cal;
    //protected ImageButton cal2;
    //protected DropDownList drpBuyer;
    //protected GridView GridView1;
    //protected ValidatorCalloutExtender RequiredFieldValidator1_ValidatorCalloutExtender;
    //protected ValidatorCalloutExtender RequiredFieldValidator2_ValidatorCalloutExtender;
    //protected RequiredFieldValidator rqFormdt;
    //protected RequiredFieldValidator rqTodate;
    //protected TextBox txtFormdate;
    //protected CalendarExtender txtFormdate_CalendarExtender;
    //protected TextBox txtTodate;
    //protected CalendarExtender txtTodate_CalendarExtender;
    //protected UpdatePanel UpdatePanel1;

    public void bindbir()
    {
        this.drpBuyer.DataSource = this._bl.get_InformationdataTable("SELECT distinct Smt_StyleMaster.nAcct, Smt_BuyerName.cBuyer_Name FROM  Smt_StyleMaster INNER JOIN Smt_BuyerName ON Smt_StyleMaster.nAcct = Smt_BuyerName.nBuyer_ID order by cBuyer_Name");
        this.drpBuyer.DataTextField = "cBuyer_Name";
        this.drpBuyer.DataValueField = "nAcct";
        this.drpBuyer.DataBind();
        this.drpBuyer.Items.Insert(0, new ListItem("All", "0"));
        this.drpBuyer.SelectedIndex = 0;
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        try
        {
            DataTable table = this._bl.get_InformationdataTable("Sp_Smt_OrdersMaster_DshbrdD2D1 '" + this.txtFormdate.Text + "','" + this.txtTodate.Text + "'," + this.drpBuyer.SelectedValue);
            this.GridView1.DataSource = table;
            this.GridView1.DataBind();
        }
        catch (Exception exception)
        {
            label.Text = exception.Message;
        }
    }

    protected void GridView1_PreRender(object sender, EventArgs e)
    {
        margePORaise(this.GridView1);
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            for (int i = 0; i < this.GridView1.Columns.Count; i++)
            {
                e.Row.Cells[i].Attributes.Add("style", "text-align:right; padding-right:2px");
            }
            int num2 = e.Row.RowIndex + 2;
            if (e.Row.Enabled)
            {
                e.Row.Attributes.Add("onclick", string.Concat(new object[] { "javascript:gridrowcolor('", this.GridView1.ClientID, "','", num2, "')" }));
            }
            DataRowView dataItem = (DataRowView)e.Row.DataItem;
            string s = e.Row.Cells[4].Text.Trim();
            string str2 = dataItem["CutQty"].ToString();
            Label label = (Label)e.Row.FindControl("LBLcUTBLANCE");
            HtmlAnchor anchor1 = (HtmlAnchor)e.Row.FindControl("ainputbal");
            decimal num3 = 0M;
            if (!string.IsNullOrEmpty(str2))
            {
                num3 = decimal.Parse(str2);
            }
            if (decimal.Parse(s) > 0M)
            {
                label.Text = (num3 - decimal.Parse(s)).ToString();
            }
            Label label2 = (Label)e.Row.FindControl("LBLINPUTBLNCE");
            string str3 = dataItem["INPUTQTY"].ToString();
            decimal num4 = 0M;
            if (!string.IsNullOrEmpty(str3))
            {
                num4 = decimal.Parse(str3);
            }
            string str4 = (num3 - num4).ToString();
            if (decimal.Parse(str4) > 0M)
            {
                label2.Text = str4.ToString();
            }
        }
        if (e.Row.RowType == DataControlRowType.Header)
        {
            GridView view1 = (GridView)sender;
            GridViewRow child = new GridViewRow(0, 0, DataControlRowType.Header, DataControlRowState.Insert);
            TableCell cell = new TableCell
            {
                Text = "ORDER INFORMATION",
                HorizontalAlign = HorizontalAlign.Center,
                ColumnSpan = 10
            };
            child.Cells.Add(cell);
            cell = new TableCell
            {
                Text = "FABRIC INFORMATION",
                HorizontalAlign = HorizontalAlign.Center,
                ColumnSpan = 5
            };
            child.Cells.Add(cell);
            cell = new TableCell
            {
                Text = "ACCESSORIES",
                HorizontalAlign = HorizontalAlign.Center,
                ColumnSpan = 1
            };
            child.Cells.Add(cell);
            cell = new TableCell
            {
                Text = "CUTTING TO SHIPMENT INFORMATION",
                HorizontalAlign = HorizontalAlign.Center,
                ColumnSpan = 8
            };
            child.Cells.Add(cell);
            this.GridView1.Controls[0].Controls.AddAt(0, child);
        }
    }

    public static void margePORaise(GridView gridView)
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
            if (row.Cells[2].Text == row2.Cells[2].Text)
            {
                row.Cells[2].RowSpan = (row2.Cells[2].RowSpan < 2) ? 2 : (row2.Cells[2].RowSpan + 1);
                row2.Cells[2].Visible = false;
                row.Cells[6].RowSpan = (row2.Cells[6].RowSpan < 2) ? 2 : (row2.Cells[6].RowSpan + 1);
                row2.Cells[6].Visible = false;
                row.Cells[7].RowSpan = (row2.Cells[7].RowSpan < 2) ? 2 : (row2.Cells[7].RowSpan + 1);
                row2.Cells[7].Visible = false;
                row.Cells[8].RowSpan = (row2.Cells[8].RowSpan < 2) ? 2 : (row2.Cells[8].RowSpan + 1);
                row2.Cells[8].Visible = false;
                row.Cells[9].RowSpan = (row2.Cells[9].RowSpan < 2) ? 2 : (row2.Cells[9].RowSpan + 1);
                row2.Cells[9].Visible = false;
                row.Cells[10].RowSpan = (row2.Cells[10].RowSpan < 2) ? 2 : (row2.Cells[10].RowSpan + 1);
                row2.Cells[10].Visible = false;
                row.Cells[12].RowSpan = (row2.Cells[12].RowSpan < 2) ? 2 : (row2.Cells[12].RowSpan + 1);
                row2.Cells[12].Visible = false;
                row.Cells[13].RowSpan = (row2.Cells[13].RowSpan < 2) ? 2 : (row2.Cells[13].RowSpan + 1);
                row2.Cells[13].Visible = false;
                row.Cells[0x10].RowSpan = (row2.Cells[0x10].RowSpan < 2) ? 2 : (row2.Cells[0x10].RowSpan + 1);
                row2.Cells[0x10].Visible = false;
                row.Cells[15].RowSpan = (row2.Cells[15].RowSpan < 2) ? 2 : (row2.Cells[15].RowSpan + 1);
                row2.Cells[15].Visible = false;
            }
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!base.IsPostBack)
        {
            this.bindbir();
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
