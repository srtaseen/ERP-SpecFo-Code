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

[Serializable, HelpKeyword("vs.data.DataSet"), XmlSchemaProvider("GetTypedDataSetSchema"), ToolboxItem(true), XmlRoot("Production"), DesignerCategory("code")]
public class Production : DataSet
{
    //    private System.Data.SchemaSerializationMode _schemaSerializationMode;
    //    private CutsummeryD2DDataTable tableCutsummeryD2D;
    //    private DailyCuttingDataTable tableDailyCutting;
    //    private DlyfinlrlptDataTable tableDlyfinlrlpt;
    //    private ProductiondtlDataTable tableProductiondtl;

    //    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //    public Production()
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
    //    protected Production(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
    //                if (dataSet.Tables["DailyCutting"] != null)
    //                {
    //                    base.Tables.Add(new DailyCuttingDataTable(dataSet.Tables["DailyCutting"]));
    //                }
    //                if (dataSet.Tables["CutsummeryD2D"] != null)
    //                {
    //                    base.Tables.Add(new CutsummeryD2DDataTable(dataSet.Tables["CutsummeryD2D"]));
    //                }
    //                if (dataSet.Tables["Productiondtl"] != null)
    //                {
    //                    base.Tables.Add(new ProductiondtlDataTable(dataSet.Tables["Productiondtl"]));
    //                }
    //                if (dataSet.Tables["Dlyfinlrlpt"] != null)
    //                {
    //                    base.Tables.Add(new DlyfinlrlptDataTable(dataSet.Tables["Dlyfinlrlpt"]));
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
    //        Production production = (Production)base.Clone();
    //        production.InitVars();
    //        production.SchemaSerializationMode = this.SchemaSerializationMode;
    //        return production;
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
    //        Production production = new Production();
    //        XmlSchemaComplexType type = new XmlSchemaComplexType();
    //        XmlSchemaSequence sequence = new XmlSchemaSequence();
    //        XmlSchemaAny item = new XmlSchemaAny
    //        {
    //            Namespace = production.Namespace
    //        };
    //        sequence.Items.Add(item);
    //        type.Particle = sequence;
    //        XmlSchema schemaSerializable = production.GetSchemaSerializable();
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

    //    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //    private void InitClass()
    //    {
    //        base.DataSetName = "Production";
    //        base.Prefix = "";
    //        base.Namespace = "http://tempuri.org/Production.xsd";
    //        base.EnforceConstraints = true;
    //        this.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
    //        this.tableDailyCutting = new DailyCuttingDataTable();
    //        base.Tables.Add(this.tableDailyCutting);
    //        this.tableCutsummeryD2D = new CutsummeryD2DDataTable();
    //        base.Tables.Add(this.tableCutsummeryD2D);
    //        this.tableProductiondtl = new ProductiondtlDataTable();
    //        base.Tables.Add(this.tableProductiondtl);
    //        this.tableDlyfinlrlpt = new DlyfinlrlptDataTable();
    //        base.Tables.Add(this.tableDlyfinlrlpt);
    //    }

    //    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //    protected override void InitializeDerivedDataSet()
    //    {
    //        base.BeginInit();
    //        this.InitClass();
    //        base.EndInit();
    //    }

    //    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //    internal void InitVars()
    //    {
    //        this.InitVars(true);
    //    }

    //    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //    internal void InitVars(bool initTable)
    //    {
    //        this.tableDailyCutting = (DailyCuttingDataTable)base.Tables["DailyCutting"];
    //        if (initTable && (this.tableDailyCutting != null))
    //        {
    //            this.tableDailyCutting.InitVars();
    //        }
    //        this.tableCutsummeryD2D = (CutsummeryD2DDataTable)base.Tables["CutsummeryD2D"];
    //        if (initTable && (this.tableCutsummeryD2D != null))
    //        {
    //            this.tableCutsummeryD2D.InitVars();
    //        }
    //        this.tableProductiondtl = (ProductiondtlDataTable)base.Tables["Productiondtl"];
    //        if (initTable && (this.tableProductiondtl != null))
    //        {
    //            this.tableProductiondtl.InitVars();
    //        }
    //        this.tableDlyfinlrlpt = (DlyfinlrlptDataTable)base.Tables["Dlyfinlrlpt"];
    //        if (initTable && (this.tableDlyfinlrlpt != null))
    //        {
    //            this.tableDlyfinlrlpt.InitVars();
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
    //            if (dataSet.Tables["DailyCutting"] != null)
    //            {
    //                base.Tables.Add(new DailyCuttingDataTable(dataSet.Tables["DailyCutting"]));
    //            }
    //            if (dataSet.Tables["CutsummeryD2D"] != null)
    //            {
    //                base.Tables.Add(new CutsummeryD2DDataTable(dataSet.Tables["CutsummeryD2D"]));
    //            }
    //            if (dataSet.Tables["Productiondtl"] != null)
    //            {
    //                base.Tables.Add(new ProductiondtlDataTable(dataSet.Tables["Productiondtl"]));
    //            }
    //            if (dataSet.Tables["Dlyfinlrlpt"] != null)
    //            {
    //                base.Tables.Add(new DlyfinlrlptDataTable(dataSet.Tables["Dlyfinlrlpt"]));
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

    //    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //    private bool ShouldSerializeCutsummeryD2D() =>
    //        false;

    //    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //    private bool ShouldSerializeDailyCutting() =>
    //        false;

    //    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //    private bool ShouldSerializeDlyfinlrlpt() =>
    //        false;

    //    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //    private bool ShouldSerializeProductiondtl() =>
    //        false;

    //    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //    protected override bool ShouldSerializeRelations() =>
    //        false;

    //    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //    protected override bool ShouldSerializeTables() =>
    //        false;

    //    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    //    public CutsummeryD2DDataTable CutsummeryD2D =>
    //        this.tableCutsummeryD2D;

    //    [Browsable(false), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    //    public DailyCuttingDataTable DailyCutting =>
    //        this.tableDailyCutting;

    //    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
    //    public DlyfinlrlptDataTable Dlyfinlrlpt =>
    //        this.tableDlyfinlrlpt;

    //    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false)]
    //    public ProductiondtlDataTable Productiondtl =>
    //        this.tableProductiondtl;

    //    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    //    public DataRelationCollection Relations =>
    //        base.Relations;

    //    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    //    public override System.Data.SchemaSerializationMode SchemaSerializationMode
    //    {
    //        get => 
    //            this._schemaSerializationMode;
    //        set
    //        {
    //            this._schemaSerializationMode = value;
    //        }
    //        }

    //        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public DataTableCollection Tables =>
    //        base.Tables;

    //        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
    //        public class CutsummeryD2DDataTable : TypedTableBase<Production.CutsummeryD2DRow>
    //    {
    //        private DataColumn columncBuyer_Name;
    //        private DataColumn columncPoNum;
    //        private DataColumn columncStyleNo;
    //        private DataColumn columnCutQty;
    //        private DataColumn columnnOrdQty;
    //        private DataColumn columnShipDt;
    //        private DataColumn columnToDayInpQty;
    //        private DataColumn columnTtlInpQty;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public event Production.CutsummeryD2DRowChangeEventHandler CutsummeryD2DRowChanged;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public event Production.CutsummeryD2DRowChangeEventHandler CutsummeryD2DRowChanging;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public event Production.CutsummeryD2DRowChangeEventHandler CutsummeryD2DRowDeleted;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public event Production.CutsummeryD2DRowChangeEventHandler CutsummeryD2DRowDeleting;

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public CutsummeryD2DDataTable()
    //        {
    //            base.TableName = "CutsummeryD2D";
    //            this.BeginInit();
    //            this.InitClass();
    //            this.EndInit();
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        internal CutsummeryD2DDataTable(DataTable table)
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
    //        protected CutsummeryD2DDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
    //        {
    //            this.InitVars();
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public void AddCutsummeryD2DRow(Production.CutsummeryD2DRow row)
    //        {
    //            base.Rows.Add(row);
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public Production.CutsummeryD2DRow AddCutsummeryD2DRow(string cBuyer_Name, string cStyleNo, string cPoNum, DateTime ShipDt, int nOrdQty, int CutQty, int ToDayInpQty, int TtlInpQty)
    //        {
    //            Production.CutsummeryD2DRow row = (Production.CutsummeryD2DRow)base.NewRow();
    //            row.ItemArray = new object[] { cBuyer_Name, cStyleNo, cPoNum, ShipDt, nOrdQty, CutQty, ToDayInpQty, TtlInpQty };
    //            base.Rows.Add(row);
    //            return row;
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public override DataTable Clone()
    //        {
    //            Production.CutsummeryD2DDataTable table = (Production.CutsummeryD2DDataTable)base.Clone();
    //            table.InitVars();
    //            return table;
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        protected override DataTable CreateInstance() =>
    //            new Production.CutsummeryD2DDataTable();

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        protected override Type GetRowType() =>
    //            typeof(Production.CutsummeryD2DRow);

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    //        {
    //            XmlSchemaComplexType type = new XmlSchemaComplexType();
    //            XmlSchemaSequence sequence = new XmlSchemaSequence();
    //            Production production = new Production();
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
    //                FixedValue = production.Namespace
    //            };
    //            type.Attributes.Add(attribute);
    //            XmlSchemaAttribute attribute2 = new XmlSchemaAttribute
    //            {
    //                Name = "tableTypeName",
    //                FixedValue = "CutsummeryD2DDataTable"
    //            };
    //            type.Attributes.Add(attribute2);
    //            type.Particle = sequence;
    //            XmlSchema schemaSerializable = production.GetSchemaSerializable();
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
    //            this.columncBuyer_Name = new DataColumn("cBuyer_Name", typeof(string), null, MappingType.Element);
    //            base.Columns.Add(this.columncBuyer_Name);
    //            this.columncStyleNo = new DataColumn("cStyleNo", typeof(string), null, MappingType.Element);
    //            base.Columns.Add(this.columncStyleNo);
    //            this.columncPoNum = new DataColumn("cPoNum", typeof(string), null, MappingType.Element);
    //            base.Columns.Add(this.columncPoNum);
    //            this.columnShipDt = new DataColumn("ShipDt", typeof(DateTime), null, MappingType.Element);
    //            base.Columns.Add(this.columnShipDt);
    //            this.columnnOrdQty = new DataColumn("nOrdQty", typeof(int), null, MappingType.Element);
    //            base.Columns.Add(this.columnnOrdQty);
    //            this.columnCutQty = new DataColumn("CutQty", typeof(int), null, MappingType.Element);
    //            base.Columns.Add(this.columnCutQty);
    //            this.columnToDayInpQty = new DataColumn("ToDayInpQty", typeof(int), null, MappingType.Element);
    //            base.Columns.Add(this.columnToDayInpQty);
    //            this.columnTtlInpQty = new DataColumn("TtlInpQty", typeof(int), null, MappingType.Element);
    //            base.Columns.Add(this.columnTtlInpQty);
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        internal void InitVars()
    //        {
    //            this.columncBuyer_Name = base.Columns["cBuyer_Name"];
    //            this.columncStyleNo = base.Columns["cStyleNo"];
    //            this.columncPoNum = base.Columns["cPoNum"];
    //            this.columnShipDt = base.Columns["ShipDt"];
    //            this.columnnOrdQty = base.Columns["nOrdQty"];
    //            this.columnCutQty = base.Columns["CutQty"];
    //            this.columnToDayInpQty = base.Columns["ToDayInpQty"];
    //            this.columnTtlInpQty = base.Columns["TtlInpQty"];
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public Production.CutsummeryD2DRow NewCutsummeryD2DRow() =>
    //            ((Production.CutsummeryD2DRow)base.NewRow());

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) =>
    //            new Production.CutsummeryD2DRow(builder);

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        protected override void OnRowChanged(DataRowChangeEventArgs e)
    //        {
    //            base.OnRowChanged(e);
    //            if (this.CutsummeryD2DRowChanged != null)
    //            {
    //                this.CutsummeryD2DRowChanged(this, new Production.CutsummeryD2DRowChangeEvent((Production.CutsummeryD2DRow)e.Row, e.Action));
    //            }
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        protected override void OnRowChanging(DataRowChangeEventArgs e)
    //        {
    //            base.OnRowChanging(e);
    //            if (this.CutsummeryD2DRowChanging != null)
    //            {
    //                this.CutsummeryD2DRowChanging(this, new Production.CutsummeryD2DRowChangeEvent((Production.CutsummeryD2DRow)e.Row, e.Action));
    //            }
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        protected override void OnRowDeleted(DataRowChangeEventArgs e)
    //        {
    //            base.OnRowDeleted(e);
    //            if (this.CutsummeryD2DRowDeleted != null)
    //            {
    //                this.CutsummeryD2DRowDeleted(this, new Production.CutsummeryD2DRowChangeEvent((Production.CutsummeryD2DRow)e.Row, e.Action));
    //            }
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        protected override void OnRowDeleting(DataRowChangeEventArgs e)
    //        {
    //            base.OnRowDeleting(e);
    //            if (this.CutsummeryD2DRowDeleting != null)
    //            {
    //                this.CutsummeryD2DRowDeleting(this, new Production.CutsummeryD2DRowChangeEvent((Production.CutsummeryD2DRow)e.Row, e.Action));
    //            }
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public void RemoveCutsummeryD2DRow(Production.CutsummeryD2DRow row)
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
    //        public DataColumn cPoNumColumn =>
    //            this.columncPoNum;

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public DataColumn cStyleNoColumn =>
    //            this.columncStyleNo;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public DataColumn CutQtyColumn =>
    //            this.columnCutQty;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public Production.CutsummeryD2DRow this[int index] =>
    //            ((Production.CutsummeryD2DRow)base.Rows[index]);

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public DataColumn nOrdQtyColumn =>
    //            this.columnnOrdQty;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public DataColumn ShipDtColumn =>
    //            this.columnShipDt;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public DataColumn ToDayInpQtyColumn =>
    //            this.columnToDayInpQty;

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public DataColumn TtlInpQtyColumn =>
    //            this.columnTtlInpQty;
    //    }

    //    public class CutsummeryD2DRow : DataRow
    //    {
    //        private Production.CutsummeryD2DDataTable tableCutsummeryD2D;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        internal CutsummeryD2DRow(DataRowBuilder rb) : base(rb)
    //        {
    //            this.tableCutsummeryD2D = (Production.CutsummeryD2DDataTable)base.Table;
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public bool IscBuyer_NameNull() =>
    //            base.IsNull(this.tableCutsummeryD2D.cBuyer_NameColumn);

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public bool IscPoNumNull() =>
    //            base.IsNull(this.tableCutsummeryD2D.cPoNumColumn);

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public bool IscStyleNoNull() =>
    //            base.IsNull(this.tableCutsummeryD2D.cStyleNoColumn);

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public bool IsCutQtyNull() =>
    //            base.IsNull(this.tableCutsummeryD2D.CutQtyColumn);

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public bool IsnOrdQtyNull() =>
    //            base.IsNull(this.tableCutsummeryD2D.nOrdQtyColumn);

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public bool IsShipDtNull() =>
    //            base.IsNull(this.tableCutsummeryD2D.ShipDtColumn);

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public bool IsToDayInpQtyNull() =>
    //            base.IsNull(this.tableCutsummeryD2D.ToDayInpQtyColumn);

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public bool IsTtlInpQtyNull() =>
    //            base.IsNull(this.tableCutsummeryD2D.TtlInpQtyColumn);

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public void SetcBuyer_NameNull()
    //        {
    //            base[this.tableCutsummeryD2D.cBuyer_NameColumn] = Convert.DBNull;
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public void SetcPoNumNull()
    //        {
    //            base[this.tableCutsummeryD2D.cPoNumColumn] = Convert.DBNull;
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public void SetcStyleNoNull()
    //        {
    //            base[this.tableCutsummeryD2D.cStyleNoColumn] = Convert.DBNull;
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public void SetCutQtyNull()
    //        {
    //            base[this.tableCutsummeryD2D.CutQtyColumn] = Convert.DBNull;
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public void SetnOrdQtyNull()
    //        {
    //            base[this.tableCutsummeryD2D.nOrdQtyColumn] = Convert.DBNull;
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public void SetShipDtNull()
    //        {
    //            base[this.tableCutsummeryD2D.ShipDtColumn] = Convert.DBNull;
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public void SetToDayInpQtyNull()
    //        {
    //            base[this.tableCutsummeryD2D.ToDayInpQtyColumn] = Convert.DBNull;
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public void SetTtlInpQtyNull()
    //        {
    //            base[this.tableCutsummeryD2D.TtlInpQtyColumn] = Convert.DBNull;
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public string cBuyer_Name
    //        {
    //            get
    //            {
    //                string str;
    //                try
    //                {
    //                    str = (string)base[this.tableCutsummeryD2D.cBuyer_NameColumn];
    //                }
    //                catch (InvalidCastException exception)
    //                {
    //                    throw new StrongTypingException("The value for column 'cBuyer_Name' in table 'CutsummeryD2D' is DBNull.", exception);
    //                }
    //                return str;
    //            }
    //            set
    //            {
    //                base[this.tableCutsummeryD2D.cBuyer_NameColumn] = value;
    //            }
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public string cPoNum
    //        {
    //            get
    //            {
    //                string str;
    //                try
    //                {
    //                    str = (string)base[this.tableCutsummeryD2D.cPoNumColumn];
    //                }
    //                catch (InvalidCastException exception)
    //                {
    //                    throw new StrongTypingException("The value for column 'cPoNum' in table 'CutsummeryD2D' is DBNull.", exception);
    //                }
    //                return str;
    //            }
    //            set
    //            {
    //                base[this.tableCutsummeryD2D.cPoNumColumn] = value;
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
    //                    str = (string)base[this.tableCutsummeryD2D.cStyleNoColumn];
    //                }
    //                catch (InvalidCastException exception)
    //                {
    //                    throw new StrongTypingException("The value for column 'cStyleNo' in table 'CutsummeryD2D' is DBNull.", exception);
    //                }
    //                return str;
    //            }
    //            set
    //            {
    //                base[this.tableCutsummeryD2D.cStyleNoColumn] = value;
    //            }
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public int CutQty
    //        {
    //            get
    //            {
    //                int num;
    //                try
    //                {
    //                    num = (int)base[this.tableCutsummeryD2D.CutQtyColumn];
    //                }
    //                catch (InvalidCastException exception)
    //                {
    //                    throw new StrongTypingException("The value for column 'CutQty' in table 'CutsummeryD2D' is DBNull.", exception);
    //                }
    //                return num;
    //            }
    //            set
    //            {
    //                base[this.tableCutsummeryD2D.CutQtyColumn] = value;
    //            }
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public int nOrdQty
    //        {
    //            get
    //            {
    //                int num;
    //                try
    //                {
    //                    num = (int)base[this.tableCutsummeryD2D.nOrdQtyColumn];
    //                }
    //                catch (InvalidCastException exception)
    //                {
    //                    throw new StrongTypingException("The value for column 'nOrdQty' in table 'CutsummeryD2D' is DBNull.", exception);
    //                }
    //                return num;
    //            }
    //            set
    //            {
    //                base[this.tableCutsummeryD2D.nOrdQtyColumn] = value;
    //            }
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public DateTime ShipDt
    //        {
    //            get
    //            {
    //                DateTime time;
    //                try
    //                {
    //                    time = (DateTime)base[this.tableCutsummeryD2D.ShipDtColumn];
    //                }
    //                catch (InvalidCastException exception)
    //                {
    //                    throw new StrongTypingException("The value for column 'ShipDt' in table 'CutsummeryD2D' is DBNull.", exception);
    //                }
    //                return time;
    //            }
    //            set
    //            {
    //                base[this.tableCutsummeryD2D.ShipDtColumn] = value;
    //            }
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public int ToDayInpQty
    //        {
    //            get
    //            {
    //                int num;
    //                try
    //                {
    //                    num = (int)base[this.tableCutsummeryD2D.ToDayInpQtyColumn];
    //                }
    //                catch (InvalidCastException exception)
    //                {
    //                    throw new StrongTypingException("The value for column 'ToDayInpQty' in table 'CutsummeryD2D' is DBNull.", exception);
    //                }
    //                return num;
    //            }
    //            set
    //            {
    //                base[this.tableCutsummeryD2D.ToDayInpQtyColumn] = value;
    //            }
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public int TtlInpQty
    //        {
    //            get
    //            {
    //                int num;
    //                try
    //                {
    //                    num = (int)base[this.tableCutsummeryD2D.TtlInpQtyColumn];
    //                }
    //                catch (InvalidCastException exception)
    //                {
    //                    throw new StrongTypingException("The value for column 'TtlInpQty' in table 'CutsummeryD2D' is DBNull.", exception);
    //                }
    //                return num;
    //            }
    //            set
    //            {
    //                base[this.tableCutsummeryD2D.TtlInpQtyColumn] = value;
    //            }
    //        }
    //    }

    //    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //    public class CutsummeryD2DRowChangeEvent : EventArgs
    //    {
    //        private DataRowAction eventAction;
    //        private Production.CutsummeryD2DRow eventRow;

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public CutsummeryD2DRowChangeEvent(Production.CutsummeryD2DRow row, DataRowAction action)
    //        {
    //            this.eventRow = row;
    //            this.eventAction = action;
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public DataRowAction Action =>
    //            this.eventAction;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public Production.CutsummeryD2DRow Row =>
    //            this.eventRow;
    //    }

    //    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //    public delegate void CutsummeryD2DRowChangeEventHandler(object sender, Production.CutsummeryD2DRowChangeEvent e);

    //    [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
    //    public class DailyCuttingDataTable : TypedTableBase<Production.DailyCuttingRow>
    //    {
    //        private DataColumn columncBuyer_Name;
    //        private DataColumn columncColour;
    //        private DataColumn columncPONo;
    //        private DataColumn columnCQty;
    //        private DataColumn columncStyleNo;
    //        private DataColumn columnntot;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public event Production.DailyCuttingRowChangeEventHandler DailyCuttingRowChanged;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public event Production.DailyCuttingRowChangeEventHandler DailyCuttingRowChanging;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public event Production.DailyCuttingRowChangeEventHandler DailyCuttingRowDeleted;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public event Production.DailyCuttingRowChangeEventHandler DailyCuttingRowDeleting;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public DailyCuttingDataTable()
    //        {
    //            base.TableName = "DailyCutting";
    //            this.BeginInit();
    //            this.InitClass();
    //            this.EndInit();
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        internal DailyCuttingDataTable(DataTable table)
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
    //        protected DailyCuttingDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
    //        {
    //            this.InitVars();
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public void AddDailyCuttingRow(Production.DailyCuttingRow row)
    //        {
    //            base.Rows.Add(row);
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public Production.DailyCuttingRow AddDailyCuttingRow(string cBuyer_Name, string cStyleNo, string cPONo, string cColour, int ntot, int CQty)
    //        {
    //            Production.DailyCuttingRow row = (Production.DailyCuttingRow)base.NewRow();
    //            row.ItemArray = new object[] { cBuyer_Name, cStyleNo, cPONo, cColour, ntot, CQty };
    //            base.Rows.Add(row);
    //            return row;
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public override DataTable Clone()
    //        {
    //            Production.DailyCuttingDataTable table = (Production.DailyCuttingDataTable)base.Clone();
    //            table.InitVars();
    //            return table;
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        protected override DataTable CreateInstance() =>
    //            new Production.DailyCuttingDataTable();

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        protected override Type GetRowType() =>
    //            typeof(Production.DailyCuttingRow);

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    //        {
    //            XmlSchemaComplexType type = new XmlSchemaComplexType();
    //            XmlSchemaSequence sequence = new XmlSchemaSequence();
    //            Production production = new Production();
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
    //                FixedValue = production.Namespace
    //            };
    //            type.Attributes.Add(attribute);
    //            XmlSchemaAttribute attribute2 = new XmlSchemaAttribute
    //            {
    //                Name = "tableTypeName",
    //                FixedValue = "DailyCuttingDataTable"
    //            };
    //            type.Attributes.Add(attribute2);
    //            type.Particle = sequence;
    //            XmlSchema schemaSerializable = production.GetSchemaSerializable();
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
    //            this.columncStyleNo = new DataColumn("cStyleNo", typeof(string), null, MappingType.Element);
    //            base.Columns.Add(this.columncStyleNo);
    //            this.columncPONo = new DataColumn("cPONo", typeof(string), null, MappingType.Element);
    //            base.Columns.Add(this.columncPONo);
    //            this.columncColour = new DataColumn("cColour", typeof(string), null, MappingType.Element);
    //            base.Columns.Add(this.columncColour);
    //            this.columnntot = new DataColumn("ntot", typeof(int), null, MappingType.Element);
    //            base.Columns.Add(this.columnntot);
    //            this.columnCQty = new DataColumn("CQty", typeof(int), null, MappingType.Element);
    //            base.Columns.Add(this.columnCQty);
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        internal void InitVars()
    //        {
    //            this.columncBuyer_Name = base.Columns["cBuyer_Name"];
    //            this.columncStyleNo = base.Columns["cStyleNo"];
    //            this.columncPONo = base.Columns["cPONo"];
    //            this.columncColour = base.Columns["cColour"];
    //            this.columnntot = base.Columns["ntot"];
    //            this.columnCQty = base.Columns["CQty"];
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public Production.DailyCuttingRow NewDailyCuttingRow() =>
    //            ((Production.DailyCuttingRow)base.NewRow());

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) =>
    //            new Production.DailyCuttingRow(builder);

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        protected override void OnRowChanged(DataRowChangeEventArgs e)
    //        {
    //            base.OnRowChanged(e);
    //            if (this.DailyCuttingRowChanged != null)
    //            {
    //                this.DailyCuttingRowChanged(this, new Production.DailyCuttingRowChangeEvent((Production.DailyCuttingRow)e.Row, e.Action));
    //            }
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        protected override void OnRowChanging(DataRowChangeEventArgs e)
    //        {
    //            base.OnRowChanging(e);
    //            if (this.DailyCuttingRowChanging != null)
    //            {
    //                this.DailyCuttingRowChanging(this, new Production.DailyCuttingRowChangeEvent((Production.DailyCuttingRow)e.Row, e.Action));
    //            }
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        protected override void OnRowDeleted(DataRowChangeEventArgs e)
    //        {
    //            base.OnRowDeleted(e);
    //            if (this.DailyCuttingRowDeleted != null)
    //            {
    //                this.DailyCuttingRowDeleted(this, new Production.DailyCuttingRowChangeEvent((Production.DailyCuttingRow)e.Row, e.Action));
    //            }
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        protected override void OnRowDeleting(DataRowChangeEventArgs e)
    //        {
    //            base.OnRowDeleting(e);
    //            if (this.DailyCuttingRowDeleting != null)
    //            {
    //                this.DailyCuttingRowDeleting(this, new Production.DailyCuttingRowChangeEvent((Production.DailyCuttingRow)e.Row, e.Action));
    //            }
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public void RemoveDailyCuttingRow(Production.DailyCuttingRow row)
    //        {
    //            base.Rows.Remove(row);
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public DataColumn cBuyer_NameColumn =>
    //            this.columncBuyer_Name;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public DataColumn cColourColumn =>
    //            this.columncColour;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, Browsable(false)]
    //        public int Count =>
    //            base.Rows.Count;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public DataColumn cPONoColumn =>
    //            this.columncPONo;

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public DataColumn CQtyColumn =>
    //            this.columnCQty;

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public DataColumn cStyleNoColumn =>
    //            this.columncStyleNo;

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public Production.DailyCuttingRow this[int index] =>
    //            ((Production.DailyCuttingRow)base.Rows[index]);

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public DataColumn ntotColumn =>
    //            this.columnntot;
    //    }

    //    public class DailyCuttingRow : DataRow
    //    {
    //        private Production.DailyCuttingDataTable tableDailyCutting;

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        internal DailyCuttingRow(DataRowBuilder rb) : base(rb)
    //        {
    //            this.tableDailyCutting = (Production.DailyCuttingDataTable)base.Table;
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public bool IscBuyer_NameNull() =>
    //            base.IsNull(this.tableDailyCutting.cBuyer_NameColumn);

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public bool IscColourNull() =>
    //            base.IsNull(this.tableDailyCutting.cColourColumn);

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public bool IscPONoNull() =>
    //            base.IsNull(this.tableDailyCutting.cPONoColumn);

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public bool IsCQtyNull() =>
    //            base.IsNull(this.tableDailyCutting.CQtyColumn);

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public bool IscStyleNoNull() =>
    //            base.IsNull(this.tableDailyCutting.cStyleNoColumn);

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public bool IsntotNull() =>
    //            base.IsNull(this.tableDailyCutting.ntotColumn);

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public void SetcBuyer_NameNull()
    //        {
    //            base[this.tableDailyCutting.cBuyer_NameColumn] = Convert.DBNull;
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public void SetcColourNull()
    //        {
    //            base[this.tableDailyCutting.cColourColumn] = Convert.DBNull;
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public void SetcPONoNull()
    //        {
    //            base[this.tableDailyCutting.cPONoColumn] = Convert.DBNull;
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public void SetCQtyNull()
    //        {
    //            base[this.tableDailyCutting.CQtyColumn] = Convert.DBNull;
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public void SetcStyleNoNull()
    //        {
    //            base[this.tableDailyCutting.cStyleNoColumn] = Convert.DBNull;
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public void SetntotNull()
    //        {
    //            base[this.tableDailyCutting.ntotColumn] = Convert.DBNull;
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public string cBuyer_Name
    //        {
    //            get
    //            {
    //                string str;
    //                try
    //                {
    //                    str = (string)base[this.tableDailyCutting.cBuyer_NameColumn];
    //                }
    //                catch (InvalidCastException exception)
    //                {
    //                    throw new StrongTypingException("The value for column 'cBuyer_Name' in table 'DailyCutting' is DBNull.", exception);
    //                }
    //                return str;
    //            }
    //            set
    //            {
    //                base[this.tableDailyCutting.cBuyer_NameColumn] = value;
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
    //                    str = (string)base[this.tableDailyCutting.cColourColumn];
    //                }
    //                catch (InvalidCastException exception)
    //                {
    //                    throw new StrongTypingException("The value for column 'cColour' in table 'DailyCutting' is DBNull.", exception);
    //                }
    //                return str;
    //            }
    //            set
    //            {
    //                base[this.tableDailyCutting.cColourColumn] = value;
    //            }
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public string cPONo
    //        {
    //            get
    //            {
    //                string str;
    //                try
    //                {
    //                    str = (string)base[this.tableDailyCutting.cPONoColumn];
    //                }
    //                catch (InvalidCastException exception)
    //                {
    //                    throw new StrongTypingException("The value for column 'cPONo' in table 'DailyCutting' is DBNull.", exception);
    //                }
    //                return str;
    //            }
    //            set
    //            {
    //                base[this.tableDailyCutting.cPONoColumn] = value;
    //            }
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public int CQty
    //        {
    //            get
    //            {
    //                int num;
    //                try
    //                {
    //                    num = (int)base[this.tableDailyCutting.CQtyColumn];
    //                }
    //                catch (InvalidCastException exception)
    //                {
    //                    throw new StrongTypingException("The value for column 'CQty' in table 'DailyCutting' is DBNull.", exception);
    //                }
    //                return num;
    //            }
    //            set
    //            {
    //                base[this.tableDailyCutting.CQtyColumn] = value;
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
    //                    str = (string)base[this.tableDailyCutting.cStyleNoColumn];
    //                }
    //                catch (InvalidCastException exception)
    //                {
    //                    throw new StrongTypingException("The value for column 'cStyleNo' in table 'DailyCutting' is DBNull.", exception);
    //                }
    //                return str;
    //            }
    //            set
    //            {
    //                base[this.tableDailyCutting.cStyleNoColumn] = value;
    //            }
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public int ntot
    //        {
    //            get
    //            {
    //                int num;
    //                try
    //                {
    //                    num = (int)base[this.tableDailyCutting.ntotColumn];
    //                }
    //                catch (InvalidCastException exception)
    //                {
    //                    throw new StrongTypingException("The value for column 'ntot' in table 'DailyCutting' is DBNull.", exception);
    //                }
    //                return num;
    //            }
    //            set
    //            {
    //                base[this.tableDailyCutting.ntotColumn] = value;
    //            }
    //        }
    //    }

    //    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //    public class DailyCuttingRowChangeEvent : EventArgs
    //    {
    //        private DataRowAction eventAction;
    //        private Production.DailyCuttingRow eventRow;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public DailyCuttingRowChangeEvent(Production.DailyCuttingRow row, DataRowAction action)
    //        {
    //            this.eventRow = row;
    //            this.eventAction = action;
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public DataRowAction Action =>
    //            this.eventAction;

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public Production.DailyCuttingRow Row =>
    //            this.eventRow;
    //    }

    //    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //    public delegate void DailyCuttingRowChangeEventHandler(object sender, Production.DailyCuttingRowChangeEvent e);

    //    [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
    //    public class DlyfinlrlptDataTable : TypedTableBase<Production.DlyfinlrlptRow>
    //    {
    //        private DataColumn columncBuyer_Name;
    //        private DataColumn columncPoNum;
    //        private DataColumn columncStyleNo;
    //        private DataColumn columnCumQty;
    //        private DataColumn columnOrderQty;
    //        private DataColumn columnShipDt;
    //        private DataColumn columnTodayFinQty;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public event Production.DlyfinlrlptRowChangeEventHandler DlyfinlrlptRowChanged;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public event Production.DlyfinlrlptRowChangeEventHandler DlyfinlrlptRowChanging;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public event Production.DlyfinlrlptRowChangeEventHandler DlyfinlrlptRowDeleted;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public event Production.DlyfinlrlptRowChangeEventHandler DlyfinlrlptRowDeleting;

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public DlyfinlrlptDataTable()
    //        {
    //            base.TableName = "Dlyfinlrlpt";
    //            this.BeginInit();
    //            this.InitClass();
    //            this.EndInit();
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        internal DlyfinlrlptDataTable(DataTable table)
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
    //        protected DlyfinlrlptDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
    //        {
    //            this.InitVars();
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public void AddDlyfinlrlptRow(Production.DlyfinlrlptRow row)
    //        {
    //            base.Rows.Add(row);
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public Production.DlyfinlrlptRow AddDlyfinlrlptRow(string cBuyer_Name, string cStyleNo, string cPoNum, DateTime ShipDt, int OrderQty, int TodayFinQty, int CumQty)
    //        {
    //            Production.DlyfinlrlptRow row = (Production.DlyfinlrlptRow)base.NewRow();
    //            row.ItemArray = new object[] { cBuyer_Name, cStyleNo, cPoNum, ShipDt, OrderQty, TodayFinQty, CumQty };
    //            base.Rows.Add(row);
    //            return row;
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public override DataTable Clone()
    //        {
    //            Production.DlyfinlrlptDataTable table = (Production.DlyfinlrlptDataTable)base.Clone();
    //            table.InitVars();
    //            return table;
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        protected override DataTable CreateInstance() =>
    //            new Production.DlyfinlrlptDataTable();

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        protected override Type GetRowType() =>
    //            typeof(Production.DlyfinlrlptRow);

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    //        {
    //            XmlSchemaComplexType type = new XmlSchemaComplexType();
    //            XmlSchemaSequence sequence = new XmlSchemaSequence();
    //            Production production = new Production();
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
    //                FixedValue = production.Namespace
    //            };
    //            type.Attributes.Add(attribute);
    //            XmlSchemaAttribute attribute2 = new XmlSchemaAttribute
    //            {
    //                Name = "tableTypeName",
    //                FixedValue = "DlyfinlrlptDataTable"
    //            };
    //            type.Attributes.Add(attribute2);
    //            type.Particle = sequence;
    //            XmlSchema schemaSerializable = production.GetSchemaSerializable();
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
    //            this.columncStyleNo = new DataColumn("cStyleNo", typeof(string), null, MappingType.Element);
    //            base.Columns.Add(this.columncStyleNo);
    //            this.columncPoNum = new DataColumn("cPoNum", typeof(string), null, MappingType.Element);
    //            base.Columns.Add(this.columncPoNum);
    //            this.columnShipDt = new DataColumn("ShipDt", typeof(DateTime), null, MappingType.Element);
    //            base.Columns.Add(this.columnShipDt);
    //            this.columnOrderQty = new DataColumn("OrderQty", typeof(int), null, MappingType.Element);
    //            base.Columns.Add(this.columnOrderQty);
    //            this.columnTodayFinQty = new DataColumn("TodayFinQty", typeof(int), null, MappingType.Element);
    //            base.Columns.Add(this.columnTodayFinQty);
    //            this.columnCumQty = new DataColumn("CumQty", typeof(int), null, MappingType.Element);
    //            base.Columns.Add(this.columnCumQty);
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        internal void InitVars()
    //        {
    //            this.columncBuyer_Name = base.Columns["cBuyer_Name"];
    //            this.columncStyleNo = base.Columns["cStyleNo"];
    //            this.columncPoNum = base.Columns["cPoNum"];
    //            this.columnShipDt = base.Columns["ShipDt"];
    //            this.columnOrderQty = base.Columns["OrderQty"];
    //            this.columnTodayFinQty = base.Columns["TodayFinQty"];
    //            this.columnCumQty = base.Columns["CumQty"];
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public Production.DlyfinlrlptRow NewDlyfinlrlptRow() =>
    //            ((Production.DlyfinlrlptRow)base.NewRow());

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) =>
    //            new Production.DlyfinlrlptRow(builder);

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        protected override void OnRowChanged(DataRowChangeEventArgs e)
    //        {
    //            base.OnRowChanged(e);
    //            if (this.DlyfinlrlptRowChanged != null)
    //            {
    //                this.DlyfinlrlptRowChanged(this, new Production.DlyfinlrlptRowChangeEvent((Production.DlyfinlrlptRow)e.Row, e.Action));
    //            }
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        protected override void OnRowChanging(DataRowChangeEventArgs e)
    //        {
    //            base.OnRowChanging(e);
    //            if (this.DlyfinlrlptRowChanging != null)
    //            {
    //                this.DlyfinlrlptRowChanging(this, new Production.DlyfinlrlptRowChangeEvent((Production.DlyfinlrlptRow)e.Row, e.Action));
    //            }
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        protected override void OnRowDeleted(DataRowChangeEventArgs e)
    //        {
    //            base.OnRowDeleted(e);
    //            if (this.DlyfinlrlptRowDeleted != null)
    //            {
    //                this.DlyfinlrlptRowDeleted(this, new Production.DlyfinlrlptRowChangeEvent((Production.DlyfinlrlptRow)e.Row, e.Action));
    //            }
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        protected override void OnRowDeleting(DataRowChangeEventArgs e)
    //        {
    //            base.OnRowDeleting(e);
    //            if (this.DlyfinlrlptRowDeleting != null)
    //            {
    //                this.DlyfinlrlptRowDeleting(this, new Production.DlyfinlrlptRowChangeEvent((Production.DlyfinlrlptRow)e.Row, e.Action));
    //            }
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public void RemoveDlyfinlrlptRow(Production.DlyfinlrlptRow row)
    //        {
    //            base.Rows.Remove(row);
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public DataColumn cBuyer_NameColumn =>
    //            this.columncBuyer_Name;

    //        [Browsable(false), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public int Count =>
    //            base.Rows.Count;

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public DataColumn cPoNumColumn =>
    //            this.columncPoNum;

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public DataColumn cStyleNoColumn =>
    //            this.columncStyleNo;

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public DataColumn CumQtyColumn =>
    //            this.columnCumQty;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public Production.DlyfinlrlptRow this[int index] =>
    //            ((Production.DlyfinlrlptRow)base.Rows[index]);

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public DataColumn OrderQtyColumn =>
    //            this.columnOrderQty;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public DataColumn ShipDtColumn =>
    //            this.columnShipDt;

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public DataColumn TodayFinQtyColumn =>
    //            this.columnTodayFinQty;
    //    }

    //    public class DlyfinlrlptRow : DataRow
    //    {
    //        private Production.DlyfinlrlptDataTable tableDlyfinlrlpt;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        internal DlyfinlrlptRow(DataRowBuilder rb) : base(rb)
    //        {
    //            this.tableDlyfinlrlpt = (Production.DlyfinlrlptDataTable)base.Table;
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public bool IscBuyer_NameNull() =>
    //            base.IsNull(this.tableDlyfinlrlpt.cBuyer_NameColumn);

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public bool IscPoNumNull() =>
    //            base.IsNull(this.tableDlyfinlrlpt.cPoNumColumn);

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public bool IscStyleNoNull() =>
    //            base.IsNull(this.tableDlyfinlrlpt.cStyleNoColumn);

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public bool IsCumQtyNull() =>
    //            base.IsNull(this.tableDlyfinlrlpt.CumQtyColumn);

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public bool IsOrderQtyNull() =>
    //            base.IsNull(this.tableDlyfinlrlpt.OrderQtyColumn);

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public bool IsShipDtNull() =>
    //            base.IsNull(this.tableDlyfinlrlpt.ShipDtColumn);

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public bool IsTodayFinQtyNull() =>
    //            base.IsNull(this.tableDlyfinlrlpt.TodayFinQtyColumn);

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public void SetcBuyer_NameNull()
    //        {
    //            base[this.tableDlyfinlrlpt.cBuyer_NameColumn] = Convert.DBNull;
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public void SetcPoNumNull()
    //        {
    //            base[this.tableDlyfinlrlpt.cPoNumColumn] = Convert.DBNull;
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public void SetcStyleNoNull()
    //        {
    //            base[this.tableDlyfinlrlpt.cStyleNoColumn] = Convert.DBNull;
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public void SetCumQtyNull()
    //        {
    //            base[this.tableDlyfinlrlpt.CumQtyColumn] = Convert.DBNull;
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public void SetOrderQtyNull()
    //        {
    //            base[this.tableDlyfinlrlpt.OrderQtyColumn] = Convert.DBNull;
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public void SetShipDtNull()
    //        {
    //            base[this.tableDlyfinlrlpt.ShipDtColumn] = Convert.DBNull;
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public void SetTodayFinQtyNull()
    //        {
    //            base[this.tableDlyfinlrlpt.TodayFinQtyColumn] = Convert.DBNull;
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public string cBuyer_Name
    //        {
    //            get
    //            {
    //                string str;
    //                try
    //                {
    //                    str = (string)base[this.tableDlyfinlrlpt.cBuyer_NameColumn];
    //                }
    //                catch (InvalidCastException exception)
    //                {
    //                    throw new StrongTypingException("The value for column 'cBuyer_Name' in table 'Dlyfinlrlpt' is DBNull.", exception);
    //                }
    //                return str;
    //            }
    //            set
    //            {
    //                base[this.tableDlyfinlrlpt.cBuyer_NameColumn] = value;
    //            }
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public string cPoNum
    //        {
    //            get
    //            {
    //                string str;
    //                try
    //                {
    //                    str = (string)base[this.tableDlyfinlrlpt.cPoNumColumn];
    //                }
    //                catch (InvalidCastException exception)
    //                {
    //                    throw new StrongTypingException("The value for column 'cPoNum' in table 'Dlyfinlrlpt' is DBNull.", exception);
    //                }
    //                return str;
    //            }
    //            set
    //            {
    //                base[this.tableDlyfinlrlpt.cPoNumColumn] = value;
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
    //                    str = (string)base[this.tableDlyfinlrlpt.cStyleNoColumn];
    //                }
    //                catch (InvalidCastException exception)
    //                {
    //                    throw new StrongTypingException("The value for column 'cStyleNo' in table 'Dlyfinlrlpt' is DBNull.", exception);
    //                }
    //                return str;
    //            }
    //            set
    //            {
    //                base[this.tableDlyfinlrlpt.cStyleNoColumn] = value;
    //            }
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public int CumQty
    //        {
    //            get
    //            {
    //                int num;
    //                try
    //                {
    //                    num = (int)base[this.tableDlyfinlrlpt.CumQtyColumn];
    //                }
    //                catch (InvalidCastException exception)
    //                {
    //                    throw new StrongTypingException("The value for column 'CumQty' in table 'Dlyfinlrlpt' is DBNull.", exception);
    //                }
    //                return num;
    //            }
    //            set
    //            {
    //                base[this.tableDlyfinlrlpt.CumQtyColumn] = value;
    //            }
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public int OrderQty
    //        {
    //            get
    //            {
    //                int num;
    //                try
    //                {
    //                    num = (int)base[this.tableDlyfinlrlpt.OrderQtyColumn];
    //                }
    //                catch (InvalidCastException exception)
    //                {
    //                    throw new StrongTypingException("The value for column 'OrderQty' in table 'Dlyfinlrlpt' is DBNull.", exception);
    //                }
    //                return num;
    //            }
    //            set
    //            {
    //                base[this.tableDlyfinlrlpt.OrderQtyColumn] = value;
    //            }
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public DateTime ShipDt
    //        {
    //            get
    //            {
    //                DateTime time;
    //                try
    //                {
    //                    time = (DateTime)base[this.tableDlyfinlrlpt.ShipDtColumn];
    //                }
    //                catch (InvalidCastException exception)
    //                {
    //                    throw new StrongTypingException("The value for column 'ShipDt' in table 'Dlyfinlrlpt' is DBNull.", exception);
    //                }
    //                return time;
    //            }
    //            set
    //            {
    //                base[this.tableDlyfinlrlpt.ShipDtColumn] = value;
    //            }
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public int TodayFinQty
    //        {
    //            get
    //            {
    //                int num;
    //                try
    //                {
    //                    num = (int)base[this.tableDlyfinlrlpt.TodayFinQtyColumn];
    //                }
    //                catch (InvalidCastException exception)
    //                {
    //                    throw new StrongTypingException("The value for column 'TodayFinQty' in table 'Dlyfinlrlpt' is DBNull.", exception);
    //                }
    //                return num;
    //            }
    //            set
    //            {
    //                base[this.tableDlyfinlrlpt.TodayFinQtyColumn] = value;
    //            }
    //        }
    //    }

    //    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //    public class DlyfinlrlptRowChangeEvent : EventArgs
    //    {
    //        private DataRowAction eventAction;
    //        private Production.DlyfinlrlptRow eventRow;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public DlyfinlrlptRowChangeEvent(Production.DlyfinlrlptRow row, DataRowAction action)
    //        {
    //            this.eventRow = row;
    //            this.eventAction = action;
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public DataRowAction Action =>
    //            this.eventAction;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public Production.DlyfinlrlptRow Row =>
    //            this.eventRow;
    //    }

    //    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //    public delegate void DlyfinlrlptRowChangeEventHandler(object sender, Production.DlyfinlrlptRowChangeEvent e);

    //    [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
    //    public class ProductiondtlDataTable : TypedTableBase<Production.ProductiondtlRow>
    //    {
    //        private DataColumn columnBColor;
    //        private DataColumn columnBPO;
    //        private DataColumn columnBSize;
    //        private DataColumn columnCutQty;
    //        private DataColumn columnnBun;
    //        private DataColumn columnnFOut;
    //        private DataColumn columnnINP;
    //        private DataColumn columnnQOut;
    //        private DataColumn columnOrdQty;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public event Production.ProductiondtlRowChangeEventHandler ProductiondtlRowChanged;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public event Production.ProductiondtlRowChangeEventHandler ProductiondtlRowChanging;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public event Production.ProductiondtlRowChangeEventHandler ProductiondtlRowDeleted;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public event Production.ProductiondtlRowChangeEventHandler ProductiondtlRowDeleting;

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public ProductiondtlDataTable()
    //        {
    //            base.TableName = "Productiondtl";
    //            this.BeginInit();
    //            this.InitClass();
    //            this.EndInit();
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        internal ProductiondtlDataTable(DataTable table)
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
    //        protected ProductiondtlDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
    //        {
    //            this.InitVars();
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public void AddProductiondtlRow(Production.ProductiondtlRow row)
    //        {
    //            base.Rows.Add(row);
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public Production.ProductiondtlRow AddProductiondtlRow(string BColor, string BPO, string BSize, int OrdQty, int CutQty, int nBun, int nINP, int nQOut, int nFOut)
    //        {
    //            Production.ProductiondtlRow row = (Production.ProductiondtlRow)base.NewRow();
    //            row.ItemArray = new object[] { BColor, BPO, BSize, OrdQty, CutQty, nBun, nINP, nQOut, nFOut };
    //            base.Rows.Add(row);
    //            return row;
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public override DataTable Clone()
    //        {
    //            Production.ProductiondtlDataTable table = (Production.ProductiondtlDataTable)base.Clone();
    //            table.InitVars();
    //            return table;
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        protected override DataTable CreateInstance() =>
    //            new Production.ProductiondtlDataTable();

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        protected override Type GetRowType() =>
    //            typeof(Production.ProductiondtlRow);

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    //        {
    //            XmlSchemaComplexType type = new XmlSchemaComplexType();
    //            XmlSchemaSequence sequence = new XmlSchemaSequence();
    //            Production production = new Production();
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
    //                FixedValue = production.Namespace
    //            };
    //            type.Attributes.Add(attribute);
    //            XmlSchemaAttribute attribute2 = new XmlSchemaAttribute
    //            {
    //                Name = "tableTypeName",
    //                FixedValue = "ProductiondtlDataTable"
    //            };
    //            type.Attributes.Add(attribute2);
    //            type.Particle = sequence;
    //            XmlSchema schemaSerializable = production.GetSchemaSerializable();
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
    //            this.columnBColor = new DataColumn("BColor", typeof(string), null, MappingType.Element);
    //            base.Columns.Add(this.columnBColor);
    //            this.columnBPO = new DataColumn("BPO", typeof(string), null, MappingType.Element);
    //            base.Columns.Add(this.columnBPO);
    //            this.columnBSize = new DataColumn("BSize", typeof(string), null, MappingType.Element);
    //            base.Columns.Add(this.columnBSize);
    //            this.columnOrdQty = new DataColumn("OrdQty", typeof(int), null, MappingType.Element);
    //            base.Columns.Add(this.columnOrdQty);
    //            this.columnCutQty = new DataColumn("CutQty", typeof(int), null, MappingType.Element);
    //            base.Columns.Add(this.columnCutQty);
    //            this.columnnBun = new DataColumn("nBun", typeof(int), null, MappingType.Element);
    //            base.Columns.Add(this.columnnBun);
    //            this.columnnINP = new DataColumn("nINP", typeof(int), null, MappingType.Element);
    //            base.Columns.Add(this.columnnINP);
    //            this.columnnQOut = new DataColumn("nQOut", typeof(int), null, MappingType.Element);
    //            base.Columns.Add(this.columnnQOut);
    //            this.columnnFOut = new DataColumn("nFOut", typeof(int), null, MappingType.Element);
    //            base.Columns.Add(this.columnnFOut);
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        internal void InitVars()
    //        {
    //            this.columnBColor = base.Columns["BColor"];
    //            this.columnBPO = base.Columns["BPO"];
    //            this.columnBSize = base.Columns["BSize"];
    //            this.columnOrdQty = base.Columns["OrdQty"];
    //            this.columnCutQty = base.Columns["CutQty"];
    //            this.columnnBun = base.Columns["nBun"];
    //            this.columnnINP = base.Columns["nINP"];
    //            this.columnnQOut = base.Columns["nQOut"];
    //            this.columnnFOut = base.Columns["nFOut"];
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public Production.ProductiondtlRow NewProductiondtlRow() =>
    //            ((Production.ProductiondtlRow)base.NewRow());

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) =>
    //            new Production.ProductiondtlRow(builder);

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        protected override void OnRowChanged(DataRowChangeEventArgs e)
    //        {
    //            base.OnRowChanged(e);
    //            if (this.ProductiondtlRowChanged != null)
    //            {
    //                this.ProductiondtlRowChanged(this, new Production.ProductiondtlRowChangeEvent((Production.ProductiondtlRow)e.Row, e.Action));
    //            }
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        protected override void OnRowChanging(DataRowChangeEventArgs e)
    //        {
    //            base.OnRowChanging(e);
    //            if (this.ProductiondtlRowChanging != null)
    //            {
    //                this.ProductiondtlRowChanging(this, new Production.ProductiondtlRowChangeEvent((Production.ProductiondtlRow)e.Row, e.Action));
    //            }
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        protected override void OnRowDeleted(DataRowChangeEventArgs e)
    //        {
    //            base.OnRowDeleted(e);
    //            if (this.ProductiondtlRowDeleted != null)
    //            {
    //                this.ProductiondtlRowDeleted(this, new Production.ProductiondtlRowChangeEvent((Production.ProductiondtlRow)e.Row, e.Action));
    //            }
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        protected override void OnRowDeleting(DataRowChangeEventArgs e)
    //        {
    //            base.OnRowDeleting(e);
    //            if (this.ProductiondtlRowDeleting != null)
    //            {
    //                this.ProductiondtlRowDeleting(this, new Production.ProductiondtlRowChangeEvent((Production.ProductiondtlRow)e.Row, e.Action));
    //            }
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public void RemoveProductiondtlRow(Production.ProductiondtlRow row)
    //        {
    //            base.Rows.Remove(row);
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public DataColumn BColorColumn =>
    //            this.columnBColor;

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public DataColumn BPOColumn =>
    //            this.columnBPO;

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public DataColumn BSizeColumn =>
    //            this.columnBSize;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode]
    //        public int Count =>
    //            base.Rows.Count;

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public DataColumn CutQtyColumn =>
    //            this.columnCutQty;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public Production.ProductiondtlRow this[int index] =>
    //            ((Production.ProductiondtlRow)base.Rows[index]);

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public DataColumn nBunColumn =>
    //            this.columnnBun;

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public DataColumn nFOutColumn =>
    //            this.columnnFOut;

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public DataColumn nINPColumn =>
    //            this.columnnINP;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public DataColumn nQOutColumn =>
    //            this.columnnQOut;

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public DataColumn OrdQtyColumn =>
    //            this.columnOrdQty;
    //    }

    //    public class ProductiondtlRow : DataRow
    //    {
    //        private Production.ProductiondtlDataTable tableProductiondtl;

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        internal ProductiondtlRow(DataRowBuilder rb) : base(rb)
    //        {
    //            this.tableProductiondtl = (Production.ProductiondtlDataTable)base.Table;
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public bool IsBColorNull() =>
    //            base.IsNull(this.tableProductiondtl.BColorColumn);

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public bool IsBPONull() =>
    //            base.IsNull(this.tableProductiondtl.BPOColumn);

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public bool IsBSizeNull() =>
    //            base.IsNull(this.tableProductiondtl.BSizeColumn);

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public bool IsCutQtyNull() =>
    //            base.IsNull(this.tableProductiondtl.CutQtyColumn);

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public bool IsnBunNull() =>
    //            base.IsNull(this.tableProductiondtl.nBunColumn);

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public bool IsnFOutNull() =>
    //            base.IsNull(this.tableProductiondtl.nFOutColumn);

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public bool IsnINPNull() =>
    //            base.IsNull(this.tableProductiondtl.nINPColumn);

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public bool IsnQOutNull() =>
    //            base.IsNull(this.tableProductiondtl.nQOutColumn);

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public bool IsOrdQtyNull() =>
    //            base.IsNull(this.tableProductiondtl.OrdQtyColumn);

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public void SetBColorNull()
    //        {
    //            base[this.tableProductiondtl.BColorColumn] = Convert.DBNull;
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public void SetBPONull()
    //        {
    //            base[this.tableProductiondtl.BPOColumn] = Convert.DBNull;
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public void SetBSizeNull()
    //        {
    //            base[this.tableProductiondtl.BSizeColumn] = Convert.DBNull;
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public void SetCutQtyNull()
    //        {
    //            base[this.tableProductiondtl.CutQtyColumn] = Convert.DBNull;
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public void SetnBunNull()
    //        {
    //            base[this.tableProductiondtl.nBunColumn] = Convert.DBNull;
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public void SetnFOutNull()
    //        {
    //            base[this.tableProductiondtl.nFOutColumn] = Convert.DBNull;
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public void SetnINPNull()
    //        {
    //            base[this.tableProductiondtl.nINPColumn] = Convert.DBNull;
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public void SetnQOutNull()
    //        {
    //            base[this.tableProductiondtl.nQOutColumn] = Convert.DBNull;
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public void SetOrdQtyNull()
    //        {
    //            base[this.tableProductiondtl.OrdQtyColumn] = Convert.DBNull;
    //        }

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public string BColor
    //        {
    //            get
    //            {
    //                string str;
    //                try
    //                {
    //                    str = (string)base[this.tableProductiondtl.BColorColumn];
    //                }
    //                catch (InvalidCastException exception)
    //                {
    //                    throw new StrongTypingException("The value for column 'BColor' in table 'Productiondtl' is DBNull.", exception);
    //                }
    //                return str;
    //            }
    //            set
    //            {
    //                base[this.tableProductiondtl.BColorColumn] = value;
    //            }
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public string BPO
    //        {
    //            get
    //            {
    //                string str;
    //                try
    //                {
    //                    str = (string)base[this.tableProductiondtl.BPOColumn];
    //                }
    //                catch (InvalidCastException exception)
    //                {
    //                    throw new StrongTypingException("The value for column 'BPO' in table 'Productiondtl' is DBNull.", exception);
    //                }
    //                return str;
    //            }
    //            set
    //            {
    //                base[this.tableProductiondtl.BPOColumn] = value;
    //            }
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public string BSize
    //        {
    //            get
    //            {
    //                string str;
    //                try
    //                {
    //                    str = (string)base[this.tableProductiondtl.BSizeColumn];
    //                }
    //                catch (InvalidCastException exception)
    //                {
    //                    throw new StrongTypingException("The value for column 'BSize' in table 'Productiondtl' is DBNull.", exception);
    //                }
    //                return str;
    //            }
    //            set
    //            {
    //                base[this.tableProductiondtl.BSizeColumn] = value;
    //            }
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public int CutQty
    //        {
    //            get
    //            {
    //                int num;
    //                try
    //                {
    //                    num = (int)base[this.tableProductiondtl.CutQtyColumn];
    //                }
    //                catch (InvalidCastException exception)
    //                {
    //                    throw new StrongTypingException("The value for column 'CutQty' in table 'Productiondtl' is DBNull.", exception);
    //                }
    //                return num;
    //            }
    //            set
    //            {
    //                base[this.tableProductiondtl.CutQtyColumn] = value;
    //            }
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public int nBun
    //        {
    //            get
    //            {
    //                int num;
    //                try
    //                {
    //                    num = (int)base[this.tableProductiondtl.nBunColumn];
    //                }
    //                catch (InvalidCastException exception)
    //                {
    //                    throw new StrongTypingException("The value for column 'nBun' in table 'Productiondtl' is DBNull.", exception);
    //                }
    //                return num;
    //            }
    //            set
    //            {
    //                base[this.tableProductiondtl.nBunColumn] = value;
    //            }
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public int nFOut
    //        {
    //            get
    //            {
    //                int num;
    //                try
    //                {
    //                    num = (int)base[this.tableProductiondtl.nFOutColumn];
    //                }
    //                catch (InvalidCastException exception)
    //                {
    //                    throw new StrongTypingException("The value for column 'nFOut' in table 'Productiondtl' is DBNull.", exception);
    //                }
    //                return num;
    //            }
    //            set
    //            {
    //                base[this.tableProductiondtl.nFOutColumn] = value;
    //            }
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public int nINP
    //        {
    //            get
    //            {
    //                int num;
    //                try
    //                {
    //                    num = (int)base[this.tableProductiondtl.nINPColumn];
    //                }
    //                catch (InvalidCastException exception)
    //                {
    //                    throw new StrongTypingException("The value for column 'nINP' in table 'Productiondtl' is DBNull.", exception);
    //                }
    //                return num;
    //            }
    //            set
    //            {
    //                base[this.tableProductiondtl.nINPColumn] = value;
    //            }
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public int nQOut
    //        {
    //            get
    //            {
    //                int num;
    //                try
    //                {
    //                    num = (int)base[this.tableProductiondtl.nQOutColumn];
    //                }
    //                catch (InvalidCastException exception)
    //                {
    //                    throw new StrongTypingException("The value for column 'nQOut' in table 'Productiondtl' is DBNull.", exception);
    //                }
    //                return num;
    //            }
    //            set
    //            {
    //                base[this.tableProductiondtl.nQOutColumn] = value;
    //            }
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public int OrdQty
    //        {
    //            get
    //            {
    //                int num;
    //                try
    //                {
    //                    num = (int)base[this.tableProductiondtl.OrdQtyColumn];
    //                }
    //                catch (InvalidCastException exception)
    //                {
    //                    throw new StrongTypingException("The value for column 'OrdQty' in table 'Productiondtl' is DBNull.", exception);
    //                }
    //                return num;
    //            }
    //            set
    //            {
    //                base[this.tableProductiondtl.OrdQtyColumn] = value;
    //            }
    //        }
    //    }

    //    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //    public class ProductiondtlRowChangeEvent : EventArgs
    //    {
    //        private DataRowAction eventAction;
    //        private Production.ProductiondtlRow eventRow;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public ProductiondtlRowChangeEvent(Production.ProductiondtlRow row, DataRowAction action)
    //        {
    //            this.eventRow = row;
    //            this.eventAction = action;
    //        }

    //        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //        public DataRowAction Action =>
    //            this.eventAction;

    //        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    //        public Production.ProductiondtlRow Row =>
    //            this.eventRow;
    //    }

    //    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    //    public delegate void ProductiondtlRowChangeEventHandler(object sender, Production.ProductiondtlRowChangeEvent e);
}
