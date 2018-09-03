using AjaxControlToolkit;
using ASP;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Smt_Mer_BOM : System.Web.UI.Page
{
    private BLLInventory _blInv = new BLLInventory();
    //protected HtmlAnchor acolsen;
    //protected HtmlAnchor acontry;
    //protected HtmlAnchor adcons;
    //protected HtmlAnchor addimn;
    //protected HtmlAnchor addsuppl;
    //protected HtmlAnchor adsubcat;
    //protected HtmlAnchor aposen;
    //protected HtmlAnchor asizesen;
    //protected HtmlAnchor asuppo;
    //protected Button btnClear;
    //protected Button btnDatagenerate;
    //protected Button btnEdit;
    //protected ConfirmButtonExtender btnEdit_ConfirmButtonExtender1;
    //protected Button btnitmclr;
    //protected ImageButton btnLoadconstruction;
    //protected ImageButton btnLoadDimension;
    //protected ImageButton btnLoadmaincat;
    //protected ImageButton btnLoadsubcat;
    //protected ImageButton btnLoadsupplier;
    //protected Button btnppgntpo;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    //protected Button btnStyleref;
    //protected ModalPopupExtender Button2_ModalPopupExtender;
    //protected CheckBox chkcolor;
    //protected CheckBox chkcountry;
    //protected CheckBox chksz;
    private SqlConnection cn = GetWay.SpecFo_Inventorycon;
    private DALInventory dlinventory = new DALInventory();
    //protected DropDownList drpconsmunit;
    //protected DropDownList drpcosntruction;
    //protected DropDownList drpCurrency;
    //protected DropDownList drpDimension;
    //protected DropDownList drpMaincat;
    //protected DropDownList drpOrderunit;
    //protected DropDownList drpstyle;
    //protected DropDownList drpSubcat;
    //protected DropDownList drpSupplier;
    //protected Panel dvNewitem;
    //protected HtmlGenericControl dvposen;
    //protected FilteredTextBoxExtender FilteredTextBoxExtender1;
    //protected FilteredTextBoxExtender FilteredTextBoxExtender2;
    //protected GridView grdBOMitm;
    //protected Label Label1;
    //protected Label lblcolsensl;
    //protected Label lblcountrysensl;
    //protected Label lblermsg;
    //protected Label lblRowid;
    //protected Label lblszsl;
    //protected Label lblversion;
    private BLL mybll = new BLL();
    private DAL mycls = new DAL();
    //protected Panel Panel1;
    //protected RequiredFieldValidator RequiredFieldValidator10;
    //protected ValidatorCalloutExtender RequiredFieldValidator10_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator11;
    //protected ValidatorCalloutExtender RequiredFieldValidator11_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator12;
    //protected ValidatorCalloutExtender RequiredFieldValidator12_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator13;
    //protected ValidatorCalloutExtender RequiredFieldValidator13_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator14;
    //protected ValidatorCalloutExtender RequiredFieldValidator14_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator15;
    //protected ValidatorCalloutExtender RequiredFieldValidator15_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator6;
    //protected ValidatorCalloutExtender RequiredFieldValidator6_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator7;
    //protected ValidatorCalloutExtender RequiredFieldValidator7_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator8;
    //protected ValidatorCalloutExtender RequiredFieldValidator8_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator9;
    //protected ValidatorCalloutExtender RequiredFieldValidator9_ValidatorCalloutExtender;
    //protected TextBox txtBrand;
    //protected TextBox txtBuyer;
    //protected TextBox txtConsumption;
    //protected TextBox txtGmtdept;
    //protected TextBox txtGmttype;
    //protected TextBox txtLot;
    //protected FilteredTextBoxExtender txtOrderqty_FilteredTextBoxExtender;
    //protected TextBox txtordQty;
    //protected TextBox txtPlacement;
    //protected TextBox txtRate;
    //protected TextBox txtRemarks;
    //protected TextBox txtRequirement;
    //protected TextBox txtSEason;
    //protected TextBox txtUnitparam;
    //protected TextBox txtValue;
    //protected TextBox txtWstg;
    //protected UpdatePanel UpdatePanel1;

    public void bindArticle()
    {
        this.drpcosntruction.DataSource = this._blInv.get_InformationdataTable("select nArtCode,cArticle from Smt_Artcle where nMainCatID=" + this.drpMaincat.SelectedValue + " order by cArticle");
        this.drpcosntruction.DataTextField = "cArticle";
        this.drpcosntruction.DataValueField = "nArtCode";
        this.drpcosntruction.DataBind();
    }

    public void bindDimn()
    {
        this.drpDimension.DataSource = this._blInv.get_InformationdataTable("select ndCode,cDimen from Smt_Dimension where nMainCatID=" + this.drpMaincat.SelectedValue + " order by cDimen");
        this.drpDimension.DataTextField = "cDimen";
        this.drpDimension.DataValueField = "ndCode";
        this.drpDimension.DataBind();
    }

    public void bindMaincat(DropDownList drpMcat)
    {
        drpMcat.DataSource = this._blInv.get_Informationdataset("Sp_Smt_BOM_GetMainCatMarchentPurchase");
        drpMcat.DataTextField = "cMainCategory";
        drpMcat.DataValueField = "nMainCategory_ID";
        drpMcat.DataBind();
        drpMcat.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        drpMcat.SelectedIndex = 0;
    }

    public void bindordunit()
    {
        DataTable table = this._blInv.get_InformationdataTable("OrdUnit_getgroupunit " + this.drpSubcat.SelectedValue);
        this.drpOrderunit.DataSource = table;
        this.drpOrderunit.DataTextField = "cUnitDes";
        this.drpOrderunit.DataValueField = "nUnitID";
        this.drpOrderunit.DataBind();
        this.drpOrderunit.Items.Insert(0, string.Empty);
    }

    public void bindStyleid()
    {
        DataTable table = this.mybll.get_InformationdataTable("Sp_Smt_GetStyleID '" + this.Session["Uid"].ToString() + "','B'");
        this.drpstyle.Items.Add(new ListItem("", ""));
        this.drpstyle.DataSource = table;
        this.drpstyle.DataTextField = "StyleNO";
        this.drpstyle.DataValueField = "StyleID";
        this.drpstyle.DataBind();
        this.drpstyle.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpstyle.SelectedIndex = 0;
    }

    public void bindSubcat()
    {
        this.drpSubcat.DataSource = this._blInv.get_InformationdataTable("select cCode,cDes from Smt_SubCatagory where cManCode=" + this.drpMaincat.SelectedValue + " order by cDes");
        this.drpSubcat.DataTextField = "cDes";
        this.drpSubcat.DataValueField = "cCode";
        this.drpSubcat.DataBind();
    }

    public void bindsupplier()
    {
        this.drpSupplier.DataSource = this._blInv.get_InformationdataTable("Sp_Smt_getSupplierforMaincategory " + this.drpMaincat.SelectedValue);
        this.drpSupplier.DataTextField = "cSupName";
        this.drpSupplier.DataValueField = "SupplierID";
        this.drpSupplier.DataBind();
    }

    public void bindUnit()
    {
        this.drpOrderunit.DataSource = this._blInv.get_InformationdataTable("select nUnitID,cUnitDes from Smt_Unit order by cUnitDes");
        this.drpOrderunit.DataTextField = "cUnitDes";
        this.drpOrderunit.DataValueField = "nUnitID";
        this.drpOrderunit.DataBind();
    }

    public void bindversion(int version)
    {
        DataTable table = this._blInv.get_InformationdataTable(string.Concat(new object[] { "BOM_getBystylegenerated ", this.drpstyle.SelectedValue, ",", version }));
        if (table.Rows.Count > 0)
        {
            this.drpCurrency.SelectedIndex = 0;
            string str = table.Rows[0]["cCurtype"].ToString();
            if (!string.IsNullOrEmpty(str))
            {
                this.drpCurrency.SelectedValue = str;
            }
        }
    }

    public void bnditm(int version)
    {
        DataTable table = this._blInv.get_InformationdataTable(string.Concat(new object[] { "BOM_getBystyle ", this.drpstyle.SelectedValue, ",", version }));
        this.grdBOMitm.DataSource = table;
        this.grdBOMitm.DataBind();
        if (table.Rows.Count > 0)
        {
            this.drpCurrency.SelectedIndex = 0;
            string str = table.Rows[0]["cCurtype"].ToString();
            if (!string.IsNullOrEmpty(str))
            {
                this.drpCurrency.SelectedValue = str;
            }
        }
    }

    protected void btDltItem(object sender, EventArgs e)
    {
        GridViewRow parent = ((ImageButton)sender).Parent.Parent as GridViewRow;
        ImageButton button = (ImageButton)parent.FindControl("btnDelete");
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        SqlTransaction transaction = this.cn.BeginTransaction();
        try
        {
            SqlCommand command = new SqlCommand("BOM_Deleate", this.cn, transaction)
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@slno", button.CommandArgument);
            command.ExecuteNonQuery();
            transaction.Commit();
            label.Text = "Deleted Successfully";
            this.bnditm(1);
        }
        catch (Exception exception)
        {
            transaction.Rollback();
            this.lblermsg.Text = exception.Message;
        }
        finally
        {
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
        }
    }

    protected void btEditItem(object sender, EventArgs e)
    {
        this.chkcolor.Checked = true;
        this.chkcountry.Checked = false;
        this.chksz.Checked = false;
        this.chkcolor.Enabled = true;
        this.chkcountry.Enabled = true;
        this.chksz.Enabled = true;
        for (int i = 0; i < this.grdBOMitm.Rows.Count; i++)
        {
            if (this.grdBOMitm.Rows[i].Enabled)
            {
                this.grdBOMitm.Rows[i].BackColor = Color.Empty;
                this.grdBOMitm.Rows[i].ForeColor = Color.Black;
            }
        }
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        GridViewRow parent = ((ImageButton)sender).Parent.Parent as GridViewRow;
        ImageButton button = (ImageButton)parent.FindControl("btnEdit");
        this.lblRowid.Text = button.CommandArgument;
        this.btnSave.Visible = false;
        this.btnEdit.Visible = true;
        DataTable table = this._blInv.get_InformationdataTable("BOM_getByRowforEdit " + this.drpstyle.SelectedValue + "," + this.lblRowid.Text);
        if (table.Rows.Count > 0)
        {
            this.grdBOMitm.Rows[parent.RowIndex].BackColor = Color.FromName("#1E90B9");
            this.drpMaincat.SelectedValue = table.Rows[0]["MainCatCode"].ToString();
            this.bindSubcat();
            this.bindArticle();
            this.bindDimn();
            this.bindsupplier();
            this.bindordunit();
            this.drpSubcat.SelectedValue = table.Rows[0]["SubCatID"].ToString();
            this.drpcosntruction.SelectedValue = table.Rows[0]["ConstructionID"].ToString();
            this.drpDimension.SelectedValue = table.Rows[0]["DimensionID"].ToString();
            this.drpSupplier.SelectedValue = table.Rows[0]["nSup"].ToString();
            this.drpOrderunit.SelectedValue = table.Rows[0]["cUnit"].ToString();
            this.drpconsmunit.SelectedValue = table.Rows[0]["ctype"].ToString();
            this.txtConsumption.Text = table.Rows[0]["nCom"].ToString();
            this.txtWstg.Text = table.Rows[0]["nWst"].ToString();
            this.txtRate.Text = table.Rows[0]["nUprice"].ToString();
            this.txtValue.Text = table.Rows[0]["nValue"].ToString();
            this.txtRequirement.Text = table.Rows[0]["nReqqty"].ToString();
            this.txtRemarks.Text = table.Rows[0]["cremk"].ToString();
            this.txtPlacement.Text = table.Rows[0]["cPlsmnt"].ToString();
            this.chkcolor.Checked = bool.Parse(table.Rows[0]["bColSen"].ToString());
            this.chksz.Checked = bool.Parse(table.Rows[0]["bszSen"].ToString());
            this.txtUnitparam.Text = table.Rows[0]["UnitConParam"].ToString();
            this.chkcountry.Checked = bool.Parse(table.Rows[0]["Countrysen"].ToString());
            if (this.chksz.Checked)
            {
                DataTable table2 = this._blInv.get_InformationdataTable("BOM_sizesen_getslno " + this.drpstyle.SelectedValue + "," + this.drpMaincat.SelectedValue + "," + this.drpSubcat.SelectedValue + "," + this.drpcosntruction.SelectedValue + "," + this.drpDimension.SelectedValue + ",'" + this.txtPlacement.Text + "'");
                if (table2.Rows.Count > 0)
                {
                    this.lblszsl.Text = table2.Rows[0]["slno"].ToString();
                }
            }
            if (this.chkcolor.Checked)
            {
                DataTable table3 = this._blInv.get_InformationdataTable("BOM_colsen_getslno " + this.drpstyle.SelectedValue + "," + this.drpMaincat.SelectedValue + "," + this.drpSubcat.SelectedValue + "," + this.drpcosntruction.SelectedValue + "," + this.drpDimension.SelectedValue + ",'" + this.txtPlacement.Text + "'");
                if (table3.Rows.Count > 0)
                {
                    this.lblcolsensl.Text = table3.Rows[0]["slno"].ToString();
                }
            }
            if (this.chkcountry.Checked)
            {
                DataTable table4 = this._blInv.get_InformationdataTable("BOM_cuntrysen_getslno " + this.drpstyle.SelectedValue + "," + this.drpMaincat.SelectedValue + "," + this.drpSubcat.SelectedValue + "," + this.drpcosntruction.SelectedValue + "," + this.drpDimension.SelectedValue + ",'" + this.txtPlacement.Text + "'");
                if (table4.Rows.Count > 0)
                {
                    this.lblcountrysensl.Text = table4.Rows[0]["slno"].ToString();
                }
            }
            if (this.chkcolor.Checked || this.chksz.Checked)
            {
                this.chkcountry.Enabled = false;
            }
            if (this.chkcountry.Checked)
            {
                this.chkcolor.Enabled = false;
                this.chksz.Enabled = false;
            }
        }
    }

    protected void btnAddpnl_Click(object sender, EventArgs e)
    {
        this.dvNewitem.Visible = false;
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.lblRowid.Text = "";
        this.drpSupplier.Items.Clear();
        this.drpSubcat.Items.Clear();
        this.drpcosntruction.Items.Clear();
        this.drpDimension.Items.Clear();
        this.drpOrderunit.Items.Clear();
        this.drpconsmunit.SelectedIndex = 0;
        this.drpMaincat.SelectedIndex = 0;
        this.txtConsumption.Text = "";
        this.txtPlacement.Text = "";
        this.txtRate.Text = "";
        this.txtRemarks.Text = "";
        this.txtRequirement.Text = "";
        this.txtValue.Text = "";
        this.txtWstg.Text = "";
        this.chkcolor.Checked = false;
        this.chksz.Checked = false;
        this.chkcountry.Checked = false;
        this.lblermsg.Text = "";
        this.grdBOMitm.DataSource = null;
        this.grdBOMitm.DataBind();
        this.drpstyle.SelectedIndex = 0;
        this.dvNewitem.Enabled = false;
        this.btnSave.Visible = true;
        this.btnEdit.Visible = false;
        this.txtBrand.Text = "";
        this.txtBuyer.Text = "";
        this.txtGmtdept.Text = "";
        this.txtGmttype.Text = "";
        this.txtSEason.Text = "";
        this.txtordQty.Text = "";
        this.drpCurrency.SelectedIndex = 0;
        this.lblcolsensl.Text = "";
        this.lblcountrysensl.Text = "";
        this.lblszsl.Text = "";
    }

    protected void btnDatagenerate_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        if (this.grdBOMitm.Rows.Count > 0)
        {
            if (this.cn.State == ConnectionState.Closed)
            {
                this.cn.Open();
            }
            SqlTransaction transaction = this.cn.BeginTransaction();
            try
            {
                for (int i = 0; i < this.grdBOMitm.Rows.Count; i++)
                {
                    if (this.grdBOMitm.Rows[i].Enabled)
                    {
                        Label label2 = (Label)this.grdBOMitm.Rows[i].FindControl("lblmaincat");
                        Label label3 = (Label)this.grdBOMitm.Rows[i].FindControl("lblsubcat");
                        Label label4 = (Label)this.grdBOMitm.Rows[i].FindControl("lblconst");
                        Label label5 = (Label)this.grdBOMitm.Rows[i].FindControl("lbldimn");
                        Label label6 = (Label)this.grdBOMitm.Rows[i].FindControl("lblplacement");
                        CheckBox box = (CheckBox)this.grdBOMitm.Rows[i].FindControl("chkcol");
                        CheckBox box2 = (CheckBox)this.grdBOMitm.Rows[i].FindControl("chksz");
                        CheckBox box3 = (CheckBox)this.grdBOMitm.Rows[i].FindControl("chkcn");
                        string str = "0";
                        if (box.Checked)
                        {
                            str = "1";
                        }
                        string str2 = "0";
                        if (box2.Checked)
                        {
                            str2 = "1";
                        }
                        string str3 = "0";
                        if (box3.Checked)
                        {
                            str3 = "1";
                        }
                        SqlCommand command = new SqlCommand("BOM_DG", this.cn, transaction)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        command.Parameters.AddWithValue("@Styleid", this.drpstyle.SelectedValue);
                        command.Parameters.AddWithValue("@maincatid", label2.Text.Trim());
                        command.Parameters.AddWithValue("@subcatid", label3.Text.Trim());
                        command.Parameters.AddWithValue("@constructionid", label4.Text.Trim());
                        command.Parameters.AddWithValue("@dimensionid", label5.Text.Trim());
                        command.Parameters.AddWithValue("@placement", label6.Text.Trim());
                        command.Parameters.AddWithValue("@colsen", str);
                        command.Parameters.AddWithValue("@sizsen", str2);
                        command.Parameters.AddWithValue("@countrysen", str3);
                        command.ExecuteNonQuery();
                    }
                }
                transaction.Commit();
                this.runjQueryCode("window.open('Merchandising/BOM/datagnrt.aspx?x=" + this.drpstyle.SelectedValue + "','popup','location=1,status=1,left=right=0,top=0,scrollbars=1,width=970,height=600')");
            }
            catch (Exception exception)
            {
                transaction.Rollback();
                this.Label1.Text = exception.Message;
            }
            finally
            {
                if (this.cn.State == ConnectionState.Open)
                {
                    transaction.Dispose();
                    this.cn.Close();
                }
            }
        }
        else
        {
            label.Text = "Item(s) not available for this style";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        SqlTransaction transaction = this.cn.BeginTransaction();
        try
        {
            string str = "0";
            if (this.chksz.Checked)
            {
                str = "1";
            }
            string str2 = "0";
            if (this.chkcolor.Checked)
            {
                str2 = "1";
            }
            string str3 = "0";
            if (this.chkcountry.Checked)
            {
                str3 = "1";
            }
            SqlCommand command = new SqlCommand("BOM_update2", this.cn, transaction)
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@StyleID", this.drpstyle.SelectedValue);
            command.Parameters.AddWithValue("@cUnit", this.drpOrderunit.SelectedValue);
            command.Parameters.AddWithValue("@nCom", this.txtConsumption.Text);
            command.Parameters.AddWithValue("@nWst", this.txtWstg.Text);
            command.Parameters.AddWithValue("@nUprice", this.txtRate.Text);
            command.Parameters.AddWithValue("@nValue", this.txtValue.Text);
            command.Parameters.AddWithValue("@nSup", this.drpSupplier.SelectedValue);
            command.Parameters.AddWithValue("@ctype", this.drpconsmunit.SelectedValue);
            command.Parameters.AddWithValue("@nReqqty", this.txtRequirement.Text);
            command.Parameters.AddWithValue("@bszSen", str);
            command.Parameters.AddWithValue("@bColSen", str2);
            command.Parameters.AddWithValue("@cPlsmnt", this.txtPlacement.Text);
            command.Parameters.AddWithValue("@cremk", this.txtRemarks.Text);
            command.Parameters.AddWithValue("@MainCatCode", this.drpMaincat.SelectedValue);
            command.Parameters.AddWithValue("@SubCatID", this.drpSubcat.SelectedValue);
            command.Parameters.AddWithValue("@ConstructionID", this.drpcosntruction.SelectedValue);
            command.Parameters.AddWithValue("@DimensionID", this.drpDimension.SelectedValue);
            command.Parameters.AddWithValue("@nid", this.lblRowid.Text);
            command.Parameters.AddWithValue("@Countrysen", str3);
            command.Parameters.AddWithValue("@sizesenslall", this.lblszsl.Text);
            command.Parameters.AddWithValue("@colsenslall", this.lblcolsensl.Text);
            command.Parameters.AddWithValue("@cntrysenslall", this.lblcountrysensl.Text);
            command.ExecuteNonQuery();
            transaction.Commit();
            label.Text = "Updated Successfully";
            this.lblRowid.Text = "";
            this.drpSupplier.Items.Clear();
            this.drpSubcat.Items.Clear();
            this.drpcosntruction.Items.Clear();
            this.drpDimension.Items.Clear();
            this.drpOrderunit.Items.Clear();
            this.drpconsmunit.SelectedIndex = 0;
            this.drpMaincat.SelectedIndex = 0;
            this.txtConsumption.Text = "";
            this.txtPlacement.Text = "";
            this.txtRate.Text = "";
            this.txtRemarks.Text = "";
            this.txtRequirement.Text = "";
            this.txtValue.Text = "";
            this.txtWstg.Text = "";
            this.chkcolor.Checked = false;
            this.chksz.Checked = false;
            this.chkcountry.Checked = false;
            this.lblcolsensl.Text = "";
            this.lblcountrysensl.Text = "";
            this.lblszsl.Text = "";
            this.btnSave.Visible = true;
            this.btnEdit.Visible = false;
        }
        catch (Exception exception)
        {
            this.lblermsg.Text = exception.Message;
            transaction.Rollback();
        }
        finally
        {
            if (this.cn.State == ConnectionState.Open)
            {
                this.cn.Close();
            }
            this.bnditm(1);
        }
    }

    protected void btnitmclr_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.lblRowid.Text = "";
        this.drpSupplier.Items.Clear();
        this.drpSubcat.Items.Clear();
        this.drpcosntruction.Items.Clear();
        this.drpDimension.Items.Clear();
        this.drpOrderunit.Items.Clear();
        this.drpconsmunit.SelectedIndex = 0;
        this.drpMaincat.SelectedIndex = 0;
        this.txtConsumption.Text = "";
        this.txtPlacement.Text = "";
        this.txtRate.Text = "";
        this.txtRemarks.Text = "";
        this.txtRequirement.Text = "";
        this.txtValue.Text = "";
        this.txtWstg.Text = "";
        this.chkcolor.Checked = false;
        this.chksz.Checked = false;
        this.chkcountry.Checked = false;
        this.lblermsg.Text = "";
        this.lblcolsensl.Text = "";
        this.lblcountrysensl.Text = "";
        this.lblszsl.Text = "";
        this.btnEdit.Visible = false;
        this.btnSave.Visible = true;
    }

    protected void btnLoadconstruction_Click(object sender, ImageClickEventArgs e)
    {
        this.dlinventory.drp_ConstructionArticlebymaincategory(this.drpMaincat, this.drpcosntruction);
    }

    protected void btnLoadDimension_Click(object sender, ImageClickEventArgs e)
    {
        this.dlinventory.drp_itemdescriptionbymaincat(this.drpMaincat, this.drpSubcat);
    }

    protected void btnLoadmaincat_Click(object sender, ImageClickEventArgs e)
    {
        if (!string.IsNullOrEmpty(this.drpMaincat.SelectedValue))
        {
            this.dlinventory.drp_ConstructionArticlebymaincategory(this.drpMaincat, this.drpcosntruction);
            this.dlinventory.drp_itemdescriptionbymaincat(this.drpMaincat, this.drpSubcat);
            this.dlinventory.drp_Dimensionbymaincategory(this.drpMaincat, this.drpDimension);
            this.dlinventory.drp_SupplierforMaincategory1(this.drpMaincat, this.drpSupplier);
        }
    }

    protected void btnLoadsubcat_Click(object sender, ImageClickEventArgs e)
    {
        this.dlinventory.drp_itemdescriptionbymaincat(this.drpMaincat, this.drpSubcat);
    }

    protected void btnLoadsupplier_Click(object sender, ImageClickEventArgs e)
    {
        this.dlinventory.drp_SupplierforMaincategory1(this.drpMaincat, this.drpSupplier);
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        if (this._blInv.get_InformationdataTable("BOM_Save_checkedexist " + this.drpstyle.SelectedValue + "," + this.drpMaincat.SelectedValue + "," + this.drpSubcat.SelectedValue + "," + this.drpcosntruction.SelectedValue + "," + this.drpDimension.SelectedValue + ",'" + this.txtPlacement.Text + "'").Rows.Count > 0)
        {
            label.Text = "Already Exists";
        }
        else
        {
            if (this.cn.State == ConnectionState.Closed)
            {
                this.cn.Open();
            }
            SqlTransaction transaction = this.cn.BeginTransaction();
            try
            {
                string str = "0";
                if (this.chksz.Checked)
                {
                    str = "1";
                }
                string str2 = "0";
                if (this.chkcolor.Checked)
                {
                    str2 = "1";
                }
                string str3 = "0";
                if (this.chkcountry.Checked)
                {
                    str3 = "1";
                }
                SqlCommand command = new SqlCommand("BOM_Save1", this.cn, transaction)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@StyleID", this.drpstyle.SelectedValue);
                command.Parameters.AddWithValue("@cUnit", this.drpOrderunit.SelectedValue);
                command.Parameters.AddWithValue("@nCom", this.txtConsumption.Text);
                command.Parameters.AddWithValue("@nWst", this.txtWstg.Text);
                command.Parameters.AddWithValue("@nUprice", this.txtRate.Text);
                command.Parameters.AddWithValue("@nValue", this.txtValue.Text);
                command.Parameters.AddWithValue("@nSup", this.drpSupplier.SelectedValue);
                command.Parameters.AddWithValue("@cUser", this.Session["Uid"].ToString());
                command.Parameters.AddWithValue("@cCurtype", this.drpCurrency.SelectedValue);
                command.Parameters.AddWithValue("@ctype", this.drpconsmunit.SelectedValue);
                command.Parameters.AddWithValue("@nReqqty", this.txtRequirement.Text);
                command.Parameters.AddWithValue("@bszSen", str);
                command.Parameters.AddWithValue("@bColSen", str2);
                command.Parameters.AddWithValue("@cPlsmnt", this.txtPlacement.Text);
                command.Parameters.AddWithValue("@cremk", this.txtRemarks.Text);
                command.Parameters.AddWithValue("@MainCatCode", this.drpMaincat.SelectedValue);
                command.Parameters.AddWithValue("@SubCatID", this.drpSubcat.SelectedValue);
                command.Parameters.AddWithValue("@ConstructionID", this.drpcosntruction.SelectedValue);
                command.Parameters.AddWithValue("@DimensionID", this.drpDimension.SelectedValue);
                command.Parameters.AddWithValue("@Countrysen", str3);
                command.ExecuteNonQuery();
                transaction.Commit();
                if (this.cn.State == ConnectionState.Open)
                {
                    this.cn.Close();
                }
                this.bnditm(1);
                label.Text = "Saved Successfully";
            }
            catch (Exception exception)
            {
                transaction.Rollback();
                label.Text = exception.Message;
            }
            finally
            {
                if (this.cn.State == ConnectionState.Open)
                {
                    this.cn.Close();
                }
            }
        }
    }

    protected void btnStyleref_Click(object sender, EventArgs e)
    {
        this.drpstyle_SelectedIndexChanged(null, null);
    }

    protected void chkcolor_CheckedChanged(object sender, EventArgs e)
    {
        this.chkcountry.Enabled = true;
        if (this.chkcolor.Checked || this.chksz.Checked)
        {
            this.chkcountry.Enabled = false;
            this.chkcountry.Checked = false;
        }
    }

    protected void chkcountry_CheckedChanged(object sender, EventArgs e)
    {
        this.chkcolor.Enabled = true;
        this.chksz.Enabled = true;
        if (this.chkcountry.Checked)
        {
            this.chkcolor.Enabled = false;
            this.chksz.Enabled = false;
        }
    }

    protected void chksz_CheckedChanged(object sender, EventArgs e)
    {
        this.chkcountry.Enabled = true;
        if (this.chkcolor.Checked || this.chksz.Checked)
        {
            this.chkcountry.Enabled = false;
            this.chkcountry.Checked = false;
        }
    }

    protected void drpMaincat_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.drpOrderunit.Items.Clear();
        try
        {
            this.bindSubcat();
            if (!string.IsNullOrEmpty(this.drpSubcat.SelectedValue))
            {
                this.bindordunit();
            }
            this.bindArticle();
            this.bindDimn();
            this.bindsupplier();
        }
        catch (Exception exception)
        {
            label.Text = exception.Message;
        }
    }

    protected void drpOrderunit_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.txtUnitparam.Text = "";
        if (!string.IsNullOrEmpty(this.drpOrderunit.SelectedValue))
        {
            DataTable table = this._blInv.get_InformationdataTable("select nConPara from Smt_Unit where nUnitID=" + this.drpOrderunit.SelectedValue);
            this.txtUnitparam.Text = table.Rows[0]["nConPara"].ToString();
        }
    }

    protected void drpstyle_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        try
        {
            this.lblermsg.Text = "";
            this.dvNewitem.Enabled = false;
            this.btnEdit.Visible = false;
            this.btnSave.Visible = true;
            this.grdBOMitm.DataSource = null;
            this.grdBOMitm.DataBind();
            this.dvposen.Visible = false;
            if (!string.IsNullOrEmpty(this.drpstyle.SelectedValue))
            {
                DataTable table = this.mybll.get_InformationdataTable("Sp_Smt_StyleMaster_getmasterinfo " + this.drpstyle.SelectedValue);
                if (table.Rows.Count > 0)
                {
                    this.txtBuyer.Text = table.Rows[0]["cBuyer_Name"].ToString();
                    this.txtBrand.Text = table.Rows[0]["cBrand_Name"].ToString();
                    this.txtGmtdept.Text = table.Rows[0]["cGmt_Dept_Description"].ToString();
                    this.txtGmttype.Text = table.Rows[0]["cGmetDis"].ToString();
                    this.txtSEason.Text = table.Rows[0]["cSeason_Name"].ToString();
                    this.lblversion.Text = "1";
                    DataTable table2 = this._blInv.get_InformationdataTable("select isnull(max(cver),0) as cver from Smt_BOM where nstyCode=" + this.drpstyle.SelectedValue);
                    if (table2.Rows.Count > 0)
                    {
                        this.lblversion.Text = (int.Parse(table2.Rows[0]["cver"].ToString()) + 1).ToString();
                    }
                    DataTable table3 = this._blInv.get_InformationdataTable("BOM_PO_getttlqty " + this.drpstyle.SelectedValue);
                    if (table3.Rows.Count > 0)
                    {
                        this.txtordQty.Text = table3.Rows[0]["Qty"].ToString();
                        this.dvNewitem.Enabled = true;
                        this.bnditm(1);
                        this.btnEdit.Visible = false;
                        this.btnSave.Visible = true;
                    }
                    else
                    {
                        this.dvposen.Visible = true;
                        this.lblermsg.Text = "First Check PO Sensitivity";
                    }
                }
            }
        }
        catch (Exception exception)
        {
            label.Text = exception.Message;
        }
    }

    protected void drpSubcat_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.drpOrderunit.Items.Clear();
        if (!string.IsNullOrEmpty(this.drpSubcat.SelectedValue))
        {
            this.bindordunit();
        }
    }

    private string getjQueryCode(string jsCodetoRun)
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine("$(document).ready(function() {");
        builder.AppendLine(jsCodetoRun);
        builder.AppendLine(" });");
        return builder.ToString();
    }

    protected void grdBOMitm_PreRender(object sender, EventArgs e)
    {
        for (int i = 0; i < this.grdBOMitm.Rows.Count; i++)
        {
            Label label = (Label)this.grdBOMitm.Rows[i].FindControl("lblmaincat");
            Label label2 = (Label)this.grdBOMitm.Rows[i].FindControl("lblsubcat");
            Label label3 = (Label)this.grdBOMitm.Rows[i].FindControl("lblconst");
            Label label4 = (Label)this.grdBOMitm.Rows[i].FindControl("lbldimn");
            Label label5 = (Label)this.grdBOMitm.Rows[i].FindControl("lblplacement");
            if (this._blInv.get_InformationdataTable("BOM_DG_CheckEnabled " + this.drpstyle.SelectedValue + "," + label.Text + "," + label2.Text + "," + label3.Text + "," + label4.Text + ",'" + label5.Text + "'").Rows.Count > 0)
            {
                this.grdBOMitm.Rows[i].Enabled = false;
                this.grdBOMitm.Rows[i].BackColor = Color.FromName("#E9A2E9");
                this.grdBOMitm.Rows[i].ToolTip = "PO Raised for this item";
            }
        }
    }

    protected void grdBOMitm_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label label = (Label)e.Row.FindControl("lblmaincat");
            Label label2 = (Label)e.Row.FindControl("lblsubcat");
            Label label3 = (Label)e.Row.FindControl("lblconst");
            Label label4 = (Label)e.Row.FindControl("lbldimn");
            Label label5 = (Label)e.Row.FindControl("lblplacement");
            if (this._blInv.get_InformationdataTable("BOM_DG_CheckEnabled " + this.drpstyle.SelectedValue + "," + label.Text + "," + label2.Text + "," + label3.Text + "," + label4.Text + ",'" + label5.Text + "'").Rows.Count > 0)
            {
                e.Row.Enabled = false;
                e.Row.BackColor = Color.FromName("#E9A2E9");
                ImageButton button = (ImageButton)e.Row.FindControl("btnEdit");
                button.ImageUrl = "images/red_ok.png";
                button.ToolTip = "PO Raised for this item";
                ImageButton button2 = (ImageButton)e.Row.FindControl("btnDelete");
                button2.Visible = false;
            }
        }
    }

    public static void margePORaise(GridView gridView)
    {
        for (int i = gridView.Rows.Count - 2; i >= 0; i--)
        {
            GridViewRow row = gridView.Rows[i];
            GridViewRow row2 = gridView.Rows[i + 1];
            if (row.Cells[0].Text == row2.Cells[0].Text)
            {
                row.Cells[0].RowSpan = (row2.Cells[0].RowSpan < 2) ? 2 : (row2.Cells[0].RowSpan + 1);
                row2.Cells[0].Visible = false;
            }
            if (row.Cells[1].Text == row2.Cells[1].Text)
            {
                row.Cells[1].RowSpan = (row2.Cells[1].RowSpan < 2) ? 2 : (row2.Cells[1].RowSpan + 1);
                row2.Cells[1].Visible = false;
            }
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.Session["Uid"] == null)
        {
            base.Response.Redirect("Smt_Login.aspx", false);
        }
        else if (!base.IsPostBack)
        {
            this.bindMaincat(this.drpMaincat);
            this.bindUnit();
            this.bindStyleid();
            this.dlinventory.drp_Currencytype(this.drpCurrency);
        }
    }

    public void prm()
    {
        if (this.Session["Uid"].ToString().ToUpper() != "ADMIN")
        {
            HtmlAnchor[] anchorArray = new HtmlAnchor[] { this.adsubcat, this.adcons, this.addimn, this.addsuppl };
            for (int i = 0; i < anchorArray.Length; i++)
            {
                string innerText = anchorArray[i].InnerText;
                if (this.mybll.get_InformationdataTable("select Form_Name from Smt_UserPermittedform where User_ID='" + this.Session["Uid"].ToString() + "' and Form_Name='" + innerText + "'").Rows.Count < 1)
                {
                    anchorArray[i].Visible = false;
                }
            }
        }
    }

    private void runjQueryCode(string jsCodetoRun)
    {
        ScriptManager current = ScriptManager.GetCurrent(this);
        if ((current != null) && current.IsInAsyncPostBack)
        {
            ScriptManager.RegisterClientScriptBlock((Page)this, typeof(Page), Guid.NewGuid().ToString(), this.getjQueryCode(jsCodetoRun), true);
        }
        else
        {
            base.ClientScript.RegisterClientScriptBlock(typeof(Page), Guid.NewGuid().ToString(), this.getjQueryCode(jsCodetoRun), true);
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}