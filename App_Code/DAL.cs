
using AjaxControlToolkit;
using C1.Web.UI.Controls.C1ComboBox;
using C1.Web.UI.Controls.C1GridView;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public class DAL
{
    public static Hashtable _xCrush = new Hashtable();
    private SqlConnection cn = GetWay.SpecFoCon;
    private string frname;
    private BLL mybll = new BLL();
    private string sts;
    private string url;

    public static int _xrED(string _xRID, string _xRflnm)
    {
        int num = 0;
        if (!_xCrush.Contains(_xRID))
        {
            _xCrush.Add(_xRID, _xRflnm);
            return num;
        }
        return 1;
    }

    public void ActivateUsertheme(string userid, string theme, Label lbl)
    {
        SqlCommand command = new SqlCommand("update Smt_Users set theme_Name='" + theme.Trim() + "' where  cUserName='" + userid + "'", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.ExecuteNonQuery();
        lbl.Text = "Activated Successfully";
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void BuyerReport(string Formdt, string Todt)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_BuyerWiseStyleRpt_New", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@StartDate", Formdt);
        command.Parameters.AddWithValue("@EndDate", Todt);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void BuyerReportweekly(string Formdt, string Todt)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_OrderMaster_ReportBuyerWiseweekly", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@stdt", Formdt);
        command.Parameters.AddWithValue("@Enddt", Todt);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    //public void c1drp_Color(C1.Web.UI.Controls.C1ComboBox.C1ComboBox drp)
    //{
    //    this.mybll.c1combobox(drp, "select nColNo,cColour from Smt_Colours", 1, 0);
    //}

    //public void c1drp_pobystyleid(C1.Web.UI.Controls.C1ComboBox.C1ComboBox drp, DropDownList drpwhere)
    //{
    //    this.mybll.c1combobox(drp, "select cPoNum,nOStyleId,cOrderNu,nOrdQty,DXfty from Smt_OrdersMaster where nOStyleId='" + drpwhere.SelectedValue + "'", 0, 2);
    //}

    //public void c1drp_SHADE(C1.Web.UI.Controls.C1ComboBox.C1ComboBox drp)
    //{
    //    this.mybll.c1combobox(drp, "select nshcode,cShade from Smt_Fabshade", 1, 0);
    //}

    public void C1drpPOno_firstyleno(DropDownList drpstyleno, DropDownList drppo)
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select nOID from Smt_OrdersMaster where nOStyleId='" + drpstyleno.SelectedValue + "'", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet);
        drppo.DataSource = dataSet;
        drppo.DataTextField = "nOID";
        drppo.DataValueField = "nOID";
        drppo.DataBind();
        drppo.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        drppo.SelectedIndex = 0;
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

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

    public void Delete_Assortmentcolor(int styleid, int colorid, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_DeleteColour", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nstyid", styleid);
        command.Parameters.AddWithValue("@nColid", colorid);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        lbl.Text = "Deleted Successfully";
    }

    public void Delete_BOM(int styleid, string verson, string lot)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_BOM_Delete", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nstyCode", styleid);
        command.Parameters.AddWithValue("@cver", verson);
        command.Parameters.AddWithValue("@clots", lot);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Delete_btnperm(string Userid)
    {
        SqlCommand command = new SqlCommand("Sp_tst_permitterbtn_Delete", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@UserName", Userid);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Delete_ColorSen(int nstyCode, int MainCatCode, string cPlsmnt, int SubCatID, int nArticle_ID, int nDimension_Id)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_ColSen_Delete1", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nstyCode", nstyCode);
        command.Parameters.AddWithValue("@MainCatCode", MainCatCode);
        command.Parameters.AddWithValue("@cPlsmnt", cPlsmnt);
        command.Parameters.AddWithValue("@SubCatID", SubCatID);
        command.Parameters.AddWithValue("@nArticle_ID", nArticle_ID);
        command.Parameters.AddWithValue("@nDimension_Id", nDimension_Id);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void delete_Colorsensitivity(int styleid)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_DeleteColorsensitivity", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nstyCode", styleid);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Delete_CountryPack(int styleid, string lot, string pack, int nCountryCode)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_CntryPack_Delete", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nstyid_1", styleid);
        command.Parameters.AddWithValue("@cshpID_2", lot);
        command.Parameters.AddWithValue("@cPack", pack);
        command.Parameters.AddWithValue("@nCountryCode", nCountryCode);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Delete_grouppermission(int groupid)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_UserPermittedform_Delete", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nUgroup", groupid);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Delete_grouppermissionupdate(string User_ID)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_UserPermittedform_DltUsr", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@User_ID", User_ID);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Delete_InseamQty(int styleid, string lot, string pack)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_InseamQty_Delete", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nstyid", styleid);
        command.Parameters.AddWithValue("@cPo", lot);
        command.Parameters.AddWithValue("@cPack", pack);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Delete_Ordermaster(int styleid, string lot, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_DeletePo", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nstyid", styleid);
        command.Parameters.AddWithValue("@cLot", lot);
        command.ExecuteNonQuery();
        lbl.Text = "Deleted Successfully";
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Delete_Packcountry(int styleid, string lot, string pack, int nCountryCode)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_PackContry_Delete", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nstyCd", styleid);
        command.Parameters.AddWithValue("@cShiId", lot);
        command.Parameters.AddWithValue("@cPack", pack);
        command.Parameters.AddWithValue("@nCountryCode", nCountryCode);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Delete_Productionplane(int CompanyID, int BuildingUnit_ID, int FloorID, int LineID, int StyleID, string LotNo, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Productionplane_DeleteRow", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@CompanyID", CompanyID);
        command.Parameters.AddWithValue("@BuildingUnit_ID", BuildingUnit_ID);
        command.Parameters.AddWithValue("@FloorID", FloorID);
        command.Parameters.AddWithValue("@LineID", LineID);
        command.Parameters.AddWithValue("@StyleID", StyleID);
        command.Parameters.AddWithValue("@LotNo", LotNo);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        lbl.Text = "Deleted Successfully";
    }

    public void Delete_SizeSensitivity(int styleid, int category, int itemid)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_DeleteSizeSensitivity", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nStyID", styleid);
        command.Parameters.AddWithValue("@McatID", category);
        command.Parameters.AddWithValue("@ItemCode", itemid);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Delete_Specialop(string cstid)
    {
        SqlCommand command = new SqlCommand("SpInsSmtStySpOp_Delete", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@csty", cstid);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Delete_styleFile(int styleid, string filename)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_StylemasterFile_DlByfileName", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@StyleNo", styleid);
        command.Parameters.AddWithValue("@Fileno", filename);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Delete_styleFileAll(int styleid)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_StylemasterFile_DltStyle", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@StyleNo", styleid);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Delete_Suppliermaincategory(string code)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_SupSupManCat_Delete", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@cSupCode_1", code);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Delete_TNABuyer(int Buyer_Id)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_TNA_Buyer_Delete", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@Buyer_Id", Buyer_Id);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Delete_TNACustom(string tnaname)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_TNA_Custom_Dedete", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@CustomName", tnaname);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Delete_TNAstyle(int nStyle_Id)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_TNA_Style_Delete", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nStyle_Id", nStyle_Id);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Delete_TNATaskStatus(int StyleID)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_TNA_TaskStatus_Delete", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@Style_ID", StyleID);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Delete_UserLog(int slno, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_UserLog_Delete", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@Slno", slno);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        lbl.Text = "Deleted Successfully";
    }

    public void Delete_Virtual(int styleid, string user)
    {
        SqlCommand command = new SqlCommand(string.Concat(new object[] { "delete from Smt_Virtual where nstyCode='", styleid, "' and username='", user, "'" }), this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Dlt_Inseamqty(int StyleID, string Lot, string Pack, int CountryCode)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_InseamsQty_dlt", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@StyleID", StyleID);
        command.Parameters.AddWithValue("@Lot", Lot);
        command.Parameters.AddWithValue("@Pack", Pack);
        command.Parameters.AddWithValue("@CountryCode", CountryCode);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void drp_Brand(DropDownList drp)
    {
        this.mybll.dropdown(drp, "Smt_Brand", "cBrand_Name", 1, 0);
    }

    public void drp_Buyer(DropDownList drp)
    {
        this.mybll.dropdown(drp, "Smt_BuyerName", "cBuyer_Name", 1, 0);
    }

    //public void drp_clr(ComboBox drp)
    //{
    //    this.mybll.drpcombo(drp, "Smt_Color", 1, 0);
    //}

    public void drp_color(DropDownList drp)
    {
        this.mybll.dropdown(drp, "Smt_Colours", "cColour", 1, 0);
    }

    public void drp_Company(DropDownList drp)
    {
        this.mybll.dropdown(drp, "Smt_Company", "cCmpName", 1, 0);
    }

    public void drp_ConstructionArticlebymaincategory(DropDownList maincategory, DropDownList drpconst)
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select nArtCode,cArticle from View_Smt_Article where cMainCategory='" + maincategory.SelectedItem.Text + "'", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet);
        drpconst.DataSource = dataSet;
        drpconst.DataTextField = "cArticle";
        drpconst.DataValueField = "nArtCode";
        drpconst.DataBind();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void drp_ConstructionArticlebymaincategory1(DropDownList maincategory, DropDownList drpconst)
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select nArtCode,cArticle from View_Smt_Article where cMainCategory='" + maincategory.SelectedItem.Text + "'", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet);
        drpconst.DataSource = dataSet;
        drpconst.DataTextField = "cArticle";
        drpconst.DataValueField = "nArtCode";
        drpconst.DataBind();
        drpconst.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        drpconst.SelectedIndex = 0;
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void drp_Counrys(DropDownList drp)
    {
        this.mybll.dropdown(drp, "Smt_Counrys", "cConDes", 1, 0);
    }

    public void drp_Country(DropDownList drp)
    {
        this.mybll.dropdown(drp, "Smt_Country", "cCountry_Name", 1, 0);
    }

    public void drp_Department(DropDownList drp)
    {
        this.mybll.dropdown(drp, "Smt_Department", "cDeptname", 1, 0);
    }

    public void drp_Dimensionbymaincategory(DropDownList maincategory, DropDownList dimension)
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select ndCode,cDimen from View_Smt_Dimension where cMainCategory='" + maincategory.SelectedItem.Text + "'", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet);
        dimension.DataSource = dataSet;
        dimension.DataTextField = "cDimen";
        dimension.DataValueField = "ndCode";
        dimension.DataBind();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void drp_Dimensionbymaincategory1(DropDownList maincategory, DropDownList dimension)
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select ndCode,cDimen from View_Smt_Dimension where cMainCategory='" + maincategory.SelectedItem.Text + "'", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet);
        dimension.DataSource = dataSet;
        dimension.DataTextField = "cDimen";
        dimension.DataValueField = "ndCode";
        dimension.DataBind();
        dimension.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        dimension.SelectedIndex = 0;
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void drp_drpStyleno(DropDownList drp)
    {
        this.mybll.dropdown(drp, "Smt_StyleMaster", "cStyleNo", 1, 0);
    }

    public void drp_fabrictype(DropDownList drp)
    {
        this.mybll.dropdown(drp, "Smt_FabricType", "cDes", 1, 0);
    }

    public void drp_Floor(DropDownList drp)
    {
        this.mybll.dropdown(drp, "Smt_Floor", "cFloor_Descriptin", 1, 0);
    }

    public void drp_garmentdepartment(DropDownList drp)
    {
        this.mybll.dropdown(drp, "Smt_Gmt_Department", "cGmt_Dept_Description", 1, 0);
    }

    public void drp_garmenttype(DropDownList drp)
    {
        this.mybll.dropdown(drp, "Smt_GmtType", "cGmetDis", 1, 0);
    }

    public void drp_itemdescriptionbymaincategory(DropDownList maincategory, DropDownList drpitem)
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select cCode,cDes from View_Smt_SubcatMaincat where cMainCategory='" + maincategory.SelectedItem.Text + "'", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet);
        drpitem.DataSource = dataSet;
        drpitem.DataTextField = "cDes";
        drpitem.DataValueField = "cCode";
        drpitem.DataBind();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void drp_itemdescriptionbymaincategory1(DropDownList maincategory, DropDownList drpitem)
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select cCode,cDes from View_Smt_SubcatMaincat where cMainCategory='" + maincategory.SelectedItem.Text + "'", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet);
        drpitem.DataSource = dataSet;
        drpitem.DataTextField = "cDes";
        drpitem.DataValueField = "cCode";
        drpitem.DataBind();
        drpitem.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        drpitem.SelectedIndex = 0;
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void drp_MasterCategory(DropDownList drp)
    {
        this.mybll.dropdown(drp, "Smt_MasterCategory", "cMasterCategory", 1, 0);
    }

    public void drp_masterStyleno(DropDownList drp)
    {
        this.mybll.dropdown(drp, "Smt_StyleMaster", "cStyleNo", 1, 0);
    }

    public void drp_season(DropDownList drp)
    {
        this.mybll.dropdown(drp, "Smt_Season", "cSeason_Name", 1, 0);
    }

    public void drp_Section(DropDownList drp)
    {
        this.mybll.dropdown(drp, "Smt_Section", "cSection_Description", 1, 0);
    }

    //public void drp_shad(DropDownList drp)
    //{
    //    this.mybll.dropdownnotnull(drp, "Smt_Fabshade", 1, 0);
    //}

    public void drp_sizesentabdim(DropDownList maincategory, int styleid, string mcat)
    {
        SqlDataAdapter adapter = new SqlDataAdapter(string.Concat(new object[] { "select distinct cDime from Smt_SizeSensitive where nStyID='", styleid, "' and cMcat='", mcat, "'" }), this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet);
        maincategory.DataSource = dataSet;
        maincategory.DataTextField = "cDime";
        maincategory.DataValueField = "cDime";
        maincategory.DataBind();
        maincategory.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        maincategory.SelectedIndex = 0;
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void drp_sizesentabSize(DropDownList maincategory, int styleid, string mcat)
    {
        SqlDataAdapter adapter = new SqlDataAdapter(string.Concat(new object[] { "select distinct cSize from Smt_SizeSensitive where nStyID='", styleid, "' and cMcat='", mcat, "'" }), this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet);
        maincategory.DataSource = dataSet;
        maincategory.DataTextField = "cSize";
        maincategory.DataValueField = "cSize";
        maincategory.DataBind();
        maincategory.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        maincategory.SelectedIndex = 0;
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void drp_store(DropDownList drp)
    {
        this.mybll.dropdown(drp, "Smt_Store", "cStore_Name", 1, 0);
    }

    //public void drp_StyleID(DropDownList drp)
    //{
    //    this.mybll.drpwithstatement(drp, "select nStyleID,cStyleNo from Smt_StyleMaster", 1, 0);
    //}

    public void drp_styletype(DropDownList drp)
    {
        this.mybll.dropdown(drp, "Smt_StyleType", "cStyleType", 1, 0);
    }

    public void drp_Supplierbystyleandversion(DropDownList supplier, string style, string version)
    {
        SqlDataAdapter adapter = new SqlDataAdapter("Sp_Smt_GetSupplierbycode '" + style + "','" + version + "'", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet);
        supplier.DataSource = dataSet;
        supplier.DataTextField = "cSupName";
        supplier.DataValueField = "nSup";
        supplier.DataBind();
        supplier.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        supplier.SelectedIndex = 0;
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void drp_SupplierforMaincategory(DropDownList drpMaincategory, DropDownList drpSupplier)
    {
        SqlDataAdapter adapter = new SqlDataAdapter("Sp_Smt_getSupplierforMaincategory '" + drpMaincategory.SelectedValue + "'", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet);
        drpSupplier.DataSource = dataSet;
        drpSupplier.DataTextField = "cSupName";
        drpSupplier.DataValueField = "SupplierID";
        drpSupplier.DataBind();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void drp_SupplierforMaincategory1(DropDownList drpMaincategory, DropDownList drpSupplier)
    {
        SqlDataAdapter adapter = new SqlDataAdapter("Sp_Smt_getSupplierforMaincategory '" + drpMaincategory.SelectedValue + "'", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet);
        drpSupplier.DataSource = dataSet;
        drpSupplier.DataTextField = "cSupName";
        drpSupplier.DataValueField = "SupplierID";
        drpSupplier.DataBind();
        drpSupplier.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        drpSupplier.SelectedIndex = 0;
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void drp_Unitfromsubcategory(DropDownList subcategory, DropDownList unit)
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select cUnit,cUnitDes from View_Smt_UnitfromSubcategory where cCode='" + subcategory.SelectedValue + "'", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet);
        unit.DataSource = dataSet;
        unit.DataTextField = "cUnitDes";
        unit.DataValueField = "cUnit";
        unit.DataBind();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void drp_usergroup(DropDownList drp)
    {
        this.mybll.dropdown(drp, "Smt_UserGroups", "cGrpDescription", 1, 0);
    }

    public void drp_userlevel(DropDownList drp)
    {
        this.mybll.dropdown(drp, "Smt_Userlevel", "cLevelDescription", 2, 0);
    }

    public void drpPOno_firstyleno(DropDownList drpstyleno, DropDownList drppo)
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select nOID from Smt_OrdersMaster where nOStyleId='" + drpstyleno.SelectedValue + "'", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet);
        drppo.DataSource = dataSet;
        drppo.DataTextField = "nOID";
        drppo.DataValueField = "nOID";
        drppo.DataBind();
        drppo.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        drppo.SelectedIndex = 0;
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void FilldorpdownNew(DropDownList drpstyleno, string SelectStatement, string TextField, string ValueField)
    {
        SqlDataAdapter adapter = new SqlDataAdapter(SelectStatement ?? "", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet);
        drpstyleno.DataSource = dataSet;
        drpstyleno.DataTextField = TextField;
        drpstyleno.DataValueField = ValueField;
        drpstyleno.DataBind();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public DataTable get_Alltbl(string statement)
    {
        SqlDataAdapter adapter = new SqlDataAdapter(statement, this.cn);
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

    public DataSet get_Brand()
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select nBrand_ID,cBrand_Name from Smt_Brand order by nBrand_ID desc", this.cn);
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

    public DataSet get_Buyer()
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select nBuyer_ID,cBuyer_Name from Smt_BuyerName", this.cn);
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

    public DataSet get_Color()
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select nColor_ID,cColor from Smt_Color", this.cn);
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

    public DataSet get_companyinfo()
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select nCompanyID,cCmpName,cAdd1,cAdd2 from Smt_Company", this.cn);
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

    public DataSet get_Department()
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select nUserDept,cDeptname,cCmpName from View_Smt_Department", this.cn);
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

    public DataTable get_Departmentbyid(int departmentid)
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select nUserDept,cDeptname,nCompanyID from Smt_Department where nUserDept='" + departmentid + "'", this.cn);
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

    public DataSet get_Desigantion()
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select nDesignation_ID,cDesignation from Smt_Designation", this.cn);
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

    public DataSet get_Fabshade()
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select nshcode,cShade from Smt_Fabshade order by nshcode desc", this.cn);
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

    public DataSet get_Fabshadebyid(int id)
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select cShade from Smt_Fabshade where nshcode='" + id + "'", this.cn);
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

    public DataSet get_Floor()
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select nFloor,cFloor_Descriptin from Smt_Floor", this.cn);
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

    public DataSet get_garmentdepartment()
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select nGmt_Dept_ID,cGmt_Dept_Description from Smt_Gmt_Department", this.cn);
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

    public DataSet get_MainCategory()
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select nMainCategory_ID,nMasterCategory_ID,cMainCategory,cMasterCategory from View_Smt_Maincategory", this.cn);
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

    public DataSet get_MasterCategory()
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select nMasterCategory_ID,cMasterCategory from Smt_MasterCategory", this.cn);
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

    public DataSet get_newuser()
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select * from View_Smt_User", this.cn);
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

    public DataSet get_Permttedform(int usergroup, string formname)
    {
        SqlDataAdapter adapter = new SqlDataAdapter(string.Concat(new object[] { "select Form_Name from Smt_UserPermittedform where nUgroup='", usergroup, "' and Form_Name='", formname, "'" }), this.cn);
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

    public DataTable get_POinfobystyleid(int styleid)
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select * from Smt_OrdersMaster where nOStyleId='" + styleid + "'", this.cn);
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

    public DataSet get_Season()
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select nSeason_ID,cSeason_Name from Smt_Season", this.cn);
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

    public DataSet get_Section()
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select * from Smt_Section order by nSectionID desc", this.cn);
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

    public DataTable get_Specialoprationstyleid(int styleid)
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select nSpId from Smt_StySpOp where nstyID='" + styleid + "'", this.cn);
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

    public DataSet get_Store()
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select nStore_ID,cStore_Name,cCountry_Name from View_Smt_Store", this.cn);
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

    public DataSet get_styleinfobystyleno(int styleno)
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select * from Smt_StyleMaster  where nStyleID='" + styleno + "'", this.cn);
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

    public DataSet get_Stylemaster()
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select * from Smt_StyleMaster order by nStyleID asc", this.cn);
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

    public DataSet get_StylemasterbyID(int styleid)
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select * from Smt_StyleMaster where nStyleID=" + styleid, this.cn);
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

    public DataSet get_StylemasterbyStyleno(string styleno)
    {
        SqlDataAdapter adapter = new SqlDataAdapter("Sp_Smt_StyleMaster_GetByStyleNo '" + styleno + "'", this.cn);
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

    public DataSet get_StyleType()
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select cStyleType from Smt_StyleType", this.cn);
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

    public DataSet get_Userbyid(string userid)
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select * from Smt_Users where cUserName='" + userid + "'", this.cn);
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

    public DataSet get_Usergroup()
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select * from Smt_UserGroups", this.cn);
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

    public DataTable get_Usergroupbyid(int userid)
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select * from Smt_UserGroups where nUgroup='" + userid + "'", this.cn);
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

    public DataSet get_UserLevel()
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select nULevelID,cLevelname,cLevelDescription from Smt_Userlevel", this.cn);
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

    public DataSet getpoqty_bypono(string ordid)
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select nOrdQty,DXfty from Smt_OrdersMaster where cPoNum='" + ordid + "' ", this.cn);
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

    public DataTable hide_Asort(int styleid, string lot)
    {
        SqlDataAdapter adapter = new SqlDataAdapter(string.Concat(new object[] { "select [Size1],[Size2],[Size3],[Size4],[Size5] from Smt_OrderSize where nStyleID='", styleid, "' and cLotNo='", lot, "'" }), this.cn);
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

    public DataTable hide_nullcolumnassortment(int styleid, string lot)
    {
        SqlDataAdapter adapter = new SqlDataAdapter(string.Concat(new object[] { "select [Size1],[Size2],[Size3],[Size4],[Size5],[Size6],[Size7],[Size8],[Size9] ,[Size10] ,[Size11],[Size12],[Size13],[Size14],[Size15],[Size16],[Size17],[Size18],[Size19],[Size20],[Size21],[Size22],[Size23],[Size24],[Size25],[Size26],[Size27],[Size28],[Size29],[Size30],[Size31],[Size32],[Size33],[Size34],[Size35],[Size36],[Size37],[Size38],[Size39],[Size40],[Size41],[Size42],[Size43],[Size44],[Size45],[Size46],[Size47],[Size48],[Size49],[Size50],[Size51],[Size52],[Size53],[Size54],[Size55],[Size56],[Size57],[Size58],[Size59],[Size60] from Smt_OrderSize where nStyleID=", styleid, " and cLotNo='", lot, "'" }), this.cn);
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

    public DataTable hide_nullcolumnassortment1(int styleid, string lot)
    {
        SqlDataAdapter adapter = new SqlDataAdapter(string.Concat(new object[] { "Sp_DispSourceCI '", styleid, "','", lot, "'" }), this.cn);
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

    public DataTable hide_test(int styleid, string lot)
    {
        SqlDataAdapter adapter = new SqlDataAdapter(string.Concat(new object[] { "select [Size1],[Size2],[Size3] from Smt_OrderSize where nStyleID='", styleid, "' and cLotNo='", lot, "'" }), this.cn);
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

    public string permissionform(int grp, string frm)
    {
        SqlCommand command = new SqlCommand(string.Concat(new object[] { "select * from Smt_UserPermittedform where nUgroup='", grp, "' and Url='", frm, "'" }), this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        SqlDataReader reader = command.ExecuteReader();
        if (reader.Read())
        {
            this.frname = reader["Url"].ToString();
            reader.Close();
        }
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        return this.frname;
    }

    public string permissionformmasterload(string grp, string usr, string frm)
    {
        SqlCommand command = new SqlCommand("select Permission_Status from Smt_Users where cUserName='" + usr + "'", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        SqlDataReader reader = command.ExecuteReader();
        reader.Read();
        if (reader.HasRows)
        {
            this.sts = reader["Permission_status"].ToString();
            if (this.sts == "U")
            {
                reader.Close();
                SqlCommand command2 = new SqlCommand("select Url from Smt_UserPermittedform where User_ID='" + usr + "' and Url='" + frm + "'", this.cn);
                if (this.cn.State == ConnectionState.Closed)
                {
                    this.cn.Open();
                }
                SqlDataReader reader2 = command2.ExecuteReader();
                reader2.Read();
                if (reader2.HasRows)
                {
                    this.url = reader2["Url"].ToString();
                    reader2.Close();
                }
                reader2.Close();
            }
            else
            {
                reader.Close();
                SqlCommand command3 = new SqlCommand("select Url from Smt_UserPermittedform where nUgroup='" + grp + "' and Url='" + frm + "'", this.cn);
                if (this.cn.State == ConnectionState.Closed)
                {
                    this.cn.Open();
                }
                SqlDataReader reader3 = command3.ExecuteReader();
                reader3.Read();
                if (reader3.HasRows)
                {
                    this.url = reader3["Url"].ToString();
                    reader3.Close();
                }
                reader3.Close();
                if (this.cn.State == ConnectionState.Open)
                {
                    this.cn.Close();
                }
            }
        }
        return this.url;
    }

    public string permissionformmasterloadCom(string grp, string usr, string frm)
    {
        SqlCommand command = new SqlCommand("select Permission_Status from Smt_Users where cUserName='" + usr + "'", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        SqlDataReader reader = command.ExecuteReader();
        reader.Read();
        if (reader.HasRows)
        {
            this.sts = reader["Permission_status"].ToString();
            if (this.sts == "U")
            {
                reader.Close();
                SqlCommand command2 = new SqlCommand("select Url from Smt_UserPermittedform where User_ID='" + usr + "' and Url='Commercial/" + frm + "'", this.cn);
                if (this.cn.State == ConnectionState.Closed)
                {
                    this.cn.Open();
                }
                SqlDataReader reader2 = command2.ExecuteReader();
                reader2.Read();
                if (reader2.HasRows)
                {
                    this.url = reader2["Url"].ToString();
                    reader2.Close();
                }
                reader2.Close();
            }
            else
            {
                reader.Close();
                SqlCommand command3 = new SqlCommand("select Url from Smt_UserPermittedform where nUgroup='" + grp + "' and Url='Commercial/" + frm + "'", this.cn);
                if (this.cn.State == ConnectionState.Closed)
                {
                    this.cn.Open();
                }
                SqlDataReader reader3 = command3.ExecuteReader();
                reader3.Read();
                if (reader3.HasRows)
                {
                    this.url = reader3["Url"].ToString();
                    reader3.Close();
                }
                reader3.Close();
                if (this.cn.State == ConnectionState.Open)
                {
                    this.cn.Close();
                }
            }
        }
        return this.url;
    }

    public void Rename_Styleno(int styleid, string StyleNo, Label lbl)
    {
        SqlCommand command = new SqlCommand("select cStyleNo from Smt_StyleMaster where cStyleNo='" + StyleNo + "'", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        SqlDataReader reader = command.ExecuteReader();
        if (reader.Read())
        {
            lbl.Text = "Style No Already Exist";
            reader.Close();
        }
        else
        {
            reader.Close();
            new SqlCommand(string.Concat(new object[] { "update Smt_StyleMaster set cStyleNo='", StyleNo, "' where nStyleID=", styleid }), this.cn) { CommandType = CommandType.Text }.ExecuteNonQuery();
            lbl.Text = "Rename Successfully";
        }
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Report_Ordermaster_BuyerWise(string Formdt, string Todt)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_OrderMaster_ReportBuyerWise", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@StartDate", Formdt);
        command.Parameters.AddWithValue("@EndDate", Todt);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Report_Ordermaster_BuyerWisetest()
    {
        SqlCommand command = new SqlCommand("Sp_Smt_OrderMaster_ReportBuyerWisetest", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Report_Ordermaster_GmtTypeWise(string Formdt, string Todt)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_OrderMaster_ReportGMTTypeWise", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@StartDate", Formdt);
        command.Parameters.AddWithValue("@EndDate", Todt);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public static void RmvXR(string _xRid)
    {
        if (_xCrush.Contains(_xRid))
        {
            _xCrush.Remove(_xRid);
        }
    }

    public void sav_confstyle(string stno, int qty, string usr, string nfob, Label lbl)
    {
        if (this.mybll.get_InformationdataTable("select cStyleNo from Smt_StyleMaster where cStyleNo='" + stno + "'").Rows.Count > 0)
        {
            lbl.Text = "Already Exists";
        }
        else
        {
            SqlCommand command = new SqlCommand("Sp_Smt_StyleMaster_EcostConfirm", this.cn);
            if (this.cn.State == ConnectionState.Closed)
            {
                this.cn.Open();
            }
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@cStyleNo", stno);
            command.Parameters.AddWithValue("@nTotOrdQty", qty);
            command.Parameters.AddWithValue("@cInputUser", usr);
            command.Parameters.AddWithValue("@nfob", nfob);
            command.ExecuteNonQuery();
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
            lbl.Text = "Saved Successfully";
        }
    }

    public void Save_ActionDesc(string actiondesc, int actiontype, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand(string.Concat(new object[] { "select Action_Description from Smt_ActionDescription where Action_Description='", actiondesc.Trim(), "' and Action_Type=", actiontype }), this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_ActionDescription_Save", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@Action_Description", actiondesc);
            command2.Parameters.AddWithValue("@Action_Type", actiontype);
            command2.Parameters.AddWithValue("@Create_By", user);
            if (command2.ExecuteNonQuery() > 0)
            {
                lbl.Text = "Saved Successfully";
            }
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Save_ActionType(string actiontype, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand("select Action_Type from Smt_ActionType where Action_Type='" + actiontype.Trim() + "' ", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_ActionType_Save", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@Action_Type", actiontype);
            command2.Parameters.AddWithValue("@Create_By", user);
            if (command2.ExecuteNonQuery() > 0)
            {
                lbl.Text = "Saved Successfully";
            }
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Save_All(string Statement, string _Stp, string[] prClm, string[] prvl, Label lbl)
    {
        int count = 0;
        if (!string.IsNullOrEmpty(Statement))
        {
            count = this.mybll.get_InformationdataTable(Statement).Rows.Count;
        }
        if (count > 0)
        {
            lbl.Text = "Already Exists";
        }
        else
        {
            SqlCommand command = new SqlCommand(_Stp, this.cn);
            if (this.cn.State == ConnectionState.Closed)
            {
                this.cn.Open();
            }
            command.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < prClm.Length; i++)
            {
                string parameterName = prClm[i];
                string str2 = prvl[i];
                if (!string.IsNullOrEmpty(str2))
                {
                    command.Parameters.AddWithValue(parameterName, str2);
                }
                else
                {
                    command.Parameters.AddWithValue(parameterName, DBNull.Value);
                }
            }
            command.ExecuteNonQuery();
            lbl.Text = "Saved Successfully";
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Save_Article(string article, string maincode, Label lbl)
    {
        SqlCommand command = new SqlCommand("select cArticle,cMcat from Smt_Artcle where cArticle='" + article.Trim() + "' and cMcat='" + maincode.Trim() + "'", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_Artcle_Save", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@cArticle_1", article);
            command2.Parameters.AddWithValue("@cMCat", maincode);
            command2.ExecuteNonQuery();
            lbl.Text = "Saved Successfully";
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Save_AssortmentColor(int styleID, string Lot, string FabColor, string Shade, string userid, string grp, int colortot, string LabDipcc, string LabAppshade, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Colours_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nStyleID_1", styleID);
        command.Parameters.AddWithValue("@cLot_2", Lot);
        if (!string.IsNullOrEmpty(FabColor))
        {
            command.Parameters.AddWithValue("@cFabcol", FabColor);
        }
        else
        {
            command.Parameters.AddWithValue("@cFabcol", DBNull.Value);
        }
        command.Parameters["@cFabcol"].SqlDbType = SqlDbType.Int;
        if (!string.IsNullOrEmpty(Shade))
        {
            command.Parameters.AddWithValue("@cshd", Shade);
        }
        else
        {
            command.Parameters.AddWithValue("@cshd", "1");
        }
        command.Parameters["@cshd"].SqlDbType = SqlDbType.Int;
        command.Parameters.AddWithValue("@cEntUser_4", userid);
        command.Parameters.AddWithValue("@cGrp", grp);
        command.Parameters.AddWithValue("@nColtot", colortot);
        command.Parameters.AddWithValue("@LabDipCCNo", LabDipcc);
        command.Parameters.AddWithValue("@LabAppShade", LabAppshade);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        lbl.Text = "Saved Successfully";
    }

    public void Save_AssortmentColorforTab2(int styleid, string lot, string fabcolor, string shade, string user, string grp, int ctotal, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_InsOrdFabColour", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nStyleID_1", styleid);
        command.Parameters.AddWithValue("@cLot_2", lot);
        if (!string.IsNullOrEmpty(fabcolor))
        {
            command.Parameters.AddWithValue("@cFabcol", fabcolor);
        }
        else
        {
            command.Parameters.AddWithValue("@cFabcol", DBNull.Value);
        }
        command.Parameters["@cFabcol"].SqlDbType = SqlDbType.VarChar;
        if (!string.IsNullOrEmpty(shade))
        {
            command.Parameters.AddWithValue("@cshd", shade);
        }
        else
        {
            command.Parameters.AddWithValue("@cshd", DBNull.Value);
        }
        command.Parameters["@cshd"].SqlDbType = SqlDbType.VarChar;
        command.Parameters.AddWithValue("@cEntUser_4", user);
        command.Parameters.AddWithValue("@cGrp", grp);
        command.Parameters.AddWithValue("@nColtot", ctotal);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        lbl.Text = "Saved Successfully";
    }

    public void Save_assotcolsizprice(int StyleID, string Lot, int ColorCd, string ordSize, string SzPrice, string Entryby, Label lbl)
    {
        SqlCommand command = new SqlCommand("Smt_ColSizprice_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@StyleID", StyleID);
        command.Parameters.AddWithValue("@Lot", Lot);
        command.Parameters.AddWithValue("@ColorCd", ColorCd);
        command.Parameters.AddWithValue("@ordSize", ordSize);
        if (!string.IsNullOrEmpty(SzPrice))
        {
            command.Parameters.AddWithValue("@SzPrice", SzPrice);
        }
        else
        {
            command.Parameters.AddWithValue("@SzPrice", "0");
        }
        command.Parameters.AddWithValue("@Entryby", Entryby);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        lbl.Text = "Saved Successfully";
    }

    public void Save_BankInfo(string BankName, string Address, string Telephone, string fax, string country, string swiftCode, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand("select Bank_Name from Smt_BankInfo where Bank_Name='" + BankName.Trim() + "' and Bank_Address='" + Address + "' and Telephone_No='" + Telephone + "' and fax='" + fax + "' and Country_Code='" + country + "' and Swift_Code='" + swiftCode + "'", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_BankInfo_Save", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@Bank_Name", BankName);
            command2.Parameters.AddWithValue("@Bank_Address", Address);
            command2.Parameters.AddWithValue("@Telephone_No", Telephone);
            command2.Parameters.AddWithValue("@Fax", fax);
            command2.Parameters.AddWithValue("@Country_Code", country);
            command2.Parameters.AddWithValue("@Swift_Code", swiftCode);
            command2.Parameters.AddWithValue("@Created_By", user);
            command2.ExecuteNonQuery();
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
            lbl.Text = "Saved Successfully";
        }
    }

    public void Save_BOM(int nstyCode_1, string cver_2, string nItemcode_3, string cUnit_4, string nCom_5, string nWst_6, string nUprice_7, string nValue_8, string nSup_9, string nOrdqty_10, string cUser_11, string cCurtype, string cSzRange, string ctype, string nReqqty, string nStock, string nNetReq, string nColtQty, string csize, string cFabCol, string cMcat, int bszSen, int bColSen, int bPack, int bRecnf, string cpack, string nDyeGrp, string cPos, string cPlsmnt, string Gmtprt, int badj, string clots, int ncnf, int npook, string cremk, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_BOM_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nstyCode_1", nstyCode_1);
        command.Parameters.AddWithValue("@cver_2", cver_2);
        if (!string.IsNullOrEmpty(nItemcode_3))
        {
            command.Parameters.AddWithValue("@nItemcode_3", nItemcode_3);
        }
        else
        {
            command.Parameters.AddWithValue("@nItemcode_3", DBNull.Value);
        }
        command.Parameters["@nItemcode_3"].SqlDbType = SqlDbType.Int;
        command.Parameters.AddWithValue("@cUnit_4", cUnit_4);
        if (!string.IsNullOrEmpty(nCom_5))
        {
            command.Parameters.AddWithValue("@nCom_5", nCom_5);
        }
        else
        {
            command.Parameters.AddWithValue("@nCom_5", DBNull.Value);
        }
        command.Parameters["@nCom_5"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(nWst_6))
        {
            command.Parameters.AddWithValue("@nWst_6", nWst_6);
        }
        else
        {
            command.Parameters.AddWithValue("@nWst_6", DBNull.Value);
        }
        command.Parameters["@nWst_6"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(nUprice_7))
        {
            command.Parameters.AddWithValue("@nUprice_7", nUprice_7);
        }
        else
        {
            command.Parameters.AddWithValue("@nUprice_7", DBNull.Value);
        }
        command.Parameters["@nUprice_7"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(nValue_8))
        {
            command.Parameters.AddWithValue("@nValue_8", nValue_8);
        }
        else
        {
            command.Parameters.AddWithValue("@nValue_8", DBNull.Value);
        }
        command.Parameters["@nValue_8"].SqlDbType = SqlDbType.Decimal;
        command.Parameters.AddWithValue("@nSup_9", nSup_9);
        if (!string.IsNullOrEmpty(nOrdqty_10))
        {
            command.Parameters.AddWithValue("@nOrdqty_10", nOrdqty_10);
        }
        else
        {
            command.Parameters.AddWithValue("@nOrdqty_10", DBNull.Value);
        }
        command.Parameters["@nOrdqty_10"].SqlDbType = SqlDbType.Int;
        command.Parameters.AddWithValue("@cUser_11", cUser_11);
        command.Parameters.AddWithValue("@cCurtype", cCurtype);
        command.Parameters.AddWithValue("@cSzRange", cSzRange);
        command.Parameters.AddWithValue("@ctype", ctype);
        if (!string.IsNullOrEmpty(nReqqty))
        {
            command.Parameters.AddWithValue("@nReqqty", nReqqty);
        }
        else
        {
            command.Parameters.AddWithValue("@nReqqty", DBNull.Value);
        }
        command.Parameters["@nReqqty"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(nStock))
        {
            command.Parameters.AddWithValue("@nStock", nStock);
        }
        else
        {
            command.Parameters.AddWithValue("@nStock", "0.000");
        }
        command.Parameters["@nStock"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(nNetReq))
        {
            command.Parameters.AddWithValue("@nNetReq", nNetReq);
        }
        else
        {
            command.Parameters.AddWithValue("@nNetReq", DBNull.Value);
        }
        command.Parameters["@nNetReq"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(nColtQty))
        {
            command.Parameters.AddWithValue("@nColtQty", nColtQty);
        }
        else
        {
            command.Parameters.AddWithValue("@nColtQty", DBNull.Value);
        }
        command.Parameters["@nColtQty"].SqlDbType = SqlDbType.Int;
        command.Parameters.AddWithValue("@csize", csize);
        command.Parameters.AddWithValue("@cFabCol", cFabCol);
        command.Parameters.AddWithValue("@cMcat", cMcat);
        command.Parameters.AddWithValue("@bszSen", bszSen);
        command.Parameters.AddWithValue("@bColSen", bColSen);
        command.Parameters.AddWithValue("@bPack", bPack);
        command.Parameters.AddWithValue("@bRecnf", bRecnf);
        command.Parameters.AddWithValue("@cpack", cpack);
        if (!string.IsNullOrEmpty(nDyeGrp))
        {
            command.Parameters.AddWithValue("@nDyeGrp", nDyeGrp);
        }
        else
        {
            command.Parameters.AddWithValue("@nDyeGrp", DBNull.Value);
        }
        command.Parameters["@nDyeGrp"].SqlDbType = SqlDbType.Int;
        command.Parameters.AddWithValue("@cPos", cPos);
        command.Parameters.AddWithValue("@cPlsmnt", cPlsmnt);
        command.Parameters.AddWithValue("@Gmtprt", Gmtprt);
        command.Parameters.AddWithValue("@badj", badj);
        command.Parameters.AddWithValue("@clots", clots);
        command.Parameters.AddWithValue("@ncnf", ncnf);
        command.Parameters.AddWithValue("@npook", npook);
        command.Parameters.AddWithValue("@cremk", cremk);
        command.ExecuteNonQuery();
        lbl.Text = "Saved Successfully";
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_Brand(string brand, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand("select cBrand_Name from Smt_Brand where cBrand_Name='" + brand.Trim() + "'", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_Brand_Save", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("cBrand_Name", brand);
            command2.Parameters.AddWithValue("cEntUser", user);
            if (command2.ExecuteNonQuery() > 0)
            {
                lbl.Text = "Saved Successfully";
            }
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Save_btnperm(string Userid, string formname, string btnid, string btntext, string permission, string modulename, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_tst_permitterbtn_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@UserName", Userid);
        command.Parameters.AddWithValue("@FormName", formname);
        command.Parameters.AddWithValue("@ButtonName", btnid);
        command.Parameters.AddWithValue("@ButtonText", btntext);
        command.Parameters.AddWithValue("@Permission", permission);
        command.Parameters.AddWithValue("@ModuleName", modulename);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        lbl.Text = "Saved Successfully";
    }

    public void Save_btnPermission(string btnName, string btntext, string FormName)
    {
        SqlCommand command = new SqlCommand("Sp_tst_Button_sv", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@Btn_Name", btnName);
        command.Parameters.AddWithValue("@Btn_Text", btntext);
        command.Parameters.AddWithValue("@Form_Name", FormName);
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_BuildingUnit(string Unitname, int Company_ID, string username, Label lbl)
    {
        SqlCommand command = new SqlCommand(string.Concat(new object[] { "select Unit_Name from Smt_BuildingUnit where Unit_Name='", Unitname, "' and Company_ID=", Company_ID }), this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        SqlDataReader reader = command.ExecuteReader();
        reader.Read();
        if (reader.HasRows)
        {
            lbl.Text = "Already Exist";
            reader.Close();
        }
        else
        {
            reader.Close();
            SqlCommand command2 = new SqlCommand("Sp_Smt_BuildingUnit_Save", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@Unit_Name", Unitname);
            command2.Parameters.AddWithValue("@Company_ID", Company_ID);
            command2.Parameters.AddWithValue("@CreatedBy", username);
            command2.ExecuteNonQuery();
            lbl.Text = "Saved Successfully";
        }
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_Buyer(string Buyer, string user, string Address1, string Address2, string Phone_No, string Cont_Person, string Email, string Fax, int buyerid, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_BuyerName_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@cBuyer_Name", Buyer);
        command.Parameters.AddWithValue("@cEntUser", user);
        command.Parameters.AddWithValue("@Address1", Address1);
        command.Parameters.AddWithValue("@Address2", Address2);
        command.Parameters.AddWithValue("@Phone_No", Phone_No);
        command.Parameters.AddWithValue("@Cont_Person", Cont_Person);
        command.Parameters.AddWithValue("@Email", Email);
        command.Parameters.AddWithValue("@Fax", Fax);
        command.Parameters.AddWithValue("@nBuyer_ID", buyerid);
        if (command.ExecuteNonQuery() > 0)
        {
            lbl.Text = "Saved Successfully";
        }
        else
        {
            lbl.Text = "Already Exist";
        }
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_Color(string Color, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand("select cColour from Smt_Colours where cColour='" + Color.Trim() + "'", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_Color_Save", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("cColour", Color);
            command2.Parameters.AddWithValue("cEntUser", user);
            if (command2.ExecuteNonQuery() > 0)
            {
                lbl.Text = "Saved Successfully";
            }
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Save_Colorgroup(string grp, string packdesc, Label lbl)
    {
        SqlCommand command = new SqlCommand("select cGrp from Smt_ColGrp where cGrp='" + grp.Trim() + "' and cPAckDis='" + packdesc + "'", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_ColGrp_Save", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("cGrp", grp);
            command2.Parameters.AddWithValue("cPAckDis", packdesc);
            command2.ExecuteNonQuery();
            lbl.Text = "Saved Successfully";
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Save_ColorSensitivity(int nstyCode_1, string cLnType_2, string CFColNo_3, string cDes_4, string cEntUser_6, int nItemcd, string cPlsmnt, string nprice, int ArticleId, int DimensionID)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_ConAllAuto", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nstyCode_1", nstyCode_1);
        command.Parameters.AddWithValue("@cLnType_2", cLnType_2);
        command.Parameters.AddWithValue("@CFColNo_3", CFColNo_3);
        command.Parameters.AddWithValue("@cDes_4", cDes_4);
        command.Parameters.AddWithValue("@cEntUser_6", cEntUser_6);
        command.Parameters.AddWithValue("@nItemcd", nItemcd);
        command.Parameters.AddWithValue("@cPlsmnt", cPlsmnt);
        if (!string.IsNullOrEmpty(nprice))
        {
            command.Parameters.AddWithValue("@nprice", nprice);
        }
        else
        {
            command.Parameters.AddWithValue("@nprice", DBNull.Value);
        }
        command.Parameters["@nprice"].SqlDbType = SqlDbType.Decimal;
        command.Parameters.AddWithValue("@nArticle_ID", ArticleId);
        command.Parameters.AddWithValue("@nDimension_Id", DimensionID);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_CompanyInfo(string companyname, string add1, string add2, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand("select cCmpName from Smt_Company where cCmpName='" + companyname.Trim() + "'", this.cn);
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
            SqlCommand command2 = new SqlCommand("SP_Smt_Company", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@cCmpName", companyname);
            command2.Parameters.AddWithValue("@cAdd1", add1);
            command2.Parameters.AddWithValue("@cAdd2", add2);
            command2.Parameters.AddWithValue("@cEntUSer", user);
            if (command2.ExecuteNonQuery() > 0)
            {
                lbl.Text = "Saved Successfully";
            }
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Save_Control(Control parent, string formname)
    {
        foreach (Control control in parent.Controls)
        {
            if (control.Controls.Count > 0)
            {
                this.Save_Control(control, formname);
            }
            if (control is Button)
            {
                string text = ((Button)control).Text;
                string iD = ((Button)control).ID;
                this.Save_btnPermission(iD, text, formname);
            }
            if (control is ImageButton)
            {
                string toolTip = ((ImageButton)control).ToolTip;
                string btnName = ((ImageButton)control).ID;
                this.Save_btnPermission(btnName, toolTip, formname);
            }
        }
    }

    public void Save_Country(string cname, Label lbl)
    {
        SqlCommand command = new SqlCommand("select cConDes from Smt_Counrys where cConDes='" + cname.Trim() + "'", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_Counrys_Save", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@cConDes", cname);
            if (command2.ExecuteNonQuery() > 0)
            {
                lbl.Text = "Saved Successfully";
            }
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Save_CountryPack(int styleid, string shipid, string country, string item, int packquantity, string user, string pack, string type, int countrycode, string OrdNo, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_CntryPack", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nstyid_1", styleid);
        command.Parameters.AddWithValue("@cshpID_2", shipid);
        if (!string.IsNullOrEmpty(country))
        {
            command.Parameters.AddWithValue("@cCntry_3", country);
        }
        else
        {
            command.Parameters.AddWithValue("@cCntry_3", "-");
        }
        command.Parameters["@cCntry_3"].SqlDbType = SqlDbType.VarChar;
        command.Parameters.AddWithValue("@cItem_4", item);
        command.Parameters.AddWithValue("@nPacqty_5", packquantity);
        command.Parameters.AddWithValue("@centUser_6", user);
        command.Parameters.AddWithValue("@cPack", pack);
        command.Parameters.AddWithValue("@cType", type);
        command.Parameters.AddWithValue("@nCountryCode", countrycode);
        if (!string.IsNullOrEmpty(OrdNo))
        {
            command.Parameters.AddWithValue("@cOrderNo", OrdNo);
        }
        else
        {
            command.Parameters.AddWithValue("@cOrderNo", "-");
        }
        command.ExecuteNonQuery();
        lbl.Text = "Saved Successfully";
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_Currencytype(string code, string type, decimal exrate, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand(string.Concat(new object[] { "select cCurCode,cCurdes,nExgRate from Smt_CurencyType where cCurCode='", code.Trim(), "' and cCurdes='", type, "' and nExgRate='", exrate, "'" }), this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_CurencyType_Save", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@cCurCode", code);
            command2.Parameters.AddWithValue("@cCurdes", type);
            command2.Parameters.AddWithValue("@nExgRate", exrate);
            command2.Parameters.AddWithValue("@cuser", user);
            command2.ExecuteNonQuery();
            lbl.Text = "Saved Successfully";
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Save_Department(string department, int companyid, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand(string.Concat(new object[] { "select cDeptname,nCompanyID from Smt_Department where cDeptname='", department.Trim(), "' and nCompanyID='", companyid, "'" }), this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_Department_Save", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("cDeptname", department);
            command2.Parameters.AddWithValue("nCompanyID", companyid);
            command2.Parameters.AddWithValue("cEntUser", user);
            if (command2.ExecuteNonQuery() > 0)
            {
                lbl.Text = "Saved Successfully";
            }
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Save_Dependencygroup(string dpGroup, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand("select Dependency_Group from Smt_Dependencygroup where Dependency_Group='" + dpGroup.Trim() + "'", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_Dependencygroup_save", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@Dependency_Group", dpGroup);
            command2.Parameters.AddWithValue("@Create_User", user);
            if (command2.ExecuteNonQuery() > 0)
            {
                lbl.Text = "Saved Successfully";
            }
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Save_Desigantion(string Desigantion, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand("select cDesignation from Smt_Designation where cDesignation='" + Desigantion.Trim() + "'", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_Designation_Save", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@cDesignation", Desigantion);
            command2.Parameters.AddWithValue("@cEntUser", user);
            if (command2.ExecuteNonQuery() > 0)
            {
                lbl.Text = "Saved Successfully";
            }
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Save_Dimension(string Dimension, string maincode, Label lbl)
    {
        SqlCommand command = new SqlCommand("select cDimen,cMcat from Smt_Dimension where cDimen='" + Dimension.Trim() + "' and cMcat='" + maincode.Trim() + "'", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_Dimension_Save", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@cDimen_1", Dimension);
            command2.Parameters.AddWithValue("@cmcat", maincode);
            command2.ExecuteNonQuery();
            lbl.Text = "Saved Successfully";
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Save_Fabeshade(string shade, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand("select cShade from Smt_Fabshade where cShade='" + shade.Trim() + "'", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_Fabshade_Save", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("cShade", shade);
            command2.Parameters.AddWithValue("cEntUser", user);
            command2.ExecuteNonQuery();
            lbl.Text = "Saved Successfully";
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Save_Floor(string floor, int BuildingUID, int CompanyID, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand(string.Concat(new object[] { "select cFloor_Descriptin from Smt_Floor where cFloor_Descriptin='", floor.Trim(), "' and BuildingUID=", BuildingUID, " and CompanyID=", CompanyID }), this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_Floor_Save", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@cFloor_Descriptin", floor);
            command2.Parameters.AddWithValue("@cEntUser", user);
            command2.Parameters.AddWithValue("@BuildingUID", BuildingUID);
            command2.Parameters.AddWithValue("@CompanyID", CompanyID);
            if (command2.ExecuteNonQuery() > 0)
            {
                lbl.Text = "Saved Successfully";
            }
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Save_Garmentdept(string Garmentdept, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand("select cGmt_Dept_Description from Smt_Gmt_Department where cGmt_Dept_Description='" + Garmentdept.Trim() + "'", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_Gmt_Department_Save", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@cGmt_Dept_Description", Garmentdept);
            command2.Parameters.AddWithValue("@cEntUser", user);
            if (command2.ExecuteNonQuery() > 0)
            {
                lbl.Text = "Saved Successfully";
            }
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Save_GarmentType(string gmttype, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand("select cGmetDis from Smt_GmtType where cGmetDis='" + gmttype.Trim() + "'", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_GmtType_Save", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@cGmetDis", gmttype);
            command2.Parameters.AddWithValue("@Username", user);
            command2.ExecuteNonQuery();
            lbl.Text = "Saved Successfully";
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Save_grouppermission(string groupid, string formname, string fromurl, string permissionstatus, string userid, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_UserPermittedform_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        if (!string.IsNullOrEmpty(groupid))
        {
            command.Parameters.AddWithValue("@nUgroup", groupid);
        }
        else
        {
            command.Parameters.AddWithValue("@nUgroup", "99");
        }
        command.Parameters["@nUgroup"].SqlDbType = SqlDbType.Int;
        command.Parameters.AddWithValue("@Form_Name", formname);
        command.Parameters.AddWithValue("@Url", fromurl);
        command.Parameters.AddWithValue("@Permission_Status", permissionstatus);
        command.Parameters.AddWithValue("@User_ID", userid);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        lbl.Text = "Saved Successfully";
    }

    public void Save_Inseam(int StyleID, string Lot, string Pack, int ColID, string OrdSize, string InsmSize, string Qty, string EntryBy, Label lbl)
    {
        if (this.mybll.get_InformationdataTable(string.Concat(new object[] { "select StyleID from Smt_InseamSize where StyleID=", StyleID, " and Lot='", Lot, "' and Pack='", Pack, "' and ColID=", ColID, " and OrdSize='", OrdSize, "' and InsmSize='", InsmSize, "'" })).Rows.Count > 0)
        {
            lbl.Text = "Already Exists";
        }
        else
        {
            SqlCommand command = new SqlCommand("Sp_Smt_Inseamsz_SV", this.cn);
            if (this.cn.State == ConnectionState.Closed)
            {
                this.cn.Open();
            }
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@StyleID", StyleID);
            command.Parameters.AddWithValue("@Lot", Lot);
            command.Parameters.AddWithValue("@Pack", Pack);
            command.Parameters.AddWithValue("@ColID", ColID);
            command.Parameters.AddWithValue("@OrdSize", OrdSize);
            command.Parameters.AddWithValue("@InsmSize", InsmSize);
            command.Parameters.AddWithValue("@Qty", Qty);
            command.Parameters.AddWithValue("@EntryBy", EntryBy);
            command.ExecuteNonQuery();
            lbl.Text = "Saved Successfully";
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Save_Inseamqty(int StyleID, string Lot, string Pack, int CountryCode, int ColorCode, string OrdSize, string InsmSize, string Insm_Qty, string EntryBy, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_InseamsQty_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@StyleID", StyleID);
        command.Parameters.AddWithValue("@Lot", Lot);
        command.Parameters.AddWithValue("@Pack", Pack);
        command.Parameters.AddWithValue("@CountryCode", CountryCode);
        command.Parameters.AddWithValue("@ColorCode", ColorCode);
        command.Parameters.AddWithValue("@OrdSize", OrdSize);
        command.Parameters.AddWithValue("@InsmSize", InsmSize);
        command.Parameters.AddWithValue("@Insm_Qty", Insm_Qty);
        command.Parameters.AddWithValue("@EntryBy", EntryBy);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        lbl.Text = "Saved Successfully";
    }

    public void Save_InseamQty(int styleid, DateTime shipdate, string lot, string itemno, string country, string pack, string color, string inseam, string shade, int nrow, int qty, string user, string[] InsmQty, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_InsSmtInseamQty", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nstyid_1", styleid);
        command.Parameters.AddWithValue("@dShiDt_2", shipdate);
        command.Parameters.AddWithValue("@cPo_3", lot);
        command.Parameters.AddWithValue("@cItemNo_4", itemno);
        command.Parameters.AddWithValue("@cContry_5", country);
        command.Parameters.AddWithValue("@cPack_6", pack);
        command.Parameters.AddWithValue("@cFabcol_7", color);
        command.Parameters.AddWithValue("@cInSeam_8", inseam);
        command.Parameters.AddWithValue("@cShade", shade);
        command.Parameters.AddWithValue("@nrow", nrow);
        command.Parameters.AddWithValue("@nQty2_10", qty);
        command.Parameters.AddWithValue("@dEntuser_11", user);
        for (int i = 1; i <= 60; i++)
        {
            string parameterName = "@nQty" + i;
            string str2 = InsmQty[i - 1];
            command.Parameters.AddWithValue(parameterName, str2);
        }
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        lbl.Text = "Saved Successfully";
    }

    public void Save_InseamSz(int StyleID, string Lot, string OrdSz, string InsmSize, string EntryBy, Label lbl)
    {
        if (this.mybll.get_InformationdataTable(string.Concat(new object[] { "select StyleID from Smt_InseamSz where StyleID=", StyleID, " and Lot='", Lot, "' and OrdSz='", OrdSz, "' and InsmSize='", InsmSize, "'" })).Rows.Count > 0)
        {
            lbl.Text = "Already Exists";
        }
        else
        {
            SqlCommand command = new SqlCommand("Sp_Smt_Inseamsz_Save", this.cn);
            if (this.cn.State == ConnectionState.Closed)
            {
                this.cn.Open();
            }
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@StyleID", StyleID);
            command.Parameters.AddWithValue("@Lot", Lot);
            command.Parameters.AddWithValue("@OrdSz", OrdSz);
            command.Parameters.AddWithValue("@InsmSize", InsmSize);
            command.Parameters.AddWithValue("@EntryBy", EntryBy);
            command.ExecuteNonQuery();
            lbl.Text = "Saved Successfully";
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Save_Learningcurve(string[] PValue, string Chkstatement, Label lbl)
    {
        string[] prClm = new string[] { "@Curve_Name", "@Day_1", "@Day_2", "@Day_3", "@Day_4", "@Day_5", "@Createby" };
        this.Save_All(Chkstatement, "Sp_Smt_Learningcurve_Save", prClm, PValue, lbl);
    }

    public void Save_Line(string Line_No, int CompanyID, int DepartmentID, int SectionID, int BuildingUnitID, int FloorID, string nMachineOp, string nHelper, string CreatedBy, Label lbl)
    {
        SqlCommand command = new SqlCommand(string.Concat(new object[] { "select Line_No from Smt_Line where Line_No='", Line_No, "' and CompanyID=", CompanyID, " and BuildingUnitID=", BuildingUnitID, " and FloorID=", FloorID }), this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        SqlDataReader reader = command.ExecuteReader();
        reader.Read();
        if (reader.HasRows)
        {
            reader.Close();
            lbl.Text = "Already Exists";
        }
        else
        {
            reader.Close();
            SqlCommand command2 = new SqlCommand("Sp_Smt_Line_Save", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@Line_No", Line_No);
            command2.Parameters.AddWithValue("@CompanyID", CompanyID);
            command2.Parameters.AddWithValue("@DepartmentID", DepartmentID);
            command2.Parameters.AddWithValue("@SectionID", SectionID);
            command2.Parameters.AddWithValue("@BuildingUnitID", BuildingUnitID);
            command2.Parameters.AddWithValue("@FloorID", FloorID);
            if (!string.IsNullOrEmpty(nMachineOp))
            {
                command2.Parameters.AddWithValue("@nMachineOp", nMachineOp);
            }
            else
            {
                command2.Parameters.AddWithValue("@nMachineOp", "0");
            }
            if (!string.IsNullOrEmpty(nHelper))
            {
                command2.Parameters.AddWithValue("@nHelper", nHelper);
            }
            else
            {
                command2.Parameters.AddWithValue("@nHelper", "0");
            }
            command2.Parameters.AddWithValue("@CreatedBy", CreatedBy);
            command2.ExecuteNonQuery();
            lbl.Text = "Saved Successfully";
        }
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_MainCategory(string maincategory, int mastercategoryid, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand(string.Concat(new object[] { "select cMainCategory,nMasterCategory_ID from Smt_MainCategory where cMainCategory='", maincategory.Trim(), "' and nMasterCategory_ID='", mastercategoryid, "'" }), this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_MainCategory_Save", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@cMainCategory", maincategory);
            command2.Parameters.AddWithValue("@nMasterCategory_ID", mastercategoryid);
            command2.Parameters.AddWithValue("@cEntUser", user);
            if (command2.ExecuteNonQuery() > 0)
            {
                lbl.Text = "Saved Successfully";
            }
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Save_MasterCategory(string MasterCategory, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand("select cMasterCategory from Smt_MasterCategory where cMasterCategory='" + MasterCategory.Trim() + "'", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_MasterCategory_Save", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@cMasterCategory", MasterCategory);
            command2.Parameters.AddWithValue("@cEntUser", user);
            command2.ExecuteNonQuery();
            lbl.Text = "Saved Successfully";
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void save_Masterstyle(string styleno, string contract, int garmenttype, int ttlqty, int buyer, string userid, short activity, string smv, string season, int bconf, string filename, int brandid, int storeid, int departmentid, int nopack, int ratio, string ctype, string recvdate, string ordrecvdate, string confirmdate, string colorrecv, string yearncount, int mscd, string factory, string ql, decimal fob, string confirmation, string fabrictype, string labccno, string bpcd, string ConfType, string Fobmode, Label result)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_StyleMaster_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@cStyleNo_2", styleno);
        command.Parameters.AddWithValue("@cDispStyleNo_3", contract);
        command.Parameters.AddWithValue("@nGmtType_4", garmenttype);
        command.Parameters.AddWithValue("@nTotOrdQty_5", ttlqty);
        command.Parameters.AddWithValue("@nAcct_6", buyer);
        command.Parameters.AddWithValue("@cInputUser_7", userid);
        command.Parameters.AddWithValue("@bInActive_9", activity);
        if (!string.IsNullOrEmpty(smv))
        {
            command.Parameters.AddWithValue("@nsmv", smv);
        }
        else
        {
            command.Parameters.AddWithValue("@nsmv", DBNull.Value);
        }
        command.Parameters["@nsmv"].SqlDbType = SqlDbType.Decimal;
        command.Parameters.AddWithValue("@nSeason_10", season);
        command.Parameters.AddWithValue("@bconf", bconf);
        command.Parameters.AddWithValue("@cfile", filename);
        command.Parameters.AddWithValue("@nBran_12", brandid);
        command.Parameters.AddWithValue("@nstore", storeid);
        command.Parameters.AddWithValue("@cdept", departmentid);
        command.Parameters.AddWithValue("@npack", nopack);
        command.Parameters.AddWithValue("@nratio", ratio);
        command.Parameters.AddWithValue("@cType", ctype);
        if (!string.IsNullOrEmpty(recvdate))
        {
            DateTime time = this.dateformat(recvdate);
            command.Parameters.AddWithValue("@dstdFileRec", time);
        }
        else
        {
            command.Parameters.AddWithValue("@dstdFileRec", DBNull.Value);
        }
        command.Parameters["@dstdFileRec"].SqlDbType = SqlDbType.DateTime;
        if (!string.IsNullOrEmpty(ordrecvdate))
        {
            DateTime time2 = this.dateformat(ordrecvdate);
            command.Parameters.AddWithValue("@dOOshtRec", time2);
        }
        else
        {
            command.Parameters.AddWithValue("@dOOshtRec", DBNull.Value);
        }
        command.Parameters["@dOOshtRec"].SqlDbType = SqlDbType.DateTime;
        if (!string.IsNullOrEmpty(confirmdate))
        {
            DateTime time3 = this.dateformat(confirmdate);
            command.Parameters.AddWithValue("@dCOShtRec", time3);
        }
        else
        {
            command.Parameters.AddWithValue("@dCOShtRec", DBNull.Value);
        }
        command.Parameters["@dCOShtRec"].SqlDbType = SqlDbType.DateTime;
        if (!string.IsNullOrEmpty(colorrecv))
        {
            DateTime time4 = this.dateformat(colorrecv);
            command.Parameters.AddWithValue("@dCSwchRec", time4);
        }
        else
        {
            command.Parameters.AddWithValue("@dCSwchRec", DBNull.Value);
        }
        command.Parameters["@dCSwchRec"].SqlDbType = SqlDbType.DateTime;
        command.Parameters.AddWithValue("@cYnCnt", yearncount);
        command.Parameters.AddWithValue("@nMSCd", mscd);
        command.Parameters.AddWithValue("@cCmp", factory);
        command.Parameters.AddWithValue("@cQl", ql);
        command.Parameters.AddWithValue("@nFob", fob);
        command.Parameters.AddWithValue("@cCnftype", confirmation);
        command.Parameters.AddWithValue("@cFabtype", fabrictype);
        command.Parameters.AddWithValue("@cLabccno", labccno);
        if (!string.IsNullOrEmpty(bpcd))
        {
            DateTime time5 = this.dateformat(bpcd);
            command.Parameters.AddWithValue("@bpcd", time5);
        }
        else
        {
            command.Parameters.AddWithValue("@bpcd", DBNull.Value);
        }
        command.Parameters["@bpcd"].SqlDbType = SqlDbType.DateTime;
        command.Parameters.AddWithValue("@ConfirmStatus", ConfType);
        command.Parameters.AddWithValue("@Fobmode", Fobmode);
        if (command.ExecuteNonQuery() > 0)
        {
            result.Text = "Saved Successfully";
        }
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_Newitem(string Desc, string maincode, string user, string Unit, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_SubCatagory_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@cDes_2", Desc);
        command.Parameters.AddWithValue("@cManCode_3", maincode);
        command.Parameters.AddWithValue("@CEntUser_5", user);
        command.Parameters.AddWithValue("@cUnit", Unit);
        command.ExecuteNonQuery();
        lbl.Text = "Saved Successfully";
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_Newuser(string username, string Userfullname, string password, int userlevel, int department, int sectionid, string email, int companyid, string usergroup, string permissionstatus, string activitystatu, Label lbl)
    {
        SqlCommand command = new SqlCommand("select cUserName from Smt_Users where cUserName='" + username.Trim() + "' ", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_Users_Save", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("cUserName", username);
            command2.Parameters.AddWithValue("cUserFullname", Userfullname);
            command2.Parameters.AddWithValue("cPassWord", password);
            command2.Parameters.AddWithValue("nULevelID", userlevel);
            command2.Parameters.AddWithValue("nUserDept", department);
            command2.Parameters.AddWithValue("nSectionID", sectionid);
            command2.Parameters.AddWithValue("Email", email);
            command2.Parameters.AddWithValue("nCompanyID", companyid);
            if (!string.IsNullOrEmpty(usergroup))
            {
                command2.Parameters.AddWithValue("nUgroup", usergroup);
            }
            else
            {
                command2.Parameters.AddWithValue("nUgroup", "99");
            }
            command2.Parameters["nUgroup"].SqlDbType = SqlDbType.Int;
            command2.Parameters.AddWithValue("@Permission_status", permissionstatus);
            command2.Parameters.AddWithValue("@Activity_status", activitystatu);
            command2.ExecuteNonQuery();
            lbl.Text = "Saved Successfully";
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Save_OrderDetail(int styleid, string lot, string color, string shade, string[] Size, int nCont_24, string user, string grp, int coltotal, string csty, string labcolno, string labshade, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_OrderDtl_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nStyleID_1", styleid);
        command.Parameters.AddWithValue("@Clot_2", lot);
        if (!string.IsNullOrEmpty(color))
        {
            command.Parameters.AddWithValue("@Col", color);
        }
        else
        {
            command.Parameters.AddWithValue("@Col", DBNull.Value);
        }
        command.Parameters["@Col"].SqlDbType = SqlDbType.Int;
        if (!string.IsNullOrEmpty(shade))
        {
            command.Parameters.AddWithValue("@cshd", shade);
        }
        else
        {
            command.Parameters.AddWithValue("@cshd", "1");
        }
        command.Parameters["@cshd"].SqlDbType = SqlDbType.Int;
        for (int i = 1; i <= 60; i++)
        {
            string parameterName = "@cS" + i;
            string str2 = Size[i - 1].ToString().ToUpper();
            command.Parameters.AddWithValue(parameterName, str2);
        }
        command.Parameters.AddWithValue("@nCont_24", nCont_24);
        command.Parameters.AddWithValue("@cEntuser_25", user);
        command.Parameters.AddWithValue("@cGrp", grp);
        command.Parameters.AddWithValue("@nColtot", coltotal);
        command.Parameters.AddWithValue("@csty", csty);
        command.Parameters.AddWithValue("@cLbColno", labcolno);
        command.Parameters.AddWithValue("@clbshd", labshade);
        command.ExecuteNonQuery();
        lbl.Text = "Saved Successfully";
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_ordermaster(string styleid, string lot, int orderqty, string pono, string shipmode, string shipdate, int nopack, int ratio, decimal fob, string ShipDt, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_OrdersMaster_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nOStyleId_1", styleid);
        command.Parameters.AddWithValue("@cOrderNu_2", lot);
        command.Parameters.AddWithValue("@nOrdQty_3", orderqty);
        command.Parameters.AddWithValue("@cPoNum_4", pono);
        command.Parameters.AddWithValue("@mode", shipmode);
        if (!string.IsNullOrEmpty(shipdate))
        {
            DateTime time = this.dateformat(shipdate);
            command.Parameters.AddWithValue("@xfty", time);
        }
        else
        {
            command.Parameters.AddWithValue("@xfty", DBNull.Value);
        }
        command.Parameters["@xfty"].SqlDbType = SqlDbType.DateTime;
        command.Parameters.AddWithValue("@npack", nopack);
        command.Parameters.AddWithValue("@nratio", ratio);
        command.Parameters.AddWithValue("@nfob", fob);
        if (!string.IsNullOrEmpty(ShipDt))
        {
            DateTime time2 = this.dateformat(ShipDt);
            command.Parameters.AddWithValue("@ShipDt", time2);
        }
        else
        {
            command.Parameters.AddWithValue("@ShipDt", DBNull.Value);
        }
        command.Parameters["@ShipDt"].SqlDbType = SqlDbType.DateTime;
        if (command.ExecuteNonQuery() > 0)
        {
            lbl.Text = "Saved Successfully";
        }
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void save_Ordersize(int styleid, string lot, string[] size, string[] insem, string[] GSz, string userid, int active, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_OrderSize", this.cn);
        this.cn.Open();
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nStyleID_1", styleid);
        command.Parameters.AddWithValue("@cLotNo_2", lot);
        for (int i = 1; i <= 60; i++)
        {
            string parameterName = "@size" + i;
            string str2 = size[i - 1].ToString().ToUpper();
            command.Parameters.AddWithValue(parameterName, str2);
        }
        for (int j = 1; j <= 60; j++)
        {
            string str3 = "@insem" + j;
            string str4 = insem[j - 1].ToString().ToUpper();
            command.Parameters.AddWithValue(str3, str4);
        }
        for (int k = 1; k <= 60; k++)
        {
            string str5 = "@GSz" + k;
            string str6 = GSz[k - 1].ToString().ToUpper();
            command.Parameters.AddWithValue(str5, str6);
        }
        command.Parameters.AddWithValue("@cEnctUser_13", userid);
        command.Parameters.AddWithValue("@bAIn", active);
        command.ExecuteNonQuery();
        lbl.Text = "Saved Successfully";
        this.cn.Close();
    }

    public void save_PackCountry(int styleid, string lot, string color, string shade, string pack, string[] nR1, string[] nR2, int packqty, string userid, int CountryCode, string OrdNo, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_PackContry", this.cn);
        this.cn.Open();
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nstyCd_1", styleid);
        command.Parameters.AddWithValue("@cShiId_2", lot);
        command.Parameters.AddWithValue("@cCol_3", color);
        command.Parameters.AddWithValue("@cshd_4", shade);
        command.Parameters.AddWithValue("@cPack_6", pack);
        for (int i = 1; i <= 0x19; i++)
        {
            int num2 = i + 7;
            string parameterName = string.Concat(new object[] { "@nR", i, "_", num2 });
            string str2 = nR1[i - 1].ToString();
            command.Parameters.AddWithValue(parameterName, str2);
        }
        for (int j = 0x1a; j <= 60; j++)
        {
            string str3 = "@nR" + j;
            string str4 = nR2[j - 1].ToString();
            command.Parameters.AddWithValue(str3, str4);
        }
        command.Parameters.AddWithValue("@nPackQty", packqty);
        command.Parameters.AddWithValue("@cEntuser_33", userid);
        command.Parameters.AddWithValue("@nCountryCode", CountryCode);
        if (!string.IsNullOrEmpty(OrdNo))
        {
            command.Parameters.AddWithValue("@cOrderNo", OrdNo);
        }
        else
        {
            command.Parameters.AddWithValue("@cOrderNo", "-");
        }
        command.ExecuteNonQuery();
        lbl.Text = "Saved Successfully";
        this.cn.Close();
    }

    public void Save_ProductionDaytarget(int StyleID, string Lot, int P_Month, int P_Year, string[] _Allday, string Tgt_Hour, string Tgt_10Hour, int sl, string Split)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Plan_DayTargets_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@StyleID", StyleID);
        command.Parameters.AddWithValue("@Lot", Lot);
        command.Parameters.AddWithValue("@P_Month", P_Month);
        command.Parameters.AddWithValue("@P_Year", P_Year);
        for (int i = 1; i <= _Allday.Length; i++)
        {
            string parameterName = "@Day" + i;
            string str2 = _Allday[i - 1].ToString();
            string str3 = "0";
            if (!string.IsNullOrEmpty(str2))
            {
                str3 = str2;
            }
            command.Parameters.AddWithValue(parameterName, str3);
        }
        if (!string.IsNullOrEmpty(Tgt_Hour))
        {
            command.Parameters.AddWithValue("@Tgt_Hour", Tgt_Hour);
        }
        else
        {
            command.Parameters.AddWithValue("@Tgt_Hour", "0");
        }
        if (!string.IsNullOrEmpty(Tgt_10Hour))
        {
            command.Parameters.AddWithValue("@Tgt_10Hour", Tgt_10Hour);
        }
        else
        {
            command.Parameters.AddWithValue("@Tgt_10Hour", "0");
        }
        command.Parameters.AddWithValue("@sl", sl);
        command.Parameters.AddWithValue("@Split", Split);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_Productionplan(int CompanyID, int BuildingUnit_ID, int FloorID, int LineID, int BuyerID, string PONo, string febRefno, string Marchandisir, string EMB, string BPCD, string Sewing, string POQty, string DevQty, string CreatedBy, string LotNo, int StyleID, string StartDt, string ShipDt, int P_Month, int P_Year, string Split, int Tgt_Hour, int Tgt_10Hour, string[] trgtday, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Productionplane_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@CompanyID", CompanyID);
        command.Parameters.AddWithValue("@BuildingUnit_ID", BuildingUnit_ID);
        command.Parameters.AddWithValue("@FloorID", FloorID);
        command.Parameters.AddWithValue("@LineID", LineID);
        command.Parameters.AddWithValue("@BuyerID", BuyerID);
        command.Parameters.AddWithValue("@PONo", PONo);
        command.Parameters.AddWithValue("@febRefno", febRefno);
        command.Parameters.AddWithValue("@Marchandisir", Marchandisir);
        command.Parameters.AddWithValue("@EMB", EMB);
        if (!string.IsNullOrEmpty(BPCD))
        {
            DateTime time = this.dateformat(BPCD);
            command.Parameters.AddWithValue("@BPCD", time);
        }
        else
        {
            command.Parameters.AddWithValue("@BPCD", DBNull.Value);
        }
        command.Parameters["@BPCD"].SqlDbType = SqlDbType.DateTime;
        command.Parameters.AddWithValue("@Sewing", Sewing);
        command.Parameters.AddWithValue("@POQty", POQty);
        if (!string.IsNullOrEmpty(DevQty))
        {
            command.Parameters.AddWithValue("@DevQty", DevQty);
        }
        else
        {
            command.Parameters.AddWithValue("@DevQty", "0.00");
        }
        command.Parameters.AddWithValue("@CreatedBy", CreatedBy);
        command.Parameters.AddWithValue("@LotNo", LotNo);
        command.Parameters.AddWithValue("@StyleID", StyleID);
        if (!string.IsNullOrEmpty(StartDt))
        {
            DateTime time2 = this.dateformat(StartDt);
            command.Parameters.AddWithValue("@StartDt", time2);
        }
        else
        {
            command.Parameters.AddWithValue("@StartDt", DBNull.Value);
        }
        command.Parameters["@StartDt"].SqlDbType = SqlDbType.DateTime;
        if (!string.IsNullOrEmpty(ShipDt))
        {
            DateTime time3 = this.dateformat(ShipDt);
            command.Parameters.AddWithValue("@ShipDt", time3);
        }
        else
        {
            command.Parameters.AddWithValue("@ShipDt", DBNull.Value);
        }
        command.Parameters["@ShipDt"].SqlDbType = SqlDbType.DateTime;
        command.Parameters.AddWithValue("@P_Month", P_Month);
        command.Parameters.AddWithValue("@P_Year", P_Year);
        command.Parameters.AddWithValue("@Tgt_Hour", Tgt_Hour);
        command.Parameters.AddWithValue("@Tgt_10Hour", Tgt_10Hour);
        for (int i = 1; i <= trgtday.Length; i++)
        {
            string parameterName = "@Day" + i;
            string str2 = trgtday[i - 1].ToString();
            string str3 = "0";
            if (!string.IsNullOrEmpty(str2))
            {
                str3 = str2;
            }
            command.Parameters.AddWithValue(parameterName, str3);
        }
        command.Parameters.AddWithValue("@Split", Split);
        command.ExecuteNonQuery();
        lbl.Text = "Saved Successfully";
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_Season(string season, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand("select cSeason_Name from Smt_Season where cSeason_Name='" + season.Trim() + "'", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_Season_Save", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("cSeason_Name", season);
            command2.Parameters.AddWithValue("cEntUser", user);
            if (command2.ExecuteNonQuery() > 0)
            {
                lbl.Text = "Saved Successfully";
            }
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Save_Section(string section, int department, int carder, int companyid, string supervisor, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand(string.Concat(new object[] { "select cSection_Description from Smt_Section where cSection_Description='", section.Trim(), "' and nCompanyID=", companyid }), this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_Section_Save", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("cSection_Description", section);
            command2.Parameters.AddWithValue("nUserDept", department);
            command2.Parameters.AddWithValue("nCarder", carder);
            command2.Parameters.AddWithValue("nCompanyID", companyid);
            command2.Parameters.AddWithValue("cSupervisor", supervisor);
            command2.Parameters.AddWithValue("cEntUser", user);
            if (command2.ExecuteNonQuery() > 0)
            {
                lbl.Text = "Saved Successfully";
            }
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Save_SizeSensitivity(int nStyID_1, string cMcat_2, string cSize_3, string cDime_4, string cEntUSe_5, string cItemNAme, string cPlsmnt, string nPrice)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_SizeSensitive", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nStyID_1", nStyID_1);
        command.Parameters.AddWithValue("@cMcat_2", cMcat_2);
        command.Parameters.AddWithValue("@cSize_3", cSize_3);
        command.Parameters.AddWithValue("@cDime_4", cDime_4);
        command.Parameters.AddWithValue("@cEntUSe_5", cEntUSe_5);
        command.Parameters.AddWithValue("@cItemNAme", cItemNAme);
        command.Parameters.AddWithValue("@cPlsmnt", cPlsmnt);
        if (!string.IsNullOrEmpty(nPrice))
        {
            command.Parameters.AddWithValue("@nPrice", nPrice);
        }
        else
        {
            command.Parameters.AddWithValue("@nPrice", DBNull.Value);
        }
        command.Parameters["@nPrice"].SqlDbType = SqlDbType.Decimal;
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_specialoperation(string cstid, int nspid2, string cEntUSer_3, Label lbl)
    {
        SqlCommand command = new SqlCommand("SpInsSmtStySpOp", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@csty", cstid);
        command.Parameters.AddWithValue("@nSpId_2", nspid2);
        command.Parameters.AddWithValue("@cEntUSer_3", cEntUSer_3);
        if (command.ExecuteNonQuery() > 0)
        {
            lbl.Text = "Saved Successfully";
        }
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_Store(string storename, int country, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Store_Save", this.cn);
        if ((this.cn.State == ConnectionState.Closed) || (this.cn.State == ConnectionState.Broken))
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@cStore_Name", storename);
        command.Parameters.AddWithValue("@nCountry_ID", country);
        command.Parameters.AddWithValue("@cEntUser", user);
        if (command.ExecuteNonQuery() > 0)
        {
            lbl.Text = "Saved Successfully";
        }
        else
        {
            lbl.Text = "Already Exist";
        }
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void save_styleFile(int styleid, string filenm, string user, int flsl, string Remarks)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_StylemasterFile", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@StyleID", styleid);
        command.Parameters.AddWithValue("@Fileno", filenm);
        command.Parameters.AddWithValue("@CreateBy", user);
        command.Parameters.AddWithValue("@Flsl", flsl);
        command.Parameters.AddWithValue("@Remarks", Remarks);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_StyleType(string StyleType, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand("select cStyleType from Smt_StyleType where cStyleType='" + StyleType.Trim() + "'", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_StyleType_Save", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@cStyleType", StyleType);
            command2.Parameters.AddWithValue("@cEntUser", user);
            command2.ExecuteNonQuery();
            lbl.Text = "Saved Successfully";
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Save_Suppliermaincategory(string code, string maincat)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_SupSupManCat_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@cSupCode_1", code);
        command.Parameters.AddWithValue("@cManCat_2", maincat);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_Suppliers(string supcode, string name, string add1, string add2, string contno, string valtno, string type, string user, string catt, string email, string code, Label lbl)
    {
        SqlCommand command = new SqlCommand("select cSupName from Smt_Suppliers where cSupName='" + name.Trim() + "'", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        SqlDataReader reader = command.ExecuteReader();
        if (reader.Read())
        {
            lbl.Text = "Supplier Name Already Exist";
            reader.Close();
        }
        else
        {
            reader.Close();
            SqlCommand command2 = new SqlCommand("Sp_Smt_Suppliers", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@cSupCode_1", supcode);
            command2.Parameters.AddWithValue("@cSupName_2", name);
            command2.Parameters.AddWithValue("@cSupAdd1_3", add1);
            command2.Parameters.AddWithValue("@cSupAdd2_4", add2);
            command2.Parameters.AddWithValue("@cSupContNo_5", contno);
            command2.Parameters.AddWithValue("@cSupValtNo_6", valtno);
            command2.Parameters.AddWithValue("@cSupType_7", type);
            command2.Parameters.AddWithValue("@cEntUser_9", user);
            command2.Parameters.AddWithValue("@catt", catt);
            command2.Parameters.AddWithValue("@cEmail", email);
            command2.Parameters.AddWithValue("@csCode", code);
            command2.ExecuteNonQuery();
            lbl.Text = "Saved Successfully";
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Save_TNABuyer(string Buyer_Id, string Action_ID, string Gap_Days, string Department_Id, string Create_By, int Action_TypeID, int Critical_Action, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_TNA_Buyer_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@Buyer_Id", Buyer_Id);
        command.Parameters.AddWithValue("@Action_ID", Action_ID);
        command.Parameters.AddWithValue("@Gap_Days", Gap_Days);
        command.Parameters.AddWithValue("@Department_Id", Department_Id);
        command.Parameters.AddWithValue("@Create_By", Create_By);
        command.Parameters.AddWithValue("@Action_TypeID", Action_TypeID);
        command.Parameters.AddWithValue("@Critical_Action", Critical_Action);
        command.ExecuteNonQuery();
        lbl.Text = "Saved Successfully";
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_TNACustom(string Action_ID, int Gap_Days, string Department_Id, string Create_By, int Action_TypeID, int Critical_Action, string CustomName, int leddays, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_TNA_Custom_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@Action_ID", Action_ID);
        command.Parameters.AddWithValue("@Gap_Days", Gap_Days);
        command.Parameters.AddWithValue("@Department_Id", Department_Id);
        command.Parameters.AddWithValue("@Create_By", Create_By);
        command.Parameters.AddWithValue("@Action_TypeID", Action_TypeID);
        command.Parameters.AddWithValue("@Critical_Action", Critical_Action);
        command.Parameters.AddWithValue("@CustomName", CustomName);
        command.Parameters.AddWithValue("@SLD", leddays);
        command.ExecuteNonQuery();
        lbl.Text = "Saved Successfully";
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_TNAParameter(string Actiontype, string actiondes, string gapdays, string actiondept, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand("select Action_Description from Smt_TNA_Parameter where Action_Type=" + Actiontype.Trim() + " and Action_Description='" + actiondes + "'", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_TNA_Parameter_Save", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@Action_Type", Actiontype);
            command2.Parameters.AddWithValue("@Action_Description", actiondes);
            command2.Parameters.AddWithValue("@Gap_Days", gapdays);
            command2.Parameters.AddWithValue("@Action_Dept", actiondept);
            command2.Parameters.AddWithValue("@Created_By", user);
            command2.ExecuteNonQuery();
            lbl.Text = "Saved Successfully";
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Save_TNAStyle(string nStyle_Id, string Action_ID, int Gap_Days, string Department_Id, string Create_By, int Action_TypeID, int Critical_Action, DateTime BPCD, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_TNA_Style_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nStyle_Id", nStyle_Id);
        command.Parameters.AddWithValue("@Action_ID", Action_ID);
        command.Parameters.AddWithValue("@Gap_Days", Gap_Days);
        command.Parameters.AddWithValue("@Department_Id", Department_Id);
        command.Parameters.AddWithValue("@Create_By", Create_By);
        command.Parameters.AddWithValue("@Action_TypeID", Action_TypeID);
        command.Parameters.AddWithValue("@Critical_Action", Critical_Action);
        command.Parameters.AddWithValue("@BPCD", BPCD);
        command.ExecuteNonQuery();
        lbl.Text = "Saved Successfully";
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_TNATaskStatus(int Action_TypeID, int Actin_ElementID, string Action_status, string Actual_Date, string Fst_Plndate, string Scnd_Plndate, string Thrd_Plndate, string Tsk_CompleteDt, string Comments, int Style_ID, int Gap_Days, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_TNA_TaskStatus_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@Action_TypeID", Action_TypeID);
        command.Parameters.AddWithValue("@Actin_ElementID", Actin_ElementID);
        command.Parameters.AddWithValue("@Action_status", Action_status);
        if (!string.IsNullOrEmpty(Actual_Date))
        {
            DateTime time = this.dateformat(Actual_Date);
            command.Parameters.AddWithValue("@Actual_Date", time);
        }
        else
        {
            command.Parameters.AddWithValue("@Actual_Date", DBNull.Value);
        }
        command.Parameters["@Actual_Date"].SqlDbType = SqlDbType.DateTime;
        if (!string.IsNullOrEmpty(Fst_Plndate))
        {
            DateTime time2 = this.dateformat(Fst_Plndate);
            command.Parameters.AddWithValue("@Fst_Plndate", time2);
        }
        else
        {
            command.Parameters.AddWithValue("@Fst_Plndate", DBNull.Value);
        }
        command.Parameters["@Fst_Plndate"].SqlDbType = SqlDbType.DateTime;
        if (!string.IsNullOrEmpty(Scnd_Plndate))
        {
            DateTime time3 = this.dateformat(Scnd_Plndate);
            command.Parameters.AddWithValue("@Scnd_Plndate", time3);
        }
        else
        {
            command.Parameters.AddWithValue("@Scnd_Plndate", DBNull.Value);
        }
        command.Parameters["@Scnd_Plndate"].SqlDbType = SqlDbType.DateTime;
        if (!string.IsNullOrEmpty(Thrd_Plndate))
        {
            DateTime time4 = this.dateformat(Thrd_Plndate);
            command.Parameters.AddWithValue("@Thrd_Plndate", time4);
        }
        else
        {
            command.Parameters.AddWithValue("@Thrd_Plndate", DBNull.Value);
        }
        command.Parameters["@Thrd_Plndate"].SqlDbType = SqlDbType.DateTime;
        if (!string.IsNullOrEmpty(Tsk_CompleteDt))
        {
            DateTime time5 = this.dateformat(Tsk_CompleteDt);
            command.Parameters.AddWithValue("@Tsk_CompleteDt", time5);
        }
        else
        {
            command.Parameters.AddWithValue("@Tsk_CompleteDt", DBNull.Value);
        }
        command.Parameters["@Tsk_CompleteDt"].SqlDbType = SqlDbType.DateTime;
        command.Parameters.AddWithValue("@Comments", Comments);
        command.Parameters.AddWithValue("@Style_ID", Style_ID);
        command.Parameters.AddWithValue("@Gap_Days", Gap_Days);
        command.ExecuteNonQuery();
        lbl.Text = "Saved Successfully";
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_Unit(string unitcode, string description, int parameter, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand(string.Concat(new object[] { "select cUnitCode,cUnitDes,nConPara from Smt_Unit where cUnitCode='", unitcode.Trim(), "' and cUnitDes='", description, "' and nConPara='", parameter, "'" }), this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_Unit_Save", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@cUnitCode", unitcode);
            command2.Parameters.AddWithValue("@cUnitDes", description);
            command2.Parameters.AddWithValue("@nConPara", parameter);
            command2.Parameters.AddWithValue("@cEntUser", user);
            if (command2.ExecuteNonQuery() > 0)
            {
                lbl.Text = "Saved Successfully";
            }
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Save_Usergroup(string userdescription, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Usergroup_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@cGrpDescription", userdescription);
        command.Parameters.AddWithValue("@cEntUser", user);
        command.ExecuteNonQuery();
        lbl.Text = "Saved Successfully";
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_UserIn(string Userid, string CompName, string IPAdd, DateTime logindt)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_UserLog_Login", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@UserID", Userid);
        command.Parameters.AddWithValue("@User_PC", CompName);
        command.Parameters.AddWithValue("@PC_IP", IPAdd);
        command.Parameters.AddWithValue("@Login_Date", logindt);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_UserLevel(string Levelname, string Description, string username, Label lbl)
    {
        SqlCommand command = new SqlCommand("select cLevelname,cLevelDescription from Smt_Userlevel where cLevelname='" + Levelname.Trim() + "' and cLevelDescription='" + Description.Trim() + "'", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        SqlDataReader reader = command.ExecuteReader();
        if (reader.Read())
        {
            lbl.Text = "Already Exist";
        }
        else
        {
            reader.Close();
            SqlCommand command2 = new SqlCommand("Sp_Smt_Userlevel_Save", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("cLevelname", Levelname);
            command2.Parameters.AddWithValue("cLevelDescription", Description);
            command2.Parameters.AddWithValue("cEntUser", username);
            if (command2.ExecuteNonQuery() > 0)
            {
                lbl.Text = "Saved Successfully";
            }
        }
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_UserOut(string Userid, DateTime Login_Date)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_UserLog_LogOut", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@UserID", Userid);
        command.Parameters.AddWithValue("@Login_Date", Login_Date);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_virtual(int styleid, int itemcode, string unit, decimal ncom, decimal wstg, decimal uprice, decimal valu, int suplier, int ordqty, string size, string typ, decimal reqqty, decimal stock, decimal netqty, int coltotqty, int nsiz, string mcat, string constructon, string dimn, string placement, int fabcol, int itecol, string lot, string user, string PO)
    {
        SqlCommand command = new SqlCommand("sp_Smt_Virtual_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nstyCode", styleid);
        command.Parameters.AddWithValue("@nItemcode", itemcode);
        command.Parameters.AddWithValue("@cUnit", unit);
        command.Parameters.AddWithValue("@nCom", ncom);
        command.Parameters.AddWithValue("@nWst", wstg);
        command.Parameters.AddWithValue("@nUprice", uprice);
        command.Parameters.AddWithValue("@nValue", valu);
        command.Parameters.AddWithValue("@nSup", suplier);
        command.Parameters.AddWithValue("@nOrdqty", ordqty);
        command.Parameters.AddWithValue("@cSzRange", size);
        command.Parameters.AddWithValue("@ctype", typ);
        command.Parameters.AddWithValue("@nReqqty", reqqty);
        command.Parameters.AddWithValue("@nStock", stock);
        command.Parameters.AddWithValue("@nNetReq", netqty);
        command.Parameters.AddWithValue("@nColtQty", coltotqty);
        command.Parameters.AddWithValue("@nSizeR", nsiz);
        command.Parameters.AddWithValue("@cMCat", mcat);
        command.Parameters.AddWithValue("@construction", constructon);
        command.Parameters.AddWithValue("@cDime", dimn);
        command.Parameters.AddWithValue("@cPlsmnt", placement);
        command.Parameters.AddWithValue("@nFColNo", fabcol);
        command.Parameters.AddWithValue("@nLnCol", itecol);
        command.Parameters.AddWithValue("@clots", lot);
        command.Parameters.AddWithValue("@username", user);
        command.Parameters.AddWithValue("@PO", PO);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void SaveOrdermasterLog(int styleID, string StyleNo, string UserName, string Lot)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_OrdersMaster_Log", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@StyleId", styleID);
        command.Parameters.AddWithValue("@StyleNO", StyleNo);
        command.Parameters.AddWithValue("@UserName", UserName);
        command.Parameters.AddWithValue("@Lot", Lot);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void search_comonegrid(C1.Web.UI.Controls.C1GridView.C1GridView grd, string[] srcvalues)
    {
        string selectfield = "*";
        string[] searchfield = new string[] { "nAcct", "nSeason", "nBran", "nstore", "nDept" };
        DataSet set = this.mybll.mastersearch_exectvalue(selectfield, "Smt_View_Stylemaster", searchfield, srcvalues);
        grd.DataSource = set;
        grd.DataBind();
    }

    public void search_Stylemaster(GridView grd, string[] srcvalues)
    {
        string selectfield = "*";
        string[] searchfield = new string[] { "nAcct", "nSeason", "nBran", "nstore", "nDept" };
        DataSet set = this.mybll.mastersearch_exectvalue(selectfield, "Smt_View_Stylemaster", searchfield, srcvalues);
        grd.DataSource = set;
        grd.DataBind();
    }

    public void SetBtnPermission(string UserID, Control[] btnall, Control[] Addbtn, string formname)
    {
        SqlCommand command = new SqlCommand("select UserName from tst_permitterbtn where UserName='" + UserID.ToUpper() + "'", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        SqlDataReader reader = command.ExecuteReader();
        reader.Read();
        if (reader.HasRows)
        {
            reader.Close();
            for (int i = 0; i < btnall.Length; i++)
            {
                string[] strArray = btnall[i].GetType().ToString().Split(new char[] { '.' });
                int index = strArray.Length - 1;
                string str2 = strArray[index];
                string str3 = btnall[i].ID.ToString();
                SqlDataReader reader2 = new SqlCommand("select ButtonName from tst_permitterbtn where UserName='" + UserID.ToUpper() + "' and FormName='" + formname + "' and ButtonName='" + str3 + "'", this.cn).ExecuteReader();
                reader2.Read();
                if (reader2.HasRows)
                {
                    reader2.Close();
                    if (str2 == "Button")
                    {
                        Button button = (Button)btnall[i];
                        button.Enabled = true;
                        button.CssClass = "button";
                    }
                }
                else
                {
                    reader2.Close();
                    if (str2 == "Button")
                    {
                        Button button2 = (Button)btnall[i];
                        button2.Enabled = false;
                        button2.CssClass = "";
                    }
                }
            }
            if (Addbtn.Length > 0)
            {
                for (int j = 0; j < Addbtn.Length; j++)
                {
                    string[] strArray2 = Addbtn[j].GetType().ToString().Split(new char[] { '.' });
                    int num4 = strArray2.Length - 1;
                    string str5 = strArray2[num4];
                    string str6 = Addbtn[j].ID.ToString();
                    SqlDataReader reader3 = new SqlCommand("select ButtonName from tst_permitterbtn where UserName='" + UserID.ToUpper() + "' and FormName='" + formname + "' and ButtonName='" + str6 + "'", this.cn).ExecuteReader();
                    reader3.Read();
                    if (reader3.HasRows)
                    {
                        reader3.Close();
                        if (str5 == "Button")
                        {
                            Button button3 = (Button)Addbtn[j];
                            button3.Enabled = true;
                            button3.CssClass = "btPOPUP";
                        }
                    }
                    else
                    {
                        reader3.Close();
                        if (str5 == "Button")
                        {
                            Button button4 = (Button)Addbtn[j];
                            button4.Enabled = false;
                            button4.CssClass = "btPOPUPdisabled";
                        }
                    }
                }
            }
        }
        else
        {
            reader.Close();
        }
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void SetBtnPermissionwithhtmlbtn(string UserID, Control[] btnall, Control[] Addbtn, HtmlInputButton[] htmlbtn, string formname)
    {
        SqlCommand command = new SqlCommand("select UserName from tst_permitterbtn where UserName='" + UserID.ToUpper() + "'", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        SqlDataReader reader = command.ExecuteReader();
        reader.Read();
        if (reader.HasRows)
        {
            reader.Close();
            for (int i = 0; i < btnall.Length; i++)
            {
                string[] strArray = btnall[i].GetType().ToString().Split(new char[] { '.' });
                int index = strArray.Length - 1;
                string str2 = strArray[index];
                string str3 = btnall[i].ID.ToString();
                SqlDataReader reader2 = new SqlCommand("select ButtonName from tst_permitterbtn where UserName='" + UserID.ToUpper() + "' and FormName='" + formname + "' and ButtonName='" + str3 + "'", this.cn).ExecuteReader();
                reader2.Read();
                if (reader2.HasRows)
                {
                    reader2.Close();
                    if (str2 == "Button")
                    {
                        Button button = (Button)btnall[i];
                        button.Enabled = true;
                        button.CssClass = "button";
                    }
                }
                else
                {
                    reader2.Close();
                    if (str2 == "Button")
                    {
                        Button button2 = (Button)btnall[i];
                        button2.Enabled = false;
                        button2.CssClass = "";
                    }
                }
            }
            if (Addbtn.Length > 0)
            {
                for (int j = 0; j < Addbtn.Length; j++)
                {
                    string[] strArray2 = Addbtn[j].GetType().ToString().Split(new char[] { '.' });
                    int num4 = strArray2.Length - 1;
                    string str5 = strArray2[num4];
                    string str6 = Addbtn[j].ID.ToString();
                    SqlDataReader reader3 = new SqlCommand("select ButtonName from tst_permitterbtn where UserName='" + UserID.ToUpper() + "' and FormName='" + formname + "' and ButtonName='" + str6 + "'", this.cn).ExecuteReader();
                    reader3.Read();
                    if (reader3.HasRows)
                    {
                        reader3.Close();
                        if (str5 == "Button")
                        {
                            Button button3 = (Button)Addbtn[j];
                            button3.Enabled = true;
                            button3.CssClass = "btPOPUP";
                        }
                    }
                    else
                    {
                        reader3.Close();
                        if (str5 == "Button")
                        {
                            Button button4 = (Button)Addbtn[j];
                            button4.Enabled = false;
                            button4.CssClass = "btPOPUPdisabled";
                        }
                    }
                }
            }
            if (htmlbtn.Length > 0)
            {
                for (int k = 0; k < htmlbtn.Length; k++)
                {
                    string[] strArray3 = htmlbtn[k].GetType().ToString().Split(new char[] { '.' });
                    int num6 = strArray3.Length - 1;
                    string str8 = strArray3[num6];
                    string str9 = htmlbtn[k].ID.ToString();
                    SqlDataReader reader4 = new SqlCommand("select ButtonName from tst_permitterbtn where UserName='" + UserID.ToUpper() + "' and FormName='" + formname + "' and ButtonName='" + str9 + "'", this.cn).ExecuteReader();
                    reader4.Read();
                    if (reader4.HasRows)
                    {
                        reader4.Close();
                        if (str8 == "HtmlInputButton")
                        {
                            HtmlInputButton button5 = htmlbtn[k];
                            button5.Disabled = false;
                            button5.Attributes.Add("class", "btPOPUP");
                        }
                    }
                    else
                    {
                        reader4.Close();
                        if (str8 == "HtmlInputButton")
                        {
                            HtmlInputButton button6 = htmlbtn[k];
                            button6.Disabled = true;
                            button6.Attributes.Add("class", "btPOPUPdisabled");
                        }
                    }
                }
            }
        }
        else
        {
            reader.Close();
        }
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public DataTable special_operation()
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select nID,cCode,cDescription from Smt_SpecialOperation", this.cn);
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

    public void StCplst(string nStydino, int ostid, string sr, int odlv, int clsz, int sqt, Label lbl)
    {
        if (this.mybll.get_InformationdataTable("select cStyleNo from Smt_StyleMaster where cStyleNo='" + nStydino + "'").Rows.Count > 0)
        {
            lbl.Text = "Already exists";
        }
        else
        {
            SqlCommand command = new SqlCommand("Sp_Smt_StyleMaster_Copystl", this.cn);
            if (this.cn.State == ConnectionState.Closed)
            {
                this.cn.Open();
            }
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@cStyleNo", nStydino);
            command.Parameters.AddWithValue("@OstyleID", ostid);
            command.Parameters.AddWithValue("@Entuser", sr);
            command.Parameters.AddWithValue("@isOrd", odlv);
            command.Parameters.AddWithValue("@isastcl", clsz);
            command.Parameters.AddWithValue("@isastqt", sqt);
            command.ExecuteNonQuery();
            lbl.Text = "Copied Successfully";
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Update_ActionDesc(string actiondesc, int Actiontype, string user, string actioncode, Label lbl)
    {
        SqlCommand command = new SqlCommand(string.Concat(new object[] { "select Action_Description from Smt_ActionDescription where Action_Description='", actiondesc.Trim(), "' and Action_Type=", Actiontype }), this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_ActionDescription_Update", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@Action_Description", actiondesc);
            command2.Parameters.AddWithValue("@Action_Type", Actiontype);
            command2.Parameters.AddWithValue("@Create_By", user);
            command2.Parameters.AddWithValue("@Desc_Code", actioncode);
            if (command2.ExecuteNonQuery() > 0)
            {
                lbl.Text = "Updated Successfully";
            }
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Update_Actiontype(string Actiontype, string user, string actioncode, Label lbl)
    {
        SqlCommand command = new SqlCommand("select Action_Type from Smt_ActionType where Action_Type='" + Actiontype.Trim() + "' ", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_ActionType_update", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@Action_Type", Actiontype);
            command2.Parameters.AddWithValue("@Create_By", user);
            command2.Parameters.AddWithValue("@Acttype_Code", actioncode);
            if (command2.ExecuteNonQuery() > 0)
            {
                lbl.Text = "Updated Successfully";
            }
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Update_Assortmentcolor(int styleid, int oldcolorid, int newcolorid, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_ChangeColour", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nstyid", styleid);
        command.Parameters.AddWithValue("@nOColid", oldcolorid);
        command.Parameters.AddWithValue("@nNColid", newcolorid);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        lbl.Text = "Updated Successfully";
    }

    public void Update_BankInfo(int bankCode, string BankName, string Address, string Telephone, string fax, string country, string swiftCode, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand("select Bank_Name from Smt_BankInfo where Bank_Name='" + BankName.Trim() + "' and Bank_Address='" + Address + "' and Telephone_No='" + Telephone + "' and fax='" + fax + "' and Country_Code='" + country + "' and Swift_Code='" + swiftCode + "'", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_BankInfo_Update", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@Bank_Code", bankCode);
            command2.Parameters.AddWithValue("@Bank_Name", BankName);
            command2.Parameters.AddWithValue("@Bank_Address", Address);
            command2.Parameters.AddWithValue("@Telephone_No", Telephone);
            command2.Parameters.AddWithValue("@Fax", fax);
            command2.Parameters.AddWithValue("@Country_Code", country);
            command2.Parameters.AddWithValue("@Swift_Code", swiftCode);
            command2.Parameters.AddWithValue("@Created_By", user);
            command2.ExecuteNonQuery();
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
            lbl.Text = "Updated Successfully";
        }
    }

    public void Update_Brand(int brandid, string brand, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand("select cBrand_Name from Smt_Brand where cBrand_Name='" + brand.Trim() + "'", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_Brand_Update", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("nBrand_ID", brandid);
            command2.Parameters.AddWithValue("cBrand_Name", brand);
            command2.Parameters.AddWithValue("cEntUser", user);
            if (command2.ExecuteNonQuery() > 0)
            {
                lbl.Text = "Updated Successfully";
            }
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Update_BuildingUnit(int unitcode, string Unitname, int Company_ID, string username, Label lbl)
    {
        SqlCommand command = new SqlCommand(string.Concat(new object[] { "select Unit_Name from Smt_BuildingUnit where Unit_Name='", Unitname, "' and Company_ID=", Company_ID }), this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        SqlDataReader reader = command.ExecuteReader();
        reader.Read();
        if (reader.HasRows)
        {
            lbl.Text = "Already Exist";
            reader.Close();
        }
        else
        {
            reader.Close();
            SqlCommand command2 = new SqlCommand("Sp_Smt_BuildingUnit_Update", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@Unit_Code", unitcode);
            command2.Parameters.AddWithValue("@Unit_Name", Unitname);
            command2.Parameters.AddWithValue("@Company_ID", Company_ID);
            command2.Parameters.AddWithValue("@CreatedBy", username);
            command2.ExecuteNonQuery();
            lbl.Text = "Updated Successfully";
        }
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Update_Buyer(int buyerid, string Buyer, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand("select cBuyer_Name from Smt_BuyerName where cBuyer_Name='" + Buyer.Trim() + "'", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_BuyerName_Update", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@nBuyer_ID", buyerid);
            command2.Parameters.AddWithValue("@cBuyer_Name", Buyer);
            command2.Parameters.AddWithValue("@cEntUser", user);
            if (command2.ExecuteNonQuery() > 0)
            {
                lbl.Text = "Updated Successfully";
            }
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Update_Color(int colorid, string Color, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand("select cColour from Smt_Colours where cColour='" + Color.Trim() + "'", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_Color_Update", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@nColNo", colorid);
            command2.Parameters.AddWithValue("@cColour", Color);
            command2.Parameters.AddWithValue("@cEntUser", user);
            if (command2.ExecuteNonQuery() > 0)
            {
                lbl.Text = "Updated Successfully";
            }
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Update_Colorgorup(int cid, string grpname, string packdesc, Label lbl)
    {
        SqlCommand command = new SqlCommand("select cGrp from Smt_ColGrp where cGrp='" + grpname.Trim() + "' and cPAckDis='" + packdesc + "'", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_ColGrp_Update", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("nId", cid);
            command2.Parameters.AddWithValue("cGrp", grpname);
            command2.Parameters.AddWithValue("cPAckDis", packdesc);
            command2.ExecuteNonQuery();
            lbl.Text = "Updated Successfully";
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Update_ColorSensitivity(int nstyCode_1, string cLnType_2, string CFColNo_3, string cLnCol_5, int nItemcd, string cPlsmnt, string nprice, int activity, int nArticle_ID, int nDimension_Id)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_ConAllAuto1", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nstyCode_1", nstyCode_1);
        command.Parameters.AddWithValue("@cLnType_2", cLnType_2);
        command.Parameters.AddWithValue("@CFColNo_3", CFColNo_3);
        command.Parameters.AddWithValue("@cLnCol_5", cLnCol_5);
        command.Parameters.AddWithValue("@nItemcd", nItemcd);
        command.Parameters.AddWithValue("@cPlsmnt", cPlsmnt);
        if (!string.IsNullOrEmpty(nprice))
        {
            command.Parameters.AddWithValue("@nprice", nprice);
        }
        else
        {
            command.Parameters.AddWithValue("@nprice", DBNull.Value);
        }
        command.Parameters["@nprice"].SqlDbType = SqlDbType.Decimal;
        command.Parameters.AddWithValue("@bact", activity);
        command.Parameters.AddWithValue("@nArticle_ID", nArticle_ID);
        command.Parameters.AddWithValue("@nDimension_Id", nDimension_Id);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Update_CompanyInfo(int compid, string companyname, string add1, string add2, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand("SP_Smt_Company_Update", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nCompanyID", compid);
        command.Parameters.AddWithValue("@cCmpName", companyname);
        command.Parameters.AddWithValue("@cAdd1", add1);
        command.Parameters.AddWithValue("@cAdd2", add2);
        command.Parameters.AddWithValue("@cEntUSer", user);
        if (command.ExecuteNonQuery() > 0)
        {
            lbl.Text = "Updated Successfully";
        }
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Update_Country(int cid, string cname, Label lbl)
    {
        SqlCommand command = new SqlCommand("select cConDes from Smt_Counrys where cConDes='" + cname.Trim() + "'", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_Counrys_Update", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@nConCode", cid);
            command2.Parameters.AddWithValue("@cConDes", cname);
            if (command2.ExecuteNonQuery() > 0)
            {
                lbl.Text = "Updated Successfully";
            }
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Update_Currencytype(string code, string type, decimal exrate, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand(string.Concat(new object[] { "select cCurCode,cCurdes,nExgRate from Smt_CurencyType where cCurCode='", code.Trim(), "' and cCurdes='", type, "' and nExgRate='", exrate, "'" }), this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_CurencyType_Update", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@cCurCode", code);
            command2.Parameters.AddWithValue("@cCurdes", type);
            command2.Parameters.AddWithValue("@nExgRate", exrate);
            command2.Parameters.AddWithValue("@cuser", user);
            command2.ExecuteNonQuery();
            lbl.Text = "Updated Successfully";
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Update_Department(int deptid, string department, int companyid, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand(string.Concat(new object[] { "select cDeptname,nCompanyID from Smt_Department where cDeptname='", department.Trim(), "' and nCompanyID='", companyid, "'" }), this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_Department_Update", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@nUserDept", deptid);
            command2.Parameters.AddWithValue("@cDeptname", department);
            command2.Parameters.AddWithValue("@nCompanyID", companyid);
            command2.Parameters.AddWithValue("@cEntUser", user);
            if (command2.ExecuteNonQuery() > 0)
            {
                lbl.Text = "Updated Successfully";
            }
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Update_Dependencygroup(int depgrpcode, string dpGroup, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand("select Dependency_Group from Smt_Dependencygroup where Dependency_Group='" + dpGroup.Trim() + "'", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_Dependencygroup_update", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@Dependency_Group", dpGroup);
            command2.Parameters.AddWithValue("@Create_User", user);
            command2.Parameters.AddWithValue("@SL_No", depgrpcode);
            if (command2.ExecuteNonQuery() > 0)
            {
                lbl.Text = "Updated Successfully";
            }
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Update_Desigantion(int desid, string Desigantion, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand("select cDesignation from Smt_Designation where cDesignation='" + Desigantion.Trim() + "'", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_Designation_Update", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@nDesignation_ID", desid);
            command2.Parameters.AddWithValue("@cDesignation", Desigantion);
            command2.Parameters.AddWithValue("@cEntUser", user);
            if (command2.ExecuteNonQuery() > 0)
            {
                lbl.Text = "Updated Successfully";
            }
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Update_Fabeshade(int shadeid, string shade, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand("select cShade from Smt_Fabshade where cShade='" + shade.Trim() + "'", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_Fabshade_Update", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("nshcode", shadeid);
            command2.Parameters.AddWithValue("cShade", shade);
            command2.ExecuteNonQuery();
            lbl.Text = "Updated Successfully";
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Update_Floor(int florid, string floor, int BuildingUID, int CompanyID, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand(string.Concat(new object[] { "select cFloor_Descriptin from Smt_Floor where cFloor_Descriptin='", floor.Trim(), "' and BuildingUID=", BuildingUID, " and CompanyID=", CompanyID }), this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_Floor_Update", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@nFloor", florid);
            command2.Parameters.AddWithValue("@cFloor_Descriptin", floor);
            command2.Parameters.AddWithValue("@cEntUser", user);
            command2.Parameters.AddWithValue("@BuildingUID", BuildingUID);
            command2.Parameters.AddWithValue("@CompanyID", CompanyID);
            if (command2.ExecuteNonQuery() > 0)
            {
                lbl.Text = "Updated Successfully";
            }
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Update_Garmentdept(int deptid, string Garmentdept, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand("select cGmt_Dept_Description from Smt_Gmt_Department where cGmt_Dept_Description='" + Garmentdept.Trim() + "'", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_Gmt_Department_Update", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@nGmt_Dept_ID", deptid);
            command2.Parameters.AddWithValue("@cGmt_Dept_Description", Garmentdept);
            command2.Parameters.AddWithValue("@cEntUser", user);
            command2.ExecuteNonQuery();
            lbl.Text = "Updated Successfully";
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Update_GarmentType(int nGmtCode, string cGmetDis, string cEntUser, Label lbl)
    {
        SqlCommand command = new SqlCommand("select cGmetDis from Smt_GmtType where cGmetDis='" + cGmetDis.Trim() + "'", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_GmtType_Update", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@nGmtCode", nGmtCode);
            command2.Parameters.AddWithValue("@cGmetDis", cGmetDis);
            command2.Parameters.AddWithValue("@cEntUser", cEntUser);
            command2.ExecuteNonQuery();
            lbl.Text = "Updated Successfully";
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Update_Line(int Line_Code, string Line_No, int CompanyID, int DepartmentID, int SectionID, int BuildingUnitID, int FloorID, string nMachineOp, string nHelper, string CreatedBy, Label lbl)
    {
        SqlCommand command = new SqlCommand(string.Concat(new object[] { "select Line_No from Smt_Line where Line_No='", Line_No, "' and CompanyID=", CompanyID, " and BuildingUnitID=", BuildingUnitID, " and FloorID=", FloorID }), this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        SqlDataReader reader = command.ExecuteReader();
        reader.Read();
        if (reader.HasRows)
        {
            reader.Close();
            lbl.Text = "Already Exists";
        }
        else
        {
            reader.Close();
            SqlCommand command2 = new SqlCommand("Sp_Smt_Line_Update", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@Line_Code", Line_Code);
            command2.Parameters.AddWithValue("@Line_No", Line_No);
            command2.Parameters.AddWithValue("@CompanyID", CompanyID);
            command2.Parameters.AddWithValue("@DepartmentID", DepartmentID);
            command2.Parameters.AddWithValue("@SectionID", SectionID);
            command2.Parameters.AddWithValue("@BuildingUnitID", BuildingUnitID);
            command2.Parameters.AddWithValue("@FloorID", FloorID);
            if (!string.IsNullOrEmpty(nMachineOp))
            {
                command2.Parameters.AddWithValue("@nMachineOp", nMachineOp);
            }
            else
            {
                command2.Parameters.AddWithValue("@nMachineOp", "0");
            }
            if (!string.IsNullOrEmpty(nHelper))
            {
                command2.Parameters.AddWithValue("@nHelper", nHelper);
            }
            else
            {
                command2.Parameters.AddWithValue("@nHelper", "0");
            }
            command2.Parameters.AddWithValue("@CreatedBy", CreatedBy);
            command2.ExecuteNonQuery();
            lbl.Text = "Updated Successfully";
        }
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Update_MainCategory(int mainid, string maincategory, int mastercategoryid, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand(string.Concat(new object[] { "select cMainCategory,nMasterCategory_ID from Smt_MainCategory where cMainCategory='", maincategory.Trim(), "' and nMasterCategory_ID='", mastercategoryid, "'" }), this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_MainCategory_Update", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@nMainCategory_ID", mainid);
            command2.Parameters.AddWithValue("@cMainCategory", maincategory);
            command2.Parameters.AddWithValue("@nMasterCategory_ID", mastercategoryid);
            command2.Parameters.AddWithValue("@cEntUser", user);
            if (command2.ExecuteNonQuery() > 0)
            {
                lbl.Text = "Updated Successfully";
            }
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Update_MasterCategory(int masterid, string MasterCategory, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand("select cMasterCategory from Smt_MasterCategory where cMasterCategory='" + MasterCategory.Trim() + "'", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_MasterCategory_Update", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@nMasterCategory_ID", masterid);
            command2.Parameters.AddWithValue("@cMasterCategory", MasterCategory);
            command2.Parameters.AddWithValue("@cEntUser", user);
            command2.ExecuteNonQuery();
            lbl.Text = "Updated Successfully";
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Update_Newuser(int userid, string username, string Userfullname, string password, string userlevel, string department, string sectionid, string email, string companyid, string usergroup, string permissionstatus, string activitystatu, Label lbl)
    {
        SqlCommand command = null;
        if (permissionstatus == "G")
        {
            command = new SqlCommand("select cUserName from Smt_Users where cUserName='" + username.Trim() + "' and cUserFullname='" + Userfullname.Trim() + "' and cPassWord='" + password.Trim() + "' and nULevelID='" + userlevel + "' and nUserDept='" + department + "' and nSectionID='" + sectionid + "' and Email='" + email + "' and nCompanyID='" + companyid + "' and nUgroup='" + usergroup + "' and Activity_status='" + activitystatu + "'", this.cn);
        }
        else
        {
            command = new SqlCommand("select cUserName from Smt_Users where cUserName='" + username.Trim() + "' and cUserFullname='" + Userfullname.Trim() + "' and cPassWord='" + password.Trim() + "' and nULevelID='" + userlevel + "' and nUserDept='" + department + "' and nSectionID='" + sectionid + "' and Email='" + email + "' and nCompanyID='" + companyid + "' and Activity_status='" + activitystatu + "'", this.cn);
        }
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_Users_Update", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@nUserID", userid);
            command2.Parameters.AddWithValue("@cUserName", username);
            command2.Parameters.AddWithValue("@cUserFullname", Userfullname);
            command2.Parameters.AddWithValue("@cPassWord", password);
            if (!string.IsNullOrEmpty(userlevel))
            {
                command2.Parameters.AddWithValue("@nULevelID", userlevel);
            }
            else
            {
                command2.Parameters.AddWithValue("@nULevelID", DBNull.Value);
            }
            command2.Parameters["@nULevelID"].SqlDbType = SqlDbType.Int;
            if (!string.IsNullOrEmpty(department))
            {
                command2.Parameters.AddWithValue("@nUserDept", department);
            }
            else
            {
                command2.Parameters.AddWithValue("@nUserDept", DBNull.Value);
            }
            command2.Parameters["@nUserDept"].SqlDbType = SqlDbType.Int;
            if (!string.IsNullOrEmpty(sectionid))
            {
                command2.Parameters.AddWithValue("@nSectionID", sectionid);
            }
            else
            {
                command2.Parameters.AddWithValue("@nSectionID", DBNull.Value);
            }
            command2.Parameters["@nSectionID"].SqlDbType = SqlDbType.Int;
            command2.Parameters.AddWithValue("@Email", email);
            if (!string.IsNullOrEmpty(companyid))
            {
                command2.Parameters.AddWithValue("@nCompanyID", companyid);
            }
            else
            {
                command2.Parameters.AddWithValue("@nCompanyID", DBNull.Value);
            }
            command2.Parameters["@nCompanyID"].SqlDbType = SqlDbType.Int;
            if (!string.IsNullOrEmpty(usergroup))
            {
                command2.Parameters.AddWithValue("@nUgroup", usergroup);
            }
            else
            {
                command2.Parameters.AddWithValue("@nUgroup", "99");
            }
            command2.Parameters["@nUgroup"].SqlDbType = SqlDbType.Int;
            command2.Parameters.AddWithValue("@Permission_status", permissionstatus);
            command2.Parameters.AddWithValue("@Activity_status", activitystatu);
            command2.ExecuteNonQuery();
            lbl.Text = "Saved Successfully";
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Update_OrderDetail(int styleid, string lot, string color, string shade, string[] Qty, string user, int total, int sqty, int sr, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_OrderDtlQty", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nStyleID_1", styleid);
        command.Parameters.AddWithValue("@Clot_2", lot);
        command.Parameters.AddWithValue("@Col", color);
        command.Parameters.AddWithValue("@shd", shade);
        for (int i = 1; i <= 60; i++)
        {
            string parameterName = "@nq" + i;
            string str2 = Qty[i - 1];
            command.Parameters.AddWithValue(parameterName, str2);
        }
        command.Parameters.AddWithValue("@cEntuser_17", user);
        command.Parameters.AddWithValue("@ntot", total);
        command.Parameters.AddWithValue("@sqty", sqty);
        command.Parameters.AddWithValue("@sR", sr);
        command.ExecuteNonQuery();
        lbl.Text = "Saved Successfully";
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Update_ordermasterBgBOM(int styleid)
    {
        SqlCommand command = new SqlCommand("Update Smt_OrdersMaster set bGbom='1' where nOStyleId='" + styleid + "'", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.Text;
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Update_PackcountryBgBOM(int styleid)
    {
        SqlCommand command = new SqlCommand("Update Smt_PackContry set bgetBom='1' where nstyCd='" + styleid + "'", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.Text;
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Update_Productionplan(int Pln_Slno, int CompanyID, int BuildingUnit_ID, int FloorID, int LineID, int BuyerID, string PONo, string febRefno, string Marchandisir, string EMB, string BPCD, string Sewing, string POQty, string DevQty, string CreatedBy, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Productionplane_Update", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@Pln_Slno", Pln_Slno);
        command.Parameters.AddWithValue("@CompanyID", CompanyID);
        command.Parameters.AddWithValue("@BuildingUnit_ID", BuildingUnit_ID);
        command.Parameters.AddWithValue("@FloorID", FloorID);
        command.Parameters.AddWithValue("@LineID", LineID);
        command.Parameters.AddWithValue("@BuyerID", BuyerID);
        command.Parameters.AddWithValue("@PONo", PONo);
        command.Parameters.AddWithValue("@febRefno", febRefno);
        command.Parameters.AddWithValue("@Marchandisir", Marchandisir);
        command.Parameters.AddWithValue("@EMB", EMB);
        if (!string.IsNullOrEmpty(BPCD))
        {
            DateTime time = this.dateformat(BPCD);
            command.Parameters.AddWithValue("@BPCD", time);
        }
        else
        {
            command.Parameters.AddWithValue("@BPCD", DBNull.Value);
        }
        command.Parameters["@BPCD"].SqlDbType = SqlDbType.DateTime;
        command.Parameters.AddWithValue("@Sewing", Sewing);
        command.Parameters.AddWithValue("@POQty", POQty);
        if (!string.IsNullOrEmpty(DevQty))
        {
            command.Parameters.AddWithValue("@DevQty", DevQty);
        }
        else
        {
            command.Parameters.AddWithValue("@DevQty", "0.00");
        }
        command.Parameters.AddWithValue("@CreatedBy", CreatedBy);
        command.ExecuteNonQuery();
        lbl.Text = "Updated Successfully";
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Update_Season(int seasonid, string season, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand("select cSeason_Name from Smt_Season where cSeason_Name='" + season.Trim() + "'", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_Season_Update", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@nSeason_ID", seasonid);
            command2.Parameters.AddWithValue("@cSeason_Name", season);
            command2.Parameters.AddWithValue("@cEntUser", user);
            if (command2.ExecuteNonQuery() > 0)
            {
                lbl.Text = "Updated Successfully";
            }
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Update_Section(int setid, string section, int department, int carder, int companyid, string supervisor, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand(string.Concat(new object[] { "select cSection_Description from Smt_Section where cSection_Description='", section.Trim(), "' and nCompanyID=", companyid, " and nUserDept=", department, " and nCarder=", carder, " and cSupervisor='", supervisor, "'" }), this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_Section_Update", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@nSectionID", setid);
            command2.Parameters.AddWithValue("@cSection_Description", section);
            command2.Parameters.AddWithValue("@nUserDept", department);
            command2.Parameters.AddWithValue("@nCarder", carder);
            command2.Parameters.AddWithValue("@nCompanyID", companyid);
            command2.Parameters.AddWithValue("@cSupervisor", supervisor);
            command2.Parameters.AddWithValue("@cEntUser", user);
            if (command2.ExecuteNonQuery() > 0)
            {
                lbl.Text = "Updated Successfully";
            }
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Update_SizeSensitivity(int nStyID_1, string cMcat_2, string cSize_3, string cDime_4, string cItemNAme, string cPlsmnt, string nPrice, int status)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_SizeSensitive1", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nStyID_1", nStyID_1);
        command.Parameters.AddWithValue("@cMcat_2", cMcat_2);
        command.Parameters.AddWithValue("@cSize_3", cSize_3);
        command.Parameters.AddWithValue("@cDime_4", cDime_4);
        command.Parameters.AddWithValue("@cItemNAme", cItemNAme);
        command.Parameters.AddWithValue("@cPlsmnt", cPlsmnt);
        if (!string.IsNullOrEmpty(nPrice))
        {
            command.Parameters.AddWithValue("@nPrice", nPrice);
        }
        else
        {
            command.Parameters.AddWithValue("@nPrice", DBNull.Value);
        }
        command.Parameters["@nPrice"].SqlDbType = SqlDbType.Decimal;
        command.Parameters.AddWithValue("@bAct", status);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Update_Store(int storeid, string storename, int country, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand(string.Concat(new object[] { "select cStore_Name,nCountry_ID from Smt_Store where cStore_Name='", storename.Trim(), "' and nCountry_ID='", country, "'" }), this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_Store_Update", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@nStore_ID", storeid);
            command2.Parameters.AddWithValue("@cStore_Name", storename);
            command2.Parameters.AddWithValue("@nCountry_ID", country);
            command2.Parameters.AddWithValue("@cEntUser", user);
            if (command2.ExecuteNonQuery() > 0)
            {
                lbl.Text = "Updated Successfully";
            }
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Update_Stylefile(int Styleid, string filename)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_StylemasterFile_Sketch", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@StyleID", Styleid);
        command.Parameters.AddWithValue("@Fileno", filename);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Update_StyleType(int tpid, string StyleType, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand("select cStyleType from Smt_StyleType where cStyleType='" + StyleType.Trim() + "'", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_StyleType_Update", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@nStyleTypeID", tpid);
            command2.Parameters.AddWithValue("@cStyleType", StyleType);
            command2.Parameters.AddWithValue("@cEntUser", user);
            command2.ExecuteNonQuery();
            lbl.Text = "Updated Successfully";
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Update_Suppliers(string supcode, string name, string add1, string add2, string contno, string valtno, string type, string user, string catt, string email, string code, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Suppliers_Update", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@cSupCode_1", supcode);
        command.Parameters.AddWithValue("@cSupName_2", name);
        command.Parameters.AddWithValue("@cSupAdd1_3", add1);
        command.Parameters.AddWithValue("@cSupAdd2_4", add2);
        command.Parameters.AddWithValue("@cSupContNo_5", contno);
        command.Parameters.AddWithValue("@cSupValtNo_6", valtno);
        command.Parameters.AddWithValue("@cSupType_7", type);
        command.Parameters.AddWithValue("@cEntUser_9", user);
        command.Parameters.AddWithValue("@catt", catt);
        command.Parameters.AddWithValue("@cEmail", email);
        command.Parameters.AddWithValue("@csCode", code);
        command.ExecuteNonQuery();
        lbl.Text = "Updated Successfully";
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Update_Unit(int unitid, string unitcode, string description, int parameter, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand(string.Concat(new object[] { "select cUnitCode,cUnitDes,nConPara from Smt_Unit where cUnitCode='", unitcode.Trim(), "' and cUnitDes='", description, "' and nConPara='", parameter, "'" }), this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_Unit_Update", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@nUnitID", unitid);
            command2.Parameters.AddWithValue("@cUnitCode", unitcode);
            command2.Parameters.AddWithValue("@cUnitDes", description);
            command2.Parameters.AddWithValue("@nConPara", parameter);
            command2.Parameters.AddWithValue("@cEntUser", user);
            if (command2.ExecuteNonQuery() > 0)
            {
                lbl.Text = "Updated Successfully";
            }
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Update_userbyhimself(string userid, string password, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Users_Update1", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@cUserName", userid);
        command.Parameters.AddWithValue("@cPassWord", password);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        lbl.Text = "Updated Successfully";
    }

    public void Update_Usergroup(int gropuid, string userdescription, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Usergroup_Update", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nUgroup", gropuid);
        command.Parameters.AddWithValue("@cGrpDescription", userdescription);
        command.Parameters.AddWithValue("@cEntUser", user);
        command.ExecuteNonQuery();
        lbl.Text = "Updated Successfully";
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Update_UserLevel(int lblid, string Levelname, string Description, string username, Label lbl)
    {
        SqlCommand command = new SqlCommand("select cLevelname,cLevelDescription from Smt_Userlevel where cLevelname='" + Levelname.Trim() + "' and cLevelDescription='" + Description.Trim() + "'", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        SqlDataReader reader = command.ExecuteReader();
        if (reader.Read())
        {
            lbl.Text = "Already Exist";
        }
        else
        {
            reader.Close();
            SqlCommand command2 = new SqlCommand("Sp_Smt_Userlevel_Update", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@nULevelID", lblid);
            command2.Parameters.AddWithValue("@cLevelname", Levelname);
            command2.Parameters.AddWithValue("@cLevelDescription", Description);
            command2.Parameters.AddWithValue("@cEntUser", username);
            if (command2.ExecuteNonQuery() > 0)
            {
                lbl.Text = "Updated Successfully";
            }
        }
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void updtlgo(string lgo)
    {
        SqlCommand command = new SqlCommand("update Smt_Company set lgo='" + lgo + "' where Display_AS_Header=1", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.Text;
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void uploadsign(string signtr, string userid)
    {
        SqlCommand command = new SqlCommand("update Smt_Users set signtr='" + signtr + "' where cUserName='" + userid + "'", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.Text;
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public static void WhNow()
    {
        IDictionaryEnumerator enumerator = _xCrush.GetEnumerator();
        while (enumerator.MoveNext())
        {
            HttpContext.Current.Response.Write(enumerator.Value + "<br>");
        }
    }
}
