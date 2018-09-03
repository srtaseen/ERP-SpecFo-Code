
using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Web.UI.WebControls;

public class DALInventory
{
    private BLL _bl = new BLL();
    private BLLInventory blinventory = new BLLInventory();
    private SqlConnection cn = GetWay.SpecFo_Inventorycon;
    private SqlConnection cnsp = GetWay.SpecFoCon;

    public void BOM_UpdateForPORevised(int SubCatID, int nstyCode, int MainCatCode, string cPLmnt, string clots, int nSup, string MainCategory, int nPoNum, int ArticleID, int DimensionID)
    {
        SqlCommand command = new SqlCommand("Sp_SmtBOM_UpdatePORevised", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@SubCatID", SubCatID);
        command.Parameters.AddWithValue("@nstyCode", nstyCode);
        command.Parameters.AddWithValue("@MainCatCode", MainCatCode);
        command.Parameters.AddWithValue("@cPLmnt", cPLmnt);
        command.Parameters.AddWithValue("@clots", clots);
        command.Parameters.AddWithValue("@nSup", nSup);
        command.Parameters.AddWithValue("@cMCat", MainCategory);
        command.Parameters.AddWithValue("@nPoNum", nPoNum);
        command.Parameters.AddWithValue("@ArticleID", ArticleID);
        command.Parameters.AddWithValue("@DimensionID", DimensionID);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Copy_EstimateBOM(int OrgStyle, int Newstyle, string Createuser, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_BOM_Estimate_Copy", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@OrgStyle", OrgStyle);
        command.Parameters.AddWithValue("@Newstyle", Newstyle);
        command.Parameters.AddWithValue("@Createuser", Createuser);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        lbl.Text = "Saved Successfully";
    }

    public void CopyBom(int OldStyleID, int Newstlid, Label lbl)
    {
        SqlCommand command = new SqlCommand("select MainCatCode from Smt_BOM where nstyCode=" + Newstlid + " and cver=1", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_BOMCopy", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@OldStyleID", OldStyleID);
            command2.Parameters.AddWithValue("@newStyleID", Newstlid);
            command2.ExecuteNonQuery();
            lbl.Text = "Saved Successfully";
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
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

    public void Del_Sizesen(int nstyCode, int MainCatCode, string cPlsmnt, int SubCatID, int ArticleID, int DimensionID)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_SizeSen_Delete1", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nstyCode", nstyCode);
        command.Parameters.AddWithValue("@MainCatCode", MainCatCode);
        command.Parameters.AddWithValue("@cPlsmnt", cPlsmnt);
        command.Parameters.AddWithValue("@SubCatID", SubCatID);
        command.Parameters.AddWithValue("@ArticleID", ArticleID);
        command.Parameters.AddWithValue("@DimensionID", DimensionID);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Delete_BOM(int styleid, int MainCatCode, string cPlsmnt, int SubCatID, int DimensionID, int ConstructionID, int nSup)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_BOM_Delete", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nstyCode", styleid);
        command.Parameters.AddWithValue("@MainCatCode", MainCatCode);
        command.Parameters.AddWithValue("@cPlsmnt", cPlsmnt);
        command.Parameters.AddWithValue("@SubCatID", SubCatID);
        command.Parameters.AddWithValue("@DimensionID", DimensionID);
        command.Parameters.AddWithValue("@ConstructionID", ConstructionID);
        command.Parameters.AddWithValue("@nSup", nSup);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Delete_BOM1(int styleid)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_BOM_Delete1", this.cn);
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

    public void Delete_BOMbeforeSave(int styleid)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_BOM_DeleteBeforeSave", this.cn);
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

    public void Delete_BomEstimate(int styleid)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_BOM_Estimate_Delete", this.cn);
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

    public void Delete_BomMaincatnull(int styleid)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_BOM_DeleteMCatnull", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@styleid", styleid);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Delete_EstimateCosting_MCat(int Styleid)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_EstimateCosting_MCat_Delete", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nStyleID", Styleid);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Delete_EstimateCosting_Quick(string StyleNo)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_EstimateCosting_Quick_Delete", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@StyleNo", StyleNo);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Delete_FactoryPurchase(int nRequest_No)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_FactoryPurchase_Delete", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nRequest_No", nRequest_No);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Delete_FactoryPurchaseNew(int nRequest_No)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_FactoryPurchase_DeleteReqNew", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nRequest_No", nRequest_No);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Delete_LocalpurchaseItem(int slno, int RequestNo)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_FactoryPurchase_DeleteItem", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@slno", slno);
        command.Parameters.AddWithValue("@RequestNo", RequestNo);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Delete_LocalpurchaseItemPOedit(int slno)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_FactoryPurchase_DeleteItemPOEdit", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@slno", slno);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Delete_MechanicalPurchase(int nRequest_No)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_MechanicalPurchase_DeleteRequest", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@requestno", nRequest_No);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Delete_SizeSensitivity(int styleid)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_DeleteSizeSensitivity", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nStyID", styleid);
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

    public void drp_ConstructionArticlebymaincategory(DropDownList maincategory, DropDownList drpconst)
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select nArtCode,cArticle from View_Smt_Article where cMainCategory='" + maincategory.SelectedItem.Text + "' order by cArticle", this.cn);
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
        SqlDataAdapter adapter = new SqlDataAdapter("select nArtCode,cArticle from Smt_Artcle where cMcat='" + maincategory.SelectedItem.Text + "'", this.cn);
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

    public void drp_Currencytype(DropDownList drp)
    {
        this.blinventory.dropdown(drp, "Smt_CurencyType", "cCurdes", 0, 0);
    }

    public void drp_Dimensionbymaincategory(DropDownList maincategory, DropDownList dimension)
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select ndCode,cDimen from Smt_Dimension where nMainCatID='" + maincategory.SelectedValue + "' order by cDimen", this.cn);
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
        SqlDataAdapter adapter = new SqlDataAdapter("select ndCode,cDimen from Smt_Dimension where nMainCatID='" + maincategory.SelectedValue + "'", this.cn);
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

    public void drp_DimensionbymaincategoryID(int maincategory, DropDownList dimension)
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select ndCode,cDimen from Smt_Dimension where nMainCatID=" + maincategory, this.cn);
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

    public void drp_itemdescriptionbymaincat(DropDownList maincategory, DropDownList drpitem)
    {
        SqlDataAdapter adapter = new SqlDataAdapter("Sp_Smt_SubCatagory_GetByMainCat '" + maincategory.SelectedValue + "'", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet);
        drpitem.DataSource = dataSet;
        drpitem.DataTextField = "cItemDes";
        drpitem.DataValueField = "nItemcode";
        drpitem.DataBind();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void drp_itemdescriptionbymaincatBOM(DropDownList maincategory, DropDownList drpitem)
    {
        SqlDataAdapter adapter = new SqlDataAdapter("Sp_Smt_SubCatagory_GetByMainCat '" + maincategory.SelectedValue + "'", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet);
        drpitem.DataSource = dataSet;
        drpitem.DataTextField = "cItemDes";
        drpitem.DataValueField = "nItemcode";
        drpitem.DataBind();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void drp_itemdescriptionbymaincategory(DropDownList maincategory, DropDownList drpitem)
    {
        SqlDataAdapter adapter = new SqlDataAdapter("Sp_Smt_GetItemDescByMainCat '" + maincategory.SelectedValue + "'", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet);
        drpitem.DataSource = dataSet;
        drpitem.DataTextField = "cItemDes";
        drpitem.DataValueField = "ItemCode";
        drpitem.DataBind();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void drp_itemdescriptionbymaincategory1(DropDownList maincategory, DropDownList drpitem)
    {
        SqlDataAdapter adapter = new SqlDataAdapter("Sp_Smt_GetItemDescByMainCat '" + maincategory.SelectedValue + "'", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet);
        drpitem.DataSource = dataSet;
        drpitem.DataTextField = "cItemDes";
        drpitem.DataValueField = "ItemCode";
        drpitem.DataBind();
        drpitem.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        drpitem.SelectedIndex = 0;
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void drp_itemdescriptionbymaincategoryP2(DropDownList maincategory, DropDownList drpitem, int styleid)
    {
        SqlDataAdapter adapter = new SqlDataAdapter(string.Concat(new object[] { "Sp_Smt_GetItemDescByMainCat1 '", maincategory.SelectedValue, "','", styleid, "'" }), this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet);
        drpitem.DataSource = dataSet;
        drpitem.DataTextField = "cItemDes";
        drpitem.DataValueField = "nItemcode";
        drpitem.DataBind();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void drp_Maincategory(DropDownList drp)
    {
        this.blinventory.dropdown(drp, "Smt_MainCategory", "cMainCategory", 1, 0);
    }

    public void drp_sizesentabdim(DropDownList maincategory, int mcat)
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select distinct cDimen,ndCode from Smt_Dimension where nMainCatID='" + mcat + "' order by cDimen", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet);
        maincategory.DataSource = dataSet;
        maincategory.DataTextField = "cDimen";
        maincategory.DataValueField = "ndCode";
        maincategory.DataBind();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void drp_sizesentabSize(DropDownList maincategory, int styleid, string mcat)
    {
        SqlDataAdapter adapter = new SqlDataAdapter(string.Concat(new object[] { "select distinct cSize from Smt_SizeSensitive where nStyID='", styleid, "' and cMcat='", mcat, "' order by cSize" }), this.cn);
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
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
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
        drpSupplier.Items.Insert(0, new ListItem("-", "37"));
        drpSupplier.SelectedIndex = 0;
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
        drpSupplier.Items.Insert(0, new ListItem("-", "37"));
        drpSupplier.SelectedIndex = 0;
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void drp_Suppliertype(DropDownList drp)
    {
        this.blinventory.dropdown(drp, "Smt_SuppliersType", "cDescription", 2, 1);
    }

    public void drp_Unit(DropDownList drp)
    {
        this.blinventory.dropdown(drp, "Smt_Unit", "cUnitDes", 2, 0);
    }

    public void EbinRpt(int itemcode)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_ItemMaster_EBINCard1", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@ItemCode", itemcode);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void ExecReport(int styleid)
    {
        SqlCommand command = new SqlCommand("Sp_Inv_ReportStyleStatus1", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@StyleID", styleid);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void FactoryPurchase_POApprove(string ApprovedBy, int PONO, string remark, Label lbl)
    {
        SqlCommand command = new SqlCommand("FactoryPurchase_POApprove", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@PO_Approved_By", ApprovedBy);
        command.Parameters.AddWithValue("@PO_No", PONO);
        command.Parameters.AddWithValue("@Remrk", remark);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        lbl.Text = "PO Approved";
    }

    public void FactoryPurchase_POCancel(string CancelBy, int PONO, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_FactoryPurchase_POCancel", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@PO_Canceled_By", CancelBy);
        command.Parameters.AddWithValue("@PO_No", PONO);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        lbl.Text = "PO Cancelled Successfully";
    }

    public void Factorypurchase_PORevise(int reqno, int pono, string user)
    {
        SqlCommand command = new SqlCommand("FactoryPurchase_PORevise", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@ReqNo", reqno);
        command.Parameters.AddWithValue("@PO_No", pono);
        command.Parameters.AddWithValue("@RevisedBy", user);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Factorypurchase_Updaterevisedpo(int SupplierID, string ReqQty, string Uprice, string Value, int Slno, string PO_No, string user)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_FactoryPurchase_Revpoupdate", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@SupplierID", SupplierID);
        command.Parameters.AddWithValue("@ReqQty", ReqQty);
        command.Parameters.AddWithValue("@Uprice", Uprice);
        command.Parameters.AddWithValue("@Value", Value);
        command.Parameters.AddWithValue("@Slno", Slno);
        command.Parameters.AddWithValue("@PO_No", PO_No);
        command.Parameters.AddWithValue("@Created_User", user);
        command.ExecuteNonQuery();
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

    public void ItmManqtychange(int Itmcode, string qty, int nCompanyID, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_ItemMaster_Updateqtymanually", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nItemCode", Itmcode);
        if (!string.IsNullOrEmpty(qty))
        {
            command.Parameters.AddWithValue("@nItemBalQty", qty);
        }
        else
        {
            command.Parameters.AddWithValue("@nItemBalQty", "0");
        }
        command.Parameters.AddWithValue("@nCompanyID", nCompanyID);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        lbl.Text = "Saved Successfully";
    }

    public void PO_Cancel(int PoNo, string username)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_POPrintCancel", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@PO", PoNo);
        command.Parameters.AddWithValue("@UserName", username);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void PO_ConfirmToApprove(int PONo)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_POHedder_ConfirmToApprove", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nPoNum", PONo);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void PO_ForApprove(int PONo, string user)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_POHedder_POApproval", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nPoNum", PONo);
        command.Parameters.AddWithValue("@cAppBy", user);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void PO_ForApprove_Revise(int PONo, string USER)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_POHedderRev_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nPoNum", PONo);
        command.Parameters.AddWithValue("@RevUser", USER);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void PO_ForApprove_RevisePO(int PONo, string USER)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_RevisePo", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nPoNum", PONo);
        command.Parameters.AddWithValue("@cdelUser", USER);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void PORaised_CancelBOM(int StyleID, int MainCat, int Supplier, string Lot, int ArticleID, int DimensionID, string Placement, int SubCatid, int pono, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_SmtBOM_UpdatePOCancel", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@SubCatID", SubCatid);
        command.Parameters.AddWithValue("@nstyCode", StyleID);
        command.Parameters.AddWithValue("@MainCatCode", MainCat);
        command.Parameters.AddWithValue("@cPLmnt", Lot);
        command.Parameters.AddWithValue("@nSup", Supplier);
        command.Parameters.AddWithValue("@nPoNum", pono);
        command.Parameters.AddWithValue("@ArticleID", ArticleID);
        command.Parameters.AddWithValue("@DimensionID", DimensionID);
        command.ExecuteNonQuery();
        lbl.Text = "PO Cancelled Successfully";
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_Article(string article, int Maincatid, string maincat, Label lbl)
    {
        SqlCommand command = new SqlCommand(string.Concat(new object[] { "select cArticle from Smt_Artcle where cArticle='", article.Trim(), "' and nMainCatID='", Maincatid, "'" }), this.cn);
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
            command2.Parameters.AddWithValue("@nMainCatID", Maincatid);
            command2.Parameters.AddWithValue("@cMCat", maincat);
            command2.ExecuteNonQuery();
            lbl.Text = "Saved Successfully";
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Save_BOM(int nstyCode_1, int cver_2, string nItemcode_3, string cUnit_4, string nCom_5, string nWst_6, string nUprice_7, string nValue_8, string nSup_9, string nOrdqty_10, string cUser_11, string cCurtype, string cSzRange, string ctype, string nReqqty, string nStock, string nNetReq, string nColtQty, string csize, string cFabCol, string cMcat, int bszSen, int bColSen, int bPack, int bRecnf, string cpack, string nDyeGrp, string cPos, string cPlsmnt, string Gmtprt, int badj, string clots, int ncnf, int npook, string cremk, string Artical, string Dimen, string AJSRequirement, string UnitConParam, int PO_Raise, string POSensitivity, Label lbl)
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
            command.Parameters.AddWithValue("@nCom_5", "0.00");
        }
        if (!string.IsNullOrEmpty(nWst_6))
        {
            command.Parameters.AddWithValue("@nWst_6", nWst_6);
        }
        else
        {
            command.Parameters.AddWithValue("@nWst_6", "0.00");
        }
        if (!string.IsNullOrEmpty(nUprice_7))
        {
            command.Parameters.AddWithValue("@nUprice_7", nUprice_7);
        }
        else
        {
            command.Parameters.AddWithValue("@nUprice_7", "0.00");
        }
        if (!string.IsNullOrEmpty(nValue_8))
        {
            command.Parameters.AddWithValue("@nValue_8", nValue_8);
        }
        else
        {
            command.Parameters.AddWithValue("@nValue_8", "0.00");
        }
        if (!string.IsNullOrEmpty(nSup_9))
        {
            command.Parameters.AddWithValue("@nSup_9", nSup_9);
        }
        else
        {
            command.Parameters.AddWithValue("@nSup_9", DBNull.Value);
        }
        command.Parameters["@nSup_9"].SqlDbType = SqlDbType.Int;
        if (!string.IsNullOrEmpty(nOrdqty_10))
        {
            command.Parameters.AddWithValue("@nOrdqty_10", nOrdqty_10);
        }
        else
        {
            command.Parameters.AddWithValue("@nOrdqty_10", "0.00");
        }
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
            command.Parameters.AddWithValue("@nReqqty", "0.00");
        }
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
            command.Parameters.AddWithValue("@nNetReq", "0.00");
        }
        if (!string.IsNullOrEmpty(nColtQty))
        {
            command.Parameters.AddWithValue("@nColtQty", nColtQty);
        }
        else
        {
            command.Parameters.AddWithValue("@nColtQty", "0.00");
        }
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
            command.Parameters.AddWithValue("@nDyeGrp", "0");
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
        command.Parameters.AddWithValue("@Artical", Artical);
        command.Parameters.AddWithValue("@Dimen", Dimen);
        if (!string.IsNullOrEmpty(AJSRequirement))
        {
            command.Parameters.AddWithValue("@AJSRequirement", AJSRequirement);
        }
        else
        {
            command.Parameters.AddWithValue("@AJSRequirement", "0.00");
        }
        if (!string.IsNullOrEmpty(UnitConParam))
        {
            command.Parameters.AddWithValue("@UnitConParam", UnitConParam);
        }
        else
        {
            command.Parameters.AddWithValue("@UnitConParam", DBNull.Value);
        }
        command.Parameters["@UnitConParam"].SqlDbType = SqlDbType.Decimal;
        command.Parameters.AddWithValue("@PO_Raise", PO_Raise);
        command.Parameters.AddWithValue("@POSensitivity", POSensitivity);
        command.ExecuteNonQuery();
        lbl.Text = "Saved Successfully";
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_BOMEstimate(int nstyCode_1, int nItemcode_3, string cUnit_4, string nCom_5, string nWst_6, string nUprice_7, string nValue_8, string nOrdqty_10, string cUser_11, string cCurtype, string ctype, string nReqqty, string placement, int maincatid, int articleid, int dimensionid, string unitparam, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_BOM_Estimate_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nstyCode", nstyCode_1);
        command.Parameters.AddWithValue("@nItemcode", nItemcode_3);
        command.Parameters.AddWithValue("@cUnit", cUnit_4);
        if (!string.IsNullOrEmpty(nCom_5))
        {
            command.Parameters.AddWithValue("@nCom", nCom_5);
        }
        else
        {
            command.Parameters.AddWithValue("@nCom", "0.00");
        }
        command.Parameters["@nCom"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(nWst_6))
        {
            command.Parameters.AddWithValue("@nWst", nWst_6);
        }
        else
        {
            command.Parameters.AddWithValue("@nWst", "0.00");
        }
        command.Parameters["@nWst"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(nUprice_7))
        {
            command.Parameters.AddWithValue("@nUprice", nUprice_7);
        }
        else
        {
            command.Parameters.AddWithValue("@nUprice", "0.00");
        }
        command.Parameters["@nUprice"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(nValue_8))
        {
            command.Parameters.AddWithValue("@nValue", nValue_8);
        }
        else
        {
            command.Parameters.AddWithValue("@nValue", "0.00");
        }
        command.Parameters["@nValue"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(nOrdqty_10))
        {
            command.Parameters.AddWithValue("@nOrdqty", nOrdqty_10);
        }
        else
        {
            command.Parameters.AddWithValue("@nOrdqty", "0.00");
        }
        command.Parameters["@nOrdqty"].SqlDbType = SqlDbType.Decimal;
        command.Parameters.AddWithValue("@cUser", cUser_11);
        command.Parameters.AddWithValue("@cCurtype", cCurtype);
        command.Parameters.AddWithValue("@ctype", ctype);
        if (!string.IsNullOrEmpty(nReqqty))
        {
            command.Parameters.AddWithValue("@nReqqty", nReqqty);
        }
        else
        {
            command.Parameters.AddWithValue("@nReqqty", "0.00");
        }
        command.Parameters["@nReqqty"].SqlDbType = SqlDbType.Decimal;
        command.Parameters.AddWithValue("@cPlsmnt", placement);
        command.Parameters.AddWithValue("@MainCatCode", maincatid);
        command.Parameters.AddWithValue("@ConstructionID", articleid);
        command.Parameters.AddWithValue("@DimensionID", dimensionid);
        if (!string.IsNullOrEmpty(unitparam))
        {
            command.Parameters.AddWithValue("@UnitConParam", unitparam);
        }
        else
        {
            command.Parameters.AddWithValue("@UnitConParam", DBNull.Value);
        }
        command.Parameters["@UnitConParam"].SqlDbType = SqlDbType.Int;
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

    public void Save_Dimension(string Dimension, string MainCat, int Maincatid, Label lbl)
    {
        SqlCommand command = new SqlCommand(string.Concat(new object[] { "select cDimen from Smt_Dimension where cDimen='", Dimension.Trim(), "' and nMainCatID=", Maincatid }), this.cn);
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
            command2.Parameters.AddWithValue("@cMCat", MainCat);
            command2.Parameters.AddWithValue("@nMainCatID", Maincatid);
            command2.ExecuteNonQuery();
            lbl.Text = "Saved Successfully";
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Save_EstimateCosting(int nStyleId, string Row_Material, string Embroidary, string Printing, string Washing, string Other, string Rate, string Print_Type, string Wash_Type, string Stitch, string Subttl_Percent, string Subttl_Pc, string Subttl_Dz, string Subttl_Ttl, string Fob_Percent, string Fob_Pc, string Fob_Dz, string Fob_Ttl, string Manuf_Percent, string Manuf_Pc, string Manuf_Dz, string Manuf_Ttl, string Overhead_Percent, string Overhead_Pc, string Overhead_Dz, string Overhead_Ttl, string Comission_Percent, string Comission_Pc, string Comission_Dz, string Comission_Ttl, string ProfitMargin_Percent, string ProfitMargin_Pc, string ProfitMargin_Dz, string ProfitMargin_Ttl, string Created_By, string TotalCost_Percent, string TotalCost_Pc, string TotalCost_Dz, string TotalCost_Ttl, string RowMaterialDz, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_EstimateCosting_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nStyleId", nStyleId);
        if (!string.IsNullOrEmpty(Row_Material))
        {
            command.Parameters.AddWithValue("@Row_Material", Row_Material);
        }
        else
        {
            command.Parameters.AddWithValue("@Row_Material", "0.00");
        }
        command.Parameters["@Row_Material"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(Embroidary))
        {
            command.Parameters.AddWithValue("@Embroidary", Embroidary);
        }
        else
        {
            command.Parameters.AddWithValue("@Embroidary", "0.00");
        }
        command.Parameters["@Embroidary"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(Printing))
        {
            command.Parameters.AddWithValue("@Printing", Printing);
        }
        else
        {
            command.Parameters.AddWithValue("@Printing", "0.00");
        }
        command.Parameters["@Printing"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(Washing))
        {
            command.Parameters.AddWithValue("@Washing", Washing);
        }
        else
        {
            command.Parameters.AddWithValue("@Washing", "0.00");
        }
        command.Parameters["@Washing"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(Other))
        {
            command.Parameters.AddWithValue("@Other", Other);
        }
        else
        {
            command.Parameters.AddWithValue("@Other", "0.00");
        }
        command.Parameters["@Other"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(Rate))
        {
            command.Parameters.AddWithValue("@Rate", Rate);
        }
        else
        {
            command.Parameters.AddWithValue("@Rate", "0.00");
        }
        command.Parameters["@Rate"].SqlDbType = SqlDbType.Decimal;
        command.Parameters.AddWithValue("@Print_Type", Print_Type);
        command.Parameters.AddWithValue("@Wash_Type", Wash_Type);
        command.Parameters.AddWithValue("@Stitch", Stitch);
        if (!string.IsNullOrEmpty(Subttl_Percent))
        {
            command.Parameters.AddWithValue("@Subttl_Percent", Subttl_Percent);
        }
        else
        {
            command.Parameters.AddWithValue("@Subttl_Percent", "0.00");
        }
        command.Parameters["@Subttl_Percent"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(Subttl_Pc))
        {
            command.Parameters.AddWithValue("@Subttl_Pc", Subttl_Pc);
        }
        else
        {
            command.Parameters.AddWithValue("@Subttl_Pc", "0.00");
        }
        command.Parameters["@Subttl_Pc"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(Subttl_Dz))
        {
            command.Parameters.AddWithValue("@Subttl_Dz", Subttl_Dz);
        }
        else
        {
            command.Parameters.AddWithValue("@Subttl_Dz", "0.00");
        }
        command.Parameters["@Subttl_Dz"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(Subttl_Ttl))
        {
            command.Parameters.AddWithValue("@Subttl_Ttl", Subttl_Ttl);
        }
        else
        {
            command.Parameters.AddWithValue("@Subttl_Ttl", "0.00");
        }
        command.Parameters["@Subttl_Ttl"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(Fob_Percent))
        {
            command.Parameters.AddWithValue("@Fob_Percent", Fob_Percent);
        }
        else
        {
            command.Parameters.AddWithValue("@Fob_Percent", "0.00");
        }
        command.Parameters["@Fob_Percent"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(Fob_Pc))
        {
            command.Parameters.AddWithValue("@Fob_Pc", Fob_Pc);
        }
        else
        {
            command.Parameters.AddWithValue("@Fob_Pc", "0.00");
        }
        command.Parameters["@Fob_Pc"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(Fob_Dz))
        {
            command.Parameters.AddWithValue("@Fob_Dz", Fob_Dz);
        }
        else
        {
            command.Parameters.AddWithValue("@Fob_Dz", "0.00");
        }
        command.Parameters["@Fob_Dz"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(Fob_Ttl))
        {
            command.Parameters.AddWithValue("@Fob_Ttl", Fob_Ttl);
        }
        else
        {
            command.Parameters.AddWithValue("@Fob_Ttl", "0.00");
        }
        command.Parameters["@Fob_Ttl"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(Manuf_Percent))
        {
            command.Parameters.AddWithValue("@Manuf_Percent", Manuf_Percent);
        }
        else
        {
            command.Parameters.AddWithValue("@Manuf_Percent", "0.00");
        }
        command.Parameters["@Manuf_Percent"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(Manuf_Pc))
        {
            command.Parameters.AddWithValue("@Manuf_Pc", Manuf_Pc);
        }
        else
        {
            command.Parameters.AddWithValue("@Manuf_Pc", "0.00");
        }
        command.Parameters["@Manuf_Pc"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(Manuf_Dz))
        {
            command.Parameters.AddWithValue("@Manuf_Dz", Manuf_Dz);
        }
        else
        {
            command.Parameters.AddWithValue("@Manuf_Dz", "0.00");
        }
        command.Parameters["@Manuf_Dz"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(Manuf_Ttl))
        {
            command.Parameters.AddWithValue("@Manuf_Ttl", Manuf_Ttl);
        }
        else
        {
            command.Parameters.AddWithValue("@Manuf_Ttl", "0.00");
        }
        command.Parameters["@Manuf_Ttl"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(Overhead_Percent))
        {
            command.Parameters.AddWithValue("@Overhead_Percent", Overhead_Percent);
        }
        else
        {
            command.Parameters.AddWithValue("@Overhead_Percent", "0.00");
        }
        command.Parameters["@Overhead_Percent"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(Overhead_Pc))
        {
            command.Parameters.AddWithValue("@Overhead_Pc", Overhead_Pc);
        }
        else
        {
            command.Parameters.AddWithValue("@Overhead_Pc", "0.00");
        }
        command.Parameters["@Overhead_Pc"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(Overhead_Dz))
        {
            command.Parameters.AddWithValue("@Overhead_Dz", Overhead_Dz);
        }
        else
        {
            command.Parameters.AddWithValue("@Overhead_Dz", "0.00");
        }
        command.Parameters["@Overhead_Dz"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(Overhead_Ttl))
        {
            command.Parameters.AddWithValue("@Overhead_Ttl", Overhead_Ttl);
        }
        else
        {
            command.Parameters.AddWithValue("@Overhead_Ttl", "0.00");
        }
        command.Parameters["@Overhead_Ttl"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(Comission_Percent))
        {
            command.Parameters.AddWithValue("@Comission_Percent", Comission_Percent);
        }
        else
        {
            command.Parameters.AddWithValue("@Comission_Percent", "0.00");
        }
        command.Parameters["@Comission_Percent"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(Comission_Pc))
        {
            command.Parameters.AddWithValue("@Comission_Pc", Comission_Pc);
        }
        else
        {
            command.Parameters.AddWithValue("@Comission_Pc", "0.00");
        }
        command.Parameters["@Comission_Pc"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(Comission_Dz))
        {
            command.Parameters.AddWithValue("@Comission_Dz", Comission_Dz);
        }
        else
        {
            command.Parameters.AddWithValue("@Comission_Dz", "0.00");
        }
        command.Parameters["@Comission_Dz"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(Comission_Ttl))
        {
            command.Parameters.AddWithValue("@Comission_Ttl", Comission_Ttl);
        }
        else
        {
            command.Parameters.AddWithValue("@Comission_Ttl", "0.00");
        }
        command.Parameters["@Comission_Ttl"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(ProfitMargin_Percent))
        {
            command.Parameters.AddWithValue("@ProfitMargin_Percent", ProfitMargin_Percent);
        }
        else
        {
            command.Parameters.AddWithValue("@ProfitMargin_Percent", "0.00");
        }
        command.Parameters["@ProfitMargin_Percent"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(ProfitMargin_Pc))
        {
            command.Parameters.AddWithValue("@ProfitMargin_Pc", ProfitMargin_Pc);
        }
        else
        {
            command.Parameters.AddWithValue("@ProfitMargin_Pc", "0.00");
        }
        command.Parameters["@ProfitMargin_Pc"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(ProfitMargin_Dz))
        {
            command.Parameters.AddWithValue("@ProfitMargin_Dz", ProfitMargin_Dz);
        }
        else
        {
            command.Parameters.AddWithValue("@ProfitMargin_Dz", "0.00");
        }
        command.Parameters["@ProfitMargin_Dz"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(ProfitMargin_Ttl))
        {
            command.Parameters.AddWithValue("@ProfitMargin_Ttl", ProfitMargin_Ttl);
        }
        else
        {
            command.Parameters.AddWithValue("@ProfitMargin_Ttl", "0.00");
        }
        command.Parameters["@ProfitMargin_Ttl"].SqlDbType = SqlDbType.Decimal;
        command.Parameters.AddWithValue("@Created_By", Created_By);
        if (!string.IsNullOrEmpty(TotalCost_Percent))
        {
            command.Parameters.AddWithValue("@TotalCost_Percent", TotalCost_Percent);
        }
        else
        {
            command.Parameters.AddWithValue("@TotalCost_Percent", "0.00");
        }
        command.Parameters["@TotalCost_Percent"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(TotalCost_Pc))
        {
            command.Parameters.AddWithValue("@TotalCost_Pc", TotalCost_Pc);
        }
        else
        {
            command.Parameters.AddWithValue("@TotalCost_Pc", "0.00");
        }
        command.Parameters["@TotalCost_Pc"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(TotalCost_Dz))
        {
            command.Parameters.AddWithValue("@TotalCost_Dz", TotalCost_Dz);
        }
        else
        {
            command.Parameters.AddWithValue("@TotalCost_Dz", "0.00");
        }
        command.Parameters["@TotalCost_Dz"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(TotalCost_Ttl))
        {
            command.Parameters.AddWithValue("@TotalCost_Ttl", TotalCost_Ttl);
        }
        else
        {
            command.Parameters.AddWithValue("@TotalCost_Ttl", "0.00");
        }
        command.Parameters["@TotalCost_Ttl"].SqlDbType = SqlDbType.Decimal;
        if (!string.IsNullOrEmpty(RowMaterialDz))
        {
            command.Parameters.AddWithValue("@RowMaterialDz", RowMaterialDz);
        }
        else
        {
            command.Parameters.AddWithValue("@RowMaterialDz", "0.00");
        }
        command.Parameters["@RowMaterialDz"].SqlDbType = SqlDbType.Decimal;
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        lbl.Text = "Saved Successfully";
    }

    public void Save_EstimateCosting_Quick(string StyleNo, int nItemcode, int cUnit, string nCom, string nWst, string nUprice, string nValue, int nOrdqty, string cUser, string ctype, string nReqqty, string cPlsmnt, int MainCatCode, int ConstructionID, int DimensionID, int UnitConParam, string PcPerHr, string CstperHr, string Manfcst, string TotalCst, int BuyerID, string Profit, string Other, string Commercialcost, string Buyercost, string Freightcost, string TotalFob, string Fobpc, string FobDz, string Commercialcstprcnt, string Buyercmsnprcnt)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_EstimateCosting_Quick_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@StyleNo", StyleNo);
        command.Parameters.AddWithValue("@nItemcode", nItemcode);
        command.Parameters.AddWithValue("@cUnit", cUnit);
        if (!string.IsNullOrEmpty(nCom))
        {
            command.Parameters.AddWithValue("@nCom", nCom);
        }
        else
        {
            command.Parameters.AddWithValue("@nCom", "0");
        }
        if (!string.IsNullOrEmpty(nWst))
        {
            command.Parameters.AddWithValue("@nWst", nWst);
        }
        else
        {
            command.Parameters.AddWithValue("@nWst", "0");
        }
        if (!string.IsNullOrEmpty(nUprice))
        {
            command.Parameters.AddWithValue("@nUprice", nUprice);
        }
        else
        {
            command.Parameters.AddWithValue("@nUprice", "0");
        }
        if (!string.IsNullOrEmpty(nValue))
        {
            command.Parameters.AddWithValue("@nValue", nValue);
        }
        else
        {
            command.Parameters.AddWithValue("@nValue", "0");
        }
        command.Parameters.AddWithValue("@nOrdqty", nOrdqty);
        command.Parameters.AddWithValue("@cUser", cUser);
        command.Parameters.AddWithValue("@ctype", ctype);
        command.Parameters.AddWithValue("@nReqqty", nReqqty);
        command.Parameters.AddWithValue("@cPlsmnt", cPlsmnt);
        command.Parameters.AddWithValue("@MainCatCode", MainCatCode);
        command.Parameters.AddWithValue("@ConstructionID", ConstructionID);
        command.Parameters.AddWithValue("@DimensionID", DimensionID);
        command.Parameters.AddWithValue("@UnitConParam", UnitConParam);
        if (!string.IsNullOrEmpty(PcPerHr))
        {
            command.Parameters.AddWithValue("@PcPerHr", PcPerHr);
        }
        else
        {
            command.Parameters.AddWithValue("@PcPerHr", "0");
        }
        if (!string.IsNullOrEmpty(CstperHr))
        {
            command.Parameters.AddWithValue("@CstperHr", CstperHr);
        }
        else
        {
            command.Parameters.AddWithValue("@CstperHr", "0");
        }
        if (!string.IsNullOrEmpty(Manfcst))
        {
            command.Parameters.AddWithValue("@Manfcst", Manfcst);
        }
        else
        {
            command.Parameters.AddWithValue("@Manfcst", "0");
        }
        if (!string.IsNullOrEmpty(TotalCst))
        {
            command.Parameters.AddWithValue("@TotalCst", TotalCst);
        }
        else
        {
            command.Parameters.AddWithValue("@TotalCst", "0");
        }
        command.Parameters.AddWithValue("@BuyerID", BuyerID);
        if (!string.IsNullOrEmpty(Profit))
        {
            command.Parameters.AddWithValue("@Profit", Profit);
        }
        else
        {
            command.Parameters.AddWithValue("@Profit", "0");
        }
        if (!string.IsNullOrEmpty(Other))
        {
            command.Parameters.AddWithValue("@Other", Other);
        }
        else
        {
            command.Parameters.AddWithValue("@Other", "0");
        }
        if (!string.IsNullOrEmpty(Commercialcost))
        {
            command.Parameters.AddWithValue("@Commercialcost", Commercialcost);
        }
        else
        {
            command.Parameters.AddWithValue("@Commercialcost", "0");
        }
        if (!string.IsNullOrEmpty(Buyercost))
        {
            command.Parameters.AddWithValue("@Buyercost", Buyercost);
        }
        else
        {
            command.Parameters.AddWithValue("@Buyercost", "0");
        }
        if (!string.IsNullOrEmpty(Freightcost))
        {
            command.Parameters.AddWithValue("@Freightcost", Freightcost);
        }
        else
        {
            command.Parameters.AddWithValue("@Freightcost", "0");
        }
        if (!string.IsNullOrEmpty(TotalFob))
        {
            command.Parameters.AddWithValue("@TotalFob", TotalFob);
        }
        else
        {
            command.Parameters.AddWithValue("@TotalFob", "0");
        }
        if (!string.IsNullOrEmpty(Fobpc))
        {
            command.Parameters.AddWithValue("@Fobpc", Fobpc);
        }
        else
        {
            command.Parameters.AddWithValue("@Fobpc", "0");
        }
        if (!string.IsNullOrEmpty(FobDz))
        {
            command.Parameters.AddWithValue("@FobDz", FobDz);
        }
        else
        {
            command.Parameters.AddWithValue("@FobDz", "0");
        }
        if (!string.IsNullOrEmpty(Commercialcstprcnt))
        {
            command.Parameters.AddWithValue("@Commercialcstprcnt", Commercialcstprcnt);
        }
        else
        {
            command.Parameters.AddWithValue("@Commercialcstprcnt", "0");
        }
        if (!string.IsNullOrEmpty(Buyercmsnprcnt))
        {
            command.Parameters.AddWithValue("@Buyercmsnprcnt", Buyercmsnprcnt);
        }
        else
        {
            command.Parameters.AddWithValue("@Buyercmsnprcnt", "0");
        }
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_EstimatecostingItm(int MastcatID, string nValue, int StyleID)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_EstimateCosting_MCat_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nMasterCategory_ID", MastcatID);
        command.Parameters.AddWithValue("@dValue", nValue);
        command.Parameters.AddWithValue("@nStyleID", StyleID);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_FactoryPurchase(int nDepartment_ID, int nSection_ID, int nStyleID, string cCurType, int nRequest_No, int nMainCat_ID, int nSubCat_ID, int nColor_ID, int nArticle_ID, int nDimension_ID, int nUnit_ID, string dReqQty, string dUnitPrice, string dValue, string dStock, string Created_User, string SizeID, string ItemDescription, int LnNO, int nCompanyID, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_FactoryPurchase_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nDepartment_ID", nDepartment_ID);
        command.Parameters.AddWithValue("@nSection_ID", nSection_ID);
        command.Parameters.AddWithValue("@nStyleID", nStyleID);
        command.Parameters.AddWithValue("@cCurType", cCurType);
        command.Parameters.AddWithValue("@nRequest_No", nRequest_No);
        command.Parameters.AddWithValue("@nMainCat_ID", nMainCat_ID);
        command.Parameters.AddWithValue("@nSubCat_ID", nSubCat_ID);
        command.Parameters.AddWithValue("@nColor_ID", nColor_ID);
        command.Parameters.AddWithValue("@nArticle_ID", nArticle_ID);
        command.Parameters.AddWithValue("@nDimension_ID", nDimension_ID);
        command.Parameters.AddWithValue("@nUnit_ID", nUnit_ID);
        if (!string.IsNullOrEmpty(dReqQty))
        {
            command.Parameters.AddWithValue("@dReqQty", dReqQty);
        }
        else
        {
            command.Parameters.AddWithValue("@dReqQty", "0");
        }
        if (!string.IsNullOrEmpty(dUnitPrice))
        {
            command.Parameters.AddWithValue("@dUnitPrice", dUnitPrice);
        }
        else
        {
            command.Parameters.AddWithValue("@dUnitPrice", "0");
        }
        if (!string.IsNullOrEmpty(dValue))
        {
            command.Parameters.AddWithValue("@dValue", dValue);
        }
        else
        {
            command.Parameters.AddWithValue("@dValue", "0");
        }
        if (!string.IsNullOrEmpty(dStock))
        {
            command.Parameters.AddWithValue("@dStock", dStock);
        }
        else
        {
            command.Parameters.AddWithValue("@dStock", "0");
        }
        command.Parameters.AddWithValue("@Created_User", Created_User);
        command.Parameters.AddWithValue("@SizeID", SizeID);
        command.Parameters.AddWithValue("@ItemDescription", ItemDescription);
        command.Parameters.AddWithValue("@LnNO", LnNO);
        command.Parameters.AddWithValue("@nCompanyID", nCompanyID);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        lbl.Text = "Saved Successfully";
    }

    public void Save_GmtSize(string cSize)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Sizes_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@cSize_1", cSize);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_GoodsIssuing(int nIssNo, string cIssType, int nlnNo, int cSecCode, int nSubCode, int cItemcode, string cUnit, string UnitParam, string nIssQty, string cuser, string nstyCode, string nPrice, string Value, int Department, string IssueNoteNO, int nCompanyID, string nEmployeeID, string Remarks)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_GoodsIssue_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nIssNo", nIssNo);
        command.Parameters.AddWithValue("@cIssType", cIssType);
        command.Parameters.AddWithValue("@nlnNo", nlnNo);
        command.Parameters.AddWithValue("@cSecCode", cSecCode);
        command.Parameters.AddWithValue("@nSubCode", nSubCode);
        command.Parameters.AddWithValue("@nItemcode", cItemcode);
        command.Parameters.AddWithValue("@cUnit", cUnit);
        command.Parameters.AddWithValue("@UnitParam", UnitParam);
        command.Parameters.AddWithValue("@nIssQty", nIssQty);
        command.Parameters.AddWithValue("@cuser", cuser);
        if (!string.IsNullOrEmpty(nstyCode))
        {
            command.Parameters.AddWithValue("@nstyCode", nstyCode);
        }
        else
        {
            command.Parameters.AddWithValue("@nstyCode", DBNull.Value);
        }
        command.Parameters["@nstyCode"].SqlDbType = SqlDbType.Int;
        command.Parameters.AddWithValue("@nPrice", nPrice);
        command.Parameters.AddWithValue("@Value", Value);
        command.Parameters.AddWithValue("@Department_Code", Department);
        command.Parameters.AddWithValue("@IssueNoteNO", IssueNoteNO);
        command.Parameters.AddWithValue("@nCompanyID", nCompanyID);
        if (!string.IsNullOrEmpty(nEmployeeID))
        {
            command.Parameters.AddWithValue("@nEmployeeID", nEmployeeID);
        }
        else
        {
            command.Parameters.AddWithValue("@nEmployeeID", DBNull.Value);
        }
        command.Parameters["@nEmployeeID"].SqlDbType = SqlDbType.Int;
        command.Parameters.AddWithValue("@Remarks", Remarks);
        command.ExecuteNonQuery();
    }

    public void Save_GRN(int nGrnNo_1, int nPoNum_2, int nlineNo_3, int cItemCode_4, string cItemDec_5, string cSize_6, string cColour_7, string cArt_8, string cDimec_9, string cUnit_10, string nQty_11, string nFoc, string nPrice_12, string nValue_13, string cuser_38, string cInVoice, string nstycode, string cCur, string Recvtype, string NSuplierID, int BrandId, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_GoodReceived_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nGrnNo_1", nGrnNo_1);
        command.Parameters.AddWithValue("@nPoNum_2", nPoNum_2);
        command.Parameters.AddWithValue("@nlineNo_3", nlineNo_3);
        command.Parameters.AddWithValue("@cItemCode_4", cItemCode_4);
        command.Parameters.AddWithValue("@cItemDec_5", cItemDec_5);
        command.Parameters.AddWithValue("@cSize_6", cSize_6);
        command.Parameters.AddWithValue("@cColour_7", cColour_7);
        command.Parameters.AddWithValue("@cArt_8", cArt_8);
        command.Parameters.AddWithValue("@cDimec_9", cDimec_9);
        command.Parameters.AddWithValue("@cUnit_10", cUnit_10);
        if (!string.IsNullOrEmpty(nQty_11))
        {
            command.Parameters.AddWithValue("@nQty_11", nQty_11);
        }
        else
        {
            command.Parameters.AddWithValue("@nQty_11", "0");
        }
        if (!string.IsNullOrEmpty(nFoc))
        {
            command.Parameters.AddWithValue("@nFoc", nFoc);
        }
        else
        {
            command.Parameters.AddWithValue("@nFoc", "0");
        }
        if (!string.IsNullOrEmpty(nPrice_12))
        {
            command.Parameters.AddWithValue("@nPrice_12", nPrice_12);
        }
        else
        {
            command.Parameters.AddWithValue("@nPrice_12", "0");
        }
        if (!string.IsNullOrEmpty(nValue_13))
        {
            command.Parameters.AddWithValue("@nValue_13", nValue_13);
        }
        else
        {
            command.Parameters.AddWithValue("@nValue_13", "0");
        }
        command.Parameters.AddWithValue("@cuser_38", cuser_38);
        command.Parameters.AddWithValue("@cInVoice", cInVoice);
        command.Parameters.AddWithValue("@nstycode", nstycode);
        command.Parameters.AddWithValue("@cCur", cCur);
        command.Parameters.AddWithValue("@Recvtype", Recvtype);
        if (!string.IsNullOrEmpty(NSuplierID))
        {
            command.Parameters.AddWithValue("@NSuplierID", NSuplierID);
        }
        else
        {
            command.Parameters.AddWithValue("@NSuplierID", DBNull.Value);
        }
        command.Parameters["@NSuplierID"].SqlDbType = SqlDbType.Int;
        command.Parameters.AddWithValue("@BrandId", BrandId);
        command.ExecuteNonQuery();
        lbl.Text = "Saved Successfully";
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_GRNApproval(int GRnno, string cAppBy)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_GoodReceived_GRNApprove", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nGrnNo", GRnno);
        command.Parameters.AddWithValue("@cAppBy", cAppBy);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_GRNCancel(int GRnno, string CancelledBy, string Pono, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_GoodReceived_Cancel", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@CancelledBy", CancelledBy);
        command.Parameters.AddWithValue("@nGrnNo", GRnno);
        command.Parameters.AddWithValue("@Pono", Pono);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        lbl.Text = "Cancelled Successfully";
    }

    public void Save_GRNGRD(int nPONO, int nStyleID, int nItemCode, int nLineNo, string cUnit, string dGRD_GrnQty, string cUserID, string cRcvType, string ChallanNO, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_GoodReceivedGrd_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nPONO", nPONO);
        command.Parameters.AddWithValue("@nStyleID", nStyleID);
        command.Parameters.AddWithValue("@nItemCode", nItemCode);
        command.Parameters.AddWithValue("@nLineNo", nLineNo);
        command.Parameters.AddWithValue("@cUnit", cUnit);
        command.Parameters.AddWithValue("@dGRD_GrnQty", dGRD_GrnQty);
        command.Parameters.AddWithValue("@cUserID", cUserID);
        command.Parameters.AddWithValue("@cRcvType", cRcvType);
        command.Parameters.AddWithValue("@ChallanNO", ChallanNO);
        command.ExecuteNonQuery();
        lbl.Text = "Saved Successfully";
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_GRNHeader(int GRN_No, string GRN_Type, int nPoNum, int nStyleNo, string Challan_No, string Supplier_ID, int Buyer_ID, string Create_User)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_GoodReceived_Header_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@GRN_No", GRN_No);
        command.Parameters.AddWithValue("@GRN_Type", GRN_Type);
        command.Parameters.AddWithValue("@nPoNum", nPoNum);
        command.Parameters.AddWithValue("@nStyleNo", nStyleNo);
        command.Parameters.AddWithValue("@Challan_No", Challan_No);
        if (!string.IsNullOrEmpty(Supplier_ID))
        {
            command.Parameters.AddWithValue("@Supplier_ID", Supplier_ID);
        }
        else
        {
            command.Parameters.AddWithValue("@Supplier_ID", "-");
        }
        command.Parameters.AddWithValue("@Buyer_ID", Buyer_ID);
        command.Parameters.AddWithValue("@Create_User", Create_User);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_GRNRevise(int GRnno, string RevisedBy)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_GoodReceived_GRNRevise", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nGrnNo", GRnno);
        command.Parameters.AddWithValue("@RevisedBy", RevisedBy);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_GRNReviseupdatepo(int pono, int grnno)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_GoodReceived_UpdFPQtyGRNRevise", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@PONO", pono);
        command.Parameters.AddWithValue("@GRNNO", grnno);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_itemLocation(int ItemCode, int StorageID, int StorageBloack, int StorageRack, int StorageCell, string EntryBy, Label lbl)
    {
        if (int.Parse(this.blinventory.get_InformationdataTable(string.Concat(new object[] { "select count(ItemCode) as Cnt from Smt_ItemMaster_Location where StorageID=", StorageID, " and StorageBloack=", StorageBloack, " and StorageRack=", StorageRack, " and StorageCell=", StorageCell })).Rows[0]["Cnt"].ToString()) >= 3)
        {
            lbl.Text = "Already 3 Items Stored In this Location";
        }
        else
        {
            SqlCommand command = new SqlCommand("Sp_Smt_ItemMaster_Location_Save", this.cn);
            if (this.cn.State == ConnectionState.Closed)
            {
                this.cn.Open();
            }
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ItemCode", ItemCode);
            command.Parameters.AddWithValue("@StorageID", StorageID);
            command.Parameters.AddWithValue("@StorageBloack", StorageBloack);
            command.Parameters.AddWithValue("@StorageRack", StorageRack);
            command.Parameters.AddWithValue("@StorageCell", StorageCell);
            command.Parameters.AddWithValue("@EntryBy", EntryBy);
            command.ExecuteNonQuery();
            lbl.Text = "Saved Successfully";
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Save_ItemMasterafterautogenerate(int Subcatid, string nfabcolid, string csize, string nartcl, string ndimnsonid, string itmdesc, string userid, int Unitid)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_ItmMasterAfterautogenerate_Save1", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@Subcatid", Subcatid);
        command.Parameters.AddWithValue("@fabcol", nfabcolid);
        command.Parameters.AddWithValue("@csize", csize);
        command.Parameters.AddWithValue("@article", nartcl);
        command.Parameters.AddWithValue("@dinm", ndimnsonid);
        command.Parameters.AddWithValue("@itmdesc", itmdesc);
        command.Parameters.AddWithValue("@userid", userid);
        command.Parameters.AddWithValue("@Unitid", Unitid);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_ItemMasterFactoryPurchase(int SubCatID, int nColour_2, int nsize_3, int nArt_4, int nDimec_5, string cItemDes_6, int cItemUnit_7, string nConverPara_8, string cEnUser_9)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_ItemMaster_SaveForFactoryPurchase", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@SubCatID", SubCatID);
        command.Parameters.AddWithValue("@nColour_2", nColour_2);
        command.Parameters.AddWithValue("@nsize_3", nsize_3);
        command.Parameters.AddWithValue("@nArt_4", nArt_4);
        command.Parameters.AddWithValue("@nDimec_5", nDimec_5);
        command.Parameters.AddWithValue("@cItemDes_6", cItemDes_6);
        command.Parameters.AddWithValue("@cItemUnit_7", cItemUnit_7);
        command.Parameters.AddWithValue("@nConverPara_8", nConverPara_8);
        command.Parameters.AddWithValue("@cEnUser_9", cEnUser_9);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_ItemMasterforOtherBooking(int SubcatID, int ColorID, int Size, int Article, int Dimension, string ItemDesc, int UnitID, string UserName)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Itemmaster_SaveForOtherBooking", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nItemcode_3", SubcatID);
        command.Parameters.AddWithValue("@nFabCol", ColorID);
        command.Parameters.AddWithValue("@SizID", Size);
        command.Parameters.AddWithValue("@Artical", Article);
        command.Parameters.AddWithValue("@Dimen", Dimension);
        command.Parameters.AddWithValue("@ItemDesc", ItemDesc);
        command.Parameters.AddWithValue("@cUnit_4", UnitID);
        command.Parameters.AddWithValue("@cUser_11", UserName);
        command.ExecuteNonQuery();
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

    public void Save_MechanicalPurchase(string M_Make, string ModelNo, string cCurType, int nRequest_No, int nMainCat_ID, int nSubCat_ID, int nArticle_ID, int nDimension_ID, int nUnit_ID, string dReqQty, string dUnitPrice, string dValue, string dStock, string Created_User, string ItemDescription, int LnNO, int nCompanyID, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_MechanicalPurchase_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@M_Make", M_Make);
        command.Parameters.AddWithValue("@ModelNo", ModelNo);
        command.Parameters.AddWithValue("@cCurType", cCurType);
        command.Parameters.AddWithValue("@nRequest_No", nRequest_No);
        command.Parameters.AddWithValue("@nMainCat_ID", nMainCat_ID);
        command.Parameters.AddWithValue("@nSubCat_ID", nSubCat_ID);
        command.Parameters.AddWithValue("@nArticle_ID", nArticle_ID);
        command.Parameters.AddWithValue("@nDimension_ID", nDimension_ID);
        command.Parameters.AddWithValue("@nUnit_ID", nUnit_ID);
        if (!string.IsNullOrEmpty(dReqQty))
        {
            command.Parameters.AddWithValue("@dReqQty", dReqQty);
        }
        else
        {
            command.Parameters.AddWithValue("@dReqQty", "0");
        }
        if (!string.IsNullOrEmpty(dUnitPrice))
        {
            command.Parameters.AddWithValue("@dUnitPrice", dUnitPrice);
        }
        else
        {
            command.Parameters.AddWithValue("@dUnitPrice", "0");
        }
        if (!string.IsNullOrEmpty(dValue))
        {
            command.Parameters.AddWithValue("@dValue", dValue);
        }
        else
        {
            command.Parameters.AddWithValue("@dValue", "0");
        }
        if (!string.IsNullOrEmpty(dStock))
        {
            command.Parameters.AddWithValue("@dStock", dStock);
        }
        else
        {
            command.Parameters.AddWithValue("@dStock", "0");
        }
        command.Parameters.AddWithValue("@Created_User", Created_User);
        command.Parameters.AddWithValue("@ItemDescription", ItemDescription);
        command.Parameters.AddWithValue("@LnNO", LnNO);
        command.Parameters.AddWithValue("@nCompanyID", nCompanyID);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        lbl.Text = "Saved Successfully";
    }

    public void Save_Newitem(string Desc, string maincode, string user, string Unit, Label lbl)
    {
        SqlCommand command = new SqlCommand("select cDes from Smt_SubCatagory where cDes='" + Desc.Trim() + "'", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_SubCatagory_Save", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@cDes_2", Desc);
            command2.Parameters.AddWithValue("@cManCode_3", maincode);
            command2.Parameters.AddWithValue("@CEntUser_5", user);
            command2.Parameters.AddWithValue("@cUnit", Unit);
            command2.ExecuteNonQuery();
            lbl.Text = "Saved Successfully";
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Save_PODetail(int nPoNum_1, int nLnNo_2, int cItemCode_3, string cItemdes_4, string cSize_5, string cColour_6, string cArt_7, string cDimec_8, string cUnit_9, string nQty_10, string nPrice_11, string nVal_12, string cStatus_37, string cUser_38, int nStyCode, string dDelDate, string cPack, string nDyeGrp, string cPo, string cPLmnt, string cSupCode, string nSupPo, string cGmtPrt, string cDyPrc, int SubcatID, int ArticleID, int DimensionID, int MCatID, int SupplierID, string clots, string nCom, string nOrdqty)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_PODetails_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nPoNum_1", nPoNum_1);
        command.Parameters.AddWithValue("@nLnNo_2", nLnNo_2);
        command.Parameters.AddWithValue("@cItemCode_3", cItemCode_3);
        command.Parameters.AddWithValue("@cItemdes_4", cItemdes_4);
        command.Parameters.AddWithValue("@cSize_5", cSize_5);
        command.Parameters.AddWithValue("@cColour_6", cColour_6);
        command.Parameters.AddWithValue("@cArt_7", cArt_7);
        command.Parameters.AddWithValue("@cDimec_8", cDimec_8);
        command.Parameters.AddWithValue("@cUnit_9", cUnit_9);
        command.Parameters.AddWithValue("@nQty_10", nQty_10);
        command.Parameters.AddWithValue("@nPrice_11", nPrice_11);
        command.Parameters.AddWithValue("@nVal_12", nVal_12);
        command.Parameters.AddWithValue("@cStatus_37", cStatus_37);
        command.Parameters.AddWithValue("@cUser_38", cUser_38);
        command.Parameters.AddWithValue("@nStyCode", nStyCode);
        if (!string.IsNullOrEmpty(dDelDate))
        {
            command.Parameters.AddWithValue("@dDelDate", dDelDate);
        }
        else
        {
            command.Parameters.AddWithValue("@dDelDate", DBNull.Value);
        }
        command.Parameters["@dDelDate"].SqlDbType = SqlDbType.DateTime;
        command.Parameters.AddWithValue("@cPack", cPack);
        command.Parameters.AddWithValue("@nDyeGrp", nDyeGrp);
        command.Parameters.AddWithValue("@cPo", cPo);
        command.Parameters.AddWithValue("@cPLmnt", cPLmnt);
        command.Parameters.AddWithValue("@cSupCode", cSupCode);
        command.Parameters.AddWithValue("@nSupPo", nSupPo);
        command.Parameters.AddWithValue("@cGmtPrt", cGmtPrt);
        command.Parameters.AddWithValue("@cDyPrc", cDyPrc);
        command.Parameters.AddWithValue("@SubcatID", SubcatID);
        command.Parameters.AddWithValue("@ArticleID", ArticleID);
        command.Parameters.AddWithValue("@DimensionID", DimensionID);
        command.Parameters.AddWithValue("@MCatID", MCatID);
        command.Parameters.AddWithValue("@SupplierID", SupplierID);
        command.Parameters.AddWithValue("@clots", clots);
        command.Parameters.AddWithValue("@nCom", nCom);
        command.Parameters.AddWithValue("@nOrdqty", nOrdqty);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_PODetailOtherBooking(int nPoNum_1, int nLnNo_2, int cItemCode_3, string cItemdes_4, string cSize_5, string cColour_6, string cArt_7, string cDimec_8, string cUnit_9, string nQty_10, string nPrice_11, string nVal_12, string cStatus_37, string cUser_38, int nStyCode, string dDelDate, string cPack, string nDyeGrp, string cPo, string cPLmnt, string cSupCode, string nSupPo, string cGmtPrt, string cDyPrc, int SubcatID, int ArticleID, int DimensionID, int MCatID, string clots, string nCom)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_PODetails_SaveOtherBooking", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nPoNum_1", nPoNum_1);
        command.Parameters.AddWithValue("@nLnNo_2", nLnNo_2);
        command.Parameters.AddWithValue("@cItemCode_3", cItemCode_3);
        command.Parameters.AddWithValue("@cItemdes_4", cItemdes_4);
        command.Parameters.AddWithValue("@cSize_5", cSize_5);
        command.Parameters.AddWithValue("@cColour_6", cColour_6);
        command.Parameters.AddWithValue("@cArt_7", cArt_7);
        command.Parameters.AddWithValue("@cDimec_8", cDimec_8);
        command.Parameters.AddWithValue("@cUnit_9", cUnit_9);
        command.Parameters.AddWithValue("@nQty_10", nQty_10);
        command.Parameters.AddWithValue("@nPrice_11", nPrice_11);
        command.Parameters.AddWithValue("@nVal_12", nVal_12);
        command.Parameters.AddWithValue("@cStatus_37", cStatus_37);
        command.Parameters.AddWithValue("@cUser_38", cUser_38);
        command.Parameters.AddWithValue("@nStyCode", nStyCode);
        if (!string.IsNullOrEmpty(dDelDate))
        {
            command.Parameters.AddWithValue("@dDelDate", dDelDate);
        }
        else
        {
            command.Parameters.AddWithValue("@dDelDate", DBNull.Value);
        }
        command.Parameters["@dDelDate"].SqlDbType = SqlDbType.DateTime;
        command.Parameters.AddWithValue("@cPack", cPack);
        command.Parameters.AddWithValue("@nDyeGrp", nDyeGrp);
        command.Parameters.AddWithValue("@cPo", cPo);
        command.Parameters.AddWithValue("@cPLmnt", cPLmnt);
        command.Parameters.AddWithValue("@cSupCode", cSupCode);
        command.Parameters.AddWithValue("@nSupPo", nSupPo);
        command.Parameters.AddWithValue("@cGmtPrt", cGmtPrt);
        command.Parameters.AddWithValue("@cDyPrc", cDyPrc);
        command.Parameters.AddWithValue("@SubcatID", SubcatID);
        command.Parameters.AddWithValue("@ArticleID", ArticleID);
        command.Parameters.AddWithValue("@DimensionID", DimensionID);
        command.Parameters.AddWithValue("@MCatID", MCatID);
        command.Parameters.AddWithValue("@clots", clots);
        command.Parameters.AddWithValue("@nCom", nCom);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_POHeader(int PONo, string SuplierCode, string CurrencyType, string Deliverydate, string CreditDays, string Amount, string UserName, string CStatus, string Attention, string SupplierPO, string Remarks, string DeliveryTo, int nbid, int nPtp, string Company_ID, string IssueTo)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_POHedder_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nPoNum_1", PONo);
        command.Parameters.AddWithValue("@nSuplierID", SuplierCode);
        command.Parameters.AddWithValue("@cCurType_3", CurrencyType);
        if (!string.IsNullOrEmpty(Deliverydate))
        {
            DateTime time = this.dateformat(Deliverydate);
            command.Parameters.AddWithValue("@dDelevey_4", time);
        }
        else
        {
            command.Parameters.AddWithValue("@dDelevey_4", DBNull.Value);
        }
        command.Parameters["@dDelevey_4"].SqlDbType = SqlDbType.SmallDateTime;
        command.Parameters.AddWithValue("@cCredtDay_5", CreditDays);
        command.Parameters.AddWithValue("@nAmot_6", Amount);
        command.Parameters.AddWithValue("@cuser_7", UserName);
        command.Parameters.AddWithValue("@cStatus_8", CStatus);
        command.Parameters.AddWithValue("@att", Attention);
        command.Parameters.AddWithValue("@nSupPo", SupplierPO);
        command.Parameters.AddWithValue("@cRemark", Remarks);
        command.Parameters.AddWithValue("@cfty", DeliveryTo);
        command.Parameters.AddWithValue("@nbid", nbid);
        command.Parameters.AddWithValue("@nPtp", nPtp);
        if (!string.IsNullOrEmpty(Company_ID))
        {
            command.Parameters.AddWithValue("@Company_ID", Company_ID);
        }
        else
        {
            command.Parameters.AddWithValue("@Company_ID", DBNull.Value);
        }
        command.Parameters["@Company_ID"].SqlDbType = SqlDbType.Int;
        if (!string.IsNullOrEmpty(IssueTo))
        {
            command.Parameters.AddWithValue("@nIssueTo", IssueTo);
        }
        else
        {
            command.Parameters.AddWithValue("@nIssueTo", DBNull.Value);
        }
        command.Parameters["@nIssueTo"].SqlDbType = SqlDbType.Int;
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_POHeaderOtherBooking(int PONo, string SuplierCode, string CurrencyType, string Deliverydate, string CreditDays, string Amount, string UserName, string CStatus, string Attention, string SupplierPO, string Remarks, string DeliveryTo, int nbid, int nPtp, string Company_ID, string nOrderType, string PIIssue)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_POHedder_SaveforBooking", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nPoNum_1", PONo);
        command.Parameters.AddWithValue("@nSuplierID", SuplierCode);
        command.Parameters.AddWithValue("@cCurType_3", CurrencyType);
        if (!string.IsNullOrEmpty(Deliverydate))
        {
            DateTime time = this.dateformat(Deliverydate);
            command.Parameters.AddWithValue("@dDelevey_4", time);
        }
        else
        {
            command.Parameters.AddWithValue("@dDelevey_4", DBNull.Value);
        }
        command.Parameters["@dDelevey_4"].SqlDbType = SqlDbType.SmallDateTime;
        command.Parameters.AddWithValue("@cCredtDay_5", CreditDays);
        command.Parameters.AddWithValue("@nAmot_6", Amount);
        command.Parameters.AddWithValue("@cuser_7", UserName);
        command.Parameters.AddWithValue("@cStatus_8", CStatus);
        command.Parameters.AddWithValue("@att", Attention);
        command.Parameters.AddWithValue("@nSupPo", SupplierPO);
        command.Parameters.AddWithValue("@cRemark", Remarks);
        command.Parameters.AddWithValue("@cfty", DeliveryTo);
        command.Parameters.AddWithValue("@nbid", nbid);
        command.Parameters.AddWithValue("@nPtp", nPtp);
        if (!string.IsNullOrEmpty(Company_ID))
        {
            command.Parameters.AddWithValue("@Company_ID", Company_ID);
        }
        else
        {
            command.Parameters.AddWithValue("@Company_ID", DBNull.Value);
        }
        command.Parameters["@Company_ID"].SqlDbType = SqlDbType.Int;
        command.Parameters.AddWithValue("@nOrderType", nOrderType);
        if (!string.IsNullOrEmpty(PIIssue))
        {
            command.Parameters.AddWithValue("@nIssueTo", PIIssue);
        }
        else
        {
            command.Parameters.AddWithValue("@nIssueTo", DBNull.Value);
        }
        command.Parameters["@nIssueTo"].SqlDbType = SqlDbType.Int;
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_POSensitivity(int nMcatID, int nSubCatID, string Lot, string PONO, string Placement, int nStyleID, string POQty, int nArticleID, int nDimensionID)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_POSensitivity_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nMcatID", nMcatID);
        command.Parameters.AddWithValue("@nSubCatID", nSubCatID);
        command.Parameters.AddWithValue("@Lot", Lot);
        command.Parameters.AddWithValue("@PONO", PONO);
        command.Parameters.AddWithValue("@Placement", Placement);
        command.Parameters.AddWithValue("@nStyleID", nStyleID);
        command.Parameters.AddWithValue("@POQty", POQty);
        command.Parameters.AddWithValue("@nArticleID", nArticleID);
        command.Parameters.AddWithValue("@nDimensionID", nDimensionID);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_ReturnNote(int nCompanyID, int nDepartment_Code, int nSection_Code, string cReturn_Type, string cReturn_NoteNO, int nSubcat_Code, int nItemcode, int nUnit, string dReturn_Qty, string cuser, string nstyCode, int GoodsReturnNo, int MainCatID, Label lbl)
    {
        SqlCommand command = new SqlCommand("GoodsRutern_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nCompanyID", nCompanyID);
        command.Parameters.AddWithValue("@nDepartment_Code", nDepartment_Code);
        command.Parameters.AddWithValue("@nSection_Code", nSection_Code);
        command.Parameters.AddWithValue("@cReturn_Type", cReturn_Type);
        command.Parameters.AddWithValue("@cReturn_NoteNO", cReturn_NoteNO);
        command.Parameters.AddWithValue("@nSubcat_Code", nSubcat_Code);
        command.Parameters.AddWithValue("@nItemcode", nItemcode);
        command.Parameters.AddWithValue("@nUnit", nUnit);
        command.Parameters.AddWithValue("@dReturn_Qty", dReturn_Qty);
        command.Parameters.AddWithValue("@cuser", cuser);
        command.Parameters.AddWithValue("@nstyCode", nstyCode);
        command.Parameters.AddWithValue("@GoodsReturnNo", GoodsReturnNo);
        command.Parameters.AddWithValue("@MainCatID", MainCatID);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        lbl.Text = "Saved Successfully";
    }

    public void Save_SizeSensitivity(int nStyID_1, string cMcat_2, int MainCatID, string cSize_3, string cDime_4, string cEntUSe_5, string cItemNAme, string cPlsmnt, string nPrice, int itemcode, int ArticleID, int DimensionID, string SizeDimn)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_SizeSensitive", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nStyID_1", nStyID_1);
        command.Parameters.AddWithValue("@cMcat_2", cMcat_2);
        command.Parameters.AddWithValue("@cMcatID", MainCatID);
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
        command.Parameters.AddWithValue("@Itemcode", itemcode);
        command.Parameters.AddWithValue("@ArticleID", ArticleID);
        command.Parameters.AddWithValue("@DimensionID", DimensionID);
        command.Parameters.AddWithValue("@SizeDimn", SizeDimn);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_StoragePlane(string Storage, int Block, int Rack, int Cell, string User, Label lbl)
    {
        SqlCommand command = new SqlCommand("select Storage_Name from Smt_StorageMasterPlane where Storage_Name='" + Storage + "'", this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_StorageMasterPlane_save", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@Storage_Name", Storage);
            command2.Parameters.AddWithValue("@Storage_Block", Block);
            command2.Parameters.AddWithValue("@Storage_Rack", Rack);
            command2.Parameters.AddWithValue("@Storage_Cell", Cell);
            command2.Parameters.AddWithValue("@EnBy", User);
            command2.ExecuteNonQuery();
            lbl.Text = "Saved Successfully";
        }
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_StyMCatPO(int nStyID_1, string cMmCat_2, string suplier, string cBpo, string cbomVer, string clot, int nItem, int nArticleID, int nDimensionId, string placement)
    {
        SqlCommand command = new SqlCommand("SP_Smt_StyMcatPOBOM_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nStyID_1", nStyID_1);
        command.Parameters.AddWithValue("@MaincatDesc", cMmCat_2);
        if (!string.IsNullOrEmpty(suplier))
        {
            command.Parameters.AddWithValue("@nSuplierID", suplier);
        }
        else
        {
            command.Parameters.AddWithValue("@nSuplierID", DBNull.Value);
        }
        command.Parameters["@nSuplierID"].SqlDbType = SqlDbType.Int;
        command.Parameters.AddWithValue("@cBpo", cBpo);
        command.Parameters.AddWithValue("@cbomVer", cbomVer);
        command.Parameters.AddWithValue("@clot", clot);
        command.Parameters.AddWithValue("@nItem", nItem);
        command.Parameters.AddWithValue("@nArticleID", nArticleID);
        command.Parameters.AddWithValue("@nDimensionId", nDimensionId);
        command.Parameters.AddWithValue("@placement", placement);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_Suppliermaincategory(string code, string maincat, int suplierid, int mcatid)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_SupSupManCat_Save", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@cSupCode_1", code);
        command.Parameters.AddWithValue("@cManCat_2", maincat);
        command.Parameters.AddWithValue("@SuplierID", suplierid);
        command.Parameters.AddWithValue("@McatCode", mcatid);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Save_Suppliers(string supcode, string name, string add1, string add2, string contno, string valtno, string type, string user, string catt, string email, string code, string suplieracc, Label lbl)
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_Suppliers_Save", this.cn)
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
            command2.Parameters.AddWithValue("@suplierAccount", suplieracc);
            command2.ExecuteNonQuery();
            lbl.Text = "Saved Successfully";
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
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

    public void Save_virtual(int styleid, int itemcode, string unit, decimal ncom, decimal wstg, decimal uprice, decimal valu, string suplier, int ordqty, string size, string typ, decimal reqqty, decimal stock, decimal netqty, int coltotqty, int nsiz, string mcat, string constructon, string dimn, string placement, int fabcol, int itecol, string lot, string user, string PO, int ArticleID, int DimensionID, string AJSRequirement, string UnitParam, string SizeDimnsion)
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
        if (!string.IsNullOrEmpty(suplier))
        {
            command.Parameters.AddWithValue("@nSup", suplier);
        }
        else
        {
            command.Parameters.AddWithValue("@nSup", DBNull.Value);
        }
        command.Parameters["@nSup"].SqlDbType = SqlDbType.Int;
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
        command.Parameters.AddWithValue("@articleid", ArticleID);
        command.Parameters.AddWithValue("@dimensionid", DimensionID);
        command.Parameters.AddWithValue("@AJSRequirement", AJSRequirement);
        command.Parameters.AddWithValue("@UnitParam", UnitParam);
        command.Parameters.AddWithValue("@SizeDimnsion", SizeDimnsion);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Subcat_hide(string mcatid, string cCode, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_SubCatagory_hide", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@mcatid", mcatid);
        command.Parameters.AddWithValue("@cCode", cCode);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        lbl.Text = "Saved Successfully";
    }

    public void Subcat_hideun(string mcatid)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_SubCatagory_unhide", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@mcatid", mcatid);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void svwithtn(string procdr, SqlConnection cn, string[] normalparam, string[] normalprmval, string[] dtmparam, string[] dtmparamval)
    {
        SqlCommand command = new SqlCommand(procdr, cn)
        {
            CommandType = CommandType.StoredProcedure
        };
        for (int i = 0; i < normalparam.Length; i++)
        {
            command.Parameters.AddWithValue(normalparam[i], normalprmval[i]);
        }
        if (normalparam.Length > 0)
        {
            for (int j = 0; j < normalparam.Length; j++)
            {
                string parameterName = normalparam[j];
                string str2 = normalprmval[j];
                if (!string.IsNullOrEmpty(str2))
                {
                    command.Parameters.AddWithValue(parameterName, str2);
                }
                else
                {
                    command.Parameters.AddWithValue(parameterName, DBNull.Value);
                }
            }
        }
        if (dtmparam.Length > 0)
        {
            for (int k = 0; k < dtmparam.Length; k++)
            {
                string str3 = dtmparam[k];
                string str4 = dtmparamval[k];
                if (!string.IsNullOrEmpty(str4))
                {
                    command.Parameters.AddWithValue(str3, string.Format("{0:dd/MM/yyyy}", str4));
                }
                else
                {
                    command.Parameters.AddWithValue(str3, DBNull.Value);
                }
                command.Parameters[str3].SqlDbType = SqlDbType.SmallDateTime;
            }
        }
        command.ExecuteNonQuery();
    }

    public void svwithtn(string procdr, SqlConnection cn, SqlTransaction tn, string[] normalparam, string[] normalprmval, string[] dtmparam, string[] dtmparamval)
    {
        SqlCommand command = new SqlCommand(procdr, cn, tn)
        {
            CommandType = CommandType.StoredProcedure
        };
        for (int i = 0; i < normalparam.Length; i++)
        {
            command.Parameters.AddWithValue(normalparam[i], normalprmval[i]);
        }
        if (normalparam.Length > 0)
        {
            for (int j = 0; j < normalparam.Length; j++)
            {
                string parameterName = normalparam[j];
                string str2 = normalprmval[j];
                if (!string.IsNullOrEmpty(str2))
                {
                    command.Parameters.AddWithValue(parameterName, str2);
                }
                else
                {
                    command.Parameters.AddWithValue(parameterName, DBNull.Value);
                }
            }
        }
        if (dtmparam.Length > 0)
        {
            for (int k = 0; k < dtmparam.Length; k++)
            {
                string str3 = dtmparam[k];
                string str4 = dtmparamval[k];
                if (!string.IsNullOrEmpty(str4))
                {
                    command.Parameters.AddWithValue(str3, string.Format("{0:dd/MM/yyyy}", str4));
                }
                else
                {
                    command.Parameters.AddWithValue(str3, DBNull.Value);
                }
                command.Parameters[str3].SqlDbType = SqlDbType.SmallDateTime;
            }
        }
    }

    public void Upd_grnprice(int nGrnNo, int nPoNum, int cItemCode, string nPrice, string nValue, string UserID, string nQty, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_GoodReceived_Updupriceforapp", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nGrnNo", nGrnNo);
        command.Parameters.AddWithValue("@nPoNum", nPoNum);
        command.Parameters.AddWithValue("@cItemCode", cItemCode);
        command.Parameters.AddWithValue("@nPrice", nPrice);
        command.Parameters.AddWithValue("@nValue", nValue);
        command.Parameters.AddWithValue("@UserID", UserID);
        command.Parameters.AddWithValue("@nQty", nQty);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        lbl.Text = "Saved Successfully";
    }

    public void Update_Article(int nArtCode, string article, int Maincatid, string maincat, Label lbl)
    {
        SqlCommand command = new SqlCommand(string.Concat(new object[] { "select cArticle from Smt_Artcle where cArticle='", article.Trim(), "' and nMainCatID='", Maincatid, "'" }), this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_Artcle_Update", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@nArtCode", nArtCode);
            command2.Parameters.AddWithValue("@cArticle_1", article);
            command2.Parameters.AddWithValue("@nMainCatID", Maincatid);
            command2.Parameters.AddWithValue("@cMCat", maincat);
            command2.ExecuteNonQuery();
            lbl.Text = "Updated Successfully";
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Update_BomMaincatnull(int styleid)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_BOM_UpdateMCatflag", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@styleid", styleid);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
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

    public void Update_Dimension(int dimnID, string Dimension, string MainCat, int Maincatid, Label lbl)
    {
        SqlCommand command = new SqlCommand(string.Concat(new object[] { "select cDimen,cMcat from Smt_Dimension where cDimen='", Dimension.Trim(), "' and nMainCatID='", Maincatid, "'" }), this.cn);
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
            SqlCommand command2 = new SqlCommand("Sp_Smt_Dimension_Update", this.cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            command2.Parameters.AddWithValue("@ndCode", dimnID);
            command2.Parameters.AddWithValue("@cDimen_1", Dimension);
            command2.Parameters.AddWithValue("@cMCat", MainCat);
            command2.Parameters.AddWithValue("@nMainCatID", Maincatid);
            command2.ExecuteNonQuery();
            lbl.Text = "Updated Successfully";
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    public void Update_FactoryPurchaseEditPO(string ReqQty, string Uprice, string Value, int Slno, int POno, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_FactoryPurchase_UpdateByPO", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nFPSlno", Slno);
        command.Parameters.AddWithValue("@POno", POno);
        if (!string.IsNullOrEmpty(ReqQty))
        {
            command.Parameters.AddWithValue("@ReqQty", ReqQty);
        }
        else
        {
            command.Parameters.AddWithValue("@ReqQty", "0");
        }
        if (!string.IsNullOrEmpty(Uprice))
        {
            command.Parameters.AddWithValue("@Uprice", Uprice);
        }
        else
        {
            command.Parameters.AddWithValue("@Uprice", "0");
        }
        if (!string.IsNullOrEmpty(Value))
        {
            command.Parameters.AddWithValue("@Value", Value);
        }
        else
        {
            command.Parameters.AddWithValue("@Value", "0");
        }
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        lbl.Text = "PO Updated Successfully";
    }

    public void Update_factorypurchaseforMultireq(int SupplierID, string ReqQty, string Uprice, string Value, int RequestNo, int Slno, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_FactoryPurchase_UpdateMltireq", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@SupplierID", SupplierID);
        command.Parameters.AddWithValue("@ReqQty", ReqQty);
        command.Parameters.AddWithValue("@Uprice", Uprice);
        command.Parameters.AddWithValue("@Value", Value);
        command.Parameters.AddWithValue("@RequestNo", RequestNo);
        command.Parameters.AddWithValue("@Slno", Slno);
        command.ExecuteNonQuery();
        lbl.Text = "Saved Successfully";
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Update_FactoryPurchasePO(int SupplierID, string ReqQty, string Uprice, string Value, string Stock, int RequestNo, int Slno, string POCreateUser, int PO_No, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_FactoryPurchase_SavePO", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@SupplierID", SupplierID);
        if (!string.IsNullOrEmpty(ReqQty))
        {
            command.Parameters.AddWithValue("@ReqQty", ReqQty);
        }
        else
        {
            command.Parameters.AddWithValue("@ReqQty", "0");
        }
        if (!string.IsNullOrEmpty(Uprice))
        {
            command.Parameters.AddWithValue("@Uprice", Uprice);
        }
        else
        {
            command.Parameters.AddWithValue("@Uprice", "0");
        }
        if (!string.IsNullOrEmpty(Value))
        {
            command.Parameters.AddWithValue("@Value", Value);
        }
        else
        {
            command.Parameters.AddWithValue("@Value", "0");
        }
        if (!string.IsNullOrEmpty(Stock))
        {
            command.Parameters.AddWithValue("@Stock", Stock);
        }
        else
        {
            command.Parameters.AddWithValue("@Stock", "0");
        }
        command.Parameters.AddWithValue("@RequestNo", RequestNo);
        command.Parameters.AddWithValue("@Slno", Slno);
        command.Parameters.AddWithValue("@POCreateUser", POCreateUser);
        command.Parameters.AddWithValue("@PO_No", PO_No);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        lbl.Text = "PO Created Successfully";
    }

    public void Update_FactoryPurchasePO1(int SupplierID, string ReqQty, string Uprice, string Value, string Stock, int RequestNo, int Slno, string POCreateUser, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_FactoryPurchase_SavePO1", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@SupplierID", SupplierID);
        if (!string.IsNullOrEmpty(ReqQty))
        {
            command.Parameters.AddWithValue("@ReqQty", ReqQty);
        }
        else
        {
            command.Parameters.AddWithValue("@ReqQty", "0");
        }
        if (!string.IsNullOrEmpty(Uprice))
        {
            command.Parameters.AddWithValue("@Uprice", Uprice);
        }
        else
        {
            command.Parameters.AddWithValue("@Uprice", "0");
        }
        if (!string.IsNullOrEmpty(Value))
        {
            command.Parameters.AddWithValue("@Value", Value);
        }
        else
        {
            command.Parameters.AddWithValue("@Value", "0");
        }
        if (!string.IsNullOrEmpty(Stock))
        {
            command.Parameters.AddWithValue("@Stock", Stock);
        }
        else
        {
            command.Parameters.AddWithValue("@Stock", "0");
        }
        command.Parameters.AddWithValue("@RequestNo", RequestNo);
        command.Parameters.AddWithValue("@Slno", Slno);
        command.Parameters.AddWithValue("@POCreateUser", POCreateUser);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        lbl.Text = "PO Created Successfully";
    }

    public void Update_FactoryPurchasePONew(int SupplierID, string ReqQty, string Uprice, string Value, int Slno, string POCreateUser, int nsl, string remark, Label lbl)
    {
        SqlCommand command = new SqlCommand("FactoryPurchase_SavePONew", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@SupplierID", SupplierID);
        if (!string.IsNullOrEmpty(ReqQty))
        {
            command.Parameters.AddWithValue("@ReqQty", ReqQty);
        }
        else
        {
            command.Parameters.AddWithValue("@ReqQty", "0");
        }
        if (!string.IsNullOrEmpty(Uprice))
        {
            command.Parameters.AddWithValue("@Uprice", Uprice);
        }
        else
        {
            command.Parameters.AddWithValue("@Uprice", "0");
        }
        if (!string.IsNullOrEmpty(Value))
        {
            command.Parameters.AddWithValue("@Value", Value);
        }
        else
        {
            command.Parameters.AddWithValue("@Value", "0");
        }
        command.Parameters.AddWithValue("@Slno", Slno);
        command.Parameters.AddWithValue("@POCreateUser", POCreateUser);
        command.Parameters.AddWithValue("@nslno", nsl);
        command.Parameters.AddWithValue("@rmrk", remark);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        lbl.Text = "PO Created Successfully";
    }

    public void Update_factPurMultipogenerate(int supplierid, string qty, string prce, string val, int Multparam, int sl, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_FactoryPurchase_SavePOMultiple", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@SupplierID", supplierid);
        command.Parameters.AddWithValue("@ReqQty", qty);
        command.Parameters.AddWithValue("@Uprice", prce);
        command.Parameters.AddWithValue("@Value", val);
        command.Parameters.AddWithValue("@Multireqno", Multparam);
        command.Parameters.AddWithValue("@Slno", sl);
        command.Parameters.AddWithValue("@POCreateUser", user);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        lbl.Text = "Saved Successfully";
    }

    public void update_FPMltino(int maxno, string reqno)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_FactoryPurchase_updateMulticlm", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@Multireqno", maxno);
        command.Parameters.AddWithValue("@nRequest_No", reqno);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Update_FPQtyfullgrn(int pono, string grntype)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_GoodReceived_UpdFPQtyfull", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@PONO", pono);
        command.Parameters.AddWithValue("@GRNType", grntype);
        command.ExecuteNonQuery();
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

    public void Update_MechanicalforMultireq(int SupplierID, string ReqQty, string Uprice, string Value, int RequestNo, int Slno, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_MechanicalPurchase_UpdateMltireq", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@SupplierID", SupplierID);
        command.Parameters.AddWithValue("@ReqQty", ReqQty);
        command.Parameters.AddWithValue("@Uprice", Uprice);
        command.Parameters.AddWithValue("@Value", Value);
        command.Parameters.AddWithValue("@RequestNo", RequestNo);
        command.Parameters.AddWithValue("@Slno", Slno);
        command.ExecuteNonQuery();
        lbl.Text = "Saved Successfully";
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void update_MechanicalMltino(int maxno, string reqno)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_MechanicalPurchase_updateMulticlm", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@Multireqno", maxno);
        command.Parameters.AddWithValue("@nRequest_No", reqno);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Update_MechanicalMultipogenerate(int supplierid, string qty, string prce, string val, int Multparam, int sl, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_MechanicalPurchase_SavePOMultiple", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@SupplierID", supplierid);
        command.Parameters.AddWithValue("@ReqQty", qty);
        command.Parameters.AddWithValue("@Uprice", prce);
        command.Parameters.AddWithValue("@Value", val);
        command.Parameters.AddWithValue("@Multireqno", Multparam);
        command.Parameters.AddWithValue("@Slno", sl);
        command.Parameters.AddWithValue("@POCreateUser", user);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        lbl.Text = "Saved Successfully";
    }

    public void Update_MechanicalPurchasePO1(int SupplierID, string ReqQty, string Uprice, string Value, string Stock, int RequestNo, int Slno, string POCreateUser, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_MechanicalPurchase_SavePO1", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@SupplierID", SupplierID);
        if (!string.IsNullOrEmpty(ReqQty))
        {
            command.Parameters.AddWithValue("@ReqQty", ReqQty);
        }
        else
        {
            command.Parameters.AddWithValue("@ReqQty", "0");
        }
        if (!string.IsNullOrEmpty(Uprice))
        {
            command.Parameters.AddWithValue("@Uprice", Uprice);
        }
        else
        {
            command.Parameters.AddWithValue("@Uprice", "0");
        }
        if (!string.IsNullOrEmpty(Value))
        {
            command.Parameters.AddWithValue("@Value", Value);
        }
        else
        {
            command.Parameters.AddWithValue("@Value", "0");
        }
        if (!string.IsNullOrEmpty(Stock))
        {
            command.Parameters.AddWithValue("@Stock", Stock);
        }
        else
        {
            command.Parameters.AddWithValue("@Stock", "0");
        }
        command.Parameters.AddWithValue("@RequestNo", RequestNo);
        command.Parameters.AddWithValue("@Slno", Slno);
        command.Parameters.AddWithValue("@POCreateUser", POCreateUser);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        lbl.Text = "PO Created Successfully";
    }

    public void Update_ParameterFactoryReturn(int FRNO)
    {
        SqlCommand command = new SqlCommand("update Smt_Parameters set GoodsReturnNo=" + FRNO, this.cn);
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

    public void Update_ParameterForGRN(int GrnNO)
    {
        SqlCommand command = new SqlCommand("update Smt_Parameters set nGRnLast=" + GrnNO, this.cn);
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

    public void Update_ParameterFormLocalPurchase(int REQNo)
    {
        SqlCommand command = new SqlCommand("update Smt_Parameters set Local_PurchaseReQNO=" + REQNo, this.cn);
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

    public void Update_ParameterFormLocalPurchasePONo(int PONO)
    {
        SqlCommand command = new SqlCommand("update Smt_Parameters set Local_Purchase_PONO=" + PONO, this.cn);
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

    public void Update_ParameterFormMechanicalPurchase(int REQNo)
    {
        SqlCommand command = new SqlCommand("update Smt_Parameters set Mechanical_ReqNo=" + REQNo, this.cn);
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

    public void update_ParameterforMultiFP(int maxno)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Parameters_update_fpMulti", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@FactorypurchaseMulti", maxno);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void update_ParameterforMultiMP(int maxno)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Parameters_update_MechanicalMulti", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@FactorypurchaseMulti", maxno);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void update_ParameterfromPO(int polast)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_Parameters_Update", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@polast", polast);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Update_ParameterGoodsIssueNo(int IssueNo)
    {
        SqlCommand command = new SqlCommand("update Smt_Parameters set GoodsIssueNo=" + IssueNo, this.cn);
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

    public void Update_POSensitivity(int nMcatID, int nSubCatID, string PONO, string Placement, int nStyleID, string Status, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_POSensitivity_Update", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nMcatID", nMcatID);
        command.Parameters.AddWithValue("@nSubCatID", nSubCatID);
        command.Parameters.AddWithValue("@PONO", PONO);
        command.Parameters.AddWithValue("@Placement", Placement);
        command.Parameters.AddWithValue("@nStyleID", nStyleID);
        command.Parameters.AddWithValue("@Status", Status);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        lbl.Text = "Saved Successfully";
    }

    public void Update_SizeSensitivity(int nStyID_1, string cMcat_2, string cSize_3, string cDime_4, string cItemNAme, string cPlsmnt, string nPrice, int status, string SizeDimension)
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
        command.Parameters.AddWithValue("@SizeDimension", SizeDimension);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Update_StoragePlane(int sl, int Block, int rack, int cell, string user, Label lbl)
    {
        SqlCommand command = new SqlCommand("Sp_Smt_StorageMasterPlane_Update", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@Storage_Sl", sl);
        command.Parameters.AddWithValue("@Storage_Block", Block);
        command.Parameters.AddWithValue("@Storage_Rack", rack);
        command.Parameters.AddWithValue("@Storage_Cell", cell);
        command.Parameters.AddWithValue("@EnBy", user);
        command.ExecuteNonQuery();
        lbl.Text = "Updated Successfully";
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Update_StyMCatPO(int nStyID_1, string cMmCat_2, int nPO_3, int cSupCode, int csub, int nArticleID, int nDimensionId, string placement)
    {
        SqlCommand command = new SqlCommand("SP_Smt_StyMcatPO_Update", this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@nStyID_1", nStyID_1);
        command.Parameters.AddWithValue("@cMmCat_2", cMmCat_2);
        command.Parameters.AddWithValue("@nPO_3", nPO_3);
        command.Parameters.AddWithValue("@cSupCode", cSupCode);
        command.Parameters.AddWithValue("@csub", csub);
        command.Parameters.AddWithValue("@nArticleID", nArticleID);
        command.Parameters.AddWithValue("@nDimensionId", nDimensionId);
        command.Parameters.AddWithValue("@placement", placement);
        command.ExecuteNonQuery();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void Update_SupplierPO(int SuplierID)
    {
        SqlCommand command = new SqlCommand("update Smt_Suppliers set npo=npo+1,NoOfPoCreate=NoOfPoCreate+1 where nCode='" + SuplierID + "'", this.cn);
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

    public void Update_Suppliers(string supcode, string name, string add1, string add2, string contno, string valtno, string type, string user, string catt, string email, string code, string accountno, Label lbl)
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
        command.Parameters.AddWithValue("@suplierAccount", accountno);
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

    public void UpdateParamfpnew(int prm)
    {
        SqlCommand command = new SqlCommand("update Smt_Parameters set fpnsl=" + prm, this.cn);
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
}
