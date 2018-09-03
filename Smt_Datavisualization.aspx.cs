using AjaxControlToolkit;
using ASP;
using System;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

public partial class Smt_Datavisualization : System.Web.UI.Page
{
    private BLL _bl = new BLL();
    //protected Button btnview;
    //protected ImageButton cal1;
    //protected ImageButton cal2;
    //protected Chart Chart1
    //protected RadioButton rdarea;
    //protected RadioButton rdbar;
    //protected RadioButton rdbubble;
    //protected RadioButton rdbuyer;
    //protected RadioButton rdCmpany;
    //protected RadioButton rdcolumn;
    //protected RadioButton rdfast;
    //protected RadioButton rdfunnel;
    //protected RadioButton rdline;
    //protected RadioButton rdpie;
    //protected RadioButton rdpoint;
    //protected RadioButton rdpointandfigr;
    //protected RadioButton rdpolar;
    //protected RadioButton rdpyramid;
    //protected TextBox txtFormdate;
    //protected CalendarExtender txtFormdate_CalendarExtender;
    //protected TextBox txtTodate;
    //protected CalendarExtender txtTodate_CalendarExtender1;

    public void bind()
    {
        this.Chart1.DataSource = this._bl.get_InformationdataTable("Sp_Smt_OrdersMaster_chartbuyerwise '" + this.txtFormdate.Text + "','" + this.txtTodate.Text + "'");
        this.Chart1.DataBind();
    }

    public void bindcomp()
    {
        this.Chart1.DataSource = this._bl.get_InformationdataTable("Sp_Smt_OrdersMaster_chartCompwise '" + this.txtFormdate.Text + "','" + this.txtTodate.Text + "'");
        this.Chart1.DataBind();
    }

    protected void btnview_Click(object sender, EventArgs e)
    {
        if (this.rdbuyer.Checked)
        {
            this.bind();
        }
        if (this.rdCmpany.Checked)
        {
            this.bindcomp();
        }
        this.Chart1.Series["Series1"].ChartType = SeriesChartType.Column;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void rdarea_CheckedChanged(object sender, EventArgs e)
    {
        if (this.rdbuyer.Checked)
        {
            this.bind();
        }
        if (this.rdCmpany.Checked)
        {
            this.bindcomp();
        }
        this.Chart1.Series["Series1"].ChartType = SeriesChartType.Area;
    }

    protected void rdbar_CheckedChanged(object sender, EventArgs e)
    {
        if (this.rdbuyer.Checked)
        {
            this.bind();
        }
        if (this.rdCmpany.Checked)
        {
            this.bindcomp();
        }
        this.Chart1.Series["Series1"].ChartType = SeriesChartType.Bar;
    }

    protected void rdbubble_CheckedChanged(object sender, EventArgs e)
    {
        if (this.rdbuyer.Checked)
        {
            this.bind();
        }
        if (this.rdCmpany.Checked)
        {
            this.bindcomp();
        }
        this.Chart1.Series["Series1"].ChartType = SeriesChartType.Bubble;
    }

    protected void rdcolumn_CheckedChanged(object sender, EventArgs e)
    {
        if (this.rdbuyer.Checked)
        {
            this.bind();
        }
        if (this.rdCmpany.Checked)
        {
            this.bindcomp();
        }
        this.Chart1.Series["Series1"].ChartType = SeriesChartType.Column;
    }

    protected void rdfast_CheckedChanged(object sender, EventArgs e)
    {
        if (this.rdbuyer.Checked)
        {
            this.bind();
        }
        if (this.rdCmpany.Checked)
        {
            this.bindcomp();
        }
        this.Chart1.Series["Series1"].ChartType = SeriesChartType.FastLine;
    }

    protected void rdfunnel_CheckedChanged(object sender, EventArgs e)
    {
        if (this.rdbuyer.Checked)
        {
            this.bind();
        }
        if (this.rdCmpany.Checked)
        {
            this.bindcomp();
        }
        this.Chart1.Series["Series1"].ChartType = SeriesChartType.Funnel;
    }

    protected void rdline_CheckedChanged(object sender, EventArgs e)
    {
        if (this.rdbuyer.Checked)
        {
            this.bind();
        }
        if (this.rdCmpany.Checked)
        {
            this.bindcomp();
        }
        this.Chart1.Series["Series1"].ChartType = SeriesChartType.Line;
    }

    protected void rdpie_CheckedChanged(object sender, EventArgs e)
    {
        if (this.rdbuyer.Checked)
        {
            this.bind();
        }
        if (this.rdCmpany.Checked)
        {
            this.bindcomp();
        }
        this.Chart1.Series["Series1"].ChartType = SeriesChartType.Pie;
    }

    protected void rdpoint_CheckedChanged(object sender, EventArgs e)
    {
        if (this.rdbuyer.Checked)
        {
            this.bind();
        }
        if (this.rdCmpany.Checked)
        {
            this.bindcomp();
        }
        this.Chart1.Series["Series1"].ChartType = SeriesChartType.Point;
    }

    protected void rdpointandfigr_CheckedChanged(object sender, EventArgs e)
    {
        if (this.rdbuyer.Checked)
        {
            this.bind();
        }
        if (this.rdCmpany.Checked)
        {
            this.bindcomp();
        }
        this.Chart1.Series["Series1"].ChartType = SeriesChartType.PointAndFigure;
    }

    protected void rdpolar_CheckedChanged(object sender, EventArgs e)
    {
        if (this.rdbuyer.Checked)
        {
            this.bind();
        }
        if (this.rdCmpany.Checked)
        {
            this.bindcomp();
        }
        this.Chart1.Series["Series1"].ChartType = SeriesChartType.Polar;
    }

    protected void rdpyramid_CheckedChanged(object sender, EventArgs e)
    {
        if (this.rdbuyer.Checked)
        {
            this.bind();
        }
        if (this.rdCmpany.Checked)
        {
            this.bindcomp();
        }
        this.Chart1.Series["Series1"].ChartType = SeriesChartType.Pyramid;
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
