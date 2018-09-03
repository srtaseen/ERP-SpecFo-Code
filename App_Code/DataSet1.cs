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

[Serializable, HelpKeyword("vs.data.DataSet"), XmlSchemaProvider("GetTypedDataSetSchema"), ToolboxItem(true), XmlRoot("DataSet1"), DesignerCategory("code")]
public class DataSet1 : DataSet
{
//    private System.Data.SchemaSerializationMode _schemaSerializationMode;
//    private dtbrandDataTable tabledtbrand;
//    private Smt_StyleMasterDataTable tableSmt_StyleMaster;
//    private testdtblreportDataTable tabletestdtblreport;

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//    public DataSet1()
//    {
//        this._schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
//        base.BeginInit();
//        this.InitClass();
//        CollectionChangeEventHandler handler = new CollectionChangeEventHandler(this.SchemaChanged);
//        base.Tables.CollectionChanged += handler;
//        base.Relations.CollectionChanged += handler;
//        base.EndInit();
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//    protected DataSet1(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
//                if (dataSet.Tables["Smt_StyleMaster"] != null)
//                {
//                    base.Tables.Add(new Smt_StyleMasterDataTable(dataSet.Tables["Smt_StyleMaster"]));
//                }
//                if (dataSet.Tables["testdtblreport"] != null)
//                {
//                    base.Tables.Add(new testdtblreportDataTable(dataSet.Tables["testdtblreport"]));
//                }
//                if (dataSet.Tables["dtbrand"] != null)
//                {
//                    base.Tables.Add(new dtbrandDataTable(dataSet.Tables["dtbrand"]));
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
//        DataSet1 set = (DataSet1)base.Clone();
//        set.InitVars();
//        set.SchemaSerializationMode = this.SchemaSerializationMode;
//        return set;
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
//        DataSet1 set = new DataSet1();
//        XmlSchemaComplexType type = new XmlSchemaComplexType();
//        XmlSchemaSequence sequence = new XmlSchemaSequence();
//        XmlSchemaAny item = new XmlSchemaAny
//        {
//            Namespace = set.Namespace
//        };
//        sequence.Items.Add(item);
//        type.Particle = sequence;
//        XmlSchema schemaSerializable = set.GetSchemaSerializable();
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
//        base.DataSetName = "DataSet1";
//        base.Prefix = "";
//        base.Namespace = "http://tempuri.org/DataSet1.xsd";
//        base.EnforceConstraints = true;
//        this.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
//        this.tableSmt_StyleMaster = new Smt_StyleMasterDataTable();
//        base.Tables.Add(this.tableSmt_StyleMaster);
//        this.tabletestdtblreport = new testdtblreportDataTable();
//        base.Tables.Add(this.tabletestdtblreport);
//        this.tabledtbrand = new dtbrandDataTable();
//        base.Tables.Add(this.tabledtbrand);
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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
//        this.tableSmt_StyleMaster = (Smt_StyleMasterDataTable)base.Tables["Smt_StyleMaster"];
//        if (initTable && (this.tableSmt_StyleMaster != null))
//        {
//            this.tableSmt_StyleMaster.InitVars();
//        }
//        this.tabletestdtblreport = (testdtblreportDataTable)base.Tables["testdtblreport"];
//        if (initTable && (this.tabletestdtblreport != null))
//        {
//            this.tabletestdtblreport.InitVars();
//        }
//        this.tabledtbrand = (dtbrandDataTable)base.Tables["dtbrand"];
//        if (initTable && (this.tabledtbrand != null))
//        {
//            this.tabledtbrand.InitVars();
//        }
//    }

//    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    protected override void ReadXmlSerializable(XmlReader reader)
//    {
//        if (base.DetermineSchemaSerializationMode(reader) == System.Data.SchemaSerializationMode.IncludeSchema)
//        {
//            this.Reset();
//            DataSet dataSet = new DataSet();
//            dataSet.ReadXml(reader);
//            if (dataSet.Tables["Smt_StyleMaster"] != null)
//            {
//                base.Tables.Add(new Smt_StyleMasterDataTable(dataSet.Tables["Smt_StyleMaster"]));
//            }
//            if (dataSet.Tables["testdtblreport"] != null)
//            {
//                base.Tables.Add(new testdtblreportDataTable(dataSet.Tables["testdtblreport"]));
//            }
//            if (dataSet.Tables["dtbrand"] != null)
//            {
//                base.Tables.Add(new dtbrandDataTable(dataSet.Tables["dtbrand"]));
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

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//    private void SchemaChanged(object sender, CollectionChangeEventArgs e)
//    {
//        if (e.Action == CollectionChangeAction.Remove)
//        {
//            this.InitVars();
//        }
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//    private bool ShouldSerializedtbrand() =>
//        false;

//    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    protected override bool ShouldSerializeRelations() =>
//        false;

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//    private bool ShouldSerializeSmt_StyleMaster() =>
//        false;

//    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    protected override bool ShouldSerializeTables() =>
//        false;

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//    private bool ShouldSerializetestdtblreport() =>
//        false;

//    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
//    public dtbrandDataTable dtbrand =>
//        this.tabledtbrand;

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
//    public DataRelationCollection Relations =>
//        base.Relations;

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

//        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public Smt_StyleMasterDataTable Smt_StyleMaster =>
//        this.tableSmt_StyleMaster;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
//        public DataTableCollection Tables =>
//        base.Tables;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
//        public testdtblreportDataTable testdtblreport =>
//        this.tabletestdtblreport;

//        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
//        public class dtbrandDataTable : TypedTableBase<DataSet1.dtbrandRow>
//    {
//        private DataColumn columncBrand_Name;
//        private DataColumn columnnBrand_ID;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event DataSet1.dtbrandRowChangeEventHandler dtbrandRowChanged;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event DataSet1.dtbrandRowChangeEventHandler dtbrandRowChanging;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event DataSet1.dtbrandRowChangeEventHandler dtbrandRowDeleted;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event DataSet1.dtbrandRowChangeEventHandler dtbrandRowDeleting;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public dtbrandDataTable()
//        {
//            base.TableName = "dtbrand";
//            this.BeginInit();
//            this.InitClass();
//            this.EndInit();
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal dtbrandDataTable(DataTable table)
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
//        protected dtbrandDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
//        {
//            this.InitVars();
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void AdddtbrandRow(DataSet1.dtbrandRow row)
//        {
//            base.Rows.Add(row);
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataSet1.dtbrandRow AdddtbrandRow(int nBrand_ID, string cBrand_Name)
//        {
//            DataSet1.dtbrandRow row = (DataSet1.dtbrandRow)base.NewRow();
//            row.ItemArray = new object[] { nBrand_ID, cBrand_Name };
//            base.Rows.Add(row);
//            return row;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public override DataTable Clone()
//        {
//            DataSet1.dtbrandDataTable table = (DataSet1.dtbrandDataTable)base.Clone();
//            table.InitVars();
//            return table;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override DataTable CreateInstance() =>
//            new DataSet1.dtbrandDataTable();

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override Type GetRowType() =>
//            typeof(DataSet1.dtbrandRow);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
//        {
//            XmlSchemaComplexType type = new XmlSchemaComplexType();
//            XmlSchemaSequence sequence = new XmlSchemaSequence();
//            DataSet1 set = new DataSet1();
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
//                FixedValue = set.Namespace
//            };
//            type.Attributes.Add(attribute);
//            XmlSchemaAttribute attribute2 = new XmlSchemaAttribute
//            {
//                Name = "tableTypeName",
//                FixedValue = "dtbrandDataTable"
//            };
//            type.Attributes.Add(attribute2);
//            type.Particle = sequence;
//            XmlSchema schemaSerializable = set.GetSchemaSerializable();
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
//            this.columnnBrand_ID = new DataColumn("nBrand_ID", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnnBrand_ID);
//            this.columncBrand_Name = new DataColumn("cBrand_Name", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncBrand_Name);
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        internal void InitVars()
//        {
//            this.columnnBrand_ID = base.Columns["nBrand_ID"];
//            this.columncBrand_Name = base.Columns["cBrand_Name"];
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataSet1.dtbrandRow NewdtbrandRow() =>
//            ((DataSet1.dtbrandRow)base.NewRow());

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) =>
//            new DataSet1.dtbrandRow(builder);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowChanged(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanged(e);
//            if (this.dtbrandRowChanged != null)
//            {
//                this.dtbrandRowChanged(this, new DataSet1.dtbrandRowChangeEvent((DataSet1.dtbrandRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowChanging(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanging(e);
//            if (this.dtbrandRowChanging != null)
//            {
//                this.dtbrandRowChanging(this, new DataSet1.dtbrandRowChangeEvent((DataSet1.dtbrandRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowDeleted(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleted(e);
//            if (this.dtbrandRowDeleted != null)
//            {
//                this.dtbrandRowDeleted(this, new DataSet1.dtbrandRowChangeEvent((DataSet1.dtbrandRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowDeleting(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleting(e);
//            if (this.dtbrandRowDeleting != null)
//            {
//                this.dtbrandRowDeleting(this, new DataSet1.dtbrandRowChangeEvent((DataSet1.dtbrandRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void RemovedtbrandRow(DataSet1.dtbrandRow row)
//        {
//            base.Rows.Remove(row);
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cBrand_NameColumn =>
//            this.columncBrand_Name;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode]
//        public int Count =>
//            base.Rows.Count;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataSet1.dtbrandRow this[int index] =>
//            ((DataSet1.dtbrandRow)base.Rows[index]);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn nBrand_IDColumn =>
//            this.columnnBrand_ID;
//    }

//    public class dtbrandRow : DataRow
//    {
//        private DataSet1.dtbrandDataTable tabledtbrand;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        internal dtbrandRow(DataRowBuilder rb) : base(rb)
//        {
//            this.tabledtbrand = (DataSet1.dtbrandDataTable)base.Table;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscBrand_NameNull() =>
//            base.IsNull(this.tabledtbrand.cBrand_NameColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsnBrand_IDNull() =>
//            base.IsNull(this.tabledtbrand.nBrand_IDColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcBrand_NameNull()
//        {
//            base[this.tabledtbrand.cBrand_NameColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnBrand_IDNull()
//        {
//            base[this.tabledtbrand.nBrand_IDColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cBrand_Name
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tabledtbrand.cBrand_NameColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cBrand_Name' in table 'dtbrand' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tabledtbrand.cBrand_NameColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public int nBrand_ID
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tabledtbrand.nBrand_IDColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nBrand_ID' in table 'dtbrand' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tabledtbrand.nBrand_IDColumn] = value;
//            }
//        }
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public class dtbrandRowChangeEvent : EventArgs
//    {
//        private DataRowAction eventAction;
//        private DataSet1.dtbrandRow eventRow;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public dtbrandRowChangeEvent(DataSet1.dtbrandRow row, DataRowAction action)
//        {
//            this.eventRow = row;
//            this.eventAction = action;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataRowAction Action =>
//            this.eventAction;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataSet1.dtbrandRow Row =>
//            this.eventRow;
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public delegate void dtbrandRowChangeEventHandler(object sender, DataSet1.dtbrandRowChangeEvent e);

//    [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
//    public class Smt_StyleMasterDataTable : TypedTableBase<DataSet1.Smt_StyleMasterRow>
//    {
//        private DataColumn columnbadbk;
//        private DataColumn columnbConf;
//        private DataColumn columnBGetPln;
//        private DataColumn columnbInActive;
//        private DataColumn columnbstk;
//        private DataColumn columncAuser;
//        private DataColumn columnccFabtype;
//        private DataColumn columncCmmt;
//        private DataColumn columncCmp;
//        private DataColumn columncCnftype;
//        private DataColumn columncDispStyleNo;
//        private DataColumn columncEpfNo;
//        private DataColumn columncExcUser;
//        private DataColumn columncfabcomp;
//        private DataColumn columncFile;
//        private DataColumn columncGmtType;
//        private DataColumn columncInputDate;
//        private DataColumn columncInputUser;
//        private DataColumn columncLabdpcc;
//        private DataColumn columncLcNo;
//        private DataColumn columncPIFty;
//        private DataColumn columncRpt;
//        private DataColumn columncSpeOP;
//        private DataColumn columncStyleNo;
//        private DataColumn columncszrng;
//        private DataColumn columncType;
//        private DataColumn columncYnCnt;
//        private DataColumn columndaddDt;
//        private DataColumn columndbestship;
//        private DataColumn columndBPCd;
//        private DataColumn columndcmdate1;
//        private DataColumn columndcmdate2;
//        private DataColumn columndcmdate3;
//        private DataColumn columndcmdate4;
//        private DataColumn columndComp;
//        private DataColumn columndConf;
//        private DataColumn columndCOShtRec;
//        private DataColumn columndCSwchRec;
//        private DataColumn columndOOshtRec;
//        private DataColumn columndstdFileRec;
//        private DataColumn columnIBck;
//        private DataColumn columnIFnt;
//        private DataColumn columnnAcct;
//        private DataColumn columnnbdt;
//        private DataColumn columnnBran;
//        private DataColumn columnnCm;
//        private DataColumn columnnCM1;
//        private DataColumn columnnCM2;
//        private DataColumn columnnCM3;
//        private DataColumn columnnCM4;
//        private DataColumn columnncolCD;
//        private DataColumn columnnDept;
//        private DataColumn columnnExcut;
//        private DataColumn columnnfabName;
//        private DataColumn columnnfinSmv;
//        private DataColumn columnnfob;
//        private DataColumn columnnFrUpQty;
//        private DataColumn columnnHrPrd;
//        private DataColumn columnnLeadtime;
//        private DataColumn columnnLerCv;
//        private DataColumn columnnMcReq;
//        private DataColumn columnnMSCd;
//        private DataColumn columnnPk;
//        private DataColumn columnnPlnEff;
//        private DataColumn columnnPntPO;
//        private DataColumn columnnPOReq;
//        private DataColumn columnnQl;
//        private DataColumn columnnRatio;
//        private DataColumn columnnSeason;
//        private DataColumn columnNSMV;
//        private DataColumn columnnstore;
//        private DataColumn columnnStyleID;
//        private DataColumn columnnTotOrdQty;
//        private DataColumn columnnWeaving;
//        private DataColumn columnPfront;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event DataSet1.Smt_StyleMasterRowChangeEventHandler Smt_StyleMasterRowChanged;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event DataSet1.Smt_StyleMasterRowChangeEventHandler Smt_StyleMasterRowChanging;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event DataSet1.Smt_StyleMasterRowChangeEventHandler Smt_StyleMasterRowDeleted;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event DataSet1.Smt_StyleMasterRowChangeEventHandler Smt_StyleMasterRowDeleting;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public Smt_StyleMasterDataTable()
//        {
//            base.TableName = "Smt_StyleMaster";
//            this.BeginInit();
//            this.InitClass();
//            this.EndInit();
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        internal Smt_StyleMasterDataTable(DataTable table)
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
//        protected Smt_StyleMasterDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
//        {
//            this.InitVars();
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void AddSmt_StyleMasterRow(DataSet1.Smt_StyleMasterRow row)
//        {
//            base.Rows.Add(row);
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataSet1.Smt_StyleMasterRow AddSmt_StyleMasterRow(string cStyleNo, string cDispStyleNo, short cGmtType, int nTotOrdQty, short nAcct, string cInputUser, DateTime cInputDate, bool bInActive, double nCM1, DateTime dcmdate1, double nCM2, DateTime dcmdate2, double nCM3, DateTime dcmdate3, double nCM4, DateTime dcmdate4, double nCm, double NSMV, string cEpfNo, string cSpeOP, double nPlnEff, decimal nfob, decimal nfinSmv, DateTime dComp, DateTime dBPCd, string cLcNo, int nSeason, int bConf, string cFile, int nBran, bool BGetPln, int nstore, DateTime dbestship, string cfabcomp, int nfabName, int nWeaving, int nLeadtime, string cszrng, string IFnt, string IBck, byte[] Pfront, int nMcReq, int nHrPrd, short nLerCv, decimal nbdt, int nDept, string cCmmt, DateTime dConf, string cExcUser, string cPIFty, int nPOReq, int nPntPO, int nPk, int nRatio, string cType, int nMSCd, string cCmp, DateTime dstdFileRec, DateTime dOOshtRec, DateTime dCOShtRec, DateTime dCSwchRec, string cYnCnt, int nQl, string cCnftype, string ccFabtype, int ncolCD, int nFrUpQty, bool bstk, string cRpt, bool badbk, string cAuser, DateTime daddDt, int nExcut, string cLabdpcc)
//        {
//            DataSet1.Smt_StyleMasterRow row = (DataSet1.Smt_StyleMasterRow)base.NewRow();
//            object[] objArray2 = new object[0x4b];
//            objArray2[1] = cStyleNo;
//            objArray2[2] = cDispStyleNo;
//            objArray2[3] = cGmtType;
//            objArray2[4] = nTotOrdQty;
//            objArray2[5] = nAcct;
//            objArray2[6] = cInputUser;
//            objArray2[7] = cInputDate;
//            objArray2[8] = bInActive;
//            objArray2[9] = nCM1;
//            objArray2[10] = dcmdate1;
//            objArray2[11] = nCM2;
//            objArray2[12] = dcmdate2;
//            objArray2[13] = nCM3;
//            objArray2[14] = dcmdate3;
//            objArray2[15] = nCM4;
//            objArray2[0x10] = dcmdate4;
//            objArray2[0x11] = nCm;
//            objArray2[0x12] = NSMV;
//            objArray2[0x13] = cEpfNo;
//            objArray2[20] = cSpeOP;
//            objArray2[0x15] = nPlnEff;
//            objArray2[0x16] = nfob;
//            objArray2[0x17] = nfinSmv;
//            objArray2[0x18] = dComp;
//            objArray2[0x19] = dBPCd;
//            objArray2[0x1a] = cLcNo;
//            objArray2[0x1b] = nSeason;
//            objArray2[0x1c] = bConf;
//            objArray2[0x1d] = cFile;
//            objArray2[30] = nBran;
//            objArray2[0x1f] = BGetPln;
//            objArray2[0x20] = nstore;
//            objArray2[0x21] = dbestship;
//            objArray2[0x22] = cfabcomp;
//            objArray2[0x23] = nfabName;
//            objArray2[0x24] = nWeaving;
//            objArray2[0x25] = nLeadtime;
//            objArray2[0x26] = cszrng;
//            objArray2[0x27] = IFnt;
//            objArray2[40] = IBck;
//            objArray2[0x29] = Pfront;
//            objArray2[0x2a] = nMcReq;
//            objArray2[0x2b] = nHrPrd;
//            objArray2[0x2c] = nLerCv;
//            objArray2[0x2d] = nbdt;
//            objArray2[0x2e] = nDept;
//            objArray2[0x2f] = cCmmt;
//            objArray2[0x30] = dConf;
//            objArray2[0x31] = cExcUser;
//            objArray2[50] = cPIFty;
//            objArray2[0x33] = nPOReq;
//            objArray2[0x34] = nPntPO;
//            objArray2[0x35] = nPk;
//            objArray2[0x36] = nRatio;
//            objArray2[0x37] = cType;
//            objArray2[0x38] = nMSCd;
//            objArray2[0x39] = cCmp;
//            objArray2[0x3a] = dstdFileRec;
//            objArray2[0x3b] = dOOshtRec;
//            objArray2[60] = dCOShtRec;
//            objArray2[0x3d] = dCSwchRec;
//            objArray2[0x3e] = cYnCnt;
//            objArray2[0x3f] = nQl;
//            objArray2[0x40] = cCnftype;
//            objArray2[0x41] = ccFabtype;
//            objArray2[0x42] = ncolCD;
//            objArray2[0x43] = nFrUpQty;
//            objArray2[0x44] = bstk;
//            objArray2[0x45] = cRpt;
//            objArray2[70] = badbk;
//            objArray2[0x47] = cAuser;
//            objArray2[0x48] = daddDt;
//            objArray2[0x49] = nExcut;
//            objArray2[0x4a] = cLabdpcc;
//            object[] objArray = objArray2;
//            row.ItemArray = objArray;
//            base.Rows.Add(row);
//            return row;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public override DataTable Clone()
//        {
//            DataSet1.Smt_StyleMasterDataTable table = (DataSet1.Smt_StyleMasterDataTable)base.Clone();
//            table.InitVars();
//            return table;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override DataTable CreateInstance() =>
//            new DataSet1.Smt_StyleMasterDataTable();

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataSet1.Smt_StyleMasterRow FindBynStyleID(int nStyleID) =>
//            ((DataSet1.Smt_StyleMasterRow)base.Rows.Find(new object[] { nStyleID }));

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override Type GetRowType() =>
//            typeof(DataSet1.Smt_StyleMasterRow);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
//        {
//            XmlSchemaComplexType type = new XmlSchemaComplexType();
//            XmlSchemaSequence sequence = new XmlSchemaSequence();
//            DataSet1 set = new DataSet1();
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
//                FixedValue = set.Namespace
//            };
//            type.Attributes.Add(attribute);
//            XmlSchemaAttribute attribute2 = new XmlSchemaAttribute
//            {
//                Name = "tableTypeName",
//                FixedValue = "Smt_StyleMasterDataTable"
//            };
//            type.Attributes.Add(attribute2);
//            type.Particle = sequence;
//            XmlSchema schemaSerializable = set.GetSchemaSerializable();
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
//            this.columnnStyleID = new DataColumn("nStyleID", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnnStyleID);
//            this.columncStyleNo = new DataColumn("cStyleNo", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncStyleNo);
//            this.columncDispStyleNo = new DataColumn("cDispStyleNo", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncDispStyleNo);
//            this.columncGmtType = new DataColumn("cGmtType", typeof(short), null, MappingType.Element);
//            base.Columns.Add(this.columncGmtType);
//            this.columnnTotOrdQty = new DataColumn("nTotOrdQty", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnnTotOrdQty);
//            this.columnnAcct = new DataColumn("nAcct", typeof(short), null, MappingType.Element);
//            base.Columns.Add(this.columnnAcct);
//            this.columncInputUser = new DataColumn("cInputUser", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncInputUser);
//            this.columncInputDate = new DataColumn("cInputDate", typeof(DateTime), null, MappingType.Element);
//            base.Columns.Add(this.columncInputDate);
//            this.columnbInActive = new DataColumn("bInActive", typeof(bool), null, MappingType.Element);
//            base.Columns.Add(this.columnbInActive);
//            this.columnnCM1 = new DataColumn("nCM1", typeof(double), null, MappingType.Element);
//            base.Columns.Add(this.columnnCM1);
//            this.columndcmdate1 = new DataColumn("dcmdate1", typeof(DateTime), null, MappingType.Element);
//            base.Columns.Add(this.columndcmdate1);
//            this.columnnCM2 = new DataColumn("nCM2", typeof(double), null, MappingType.Element);
//            base.Columns.Add(this.columnnCM2);
//            this.columndcmdate2 = new DataColumn("dcmdate2", typeof(DateTime), null, MappingType.Element);
//            base.Columns.Add(this.columndcmdate2);
//            this.columnnCM3 = new DataColumn("nCM3", typeof(double), null, MappingType.Element);
//            base.Columns.Add(this.columnnCM3);
//            this.columndcmdate3 = new DataColumn("dcmdate3", typeof(DateTime), null, MappingType.Element);
//            base.Columns.Add(this.columndcmdate3);
//            this.columnnCM4 = new DataColumn("nCM4", typeof(double), null, MappingType.Element);
//            base.Columns.Add(this.columnnCM4);
//            this.columndcmdate4 = new DataColumn("dcmdate4", typeof(DateTime), null, MappingType.Element);
//            base.Columns.Add(this.columndcmdate4);
//            this.columnnCm = new DataColumn("nCm", typeof(double), null, MappingType.Element);
//            base.Columns.Add(this.columnnCm);
//            this.columnNSMV = new DataColumn("NSMV", typeof(double), null, MappingType.Element);
//            base.Columns.Add(this.columnNSMV);
//            this.columncEpfNo = new DataColumn("cEpfNo", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncEpfNo);
//            this.columncSpeOP = new DataColumn("cSpeOP", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncSpeOP);
//            this.columnnPlnEff = new DataColumn("nPlnEff", typeof(double), null, MappingType.Element);
//            base.Columns.Add(this.columnnPlnEff);
//            this.columnnfob = new DataColumn("nfob", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnnfob);
//            this.columnnfinSmv = new DataColumn("nfinSmv", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnnfinSmv);
//            this.columndComp = new DataColumn("dComp", typeof(DateTime), null, MappingType.Element);
//            base.Columns.Add(this.columndComp);
//            this.columndBPCd = new DataColumn("dBPCd", typeof(DateTime), null, MappingType.Element);
//            base.Columns.Add(this.columndBPCd);
//            this.columncLcNo = new DataColumn("cLcNo", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncLcNo);
//            this.columnnSeason = new DataColumn("nSeason", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnnSeason);
//            this.columnbConf = new DataColumn("bConf", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnbConf);
//            this.columncFile = new DataColumn("cFile", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncFile);
//            this.columnnBran = new DataColumn("nBran", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnnBran);
//            this.columnBGetPln = new DataColumn("BGetPln", typeof(bool), null, MappingType.Element);
//            base.Columns.Add(this.columnBGetPln);
//            this.columnnstore = new DataColumn("nstore", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnnstore);
//            this.columndbestship = new DataColumn("dbestship", typeof(DateTime), null, MappingType.Element);
//            base.Columns.Add(this.columndbestship);
//            this.columncfabcomp = new DataColumn("cfabcomp", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncfabcomp);
//            this.columnnfabName = new DataColumn("nfabName", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnnfabName);
//            this.columnnWeaving = new DataColumn("nWeaving", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnnWeaving);
//            this.columnnLeadtime = new DataColumn("nLeadtime", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnnLeadtime);
//            this.columncszrng = new DataColumn("cszrng", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncszrng);
//            this.columnIFnt = new DataColumn("IFnt", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columnIFnt);
//            this.columnIBck = new DataColumn("IBck", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columnIBck);
//            this.columnPfront = new DataColumn("Pfront", typeof(byte[]), null, MappingType.Element);
//            base.Columns.Add(this.columnPfront);
//            this.columnnMcReq = new DataColumn("nMcReq", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnnMcReq);
//            this.columnnHrPrd = new DataColumn("nHrPrd", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnnHrPrd);
//            this.columnnLerCv = new DataColumn("nLerCv", typeof(short), null, MappingType.Element);
//            base.Columns.Add(this.columnnLerCv);
//            this.columnnbdt = new DataColumn("nbdt", typeof(decimal), null, MappingType.Element);
//            base.Columns.Add(this.columnnbdt);
//            this.columnnDept = new DataColumn("nDept", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnnDept);
//            this.columncCmmt = new DataColumn("cCmmt", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncCmmt);
//            this.columndConf = new DataColumn("dConf", typeof(DateTime), null, MappingType.Element);
//            base.Columns.Add(this.columndConf);
//            this.columncExcUser = new DataColumn("cExcUser", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncExcUser);
//            this.columncPIFty = new DataColumn("cPIFty", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncPIFty);
//            this.columnnPOReq = new DataColumn("nPOReq", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnnPOReq);
//            this.columnnPntPO = new DataColumn("nPntPO", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnnPntPO);
//            this.columnnPk = new DataColumn("nPk", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnnPk);
//            this.columnnRatio = new DataColumn("nRatio", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnnRatio);
//            this.columncType = new DataColumn("cType", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncType);
//            this.columnnMSCd = new DataColumn("nMSCd", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnnMSCd);
//            this.columncCmp = new DataColumn("cCmp", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncCmp);
//            this.columndstdFileRec = new DataColumn("dstdFileRec", typeof(DateTime), null, MappingType.Element);
//            base.Columns.Add(this.columndstdFileRec);
//            this.columndOOshtRec = new DataColumn("dOOshtRec", typeof(DateTime), null, MappingType.Element);
//            base.Columns.Add(this.columndOOshtRec);
//            this.columndCOShtRec = new DataColumn("dCOShtRec", typeof(DateTime), null, MappingType.Element);
//            base.Columns.Add(this.columndCOShtRec);
//            this.columndCSwchRec = new DataColumn("dCSwchRec", typeof(DateTime), null, MappingType.Element);
//            base.Columns.Add(this.columndCSwchRec);
//            this.columncYnCnt = new DataColumn("cYnCnt", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncYnCnt);
//            this.columnnQl = new DataColumn("nQl", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnnQl);
//            this.columncCnftype = new DataColumn("cCnftype", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncCnftype);
//            this.columnccFabtype = new DataColumn("ccFabtype", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columnccFabtype);
//            this.columnncolCD = new DataColumn("ncolCD", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnncolCD);
//            this.columnnFrUpQty = new DataColumn("nFrUpQty", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnnFrUpQty);
//            this.columnbstk = new DataColumn("bstk", typeof(bool), null, MappingType.Element);
//            base.Columns.Add(this.columnbstk);
//            this.columncRpt = new DataColumn("cRpt", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncRpt);
//            this.columnbadbk = new DataColumn("badbk", typeof(bool), null, MappingType.Element);
//            base.Columns.Add(this.columnbadbk);
//            this.columncAuser = new DataColumn("cAuser", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncAuser);
//            this.columndaddDt = new DataColumn("daddDt", typeof(DateTime), null, MappingType.Element);
//            base.Columns.Add(this.columndaddDt);
//            this.columnnExcut = new DataColumn("nExcut", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnnExcut);
//            this.columncLabdpcc = new DataColumn("cLabdpcc", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncLabdpcc);
//            base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] { this.columnnStyleID }, true));
//            this.columnnStyleID.AutoIncrement = true;
//            this.columnnStyleID.AutoIncrementSeed = -1L;
//            this.columnnStyleID.AutoIncrementStep = -1L;
//            this.columnnStyleID.AllowDBNull = false;
//            this.columnnStyleID.ReadOnly = true;
//            this.columnnStyleID.Unique = true;
//            this.columncStyleNo.MaxLength = 50;
//            this.columncDispStyleNo.MaxLength = 50;
//            this.columncInputUser.MaxLength = 20;
//            this.columnbInActive.AllowDBNull = false;
//            this.columnnCM1.AllowDBNull = false;
//            this.columnnCM2.AllowDBNull = false;
//            this.columnnCM3.AllowDBNull = false;
//            this.columnnCM4.AllowDBNull = false;
//            this.columnnCm.AllowDBNull = false;
//            this.columnNSMV.AllowDBNull = false;
//            this.columncEpfNo.MaxLength = 5;
//            this.columncSpeOP.MaxLength = 3;
//            this.columnnPlnEff.AllowDBNull = false;
//            this.columnnfob.AllowDBNull = false;
//            this.columnnfinSmv.AllowDBNull = false;
//            this.columncLcNo.MaxLength = 15;
//            this.columncFile.MaxLength = 10;
//            this.columnBGetPln.AllowDBNull = false;
//            this.columncfabcomp.MaxLength = 100;
//            this.columncszrng.MaxLength = 15;
//            this.columnIFnt.MaxLength = 50;
//            this.columnIBck.MaxLength = 50;
//            this.columnnHrPrd.AllowDBNull = false;
//            this.columnnLerCv.AllowDBNull = false;
//            this.columnnbdt.AllowDBNull = false;
//            this.columncCmmt.MaxLength = 0xfe;
//            this.columncExcUser.MaxLength = 15;
//            this.columncPIFty.MaxLength = 3;
//            this.columnnPk.AllowDBNull = false;
//            this.columncType.MaxLength = 10;
//            this.columncCmp.MaxLength = 5;
//            this.columncYnCnt.MaxLength = 5;
//            this.columncCnftype.MaxLength = 15;
//            this.columnccFabtype.MaxLength = 30;
//            this.columnbstk.AllowDBNull = false;
//            this.columncRpt.MaxLength = 2;
//            this.columnbadbk.AllowDBNull = false;
//            this.columncAuser.MaxLength = 20;
//            this.columncLabdpcc.MaxLength = 50;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        internal void InitVars()
//        {
//            this.columnnStyleID = base.Columns["nStyleID"];
//            this.columncStyleNo = base.Columns["cStyleNo"];
//            this.columncDispStyleNo = base.Columns["cDispStyleNo"];
//            this.columncGmtType = base.Columns["cGmtType"];
//            this.columnnTotOrdQty = base.Columns["nTotOrdQty"];
//            this.columnnAcct = base.Columns["nAcct"];
//            this.columncInputUser = base.Columns["cInputUser"];
//            this.columncInputDate = base.Columns["cInputDate"];
//            this.columnbInActive = base.Columns["bInActive"];
//            this.columnnCM1 = base.Columns["nCM1"];
//            this.columndcmdate1 = base.Columns["dcmdate1"];
//            this.columnnCM2 = base.Columns["nCM2"];
//            this.columndcmdate2 = base.Columns["dcmdate2"];
//            this.columnnCM3 = base.Columns["nCM3"];
//            this.columndcmdate3 = base.Columns["dcmdate3"];
//            this.columnnCM4 = base.Columns["nCM4"];
//            this.columndcmdate4 = base.Columns["dcmdate4"];
//            this.columnnCm = base.Columns["nCm"];
//            this.columnNSMV = base.Columns["NSMV"];
//            this.columncEpfNo = base.Columns["cEpfNo"];
//            this.columncSpeOP = base.Columns["cSpeOP"];
//            this.columnnPlnEff = base.Columns["nPlnEff"];
//            this.columnnfob = base.Columns["nfob"];
//            this.columnnfinSmv = base.Columns["nfinSmv"];
//            this.columndComp = base.Columns["dComp"];
//            this.columndBPCd = base.Columns["dBPCd"];
//            this.columncLcNo = base.Columns["cLcNo"];
//            this.columnnSeason = base.Columns["nSeason"];
//            this.columnbConf = base.Columns["bConf"];
//            this.columncFile = base.Columns["cFile"];
//            this.columnnBran = base.Columns["nBran"];
//            this.columnBGetPln = base.Columns["BGetPln"];
//            this.columnnstore = base.Columns["nstore"];
//            this.columndbestship = base.Columns["dbestship"];
//            this.columncfabcomp = base.Columns["cfabcomp"];
//            this.columnnfabName = base.Columns["nfabName"];
//            this.columnnWeaving = base.Columns["nWeaving"];
//            this.columnnLeadtime = base.Columns["nLeadtime"];
//            this.columncszrng = base.Columns["cszrng"];
//            this.columnIFnt = base.Columns["IFnt"];
//            this.columnIBck = base.Columns["IBck"];
//            this.columnPfront = base.Columns["Pfront"];
//            this.columnnMcReq = base.Columns["nMcReq"];
//            this.columnnHrPrd = base.Columns["nHrPrd"];
//            this.columnnLerCv = base.Columns["nLerCv"];
//            this.columnnbdt = base.Columns["nbdt"];
//            this.columnnDept = base.Columns["nDept"];
//            this.columncCmmt = base.Columns["cCmmt"];
//            this.columndConf = base.Columns["dConf"];
//            this.columncExcUser = base.Columns["cExcUser"];
//            this.columncPIFty = base.Columns["cPIFty"];
//            this.columnnPOReq = base.Columns["nPOReq"];
//            this.columnnPntPO = base.Columns["nPntPO"];
//            this.columnnPk = base.Columns["nPk"];
//            this.columnnRatio = base.Columns["nRatio"];
//            this.columncType = base.Columns["cType"];
//            this.columnnMSCd = base.Columns["nMSCd"];
//            this.columncCmp = base.Columns["cCmp"];
//            this.columndstdFileRec = base.Columns["dstdFileRec"];
//            this.columndOOshtRec = base.Columns["dOOshtRec"];
//            this.columndCOShtRec = base.Columns["dCOShtRec"];
//            this.columndCSwchRec = base.Columns["dCSwchRec"];
//            this.columncYnCnt = base.Columns["cYnCnt"];
//            this.columnnQl = base.Columns["nQl"];
//            this.columncCnftype = base.Columns["cCnftype"];
//            this.columnccFabtype = base.Columns["ccFabtype"];
//            this.columnncolCD = base.Columns["ncolCD"];
//            this.columnnFrUpQty = base.Columns["nFrUpQty"];
//            this.columnbstk = base.Columns["bstk"];
//            this.columncRpt = base.Columns["cRpt"];
//            this.columnbadbk = base.Columns["badbk"];
//            this.columncAuser = base.Columns["cAuser"];
//            this.columndaddDt = base.Columns["daddDt"];
//            this.columnnExcut = base.Columns["nExcut"];
//            this.columncLabdpcc = base.Columns["cLabdpcc"];
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) =>
//            new DataSet1.Smt_StyleMasterRow(builder);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataSet1.Smt_StyleMasterRow NewSmt_StyleMasterRow() =>
//            ((DataSet1.Smt_StyleMasterRow)base.NewRow());

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowChanged(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanged(e);
//            if (this.Smt_StyleMasterRowChanged != null)
//            {
//                this.Smt_StyleMasterRowChanged(this, new DataSet1.Smt_StyleMasterRowChangeEvent((DataSet1.Smt_StyleMasterRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowChanging(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanging(e);
//            if (this.Smt_StyleMasterRowChanging != null)
//            {
//                this.Smt_StyleMasterRowChanging(this, new DataSet1.Smt_StyleMasterRowChangeEvent((DataSet1.Smt_StyleMasterRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowDeleted(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleted(e);
//            if (this.Smt_StyleMasterRowDeleted != null)
//            {
//                this.Smt_StyleMasterRowDeleted(this, new DataSet1.Smt_StyleMasterRowChangeEvent((DataSet1.Smt_StyleMasterRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowDeleting(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleting(e);
//            if (this.Smt_StyleMasterRowDeleting != null)
//            {
//                this.Smt_StyleMasterRowDeleting(this, new DataSet1.Smt_StyleMasterRowChangeEvent((DataSet1.Smt_StyleMasterRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void RemoveSmt_StyleMasterRow(DataSet1.Smt_StyleMasterRow row)
//        {
//            base.Rows.Remove(row);
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn badbkColumn =>
//            this.columnbadbk;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn bConfColumn =>
//            this.columnbConf;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn BGetPlnColumn =>
//            this.columnBGetPln;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn bInActiveColumn =>
//            this.columnbInActive;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn bstkColumn =>
//            this.columnbstk;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cAuserColumn =>
//            this.columncAuser;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn ccFabtypeColumn =>
//            this.columnccFabtype;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cCmmtColumn =>
//            this.columncCmmt;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cCmpColumn =>
//            this.columncCmp;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cCnftypeColumn =>
//            this.columncCnftype;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cDispStyleNoColumn =>
//            this.columncDispStyleNo;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cEpfNoColumn =>
//            this.columncEpfNo;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cExcUserColumn =>
//            this.columncExcUser;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cfabcompColumn =>
//            this.columncfabcomp;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cFileColumn =>
//            this.columncFile;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cGmtTypeColumn =>
//            this.columncGmtType;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cInputDateColumn =>
//            this.columncInputDate;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cInputUserColumn =>
//            this.columncInputUser;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cLabdpccColumn =>
//            this.columncLabdpcc;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cLcNoColumn =>
//            this.columncLcNo;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
//        public int Count =>
//            base.Rows.Count;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cPIFtyColumn =>
//            this.columncPIFty;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cRptColumn =>
//            this.columncRpt;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cSpeOPColumn =>
//            this.columncSpeOP;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cStyleNoColumn =>
//            this.columncStyleNo;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cszrngColumn =>
//            this.columncszrng;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn cTypeColumn =>
//            this.columncType;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cYnCntColumn =>
//            this.columncYnCnt;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn daddDtColumn =>
//            this.columndaddDt;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn dbestshipColumn =>
//            this.columndbestship;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn dBPCdColumn =>
//            this.columndBPCd;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn dcmdate1Column =>
//            this.columndcmdate1;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn dcmdate2Column =>
//            this.columndcmdate2;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn dcmdate3Column =>
//            this.columndcmdate3;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn dcmdate4Column =>
//            this.columndcmdate4;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn dCompColumn =>
//            this.columndComp;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn dConfColumn =>
//            this.columndConf;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn dCOShtRecColumn =>
//            this.columndCOShtRec;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn dCSwchRecColumn =>
//            this.columndCSwchRec;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn dOOshtRecColumn =>
//            this.columndOOshtRec;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn dstdFileRecColumn =>
//            this.columndstdFileRec;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn IBckColumn =>
//            this.columnIBck;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn IFntColumn =>
//            this.columnIFnt;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataSet1.Smt_StyleMasterRow this[int index] =>
//            ((DataSet1.Smt_StyleMasterRow)base.Rows[index]);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn nAcctColumn =>
//            this.columnnAcct;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn nbdtColumn =>
//            this.columnnbdt;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn nBranColumn =>
//            this.columnnBran;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn nCM1Column =>
//            this.columnnCM1;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn nCM2Column =>
//            this.columnnCM2;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn nCM3Column =>
//            this.columnnCM3;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn nCM4Column =>
//            this.columnnCM4;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn nCmColumn =>
//            this.columnnCm;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn ncolCDColumn =>
//            this.columnncolCD;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn nDeptColumn =>
//            this.columnnDept;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn nExcutColumn =>
//            this.columnnExcut;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn nfabNameColumn =>
//            this.columnnfabName;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn nfinSmvColumn =>
//            this.columnnfinSmv;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn nfobColumn =>
//            this.columnnfob;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn nFrUpQtyColumn =>
//            this.columnnFrUpQty;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn nHrPrdColumn =>
//            this.columnnHrPrd;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn nLeadtimeColumn =>
//            this.columnnLeadtime;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn nLerCvColumn =>
//            this.columnnLerCv;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn nMcReqColumn =>
//            this.columnnMcReq;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn nMSCdColumn =>
//            this.columnnMSCd;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn nPkColumn =>
//            this.columnnPk;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn nPlnEffColumn =>
//            this.columnnPlnEff;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn nPntPOColumn =>
//            this.columnnPntPO;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn nPOReqColumn =>
//            this.columnnPOReq;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn nQlColumn =>
//            this.columnnQl;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn nRatioColumn =>
//            this.columnnRatio;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn nSeasonColumn =>
//            this.columnnSeason;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn NSMVColumn =>
//            this.columnNSMV;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn nstoreColumn =>
//            this.columnnstore;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn nStyleIDColumn =>
//            this.columnnStyleID;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataColumn nTotOrdQtyColumn =>
//            this.columnnTotOrdQty;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn nWeavingColumn =>
//            this.columnnWeaving;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn PfrontColumn =>
//            this.columnPfront;
//    }

//    public class Smt_StyleMasterRow : DataRow
//    {
//        private DataSet1.Smt_StyleMasterDataTable tableSmt_StyleMaster;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal Smt_StyleMasterRow(DataRowBuilder rb) : base(rb)
//        {
//            this.tableSmt_StyleMaster = (DataSet1.Smt_StyleMasterDataTable)base.Table;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsbConfNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.bConfColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscAuserNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.cAuserColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsccFabtypeNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.ccFabtypeColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscCmmtNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.cCmmtColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscCmpNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.cCmpColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscCnftypeNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.cCnftypeColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscDispStyleNoNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.cDispStyleNoColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscEpfNoNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.cEpfNoColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscExcUserNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.cExcUserColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscfabcompNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.cfabcompColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscFileNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.cFileColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscGmtTypeNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.cGmtTypeColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscInputDateNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.cInputDateColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscInputUserNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.cInputUserColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscLabdpccNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.cLabdpccColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscLcNoNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.cLcNoColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscPIFtyNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.cPIFtyColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscRptNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.cRptColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscSpeOPNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.cSpeOPColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscStyleNoNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.cStyleNoColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscszrngNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.cszrngColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IscTypeNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.cTypeColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscYnCntNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.cYnCntColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsdaddDtNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.daddDtColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsdbestshipNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.dbestshipColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsdBPCdNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.dBPCdColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool Isdcmdate1Null() =>
//            base.IsNull(this.tableSmt_StyleMaster.dcmdate1Column);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool Isdcmdate2Null() =>
//            base.IsNull(this.tableSmt_StyleMaster.dcmdate2Column);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool Isdcmdate3Null() =>
//            base.IsNull(this.tableSmt_StyleMaster.dcmdate3Column);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool Isdcmdate4Null() =>
//            base.IsNull(this.tableSmt_StyleMaster.dcmdate4Column);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsdCompNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.dCompColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsdConfNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.dConfColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsdCOShtRecNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.dCOShtRecColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsdCSwchRecNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.dCSwchRecColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsdOOshtRecNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.dOOshtRecColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsdstdFileRecNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.dstdFileRecColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsIBckNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.IBckColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsIFntNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.IFntColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsnAcctNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.nAcctColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsnBranNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.nBranColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsncolCDNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.ncolCDColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsnDeptNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.nDeptColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsnExcutNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.nExcutColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsnfabNameNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.nfabNameColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsnFrUpQtyNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.nFrUpQtyColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsnLeadtimeNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.nLeadtimeColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsnMcReqNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.nMcReqColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsnMSCdNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.nMSCdColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsnPntPONull() =>
//            base.IsNull(this.tableSmt_StyleMaster.nPntPOColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsnPOReqNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.nPOReqColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsnQlNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.nQlColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsnRatioNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.nRatioColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool IsnSeasonNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.nSeasonColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsnstoreNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.nstoreColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsnTotOrdQtyNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.nTotOrdQtyColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsnWeavingNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.nWeavingColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsPfrontNull() =>
//            base.IsNull(this.tableSmt_StyleMaster.PfrontColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetbConfNull()
//        {
//            base[this.tableSmt_StyleMaster.bConfColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcAuserNull()
//        {
//            base[this.tableSmt_StyleMaster.cAuserColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetccFabtypeNull()
//        {
//            base[this.tableSmt_StyleMaster.ccFabtypeColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcCmmtNull()
//        {
//            base[this.tableSmt_StyleMaster.cCmmtColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcCmpNull()
//        {
//            base[this.tableSmt_StyleMaster.cCmpColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcCnftypeNull()
//        {
//            base[this.tableSmt_StyleMaster.cCnftypeColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcDispStyleNoNull()
//        {
//            base[this.tableSmt_StyleMaster.cDispStyleNoColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcEpfNoNull()
//        {
//            base[this.tableSmt_StyleMaster.cEpfNoColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcExcUserNull()
//        {
//            base[this.tableSmt_StyleMaster.cExcUserColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcfabcompNull()
//        {
//            base[this.tableSmt_StyleMaster.cfabcompColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcFileNull()
//        {
//            base[this.tableSmt_StyleMaster.cFileColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcGmtTypeNull()
//        {
//            base[this.tableSmt_StyleMaster.cGmtTypeColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcInputDateNull()
//        {
//            base[this.tableSmt_StyleMaster.cInputDateColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcInputUserNull()
//        {
//            base[this.tableSmt_StyleMaster.cInputUserColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcLabdpccNull()
//        {
//            base[this.tableSmt_StyleMaster.cLabdpccColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcLcNoNull()
//        {
//            base[this.tableSmt_StyleMaster.cLcNoColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcPIFtyNull()
//        {
//            base[this.tableSmt_StyleMaster.cPIFtyColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcRptNull()
//        {
//            base[this.tableSmt_StyleMaster.cRptColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcSpeOPNull()
//        {
//            base[this.tableSmt_StyleMaster.cSpeOPColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcStyleNoNull()
//        {
//            base[this.tableSmt_StyleMaster.cStyleNoColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcszrngNull()
//        {
//            base[this.tableSmt_StyleMaster.cszrngColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcTypeNull()
//        {
//            base[this.tableSmt_StyleMaster.cTypeColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetcYnCntNull()
//        {
//            base[this.tableSmt_StyleMaster.cYnCntColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetdaddDtNull()
//        {
//            base[this.tableSmt_StyleMaster.daddDtColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetdbestshipNull()
//        {
//            base[this.tableSmt_StyleMaster.dbestshipColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetdBPCdNull()
//        {
//            base[this.tableSmt_StyleMaster.dBPCdColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void Setdcmdate1Null()
//        {
//            base[this.tableSmt_StyleMaster.dcmdate1Column] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void Setdcmdate2Null()
//        {
//            base[this.tableSmt_StyleMaster.dcmdate2Column] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void Setdcmdate3Null()
//        {
//            base[this.tableSmt_StyleMaster.dcmdate3Column] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void Setdcmdate4Null()
//        {
//            base[this.tableSmt_StyleMaster.dcmdate4Column] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetdCompNull()
//        {
//            base[this.tableSmt_StyleMaster.dCompColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetdConfNull()
//        {
//            base[this.tableSmt_StyleMaster.dConfColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetdCOShtRecNull()
//        {
//            base[this.tableSmt_StyleMaster.dCOShtRecColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetdCSwchRecNull()
//        {
//            base[this.tableSmt_StyleMaster.dCSwchRecColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetdOOshtRecNull()
//        {
//            base[this.tableSmt_StyleMaster.dOOshtRecColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetdstdFileRecNull()
//        {
//            base[this.tableSmt_StyleMaster.dstdFileRecColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetIBckNull()
//        {
//            base[this.tableSmt_StyleMaster.IBckColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetIFntNull()
//        {
//            base[this.tableSmt_StyleMaster.IFntColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetnAcctNull()
//        {
//            base[this.tableSmt_StyleMaster.nAcctColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnBranNull()
//        {
//            base[this.tableSmt_StyleMaster.nBranColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetncolCDNull()
//        {
//            base[this.tableSmt_StyleMaster.ncolCDColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnDeptNull()
//        {
//            base[this.tableSmt_StyleMaster.nDeptColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetnExcutNull()
//        {
//            base[this.tableSmt_StyleMaster.nExcutColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnfabNameNull()
//        {
//            base[this.tableSmt_StyleMaster.nfabNameColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnFrUpQtyNull()
//        {
//            base[this.tableSmt_StyleMaster.nFrUpQtyColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnLeadtimeNull()
//        {
//            base[this.tableSmt_StyleMaster.nLeadtimeColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnMcReqNull()
//        {
//            base[this.tableSmt_StyleMaster.nMcReqColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnMSCdNull()
//        {
//            base[this.tableSmt_StyleMaster.nMSCdColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnPntPONull()
//        {
//            base[this.tableSmt_StyleMaster.nPntPOColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnPOReqNull()
//        {
//            base[this.tableSmt_StyleMaster.nPOReqColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnQlNull()
//        {
//            base[this.tableSmt_StyleMaster.nQlColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnRatioNull()
//        {
//            base[this.tableSmt_StyleMaster.nRatioColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnSeasonNull()
//        {
//            base[this.tableSmt_StyleMaster.nSeasonColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnstoreNull()
//        {
//            base[this.tableSmt_StyleMaster.nstoreColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnTotOrdQtyNull()
//        {
//            base[this.tableSmt_StyleMaster.nTotOrdQtyColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnWeavingNull()
//        {
//            base[this.tableSmt_StyleMaster.nWeavingColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetPfrontNull()
//        {
//            base[this.tableSmt_StyleMaster.PfrontColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool badbk
//        {
//            get => 
//                ((bool)base[this.tableSmt_StyleMaster.badbkColumn]);
//            set
//            {
//                base[this.tableSmt_StyleMaster.badbkColumn] = value;
//            }
//            }

//            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//            public int bConf
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableSmt_StyleMaster.bConfColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'bConf' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.bConfColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public bool BGetPln
//        {
//            get => 
//                ((bool)base[this.tableSmt_StyleMaster.BGetPlnColumn]);
//            set
//            {
//                base[this.tableSmt_StyleMaster.BGetPlnColumn] = value;
//            }
//            }

//            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//            public bool bInActive
//        {
//            get => 
//                ((bool)base[this.tableSmt_StyleMaster.bInActiveColumn]);
//            set
//            {
//                base[this.tableSmt_StyleMaster.bInActiveColumn] = value;
//            }
//            }

//            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//            public bool bstk
//        {
//            get => 
//                ((bool)base[this.tableSmt_StyleMaster.bstkColumn]);
//            set
//            {
//                base[this.tableSmt_StyleMaster.bstkColumn] = value;
//            }
//            }

//            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//            public string cAuser
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableSmt_StyleMaster.cAuserColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cAuser' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.cAuserColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string ccFabtype
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableSmt_StyleMaster.ccFabtypeColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'ccFabtype' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.ccFabtypeColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cCmmt
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableSmt_StyleMaster.cCmmtColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cCmmt' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.cCmmtColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cCmp
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableSmt_StyleMaster.cCmpColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cCmp' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.cCmpColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cCnftype
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableSmt_StyleMaster.cCnftypeColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cCnftype' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.cCnftypeColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cDispStyleNo
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableSmt_StyleMaster.cDispStyleNoColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cDispStyleNo' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.cDispStyleNoColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cEpfNo
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableSmt_StyleMaster.cEpfNoColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cEpfNo' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.cEpfNoColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cExcUser
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableSmt_StyleMaster.cExcUserColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cExcUser' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.cExcUserColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cfabcomp
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableSmt_StyleMaster.cfabcompColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cfabcomp' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.cfabcompColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cFile
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableSmt_StyleMaster.cFileColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cFile' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.cFileColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public short cGmtType
//        {
//            get
//            {
//                short num;
//                try
//                {
//                    num = (short)base[this.tableSmt_StyleMaster.cGmtTypeColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cGmtType' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.cGmtTypeColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DateTime cInputDate
//        {
//            get
//            {
//                DateTime time;
//                try
//                {
//                    time = (DateTime)base[this.tableSmt_StyleMaster.cInputDateColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cInputDate' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return time;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.cInputDateColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cInputUser
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableSmt_StyleMaster.cInputUserColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cInputUser' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.cInputUserColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cLabdpcc
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableSmt_StyleMaster.cLabdpccColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cLabdpcc' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.cLabdpccColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cLcNo
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableSmt_StyleMaster.cLcNoColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cLcNo' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.cLcNoColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cPIFty
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableSmt_StyleMaster.cPIFtyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cPIFty' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.cPIFtyColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cRpt
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableSmt_StyleMaster.cRptColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cRpt' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.cRptColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cSpeOP
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableSmt_StyleMaster.cSpeOPColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cSpeOP' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.cSpeOPColumn] = value;
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
//                    str = (string)base[this.tableSmt_StyleMaster.cStyleNoColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cStyleNo' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.cStyleNoColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cszrng
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableSmt_StyleMaster.cszrngColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cszrng' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.cszrngColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string cType
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableSmt_StyleMaster.cTypeColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cType' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.cTypeColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cYnCnt
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableSmt_StyleMaster.cYnCntColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cYnCnt' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.cYnCntColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DateTime daddDt
//        {
//            get
//            {
//                DateTime time;
//                try
//                {
//                    time = (DateTime)base[this.tableSmt_StyleMaster.daddDtColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'daddDt' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return time;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.daddDtColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DateTime dbestship
//        {
//            get
//            {
//                DateTime time;
//                try
//                {
//                    time = (DateTime)base[this.tableSmt_StyleMaster.dbestshipColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'dbestship' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return time;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.dbestshipColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DateTime dBPCd
//        {
//            get
//            {
//                DateTime time;
//                try
//                {
//                    time = (DateTime)base[this.tableSmt_StyleMaster.dBPCdColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'dBPCd' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return time;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.dBPCdColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DateTime dcmdate1
//        {
//            get
//            {
//                DateTime time;
//                try
//                {
//                    time = (DateTime)base[this.tableSmt_StyleMaster.dcmdate1Column];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'dcmdate1' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return time;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.dcmdate1Column] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DateTime dcmdate2
//        {
//            get
//            {
//                DateTime time;
//                try
//                {
//                    time = (DateTime)base[this.tableSmt_StyleMaster.dcmdate2Column];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'dcmdate2' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return time;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.dcmdate2Column] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DateTime dcmdate3
//        {
//            get
//            {
//                DateTime time;
//                try
//                {
//                    time = (DateTime)base[this.tableSmt_StyleMaster.dcmdate3Column];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'dcmdate3' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return time;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.dcmdate3Column] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DateTime dcmdate4
//        {
//            get
//            {
//                DateTime time;
//                try
//                {
//                    time = (DateTime)base[this.tableSmt_StyleMaster.dcmdate4Column];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'dcmdate4' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return time;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.dcmdate4Column] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DateTime dComp
//        {
//            get
//            {
//                DateTime time;
//                try
//                {
//                    time = (DateTime)base[this.tableSmt_StyleMaster.dCompColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'dComp' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return time;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.dCompColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DateTime dConf
//        {
//            get
//            {
//                DateTime time;
//                try
//                {
//                    time = (DateTime)base[this.tableSmt_StyleMaster.dConfColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'dConf' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return time;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.dConfColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DateTime dCOShtRec
//        {
//            get
//            {
//                DateTime time;
//                try
//                {
//                    time = (DateTime)base[this.tableSmt_StyleMaster.dCOShtRecColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'dCOShtRec' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return time;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.dCOShtRecColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DateTime dCSwchRec
//        {
//            get
//            {
//                DateTime time;
//                try
//                {
//                    time = (DateTime)base[this.tableSmt_StyleMaster.dCSwchRecColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'dCSwchRec' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return time;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.dCSwchRecColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DateTime dOOshtRec
//        {
//            get
//            {
//                DateTime time;
//                try
//                {
//                    time = (DateTime)base[this.tableSmt_StyleMaster.dOOshtRecColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'dOOshtRec' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return time;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.dOOshtRecColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DateTime dstdFileRec
//        {
//            get
//            {
//                DateTime time;
//                try
//                {
//                    time = (DateTime)base[this.tableSmt_StyleMaster.dstdFileRecColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'dstdFileRec' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return time;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.dstdFileRecColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string IBck
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableSmt_StyleMaster.IBckColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'IBck' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.IBckColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public string IFnt
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tableSmt_StyleMaster.IFntColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'IFnt' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.IFntColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public short nAcct
//        {
//            get
//            {
//                short num;
//                try
//                {
//                    num = (short)base[this.tableSmt_StyleMaster.nAcctColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nAcct' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.nAcctColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public decimal nbdt
//        {
//            get => 
//                ((decimal)base[this.tableSmt_StyleMaster.nbdtColumn]);
//            set
//            {
//                base[this.tableSmt_StyleMaster.nbdtColumn] = value;
//            }
//            }

//            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//            public int nBran
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableSmt_StyleMaster.nBranColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nBran' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.nBranColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public double nCm
//        {
//            get => 
//                ((double)base[this.tableSmt_StyleMaster.nCmColumn]);
//            set
//            {
//                base[this.tableSmt_StyleMaster.nCmColumn] = value;
//            }
//            }

//            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//            public double nCM1
//        {
//            get => 
//                ((double)base[this.tableSmt_StyleMaster.nCM1Column]);
//            set
//            {
//                base[this.tableSmt_StyleMaster.nCM1Column] = value;
//            }
//            }

//            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//            public double nCM2
//        {
//            get => 
//                ((double)base[this.tableSmt_StyleMaster.nCM2Column]);
//            set
//            {
//                base[this.tableSmt_StyleMaster.nCM2Column] = value;
//            }
//            }

//            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//            public double nCM3
//        {
//            get => 
//                ((double)base[this.tableSmt_StyleMaster.nCM3Column]);
//            set
//            {
//                base[this.tableSmt_StyleMaster.nCM3Column] = value;
//            }
//            }

//            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//            public double nCM4
//        {
//            get => 
//                ((double)base[this.tableSmt_StyleMaster.nCM4Column]);
//            set
//            {
//                base[this.tableSmt_StyleMaster.nCM4Column] = value;
//            }
//            }

//            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//            public int ncolCD
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableSmt_StyleMaster.ncolCDColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'ncolCD' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.ncolCDColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public int nDept
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableSmt_StyleMaster.nDeptColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nDept' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.nDeptColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public int nExcut
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableSmt_StyleMaster.nExcutColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nExcut' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.nExcutColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public int nfabName
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableSmt_StyleMaster.nfabNameColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nfabName' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.nfabNameColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public decimal nfinSmv
//        {
//            get => 
//                ((decimal)base[this.tableSmt_StyleMaster.nfinSmvColumn]);
//            set
//            {
//                base[this.tableSmt_StyleMaster.nfinSmvColumn] = value;
//            }
//            }

//            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//            public decimal nfob
//        {
//            get => 
//                ((decimal)base[this.tableSmt_StyleMaster.nfobColumn]);
//            set
//            {
//                base[this.tableSmt_StyleMaster.nfobColumn] = value;
//            }
//            }

//            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//            public int nFrUpQty
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableSmt_StyleMaster.nFrUpQtyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nFrUpQty' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.nFrUpQtyColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public int nHrPrd
//        {
//            get => 
//                ((int)base[this.tableSmt_StyleMaster.nHrPrdColumn]);
//            set
//            {
//                base[this.tableSmt_StyleMaster.nHrPrdColumn] = value;
//            }
//            }

//            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//            public int nLeadtime
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableSmt_StyleMaster.nLeadtimeColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nLeadtime' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.nLeadtimeColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public short nLerCv
//        {
//            get => 
//                ((short)base[this.tableSmt_StyleMaster.nLerCvColumn]);
//            set
//            {
//                base[this.tableSmt_StyleMaster.nLerCvColumn] = value;
//            }
//            }

//            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//            public int nMcReq
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableSmt_StyleMaster.nMcReqColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nMcReq' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.nMcReqColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public int nMSCd
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableSmt_StyleMaster.nMSCdColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nMSCd' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.nMSCdColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public int nPk
//        {
//            get => 
//                ((int)base[this.tableSmt_StyleMaster.nPkColumn]);
//            set
//            {
//                base[this.tableSmt_StyleMaster.nPkColumn] = value;
//            }
//            }

//            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//            public double nPlnEff
//        {
//            get => 
//                ((double)base[this.tableSmt_StyleMaster.nPlnEffColumn]);
//            set
//            {
//                base[this.tableSmt_StyleMaster.nPlnEffColumn] = value;
//            }
//            }

//            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//            public int nPntPO
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableSmt_StyleMaster.nPntPOColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nPntPO' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.nPntPOColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public int nPOReq
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableSmt_StyleMaster.nPOReqColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nPOReq' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.nPOReqColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public int nQl
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableSmt_StyleMaster.nQlColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nQl' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.nQlColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public int nRatio
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableSmt_StyleMaster.nRatioColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nRatio' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.nRatioColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public int nSeason
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableSmt_StyleMaster.nSeasonColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nSeason' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.nSeasonColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public double NSMV
//        {
//            get => 
//                ((double)base[this.tableSmt_StyleMaster.NSMVColumn]);
//            set
//            {
//                base[this.tableSmt_StyleMaster.NSMVColumn] = value;
//            }
//            }

//            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//            public int nstore
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableSmt_StyleMaster.nstoreColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nstore' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.nstoreColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public int nStyleID
//        {
//            get => 
//                ((int)base[this.tableSmt_StyleMaster.nStyleIDColumn]);
//            set
//            {
//                base[this.tableSmt_StyleMaster.nStyleIDColumn] = value;
//            }
//            }

//            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//            public int nTotOrdQty
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableSmt_StyleMaster.nTotOrdQtyColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nTotOrdQty' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.nTotOrdQtyColumn] = value;
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public int nWeaving
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tableSmt_StyleMaster.nWeavingColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nWeaving' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.nWeavingColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public byte[] Pfront
//        {
//            get
//            {
//                byte[] buffer;
//                try
//                {
//                    buffer = (byte[])base[this.tableSmt_StyleMaster.PfrontColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'Pfront' in table 'Smt_StyleMaster' is DBNull.", exception);
//                }
//                return buffer;
//            }
//            set
//            {
//                base[this.tableSmt_StyleMaster.PfrontColumn] = value;
//            }
//        }
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public class Smt_StyleMasterRowChangeEvent : EventArgs
//    {
//        private DataRowAction eventAction;
//        private DataSet1.Smt_StyleMasterRow eventRow;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public Smt_StyleMasterRowChangeEvent(DataSet1.Smt_StyleMasterRow row, DataRowAction action)
//        {
//            this.eventRow = row;
//            this.eventAction = action;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataRowAction Action =>
//            this.eventAction;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataSet1.Smt_StyleMasterRow Row =>
//            this.eventRow;
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public delegate void Smt_StyleMasterRowChangeEventHandler(object sender, DataSet1.Smt_StyleMasterRowChangeEvent e);

//    [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
//    public class testdtblreportDataTable : TypedTableBase<DataSet1.testdtblreportRow>
//    {
//        private DataColumn columncColour;
//        private DataColumn columnnColNo;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event DataSet1.testdtblreportRowChangeEventHandler testdtblreportRowChanged;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event DataSet1.testdtblreportRowChangeEventHandler testdtblreportRowChanging;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event DataSet1.testdtblreportRowChangeEventHandler testdtblreportRowDeleted;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public event DataSet1.testdtblreportRowChangeEventHandler testdtblreportRowDeleting;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public testdtblreportDataTable()
//        {
//            base.TableName = "testdtblreport";
//            this.BeginInit();
//            this.InitClass();
//            this.EndInit();
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal testdtblreportDataTable(DataTable table)
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
//        protected testdtblreportDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
//        {
//            this.InitVars();
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void AddtestdtblreportRow(DataSet1.testdtblreportRow row)
//        {
//            base.Rows.Add(row);
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataSet1.testdtblreportRow AddtestdtblreportRow(int nColNo, string cColour)
//        {
//            DataSet1.testdtblreportRow row = (DataSet1.testdtblreportRow)base.NewRow();
//            row.ItemArray = new object[] { nColNo, cColour };
//            base.Rows.Add(row);
//            return row;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public override DataTable Clone()
//        {
//            DataSet1.testdtblreportDataTable table = (DataSet1.testdtblreportDataTable)base.Clone();
//            table.InitVars();
//            return table;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override DataTable CreateInstance() =>
//            new DataSet1.testdtblreportDataTable();

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override Type GetRowType() =>
//            typeof(DataSet1.testdtblreportRow);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
//        {
//            XmlSchemaComplexType type = new XmlSchemaComplexType();
//            XmlSchemaSequence sequence = new XmlSchemaSequence();
//            DataSet1 set = new DataSet1();
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
//                FixedValue = set.Namespace
//            };
//            type.Attributes.Add(attribute);
//            XmlSchemaAttribute attribute2 = new XmlSchemaAttribute
//            {
//                Name = "tableTypeName",
//                FixedValue = "testdtblreportDataTable"
//            };
//            type.Attributes.Add(attribute2);
//            type.Particle = sequence;
//            XmlSchema schemaSerializable = set.GetSchemaSerializable();
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
//            this.columnnColNo = new DataColumn("nColNo", typeof(int), null, MappingType.Element);
//            base.Columns.Add(this.columnnColNo);
//            this.columncColour = new DataColumn("cColour", typeof(string), null, MappingType.Element);
//            base.Columns.Add(this.columncColour);
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal void InitVars()
//        {
//            this.columnnColNo = base.Columns["nColNo"];
//            this.columncColour = base.Columns["cColour"];
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) =>
//            new DataSet1.testdtblreportRow(builder);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public DataSet1.testdtblreportRow NewtestdtblreportRow() =>
//            ((DataSet1.testdtblreportRow)base.NewRow());

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowChanged(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanged(e);
//            if (this.testdtblreportRowChanged != null)
//            {
//                this.testdtblreportRowChanged(this, new DataSet1.testdtblreportRowChangeEvent((DataSet1.testdtblreportRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowChanging(DataRowChangeEventArgs e)
//        {
//            base.OnRowChanging(e);
//            if (this.testdtblreportRowChanging != null)
//            {
//                this.testdtblreportRowChanging(this, new DataSet1.testdtblreportRowChangeEvent((DataSet1.testdtblreportRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        protected override void OnRowDeleted(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleted(e);
//            if (this.testdtblreportRowDeleted != null)
//            {
//                this.testdtblreportRowDeleted(this, new DataSet1.testdtblreportRowChangeEvent((DataSet1.testdtblreportRow)e.Row, e.Action));
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        protected override void OnRowDeleting(DataRowChangeEventArgs e)
//        {
//            base.OnRowDeleting(e);
//            if (this.testdtblreportRowDeleting != null)
//            {
//                this.testdtblreportRowDeleting(this, new DataSet1.testdtblreportRowChangeEvent((DataSet1.testdtblreportRow)e.Row, e.Action));
//            }
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void RemovetestdtblreportRow(DataSet1.testdtblreportRow row)
//        {
//            base.Rows.Remove(row);
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn cColourColumn =>
//            this.columncColour;

//        [Browsable(false), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public int Count =>
//            base.Rows.Count;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataSet1.testdtblreportRow this[int index] =>
//            ((DataSet1.testdtblreportRow)base.Rows[index]);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataColumn nColNoColumn =>
//            this.columnnColNo;
//    }

//    public class testdtblreportRow : DataRow
//    {
//        private DataSet1.testdtblreportDataTable tabletestdtblreport;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        internal testdtblreportRow(DataRowBuilder rb) : base(rb)
//        {
//            this.tabletestdtblreport = (DataSet1.testdtblreportDataTable)base.Table;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IscColourNull() =>
//            base.IsNull(this.tabletestdtblreport.cColourColumn);

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public bool IsnColNoNull() =>
//            base.IsNull(this.tabletestdtblreport.nColNoColumn);

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public void SetcColourNull()
//        {
//            base[this.tabletestdtblreport.cColourColumn] = Convert.DBNull;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public void SetnColNoNull()
//        {
//            base[this.tabletestdtblreport.nColNoColumn] = Convert.DBNull;
//        }

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public string cColour
//        {
//            get
//            {
//                string str;
//                try
//                {
//                    str = (string)base[this.tabletestdtblreport.cColourColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'cColour' in table 'testdtblreport' is DBNull.", exception);
//                }
//                return str;
//            }
//            set
//            {
//                base[this.tabletestdtblreport.cColourColumn] = value;
//            }
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public int nColNo
//        {
//            get
//            {
//                int num;
//                try
//                {
//                    num = (int)base[this.tabletestdtblreport.nColNoColumn];
//                }
//                catch (InvalidCastException exception)
//                {
//                    throw new StrongTypingException("The value for column 'nColNo' in table 'testdtblreport' is DBNull.", exception);
//                }
//                return num;
//            }
//            set
//            {
//                base[this.tabletestdtblreport.nColNoColumn] = value;
//            }
//        }
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public class testdtblreportRowChangeEvent : EventArgs
//    {
//        private DataRowAction eventAction;
//        private DataSet1.testdtblreportRow eventRow;

//        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//        public testdtblreportRowChangeEvent(DataSet1.testdtblreportRow row, DataRowAction action)
//        {
//            this.eventRow = row;
//            this.eventAction = action;
//        }

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataRowAction Action =>
//            this.eventAction;

//        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
//        public DataSet1.testdtblreportRow Row =>
//            this.eventRow;
//    }

//    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
//    public delegate void testdtblreportRowChangeEventHandler(object sender, DataSet1.testdtblreportRowChangeEvent e);
}
