using ASP;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;

public partial class Production_Dailyfinlrpt : System.Web.UI.Page
{
    private BLLInventory _blinventory = new BLLInventory();
    private SqlConnection cn = GetWay.SpecFo_Smartcode;
    //protected HtmlForm form1;
    private BLL mybll = new BLL();
    private ReportDocument rptDoc = new ReportDocument();

    public DataTable get_InformationdataTable(string sqlstatement)
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand command = this.cn.CreateCommand();
        command.CommandText = sqlstatement;
        adapter.SelectCommand = command;
        command.CommandTimeout = 600;
        DataTable dataTable = new DataTable();
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        adapter.Fill(dataTable);
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        return dataTable;
    }

    protected void Page_Init(object sender, EventArgs e)
    {
        string text1 = base.Request.QueryString["x"];
        base.Title = "MERCHENDISING REPORT";
        DataTable table = this.mybll.get_InformationdataTable("select cCmpName,cAdd1,cAdd2 from Smt_Company where Display_AS_Header=1");
        string val = table.Rows[0]["cCmpName"].ToString();
        string str2 = table.Rows[0]["cAdd1"].ToString();
        string str3 = table.Rows[0]["cAdd2"].ToString();
        Production production = new Production();
        DataTable table2 = new DataTable
        {
            TableName = "Dlyfinlrlpt"
        };
        table2 = this.get_InformationdataTable("Sp_rsWebDailyFinReport '" + this.Session["dat"].ToString() + "'," + this.Session["comp"].ToString());
        production.Tables["Dlyfinlrlpt"].Merge(table2);
        this.rptDoc.Load(base.Server.MapPath("Dailyfinalrpt.rpt"));
        this.rptDoc.SetDataSource((DataSet)production);
        this.rptDoc.SetParameterValue("cmp", val);
        this.rptDoc.SetParameterValue("ad1", str2);
        this.rptDoc.SetParameterValue("ad2", str3);
        this.rptDoc.SetParameterValue("prddt", this.Session["dat"].ToString());
        this.rptDoc.SetParameterValue("cmpname", this.Session["cmpname"].ToString());
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
