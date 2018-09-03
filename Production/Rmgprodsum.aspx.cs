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

public partial class Production_Rmgprodsum : System.Web.UI.Page
{
    private BLLInventory _blinventory = new BLLInventory();
    private SqlConnection cn = GetWay.SpecFo_Smartcode;
    //protected HtmlForm form1;
    private BLL mybll = new BLL();

    public DataTable get_InformationdataTable(string sqlstatement)
    {
        SqlDataAdapter adapter = new SqlDataAdapter(sqlstatement, this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        DataTable dataTable = new DataTable();
        adapter.Fill(dataTable);
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        return dataTable;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        string text1 = base.Request.QueryString["x"];
        ReportDocument document = new ReportDocument();
        base.Title = "MERCHENDISING REPORT";
        DataTable table = this.mybll.get_InformationdataTable("select cCmpName,cAdd1,cAdd2 from Smt_Company where Display_AS_Header=1");
        string val = table.Rows[0]["cCmpName"].ToString();
        string str2 = table.Rows[0]["cAdd1"].ToString();
        string str3 = table.Rows[0]["cAdd2"].ToString();
        new Production();
        DataTable table2 = new DataTable
        {
            TableName = "Dlyfinlrlpt"
        };
        document.SetParameterValue("cmp", val);
        document.SetParameterValue("ad1", str2);
        document.SetParameterValue("ad2", str3);
        MemoryStream stream = null;
        stream = (MemoryStream)document.ExportToStream(ExportFormatType.PortableDocFormat);
        HttpContext.Current.Response.Clear();
        HttpContext.Current.Response.Buffer = true;
        HttpContext.Current.Response.ContentType = "application/pdf";
        HttpContext.Current.Response.BinaryWrite(stream.ToArray());
        HttpContext.Current.Response.End();
        document.Close();
        document.Dispose();
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
