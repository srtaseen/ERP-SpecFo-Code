using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Configuration;
using System.Data.SqlClient;

[Serializable, XmlRoot("Inventory"), ToolboxItem(true), XmlSchemaProvider("GetTypedDataSetSchema"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code")]
public class Inventory : DataSet
{
//    private System.Data.SchemaSerializationMode _schemaSerializationMode;
//    private CompwisegrnDataTable tableCompwisegrn;
//    private Compwisegrn1DataTable tableCompwisegrn1;
//    private DTGRNDTLDataTable tableDTGRNDTL;
//    private DTGRNDTLSUMDataTable tableDTGRNDTLSUM;
//    private FactoryPurchase_ReportDataTable tableFactoryPurchase_Report;
//    private FPPOREPORTDataTable tableFPPOREPORT;
//    private GoodsIssueDataTable tableGoodsIssue;
//    private GoodsReturnDataTable tableGoodsReturn;
//    private GRN_ReportDataTable tableGRN_Report;
//    private GRND2DDataTable tableGRND2D;
//    private GRND2DFactorypurchaseDataTable tableGRND2DFactorypurchase;
//    private ItemLocationDataTable tableItemLocation;
//    private ItemTraker_GrnDataTable tableItemTraker_Grn;
//    private ItemTraker_IssueDataTable tableItemTraker_Issue;
//    private ItmTrakerDataTable tableItmTraker;
//    private monthwisefabricrptDataTable tablemonthwisefabricrpt;
//    private ReOrdErDataTable tableReOrdEr;
//    private RequestreportDataTable tableRequestreport;
//    private RPT_SignDataTable tableRPT_Sign;
//    private rptimgDataTable tablerptimg;
//    private Stock_BalanceDataTable tableStock_Balance;
//    private StyleStatusDataTable tableStyleStatus;

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//    public Inventory()
//    {
//        this._schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
//        base.BeginInit();
//        this.InitClass();
//        CollectionChangeEventHandler handler = new CollectionChangeEventHandler(this.SchemaChanged);
//        base.Tables.CollectionChanged += handler;
//        base.Relations.CollectionChanged += handler;
//        base.EndInit();
//    }

//    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    protected Inventory(SerializationInfo info, StreamingContext context) : base(info, context, false)
//    {
//        this._schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
//        if (base.IsBinarySerialized(info, context))
//        {
//            this.InitVars(false);
//            CollectionChangeEventHandler handler = new CollectionChangeEventHandler(this.SchemaChanged);
//            this.Tables.CollectionChanged += handler;
//            this.Relations.CollectionChanged += handler;
//        }
//        else
//        {
//            string s = (string)info.GetValue("XmlSchema", typeof(string));
//            if (base.DetermineSchemaSerializationMode(info, context) == System.Data.SchemaSerializationMode.IncludeSchema)
//            {
//                DataSet dataSet = new DataSet();
//                dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
//                if (dataSet.Tables["GRN_Report"] != null)
//                {
//                    base.Tables.Add(new GRN_ReportDataTable(dataSet.Tables["GRN_Report"]));
//                }
//                if (dataSet.Tables["FactoryPurchase_Report"] != null)
//                {
//                    base.Tables.Add(new FactoryPurchase_ReportDataTable(dataSet.Tables["FactoryPurchase_Report"]));
//                }
//                if (dataSet.Tables["StyleStatus"] != null)
//                {
//                    base.Tables.Add(new StyleStatusDataTable(dataSet.Tables["StyleStatus"]));
//                }
//                if (dataSet.Tables["GoodsIssue"] != null)
//                {
//                    base.Tables.Add(new GoodsIssueDataTable(dataSet.Tables["GoodsIssue"]));
//                }
//                if (dataSet.Tables["Stock Balance"] != null)
//                {
//                    base.Tables.Add(new Stock_BalanceDataTable(dataSet.Tables["Stock Balance"]));
//                }
//                if (dataSet.Tables["GRND2D"] != null)
//                {
//                    base.Tables.Add(new GRND2DDataTable(dataSet.Tables["GRND2D"]));
//                }
//                if (dataSet.Tables["GRND2DFactorypurchase"] != null)
//                {
//                    base.Tables.Add(new GRND2DFactorypurchaseDataTable(dataSet.Tables["GRND2DFactorypurchase"]));
//                }
//                if (dataSet.Tables["ItemTraker_Grn"] != null)
//                {
//                    base.Tables.Add(new ItemTraker_GrnDataTable(dataSet.Tables["ItemTraker_Grn"]));
//                }
//                if (dataSet.Tables["ItemTraker_Issue"] != null)
//                {
//                    base.Tables.Add(new ItemTraker_IssueDataTable(dataSet.Tables["ItemTraker_Issue"]));
//                }
//                if (dataSet.Tables["ItemLocation"] != null)
//                {
//                    base.Tables.Add(new ItemLocationDataTable(dataSet.Tables["ItemLocation"]));
//                }
//                if (dataSet.Tables["GoodsReturn"] != null)
//                {
//                    base.Tables.Add(new GoodsReturnDataTable(dataSet.Tables["GoodsReturn"]));
//                }
//                if (dataSet.Tables["Compwisegrn"] != null)
//                {
//                    base.Tables.Add(new CompwisegrnDataTable(dataSet.Tables["Compwisegrn"]));
//                }
//                if (dataSet.Tables["rptimg"] != null)
//                {
//                    base.Tables.Add(new rptimgDataTable(dataSet.Tables["rptimg"]));
//                }
//                if (dataSet.Tables["RPT_Sign"] != null)
//                {
//                    base.Tables.Add(new RPT_SignDataTable(dataSet.Tables["RPT_Sign"]));
//                }
//                if (dataSet.Tables["monthwisefabricrpt"] != null)
//                {
//                    base.Tables.Add(new monthwisefabricrptDataTable(dataSet.Tables["monthwisefabricrpt"]));
//                }
//                if (dataSet.Tables["DTGRNDTL"] != null)
//                {
//                    base.Tables.Add(new DTGRNDTLDataTable(dataSet.Tables["DTGRNDTL"]));
//                }
//                if (dataSet.Tables["DTGRNDTLSUM"] != null)
//                {
//                    base.Tables.Add(new DTGRNDTLSUMDataTable(dataSet.Tables["DTGRNDTLSUM"]));
//                }
//                if (dataSet.Tables["Requestreport"] != null)
//                {
//                    base.Tables.Add(new RequestreportDataTable(dataSet.Tables["Requestreport"]));
//                }
//                if (dataSet.Tables["FPPOREPORT"] != null)
//                {
//                    base.Tables.Add(new FPPOREPORTDataTable(dataSet.Tables["FPPOREPORT"]));
//                }
//                if (dataSet.Tables["ItmTraker"] != null)
//                {
//                    base.Tables.Add(new ItmTrakerDataTable(dataSet.Tables["ItmTraker"]));
//                }
//                if (dataSet.Tables["Compwisegrn1"] != null)
//                {
//                    base.Tables.Add(new Compwisegrn1DataTable(dataSet.Tables["Compwisegrn1"]));
//                }
//                if (dataSet.Tables["ReOrdEr"] != null)
//                {
//                    base.Tables.Add(new ReOrdErDataTable(dataSet.Tables["ReOrdEr"]));
//                }
//                base.DataSetName = dataSet.DataSetName;
//                base.Prefix = dataSet.Prefix;
//                base.Namespace = dataSet.Namespace;
//                base.Locale = dataSet.Locale;
//                base.CaseSensitive = dataSet.CaseSensitive;
//                base.EnforceConstraints = dataSet.EnforceConstraints;
//                base.Merge(dataSet, false, MissingSchemaAction.Add);
//                this.InitVars();
//            }
//            else
//            {
//                base.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
//            }
//            base.GetSerializationData(info, context);
//            CollectionChangeEventHandler handler2 = new CollectionChangeEventHandler(this.SchemaChanged);
//            base.Tables.CollectionChanged += handler2;
//            this.Relations.CollectionChanged += handler2;
//        }
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//    public override DataSet Clone()
//    {
//        Inventory inventory = (Inventory)base.Clone();
//        inventory.InitVars();
//        inventory.SchemaSerializationMode = this.SchemaSerializationMode;
//        return inventory;
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//    protected override XmlSchema GetSchemaSerializable()
//    {
//        MemoryStream w = new MemoryStream();
//        base.WriteXmlSchema(new XmlTextWriter(w, null));
//        w.Position = 0L;
//        return XmlSchema.Read(new XmlTextReader(w), null);
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//    public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
//    {
//        Inventory inventory = new Inventory();
//        XmlSchemaComplexType type = new XmlSchemaComplexType();
//        XmlSchemaSequence sequence = new XmlSchemaSequence();
//        XmlSchemaAny item = new XmlSchemaAny
//        {
//            Namespace = inventory.Namespace
//        };
//        sequence.Items.Add(item);
//        type.Particle = sequence;
//        XmlSchema schemaSerializable = inventory.GetSchemaSerializable();
//        if (xs.Contains(schemaSerializable.TargetNamespace))
//        {
//            MemoryStream stream = new MemoryStream();
//            MemoryStream stream2 = new MemoryStream();
//            try
//            {
//                XmlSchema current = null;
//                schemaSerializable.Write(stream);
//                IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
//                while (enumerator.MoveNext())
//                {
//                    current = (XmlSchema)enumerator.Current;
//                    stream2.SetLength(0L);
//                    current.Write(stream2);
//                    if (stream.Length == stream2.Length)
//                    {
//                        stream.Position = 0L;
//                        stream2.Position = 0L;
//                        while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
//                        {
//                        }
//                        if (stream.Position == stream.Length)
//                        {
//                            return type;
//                        }
//                    }
//                }
//            }
//            finally
//            {
//                if (stream != null)
//                {
//                    stream.Close();
//                }
//                if (stream2 != null)
//                {
//                    stream2.Close();
//                }
//            }
//        }
//        xs.Add(schemaSerializable);
//        return type;
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//    private void InitClass()
//    {
//        base.DataSetName = "Inventory";
//        base.Prefix = "";
//        base.Namespace = "http://tempuri.org/Inventory.xsd";
//        base.EnforceConstraints = true;
//        this.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
//        this.tableGRN_Report = new GRN_ReportDataTable();
//        base.Tables.Add(this.tableGRN_Report);
//        this.tableFactoryPurchase_Report = new FactoryPurchase_ReportDataTable();
//        base.Tables.Add(this.tableFactoryPurchase_Report);
//        this.tableStyleStatus = new StyleStatusDataTable();
//        base.Tables.Add(this.tableStyleStatus);
//        this.tableGoodsIssue = new GoodsIssueDataTable();
//        base.Tables.Add(this.tableGoodsIssue);
//        this.tableStock_Balance = new Stock_BalanceDataTable();
//        base.Tables.Add(this.tableStock_Balance);
//        this.tableGRND2D = new GRND2DDataTable();
//        base.Tables.Add(this.tableGRND2D);
//        this.tableGRND2DFactorypurchase = new GRND2DFactorypurchaseDataTable();
//        base.Tables.Add(this.tableGRND2DFactorypurchase);
//        this.tableItemTraker_Grn = new ItemTraker_GrnDataTable();
//        base.Tables.Add(this.tableItemTraker_Grn);
//        this.tableItemTraker_Issue = new ItemTraker_IssueDataTable();
//        base.Tables.Add(this.tableItemTraker_Issue);
//        this.tableItemLocation = new ItemLocationDataTable();
//        base.Tables.Add(this.tableItemLocation);
//        this.tableGoodsReturn = new GoodsReturnDataTable();
//        base.Tables.Add(this.tableGoodsReturn);
//        this.tableCompwisegrn = new CompwisegrnDataTable();
//        base.Tables.Add(this.tableCompwisegrn);
//        this.tablerptimg = new rptimgDataTable();
//        base.Tables.Add(this.tablerptimg);
//        this.tableRPT_Sign = new RPT_SignDataTable();
//        base.Tables.Add(this.tableRPT_Sign);
//        this.tablemonthwisefabricrpt = new monthwisefabricrptDataTable();
//        base.Tables.Add(this.tablemonthwisefabricrpt);
//        this.tableDTGRNDTL = new DTGRNDTLDataTable();
//        base.Tables.Add(this.tableDTGRNDTL);
//        this.tableDTGRNDTLSUM = new DTGRNDTLSUMDataTable();
//        base.Tables.Add(this.tableDTGRNDTLSUM);
//        this.tableRequestreport = new RequestreportDataTable();
//        base.Tables.Add(this.tableRequestreport);
//        this.tableFPPOREPORT = new FPPOREPORTDataTable();
//        base.Tables.Add(this.tableFPPOREPORT);
//        this.tableItmTraker = new ItmTrakerDataTable();
//        base.Tables.Add(this.tableItmTraker);
//        this.tableCompwisegrn1 = new Compwisegrn1DataTable();
//        base.Tables.Add(this.tableCompwisegrn1);
//        this.tableReOrdEr = new ReOrdErDataTable();
//        base.Tables.Add(this.tableReOrdEr);
//    }

//    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    protected override void InitializeDerivedDataSet()
//    {
//        base.BeginInit();
//        this.InitClass();
//        base.EndInit();
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//    internal void InitVars()
//    {
//        this.InitVars(true);
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//    internal void InitVars(bool initTable)
//    {
//        this.tableGRN_Report = (GRN_ReportDataTable)base.Tables["GRN_Report"];
//        if (initTable && (this.tableGRN_Report != null))
//        {
//            this.tableGRN_Report.InitVars();
//        }
//        this.tableFactoryPurchase_Report = (FactoryPurchase_ReportDataTable)base.Tables["FactoryPurchase_Report"];
//        if (initTable && (this.tableFactoryPurchase_Report != null))
//        {
//            this.tableFactoryPurchase_Report.InitVars();
//        }
//        this.tableStyleStatus = (StyleStatusDataTable)base.Tables["StyleStatus"];
//        if (initTable && (this.tableStyleStatus != null))
//        {
//            this.tableStyleStatus.InitVars();
//        }
//        this.tableGoodsIssue = (GoodsIssueDataTable)base.Tables["GoodsIssue"];
//        if (initTable && (this.tableGoodsIssue != null))
//        {
//            this.tableGoodsIssue.InitVars();
//        }
//        this.tableStock_Balance = (Stock_BalanceDataTable)base.Tables["Stock Balance"];
//        if (initTable && (this.tableStock_Balance != null))
//        {
//            this.tableStock_Balance.InitVars();
//        }
//        this.tableGRND2D = (GRND2DDataTable)base.Tables["GRND2D"];
//        if (initTable && (this.tableGRND2D != null))
//        {
//            this.tableGRND2D.InitVars();
//        }
//        this.tableGRND2DFactorypurchase = (GRND2DFactorypurchaseDataTable)base.Tables["GRND2DFactorypurchase"];
//        if (initTable && (this.tableGRND2DFactorypurchase != null))
//        {
//            this.tableGRND2DFactorypurchase.InitVars();
//        }
//        this.tableItemTraker_Grn = (ItemTraker_GrnDataTable)base.Tables["ItemTraker_Grn"];
//        if (initTable && (this.tableItemTraker_Grn != null))
//        {
//            this.tableItemTraker_Grn.InitVars();
//        }
//        this.tableItemTraker_Issue = (ItemTraker_IssueDataTable)base.Tables["ItemTraker_Issue"];
//        if (initTable && (this.tableItemTraker_Issue != null))
//        {
//            this.tableItemTraker_Issue.InitVars();
//        }
//        this.tableItemLocation = (ItemLocationDataTable)base.Tables["ItemLocation"];
//        if (initTable && (this.tableItemLocation != null))
//        {
//            this.tableItemLocation.InitVars();
//        }
//        this.tableGoodsReturn = (GoodsReturnDataTable)base.Tables["GoodsReturn"];
//        if (initTable && (this.tableGoodsReturn != null))
//        {
//            this.tableGoodsReturn.InitVars();
//        }
//        this.tableCompwisegrn = (CompwisegrnDataTable)base.Tables["Compwisegrn"];
//        if (initTable && (this.tableCompwisegrn != null))
//        {
//            this.tableCompwisegrn.InitVars();
//        }
//        this.tablerptimg = (rptimgDataTable)base.Tables["rptimg"];
//        if (initTable && (this.tablerptimg != null))
//        {
//            this.tablerptimg.InitVars();
//        }
//        this.tableRPT_Sign = (RPT_SignDataTable)base.Tables["RPT_Sign"];
//        if (initTable && (this.tableRPT_Sign != null))
//        {
//            this.tableRPT_Sign.InitVars();
//        }
//        this.tablemonthwisefabricrpt = (monthwisefabricrptDataTable)base.Tables["monthwisefabricrpt"];
//        if (initTable && (this.tablemonthwisefabricrpt != null))
//        {
//            this.tablemonthwisefabricrpt.InitVars();
//        }
//        this.tableDTGRNDTL = (DTGRNDTLDataTable)base.Tables["DTGRNDTL"];
//        if (initTable && (this.tableDTGRNDTL != null))
//        {
//            this.tableDTGRNDTL.InitVars();
//        }
//        this.tableDTGRNDTLSUM = (DTGRNDTLSUMDataTable)base.Tables["DTGRNDTLSUM"];
//        if (initTable && (this.tableDTGRNDTLSUM != null))
//        {
//            this.tableDTGRNDTLSUM.InitVars();
//        }
//        this.tableRequestreport = (RequestreportDataTable)base.Tables["Requestreport"];
//        if (initTable && (this.tableRequestreport != null))
//        {
//            this.tableRequestreport.InitVars();
//        }
//        this.tableFPPOREPORT = (FPPOREPORTDataTable)base.Tables["FPPOREPORT"];
//        if (initTable && (this.tableFPPOREPORT != null))
//        {
//            this.tableFPPOREPORT.InitVars();
//        }
//        this.tableItmTraker = (ItmTrakerDataTable)base.Tables["ItmTraker"];
//        if (initTable && (this.tableItmTraker != null))
//        {
//            this.tableItmTraker.InitVars();
//        }
//        this.tableCompwisegrn1 = (Compwisegrn1DataTable)base.Tables["Compwisegrn1"];
//        if (initTable && (this.tableCompwisegrn1 != null))
//        {
//            this.tableCompwisegrn1.InitVars();
//        }
//        this.tableReOrdEr = (ReOrdErDataTable)base.Tables["ReOrdEr"];
//        if (initTable && (this.tableReOrdEr != null))
//        {
//            this.tableReOrdEr.InitVars();
//        }
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//    protected override void ReadXmlSerializable(XmlReader reader)
//    {
//        if (base.DetermineSchemaSerializationMode(reader) == System.Data.SchemaSerializationMode.IncludeSchema)
//        {
//            this.Reset();
//            DataSet dataSet = new DataSet();
//            dataSet.ReadXml(reader);
//            if (dataSet.Tables["GRN_Report"] != null)
//            {
//                base.Tables.Add(new GRN_ReportDataTable(dataSet.Tables["GRN_Report"]));
//            }
//            if (dataSet.Tables["FactoryPurchase_Report"] != null)
//            {
//                base.Tables.Add(new FactoryPurchase_ReportDataTable(dataSet.Tables["FactoryPurchase_Report"]));
//            }
//            if (dataSet.Tables["StyleStatus"] != null)
//            {
//                base.Tables.Add(new StyleStatusDataTable(dataSet.Tables["StyleStatus"]));
//            }
//            if (dataSet.Tables["GoodsIssue"] != null)
//            {
//                base.Tables.Add(new GoodsIssueDataTable(dataSet.Tables["GoodsIssue"]));
//            }
//            if (dataSet.Tables["Stock Balance"] != null)
//            {
//                base.Tables.Add(new Stock_BalanceDataTable(dataSet.Tables["Stock Balance"]));
//            }
//            if (dataSet.Tables["GRND2D"] != null)
//            {
//                base.Tables.Add(new GRND2DDataTable(dataSet.Tables["GRND2D"]));
//            }
//            if (dataSet.Tables["GRND2DFactorypurchase"] != null)
//            {
//                base.Tables.Add(new GRND2DFactorypurchaseDataTable(dataSet.Tables["GRND2DFactorypurchase"]));
//            }
//            if (dataSet.Tables["ItemTraker_Grn"] != null)
//            {
//                base.Tables.Add(new ItemTraker_GrnDataTable(dataSet.Tables["ItemTraker_Grn"]));
//            }
//            if (dataSet.Tables["ItemTraker_Issue"] != null)
//            {
//                base.Tables.Add(new ItemTraker_IssueDataTable(dataSet.Tables["ItemTraker_Issue"]));
//            }
//            if (dataSet.Tables["ItemLocation"] != null)
//            {
//                base.Tables.Add(new ItemLocationDataTable(dataSet.Tables["ItemLocation"]));
//            }
//            if (dataSet.Tables["GoodsReturn"] != null)
//            {
//                base.Tables.Add(new GoodsReturnDataTable(dataSet.Tables["GoodsReturn"]));
//            }
//            if (dataSet.Tables["Compwisegrn"] != null)
//            {
//                base.Tables.Add(new CompwisegrnDataTable(dataSet.Tables["Compwisegrn"]));
//            }
//            if (dataSet.Tables["rptimg"] != null)
//            {
//                base.Tables.Add(new rptimgDataTable(dataSet.Tables["rptimg"]));
//            }
//            if (dataSet.Tables["RPT_Sign"] != null)
//            {
//                base.Tables.Add(new RPT_SignDataTable(dataSet.Tables["RPT_Sign"]));
//            }
//            if (dataSet.Tables["monthwisefabricrpt"] != null)
//            {
//                base.Tables.Add(new monthwisefabricrptDataTable(dataSet.Tables["monthwisefabricrpt"]));
//            }
//            if (dataSet.Tables["DTGRNDTL"] != null)
//            {
//                base.Tables.Add(new DTGRNDTLDataTable(dataSet.Tables["DTGRNDTL"]));
//            }
//            if (dataSet.Tables["DTGRNDTLSUM"] != null)
//            {
//                base.Tables.Add(new DTGRNDTLSUMDataTable(dataSet.Tables["DTGRNDTLSUM"]));
//            }
//            if (dataSet.Tables["Requestreport"] != null)
//            {
//                base.Tables.Add(new RequestreportDataTable(dataSet.Tables["Requestreport"]));
//            }
//            if (dataSet.Tables["FPPOREPORT"] != null)
//            {
//                base.Tables.Add(new FPPOREPORTDataTable(dataSet.Tables["FPPOREPORT"]));
//            }
//            if (dataSet.Tables["ItmTraker"] != null)
//            {
//                base.Tables.Add(new ItmTrakerDataTable(dataSet.Tables["ItmTraker"]));
//            }
//            if (dataSet.Tables["Compwisegrn1"] != null)
//            {
//                base.Tables.Add(new Compwisegrn1DataTable(dataSet.Tables["Compwisegrn1"]));
//            }
//            if (dataSet.Tables["ReOrdEr"] != null)
//            {
//                base.Tables.Add(new ReOrdErDataTable(dataSet.Tables["ReOrdEr"]));
//            }
//            base.DataSetName = dataSet.DataSetName;
//            base.Prefix = dataSet.Prefix;
//            base.Namespace = dataSet.Namespace;
//            base.Locale = dataSet.Locale;
//            base.CaseSensitive = dataSet.CaseSensitive;
//            base.EnforceConstraints = dataSet.EnforceConstraints;
//            base.Merge(dataSet, false, MissingSchemaAction.Add);
//            this.InitVars();
//        }
//        else
//        {
//            base.ReadXml(reader);
//            this.InitVars();
//        }
//    }

//    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    private void SchemaChanged(object sender, CollectionChangeEventArgs e)
//    {
//        if (e.Action == CollectionChangeAction.Remove)
//        {
//            this.InitVars();
//        }
//    }

//    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    private bool ShouldSerializeCompwisegrn() =>
//        false;

//    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    private bool ShouldSerializeCompwisegrn1() =>
//        false;

//    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    private bool ShouldSerializeDTGRNDTL() =>
//        false;

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//    private bool ShouldSerializeDTGRNDTLSUM() =>
//        false;

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//    private bool ShouldSerializeFactoryPurchase_Report() =>
//        false;

//    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    private bool ShouldSerializeFPPOREPORT() =>
//        false;

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//    private bool ShouldSerializeGoodsIssue() =>
//        false;

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//    private bool ShouldSerializeGoodsReturn() =>
//        false;

//    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    private bool ShouldSerializeGRN_Report() =>
//        false;

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//    private bool ShouldSerializeGRND2D() =>
//        false;

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//    private bool ShouldSerializeGRND2DFactorypurchase() =>
//        false;

//    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    private bool ShouldSerializeItemLocation() =>
//        false;

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//    private bool ShouldSerializeItemTraker_Grn() =>
//        false;

//    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    private bool ShouldSerializeItemTraker_Issue() =>
//        false;

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//    private bool ShouldSerializeItmTraker() =>
//        false;

//    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    private bool ShouldSerializemonthwisefabricrpt() =>
//        false;

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//    protected override bool ShouldSerializeRelations() =>
//        false;

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//    private bool ShouldSerializeReOrdEr() =>
//        false;

//    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    private bool ShouldSerializeRequestreport() =>
//        false;

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//    private bool ShouldSerializeRPT_Sign() =>
//        false;

//    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    private bool ShouldSerializerptimg() =>
//        false;

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//    private bool ShouldSerializeStock_Balance() =>
//        false;

//    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    private bool ShouldSerializeStyleStatus() =>
//        false;

//    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    protected override bool ShouldSerializeTables() =>
//        false;

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
//    public CompwisegrnDataTable Compwisegrn =>
//        this.tableCompwisegrn;

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
//    public Compwisegrn1DataTable Compwisegrn1 =>
//        this.tableCompwisegrn1;

//    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public DTGRNDTLDataTable DTGRNDTL = this.tableDTGRNDTL;

//    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
//    public DTGRNDTLSUMDataTable DTGRNDTLSUM =>        this.tableDTGRNDTLSUM;

//    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
//    public FactoryPurchase_ReportDataTable FactoryPurchase_Report =>
//        this.tableFactoryPurchase_Report;

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
//    public FPPOREPORTDataTable FPPOREPORT =
//        this.tableFPPOREPORT;

//    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
//    public GoodsIssueDataTable GoodsIssue =>
//        this.tableGoodsIssue;

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
//    public GoodsReturnDataTable GoodsReturn =>
//        this.tableGoodsReturn;

//    [DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
//    public GRN_ReportDataTable GRN_Report =>
//        this.tableGRN_Report;

//    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode]
//    public GRND2DDataTable GRND2D =>
//        this.tableGRND2D;

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
//    public GRND2DFactorypurchaseDataTable GRND2DFactorypurchase =>
//        this.tableGRND2DFactorypurchase;

//    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//    public ItemLocationDataTable ItemLocation =>
//        this.tableItemLocation;

//    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
//    public ItemTraker_GrnDataTable ItemTraker_Grn =>
//        this.tableItemTraker_Grn;

//    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//    public ItemTraker_IssueDataTable ItemTraker_Issue =>
//        this.tableItemTraker_Issue;

//    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
//    public ItmTrakerDataTable ItmTraker =>
//        this.tableItmTraker;

//    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//    public monthwisefabricrptDataTable monthwisefabricrpt =>
//        this.tablemonthwisefabricrpt;

//    [DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public DataRelationCollection Relations =>
//        base.Relations;

//    [Browsable(false), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
//    public ReOrdErDataTable ReOrdEr =>
//        this.tableReOrdEr;

//    [DebuggerNonUserCode, Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public RequestreportDataTable Requestreport =>
//        this.tableRequestreport;

//    [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//    public RPT_SignDataTable RPT_Sign =>
//        this.tableRPT_Sign;

//    [DebuggerNonUserCode, Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public rptimgDataTable rptimg =>
//        this.tablerptimg;

//    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(true), DebuggerNonUserCode]
//    public override System.Data.SchemaSerializationMode SchemaSerializationMode
//    {
//        get => 
//            this._schemaSerializationMode;
//        set
//        {
//            this._schemaSerializationMode = value;
//        }
//        }

//        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, Browsable(false)]
//        public Stock_BalanceDataTable Stock_Balance =>
//        this.tableStock_Balance;

//        [DebuggerNonUserCode, Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public StyleStatusDataTable StyleStatus =>
//        this.tableStyleStatus;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
//        public DataTableCollection Tables =>
//        base.Tables;

//        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
//        public class Compwisegrn1DataTable : TypedTableBase<Inventory.Compwisegrn1Row>
//    {
//        private DataColumn columncCmpName;
//        private DataColumn columncMainCategory;
//        private DataColumn columnnValue;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.Compwisegrn1RowChangeEventHandler Compwisegrn1RowChanged;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.Compwisegrn1RowChangeEventHandler Compwisegrn1RowChanging;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.Compwisegrn1RowChangeEventHandler Compwisegrn1RowDeleted;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.Compwisegrn1RowChangeEventHandler Compwisegrn1RowDeleting;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Compwisegrn1DataTable()
//        {
//            base.TableName = "Compwisegrn1";
//            this.BeginInit();
//            this.InitClass();
//            this.EndInit();
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal Compwisegrn1DataTable(DataTable table)
//        {
//            base.TableName = table.TableName;
//            if (table.CaseSensitive != table.DataSet.CaseSensitive)
//            {
//                base.CaseSensitive = table.CaseSensitive;
//            }
//            if (table.Locale.ToString() != table.DataSet.Locale.ToString())
//            {
//                base.Locale = table.Locale;
//            }
//            if (table.Namespace != table.DataSet.Namespace)
//            {
//                base.Namespace = table.Namespace;
//            }
//            base.Prefix = table.Prefix;
//            base.MinimumCapacity = table.MinimumCapacity;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected Compwisegrn1DataTable(SerializationInfo info, StreamingContext context) : base(info, context)
//        {
//            this.InitVars();
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void AddCompwisegrn1Row(Inventory.Compwisegrn1Row row)
//        {
//            base.Rows.Add(row);
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.Compwisegrn1Row AddCompwisegrn1Row(string cCmpName, string cMainCategory, decimal nValue)
//        {
//            Inventory.Compwisegrn1Row row = (Inventory.Compwisegrn1Row)base.NewRow();
//            row.ItemArray = new object[] { cCmpName, cMainCategory, nValue };
//            base.Rows.Add(row);
//            return row;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public override DataTable Clone()
//        {
//            Inventory.Compwisegrn1DataTable table = (Inventory.Compwisegrn1DataTable)base.Clone();
//            table.InitVars();
//            return table;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override DataTable CreateInstance() =>
//            new Inventory.Compwisegrn1DataTable();

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override Type GetRowType() =>
//            typeof(Inventory.Compwisegrn1Row);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
//        {
//            XmlSchemaComplexType type = new XmlSchemaComplexType();
//            XmlSchemaSequence sequence = new XmlSchemaSequence();
//            Inventory inventory = new Inventory();
//            XmlSchemaAny item = new XmlSchemaAny
//            {
//                Namespace = "http://www.w3.org/2001/XMLSchema",
//                MinOccurs = 0M,
//                MaxOccurs = 79228162514264337593543950335M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(item);
//            XmlSchemaAny any2 = new XmlSchemaAny
//            {
//                Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
//                MinOccurs = 1M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(any2);
//            XmlSchemaAttribute attribute = new XmlSchemaAttribute
//            {
//                Name = "namespace",
//                FixedValue = inventory.Namespace
//            };
//            type.Attributes.Add(attribute);
//            XmlSchemaAttribute attribute2 = new XmlSchemaAttribute
//            {
//                Name = "tableTypeName",
//                FixedValue = "Compwisegrn1DataTable"
//            };
//            type.Attributes.Add(attribute2);
//            type.Particle = sequence;
//            XmlSchema schemaSerializable = inventory.GetSchemaSerializable();
//            if (xs.Contains(schemaSerializable.TargetNamespace))
//            {
//                MemoryStream stream = new MemoryStream();
//                MemoryStream stream2 = new MemoryStream();
//                try
//                {
//                    XmlSchema current = null;
//                    schemaSerializable.Write(stream);
//                    IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
//                    while (enumerator.MoveNext())
//                    {
//                        current = (XmlSchema)enumerator.Current;
//                        stream2.SetLength(0L);
//                        current.Write(stream2);
//                        if (stream.Length == stream2.Length)
//                        {
//                            stream.Position = 0L;
//                            stream2.Position = 0L;
//                            while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
//                            {
//                            }
//                            if (stream.Position == stream.Length)
//                            {
//                                return type;
//                            }
//                        }
//                    }
//                }
//                finally
//                {
//                    if (stream != null)
//                    {
//                        stream.Close();
//                    }
//                    if (stream2 != null)
//                    {
//                        stream2.Close();
//                    }
//                }
//            }
//            xs.Add(schemaSerializable);
//            return type;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        private void InitClass()
//        {
//            this.columncCmpName = new DataColumn("cCmpName", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncCmpName);
//            this.columncMainCategory = new DataColumn("cMainCategory", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncMainCategory);
//            this.columnnValue = new DataColumn("nValue", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnnValue);
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal void InitVars()
//        {
//            this.columncCmpName = base.Columns["cCmpName"];
//            this.columncMainCategory = base.Columns["cMainCategory"];
//            this.columnnValue = base.Columns["nValue"];
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.Compwisegrn1Row NewCompwisegrn1Row() =>
//            ((Inventory.Compwisegrn1Row)base.NewRow());

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) =>
//            new Inventory.Compwisegrn1Row(builder);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowChanged(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanged(e);
//            if (this.Compwisegrn1RowChanged != null)
//            {
//                this.Compwisegrn1RowChanged(this, new Inventory.Compwisegrn1RowChangeEvent((Inventory.Compwisegrn1Row)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowChanging(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanging(e);
//            if (this.Compwisegrn1RowChanging != null)
//            {
//                this.Compwisegrn1RowChanging(this, new Inventory.Compwisegrn1RowChangeEvent((Inventory.Compwisegrn1Row)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowDeleted(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleted(e);
//            if (this.Compwisegrn1RowDeleted != null)
//            {
//                this.Compwisegrn1RowDeleted(this, new Inventory.Compwisegrn1RowChangeEvent((Inventory.Compwisegrn1Row)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowDeleting(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleting(e);
//            if (this.Compwisegrn1RowDeleting != null)
//            {
//                this.Compwisegrn1RowDeleting(this, new Inventory.Compwisegrn1RowChangeEvent((Inventory.Compwisegrn1Row)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void RemoveCompwisegrn1Row(Inventory.Compwisegrn1Row row)
//        {
//            base.Rows.Remove(row);
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cCmpNameColumn =>
//            this.columncCmpName;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cMainCategoryColumn =>
//            this.columncMainCategory;

//        [DebuggerNonUserCode, Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public int Count =>
//            base.Rows.Count;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public Inventory.Compwisegrn1Row this[int index] =>
//            ((Inventory.Compwisegrn1Row)base.Rows[index]);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn nValueColumn =>
//            this.columnnValue;
//    }

//    public class Compwisegrn1Row : DataRow
//    {
//        private Inventory.Compwisegrn1DataTable tableCompwisegrn1;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        internal Compwisegrn1Row(DataRowBuilder rb) : base(rb)
//        {
//            this.tableCompwisegrn1 = (Inventory.Compwisegrn1DataTable)base.Table;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscCmpNameNull() =>
//            base.IsNull(this.tableCompwisegrn1.cCmpNameColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscMainCategoryNull() =>
//            base.IsNull(this.tableCompwisegrn1.cMainCategoryColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsnValueNull() =>
//            base.IsNull(this.tableCompwisegrn1.nValueColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcCmpNameNull()
//        {
//            base[this.tableCompwisegrn1.cCmpNameColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcMainCategoryNull()
//        {
//            base[this.tableCompwisegrn1.cMainCategoryColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnValueNull()
//        {
//            base[this.tableCompwisegrn1.nValueColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cCmpName
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableCompwisegrn1.cCmpNameColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cCmpName' in table 'Compwisegrn1' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableCompwisegrn1.cCmpNameColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cMainCategory
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableCompwisegrn1.cMainCategoryColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cMainCategory' in table 'Compwisegrn1' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableCompwisegrn1.cMainCategoryColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public decimal nValue
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableCompwisegrn1.nValueColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nValue' in table 'Compwisegrn1' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableCompwisegrn1.nValueColumn] = value;
//            }
//        }
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public class Compwisegrn1RowChangeEvent : EventArgs
//    {
//        private DataRowAction eventAction;
//        private Inventory.Compwisegrn1Row eventRow;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public Compwisegrn1RowChangeEvent(Inventory.Compwisegrn1Row row, DataRowAction action)
//        {
//            this.eventRow = row;
//            this.eventAction = action;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataRowAction Action =>
//            this.eventAction;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.Compwisegrn1Row Row =>
//            this.eventRow;
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public delegate void Compwisegrn1RowChangeEventHandler(object sender, Inventory.Compwisegrn1RowChangeEvent e);

//    [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
//    public class CompwisegrnDataTable : TypedTableBase<Inventory.CompwisegrnRow>
//    {
//        private DataColumn columncCmpName;
//        private DataColumn columncMainCategory;
//        private DataColumn columnnValue;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.CompwisegrnRowChangeEventHandler CompwisegrnRowChanged;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.CompwisegrnRowChangeEventHandler CompwisegrnRowChanging;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.CompwisegrnRowChangeEventHandler CompwisegrnRowDeleted;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.CompwisegrnRowChangeEventHandler CompwisegrnRowDeleting;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public CompwisegrnDataTable()
//        {
//            base.TableName = "Compwisegrn";
//            this.BeginInit();
//            this.InitClass();
//            this.EndInit();
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal CompwisegrnDataTable(DataTable table)
//        {
//            base.TableName = table.TableName;
//            if (table.CaseSensitive != table.DataSet.CaseSensitive)
//            {
//                base.CaseSensitive = table.CaseSensitive;
//            }
//            if (table.Locale.ToString() != table.DataSet.Locale.ToString())
//            {
//                base.Locale = table.Locale;
//            }
//            if (table.Namespace != table.DataSet.Namespace)
//            {
//                base.Namespace = table.Namespace;
//            }
//            base.Prefix = table.Prefix;
//            base.MinimumCapacity = table.MinimumCapacity;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected CompwisegrnDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
//        {
//            this.InitVars();
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void AddCompwisegrnRow(Inventory.CompwisegrnRow row)
//        {
//            base.Rows.Add(row);
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public Inventory.CompwisegrnRow AddCompwisegrnRow(string cCmpName, string cMainCategory, decimal nValue)
//        {
//            Inventory.CompwisegrnRow row = (Inventory.CompwisegrnRow)base.NewRow();
//            row.ItemArray = new object[] { cCmpName, cMainCategory, nValue };
//            base.Rows.Add(row);
//            return row;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public override DataTable Clone()
//        {
//            Inventory.CompwisegrnDataTable table = (Inventory.CompwisegrnDataTable)base.Clone();
//            table.InitVars();
//            return table;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override DataTable CreateInstance() =>
//            new Inventory.CompwisegrnDataTable();

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override Type GetRowType() =>
//            typeof(Inventory.CompwisegrnRow);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
//        {
//            XmlSchemaComplexType type = new XmlSchemaComplexType();
//            XmlSchemaSequence sequence = new XmlSchemaSequence();
//            Inventory inventory = new Inventory();
//            XmlSchemaAny item = new XmlSchemaAny
//            {
//                Namespace = "http://www.w3.org/2001/XMLSchema",
//                MinOccurs = 0M,
//                MaxOccurs = 79228162514264337593543950335M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(item);
//            XmlSchemaAny any2 = new XmlSchemaAny
//            {
//                Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
//                MinOccurs = 1M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(any2);
//            XmlSchemaAttribute attribute = new XmlSchemaAttribute
//            {
//                Name = "namespace",
//                FixedValue = inventory.Namespace
//            };
//            type.Attributes.Add(attribute);
//            XmlSchemaAttribute attribute2 = new XmlSchemaAttribute
//            {
//                Name = "tableTypeName",
//                FixedValue = "CompwisegrnDataTable"
//            };
//            type.Attributes.Add(attribute2);
//            type.Particle = sequence;
//            XmlSchema schemaSerializable = inventory.GetSchemaSerializable();
//            if (xs.Contains(schemaSerializable.TargetNamespace))
//            {
//                MemoryStream stream = new MemoryStream();
//                MemoryStream stream2 = new MemoryStream();
//                try
//                {
//                    XmlSchema current = null;
//                    schemaSerializable.Write(stream);
//                    IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
//                    while (enumerator.MoveNext())
//                    {
//                        current = (XmlSchema)enumerator.Current;
//                        stream2.SetLength(0L);
//                        current.Write(stream2);
//                        if (stream.Length == stream2.Length)
//                        {
//                            stream.Position = 0L;
//                            stream2.Position = 0L;
//                            while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
//                            {
//                            }
//                            if (stream.Position == stream.Length)
//                            {
//                                return type;
//                            }
//                        }
//                    }
//                }
//                finally
//                {
//                    if (stream != null)
//                    {
//                        stream.Close();
//                    }
//                    if (stream2 != null)
//                    {
//                        stream2.Close();
//                    }
//                }
//            }
//            xs.Add(schemaSerializable);
//            return type;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        private void InitClass()
//        {
//            this.columncCmpName = new DataColumn("cCmpName", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncCmpName);
//            this.columncMainCategory = new DataColumn("cMainCategory", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncMainCategory);
//            this.columnnValue = new DataColumn("nValue", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnnValue);
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        internal void InitVars()
//        {
//            this.columncCmpName = base.Columns["cCmpName"];
//            this.columncMainCategory = base.Columns["cMainCategory"];
//            this.columnnValue = base.Columns["nValue"];
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.CompwisegrnRow NewCompwisegrnRow() =>
//            ((Inventory.CompwisegrnRow)base.NewRow());

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) =>
//            new Inventory.CompwisegrnRow(builder);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowChanged(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanged(e);
//            if (this.CompwisegrnRowChanged != null)
//            {
//                this.CompwisegrnRowChanged(this, new Inventory.CompwisegrnRowChangeEvent((Inventory.CompwisegrnRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowChanging(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanging(e);
//            if (this.CompwisegrnRowChanging != null)
//            {
//                this.CompwisegrnRowChanging(this, new Inventory.CompwisegrnRowChangeEvent((Inventory.CompwisegrnRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowDeleted(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleted(e);
//            if (this.CompwisegrnRowDeleted != null)
//            {
//                this.CompwisegrnRowDeleted(this, new Inventory.CompwisegrnRowChangeEvent((Inventory.CompwisegrnRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowDeleting(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleting(e);
//            if (this.CompwisegrnRowDeleting != null)
//            {
//                this.CompwisegrnRowDeleting(this, new Inventory.CompwisegrnRowChangeEvent((Inventory.CompwisegrnRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void RemoveCompwisegrnRow(Inventory.CompwisegrnRow row)
//        {
//            base.Rows.Remove(row);
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cCmpNameColumn =>
//            this.columncCmpName;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cMainCategoryColumn =>
//            this.columncMainCategory;

//        [Browsable(false), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public int Count =>
//            base.Rows.Count;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.CompwisegrnRow this[int index] =>
//            ((Inventory.CompwisegrnRow)base.Rows[index]);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn nValueColumn =>
//            this.columnnValue;
//    }

//    public class CompwisegrnRow : DataRow
//    {
//        private Inventory.CompwisegrnDataTable tableCompwisegrn;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal CompwisegrnRow(DataRowBuilder rb) : base(rb)
//        {
//            this.tableCompwisegrn = (Inventory.CompwisegrnDataTable)base.Table;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscCmpNameNull() =>
//            base.IsNull(this.tableCompwisegrn.cCmpNameColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscMainCategoryNull() =>
//            base.IsNull(this.tableCompwisegrn.cMainCategoryColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsnValueNull() =>
//            base.IsNull(this.tableCompwisegrn.nValueColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcCmpNameNull()
//        {
//            base[this.tableCompwisegrn.cCmpNameColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcMainCategoryNull()
//        {
//            base[this.tableCompwisegrn.cMainCategoryColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnValueNull()
//        {
//            base[this.tableCompwisegrn.nValueColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cCmpName
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableCompwisegrn.cCmpNameColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cCmpName' in table 'Compwisegrn' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableCompwisegrn.cCmpNameColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cMainCategory
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableCompwisegrn.cMainCategoryColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cMainCategory' in table 'Compwisegrn' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableCompwisegrn.cMainCategoryColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public decimal nValue
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableCompwisegrn.nValueColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nValue' in table 'Compwisegrn' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableCompwisegrn.nValueColumn] = value;
//            }
//        }
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public class CompwisegrnRowChangeEvent : EventArgs
//    {
//        private DataRowAction eventAction;
//        private Inventory.CompwisegrnRow eventRow;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public CompwisegrnRowChangeEvent(Inventory.CompwisegrnRow row, DataRowAction action)
//        {
//            this.eventRow = row;
//            this.eventAction = action;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataRowAction Action =>
//            this.eventAction;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public Inventory.CompwisegrnRow Row =>
//            this.eventRow;
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public delegate void CompwisegrnRowChangeEventHandler(object sender, Inventory.CompwisegrnRowChangeEvent e);

//    [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
//    public class DTGRNDTLDataTable : TypedTableBase<Inventory.DTGRNDTLRow>
//    {
//        private DataColumn columncArt;
//        private DataColumn columncBuyer_Name;
//        private DataColumn columncColour;
//        private DataColumn columncDimec;
//        private DataColumn columncInVoice;
//        private DataColumn columncItemDec;
//        private DataColumn columncMainCategory;
//        private DataColumn columncStyleNo;
//        private DataColumn columncSupName;
//        private DataColumn columncUnit;
//        private DataColumn columndEntDate;
//        private DataColumn columnnGrnNo;
//        private DataColumn columnnPoNum;
//        private DataColumn columnnQty;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.DTGRNDTLRowChangeEventHandler DTGRNDTLRowChanged;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.DTGRNDTLRowChangeEventHandler DTGRNDTLRowChanging;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.DTGRNDTLRowChangeEventHandler DTGRNDTLRowDeleted;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.DTGRNDTLRowChangeEventHandler DTGRNDTLRowDeleting;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DTGRNDTLDataTable()
//        {
//            base.TableName = "DTGRNDTL";
//            this.BeginInit();
//            this.InitClass();
//            this.EndInit();
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal DTGRNDTLDataTable(DataTable table)
//        {
//            base.TableName = table.TableName;
//            if (table.CaseSensitive != table.DataSet.CaseSensitive)
//            {
//                base.CaseSensitive = table.CaseSensitive;
//            }
//            if (table.Locale.ToString() != table.DataSet.Locale.ToString())
//            {
//                base.Locale = table.Locale;
//            }
//            if (table.Namespace != table.DataSet.Namespace)
//            {
//                base.Namespace = table.Namespace;
//            }
//            base.Prefix = table.Prefix;
//            base.MinimumCapacity = table.MinimumCapacity;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected DTGRNDTLDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
//        {
//            this.InitVars();
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void AddDTGRNDTLRow(Inventory.DTGRNDTLRow row)
//        {
//            base.Rows.Add(row);
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.DTGRNDTLRow AddDTGRNDTLRow(int nGrnNo, int nPoNum, string cInVoice, string cMainCategory, string cItemDec, string cColour, string cArt, string cDimec, string cUnit, decimal nQty, string cStyleNo, string cSupName, string cBuyer_Name, DateTime dEntDate)
//        {
//            Inventory.DTGRNDTLRow row = (Inventory.DTGRNDTLRow)base.NewRow();
//            row.ItemArray = new object[] { nGrnNo, nPoNum, cInVoice, cMainCategory, cItemDec, cColour, cArt, cDimec, cUnit, nQty, cStyleNo, cSupName, cBuyer_Name, dEntDate };
//            base.Rows.Add(row);
//            return row;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public override DataTable Clone()
//        {
//            Inventory.DTGRNDTLDataTable table = (Inventory.DTGRNDTLDataTable)base.Clone();
//            table.InitVars();
//            return table;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override DataTable CreateInstance() =>
//            new Inventory.DTGRNDTLDataTable();

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override Type GetRowType() =>
//            typeof(Inventory.DTGRNDTLRow);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
//        {
//            XmlSchemaComplexType type = new XmlSchemaComplexType();
//            XmlSchemaSequence sequence = new XmlSchemaSequence();
//            Inventory inventory = new Inventory();
//            XmlSchemaAny item = new XmlSchemaAny
//            {
//                Namespace = "http://www.w3.org/2001/XMLSchema",
//                MinOccurs = 0M,
//                MaxOccurs = 79228162514264337593543950335M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(item);
//            XmlSchemaAny any2 = new XmlSchemaAny
//            {
//                Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
//                MinOccurs = 1M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(any2);
//            XmlSchemaAttribute attribute = new XmlSchemaAttribute
//            {
//                Name = "namespace",
//                FixedValue = inventory.Namespace
//            };
//            type.Attributes.Add(attribute);
//            XmlSchemaAttribute attribute2 = new XmlSchemaAttribute
//            {
//                Name = "tableTypeName",
//                FixedValue = "DTGRNDTLDataTable"
//            };
//            type.Attributes.Add(attribute2);
//            type.Particle = sequence;
//            XmlSchema schemaSerializable = inventory.GetSchemaSerializable();
//            if (xs.Contains(schemaSerializable.TargetNamespace))
//            {
//                MemoryStream stream = new MemoryStream();
//                MemoryStream stream2 = new MemoryStream();
//                try
//                {
//                    XmlSchema current = null;
//                    schemaSerializable.Write(stream);
//                    IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
//                    while (enumerator.MoveNext())
//                    {
//                        current = (XmlSchema)enumerator.Current;
//                        stream2.SetLength(0L);
//                        current.Write(stream2);
//                        if (stream.Length == stream2.Length)
//                        {
//                            stream.Position = 0L;
//                            stream2.Position = 0L;
//                            while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
//                            {
//                            }
//                            if (stream.Position == stream.Length)
//                            {
//                                return type;
//                            }
//                        }
//                    }
//                }
//                finally
//                {
//                    if (stream != null)
//                    {
//                        stream.Close();
//                    }
//                    if (stream2 != null)
//                    {
//                        stream2.Close();
//                    }
//                }
//            }
//            xs.Add(schemaSerializable);
//            return type;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        private void InitClass()
//        {
//            this.columnnGrnNo = new DataColumn("nGrnNo", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnnGrnNo);
//            this.columnnPoNum = new DataColumn("nPoNum", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnnPoNum);
//            this.columncInVoice = new DataColumn("cInVoice", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncInVoice);
//            this.columncMainCategory = new DataColumn("cMainCategory", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncMainCategory);
//            this.columncItemDec = new DataColumn("cItemDec", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncItemDec);
//            this.columncColour = new DataColumn("cColour", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncColour);
//            this.columncArt = new DataColumn("cArt", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncArt);
//            this.columncDimec = new DataColumn("cDimec", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncDimec);
//            this.columncUnit = new DataColumn("cUnit", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncUnit);
//            this.columnnQty = new DataColumn("nQty", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnnQty);
//            this.columncStyleNo = new DataColumn("cStyleNo", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncStyleNo);
//            this.columncSupName = new DataColumn("cSupName", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncSupName);
//            this.columncBuyer_Name = new DataColumn("cBuyer_Name", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncBuyer_Name);
//            this.columndEntDate = new DataColumn("dEntDate", typeof(DateTime), null, MappingType.Element);
//            base.Columns.Add(this.columndEntDate);
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal void InitVars()
//        {
//            this.columnnGrnNo = base.Columns["nGrnNo"];
//            this.columnnPoNum = base.Columns["nPoNum"];
//            this.columncInVoice = base.Columns["cInVoice"];
//            this.columncMainCategory = base.Columns["cMainCategory"];
//            this.columncItemDec = base.Columns["cItemDec"];
//            this.columncColour = base.Columns["cColour"];
//            this.columncArt = base.Columns["cArt"];
//            this.columncDimec = base.Columns["cDimec"];
//            this.columncUnit = base.Columns["cUnit"];
//            this.columnnQty = base.Columns["nQty"];
//            this.columncStyleNo = base.Columns["cStyleNo"];
//            this.columncSupName = base.Columns["cSupName"];
//            this.columncBuyer_Name = base.Columns["cBuyer_Name"];
//            this.columndEntDate = base.Columns["dEntDate"];
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.DTGRNDTLRow NewDTGRNDTLRow() =>
//            ((Inventory.DTGRNDTLRow)base.NewRow());

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) =>
//            new Inventory.DTGRNDTLRow(builder);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowChanged(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanged(e);
//            if (this.DTGRNDTLRowChanged != null)
//            {
//                this.DTGRNDTLRowChanged(this, new Inventory.DTGRNDTLRowChangeEvent((Inventory.DTGRNDTLRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowChanging(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanging(e);
//            if (this.DTGRNDTLRowChanging != null)
//            {
//                this.DTGRNDTLRowChanging(this, new Inventory.DTGRNDTLRowChangeEvent((Inventory.DTGRNDTLRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowDeleted(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleted(e);
//            if (this.DTGRNDTLRowDeleted != null)
//            {
//                this.DTGRNDTLRowDeleted(this, new Inventory.DTGRNDTLRowChangeEvent((Inventory.DTGRNDTLRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowDeleting(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleting(e);
//            if (this.DTGRNDTLRowDeleting != null)
//            {
//                this.DTGRNDTLRowDeleting(this, new Inventory.DTGRNDTLRowChangeEvent((Inventory.DTGRNDTLRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void RemoveDTGRNDTLRow(Inventory.DTGRNDTLRow row)
//        {
//            base.Rows.Remove(row);
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cArtColumn =>
//            this.columncArt;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cBuyer_NameColumn =>
//            this.columncBuyer_Name;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cColourColumn =>
//            this.columncColour;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cDimecColumn =>
//            this.columncDimec;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cInVoiceColumn =>
//            this.columncInVoice;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cItemDecColumn =>
//            this.columncItemDec;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cMainCategoryColumn =>
//            this.columncMainCategory;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, Browsable(false)]
//        public int Count =>
//            base.Rows.Count;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cStyleNoColumn =>
//            this.columncStyleNo;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cSupNameColumn =>
//            this.columncSupName;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cUnitColumn =>
//            this.columncUnit;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn dEntDateColumn =>
//            this.columndEntDate;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public Inventory.DTGRNDTLRow this[int index] =>
//            ((Inventory.DTGRNDTLRow)base.Rows[index]);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn nGrnNoColumn =>
//            this.columnnGrnNo;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn nPoNumColumn =>
//            this.columnnPoNum;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn nQtyColumn =>
//            this.columnnQty;
//    }

//    public class DTGRNDTLRow : DataRow
//    {
//        private Inventory.DTGRNDTLDataTable tableDTGRNDTL;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal DTGRNDTLRow(DataRowBuilder rb) : base(rb)
//        {
//            this.tableDTGRNDTL = (Inventory.DTGRNDTLDataTable)base.Table;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscArtNull() =>
//            base.IsNull(this.tableDTGRNDTL.cArtColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscBuyer_NameNull() =>
//            base.IsNull(this.tableDTGRNDTL.cBuyer_NameColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscColourNull() =>
//            base.IsNull(this.tableDTGRNDTL.cColourColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscDimecNull() =>
//            base.IsNull(this.tableDTGRNDTL.cDimecColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscInVoiceNull() =>
//            base.IsNull(this.tableDTGRNDTL.cInVoiceColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscItemDecNull() =>
//            base.IsNull(this.tableDTGRNDTL.cItemDecColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscMainCategoryNull() =>
//            base.IsNull(this.tableDTGRNDTL.cMainCategoryColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscStyleNoNull() =>
//            base.IsNull(this.tableDTGRNDTL.cStyleNoColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscSupNameNull() =>
//            base.IsNull(this.tableDTGRNDTL.cSupNameColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscUnitNull() =>
//            base.IsNull(this.tableDTGRNDTL.cUnitColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsdEntDateNull() =>
//            base.IsNull(this.tableDTGRNDTL.dEntDateColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsnGrnNoNull() =>
//            base.IsNull(this.tableDTGRNDTL.nGrnNoColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsnPoNumNull() =>
//            base.IsNull(this.tableDTGRNDTL.nPoNumColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsnQtyNull() =>
//            base.IsNull(this.tableDTGRNDTL.nQtyColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcArtNull()
//        {
//            base[this.tableDTGRNDTL.cArtColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcBuyer_NameNull()
//        {
//            base[this.tableDTGRNDTL.cBuyer_NameColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcColourNull()
//        {
//            base[this.tableDTGRNDTL.cColourColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcDimecNull()
//        {
//            base[this.tableDTGRNDTL.cDimecColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcInVoiceNull()
//        {
//            base[this.tableDTGRNDTL.cInVoiceColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcItemDecNull()
//        {
//            base[this.tableDTGRNDTL.cItemDecColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcMainCategoryNull()
//        {
//            base[this.tableDTGRNDTL.cMainCategoryColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcStyleNoNull()
//        {
//            base[this.tableDTGRNDTL.cStyleNoColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcSupNameNull()
//        {
//            base[this.tableDTGRNDTL.cSupNameColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcUnitNull()
//        {
//            base[this.tableDTGRNDTL.cUnitColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetdEntDateNull()
//        {
//            base[this.tableDTGRNDTL.dEntDateColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnGrnNoNull()
//        {
//            base[this.tableDTGRNDTL.nGrnNoColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnPoNumNull()
//        {
//            base[this.tableDTGRNDTL.nPoNumColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnQtyNull()
//        {
//            base[this.tableDTGRNDTL.nQtyColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cArt
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableDTGRNDTL.cArtColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cArt' in table 'DTGRNDTL' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableDTGRNDTL.cArtColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cBuyer_Name
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableDTGRNDTL.cBuyer_NameColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cBuyer_Name' in table 'DTGRNDTL' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableDTGRNDTL.cBuyer_NameColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cColour
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableDTGRNDTL.cColourColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cColour' in table 'DTGRNDTL' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableDTGRNDTL.cColourColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cDimec
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableDTGRNDTL.cDimecColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cDimec' in table 'DTGRNDTL' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableDTGRNDTL.cDimecColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cInVoice
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableDTGRNDTL.cInVoiceColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cInVoice' in table 'DTGRNDTL' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableDTGRNDTL.cInVoiceColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cItemDec
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableDTGRNDTL.cItemDecColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cItemDec' in table 'DTGRNDTL' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableDTGRNDTL.cItemDecColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cMainCategory
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableDTGRNDTL.cMainCategoryColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cMainCategory' in table 'DTGRNDTL' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableDTGRNDTL.cMainCategoryColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cStyleNo
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableDTGRNDTL.cStyleNoColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cStyleNo' in table 'DTGRNDTL' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableDTGRNDTL.cStyleNoColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cSupName
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableDTGRNDTL.cSupNameColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cSupName' in table 'DTGRNDTL' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableDTGRNDTL.cSupNameColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cUnit
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableDTGRNDTL.cUnitColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cUnit' in table 'DTGRNDTL' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableDTGRNDTL.cUnitColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DateTime dEntDate
//        {
//            get
//            {
//                DateTime time;
//                try
//                {
//                    time = (DateTime)base[this.tableDTGRNDTL.dEntDateColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'dEntDate' in table 'DTGRNDTL' is DBNull.", exception);
//                }
//                return time;
//            }
//            set
//            {
//                base[this.tableDTGRNDTL.dEntDateColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public int nGrnNo
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableDTGRNDTL.nGrnNoColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nGrnNo' in table 'DTGRNDTL' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableDTGRNDTL.nGrnNoColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public int nPoNum
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableDTGRNDTL.nPoNumColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nPoNum' in table 'DTGRNDTL' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableDTGRNDTL.nPoNumColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public decimal nQty
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableDTGRNDTL.nQtyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nQty' in table 'DTGRNDTL' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableDTGRNDTL.nQtyColumn] = value;
//            }
//        }
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public class DTGRNDTLRowChangeEvent : EventArgs
//    {
//        private DataRowAction eventAction;
//        private Inventory.DTGRNDTLRow eventRow;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DTGRNDTLRowChangeEvent(Inventory.DTGRNDTLRow row, DataRowAction action)
//        {
//            this.eventRow = row;
//            this.eventAction = action;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataRowAction Action =>
//            this.eventAction;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.DTGRNDTLRow Row =>
//            this.eventRow;
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public delegate void DTGRNDTLRowChangeEventHandler(object sender, Inventory.DTGRNDTLRowChangeEvent e);

//    [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
//    public class DTGRNDTLSUMDataTable : TypedTableBase<Inventory.DTGRNDTLSUMRow>
//    {
//        private DataColumn columncBuyer_Name;
//        private DataColumn columnNqTY;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.DTGRNDTLSUMRowChangeEventHandler DTGRNDTLSUMRowChanged;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.DTGRNDTLSUMRowChangeEventHandler DTGRNDTLSUMRowChanging;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.DTGRNDTLSUMRowChangeEventHandler DTGRNDTLSUMRowDeleted;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.DTGRNDTLSUMRowChangeEventHandler DTGRNDTLSUMRowDeleting;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DTGRNDTLSUMDataTable()
//        {
//            base.TableName = "DTGRNDTLSUM";
//            this.BeginInit();
//            this.InitClass();
//            this.EndInit();
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal DTGRNDTLSUMDataTable(DataTable table)
//        {
//            base.TableName = table.TableName;
//            if (table.CaseSensitive != table.DataSet.CaseSensitive)
//            {
//                base.CaseSensitive = table.CaseSensitive;
//            }
//            if (table.Locale.ToString() != table.DataSet.Locale.ToString())
//            {
//                base.Locale = table.Locale;
//            }
//            if (table.Namespace != table.DataSet.Namespace)
//            {
//                base.Namespace = table.Namespace;
//            }
//            base.Prefix = table.Prefix;
//            base.MinimumCapacity = table.MinimumCapacity;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected DTGRNDTLSUMDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
//        {
//            this.InitVars();
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void AddDTGRNDTLSUMRow(Inventory.DTGRNDTLSUMRow row)
//        {
//            base.Rows.Add(row);
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public Inventory.DTGRNDTLSUMRow AddDTGRNDTLSUMRow(decimal NqTY, string cBuyer_Name)
//        {
//            Inventory.DTGRNDTLSUMRow row = (Inventory.DTGRNDTLSUMRow)base.NewRow();
//            row.ItemArray = new object[] { NqTY, cBuyer_Name };
//            base.Rows.Add(row);
//            return row;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public override DataTable Clone()
//        {
//            Inventory.DTGRNDTLSUMDataTable table = (Inventory.DTGRNDTLSUMDataTable)base.Clone();
//            table.InitVars();
//            return table;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override DataTable CreateInstance() =>
//            new Inventory.DTGRNDTLSUMDataTable();

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override Type GetRowType() =>
//            typeof(Inventory.DTGRNDTLSUMRow);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
//        {
//            XmlSchemaComplexType type = new XmlSchemaComplexType();
//            XmlSchemaSequence sequence = new XmlSchemaSequence();
//            Inventory inventory = new Inventory();
//            XmlSchemaAny item = new XmlSchemaAny
//            {
//                Namespace = "http://www.w3.org/2001/XMLSchema",
//                MinOccurs = 0M,
//                MaxOccurs = 79228162514264337593543950335M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(item);
//            XmlSchemaAny any2 = new XmlSchemaAny
//            {
//                Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
//                MinOccurs = 1M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(any2);
//            XmlSchemaAttribute attribute = new XmlSchemaAttribute
//            {
//                Name = "namespace",
//                FixedValue = inventory.Namespace
//            };
//            type.Attributes.Add(attribute);
//            XmlSchemaAttribute attribute2 = new XmlSchemaAttribute
//            {
//                Name = "tableTypeName",
//                FixedValue = "DTGRNDTLSUMDataTable"
//            };
//            type.Attributes.Add(attribute2);
//            type.Particle = sequence;
//            XmlSchema schemaSerializable = inventory.GetSchemaSerializable();
//            if (xs.Contains(schemaSerializable.TargetNamespace))
//            {
//                MemoryStream stream = new MemoryStream();
//                MemoryStream stream2 = new MemoryStream();
//                try
//                {
//                    XmlSchema current = null;
//                    schemaSerializable.Write(stream);
//                    IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
//                    while (enumerator.MoveNext())
//                    {
//                        current = (XmlSchema)enumerator.Current;
//                        stream2.SetLength(0L);
//                        current.Write(stream2);
//                        if (stream.Length == stream2.Length)
//                        {
//                            stream.Position = 0L;
//                            stream2.Position = 0L;
//                            while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
//                            {
//                            }
//                            if (stream.Position == stream.Length)
//                            {
//                                return type;
//                            }
//                        }
//                    }
//                }
//                finally
//                {
//                    if (stream != null)
//                    {
//                        stream.Close();
//                    }
//                    if (stream2 != null)
//                    {
//                        stream2.Close();
//                    }
//                }
//            }
//            xs.Add(schemaSerializable);
//            return type;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        private void InitClass()
//        {
//            this.columnNqTY = new DataColumn("NqTY", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnNqTY);
//            this.columncBuyer_Name = new DataColumn("cBuyer_Name", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncBuyer_Name);
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        internal void InitVars()
//        {
//            this.columnNqTY = base.Columns["NqTY"];
//            this.columncBuyer_Name = base.Columns["cBuyer_Name"];
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.DTGRNDTLSUMRow NewDTGRNDTLSUMRow() =>
//            ((Inventory.DTGRNDTLSUMRow)base.NewRow());

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) =>
//            new Inventory.DTGRNDTLSUMRow(builder);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowChanged(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanged(e);
//            if (this.DTGRNDTLSUMRowChanged != null)
//            {
//                this.DTGRNDTLSUMRowChanged(this, new Inventory.DTGRNDTLSUMRowChangeEvent((Inventory.DTGRNDTLSUMRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowChanging(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanging(e);
//            if (this.DTGRNDTLSUMRowChanging != null)
//            {
//                this.DTGRNDTLSUMRowChanging(this, new Inventory.DTGRNDTLSUMRowChangeEvent((Inventory.DTGRNDTLSUMRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowDeleted(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleted(e);
//            if (this.DTGRNDTLSUMRowDeleted != null)
//            {
//                this.DTGRNDTLSUMRowDeleted(this, new Inventory.DTGRNDTLSUMRowChangeEvent((Inventory.DTGRNDTLSUMRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowDeleting(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleting(e);
//            if (this.DTGRNDTLSUMRowDeleting != null)
//            {
//                this.DTGRNDTLSUMRowDeleting(this, new Inventory.DTGRNDTLSUMRowChangeEvent((Inventory.DTGRNDTLSUMRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void RemoveDTGRNDTLSUMRow(Inventory.DTGRNDTLSUMRow row)
//        {
//            base.Rows.Remove(row);
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cBuyer_NameColumn =>
//            this.columncBuyer_Name;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
//        public int Count =>
//            base.Rows.Count;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.DTGRNDTLSUMRow this[int index] =>
//            ((Inventory.DTGRNDTLSUMRow)base.Rows[index]);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn NqTYColumn =>
//            this.columnNqTY;
//    }

//    public class DTGRNDTLSUMRow : DataRow
//    {
//        private Inventory.DTGRNDTLSUMDataTable tableDTGRNDTLSUM;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        internal DTGRNDTLSUMRow(DataRowBuilder rb) : base(rb)
//        {
//            this.tableDTGRNDTLSUM = (Inventory.DTGRNDTLSUMDataTable)base.Table;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscBuyer_NameNull() =>
//            base.IsNull(this.tableDTGRNDTLSUM.cBuyer_NameColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsNqTYNull() =>
//            base.IsNull(this.tableDTGRNDTLSUM.NqTYColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcBuyer_NameNull()
//        {
//            base[this.tableDTGRNDTLSUM.cBuyer_NameColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetNqTYNull()
//        {
//            base[this.tableDTGRNDTLSUM.NqTYColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cBuyer_Name
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableDTGRNDTLSUM.cBuyer_NameColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cBuyer_Name' in table 'DTGRNDTLSUM' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableDTGRNDTLSUM.cBuyer_NameColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public decimal NqTY
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableDTGRNDTLSUM.NqTYColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'NqTY' in table 'DTGRNDTLSUM' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableDTGRNDTLSUM.NqTYColumn] = value;
//            }
//        }
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public class DTGRNDTLSUMRowChangeEvent : EventArgs
//    {
//        private DataRowAction eventAction;
//        private Inventory.DTGRNDTLSUMRow eventRow;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DTGRNDTLSUMRowChangeEvent(Inventory.DTGRNDTLSUMRow row, DataRowAction action)
//        {
//            this.eventRow = row;
//            this.eventAction = action;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataRowAction Action =>
//            this.eventAction;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public Inventory.DTGRNDTLSUMRow Row =>
//            this.eventRow;
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public delegate void DTGRNDTLSUMRowChangeEventHandler(object sender, Inventory.DTGRNDTLSUMRowChangeEvent e);

//    [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
//    public class FactoryPurchase_ReportDataTable : TypedTableBase<Inventory.FactoryPurchase_ReportRow>
//    {
//        private DataColumn columnApprovedBy;
//        private DataColumn columncArticle;
//        private DataColumn columncBrand_Name;
//        private DataColumn columncCmpName;
//        private DataColumn columncColour;
//        private DataColumn columncCurType;
//        private DataColumn columncDeptname;
//        private DataColumn columncDes;
//        private DataColumn columncDimen;
//        private DataColumn columncSection_Description;
//        private DataColumn columncSize1;
//        private DataColumn columncStyleNo;
//        private DataColumn columncSupName;
//        private DataColumn columncUnitDes;
//        private DataColumn columncUserFullname;
//        private DataColumn columndReqQty;
//        private DataColumn columndUnitPrice;
//        private DataColumn columndValue;
//        private DataColumn columnPO_Approved;
//        private DataColumn columnPO_Approved_By;
//        private DataColumn columnPO_Cancel;
//        private DataColumn columnPO_Create;
//        private DataColumn columnPO_CreatedDate;
//        private DataColumn columnPO_No;
//        private DataColumn columnRemarks;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.FactoryPurchase_ReportRowChangeEventHandler FactoryPurchase_ReportRowChanged;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.FactoryPurchase_ReportRowChangeEventHandler FactoryPurchase_ReportRowChanging;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.FactoryPurchase_ReportRowChangeEventHandler FactoryPurchase_ReportRowDeleted;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.FactoryPurchase_ReportRowChangeEventHandler FactoryPurchase_ReportRowDeleting;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public FactoryPurchase_ReportDataTable()
//        {
//            base.TableName = "FactoryPurchase_Report";
//            this.BeginInit();
//            this.InitClass();
//            this.EndInit();
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        internal FactoryPurchase_ReportDataTable(DataTable table)
//        {
//            base.TableName = table.TableName;
//            if (table.CaseSensitive != table.DataSet.CaseSensitive)
//            {
//                base.CaseSensitive = table.CaseSensitive;
//            }
//            if (table.Locale.ToString() != table.DataSet.Locale.ToString())
//            {
//                base.Locale = table.Locale;
//            }
//            if (table.Namespace != table.DataSet.Namespace)
//            {
//                base.Namespace = table.Namespace;
//            }
//            base.Prefix = table.Prefix;
//            base.MinimumCapacity = table.MinimumCapacity;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected FactoryPurchase_ReportDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
//        {
//            this.InitVars();
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void AddFactoryPurchase_ReportRow(Inventory.FactoryPurchase_ReportRow row)
//        {
//            base.Rows.Add(row);
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public Inventory.FactoryPurchase_ReportRow AddFactoryPurchase_ReportRow(string cStyleNo, string cDes, string cArticle, string cDimen, string cUnitDes, decimal dReqQty, decimal dUnitPrice, decimal dValue, DateTime PO_CreatedDate, bool PO_Create, string cSupName, string cSection_Description, string cDeptname, string cCurType, int PO_No, bool PO_Approved, bool PO_Cancel, string cUserFullname, string ApprovedBy, string cCmpName, string cColour, string PO_Approved_By, string Remarks, string cBrand_Name, string cSize1)
//        {
//            Inventory.FactoryPurchase_ReportRow row = (Inventory.FactoryPurchase_ReportRow)base.NewRow();
//            row.ItemArray = new object[] {
//                cStyleNo, cDes, cArticle, cDimen, cUnitDes, dReqQty, dUnitPrice, dValue, PO_CreatedDate, PO_Create, cSupName, cSection_Description, cDeptname, cCurType, PO_No, PO_Approved,
//                PO_Cancel, cUserFullname, ApprovedBy, cCmpName, cColour, PO_Approved_By, Remarks, cBrand_Name, cSize1
//            };
//            base.Rows.Add(row);
//            return row;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public override DataTable Clone()
//        {
//            Inventory.FactoryPurchase_ReportDataTable table = (Inventory.FactoryPurchase_ReportDataTable)base.Clone();
//            table.InitVars();
//            return table;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override DataTable CreateInstance() =>
//            new Inventory.FactoryPurchase_ReportDataTable();

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override Type GetRowType() =>
//            typeof(Inventory.FactoryPurchase_ReportRow);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
//        {
//            XmlSchemaComplexType type = new XmlSchemaComplexType();
//            XmlSchemaSequence sequence = new XmlSchemaSequence();
//            Inventory inventory = new Inventory();
//            XmlSchemaAny item = new XmlSchemaAny
//            {
//                Namespace = "http://www.w3.org/2001/XMLSchema",
//                MinOccurs = 0M,
//                MaxOccurs = 79228162514264337593543950335M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(item);
//            XmlSchemaAny any2 = new XmlSchemaAny
//            {
//                Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
//                MinOccurs = 1M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(any2);
//            XmlSchemaAttribute attribute = new XmlSchemaAttribute
//            {
//                Name = "namespace",
//                FixedValue = inventory.Namespace
//            };
//            type.Attributes.Add(attribute);
//            XmlSchemaAttribute attribute2 = new XmlSchemaAttribute
//            {
//                Name = "tableTypeName",
//                FixedValue = "FactoryPurchase_ReportDataTable"
//            };
//            type.Attributes.Add(attribute2);
//            type.Particle = sequence;
//            XmlSchema schemaSerializable = inventory.GetSchemaSerializable();
//            if (xs.Contains(schemaSerializable.TargetNamespace))
//            {
//                MemoryStream stream = new MemoryStream();
//                MemoryStream stream2 = new MemoryStream();
//                try
//                {
//                    XmlSchema current = null;
//                    schemaSerializable.Write(stream);
//                    IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
//                    while (enumerator.MoveNext())
//                    {
//                        current = (XmlSchema)enumerator.Current;
//                        stream2.SetLength(0L);
//                        current.Write(stream2);
//                        if (stream.Length == stream2.Length)
//                        {
//                            stream.Position = 0L;
//                            stream2.Position = 0L;
//                            while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
//                            {
//                            }
//                            if (stream.Position == stream.Length)
//                            {
//                                return type;
//                            }
//                        }
//                    }
//                }
//                finally
//                {
//                    if (stream != null)
//                    {
//                        stream.Close();
//                    }
//                    if (stream2 != null)
//                    {
//                        stream2.Close();
//                    }
//                }
//            }
//            xs.Add(schemaSerializable);
//            return type;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        private void InitClass()
//        {
//            this.columncStyleNo = new DataColumn("cStyleNo", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncStyleNo);
//            this.columncDes = new DataColumn("cDes", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncDes);
//            this.columncArticle = new DataColumn("cArticle", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncArticle);
//            this.columncDimen = new DataColumn("cDimen", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncDimen);
//            this.columncUnitDes = new DataColumn("cUnitDes", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncUnitDes);
//            this.columndReqQty = new DataColumn("dReqQty", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columndReqQty);
//            this.columndUnitPrice = new DataColumn("dUnitPrice", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columndUnitPrice);
//            this.columndValue = new DataColumn("dValue", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columndValue);
//            this.columnPO_CreatedDate = new DataColumn("PO_CreatedDate", typeof(DateTime), null, MappingType.Element);
//            base.Columns.Add(this.columnPO_CreatedDate);
//            this.columnPO_Create = new DataColumn("PO_Create", typeof(bool), null, MappingType.Element);
//            base.Columns.Add(this.columnPO_Create);
//            this.columncSupName = new DataColumn("cSupName", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncSupName);
//            this.columncSection_Description = new DataColumn("cSection_Description", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncSection_Description);
//            this.columncDeptname = new DataColumn("cDeptname", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncDeptname);
//            this.columncCurType = new DataColumn("cCurType", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncCurType);
//            this.columnPO_No = new DataColumn("PO_No", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnPO_No);
//            this.columnPO_Approved = new DataColumn("PO_Approved", typeof(bool), null, MappingType.Element);
//            base.Columns.Add(this.columnPO_Approved);
//            this.columnPO_Cancel = new DataColumn("PO_Cancel", typeof(bool), null, MappingType.Element);
//            base.Columns.Add(this.columnPO_Cancel);
//            this.columncUserFullname = new DataColumn("cUserFullname", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncUserFullname);
//            this.columnApprovedBy = new DataColumn("ApprovedBy", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columnApprovedBy);
//            this.columncCmpName = new DataColumn("cCmpName", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncCmpName);
//            this.columncColour = new DataColumn("cColour", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncColour);
//            this.columnPO_Approved_By = new DataColumn("PO_Approved_By", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columnPO_Approved_By);
//            this.columnRemarks = new DataColumn("Remarks", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columnRemarks);
//            this.columncBrand_Name = new DataColumn("cBrand_Name", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncBrand_Name);
//            this.columncSize1 = new DataColumn("cSize1", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncSize1);
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal void InitVars()
//        {
//            this.columncStyleNo = base.Columns["cStyleNo"];
//            this.columncDes = base.Columns["cDes"];
//            this.columncArticle = base.Columns["cArticle"];
//            this.columncDimen = base.Columns["cDimen"];
//            this.columncUnitDes = base.Columns["cUnitDes"];
//            this.columndReqQty = base.Columns["dReqQty"];
//            this.columndUnitPrice = base.Columns["dUnitPrice"];
//            this.columndValue = base.Columns["dValue"];
//            this.columnPO_CreatedDate = base.Columns["PO_CreatedDate"];
//            this.columnPO_Create = base.Columns["PO_Create"];
//            this.columncSupName = base.Columns["cSupName"];
//            this.columncSection_Description = base.Columns["cSection_Description"];
//            this.columncDeptname = base.Columns["cDeptname"];
//            this.columncCurType = base.Columns["cCurType"];
//            this.columnPO_No = base.Columns["PO_No"];
//            this.columnPO_Approved = base.Columns["PO_Approved"];
//            this.columnPO_Cancel = base.Columns["PO_Cancel"];
//            this.columncUserFullname = base.Columns["cUserFullname"];
//            this.columnApprovedBy = base.Columns["ApprovedBy"];
//            this.columncCmpName = base.Columns["cCmpName"];
//            this.columncColour = base.Columns["cColour"];
//            this.columnPO_Approved_By = base.Columns["PO_Approved_By"];
//            this.columnRemarks = base.Columns["Remarks"];
//            this.columncBrand_Name = base.Columns["cBrand_Name"];
//            this.columncSize1 = base.Columns["cSize1"];
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.FactoryPurchase_ReportRow NewFactoryPurchase_ReportRow() =>
//            ((Inventory.FactoryPurchase_ReportRow)base.NewRow());

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) =>
//            new Inventory.FactoryPurchase_ReportRow(builder);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowChanged(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanged(e);
//            if (this.FactoryPurchase_ReportRowChanged != null)
//            {
//                this.FactoryPurchase_ReportRowChanged(this, new Inventory.FactoryPurchase_ReportRowChangeEvent((Inventory.FactoryPurchase_ReportRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowChanging(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanging(e);
//            if (this.FactoryPurchase_ReportRowChanging != null)
//            {
//                this.FactoryPurchase_ReportRowChanging(this, new Inventory.FactoryPurchase_ReportRowChangeEvent((Inventory.FactoryPurchase_ReportRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowDeleted(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleted(e);
//            if (this.FactoryPurchase_ReportRowDeleted != null)
//            {
//                this.FactoryPurchase_ReportRowDeleted(this, new Inventory.FactoryPurchase_ReportRowChangeEvent((Inventory.FactoryPurchase_ReportRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowDeleting(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleting(e);
//            if (this.FactoryPurchase_ReportRowDeleting != null)
//            {
//                this.FactoryPurchase_ReportRowDeleting(this, new Inventory.FactoryPurchase_ReportRowChangeEvent((Inventory.FactoryPurchase_ReportRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void RemoveFactoryPurchase_ReportRow(Inventory.FactoryPurchase_ReportRow row)
//        {
//            base.Rows.Remove(row);
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn ApprovedByColumn =>
//            this.columnApprovedBy;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cArticleColumn =>
//            this.columncArticle;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cBrand_NameColumn =>
//            this.columncBrand_Name;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cCmpNameColumn =>
//            this.columncCmpName;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cColourColumn =>
//            this.columncColour;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cCurTypeColumn =>
//            this.columncCurType;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cDeptnameColumn =>
//            this.columncDeptname;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cDesColumn =>
//            this.columncDes;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cDimenColumn =>
//            this.columncDimen;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
//        public int Count =>
//            base.Rows.Count;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cSection_DescriptionColumn =>
//            this.columncSection_Description;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cSize1Column =>
//            this.columncSize1;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cStyleNoColumn =>
//            this.columncStyleNo;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cSupNameColumn =>
//            this.columncSupName;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cUnitDesColumn =>
//            this.columncUnitDes;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cUserFullnameColumn =>
//            this.columncUserFullname;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn dReqQtyColumn =>
//            this.columndReqQty;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn dUnitPriceColumn =>
//            this.columndUnitPrice;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn dValueColumn =>
//            this.columndValue;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public Inventory.FactoryPurchase_ReportRow this[int index] =>
//            ((Inventory.FactoryPurchase_ReportRow)base.Rows[index]);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn PO_Approved_ByColumn =>
//            this.columnPO_Approved_By;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn PO_ApprovedColumn =>
//            this.columnPO_Approved;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn PO_CancelColumn =>
//            this.columnPO_Cancel;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn PO_CreateColumn =>
//            this.columnPO_Create;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn PO_CreatedDateColumn =>
//            this.columnPO_CreatedDate;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn PO_NoColumn =>
//            this.columnPO_No;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn RemarksColumn =>
//            this.columnRemarks;
//    }

//    public class FactoryPurchase_ReportRow : DataRow
//    {
//        private Inventory.FactoryPurchase_ReportDataTable tableFactoryPurchase_Report;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        internal FactoryPurchase_ReportRow(DataRowBuilder rb) : base(rb)
//        {
//            this.tableFactoryPurchase_Report = (Inventory.FactoryPurchase_ReportDataTable)base.Table;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsApprovedByNull() =>
//            base.IsNull(this.tableFactoryPurchase_Report.ApprovedByColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscArticleNull() =>
//            base.IsNull(this.tableFactoryPurchase_Report.cArticleColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscBrand_NameNull() =>
//            base.IsNull(this.tableFactoryPurchase_Report.cBrand_NameColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscCmpNameNull() =>
//            base.IsNull(this.tableFactoryPurchase_Report.cCmpNameColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscColourNull() =>
//            base.IsNull(this.tableFactoryPurchase_Report.cColourColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscCurTypeNull() =>
//            base.IsNull(this.tableFactoryPurchase_Report.cCurTypeColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscDeptnameNull() =>
//            base.IsNull(this.tableFactoryPurchase_Report.cDeptnameColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscDesNull() =>
//            base.IsNull(this.tableFactoryPurchase_Report.cDesColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscDimenNull() =>
//            base.IsNull(this.tableFactoryPurchase_Report.cDimenColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscSection_DescriptionNull() =>
//            base.IsNull(this.tableFactoryPurchase_Report.cSection_DescriptionColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscSize1Null() =>
//            base.IsNull(this.tableFactoryPurchase_Report.cSize1Column);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscStyleNoNull() =>
//            base.IsNull(this.tableFactoryPurchase_Report.cStyleNoColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscSupNameNull() =>
//            base.IsNull(this.tableFactoryPurchase_Report.cSupNameColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscUnitDesNull() =>
//            base.IsNull(this.tableFactoryPurchase_Report.cUnitDesColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscUserFullnameNull() =>
//            base.IsNull(this.tableFactoryPurchase_Report.cUserFullnameColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsdReqQtyNull() =>
//            base.IsNull(this.tableFactoryPurchase_Report.dReqQtyColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsdUnitPriceNull() =>
//            base.IsNull(this.tableFactoryPurchase_Report.dUnitPriceColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsdValueNull() =>
//            base.IsNull(this.tableFactoryPurchase_Report.dValueColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsPO_Approved_ByNull() =>
//            base.IsNull(this.tableFactoryPurchase_Report.PO_Approved_ByColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsPO_ApprovedNull() =>
//            base.IsNull(this.tableFactoryPurchase_Report.PO_ApprovedColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsPO_CancelNull() =>
//            base.IsNull(this.tableFactoryPurchase_Report.PO_CancelColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsPO_CreatedDateNull() =>
//            base.IsNull(this.tableFactoryPurchase_Report.PO_CreatedDateColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsPO_CreateNull() =>
//            base.IsNull(this.tableFactoryPurchase_Report.PO_CreateColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsPO_NoNull() =>
//            base.IsNull(this.tableFactoryPurchase_Report.PO_NoColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsRemarksNull() =>
//            base.IsNull(this.tableFactoryPurchase_Report.RemarksColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetApprovedByNull()
//        {
//            base[this.tableFactoryPurchase_Report.ApprovedByColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcArticleNull()
//        {
//            base[this.tableFactoryPurchase_Report.cArticleColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcBrand_NameNull()
//        {
//            base[this.tableFactoryPurchase_Report.cBrand_NameColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcCmpNameNull()
//        {
//            base[this.tableFactoryPurchase_Report.cCmpNameColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcColourNull()
//        {
//            base[this.tableFactoryPurchase_Report.cColourColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcCurTypeNull()
//        {
//            base[this.tableFactoryPurchase_Report.cCurTypeColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcDeptnameNull()
//        {
//            base[this.tableFactoryPurchase_Report.cDeptnameColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcDesNull()
//        {
//            base[this.tableFactoryPurchase_Report.cDesColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcDimenNull()
//        {
//            base[this.tableFactoryPurchase_Report.cDimenColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcSection_DescriptionNull()
//        {
//            base[this.tableFactoryPurchase_Report.cSection_DescriptionColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcSize1Null()
//        {
//            base[this.tableFactoryPurchase_Report.cSize1Column] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcStyleNoNull()
//        {
//            base[this.tableFactoryPurchase_Report.cStyleNoColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcSupNameNull()
//        {
//            base[this.tableFactoryPurchase_Report.cSupNameColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcUnitDesNull()
//        {
//            base[this.tableFactoryPurchase_Report.cUnitDesColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcUserFullnameNull()
//        {
//            base[this.tableFactoryPurchase_Report.cUserFullnameColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetdReqQtyNull()
//        {
//            base[this.tableFactoryPurchase_Report.dReqQtyColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetdUnitPriceNull()
//        {
//            base[this.tableFactoryPurchase_Report.dUnitPriceColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetdValueNull()
//        {
//            base[this.tableFactoryPurchase_Report.dValueColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetPO_Approved_ByNull()
//        {
//            base[this.tableFactoryPurchase_Report.PO_Approved_ByColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetPO_ApprovedNull()
//        {
//            base[this.tableFactoryPurchase_Report.PO_ApprovedColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetPO_CancelNull()
//        {
//            base[this.tableFactoryPurchase_Report.PO_CancelColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetPO_CreatedDateNull()
//        {
//            base[this.tableFactoryPurchase_Report.PO_CreatedDateColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetPO_CreateNull()
//        {
//            base[this.tableFactoryPurchase_Report.PO_CreateColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetPO_NoNull()
//        {
//            base[this.tableFactoryPurchase_Report.PO_NoColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetRemarksNull()
//        {
//            base[this.tableFactoryPurchase_Report.RemarksColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string ApprovedBy
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableFactoryPurchase_Report.ApprovedByColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'ApprovedBy' in table 'FactoryPurchase_Report' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableFactoryPurchase_Report.ApprovedByColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cArticle
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableFactoryPurchase_Report.cArticleColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cArticle' in table 'FactoryPurchase_Report' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableFactoryPurchase_Report.cArticleColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cBrand_Name
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableFactoryPurchase_Report.cBrand_NameColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cBrand_Name' in table 'FactoryPurchase_Report' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableFactoryPurchase_Report.cBrand_NameColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cCmpName
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableFactoryPurchase_Report.cCmpNameColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cCmpName' in table 'FactoryPurchase_Report' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableFactoryPurchase_Report.cCmpNameColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cColour
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableFactoryPurchase_Report.cColourColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cColour' in table 'FactoryPurchase_Report' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableFactoryPurchase_Report.cColourColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cCurType
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableFactoryPurchase_Report.cCurTypeColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cCurType' in table 'FactoryPurchase_Report' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableFactoryPurchase_Report.cCurTypeColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cDeptname
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableFactoryPurchase_Report.cDeptnameColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cDeptname' in table 'FactoryPurchase_Report' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableFactoryPurchase_Report.cDeptnameColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cDes
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableFactoryPurchase_Report.cDesColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cDes' in table 'FactoryPurchase_Report' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableFactoryPurchase_Report.cDesColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cDimen
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableFactoryPurchase_Report.cDimenColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cDimen' in table 'FactoryPurchase_Report' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableFactoryPurchase_Report.cDimenColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cSection_Description
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableFactoryPurchase_Report.cSection_DescriptionColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cSection_Description' in table 'FactoryPurchase_Report' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableFactoryPurchase_Report.cSection_DescriptionColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cSize1
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableFactoryPurchase_Report.cSize1Column];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cSize1' in table 'FactoryPurchase_Report' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableFactoryPurchase_Report.cSize1Column] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cStyleNo
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableFactoryPurchase_Report.cStyleNoColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cStyleNo' in table 'FactoryPurchase_Report' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableFactoryPurchase_Report.cStyleNoColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cSupName
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableFactoryPurchase_Report.cSupNameColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cSupName' in table 'FactoryPurchase_Report' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableFactoryPurchase_Report.cSupNameColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cUnitDes
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableFactoryPurchase_Report.cUnitDesColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cUnitDes' in table 'FactoryPurchase_Report' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableFactoryPurchase_Report.cUnitDesColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cUserFullname
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableFactoryPurchase_Report.cUserFullnameColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cUserFullname' in table 'FactoryPurchase_Report' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableFactoryPurchase_Report.cUserFullnameColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public decimal dReqQty
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableFactoryPurchase_Report.dReqQtyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'dReqQty' in table 'FactoryPurchase_Report' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableFactoryPurchase_Report.dReqQtyColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public decimal dUnitPrice
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableFactoryPurchase_Report.dUnitPriceColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'dUnitPrice' in table 'FactoryPurchase_Report' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableFactoryPurchase_Report.dUnitPriceColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public decimal dValue
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableFactoryPurchase_Report.dValueColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'dValue' in table 'FactoryPurchase_Report' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableFactoryPurchase_Report.dValueColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool PO_Approved
//        {
//            get
//            {
//                bool flag;
//                try
//                {
//                    flag = (bool)base[this.tableFactoryPurchase_Report.PO_ApprovedColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'PO_Approved' in table 'FactoryPurchase_Report' is DBNull.", exception);
//                }
//                return flag;
//            }
//            set
//            {
//                base[this.tableFactoryPurchase_Report.PO_ApprovedColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string PO_Approved_By
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableFactoryPurchase_Report.PO_Approved_ByColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'PO_Approved_By' in table 'FactoryPurchase_Report' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableFactoryPurchase_Report.PO_Approved_ByColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool PO_Cancel
//        {
//            get
//            {
//                bool flag;
//                try
//                {
//                    flag = (bool)base[this.tableFactoryPurchase_Report.PO_CancelColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'PO_Cancel' in table 'FactoryPurchase_Report' is DBNull.", exception);
//                }
//                return flag;
//            }
//            set
//            {
//                base[this.tableFactoryPurchase_Report.PO_CancelColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool PO_Create
//        {
//            get
//            {
//                bool flag;
//                try
//                {
//                    flag = (bool)base[this.tableFactoryPurchase_Report.PO_CreateColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'PO_Create' in table 'FactoryPurchase_Report' is DBNull.", exception);
//                }
//                return flag;
//            }
//            set
//            {
//                base[this.tableFactoryPurchase_Report.PO_CreateColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DateTime PO_CreatedDate
//        {
//            get
//            {
//                DateTime time;
//                try
//                {
//                    time = (DateTime)base[this.tableFactoryPurchase_Report.PO_CreatedDateColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'PO_CreatedDate' in table 'FactoryPurchase_Report' is DBNull.", exception);
//                }
//                return time;
//            }
//            set
//            {
//                base[this.tableFactoryPurchase_Report.PO_CreatedDateColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public int PO_No
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableFactoryPurchase_Report.PO_NoColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'PO_No' in table 'FactoryPurchase_Report' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableFactoryPurchase_Report.PO_NoColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string Remarks
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableFactoryPurchase_Report.RemarksColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'Remarks' in table 'FactoryPurchase_Report' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableFactoryPurchase_Report.RemarksColumn] = value;
//            }
//        }
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public class FactoryPurchase_ReportRowChangeEvent : EventArgs
//    {
//        private DataRowAction eventAction;
//        private Inventory.FactoryPurchase_ReportRow eventRow;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public FactoryPurchase_ReportRowChangeEvent(Inventory.FactoryPurchase_ReportRow row, DataRowAction action)
//        {
//            this.eventRow = row;
//            this.eventAction = action;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataRowAction Action =>
//            this.eventAction;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public Inventory.FactoryPurchase_ReportRow Row =>
//            this.eventRow;
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public delegate void FactoryPurchase_ReportRowChangeEventHandler(object sender, Inventory.FactoryPurchase_ReportRowChangeEvent e);

//    [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
//    public class FPPOREPORTDataTable : TypedTableBase<Inventory.FPPOREPORTRow>
//    {
//        private DataColumn columncArticle;
//        private DataColumn columncCmpName;
//        private DataColumn columncColour;
//        private DataColumn columncCurType;
//        private DataColumn columncDeptname;
//        private DataColumn columncDes;
//        private DataColumn columncDimen;
//        private DataColumn columncMainCategory;
//        private DataColumn columncSection_Description;
//        private DataColumn columncSize1;
//        private DataColumn columncSupName;
//        private DataColumn columndReqQty;
//        private DataColumn columndUnitPrice;
//        private DataColumn columndValue;
//        private DataColumn columnPO_Approve_Date;
//        private DataColumn columnPO_CreatedByremrk;
//        private DataColumn columnPO_CreatedDate;
//        private DataColumn columnPO_No;
//        private DataColumn columnpoapprovedby;
//        private DataColumn columnpocreatedby;
//        private DataColumn columnsupadd;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.FPPOREPORTRowChangeEventHandler FPPOREPORTRowChanged;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.FPPOREPORTRowChangeEventHandler FPPOREPORTRowChanging;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.FPPOREPORTRowChangeEventHandler FPPOREPORTRowDeleted;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.FPPOREPORTRowChangeEventHandler FPPOREPORTRowDeleting;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public FPPOREPORTDataTable()
//        {
//            base.TableName = "FPPOREPORT";
//            this.BeginInit();
//            this.InitClass();
//            this.EndInit();
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal FPPOREPORTDataTable(DataTable table)
//        {
//            base.TableName = table.TableName;
//            if (table.CaseSensitive != table.DataSet.CaseSensitive)
//            {
//                base.CaseSensitive = table.CaseSensitive;
//            }
//            if (table.Locale.ToString() != table.DataSet.Locale.ToString())
//            {
//                base.Locale = table.Locale;
//            }
//            if (table.Namespace != table.DataSet.Namespace)
//            {
//                base.Namespace = table.Namespace;
//            }
//            base.Prefix = table.Prefix;
//            base.MinimumCapacity = table.MinimumCapacity;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected FPPOREPORTDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
//        {
//            this.InitVars();
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void AddFPPOREPORTRow(Inventory.FPPOREPORTRow row)
//        {
//            base.Rows.Add(row);
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.FPPOREPORTRow AddFPPOREPORTRow(string cMainCategory, string cDes, string cColour, string cArticle, string cDimen, string cSize1, decimal dReqQty, decimal dUnitPrice, decimal dValue, string cCmpName, string cDeptname, string cSection_Description, string cSupName, string supadd, string pocreatedby, DateTime PO_CreatedDate, string poapprovedby, DateTime PO_Approve_Date, int PO_No, string PO_CreatedByremrk, string cCurType)
//        {
//            Inventory.FPPOREPORTRow row = (Inventory.FPPOREPORTRow)base.NewRow();
//            row.ItemArray = new object[] {
//                cMainCategory, cDes, cColour, cArticle, cDimen, cSize1, dReqQty, dUnitPrice, dValue, cCmpName, cDeptname, cSection_Description, cSupName, supadd, pocreatedby, PO_CreatedDate,
//                poapprovedby, PO_Approve_Date, PO_No, PO_CreatedByremrk, cCurType
//            };
//            base.Rows.Add(row);
//            return row;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public override DataTable Clone()
//        {
//            Inventory.FPPOREPORTDataTable table = (Inventory.FPPOREPORTDataTable)base.Clone();
//            table.InitVars();
//            return table;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override DataTable CreateInstance() =>
//            new Inventory.FPPOREPORTDataTable();

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override Type GetRowType() =>
//            typeof(Inventory.FPPOREPORTRow);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
//        {
//            XmlSchemaComplexType type = new XmlSchemaComplexType();
//            XmlSchemaSequence sequence = new XmlSchemaSequence();
//            Inventory inventory = new Inventory();
//            XmlSchemaAny item = new XmlSchemaAny
//            {
//                Namespace = "http://www.w3.org/2001/XMLSchema",
//                MinOccurs = 0M,
//                MaxOccurs = 79228162514264337593543950335M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(item);
//            XmlSchemaAny any2 = new XmlSchemaAny
//            {
//                Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
//                MinOccurs = 1M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(any2);
//            XmlSchemaAttribute attribute = new XmlSchemaAttribute
//            {
//                Name = "namespace",
//                FixedValue = inventory.Namespace
//            };
//            type.Attributes.Add(attribute);
//            XmlSchemaAttribute attribute2 = new XmlSchemaAttribute
//            {
//                Name = "tableTypeName",
//                FixedValue = "FPPOREPORTDataTable"
//            };
//            type.Attributes.Add(attribute2);
//            type.Particle = sequence;
//            XmlSchema schemaSerializable = inventory.GetSchemaSerializable();
//            if (xs.Contains(schemaSerializable.TargetNamespace))
//            {
//                MemoryStream stream = new MemoryStream();
//                MemoryStream stream2 = new MemoryStream();
//                try
//                {
//                    XmlSchema current = null;
//                    schemaSerializable.Write(stream);
//                    IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
//                    while (enumerator.MoveNext())
//                    {
//                        current = (XmlSchema)enumerator.Current;
//                        stream2.SetLength(0L);
//                        current.Write(stream2);
//                        if (stream.Length == stream2.Length)
//                        {
//                            stream.Position = 0L;
//                            stream2.Position = 0L;
//                            while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
//                            {
//                            }
//                            if (stream.Position == stream.Length)
//                            {
//                                return type;
//                            }
//                        }
//                    }
//                }
//                finally
//                {
//                    if (stream != null)
//                    {
//                        stream.Close();
//                    }
//                    if (stream2 != null)
//                    {
//                        stream2.Close();
//                    }
//                }
//            }
//            xs.Add(schemaSerializable);
//            return type;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        private void InitClass()
//        {
//            this.columncMainCategory = new DataColumn("cMainCategory", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncMainCategory);
//            this.columncDes = new DataColumn("cDes", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncDes);
//            this.columncColour = new DataColumn("cColour", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncColour);
//            this.columncArticle = new DataColumn("cArticle", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncArticle);
//            this.columncDimen = new DataColumn("cDimen", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncDimen);
//            this.columncSize1 = new DataColumn("cSize1", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncSize1);
//            this.columndReqQty = new DataColumn("dReqQty", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columndReqQty);
//            this.columndUnitPrice = new DataColumn("dUnitPrice", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columndUnitPrice);
//            this.columndValue = new DataColumn("dValue", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columndValue);
//            this.columncCmpName = new DataColumn("cCmpName", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncCmpName);
//            this.columncDeptname = new DataColumn("cDeptname", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncDeptname);
//            this.columncSection_Description = new DataColumn("cSection_Description", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncSection_Description);
//            this.columncSupName = new DataColumn("cSupName", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncSupName);
//            this.columnsupadd = new DataColumn("supadd", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columnsupadd);
//            this.columnpocreatedby = new DataColumn("pocreatedby", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columnpocreatedby);
//            this.columnPO_CreatedDate = new DataColumn("PO_CreatedDate", typeof(DateTime), null, MappingType.Element);
//            base.Columns.Add(this.columnPO_CreatedDate);
//            this.columnpoapprovedby = new DataColumn("poapprovedby", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columnpoapprovedby);
//            this.columnPO_Approve_Date = new DataColumn("PO_Approve_Date", typeof(DateTime), null, MappingType.Element);
//            base.Columns.Add(this.columnPO_Approve_Date);
//            this.columnPO_No = new DataColumn("PO_No", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnPO_No);
//            this.columnPO_CreatedByremrk = new DataColumn("PO_CreatedByremrk", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columnPO_CreatedByremrk);
//            this.columncCurType = new DataColumn("cCurType", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncCurType);
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal void InitVars()
//        {
//            this.columncMainCategory = base.Columns["cMainCategory"];
//            this.columncDes = base.Columns["cDes"];
//            this.columncColour = base.Columns["cColour"];
//            this.columncArticle = base.Columns["cArticle"];
//            this.columncDimen = base.Columns["cDimen"];
//            this.columncSize1 = base.Columns["cSize1"];
//            this.columndReqQty = base.Columns["dReqQty"];
//            this.columndUnitPrice = base.Columns["dUnitPrice"];
//            this.columndValue = base.Columns["dValue"];
//            this.columncCmpName = base.Columns["cCmpName"];
//            this.columncDeptname = base.Columns["cDeptname"];
//            this.columncSection_Description = base.Columns["cSection_Description"];
//            this.columncSupName = base.Columns["cSupName"];
//            this.columnsupadd = base.Columns["supadd"];
//            this.columnpocreatedby = base.Columns["pocreatedby"];
//            this.columnPO_CreatedDate = base.Columns["PO_CreatedDate"];
//            this.columnpoapprovedby = base.Columns["poapprovedby"];
//            this.columnPO_Approve_Date = base.Columns["PO_Approve_Date"];
//            this.columnPO_No = base.Columns["PO_No"];
//            this.columnPO_CreatedByremrk = base.Columns["PO_CreatedByremrk"];
//            this.columncCurType = base.Columns["cCurType"];
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.FPPOREPORTRow NewFPPOREPORTRow() =>
//            ((Inventory.FPPOREPORTRow)base.NewRow());

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) =>
//            new Inventory.FPPOREPORTRow(builder);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowChanged(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanged(e);
//            if (this.FPPOREPORTRowChanged != null)
//            {
//                this.FPPOREPORTRowChanged(this, new Inventory.FPPOREPORTRowChangeEvent((Inventory.FPPOREPORTRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowChanging(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanging(e);
//            if (this.FPPOREPORTRowChanging != null)
//            {
//                this.FPPOREPORTRowChanging(this, new Inventory.FPPOREPORTRowChangeEvent((Inventory.FPPOREPORTRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowDeleted(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleted(e);
//            if (this.FPPOREPORTRowDeleted != null)
//            {
//                this.FPPOREPORTRowDeleted(this, new Inventory.FPPOREPORTRowChangeEvent((Inventory.FPPOREPORTRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowDeleting(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleting(e);
//            if (this.FPPOREPORTRowDeleting != null)
//            {
//                this.FPPOREPORTRowDeleting(this, new Inventory.FPPOREPORTRowChangeEvent((Inventory.FPPOREPORTRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void RemoveFPPOREPORTRow(Inventory.FPPOREPORTRow row)
//        {
//            base.Rows.Remove(row);
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cArticleColumn =>
//            this.columncArticle;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cCmpNameColumn =>
//            this.columncCmpName;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cColourColumn =>
//            this.columncColour;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cCurTypeColumn =>
//            this.columncCurType;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cDeptnameColumn =>
//            this.columncDeptname;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cDesColumn =>
//            this.columncDes;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cDimenColumn =>
//            this.columncDimen;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cMainCategoryColumn =>
//            this.columncMainCategory;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
//        public int Count =>
//            base.Rows.Count;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cSection_DescriptionColumn =>
//            this.columncSection_Description;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cSize1Column =>
//            this.columncSize1;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cSupNameColumn =>
//            this.columncSupName;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn dReqQtyColumn =>
//            this.columndReqQty;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn dUnitPriceColumn =>
//            this.columndUnitPrice;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn dValueColumn =>
//            this.columndValue;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.FPPOREPORTRow this[int index] =>
//            ((Inventory.FPPOREPORTRow)base.Rows[index]);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn PO_Approve_DateColumn =>
//            this.columnPO_Approve_Date;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn PO_CreatedByremrkColumn =>
//            this.columnPO_CreatedByremrk;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn PO_CreatedDateColumn =>
//            this.columnPO_CreatedDate;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn PO_NoColumn =>
//            this.columnPO_No;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn poapprovedbyColumn =>
//            this.columnpoapprovedby;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn pocreatedbyColumn =>
//            this.columnpocreatedby;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn supaddColumn =>
//            this.columnsupadd;
//    }

//    public class FPPOREPORTRow : DataRow
//    {
//        private Inventory.FPPOREPORTDataTable tableFPPOREPORT;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal FPPOREPORTRow(DataRowBuilder rb) : base(rb)
//        {
//            this.tableFPPOREPORT = (Inventory.FPPOREPORTDataTable)base.Table;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscArticleNull() =>
//            base.IsNull(this.tableFPPOREPORT.cArticleColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscCmpNameNull() =>
//            base.IsNull(this.tableFPPOREPORT.cCmpNameColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscColourNull() =>
//            base.IsNull(this.tableFPPOREPORT.cColourColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscCurTypeNull() =>
//            base.IsNull(this.tableFPPOREPORT.cCurTypeColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscDeptnameNull() =>
//            base.IsNull(this.tableFPPOREPORT.cDeptnameColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscDesNull() =>
//            base.IsNull(this.tableFPPOREPORT.cDesColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscDimenNull() =>
//            base.IsNull(this.tableFPPOREPORT.cDimenColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscMainCategoryNull() =>
//            base.IsNull(this.tableFPPOREPORT.cMainCategoryColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscSection_DescriptionNull() =>
//            base.IsNull(this.tableFPPOREPORT.cSection_DescriptionColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscSize1Null() =>
//            base.IsNull(this.tableFPPOREPORT.cSize1Column);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscSupNameNull() =>
//            base.IsNull(this.tableFPPOREPORT.cSupNameColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsdReqQtyNull() =>
//            base.IsNull(this.tableFPPOREPORT.dReqQtyColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsdUnitPriceNull() =>
//            base.IsNull(this.tableFPPOREPORT.dUnitPriceColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsdValueNull() =>
//            base.IsNull(this.tableFPPOREPORT.dValueColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsPO_Approve_DateNull() =>
//            base.IsNull(this.tableFPPOREPORT.PO_Approve_DateColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsPO_CreatedByremrkNull() =>
//            base.IsNull(this.tableFPPOREPORT.PO_CreatedByremrkColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsPO_CreatedDateNull() =>
//            base.IsNull(this.tableFPPOREPORT.PO_CreatedDateColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsPO_NoNull() =>
//            base.IsNull(this.tableFPPOREPORT.PO_NoColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IspoapprovedbyNull() =>
//            base.IsNull(this.tableFPPOREPORT.poapprovedbyColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IspocreatedbyNull() =>
//            base.IsNull(this.tableFPPOREPORT.pocreatedbyColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IssupaddNull() =>
//            base.IsNull(this.tableFPPOREPORT.supaddColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcArticleNull()
//        {
//            base[this.tableFPPOREPORT.cArticleColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcCmpNameNull()
//        {
//            base[this.tableFPPOREPORT.cCmpNameColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcColourNull()
//        {
//            base[this.tableFPPOREPORT.cColourColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcCurTypeNull()
//        {
//            base[this.tableFPPOREPORT.cCurTypeColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcDeptnameNull()
//        {
//            base[this.tableFPPOREPORT.cDeptnameColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcDesNull()
//        {
//            base[this.tableFPPOREPORT.cDesColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcDimenNull()
//        {
//            base[this.tableFPPOREPORT.cDimenColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcMainCategoryNull()
//        {
//            base[this.tableFPPOREPORT.cMainCategoryColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcSection_DescriptionNull()
//        {
//            base[this.tableFPPOREPORT.cSection_DescriptionColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcSize1Null()
//        {
//            base[this.tableFPPOREPORT.cSize1Column] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcSupNameNull()
//        {
//            base[this.tableFPPOREPORT.cSupNameColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetdReqQtyNull()
//        {
//            base[this.tableFPPOREPORT.dReqQtyColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetdUnitPriceNull()
//        {
//            base[this.tableFPPOREPORT.dUnitPriceColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetdValueNull()
//        {
//            base[this.tableFPPOREPORT.dValueColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetPO_Approve_DateNull()
//        {
//            base[this.tableFPPOREPORT.PO_Approve_DateColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetPO_CreatedByremrkNull()
//        {
//            base[this.tableFPPOREPORT.PO_CreatedByremrkColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetPO_CreatedDateNull()
//        {
//            base[this.tableFPPOREPORT.PO_CreatedDateColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetPO_NoNull()
//        {
//            base[this.tableFPPOREPORT.PO_NoColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetpoapprovedbyNull()
//        {
//            base[this.tableFPPOREPORT.poapprovedbyColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetpocreatedbyNull()
//        {
//            base[this.tableFPPOREPORT.pocreatedbyColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetsupaddNull()
//        {
//            base[this.tableFPPOREPORT.supaddColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cArticle
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableFPPOREPORT.cArticleColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cArticle' in table 'FPPOREPORT' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableFPPOREPORT.cArticleColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cCmpName
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableFPPOREPORT.cCmpNameColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cCmpName' in table 'FPPOREPORT' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableFPPOREPORT.cCmpNameColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cColour
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableFPPOREPORT.cColourColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cColour' in table 'FPPOREPORT' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableFPPOREPORT.cColourColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cCurType
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableFPPOREPORT.cCurTypeColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cCurType' in table 'FPPOREPORT' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableFPPOREPORT.cCurTypeColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cDeptname
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableFPPOREPORT.cDeptnameColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cDeptname' in table 'FPPOREPORT' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableFPPOREPORT.cDeptnameColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cDes
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableFPPOREPORT.cDesColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cDes' in table 'FPPOREPORT' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableFPPOREPORT.cDesColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cDimen
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableFPPOREPORT.cDimenColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cDimen' in table 'FPPOREPORT' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableFPPOREPORT.cDimenColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cMainCategory
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableFPPOREPORT.cMainCategoryColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cMainCategory' in table 'FPPOREPORT' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableFPPOREPORT.cMainCategoryColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cSection_Description
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableFPPOREPORT.cSection_DescriptionColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cSection_Description' in table 'FPPOREPORT' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableFPPOREPORT.cSection_DescriptionColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cSize1
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableFPPOREPORT.cSize1Column];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cSize1' in table 'FPPOREPORT' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableFPPOREPORT.cSize1Column] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cSupName
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableFPPOREPORT.cSupNameColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cSupName' in table 'FPPOREPORT' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableFPPOREPORT.cSupNameColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public decimal dReqQty
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableFPPOREPORT.dReqQtyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'dReqQty' in table 'FPPOREPORT' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableFPPOREPORT.dReqQtyColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public decimal dUnitPrice
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableFPPOREPORT.dUnitPriceColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'dUnitPrice' in table 'FPPOREPORT' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableFPPOREPORT.dUnitPriceColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public decimal dValue
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableFPPOREPORT.dValueColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'dValue' in table 'FPPOREPORT' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableFPPOREPORT.dValueColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DateTime PO_Approve_Date
//        {
//            get
//            {
//                DateTime time;
//                try
//                {
//                    time = (DateTime)base[this.tableFPPOREPORT.PO_Approve_DateColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'PO_Approve_Date' in table 'FPPOREPORT' is DBNull.", exception);
//                }
//                return time;
//            }
//            set
//            {
//                base[this.tableFPPOREPORT.PO_Approve_DateColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string PO_CreatedByremrk
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableFPPOREPORT.PO_CreatedByremrkColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'PO_CreatedByremrk' in table 'FPPOREPORT' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableFPPOREPORT.PO_CreatedByremrkColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DateTime PO_CreatedDate
//        {
//            get
//            {
//                DateTime time;
//                try
//                {
//                    time = (DateTime)base[this.tableFPPOREPORT.PO_CreatedDateColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'PO_CreatedDate' in table 'FPPOREPORT' is DBNull.", exception);
//                }
//                return time;
//            }
//            set
//            {
//                base[this.tableFPPOREPORT.PO_CreatedDateColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public int PO_No
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableFPPOREPORT.PO_NoColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'PO_No' in table 'FPPOREPORT' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableFPPOREPORT.PO_NoColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string poapprovedby
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableFPPOREPORT.poapprovedbyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'poapprovedby' in table 'FPPOREPORT' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableFPPOREPORT.poapprovedbyColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string pocreatedby
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableFPPOREPORT.pocreatedbyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'pocreatedby' in table 'FPPOREPORT' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableFPPOREPORT.pocreatedbyColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string supadd
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableFPPOREPORT.supaddColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'supadd' in table 'FPPOREPORT' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableFPPOREPORT.supaddColumn] = value;
//            }
//        }
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public class FPPOREPORTRowChangeEvent : EventArgs
//    {
//        private DataRowAction eventAction;
//        private Inventory.FPPOREPORTRow eventRow;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public FPPOREPORTRowChangeEvent(Inventory.FPPOREPORTRow row, DataRowAction action)
//        {
//            this.eventRow = row;
//            this.eventAction = action;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataRowAction Action =>
//            this.eventAction;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.FPPOREPORTRow Row =>
//            this.eventRow;
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public delegate void FPPOREPORTRowChangeEventHandler(object sender, Inventory.FPPOREPORTRowChangeEvent e);

//    [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
//    public class GoodsIssueDataTable : TypedTableBase<Inventory.GoodsIssueRow>
//    {
//        private DataColumn columncArticle;
//        private DataColumn columncBrand_Name;
//        private DataColumn columncBuyer_Name;
//        private DataColumn columncColour;
//        private DataColumn columncDimen;
//        private DataColumn columncItemDes;
//        private DataColumn columncSize1;
//        private DataColumn columncStyleNo;
//        private DataColumn columncUnit;
//        private DataColumn columndEntDAte;
//        private DataColumn columnnIssQty;
//        private DataColumn columnnItemBalQty;
//        private DataColumn columnRemarks;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.GoodsIssueRowChangeEventHandler GoodsIssueRowChanged;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.GoodsIssueRowChangeEventHandler GoodsIssueRowChanging;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.GoodsIssueRowChangeEventHandler GoodsIssueRowDeleted;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.GoodsIssueRowChangeEventHandler GoodsIssueRowDeleting;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public GoodsIssueDataTable()
//        {
//            base.TableName = "GoodsIssue";
//            this.BeginInit();
//            this.InitClass();
//            this.EndInit();
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal GoodsIssueDataTable(DataTable table)
//        {
//            base.TableName = table.TableName;
//            if (table.CaseSensitive != table.DataSet.CaseSensitive)
//            {
//                base.CaseSensitive = table.CaseSensitive;
//            }
//            if (table.Locale.ToString() != table.DataSet.Locale.ToString())
//            {
//                base.Locale = table.Locale;
//            }
//            if (table.Namespace != table.DataSet.Namespace)
//            {
//                base.Namespace = table.Namespace;
//            }
//            base.Prefix = table.Prefix;
//            base.MinimumCapacity = table.MinimumCapacity;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected GoodsIssueDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
//        {
//            this.InitVars();
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void AddGoodsIssueRow(Inventory.GoodsIssueRow row)
//        {
//            base.Rows.Add(row);
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.GoodsIssueRow AddGoodsIssueRow(decimal nIssQty, string cItemDes, string cSize1, string cColour, string cArticle, string cDimen, string cUnit, decimal nItemBalQty, string cBrand_Name, string Remarks, DateTime dEntDAte, string cBuyer_Name, string cStyleNo)
//        {
//            Inventory.GoodsIssueRow row = (Inventory.GoodsIssueRow)base.NewRow();
//            row.ItemArray = new object[] { nIssQty, cItemDes, cSize1, cColour, cArticle, cDimen, cUnit, nItemBalQty, cBrand_Name, Remarks, dEntDAte, cBuyer_Name, cStyleNo };
//            base.Rows.Add(row);
//            return row;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public override DataTable Clone()
//        {
//            Inventory.GoodsIssueDataTable table = (Inventory.GoodsIssueDataTable)base.Clone();
//            table.InitVars();
//            return table;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override DataTable CreateInstance() =>
//            new Inventory.GoodsIssueDataTable();

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override Type GetRowType() =>
//            typeof(Inventory.GoodsIssueRow);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
//        {
//            XmlSchemaComplexType type = new XmlSchemaComplexType();
//            XmlSchemaSequence sequence = new XmlSchemaSequence();
//            Inventory inventory = new Inventory();
//            XmlSchemaAny item = new XmlSchemaAny
//            {
//                Namespace = "http://www.w3.org/2001/XMLSchema",
//                MinOccurs = 0M,
//                MaxOccurs = 79228162514264337593543950335M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(item);
//            XmlSchemaAny any2 = new XmlSchemaAny
//            {
//                Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
//                MinOccurs = 1M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(any2);
//            XmlSchemaAttribute attribute = new XmlSchemaAttribute
//            {
//                Name = "namespace",
//                FixedValue = inventory.Namespace
//            };
//            type.Attributes.Add(attribute);
//            XmlSchemaAttribute attribute2 = new XmlSchemaAttribute
//            {
//                Name = "tableTypeName",
//                FixedValue = "GoodsIssueDataTable"
//            };
//            type.Attributes.Add(attribute2);
//            type.Particle = sequence;
//            XmlSchema schemaSerializable = inventory.GetSchemaSerializable();
//            if (xs.Contains(schemaSerializable.TargetNamespace))
//            {
//                MemoryStream stream = new MemoryStream();
//                MemoryStream stream2 = new MemoryStream();
//                try
//                {
//                    XmlSchema current = null;
//                    schemaSerializable.Write(stream);
//                    IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
//                    while (enumerator.MoveNext())
//                    {
//                        current = (XmlSchema)enumerator.Current;
//                        stream2.SetLength(0L);
//                        current.Write(stream2);
//                        if (stream.Length == stream2.Length)
//                        {
//                            stream.Position = 0L;
//                            stream2.Position = 0L;
//                            while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
//                            {
//                            }
//                            if (stream.Position == stream.Length)
//                            {
//                                return type;
//                            }
//                        }
//                    }
//                }
//                finally
//                {
//                    if (stream != null)
//                    {
//                        stream.Close();
//                    }
//                    if (stream2 != null)
//                    {
//                        stream2.Close();
//                    }
//                }
//            }
//            xs.Add(schemaSerializable);
//            return type;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        private void InitClass()
//        {
//            this.columnnIssQty = new DataColumn("nIssQty", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnnIssQty);
//            this.columncItemDes = new DataColumn("cItemDes", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncItemDes);
//            this.columncSize1 = new DataColumn("cSize1", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncSize1);
//            this.columncColour = new DataColumn("cColour", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncColour);
//            this.columncArticle = new DataColumn("cArticle", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncArticle);
//            this.columncDimen = new DataColumn("cDimen", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncDimen);
//            this.columncUnit = new DataColumn("cUnit", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncUnit);
//            this.columnnItemBalQty = new DataColumn("nItemBalQty", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnnItemBalQty);
//            this.columncBrand_Name = new DataColumn("cBrand_Name", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncBrand_Name);
//            this.columnRemarks = new DataColumn("Remarks", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columnRemarks);
//            this.columndEntDAte = new DataColumn("dEntDAte", typeof(DateTime), null, MappingType.Element);
//            base.Columns.Add(this.columndEntDAte);
//            this.columncBuyer_Name = new DataColumn("cBuyer_Name", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncBuyer_Name);
//            this.columncStyleNo = new DataColumn("cStyleNo", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncStyleNo);
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal void InitVars()
//        {
//            this.columnnIssQty = base.Columns["nIssQty"];
//            this.columncItemDes = base.Columns["cItemDes"];
//            this.columncSize1 = base.Columns["cSize1"];
//            this.columncColour = base.Columns["cColour"];
//            this.columncArticle = base.Columns["cArticle"];
//            this.columncDimen = base.Columns["cDimen"];
//            this.columncUnit = base.Columns["cUnit"];
//            this.columnnItemBalQty = base.Columns["nItemBalQty"];
//            this.columncBrand_Name = base.Columns["cBrand_Name"];
//            this.columnRemarks = base.Columns["Remarks"];
//            this.columndEntDAte = base.Columns["dEntDAte"];
//            this.columncBuyer_Name = base.Columns["cBuyer_Name"];
//            this.columncStyleNo = base.Columns["cStyleNo"];
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.GoodsIssueRow NewGoodsIssueRow() =>
//            ((Inventory.GoodsIssueRow)base.NewRow());

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) =>
//            new Inventory.GoodsIssueRow(builder);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowChanged(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanged(e);
//            if (this.GoodsIssueRowChanged != null)
//            {
//                this.GoodsIssueRowChanged(this, new Inventory.GoodsIssueRowChangeEvent((Inventory.GoodsIssueRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowChanging(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanging(e);
//            if (this.GoodsIssueRowChanging != null)
//            {
//                this.GoodsIssueRowChanging(this, new Inventory.GoodsIssueRowChangeEvent((Inventory.GoodsIssueRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowDeleted(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleted(e);
//            if (this.GoodsIssueRowDeleted != null)
//            {
//                this.GoodsIssueRowDeleted(this, new Inventory.GoodsIssueRowChangeEvent((Inventory.GoodsIssueRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowDeleting(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleting(e);
//            if (this.GoodsIssueRowDeleting != null)
//            {
//                this.GoodsIssueRowDeleting(this, new Inventory.GoodsIssueRowChangeEvent((Inventory.GoodsIssueRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void RemoveGoodsIssueRow(Inventory.GoodsIssueRow row)
//        {
//            base.Rows.Remove(row);
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cArticleColumn =>
//            this.columncArticle;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cBrand_NameColumn =>
//            this.columncBrand_Name;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cBuyer_NameColumn =>
//            this.columncBuyer_Name;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cColourColumn =>
//            this.columncColour;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cDimenColumn =>
//            this.columncDimen;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cItemDesColumn =>
//            this.columncItemDes;

//        [Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public int Count =>
//            base.Rows.Count;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cSize1Column =>
//            this.columncSize1;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cStyleNoColumn =>
//            this.columncStyleNo;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cUnitColumn =>
//            this.columncUnit;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn dEntDAteColumn =>
//            this.columndEntDAte;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public Inventory.GoodsIssueRow this[int index] =>
//            ((Inventory.GoodsIssueRow)base.Rows[index]);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn nIssQtyColumn =>
//            this.columnnIssQty;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn nItemBalQtyColumn =>
//            this.columnnItemBalQty;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn RemarksColumn =>
//            this.columnRemarks;
//    }

//    public class GoodsIssueRow : DataRow
//    {
//        private Inventory.GoodsIssueDataTable tableGoodsIssue;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        internal GoodsIssueRow(DataRowBuilder rb) : base(rb)
//        {
//            this.tableGoodsIssue = (Inventory.GoodsIssueDataTable)base.Table;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscArticleNull() =>
//            base.IsNull(this.tableGoodsIssue.cArticleColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscBrand_NameNull() =>
//            base.IsNull(this.tableGoodsIssue.cBrand_NameColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscBuyer_NameNull() =>
//            base.IsNull(this.tableGoodsIssue.cBuyer_NameColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscColourNull() =>
//            base.IsNull(this.tableGoodsIssue.cColourColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscDimenNull() =>
//            base.IsNull(this.tableGoodsIssue.cDimenColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscItemDesNull() =>
//            base.IsNull(this.tableGoodsIssue.cItemDesColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscSize1Null() =>
//            base.IsNull(this.tableGoodsIssue.cSize1Column);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscStyleNoNull() =>
//            base.IsNull(this.tableGoodsIssue.cStyleNoColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscUnitNull() =>
//            base.IsNull(this.tableGoodsIssue.cUnitColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsdEntDAteNull() =>
//            base.IsNull(this.tableGoodsIssue.dEntDAteColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsnIssQtyNull() =>
//            base.IsNull(this.tableGoodsIssue.nIssQtyColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsnItemBalQtyNull() =>
//            base.IsNull(this.tableGoodsIssue.nItemBalQtyColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsRemarksNull() =>
//            base.IsNull(this.tableGoodsIssue.RemarksColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcArticleNull()
//        {
//            base[this.tableGoodsIssue.cArticleColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcBrand_NameNull()
//        {
//            base[this.tableGoodsIssue.cBrand_NameColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcBuyer_NameNull()
//        {
//            base[this.tableGoodsIssue.cBuyer_NameColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcColourNull()
//        {
//            base[this.tableGoodsIssue.cColourColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcDimenNull()
//        {
//            base[this.tableGoodsIssue.cDimenColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcItemDesNull()
//        {
//            base[this.tableGoodsIssue.cItemDesColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcSize1Null()
//        {
//            base[this.tableGoodsIssue.cSize1Column] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcStyleNoNull()
//        {
//            base[this.tableGoodsIssue.cStyleNoColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcUnitNull()
//        {
//            base[this.tableGoodsIssue.cUnitColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetdEntDAteNull()
//        {
//            base[this.tableGoodsIssue.dEntDAteColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetnIssQtyNull()
//        {
//            base[this.tableGoodsIssue.nIssQtyColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnItemBalQtyNull()
//        {
//            base[this.tableGoodsIssue.nItemBalQtyColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetRemarksNull()
//        {
//            base[this.tableGoodsIssue.RemarksColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cArticle
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGoodsIssue.cArticleColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cArticle' in table 'GoodsIssue' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGoodsIssue.cArticleColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cBrand_Name
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGoodsIssue.cBrand_NameColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cBrand_Name' in table 'GoodsIssue' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGoodsIssue.cBrand_NameColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cBuyer_Name
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGoodsIssue.cBuyer_NameColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cBuyer_Name' in table 'GoodsIssue' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGoodsIssue.cBuyer_NameColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cColour
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGoodsIssue.cColourColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cColour' in table 'GoodsIssue' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGoodsIssue.cColourColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cDimen
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGoodsIssue.cDimenColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cDimen' in table 'GoodsIssue' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGoodsIssue.cDimenColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cItemDes
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGoodsIssue.cItemDesColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cItemDes' in table 'GoodsIssue' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGoodsIssue.cItemDesColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cSize1
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGoodsIssue.cSize1Column];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cSize1' in table 'GoodsIssue' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGoodsIssue.cSize1Column] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cStyleNo
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGoodsIssue.cStyleNoColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cStyleNo' in table 'GoodsIssue' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGoodsIssue.cStyleNoColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cUnit
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGoodsIssue.cUnitColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cUnit' in table 'GoodsIssue' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGoodsIssue.cUnitColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DateTime dEntDAte
//        {
//            get
//            {
//                DateTime time;
//                try
//                {
//                    time = (DateTime)base[this.tableGoodsIssue.dEntDAteColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'dEntDAte' in table 'GoodsIssue' is DBNull.", exception);
//                }
//                return time;
//            }
//            set
//            {
//                base[this.tableGoodsIssue.dEntDAteColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public decimal nIssQty
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableGoodsIssue.nIssQtyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nIssQty' in table 'GoodsIssue' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableGoodsIssue.nIssQtyColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public decimal nItemBalQty
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableGoodsIssue.nItemBalQtyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nItemBalQty' in table 'GoodsIssue' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableGoodsIssue.nItemBalQtyColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string Remarks
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGoodsIssue.RemarksColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'Remarks' in table 'GoodsIssue' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGoodsIssue.RemarksColumn] = value;
//            }
//        }
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public class GoodsIssueRowChangeEvent : EventArgs
//    {
//        private DataRowAction eventAction;
//        private Inventory.GoodsIssueRow eventRow;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public GoodsIssueRowChangeEvent(Inventory.GoodsIssueRow row, DataRowAction action)
//        {
//            this.eventRow = row;
//            this.eventAction = action;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataRowAction Action =>
//            this.eventAction;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.GoodsIssueRow Row =>
//            this.eventRow;
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public delegate void GoodsIssueRowChangeEventHandler(object sender, Inventory.GoodsIssueRowChangeEvent e);

//    [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
//    public class GoodsReturnDataTable : TypedTableBase<Inventory.GoodsReturnRow>
//    {
//        private DataColumn columncArticle;
//        private DataColumn columncColour;
//        private DataColumn columncDimen;
//        private DataColumn columncItemDes;
//        private DataColumn columncMainCategory;
//        private DataColumn columncSize1;
//        private DataColumn columncUnitDes;
//        private DataColumn columndReturn_Qty;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.GoodsReturnRowChangeEventHandler GoodsReturnRowChanged;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.GoodsReturnRowChangeEventHandler GoodsReturnRowChanging;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.GoodsReturnRowChangeEventHandler GoodsReturnRowDeleted;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.GoodsReturnRowChangeEventHandler GoodsReturnRowDeleting;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public GoodsReturnDataTable()
//        {
//            base.TableName = "GoodsReturn";
//            this.BeginInit();
//            this.InitClass();
//            this.EndInit();
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        internal GoodsReturnDataTable(DataTable table)
//        {
//            base.TableName = table.TableName;
//            if (table.CaseSensitive != table.DataSet.CaseSensitive)
//            {
//                base.CaseSensitive = table.CaseSensitive;
//            }
//            if (table.Locale.ToString() != table.DataSet.Locale.ToString())
//            {
//                base.Locale = table.Locale;
//            }
//            if (table.Namespace != table.DataSet.Namespace)
//            {
//                base.Namespace = table.Namespace;
//            }
//            base.Prefix = table.Prefix;
//            base.MinimumCapacity = table.MinimumCapacity;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected GoodsReturnDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
//        {
//            this.InitVars();
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void AddGoodsReturnRow(Inventory.GoodsReturnRow row)
//        {
//            base.Rows.Add(row);
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.GoodsReturnRow AddGoodsReturnRow(string cMainCategory, string cItemDes, string cColour, string cSize1, string cArticle, string cDimen, string cUnitDes, decimal dReturn_Qty)
//        {
//            Inventory.GoodsReturnRow row = (Inventory.GoodsReturnRow)base.NewRow();
//            row.ItemArray = new object[] { cMainCategory, cItemDes, cColour, cSize1, cArticle, cDimen, cUnitDes, dReturn_Qty };
//            base.Rows.Add(row);
//            return row;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public override DataTable Clone()
//        {
//            Inventory.GoodsReturnDataTable table = (Inventory.GoodsReturnDataTable)base.Clone();
//            table.InitVars();
//            return table;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override DataTable CreateInstance() =>
//            new Inventory.GoodsReturnDataTable();

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override Type GetRowType() =>
//            typeof(Inventory.GoodsReturnRow);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
//        {
//            XmlSchemaComplexType type = new XmlSchemaComplexType();
//            XmlSchemaSequence sequence = new XmlSchemaSequence();
//            Inventory inventory = new Inventory();
//            XmlSchemaAny item = new XmlSchemaAny
//            {
//                Namespace = "http://www.w3.org/2001/XMLSchema",
//                MinOccurs = 0M,
//                MaxOccurs = 79228162514264337593543950335M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(item);
//            XmlSchemaAny any2 = new XmlSchemaAny
//            {
//                Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
//                MinOccurs = 1M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(any2);
//            XmlSchemaAttribute attribute = new XmlSchemaAttribute
//            {
//                Name = "namespace",
//                FixedValue = inventory.Namespace
//            };
//            type.Attributes.Add(attribute);
//            XmlSchemaAttribute attribute2 = new XmlSchemaAttribute
//            {
//                Name = "tableTypeName",
//                FixedValue = "GoodsReturnDataTable"
//            };
//            type.Attributes.Add(attribute2);
//            type.Particle = sequence;
//            XmlSchema schemaSerializable = inventory.GetSchemaSerializable();
//            if (xs.Contains(schemaSerializable.TargetNamespace))
//            {
//                MemoryStream stream = new MemoryStream();
//                MemoryStream stream2 = new MemoryStream();
//                try
//                {
//                    XmlSchema current = null;
//                    schemaSerializable.Write(stream);
//                    IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
//                    while (enumerator.MoveNext())
//                    {
//                        current = (XmlSchema)enumerator.Current;
//                        stream2.SetLength(0L);
//                        current.Write(stream2);
//                        if (stream.Length == stream2.Length)
//                        {
//                            stream.Position = 0L;
//                            stream2.Position = 0L;
//                            while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
//                            {
//                            }
//                            if (stream.Position == stream.Length)
//                            {
//                                return type;
//                            }
//                        }
//                    }
//                }
//                finally
//                {
//                    if (stream != null)
//                    {
//                        stream.Close();
//                    }
//                    if (stream2 != null)
//                    {
//                        stream2.Close();
//                    }
//                }
//            }
//            xs.Add(schemaSerializable);
//            return type;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        private void InitClass()
//        {
//            this.columncMainCategory = new DataColumn("cMainCategory", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncMainCategory);
//            this.columncItemDes = new DataColumn("cItemDes", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncItemDes);
//            this.columncColour = new DataColumn("cColour", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncColour);
//            this.columncSize1 = new DataColumn("cSize1", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncSize1);
//            this.columncArticle = new DataColumn("cArticle", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncArticle);
//            this.columncDimen = new DataColumn("cDimen", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncDimen);
//            this.columncUnitDes = new DataColumn("cUnitDes", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncUnitDes);
//            this.columndReturn_Qty = new DataColumn("dReturn_Qty", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columndReturn_Qty);
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal void InitVars()
//        {
//            this.columncMainCategory = base.Columns["cMainCategory"];
//            this.columncItemDes = base.Columns["cItemDes"];
//            this.columncColour = base.Columns["cColour"];
//            this.columncSize1 = base.Columns["cSize1"];
//            this.columncArticle = base.Columns["cArticle"];
//            this.columncDimen = base.Columns["cDimen"];
//            this.columncUnitDes = base.Columns["cUnitDes"];
//            this.columndReturn_Qty = base.Columns["dReturn_Qty"];
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public Inventory.GoodsReturnRow NewGoodsReturnRow() =>
//            ((Inventory.GoodsReturnRow)base.NewRow());

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) =>
//            new Inventory.GoodsReturnRow(builder);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowChanged(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanged(e);
//            if (this.GoodsReturnRowChanged != null)
//            {
//                this.GoodsReturnRowChanged(this, new Inventory.GoodsReturnRowChangeEvent((Inventory.GoodsReturnRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowChanging(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanging(e);
//            if (this.GoodsReturnRowChanging != null)
//            {
//                this.GoodsReturnRowChanging(this, new Inventory.GoodsReturnRowChangeEvent((Inventory.GoodsReturnRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowDeleted(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleted(e);
//            if (this.GoodsReturnRowDeleted != null)
//            {
//                this.GoodsReturnRowDeleted(this, new Inventory.GoodsReturnRowChangeEvent((Inventory.GoodsReturnRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowDeleting(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleting(e);
//            if (this.GoodsReturnRowDeleting != null)
//            {
//                this.GoodsReturnRowDeleting(this, new Inventory.GoodsReturnRowChangeEvent((Inventory.GoodsReturnRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void RemoveGoodsReturnRow(Inventory.GoodsReturnRow row)
//        {
//            base.Rows.Remove(row);
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cArticleColumn =>
//            this.columncArticle;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cColourColumn =>
//            this.columncColour;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cDimenColumn =>
//            this.columncDimen;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cItemDesColumn =>
//            this.columncItemDes;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cMainCategoryColumn =>
//            this.columncMainCategory;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode]
//        public int Count =>
//            base.Rows.Count;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cSize1Column =>
//            this.columncSize1;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cUnitDesColumn =>
//            this.columncUnitDes;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn dReturn_QtyColumn =>
//            this.columndReturn_Qty;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.GoodsReturnRow this[int index] =>
//            ((Inventory.GoodsReturnRow)base.Rows[index]);
//    }

//    public class GoodsReturnRow : DataRow
//    {
//        private Inventory.GoodsReturnDataTable tableGoodsReturn;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        internal GoodsReturnRow(DataRowBuilder rb) : base(rb)
//        {
//            this.tableGoodsReturn = (Inventory.GoodsReturnDataTable)base.Table;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscArticleNull() =>
//            base.IsNull(this.tableGoodsReturn.cArticleColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscColourNull() =>
//            base.IsNull(this.tableGoodsReturn.cColourColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscDimenNull() =>
//            base.IsNull(this.tableGoodsReturn.cDimenColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscItemDesNull() =>
//            base.IsNull(this.tableGoodsReturn.cItemDesColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscMainCategoryNull() =>
//            base.IsNull(this.tableGoodsReturn.cMainCategoryColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscSize1Null() =>
//            base.IsNull(this.tableGoodsReturn.cSize1Column);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscUnitDesNull() =>
//            base.IsNull(this.tableGoodsReturn.cUnitDesColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsdReturn_QtyNull() =>
//            base.IsNull(this.tableGoodsReturn.dReturn_QtyColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcArticleNull()
//        {
//            base[this.tableGoodsReturn.cArticleColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcColourNull()
//        {
//            base[this.tableGoodsReturn.cColourColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcDimenNull()
//        {
//            base[this.tableGoodsReturn.cDimenColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcItemDesNull()
//        {
//            base[this.tableGoodsReturn.cItemDesColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcMainCategoryNull()
//        {
//            base[this.tableGoodsReturn.cMainCategoryColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcSize1Null()
//        {
//            base[this.tableGoodsReturn.cSize1Column] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcUnitDesNull()
//        {
//            base[this.tableGoodsReturn.cUnitDesColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetdReturn_QtyNull()
//        {
//            base[this.tableGoodsReturn.dReturn_QtyColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cArticle
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGoodsReturn.cArticleColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cArticle' in table 'GoodsReturn' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGoodsReturn.cArticleColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cColour
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGoodsReturn.cColourColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cColour' in table 'GoodsReturn' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGoodsReturn.cColourColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cDimen
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGoodsReturn.cDimenColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cDimen' in table 'GoodsReturn' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGoodsReturn.cDimenColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cItemDes
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGoodsReturn.cItemDesColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cItemDes' in table 'GoodsReturn' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGoodsReturn.cItemDesColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cMainCategory
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGoodsReturn.cMainCategoryColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cMainCategory' in table 'GoodsReturn' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGoodsReturn.cMainCategoryColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cSize1
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGoodsReturn.cSize1Column];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cSize1' in table 'GoodsReturn' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGoodsReturn.cSize1Column] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cUnitDes
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGoodsReturn.cUnitDesColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cUnitDes' in table 'GoodsReturn' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGoodsReturn.cUnitDesColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public decimal dReturn_Qty
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableGoodsReturn.dReturn_QtyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'dReturn_Qty' in table 'GoodsReturn' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableGoodsReturn.dReturn_QtyColumn] = value;
//            }
//        }
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public class GoodsReturnRowChangeEvent : EventArgs
//    {
//        private DataRowAction eventAction;
//        private Inventory.GoodsReturnRow eventRow;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public GoodsReturnRowChangeEvent(Inventory.GoodsReturnRow row, DataRowAction action)
//        {
//            this.eventRow = row;
//            this.eventAction = action;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataRowAction Action =>
//            this.eventAction;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public Inventory.GoodsReturnRow Row =>
//            this.eventRow;
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public delegate void GoodsReturnRowChangeEventHandler(object sender, Inventory.GoodsReturnRowChangeEvent e);

//    [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
//    public class GRN_ReportDataTable : TypedTableBase<Inventory.GRN_ReportRow>
//    {
//        private DataColumn columnApprovedBy;
//        private DataColumn columnbApp;
//        private DataColumn columncAppBy;
//        private DataColumn columncArt;
//        private DataColumn columncBrand_Name;
//        private DataColumn columncCmpName;
//        private DataColumn columncColour;
//        private DataColumn columncDimec;
//        private DataColumn columncInVoice;
//        private DataColumn columncItemDec;
//        private DataColumn columncSize;
//        private DataColumn columncStyleNo;
//        private DataColumn columncSupName;
//        private DataColumn columncUnit;
//        private DataColumn columncUserFullname;
//        private DataColumn columndEntDate;
//        private DataColumn columnGrnRevise;
//        private DataColumn columnIsCanceled;
//        private DataColumn columnLOtNO;
//        private DataColumn columnNewSupplier;
//        private DataColumn columnnFOC;
//        private DataColumn columnnGrnNo;
//        private DataColumn columnnPoNum;
//        private DataColumn columnnPrice;
//        private DataColumn columnnQty;
//        private DataColumn columnnValue;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.GRN_ReportRowChangeEventHandler GRN_ReportRowChanged;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.GRN_ReportRowChangeEventHandler GRN_ReportRowChanging;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.GRN_ReportRowChangeEventHandler GRN_ReportRowDeleted;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.GRN_ReportRowChangeEventHandler GRN_ReportRowDeleting;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public GRN_ReportDataTable()
//        {
//            base.TableName = "GRN_Report";
//            this.BeginInit();
//            this.InitClass();
//            this.EndInit();
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal GRN_ReportDataTable(DataTable table)
//        {
//            base.TableName = table.TableName;
//            if (table.CaseSensitive != table.DataSet.CaseSensitive)
//            {
//                base.CaseSensitive = table.CaseSensitive;
//            }
//            if (table.Locale.ToString() != table.DataSet.Locale.ToString())
//            {
//                base.Locale = table.Locale;
//            }
//            if (table.Namespace != table.DataSet.Namespace)
//            {
//                base.Namespace = table.Namespace;
//            }
//            base.Prefix = table.Prefix;
//            base.MinimumCapacity = table.MinimumCapacity;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected GRN_ReportDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
//        {
//            this.InitVars();
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void AddGRN_ReportRow(Inventory.GRN_ReportRow row)
//        {
//            base.Rows.Add(row);
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public Inventory.GRN_ReportRow AddGRN_ReportRow(string cItemDec, string cSize, string cColour, string cArt, string cDimec, string cUnit, decimal nQty, decimal nFOC, decimal nPrice, decimal nValue, string cStyleNo, int nGrnNo, int nPoNum, string cInVoice, DateTime dEntDate, string cSupName, string cUserFullname, string ApprovedBy, bool bApp, bool IsCanceled, string cCmpName, string cAppBy, string NewSupplier, bool GrnRevise, string cBrand_Name, string LOtNO)
//        {
//            Inventory.GRN_ReportRow row = (Inventory.GRN_ReportRow)base.NewRow();
//            row.ItemArray = new object[] {
//                cItemDec, cSize, cColour, cArt, cDimec, cUnit, nQty, nFOC, nPrice, nValue, cStyleNo, nGrnNo, nPoNum, cInVoice, dEntDate, cSupName,
//                cUserFullname, ApprovedBy, bApp, IsCanceled, cCmpName, cAppBy, NewSupplier, GrnRevise, cBrand_Name, LOtNO
//            };
//            base.Rows.Add(row);
//            return row;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public override DataTable Clone()
//        {
//            Inventory.GRN_ReportDataTable table = (Inventory.GRN_ReportDataTable)base.Clone();
//            table.InitVars();
//            return table;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override DataTable CreateInstance() =>
//            new Inventory.GRN_ReportDataTable();

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override Type GetRowType() =>
//            typeof(Inventory.GRN_ReportRow);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
//        {
//            XmlSchemaComplexType type = new XmlSchemaComplexType();
//            XmlSchemaSequence sequence = new XmlSchemaSequence();
//            Inventory inventory = new Inventory();
//            XmlSchemaAny item = new XmlSchemaAny
//            {
//                Namespace = "http://www.w3.org/2001/XMLSchema",
//                MinOccurs = 0M,
//                MaxOccurs = 79228162514264337593543950335M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(item);
//            XmlSchemaAny any2 = new XmlSchemaAny
//            {
//                Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
//                MinOccurs = 1M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(any2);
//            XmlSchemaAttribute attribute = new XmlSchemaAttribute
//            {
//                Name = "namespace",
//                FixedValue = inventory.Namespace
//            };
//            type.Attributes.Add(attribute);
//            XmlSchemaAttribute attribute2 = new XmlSchemaAttribute
//            {
//                Name = "tableTypeName",
//                FixedValue = "GRN_ReportDataTable"
//            };
//            type.Attributes.Add(attribute2);
//            type.Particle = sequence;
//            XmlSchema schemaSerializable = inventory.GetSchemaSerializable();
//            if (xs.Contains(schemaSerializable.TargetNamespace))
//            {
//                MemoryStream stream = new MemoryStream();
//                MemoryStream stream2 = new MemoryStream();
//                try
//                {
//                    XmlSchema current = null;
//                    schemaSerializable.Write(stream);
//                    IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
//                    while (enumerator.MoveNext())
//                    {
//                        current = (XmlSchema)enumerator.Current;
//                        stream2.SetLength(0L);
//                        current.Write(stream2);
//                        if (stream.Length == stream2.Length)
//                        {
//                            stream.Position = 0L;
//                            stream2.Position = 0L;
//                            while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
//                            {
//                            }
//                            if (stream.Position == stream.Length)
//                            {
//                                return type;
//                            }
//                        }
//                    }
//                }
//                finally
//                {
//                    if (stream != null)
//                    {
//                        stream.Close();
//                    }
//                    if (stream2 != null)
//                    {
//                        stream2.Close();
//                    }
//                }
//            }
//            xs.Add(schemaSerializable);
//            return type;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        private void InitClass()
//        {
//            this.columncItemDec = new DataColumn("cItemDec", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncItemDec);
//            this.columncSize = new DataColumn("cSize", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncSize);
//            this.columncColour = new DataColumn("cColour", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncColour);
//            this.columncArt = new DataColumn("cArt", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncArt);
//            this.columncDimec = new DataColumn("cDimec", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncDimec);
//            this.columncUnit = new DataColumn("cUnit", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncUnit);
//            this.columnnQty = new DataColumn("nQty", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnnQty);
//            this.columnnFOC = new DataColumn("nFOC", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnnFOC);
//            this.columnnPrice = new DataColumn("nPrice", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnnPrice);
//            this.columnnValue = new DataColumn("nValue", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnnValue);
//            this.columncStyleNo = new DataColumn("cStyleNo", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncStyleNo);
//            this.columnnGrnNo = new DataColumn("nGrnNo", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnnGrnNo);
//            this.columnnPoNum = new DataColumn("nPoNum", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnnPoNum);
//            this.columncInVoice = new DataColumn("cInVoice", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncInVoice);
//            this.columndEntDate = new DataColumn("dEntDate", typeof(DateTime), null, MappingType.Element);
//            base.Columns.Add(this.columndEntDate);
//            this.columncSupName = new DataColumn("cSupName", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncSupName);
//            this.columncUserFullname = new DataColumn("cUserFullname", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncUserFullname);
//            this.columnApprovedBy = new DataColumn("ApprovedBy", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columnApprovedBy);
//            this.columnbApp = new DataColumn("bApp", typeof(bool), null, MappingType.Element);
//            base.Columns.Add(this.columnbApp);
//            this.columnIsCanceled = new DataColumn("IsCanceled", typeof(bool), null, MappingType.Element);
//            base.Columns.Add(this.columnIsCanceled);
//            this.columncCmpName = new DataColumn("cCmpName", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncCmpName);
//            this.columncAppBy = new DataColumn("cAppBy", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncAppBy);
//            this.columnNewSupplier = new DataColumn("NewSupplier", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columnNewSupplier);
//            this.columnGrnRevise = new DataColumn("GrnRevise", typeof(bool), null, MappingType.Element);
//            base.Columns.Add(this.columnGrnRevise);
//            this.columncBrand_Name = new DataColumn("cBrand_Name", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncBrand_Name);
//            this.columnLOtNO = new DataColumn("LOtNO", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columnLOtNO);
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal void InitVars()
//        {
//            this.columncItemDec = base.Columns["cItemDec"];
//            this.columncSize = base.Columns["cSize"];
//            this.columncColour = base.Columns["cColour"];
//            this.columncArt = base.Columns["cArt"];
//            this.columncDimec = base.Columns["cDimec"];
//            this.columncUnit = base.Columns["cUnit"];
//            this.columnnQty = base.Columns["nQty"];
//            this.columnnFOC = base.Columns["nFOC"];
//            this.columnnPrice = base.Columns["nPrice"];
//            this.columnnValue = base.Columns["nValue"];
//            this.columncStyleNo = base.Columns["cStyleNo"];
//            this.columnnGrnNo = base.Columns["nGrnNo"];
//            this.columnnPoNum = base.Columns["nPoNum"];
//            this.columncInVoice = base.Columns["cInVoice"];
//            this.columndEntDate = base.Columns["dEntDate"];
//            this.columncSupName = base.Columns["cSupName"];
//            this.columncUserFullname = base.Columns["cUserFullname"];
//            this.columnApprovedBy = base.Columns["ApprovedBy"];
//            this.columnbApp = base.Columns["bApp"];
//            this.columnIsCanceled = base.Columns["IsCanceled"];
//            this.columncCmpName = base.Columns["cCmpName"];
//            this.columncAppBy = base.Columns["cAppBy"];
//            this.columnNewSupplier = base.Columns["NewSupplier"];
//            this.columnGrnRevise = base.Columns["GrnRevise"];
//            this.columncBrand_Name = base.Columns["cBrand_Name"];
//            this.columnLOtNO = base.Columns["LOtNO"];
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.GRN_ReportRow NewGRN_ReportRow() =>
//            ((Inventory.GRN_ReportRow)base.NewRow());

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) =>
//            new Inventory.GRN_ReportRow(builder);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowChanged(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanged(e);
//            if (this.GRN_ReportRowChanged != null)
//            {
//                this.GRN_ReportRowChanged(this, new Inventory.GRN_ReportRowChangeEvent((Inventory.GRN_ReportRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowChanging(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanging(e);
//            if (this.GRN_ReportRowChanging != null)
//            {
//                this.GRN_ReportRowChanging(this, new Inventory.GRN_ReportRowChangeEvent((Inventory.GRN_ReportRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowDeleted(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleted(e);
//            if (this.GRN_ReportRowDeleted != null)
//            {
//                this.GRN_ReportRowDeleted(this, new Inventory.GRN_ReportRowChangeEvent((Inventory.GRN_ReportRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowDeleting(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleting(e);
//            if (this.GRN_ReportRowDeleting != null)
//            {
//                this.GRN_ReportRowDeleting(this, new Inventory.GRN_ReportRowChangeEvent((Inventory.GRN_ReportRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void RemoveGRN_ReportRow(Inventory.GRN_ReportRow row)
//        {
//            base.Rows.Remove(row);
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn ApprovedByColumn =>
//            this.columnApprovedBy;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn bAppColumn =>
//            this.columnbApp;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cAppByColumn =>
//            this.columncAppBy;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cArtColumn =>
//            this.columncArt;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cBrand_NameColumn =>
//            this.columncBrand_Name;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cCmpNameColumn =>
//            this.columncCmpName;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cColourColumn =>
//            this.columncColour;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cDimecColumn =>
//            this.columncDimec;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cInVoiceColumn =>
//            this.columncInVoice;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cItemDecColumn =>
//            this.columncItemDec;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode]
//        public int Count =>
//            base.Rows.Count;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cSizeColumn =>
//            this.columncSize;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cStyleNoColumn =>
//            this.columncStyleNo;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cSupNameColumn =>
//            this.columncSupName;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cUnitColumn =>
//            this.columncUnit;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cUserFullnameColumn =>
//            this.columncUserFullname;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn dEntDateColumn =>
//            this.columndEntDate;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn GrnReviseColumn =>
//            this.columnGrnRevise;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn IsCanceledColumn =>
//            this.columnIsCanceled;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.GRN_ReportRow this[int index] =>
//            ((Inventory.GRN_ReportRow)base.Rows[index]);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn LOtNOColumn =>
//            this.columnLOtNO;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn NewSupplierColumn =>
//            this.columnNewSupplier;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn nFOCColumn =>
//            this.columnnFOC;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn nGrnNoColumn =>
//            this.columnnGrnNo;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn nPoNumColumn =>
//            this.columnnPoNum;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn nPriceColumn =>
//            this.columnnPrice;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn nQtyColumn =>
//            this.columnnQty;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn nValueColumn =>
//            this.columnnValue;
//    }

//    public class GRN_ReportRow : DataRow
//    {
//        private Inventory.GRN_ReportDataTable tableGRN_Report;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal GRN_ReportRow(DataRowBuilder rb) : base(rb)
//        {
//            this.tableGRN_Report = (Inventory.GRN_ReportDataTable)base.Table;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsApprovedByNull() =>
//            base.IsNull(this.tableGRN_Report.ApprovedByColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsbAppNull() =>
//            base.IsNull(this.tableGRN_Report.bAppColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscAppByNull() =>
//            base.IsNull(this.tableGRN_Report.cAppByColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscArtNull() =>
//            base.IsNull(this.tableGRN_Report.cArtColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscBrand_NameNull() =>
//            base.IsNull(this.tableGRN_Report.cBrand_NameColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscCmpNameNull() =>
//            base.IsNull(this.tableGRN_Report.cCmpNameColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscColourNull() =>
//            base.IsNull(this.tableGRN_Report.cColourColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscDimecNull() =>
//            base.IsNull(this.tableGRN_Report.cDimecColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscInVoiceNull() =>
//            base.IsNull(this.tableGRN_Report.cInVoiceColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscItemDecNull() =>
//            base.IsNull(this.tableGRN_Report.cItemDecColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscSizeNull() =>
//            base.IsNull(this.tableGRN_Report.cSizeColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscStyleNoNull() =>
//            base.IsNull(this.tableGRN_Report.cStyleNoColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscSupNameNull() =>
//            base.IsNull(this.tableGRN_Report.cSupNameColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscUnitNull() =>
//            base.IsNull(this.tableGRN_Report.cUnitColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscUserFullnameNull() =>
//            base.IsNull(this.tableGRN_Report.cUserFullnameColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsdEntDateNull() =>
//            base.IsNull(this.tableGRN_Report.dEntDateColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsGrnReviseNull() =>
//            base.IsNull(this.tableGRN_Report.GrnReviseColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsIsCanceledNull() =>
//            base.IsNull(this.tableGRN_Report.IsCanceledColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsLOtNONull() =>
//            base.IsNull(this.tableGRN_Report.LOtNOColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsNewSupplierNull() =>
//            base.IsNull(this.tableGRN_Report.NewSupplierColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsnFOCNull() =>
//            base.IsNull(this.tableGRN_Report.nFOCColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsnGrnNoNull() =>
//            base.IsNull(this.tableGRN_Report.nGrnNoColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsnPoNumNull() =>
//            base.IsNull(this.tableGRN_Report.nPoNumColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsnPriceNull() =>
//            base.IsNull(this.tableGRN_Report.nPriceColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsnQtyNull() =>
//            base.IsNull(this.tableGRN_Report.nQtyColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsnValueNull() =>
//            base.IsNull(this.tableGRN_Report.nValueColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetApprovedByNull()
//        {
//            base[this.tableGRN_Report.ApprovedByColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetbAppNull()
//        {
//            base[this.tableGRN_Report.bAppColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcAppByNull()
//        {
//            base[this.tableGRN_Report.cAppByColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcArtNull()
//        {
//            base[this.tableGRN_Report.cArtColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcBrand_NameNull()
//        {
//            base[this.tableGRN_Report.cBrand_NameColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcCmpNameNull()
//        {
//            base[this.tableGRN_Report.cCmpNameColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcColourNull()
//        {
//            base[this.tableGRN_Report.cColourColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcDimecNull()
//        {
//            base[this.tableGRN_Report.cDimecColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcInVoiceNull()
//        {
//            base[this.tableGRN_Report.cInVoiceColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcItemDecNull()
//        {
//            base[this.tableGRN_Report.cItemDecColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcSizeNull()
//        {
//            base[this.tableGRN_Report.cSizeColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcStyleNoNull()
//        {
//            base[this.tableGRN_Report.cStyleNoColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcSupNameNull()
//        {
//            base[this.tableGRN_Report.cSupNameColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcUnitNull()
//        {
//            base[this.tableGRN_Report.cUnitColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcUserFullnameNull()
//        {
//            base[this.tableGRN_Report.cUserFullnameColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetdEntDateNull()
//        {
//            base[this.tableGRN_Report.dEntDateColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetGrnReviseNull()
//        {
//            base[this.tableGRN_Report.GrnReviseColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetIsCanceledNull()
//        {
//            base[this.tableGRN_Report.IsCanceledColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetLOtNONull()
//        {
//            base[this.tableGRN_Report.LOtNOColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetNewSupplierNull()
//        {
//            base[this.tableGRN_Report.NewSupplierColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetnFOCNull()
//        {
//            base[this.tableGRN_Report.nFOCColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnGrnNoNull()
//        {
//            base[this.tableGRN_Report.nGrnNoColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnPoNumNull()
//        {
//            base[this.tableGRN_Report.nPoNumColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetnPriceNull()
//        {
//            base[this.tableGRN_Report.nPriceColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetnQtyNull()
//        {
//            base[this.tableGRN_Report.nQtyColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnValueNull()
//        {
//            base[this.tableGRN_Report.nValueColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string ApprovedBy
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRN_Report.ApprovedByColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'ApprovedBy' in table 'GRN_Report' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRN_Report.ApprovedByColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool bApp
//        {
//            get
//            {
//                bool flag;
//                try
//                {
//                    flag = (bool)base[this.tableGRN_Report.bAppColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'bApp' in table 'GRN_Report' is DBNull.", exception);
//                }
//                return flag;
//            }
//            set
//            {
//                base[this.tableGRN_Report.bAppColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cAppBy
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRN_Report.cAppByColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cAppBy' in table 'GRN_Report' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRN_Report.cAppByColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cArt
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRN_Report.cArtColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cArt' in table 'GRN_Report' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRN_Report.cArtColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cBrand_Name
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRN_Report.cBrand_NameColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cBrand_Name' in table 'GRN_Report' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRN_Report.cBrand_NameColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cCmpName
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRN_Report.cCmpNameColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cCmpName' in table 'GRN_Report' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRN_Report.cCmpNameColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cColour
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRN_Report.cColourColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cColour' in table 'GRN_Report' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRN_Report.cColourColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cDimec
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRN_Report.cDimecColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cDimec' in table 'GRN_Report' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRN_Report.cDimecColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cInVoice
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRN_Report.cInVoiceColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cInVoice' in table 'GRN_Report' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRN_Report.cInVoiceColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cItemDec
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRN_Report.cItemDecColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cItemDec' in table 'GRN_Report' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRN_Report.cItemDecColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cSize
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRN_Report.cSizeColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cSize' in table 'GRN_Report' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRN_Report.cSizeColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cStyleNo
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRN_Report.cStyleNoColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cStyleNo' in table 'GRN_Report' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRN_Report.cStyleNoColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cSupName
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRN_Report.cSupNameColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cSupName' in table 'GRN_Report' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRN_Report.cSupNameColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cUnit
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRN_Report.cUnitColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cUnit' in table 'GRN_Report' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRN_Report.cUnitColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cUserFullname
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRN_Report.cUserFullnameColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cUserFullname' in table 'GRN_Report' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRN_Report.cUserFullnameColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DateTime dEntDate
//        {
//            get
//            {
//                DateTime time;
//                try
//                {
//                    time = (DateTime)base[this.tableGRN_Report.dEntDateColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'dEntDate' in table 'GRN_Report' is DBNull.", exception);
//                }
//                return time;
//            }
//            set
//            {
//                base[this.tableGRN_Report.dEntDateColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool GrnRevise
//        {
//            get
//            {
//                bool flag;
//                try
//                {
//                    flag = (bool)base[this.tableGRN_Report.GrnReviseColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'GrnRevise' in table 'GRN_Report' is DBNull.", exception);
//                }
//                return flag;
//            }
//            set
//            {
//                base[this.tableGRN_Report.GrnReviseColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsCanceled
//        {
//            get
//            {
//                bool flag;
//                try
//                {
//                    flag = (bool)base[this.tableGRN_Report.IsCanceledColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'IsCanceled' in table 'GRN_Report' is DBNull.", exception);
//                }
//                return flag;
//            }
//            set
//            {
//                base[this.tableGRN_Report.IsCanceledColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string LOtNO
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRN_Report.LOtNOColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'LOtNO' in table 'GRN_Report' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRN_Report.LOtNOColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string NewSupplier
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRN_Report.NewSupplierColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'NewSupplier' in table 'GRN_Report' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRN_Report.NewSupplierColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public decimal nFOC
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableGRN_Report.nFOCColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nFOC' in table 'GRN_Report' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableGRN_Report.nFOCColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public int nGrnNo
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableGRN_Report.nGrnNoColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nGrnNo' in table 'GRN_Report' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableGRN_Report.nGrnNoColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public int nPoNum
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableGRN_Report.nPoNumColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nPoNum' in table 'GRN_Report' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableGRN_Report.nPoNumColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public decimal nPrice
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableGRN_Report.nPriceColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nPrice' in table 'GRN_Report' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableGRN_Report.nPriceColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public decimal nQty
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableGRN_Report.nQtyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nQty' in table 'GRN_Report' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableGRN_Report.nQtyColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public decimal nValue
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableGRN_Report.nValueColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nValue' in table 'GRN_Report' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableGRN_Report.nValueColumn] = value;
//            }
//        }
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public class GRN_ReportRowChangeEvent : EventArgs
//    {
//        private DataRowAction eventAction;
//        private Inventory.GRN_ReportRow eventRow;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public GRN_ReportRowChangeEvent(Inventory.GRN_ReportRow row, DataRowAction action)
//        {
//            this.eventRow = row;
//            this.eventAction = action;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataRowAction Action =>
//            this.eventAction;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.GRN_ReportRow Row =>
//            this.eventRow;
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public delegate void GRN_ReportRowChangeEventHandler(object sender, Inventory.GRN_ReportRowChangeEvent e);

//    [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
//    public class GRND2DDataTable : TypedTableBase<Inventory.GRND2DRow>
//    {
//        private DataColumn columncArt;
//        private DataColumn columncColour;
//        private DataColumn columncDimec;
//        private DataColumn columncInVoice;
//        private DataColumn columncItemDec;
//        private DataColumn columncMainCategory;
//        private DataColumn columncSize;
//        private DataColumn columncStyleNo;
//        private DataColumn columncSupName;
//        private DataColumn columncUnit;
//        private DataColumn columnnGrnNo;
//        private DataColumn columnnPoNum;
//        private DataColumn columnnQty;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.GRND2DRowChangeEventHandler GRND2DRowChanged;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.GRND2DRowChangeEventHandler GRND2DRowChanging;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.GRND2DRowChangeEventHandler GRND2DRowDeleted;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.GRND2DRowChangeEventHandler GRND2DRowDeleting;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public GRND2DDataTable()
//        {
//            base.TableName = "GRND2D";
//            this.BeginInit();
//            this.InitClass();
//            this.EndInit();
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal GRND2DDataTable(DataTable table)
//        {
//            base.TableName = table.TableName;
//            if (table.CaseSensitive != table.DataSet.CaseSensitive)
//            {
//                base.CaseSensitive = table.CaseSensitive;
//            }
//            if (table.Locale.ToString() != table.DataSet.Locale.ToString())
//            {
//                base.Locale = table.Locale;
//            }
//            if (table.Namespace != table.DataSet.Namespace)
//            {
//                base.Namespace = table.Namespace;
//            }
//            base.Prefix = table.Prefix;
//            base.MinimumCapacity = table.MinimumCapacity;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected GRND2DDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
//        {
//            this.InitVars();
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void AddGRND2DRow(Inventory.GRND2DRow row)
//        {
//            base.Rows.Add(row);
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.GRND2DRow AddGRND2DRow(int nGrnNo, int nPoNum, string cInVoice, string cMainCategory, string cItemDec, string cSize, string cColour, string cArt, string cDimec, string cUnit, decimal nQty, string cStyleNo, string cSupName)
//        {
//            Inventory.GRND2DRow row = (Inventory.GRND2DRow)base.NewRow();
//            row.ItemArray = new object[] { nGrnNo, nPoNum, cInVoice, cMainCategory, cItemDec, cSize, cColour, cArt, cDimec, cUnit, nQty, cStyleNo, cSupName };
//            base.Rows.Add(row);
//            return row;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public override DataTable Clone()
//        {
//            Inventory.GRND2DDataTable table = (Inventory.GRND2DDataTable)base.Clone();
//            table.InitVars();
//            return table;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override DataTable CreateInstance() =>
//            new Inventory.GRND2DDataTable();

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override Type GetRowType() =>
//            typeof(Inventory.GRND2DRow);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
//        {
//            XmlSchemaComplexType type = new XmlSchemaComplexType();
//            XmlSchemaSequence sequence = new XmlSchemaSequence();
//            Inventory inventory = new Inventory();
//            XmlSchemaAny item = new XmlSchemaAny
//            {
//                Namespace = "http://www.w3.org/2001/XMLSchema",
//                MinOccurs = 0M,
//                MaxOccurs = 79228162514264337593543950335M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(item);
//            XmlSchemaAny any2 = new XmlSchemaAny
//            {
//                Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
//                MinOccurs = 1M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(any2);
//            XmlSchemaAttribute attribute = new XmlSchemaAttribute
//            {
//                Name = "namespace",
//                FixedValue = inventory.Namespace
//            };
//            type.Attributes.Add(attribute);
//            XmlSchemaAttribute attribute2 = new XmlSchemaAttribute
//            {
//                Name = "tableTypeName",
//                FixedValue = "GRND2DDataTable"
//            };
//            type.Attributes.Add(attribute2);
//            type.Particle = sequence;
//            XmlSchema schemaSerializable = inventory.GetSchemaSerializable();
//            if (xs.Contains(schemaSerializable.TargetNamespace))
//            {
//                MemoryStream stream = new MemoryStream();
//                MemoryStream stream2 = new MemoryStream();
//                try
//                {
//                    XmlSchema current = null;
//                    schemaSerializable.Write(stream);
//                    IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
//                    while (enumerator.MoveNext())
//                    {
//                        current = (XmlSchema)enumerator.Current;
//                        stream2.SetLength(0L);
//                        current.Write(stream2);
//                        if (stream.Length == stream2.Length)
//                        {
//                            stream.Position = 0L;
//                            stream2.Position = 0L;
//                            while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
//                            {
//                            }
//                            if (stream.Position == stream.Length)
//                            {
//                                return type;
//                            }
//                        }
//                    }
//                }
//                finally
//                {
//                    if (stream != null)
//                    {
//                        stream.Close();
//                    }
//                    if (stream2 != null)
//                    {
//                        stream2.Close();
//                    }
//                }
//            }
//            xs.Add(schemaSerializable);
//            return type;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        private void InitClass()
//        {
//            this.columnnGrnNo = new DataColumn("nGrnNo", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnnGrnNo);
//            this.columnnPoNum = new DataColumn("nPoNum", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnnPoNum);
//            this.columncInVoice = new DataColumn("cInVoice", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncInVoice);
//            this.columncMainCategory = new DataColumn("cMainCategory", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncMainCategory);
//            this.columncItemDec = new DataColumn("cItemDec", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncItemDec);
//            this.columncSize = new DataColumn("cSize", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncSize);
//            this.columncColour = new DataColumn("cColour", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncColour);
//            this.columncArt = new DataColumn("cArt", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncArt);
//            this.columncDimec = new DataColumn("cDimec", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncDimec);
//            this.columncUnit = new DataColumn("cUnit", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncUnit);
//            this.columnnQty = new DataColumn("nQty", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnnQty);
//            this.columncStyleNo = new DataColumn("cStyleNo", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncStyleNo);
//            this.columncSupName = new DataColumn("cSupName", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncSupName);
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal void InitVars()
//        {
//            this.columnnGrnNo = base.Columns["nGrnNo"];
//            this.columnnPoNum = base.Columns["nPoNum"];
//            this.columncInVoice = base.Columns["cInVoice"];
//            this.columncMainCategory = base.Columns["cMainCategory"];
//            this.columncItemDec = base.Columns["cItemDec"];
//            this.columncSize = base.Columns["cSize"];
//            this.columncColour = base.Columns["cColour"];
//            this.columncArt = base.Columns["cArt"];
//            this.columncDimec = base.Columns["cDimec"];
//            this.columncUnit = base.Columns["cUnit"];
//            this.columnnQty = base.Columns["nQty"];
//            this.columncStyleNo = base.Columns["cStyleNo"];
//            this.columncSupName = base.Columns["cSupName"];
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public Inventory.GRND2DRow NewGRND2DRow() =>
//            ((Inventory.GRND2DRow)base.NewRow());

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) =>
//            new Inventory.GRND2DRow(builder);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowChanged(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanged(e);
//            if (this.GRND2DRowChanged != null)
//            {
//                this.GRND2DRowChanged(this, new Inventory.GRND2DRowChangeEvent((Inventory.GRND2DRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowChanging(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanging(e);
//            if (this.GRND2DRowChanging != null)
//            {
//                this.GRND2DRowChanging(this, new Inventory.GRND2DRowChangeEvent((Inventory.GRND2DRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowDeleted(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleted(e);
//            if (this.GRND2DRowDeleted != null)
//            {
//                this.GRND2DRowDeleted(this, new Inventory.GRND2DRowChangeEvent((Inventory.GRND2DRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowDeleting(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleting(e);
//            if (this.GRND2DRowDeleting != null)
//            {
//                this.GRND2DRowDeleting(this, new Inventory.GRND2DRowChangeEvent((Inventory.GRND2DRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void RemoveGRND2DRow(Inventory.GRND2DRow row)
//        {
//            base.Rows.Remove(row);
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cArtColumn =>
//            this.columncArt;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cColourColumn =>
//            this.columncColour;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cDimecColumn =>
//            this.columncDimec;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cInVoiceColumn =>
//            this.columncInVoice;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cItemDecColumn =>
//            this.columncItemDec;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cMainCategoryColumn =>
//            this.columncMainCategory;

//        [Browsable(false), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public int Count =>
//            base.Rows.Count;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cSizeColumn =>
//            this.columncSize;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cStyleNoColumn =>
//            this.columncStyleNo;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cSupNameColumn =>
//            this.columncSupName;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cUnitColumn =>
//            this.columncUnit;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.GRND2DRow this[int index] =>
//            ((Inventory.GRND2DRow)base.Rows[index]);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn nGrnNoColumn =>
//            this.columnnGrnNo;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn nPoNumColumn =>
//            this.columnnPoNum;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn nQtyColumn =>
//            this.columnnQty;
//    }

//    [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
//    public class GRND2DFactorypurchaseDataTable : TypedTableBase<Inventory.GRND2DFactorypurchaseRow>
//    {
//        private DataColumn columncArt;
//        private DataColumn columncColour;
//        private DataColumn columncDimec;
//        private DataColumn columncInVoice;
//        private DataColumn columncItemDec;
//        private DataColumn columncMainCategory;
//        private DataColumn columncSize;
//        private DataColumn columncStyleNo;
//        private DataColumn columncSupName;
//        private DataColumn columncUnit;
//        private DataColumn columnnGrnNo;
//        private DataColumn columnnPoNum;
//        private DataColumn columnnPrice;
//        private DataColumn columnnQty;
//        private DataColumn columnnValue;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.GRND2DFactorypurchaseRowChangeEventHandler GRND2DFactorypurchaseRowChanged;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.GRND2DFactorypurchaseRowChangeEventHandler GRND2DFactorypurchaseRowChanging;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.GRND2DFactorypurchaseRowChangeEventHandler GRND2DFactorypurchaseRowDeleted;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.GRND2DFactorypurchaseRowChangeEventHandler GRND2DFactorypurchaseRowDeleting;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public GRND2DFactorypurchaseDataTable()
//        {
//            base.TableName = "GRND2DFactorypurchase";
//            this.BeginInit();
//            this.InitClass();
//            this.EndInit();
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        internal GRND2DFactorypurchaseDataTable(DataTable table)
//        {
//            base.TableName = table.TableName;
//            if (table.CaseSensitive != table.DataSet.CaseSensitive)
//            {
//                base.CaseSensitive = table.CaseSensitive;
//            }
//            if (table.Locale.ToString() != table.DataSet.Locale.ToString())
//            {
//                base.Locale = table.Locale;
//            }
//            if (table.Namespace != table.DataSet.Namespace)
//            {
//                base.Namespace = table.Namespace;
//            }
//            base.Prefix = table.Prefix;
//            base.MinimumCapacity = table.MinimumCapacity;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected GRND2DFactorypurchaseDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
//        {
//            this.InitVars();
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void AddGRND2DFactorypurchaseRow(Inventory.GRND2DFactorypurchaseRow row)
//        {
//            base.Rows.Add(row);
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public Inventory.GRND2DFactorypurchaseRow AddGRND2DFactorypurchaseRow(int nGrnNo, int nPoNum, string cInVoice, string cMainCategory, string cItemDec, string cSize, string cColour, string cArt, string cDimec, string cUnit, decimal nQty, string cStyleNo, string cSupName, decimal nPrice, decimal nValue)
//        {
//            Inventory.GRND2DFactorypurchaseRow row = (Inventory.GRND2DFactorypurchaseRow)base.NewRow();
//            row.ItemArray = new object[] { nGrnNo, nPoNum, cInVoice, cMainCategory, cItemDec, cSize, cColour, cArt, cDimec, cUnit, nQty, cStyleNo, cSupName, nPrice, nValue };
//            base.Rows.Add(row);
//            return row;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public override DataTable Clone()
//        {
//            Inventory.GRND2DFactorypurchaseDataTable table = (Inventory.GRND2DFactorypurchaseDataTable)base.Clone();
//            table.InitVars();
//            return table;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override DataTable CreateInstance() =>
//            new Inventory.GRND2DFactorypurchaseDataTable();

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override Type GetRowType() =>
//            typeof(Inventory.GRND2DFactorypurchaseRow);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
//        {
//            XmlSchemaComplexType type = new XmlSchemaComplexType();
//            XmlSchemaSequence sequence = new XmlSchemaSequence();
//            Inventory inventory = new Inventory();
//            XmlSchemaAny item = new XmlSchemaAny
//            {
//                Namespace = "http://www.w3.org/2001/XMLSchema",
//                MinOccurs = 0M,
//                MaxOccurs = 79228162514264337593543950335M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(item);
//            XmlSchemaAny any2 = new XmlSchemaAny
//            {
//                Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
//                MinOccurs = 1M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(any2);
//            XmlSchemaAttribute attribute = new XmlSchemaAttribute
//            {
//                Name = "namespace",
//                FixedValue = inventory.Namespace
//            };
//            type.Attributes.Add(attribute);
//            XmlSchemaAttribute attribute2 = new XmlSchemaAttribute
//            {
//                Name = "tableTypeName",
//                FixedValue = "GRND2DFactorypurchaseDataTable"
//            };
//            type.Attributes.Add(attribute2);
//            type.Particle = sequence;
//            XmlSchema schemaSerializable = inventory.GetSchemaSerializable();
//            if (xs.Contains(schemaSerializable.TargetNamespace))
//            {
//                MemoryStream stream = new MemoryStream();
//                MemoryStream stream2 = new MemoryStream();
//                try
//                {
//                    XmlSchema current = null;
//                    schemaSerializable.Write(stream);
//                    IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
//                    while (enumerator.MoveNext())
//                    {
//                        current = (XmlSchema)enumerator.Current;
//                        stream2.SetLength(0L);
//                        current.Write(stream2);
//                        if (stream.Length == stream2.Length)
//                        {
//                            stream.Position = 0L;
//                            stream2.Position = 0L;
//                            while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
//                            {
//                            }
//                            if (stream.Position == stream.Length)
//                            {
//                                return type;
//                            }
//                        }
//                    }
//                }
//                finally
//                {
//                    if (stream != null)
//                    {
//                        stream.Close();
//                    }
//                    if (stream2 != null)
//                    {
//                        stream2.Close();
//                    }
//                }
//            }
//            xs.Add(schemaSerializable);
//            return type;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        private void InitClass()
//        {
//            this.columnnGrnNo = new DataColumn("nGrnNo", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnnGrnNo);
//            this.columnnPoNum = new DataColumn("nPoNum", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnnPoNum);
//            this.columncInVoice = new DataColumn("cInVoice", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncInVoice);
//            this.columncMainCategory = new DataColumn("cMainCategory", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncMainCategory);
//            this.columncItemDec = new DataColumn("cItemDec", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncItemDec);
//            this.columncSize = new DataColumn("cSize", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncSize);
//            this.columncColour = new DataColumn("cColour", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncColour);
//            this.columncArt = new DataColumn("cArt", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncArt);
//            this.columncDimec = new DataColumn("cDimec", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncDimec);
//            this.columncUnit = new DataColumn("cUnit", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncUnit);
//            this.columnnQty = new DataColumn("nQty", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnnQty);
//            this.columncStyleNo = new DataColumn("cStyleNo", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncStyleNo);
//            this.columncSupName = new DataColumn("cSupName", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncSupName);
//            this.columnnPrice = new DataColumn("nPrice", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnnPrice);
//            this.columnnValue = new DataColumn("nValue", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnnValue);
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        internal void InitVars()
//        {
//            this.columnnGrnNo = base.Columns["nGrnNo"];
//            this.columnnPoNum = base.Columns["nPoNum"];
//            this.columncInVoice = base.Columns["cInVoice"];
//            this.columncMainCategory = base.Columns["cMainCategory"];
//            this.columncItemDec = base.Columns["cItemDec"];
//            this.columncSize = base.Columns["cSize"];
//            this.columncColour = base.Columns["cColour"];
//            this.columncArt = base.Columns["cArt"];
//            this.columncDimec = base.Columns["cDimec"];
//            this.columncUnit = base.Columns["cUnit"];
//            this.columnnQty = base.Columns["nQty"];
//            this.columncStyleNo = base.Columns["cStyleNo"];
//            this.columncSupName = base.Columns["cSupName"];
//            this.columnnPrice = base.Columns["nPrice"];
//            this.columnnValue = base.Columns["nValue"];
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.GRND2DFactorypurchaseRow NewGRND2DFactorypurchaseRow() =>
//            ((Inventory.GRND2DFactorypurchaseRow)base.NewRow());

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) =>
//            new Inventory.GRND2DFactorypurchaseRow(builder);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowChanged(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanged(e);
//            if (this.GRND2DFactorypurchaseRowChanged != null)
//            {
//                this.GRND2DFactorypurchaseRowChanged(this, new Inventory.GRND2DFactorypurchaseRowChangeEvent((Inventory.GRND2DFactorypurchaseRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowChanging(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanging(e);
//            if (this.GRND2DFactorypurchaseRowChanging != null)
//            {
//                this.GRND2DFactorypurchaseRowChanging(this, new Inventory.GRND2DFactorypurchaseRowChangeEvent((Inventory.GRND2DFactorypurchaseRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowDeleted(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleted(e);
//            if (this.GRND2DFactorypurchaseRowDeleted != null)
//            {
//                this.GRND2DFactorypurchaseRowDeleted(this, new Inventory.GRND2DFactorypurchaseRowChangeEvent((Inventory.GRND2DFactorypurchaseRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowDeleting(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleting(e);
//            if (this.GRND2DFactorypurchaseRowDeleting != null)
//            {
//                this.GRND2DFactorypurchaseRowDeleting(this, new Inventory.GRND2DFactorypurchaseRowChangeEvent((Inventory.GRND2DFactorypurchaseRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void RemoveGRND2DFactorypurchaseRow(Inventory.GRND2DFactorypurchaseRow row)
//        {
//            base.Rows.Remove(row);
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cArtColumn =>
//            this.columncArt;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cColourColumn =>
//            this.columncColour;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cDimecColumn =>
//            this.columncDimec;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cInVoiceColumn =>
//            this.columncInVoice;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cItemDecColumn =>
//            this.columncItemDec;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cMainCategoryColumn =>
//            this.columncMainCategory;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
//        public int Count =>
//            base.Rows.Count;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cSizeColumn =>
//            this.columncSize;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cStyleNoColumn =>
//            this.columncStyleNo;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cSupNameColumn =>
//            this.columncSupName;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cUnitColumn =>
//            this.columncUnit;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.GRND2DFactorypurchaseRow this[int index] =>
//            ((Inventory.GRND2DFactorypurchaseRow)base.Rows[index]);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn nGrnNoColumn =>
//            this.columnnGrnNo;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn nPoNumColumn =>
//            this.columnnPoNum;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn nPriceColumn =>
//            this.columnnPrice;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn nQtyColumn =>
//            this.columnnQty;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn nValueColumn =>
//            this.columnnValue;
//    }

//    public class GRND2DFactorypurchaseRow : DataRow
//    {
//        private Inventory.GRND2DFactorypurchaseDataTable tableGRND2DFactorypurchase;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal GRND2DFactorypurchaseRow(DataRowBuilder rb) : base(rb)
//        {
//            this.tableGRND2DFactorypurchase = (Inventory.GRND2DFactorypurchaseDataTable)base.Table;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscArtNull() =>
//            base.IsNull(this.tableGRND2DFactorypurchase.cArtColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscColourNull() =>
//            base.IsNull(this.tableGRND2DFactorypurchase.cColourColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscDimecNull() =>
//            base.IsNull(this.tableGRND2DFactorypurchase.cDimecColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscInVoiceNull() =>
//            base.IsNull(this.tableGRND2DFactorypurchase.cInVoiceColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscItemDecNull() =>
//            base.IsNull(this.tableGRND2DFactorypurchase.cItemDecColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscMainCategoryNull() =>
//            base.IsNull(this.tableGRND2DFactorypurchase.cMainCategoryColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscSizeNull() =>
//            base.IsNull(this.tableGRND2DFactorypurchase.cSizeColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscStyleNoNull() =>
//            base.IsNull(this.tableGRND2DFactorypurchase.cStyleNoColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscSupNameNull() =>
//            base.IsNull(this.tableGRND2DFactorypurchase.cSupNameColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscUnitNull() =>
//            base.IsNull(this.tableGRND2DFactorypurchase.cUnitColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsnGrnNoNull() =>
//            base.IsNull(this.tableGRND2DFactorypurchase.nGrnNoColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsnPoNumNull() =>
//            base.IsNull(this.tableGRND2DFactorypurchase.nPoNumColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsnPriceNull() =>
//            base.IsNull(this.tableGRND2DFactorypurchase.nPriceColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsnQtyNull() =>
//            base.IsNull(this.tableGRND2DFactorypurchase.nQtyColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsnValueNull() =>
//            base.IsNull(this.tableGRND2DFactorypurchase.nValueColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcArtNull()
//        {
//            base[this.tableGRND2DFactorypurchase.cArtColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcColourNull()
//        {
//            base[this.tableGRND2DFactorypurchase.cColourColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcDimecNull()
//        {
//            base[this.tableGRND2DFactorypurchase.cDimecColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcInVoiceNull()
//        {
//            base[this.tableGRND2DFactorypurchase.cInVoiceColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcItemDecNull()
//        {
//            base[this.tableGRND2DFactorypurchase.cItemDecColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcMainCategoryNull()
//        {
//            base[this.tableGRND2DFactorypurchase.cMainCategoryColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcSizeNull()
//        {
//            base[this.tableGRND2DFactorypurchase.cSizeColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcStyleNoNull()
//        {
//            base[this.tableGRND2DFactorypurchase.cStyleNoColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcSupNameNull()
//        {
//            base[this.tableGRND2DFactorypurchase.cSupNameColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcUnitNull()
//        {
//            base[this.tableGRND2DFactorypurchase.cUnitColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnGrnNoNull()
//        {
//            base[this.tableGRND2DFactorypurchase.nGrnNoColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnPoNumNull()
//        {
//            base[this.tableGRND2DFactorypurchase.nPoNumColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnPriceNull()
//        {
//            base[this.tableGRND2DFactorypurchase.nPriceColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnQtyNull()
//        {
//            base[this.tableGRND2DFactorypurchase.nQtyColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetnValueNull()
//        {
//            base[this.tableGRND2DFactorypurchase.nValueColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cArt
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRND2DFactorypurchase.cArtColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cArt' in table 'GRND2DFactorypurchase' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRND2DFactorypurchase.cArtColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cColour
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRND2DFactorypurchase.cColourColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cColour' in table 'GRND2DFactorypurchase' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRND2DFactorypurchase.cColourColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cDimec
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRND2DFactorypurchase.cDimecColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cDimec' in table 'GRND2DFactorypurchase' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRND2DFactorypurchase.cDimecColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cInVoice
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRND2DFactorypurchase.cInVoiceColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cInVoice' in table 'GRND2DFactorypurchase' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRND2DFactorypurchase.cInVoiceColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cItemDec
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRND2DFactorypurchase.cItemDecColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cItemDec' in table 'GRND2DFactorypurchase' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRND2DFactorypurchase.cItemDecColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cMainCategory
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRND2DFactorypurchase.cMainCategoryColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cMainCategory' in table 'GRND2DFactorypurchase' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRND2DFactorypurchase.cMainCategoryColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cSize
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRND2DFactorypurchase.cSizeColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cSize' in table 'GRND2DFactorypurchase' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRND2DFactorypurchase.cSizeColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cStyleNo
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRND2DFactorypurchase.cStyleNoColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cStyleNo' in table 'GRND2DFactorypurchase' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRND2DFactorypurchase.cStyleNoColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cSupName
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRND2DFactorypurchase.cSupNameColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cSupName' in table 'GRND2DFactorypurchase' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRND2DFactorypurchase.cSupNameColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cUnit
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRND2DFactorypurchase.cUnitColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cUnit' in table 'GRND2DFactorypurchase' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRND2DFactorypurchase.cUnitColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public int nGrnNo
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableGRND2DFactorypurchase.nGrnNoColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nGrnNo' in table 'GRND2DFactorypurchase' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableGRND2DFactorypurchase.nGrnNoColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public int nPoNum
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableGRND2DFactorypurchase.nPoNumColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nPoNum' in table 'GRND2DFactorypurchase' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableGRND2DFactorypurchase.nPoNumColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public decimal nPrice
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableGRND2DFactorypurchase.nPriceColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nPrice' in table 'GRND2DFactorypurchase' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableGRND2DFactorypurchase.nPriceColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public decimal nQty
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableGRND2DFactorypurchase.nQtyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nQty' in table 'GRND2DFactorypurchase' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableGRND2DFactorypurchase.nQtyColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public decimal nValue
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableGRND2DFactorypurchase.nValueColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nValue' in table 'GRND2DFactorypurchase' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableGRND2DFactorypurchase.nValueColumn] = value;
//            }
//        }
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public class GRND2DFactorypurchaseRowChangeEvent : EventArgs
//    {
//        private DataRowAction eventAction;
//        private Inventory.GRND2DFactorypurchaseRow eventRow;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public GRND2DFactorypurchaseRowChangeEvent(Inventory.GRND2DFactorypurchaseRow row, DataRowAction action)
//        {
//            this.eventRow = row;
//            this.eventAction = action;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataRowAction Action =>
//            this.eventAction;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.GRND2DFactorypurchaseRow Row =>
//            this.eventRow;
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public delegate void GRND2DFactorypurchaseRowChangeEventHandler(object sender, Inventory.GRND2DFactorypurchaseRowChangeEvent e);

//    public class GRND2DRow : DataRow
//    {
//        private Inventory.GRND2DDataTable tableGRND2D;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal GRND2DRow(DataRowBuilder rb) : base(rb)
//        {
//            this.tableGRND2D = (Inventory.GRND2DDataTable)base.Table;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscArtNull() =>
//            base.IsNull(this.tableGRND2D.cArtColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscColourNull() =>
//            base.IsNull(this.tableGRND2D.cColourColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscDimecNull() =>
//            base.IsNull(this.tableGRND2D.cDimecColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscInVoiceNull() =>
//            base.IsNull(this.tableGRND2D.cInVoiceColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscItemDecNull() =>
//            base.IsNull(this.tableGRND2D.cItemDecColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscMainCategoryNull() =>
//            base.IsNull(this.tableGRND2D.cMainCategoryColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscSizeNull() =>
//            base.IsNull(this.tableGRND2D.cSizeColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscStyleNoNull() =>
//            base.IsNull(this.tableGRND2D.cStyleNoColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscSupNameNull() =>
//            base.IsNull(this.tableGRND2D.cSupNameColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscUnitNull() =>
//            base.IsNull(this.tableGRND2D.cUnitColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsnGrnNoNull() =>
//            base.IsNull(this.tableGRND2D.nGrnNoColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsnPoNumNull() =>
//            base.IsNull(this.tableGRND2D.nPoNumColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsnQtyNull() =>
//            base.IsNull(this.tableGRND2D.nQtyColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcArtNull()
//        {
//            base[this.tableGRND2D.cArtColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcColourNull()
//        {
//            base[this.tableGRND2D.cColourColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcDimecNull()
//        {
//            base[this.tableGRND2D.cDimecColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcInVoiceNull()
//        {
//            base[this.tableGRND2D.cInVoiceColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcItemDecNull()
//        {
//            base[this.tableGRND2D.cItemDecColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcMainCategoryNull()
//        {
//            base[this.tableGRND2D.cMainCategoryColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcSizeNull()
//        {
//            base[this.tableGRND2D.cSizeColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcStyleNoNull()
//        {
//            base[this.tableGRND2D.cStyleNoColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcSupNameNull()
//        {
//            base[this.tableGRND2D.cSupNameColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcUnitNull()
//        {
//            base[this.tableGRND2D.cUnitColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetnGrnNoNull()
//        {
//            base[this.tableGRND2D.nGrnNoColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnPoNumNull()
//        {
//            base[this.tableGRND2D.nPoNumColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetnQtyNull()
//        {
//            base[this.tableGRND2D.nQtyColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cArt
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRND2D.cArtColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cArt' in table 'GRND2D' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRND2D.cArtColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cColour
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRND2D.cColourColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cColour' in table 'GRND2D' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRND2D.cColourColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cDimec
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRND2D.cDimecColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cDimec' in table 'GRND2D' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRND2D.cDimecColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cInVoice
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRND2D.cInVoiceColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cInVoice' in table 'GRND2D' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRND2D.cInVoiceColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cItemDec
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRND2D.cItemDecColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cItemDec' in table 'GRND2D' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRND2D.cItemDecColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cMainCategory
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRND2D.cMainCategoryColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cMainCategory' in table 'GRND2D' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRND2D.cMainCategoryColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cSize
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRND2D.cSizeColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cSize' in table 'GRND2D' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRND2D.cSizeColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cStyleNo
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRND2D.cStyleNoColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cStyleNo' in table 'GRND2D' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRND2D.cStyleNoColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cSupName
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRND2D.cSupNameColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cSupName' in table 'GRND2D' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRND2D.cSupNameColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cUnit
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableGRND2D.cUnitColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cUnit' in table 'GRND2D' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableGRND2D.cUnitColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public int nGrnNo
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableGRND2D.nGrnNoColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nGrnNo' in table 'GRND2D' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableGRND2D.nGrnNoColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public int nPoNum
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableGRND2D.nPoNumColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nPoNum' in table 'GRND2D' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableGRND2D.nPoNumColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public decimal nQty
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableGRND2D.nQtyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nQty' in table 'GRND2D' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableGRND2D.nQtyColumn] = value;
//            }
//        }
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public class GRND2DRowChangeEvent : EventArgs
//    {
//        private DataRowAction eventAction;
//        private Inventory.GRND2DRow eventRow;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public GRND2DRowChangeEvent(Inventory.GRND2DRow row, DataRowAction action)
//        {
//            this.eventRow = row;
//            this.eventAction = action;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataRowAction Action =>
//            this.eventAction;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.GRND2DRow Row =>
//            this.eventRow;
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public delegate void GRND2DRowChangeEventHandler(object sender, Inventory.GRND2DRowChangeEvent e);

//    [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
//    public class ItemLocationDataTable : TypedTableBase<Inventory.ItemLocationRow>
//    {
//        private DataColumn columnStorage_Name;
//        private DataColumn columnStorageBloack;
//        private DataColumn columnStorageCell;
//        private DataColumn columnStorageRack;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.ItemLocationRowChangeEventHandler ItemLocationRowChanged;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.ItemLocationRowChangeEventHandler ItemLocationRowChanging;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.ItemLocationRowChangeEventHandler ItemLocationRowDeleted;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.ItemLocationRowChangeEventHandler ItemLocationRowDeleting;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public ItemLocationDataTable()
//        {
//            base.TableName = "ItemLocation";
//            this.BeginInit();
//            this.InitClass();
//            this.EndInit();
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        internal ItemLocationDataTable(DataTable table)
//        {
//            base.TableName = table.TableName;
//            if (table.CaseSensitive != table.DataSet.CaseSensitive)
//            {
//                base.CaseSensitive = table.CaseSensitive;
//            }
//            if (table.Locale.ToString() != table.DataSet.Locale.ToString())
//            {
//                base.Locale = table.Locale;
//            }
//            if (table.Namespace != table.DataSet.Namespace)
//            {
//                base.Namespace = table.Namespace;
//            }
//            base.Prefix = table.Prefix;
//            base.MinimumCapacity = table.MinimumCapacity;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected ItemLocationDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
//        {
//            this.InitVars();
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void AddItemLocationRow(Inventory.ItemLocationRow row)
//        {
//            base.Rows.Add(row);
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.ItemLocationRow AddItemLocationRow(string Storage_Name, int StorageBloack, int StorageRack, int StorageCell)
//        {
//            Inventory.ItemLocationRow row = (Inventory.ItemLocationRow)base.NewRow();
//            row.ItemArray = new object[] { Storage_Name, StorageBloack, StorageRack, StorageCell };
//            base.Rows.Add(row);
//            return row;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public override DataTable Clone()
//        {
//            Inventory.ItemLocationDataTable table = (Inventory.ItemLocationDataTable)base.Clone();
//            table.InitVars();
//            return table;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override DataTable CreateInstance() =>
//            new Inventory.ItemLocationDataTable();

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override Type GetRowType() =>
//            typeof(Inventory.ItemLocationRow);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
//        {
//            XmlSchemaComplexType type = new XmlSchemaComplexType();
//            XmlSchemaSequence sequence = new XmlSchemaSequence();
//            Inventory inventory = new Inventory();
//            XmlSchemaAny item = new XmlSchemaAny
//            {
//                Namespace = "http://www.w3.org/2001/XMLSchema",
//                MinOccurs = 0M,
//                MaxOccurs = 79228162514264337593543950335M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(item);
//            XmlSchemaAny any2 = new XmlSchemaAny
//            {
//                Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
//                MinOccurs = 1M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(any2);
//            XmlSchemaAttribute attribute = new XmlSchemaAttribute
//            {
//                Name = "namespace",
//                FixedValue = inventory.Namespace
//            };
//            type.Attributes.Add(attribute);
//            XmlSchemaAttribute attribute2 = new XmlSchemaAttribute
//            {
//                Name = "tableTypeName",
//                FixedValue = "ItemLocationDataTable"
//            };
//            type.Attributes.Add(attribute2);
//            type.Particle = sequence;
//            XmlSchema schemaSerializable = inventory.GetSchemaSerializable();
//            if (xs.Contains(schemaSerializable.TargetNamespace))
//            {
//                MemoryStream stream = new MemoryStream();
//                MemoryStream stream2 = new MemoryStream();
//                try
//                {
//                    XmlSchema current = null;
//                    schemaSerializable.Write(stream);
//                    IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
//                    while (enumerator.MoveNext())
//                    {
//                        current = (XmlSchema)enumerator.Current;
//                        stream2.SetLength(0L);
//                        current.Write(stream2);
//                        if (stream.Length == stream2.Length)
//                        {
//                            stream.Position = 0L;
//                            stream2.Position = 0L;
//                            while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
//                            {
//                            }
//                            if (stream.Position == stream.Length)
//                            {
//                                return type;
//                            }
//                        }
//                    }
//                }
//                finally
//                {
//                    if (stream != null)
//                    {
//                        stream.Close();
//                    }
//                    if (stream2 != null)
//                    {
//                        stream2.Close();
//                    }
//                }
//            }
//            xs.Add(schemaSerializable);
//            return type;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        private void InitClass()
//        {
//            this.columnStorage_Name = new DataColumn("Storage_Name", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columnStorage_Name);
//            this.columnStorageBloack = new DataColumn("StorageBloack", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnStorageBloack);
//            this.columnStorageRack = new DataColumn("StorageRack", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnStorageRack);
//            this.columnStorageCell = new DataColumn("StorageCell", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnStorageCell);
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        internal void InitVars()
//        {
//            this.columnStorage_Name = base.Columns["Storage_Name"];
//            this.columnStorageBloack = base.Columns["StorageBloack"];
//            this.columnStorageRack = base.Columns["StorageRack"];
//            this.columnStorageCell = base.Columns["StorageCell"];
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.ItemLocationRow NewItemLocationRow() =>
//            ((Inventory.ItemLocationRow)base.NewRow());

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) =>
//            new Inventory.ItemLocationRow(builder);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowChanged(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanged(e);
//            if (this.ItemLocationRowChanged != null)
//            {
//                this.ItemLocationRowChanged(this, new Inventory.ItemLocationRowChangeEvent((Inventory.ItemLocationRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowChanging(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanging(e);
//            if (this.ItemLocationRowChanging != null)
//            {
//                this.ItemLocationRowChanging(this, new Inventory.ItemLocationRowChangeEvent((Inventory.ItemLocationRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowDeleted(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleted(e);
//            if (this.ItemLocationRowDeleted != null)
//            {
//                this.ItemLocationRowDeleted(this, new Inventory.ItemLocationRowChangeEvent((Inventory.ItemLocationRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowDeleting(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleting(e);
//            if (this.ItemLocationRowDeleting != null)
//            {
//                this.ItemLocationRowDeleting(this, new Inventory.ItemLocationRowChangeEvent((Inventory.ItemLocationRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void RemoveItemLocationRow(Inventory.ItemLocationRow row)
//        {
//            base.Rows.Remove(row);
//        }

//        [DebuggerNonUserCode, Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public int Count =>
//            base.Rows.Count;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public Inventory.ItemLocationRow this[int index] =>
//            ((Inventory.ItemLocationRow)base.Rows[index]);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn Storage_NameColumn =>
//            this.columnStorage_Name;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn StorageBloackColumn =>
//            this.columnStorageBloack;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn StorageCellColumn =>
//            this.columnStorageCell;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn StorageRackColumn =>
//            this.columnStorageRack;
//    }

//    public class ItemLocationRow : DataRow
//    {
//        private Inventory.ItemLocationDataTable tableItemLocation;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal ItemLocationRow(DataRowBuilder rb) : base(rb)
//        {
//            this.tableItemLocation = (Inventory.ItemLocationDataTable)base.Table;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsStorage_NameNull() =>
//            base.IsNull(this.tableItemLocation.Storage_NameColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsStorageBloackNull() =>
//            base.IsNull(this.tableItemLocation.StorageBloackColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsStorageCellNull() =>
//            base.IsNull(this.tableItemLocation.StorageCellColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsStorageRackNull() =>
//            base.IsNull(this.tableItemLocation.StorageRackColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetStorage_NameNull()
//        {
//            base[this.tableItemLocation.Storage_NameColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetStorageBloackNull()
//        {
//            base[this.tableItemLocation.StorageBloackColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetStorageCellNull()
//        {
//            base[this.tableItemLocation.StorageCellColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetStorageRackNull()
//        {
//            base[this.tableItemLocation.StorageRackColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string Storage_Name
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableItemLocation.Storage_NameColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'Storage_Name' in table 'ItemLocation' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableItemLocation.Storage_NameColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public int StorageBloack
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableItemLocation.StorageBloackColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'StorageBloack' in table 'ItemLocation' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableItemLocation.StorageBloackColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public int StorageCell
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableItemLocation.StorageCellColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'StorageCell' in table 'ItemLocation' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableItemLocation.StorageCellColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public int StorageRack
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableItemLocation.StorageRackColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'StorageRack' in table 'ItemLocation' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableItemLocation.StorageRackColumn] = value;
//            }
//        }
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public class ItemLocationRowChangeEvent : EventArgs
//    {
//        private DataRowAction eventAction;
//        private Inventory.ItemLocationRow eventRow;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public ItemLocationRowChangeEvent(Inventory.ItemLocationRow row, DataRowAction action)
//        {
//            this.eventRow = row;
//            this.eventAction = action;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataRowAction Action =>
//            this.eventAction;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.ItemLocationRow Row =>
//            this.eventRow;
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public delegate void ItemLocationRowChangeEventHandler(object sender, Inventory.ItemLocationRowChangeEvent e);

//    [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
//    public class ItemTraker_GrnDataTable : TypedTableBase<Inventory.ItemTraker_GrnRow>
//    {
//        private DataColumn columndEntDate;
//        private DataColumn columnnGrnNo;
//        private DataColumn columnnQty;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.ItemTraker_GrnRowChangeEventHandler ItemTraker_GrnRowChanged;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.ItemTraker_GrnRowChangeEventHandler ItemTraker_GrnRowChanging;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.ItemTraker_GrnRowChangeEventHandler ItemTraker_GrnRowDeleted;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.ItemTraker_GrnRowChangeEventHandler ItemTraker_GrnRowDeleting;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public ItemTraker_GrnDataTable()
//        {
//            base.TableName = "ItemTraker_Grn";
//            this.BeginInit();
//            this.InitClass();
//            this.EndInit();
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal ItemTraker_GrnDataTable(DataTable table)
//        {
//            base.TableName = table.TableName;
//            if (table.CaseSensitive != table.DataSet.CaseSensitive)
//            {
//                base.CaseSensitive = table.CaseSensitive;
//            }
//            if (table.Locale.ToString() != table.DataSet.Locale.ToString())
//            {
//                base.Locale = table.Locale;
//            }
//            if (table.Namespace != table.DataSet.Namespace)
//            {
//                base.Namespace = table.Namespace;
//            }
//            base.Prefix = table.Prefix;
//            base.MinimumCapacity = table.MinimumCapacity;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected ItemTraker_GrnDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
//        {
//            this.InitVars();
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void AddItemTraker_GrnRow(Inventory.ItemTraker_GrnRow row)
//        {
//            base.Rows.Add(row);
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public Inventory.ItemTraker_GrnRow AddItemTraker_GrnRow(int nGrnNo, DateTime dEntDate, decimal nQty)
//        {
//            Inventory.ItemTraker_GrnRow row = (Inventory.ItemTraker_GrnRow)base.NewRow();
//            row.ItemArray = new object[] { nGrnNo, dEntDate, nQty };
//            base.Rows.Add(row);
//            return row;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public override DataTable Clone()
//        {
//            Inventory.ItemTraker_GrnDataTable table = (Inventory.ItemTraker_GrnDataTable)base.Clone();
//            table.InitVars();
//            return table;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override DataTable CreateInstance() =>
//            new Inventory.ItemTraker_GrnDataTable();

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override Type GetRowType() =>
//            typeof(Inventory.ItemTraker_GrnRow);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
//        {
//            XmlSchemaComplexType type = new XmlSchemaComplexType();
//            XmlSchemaSequence sequence = new XmlSchemaSequence();
//            Inventory inventory = new Inventory();
//            XmlSchemaAny item = new XmlSchemaAny
//            {
//                Namespace = "http://www.w3.org/2001/XMLSchema",
//                MinOccurs = 0M,
//                MaxOccurs = 79228162514264337593543950335M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(item);
//            XmlSchemaAny any2 = new XmlSchemaAny
//            {
//                Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
//                MinOccurs = 1M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(any2);
//            XmlSchemaAttribute attribute = new XmlSchemaAttribute
//            {
//                Name = "namespace",
//                FixedValue = inventory.Namespace
//            };
//            type.Attributes.Add(attribute);
//            XmlSchemaAttribute attribute2 = new XmlSchemaAttribute
//            {
//                Name = "tableTypeName",
//                FixedValue = "ItemTraker_GrnDataTable"
//            };
//            type.Attributes.Add(attribute2);
//            type.Particle = sequence;
//            XmlSchema schemaSerializable = inventory.GetSchemaSerializable();
//            if (xs.Contains(schemaSerializable.TargetNamespace))
//            {
//                MemoryStream stream = new MemoryStream();
//                MemoryStream stream2 = new MemoryStream();
//                try
//                {
//                    XmlSchema current = null;
//                    schemaSerializable.Write(stream);
//                    IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
//                    while (enumerator.MoveNext())
//                    {
//                        current = (XmlSchema)enumerator.Current;
//                        stream2.SetLength(0L);
//                        current.Write(stream2);
//                        if (stream.Length == stream2.Length)
//                        {
//                            stream.Position = 0L;
//                            stream2.Position = 0L;
//                            while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
//                            {
//                            }
//                            if (stream.Position == stream.Length)
//                            {
//                                return type;
//                            }
//                        }
//                    }
//                }
//                finally
//                {
//                    if (stream != null)
//                    {
//                        stream.Close();
//                    }
//                    if (stream2 != null)
//                    {
//                        stream2.Close();
//                    }
//                }
//            }
//            xs.Add(schemaSerializable);
//            return type;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        private void InitClass()
//        {
//            this.columnnGrnNo = new DataColumn("nGrnNo", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnnGrnNo);
//            this.columndEntDate = new DataColumn("dEntDate", typeof(DateTime), null, MappingType.Element);
//            base.Columns.Add(this.columndEntDate);
//            this.columnnQty = new DataColumn("nQty", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnnQty);
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal void InitVars()
//        {
//            this.columnnGrnNo = base.Columns["nGrnNo"];
//            this.columndEntDate = base.Columns["dEntDate"];
//            this.columnnQty = base.Columns["nQty"];
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.ItemTraker_GrnRow NewItemTraker_GrnRow() =>
//            ((Inventory.ItemTraker_GrnRow)base.NewRow());

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) =>
//            new Inventory.ItemTraker_GrnRow(builder);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowChanged(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanged(e);
//            if (this.ItemTraker_GrnRowChanged != null)
//            {
//                this.ItemTraker_GrnRowChanged(this, new Inventory.ItemTraker_GrnRowChangeEvent((Inventory.ItemTraker_GrnRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowChanging(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanging(e);
//            if (this.ItemTraker_GrnRowChanging != null)
//            {
//                this.ItemTraker_GrnRowChanging(this, new Inventory.ItemTraker_GrnRowChangeEvent((Inventory.ItemTraker_GrnRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowDeleted(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleted(e);
//            if (this.ItemTraker_GrnRowDeleted != null)
//            {
//                this.ItemTraker_GrnRowDeleted(this, new Inventory.ItemTraker_GrnRowChangeEvent((Inventory.ItemTraker_GrnRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowDeleting(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleting(e);
//            if (this.ItemTraker_GrnRowDeleting != null)
//            {
//                this.ItemTraker_GrnRowDeleting(this, new Inventory.ItemTraker_GrnRowChangeEvent((Inventory.ItemTraker_GrnRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void RemoveItemTraker_GrnRow(Inventory.ItemTraker_GrnRow row)
//        {
//            base.Rows.Remove(row);
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, Browsable(false)]
//        public int Count =>
//            base.Rows.Count;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn dEntDateColumn =>
//            this.columndEntDate;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.ItemTraker_GrnRow this[int index] =>
//            ((Inventory.ItemTraker_GrnRow)base.Rows[index]);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn nGrnNoColumn =>
//            this.columnnGrnNo;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn nQtyColumn =>
//            this.columnnQty;
//    }

//    public class ItemTraker_GrnRow : DataRow
//    {
//        private Inventory.ItemTraker_GrnDataTable tableItemTraker_Grn;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        internal ItemTraker_GrnRow(DataRowBuilder rb) : base(rb)
//        {
//            this.tableItemTraker_Grn = (Inventory.ItemTraker_GrnDataTable)base.Table;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsdEntDateNull() =>
//            base.IsNull(this.tableItemTraker_Grn.dEntDateColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsnGrnNoNull() =>
//            base.IsNull(this.tableItemTraker_Grn.nGrnNoColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsnQtyNull() =>
//            base.IsNull(this.tableItemTraker_Grn.nQtyColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetdEntDateNull()
//        {
//            base[this.tableItemTraker_Grn.dEntDateColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetnGrnNoNull()
//        {
//            base[this.tableItemTraker_Grn.nGrnNoColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetnQtyNull()
//        {
//            base[this.tableItemTraker_Grn.nQtyColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DateTime dEntDate
//        {
//            get
//            {
//                DateTime time;
//                try
//                {
//                    time = (DateTime)base[this.tableItemTraker_Grn.dEntDateColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'dEntDate' in table 'ItemTraker_Grn' is DBNull.", exception);
//                }
//                return time;
//            }
//            set
//            {
//                base[this.tableItemTraker_Grn.dEntDateColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public int nGrnNo
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableItemTraker_Grn.nGrnNoColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nGrnNo' in table 'ItemTraker_Grn' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableItemTraker_Grn.nGrnNoColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public decimal nQty
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableItemTraker_Grn.nQtyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nQty' in table 'ItemTraker_Grn' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableItemTraker_Grn.nQtyColumn] = value;
//            }
//        }
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public class ItemTraker_GrnRowChangeEvent : EventArgs
//    {
//        private DataRowAction eventAction;
//        private Inventory.ItemTraker_GrnRow eventRow;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public ItemTraker_GrnRowChangeEvent(Inventory.ItemTraker_GrnRow row, DataRowAction action)
//        {
//            this.eventRow = row;
//            this.eventAction = action;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataRowAction Action =>
//            this.eventAction;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.ItemTraker_GrnRow Row =>
//            this.eventRow;
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public delegate void ItemTraker_GrnRowChangeEventHandler(object sender, Inventory.ItemTraker_GrnRowChangeEvent e);

//    [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
//    public class ItemTraker_IssueDataTable : TypedTableBase<Inventory.ItemTraker_IssueRow>
//    {
//        private DataColumn columndEntDAte;
//        private DataColumn columnnIssNo;
//        private DataColumn columnnIssQty;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.ItemTraker_IssueRowChangeEventHandler ItemTraker_IssueRowChanged;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.ItemTraker_IssueRowChangeEventHandler ItemTraker_IssueRowChanging;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.ItemTraker_IssueRowChangeEventHandler ItemTraker_IssueRowDeleted;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.ItemTraker_IssueRowChangeEventHandler ItemTraker_IssueRowDeleting;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public ItemTraker_IssueDataTable()
//        {
//            base.TableName = "ItemTraker_Issue";
//            this.BeginInit();
//            this.InitClass();
//            this.EndInit();
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        internal ItemTraker_IssueDataTable(DataTable table)
//        {
//            base.TableName = table.TableName;
//            if (table.CaseSensitive != table.DataSet.CaseSensitive)
//            {
//                base.CaseSensitive = table.CaseSensitive;
//            }
//            if (table.Locale.ToString() != table.DataSet.Locale.ToString())
//            {
//                base.Locale = table.Locale;
//            }
//            if (table.Namespace != table.DataSet.Namespace)
//            {
//                base.Namespace = table.Namespace;
//            }
//            base.Prefix = table.Prefix;
//            base.MinimumCapacity = table.MinimumCapacity;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected ItemTraker_IssueDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
//        {
//            this.InitVars();
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void AddItemTraker_IssueRow(Inventory.ItemTraker_IssueRow row)
//        {
//            base.Rows.Add(row);
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.ItemTraker_IssueRow AddItemTraker_IssueRow(DateTime dEntDAte, decimal nIssQty, int nIssNo)
//        {
//            Inventory.ItemTraker_IssueRow row = (Inventory.ItemTraker_IssueRow)base.NewRow();
//            row.ItemArray = new object[] { dEntDAte, nIssQty, nIssNo };
//            base.Rows.Add(row);
//            return row;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public override DataTable Clone()
//        {
//            Inventory.ItemTraker_IssueDataTable table = (Inventory.ItemTraker_IssueDataTable)base.Clone();
//            table.InitVars();
//            return table;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override DataTable CreateInstance() =>
//            new Inventory.ItemTraker_IssueDataTable();

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override Type GetRowType() =>
//            typeof(Inventory.ItemTraker_IssueRow);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
//        {
//            XmlSchemaComplexType type = new XmlSchemaComplexType();
//            XmlSchemaSequence sequence = new XmlSchemaSequence();
//            Inventory inventory = new Inventory();
//            XmlSchemaAny item = new XmlSchemaAny
//            {
//                Namespace = "http://www.w3.org/2001/XMLSchema",
//                MinOccurs = 0M,
//                MaxOccurs = 79228162514264337593543950335M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(item);
//            XmlSchemaAny any2 = new XmlSchemaAny
//            {
//                Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
//                MinOccurs = 1M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(any2);
//            XmlSchemaAttribute attribute = new XmlSchemaAttribute
//            {
//                Name = "namespace",
//                FixedValue = inventory.Namespace
//            };
//            type.Attributes.Add(attribute);
//            XmlSchemaAttribute attribute2 = new XmlSchemaAttribute
//            {
//                Name = "tableTypeName",
//                FixedValue = "ItemTraker_IssueDataTable"
//            };
//            type.Attributes.Add(attribute2);
//            type.Particle = sequence;
//            XmlSchema schemaSerializable = inventory.GetSchemaSerializable();
//            if (xs.Contains(schemaSerializable.TargetNamespace))
//            {
//                MemoryStream stream = new MemoryStream();
//                MemoryStream stream2 = new MemoryStream();
//                try
//                {
//                    XmlSchema current = null;
//                    schemaSerializable.Write(stream);
//                    IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
//                    while (enumerator.MoveNext())
//                    {
//                        current = (XmlSchema)enumerator.Current;
//                        stream2.SetLength(0L);
//                        current.Write(stream2);
//                        if (stream.Length == stream2.Length)
//                        {
//                            stream.Position = 0L;
//                            stream2.Position = 0L;
//                            while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
//                            {
//                            }
//                            if (stream.Position == stream.Length)
//                            {
//                                return type;
//                            }
//                        }
//                    }
//                }
//                finally
//                {
//                    if (stream != null)
//                    {
//                        stream.Close();
//                    }
//                    if (stream2 != null)
//                    {
//                        stream2.Close();
//                    }
//                }
//            }
//            xs.Add(schemaSerializable);
//            return type;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        private void InitClass()
//        {
//            this.columndEntDAte = new DataColumn("dEntDAte", typeof(DateTime), null, MappingType.Element);
//            base.Columns.Add(this.columndEntDAte);
//            this.columnnIssQty = new DataColumn("nIssQty", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnnIssQty);
//            this.columnnIssNo = new DataColumn("nIssNo", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnnIssNo);
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        internal void InitVars()
//        {
//            this.columndEntDAte = base.Columns["dEntDAte"];
//            this.columnnIssQty = base.Columns["nIssQty"];
//            this.columnnIssNo = base.Columns["nIssNo"];
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public Inventory.ItemTraker_IssueRow NewItemTraker_IssueRow() =>
//            ((Inventory.ItemTraker_IssueRow)base.NewRow());

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) =>
//            new Inventory.ItemTraker_IssueRow(builder);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowChanged(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanged(e);
//            if (this.ItemTraker_IssueRowChanged != null)
//            {
//                this.ItemTraker_IssueRowChanged(this, new Inventory.ItemTraker_IssueRowChangeEvent((Inventory.ItemTraker_IssueRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowChanging(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanging(e);
//            if (this.ItemTraker_IssueRowChanging != null)
//            {
//                this.ItemTraker_IssueRowChanging(this, new Inventory.ItemTraker_IssueRowChangeEvent((Inventory.ItemTraker_IssueRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowDeleted(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleted(e);
//            if (this.ItemTraker_IssueRowDeleted != null)
//            {
//                this.ItemTraker_IssueRowDeleted(this, new Inventory.ItemTraker_IssueRowChangeEvent((Inventory.ItemTraker_IssueRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowDeleting(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleting(e);
//            if (this.ItemTraker_IssueRowDeleting != null)
//            {
//                this.ItemTraker_IssueRowDeleting(this, new Inventory.ItemTraker_IssueRowChangeEvent((Inventory.ItemTraker_IssueRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void RemoveItemTraker_IssueRow(Inventory.ItemTraker_IssueRow row)
//        {
//            base.Rows.Remove(row);
//        }

//        [Browsable(false), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public int Count =>
//            base.Rows.Count;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn dEntDAteColumn =>
//            this.columndEntDAte;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public Inventory.ItemTraker_IssueRow this[int index] =>
//            ((Inventory.ItemTraker_IssueRow)base.Rows[index]);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn nIssNoColumn =>
//            this.columnnIssNo;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn nIssQtyColumn =>
//            this.columnnIssQty;
//    }

//    public class ItemTraker_IssueRow : DataRow
//    {
//        private Inventory.ItemTraker_IssueDataTable tableItemTraker_Issue;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal ItemTraker_IssueRow(DataRowBuilder rb) : base(rb)
//        {
//            this.tableItemTraker_Issue = (Inventory.ItemTraker_IssueDataTable)base.Table;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsdEntDAteNull() =>
//            base.IsNull(this.tableItemTraker_Issue.dEntDAteColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsnIssNoNull() =>
//            base.IsNull(this.tableItemTraker_Issue.nIssNoColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsnIssQtyNull() =>
//            base.IsNull(this.tableItemTraker_Issue.nIssQtyColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetdEntDAteNull()
//        {
//            base[this.tableItemTraker_Issue.dEntDAteColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetnIssNoNull()
//        {
//            base[this.tableItemTraker_Issue.nIssNoColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetnIssQtyNull()
//        {
//            base[this.tableItemTraker_Issue.nIssQtyColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DateTime dEntDAte
//        {
//            get
//            {
//                DateTime time;
//                try
//                {
//                    time = (DateTime)base[this.tableItemTraker_Issue.dEntDAteColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'dEntDAte' in table 'ItemTraker_Issue' is DBNull.", exception);
//                }
//                return time;
//            }
//            set
//            {
//                base[this.tableItemTraker_Issue.dEntDAteColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public int nIssNo
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableItemTraker_Issue.nIssNoColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nIssNo' in table 'ItemTraker_Issue' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableItemTraker_Issue.nIssNoColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public decimal nIssQty
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableItemTraker_Issue.nIssQtyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nIssQty' in table 'ItemTraker_Issue' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableItemTraker_Issue.nIssQtyColumn] = value;
//            }
//        }
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public class ItemTraker_IssueRowChangeEvent : EventArgs
//    {
//        private DataRowAction eventAction;
//        private Inventory.ItemTraker_IssueRow eventRow;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public ItemTraker_IssueRowChangeEvent(Inventory.ItemTraker_IssueRow row, DataRowAction action)
//        {
//            this.eventRow = row;
//            this.eventAction = action;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataRowAction Action =>
//            this.eventAction;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.ItemTraker_IssueRow Row =>
//            this.eventRow;
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public delegate void ItemTraker_IssueRowChangeEventHandler(object sender, Inventory.ItemTraker_IssueRowChangeEvent e);

//    [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
//    public class ItmTrakerDataTable : TypedTableBase<Inventory.ItmTrakerRow>
//    {
//        private DataColumn columnGRN_Date;
//        private DataColumn columnGRN_FOC;
//        private DataColumn columnGRN_ItmQty;
//        private DataColumn columnGRN_No;
//        private DataColumn columnGRN_Qty;
//        private DataColumn columngrnUnit;
//        private DataColumn columnIssue_Date;
//        private DataColumn columnIssue_ItmQty;
//        private DataColumn columnIssue_No;
//        private DataColumn columnIssue_Qty;
//        private DataColumn columnIssueUnit;
//        private DataColumn columnReturn_Date;
//        private DataColumn columnReturn_ItmQty;
//        private DataColumn columnReturn_No;
//        private DataColumn columnReturn_Qty;
//        private DataColumn columnReturnUnit;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.ItmTrakerRowChangeEventHandler ItmTrakerRowChanged;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.ItmTrakerRowChangeEventHandler ItmTrakerRowChanging;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.ItmTrakerRowChangeEventHandler ItmTrakerRowDeleted;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.ItmTrakerRowChangeEventHandler ItmTrakerRowDeleting;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public ItmTrakerDataTable()
//        {
//            base.TableName = "ItmTraker";
//            this.BeginInit();
//            this.InitClass();
//            this.EndInit();
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        internal ItmTrakerDataTable(DataTable table)
//        {
//            base.TableName = table.TableName;
//            if (table.CaseSensitive != table.DataSet.CaseSensitive)
//            {
//                base.CaseSensitive = table.CaseSensitive;
//            }
//            if (table.Locale.ToString() != table.DataSet.Locale.ToString())
//            {
//                base.Locale = table.Locale;
//            }
//            if (table.Namespace != table.DataSet.Namespace)
//            {
//                base.Namespace = table.Namespace;
//            }
//            base.Prefix = table.Prefix;
//            base.MinimumCapacity = table.MinimumCapacity;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected ItmTrakerDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
//        {
//            this.InitVars();
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void AddItmTrakerRow(Inventory.ItmTrakerRow row)
//        {
//            base.Rows.Add(row);
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public Inventory.ItmTrakerRow AddItmTrakerRow(DateTime GRN_Date, int GRN_No, decimal GRN_Qty, DateTime Issue_Date, int Issue_No, decimal Issue_Qty, decimal GRN_FOC, DateTime Return_Date, int Return_No, decimal Return_Qty, string grnUnit, string IssueUnit, string ReturnUnit, decimal GRN_ItmQty, decimal Issue_ItmQty, decimal Return_ItmQty)
//        {
//            Inventory.ItmTrakerRow row = (Inventory.ItmTrakerRow)base.NewRow();
//            row.ItemArray = new object[] { GRN_Date, GRN_No, GRN_Qty, Issue_Date, Issue_No, Issue_Qty, GRN_FOC, Return_Date, Return_No, Return_Qty, grnUnit, IssueUnit, ReturnUnit, GRN_ItmQty, Issue_ItmQty, Return_ItmQty };
//            base.Rows.Add(row);
//            return row;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public override DataTable Clone()
//        {
//            Inventory.ItmTrakerDataTable table = (Inventory.ItmTrakerDataTable)base.Clone();
//            table.InitVars();
//            return table;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override DataTable CreateInstance() =>
//            new Inventory.ItmTrakerDataTable();

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override Type GetRowType() =>
//            typeof(Inventory.ItmTrakerRow);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
//        {
//            XmlSchemaComplexType type = new XmlSchemaComplexType();
//            XmlSchemaSequence sequence = new XmlSchemaSequence();
//            Inventory inventory = new Inventory();
//            XmlSchemaAny item = new XmlSchemaAny
//            {
//                Namespace = "http://www.w3.org/2001/XMLSchema",
//                MinOccurs = 0M,
//                MaxOccurs = 79228162514264337593543950335M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(item);
//            XmlSchemaAny any2 = new XmlSchemaAny
//            {
//                Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
//                MinOccurs = 1M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(any2);
//            XmlSchemaAttribute attribute = new XmlSchemaAttribute
//            {
//                Name = "namespace",
//                FixedValue = inventory.Namespace
//            };
//            type.Attributes.Add(attribute);
//            XmlSchemaAttribute attribute2 = new XmlSchemaAttribute
//            {
//                Name = "tableTypeName",
//                FixedValue = "ItmTrakerDataTable"
//            };
//            type.Attributes.Add(attribute2);
//            type.Particle = sequence;
//            XmlSchema schemaSerializable = inventory.GetSchemaSerializable();
//            if (xs.Contains(schemaSerializable.TargetNamespace))
//            {
//                MemoryStream stream = new MemoryStream();
//                MemoryStream stream2 = new MemoryStream();
//                try
//                {
//                    XmlSchema current = null;
//                    schemaSerializable.Write(stream);
//                    IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
//                    while (enumerator.MoveNext())
//                    {
//                        current = (XmlSchema)enumerator.Current;
//                        stream2.SetLength(0L);
//                        current.Write(stream2);
//                        if (stream.Length == stream2.Length)
//                        {
//                            stream.Position = 0L;
//                            stream2.Position = 0L;
//                            while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
//                            {
//                            }
//                            if (stream.Position == stream.Length)
//                            {
//                                return type;
//                            }
//                        }
//                    }
//                }
//                finally
//                {
//                    if (stream != null)
//                    {
//                        stream.Close();
//                    }
//                    if (stream2 != null)
//                    {
//                        stream2.Close();
//                    }
//                }
//            }
//            xs.Add(schemaSerializable);
//            return type;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        private void InitClass()
//        {
//            this.columnGRN_Date = new DataColumn("GRN_Date", typeof(DateTime), null, MappingType.Element);
//            base.Columns.Add(this.columnGRN_Date);
//            this.columnGRN_No = new DataColumn("GRN_No", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnGRN_No);
//            this.columnGRN_Qty = new DataColumn("GRN_Qty", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnGRN_Qty);
//            this.columnIssue_Date = new DataColumn("Issue_Date", typeof(DateTime), null, MappingType.Element);
//            base.Columns.Add(this.columnIssue_Date);
//            this.columnIssue_No = new DataColumn("Issue_No", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnIssue_No);
//            this.columnIssue_Qty = new DataColumn("Issue_Qty", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnIssue_Qty);
//            this.columnGRN_FOC = new DataColumn("GRN_FOC", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnGRN_FOC);
//            this.columnReturn_Date = new DataColumn("Return_Date", typeof(DateTime), null, MappingType.Element);
//            base.Columns.Add(this.columnReturn_Date);
//            this.columnReturn_No = new DataColumn("Return_No", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnReturn_No);
//            this.columnReturn_Qty = new DataColumn("Return_Qty", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnReturn_Qty);
//            this.columngrnUnit = new DataColumn("grnUnit", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columngrnUnit);
//            this.columnIssueUnit = new DataColumn("IssueUnit", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columnIssueUnit);
//            this.columnReturnUnit = new DataColumn("ReturnUnit", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columnReturnUnit);
//            this.columnGRN_ItmQty = new DataColumn("GRN_ItmQty", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnGRN_ItmQty);
//            this.columnIssue_ItmQty = new DataColumn("Issue_ItmQty", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnIssue_ItmQty);
//            this.columnReturn_ItmQty = new DataColumn("Return_ItmQty", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnReturn_ItmQty);
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        internal void InitVars()
//        {
//            this.columnGRN_Date = base.Columns["GRN_Date"];
//            this.columnGRN_No = base.Columns["GRN_No"];
//            this.columnGRN_Qty = base.Columns["GRN_Qty"];
//            this.columnIssue_Date = base.Columns["Issue_Date"];
//            this.columnIssue_No = base.Columns["Issue_No"];
//            this.columnIssue_Qty = base.Columns["Issue_Qty"];
//            this.columnGRN_FOC = base.Columns["GRN_FOC"];
//            this.columnReturn_Date = base.Columns["Return_Date"];
//            this.columnReturn_No = base.Columns["Return_No"];
//            this.columnReturn_Qty = base.Columns["Return_Qty"];
//            this.columngrnUnit = base.Columns["grnUnit"];
//            this.columnIssueUnit = base.Columns["IssueUnit"];
//            this.columnReturnUnit = base.Columns["ReturnUnit"];
//            this.columnGRN_ItmQty = base.Columns["GRN_ItmQty"];
//            this.columnIssue_ItmQty = base.Columns["Issue_ItmQty"];
//            this.columnReturn_ItmQty = base.Columns["Return_ItmQty"];
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public Inventory.ItmTrakerRow NewItmTrakerRow() =>
//            ((Inventory.ItmTrakerRow)base.NewRow());

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) =>
//            new Inventory.ItmTrakerRow(builder);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowChanged(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanged(e);
//            if (this.ItmTrakerRowChanged != null)
//            {
//                this.ItmTrakerRowChanged(this, new Inventory.ItmTrakerRowChangeEvent((Inventory.ItmTrakerRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowChanging(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanging(e);
//            if (this.ItmTrakerRowChanging != null)
//            {
//                this.ItmTrakerRowChanging(this, new Inventory.ItmTrakerRowChangeEvent((Inventory.ItmTrakerRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowDeleted(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleted(e);
//            if (this.ItmTrakerRowDeleted != null)
//            {
//                this.ItmTrakerRowDeleted(this, new Inventory.ItmTrakerRowChangeEvent((Inventory.ItmTrakerRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowDeleting(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleting(e);
//            if (this.ItmTrakerRowDeleting != null)
//            {
//                this.ItmTrakerRowDeleting(this, new Inventory.ItmTrakerRowChangeEvent((Inventory.ItmTrakerRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void RemoveItmTrakerRow(Inventory.ItmTrakerRow row)
//        {
//            base.Rows.Remove(row);
//        }

//        [Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public int Count =>
//            base.Rows.Count;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn GRN_DateColumn =>
//            this.columnGRN_Date;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn GRN_FOCColumn =>
//            this.columnGRN_FOC;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn GRN_ItmQtyColumn =>
//            this.columnGRN_ItmQty;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn GRN_NoColumn =>
//            this.columnGRN_No;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn GRN_QtyColumn =>
//            this.columnGRN_Qty;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn grnUnitColumn =>
//            this.columngrnUnit;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn Issue_DateColumn =>
//            this.columnIssue_Date;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn Issue_ItmQtyColumn =>
//            this.columnIssue_ItmQty;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn Issue_NoColumn =>
//            this.columnIssue_No;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn Issue_QtyColumn =>
//            this.columnIssue_Qty;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn IssueUnitColumn =>
//            this.columnIssueUnit;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public Inventory.ItmTrakerRow this[int index] =>
//            ((Inventory.ItmTrakerRow)base.Rows[index]);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn Return_DateColumn =>
//            this.columnReturn_Date;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn Return_ItmQtyColumn =>
//            this.columnReturn_ItmQty;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn Return_NoColumn =>
//            this.columnReturn_No;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn Return_QtyColumn =>
//            this.columnReturn_Qty;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn ReturnUnitColumn =>
//            this.columnReturnUnit;
//    }

//    public class ItmTrakerRow : DataRow
//    {
//        private Inventory.ItmTrakerDataTable tableItmTraker;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        internal ItmTrakerRow(DataRowBuilder rb) : base(rb)
//        {
//            this.tableItmTraker = (Inventory.ItmTrakerDataTable)base.Table;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsGRN_DateNull() =>
//            base.IsNull(this.tableItmTraker.GRN_DateColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsGRN_FOCNull() =>
//            base.IsNull(this.tableItmTraker.GRN_FOCColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsGRN_ItmQtyNull() =>
//            base.IsNull(this.tableItmTraker.GRN_ItmQtyColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsGRN_NoNull() =>
//            base.IsNull(this.tableItmTraker.GRN_NoColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsGRN_QtyNull() =>
//            base.IsNull(this.tableItmTraker.GRN_QtyColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsgrnUnitNull() =>
//            base.IsNull(this.tableItmTraker.grnUnitColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsIssue_DateNull() =>
//            base.IsNull(this.tableItmTraker.Issue_DateColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsIssue_ItmQtyNull() =>
//            base.IsNull(this.tableItmTraker.Issue_ItmQtyColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsIssue_NoNull() =>
//            base.IsNull(this.tableItmTraker.Issue_NoColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsIssue_QtyNull() =>
//            base.IsNull(this.tableItmTraker.Issue_QtyColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsIssueUnitNull() =>
//            base.IsNull(this.tableItmTraker.IssueUnitColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsReturn_DateNull() =>
//            base.IsNull(this.tableItmTraker.Return_DateColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsReturn_ItmQtyNull() =>
//            base.IsNull(this.tableItmTraker.Return_ItmQtyColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsReturn_NoNull() =>
//            base.IsNull(this.tableItmTraker.Return_NoColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsReturn_QtyNull() =>
//            base.IsNull(this.tableItmTraker.Return_QtyColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsReturnUnitNull() =>
//            base.IsNull(this.tableItmTraker.ReturnUnitColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetGRN_DateNull()
//        {
//            base[this.tableItmTraker.GRN_DateColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetGRN_FOCNull()
//        {
//            base[this.tableItmTraker.GRN_FOCColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetGRN_ItmQtyNull()
//        {
//            base[this.tableItmTraker.GRN_ItmQtyColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetGRN_NoNull()
//        {
//            base[this.tableItmTraker.GRN_NoColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetGRN_QtyNull()
//        {
//            base[this.tableItmTraker.GRN_QtyColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetgrnUnitNull()
//        {
//            base[this.tableItmTraker.grnUnitColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetIssue_DateNull()
//        {
//            base[this.tableItmTraker.Issue_DateColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetIssue_ItmQtyNull()
//        {
//            base[this.tableItmTraker.Issue_ItmQtyColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetIssue_NoNull()
//        {
//            base[this.tableItmTraker.Issue_NoColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetIssue_QtyNull()
//        {
//            base[this.tableItmTraker.Issue_QtyColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetIssueUnitNull()
//        {
//            base[this.tableItmTraker.IssueUnitColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetReturn_DateNull()
//        {
//            base[this.tableItmTraker.Return_DateColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetReturn_ItmQtyNull()
//        {
//            base[this.tableItmTraker.Return_ItmQtyColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetReturn_NoNull()
//        {
//            base[this.tableItmTraker.Return_NoColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetReturn_QtyNull()
//        {
//            base[this.tableItmTraker.Return_QtyColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetReturnUnitNull()
//        {
//            base[this.tableItmTraker.ReturnUnitColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DateTime GRN_Date
//        {
//            get
//            {
//                DateTime time;
//                try
//                {
//                    time = (DateTime)base[this.tableItmTraker.GRN_DateColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'GRN_Date' in table 'ItmTraker' is DBNull.", exception);
//                }
//                return time;
//            }
//            set
//            {
//                base[this.tableItmTraker.GRN_DateColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public decimal GRN_FOC
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableItmTraker.GRN_FOCColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'GRN_FOC' in table 'ItmTraker' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableItmTraker.GRN_FOCColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public decimal GRN_ItmQty
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableItmTraker.GRN_ItmQtyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'GRN_ItmQty' in table 'ItmTraker' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableItmTraker.GRN_ItmQtyColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public int GRN_No
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableItmTraker.GRN_NoColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'GRN_No' in table 'ItmTraker' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableItmTraker.GRN_NoColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public decimal GRN_Qty
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableItmTraker.GRN_QtyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'GRN_Qty' in table 'ItmTraker' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableItmTraker.GRN_QtyColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string grnUnit
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableItmTraker.grnUnitColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'grnUnit' in table 'ItmTraker' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableItmTraker.grnUnitColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DateTime Issue_Date
//        {
//            get
//            {
//                DateTime time;
//                try
//                {
//                    time = (DateTime)base[this.tableItmTraker.Issue_DateColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'Issue_Date' in table 'ItmTraker' is DBNull.", exception);
//                }
//                return time;
//            }
//            set
//            {
//                base[this.tableItmTraker.Issue_DateColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public decimal Issue_ItmQty
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableItmTraker.Issue_ItmQtyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'Issue_ItmQty' in table 'ItmTraker' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableItmTraker.Issue_ItmQtyColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public int Issue_No
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableItmTraker.Issue_NoColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'Issue_No' in table 'ItmTraker' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableItmTraker.Issue_NoColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public decimal Issue_Qty
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableItmTraker.Issue_QtyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'Issue_Qty' in table 'ItmTraker' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableItmTraker.Issue_QtyColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string IssueUnit
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableItmTraker.IssueUnitColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'IssueUnit' in table 'ItmTraker' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableItmTraker.IssueUnitColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DateTime Return_Date
//        {
//            get
//            {
//                DateTime time;
//                try
//                {
//                    time = (DateTime)base[this.tableItmTraker.Return_DateColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'Return_Date' in table 'ItmTraker' is DBNull.", exception);
//                }
//                return time;
//            }
//            set
//            {
//                base[this.tableItmTraker.Return_DateColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public decimal Return_ItmQty
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableItmTraker.Return_ItmQtyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'Return_ItmQty' in table 'ItmTraker' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableItmTraker.Return_ItmQtyColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public int Return_No
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableItmTraker.Return_NoColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'Return_No' in table 'ItmTraker' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableItmTraker.Return_NoColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public decimal Return_Qty
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableItmTraker.Return_QtyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'Return_Qty' in table 'ItmTraker' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableItmTraker.Return_QtyColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string ReturnUnit
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableItmTraker.ReturnUnitColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'ReturnUnit' in table 'ItmTraker' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableItmTraker.ReturnUnitColumn] = value;
//            }
//        }
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public class ItmTrakerRowChangeEvent : EventArgs
//    {
//        private DataRowAction eventAction;
//        private Inventory.ItmTrakerRow eventRow;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public ItmTrakerRowChangeEvent(Inventory.ItmTrakerRow row, DataRowAction action)
//        {
//            this.eventRow = row;
//            this.eventAction = action;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataRowAction Action =>
//            this.eventAction;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public Inventory.ItmTrakerRow Row =>
//            this.eventRow;
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public delegate void ItmTrakerRowChangeEventHandler(object sender, Inventory.ItmTrakerRowChangeEvent e);

//    [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
//    public class monthwisefabricrptDataTable : TypedTableBase<Inventory.monthwisefabricrptRow>
//    {
//        private DataColumn columncBuyer_Name;
//        private DataColumn columngrnQty;
//        private DataColumn columnissueQty;
//        private DataColumn columnOrdqty;
//        private DataColumn columnReqqty;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.monthwisefabricrptRowChangeEventHandler monthwisefabricrptRowChanged;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.monthwisefabricrptRowChangeEventHandler monthwisefabricrptRowChanging;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.monthwisefabricrptRowChangeEventHandler monthwisefabricrptRowDeleted;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.monthwisefabricrptRowChangeEventHandler monthwisefabricrptRowDeleting;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public monthwisefabricrptDataTable()
//        {
//            base.TableName = "monthwisefabricrpt";
//            this.BeginInit();
//            this.InitClass();
//            this.EndInit();
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        internal monthwisefabricrptDataTable(DataTable table)
//        {
//            base.TableName = table.TableName;
//            if (table.CaseSensitive != table.DataSet.CaseSensitive)
//            {
//                base.CaseSensitive = table.CaseSensitive;
//            }
//            if (table.Locale.ToString() != table.DataSet.Locale.ToString())
//            {
//                base.Locale = table.Locale;
//            }
//            if (table.Namespace != table.DataSet.Namespace)
//            {
//                base.Namespace = table.Namespace;
//            }
//            base.Prefix = table.Prefix;
//            base.MinimumCapacity = table.MinimumCapacity;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected monthwisefabricrptDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
//        {
//            this.InitVars();
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void AddmonthwisefabricrptRow(Inventory.monthwisefabricrptRow row)
//        {
//            base.Rows.Add(row);
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.monthwisefabricrptRow AddmonthwisefabricrptRow(string cBuyer_Name, decimal Ordqty, decimal Reqqty, decimal grnQty, decimal issueQty)
//        {
//            Inventory.monthwisefabricrptRow row = (Inventory.monthwisefabricrptRow)base.NewRow();
//            row.ItemArray = new object[] { cBuyer_Name, Ordqty, Reqqty, grnQty, issueQty };
//            base.Rows.Add(row);
//            return row;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public override DataTable Clone()
//        {
//            Inventory.monthwisefabricrptDataTable table = (Inventory.monthwisefabricrptDataTable)base.Clone();
//            table.InitVars();
//            return table;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override DataTable CreateInstance() =>
//            new Inventory.monthwisefabricrptDataTable();

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override Type GetRowType() =>
//            typeof(Inventory.monthwisefabricrptRow);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
//        {
//            XmlSchemaComplexType type = new XmlSchemaComplexType();
//            XmlSchemaSequence sequence = new XmlSchemaSequence();
//            Inventory inventory = new Inventory();
//            XmlSchemaAny item = new XmlSchemaAny
//            {
//                Namespace = "http://www.w3.org/2001/XMLSchema",
//                MinOccurs = 0M,
//                MaxOccurs = 79228162514264337593543950335M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(item);
//            XmlSchemaAny any2 = new XmlSchemaAny
//            {
//                Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
//                MinOccurs = 1M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(any2);
//            XmlSchemaAttribute attribute = new XmlSchemaAttribute
//            {
//                Name = "namespace",
//                FixedValue = inventory.Namespace
//            };
//            type.Attributes.Add(attribute);
//            XmlSchemaAttribute attribute2 = new XmlSchemaAttribute
//            {
//                Name = "tableTypeName",
//                FixedValue = "monthwisefabricrptDataTable"
//            };
//            type.Attributes.Add(attribute2);
//            type.Particle = sequence;
//            XmlSchema schemaSerializable = inventory.GetSchemaSerializable();
//            if (xs.Contains(schemaSerializable.TargetNamespace))
//            {
//                MemoryStream stream = new MemoryStream();
//                MemoryStream stream2 = new MemoryStream();
//                try
//                {
//                    XmlSchema current = null;
//                    schemaSerializable.Write(stream);
//                    IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
//                    while (enumerator.MoveNext())
//                    {
//                        current = (XmlSchema)enumerator.Current;
//                        stream2.SetLength(0L);
//                        current.Write(stream2);
//                        if (stream.Length == stream2.Length)
//                        {
//                            stream.Position = 0L;
//                            stream2.Position = 0L;
//                            while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
//                            {
//                            }
//                            if (stream.Position == stream.Length)
//                            {
//                                return type;
//                            }
//                        }
//                    }
//                }
//                finally
//                {
//                    if (stream != null)
//                    {
//                        stream.Close();
//                    }
//                    if (stream2 != null)
//                    {
//                        stream2.Close();
//                    }
//                }
//            }
//            xs.Add(schemaSerializable);
//            return type;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        private void InitClass()
//        {
//            this.columncBuyer_Name = new DataColumn("cBuyer_Name", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncBuyer_Name);
//            this.columnOrdqty = new DataColumn("Ordqty", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnOrdqty);
//            this.columnReqqty = new DataColumn("Reqqty", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnReqqty);
//            this.columngrnQty = new DataColumn("grnQty", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columngrnQty);
//            this.columnissueQty = new DataColumn("issueQty", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnissueQty);
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        internal void InitVars()
//        {
//            this.columncBuyer_Name = base.Columns["cBuyer_Name"];
//            this.columnOrdqty = base.Columns["Ordqty"];
//            this.columnReqqty = base.Columns["Reqqty"];
//            this.columngrnQty = base.Columns["grnQty"];
//            this.columnissueQty = base.Columns["issueQty"];
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.monthwisefabricrptRow NewmonthwisefabricrptRow() =>
//            ((Inventory.monthwisefabricrptRow)base.NewRow());

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) =>
//            new Inventory.monthwisefabricrptRow(builder);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowChanged(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanged(e);
//            if (this.monthwisefabricrptRowChanged != null)
//            {
//                this.monthwisefabricrptRowChanged(this, new Inventory.monthwisefabricrptRowChangeEvent((Inventory.monthwisefabricrptRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowChanging(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanging(e);
//            if (this.monthwisefabricrptRowChanging != null)
//            {
//                this.monthwisefabricrptRowChanging(this, new Inventory.monthwisefabricrptRowChangeEvent((Inventory.monthwisefabricrptRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowDeleted(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleted(e);
//            if (this.monthwisefabricrptRowDeleted != null)
//            {
//                this.monthwisefabricrptRowDeleted(this, new Inventory.monthwisefabricrptRowChangeEvent((Inventory.monthwisefabricrptRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowDeleting(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleting(e);
//            if (this.monthwisefabricrptRowDeleting != null)
//            {
//                this.monthwisefabricrptRowDeleting(this, new Inventory.monthwisefabricrptRowChangeEvent((Inventory.monthwisefabricrptRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void RemovemonthwisefabricrptRow(Inventory.monthwisefabricrptRow row)
//        {
//            base.Rows.Remove(row);
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cBuyer_NameColumn =>
//            this.columncBuyer_Name;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode]
//        public int Count =>
//            base.Rows.Count;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn grnQtyColumn =>
//            this.columngrnQty;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn issueQtyColumn =>
//            this.columnissueQty;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.monthwisefabricrptRow this[int index] =>
//            ((Inventory.monthwisefabricrptRow)base.Rows[index]);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn OrdqtyColumn =>
//            this.columnOrdqty;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn ReqqtyColumn =>
//            this.columnReqqty;
//    }

//    public class monthwisefabricrptRow : DataRow
//    {
//        private Inventory.monthwisefabricrptDataTable tablemonthwisefabricrpt;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        internal monthwisefabricrptRow(DataRowBuilder rb) : base(rb)
//        {
//            this.tablemonthwisefabricrpt = (Inventory.monthwisefabricrptDataTable)base.Table;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscBuyer_NameNull() =>
//            base.IsNull(this.tablemonthwisefabricrpt.cBuyer_NameColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsgrnQtyNull() =>
//            base.IsNull(this.tablemonthwisefabricrpt.grnQtyColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsissueQtyNull() =>
//            base.IsNull(this.tablemonthwisefabricrpt.issueQtyColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsOrdqtyNull() =>
//            base.IsNull(this.tablemonthwisefabricrpt.OrdqtyColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsReqqtyNull() =>
//            base.IsNull(this.tablemonthwisefabricrpt.ReqqtyColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcBuyer_NameNull()
//        {
//            base[this.tablemonthwisefabricrpt.cBuyer_NameColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetgrnQtyNull()
//        {
//            base[this.tablemonthwisefabricrpt.grnQtyColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetissueQtyNull()
//        {
//            base[this.tablemonthwisefabricrpt.issueQtyColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetOrdqtyNull()
//        {
//            base[this.tablemonthwisefabricrpt.OrdqtyColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetReqqtyNull()
//        {
//            base[this.tablemonthwisefabricrpt.ReqqtyColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cBuyer_Name
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tablemonthwisefabricrpt.cBuyer_NameColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cBuyer_Name' in table 'monthwisefabricrpt' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tablemonthwisefabricrpt.cBuyer_NameColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public decimal grnQty
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tablemonthwisefabricrpt.grnQtyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'grnQty' in table 'monthwisefabricrpt' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tablemonthwisefabricrpt.grnQtyColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public decimal issueQty
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tablemonthwisefabricrpt.issueQtyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'issueQty' in table 'monthwisefabricrpt' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tablemonthwisefabricrpt.issueQtyColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public decimal Ordqty
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tablemonthwisefabricrpt.OrdqtyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'Ordqty' in table 'monthwisefabricrpt' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tablemonthwisefabricrpt.OrdqtyColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public decimal Reqqty
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tablemonthwisefabricrpt.ReqqtyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'Reqqty' in table 'monthwisefabricrpt' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tablemonthwisefabricrpt.ReqqtyColumn] = value;
//            }
//        }
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public class monthwisefabricrptRowChangeEvent : EventArgs
//    {
//        private DataRowAction eventAction;
//        private Inventory.monthwisefabricrptRow eventRow;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public monthwisefabricrptRowChangeEvent(Inventory.monthwisefabricrptRow row, DataRowAction action)
//        {
//            this.eventRow = row;
//            this.eventAction = action;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataRowAction Action =>
//            this.eventAction;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.monthwisefabricrptRow Row =>
//            this.eventRow;
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public delegate void monthwisefabricrptRowChangeEventHandler(object sender, Inventory.monthwisefabricrptRowChangeEvent e);

//    [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
//    public class ReOrdErDataTable : TypedTableBase<Inventory.ReOrdErRow>
//    {
//        private DataColumn columncArticle;
//        private DataColumn columncBrand_Name;
//        private DataColumn columncCmpName;
//        private DataColumn columncColour;
//        private DataColumn columncDes;
//        private DataColumn columncDimen;
//        private DataColumn columncMainCategory;
//        private DataColumn columncSize1;
//        private DataColumn columncUnitDes;
//        private DataColumn columnnItemBalQty;
//        private DataColumn columnReordLvl;
//        private DataColumn columnReOrdQty;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.ReOrdErRowChangeEventHandler ReOrdErRowChanged;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.ReOrdErRowChangeEventHandler ReOrdErRowChanging;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.ReOrdErRowChangeEventHandler ReOrdErRowDeleted;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.ReOrdErRowChangeEventHandler ReOrdErRowDeleting;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public ReOrdErDataTable()
//        {
//            base.TableName = "ReOrdEr";
//            this.BeginInit();
//            this.InitClass();
//            this.EndInit();
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal ReOrdErDataTable(DataTable table)
//        {
//            base.TableName = table.TableName;
//            if (table.CaseSensitive != table.DataSet.CaseSensitive)
//            {
//                base.CaseSensitive = table.CaseSensitive;
//            }
//            if (table.Locale.ToString() != table.DataSet.Locale.ToString())
//            {
//                base.Locale = table.Locale;
//            }
//            if (table.Namespace != table.DataSet.Namespace)
//            {
//                base.Namespace = table.Namespace;
//            }
//            base.Prefix = table.Prefix;
//            base.MinimumCapacity = table.MinimumCapacity;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected ReOrdErDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
//        {
//            this.InitVars();
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void AddReOrdErRow(Inventory.ReOrdErRow row)
//        {
//            base.Rows.Add(row);
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.ReOrdErRow AddReOrdErRow(string cCmpName, string cMainCategory, string cDes, string cArticle, string cDimen, string cColour, string cSize1, string cBrand_Name, string cUnitDes, decimal nItemBalQty, decimal ReordLvl, decimal ReOrdQty)
//        {
//            Inventory.ReOrdErRow row = (Inventory.ReOrdErRow)base.NewRow();
//            row.ItemArray = new object[] { cCmpName, cMainCategory, cDes, cArticle, cDimen, cColour, cSize1, cBrand_Name, cUnitDes, nItemBalQty, ReordLvl, ReOrdQty };
//            base.Rows.Add(row);
//            return row;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public override DataTable Clone()
//        {
//            Inventory.ReOrdErDataTable table = (Inventory.ReOrdErDataTable)base.Clone();
//            table.InitVars();
//            return table;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override DataTable CreateInstance() =>
//            new Inventory.ReOrdErDataTable();

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override Type GetRowType() =>
//            typeof(Inventory.ReOrdErRow);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
//        {
//            XmlSchemaComplexType type = new XmlSchemaComplexType();
//            XmlSchemaSequence sequence = new XmlSchemaSequence();
//            Inventory inventory = new Inventory();
//            XmlSchemaAny item = new XmlSchemaAny
//            {
//                Namespace = "http://www.w3.org/2001/XMLSchema",
//                MinOccurs = 0M,
//                MaxOccurs = 79228162514264337593543950335M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(item);
//            XmlSchemaAny any2 = new XmlSchemaAny
//            {
//                Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
//                MinOccurs = 1M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(any2);
//            XmlSchemaAttribute attribute = new XmlSchemaAttribute
//            {
//                Name = "namespace",
//                FixedValue = inventory.Namespace
//            };
//            type.Attributes.Add(attribute);
//            XmlSchemaAttribute attribute2 = new XmlSchemaAttribute
//            {
//                Name = "tableTypeName",
//                FixedValue = "ReOrdErDataTable"
//            };
//            type.Attributes.Add(attribute2);
//            type.Particle = sequence;
//            XmlSchema schemaSerializable = inventory.GetSchemaSerializable();
//            if (xs.Contains(schemaSerializable.TargetNamespace))
//            {
//                MemoryStream stream = new MemoryStream();
//                MemoryStream stream2 = new MemoryStream();
//                try
//                {
//                    XmlSchema current = null;
//                    schemaSerializable.Write(stream);
//                    IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
//                    while (enumerator.MoveNext())
//                    {
//                        current = (XmlSchema)enumerator.Current;
//                        stream2.SetLength(0L);
//                        current.Write(stream2);
//                        if (stream.Length == stream2.Length)
//                        {
//                            stream.Position = 0L;
//                            stream2.Position = 0L;
//                            while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
//                            {
//                            }
//                            if (stream.Position == stream.Length)
//                            {
//                                return type;
//                            }
//                        }
//                    }
//                }
//                finally
//                {
//                    if (stream != null)
//                    {
//                        stream.Close();
//                    }
//                    if (stream2 != null)
//                    {
//                        stream2.Close();
//                    }
//                }
//            }
//            xs.Add(schemaSerializable);
//            return type;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        private void InitClass()
//        {
//            this.columncCmpName = new DataColumn("cCmpName", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncCmpName);
//            this.columncMainCategory = new DataColumn("cMainCategory", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncMainCategory);
//            this.columncDes = new DataColumn("cDes", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncDes);
//            this.columncArticle = new DataColumn("cArticle", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncArticle);
//            this.columncDimen = new DataColumn("cDimen", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncDimen);
//            this.columncColour = new DataColumn("cColour", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncColour);
//            this.columncSize1 = new DataColumn("cSize1", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncSize1);
//            this.columncBrand_Name = new DataColumn("cBrand_Name", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncBrand_Name);
//            this.columncUnitDes = new DataColumn("cUnitDes", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncUnitDes);
//            this.columnnItemBalQty = new DataColumn("nItemBalQty", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnnItemBalQty);
//            this.columnReordLvl = new DataColumn("ReordLvl", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnReordLvl);
//            this.columnReOrdQty = new DataColumn("ReOrdQty", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnReOrdQty);
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        internal void InitVars()
//        {
//            this.columncCmpName = base.Columns["cCmpName"];
//            this.columncMainCategory = base.Columns["cMainCategory"];
//            this.columncDes = base.Columns["cDes"];
//            this.columncArticle = base.Columns["cArticle"];
//            this.columncDimen = base.Columns["cDimen"];
//            this.columncColour = base.Columns["cColour"];
//            this.columncSize1 = base.Columns["cSize1"];
//            this.columncBrand_Name = base.Columns["cBrand_Name"];
//            this.columncUnitDes = base.Columns["cUnitDes"];
//            this.columnnItemBalQty = base.Columns["nItemBalQty"];
//            this.columnReordLvl = base.Columns["ReordLvl"];
//            this.columnReOrdQty = base.Columns["ReOrdQty"];
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.ReOrdErRow NewReOrdErRow() =>
//            ((Inventory.ReOrdErRow)base.NewRow());

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) =>
//            new Inventory.ReOrdErRow(builder);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowChanged(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanged(e);
//            if (this.ReOrdErRowChanged != null)
//            {
//                this.ReOrdErRowChanged(this, new Inventory.ReOrdErRowChangeEvent((Inventory.ReOrdErRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowChanging(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanging(e);
//            if (this.ReOrdErRowChanging != null)
//            {
//                this.ReOrdErRowChanging(this, new Inventory.ReOrdErRowChangeEvent((Inventory.ReOrdErRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowDeleted(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleted(e);
//            if (this.ReOrdErRowDeleted != null)
//            {
//                this.ReOrdErRowDeleted(this, new Inventory.ReOrdErRowChangeEvent((Inventory.ReOrdErRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowDeleting(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleting(e);
//            if (this.ReOrdErRowDeleting != null)
//            {
//                this.ReOrdErRowDeleting(this, new Inventory.ReOrdErRowChangeEvent((Inventory.ReOrdErRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void RemoveReOrdErRow(Inventory.ReOrdErRow row)
//        {
//            base.Rows.Remove(row);
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cArticleColumn =>
//            this.columncArticle;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cBrand_NameColumn =>
//            this.columncBrand_Name;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cCmpNameColumn =>
//            this.columncCmpName;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cColourColumn =>
//            this.columncColour;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cDesColumn =>
//            this.columncDes;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cDimenColumn =>
//            this.columncDimen;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cMainCategoryColumn =>
//            this.columncMainCategory;

//        [Browsable(false), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public int Count =>
//            base.Rows.Count;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cSize1Column =>
//            this.columncSize1;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cUnitDesColumn =>
//            this.columncUnitDes;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.ReOrdErRow this[int index] =>
//            ((Inventory.ReOrdErRow)base.Rows[index]);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn nItemBalQtyColumn =>
//            this.columnnItemBalQty;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn ReordLvlColumn =>
//            this.columnReordLvl;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn ReOrdQtyColumn =>
//            this.columnReOrdQty;
//    }

//    public class ReOrdErRow : DataRow
//    {
//        private Inventory.ReOrdErDataTable tableReOrdEr;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal ReOrdErRow(DataRowBuilder rb) : base(rb)
//        {
//            this.tableReOrdEr = (Inventory.ReOrdErDataTable)base.Table;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscArticleNull() =>
//            base.IsNull(this.tableReOrdEr.cArticleColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscBrand_NameNull() =>
//            base.IsNull(this.tableReOrdEr.cBrand_NameColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscCmpNameNull() =>
//            base.IsNull(this.tableReOrdEr.cCmpNameColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscColourNull() =>
//            base.IsNull(this.tableReOrdEr.cColourColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscDesNull() =>
//            base.IsNull(this.tableReOrdEr.cDesColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscDimenNull() =>
//            base.IsNull(this.tableReOrdEr.cDimenColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscMainCategoryNull() =>
//            base.IsNull(this.tableReOrdEr.cMainCategoryColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscSize1Null() =>
//            base.IsNull(this.tableReOrdEr.cSize1Column);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscUnitDesNull() =>
//            base.IsNull(this.tableReOrdEr.cUnitDesColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsnItemBalQtyNull() =>
//            base.IsNull(this.tableReOrdEr.nItemBalQtyColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsReordLvlNull() =>
//            base.IsNull(this.tableReOrdEr.ReordLvlColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsReOrdQtyNull() =>
//            base.IsNull(this.tableReOrdEr.ReOrdQtyColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcArticleNull()
//        {
//            base[this.tableReOrdEr.cArticleColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcBrand_NameNull()
//        {
//            base[this.tableReOrdEr.cBrand_NameColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcCmpNameNull()
//        {
//            base[this.tableReOrdEr.cCmpNameColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcColourNull()
//        {
//            base[this.tableReOrdEr.cColourColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcDesNull()
//        {
//            base[this.tableReOrdEr.cDesColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcDimenNull()
//        {
//            base[this.tableReOrdEr.cDimenColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcMainCategoryNull()
//        {
//            base[this.tableReOrdEr.cMainCategoryColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcSize1Null()
//        {
//            base[this.tableReOrdEr.cSize1Column] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcUnitDesNull()
//        {
//            base[this.tableReOrdEr.cUnitDesColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetnItemBalQtyNull()
//        {
//            base[this.tableReOrdEr.nItemBalQtyColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetReordLvlNull()
//        {
//            base[this.tableReOrdEr.ReordLvlColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetReOrdQtyNull()
//        {
//            base[this.tableReOrdEr.ReOrdQtyColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cArticle
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableReOrdEr.cArticleColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cArticle' in table 'ReOrdEr' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableReOrdEr.cArticleColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cBrand_Name
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableReOrdEr.cBrand_NameColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cBrand_Name' in table 'ReOrdEr' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableReOrdEr.cBrand_NameColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cCmpName
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableReOrdEr.cCmpNameColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cCmpName' in table 'ReOrdEr' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableReOrdEr.cCmpNameColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cColour
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableReOrdEr.cColourColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cColour' in table 'ReOrdEr' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableReOrdEr.cColourColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cDes
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableReOrdEr.cDesColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cDes' in table 'ReOrdEr' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableReOrdEr.cDesColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cDimen
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableReOrdEr.cDimenColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cDimen' in table 'ReOrdEr' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableReOrdEr.cDimenColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cMainCategory
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableReOrdEr.cMainCategoryColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cMainCategory' in table 'ReOrdEr' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableReOrdEr.cMainCategoryColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cSize1
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableReOrdEr.cSize1Column];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cSize1' in table 'ReOrdEr' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableReOrdEr.cSize1Column] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cUnitDes
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableReOrdEr.cUnitDesColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cUnitDes' in table 'ReOrdEr' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableReOrdEr.cUnitDesColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public decimal nItemBalQty
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableReOrdEr.nItemBalQtyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nItemBalQty' in table 'ReOrdEr' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableReOrdEr.nItemBalQtyColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public decimal ReordLvl
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableReOrdEr.ReordLvlColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'ReordLvl' in table 'ReOrdEr' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableReOrdEr.ReordLvlColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public decimal ReOrdQty
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableReOrdEr.ReOrdQtyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'ReOrdQty' in table 'ReOrdEr' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableReOrdEr.ReOrdQtyColumn] = value;
//            }
//        }
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public class ReOrdErRowChangeEvent : EventArgs
//    {
//        private DataRowAction eventAction;
//        private Inventory.ReOrdErRow eventRow;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public ReOrdErRowChangeEvent(Inventory.ReOrdErRow row, DataRowAction action)
//        {
//            this.eventRow = row;
//            this.eventAction = action;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataRowAction Action =>
//            this.eventAction;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.ReOrdErRow Row =>
//            this.eventRow;
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public delegate void ReOrdErRowChangeEventHandler(object sender, Inventory.ReOrdErRowChangeEvent e);

//    [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
//    public class RequestreportDataTable : TypedTableBase<Inventory.RequestreportRow>
//    {
//        private DataColumn columncArticle;
//        private DataColumn columncCmpName;
//        private DataColumn columncColour;
//        private DataColumn columncCurType;
//        private DataColumn columncDeptname;
//        private DataColumn columncDes;
//        private DataColumn columncDimen;
//        private DataColumn columncMainCategory;
//        private DataColumn columncSection_Description;
//        private DataColumn columncSize1;
//        private DataColumn columndReqQty;
//        private DataColumn columndUnitPrice;
//        private DataColumn columndValue;
//        private DataColumn columnFP_Status;
//        private DataColumn columnnRequest_No;
//        private DataColumn columnRemarks;
//        private DataColumn columnReq_Appdt;
//        private DataColumn columnreqappby;
//        private DataColumn columnReqCreatedby;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.RequestreportRowChangeEventHandler RequestreportRowChanged;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.RequestreportRowChangeEventHandler RequestreportRowChanging;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.RequestreportRowChangeEventHandler RequestreportRowDeleted;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.RequestreportRowChangeEventHandler RequestreportRowDeleting;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public RequestreportDataTable()
//        {
//            base.TableName = "Requestreport";
//            this.BeginInit();
//            this.InitClass();
//            this.EndInit();
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal RequestreportDataTable(DataTable table)
//        {
//            base.TableName = table.TableName;
//            if (table.CaseSensitive != table.DataSet.CaseSensitive)
//            {
//                base.CaseSensitive = table.CaseSensitive;
//            }
//            if (table.Locale.ToString() != table.DataSet.Locale.ToString())
//            {
//                base.Locale = table.Locale;
//            }
//            if (table.Namespace != table.DataSet.Namespace)
//            {
//                base.Namespace = table.Namespace;
//            }
//            base.Prefix = table.Prefix;
//            base.MinimumCapacity = table.MinimumCapacity;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected RequestreportDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
//        {
//            this.InitVars();
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void AddRequestreportRow(Inventory.RequestreportRow row)
//        {
//            base.Rows.Add(row);
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.RequestreportRow AddRequestreportRow(string cMainCategory, string cDes, string cColour, string cSize1, string cArticle, string cDimen, decimal dReqQty, decimal dUnitPrice, decimal dValue, string cCmpName, string cDeptname, string cSection_Description, int nRequest_No, string cCurType, string ReqCreatedby, string reqappby, DateTime Req_Appdt, string FP_Status, string Remarks)
//        {
//            Inventory.RequestreportRow row = (Inventory.RequestreportRow)base.NewRow();
//            row.ItemArray = new object[] {
//                cMainCategory, cDes, cColour, cSize1, cArticle, cDimen, dReqQty, dUnitPrice, dValue, cCmpName, cDeptname, cSection_Description, nRequest_No, cCurType, ReqCreatedby, reqappby,
//                Req_Appdt, FP_Status, Remarks
//            };
//            base.Rows.Add(row);
//            return row;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public override DataTable Clone()
//        {
//            Inventory.RequestreportDataTable table = (Inventory.RequestreportDataTable)base.Clone();
//            table.InitVars();
//            return table;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override DataTable CreateInstance() =>
//            new Inventory.RequestreportDataTable();

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override Type GetRowType() =>
//            typeof(Inventory.RequestreportRow);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
//        {
//            XmlSchemaComplexType type = new XmlSchemaComplexType();
//            XmlSchemaSequence sequence = new XmlSchemaSequence();
//            Inventory inventory = new Inventory();
//            XmlSchemaAny item = new XmlSchemaAny
//            {
//                Namespace = "http://www.w3.org/2001/XMLSchema",
//                MinOccurs = 0M,
//                MaxOccurs = 79228162514264337593543950335M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(item);
//            XmlSchemaAny any2 = new XmlSchemaAny
//            {
//                Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
//                MinOccurs = 1M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(any2);
//            XmlSchemaAttribute attribute = new XmlSchemaAttribute
//            {
//                Name = "namespace",
//                FixedValue = inventory.Namespace
//            };
//            type.Attributes.Add(attribute);
//            XmlSchemaAttribute attribute2 = new XmlSchemaAttribute
//            {
//                Name = "tableTypeName",
//                FixedValue = "RequestreportDataTable"
//            };
//            type.Attributes.Add(attribute2);
//            type.Particle = sequence;
//            XmlSchema schemaSerializable = inventory.GetSchemaSerializable();
//            if (xs.Contains(schemaSerializable.TargetNamespace))
//            {
//                MemoryStream stream = new MemoryStream();
//                MemoryStream stream2 = new MemoryStream();
//                try
//                {
//                    XmlSchema current = null;
//                    schemaSerializable.Write(stream);
//                    IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
//                    while (enumerator.MoveNext())
//                    {
//                        current = (XmlSchema)enumerator.Current;
//                        stream2.SetLength(0L);
//                        current.Write(stream2);
//                        if (stream.Length == stream2.Length)
//                        {
//                            stream.Position = 0L;
//                            stream2.Position = 0L;
//                            while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
//                            {
//                            }
//                            if (stream.Position == stream.Length)
//                            {
//                                return type;
//                            }
//                        }
//                    }
//                }
//                finally
//                {
//                    if (stream != null)
//                    {
//                        stream.Close();
//                    }
//                    if (stream2 != null)
//                    {
//                        stream2.Close();
//                    }
//                }
//            }
//            xs.Add(schemaSerializable);
//            return type;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        private void InitClass()
//        {
//            this.columncMainCategory = new DataColumn("cMainCategory", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncMainCategory);
//            this.columncDes = new DataColumn("cDes", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncDes);
//            this.columncColour = new DataColumn("cColour", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncColour);
//            this.columncSize1 = new DataColumn("cSize1", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncSize1);
//            this.columncArticle = new DataColumn("cArticle", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncArticle);
//            this.columncDimen = new DataColumn("cDimen", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncDimen);
//            this.columndReqQty = new DataColumn("dReqQty", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columndReqQty);
//            this.columndUnitPrice = new DataColumn("dUnitPrice", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columndUnitPrice);
//            this.columndValue = new DataColumn("dValue", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columndValue);
//            this.columncCmpName = new DataColumn("cCmpName", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncCmpName);
//            this.columncDeptname = new DataColumn("cDeptname", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncDeptname);
//            this.columncSection_Description = new DataColumn("cSection_Description", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncSection_Description);
//            this.columnnRequest_No = new DataColumn("nRequest_No", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnnRequest_No);
//            this.columncCurType = new DataColumn("cCurType", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncCurType);
//            this.columnReqCreatedby = new DataColumn("ReqCreatedby", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columnReqCreatedby);
//            this.columnreqappby = new DataColumn("reqappby", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columnreqappby);
//            this.columnReq_Appdt = new DataColumn("Req_Appdt", typeof(DateTime), null, MappingType.Element);
//            base.Columns.Add(this.columnReq_Appdt);
//            this.columnFP_Status = new DataColumn("FP_Status", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columnFP_Status);
//            this.columnRemarks = new DataColumn("Remarks", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columnRemarks);
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        internal void InitVars()
//        {
//            this.columncMainCategory = base.Columns["cMainCategory"];
//            this.columncDes = base.Columns["cDes"];
//            this.columncColour = base.Columns["cColour"];
//            this.columncSize1 = base.Columns["cSize1"];
//            this.columncArticle = base.Columns["cArticle"];
//            this.columncDimen = base.Columns["cDimen"];
//            this.columndReqQty = base.Columns["dReqQty"];
//            this.columndUnitPrice = base.Columns["dUnitPrice"];
//            this.columndValue = base.Columns["dValue"];
//            this.columncCmpName = base.Columns["cCmpName"];
//            this.columncDeptname = base.Columns["cDeptname"];
//            this.columncSection_Description = base.Columns["cSection_Description"];
//            this.columnnRequest_No = base.Columns["nRequest_No"];
//            this.columncCurType = base.Columns["cCurType"];
//            this.columnReqCreatedby = base.Columns["ReqCreatedby"];
//            this.columnreqappby = base.Columns["reqappby"];
//            this.columnReq_Appdt = base.Columns["Req_Appdt"];
//            this.columnFP_Status = base.Columns["FP_Status"];
//            this.columnRemarks = base.Columns["Remarks"];
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.RequestreportRow NewRequestreportRow() =>
//            ((Inventory.RequestreportRow)base.NewRow());

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) =>
//            new Inventory.RequestreportRow(builder);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowChanged(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanged(e);
//            if (this.RequestreportRowChanged != null)
//            {
//                this.RequestreportRowChanged(this, new Inventory.RequestreportRowChangeEvent((Inventory.RequestreportRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowChanging(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanging(e);
//            if (this.RequestreportRowChanging != null)
//            {
//                this.RequestreportRowChanging(this, new Inventory.RequestreportRowChangeEvent((Inventory.RequestreportRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowDeleted(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleted(e);
//            if (this.RequestreportRowDeleted != null)
//            {
//                this.RequestreportRowDeleted(this, new Inventory.RequestreportRowChangeEvent((Inventory.RequestreportRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowDeleting(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleting(e);
//            if (this.RequestreportRowDeleting != null)
//            {
//                this.RequestreportRowDeleting(this, new Inventory.RequestreportRowChangeEvent((Inventory.RequestreportRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void RemoveRequestreportRow(Inventory.RequestreportRow row)
//        {
//            base.Rows.Remove(row);
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cArticleColumn =>
//            this.columncArticle;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cCmpNameColumn =>
//            this.columncCmpName;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cColourColumn =>
//            this.columncColour;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cCurTypeColumn =>
//            this.columncCurType;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cDeptnameColumn =>
//            this.columncDeptname;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cDesColumn =>
//            this.columncDes;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cDimenColumn =>
//            this.columncDimen;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cMainCategoryColumn =>
//            this.columncMainCategory;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
//        public int Count =>
//            base.Rows.Count;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cSection_DescriptionColumn =>
//            this.columncSection_Description;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cSize1Column =>
//            this.columncSize1;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn dReqQtyColumn =>
//            this.columndReqQty;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn dUnitPriceColumn =>
//            this.columndUnitPrice;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn dValueColumn =>
//            this.columndValue;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn FP_StatusColumn =>
//            this.columnFP_Status;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.RequestreportRow this[int index] =>
//            ((Inventory.RequestreportRow)base.Rows[index]);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn nRequest_NoColumn =>
//            this.columnnRequest_No;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn RemarksColumn =>
//            this.columnRemarks;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn Req_AppdtColumn =>
//            this.columnReq_Appdt;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn reqappbyColumn =>
//            this.columnreqappby;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn ReqCreatedbyColumn =>
//            this.columnReqCreatedby;
//    }

//    public class RequestreportRow : DataRow
//    {
//        private Inventory.RequestreportDataTable tableRequestreport;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal RequestreportRow(DataRowBuilder rb) : base(rb)
//        {
//            this.tableRequestreport = (Inventory.RequestreportDataTable)base.Table;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscArticleNull() =>
//            base.IsNull(this.tableRequestreport.cArticleColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscCmpNameNull() =>
//            base.IsNull(this.tableRequestreport.cCmpNameColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscColourNull() =>
//            base.IsNull(this.tableRequestreport.cColourColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscCurTypeNull() =>
//            base.IsNull(this.tableRequestreport.cCurTypeColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscDeptnameNull() =>
//            base.IsNull(this.tableRequestreport.cDeptnameColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscDesNull() =>
//            base.IsNull(this.tableRequestreport.cDesColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscDimenNull() =>
//            base.IsNull(this.tableRequestreport.cDimenColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscMainCategoryNull() =>
//            base.IsNull(this.tableRequestreport.cMainCategoryColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscSection_DescriptionNull() =>
//            base.IsNull(this.tableRequestreport.cSection_DescriptionColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscSize1Null() =>
//            base.IsNull(this.tableRequestreport.cSize1Column);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsdReqQtyNull() =>
//            base.IsNull(this.tableRequestreport.dReqQtyColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsdUnitPriceNull() =>
//            base.IsNull(this.tableRequestreport.dUnitPriceColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsdValueNull() =>
//            base.IsNull(this.tableRequestreport.dValueColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsFP_StatusNull() =>
//            base.IsNull(this.tableRequestreport.FP_StatusColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsnRequest_NoNull() =>
//            base.IsNull(this.tableRequestreport.nRequest_NoColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsRemarksNull() =>
//            base.IsNull(this.tableRequestreport.RemarksColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsReq_AppdtNull() =>
//            base.IsNull(this.tableRequestreport.Req_AppdtColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsreqappbyNull() =>
//            base.IsNull(this.tableRequestreport.reqappbyColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsReqCreatedbyNull() =>
//            base.IsNull(this.tableRequestreport.ReqCreatedbyColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcArticleNull()
//        {
//            base[this.tableRequestreport.cArticleColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcCmpNameNull()
//        {
//            base[this.tableRequestreport.cCmpNameColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcColourNull()
//        {
//            base[this.tableRequestreport.cColourColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcCurTypeNull()
//        {
//            base[this.tableRequestreport.cCurTypeColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcDeptnameNull()
//        {
//            base[this.tableRequestreport.cDeptnameColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcDesNull()
//        {
//            base[this.tableRequestreport.cDesColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcDimenNull()
//        {
//            base[this.tableRequestreport.cDimenColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcMainCategoryNull()
//        {
//            base[this.tableRequestreport.cMainCategoryColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcSection_DescriptionNull()
//        {
//            base[this.tableRequestreport.cSection_DescriptionColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcSize1Null()
//        {
//            base[this.tableRequestreport.cSize1Column] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetdReqQtyNull()
//        {
//            base[this.tableRequestreport.dReqQtyColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetdUnitPriceNull()
//        {
//            base[this.tableRequestreport.dUnitPriceColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetdValueNull()
//        {
//            base[this.tableRequestreport.dValueColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetFP_StatusNull()
//        {
//            base[this.tableRequestreport.FP_StatusColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnRequest_NoNull()
//        {
//            base[this.tableRequestreport.nRequest_NoColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetRemarksNull()
//        {
//            base[this.tableRequestreport.RemarksColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetReq_AppdtNull()
//        {
//            base[this.tableRequestreport.Req_AppdtColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetreqappbyNull()
//        {
//            base[this.tableRequestreport.reqappbyColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetReqCreatedbyNull()
//        {
//            base[this.tableRequestreport.ReqCreatedbyColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cArticle
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableRequestreport.cArticleColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cArticle' in table 'Requestreport' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableRequestreport.cArticleColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cCmpName
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableRequestreport.cCmpNameColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cCmpName' in table 'Requestreport' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableRequestreport.cCmpNameColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cColour
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableRequestreport.cColourColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cColour' in table 'Requestreport' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableRequestreport.cColourColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cCurType
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableRequestreport.cCurTypeColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cCurType' in table 'Requestreport' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableRequestreport.cCurTypeColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cDeptname
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableRequestreport.cDeptnameColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cDeptname' in table 'Requestreport' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableRequestreport.cDeptnameColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cDes
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableRequestreport.cDesColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cDes' in table 'Requestreport' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableRequestreport.cDesColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cDimen
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableRequestreport.cDimenColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cDimen' in table 'Requestreport' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableRequestreport.cDimenColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cMainCategory
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableRequestreport.cMainCategoryColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cMainCategory' in table 'Requestreport' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableRequestreport.cMainCategoryColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cSection_Description
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableRequestreport.cSection_DescriptionColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cSection_Description' in table 'Requestreport' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableRequestreport.cSection_DescriptionColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cSize1
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableRequestreport.cSize1Column];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cSize1' in table 'Requestreport' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableRequestreport.cSize1Column] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public decimal dReqQty
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableRequestreport.dReqQtyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'dReqQty' in table 'Requestreport' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableRequestreport.dReqQtyColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public decimal dUnitPrice
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableRequestreport.dUnitPriceColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'dUnitPrice' in table 'Requestreport' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableRequestreport.dUnitPriceColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public decimal dValue
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableRequestreport.dValueColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'dValue' in table 'Requestreport' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableRequestreport.dValueColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string FP_Status
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableRequestreport.FP_StatusColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'FP_Status' in table 'Requestreport' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableRequestreport.FP_StatusColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public int nRequest_No
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableRequestreport.nRequest_NoColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nRequest_No' in table 'Requestreport' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableRequestreport.nRequest_NoColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string Remarks
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableRequestreport.RemarksColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'Remarks' in table 'Requestreport' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableRequestreport.RemarksColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DateTime Req_Appdt
//        {
//            get
//            {
//                DateTime time;
//                try
//                {
//                    time = (DateTime)base[this.tableRequestreport.Req_AppdtColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'Req_Appdt' in table 'Requestreport' is DBNull.", exception);
//                }
//                return time;
//            }
//            set
//            {
//                base[this.tableRequestreport.Req_AppdtColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string reqappby
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableRequestreport.reqappbyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'reqappby' in table 'Requestreport' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableRequestreport.reqappbyColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string ReqCreatedby
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableRequestreport.ReqCreatedbyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'ReqCreatedby' in table 'Requestreport' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableRequestreport.ReqCreatedbyColumn] = value;
//            }
//        }
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public class RequestreportRowChangeEvent : EventArgs
//    {
//        private DataRowAction eventAction;
//        private Inventory.RequestreportRow eventRow;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public RequestreportRowChangeEvent(Inventory.RequestreportRow row, DataRowAction action)
//        {
//            this.eventRow = row;
//            this.eventAction = action;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataRowAction Action =>
//            this.eventAction;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.RequestreportRow Row =>
//            this.eventRow;
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public delegate void RequestreportRowChangeEventHandler(object sender, Inventory.RequestreportRowChangeEvent e);

//    [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
//    public class RPT_SignDataTable : TypedTableBase<Inventory.RPT_SignRow>
//    {
//        private DataColumn columnsigntr;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.RPT_SignRowChangeEventHandler RPT_SignRowChanged;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.RPT_SignRowChangeEventHandler RPT_SignRowChanging;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.RPT_SignRowChangeEventHandler RPT_SignRowDeleted;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.RPT_SignRowChangeEventHandler RPT_SignRowDeleting;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public RPT_SignDataTable()
//        {
//            base.TableName = "RPT_Sign";
//            this.BeginInit();
//            this.InitClass();
//            this.EndInit();
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        internal RPT_SignDataTable(DataTable table)
//        {
//            base.TableName = table.TableName;
//            if (table.CaseSensitive != table.DataSet.CaseSensitive)
//            {
//                base.CaseSensitive = table.CaseSensitive;
//            }
//            if (table.Locale.ToString() != table.DataSet.Locale.ToString())
//            {
//                base.Locale = table.Locale;
//            }
//            if (table.Namespace != table.DataSet.Namespace)
//            {
//                base.Namespace = table.Namespace;
//            }
//            base.Prefix = table.Prefix;
//            base.MinimumCapacity = table.MinimumCapacity;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected RPT_SignDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
//        {
//            this.InitVars();
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public Inventory.RPT_SignRow AddRPT_SignRow(byte[] signtr)
//        {
//            Inventory.RPT_SignRow row = (Inventory.RPT_SignRow)base.NewRow();
//            row.ItemArray = new object[] { signtr };
//            base.Rows.Add(row);
//            return row;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void AddRPT_SignRow(Inventory.RPT_SignRow row)
//        {
//            base.Rows.Add(row);
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public override DataTable Clone()
//        {
//            Inventory.RPT_SignDataTable table = (Inventory.RPT_SignDataTable)base.Clone();
//            table.InitVars();
//            return table;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override DataTable CreateInstance() =>
//            new Inventory.RPT_SignDataTable();

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override Type GetRowType() =>
//            typeof(Inventory.RPT_SignRow);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
//        {
//            XmlSchemaComplexType type = new XmlSchemaComplexType();
//            XmlSchemaSequence sequence = new XmlSchemaSequence();
//            Inventory inventory = new Inventory();
//            XmlSchemaAny item = new XmlSchemaAny
//            {
//                Namespace = "http://www.w3.org/2001/XMLSchema",
//                MinOccurs = 0M,
//                MaxOccurs = 79228162514264337593543950335M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(item);
//            XmlSchemaAny any2 = new XmlSchemaAny
//            {
//                Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
//                MinOccurs = 1M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(any2);
//            XmlSchemaAttribute attribute = new XmlSchemaAttribute
//            {
//                Name = "namespace",
//                FixedValue = inventory.Namespace
//            };
//            type.Attributes.Add(attribute);
//            XmlSchemaAttribute attribute2 = new XmlSchemaAttribute
//            {
//                Name = "tableTypeName",
//                FixedValue = "RPT_SignDataTable"
//            };
//            type.Attributes.Add(attribute2);
//            type.Particle = sequence;
//            XmlSchema schemaSerializable = inventory.GetSchemaSerializable();
//            if (xs.Contains(schemaSerializable.TargetNamespace))
//            {
//                MemoryStream stream = new MemoryStream();
//                MemoryStream stream2 = new MemoryStream();
//                try
//                {
//                    XmlSchema current = null;
//                    schemaSerializable.Write(stream);
//                    IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
//                    while (enumerator.MoveNext())
//                    {
//                        current = (XmlSchema)enumerator.Current;
//                        stream2.SetLength(0L);
//                        current.Write(stream2);
//                        if (stream.Length == stream2.Length)
//                        {
//                            stream.Position = 0L;
//                            stream2.Position = 0L;
//                            while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
//                            {
//                            }
//                            if (stream.Position == stream.Length)
//                            {
//                                return type;
//                            }
//                        }
//                    }
//                }
//                finally
//                {
//                    if (stream != null)
//                    {
//                        stream.Close();
//                    }
//                    if (stream2 != null)
//                    {
//                        stream2.Close();
//                    }
//                }
//            }
//            xs.Add(schemaSerializable);
//            return type;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        private void InitClass()
//        {
//            this.columnsigntr = new DataColumn("signtr", typeof(byte[]), null, MappingType.Element);
//            base.Columns.Add(this.columnsigntr);
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal void InitVars()
//        {
//            this.columnsigntr = base.Columns["signtr"];
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) =>
//            new Inventory.RPT_SignRow(builder);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public Inventory.RPT_SignRow NewRPT_SignRow() =>
//            ((Inventory.RPT_SignRow)base.NewRow());

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowChanged(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanged(e);
//            if (this.RPT_SignRowChanged != null)
//            {
//                this.RPT_SignRowChanged(this, new Inventory.RPT_SignRowChangeEvent((Inventory.RPT_SignRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowChanging(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanging(e);
//            if (this.RPT_SignRowChanging != null)
//            {
//                this.RPT_SignRowChanging(this, new Inventory.RPT_SignRowChangeEvent((Inventory.RPT_SignRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowDeleted(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleted(e);
//            if (this.RPT_SignRowDeleted != null)
//            {
//                this.RPT_SignRowDeleted(this, new Inventory.RPT_SignRowChangeEvent((Inventory.RPT_SignRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowDeleting(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleting(e);
//            if (this.RPT_SignRowDeleting != null)
//            {
//                this.RPT_SignRowDeleting(this, new Inventory.RPT_SignRowChangeEvent((Inventory.RPT_SignRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void RemoveRPT_SignRow(Inventory.RPT_SignRow row)
//        {
//            base.Rows.Remove(row);
//        }

//        [Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public int Count =>
//            base.Rows.Count;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.RPT_SignRow this[int index] =>
//            ((Inventory.RPT_SignRow)base.Rows[index]);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn signtrColumn =>
//            this.columnsigntr;
//    }

//    public class RPT_SignRow : DataRow
//    {
//        private Inventory.RPT_SignDataTable tableRPT_Sign;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal RPT_SignRow(DataRowBuilder rb) : base(rb)
//        {
//            this.tableRPT_Sign = (Inventory.RPT_SignDataTable)base.Table;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IssigntrNull() =>
//            base.IsNull(this.tableRPT_Sign.signtrColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetsigntrNull()
//        {
//            base[this.tableRPT_Sign.signtrColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public byte[] signtr
//        {
//            get
//            {
//                byte[] buffer;
//                try
//                {
//                    buffer = (byte[])base[this.tableRPT_Sign.signtrColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'signtr' in table 'RPT_Sign' is DBNull.", exception);
//                }
//                return buffer;
//            }
//            set
//            {
//                base[this.tableRPT_Sign.signtrColumn] = value;
//            }
//        }
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public class RPT_SignRowChangeEvent : EventArgs
//    {
//        private DataRowAction eventAction;
//        private Inventory.RPT_SignRow eventRow;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public RPT_SignRowChangeEvent(Inventory.RPT_SignRow row, DataRowAction action)
//        {
//            this.eventRow = row;
//            this.eventAction = action;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataRowAction Action =>
//            this.eventAction;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.RPT_SignRow Row =>
//            this.eventRow;
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public delegate void RPT_SignRowChangeEventHandler(object sender, Inventory.RPT_SignRowChangeEvent e);

//    [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
//    public class rptimgDataTable : TypedTableBase<Inventory.rptimgRow>
//    {
//        private DataColumn columnlgo;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.rptimgRowChangeEventHandler rptimgRowChanged;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.rptimgRowChangeEventHandler rptimgRowChanging;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.rptimgRowChangeEventHandler rptimgRowDeleted;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.rptimgRowChangeEventHandler rptimgRowDeleting;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public rptimgDataTable()
//        {
//            base.TableName = "rptimg";
//            this.BeginInit();
//            this.InitClass();
//            this.EndInit();
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal rptimgDataTable(DataTable table)
//        {
//            base.TableName = table.TableName;
//            if (table.CaseSensitive != table.DataSet.CaseSensitive)
//            {
//                base.CaseSensitive = table.CaseSensitive;
//            }
//            if (table.Locale.ToString() != table.DataSet.Locale.ToString())
//            {
//                base.Locale = table.Locale;
//            }
//            if (table.Namespace != table.DataSet.Namespace)
//            {
//                base.Namespace = table.Namespace;
//            }
//            base.Prefix = table.Prefix;
//            base.MinimumCapacity = table.MinimumCapacity;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected rptimgDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
//        {
//            this.InitVars();
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.rptimgRow AddrptimgRow(byte[] lgo)
//        {
//            Inventory.rptimgRow row = (Inventory.rptimgRow)base.NewRow();
//            row.ItemArray = new object[] { lgo };
//            base.Rows.Add(row);
//            return row;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void AddrptimgRow(Inventory.rptimgRow row)
//        {
//            base.Rows.Add(row);
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public override DataTable Clone()
//        {
//            Inventory.rptimgDataTable table = (Inventory.rptimgDataTable)base.Clone();
//            table.InitVars();
//            return table;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override DataTable CreateInstance() =>
//            new Inventory.rptimgDataTable();

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override Type GetRowType() =>
//            typeof(Inventory.rptimgRow);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
//        {
//            XmlSchemaComplexType type = new XmlSchemaComplexType();
//            XmlSchemaSequence sequence = new XmlSchemaSequence();
//            Inventory inventory = new Inventory();
//            XmlSchemaAny item = new XmlSchemaAny
//            {
//                Namespace = "http://www.w3.org/2001/XMLSchema",
//                MinOccurs = 0M,
//                MaxOccurs = 79228162514264337593543950335M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(item);
//            XmlSchemaAny any2 = new XmlSchemaAny
//            {
//                Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
//                MinOccurs = 1M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(any2);
//            XmlSchemaAttribute attribute = new XmlSchemaAttribute
//            {
//                Name = "namespace",
//                FixedValue = inventory.Namespace
//            };
//            type.Attributes.Add(attribute);
//            XmlSchemaAttribute attribute2 = new XmlSchemaAttribute
//            {
//                Name = "tableTypeName",
//                FixedValue = "rptimgDataTable"
//            };
//            type.Attributes.Add(attribute2);
//            type.Particle = sequence;
//            XmlSchema schemaSerializable = inventory.GetSchemaSerializable();
//            if (xs.Contains(schemaSerializable.TargetNamespace))
//            {
//                MemoryStream stream = new MemoryStream();
//                MemoryStream stream2 = new MemoryStream();
//                try
//                {
//                    XmlSchema current = null;
//                    schemaSerializable.Write(stream);
//                    IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
//                    while (enumerator.MoveNext())
//                    {
//                        current = (XmlSchema)enumerator.Current;
//                        stream2.SetLength(0L);
//                        current.Write(stream2);
//                        if (stream.Length == stream2.Length)
//                        {
//                            stream.Position = 0L;
//                            stream2.Position = 0L;
//                            while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
//                            {
//                            }
//                            if (stream.Position == stream.Length)
//                            {
//                                return type;
//                            }
//                        }
//                    }
//                }
//                finally
//                {
//                    if (stream != null)
//                    {
//                        stream.Close();
//                    }
//                    if (stream2 != null)
//                    {
//                        stream2.Close();
//                    }
//                }
//            }
//            xs.Add(schemaSerializable);
//            return type;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        private void InitClass()
//        {
//            this.columnlgo = new DataColumn("lgo", typeof(byte[]), null, MappingType.Element);
//            base.Columns.Add(this.columnlgo);
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal void InitVars()
//        {
//            this.columnlgo = base.Columns["lgo"];
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) =>
//            new Inventory.rptimgRow(builder);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public Inventory.rptimgRow NewrptimgRow() =>
//            ((Inventory.rptimgRow)base.NewRow());

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowChanged(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanged(e);
//            if (this.rptimgRowChanged != null)
//            {
//                this.rptimgRowChanged(this, new Inventory.rptimgRowChangeEvent((Inventory.rptimgRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowChanging(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanging(e);
//            if (this.rptimgRowChanging != null)
//            {
//                this.rptimgRowChanging(this, new Inventory.rptimgRowChangeEvent((Inventory.rptimgRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowDeleted(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleted(e);
//            if (this.rptimgRowDeleted != null)
//            {
//                this.rptimgRowDeleted(this, new Inventory.rptimgRowChangeEvent((Inventory.rptimgRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowDeleting(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleting(e);
//            if (this.rptimgRowDeleting != null)
//            {
//                this.rptimgRowDeleting(this, new Inventory.rptimgRowChangeEvent((Inventory.rptimgRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void RemoverptimgRow(Inventory.rptimgRow row)
//        {
//            base.Rows.Remove(row);
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
//        public int Count =>
//            base.Rows.Count;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public Inventory.rptimgRow this[int index] =>
//            ((Inventory.rptimgRow)base.Rows[index]);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn lgoColumn =>
//            this.columnlgo;
//    }

//    public class rptimgRow : DataRow
//    {
//        private Inventory.rptimgDataTable tablerptimg;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        internal rptimgRow(DataRowBuilder rb) : base(rb)
//        {
//            this.tablerptimg = (Inventory.rptimgDataTable)base.Table;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IslgoNull() =>
//            base.IsNull(this.tablerptimg.lgoColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetlgoNull()
//        {
//            base[this.tablerptimg.lgoColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public byte[] lgo
//        {
//            get
//            {
//                byte[] buffer;
//                try
//                {
//                    buffer = (byte[])base[this.tablerptimg.lgoColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'lgo' in table 'rptimg' is DBNull.", exception);
//                }
//                return buffer;
//            }
//            set
//            {
//                base[this.tablerptimg.lgoColumn] = value;
//            }
//        }
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public class rptimgRowChangeEvent : EventArgs
//    {
//        private DataRowAction eventAction;
//        private Inventory.rptimgRow eventRow;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public rptimgRowChangeEvent(Inventory.rptimgRow row, DataRowAction action)
//        {
//            this.eventRow = row;
//            this.eventAction = action;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataRowAction Action =>
//            this.eventAction;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public Inventory.rptimgRow Row =>
//            this.eventRow;
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public delegate void rptimgRowChangeEventHandler(object sender, Inventory.rptimgRowChangeEvent e);

//    [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
//    public class Stock_BalanceDataTable : TypedTableBase<Inventory.Stock_BalanceRow>
//    {
//        private DataColumn columncArticle;
//        private DataColumn columncColour;
//        private DataColumn columncDes;
//        private DataColumn columncDimen;
//        private DataColumn columncSize1;
//        private DataColumn columncUnitDes;
//        private DataColumn columnnItemBalQty;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.Stock_BalanceRowChangeEventHandler Stock_BalanceRowChanged;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.Stock_BalanceRowChangeEventHandler Stock_BalanceRowChanging;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.Stock_BalanceRowChangeEventHandler Stock_BalanceRowDeleted;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.Stock_BalanceRowChangeEventHandler Stock_BalanceRowDeleting;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Stock_BalanceDataTable()
//        {
//            base.TableName = "Stock Balance";
//            this.BeginInit();
//            this.InitClass();
//            this.EndInit();
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal Stock_BalanceDataTable(DataTable table)
//        {
//            base.TableName = table.TableName;
//            if (table.CaseSensitive != table.DataSet.CaseSensitive)
//            {
//                base.CaseSensitive = table.CaseSensitive;
//            }
//            if (table.Locale.ToString() != table.DataSet.Locale.ToString())
//            {
//                base.Locale = table.Locale;
//            }
//            if (table.Namespace != table.DataSet.Namespace)
//            {
//                base.Namespace = table.Namespace;
//            }
//            base.Prefix = table.Prefix;
//            base.MinimumCapacity = table.MinimumCapacity;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected Stock_BalanceDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
//        {
//            this.InitVars();
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void AddStock_BalanceRow(Inventory.Stock_BalanceRow row)
//        {
//            base.Rows.Add(row);
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.Stock_BalanceRow AddStock_BalanceRow(string cDes, string cSize1, string cColour, string cArticle, string cDimen, string cUnitDes, decimal nItemBalQty)
//        {
//            Inventory.Stock_BalanceRow row = (Inventory.Stock_BalanceRow)base.NewRow();
//            row.ItemArray = new object[] { cDes, cSize1, cColour, cArticle, cDimen, cUnitDes, nItemBalQty };
//            base.Rows.Add(row);
//            return row;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public override DataTable Clone()
//        {
//            Inventory.Stock_BalanceDataTable table = (Inventory.Stock_BalanceDataTable)base.Clone();
//            table.InitVars();
//            return table;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override DataTable CreateInstance() =>
//            new Inventory.Stock_BalanceDataTable();

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override Type GetRowType() =>
//            typeof(Inventory.Stock_BalanceRow);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
//        {
//            XmlSchemaComplexType type = new XmlSchemaComplexType();
//            XmlSchemaSequence sequence = new XmlSchemaSequence();
//            Inventory inventory = new Inventory();
//            XmlSchemaAny item = new XmlSchemaAny
//            {
//                Namespace = "http://www.w3.org/2001/XMLSchema",
//                MinOccurs = 0M,
//                MaxOccurs = 79228162514264337593543950335M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(item);
//            XmlSchemaAny any2 = new XmlSchemaAny
//            {
//                Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
//                MinOccurs = 1M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(any2);
//            XmlSchemaAttribute attribute = new XmlSchemaAttribute
//            {
//                Name = "namespace",
//                FixedValue = inventory.Namespace
//            };
//            type.Attributes.Add(attribute);
//            XmlSchemaAttribute attribute2 = new XmlSchemaAttribute
//            {
//                Name = "tableTypeName",
//                FixedValue = "Stock_BalanceDataTable"
//            };
//            type.Attributes.Add(attribute2);
//            type.Particle = sequence;
//            XmlSchema schemaSerializable = inventory.GetSchemaSerializable();
//            if (xs.Contains(schemaSerializable.TargetNamespace))
//            {
//                MemoryStream stream = new MemoryStream();
//                MemoryStream stream2 = new MemoryStream();
//                try
//                {
//                    XmlSchema current = null;
//                    schemaSerializable.Write(stream);
//                    IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
//                    while (enumerator.MoveNext())
//                    {
//                        current = (XmlSchema)enumerator.Current;
//                        stream2.SetLength(0L);
//                        current.Write(stream2);
//                        if (stream.Length == stream2.Length)
//                        {
//                            stream.Position = 0L;
//                            stream2.Position = 0L;
//                            while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
//                            {
//                            }
//                            if (stream.Position == stream.Length)
//                            {
//                                return type;
//                            }
//                        }
//                    }
//                }
//                finally
//                {
//                    if (stream != null)
//                    {
//                        stream.Close();
//                    }
//                    if (stream2 != null)
//                    {
//                        stream2.Close();
//                    }
//                }
//            }
//            xs.Add(schemaSerializable);
//            return type;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        private void InitClass()
//        {
//            this.columncDes = new DataColumn("cDes", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncDes);
//            this.columncSize1 = new DataColumn("cSize1", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncSize1);
//            this.columncColour = new DataColumn("cColour", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncColour);
//            this.columncArticle = new DataColumn("cArticle", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncArticle);
//            this.columncDimen = new DataColumn("cDimen", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncDimen);
//            this.columncUnitDes = new DataColumn("cUnitDes", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncUnitDes);
//            this.columnnItemBalQty = new DataColumn("nItemBalQty", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnnItemBalQty);
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        internal void InitVars()
//        {
//            this.columncDes = base.Columns["cDes"];
//            this.columncSize1 = base.Columns["cSize1"];
//            this.columncColour = base.Columns["cColour"];
//            this.columncArticle = base.Columns["cArticle"];
//            this.columncDimen = base.Columns["cDimen"];
//            this.columncUnitDes = base.Columns["cUnitDes"];
//            this.columnnItemBalQty = base.Columns["nItemBalQty"];
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) =>
//            new Inventory.Stock_BalanceRow(builder);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.Stock_BalanceRow NewStock_BalanceRow() =>
//            ((Inventory.Stock_BalanceRow)base.NewRow());

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowChanged(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanged(e);
//            if (this.Stock_BalanceRowChanged != null)
//            {
//                this.Stock_BalanceRowChanged(this, new Inventory.Stock_BalanceRowChangeEvent((Inventory.Stock_BalanceRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowChanging(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanging(e);
//            if (this.Stock_BalanceRowChanging != null)
//            {
//                this.Stock_BalanceRowChanging(this, new Inventory.Stock_BalanceRowChangeEvent((Inventory.Stock_BalanceRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowDeleted(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleted(e);
//            if (this.Stock_BalanceRowDeleted != null)
//            {
//                this.Stock_BalanceRowDeleted(this, new Inventory.Stock_BalanceRowChangeEvent((Inventory.Stock_BalanceRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowDeleting(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleting(e);
//            if (this.Stock_BalanceRowDeleting != null)
//            {
//                this.Stock_BalanceRowDeleting(this, new Inventory.Stock_BalanceRowChangeEvent((Inventory.Stock_BalanceRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void RemoveStock_BalanceRow(Inventory.Stock_BalanceRow row)
//        {
//            base.Rows.Remove(row);
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cArticleColumn =>
//            this.columncArticle;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cColourColumn =>
//            this.columncColour;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cDesColumn =>
//            this.columncDes;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cDimenColumn =>
//            this.columncDimen;

//        [Browsable(false), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public int Count =>
//            base.Rows.Count;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cSize1Column =>
//            this.columncSize1;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cUnitDesColumn =>
//            this.columncUnitDes;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public Inventory.Stock_BalanceRow this[int index] =>
//            ((Inventory.Stock_BalanceRow)base.Rows[index]);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn nItemBalQtyColumn =>
//            this.columnnItemBalQty;
//    }

//    public class Stock_BalanceRow : DataRow
//    {
//        private Inventory.Stock_BalanceDataTable tableStock_Balance;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal Stock_BalanceRow(DataRowBuilder rb) : base(rb)
//        {
//            this.tableStock_Balance = (Inventory.Stock_BalanceDataTable)base.Table;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscArticleNull() =>
//            base.IsNull(this.tableStock_Balance.cArticleColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscColourNull() =>
//            base.IsNull(this.tableStock_Balance.cColourColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscDesNull() =>
//            base.IsNull(this.tableStock_Balance.cDesColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscDimenNull() =>
//            base.IsNull(this.tableStock_Balance.cDimenColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscSize1Null() =>
//            base.IsNull(this.tableStock_Balance.cSize1Column);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscUnitDesNull() =>
//            base.IsNull(this.tableStock_Balance.cUnitDesColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsnItemBalQtyNull() =>
//            base.IsNull(this.tableStock_Balance.nItemBalQtyColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcArticleNull()
//        {
//            base[this.tableStock_Balance.cArticleColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcColourNull()
//        {
//            base[this.tableStock_Balance.cColourColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcDesNull()
//        {
//            base[this.tableStock_Balance.cDesColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcDimenNull()
//        {
//            base[this.tableStock_Balance.cDimenColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcSize1Null()
//        {
//            base[this.tableStock_Balance.cSize1Column] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcUnitDesNull()
//        {
//            base[this.tableStock_Balance.cUnitDesColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnItemBalQtyNull()
//        {
//            base[this.tableStock_Balance.nItemBalQtyColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cArticle
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableStock_Balance.cArticleColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cArticle' in table 'Stock Balance' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableStock_Balance.cArticleColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cColour
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableStock_Balance.cColourColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cColour' in table 'Stock Balance' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableStock_Balance.cColourColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cDes
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableStock_Balance.cDesColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cDes' in table 'Stock Balance' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableStock_Balance.cDesColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cDimen
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableStock_Balance.cDimenColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cDimen' in table 'Stock Balance' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableStock_Balance.cDimenColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cSize1
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableStock_Balance.cSize1Column];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cSize1' in table 'Stock Balance' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableStock_Balance.cSize1Column] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cUnitDes
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableStock_Balance.cUnitDesColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cUnitDes' in table 'Stock Balance' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableStock_Balance.cUnitDesColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public decimal nItemBalQty
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableStock_Balance.nItemBalQtyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nItemBalQty' in table 'Stock Balance' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableStock_Balance.nItemBalQtyColumn] = value;
//            }
//        }
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public class Stock_BalanceRowChangeEvent : EventArgs
//    {
//        private DataRowAction eventAction;
//        private Inventory.Stock_BalanceRow eventRow;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Stock_BalanceRowChangeEvent(Inventory.Stock_BalanceRow row, DataRowAction action)
//        {
//            this.eventRow = row;
//            this.eventAction = action;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataRowAction Action =>
//            this.eventAction;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.Stock_BalanceRow Row =>
//            this.eventRow;
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public delegate void Stock_BalanceRowChangeEventHandler(object sender, Inventory.Stock_BalanceRowChangeEvent e);

//    [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
//    public class StyleStatusDataTable : TypedTableBase<Inventory.StyleStatusRow>
//    {
//        private DataColumn columncArt;
//        private DataColumn columncColour;
//        private DataColumn columncDimec;
//        private DataColumn columncItemdes;
//        private DataColumn columncSize;
//        private DataColumn columncUnit;
//        private DataColumn columngrnQty;
//        private DataColumn columnnIssQty;
//        private DataColumn columnnItemBalQty;
//        private DataColumn columnnPoNum;
//        private DataColumn columnnQty;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.StyleStatusRowChangeEventHandler StyleStatusRowChanged;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.StyleStatusRowChangeEventHandler StyleStatusRowChanging;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.StyleStatusRowChangeEventHandler StyleStatusRowDeleted;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event Inventory.StyleStatusRowChangeEventHandler StyleStatusRowDeleting;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public StyleStatusDataTable()
//        {
//            base.TableName = "StyleStatus";
//            this.BeginInit();
//            this.InitClass();
//            this.EndInit();
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal StyleStatusDataTable(DataTable table)
//        {
//            base.TableName = table.TableName;
//            if (table.CaseSensitive != table.DataSet.CaseSensitive)
//            {
//                base.CaseSensitive = table.CaseSensitive;
//            }
//            if (table.Locale.ToString() != table.DataSet.Locale.ToString())
//            {
//                base.Locale = table.Locale;
//            }
//            if (table.Namespace != table.DataSet.Namespace)
//            {
//                base.Namespace = table.Namespace;
//            }
//            base.Prefix = table.Prefix;
//            base.MinimumCapacity = table.MinimumCapacity;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected StyleStatusDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
//        {
//            this.InitVars();
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void AddStyleStatusRow(Inventory.StyleStatusRow row)
//        {
//            base.Rows.Add(row);
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public Inventory.StyleStatusRow AddStyleStatusRow(int nPoNum, string cItemdes, string cSize, string cColour, string cArt, string cDimec, string cUnit, decimal nQty, decimal grnQty, decimal nIssQty, decimal nItemBalQty)
//        {
//            Inventory.StyleStatusRow row = (Inventory.StyleStatusRow)base.NewRow();
//            row.ItemArray = new object[] { nPoNum, cItemdes, cSize, cColour, cArt, cDimec, cUnit, nQty, grnQty, nIssQty, nItemBalQty };
//            base.Rows.Add(row);
//            return row;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public override DataTable Clone()
//        {
//            Inventory.StyleStatusDataTable table = (Inventory.StyleStatusDataTable)base.Clone();
//            table.InitVars();
//            return table;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override DataTable CreateInstance() =>
//            new Inventory.StyleStatusDataTable();

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override Type GetRowType() =>
//            typeof(Inventory.StyleStatusRow);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
//        {
//            XmlSchemaComplexType type = new XmlSchemaComplexType();
//            XmlSchemaSequence sequence = new XmlSchemaSequence();
//            Inventory inventory = new Inventory();
//            XmlSchemaAny item = new XmlSchemaAny
//            {
//                Namespace = "http://www.w3.org/2001/XMLSchema",
//                MinOccurs = 0M,
//                MaxOccurs = 79228162514264337593543950335M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(item);
//            XmlSchemaAny any2 = new XmlSchemaAny
//            {
//                Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
//                MinOccurs = 1M,
//                ProcessContents = XmlSchemaContentProcessing.Lax
//            };
//            sequence.Items.Add(any2);
//            XmlSchemaAttribute attribute = new XmlSchemaAttribute
//            {
//                Name = "namespace",
//                FixedValue = inventory.Namespace
//            };
//            type.Attributes.Add(attribute);
//            XmlSchemaAttribute attribute2 = new XmlSchemaAttribute
//            {
//                Name = "tableTypeName",
//                FixedValue = "StyleStatusDataTable"
//            };
//            type.Attributes.Add(attribute2);
//            type.Particle = sequence;
//            XmlSchema schemaSerializable = inventory.GetSchemaSerializable();
//            if (xs.Contains(schemaSerializable.TargetNamespace))
//            {
//                MemoryStream stream = new MemoryStream();
//                MemoryStream stream2 = new MemoryStream();
//                try
//                {
//                    XmlSchema current = null;
//                    schemaSerializable.Write(stream);
//                    IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
//                    while (enumerator.MoveNext())
//                    {
//                        current = (XmlSchema)enumerator.Current;
//                        stream2.SetLength(0L);
//                        current.Write(stream2);
//                        if (stream.Length == stream2.Length)
//                        {
//                            stream.Position = 0L;
//                            stream2.Position = 0L;
//                            while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
//                            {
//                            }
//                            if (stream.Position == stream.Length)
//                            {
//                                return type;
//                            }
//                        }
//                    }
//                }
//                finally
//                {
//                    if (stream != null)
//                    {
//                        stream.Close();
//                    }
//                    if (stream2 != null)
//                    {
//                        stream2.Close();
//                    }
//                }
//            }
//            xs.Add(schemaSerializable);
//            return type;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        private void InitClass()
//        {
//            this.columnnPoNum = new DataColumn("nPoNum", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnnPoNum);
//            this.columncItemdes = new DataColumn("cItemdes", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncItemdes);
//            this.columncSize = new DataColumn("cSize", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncSize);
//            this.columncColour = new DataColumn("cColour", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncColour);
//            this.columncArt = new DataColumn("cArt", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncArt);
//            this.columncDimec = new DataColumn("cDimec", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncDimec);
//            this.columncUnit = new DataColumn("cUnit", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncUnit);
//            this.columnnQty = new DataColumn("nQty", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnnQty);
//            this.columngrnQty = new DataColumn("grnQty", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columngrnQty);
//            this.columnnIssQty = new DataColumn("nIssQty", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnnIssQty);
//            this.columnnItemBalQty = new DataColumn("nItemBalQty", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnnItemBalQty);
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal void InitVars()
//        {
//            this.columnnPoNum = base.Columns["nPoNum"];
//            this.columncItemdes = base.Columns["cItemdes"];
//            this.columncSize = base.Columns["cSize"];
//            this.columncColour = base.Columns["cColour"];
//            this.columncArt = base.Columns["cArt"];
//            this.columncDimec = base.Columns["cDimec"];
//            this.columncUnit = base.Columns["cUnit"];
//            this.columnnQty = base.Columns["nQty"];
//            this.columngrnQty = base.Columns["grnQty"];
//            this.columnnIssQty = base.Columns["nIssQty"];
//            this.columnnItemBalQty = base.Columns["nItemBalQty"];
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) =>
//            new Inventory.StyleStatusRow(builder);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public Inventory.StyleStatusRow NewStyleStatusRow() =>
//            ((Inventory.StyleStatusRow)base.NewRow());

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowChanged(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanged(e);
//            if (this.StyleStatusRowChanged != null)
//            {
//                this.StyleStatusRowChanged(this, new Inventory.StyleStatusRowChangeEvent((Inventory.StyleStatusRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowChanging(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanging(e);
//            if (this.StyleStatusRowChanging != null)
//            {
//                this.StyleStatusRowChanging(this, new Inventory.StyleStatusRowChangeEvent((Inventory.StyleStatusRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowDeleted(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleted(e);
//            if (this.StyleStatusRowDeleted != null)
//            {
//                this.StyleStatusRowDeleted(this, new Inventory.StyleStatusRowChangeEvent((Inventory.StyleStatusRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowDeleting(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleting(e);
//            if (this.StyleStatusRowDeleting != null)
//            {
//                this.StyleStatusRowDeleting(this, new Inventory.StyleStatusRowChangeEvent((Inventory.StyleStatusRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void RemoveStyleStatusRow(Inventory.StyleStatusRow row)
//        {
//            base.Rows.Remove(row);
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cArtColumn =>
//            this.columncArt;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cColourColumn =>
//            this.columncColour;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cDimecColumn =>
//            this.columncDimec;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cItemdesColumn =>
//            this.columncItemdes;

//        [DebuggerNonUserCode, Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public int Count =>
//            base.Rows.Count;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cSizeColumn =>
//            this.columncSize;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cUnitColumn =>
//            this.columncUnit;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn grnQtyColumn =>
//            this.columngrnQty;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public Inventory.StyleStatusRow this[int index] =>
//            ((Inventory.StyleStatusRow)base.Rows[index]);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn nIssQtyColumn =>
//            this.columnnIssQty;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn nItemBalQtyColumn =>
//            this.columnnItemBalQty;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn nPoNumColumn =>
//            this.columnnPoNum;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn nQtyColumn =>
//            this.columnnQty;
//    }

//    public class StyleStatusRow : DataRow
//    {
//        private Inventory.StyleStatusDataTable tableStyleStatus;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal StyleStatusRow(DataRowBuilder rb) : base(rb)
//        {
//            this.tableStyleStatus = (Inventory.StyleStatusDataTable)base.Table;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscArtNull() =>
//            base.IsNull(this.tableStyleStatus.cArtColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscColourNull() =>
//            base.IsNull(this.tableStyleStatus.cColourColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscDimecNull() =>
//            base.IsNull(this.tableStyleStatus.cDimecColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscItemdesNull() =>
//            base.IsNull(this.tableStyleStatus.cItemdesColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscSizeNull() =>
//            base.IsNull(this.tableStyleStatus.cSizeColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscUnitNull() =>
//            base.IsNull(this.tableStyleStatus.cUnitColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsgrnQtyNull() =>
//            base.IsNull(this.tableStyleStatus.grnQtyColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsnIssQtyNull() =>
//            base.IsNull(this.tableStyleStatus.nIssQtyColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsnItemBalQtyNull() =>
//            base.IsNull(this.tableStyleStatus.nItemBalQtyColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsnPoNumNull() =>
//            base.IsNull(this.tableStyleStatus.nPoNumColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsnQtyNull() =>
//            base.IsNull(this.tableStyleStatus.nQtyColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcArtNull()
//        {
//            base[this.tableStyleStatus.cArtColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcColourNull()
//        {
//            base[this.tableStyleStatus.cColourColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcDimecNull()
//        {
//            base[this.tableStyleStatus.cDimecColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcItemdesNull()
//        {
//            base[this.tableStyleStatus.cItemdesColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcSizeNull()
//        {
//            base[this.tableStyleStatus.cSizeColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcUnitNull()
//        {
//            base[this.tableStyleStatus.cUnitColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetgrnQtyNull()
//        {
//            base[this.tableStyleStatus.grnQtyColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnIssQtyNull()
//        {
//            base[this.tableStyleStatus.nIssQtyColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnItemBalQtyNull()
//        {
//            base[this.tableStyleStatus.nItemBalQtyColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnPoNumNull()
//        {
//            base[this.tableStyleStatus.nPoNumColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetnQtyNull()
//        {
//            base[this.tableStyleStatus.nQtyColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cArt
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableStyleStatus.cArtColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cArt' in table 'StyleStatus' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableStyleStatus.cArtColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cColour
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableStyleStatus.cColourColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cColour' in table 'StyleStatus' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableStyleStatus.cColourColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cDimec
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableStyleStatus.cDimecColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cDimec' in table 'StyleStatus' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableStyleStatus.cDimecColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cItemdes
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableStyleStatus.cItemdesColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cItemdes' in table 'StyleStatus' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableStyleStatus.cItemdesColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cSize
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableStyleStatus.cSizeColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cSize' in table 'StyleStatus' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableStyleStatus.cSizeColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cUnit
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableStyleStatus.cUnitColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cUnit' in table 'StyleStatus' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableStyleStatus.cUnitColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public decimal grnQty
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableStyleStatus.grnQtyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'grnQty' in table 'StyleStatus' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableStyleStatus.grnQtyColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public decimal nIssQty
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableStyleStatus.nIssQtyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nIssQty' in table 'StyleStatus' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableStyleStatus.nIssQtyColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public decimal nItemBalQty
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableStyleStatus.nItemBalQtyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nItemBalQty' in table 'StyleStatus' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableStyleStatus.nItemBalQtyColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public int nPoNum
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableStyleStatus.nPoNumColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nPoNum' in table 'StyleStatus' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableStyleStatus.nPoNumColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public decimal nQty
//        {
//            get
//            {
//                decimal num;
//                try
//                {
//                    num = (decimal)base[this.tableStyleStatus.nQtyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nQty' in table 'StyleStatus' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableStyleStatus.nQtyColumn] = value;
//            }
//        }
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public class StyleStatusRowChangeEvent : EventArgs
//    {
//        private DataRowAction eventAction;
//        private Inventory.StyleStatusRow eventRow;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public StyleStatusRowChangeEvent(Inventory.StyleStatusRow row, DataRowAction action)
//        {
//            this.eventRow = row;
//            this.eventAction = action;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataRowAction Action =>
//            this.eventAction;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Inventory.StyleStatusRow Row =>
//            this.eventRow;
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public delegate void StyleStatusRowChangeEventHandler(object sender, Inventory.StyleStatusRowChangeEvent e);
}
