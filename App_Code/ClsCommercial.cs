using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Web.UI.WebControls;

public class ClsCommercial
{
    private BLLInventory blinventory = new BLLInventory();
    private BLL bll = new BLL();
    private SqlConnection cn = GetWay.SpecFoCon;
    private SqlConnection cnInventory = GetWay.SpecFo_Inventorycon;

    public DateTime dateformat(string tt)
    {
        string str = tt;
        char[] separator = new char[] { '/' };
        string[] strArray = str.Split(separator);
        string str2 = strArray[0];
        string str3 = strArray[1];
        string str4 = strArray[2];
        string str5 = null;
        switch (DateTimeFormatInfo.CurrentInfo.ShortDatePattern.ToString())
        {
            case "dd/MM/yyyy":
                str5 = str2 + "/" + str3 + "/" + str4;
                break;

            case "dd/MM/yy":
                str5 = str2 + "/" + str3 + "/" + str4;
                break;

            case "d/M/yy":
                str5 = str2 + "/" + str3 + "/" + str4;
                break;

            case "d.M.yy":
                str5 = str2 + "." + str3 + "." + str4;
                break;

            case "M/d/yyyy":
                str5 = str3 + "/" + str2 + "/" + str4;
                break;

            case "M/d/yy":
                str5 = str3 + "/" + str2 + "/" + str4;
                break;

            case "MM/dd/yy":
                str5 = str3 + "/" + str2 + "/" + str4;
                break;

            case "MM/dd/yyyy":
                str5 = str3 + "/" + str2 + "/" + str4;
                break;

            case "yy/MM/dd":
                str5 = str4 + "/" + str3 + "/" + str2;
                break;

            case "yyyy-MM-dd":
                str5 = str4 + "-" + str3 + "-" + str2;
                break;

            case "dd-MMM-yy":
                str5 = str2 + "-" + str3 + "-" + str4;
                break;
        }
        return Convert.ToDateTime(str5);
    }

    public void Delete_Acceptance(string Acceptno)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Com_Acceptance_Delete", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@Accept_No", Acceptno);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Delete_B2BLC_PI(string Lcno)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Com_B2BLC_PI_Delete", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@B2BLC_No", Lcno);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Delete_ExportInvoice(string invoiceNo)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Com_Export_StyleInfo_Delete", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@InvoiceNO", invoiceNo);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Delete_ExportInvoice1(string invoiceNo, int StyleId)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Com_Export_StyleInfo_Delete1", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@InvoiceNO", invoiceNo);
        command.Parameters.AddWithValue("@nStyleID", StyleId);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Delete_MasterContractQty(int SlNo)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Com_ContractInfoQtyDtl_Delete", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@SlNo", SlNo);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Delete_MasterContractStyle(string contractno)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Com_ContractInfoStyle_Delete", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@Contract_No", contractno);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Delete_PIDetail(string PINO)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_PIDetails_Delete", this.cnInventory);
        if (this.cnInventory.State == ConnectionState.Closed)
        {
            this.cnInventory.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@PI_No", PINO);
        command.ExecuteNonQuery();
        if (this.cnInventory.State == ConnectionState.Open)
        {
            this.cnInventory.Close();
        }
    }

    public DataSet get_Informationdataset(string sqlstatement)
    {
        SqlDataAdapter adapter = new SqlDataAdapter(sqlstatement, this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet);
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        return dataSet;
    }

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

    public void Save_Acceptance(string acceptanceno, string bblc, string invoice, string accptdt, string accptValue, string maturitydt, string paymode, string createduser, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Com_Acceptance_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@Accept_No", acceptanceno);
        command.Parameters.AddWithValue("@BBLC_No", bblc);
        command.Parameters.AddWithValue("@InvoiceNo", invoice);
        if (!string.IsNullOrEmpty(accptdt))
        {
            DateTime time = this.dateformat(accptdt);
            command.Parameters.AddWithValue("@Accept_Date", time);
        }
        else
        {
            command.Parameters.AddWithValue("@Accept_Date", DBNull.Value);
        }
        command.Parameters["@Accept_Date"].SqlDbType = SqlDbType.SmallDateTime;
        command.Parameters.AddWithValue("@Accept_Value", accptValue);
        if (!string.IsNullOrEmpty(maturitydt))
        {
            DateTime time2 = this.dateformat(maturitydt);
            command.Parameters.AddWithValue("@Maturity_Date", time2);
        }
        else
        {
            command.Parameters.AddWithValue("@Maturity_Date", DBNull.Value);
        }
        command.Parameters["@Maturity_Date"].SqlDbType = SqlDbType.SmallDateTime;
        command.Parameters.AddWithValue("@Payment_Mode", paymode);
        command.Parameters.AddWithValue("@Created_By", createduser);
        command.ExecuteNonQuery();
        lbl.Text = "Saved Successfully";
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_B2BLC(string BuyerID, string SeasonID, string Lc_NO_Status, string MasterLCNo, string B2BLCNo, string Opening_Date, string LastShipment_Date, string Amendment_Date, string Expire_Date, string Benificiery, string Doc_Receive_Date, string Currency, string B2BLC_Value, string Issuing_Bank, string Receiving_Bank, string Maximum, string Bank_Charge, string Status, string Create_user, string Remarks, int BBLC_Amandment, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Com_B2BLC_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@BuyerID", BuyerID);
        command.Parameters.AddWithValue("@SeasonID", SeasonID);
        if (!string.IsNullOrEmpty(Lc_NO_Status))
        {
            command.Parameters.AddWithValue("@Lc_NO_Status", Lc_NO_Status);
        }
        else
        {
            command.Parameters.AddWithValue("@Lc_NO_Status", "");
        }
        command.Parameters.AddWithValue("@MasterLCNo", MasterLCNo);
        command.Parameters.AddWithValue("@B2BLCNo", B2BLCNo);
        if (!string.IsNullOrEmpty(Opening_Date))
        {
            DateTime time = this.dateformat(Opening_Date);
            command.Parameters.AddWithValue("@Opening_Date", time);
        }
        else
        {
            command.Parameters.AddWithValue("@Opening_Date", DBNull.Value);
        }
        command.Parameters["@Opening_Date"].SqlDbType = SqlDbType.SmallDateTime;
        if (!string.IsNullOrEmpty(LastShipment_Date))
        {
            DateTime time2 = this.dateformat(LastShipment_Date);
            command.Parameters.AddWithValue("@LastShipment_Date", time2);
        }
        else
        {
            command.Parameters.AddWithValue("@LastShipment_Date", DBNull.Value);
        }
        command.Parameters["@LastShipment_Date"].SqlDbType = SqlDbType.SmallDateTime;
        if (!string.IsNullOrEmpty(Amendment_Date))
        {
            DateTime time3 = this.dateformat(Amendment_Date);
            command.Parameters.AddWithValue("@Amendment_Date", time3);
        }
        else
        {
            command.Parameters.AddWithValue("@Amendment_Date", DBNull.Value);
        }
        command.Parameters["@Amendment_Date"].SqlDbType = SqlDbType.SmallDateTime;
        if (!string.IsNullOrEmpty(Expire_Date))
        {
            DateTime time4 = this.dateformat(Expire_Date);
            command.Parameters.AddWithValue("@Expire_Date", time4);
        }
        else
        {
            command.Parameters.AddWithValue("@Expire_Date", DBNull.Value);
        }
        command.Parameters["@Expire_Date"].SqlDbType = SqlDbType.SmallDateTime;
        if (!string.IsNullOrEmpty(Benificiery))
        {
            command.Parameters.AddWithValue("@Benificiery", Benificiery);
        }
        else
        {
            command.Parameters.AddWithValue("@Benificiery", DBNull.Value);
        }
        command.Parameters["@Benificiery"].SqlDbType = SqlDbType.Int;
        if (!string.IsNullOrEmpty(Doc_Receive_Date))
        {
            DateTime time5 = this.dateformat(Doc_Receive_Date);
            command.Parameters.AddWithValue("@Doc_Receive_Date", time5);
        }
        else
        {
            command.Parameters.AddWithValue("@Doc_Receive_Date", DBNull.Value);
        }
        command.Parameters["@Doc_Receive_Date"].SqlDbType = SqlDbType.SmallDateTime;
        if (!string.IsNullOrEmpty(Currency))
        {
            command.Parameters.AddWithValue("@Currency", Currency);
        }
        else
        {
            command.Parameters.AddWithValue("@Currency", "");
        }
        if (!string.IsNullOrEmpty(B2BLC_Value))
        {
            command.Parameters.AddWithValue("@B2BLC_Value", B2BLC_Value);
        }
        else
        {
            command.Parameters.AddWithValue("@B2BLC_Value", "0");
        }
        if (!string.IsNullOrEmpty(Issuing_Bank))
        {
            command.Parameters.AddWithValue("@Issuing_Bank", Issuing_Bank);
        }
        else
        {
            command.Parameters.AddWithValue("@Issuing_Bank", DBNull.Value);
        }
        command.Parameters["@Issuing_Bank"].SqlDbType = SqlDbType.Int;
        if (!string.IsNullOrEmpty(Receiving_Bank))
        {
            command.Parameters.AddWithValue("@Receiving_Bank", Receiving_Bank);
        }
        else
        {
            command.Parameters.AddWithValue("@Receiving_Bank", DBNull.Value);
        }
        command.Parameters["@Receiving_Bank"].SqlDbType = SqlDbType.Int;
        if (!string.IsNullOrEmpty(Maximum))
        {
            command.Parameters.AddWithValue("@Maximum", Maximum);
        }
        else
        {
            command.Parameters.AddWithValue("@Maximum", DBNull.Value);
        }
        command.Parameters["@Maximum"].SqlDbType = SqlDbType.Int;
        if (!string.IsNullOrEmpty(Bank_Charge))
        {
            command.Parameters.AddWithValue("@Bank_Charge", Bank_Charge);
        }
        else
        {
            command.Parameters.AddWithValue("@Bank_Charge", DBNull.Value);
        }
        command.Parameters["@Bank_Charge"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(Status))
        {
            command.Parameters.AddWithValue("@Status", Status);
        }
        else
        {
            command.Parameters.AddWithValue("@Status", "");
        }
        command.Parameters.AddWithValue("@Create_user", Create_user);
        command.Parameters.AddWithValue("@Remarks", Remarks);
        command.Parameters.AddWithValue("@BBLC_Amandment", BBLC_Amandment);
        command.ExecuteNonQuery();
        lbl.Text = "Saved Successfully";
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_B2BLC_PI(string lcno, string pino, string supplierid, string pidate, string pivalue, int BBLC_Amandment, int chk)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Com_B2BLC_PI_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@B2BLC_No", lcno);
        command.Parameters.AddWithValue("@PI_NO", pino);
        command.Parameters.AddWithValue("@SupplierID", supplierid);
        if (!string.IsNullOrEmpty(pidate))
        {
            DateTime time = this.dateformat(pidate);
            command.Parameters.AddWithValue("@PI_Dt", time);
        }
        else
        {
            command.Parameters.AddWithValue("@PI_Dt", DBNull.Value);
        }
        command.Parameters["@PI_Dt"].SqlDbType = SqlDbType.SmallDateTime;
        if (!string.IsNullOrEmpty(pivalue))
        {
            command.Parameters.AddWithValue("@PI_Value", pivalue);
        }
        else
        {
            command.Parameters.AddWithValue("@PI_Value", "0");
        }
        command.Parameters.AddWithValue("@BBLC_Amandment", BBLC_Amandment);
        command.Parameters.AddWithValue("@chk", chk);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_ContractInfo(string BuyerID, string seasonId, string companyid, string cContractNo, string nIssuingBank, string nReceivingBank, string nNegotiableBank, string B2BLc, string cPaymentTerm, string cShipMode, string dOpeningDate, string dAmendmentDate, string dLastShipDate, string dExpireDate, string nCurrencyType, string cUDVersion, string nFrightValue, string cNotifyParti, string UDNO, string nInsuranceValue, string dPartialshipment, string Created_User, string TotalPOQty, string ContractValue, string totalCommission, string CalculateValue, string Status, int AmdNo, int Payment_Mode, string Salescontno, string Prcnt, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Com_ContractInfo_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        if (!string.IsNullOrEmpty(BuyerID))
        {
            command.Parameters.AddWithValue("@BuyerID", BuyerID);
        }
        else
        {
            command.Parameters.AddWithValue("@BuyerID", DBNull.Value);
        }
        command.Parameters["@BuyerID"].SqlDbType = SqlDbType.Int;
        if (!string.IsNullOrEmpty(seasonId))
        {
            command.Parameters.AddWithValue("@SeasonID", seasonId);
        }
        else
        {
            command.Parameters.AddWithValue("@SeasonID", DBNull.Value);
        }
        command.Parameters["@SeasonID"].SqlDbType = SqlDbType.Int;
        if (!string.IsNullOrEmpty(companyid))
        {
            command.Parameters.AddWithValue("@CompanyID", companyid);
        }
        else
        {
            command.Parameters.AddWithValue("@CompanyID", DBNull.Value);
        }
        command.Parameters["@CompanyID"].SqlDbType = SqlDbType.Int;
        command.Parameters.AddWithValue("@cContractNo", cContractNo);
        if (!string.IsNullOrEmpty(nIssuingBank))
        {
            command.Parameters.AddWithValue("@nIssuingBank", nIssuingBank);
        }
        else
        {
            command.Parameters.AddWithValue("@nIssuingBank", DBNull.Value);
        }
        command.Parameters["@nIssuingBank"].SqlDbType = SqlDbType.Int;
        if (!string.IsNullOrEmpty(nReceivingBank))
        {
            command.Parameters.AddWithValue("@nReceivingBank", nReceivingBank);
        }
        else
        {
            command.Parameters.AddWithValue("@nReceivingBank", DBNull.Value);
        }
        command.Parameters["@nReceivingBank"].SqlDbType = SqlDbType.Int;
        if (!string.IsNullOrEmpty(nNegotiableBank))
        {
            command.Parameters.AddWithValue("@nNegotiableBank", nNegotiableBank);
        }
        else
        {
            command.Parameters.AddWithValue("@nNegotiableBank", DBNull.Value);
        }
        command.Parameters["@nNegotiableBank"].SqlDbType = SqlDbType.Int;
        command.Parameters.AddWithValue("@B2BLc", B2BLc);
        command.Parameters.AddWithValue("@cPaymentTerm", cPaymentTerm);
        command.Parameters.AddWithValue("@cShipMode", cShipMode);
        if (!string.IsNullOrEmpty(dOpeningDate))
        {
            DateTime time = this.dateformat(dOpeningDate);
            command.Parameters.AddWithValue("@dOpeningDate", time);
        }
        else
        {
            command.Parameters.AddWithValue("@dOpeningDate", DBNull.Value);
        }
        command.Parameters["@dOpeningDate"].SqlDbType = SqlDbType.SmallDateTime;
        if (!string.IsNullOrEmpty(dAmendmentDate))
        {
            DateTime time2 = this.dateformat(dAmendmentDate);
            command.Parameters.AddWithValue("@dAmendmentDate", time2);
        }
        else
        {
            command.Parameters.AddWithValue("@dAmendmentDate", DBNull.Value);
        }
        command.Parameters["@dAmendmentDate"].SqlDbType = SqlDbType.SmallDateTime;
        if (!string.IsNullOrEmpty(dLastShipDate))
        {
            DateTime time3 = this.dateformat(dLastShipDate);
            command.Parameters.AddWithValue("@dLastShipDate", time3);
        }
        else
        {
            command.Parameters.AddWithValue("@dLastShipDate", DBNull.Value);
        }
        command.Parameters["@dLastShipDate"].SqlDbType = SqlDbType.SmallDateTime;
        if (!string.IsNullOrEmpty(dExpireDate))
        {
            DateTime time4 = this.dateformat(dExpireDate);
            command.Parameters.AddWithValue("@dExpireDate", time4);
        }
        else
        {
            command.Parameters.AddWithValue("@dExpireDate", DBNull.Value);
        }
        command.Parameters["@dExpireDate"].SqlDbType = SqlDbType.SmallDateTime;
        command.Parameters.AddWithValue("@nCurrencyType", nCurrencyType);
        command.Parameters.AddWithValue("@cUDVersion", cUDVersion);
        if (!string.IsNullOrEmpty(nFrightValue))
        {
            command.Parameters.AddWithValue("@nFrightValue", nFrightValue);
        }
        else
        {
            command.Parameters.AddWithValue("@nFrightValue", "0.00");
        }
        command.Parameters.AddWithValue("@cNotifyParti", cNotifyParti);
        command.Parameters.AddWithValue("@UDNO", UDNO);
        if (!string.IsNullOrEmpty(nInsuranceValue))
        {
            command.Parameters.AddWithValue("@nInsuranceValue", nInsuranceValue);
        }
        else
        {
            command.Parameters.AddWithValue("@nInsuranceValue", "0.00");
        }
        command.Parameters.AddWithValue("@dPartialshipment", dPartialshipment);
        command.Parameters.AddWithValue("@Created_User", Created_User);
        if (!string.IsNullOrEmpty(TotalPOQty))
        {
            command.Parameters.AddWithValue("@TotalPOQty", TotalPOQty);
        }
        else
        {
            command.Parameters.AddWithValue("@TotalPOQty", "0.00");
        }
        if (!string.IsNullOrEmpty(ContractValue))
        {
            command.Parameters.AddWithValue("@ContractValue", ContractValue);
        }
        else
        {
            command.Parameters.AddWithValue("@ContractValue", "0.00");
        }
        if (!string.IsNullOrEmpty(totalCommission))
        {
            command.Parameters.AddWithValue("@totalCommission", totalCommission);
        }
        else
        {
            command.Parameters.AddWithValue("@totalCommission", "0.00");
        }
        if (!string.IsNullOrEmpty(CalculateValue))
        {
            command.Parameters.AddWithValue("@CalculateValue", CalculateValue);
        }
        else
        {
            command.Parameters.AddWithValue("@CalculateValue", "0.00");
        }
        if (!string.IsNullOrEmpty(Status))
        {
            command.Parameters.AddWithValue("@Status", Status);
        }
        else
        {
            command.Parameters.AddWithValue("@Status", "");
        }
        command.Parameters.AddWithValue("@AmandmentNO", AmdNo);
        command.Parameters.AddWithValue("@Payment_Mode", Payment_Mode);
        command.Parameters.AddWithValue("@Salescontno", Salescontno);
        command.Parameters.AddWithValue("@Prcnt", Prcnt);
        if (command.ExecuteNonQuery() > 0)
        {
            lbl.Text = "Saved Successfully";
        }
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_ExporInvoiceStyle(string InvoiceNo, int StyleID, string Qty, string Fob)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Com_Export_StyleInfo_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@InvoiceNO", InvoiceNo);
        command.Parameters.AddWithValue("@nStyleID", StyleID);
        if (!string.IsNullOrEmpty(Qty))
        {
            command.Parameters.AddWithValue("@StyleQty", Qty);
        }
        else
        {
            command.Parameters.AddWithValue("@StyleQty", "0.00");
        }
        if (!string.IsNullOrEmpty(Fob))
        {
            command.Parameters.AddWithValue("@FOB", Fob);
        }
        else
        {
            command.Parameters.AddWithValue("@FOB", "0.00");
        }
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_ExportInvoice(string Invoice_No, string Invoice_Date, string Master_LCNO, string Factory, string Consignee, string Bill_No, string Bill_Date, string Ship_Mode, string Port_Of_Loading, string Final_Destination, string Career_By, string Payment_Term, string Created_By, string InvoiceValue, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Com_Export_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@Invoice_No", Invoice_No);
        if (!string.IsNullOrEmpty(Invoice_Date))
        {
            DateTime time = this.dateformat(Invoice_Date);
            command.Parameters.AddWithValue("@Invoice_Date", time);
        }
        else
        {
            command.Parameters.AddWithValue("@Invoice_Date", DBNull.Value);
        }
        command.Parameters["@Invoice_Date"].SqlDbType = SqlDbType.SmallDateTime;
        command.Parameters.AddWithValue("@Master_LCNO", Master_LCNO);
        if (!string.IsNullOrEmpty(Factory))
        {
            command.Parameters.AddWithValue("@Factory", Factory);
        }
        else
        {
            command.Parameters.AddWithValue("@Factory", DBNull.Value);
        }
        command.Parameters["@Factory"].SqlDbType = SqlDbType.Int;
        if (!string.IsNullOrEmpty(Consignee))
        {
            command.Parameters.AddWithValue("@Consignee", Consignee);
        }
        else
        {
            command.Parameters.AddWithValue("@Consignee", DBNull.Value);
        }
        command.Parameters["@Consignee"].SqlDbType = SqlDbType.Int;
        command.Parameters.AddWithValue("@Bill_No", Bill_No);
        if (!string.IsNullOrEmpty(Bill_Date))
        {
            DateTime time2 = this.dateformat(Bill_Date);
            command.Parameters.AddWithValue("@Bill_Date", time2);
        }
        else
        {
            command.Parameters.AddWithValue("@Bill_Date", DBNull.Value);
        }
        command.Parameters["@Bill_Date"].SqlDbType = SqlDbType.SmallDateTime;
        command.Parameters.AddWithValue("@Ship_Mode", Ship_Mode);
        command.Parameters.AddWithValue("@Port_Of_Loading", Port_Of_Loading);
        command.Parameters.AddWithValue("@Final_Destination", Final_Destination);
        command.Parameters.AddWithValue("@Career_By", Career_By);
        if (!string.IsNullOrEmpty(Payment_Term))
        {
            command.Parameters.AddWithValue("@Payment_Term", Payment_Term);
        }
        else
        {
            command.Parameters.AddWithValue("@Payment_Term", DBNull.Value);
        }
        command.Parameters["@Payment_Term"].SqlDbType = SqlDbType.Int;
        command.Parameters.AddWithValue("@Created_By", Created_By);
        if (!string.IsNullOrEmpty(InvoiceValue))
        {
            command.Parameters.AddWithValue("@Invoice_Value", InvoiceValue);
        }
        else
        {
            command.Parameters.AddWithValue("@Invoice_Value", "0.0");
        }
        command.ExecuteNonQuery();
        lbl.Text = "Saved Successfully";
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
    }

    public void Save_Import(string Supplier_ID, string B2BLC_No, string LCValue, string Balance, string IMP_InvoiceNo, string Imp_InvoiceDate, string Invoice_Value, string ShipMode, string BLAWBNO, string BLDate, string ContainerNo, string CarierNo, string Agent, string MVessel_Name, string MVessel_ETD, string FVessel_Name, string FVessel_ETD, string NNDocs_Date, string Original_Date, string OriginalCNF, string Goods_Inhouse, string BillOfEntry, string Created_user, string FVessel_Eta, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Com_Import_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@Supplier_ID", Supplier_ID);
        command.Parameters.AddWithValue("@B2BLC_No", B2BLC_No);
        if (!string.IsNullOrEmpty(LCValue))
        {
            command.Parameters.AddWithValue("@LCValue", LCValue);
        }
        else
        {
            command.Parameters.AddWithValue("@LCValue", "0");
        }
        if (!string.IsNullOrEmpty(Balance))
        {
            command.Parameters.AddWithValue("@Balance", Balance);
        }
        else
        {
            command.Parameters.AddWithValue("@Balance", "0");
        }
        command.Parameters.AddWithValue("@IMP_InvoiceNo", IMP_InvoiceNo);
        if (!string.IsNullOrEmpty(Imp_InvoiceDate))
        {
            DateTime time = this.dateformat(Imp_InvoiceDate);
            command.Parameters.AddWithValue("@Imp_InvoiceDate", time);
        }
        else
        {
            command.Parameters.AddWithValue("@Imp_InvoiceDate", DBNull.Value);
        }
        command.Parameters["@Imp_InvoiceDate"].SqlDbType = SqlDbType.SmallDateTime;
        if (!string.IsNullOrEmpty(Invoice_Value))
        {
            command.Parameters.AddWithValue("@Invoice_Value", Invoice_Value);
        }
        else
        {
            command.Parameters.AddWithValue("@Invoice_Value", "0");
        }
        command.Parameters.AddWithValue("@ShipMode", ShipMode);
        command.Parameters.AddWithValue("@BLAWBNO", BLAWBNO);
        if (!string.IsNullOrEmpty(BLDate))
        {
            DateTime time2 = this.dateformat(BLDate);
            command.Parameters.AddWithValue("@BLDate", time2);
        }
        else
        {
            command.Parameters.AddWithValue("@BLDate", DBNull.Value);
        }
        command.Parameters["@BLDate"].SqlDbType = SqlDbType.SmallDateTime;
        command.Parameters.AddWithValue("@ContainerNo", ContainerNo);
        command.Parameters.AddWithValue("@CarierNo", CarierNo);
        command.Parameters.AddWithValue("@Agent", Agent);
        command.Parameters.AddWithValue("@MVessel_Name", MVessel_Name);
        if (!string.IsNullOrEmpty(MVessel_ETD))
        {
            DateTime time3 = this.dateformat(MVessel_ETD);
            command.Parameters.AddWithValue("@MVessel_ETD", time3);
        }
        else
        {
            command.Parameters.AddWithValue("@MVessel_ETD", DBNull.Value);
        }
        command.Parameters["@MVessel_ETD"].SqlDbType = SqlDbType.SmallDateTime;
        command.Parameters.AddWithValue("@FVessel_Name", FVessel_Name);
        if (!string.IsNullOrEmpty(FVessel_ETD))
        {
            DateTime time4 = this.dateformat(FVessel_ETD);
            command.Parameters.AddWithValue("@FVessel_ETD", time4);
        }
        else
        {
            command.Parameters.AddWithValue("@FVessel_ETD", DBNull.Value);
        }
        command.Parameters["@FVessel_ETD"].SqlDbType = SqlDbType.SmallDateTime;
        if (!string.IsNullOrEmpty(NNDocs_Date))
        {
            DateTime time5 = this.dateformat(NNDocs_Date);
            command.Parameters.AddWithValue("@NNDocs_Date", time5);
        }
        else
        {
            command.Parameters.AddWithValue("@NNDocs_Date", DBNull.Value);
        }
        command.Parameters["@NNDocs_Date"].SqlDbType = SqlDbType.SmallDateTime;
        if (!string.IsNullOrEmpty(Original_Date))
        {
            DateTime time6 = this.dateformat(Original_Date);
            command.Parameters.AddWithValue("@Original_Date", time6);
        }
        else
        {
            command.Parameters.AddWithValue("@Original_Date", DBNull.Value);
        }
        command.Parameters["@Original_Date"].SqlDbType = SqlDbType.SmallDateTime;
        if (!string.IsNullOrEmpty(OriginalCNF))
        {
            DateTime time7 = this.dateformat(OriginalCNF);
            command.Parameters.AddWithValue("@OriginalCNF", time7);
        }
        else
        {
            command.Parameters.AddWithValue("@OriginalCNF", DBNull.Value);
        }
        command.Parameters["@OriginalCNF"].SqlDbType = SqlDbType.SmallDateTime;
        if (!string.IsNullOrEmpty(Goods_Inhouse))
        {
            DateTime time8 = this.dateformat(Goods_Inhouse);
            command.Parameters.AddWithValue("@Goods_Inhouse", time8);
        }
        else
        {
            command.Parameters.AddWithValue("@Goods_Inhouse", DBNull.Value);
        }
        command.Parameters["@Goods_Inhouse"].SqlDbType = SqlDbType.SmallDateTime;
        if (!string.IsNullOrEmpty(BillOfEntry))
        {
            DateTime time9 = this.dateformat(BillOfEntry);
            command.Parameters.AddWithValue("@BillOfEntry", time9);
        }
        else
        {
            command.Parameters.AddWithValue("@BillOfEntry", DBNull.Value);
        }
        command.Parameters["@BillOfEntry"].SqlDbType = SqlDbType.SmallDateTime;
        command.Parameters.AddWithValue("@Created_user", Created_user);
        if (!string.IsNullOrEmpty(FVessel_Eta))
        {
            DateTime time10 = this.dateformat(FVessel_Eta);
            command.Parameters.AddWithValue("@FVessel_Eta", time10);
        }
        else
        {
            command.Parameters.AddWithValue("@FVessel_Eta", DBNull.Value);
        }
        command.Parameters["@FVessel_Eta"].SqlDbType = SqlDbType.SmallDateTime;
        if (command.ExecuteNonQuery() > 0)
        {
            lbl.Text = "Saved Successfully";
        }
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_MasterContractQty(string ContractNo, string Quantity, string ContractValue, string TotalComission, string CalculateValue)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Com_ContractInfoQtyDtl_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@ContractNo", ContractNo);
        if (!string.IsNullOrEmpty(Quantity))
        {
            command.Parameters.AddWithValue("@Quantity", Quantity);
        }
        else
        {
            command.Parameters.AddWithValue("@Quantity", "0");
        }
        command.Parameters["@Quantity"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(ContractValue))
        {
            command.Parameters.AddWithValue("@ContractValue", ContractValue);
        }
        else
        {
            command.Parameters.AddWithValue("@ContractValue", "0");
        }
        command.Parameters["@ContractValue"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(TotalComission))
        {
            command.Parameters.AddWithValue("@TotalComission", TotalComission);
        }
        else
        {
            command.Parameters.AddWithValue("@TotalComission", "0");
        }
        command.Parameters["@TotalComission"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(CalculateValue))
        {
            command.Parameters.AddWithValue("@CalculateValue", CalculateValue);
        }
        else
        {
            command.Parameters.AddWithValue("@CalculateValue", "0");
        }
        command.Parameters["@CalculateValue"].SqlDbType = SqlDbType.Decimal;
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_MasterContractStyle(string ContNo, string StyleId, string user, int Amandment, string Lot, int chkbx)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Com_ContractInfoStyle_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@Contract_No", ContNo);
        command.Parameters.AddWithValue("@StyleID", StyleId);
        command.Parameters.AddWithValue("@Create_By", user);
        command.Parameters.AddWithValue("@AmandmentNO", Amandment);
        command.Parameters.AddWithValue("@Lot", Lot);
        command.Parameters.AddWithValue("@chkbx", chkbx);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_Payment(int compID, int SupplierID, string B2BLC, string bankRefno, string bankrefDate, string MaturityDate, decimal BillValues, string UserName, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Com_Payment_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@Company_ID", compID);
        command.Parameters.AddWithValue("@Supplier_ID", SupplierID);
        command.Parameters.AddWithValue("@B2BLC_No", B2BLC);
        command.Parameters.AddWithValue("@BankRefNo", bankRefno);
        if (!string.IsNullOrEmpty(bankrefDate))
        {
            DateTime time = this.dateformat(bankrefDate);
            command.Parameters.AddWithValue("@BankRefDate", time);
        }
        else
        {
            command.Parameters.AddWithValue("@BankRefDate", DBNull.Value);
        }
        command.Parameters["@BankRefDate"].SqlDbType = SqlDbType.SmallDateTime;
        if (!string.IsNullOrEmpty(MaturityDate))
        {
            DateTime time2 = this.dateformat(MaturityDate);
            command.Parameters.AddWithValue("@Maturity_Date", time2);
        }
        else
        {
            command.Parameters.AddWithValue("@Maturity_Date", DBNull.Value);
        }
        command.Parameters["@Maturity_Date"].SqlDbType = SqlDbType.SmallDateTime;
        command.Parameters.AddWithValue("@Bill_Values", BillValues);
        command.Parameters.AddWithValue("@Created_User", UserName);
        command.ExecuteNonQuery();
        lbl.Text = "Saved Successfully";
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_PaymentMode(string PaymentMode, string Username, Label lbl)
    {
        SqlCommand command = new SqlCommand("select Payment_Mode from Smt_PaymentMode where Payment_Mode='" + PaymentMode.Trim() + "'", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        SqlDataReader reader = command.ExecuteReader();
        if (reader.Read())
        {
            lbl.Text = "Already Exist";
            reader.Close();
        }
        else
        {
            reader.Close();
            SqlCommand command2 = new SqlCommand("Sp_Smt_PaymentMode_Save", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@Payment_Term", PaymentMode);
            command2.Parameters.AddWithValue("@Created_User", Username);
            command2.ExecuteNonQuery();
            lbl.Text = "Saved Successfully";
            if (this.cn.State == ConnectionState.Closed)
            {
                this.cn.Open();
            }
        }
    }

    public void Save_PaymentTerm(string PaymentTerm, string Username, Label lbl)
    {
        SqlCommand command = new SqlCommand("select Payment_Term from Smt_PaymentTerm where Payment_Term='" + PaymentTerm.Trim() + "'", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        SqlDataReader reader = command.ExecuteReader();
        if (reader.Read())
        {
            lbl.Text = "Already Exist";
            reader.Close();
        }
        else
        {
            reader.Close();
            SqlCommand command2 = new SqlCommand("Sp_Smt_PaymentTerm_Save", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@Payment_Term", PaymentTerm);
            command2.Parameters.AddWithValue("@Created_User", Username);
            command2.ExecuteNonQuery();
            lbl.Text = "Saved Successfully";
            if (this.cn.State == ConnectionState.Closed)
            {
                this.cn.Open();
            }
        }
    }

    public void Save_PIDetails(string PIID, string PONO, int ItemCode, string ItemDesc, string Size, string Color, string Article, string Dimension, string Unit, string Quantity, string Price, string Value, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_PIDetails_Save", this.cnInventory);
        if (this.cnInventory.State == ConnectionState.Closed)
        {
            this.cnInventory.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@PI_No", PIID);
        command.Parameters.AddWithValue("@PO_No", PONO);
        command.Parameters.AddWithValue("@ItemCode", ItemCode);
        command.Parameters.AddWithValue("@ItemDesc", ItemDesc);
        command.Parameters.AddWithValue("@Size", Size);
        command.Parameters.AddWithValue("@Color", Color);
        command.Parameters.AddWithValue("@Article", Article);
        command.Parameters.AddWithValue("@Dimension", Dimension);
        command.Parameters.AddWithValue("@Unit", Unit);
        command.Parameters.AddWithValue("@Quantity", Quantity);
        command.Parameters.AddWithValue("@Price", Price);
        command.Parameters.AddWithValue("@Value", Value);
        command.ExecuteNonQuery();
        if (this.cnInventory.State == ConnectionState.Open)
        {
            this.cnInventory.Close();
        }
        lbl.Text = "Saved Successfully";
    }

    public void Save_PIMaster(string Supplier_ID, string PINo, string PIdate, string ShipmentDate, string Currency, string User, string totalval, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_PIMaster_Save", this.cnInventory);
        if (this.cnInventory.State == ConnectionState.Closed)
        {
            this.cnInventory.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@Supplier_ID", Supplier_ID);
        command.Parameters.AddWithValue("@PI_No", PINo);
        if (!string.IsNullOrEmpty(PIdate))
        {
            DateTime time = this.dateformat(PIdate);
            command.Parameters.AddWithValue("@PI_date", time);
        }
        else
        {
            command.Parameters.AddWithValue("@PI_date", DBNull.Value);
        }
        command.Parameters["@PI_date"].SqlDbType = SqlDbType.SmallDateTime;
        if (!string.IsNullOrEmpty(ShipmentDate))
        {
            DateTime time2 = this.dateformat(ShipmentDate);
            command.Parameters.AddWithValue("@Shipment_Date", time2);
        }
        else
        {
            command.Parameters.AddWithValue("@Shipment_Date", DBNull.Value);
        }
        command.Parameters["@Shipment_Date"].SqlDbType = SqlDbType.SmallDateTime;
        command.Parameters.AddWithValue("@Currency", Currency);
        command.Parameters.AddWithValue("@Create_User", User);
        if (!string.IsNullOrEmpty(totalval))
        {
            command.Parameters.AddWithValue("@PI_Total", totalval);
        }
        else
        {
            command.Parameters.AddWithValue("@PI_Total", "0.00");
        }
        command.ExecuteNonQuery();
        lbl.Text = "Saved Successfully";
        if (this.cnInventory.State == ConnectionState.Open)
        {
            this.cnInventory.Close();
        }
    }

    public void Update_AcceptanceInvoice(string Acceptno)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Com_Acceptance_UpdateImport", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@InvoiceNo", Acceptno);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Update_B2BLC(string BuyerID, string SeasonID, string Lc_NO_Status, string MasterLCNo, string B2BLCNo, string Opening_Date, string LastShipment_Date, string Amendment_Date, string Expire_Date, string Benificiery, string Doc_Receive_Date, string Currency, string B2BLC_Value, string Issuing_Bank, string Receiving_Bank, string Maximum, string Bank_Charge, string Status, string Create_user, string Remarks, string lcValue, string bblcLimit, string bblcOpened, string balance, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Com_B2BLC_Update", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@BuyerID", BuyerID);
        command.Parameters.AddWithValue("@SeasonID", SeasonID);
        if (!string.IsNullOrEmpty(Lc_NO_Status))
        {
            command.Parameters.AddWithValue("@Lc_NO_Status", Lc_NO_Status);
        }
        else
        {
            command.Parameters.AddWithValue("@Lc_NO_Status", "");
        }
        command.Parameters.AddWithValue("@MasterLCNo", MasterLCNo);
        command.Parameters.AddWithValue("@B2BLCNo", B2BLCNo);
        if (!string.IsNullOrEmpty(Opening_Date))
        {
            DateTime time = this.dateformat(Opening_Date);
            command.Parameters.AddWithValue("@Opening_Date", time);
        }
        else
        {
            command.Parameters.AddWithValue("@Opening_Date", DBNull.Value);
        }
        command.Parameters["@Opening_Date"].SqlDbType = SqlDbType.SmallDateTime;
        if (!string.IsNullOrEmpty(LastShipment_Date))
        {
            DateTime time2 = this.dateformat(LastShipment_Date);
            command.Parameters.AddWithValue("@LastShipment_Date", time2);
        }
        else
        {
            command.Parameters.AddWithValue("@LastShipment_Date", DBNull.Value);
        }
        command.Parameters["@LastShipment_Date"].SqlDbType = SqlDbType.SmallDateTime;
        if (!string.IsNullOrEmpty(Amendment_Date))
        {
            DateTime time3 = this.dateformat(Amendment_Date);
            command.Parameters.AddWithValue("@Amendment_Date", time3);
        }
        else
        {
            command.Parameters.AddWithValue("@Amendment_Date", DBNull.Value);
        }
        command.Parameters["@Amendment_Date"].SqlDbType = SqlDbType.SmallDateTime;
        if (!string.IsNullOrEmpty(Expire_Date))
        {
            DateTime time4 = this.dateformat(Expire_Date);
            command.Parameters.AddWithValue("@Expire_Date", time4);
        }
        else
        {
            command.Parameters.AddWithValue("@Expire_Date", DBNull.Value);
        }
        command.Parameters["@Expire_Date"].SqlDbType = SqlDbType.SmallDateTime;
        if (!string.IsNullOrEmpty(Benificiery))
        {
            command.Parameters.AddWithValue("@Benificiery", Benificiery);
        }
        else
        {
            command.Parameters.AddWithValue("@Benificiery", DBNull.Value);
        }
        command.Parameters["@Benificiery"].SqlDbType = SqlDbType.Int;
        if (!string.IsNullOrEmpty(Doc_Receive_Date))
        {
            DateTime time5 = this.dateformat(Doc_Receive_Date);
            command.Parameters.AddWithValue("@Doc_Receive_Date", time5);
        }
        else
        {
            command.Parameters.AddWithValue("@Doc_Receive_Date", DBNull.Value);
        }
        command.Parameters["@Doc_Receive_Date"].SqlDbType = SqlDbType.SmallDateTime;
        if (!string.IsNullOrEmpty(Currency))
        {
            command.Parameters.AddWithValue("@Currency", Currency);
        }
        else
        {
            command.Parameters.AddWithValue("@Currency", "");
        }
        command.Parameters.AddWithValue("@B2BLC_Value", B2BLC_Value);
        if (!string.IsNullOrEmpty(Issuing_Bank))
        {
            command.Parameters.AddWithValue("@Issuing_Bank", Issuing_Bank);
        }
        else
        {
            command.Parameters.AddWithValue("@Issuing_Bank", DBNull.Value);
        }
        command.Parameters["@Issuing_Bank"].SqlDbType = SqlDbType.Int;
        if (!string.IsNullOrEmpty(Receiving_Bank))
        {
            command.Parameters.AddWithValue("@Receiving_Bank", Receiving_Bank);
        }
        else
        {
            command.Parameters.AddWithValue("@Receiving_Bank", DBNull.Value);
        }
        command.Parameters["@Receiving_Bank"].SqlDbType = SqlDbType.Int;
        if (!string.IsNullOrEmpty(Maximum))
        {
            command.Parameters.AddWithValue("@Maximum", Maximum);
        }
        else
        {
            command.Parameters.AddWithValue("@Maximum", DBNull.Value);
        }
        command.Parameters["@Maximum"].SqlDbType = SqlDbType.Int;
        if (!string.IsNullOrEmpty(Bank_Charge))
        {
            command.Parameters.AddWithValue("@Bank_Charge", Bank_Charge);
        }
        else
        {
            command.Parameters.AddWithValue("@Bank_Charge", DBNull.Value);
        }
        command.Parameters["@Bank_Charge"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(Status))
        {
            command.Parameters.AddWithValue("@Status", Status);
        }
        else
        {
            command.Parameters.AddWithValue("@Status", "");
        }
        command.Parameters.AddWithValue("@Create_user", Create_user);
        command.Parameters.AddWithValue("@Remarks", Remarks);
        if (!string.IsNullOrEmpty(lcValue))
        {
            command.Parameters.AddWithValue("@LCValue", lcValue);
        }
        else
        {
            command.Parameters.AddWithValue("@LCValue", DBNull.Value);
        }
        command.Parameters["@LCValue"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(bblcLimit))
        {
            command.Parameters.AddWithValue("@BBLCLimit", bblcLimit);
        }
        else
        {
            command.Parameters.AddWithValue("@BBLCLimit", DBNull.Value);
        }
        command.Parameters["@BBLCLimit"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(bblcOpened))
        {
            command.Parameters.AddWithValue("@BBLCOpened", bblcOpened);
        }
        else
        {
            command.Parameters.AddWithValue("@BBLCOpened", DBNull.Value);
        }
        command.Parameters["@BBLCOpened"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(balance))
        {
            command.Parameters.AddWithValue("@Balance", balance);
        }
        else
        {
            command.Parameters.AddWithValue("@Balance", DBNull.Value);
        }
        command.Parameters["@Balance"].SqlDbType = SqlDbType.Decimal;
        command.ExecuteNonQuery();
        lbl.Text = "Update Successfully";
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Update_B2BLC_PI(string PINo)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_PIMaster_UpdatefromB2BLc", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@PI_No", PINo);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Update_ContractInfo(string BuyerID, string seasonId, string companyid, string cContractNo, string nIssuingBank, string nReceivingBank, string nNegotiableBank, string B2BLc, string cPaymentTerm, string cShipMode, string dOpeningDate, string dAmendmentDate, string dLastShipDate, string dExpireDate, string nCurrencyType, string cUDVersion, string nFrightValue, string cNotifyParti, string UDNO, string nInsuranceValue, string dPartialshipment, string Created_User, string TotalPOQty, string ContractValue, string totalCommission, string CalculateValue, string Status, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Com_ContractInfo_Save1", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        if (!string.IsNullOrEmpty(BuyerID))
        {
            command.Parameters.AddWithValue("@BuyerID", BuyerID);
        }
        else
        {
            command.Parameters.AddWithValue("@BuyerID", DBNull.Value);
        }
        command.Parameters["@BuyerID"].SqlDbType = SqlDbType.Int;
        if (!string.IsNullOrEmpty(seasonId))
        {
            command.Parameters.AddWithValue("@SeasonID", seasonId);
        }
        else
        {
            command.Parameters.AddWithValue("@SeasonID", DBNull.Value);
        }
        command.Parameters["@SeasonID"].SqlDbType = SqlDbType.Int;
        if (!string.IsNullOrEmpty(companyid))
        {
            command.Parameters.AddWithValue("@CompanyID", companyid);
        }
        else
        {
            command.Parameters.AddWithValue("@CompanyID", DBNull.Value);
        }
        command.Parameters["@CompanyID"].SqlDbType = SqlDbType.Int;
        command.Parameters.AddWithValue("@cContractNo", cContractNo);
        if (!string.IsNullOrEmpty(nIssuingBank))
        {
            command.Parameters.AddWithValue("@nIssuingBank", nIssuingBank);
        }
        else
        {
            command.Parameters.AddWithValue("@nIssuingBank", DBNull.Value);
        }
        command.Parameters["@nIssuingBank"].SqlDbType = SqlDbType.Int;
        if (!string.IsNullOrEmpty(nReceivingBank))
        {
            command.Parameters.AddWithValue("@nReceivingBank", nReceivingBank);
        }
        else
        {
            command.Parameters.AddWithValue("@nReceivingBank", DBNull.Value);
        }
        command.Parameters["@nReceivingBank"].SqlDbType = SqlDbType.Int;
        if (!string.IsNullOrEmpty(nNegotiableBank))
        {
            command.Parameters.AddWithValue("@nNegotiableBank", nNegotiableBank);
        }
        else
        {
            command.Parameters.AddWithValue("@nNegotiableBank", DBNull.Value);
        }
        command.Parameters["@nNegotiableBank"].SqlDbType = SqlDbType.Int;
        command.Parameters.AddWithValue("@B2BLc", B2BLc);
        command.Parameters.AddWithValue("@cPaymentTerm", cPaymentTerm);
        command.Parameters.AddWithValue("@cShipMode", cShipMode);
        if (!string.IsNullOrEmpty(dOpeningDate))
        {
            command.Parameters.AddWithValue("@dOpeningDate", dOpeningDate);
        }
        else
        {
            command.Parameters.AddWithValue("@dOpeningDate", DBNull.Value);
        }
        command.Parameters["@dOpeningDate"].SqlDbType = SqlDbType.SmallDateTime;
        if (!string.IsNullOrEmpty(dAmendmentDate))
        {
            command.Parameters.AddWithValue("@dAmendmentDate", dAmendmentDate);
        }
        else
        {
            command.Parameters.AddWithValue("@dAmendmentDate", DBNull.Value);
        }
        command.Parameters["@dAmendmentDate"].SqlDbType = SqlDbType.SmallDateTime;
        if (!string.IsNullOrEmpty(dLastShipDate))
        {
            command.Parameters.AddWithValue("@dLastShipDate", dLastShipDate);
        }
        else
        {
            command.Parameters.AddWithValue("@dLastShipDate", DBNull.Value);
        }
        command.Parameters["@dLastShipDate"].SqlDbType = SqlDbType.SmallDateTime;
        if (!string.IsNullOrEmpty(dExpireDate))
        {
            command.Parameters.AddWithValue("@dExpireDate", dExpireDate);
        }
        else
        {
            command.Parameters.AddWithValue("@dExpireDate", DBNull.Value);
        }
        command.Parameters["@dExpireDate"].SqlDbType = SqlDbType.SmallDateTime;
        command.Parameters.AddWithValue("@nCurrencyType", nCurrencyType);
        command.Parameters.AddWithValue("@cUDVersion", cUDVersion);
        if (!string.IsNullOrEmpty(nFrightValue))
        {
            command.Parameters.AddWithValue("@nFrightValue", nFrightValue);
        }
        else
        {
            command.Parameters.AddWithValue("@nFrightValue", DBNull.Value);
        }
        command.Parameters["@nFrightValue"].SqlDbType = SqlDbType.Decimal;
        command.Parameters.AddWithValue("@cNotifyParti", cNotifyParti);
        command.Parameters.AddWithValue("@UDNO", UDNO);
        if (!string.IsNullOrEmpty(nInsuranceValue))
        {
            command.Parameters.AddWithValue("@nInsuranceValue", nInsuranceValue);
        }
        else
        {
            command.Parameters.AddWithValue("@nInsuranceValue", DBNull.Value);
        }
        command.Parameters["@nInsuranceValue"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(dPartialshipment))
        {
            command.Parameters.AddWithValue("@dPartialshipment", dPartialshipment);
        }
        else
        {
            command.Parameters.AddWithValue("@dPartialshipment", DBNull.Value);
        }
        command.Parameters["@dPartialshipment"].SqlDbType = SqlDbType.Int;
        command.Parameters.AddWithValue("@Created_User", Created_User);
        if (!string.IsNullOrEmpty(TotalPOQty))
        {
            command.Parameters.AddWithValue("@TotalPOQty", TotalPOQty);
        }
        else
        {
            command.Parameters.AddWithValue("@TotalPOQty", "0.00");
        }
        if (!string.IsNullOrEmpty(ContractValue))
        {
            command.Parameters.AddWithValue("@ContractValue", ContractValue);
        }
        else
        {
            command.Parameters.AddWithValue("@ContractValue", "0.00");
        }
        if (!string.IsNullOrEmpty(totalCommission))
        {
            command.Parameters.AddWithValue("@totalCommission", totalCommission);
        }
        else
        {
            command.Parameters.AddWithValue("@totalCommission", "0.00");
        }
        if (!string.IsNullOrEmpty(CalculateValue))
        {
            command.Parameters.AddWithValue("@CalculateValue", CalculateValue);
        }
        else
        {
            command.Parameters.AddWithValue("@CalculateValue", "0.00");
        }
        if (!string.IsNullOrEmpty(Status))
        {
            command.Parameters.AddWithValue("@Status", Status);
        }
        else
        {
            command.Parameters.AddWithValue("@Status", "");
        }
        if (command.ExecuteNonQuery() > 0)
        {
            lbl.Text = "Updated Successfully";
        }
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Update_InvoiceNo(int Invoiceno)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Parameters_UpdatefromExportInvoice", this.cnInventory);
        if (this.cnInventory.State == ConnectionState.Closed)
        {
            this.cnInventory.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@InvoiceNO", Invoiceno);
        command.ExecuteNonQuery();
        if (this.cnInventory.State == ConnectionState.Open)
        {
            this.cnInventory.Close();
        }
    }

    public void Update_MasterContractQty(int SlNo, string ContractNo, string Quantity, string ContractValue, string TotalComission, string CalculateValue)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Com_ContractInfoQtyDtl_Update", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@SlNo", SlNo);
        command.Parameters.AddWithValue("@ContractNo", ContractNo);
        command.Parameters.AddWithValue("@Quantity", Quantity);
        command.Parameters.AddWithValue("@ContractValue", ContractValue);
        command.Parameters.AddWithValue("@TotalComission", TotalComission);
        command.Parameters.AddWithValue("@CalculateValue", CalculateValue);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Update_MasterContractStyle(string ContNo, string StyleId, string user, int Amendment_NO)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Com_ContractInfoStyle_Save1", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@Contract_No", ContNo);
        command.Parameters.AddWithValue("@StyleID", StyleId);
        command.Parameters.AddWithValue("@Create_By", user);
        command.Parameters.AddWithValue("@Amendment_NO", Amendment_NO);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Update_PaymentMode(int PMNO, string PaymentMode, string Username, Label lbl)
    {
        SqlCommand command = new SqlCommand("select Payment_Mode from Smt_PaymentMode where Payment_Mode='" + PaymentMode.Trim() + "'", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        SqlDataReader reader = command.ExecuteReader();
        if (reader.Read())
        {
            lbl.Text = "Already Exist";
            reader.Close();
        }
        else
        {
            reader.Close();
            SqlCommand command2 = new SqlCommand("Sp_Smt_PaymentMode_Update", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@PT_NO", PMNO);
            command2.Parameters.AddWithValue("@Payment_Term", PaymentMode);
            command2.Parameters.AddWithValue("@Created_User", Username);
            command2.ExecuteNonQuery();
            lbl.Text = "Updated Successfully";
            if (this.cn.State == ConnectionState.Closed)
            {
                this.cn.Open();
            }
        }
    }

    public void Update_PaymentTerm(int PTNO, string PaymentTerm, string Username, Label lbl)
    {
        SqlCommand command = new SqlCommand("select Payment_Term from Smt_PaymentTerm where Payment_Term='" + PaymentTerm.Trim() + "'", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        SqlDataReader reader = command.ExecuteReader();
        if (reader.Read())
        {
            lbl.Text = "Already Exist";
            reader.Close();
        }
        else
        {
            reader.Close();
            SqlCommand command2 = new SqlCommand("Sp_Smt_PaymentTerm_Update", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@PT_NO", PTNO);
            command2.Parameters.AddWithValue("@Payment_Term", PaymentTerm);
            command2.Parameters.AddWithValue("@Created_User", Username);
            command2.ExecuteNonQuery();
            lbl.Text = "Updated Successfully";
            if (this.cn.State == ConnectionState.Closed)
            {
                this.cn.Open();
            }
        }
    }

    public void Update_POfromPI(string PINO)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_POHedder_UpdateByPI", this.cnInventory);
        if (this.cnInventory.State == ConnectionState.Closed)
        {
            this.cnInventory.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@PO_No", PINO);
        command.ExecuteNonQuery();
        if (this.cnInventory.State == ConnectionState.Open)
        {
            this.cnInventory.Close();
        }
    }

    public void Update_StylemasterbyMasterLC(int StyleID, string Contno)
    {
        SqlCommand command = new SqlCommand("Sp_smt_UpdateStylemasterforMasterLC", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@StyleID", StyleID);
        command.Parameters.AddWithValue("@MasterLCNO", Contno);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Update_StylemasterbyMasterLC1(int StyleID)
    {
        SqlCommand command = new SqlCommand("Sp_smt_UpdateStylemasterforMasterLC1", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@StyleID", StyleID);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }
}
