using AjaxControlToolkit;
using ASP;
using C1.Web.UI.Controls.C1GridView;
using C1.Web.UI.Controls.C1TabControl;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Smt_Mer_Stylemaster : System.Web.UI.Page
{
    private BLLInventory _blInventory = new BLLInventory();
    private MC _mc = new MC();
    //protected Button btnAddbrand;
    //protected Button btnAddbuyer;
    //protected Button btnAddgmtdept;
    //protected Button btnAddgmttype;
    //protected Button btnAddseason;
    //protected Button btnAddstore;
    //protected ImageButton btnaddtop;
    //protected Button btnClear;
    //protected ImageButton btnLoadBrand;
    //protected ImageButton btnLoadbyer;
    //protected ImageButton btnLoadFactory;
    //protected ImageButton btnLoadgmtdept;
    //protected ImageButton btnLoadGmttype;
    //protected ImageButton btnLoadseason;
    //protected ImageButton btnLoadStore;
    //protected ImageButton btnOK;
    //protected Button btnRename;
    //protected ModalPopupExtender btnRename_ModalPopupExtender;
    //protected Button btnRename0;
    //protected ModalPopupExtender btnRename0_ModalPopupExtender;
    //protected Button btnReport;
    //protected Button btnReportPI;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    //protected Button btntestmsg;
    //protected ImageButton btnupldcls;
    //protected Button btnUplod;
    //protected ModalPopupExtender btnUplod_ModalPopupExtender1;
    //protected C1.Web.UI.Controls.C1GridView.C1GridView C1GridView1;
    //protected C1.Web.UI.Controls.C1TabControl.C1TabControl C1TabControl1;
    //protected C1TabPage C1TabPage1;
    //protected C1TabPage C1TabPage2;
    //protected C1TabPage C1TabPage3;
    //protected C1TabPage C1TabPage4;
    //protected ImageButton cal1;
    //protected ImageButton cal2;
    //protected ImageButton cal3;
    //protected ToggleButtonExtender CheckBox1_ToggleButtonExtender;
    //protected CheckBox chkConfirmation;
    private SqlConnection cn = GetWay.SpecFoCon;
    //protected DropDownList drpBrand;
    //protected DropDownList drpBuyer;
    //protected DropDownList drpDivision;
    //protected DropDownList drpFactory;
    //protected DropDownList drpfob;
    //protected DropDownList drpGarmenttype;
    //protected DropDownList drpOts;
    //protected DropDownList drpSeason;
    //protected DropDownList drpStore;
    //protected DropDownList drpStyle;
    //protected HtmlGenericControl dvalrt;
    //protected FilteredTextBoxExtender fltr;
    //protected FilteredTextBoxExtender fltrefficiency;
    //protected FilteredTextBoxExtender fltrfob;
    //protected GridView grdDelivery;
    //protected C1.Web.UI.Controls.C1GridView.C1GridView grdPODtl;
    //protected GridView GridView1;
    //protected ImageButton ImageButton1;
    //protected Label Label1;
    //protected Label Label10;
    //protected Label Label12;
    //protected Label Label13;
    //protected Label Label2;
    //protected Label Label25;
    //protected Label Label27;
    //protected Label Label3;
    //protected Label Label31;
    //protected Label Label32;
    //protected Label Label33;
    //protected Label Label39;
    //protected Label Label4;
    //protected Label Label5;
    //protected Label Label6;
    //protected Label Label8;
    //protected Label lblAlertmsg;
    //protected Label lblstyleid;
    //protected ModalPopupExtender mdlAlertmsg;
    private BLL mybll = new BLL();
    private DAL mycls = new DAL();
    //protected RequiredFieldValidator RequiredFieldValidator12;
    //protected ValidatorCalloutExtender RequiredFieldValidator12_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator13;
    //protected ValidatorCalloutExtender RequiredFieldValidator13_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator14;
    //protected ValidatorCalloutExtender RequiredFieldValidator14_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator16;
    //protected ValidatorCalloutExtender RequiredFieldValidator16_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator19;
    //protected ValidatorCalloutExtender RequiredFieldValidator19_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator20;
    //protected ValidatorCalloutExtender RequiredFieldValidator20_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator21;
    //protected ValidatorCalloutExtender RequiredFieldValidator21_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator3;
    //protected ValidatorCalloutExtender RequiredFieldValidator3_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator4;
    //protected ValidatorCalloutExtender RequiredFieldValidator4_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator5;
    //protected ValidatorCalloutExtender RequiredFieldValidator5_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator6;
    //protected ValidatorCalloutExtender RequiredFieldValidator6_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator7;
    //protected ValidatorCalloutExtender RequiredFieldValidator7_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator8;
    //protected ValidatorCalloutExtender RequiredFieldValidator8_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator9;
    //protected ValidatorCalloutExtender RequiredFieldValidator9_ValidatorCalloutExtender;
    //protected TextBox txtBpcd;
    //protected CalendarExtender txtBpcd_CalendarExtender;
    //protected TextBox txtconfirmrcvd;
    //protected CalendarExtender txtconfirmrcvd_CalendarExtender;
    //protected TextBox txtContact;
    //protected TextBox txtfob;
    //protected TextBox txtOrderqty;
    //protected FilteredTextBoxExtender txtOrderqty_FilteredTextBoxExtender;
    //protected TextBox txtoriginalrcvd;
    //protected CalendarExtender txtoriginalrcvd_CalendarExtender;
    //protected TextBox txtplanefficiency;
    //protected TextBox txtsmv;
    //protected TextBox txtStid;
    //protected TextBox txtStyle;
    //protected TextBox txtTesttotal;
    //protected UpdatePanel UpdatePanel1;
    //protected UpdatePanel UpdatePanel2;
    //protected UpdatePanel UpdatePanel3;
    //protected UpdatePanel UpdatePanel4;
    //protected UpdatePanel UpdatePanel5;
    //protected UpdatePanel UpdatePanel6;
    //protected UpdatePanel UpdatePanel7;
    //protected UpdatePanel updViewEdit;

    private void AddNewRowToGrid()
    {
        int num = 0;
        if (this.ViewState["CurrentTable"] != null)
        {
            DataTable table = (DataTable)this.ViewState["CurrentTable"];
            DataRow row = null;
            if (table.Rows.Count > 0)
            {
                for (int i = 1; i <= table.Rows.Count; i++)
                {
                    TextBox box = (TextBox)this.grdDelivery.Rows[num].FindControl("txtlot");
                    TextBox box2 = (TextBox)this.grdDelivery.Rows[num].FindControl("txtpono");
                    TextBox box3 = (TextBox)this.grdDelivery.Rows[num].FindControl("txtttlqty");
                    DropDownList list = (DropDownList)this.grdDelivery.Rows[num].FindControl("drpshipmode");
                    TextBox box4 = (TextBox)this.grdDelivery.Rows[num].FindControl("txtFobdate");
                    TextBox box5 = (TextBox)this.grdDelivery.Rows[num].FindControl("txtprice");
                    TextBox box6 = (TextBox)this.grdDelivery.Rows[num].FindControl("txtXftydate");
                    Label label1 = (Label)this.grdDelivery.Rows[num].FindControl("lblttqty");
                    row = table.NewRow();
                    table.Rows[i - 1]["cOrderNu"] = box.Text;
                    table.Rows[i - 1]["cPoNum"] = box2.Text;
                    if (!string.IsNullOrEmpty(box3.Text))
                    {
                        table.Rows[i - 1]["nOrdQty"] = box3.Text;
                    }
                    else
                    {
                        table.Rows[i - 1]["nOrdQty"] = "0";
                    }
                    table.Rows[i - 1]["Cmode"] = list.SelectedValue;
                    table.Rows[i - 1]["DXfty"] = box4.Text;
                    if (!string.IsNullOrEmpty(box5.Text))
                    {
                        table.Rows[i - 1]["nfob"] = box5.Text;
                    }
                    else
                    {
                        table.Rows[i - 1]["nfob"] = "0";
                    }
                    if (!string.IsNullOrEmpty(box6.Text))
                    {
                        table.Rows[i - 1]["ShipDt"] = box6.Text;
                    }
                    else
                    {
                        table.Rows[i - 1]["ShipDt"] = DBNull.Value;
                    }
                    num++;
                }
                table.Rows.Add(row);
                this.ViewState["CurrentTable"] = table;
                this.grdDelivery.DataSource = table;
                this.grdDelivery.DataBind();
            }
        }
        else
        {
            base.Response.Write("ViewState is null");
        }
        this.SetPreviousData();
    }

    public void bind()
    {
        this.C1GridView1.DataSource = this.mybll.get_InformationdataTable("Sp_Smt_StyleMaster_GetAllbyUserGroup '" + this.Session["Uid"].ToString() + "'");
        this.C1GridView1.DataBind();
    }

    public void bindgrid()
    {
        this.C1GridView1.DataSource = this.mybll.get_InformationdataTable("Sp_Smt_StyleMaster_GetAllbyUserGroup '" + this.Session["Uid"].ToString() + "'");
        this.C1GridView1.DataBind();
    }

    public void bindgridPO()
    {
        this.grdPODtl.DataSource = this.mybll.get_InformationdataTable("Sp_Smt_StyleMaster_GetAllPObyUserGroup '" + this.Session["Uid"].ToString() + "'");
        this.grdPODtl.DataBind();
    }

    public void bindots()
    {
        DataTable table = this.mybll.get_InformationdataTable("Sp_Smt_TNA_Custom_getcustomname");
        this.drpOts.DataSource = table;
        this.drpOts.DataTextField = "CustomName";
        this.drpOts.DataValueField = "CustomName";
        this.drpOts.DataBind();
        this.drpOts.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpOts.SelectedIndex = 0;
    }

    public void bindpdtl()
    {
        this.grdPODtl.DataSource = this.mybll.get_InformationdataTable("Sp_Smt_StyleMaster_GetAllPObyUserGroup '" + this.Session["Uid"].ToString() + "'");
        this.grdPODtl.DataBind();
    }

    public void bindspecialoperation()
    {
        this.GridView1.DataSource = this.mycls.special_operation();
        this.GridView1.DataBind();
    }

    protected void btnAdd_Click(object sender, ImageClickEventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.AddNewRowToGrid();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        this.cleartext();
        this.SetInitialRow();
        this.bindspecialoperation();
        label.Text = "";
        this.txtTesttotal.Text = "0";
        this.lblstyleid.Text = "";
        this.txtOrderqty.Attributes.Add("style", "CssClass:textbox");
        this.btnSave.Text = "Save";
        this.btnSave.ToolTip = "Save";
        this.drpfob.SelectedValue = "FOB";
    }

    protected void btnLoadBrand_Click(object sender, ImageClickEventArgs e)
    {
        string selectedValue = this.drpBrand.SelectedValue;
        this.mycls.drp_Brand(this.drpBrand);
        if (!string.IsNullOrEmpty(selectedValue))
        {
            this.drpBrand.SelectedValue = selectedValue;
        }
    }

    protected void btnLoadbyer_Click(object sender, ImageClickEventArgs e)
    {
        string selectedValue = this.drpBuyer.SelectedValue;
        this.mycls.drp_Buyer(this.drpBuyer);
        if (!string.IsNullOrEmpty(selectedValue))
        {
            this.drpBuyer.SelectedValue = selectedValue;
        }
    }

    protected void btnLoadFactory_Click(object sender, ImageClickEventArgs e)
    {
        this.mycls.drp_Company(this.drpFactory);
    }

    protected void btnLoadgmtdept_Click(object sender, ImageClickEventArgs e)
    {
        string selectedValue = this.drpDivision.SelectedValue;
        this.mycls.drp_garmentdepartment(this.drpDivision);
        if (!string.IsNullOrEmpty(selectedValue))
        {
            this.drpDivision.SelectedValue = selectedValue;
        }
    }

    protected void btnLoadGmttype_Click(object sender, ImageClickEventArgs e)
    {
        string selectedValue = this.drpGarmenttype.SelectedValue;
        this.mycls.drp_garmenttype(this.drpGarmenttype);
        if (!string.IsNullOrEmpty(selectedValue))
        {
            this.drpGarmenttype.SelectedValue = selectedValue;
        }
    }

    protected void btnLoadseason_Click(object sender, ImageClickEventArgs e)
    {
        string selectedValue = this.drpSeason.SelectedValue;
        this.mycls.drp_season(this.drpSeason);
        if (!string.IsNullOrEmpty(selectedValue))
        {
            this.drpSeason.SelectedValue = selectedValue;
        }
    }

    protected void btnLoadStore_Click(object sender, ImageClickEventArgs e)
    {
        string selectedValue = this.drpStore.SelectedValue;
        this.mycls.drp_store(this.drpStore);
        if (!string.IsNullOrEmpty(selectedValue))
        {
            this.drpStore.SelectedValue = selectedValue;
        }
    }

    protected void btnOK_Click(object sender, ImageClickEventArgs e)
    {
        this.C1GridView1.DataBind();
        this.grdPODtl.DataBind();
    }

    protected void btnRemove_Click(object sender, ImageClickEventArgs e)
    {
        Label lbl = (Label)base.Master.FindControl("lbltotalinfo");
        lbl.Text = "";
        GridViewRow parent = ((ImageButton)sender).Parent.Parent as GridViewRow;
        TextBox box = (TextBox)parent.FindControl("txtlot");
        if (!string.IsNullOrEmpty(this.lblstyleid.Text))
        {
            DataTable table = this._blInventory.get_InformationdataTable("select clots from Smt_BOM where nstyCode=" + this.lblstyleid.Text.Trim() + " and  cver=1");
            if (table.Rows.Count <= 0)
            {
                if (this.grdDelivery.Rows.Count <= 1)
                {
                    this.lblAlertmsg.Text = "Only one PO you can't delete.";
                    this.mdlAlertmsg.Show();
                }
                else
                {
                    if (!string.IsNullOrEmpty(this.lblstyleid.Text))
                    {
                        this.mycls.SaveOrdermasterLog(int.Parse(this.lblstyleid.Text.Trim()), this.txtStyle.Text.Trim(), this.Session["Uid"].ToString(), box.Text);
                        this.mycls.Delete_Ordermaster(int.Parse(this.lblstyleid.Text), box.Text, lbl);
                    }
                    this.checktotalwhenremoverow();
                    GridViewRow row3 = ((ImageButton)sender).Parent.Parent as GridViewRow;
                    if ((this.ViewState["CurrentTable"] != null) && (this.grdDelivery.Rows.Count > 1))
                    {
                        DataTable table3 = (DataTable)this.ViewState["CurrentTable"];
                        table3.Rows.RemoveAt(row3.RowIndex);
                        this.grdDelivery.DataSource = table3;
                        this.grdDelivery.DataBind();
                        this.SetPreviousData();
                    }
                }
            }
            else
            {
                string str = table.Rows[0]["clots"].ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    if (str.Split(new char[] { '/' }).Contains<string>(box.Text))
                    {
                        this.lblAlertmsg.Text = "BOM already created for this PO .For deleting this PO you need to uncheck this PO from BOM PO Sensitivity tab and save again.";
                        this.mdlAlertmsg.Show();
                    }
                    else if (this.grdDelivery.Rows.Count <= 1)
                    {
                        this.lblAlertmsg.Text = "Only one PO you can't delete.";
                        this.mdlAlertmsg.Show();
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(this.lblstyleid.Text))
                        {
                            this.mycls.SaveOrdermasterLog(int.Parse(this.lblstyleid.Text.Trim()), this.txtStyle.Text.Trim(), this.Session["Uid"].ToString(), box.Text);
                            this.mycls.Delete_Ordermaster(int.Parse(this.lblstyleid.Text), box.Text, lbl);
                        }
                        this.checktotalwhenremoverow();
                        GridViewRow row2 = ((ImageButton)sender).Parent.Parent as GridViewRow;
                        if ((this.ViewState["CurrentTable"] != null) && (this.grdDelivery.Rows.Count > 1))
                        {
                            DataTable table2 = (DataTable)this.ViewState["CurrentTable"];
                            table2.Rows.RemoveAt(row2.RowIndex);
                            this.grdDelivery.DataSource = table2;
                            this.grdDelivery.DataBind();
                            this.SetPreviousData();
                        }
                    }
                }
            }
        }
        else
        {
            this.checktotalwhenremoverow();
            GridViewRow row4 = ((ImageButton)sender).Parent.Parent as GridViewRow;
            if (this.ViewState["CurrentTable"] != null)
            {
                if (this.grdDelivery.Rows.Count > 1)
                {
                    DataTable table4 = (DataTable)this.ViewState["CurrentTable"];
                    table4.Rows.RemoveAt(row4.RowIndex);
                    this.grdDelivery.DataSource = table4;
                    this.grdDelivery.DataBind();
                    this.SetPreviousData();
                }
                else
                {
                    this.lblAlertmsg.Text = "Only one PO you can't delete.";
                    this.mdlAlertmsg.Show();
                }
            }
        }
    }

    protected void btnReport_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        if (!string.IsNullOrEmpty(this.lblstyleid.Text))
        {
            this.Session["Param"] = "StyleNo";
            this.Session["stid"] = this.lblstyleid.Text;
            this.runjQueryCode("window.open('Report_Merchandising/Smt_MerchandisingReport.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
        }
        else
        {
            label.Text = "First Select Style";
        }
    }

    protected void btnReportPI_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        if (!string.IsNullOrEmpty(this.lblstyleid.Text))
        {
            this.Session["Param"] = "StyleNoPI";
            this.Session["stid"] = this.lblstyleid.Text;
            this.runjQueryCode("window.open('Report_Merchandising/Smt_MerchandisingReport.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
        }
        else
        {
            label.Text = "First Select Style";
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        this.cn.Open();
        SqlTransaction transaction = this.cn.BeginTransaction();
        try
        {
            string str = "DEV";
            if (this.chkConfirmation.Checked)
            {
                str = "CONF";
            }
            SqlCommand command = new SqlCommand("Sp_Smt_StyleMaster_Save1", this.cn, transaction)
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@cStyleNo_2", this.txtStyle.Text);
            command.Parameters.AddWithValue("@cDispStyleNo_3", this.txtContact.Text);
            command.Parameters.AddWithValue("@nGmtType_4", this.drpGarmenttype.SelectedValue);
            command.Parameters.AddWithValue("@nTotOrdQty_5", this.txtOrderqty.Text);
            command.Parameters.AddWithValue("@nAcct_6", this.drpBuyer.SelectedValue);
            command.Parameters.AddWithValue("@cInputUser_7", this.Session["Uid"].ToString());
            command.Parameters.AddWithValue("@nSeason_10", this.drpSeason.SelectedValue);
            command.Parameters.AddWithValue("@nBran_12", this.drpBrand.SelectedValue);
            command.Parameters.AddWithValue("@nstore", this.drpStore.SelectedValue);
            command.Parameters.AddWithValue("@cdept", this.drpDivision.SelectedValue);
            command.Parameters.AddWithValue("@cType", this.drpStyle.SelectedValue);
            command.Parameters.AddWithValue("@dOOshtRec", this.txtoriginalrcvd.Text);
            command.Parameters.AddWithValue("@dCOShtRec", this.txtconfirmrcvd.Text);
            command.Parameters.AddWithValue("@cCmp", this.drpFactory.SelectedValue);
            command.Parameters.AddWithValue("@nFob", this.txtfob.Text);
            command.Parameters.AddWithValue("@bpcd", this.txtBpcd.Text);
            command.Parameters.AddWithValue("@ConfirmStatus", str);
            command.Parameters.AddWithValue("@Fobmode", this.drpfob.SelectedValue);
            command.ExecuteNonQuery();
            for (int i = 0; i < this.grdDelivery.Rows.Count; i++)
            {
                TextBox box = (TextBox)this.grdDelivery.Rows[i].FindControl("txtlot");
                TextBox box2 = (TextBox)this.grdDelivery.Rows[i].FindControl("txtpono");
                TextBox box3 = (TextBox)this.grdDelivery.Rows[i].FindControl("txtttlqty");
                DropDownList list = (DropDownList)this.grdDelivery.Rows[i].FindControl("drpshipmode");
                if ((!string.IsNullOrEmpty(box.Text) && !string.IsNullOrEmpty(box2.Text)) && !string.IsNullOrEmpty(box3.Text))
                {
                    TextBox box4 = (TextBox)this.grdDelivery.Rows[i].FindControl("txtFobdate");
                    TextBox box5 = (TextBox)this.grdDelivery.Rows[i].FindControl("txtXftydate");
                    TextBox box6 = (TextBox)this.grdDelivery.Rows[i].FindControl("txtprice");
                    SqlCommand command2 = new SqlCommand("Sp_Smt_OrdersMaster_Save", this.cn, transaction)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    command2.Parameters.AddWithValue("@nOStyleId_1", this.txtStyle.Text);
                    command2.Parameters.AddWithValue("@cOrderNu_2", box.Text);
                    command2.Parameters.AddWithValue("@nOrdQty_3", box3.Text);
                    command2.Parameters.AddWithValue("@cPoNum_4", box2.Text);
                    command2.Parameters.AddWithValue("@mode", list.SelectedValue);
                    command2.Parameters.AddWithValue("@xfty", box4.Text);
                    command2.Parameters.AddWithValue("@npack", "0");
                    command2.Parameters.AddWithValue("@nratio", "0");
                    command2.Parameters.AddWithValue("@nfob", box6.Text);
                    command2.Parameters.AddWithValue("@ShipDt", box5.Text);
                    command2.ExecuteNonQuery();
                }
            }
            SqlCommand command3 = new SqlCommand("SpInsSmtStySpOp_Delete", this.cn, transaction)
            {
                CommandType = CommandType.StoredProcedure
            };
            command3.Parameters.AddWithValue("@csty", this.txtStyle.Text);
            command3.ExecuteNonQuery();
            for (int j = 0; j < this.GridView1.Rows.Count; j++)
            {
                Label label2 = (Label)this.GridView1.Rows[j].FindControl("lblid");
                Label label1 = (Label)this.GridView1.Rows[j].FindControl("lbldescription");
                CheckBox box7 = (CheckBox)this.GridView1.Rows[j].FindControl("chkSelect");
                if (box7.Checked)
                {
                    SqlCommand command4 = new SqlCommand("SpInsSmtStySpOp", this.cn, transaction)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    command4.Parameters.AddWithValue("@csty", this.txtStyle.Text);
                    command4.Parameters.AddWithValue("@nSpId_2", label2.Text);
                    command4.Parameters.AddWithValue("@cEntUSer_3", this.Session["Uid"].ToString());
                    command4.ExecuteNonQuery();
                }
            }
            if (!string.IsNullOrEmpty(this.drpOts.SelectedValue))
            {
                SqlCommand command5 = new SqlCommand("Sp_smt_OTSmrgstyle", this.cn, transaction)
                {
                    CommandType = CommandType.StoredProcedure,
                    //CommandType = CommandType.StoredProcedure
                };
                command5.Parameters.AddWithValue("@styleno", this.txtStyle.Text);
                command5.Parameters.AddWithValue("@CustomName", this.drpOts.SelectedValue);
                command5.ExecuteNonQuery();
            }
            transaction.Commit();
            label.Text = "Saved Successfully";
            this.cleartext();
            this.SetInitialRow();
            this.bind();
            this.bindpdtl();
            this.btnSave.Text = "Save";
            this.btnSave.ToolTip = "Save";
        }
        catch (Exception exception)
        {
            transaction.Rollback();
            label.Text = exception.Message;
        }
        finally
        {
            this.cn.Close();
        }
    }

    protected void C1GridView1_Filtering(object sender, C1GridViewFilterEventArgs e)
    {
        this.bind();
    }

    protected void C1GridView1_PageIndexChanging(object sender, C1GridViewPageEventArgs e)
    {
        this.C1GridView1.PageIndex = e.NewPageIndex;
        this.bind();
    }

    protected void C1GridView1_RowCommand(object sender, C1GridViewCommandEventArgs e)
    {
        Label label1 = (Label)base.Master.FindControl("lbltotalinfo");
        if (e.CommandName == "Select")
        {
            int num = int.Parse(e.CommandArgument.ToString());
            string styleNo = this.C1GridView1.Rows[num].Cells[2].Text.Trim();
            this.stle(styleNo);
            this.C1TabControl1.MoveFirst();
        }
    }

    protected void C1GridView1_RowDataBound(object sender, C1GridViewRowEventArgs e)
    {
        if (e.Row.RowType == C1GridViewRowType.DataRow)
        {
            e.Row.Cells[0].Attributes.Add("style", "padding-left:5px;padding-right:5px;color:red");
        }
    }

    protected void C1GridView1_Sorting(object sender, C1GridViewSortEventArgs e)
    {
        this.bind();
    }

    public void checktotalwhenremoverow()
    {
        int num = 0;
        DataTable table = (DataTable)this.ViewState["CurrentTable"];
        if (table.Rows.Count > 0)
        {
            for (int i = 1; i <= table.Rows.Count; i++)
            {
                TextBox box = (TextBox)this.grdDelivery.Rows[num].FindControl("txtlot");
                TextBox box2 = (TextBox)this.grdDelivery.Rows[num].FindControl("txtpono");
                TextBox box3 = (TextBox)this.grdDelivery.Rows[num].FindControl("txtttlqty");
                DropDownList list = (DropDownList)this.grdDelivery.Rows[num].FindControl("drpshipmode");
                TextBox box4 = (TextBox)this.grdDelivery.Rows[num].FindControl("txtFobdate");
                TextBox box5 = (TextBox)this.grdDelivery.Rows[num].FindControl("txtprice");
                TextBox box6 = (TextBox)this.grdDelivery.Rows[num].FindControl("txtXftydate");
                table.NewRow();
                table.Rows[i - 1]["cOrderNu"] = box.Text;
                table.Rows[i - 1]["cPoNum"] = box2.Text;
                if (!string.IsNullOrEmpty(box3.Text))
                {
                    table.Rows[i - 1]["nOrdQty"] = box3.Text;
                }
                else
                {
                    table.Rows[i - 1]["nOrdQty"] = DBNull.Value;
                }
                table.Rows[i - 1]["Cmode"] = list.SelectedValue;
                if (!string.IsNullOrEmpty(box4.Text))
                {
                    table.Rows[i - 1]["DXfty"] = box4.Text;
                }
                else
                {
                    table.Rows[i - 1]["DXfty"] = DBNull.Value;
                }
                if (!string.IsNullOrEmpty(box5.Text))
                {
                    table.Rows[i - 1]["nfob"] = box5.Text;
                }
                else
                {
                    table.Rows[i - 1]["nfob"] = DBNull.Value;
                }
                if (!string.IsNullOrEmpty(box6.Text))
                {
                    table.Rows[i - 1]["ShipDt"] = box6.Text;
                }
                else
                {
                    table.Rows[i - 1]["ShipDt"] = DBNull.Value;
                }
                num++;
            }
            this.ViewState["CurrentTable"] = table;
            this.grdDelivery.DataSource = table;
            this.grdDelivery.DataBind();
        }
    }

    public void cleartext()
    {
        this.drpBrand.SelectedValue = "";
        this.drpBuyer.SelectedValue = "";
        this.drpDivision.SelectedValue = "";
        this.drpFactory.SelectedValue = "";
        this.drpGarmenttype.SelectedValue = "";
        this.drpSeason.SelectedValue = "";
        this.drpStore.SelectedValue = "";
        this.drpStyle.SelectedValue = "";
        this.txtBpcd.Text = "";
        this.txtconfirmrcvd.Text = "";
        this.txtContact.Text = "";
        this.txtfob.Text = "";
        this.txtOrderqty.Text = "";
        this.txtoriginalrcvd.Text = "";
        this.txtplanefficiency.Text = "";
        this.txtsmv.Text = "";
        this.txtStyle.Text = "";
        this.txtStyle.Enabled = true;
        this.txtContact.Enabled = true;
        this.txtconfirmrcvd.Text = DateTime.Now.Date.ToString("dd-MMM-yyyy");
        this.txtoriginalrcvd.Text = DateTime.Now.Date.ToString("dd-MMM-yyyy");
        this.txtBpcd.Text = DateTime.Now.Date.ToString("dd-MMM-yyyy");
        this.btnSave.Text = "Update";
        this.btnSave.ToolTip = "Update";
        this.lblstyleid.Text = "";
        this.chkConfirmation.Checked = false;
        this.chkConfirmation.Enabled = true;
        this.Session["po"] = "no";
        this.bind();
        this.txtStid.Text = "";
        this.dvalrt.Visible = false;
        this.btnSave.Visible = true;
    }

    private string getjQueryCode(string jsCodetoRun)
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine("$(document).ready(function() {");
        builder.AppendLine(jsCodetoRun);
        builder.AppendLine(" });");
        return builder.ToString();
    }

    protected void grdDelivery_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        int num = 0;
        for (int i = 0; i < this.grdDelivery.Rows.Count; i++)
        {
            int num3 = 0;
            TextBox box = (TextBox)this.grdDelivery.Rows[i].FindControl("txtttlqty");
            if (!string.IsNullOrEmpty(box.Text))
            {
                num3 = int.Parse(box.Text);
                num += num3;
            }
        }
        this.txtTesttotal.Text = num.ToString();
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            int num5 = e.Row.RowIndex + 1;
            TextBox box2 = (TextBox)e.Row.FindControl("txtlot");
            TextBox box3 = (TextBox)e.Row.FindControl("txtpono");
            TextBox box4 = (TextBox)e.Row.FindControl("txtttlqty");
            TextBox box5 = (TextBox)e.Row.FindControl("txtprice");
            Label label = (Label)e.Row.FindControl("lblInseamQty");
            Label label1 = (Label)e.Row.FindControl("lblttqty");
            ImageButton button = (ImageButton)e.Row.FindControl("cal4");
            TextBox box1 = (TextBox)e.Row.FindControl("txtXftydate");
            TextBox box6 = (TextBox)e.Row.FindControl("txtFobdate");
            CalendarExtender extender = (CalendarExtender)e.Row.FindControl("txtshipdate_CalendarExtender");
            if (!string.IsNullOrEmpty(box2.Text.Trim()))
            {
                DataTable table = this.mybll.get_InformationdataTable("Sp_Smt_PackContry_getLotQty " + this.lblstyleid.Text.Trim() + ",'" + box2.Text + "'");
                if (!string.IsNullOrEmpty(table.Rows[0]["nRtot"].ToString()))
                {
                    label.Text = table.Rows[0]["nRtot"].ToString();
                }
                else
                {
                    label.Text = "0";
                }
            }
            button.Attributes.Add("onfocus", "javascript:ShowCalendar4('" + extender.ClientID + "')");
            box2.Attributes.Add("onblur", "javascript:return trgval('" + this.grdDelivery.ClientID + "')");
            box4.Attributes.Add("onblur", string.Concat(new object[] { "javascript:checktotQty('", num5, "','", this.grdDelivery.ClientID, "','", this.txtOrderqty.ClientID, "','", this.txtfob.ClientID, "','", box3.ClientID, "')" }));
            ImageButton button2 = (ImageButton)e.Row.FindControl("calshdt");
            button2.Attributes.Add("OnClick", string.Concat(new object[] { "javascript:oncliccick('", this.grdDelivery.ClientID, "','", num5, "')" }));
            if (!string.IsNullOrEmpty(this.lblstyleid.Text.Trim()) && (this._blInventory.get_InformationdataTable("select cLot from Smt_StyleWisePOByMCat_Item where nStyID=" + this.lblstyleid.Text.Trim() + " and cLot='" + box2.Text + "' and bpntpo=1").Rows.Count > 0))
            {
                button.Enabled = true;
                box2.Enabled = false;
                box5.Enabled = true;
                box3.Enabled = false;
                box4.Enabled = false;
                e.Row.BackColor = Color.Pink;
                e.Row.ToolTip = "PO raised for this Lot";
                this.dvalrt.Visible = true;
                if (box3.Text.ToUpper() == "TBC")
                {
                    box4.Enabled = true;
                }
            }
        }
        if (e.Row.RowType == DataControlRowType.Footer)
        {
            e.Row.Cells[2].Text = num.ToString();
            e.Row.Cells[1].Attributes.Add("style", "text-align:right");
            e.Row.Cells[1].Text = "Total Quantity";
            e.Row.Cells[3].Text = "Balance Qty";
            e.Row.Cells[2].Attributes.Add("style", "text-align:left");
            e.Row.Cells[3].Attributes.Add("style", "text-align:right");
            e.Row.Cells[4].Attributes.Add("style", "text-align:left");
            e.Row.Cells[4].Text = "0";
            if (!string.IsNullOrEmpty(this.txtOrderqty.Text))
            {
                e.Row.Cells[4].Text = (int.Parse(this.txtOrderqty.Text) - num).ToString();
            }
        }
    }

    protected void grdPODtl_Filtering(object sender, C1GridViewFilterEventArgs e)
    {
        this.bindpdtl();
    }

    protected void grdPODtl_PageIndexChanging(object sender, C1GridViewPageEventArgs e)
    {
        this.grdPODtl.PageIndex = e.NewPageIndex;
        this.bindpdtl();
    }

    protected void grdPODtl_PreRender(object sender, EventArgs e)
    {
        MergeRowsPackwise(this.grdPODtl);
    }

    protected void grdPODtl_RowCommand(object sender, C1GridViewCommandEventArgs e)
    {
        Label label1 = (Label)base.Master.FindControl("lbltotalinfo");
        if (e.CommandName == "Select")
        {
            int num = int.Parse(e.CommandArgument.ToString());
            string text = this.grdPODtl.Rows[num].Cells[2].Text;
            this.stle(text);
            this.C1TabControl1.MoveFirst();
        }
    }

    protected void grdPODtl_RowDataBound(object sender, C1GridViewRowEventArgs e)
    {
        if (e.Row.RowType == C1GridViewRowType.DataRow)
        {
            e.Row.Cells[0].Attributes.Add("style", "padding-left:5px;padding-right:7px;color:green");
        }
    }

    protected void grdPODtl_Sorting(object sender, C1GridViewSortEventArgs e)
    {
        this.bindpdtl();
    }

    public static void MergeRowsPackwise(C1.Web.UI.Controls.C1GridView.C1GridView gridView)
    {
        for (int i = gridView.Rows.Count - 2; i >= 0; i--)
        {
            C1GridViewRow row = gridView.Rows[i];
            C1GridViewRow row2 = gridView.Rows[i + 1];
            if (row.Cells[1].Text == row2.Cells[1].Text)
            {
                row.Cells[1].RowSpan = (row2.Cells[1].RowSpan < 2) ? 2 : (row2.Cells[1].RowSpan + 1);
                row2.Cells[1].Visible = false;
            }
            if (row.Cells[2].Text == row2.Cells[2].Text)
            {
                row.Cells[2].RowSpan = (row2.Cells[2].RowSpan < 2) ? 2 : (row2.Cells[2].RowSpan + 1);
                row2.Cells[2].Visible = false;
                row.Cells[0].RowSpan = (row2.Cells[0].RowSpan < 2) ? 2 : (row2.Cells[0].RowSpan + 1);
                row2.Cells[0].Visible = false;
                row.Cells[3].RowSpan = (row2.Cells[3].RowSpan < 2) ? 2 : (row2.Cells[3].RowSpan + 1);
                row2.Cells[3].Visible = false;
                row.Cells[4].RowSpan = (row2.Cells[4].RowSpan < 2) ? 2 : (row2.Cells[4].RowSpan + 1);
                row2.Cells[4].Visible = false;
                row.Cells[5].RowSpan = (row2.Cells[5].RowSpan < 2) ? 2 : (row2.Cells[5].RowSpan + 1);
                row2.Cells[5].Visible = false;
            }
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
                string[] strArray = base.Request.FilePath.ToString().Split(new char[] { '/' });
                int index = strArray.Length - 1;
                string text1 = strArray[index];
                this.Session["po"] = "no";
                this.SetInitialRow();
                this.bindspecialoperation();
                this.mycls.drp_Buyer(this.drpBuyer);
                this.mycls.drp_Company(this.drpFactory);
                this.mycls.drp_garmentdepartment(this.drpDivision);
                this.mycls.drp_Brand(this.drpBrand);
                this.mycls.drp_season(this.drpSeason);
                this.mycls.drp_store(this.drpStore);
                this.mycls.drp_styletype(this.drpStyle);
                this.mycls.drp_garmenttype(this.drpGarmenttype);
                this.txtconfirmrcvd.Text = DateTime.Now.Date.ToString("dd-MMM-yyyy");
                this.txtoriginalrcvd.Text = DateTime.Now.Date.ToString("dd-MMM-yyyy");
                this.txtBpcd.Text = DateTime.Now.Date.ToString("dd-MMM-yyyy");
                this.txtStyle.Focus();
                this.mybll.ClearErrormsg(this, lbl);
                this.bind();
                this.bindots();
                Control[] btnall = new Control[0];
                Control[] addbtn = new Control[] { this.btnAddbrand, this.btnAddbuyer, this.btnAddgmtdept, this.btnAddgmttype, this.btnAddseason, this.btnAddstore };
                this.mycls.SetBtnPermission(this.Session["Uid"].ToString(), btnall, addbtn, "Smt_Mer_Stylemaster.aspx");
            }
            this.txtfob.Attributes.Add("onkeyup", "javascript:SetUpriceforGrid('" + this.grdDelivery.ClientID + "','" + this.txtfob.ClientID + "')");
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

    private void SetInitialRow()
    {
        DataTable table = new DataTable();
        DataRow row = null;
        table.Columns.Add(new DataColumn("cOrderNu", typeof(string)));
        table.Columns.Add(new DataColumn("cPoNum", typeof(string)));
        table.Columns.Add(new DataColumn("nOrdQty", typeof(string)));
        table.Columns.Add(new DataColumn("Cmode", typeof(string)));
        table.Columns.Add(new DataColumn("DXfty", typeof(string)));
        table.Columns.Add(new DataColumn("nfob", typeof(string)));
        table.Columns.Add(new DataColumn("ShipDt", typeof(string)));
        row = table.NewRow();
        for (int i = 0; i < 12; i++)
        {
            row = table.NewRow();
            row["cOrderNu"] = string.Empty;
            row["cPoNum"] = string.Empty;
            row["nOrdQty"] = string.Empty;
            row["Cmode"] = string.Empty;
            row["DXfty"] = string.Empty;
            row["nfob"] = string.Empty;
            row["ShipDt"] = string.Empty;
            table.Rows.Add(row);
        }
        this.ViewState["CurrentTable"] = table;
        this.grdDelivery.DataSource = table;
        this.grdDelivery.DataBind();
    }

    private void SetPreviousData()
    {
        int num = 0;
        if (this.ViewState["CurrentTable"] != null)
        {
            DataTable table = (DataTable)this.ViewState["CurrentTable"];
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    TextBox box = (TextBox)this.grdDelivery.Rows[num].FindControl("txtlot");
                    TextBox box2 = (TextBox)this.grdDelivery.Rows[num].FindControl("txtpono");
                    TextBox box3 = (TextBox)this.grdDelivery.Rows[num].FindControl("txtttlqty");
                    DropDownList list = (DropDownList)this.grdDelivery.Rows[num].FindControl("drpshipmode");
                    TextBox box4 = (TextBox)this.grdDelivery.Rows[num].FindControl("txtFobdate");
                    TextBox box5 = (TextBox)this.grdDelivery.Rows[num].FindControl("txtprice");
                    Label label = (Label)this.grdDelivery.Rows[num].FindControl("lblttqty");
                    TextBox box6 = (TextBox)this.grdDelivery.Rows[num].FindControl("txtXftydate");
                    Label label1 = (Label)this.grdDelivery.Rows[num].FindControl("lblInseamQty");
                    box.Text = table.Rows[i]["cOrderNu"].ToString();
                    box2.Text = table.Rows[i]["cPoNum"].ToString();
                    box3.Text = table.Rows[i]["nOrdQty"].ToString();
                    label.Text = table.Rows[i]["nOrdQty"].ToString();
                    list.SelectedValue = table.Rows[i]["Cmode"].ToString();
                    box4.Text = table.Rows[i]["DXfty"].ToString();
                    box5.Text = table.Rows[i]["nfob"].ToString();
                    box6.Text = table.Rows[i]["ShipDt"].ToString();
                    num++;
                }
            }
        }
    }

    private void ShowPopUpMsg(string msg)
    {
        StringBuilder builder = new StringBuilder();
        builder.Append("alert('");
        builder.Append(msg.Replace("\n", @"\n").Replace("\r", "").Replace("'", @"\'"));
        builder.Append("');");
        ScriptManager.RegisterStartupScript(this.Page, base.GetType(), "showalert", builder.ToString(), true);
    }

    public void stle(string styleNo)
    {
        this.btnSave.Visible = true;
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        DataSet set = this.mybll.get_Informationdataset("Sp_Smt_StyleMaster_GetByStyleNo '" + this.Session["Uid"].ToString() + "','" + styleNo + "'");
        if (set.Tables[0].Rows.Count > 0)
        {
            string str = set.Tables[0].Rows[0]["ConfirmStatus"].ToString();
            string s = set.Tables[0].Rows[0]["nStyleID"].ToString();
            this.lblstyleid.Text = s;
            this.txtStid.Text = s;
            this.drpBuyer.SelectedValue = set.Tables[0].Rows[0]["nAcct"].ToString();
            this.drpStore.SelectedValue = set.Tables[0].Rows[0]["nstore"].ToString();
            this.drpSeason.SelectedValue = set.Tables[0].Rows[0]["nSeason"].ToString();
            this.drpStyle.SelectedValue = set.Tables[0].Rows[0]["cType"].ToString();
            this.drpBrand.SelectedValue = set.Tables[0].Rows[0]["nBran"].ToString();
            this.drpDivision.SelectedValue = set.Tables[0].Rows[0]["nDept"].ToString();
            this.drpFactory.SelectedValue = set.Tables[0].Rows[0]["cCmp"].ToString();
            this.drpGarmenttype.SelectedValue = set.Tables[0].Rows[0]["cGmtType"].ToString();
            string str3 = set.Tables[0].Rows[0]["dBPCd"].ToString();
            if (!string.IsNullOrEmpty(str3))
            {
                DateTime time = DateTime.Parse(str3);
                //this.txtBpcd.Text = $"{time:dd-MMM-yyyy}";
                this.txtBpcd.Text = time.ToString("dd MMM yyyy hh:mm:ss tt");
            }
            this.txtStyle.Text = set.Tables[0].Rows[0]["cStyleNo"].ToString();
            this.txtfob.Text = set.Tables[0].Rows[0]["nfob"].ToString();
            this.txtContact.Text = set.Tables[0].Rows[0]["cDispStyleNo"].ToString();
            this.drpfob.SelectedValue = set.Tables[0].Rows[0]["Fobmode"].ToString();
            if (str == "CONF")
            {
                this.chkConfirmation.Checked = true;
            }
            else
            {
                this.chkConfirmation.Checked = false;
            }
            if (this.mybll.get_InformationdataTable("select nStyleID from Smt_OrderSize where nStyleID=" + this.lblstyleid.Text).Rows.Count > 0)
            {
                this.chkConfirmation.Enabled = false;
            }
            else
            {
                this.chkConfirmation.Enabled = true;
            }
            this.txtOrderqty.Text = set.Tables[0].Rows[0]["nTotOrdQty"].ToString();
            this.txtplanefficiency.Text = set.Tables[0].Rows[0]["nPlnEff"].ToString();
            this.txtsmv.Text = set.Tables[0].Rows[0]["NSMV"].ToString();
            string str4 = set.Tables[0].Rows[0]["dCOShtRec"].ToString();
            if (!string.IsNullOrEmpty(str4))
            {
                DateTime time2 = DateTime.Parse(str4);
                //this.txtconfirmrcvd.Text = $"{time2:dd-MMM-yyyy}";
                this.txtconfirmrcvd.Text = time2.ToString("dd MMM yyyy hh:mm:ss tt");
            }
            string str5 = set.Tables[0].Rows[0]["dOOshtRec"].ToString();
            if (!string.IsNullOrEmpty(str5))
            {
                DateTime time3 = DateTime.Parse(str5);
                //this.txtoriginalrcvd.Text = $"{time3:dd-MMM-yyyy}";
                this.txtoriginalrcvd.Text = time3.ToString("dd MMM yyyy hh:mm:ss tt");
            }
            DataTable table2 = this.mybll.get_InformationdataTable("Sp_Smt_OrdersMaster_getdtlbystyle " + s);
            if (table2.Rows.Count > 0)
            {
                this.ViewState["CurrentTable"] = table2;
                this.grdDelivery.DataSource = table2;
                this.grdDelivery.DataBind();
            }
            else
            {
                this.ViewState["CurrentTable"] = null;
                this.SetInitialRow();
            }
            DataTable table3 = this.mycls.get_Specialoprationstyleid(int.Parse(s));
            foreach (GridViewRow row in this.GridView1.Rows)
            {
                CheckBox box = (CheckBox)row.FindControl("chkSelect");
                box.Checked = false;
            }
            foreach (DataRow row2 in table3.Rows)
            {
                foreach (GridViewRow row3 in this.GridView1.Rows)
                {
                    Label label2 = (Label)row3.FindControl("lblid");
                    if (label2.Text == row2[0].ToString())
                    {
                        CheckBox box2 = (CheckBox)row3.FindControl("chkSelect");
                        box2.Checked = true;
                    }
                }
            }
            if (str == "CNCL")
            {
                this.btnSave.Visible = false;
                label.Text = "Style Already Cancelled";
            }
            this.txtStyle.Enabled = false;
            this.runjQueryCode("ds()");
            this.btnSave.Text = "Update";
            this.btnSave.ToolTip = "Update";
        }
        this.txtOrderqty.Focus();
    }

    protected void txtStyle_TextChanged(object sender, EventArgs e)
    {
        this.stle(this.txtStyle.Text.Trim());
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
