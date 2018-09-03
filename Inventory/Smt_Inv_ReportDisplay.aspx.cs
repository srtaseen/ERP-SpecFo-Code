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

public partial class Inventory_Smt_Inv_ReportDisplay : System.Web.UI.Page
{
    private BLLInventory _blInventory = new BLLInventory();
    //protected HtmlForm form1;
    private BLL mybll = new BLL();
    private ReportDocument rptDoc = new ReportDocument();

    public void Companylogo(Inventory ds)
    {
        DataTable table = new DataTable();
        DataSet set = this.mybll.get_Informationdataset("SELECT lgo FROM Smt_Company where Display_AS_Header=1");
        if (set.Tables[0].Rows.Count > 0)
        {
            FileStream stream;
            table.Columns.Add("lgo", Type.GetType("System.Byte[]"));
            DataRow row = table.NewRow();
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"rptsv\" + set.Tables[0].Rows[0]["lgo"].ToString()))
            {
                stream = new FileStream(AppDomain.CurrentDomain.BaseDirectory + @"rptsv\" + set.Tables[0].Rows[0]["lgo"].ToString(), FileMode.Open);
            }
            else
            {
                stream = new FileStream(AppDomain.CurrentDomain.BaseDirectory + @"rptsv\lgonoimg.png", FileMode.Open);
            }
            BinaryReader reader = new BinaryReader(stream);
            byte[] buffer = new byte[stream.Length + 1L];
            buffer = reader.ReadBytes(Convert.ToInt32(stream.Length));
            row[0] = buffer;
            table.Rows.Add(row);
            reader.Close();
            stream.Close();
            table.AcceptChanges();
        }
        ds.Tables["rptimg"].Merge(table);
    }

    protected void Page_Init(object sender, EventArgs e)
    {
        string str = this.Session["Param"].ToString();
        Inventory ds = new Inventory();
        DataTable table = new DataTable();
        DataSet set = this.mybll.get_Informationdataset("select cCmpName,cAdd1,cAdd2 from Smt_Company where Display_AS_Header=1");
        DataSet set2 = this.mybll.get_Informationdataset("select cUserFullname from SpecFo.dbo.Smt_Users where cUserName='" + this.Session["Uid"].ToString() + "'");
        string val = set.Tables[0].Rows[0]["cCmpName"].ToString();
        string str3 = set.Tables[0].Rows[0]["cAdd1"].ToString();
        string str4 = set.Tables[0].Rows[0]["cAdd2"].ToString();
        set2.Tables[0].Rows[0]["cUserFullname"].ToString();
        switch (str)
        {
            case "StyleWise":
                {
                    DataTable table2 = this.mybll.get_InformationdataTable("Sp_Inv_ReportStyleStatus_Getheader " + this.Session["stid"].ToString());
                    string str5 = table2.Rows[0]["cStyleNo"].ToString();
                    string str6 = table2.Rows[0]["nOrdQty"].ToString();
                    string str7 = table2.Rows[0]["cBuyer_Name"].ToString();
                    string str8 = table2.Rows[0]["cGmetDis"].ToString();
                    table.TableName = "StyleStatus";
                    table = this._blInventory.get_InformationdataTable("Sp_Inv_ReportStyleStatus " + this.Session["stid"].ToString());
                    ds.Tables["StyleStatus"].Merge(table);
                    this.Companylogo(ds);
                    this.rptDoc.Load(base.Server.MapPath("Rpt_InventoryStyleStatus.rpt"));
                    this.rptDoc.SetDataSource((DataSet)ds);
                    this.rptDoc.SetParameterValue("cCmpName", val);
                    this.rptDoc.SetParameterValue("cStyleNo", str5);
                    this.rptDoc.SetParameterValue("nOrdQty", str6);
                    this.rptDoc.SetParameterValue("cBuyer_Name", str7);
                    this.rptDoc.SetParameterValue("cGmetDis", str8);
                    this.Session["stid"] = null;
                    this.Session["Param"] = null;
                    break;
                }
            case "GoodsIssue":
                {
                    table.TableName = "GoodsIssue";
                    table = this._blInventory.get_InformationdataTable("Sp_Smt_GoodsIssue_ReportIssueNote '" + this.Session["IssueNID"].ToString() + "'");
                    ds.Tables["GoodsIssue"].Merge(table);
                    this.Companylogo(ds);
                    DataTable table3 = this._blInventory.get_InformationdataTable("Sp_Smt_GoodsIssue_ReportHeader " + this.Session["IssueNID"].ToString());
                    string str9 = table3.Rows[0]["nIssNo"].ToString();
                    string str10 = table3.Rows[0]["cSection_Description"].ToString();
                    table3.Rows[0]["cStyleNo"].ToString();
                    string str11 = table3.Rows[0]["IssueNoteNO"].ToString();
                    string str12 = table3.Rows[0]["cUserFullname"].ToString();
                    string str13 = table3.Rows[0]["cCmpName"].ToString();
                    string str14 = table3.Rows[0]["cDeptname"].ToString();
                    table3.Rows[0]["cBuyer_Name"].ToString();
                    this.rptDoc.Load(base.Server.MapPath("Rpt_GoodsIssuNote.rpt"));
                    this.rptDoc.SetDataSource((DataSet)ds);
                    this.rptDoc.SetParameterValue("cCmpName", val);
                    this.rptDoc.SetParameterValue("cAdd1", str3);
                    this.rptDoc.SetParameterValue("cAdd2", str4);
                    this.rptDoc.SetParameterValue("issueNo", str9);
                    this.rptDoc.SetParameterValue("section", str10);
                    this.rptDoc.SetParameterValue("cUserFullname", str12);
                    this.rptDoc.SetParameterValue("IssueNoteNO", str11);
                    this.rptDoc.SetParameterValue("dEntDAte", table3.Rows[0]["dEntDAte"].ToString());
                    this.rptDoc.SetParameterValue("comp", str13);
                    this.rptDoc.SetParameterValue("dept", str14);
                    break;
                }
            case "GoodsIssueD2D":
                table.TableName = "GoodsIssue";
                table = this._blInventory.get_InformationdataTable("Sp_Smt_GoodsIssue_ReportIssueNoteD2D '" + this.Session["FDate"].ToString() + "','" + this.Session["Tdate"].ToString() + "'");
                ds.Tables["GoodsIssue"].Merge(table);
                this.Companylogo(ds);
                this.rptDoc.Load(base.Server.MapPath("Rpt_GoodsIssuNoteD2D.rpt"));
                this.rptDoc.SetDataSource((DataSet)ds);
                this.rptDoc.SetParameterValue("cCmpName", val);
                this.rptDoc.SetParameterValue("cAdd1", str3);
                this.rptDoc.SetParameterValue("cAdd2", str4);
                break;

            case "GRNComwised2d":
                table.TableName = "Compwisegrn";
                table = this._blInventory.get_InformationdataTable("Sp_Smt_GoodReceived_ComwiseGRN '" + this.Session["FDate"].ToString() + "','" + this.Session["Tdate"].ToString() + "'");
                ds.Tables["Compwisegrn"].Merge(table);
                this.Companylogo(ds);
                this.rptDoc.Load(base.Server.MapPath("Rpt_Comgrn.rpt"));
                this.rptDoc.SetDataSource((DataSet)ds);
                this.rptDoc.SetParameterValue("cCmpName", val);
                this.rptDoc.SetParameterValue("cAdd1", str3);
                this.rptDoc.SetParameterValue("cAdd2", str4);
                this.rptDoc.SetParameterValue("dt", "From " + this.Session["FDate"].ToString() + " To " + this.Session["Tdate"].ToString());
                break;

            case "SB":
                {
                    string str15 = null;
                    string[] strArray = new string[] { "nMainCategory_ID", "cItemSubCat", "nCompanyID" };
                    string str16 = this.Session["SubCatID"].ToString();
                    string str17 = null;
                    if (str16 != "0")
                    {
                        str17 = str16;
                    }
                    string str18 = this.Session["comid"].ToString();
                    string str19 = null;
                    if (str18 != "0")
                    {
                        str19 = str18;
                    }
                    string[] strArray2 = new string[] { this.Session["MCatID"].ToString(), str17, str19 };
                    int num = 0;
                    for (int i = 0; i < strArray2.Length; i++)
                    {
                        string str20 = strArray2[i];
                        if (!string.IsNullOrEmpty(str20))
                        {
                            num++;
                            if (num == 1)
                            {
                                str15 = str15 + strArray[i] + " = " + str20;
                            }
                            else
                            {
                                str15 = str15 + " And " + strArray[i] + " =" + str20;
                            }
                        }
                    }
                    table.TableName = "Stock Balance";
                    table = this._blInventory.get_InformationdataTable("Sp_Smt_ItemMaster_ReportStockBalance_new '" + str15 + "'");
                    ds.Tables["Stock Balance"].Merge(table);
                    this.Companylogo(ds);
                    this.rptDoc.Load(base.Server.MapPath("Rpt_StockBalance.rpt"));
                    this.rptDoc.SetDataSource((DataSet)ds);
                    this.rptDoc.SetParameterValue("cCmpName", val);
                    this.rptDoc.SetParameterValue("comp", this.Session["comname"].ToString());
                    this.rptDoc.SetParameterValue("mcat", this.Session["mcat"].ToString());
                    this.Session["MCatID"] = null;
                    this.Session["SubCatID"] = null;
                    this.Session["comid"] = null;
                    this.Session["comname"] = null;
                    this.Session["subcat"] = null;
                    break;
                }
            case "RM":
                table.TableName = "GRND2D";
                table = this._blInventory.get_InformationdataTable("Sp_Smt_GoodReceived_ReportD2D '" + this.Session["FDate"].ToString() + "','" + this.Session["Tdate"].ToString() + "'," + this.Session["MCatID"].ToString());
                ds.Tables["GRND2D"].Merge(table);
                this.Companylogo(ds);
                this.rptDoc.Load(base.Server.MapPath("Rpt_GRND2D.rpt"));
                this.rptDoc.SetDataSource((DataSet)ds);
                this.rptDoc.SetParameterValue("cCmpName", val);
                this.rptDoc.SetParameterValue("FDate", this.Session["FDate"].ToString());
                this.rptDoc.SetParameterValue("Tdate", this.Session["Tdate"].ToString());
                this.Session["MCatID"] = null;
                this.Session["FDate"] = null;
                this.Session["Tdate"] = null;
                break;

            case "mnwsefabreq":
                table.TableName = "monthwisefabricrpt";
                table = this.mybll.get_InformationdataTable("Sp_smt_monthwisefab_getrpt");
                ds.Tables["monthwisefabricrpt"].Merge(table);
                this.Companylogo(ds);
                this.rptDoc.Load(base.Server.MapPath("Rpt_monthwiseFabric.rpt"));
                this.rptDoc.SetDataSource((DataSet)ds);
                this.rptDoc.SetParameterValue("cCmpName", val);
                this.rptDoc.SetParameterValue("FDate", "From " + this.Session["FDate"].ToString() + " To " + this.Session["Tdate"].ToString());
                this.Session["MCatID"] = null;
                this.Session["FDate"] = null;
                this.Session["Tdate"] = null;
                break;

            case "RMSup":
                table.TableName = "GRND2D";
                table = this._blInventory.get_InformationdataTable("Sp_Smt_GoodReceived_ReportD2D '" + this.Session["FDate"].ToString() + "','" + this.Session["Tdate"].ToString() + "'," + this.Session["MCatID"].ToString());
                ds.Tables["GRND2D"].Merge(table);
                this.Companylogo(ds);
                this.rptDoc.Load(base.Server.MapPath("Rpt_GRND2DSupplierwise.rpt"));
                this.rptDoc.SetDataSource((DataSet)ds);
                this.rptDoc.SetParameterValue("cCmpName", val);
                this.rptDoc.SetParameterValue("FDate", this.Session["FDate"].ToString());
                this.rptDoc.SetParameterValue("Tdate", this.Session["Tdate"].ToString());
                this.rptDoc.SetParameterValue("cAdd1", str3);
                this.rptDoc.SetParameterValue("cAdd2", str4);
                this.Session["MCatID"] = null;
                this.Session["FDate"] = null;
                this.Session["Tdate"] = null;
                break;
        }
        if (str == "FP")
        {
            string str21 = null;
            string[] strArray3 = new string[] { "Smt_MainCategory.nMainCategory_ID", "Smt_ItemMaster.nCompanyID", "cCode" };
            string[] strArray4 = new string[] { this.Session["MCatID"].ToString(), this.Session["comid"].ToString(), this.Session["subcat"].ToString() };
            int num3 = 0;
            for (int j = 0; j < strArray4.Length; j++)
            {
                string str22 = strArray4[j];
                if (!string.IsNullOrEmpty(str22))
                {
                    num3++;
                    if (num3 == 1)
                    {
                        str21 = str21 + strArray3[j] + " = " + str22;
                    }
                    else
                    {
                        str21 = str21 + " And " + strArray3[j] + " =" + str22;
                    }
                }
            }
            DateTime time = DateTime.Parse(this.Session["FDate"].ToString());
            DateTime time2 = DateTime.Parse(this.Session["Tdate"].ToString());
            //string str23 = $"{time:dd-MMM-yyyy}";
            //string str24 = $"{time2:dd-MMM-yyyy}";

            string str23 = time.ToString("dd MMM yyyy hh:mm:ss tt");
            string str24 = time2.ToString("dd MMM yyyy hh:mm:ss tt");


           
            if (str21 != null)
            {
                str21 = str21 + " AND (Smt_GoodReceived.dEntDate between ''" + str23 + "'' and ''" + str24 + "'')";
            }
            else
            {
                str21 = "(Smt_GoodReceived.dEntDate between ''" + str23 + "'' and ''" + str24 + "'')";
            }
            table.TableName = "GRND2DFactorypurchase";
            table = this._blInventory.get_InformationdataTable("FPRecvdtl_Report '" + str21 + "'");
            ds.Tables["GRND2DFactorypurchase"].Merge(table);
            this.Companylogo(ds);
            this.rptDoc.Load(base.Server.MapPath("Rpt_GRNFactoryPurchaseD2D.rpt"));
            this.rptDoc.SetDataSource((DataSet)ds);
            this.rptDoc.SetParameterValue("cCmpName", val);
            this.rptDoc.SetParameterValue("FDate", this.Session["FDate"].ToString());
            this.rptDoc.SetParameterValue("Tdate", this.Session["Tdate"].ToString());
            this.rptDoc.SetParameterValue("cAdd1", str3);
            this.rptDoc.SetParameterValue("cAdd2", str4);
            this.rptDoc.SetParameterValue("comnm", this.Session["comnm"].ToString());
            this.Session["MCatID"] = null;
            this.Session["FDate"] = null;
            this.Session["Tdate"] = null;
            this.Session["comid"] = null;
            this.Session["subcat"] = null;
        }
        if (str == "FR")
        {
            table.TableName = "GoodsReturn";
            table = this._blInventory.get_InformationdataTable("Sp_Smt_GoodsReturn_getDtl '" + this.Session["IssueNID"].ToString() + "'");
            ds.Tables["GoodsReturn"].Merge(table);
            this.Companylogo(ds);
            this.rptDoc.Load(base.Server.MapPath("Rpt_Inv_GoodsReturn.rpt"));
            this.rptDoc.SetDataSource((DataSet)ds);
            DataTable table4 = this._blInventory.get_InformationdataTable("Sp_Smt_GoodsReturn_getDtlHdr '" + this.Session["IssueNID"].ToString() + "'");
            this.rptDoc.SetParameterValue("cCmpName", val);
            this.rptDoc.SetParameterValue("Dept", table4.Rows[0]["cDeptname"].ToString());
            this.rptDoc.SetParameterValue("Com", table4.Rows[0]["cCmpName"].ToString());
            this.rptDoc.SetParameterValue("Sec", table4.Rows[0]["cSection_Description"].ToString());
            this.rptDoc.SetParameterValue("Typ", table4.Rows[0]["cReturn_Type"].ToString());
            this.rptDoc.SetParameterValue("rtno", table4.Rows[0]["GoodsReturnNo"].ToString());
            this.rptDoc.SetParameterValue("RetNotNo", table4.Rows[0]["cReturn_NoteNO"].ToString());
            this.rptDoc.SetParameterValue("cAdd1", str3);
            this.rptDoc.SetParameterValue("cAdd2", str4);
            this.rptDoc.SetParameterValue("usern", this.Session["UName"].ToString());
            this.Session["IssueNID"] = null;
        }
        if (str == "GRNNO")
        {
            table.TableName = "GRN_Report";
            table = this._blInventory.get_InformationdataTable("Smt_GoodReceived_Report " + this.Session["GRNNO"].ToString());
            ds.Tables["GRN_Report"].Merge(table);
            this.Companylogo(ds);
            this.rptDoc.Load(base.Server.MapPath("Rpt_Inv_GRN.rpt"));
            this.rptDoc.SetDataSource((DataSet)ds);
            this.rptDoc.SetParameterValue("cCmpName", val);
            this.rptDoc.SetParameterValue("cAdd1", str3);
            this.rptDoc.SetParameterValue("cAdd2", str4);
            DataTable table5 = this._blInventory.get_InformationdataTable("select cAppBy from Smt_GoodReceived where nGrnNo=" + this.Session["GRNNO"].ToString());
            string userid = this.Session["Uid"].ToString();
            if (table5.Rows.Count > 0)
            {
                userid = table5.Rows[0]["cAppBy"].ToString();
            }
            this.signature(ds, userid);
            this.Session["GRNNO"] = null;
        }
        if (str == "PONO")
        {
            table.TableName = "FactoryPurchase_Report";
            table = this._blInventory.get_InformationdataTable("Sp_Smt_FactoryPurchase_POReport " + this.Session["pono"].ToString());
            ds.Tables["FactoryPurchase_Report"].Merge(table);
            this.Companylogo(ds);
            this.rptDoc.Load(base.Server.MapPath("Rpt_Inv_FactoryPurchasePO.rpt"));
            this.rptDoc.SetDataSource((DataSet)ds);
            this.rptDoc.SetParameterValue("companyName", val);
            this.rptDoc.SetParameterValue("cAdd1", str3);
            this.rptDoc.SetParameterValue("cAdd2", str4);
            DataTable table6 = this._blInventory.get_InformationdataTable("select PO_Approved_By from Smt_FactoryPurchase where PO_No=" + this.Session["pono"].ToString());
            string str26 = this.Session["Uid"].ToString();
            if (table6.Rows.Count > 0)
            {
                str26 = table6.Rows[0]["PO_Approved_By"].ToString();
            }
            this.signature(ds, str26);
            this.Session["pono"] = null;
        }
        if (str == "EBIN")
        {
            DataTable table7 = new DataTable
            {
                TableName = "ItemLocation"
            };
            table7 = this._blInventory.get_InformationdataTable("Sp_Smt_ItemMaster_getItemLocation " + this.Session["Itmcode"].ToString());
            ds.Tables["ItemLocation"].Merge(table7);
            this.Companylogo(ds);
            DataTable table8 = new DataTable
            {
                TableName = "ItmTraker"
            };
            table8 = this._blInventory.get_InformationdataTable("ItemTracker_getEbinrpt");
            ds.Tables["ItmTraker"].Merge(table8);
            this.rptDoc.Load(base.Server.MapPath("Rpt_Inv_ItemTraker.rpt"));
            this.rptDoc.SetDataSource((DataSet)ds);
            this.rptDoc.SetParameterValue("companyName", val);
            this.rptDoc.SetParameterValue("add", str3 + " ," + str4);
            this.rptDoc.SetParameterValue("itm", this.Session["itm"].ToString());
            this.rptDoc.SetParameterValue("Unit", this.Session["Unit"].ToString());
            this.rptDoc.SetParameterValue("ItecCode", this.Session["Itmcode"].ToString());
            this.Session["Itmcode"] = null;
            this.Session["itm"] = null;
            this.Session["Unit"] = null;
        }
        if (str == "DTGRNDTL")
        {
            table.TableName = "DTGRNDTL";
            table = this._blInventory.get_InformationdataTable("Sp_Smt_GoodReceived_D2DFABRIC '" + this.Session["FDate"].ToString() + "','" + this.Session["Tdate"].ToString() + "'");
            ds.Tables["DTGRNDTL"].Merge(table);
            DataTable table9 = new DataTable
            {
                TableName = "DTGRNDTLSUM"
            };
            table9 = this._blInventory.get_InformationdataTable("Sp_Smt_GoodReceived_D2DFABRICSUMMERY '" + this.Session["FDate"].ToString() + "','" + this.Session["Tdate"].ToString() + "'");
            ds.Tables["DTGRNDTLSUM"].Merge(table9);
            this.Companylogo(ds);
            this.rptDoc.Load(base.Server.MapPath("Rpt_GRND2DFABRIC.rpt"));
            this.rptDoc.SetDataSource((DataSet)ds);
            this.rptDoc.SetParameterValue("cCmpName", val);
            this.rptDoc.SetParameterValue("FDate", this.Session["FDate"].ToString());
            this.rptDoc.SetParameterValue("Tdate", this.Session["Tdate"].ToString());
            this.Session["FDate"] = null;
            this.Session["Tdate"] = null;
        }
        if (str == "ReOrdEr")
        {
            table.TableName = "ReOrdEr";
            table = this._blInventory.get_InformationdataTable(string.Concat(new object[] { "Itemtracker_ReorderRpt ", this.Session["MCatID"], ",", this.Session["subcat"] }));
            ds.Tables["ReOrdEr"].Merge(table);
            this.Companylogo(ds);
            this.rptDoc.Load(base.Server.MapPath("Reorder.rpt"));
            this.rptDoc.SetDataSource((DataSet)ds);
            this.rptDoc.SetParameterValue("companyName", val);
            this.rptDoc.SetParameterValue("add", str3 + "," + str4);
            this.rptDoc.SetParameterValue("mcat", this.Session["mcatdesc"].ToString());
            this.Session["MCatID"] = null;
            this.Session["subcat"] = null;
        }
        this.Session["Param"] = null;
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
        if (!base.IsPostBack)
        {
            this.Page.Response.Cache.SetCacheability(HttpCacheability.NoCache);
        }
    }

    protected void Page_Unload(object sender, EventArgs e)
    {
        this.rptDoc.Close();
    }

    public void signature(Inventory ds, string userid)
    {
        DataTable table = new DataTable();
        DataSet set = this.mybll.get_Informationdataset("SELECT signtr FROM Smt_Users where cUserName='" + userid + "'");
        if (set.Tables[0].Rows.Count > 0)
        {
            FileStream stream;
            table.Columns.Add("signtr", Type.GetType("System.Byte[]"));
            DataRow row = table.NewRow();
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"imgsign\" + set.Tables[0].Rows[0]["signtr"].ToString()))
            {
                stream = new FileStream(AppDomain.CurrentDomain.BaseDirectory + @"imgsign\" + set.Tables[0].Rows[0]["signtr"].ToString(), FileMode.Open);
            }
            else
            {
                stream = new FileStream(AppDomain.CurrentDomain.BaseDirectory + @"rptsv\lgonoimg.png", FileMode.Open);
            }
            BinaryReader reader = new BinaryReader(stream);
            byte[] buffer = new byte[stream.Length + 1L];
            buffer = reader.ReadBytes(Convert.ToInt32(stream.Length));
            row[0] = buffer;
            table.Rows.Add(row);
            reader.Close();
            stream.Close();
            table.AcceptChanges();
        }
        ds.Tables["RPT_Sign"].Merge(table);
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
