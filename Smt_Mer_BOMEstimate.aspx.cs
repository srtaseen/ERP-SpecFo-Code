using AjaxControlToolkit;
using ASP;
using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Smt_Mer_BOMEstimate : System.Web.UI.Page
{
    private BLLInventory blinventory = new BLLInventory();
    //protected Button btnaddarticle;
    //protected Button btnadddimension;
    //protected Button btnaddsubcat;
    //protected Button btnClear;
    //protected Button btnClearall;
    //protected Button btnCopy;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    private DALInventory dlinventory = new DALInventory();
    //protected DropDownList drpCurrencytype;
    //protected DropDownList drpStyleno;
    //protected GridView grdBOM;
    //protected Label Label1;
    //protected Label Label15;
    //protected Label Label17;
    //protected Label Label2;
    //protected Label Label3;
    //protected Label Label4;
    //protected Label Label5;
    //protected Label Label6;
    //protected Label Label7;
    private BLL mybll = new BLL();
    private DAL mycls = new DAL();
    //protected RequiredFieldValidator RequiredFieldValidator1;
    //protected ValidatorCalloutExtender RequiredFieldValidator1_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator3;
    //protected ValidatorCalloutExtender RequiredFieldValidator3_ValidatorCalloutExtender;
    //protected TextBox txtBrand;
    //protected TextBox txtBuyer;
    //protected TextBox txtGarmentDpt;
    //protected TextBox txtGarmenttype;
    //protected TextBox txtOrdqtysum;
    //protected TextBox txtSeason;
    //protected TextBox txtStore;
    //protected UpdatePanel UpdatePanel1;

    private void AddBOMRow()
    {
        int num = 0;
        if (this.ViewState["BOM"] != null)
        {
            DataTable table = (DataTable)this.ViewState["BOM"];
            DataRow row = null;
            if (table.Rows.Count > 0)
            {
                for (int i = 1; i <= table.Rows.Count; i++)
                {
                    DropDownList list = (DropDownList)this.grdBOM.Rows[num].FindControl("drpBommaincategory");
                    DropDownList list2 = (DropDownList)this.grdBOM.Rows[num].FindControl("drpItemdesc");
                    DropDownList list3 = (DropDownList)this.grdBOM.Rows[num].FindControl("drpBOmconstruction");
                    DropDownList list4 = (DropDownList)this.grdBOM.Rows[num].FindControl("drpBOMDimension");
                    DropDownList list5 = (DropDownList)this.grdBOM.Rows[num].FindControl("drpBomUnit");
                    TextBox box = (TextBox)this.grdBOM.Rows[num].FindControl("txtUnitparam");
                    DropDownList list6 = (DropDownList)this.grdBOM.Rows[num].FindControl("drpbomtype");
                    TextBox box1 = (TextBox)this.grdBOM.Rows[num].FindControl("txtParam");
                    TextBox box2 = (TextBox)this.grdBOM.Rows[num].FindControl("txtBOMconsumption");
                    TextBox box3 = (TextBox)this.grdBOM.Rows[num].FindControl("txtbomwst");
                    TextBox box4 = (TextBox)this.grdBOM.Rows[num].FindControl("txtbomrate");
                    TextBox box5 = (TextBox)this.grdBOM.Rows[num].FindControl("txtbomvalue");
                    TextBox box6 = (TextBox)this.grdBOM.Rows[num].FindControl("txtbomgmtqty");
                    TextBox box7 = (TextBox)this.grdBOM.Rows[num].FindControl("txtbomrequirement");
                    TextBox box8 = (TextBox)this.grdBOM.Rows[num].FindControl("txtBomplacement");
                    row = table.NewRow();
                    if (!string.IsNullOrEmpty(list.SelectedValue))
                    {
                        table.Rows[i - 1]["MainCatCode"] = list.SelectedValue;
                    }
                    table.Rows[i - 1]["cUnit"] = list5.SelectedValue;
                    if (!string.IsNullOrEmpty(box.Text))
                    {
                        table.Rows[i - 1]["UnitConParam"] = box.Text;
                    }
                    else
                    {
                        table.Rows[i - 1]["UnitConParam"] = DBNull.Value;
                    }
                    if (!string.IsNullOrEmpty(list.SelectedValue))
                    {
                        table.Rows[i - 1]["nItemcode"] = list2.SelectedValue;
                    }
                    table.Rows[i - 1]["ConstructionID"] = list3.SelectedValue;
                    table.Rows[i - 1]["DimensionID"] = list4.SelectedValue;
                    table.Rows[i - 1]["ctype"] = list6.SelectedItem.Text.Trim();
                    if (!string.IsNullOrEmpty(box2.Text))
                    {
                        table.Rows[i - 1]["nCom"] = box2.Text;
                    }
                    else
                    {
                        table.Rows[i - 1]["nCom"] = DBNull.Value;
                    }
                    if (!string.IsNullOrEmpty(box3.Text))
                    {
                        table.Rows[i - 1]["nWst"] = box3.Text;
                    }
                    else
                    {
                        table.Rows[i - 1]["nWst"] = DBNull.Value;
                    }
                    if (!string.IsNullOrEmpty(box4.Text))
                    {
                        table.Rows[i - 1]["nUprice"] = box4.Text;
                    }
                    if (!string.IsNullOrEmpty(box5.Text))
                    {
                        table.Rows[i - 1]["nValue"] = box5.Text;
                    }
                    if (!string.IsNullOrEmpty(box6.Text))
                    {
                        table.Rows[i - 1]["nOrdqty"] = box6.Text;
                    }
                    else
                    {
                        table.Rows[i - 1]["nOrdqty"] = DBNull.Value;
                    }
                    if (!string.IsNullOrEmpty(box7.Text))
                    {
                        table.Rows[i - 1]["nReqqty"] = box7.Text;
                    }
                    else
                    {
                        table.Rows[i - 1]["nReqqty"] = DBNull.Value;
                    }
                    table.Rows[i - 1]["cPlsmnt"] = box8.Text;
                    num++;
                }
                table.Rows.Add(row);
                this.ViewState["BOM"] = table;
                this.grdBOM.DataSource = table;
                this.grdBOM.DataBind();
            }
        }
        else
        {
            base.Response.Write("ViewState is null");
        }
        this.SetPerviousBOM();
    }

    public void bindMaincat(DropDownList drpMaincat)
    {
        drpMaincat.DataSource = this.blinventory.get_Informationdataset("Sp_Smt_BOM_GetMainCatMarchentPurchase");
        drpMaincat.DataTextField = "cMainCategory";
        drpMaincat.DataValueField = "nMainCategory_ID";
        drpMaincat.DataBind();
        drpMaincat.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        drpMaincat.SelectedIndex = 0;
    }

    public void bindordunit(DropDownList drpsubcat, DropDownList drpordunt)
    {
        DataTable table = this.blinventory.get_InformationdataTable("OrdUnit_getgroupunit " + drpsubcat.SelectedValue);
        drpordunt.DataSource = table;
        drpordunt.DataTextField = "cUnitDes";
        drpordunt.DataValueField = "nUnitID";
        drpordunt.DataBind();
        drpordunt.Items.Insert(0, string.Empty);
    }

    public void bindStyleid()
    {
        DataTable table = this.mybll.get_InformationdataTable("Sp_Smt_GetStyleID '" + this.Session["Uid"].ToString() + "','EB'");
        this.drpStyleno.Items.Add(new ListItem("", ""));
        this.drpStyleno.DataSource = table;
        this.drpStyleno.DataTextField = "StyleNO";
        this.drpStyleno.DataValueField = "StyleID";
        this.drpStyleno.DataBind();
        this.drpStyleno.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpStyleno.SelectedIndex = 0;
    }

    protected void btnAddnewBOMRow_Click(object sender, ImageClickEventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.AddBOMRow();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.SetInitialRow();
        this.drpStyleno.SelectedValue = "";
        this.drpCurrencytype.SelectedValue = "";
        this.txtBrand.Text = "";
        this.txtBuyer.Text = "";
        this.txtGarmentDpt.Text = "";
        this.txtGarmenttype.Text = "";
        this.txtOrdqtysum.Text = "";
        this.txtSeason.Text = "";
        this.txtStore.Text = "";
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.btnCopy.Visible = false;
    }

    protected void btnClearall_Click(object sender, EventArgs e)
    {
        this.SetInitialRow();
        this.drpStyleno.SelectedValue = "";
        this.drpCurrencytype.SelectedValue = "";
        this.txtBrand.Text = "";
        this.txtBuyer.Text = "";
        this.txtGarmentDpt.Text = "";
        this.txtGarmenttype.Text = "";
        this.txtOrdqtysum.Text = "";
        this.txtSeason.Text = "";
        this.txtStore.Text = "";
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
    }

    protected void btnLoadBOM_Click(object sender, ImageClickEventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        for (int i = 0; i < this.grdBOM.Rows.Count; i++)
        {
            this.grdBOM.Rows[i].BackColor = Color.Empty;
        }
        GridViewRow parent = ((ImageButton)sender).Parent.Parent as GridViewRow;
        DropDownList dimension = (DropDownList)parent.FindControl("drpBOMDimension");
        DropDownList list2 = (DropDownList)parent.FindControl("drpBomUnit");
        DropDownList drpconst = (DropDownList)parent.FindControl("drpBOmconstruction");
        DropDownList maincategory = (DropDownList)parent.FindControl("drpBommaincategory");
        DropDownList drpitem = (DropDownList)parent.FindControl("drpItemdesc");
        TextBox box = (TextBox)parent.FindControl("txtUnitparam");
        parent.BackColor = Color.FromName("#0FB1FF");
        string selectedValue = drpitem.SelectedValue;
        string str2 = list2.SelectedValue;
        string text = box.Text;
        string str4 = drpconst.SelectedValue;
        string str5 = dimension.SelectedValue;
        if (!string.IsNullOrEmpty(maincategory.SelectedValue))
        {
            this.dlinventory.drp_ConstructionArticlebymaincategory(maincategory, drpconst);
            this.dlinventory.drp_itemdescriptionbymaincat(maincategory, drpitem);
            this.dlinventory.drp_Dimensionbymaincategory(maincategory, dimension);
        }
        if (!string.IsNullOrEmpty(selectedValue))
        {
            drpitem.SelectedValue = selectedValue;
            if (!string.IsNullOrEmpty(str2))
            {
                list2.SelectedValue = str2;
            }
            else
            {
                box.Text = "";
                list2.SelectedValue = this.blinventory.get_InformationdataTable("select cUnit from Smt_SubCatagory where cCode=" + drpitem.SelectedValue).Rows[0]["cUnit"].ToString().Trim();
                DataTable table2 = this.blinventory.get_InformationdataTable("select nConPara from Smt_Unit where nUnitID=" + list2.SelectedValue);
                box.Text = table2.Rows[0]["nConPara"].ToString();
            }
        }
        if (!string.IsNullOrEmpty(text))
        {
            box.Text = text;
        }
        if (!string.IsNullOrEmpty(str4))
        {
            drpconst.SelectedValue = str4;
        }
        if (!string.IsNullOrEmpty(str5))
        {
            dimension.SelectedValue = str5;
        }
    }

    protected void btnRemoveBOM_Click(object sender, ImageClickEventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        GridViewRow parent = ((ImageButton)sender).Parent.Parent as GridViewRow;
        this.CheckrowhenDeleteBOMRow();
        if ((this.ViewState["BOM"] != null) && (this.grdBOM.Rows.Count > 1))
        {
            DataTable table = (DataTable)this.ViewState["BOM"];
            table.Rows.RemoveAt(parent.RowIndex);
            this.grdBOM.DataSource = table;
            this.grdBOM.DataBind();
            this.SetPerviousBOM();
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        int num = 0;
        Label lbl = (Label)base.Master.FindControl("lbltotalinfo");
        this.dlinventory.Delete_BomEstimate(int.Parse(this.drpStyleno.SelectedValue));
        for (int i = 0; i < this.grdBOM.Rows.Count; i++)
        {
            DropDownList list = (DropDownList)this.grdBOM.Rows[i].FindControl("drpBommaincategory");
            DropDownList list2 = (DropDownList)this.grdBOM.Rows[i].FindControl("drpItemdesc");
            DropDownList list3 = (DropDownList)this.grdBOM.Rows[i].FindControl("drpBomUnit");
            DropDownList list4 = (DropDownList)this.grdBOM.Rows[i].FindControl("drpbomtype");
            if ((!string.IsNullOrEmpty(list.SelectedValue) && !string.IsNullOrEmpty(list2.SelectedValue)) && (!string.IsNullOrEmpty(list3.SelectedValue) && !string.IsNullOrEmpty(list4.SelectedValue)))
            {
                DropDownList list5 = (DropDownList)this.grdBOM.Rows[i].FindControl("drpBOmconstruction");
                DropDownList list6 = (DropDownList)this.grdBOM.Rows[i].FindControl("drpBOMDimension");
                TextBox box = (TextBox)this.grdBOM.Rows[i].FindControl("txtBOMconsumption");
                TextBox box2 = (TextBox)this.grdBOM.Rows[i].FindControl("txtbomwst");
                TextBox box3 = (TextBox)this.grdBOM.Rows[i].FindControl("txtbomrate");
                TextBox box4 = (TextBox)this.grdBOM.Rows[i].FindControl("txtbomvalue");
                TextBox box5 = (TextBox)this.grdBOM.Rows[i].FindControl("txtbomgmtqty");
                TextBox box6 = (TextBox)this.grdBOM.Rows[i].FindControl("txtbomrequirement");
                TextBox box7 = (TextBox)this.grdBOM.Rows[i].FindControl("txtBomplacement");
                TextBox box8 = (TextBox)this.grdBOM.Rows[i].FindControl("txtUnitparam");
                this.dlinventory.Save_BOMEstimate(int.Parse(this.drpStyleno.SelectedValue), int.Parse(list2.SelectedValue), list3.SelectedValue, box.Text, box2.Text, box3.Text, box4.Text, box5.Text, this.Session["Uid"].ToString(), this.drpCurrencytype.SelectedValue, list4.SelectedValue, box6.Text, box7.Text, int.Parse(list.SelectedValue), int.Parse(list5.SelectedValue), int.Parse(list6.SelectedValue), box8.Text, lbl);
                num++;
            }
        }
        if (num > 0)
        {
            this.SetInitialRow();
            this.drpStyleno.SelectedValue = "";
            this.drpCurrencytype.SelectedValue = "";
            this.txtBrand.Text = "";
            this.txtBuyer.Text = "";
            this.txtGarmentDpt.Text = "";
            this.txtGarmenttype.Text = "";
            this.txtOrdqtysum.Text = "";
            this.txtSeason.Text = "";
            this.txtStore.Text = "";
        }
    }

    public void CheckrowhenDeleteBOMRow()
    {
        int num = 0;
        DataTable table = (DataTable)this.ViewState["BOM"];
        if (table.Rows.Count > 0)
        {
            for (int i = 1; i <= table.Rows.Count; i++)
            {
                DropDownList list = (DropDownList)this.grdBOM.Rows[num].FindControl("drpBommaincategory");
                DropDownList list2 = (DropDownList)this.grdBOM.Rows[num].FindControl("drpItemdesc");
                DropDownList list1 = (DropDownList)this.grdBOM.Rows[num].FindControl("drpBOmconstruction");
                DropDownList list5 = (DropDownList)this.grdBOM.Rows[num].FindControl("drpBOMDimension");
                DropDownList list3 = (DropDownList)this.grdBOM.Rows[num].FindControl("drpBomUnit");
                DropDownList list4 = (DropDownList)this.grdBOM.Rows[num].FindControl("drpbomtype");
                TextBox box1 = (TextBox)this.grdBOM.Rows[num].FindControl("txtParam");
                TextBox box = (TextBox)this.grdBOM.Rows[num].FindControl("txtUnitparam");
                TextBox box2 = (TextBox)this.grdBOM.Rows[num].FindControl("txtBOMconsumption");
                TextBox box3 = (TextBox)this.grdBOM.Rows[num].FindControl("txtbomwst");
                TextBox box4 = (TextBox)this.grdBOM.Rows[num].FindControl("txtbomrate");
                TextBox box5 = (TextBox)this.grdBOM.Rows[num].FindControl("txtbomvalue");
                TextBox box6 = (TextBox)this.grdBOM.Rows[num].FindControl("txtbomgmtqty");
                TextBox box7 = (TextBox)this.grdBOM.Rows[num].FindControl("txtbomrequirement");
                TextBox box8 = (TextBox)this.grdBOM.Rows[num].FindControl("txtBomplacement");
                table.NewRow();
                if (!string.IsNullOrEmpty(table.Rows[i - 1]["MainCatCode"].ToString()))
                {
                    table.Rows[i - 1]["MainCatCode"] = list.SelectedValue;
                }
                table.Rows[i - 1]["cUnit"] = list3.SelectedValue;
                if (!string.IsNullOrEmpty(box.Text))
                {
                    table.Rows[i - 1]["UnitConParam"] = box.Text;
                }
                else
                {
                    table.Rows[i - 1]["UnitConParam"] = DBNull.Value;
                }
                if (!string.IsNullOrEmpty(list2.SelectedValue))
                {
                    table.Rows[i - 1]["nItemcode"] = list2.SelectedValue;
                }
                else
                {
                    table.Rows[i - 1]["nItemcode"] = DBNull.Value;
                }
                if (!string.IsNullOrEmpty(list4.SelectedValue))
                {
                    table.Rows[i - 1]["ctype"] = list4.SelectedItem.Text.Trim();
                }
                else
                {
                    table.Rows[i - 1]["ctype"] = "";
                }
                if (!string.IsNullOrEmpty(box2.Text))
                {
                    table.Rows[i - 1]["nCom"] = box2.Text;
                }
                else
                {
                    table.Rows[i - 1]["nCom"] = DBNull.Value;
                }
                if (!string.IsNullOrEmpty(box3.Text))
                {
                    table.Rows[i - 1]["nWst"] = box3.Text;
                }
                else
                {
                    table.Rows[i - 1]["nWst"] = DBNull.Value;
                }
                if (!string.IsNullOrEmpty(box4.Text))
                {
                    table.Rows[i - 1]["nUprice"] = box4.Text;
                }
                if (!string.IsNullOrEmpty(box5.Text))
                {
                    table.Rows[i - 1]["nValue"] = box5.Text;
                }
                if (!string.IsNullOrEmpty(box6.Text))
                {
                    table.Rows[i - 1]["nOrdqty"] = box6.Text;
                }
                else
                {
                    table.Rows[i - 1]["nOrdqty"] = DBNull.Value;
                }
                if (!string.IsNullOrEmpty(box7.Text))
                {
                    table.Rows[i - 1]["nReqqty"] = box7.Text;
                }
                else
                {
                    table.Rows[i - 1]["nReqqty"] = DBNull.Value;
                }
                table.Rows[i - 1]["cPlsmnt"] = box8.Text;
                num++;
            }
            this.ViewState["BOM"] = table;
        }
    }

    protected void drpBommaincategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        GridViewRow parent = ((DropDownList)sender).Parent.Parent as GridViewRow;
        DropDownList dimension = (DropDownList)parent.FindControl("drpBOMDimension");
        DropDownList list1 = (DropDownList)parent.FindControl("drpBomUnit");
        DropDownList drpconst = (DropDownList)parent.FindControl("drpBOmconstruction");
        DropDownList maincategory = (DropDownList)parent.FindControl("drpBommaincategory");
        DropDownList drpitem = (DropDownList)parent.FindControl("drpItemdesc");
        TextBox box = (TextBox)parent.FindControl("txtUnitparam");
        this.dlinventory.drp_ConstructionArticlebymaincategory(maincategory, drpconst);
        this.dlinventory.drp_itemdescriptionbymaincat(maincategory, drpitem);
        this.dlinventory.drp_Dimensionbymaincategory(maincategory, dimension);
        box.Text = "";
        if (!string.IsNullOrEmpty(drpitem.SelectedValue))
        {
            DropDownList drpordunt = (DropDownList)parent.FindControl("drpBomUnit");
            this.bindordunit(drpitem, drpordunt);
            drpordunt.SelectedValue = this.blinventory.get_InformationdataTable("select cUnit from Smt_SubCatagory where cCode='" + drpitem.SelectedValue + "'").Rows[0]["cUnit"].ToString().Trim();
            DataTable table2 = this.blinventory.get_InformationdataTable("select nConPara from Smt_Unit where nUnitID='" + drpordunt.SelectedValue + "'");
            box.Text = table2.Rows[0]["nConPara"].ToString();
        }
        else
        {
            DropDownList list6 = (DropDownList)parent.FindControl("drpBomUnit");
            list6.Items.Clear();
            box.Text = "";
        }
    }

    protected void drpBomUnit_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        GridViewRow parent = ((DropDownList)sender).Parent.Parent as GridViewRow;
        DropDownList list = (DropDownList)parent.FindControl("drpBomUnit");
        TextBox box = (TextBox)parent.FindControl("txtUnitparam");
        if (!string.IsNullOrEmpty(list.SelectedValue))
        {
            DataTable table = this.blinventory.get_InformationdataTable("select nConPara from Smt_Unit where nUnitID='" + list.SelectedValue + "'");
            box.Text = table.Rows[0]["nConPara"].ToString();
        }
        else
        {
            box.Text = "";
        }
    }

    protected void drpItemdesc_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        GridViewRow parent = ((DropDownList)sender).Parent.Parent as GridViewRow;
        DropDownList list = (DropDownList)parent.FindControl("drpItemdesc");
        if (!string.IsNullOrEmpty(list.SelectedValue))
        {
            DropDownList list2 = (DropDownList)parent.FindControl("drpBomUnit");
            TextBox box = (TextBox)parent.FindControl("txtUnitparam");
            box.Text = "";
            list2.SelectedValue = this.blinventory.get_InformationdataTable("select cUnit from Smt_SubCatagory where cCode='" + list.SelectedValue + "'").Rows[0]["cUnit"].ToString().Trim();
            DataTable table2 = this.blinventory.get_InformationdataTable("select nConPara from Smt_Unit where nUnitID='" + list2.SelectedValue + "'");
            box.Text = table2.Rows[0]["nConPara"].ToString();
        }
        else
        {
            DropDownList list3 = (DropDownList)parent.FindControl("drpBomUnit");
            TextBox box2 = (TextBox)parent.FindControl("txtUnitparam");
            list3.SelectedValue = "";
            box2.Text = "";
        }
    }

    protected void drpStyleno_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.grdBOM.Visible = true;
        this.btnCopy.Visible = false;
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        if (this.drpStyleno.SelectedValue != "")
        {
            this.txtBrand.Text = "";
            this.txtBuyer.Text = "";
            this.txtGarmentDpt.Text = "";
            this.txtGarmenttype.Text = "";
            this.txtSeason.Text = "";
            this.txtStore.Text = "";
            this.Session["dtbom"] = null;
            this.txtOrdqtysum.Text = "";
            this.drpCurrencytype.SelectedValue = "";
            string sqlstatement = "select cSeason_Name,cBuyer_Name,cBrand_Name,cStore_Name,cGmt_Dept_Description,cGmetDis from Smt_View_Stylemaster where nStyleID=" + this.drpStyleno.SelectedValue;
            DataSet set = this.mybll.get_Informationdataset(sqlstatement);
            this.txtBrand.Text = set.Tables[0].Rows[0]["cBrand_Name"].ToString();
            this.txtBuyer.Text = set.Tables[0].Rows[0]["cBuyer_Name"].ToString();
            this.txtGarmentDpt.Text = set.Tables[0].Rows[0]["cGmt_Dept_Description"].ToString();
            this.txtGarmenttype.Text = set.Tables[0].Rows[0]["cGmetDis"].ToString();
            this.txtSeason.Text = set.Tables[0].Rows[0]["cSeason_Name"].ToString();
            this.txtStore.Text = set.Tables[0].Rows[0]["cStore_Name"].ToString();
            DataTable table = this.blinventory.get_InformationdataTable("select * from Smt_BOM_Estimate where nstyCode=" + this.drpStyleno.SelectedValue);
            DataTable table2 = this.mybll.get_InformationdataTable("select sum(nOrdQty) as nOrdQty from Smt_OrdersMaster where nOStyleId=" + this.drpStyleno.SelectedValue);
            this.txtOrdqtysum.Text = table2.Rows[0]["nOrdQty"].ToString();
            if (table.Rows.Count > 0)
            {
                this.btnCopy.Visible = true;
                this.grdBOM.DataSource = table;
                this.grdBOM.DataBind();
                this.Session["dtbom"] = "i";
                this.drpCurrencytype.SelectedValue = table.Rows[0]["cCurtype"].ToString();
                this.ViewState["BOM"] = table;
            }
            else
            {
                this.SetInitialRow();
                this.drpCurrencytype.SelectedValue = "";
            }
        }
        else
        {
            this.Session["dtbom"] = null;
            this.grdBOM.DataSource = null;
            this.grdBOM.DataBind();
            this.txtBrand.Text = "";
            this.txtBuyer.Text = "";
            this.txtGarmentDpt.Text = "";
            this.txtGarmenttype.Text = "";
            this.txtSeason.Text = "";
            this.txtStore.Text = "";
            this.SetInitialRow();
            this.txtOrdqtysum.Text = "";
            this.drpCurrencytype.SelectedValue = "";
        }
    }

    public DataSet GetPOQty(string styleid, string lot)
    {
        string str = null;
        string[] strArray = lot.Split(new char[] { '/' });
        for (int i = 0; i < strArray.Length; i++)
        {
            string str2 = strArray[i].ToString();
            if (i == 0)
            {
                str = str + " And (cOrderNu='" + str2 + "'";
            }
            else
            {
                str = str + " or cOrderNu='" + str2 + "'";
            }
        }
        return this.mybll.get_Informationdataset("select sum(nOrdQty) nOrdQty from Smt_OrdersMaster where nOStyleId='" + styleid + "'" + str + ")");
    }

    protected void grdBOM_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if ((e.Row.RowType == DataControlRowType.DataRow) && (e.Row.RowType == DataControlRowType.DataRow))
        {
            DropDownList drpMaincat = (DropDownList)e.Row.FindControl("drpBommaincategory");
            DropDownList drpordunt = (DropDownList)e.Row.FindControl("drpBomUnit");
            this.bindMaincat(drpMaincat);
            DropDownList list3 = (DropDownList)e.Row.FindControl("drpbomtype");
            TextBox box = (TextBox)e.Row.FindControl("txtBOMconsumption");
            TextBox box2 = (TextBox)e.Row.FindControl("txtbomwst");
            TextBox box3 = (TextBox)e.Row.FindControl("txtbomgmtqty");
            TextBox box4 = (TextBox)e.Row.FindControl("txtbomrequirement");
            TextBox box5 = (TextBox)e.Row.FindControl("txtbomrate");
            TextBox box6 = (TextBox)e.Row.FindControl("txtbomvalue");
            TextBox box7 = (TextBox)e.Row.FindControl("txtParam");
            TextBox box8 = (TextBox)e.Row.FindControl("txtbomrequirement");
            TextBox box9 = (TextBox)e.Row.FindControl("txtBomplacement");
            TextBox box10 = (TextBox)e.Row.FindControl("txtUnitparam");
            ImageButton button1 = (ImageButton)e.Row.FindControl("btnLoadBOM");
            ImageButton button2 = (ImageButton)e.Row.FindControl("btnRemoveBOM");
            drpordunt.Attributes.Add("onchange", "GetUnitParam('" + drpordunt.ClientID + "','" + box10.ClientID + "')");
            list3.Attributes.Add("onchange", "BOMCalculationforEBOM('" + list3.ClientID + "','" + box7.ClientID + "','" + box3.ClientID + "','" + box.ClientID + "','" + box2.ClientID + "','" + box4.ClientID + "','" + box5.ClientID + "','" + box6.ClientID + "','" + this.txtOrdqtysum.ClientID + "','" + box10.ClientID + "')");
            box2.Attributes.Add("onkeyup", "BOMCalculationforEBOM('" + list3.ClientID + "','" + box7.ClientID + "','" + box3.ClientID + "','" + box.ClientID + "','" + box2.ClientID + "','" + box4.ClientID + "','" + box5.ClientID + "','" + box6.ClientID + "','" + this.txtOrdqtysum.ClientID + "','" + box10.ClientID + "')");
            box.Attributes.Add("onkeyup", "BOMCalculationforEBOM('" + list3.ClientID + "','" + box7.ClientID + "','" + box3.ClientID + "','" + box.ClientID + "','" + box2.ClientID + "','" + box4.ClientID + "','" + box5.ClientID + "','" + box6.ClientID + "' ,'" + this.txtOrdqtysum.ClientID + "','" + box10.ClientID + "')");
            box5.Attributes.Add("onkeyup", "BOMCalculationforEBOM('" + list3.ClientID + "','" + box7.ClientID + "','" + box3.ClientID + "','" + box.ClientID + "','" + box2.ClientID + "','" + box4.ClientID + "','" + box5.ClientID + "','" + box6.ClientID + "' ,'" + this.txtOrdqtysum.ClientID + "','" + box10.ClientID + "')");
            DropDownList drpitem = (DropDownList)e.Row.FindControl("drpItemdesc");
            DropDownList drpconst = (DropDownList)e.Row.FindControl("drpBOmconstruction");
            DropDownList dimension = (DropDownList)e.Row.FindControl("drpBOMDimension");
            TextBox box11 = (TextBox)e.Row.FindControl("txtbomwst");
            TextBox box12 = (TextBox)e.Row.FindControl("txtbomvalue");
            TextBox box13 = (TextBox)e.Row.FindControl("txtbomrate");
            TextBox box14 = (TextBox)e.Row.FindControl("txtBOMconsumption");
            TextBox box15 = (TextBox)e.Row.FindControl("txtbomgmtqty");
            DataRowView dataItem = (DataRowView)e.Row.DataItem;
            drpMaincat.SelectedValue = dataItem["MainCatCode"].ToString();
            if (!string.IsNullOrEmpty(drpMaincat.SelectedValue))
            {
                this.dlinventory.drp_itemdescriptionbymaincat(drpMaincat, drpitem);
                if (!string.IsNullOrEmpty(drpitem.SelectedValue))
                {
                    this.bindordunit(drpitem, drpordunt);
                }
            }
            this.dlinventory.drp_ConstructionArticlebymaincategory(drpMaincat, drpconst);
            this.dlinventory.drp_Dimensionbymaincategory(drpMaincat, dimension);
            dimension.SelectedValue = dataItem["DimensionID"].ToString();
            drpconst.SelectedValue = dataItem["ConstructionID"].ToString();
            drpitem.SelectedValue = dataItem["nItemcode"].ToString();
            drpordunt.SelectedValue = dataItem["cUnit"].ToString();
            box10.Text = dataItem["UnitConParam"].ToString();
            list3.SelectedValue = dataItem["ctype"].ToString().Trim();
            box11.Text = dataItem["nWst"].ToString();
            box12.Text = dataItem["nValue"].ToString();
            box13.Text = dataItem["nUprice"].ToString();
            box14.Text = dataItem["nCom"].ToString();
            box15.Text = dataItem["nOrdqty"].ToString();
            box8.Text = dataItem["nReqqty"].ToString();
            box9.Text = dataItem["cPlsmnt"].ToString();
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.Session["Uid"] == null)
        {
            base.Response.Redirect("Smt_Login.aspx", false);
        }
        else
        {
            Label lbl = (Label)base.Master.FindControl("lbltotalinfo");
            if (!base.IsPostBack)
            {
                this.Session["dtbom"] = null;
                this.Session["CopyBOM"] = null;
                this.bindStyleid();
                this.dlinventory.drp_Currencytype(this.drpCurrencytype);
                this.SetInitialRow();
                this.mybll.ClearErrormsg(this, lbl);
            }
            Thread.Sleep(200);
        }
    }

    private void SetInitialRow()
    {
        DataTable table = new DataTable();
        DataRow row = null;
        table.Columns.Add(new DataColumn("MainCatCode", typeof(string)));
        table.Columns.Add(new DataColumn("nItemcode", typeof(string)));
        table.Columns.Add(new DataColumn("ConstructionID", typeof(string)));
        table.Columns.Add(new DataColumn("DimensionID", typeof(string)));
        table.Columns.Add(new DataColumn("cUnit", typeof(string)));
        table.Columns.Add(new DataColumn("UnitConParam", typeof(string)));
        table.Columns.Add(new DataColumn("ctype", typeof(string)));
        table.Columns.Add(new DataColumn("param", typeof(string)));
        table.Columns.Add(new DataColumn("nCom", typeof(string)));
        table.Columns.Add(new DataColumn("nWst", typeof(string)));
        table.Columns.Add(new DataColumn("nUprice", typeof(string)));
        table.Columns.Add(new DataColumn("nValue", typeof(string)));
        table.Columns.Add(new DataColumn("nOrdqty", typeof(string)));
        table.Columns.Add(new DataColumn("nReqqty", typeof(string)));
        table.Columns.Add(new DataColumn("cPlsmnt", typeof(string)));
        for (int i = 0; i < 15; i++)
        {
            row = table.NewRow();
            row["MainCatCode"] = string.Empty;
            row["nItemcode"] = string.Empty;
            row["ConstructionID"] = string.Empty;
            row["DimensionID"] = string.Empty;
            row["cUnit"] = string.Empty;
            row["UnitConParam"] = string.Empty;
            row["ctype"] = string.Empty;
            row["param"] = string.Empty;
            row["nCom"] = string.Empty;
            row["nWst"] = string.Empty;
            row["nUprice"] = string.Empty;
            row["nValue"] = string.Empty;
            row["nOrdqty"] = string.Empty;
            row["nReqqty"] = string.Empty;
            row["cPlsmnt"] = string.Empty;
            table.Rows.Add(row);
        }
        this.ViewState["BOM"] = table;
        this.grdBOM.DataSource = table;
        this.grdBOM.DataBind();
    }

    private void SetPerviousBOM()
    {
        int num = 0;
        if (this.ViewState["BOM"] != null)
        {
            DataTable table = (DataTable)this.ViewState["BOM"];
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    DropDownList maincategory = (DropDownList)this.grdBOM.Rows[num].FindControl("drpBommaincategory");
                    DropDownList drpitem = (DropDownList)this.grdBOM.Rows[num].FindControl("drpItemdesc");
                    DropDownList list3 = (DropDownList)this.grdBOM.Rows[num].FindControl("drpBOmconstruction");
                    DropDownList list4 = (DropDownList)this.grdBOM.Rows[num].FindControl("drpBOMDimension");
                    DropDownList list5 = (DropDownList)this.grdBOM.Rows[num].FindControl("drpBomUnit");
                    DropDownList list6 = (DropDownList)this.grdBOM.Rows[num].FindControl("drpbomtype");
                    TextBox box = (TextBox)this.grdBOM.Rows[num].FindControl("txtUnitparam");
                    TextBox box2 = (TextBox)this.grdBOM.Rows[num].FindControl("txtParam");
                    TextBox box3 = (TextBox)this.grdBOM.Rows[num].FindControl("txtBOMconsumption");
                    TextBox box4 = (TextBox)this.grdBOM.Rows[num].FindControl("txtbomwst");
                    TextBox box5 = (TextBox)this.grdBOM.Rows[num].FindControl("txtbomrate");
                    TextBox box6 = (TextBox)this.grdBOM.Rows[num].FindControl("txtbomvalue");
                    TextBox box7 = (TextBox)this.grdBOM.Rows[num].FindControl("txtbomgmtqty");
                    TextBox box8 = (TextBox)this.grdBOM.Rows[num].FindControl("txtbomrequirement");
                    TextBox box9 = (TextBox)this.grdBOM.Rows[num].FindControl("txtBomplacement");
                    maincategory.SelectedValue = table.Rows[i]["MainCatCode"].ToString();
                    list5.SelectedValue = table.Rows[i]["cUnit"].ToString();
                    if (!string.IsNullOrEmpty(maincategory.SelectedValue))
                    {
                        this.dlinventory.drp_itemdescriptionbymaincat(maincategory, drpitem);
                    }
                    if (drpitem.Items.Count > 0)
                    {
                        drpitem.SelectedValue = table.Rows[i]["nItemcode"].ToString();
                    }
                    if (!string.IsNullOrEmpty(list6.SelectedValue))
                    {
                        list6.SelectedItem.Text = table.Rows[i]["ctype"].ToString().Trim();
                    }
                    list3.SelectedValue = table.Rows[i]["ConstructionID"].ToString().Trim();
                    list4.SelectedValue = table.Rows[i]["DimensionID"].ToString().Trim();
                    box.Text = table.Rows[i]["UnitConParam"].ToString();
                    box3.Text = table.Rows[i]["nCom"].ToString();
                    box4.Text = table.Rows[i]["nWst"].ToString();
                    box5.Text = table.Rows[i]["nUprice"].ToString();
                    box6.Text = table.Rows[i]["nValue"].ToString();
                    box7.Text = table.Rows[i]["nOrdqty"].ToString();
                    box8.Text = table.Rows[i]["nReqqty"].ToString();
                    box2.Text = "";
                    box9.Text = table.Rows[i]["cPlsmnt"].ToString();
                    num++;
                }
            }
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
