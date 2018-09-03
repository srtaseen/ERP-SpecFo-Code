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

public partial class Report_Merchandising_Smt_MerchandisingReport : System.Web.UI.Page
{
    private BLLInventory _blinventory = new BLLInventory();
    //protected HtmlForm form1;
    private BLL mybll = new BLL();
    private ReportDocument rptDoc = new ReportDocument();

    protected void Page_Init(object sender, EventArgs e)
    {
        base.Title = "MERCHENDISING REPORT";
        string str = this.Session["Param"].ToString();
        DataTable table = this.mybll.get_InformationdataTable("select cCmpName,cAdd1,cAdd2 from Smt_Company where Display_AS_Header=1");
        string val = table.Rows[0]["cCmpName"].ToString();
        string str3 = table.Rows[0]["cAdd1"].ToString();
        string str4 = table.Rows[0]["cAdd2"].ToString();
        Merchandising ds = new Merchandising();
        DataTable table2 = new DataTable();
        if (str == "D2D")
        {
            table2 = this.mybll.get_InformationdataTable("select * from Smt_Stylemaster_RptGen");
            table2.TableName = "BayerWiseStyleQtyD2D";
            ds.Tables["BayerWiseStyleQtyD2D"].Merge(table2);
            DateTime time = Convert.ToDateTime(this.Session["dt1"].ToString());
            DateTime time2 = Convert.ToDateTime(this.Session["dt2"].ToString());
            DataTable table3 = new DataTable();
            while (time < time2)
            {
                string columnName = time.ToString("MMM yy");
                table3.Columns.Add(new DataColumn(columnName, typeof(string)));
                time = time.AddMonths(1);
            }
            this.rptDoc.Load(base.Server.MapPath("RptBuyerWiseD2D.rpt"));
            this.rptDoc.SetDataSource((DataSet)ds);
            this.rptDoc.SetParameterValue("ComName", val);
            this.rptDoc.SetParameterValue("FormDate", this.Session["dt1"].ToString());
            this.rptDoc.SetParameterValue("ToDate", this.Session["dt2"].ToString());
            if (table3.Columns.Count > 0)
            {
                for (int i = 1; i <= table3.Columns.Count; i++)
                {
                    string str6 = table3.Columns[i - 1].ToString();
                    string name = "Month" + i;
                    this.rptDoc.SetParameterValue(name, str6);
                }
                int count = table3.Columns.Count;
                if (table3.Columns.Count < 12)
                {
                    for (int j = count + 1; j <= 12; j++)
                    {
                        string str8 = "Month" + j;
                        this.rptDoc.SetParameterValue(str8, "");
                    }
                }
            }
            this.Session["dt1"] = null;
            this.Session["dt2"] = null;
        }
        if (str == "BuyerWise")
        {
            table2 = this.mybll.get_InformationdataTable("select * from Smt_OrderMaster_Rpt_Buyerwise order by cBuyer_Name");
            table2.TableName = "Rpt_OrderMaster_Buyerwise";
            ds.Tables["Rpt_OrderMaster_Buyerwise"].Merge(table2);
            DateTime time3 = Convert.ToDateTime(this.Session["dt1"].ToString());
            DateTime time4 = Convert.ToDateTime(this.Session["dt2"].ToString());
            DataTable table4 = new DataTable();
            while (time3 < time4)
            {
                string str9 = time3.ToString("MMM yy");
                table4.Columns.Add(new DataColumn(str9, typeof(string)));
                time3 = time3.AddMonths(1);
            }
            this.rptDoc.Load(base.Server.MapPath("Rpt_OrderMaster_BuyerWise.rpt"));
            this.rptDoc.SetDataSource((DataSet)ds);
            this.rptDoc.SetParameterValue("ComName", val);
            this.rptDoc.SetParameterValue("FormDate", this.Session["dt1"].ToString());
            this.rptDoc.SetParameterValue("ToDate", this.Session["dt2"].ToString());
            if (table4.Columns.Count > 0)
            {
                for (int k = 1; k <= table4.Columns.Count; k++)
                {
                    string str10 = table4.Columns[k - 1].ToString();
                    string str11 = "Month" + k;
                    this.rptDoc.SetParameterValue(str11, str10);
                }
                int num5 = table4.Columns.Count;
                if (table4.Columns.Count < 12)
                {
                    for (int m = num5 + 1; m <= 12; m++)
                    {
                        string str12 = "Month" + m;
                        this.rptDoc.SetParameterValue(str12, "");
                    }
                }
            }
            this.Session["dt1"] = null;
            this.Session["dt2"] = null;
        }
        if (str == "buyerweekly")
        {
            DataTable table5 = new DataTable
            {
                TableName = "Buyerwiseweeklyrpt"
            };
            table5 = this.mybll.get_InformationdataTable("Sp_Smt_Ordermaster_rptbyerweeklyrpt");
            ds.Tables["Buyerwiseweeklyrpt"].Merge(table5);
            this.rptDoc.Load(base.Server.MapPath("../Report_Merchandising/buyerweekly.rpt"));
            this.rptDoc.SetDataSource((DataSet)ds);
            this.rptDoc.SetParameterValue("cmp", val);
            this.rptDoc.SetParameterValue("add", str3 + "," + str4);
            this.rptDoc.SetParameterValue("dt", string.Concat(new object[] { "From ", this.Session["dtS"].ToString(), " To ", this.Session["dtE"] }));
            this.Session["dtS"] = null;
            this.Session["dtE"] = null;
        }
        if (str == "GmtTyewise")
        {
            table2 = this.mybll.get_InformationdataTable("select * from Smt_OrderMaster_RptGmtTypewise order by cGmetDis");
            table2.TableName = "Rpt_OrderMaster_GmtTypeWise";
            ds.Tables["Rpt_OrderMaster_GmtTypeWise"].Merge(table2);
            DateTime time5 = Convert.ToDateTime(this.Session["dt1"].ToString());
            DateTime time6 = Convert.ToDateTime(this.Session["dt2"].ToString());
            DataTable table6 = new DataTable();
            while (time5 < time6)
            {
                string str13 = time5.ToString("MMM yy");
                table6.Columns.Add(new DataColumn(str13, typeof(string)));
                time5 = time5.AddMonths(1);
            }
            this.rptDoc.Load(base.Server.MapPath("Rpt_OrderMaster_GmtTypeWise.rpt"));
            this.rptDoc.SetDataSource((DataSet)ds);
            this.rptDoc.SetParameterValue("ComName", val);
            this.rptDoc.SetParameterValue("FormDate", this.Session["dt1"].ToString());
            this.rptDoc.SetParameterValue("ToDate", this.Session["dt2"].ToString());
            if (table6.Columns.Count > 0)
            {
                for (int n = 1; n <= table6.Columns.Count; n++)
                {
                    string str14 = table6.Columns[n - 1].ToString();
                    string str15 = "Month" + n;
                    this.rptDoc.SetParameterValue(str15, str14);
                }
                int num8 = table6.Columns.Count;
                if (table6.Columns.Count < 12)
                {
                    for (int num9 = num8 + 1; num9 <= 12; num9++)
                    {
                        string str16 = "Month" + num9;
                        this.rptDoc.SetParameterValue(str16, "");
                    }
                }
            }
            this.Session["dt1"] = null;
            this.Session["dt2"] = null;
            this.Session["dtS"] = null;
            this.Session["dtE"] = null;
        }
        switch (str)
        {
            case "StyleNo":
                {
                    string str17 = this.Session["stid"].ToString();
                    DataSet set = this.mybll.get_Informationdataset("Sp_Smt_StyleMaster_ReportByStyleNo " + str17.Trim());
                    string str18 = set.Tables[0].Rows[0]["cStyleNo"].ToString();
                    string str19 = set.Tables[0].Rows[0]["cBuyer_Name"].ToString();
                    string str20 = set.Tables[0].Rows[0]["cStore_Name"].ToString();
                    string str21 = set.Tables[0].Rows[0]["cSeason_Name"].ToString();
                    string str22 = set.Tables[0].Rows[0]["cBrand_Name"].ToString();
                    string str23 = set.Tables[0].Rows[0]["nTotOrdQty"].ToString();
                    string str24 = set.Tables[0].Rows[0]["cGmetDis"].ToString();
                    string str25 = set.Tables[0].Rows[0]["cGmt_Dept_Description"].ToString();
                    string str26 = set.Tables[0].Rows[0]["cDispStyleNo"].ToString();
                    set.Tables[0].Rows[0]["nfob"].ToString();
                    string str27 = set.Tables[0].Rows[0]["dOOshtRec"].ToString();
                    string str28 = set.Tables[0].Rows[0]["dBPCd"].ToString();
                    string str29 = set.Tables[0].Rows[0]["dCOShtRec"].ToString();
                    string str30 = set.Tables[0].Rows[0]["cStyleType"].ToString();
                    string str31 = set.Tables[0].Rows[0]["cInputDate"].ToString();
                    string str32 = set.Tables[0].Rows[0]["cUserFullname"].ToString();
                    string str33 = set.Tables[0].Rows[0]["Address1"].ToString();
                    string str34 = set.Tables[0].Rows[0]["Address2"].ToString();
                    DataTable table7 = new DataTable
                    {
                        TableName = "StyleReport"
                    };
                    table7 = this.mybll.get_InformationdataTable("select cOrderNu,cPoNum,nOrdQty,Cmode,DXfty,nfob,ShipDt from Smt_OrdersMaster where nOStyleId=" + str17.Trim());
                    ds.Tables["StyleReport"].Merge(table7);
                    DataTable table8 = new DataTable();
                    table8 = this.mybll.get_InformationdataTable("Sp_Smt_SpecialOperation_getbystyle " + str17.Trim());
                    table8.TableName = "Style_SpecialOP";
                    ds.Tables["Style_SpecialOP"].Merge(table8);
                    this.rptDoc.Load(base.Server.MapPath("../Report_Merchandising/StyleMaster.rpt"));
                    this.rptDoc.SetDataSource((DataSet)ds);
                    this.rptDoc.SetParameterValue("cStyleNo", str18);
                    this.rptDoc.SetParameterValue("cBuyer_Name", str19);
                    this.rptDoc.SetParameterValue("cStore_Name", str20);
                    this.rptDoc.SetParameterValue("cSeason_Name", str21);
                    this.rptDoc.SetParameterValue("cBrand_Name", str22);
                    this.rptDoc.SetParameterValue("nTotOrdQty", str23);
                    this.rptDoc.SetParameterValue("cGmetDis", str24);
                    this.rptDoc.SetParameterValue("cGmt_Dept_Description", str25);
                    this.rptDoc.SetParameterValue("cDispStyleNo", str26);
                    this.rptDoc.SetParameterValue("dOOshtRec", str27);
                    this.rptDoc.SetParameterValue("dBPCd", str28);
                    this.rptDoc.SetParameterValue("dCOShtRec", str29);
                    this.rptDoc.SetParameterValue("cCmpName", val);
                    this.rptDoc.SetParameterValue("cStyleType", str30);
                    this.rptDoc.SetParameterValue("cInputDate", str31);
                    this.rptDoc.SetParameterValue("cUserFullname", str32);
                    this.rptDoc.SetParameterValue("Address1", str33);
                    this.rptDoc.SetParameterValue("Address2", str34);
                    this.Session["stid"] = null;
                    break;
                }
            case "StyleNoPI":
                {
                    string str35 = this.Session["stid"].ToString();
                    DataSet set2 = this.mybll.get_Informationdataset("Sp_Smt_StyleMaster_ReportByStyleNo " + str35.Trim());
                    string str36 = set2.Tables[0].Rows[0]["cStyleNo"].ToString();
                    string str37 = set2.Tables[0].Rows[0]["cBuyer_Name"].ToString();
                    string str38 = set2.Tables[0].Rows[0]["cStore_Name"].ToString();
                    string str39 = set2.Tables[0].Rows[0]["cSeason_Name"].ToString();
                    string str40 = set2.Tables[0].Rows[0]["cBrand_Name"].ToString();
                    string str41 = set2.Tables[0].Rows[0]["nTotOrdQty"].ToString();
                    string str42 = set2.Tables[0].Rows[0]["cGmetDis"].ToString();
                    string str43 = set2.Tables[0].Rows[0]["cGmt_Dept_Description"].ToString();
                    string str44 = set2.Tables[0].Rows[0]["cDispStyleNo"].ToString();
                    string str45 = set2.Tables[0].Rows[0]["cInputDate"].ToString();
                    string str46 = set2.Tables[0].Rows[0]["cUserFullname"].ToString();
                    string str47 = set2.Tables[0].Rows[0]["Address1"].ToString();
                    string str48 = set2.Tables[0].Rows[0]["Address2"].ToString();
                    string str49 = set2.Tables[0].Rows[0]["Phone_No"].ToString();
                    string str50 = set2.Tables[0].Rows[0]["Cont_Person"].ToString();
                    string str51 = set2.Tables[0].Rows[0]["Email"].ToString();
                    string str52 = set2.Tables[0].Rows[0]["Fax"].ToString();
                    DataSet set3 = this.mybll.get_Informationdataset("select cCmpName,cAdd1,cAdd2 from Smt_Company where nCompanyID=" + set2.Tables[0].Rows[0]["cCmp"].ToString());
                    string str54 = set3.Tables[0].Rows[0]["cCmpName"].ToString();
                    string str55 = set3.Tables[0].Rows[0]["cAdd1"].ToString();
                    string str56 = set3.Tables[0].Rows[0]["cAdd2"].ToString();
                    DataTable table9 = new DataTable();
                    table9 = this.mybll.get_InformationdataTable("Sp_Smt_SpecialOperation_getbystyle " + str35.Trim());
                    table9.TableName = "Style_SpecialOP";
                    ds.Tables["Style_SpecialOP"].Merge(table9);
                    DataTable table10 = new DataTable
                    {
                        TableName = "StyleReport"
                    };
                    table10 = this.mybll.get_InformationdataTable("select cOrderNu,cPoNum,nOrdQty,Cmode,DXfty,nfob,ShipDt from Smt_OrdersMaster where nOStyleId=" + str35.Trim());
                    ds.Tables["StyleReport"].Merge(table10);
                    this.rptDoc.Load(base.Server.MapPath("../Report_Merchandising/StyleMasterPI.rpt"));
                    this.rptDoc.SetDataSource((DataSet)ds);
                    this.rptDoc.SetParameterValue("cStyleNo", str36);
                    this.rptDoc.SetParameterValue("cBuyer_Name", str37);
                    this.rptDoc.SetParameterValue("cStore_Name", str38);
                    this.rptDoc.SetParameterValue("cSeason_Name", str39);
                    this.rptDoc.SetParameterValue("cBrand_Name", str40);
                    this.rptDoc.SetParameterValue("nTotOrdQty", str41);
                    this.rptDoc.SetParameterValue("cGmetDis", str42);
                    this.rptDoc.SetParameterValue("cGmt_Dept_Description", str43);
                    this.rptDoc.SetParameterValue("cDispStyleNo", str44);
                    this.rptDoc.SetParameterValue("cCmpName", val);
                    this.rptDoc.SetParameterValue("cInputDate", str45);
                    this.rptDoc.SetParameterValue("cUserFullname", str46);
                    this.rptDoc.SetParameterValue("Address1", str47);
                    this.rptDoc.SetParameterValue("Address2", str48);
                    this.rptDoc.SetParameterValue("Phone_No", str49);
                    this.rptDoc.SetParameterValue("Cont_Person", str50);
                    this.rptDoc.SetParameterValue("Email", str51);
                    this.rptDoc.SetParameterValue("Fax", str52);
                    this.rptDoc.SetParameterValue("CompanyName", str54);
                    this.rptDoc.SetParameterValue("compAddress1", str55);
                    this.rptDoc.SetParameterValue("compAddress2", str56);
                    this.Session["stid"] = null;
                    break;
                }
        }
        if (str == "PONO")
        {
            DataTable table11 = new DataTable
            {
                TableName = "PO_Printing"
            };
            table11 = this._blinventory.get_InformationdataTable("Sp_Smt_POPrinting '" + this.Session["pono"].ToString() + "'");
            ds.Tables["PO_Printing"].Merge(table11);
            DataTable table12 = new DataTable
            {
                TableName = "PO_Printing_sub"
            };
            table12 = this._blinventory.get_InformationdataTable("Sp_Smt_POPrinting_subreport " + this.Session["pono"].ToString());
            ds.Tables["PO_Printing_sub"].Merge(table12);
            this.rptDoc.Load(base.Server.MapPath("../Report_Merchandising/CrystalReport2.rpt"));
            this.rptDoc.SetDataSource((DataSet)ds);
            string str57 = "";
            DataTable table13 = this._blinventory.get_InformationdataTable("SELECT  distinct SpecFo.dbo.Smt_StyleMaster.cStyleNo FROM Smt_PODetails inner join SpecFo.dbo.Smt_StyleMaster on Smt_PODetails.nstyCode=SpecFo.dbo.Smt_StyleMaster.nStyleID where nPoNum=" + this.Session["pono"].ToString());
            if (table13.Rows.Count > 0)
            {
                for (int num10 = 0; num10 < table13.Rows.Count; num10++)
                {
                    if (num10 == 0)
                    {
                        str57 = table13.Rows[num10]["cStyleNo"].ToString();
                    }
                    if (num10 > 0)
                    {
                        str57 = str57 + "," + table13.Rows[num10]["cStyleNo"].ToString();
                    }
                }
            }
            this.rptDoc.SetParameterValue("stl", str57);
            this.rptDoc.SetParameterValue("cCmpName", val);
            DataTable table14 = this._blinventory.get_InformationdataTable("select cAppBy from Smt_POHedder where nPoNum=" + this.Session["pono"].ToString());
            string userid = this.Session["Uid"].ToString();
            if (table14.Rows.Count > 0)
            {
                userid = table14.Rows[0]["cAppBy"].ToString();
            }
            this.signature(ds, userid);
            this.Session["pono"] = null;
        }
        if (str == "BreakStyleWise")
        {
            DataTable table15 = new DataTable
            {
                TableName = "Qbreakdown"
            };
            table15 = this.mybll.get_InformationdataTable("Sp_Smt_PackContry_QtyBreakdownReport1 " + this.Session["stid"].ToString());
            ds.Tables["Qbreakdown"].Merge(table15);
            DataTable table16 = new DataTable
            {
                TableName = "QtyBreakdownReportSub"
            };
            table16 = this.mybll.get_InformationdataTable("Sp_Smt_PackContry_QtyBreakdownReportSub " + this.Session["stid"].ToString());
            ds.Tables["QtyBreakdownReportSub"].Merge(table16);
            DataSet set4 = this.mybll.get_Informationdataset("Sp_Smt_StyleMaster_GetInfo " + this.Session["stid"].ToString());
            string str59 = set4.Tables[0].Rows[0]["cStyleNo"].ToString();
            string str60 = set4.Tables[0].Rows[0]["cBuyer_Name"].ToString();
            string str61 = set4.Tables[0].Rows[0]["cSeason_Name"].ToString();
            string str62 = set4.Tables[0].Rows[0]["cBrand_Name"].ToString();
            string str63 = set4.Tables[0].Rows[0]["nOrdQty"].ToString();
            string str64 = set4.Tables[0].Rows[0]["cGmetDis"].ToString();
            this.rptDoc.Load(base.Server.MapPath("../Report_Merchandising/Breakdown_POWise.rpt"));
            this.rptDoc.SetDataSource((DataSet)ds);
            this.rptDoc.SetParameterValue("cStyleNo", str59);
            this.rptDoc.SetParameterValue("cBuyer_Name", str60);
            this.rptDoc.SetParameterValue("cSeason_Name", str61);
            this.rptDoc.SetParameterValue("cBrand_Name", str62);
            this.rptDoc.SetParameterValue("nOrdQty", str63);
            this.rptDoc.SetParameterValue("cGmetDis", str64);
            this.rptDoc.SetParameterValue("cCmpName", val);
            this.Session["stid"] = null;
        }
        if (str == "eCost")
        {
            FileStream stream;
            DataTable table17 = new DataTable();
            DataTable table18 = new DataTable
            {
                TableName = "stlimg"
            };
            table17.TableName = "eCosting";
            table17 = this._blinventory.get_InformationdataTable("Sp_Smt_EstimateCosting_GetByStyleID " + this.Session["stid"].ToString());
            DataSet set5 = this.mybll.get_Informationdataset("select Fileno from Smt_StylemasterFile where StyleID=" + this.Session["stid"] + " and Sketch=1");
            table18.Columns.Add("imgName", Type.GetType("System.String"));
            table18.Columns.Add("Sketch", Type.GetType("System.Byte[]"));
            DataRow row = table18.NewRow();
            if (set5.Tables[0].Rows.Count > 0)
            {
                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"StyleFile\" + set5.Tables[0].Rows[0]["Fileno"].ToString()))
                {
                    stream = new FileStream(AppDomain.CurrentDomain.BaseDirectory + @"StyleFile\" + set5.Tables[0].Rows[0]["Fileno"].ToString(), FileMode.Open);
                }
                else
                {
                    stream = new FileStream(AppDomain.CurrentDomain.BaseDirectory + @"rptsv\noimg.png", FileMode.Open);
                }
            }
            else
            {
                stream = new FileStream(AppDomain.CurrentDomain.BaseDirectory + @"rptsv\noimg.png", FileMode.Open);
            }
            BinaryReader reader = new BinaryReader(stream);
            byte[] buffer = new byte[stream.Length + 1L];
            buffer = reader.ReadBytes(Convert.ToInt32(stream.Length));
            row["imgName"] = "Style Image";
            row["Sketch"] = buffer;
            table18.AcceptChanges();
            table18.Rows.Add(row);
            reader.Close();
            stream.Close();
            ds.Tables["stlimg"].Merge(table18);
            ds.Tables["eCosting"].Merge(table17);
            DataSet set6 = this.mybll.get_Informationdataset("Sp_Smt_StyleMaster_GetInfo " + this.Session["stid"].ToString());
            string str65 = set6.Tables[0].Rows[0]["cStyleNo"].ToString();
            string str66 = set6.Tables[0].Rows[0]["cBuyer_Name"].ToString();
            string str67 = set6.Tables[0].Rows[0]["cSeason_Name"].ToString();
            string str68 = set6.Tables[0].Rows[0]["cBrand_Name"].ToString();
            string str69 = set6.Tables[0].Rows[0]["nOrdQty"].ToString();
            string str70 = set6.Tables[0].Rows[0]["cGmetDis"].ToString();
            this.rptDoc.Load(base.Server.MapPath("../Report_Merchandising/EstimateCosting.rpt"));
            this.rptDoc.SetDataSource((DataSet)ds);
            this.rptDoc.SetParameterValue("cStyleNo", str65);
            this.rptDoc.SetParameterValue("cBuyer_Name", str66);
            this.rptDoc.SetParameterValue("cSeason_Name", str67);
            this.rptDoc.SetParameterValue("cBrand_Name", str68);
            this.rptDoc.SetParameterValue("nOrdQty", str69);
            this.rptDoc.SetParameterValue("cGmetDis", str70);
            this.rptDoc.SetParameterValue("cCmpName", val);
            this.Session["stid"] = null;
        }
        if (str == "BreakPOWise")
        {
            DataTable table19 = new DataTable
            {
                TableName = "Qbreakdown"
            };
            table19 = this.mybll.get_InformationdataTable("Sp_Smt_PackContry_ReportBreakdownPOWise " + this.Session["stid"].ToString() + ",'" + this.Session["Lot"].ToString() + "'");
            ds.Tables["Qbreakdown"].Merge(table19);
            DataSet set7 = this.mybll.get_Informationdataset("Sp_Smt_StyleMaster_GetInfoPOWsie " + this.Session["stid"].ToString() + ",'" + this.Session["Lot"].ToString() + "'");
            string str71 = set7.Tables[0].Rows[0]["cStyleNo"].ToString();
            string str72 = set7.Tables[0].Rows[0]["cBuyer_Name"].ToString();
            string str73 = set7.Tables[0].Rows[0]["cSeason_Name"].ToString();
            string str74 = set7.Tables[0].Rows[0]["cBrand_Name"].ToString();
            string str75 = set7.Tables[0].Rows[0]["nOrdQty"].ToString();
            string str76 = set7.Tables[0].Rows[0]["cGmetDis"].ToString();
            this.rptDoc.Load(base.Server.MapPath("../Report_Merchandising/Breakdown_POWise.rpt"));
            this.rptDoc.SetDataSource((DataSet)ds);
            this.rptDoc.SetParameterValue("cStyleNo", str71);
            this.rptDoc.SetParameterValue("cBuyer_Name", str72);
            this.rptDoc.SetParameterValue("cSeason_Name", str73);
            this.rptDoc.SetParameterValue("cBrand_Name", str74);
            this.rptDoc.SetParameterValue("nOrdQty", str75);
            this.rptDoc.SetParameterValue("cGmetDis", str76);
            this.rptDoc.SetParameterValue("cCmpName", val);
            this.Session["stid"] = null;
            this.Session["Lot"] = null;
        }
        if (str == "BreakPackWise")
        {
            DataSet set8 = this.mybll.get_Informationdataset("Sp_Smt_StyleMaster_GetInfo " + this.Session["stid"].ToString());
            string str77 = set8.Tables[0].Rows[0]["cStyleNo"].ToString();
            string str78 = set8.Tables[0].Rows[0]["cBuyer_Name"].ToString();
            string str79 = set8.Tables[0].Rows[0]["cSeason_Name"].ToString();
            string str80 = set8.Tables[0].Rows[0]["cBrand_Name"].ToString();
            string str81 = set8.Tables[0].Rows[0]["nOrdQty"].ToString();
            string str82 = set8.Tables[0].Rows[0]["cGmetDis"].ToString();
            if (this.mybll.get_InformationdataTable("select StyleID from Smt_InseamsQty where StyleID=" + this.Session["stid"].ToString() + " and Lot='" + this.Session["Lot"].ToString() + "'").Rows.Count > 0)
            {
                DataTable table21 = new DataTable
                {
                    TableName = "packwiseinsmrpt"
                };
                table21 = this.mybll.get_InformationdataTable("Sp_Smt_InseamsQty_getinsmrpt " + this.Session["stid"].ToString() + ",'" + this.Session["Lot"].ToString() + "'");
                ds.Tables["packwiseinsmrpt"].Merge(table21);
                this.rptDoc.Load(base.Server.MapPath("../Report_Merchandising/Rpt_AssortmentPackInsmwise.rpt"));
            }
            else
            {
                DataTable table22 = new DataTable
                {
                    TableName = "ReportPackwise"
                };
                table22 = this.mybll.get_InformationdataTable("Sp_Smt_GetAssortmentPackwise1 " + this.Session["stid"].ToString() + ",'" + this.Session["Lot"].ToString() + "'");
                ds.Tables["ReportPackwise"].Merge(table22);
                DataTable table23 = new DataTable
                {
                    TableName = "Order_Size"
                };
                table23 = this.mybll.get_InformationdataTable("select [Size1],[Size2],[Size3],[Size4],[Size5],[Size6],[Size7],[Size8],[Size9] ,[Size10],[Size11],[Size12],[Size13],[Size14],[Size15] from Smt_OrderSize where nStyleID=" + this.Session["stid"].ToString() + " and cLotNo='" + this.Session["Lot"].ToString() + "'");
                ds.Tables["Order_Size"].Merge(table23);
                this.rptDoc.Load(base.Server.MapPath("../Report_Merchandising/Rpt_AssortmentPackwise.rpt"));
            }
            this.rptDoc.SetDataSource((DataSet)ds);
            this.rptDoc.SetParameterValue("cStyleNo", str77);
            this.rptDoc.SetParameterValue("cBuyer_Name", str78);
            this.rptDoc.SetParameterValue("cSeason_Name", str79);
            this.rptDoc.SetParameterValue("cBrand_Name", str80);
            this.rptDoc.SetParameterValue("nOrdQty", str81);
            this.rptDoc.SetParameterValue("cGmetDis", str82);
            this.rptDoc.SetParameterValue("cCmpName", val);
            this.rptDoc.SetParameterValue("PONO", this.Session["PONO"].ToString());
            this.Session["stid"] = null;
            this.Session["PONO"] = null;
        }
        if (str == "BOM")
        {
            DataTable table24 = new DataTable();
            DataSet set9 = this.mybll.get_Informationdataset("Sp_Smt_StyleMaster_GetInfo " + this.Session["stid"].ToString());
            string str83 = set9.Tables[0].Rows[0]["cStyleNo"].ToString();
            string str84 = set9.Tables[0].Rows[0]["cBuyer_Name"].ToString();
            string str85 = set9.Tables[0].Rows[0]["cSeason_Name"].ToString();
            string str86 = set9.Tables[0].Rows[0]["cGmetDis"].ToString();
            string str87 = set9.Tables[0].Rows[0]["cBrand_Name"].ToString();
            string str88 = this.Session["Ver"].ToString();
            table24.TableName = "BOMAuto_Report";
            table24 = this._blinventory.get_InformationdataTable(string.Concat(new object[] { "Sp_Smt_BOM_ReportMasterCat1 ", this.Session["stid"].ToString(), ",", this.Session["Ver"] }));
            ds.Tables["BOMAuto_Report"].Merge(table24);
            if (str88 == "1")
            {
                this.rptDoc.Load(base.Server.MapPath("../Report_Merchandising/BOMMasterCatWiseVersion1.rpt"));
            }
            else
            {
                this.rptDoc.Load(base.Server.MapPath("../Report_Merchandising/BOMMasterCatWiseReport.rpt"));
            }
            this.rptDoc.SetDataSource((DataSet)ds);
            this.rptDoc.SetParameterValue("cCmpName", val);
            this.rptDoc.SetParameterValue("cStyleNo", str83);
            this.rptDoc.SetParameterValue("cBuyer_Name", str84);
            this.rptDoc.SetParameterValue("cSeason_Name", str85);
            this.rptDoc.SetParameterValue("cGmetDis", str86);
            this.rptDoc.SetParameterValue("cBrand_Name", str87);
            this.Session["Ver"] = null;
            this.Session["stid"] = null;
        }
        if (str == "TNA")
        {
            DataTable table25 = new DataTable();
            DataSet set10 = this.mybll.get_Informationdataset("Sp_Smt_StyleMaster_GetInfo " + this.Session["stid"].ToString());
            string str89 = set10.Tables[0].Rows[0]["cStyleNo"].ToString();
            string str90 = set10.Tables[0].Rows[0]["cBuyer_Name"].ToString();
            string str91 = set10.Tables[0].Rows[0]["cSeason_Name"].ToString();
            string str92 = set10.Tables[0].Rows[0]["cGmetDis"].ToString();
            string str93 = set10.Tables[0].Rows[0]["cBrand_Name"].ToString();
            DateTime.Parse(set10.Tables[0].Rows[0]["dBPCd"].ToString());
            DateTime time7 = DateTime.Parse(set10.Tables[0].Rows[0]["dCOShtRec"].ToString());
            string str94 = set10.Tables[0].Rows[0]["nOrdQty"].ToString();
            table25.TableName = "TNA";
            table25 = this.mybll.get_InformationdataTable("Sp_Smt_TNA_Style_GetTaskStatus " + this.Session["stid"].ToString());
            ds.Tables["TNA"].Merge(table25);
            this.rptDoc.Load(base.Server.MapPath("../Report_Merchandising/Rpt_TNA.rpt"));
            this.rptDoc.SetDataSource((DataSet)ds);
            this.rptDoc.SetParameterValue("cCmpName", val);
            this.rptDoc.SetParameterValue("cStyleNo", str89);
            this.rptDoc.SetParameterValue("cBuyer_Name", str90);
            this.rptDoc.SetParameterValue("cSeason_Name", str91);
            this.rptDoc.SetParameterValue("cGmetDis", str92);
            this.rptDoc.SetParameterValue("cBrand_Name", str93);
            this.rptDoc.SetParameterValue("nOrdQty", str94);
            this.rptDoc.SetParameterValue("Confirmdt", time7);
            this.Session["stid"] = null;
        }
        if (str == "OrdInhnd")
        {
            DataTable table26 = new DataTable();
            DataTable table27 = new DataTable();
            DataTable table28 = new DataTable();
            table26.TableName = "OrderInhand";
            table27.TableName = "Orderinhand_gmtdept";
            table28.TableName = "Orderinhand_gmttype";
            table27 = this.mybll.get_InformationdataTable("Sp_Smt_StyleMaster_ReportOrderinhand_Dept '" + this.Session["dtS"].ToString() + "','" + this.Session["dtE"].ToString() + "'," + this.Session["BirID"].ToString());
            table26 = this.mybll.get_InformationdataTable("Sp_Smt_StyleMaster_ReportOrderinhand '" + this.Session["dtS"].ToString() + "','" + this.Session["dtE"].ToString() + "'," + this.Session["BirID"].ToString());
            table28 = this.mybll.get_InformationdataTable("Sp_Smt_StyleMaster_ReportOrderinhand_gmtType '" + this.Session["dtS"].ToString() + "','" + this.Session["dtE"].ToString() + "'," + this.Session["BirID"].ToString());
            ds.Tables["OrderInhand"].Merge(table26);
            ds.Tables["Orderinhand_gmtdept"].Merge(table27);
            ds.Tables["Orderinhand_gmttype"].Merge(table28);
            this.rptDoc.Load(base.Server.MapPath("../Report_Merchandising/Rpt_OrderInhand.rpt"));
            this.rptDoc.SetDataSource((DataSet)ds);
            this.rptDoc.SetParameterValue("ComName", val);
            this.rptDoc.SetParameterValue("Stdt", this.Session["dtS"].ToString());
            this.rptDoc.SetParameterValue("Endt", this.Session["dtE"].ToString());
            this.Session["dtS"] = null;
            this.Session["dtE"] = null;
            this.Session["BirID"] = null;
        }
        if (str == "QC")
        {
            DataTable table29 = new DataTable
            {
                TableName = "Quickcosting"
            };
            table29 = this._blinventory.get_InformationdataTable("Sp_Smt_EstimateCosting_Quick_getReport '" + this.Session["stid"].ToString() + "'");
            ds.Tables["Quickcosting"].Merge(table29);
            this.rptDoc.Load(base.Server.MapPath("../Report_Merchandising/QC.rpt"));
            this.rptDoc.SetDataSource((DataSet)ds);
            this.rptDoc.SetParameterValue("ComName", val);
            this.Session["stid"] = null;
        }
        if (str == "Prjordsm")
        {
            DataTable table30 = new DataTable
            {
                TableName = "Projectedordsum"
            };
            table30 = this._blinventory.get_InformationdataTable("Sp_Smt_EstimateCosting_Quick_Prjordsummery '" + this.Session["dtS"].ToString() + "','" + this.Session["dtE"].ToString() + "'");
            ds.Tables["Projectedordsum"].Merge(table30);
            this.rptDoc.Load(base.Server.MapPath("../Report_Merchandising/projordsum.rpt"));
            this.rptDoc.SetDataSource((DataSet)ds);
            this.rptDoc.SetParameterValue("ComName", val);
            this.rptDoc.SetParameterValue("sdt", this.Session["dtS"].ToString());
            this.rptDoc.SetParameterValue("edt", this.Session["dtE"].ToString());
            this.Session["dtS"] = null;
            this.Session["dtE"] = null;
        }
        DataTable table31 = new DataTable();
        if (str == "sCPrc")
        {
            DataTable table32 = new DataTable
            {
                TableName = "szcolprcrpt"
            };
            table32 = this.mybll.get_InformationdataTable(string.Concat(new object[] { "Sp_Smt_ColSizprice '", this.Session["stid"], "','", this.Session["Lot"], "'" }));
            ds.Tables["szcolprcrpt"].Merge(table32);
            DataSet set11 = this.mybll.get_Informationdataset("SELECT lgo FROM Smt_Company where Display_AS_Header=1");
            if (set11.Tables[0].Rows.Count > 0)
            {
                FileStream stream2;
                table31.Columns.Add("lgo", Type.GetType("System.Byte[]"));
                DataRow row2 = table31.NewRow();
                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"rptsv\" + set11.Tables[0].Rows[0]["lgo"].ToString()))
                {
                    stream2 = new FileStream(AppDomain.CurrentDomain.BaseDirectory + @"rptsv\" + set11.Tables[0].Rows[0]["lgo"].ToString(), FileMode.Open);
                }
                else
                {
                    stream2 = new FileStream(AppDomain.CurrentDomain.BaseDirectory + @"rptsv\lgonoimg.png", FileMode.Open);
                }
                BinaryReader reader2 = new BinaryReader(stream2);
                byte[] buffer2 = new byte[stream2.Length + 1L];
                buffer2 = reader2.ReadBytes(Convert.ToInt32(stream2.Length));
                row2[0] = buffer2;
                table31.Rows.Add(row2);
                reader2.Close();
                stream2.Close();
                table31.AcceptChanges();
            }
            ds.Tables["rptimg"].Merge(table31);
            this.rptDoc.Load(base.Server.MapPath("../Report_Merchandising/imgtest.rpt"));
            this.rptDoc.SetDataSource((DataSet)ds);
            this.rptDoc.Load(base.Server.MapPath("../Report_Merchandising/Rpt_Colsizewiseprice.rpt"));
            this.rptDoc.SetDataSource((DataSet)ds);
            this.rptDoc.SetParameterValue("ComName", val);
            this.rptDoc.SetParameterValue("AD", str3);
            this.rptDoc.SetParameterValue("AD1", str4);
            this.Session["stid"] = null;
            this.Session["Lot"] = null;
        }
        if (str == "BuyerOrder")
        {
            DataTable table33 = new DataTable
            {
                TableName = "BROrdr"
            };
            table33 = this.mybll.get_InformationdataTable("Sp_Smt_StyleMaster_MntwiseBuyerorder '" + this.Session["dtS"].ToString() + "'," + this.Session["BirID"].ToString() + ",'" + this.Session["dtE"].ToString() + "'");
            ds.Tables["BROrdr"].Merge(table33);
            this.rptDoc.Load(base.Server.MapPath("../Report_Merchandising/Rpt_BuyerOrderD2D.rpt"));
            this.rptDoc.SetDataSource((DataSet)ds);
            this.rptDoc.SetParameterValue("ComName", val);
            this.rptDoc.SetParameterValue("Stdt", this.Session["dtS"].ToString());
            this.rptDoc.SetParameterValue("Endt", this.Session["dtE"].ToString());
            this.Session["dtS"] = null;
            this.Session["dtE"] = null;
            this.Session["BirID"] = null;
        }
        if (str == "tst")
        {
            DataTable table34 = new DataTable();
            DataSet set12 = this.mybll.get_Informationdataset("select Fileno,StyleID from Smt_StylemasterFile where StyleID=" + this.Session["stid"]);
            if (set12.Tables[0].Rows.Count > 0)
            {
                table34.Columns.Add("Fileno", Type.GetType("System.Byte[]"));
                table34.Columns.Add("StyleID", Type.GetType("System.Int32"));
                for (int num11 = 0; num11 < set12.Tables[0].Rows.Count; num11++)
                {
                    FileStream stream3;
                    DataRow row3 = table34.NewRow();
                    if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"StyleFile\" + set12.Tables[0].Rows[num11]["Fileno"].ToString()))
                    {
                        stream3 = new FileStream(AppDomain.CurrentDomain.BaseDirectory + @"StyleFile\" + set12.Tables[0].Rows[num11]["Fileno"].ToString(), FileMode.Open);
                    }
                    else
                    {
                        stream3 = new FileStream(AppDomain.CurrentDomain.BaseDirectory + @"images\mb.jpg", FileMode.Open);
                    }
                    BinaryReader reader3 = new BinaryReader(stream3);
                    byte[] buffer3 = new byte[stream3.Length + 1L];
                    buffer3 = reader3.ReadBytes(Convert.ToInt32(stream3.Length));
                    row3[0] = buffer3;
                    table34.Rows.Add(row3);
                    reader3.Close();
                    stream3.Close();
                }
                table34.AcceptChanges();
            }
            ds.Tables["tstimg"].Merge(table34);
            this.rptDoc.Load(base.Server.MapPath("../Report_Merchandising/imgtest.rpt"));
            this.rptDoc.SetDataSource((DataSet)ds);
        }
        this.Session["Param"] = null;
        MemoryStream stream4 = null;
        stream4 = (MemoryStream)this.rptDoc.ExportToStream(ExportFormatType.PortableDocFormat);
        //Stream stream4 = null;
        //stream4 = (Stream)this.rptDoc.ExportToStream(ExportFormatType.PortableDocFormat);
        HttpContext.Current.Response.Clear();
        HttpContext.Current.Response.Buffer = true;
        HttpContext.Current.Response.ContentType = "application/pdf";
        HttpContext.Current.Response.BinaryWrite(stream4.ToArray());
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

    public void signature(Merchandising ds, string userid)
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
