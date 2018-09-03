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

public partial class Production_RptExport : System.Web.UI.Page
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
            TableName = "Exportreport"
        };
        table2 = this.mybll.get_InformationdataTable("Export_Exprpt " + base.Request.QueryString["x"]);
        merchandising.Tables["Exportreport"].Merge(table2);
        this.rptDoc.Load(base.Server.MapPath("Expreport.rpt"));
        this.rptDoc.SetDataSource((DataSet)merchandising);
        this.rptDoc.SetParameterValue("comp", val);
        this.rptDoc.SetParameterValue("ad", str2 + "," + str3);
        this.rptDoc.SetParameterValue("dat", base.Request.QueryString["x"]);
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

    protected void Page_Unload(object sender, EventArgs e)
    {
        this.rptDoc.Close();
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
