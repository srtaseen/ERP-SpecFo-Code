using ASP;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Data;
using System.IO;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;

public partial class Production_Rptgatepass : System.Web.UI.Page
{
    private BLLInventory _blinventory = new BLLInventory();
    //protected HtmlForm form1;
    private BLL mybll = new BLL();
    private ReportDocument rptDoc = new ReportDocument();

    protected void Page_Init(object sender, EventArgs e)
    {
        base.Title = "MERCHENDISING REPORT";
        DataTable table = this.mybll.get_InformationdataTable("select cCmpName,cAdd1,cAdd2 from Smt_Company where Display_AS_Header=1");
        string val = table.Rows[0]["cCmpName"].ToString();
        string str2 = table.Rows[0]["cAdd1"].ToString();
        string str3 = table.Rows[0]["cAdd2"].ToString();
        Merchandising merchandising = new Merchandising();
        new DataTable();
        DataTable table2 = new DataTable
        {
            TableName = "export_rpt"
        };
        table2 = this.mybll.get_InformationdataTable("Export_Gatepassrpt '" + base.Request.QueryString["x"] + "','" + base.Request.QueryString["y"] + "'");
        merchandising.Tables["export_rpt"].Merge(table2);
        this.rptDoc.Load(base.Server.MapPath("Gatepass.rpt"));
        this.rptDoc.SetDataSource((DataSet)merchandising);
        this.rptDoc.SetParameterValue("cmp", val);
        this.rptDoc.SetParameterValue("Delivery", base.Request.QueryString["z"]);
        this.rptDoc.SetParameterValue("add", str2 + "," + str3);
        DataTable table3 = this.mybll.get_InformationdataTable("Assrt_Smt_OrdersMaster_getpoqty " + base.Request.QueryString["x"] + ",'" + base.Request.QueryString["y"] + "'");
        this.rptDoc.SetParameterValue("Style", table3.Rows[0]["cStyleNo"].ToString());
        this.rptDoc.SetParameterValue("po", table3.Rows[0]["cPoNum"].ToString());
        DataTable table4 = this.mybll.get_InformationdataTable("Export_getuser " + base.Request.QueryString["x"] + ",'" + base.Request.QueryString["y"] + "'");
        this.rptDoc.SetParameterValue("usr", table4.Rows[0]["cUserFullname"].ToString());
        this.rptDoc.SetParameterValue("dt", table4.Rows[0]["Entrydt"].ToString());
        MemoryStream stream = null;
        stream = (MemoryStream)this.rptDoc.ExportToStream(ExportFormatType.PortableDocFormat);
        HttpContext.Current.Response.Clear();
        HttpContext.Current.Response.Buffer = true;
        HttpContext.Current.Response.ContentType = "application/pdf";
        HttpContext.Current.Response.BinaryWrite(stream.ToArray());
        HttpContext.Current.Response.End();
        this.rptDoc.Close();
        this.rptDoc.Dispose();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void Page_Unload(object sender, EventArgs e)
    {
        this.rptDoc.Close();
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
