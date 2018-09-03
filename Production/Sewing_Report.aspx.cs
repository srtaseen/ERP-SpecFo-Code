using AjaxControlToolkit;
using ASP;
using C1.Web.UI.Controls.C1TabControl;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Production_Sewing_Report : System.Web.UI.Page
{
    private BLL _bl = new BLL();
    //protected Button btnsrc;
    //protected Button btnsrcrmg;
    //protected C1.Web.UI.Controls.C1TabControl.C1TabControl C1TabControl1;
    //protected C1TabPage C1TabPage1;
    //protected C1TabPage C1TabPage2;
    //protected ImageButton cal1;
    //protected ImageButton cal2;
    //protected CalendarExtender CalendarExtender1;
    private SqlConnection cn = GetWay.SpecFo_Smartcode;
    private decimal cutacv;
    private decimal cuttrgt;
    //protected DropDownList drpcompany;
    private decimal expn;
    private int FinishAchv;
    private decimal Finishtrgt;
    private decimal fob;
    //protected GridView GridView1;
    //protected GridView GridView2;
    private int hlper;
    private decimal hlpr;
    private decimal hr1;
    private decimal hr10;
    private decimal hr11;
    private decimal hr12;
    private decimal hr2;
    private decimal hr3;
    private decimal hr4;
    private decimal hr5;
    private decimal hr6;
    private decimal hr7;
    private decimal hr8;
    private decimal hr9;
    private decimal hrgr;
    private decimal inptacv;
    private decimal inpttrg;
    //protected Label Label5;
    private int mo;
    private decimal Mo;
    private DAL mycls = new DAL();
    //protected RequiredFieldValidator RequiredFieldValidator1;
    //protected ValidatorCalloutExtender RequiredFieldValidator1_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator2;
    //protected ValidatorCalloutExtender RequiredFieldValidator2_ValidatorCalloutExtender;
    private decimal smvarc;
    private decimal smvtrg;
    private decimal stchacv;
    private decimal stchtrgt;
    //protected Timer Timer1;
    private decimal trgt;
    private decimal ttlfob;
    //protected TextBox txtDate;
    //protected CalendarExtender txtDate_CalendarExtender;
    //protected TextBox txtDatermg;
    //protected UpdatePanel UpdatePanel1;
    //protected UpdatePanel UpdatePanel2;
    //protected UpdatePanel UpdatePanel5;

    public void binddrp()
    {
        this.drpcompany.DataSource = this._bl.get_InformationdataTable("select nCompanyID,cCmpName from Smt_Company");
        this.drpcompany.DataTextField = "cCmpName";
        this.drpcompany.DataValueField = "nCompanyID";
        this.drpcompany.DataBind();
        this.drpcompany.Items.Insert(0, string.Empty);
    }

    protected void btnsrc_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        try
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Sp_rsHrsProdcutionReport '" + this.txtDate.Text + "'," + this.drpcompany.SelectedValue, this.cn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            this.GridView1.DataSource = dataSet;
            this.GridView1.DataBind();
            label.Text = "No Line Found";
            if (this.GridView1.Rows.Count > 0)
            {
                label.Text = "";
            }
        }
        catch (Exception exception)
        {
            label.Text = exception.Message;
        }
    }

    protected void btnsrcrmg_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        try
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Sp_rsWebGroupSummary '" + this.txtDatermg.Text + "'", this.cn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            this.GridView2.DataSource = dataSet;
            this.GridView2.DataBind();
            label.Text = "No Line Found";
            if (this.GridView2.Rows.Count > 0)
            {
                label.Text = "";
            }
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
            Label label = (Label)e.Row.FindControl("lbllineid");
            SqlDataAdapter adapter = new SqlDataAdapter("Sp_rsHrsProdcutionReport1 '" + this.txtDate.Text + "'," + this.drpcompany.SelectedValue + "," + label.Text.Trim(), this.cn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            string str = "0";
            if (dataTable.Rows.Count > 0)
            {
                str = dataTable.Rows[0]["shortqty"].ToString();
                e.Row.Cells[20].Text = str;
            }
            string str2 = e.Row.Cells[7].Text.Trim();
            if (!string.IsNullOrEmpty(str2))
            {
                this.hr1 += decimal.Parse(str2);
            }
            string str3 = e.Row.Cells[8].Text.Trim();
            if (!string.IsNullOrEmpty(str3))
            {
                this.hr2 += decimal.Parse(str3);
            }
            string str4 = e.Row.Cells[9].Text.Trim();
            if (!string.IsNullOrEmpty(str4))
            {
                this.hr3 += decimal.Parse(str4);
            }
            string str5 = e.Row.Cells[10].Text.Trim();
            if (!string.IsNullOrEmpty(str5))
            {
                this.hr4 += decimal.Parse(str5);
            }
            string str6 = e.Row.Cells[11].Text.Trim();
            if (!string.IsNullOrEmpty(str6))
            {
                this.hr5 += decimal.Parse(str6);
            }
            string str7 = e.Row.Cells[12].Text.Trim();
            if (!string.IsNullOrEmpty(str7))
            {
                this.hr6 += decimal.Parse(str7);
            }
            string str8 = e.Row.Cells[13].Text.Trim();
            if (!string.IsNullOrEmpty(str8))
            {
                this.hr7 += decimal.Parse(str8);
            }
            string str9 = e.Row.Cells[14].Text.Trim();
            if (!string.IsNullOrEmpty(str9))
            {
                this.hr8 += decimal.Parse(str9);
            }
            string str10 = e.Row.Cells[15].Text.Trim();
            if (!string.IsNullOrEmpty(str10))
            {
                this.hr9 += decimal.Parse(str10);
            }
            string str11 = e.Row.Cells[0x10].Text.Trim();
            if (!string.IsNullOrEmpty(str11))
            {
                this.hr10 += decimal.Parse(str11);
            }
            string str12 = e.Row.Cells[0x11].Text.Trim();
            if (!string.IsNullOrEmpty(str12))
            {
                this.hr11 += decimal.Parse(str12);
            }
            string str13 = e.Row.Cells[0x12].Text.Trim();
            if (!string.IsNullOrEmpty(str13))
            {
                this.hr12 += decimal.Parse(str13);
            }
            string str14 = e.Row.Cells[1].Text.Trim();
            if (!string.IsNullOrEmpty(str14))
            {
                this.Mo += decimal.Parse(str14);
            }
            string str15 = e.Row.Cells[2].Text.Trim();
            if (!string.IsNullOrEmpty(str15))
            {
                this.hlpr += decimal.Parse(str15);
            }
            string str16 = e.Row.Cells[6].Text.Trim();
            if (!string.IsNullOrEmpty(str16))
            {
                this.trgt += decimal.Parse(str16);
            }
            string str17 = e.Row.Cells[20].Text.Trim();
            if (!string.IsNullOrEmpty(str17))
            {
                this.expn += decimal.Parse(str17);
            }
            string str18 = e.Row.Cells[0x15].Text.Trim();
            if (!string.IsNullOrEmpty(str18))
            {
                this.ttlfob += decimal.Parse(str18);
            }
        }
        if (e.Row.RowType == DataControlRowType.Footer)
        {
            e.Row.Cells[7].Text = this.hr1.ToString();
            e.Row.Cells[8].Text = this.hr2.ToString();
            e.Row.Cells[9].Text = this.hr3.ToString();
            e.Row.Cells[10].Text = this.hr4.ToString();
            e.Row.Cells[11].Text = this.hr5.ToString();
            e.Row.Cells[12].Text = this.hr6.ToString();
            e.Row.Cells[13].Text = this.hr7.ToString();
            e.Row.Cells[14].Text = this.hr8.ToString();
            e.Row.Cells[15].Text = this.hr9.ToString();
            e.Row.Cells[0x10].Text = this.hr10.ToString();
            e.Row.Cells[0x11].Text = this.hr11.ToString();
            e.Row.Cells[0x12].Text = this.hr12.ToString();
            e.Row.Cells[0x13].Text = (((((((((((this.hr1 + this.hr2) + this.hr3) + this.hr4) + this.hr5) + this.hr6) + this.hr7) + this.hr8) + this.hr9) + this.hr10) + this.hr11) + this.hr12).ToString();
            e.Row.Cells[20].Text = this.expn.ToString();
            e.Row.Cells[0x15].Text = this.ttlfob.ToString();
            SqlDataAdapter adapter2 = new SqlDataAdapter("Hourlyrpt_getftr '" + this.txtDate.Text + "'," + this.drpcompany.SelectedValue, this.cn);
            DataTable table2 = new DataTable();
            adapter2.Fill(table2);
            if (table2.Rows.Count > 0)
            {
                e.Row.Cells[1].Text = table2.Rows[0]["nMo"].ToString();
                e.Row.Cells[2].Text = table2.Rows[0]["nHP"].ToString();
                e.Row.Cells[6].Text = table2.Rows[0]["DTgt"].ToString();
            }
        }
    }

    protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label label = (Label)e.Row.FindControl("lblCompid");
            DataTable table = this._bl.get_InformationdataTable("select cCmpName from Smt_Company where nCompanyID=" + label.Text.Trim());
            if (table.Rows.Count > 0)
            {
                Label label2 = (Label)e.Row.FindControl("lblcompname");
                label2.Text = table.Rows[0]["cCmpName"].ToString();
                string str = e.Row.Cells[2].Text.Trim();
                if (!string.IsNullOrEmpty(str))
                {
                    this.cuttrgt += decimal.Parse(str);
                }
                string str2 = e.Row.Cells[1].Text.Trim();
                if (!string.IsNullOrEmpty(str2))
                {
                    this.cutacv += decimal.Parse(str2);
                }
                string str3 = e.Row.Cells[4].Text.Trim();
                if (!string.IsNullOrEmpty(str3))
                {
                    this.inptacv += decimal.Parse(str3);
                }
                string str4 = e.Row.Cells[3].Text.Trim();
                if (!string.IsNullOrEmpty(str4))
                {
                    this.inpttrg += decimal.Parse(str4);
                }
                string str5 = e.Row.Cells[5].Text.Trim();
                if (!string.IsNullOrEmpty(str5))
                {
                    this.stchtrgt += decimal.Parse(str5);
                }
                string str6 = e.Row.Cells[6].Text.Trim();
                if (!string.IsNullOrEmpty(str6))
                {
                    this.stchacv += decimal.Parse(str6);
                }
                string str7 = e.Row.Cells[7].Text.Trim();
                if (!string.IsNullOrEmpty(str7))
                {
                    this.smvtrg += decimal.Parse(str7);
                }
                string str8 = e.Row.Cells[8].Text.Trim();
                if (!string.IsNullOrEmpty(str8))
                {
                    this.smvarc += decimal.Parse(str8);
                }
                string str9 = e.Row.Cells[9].Text.Trim();
                if (!string.IsNullOrEmpty(str9))
                {
                    this.Finishtrgt += decimal.Parse(str9);
                }
                string str10 = e.Row.Cells[10].Text.Trim();
                if (!string.IsNullOrEmpty(str10))
                {
                    this.FinishAchv += int.Parse(str10);
                }
                string str11 = e.Row.Cells[13].Text.Trim();
                if (!string.IsNullOrEmpty(str11))
                {
                    this.hlper += int.Parse(str11);
                }
                string str12 = e.Row.Cells[12].Text.Trim();
                if (!string.IsNullOrEmpty(str12))
                {
                    this.mo += int.Parse(str12);
                }
                string str13 = e.Row.Cells[11].Text.Trim();
                if (!string.IsNullOrEmpty(str13))
                {
                    this.fob += int.Parse(str13);
                }
            }
        }
        if (e.Row.RowType == DataControlRowType.Footer)
        {
            e.Row.Cells[2].Text = this.cuttrgt.ToString();
            e.Row.Cells[1].Text = this.cutacv.ToString();
            e.Row.Cells[4].Text = this.inptacv.ToString();
            e.Row.Cells[3].Text = this.inpttrg.ToString();
            e.Row.Cells[5].Text = this.stchtrgt.ToString();
            e.Row.Cells[6].Text = this.stchacv.ToString();
            e.Row.Cells[7].Text = this.smvtrg.ToString();
            e.Row.Cells[8].Text = this.smvarc.ToString();
            e.Row.Cells[9].Text = this.Finishtrgt.ToString();
            e.Row.Cells[10].Text = this.FinishAchv.ToString();
            e.Row.Cells[11].Text = this.fob.ToString();
            e.Row.Cells[12].Text = this.mo.ToString();
            e.Row.Cells[13].Text = this.hlper.ToString();
        }
        if (e.Row.RowType == DataControlRowType.Header)
        {
            GridView view1 = (GridView)sender;
            GridViewRow child = new GridViewRow(0, 0, DataControlRowType.Header, DataControlRowState.Insert);
            TableCell cell = new TableCell
            {
                Text = "Company",
                HorizontalAlign = HorizontalAlign.Center,
                ColumnSpan = 1
            };
            child.Cells.Add(cell);
            cell = new TableCell
            {
                Text = "CUTTING",
                HorizontalAlign = HorizontalAlign.Center,
                ColumnSpan = 2
            };
            child.Cells.Add(cell);
            cell = new TableCell
            {
                Text = "INPUT",
                HorizontalAlign = HorizontalAlign.Center,
                ColumnSpan = 2
            };
            child.Cells.Add(cell);
            cell = new TableCell
            {
                Text = "STITCHING",
                HorizontalAlign = HorizontalAlign.Center,
                ColumnSpan = 2
            };
            child.Cells.Add(cell);
            cell = new TableCell
            {
                Text = "SMV",
                HorizontalAlign = HorizontalAlign.Center,
                ColumnSpan = 2
            };
            child.Cells.Add(cell);
            cell = new TableCell
            {
                Text = "FINISH GOODS",
                HorizontalAlign = HorizontalAlign.Center,
                ColumnSpan = 2
            };
            child.Cells.Add(cell);
            cell = new TableCell
            {
                Text = "OTHERS",
                HorizontalAlign = HorizontalAlign.Center,
                ColumnSpan = 3
            };
            child.Cells.Add(cell);
            this.GridView2.Controls[0].Controls.AddAt(0, child);
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
                row.Cells[1].RowSpan = (row2.Cells[1].RowSpan < 2) ? 2 : (row2.Cells[1].RowSpan + 1);
                row2.Cells[1].Visible = false;
                row.Cells[2].RowSpan = (row2.Cells[2].RowSpan < 2) ? 2 : (row2.Cells[2].RowSpan + 1);
                row2.Cells[2].Visible = false;
                row.Cells[6].RowSpan = (row2.Cells[6].RowSpan < 2) ? 2 : (row2.Cells[6].RowSpan + 1);
                row2.Cells[6].Visible = false;
                row.Cells[20].RowSpan = (row2.Cells[20].RowSpan < 2) ? 2 : (row2.Cells[20].RowSpan + 1);
                row2.Cells[20].Visible = false;
            }
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!base.IsPostBack)
        {
            

            //this.txtDate.Text = $"{DateTime.Now:dd-MMM-yyyy}".ToString();

            this.txtDate.Text = DateTime.Now.ToShortDateString();

            this.binddrp();
            //this.txtDatermg.Text = $"{DateTime.Now:dd-MMM-yyyy}";

            this.txtDatermg.Text = DateTime.Now.ToShortDateString();

            if (!string.IsNullOrEmpty(this.txtDatermg.Text.Trim()))
            {
                this.btnsrcrmg_Click(null, null);
            }
        }
    }

    protected void Timer1_Tick(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(this.txtDatermg.Text.Trim()))
        {
            this.btnsrcrmg_Click(null, null);
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
