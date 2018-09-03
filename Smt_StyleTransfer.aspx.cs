using AjaxControlToolkit;
using ASP;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class Smt_StyleTransfer : System.Web.UI.Page
{
    private BLL _bll = new BLL();
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    //protected DropDownList drpBuyer;
    //protected DropDownList drpMerchant;
    //protected GridView grdStyle;
    //protected RequiredFieldValidator RequiredFieldValidator1;
    //protected ValidatorCalloutExtender RequiredFieldValidator1_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator3;
    //protected ValidatorCalloutExtender RequiredFieldValidator3_ValidatorCalloutExtender;
    //protected UpdatePanel UpdatePanel1;

    public void bind()
    {
        this.drpMerchant.DataSource = this._bll.get_InformationdataTable("select cUserName,cUserFullname from Smt_Users order by cUserFullname");
        this.drpMerchant.DataTextField = "cUserFullname";
        this.drpMerchant.DataValueField = "cUserName";
        this.drpMerchant.DataBind();
        this.drpMerchant.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpMerchant.SelectedIndex = 0;
    }

    public void bindbuyer()
    {
        this.drpBuyer.DataSource = this._bll.get_InformationdataTable("Sp_Smt_StyleMaster_StyleTransfer_getbuyer");
        this.drpBuyer.DataTextField = "cBuyer_Name";
        this.drpBuyer.DataValueField = "nBuyer_ID";
        this.drpBuyer.DataBind();
        this.drpBuyer.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpBuyer.SelectedIndex = 0;
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        SqlConnection specFoCon = GetWay.SpecFoCon;
        MC mc = new MC();
        specFoCon.Open();
        SqlTransaction tr = specFoCon.BeginTransaction();
        try
        {
            if (this.grdStyle.Rows.Count > 0)
            {
                for (int i = 0; i < this.grdStyle.Rows.Count; i++)
                {
                    Label label2 = (Label)this.grdStyle.Rows[i].FindControl("lblstyle");
                    Label label3 = (Label)this.grdStyle.Rows[i].FindControl("lblBuyer");
                    string[] normalparam = new string[] { "@StyleID", "@Olduser", "@NewUser" };
                    CheckBox box = (CheckBox)this.grdStyle.Rows[i].FindControl("chkselect");
                    if (box.Checked)
                    {
                        string[] normalprmval = new string[] { label2.Text.Trim(), this.Session["Uid"].ToString(), this.drpMerchant.SelectedValue };
                        mc.MC_Save_nodt_tr("Sp_Smt_StyleMaster_StyleTransfer_save", specFoCon, tr, normalparam, normalprmval);
                        int num2 = 0;
                        GridView view = (GridView)this.grdStyle.Rows[i].FindControl("grdpptna");
                        for (int j = 0; j < view.Rows.Count; j++)
                        {
                            DropDownList list = (DropDownList)view.Rows[j].FindControl("drptna");
                            if (!string.IsNullOrEmpty(list.SelectedValue))
                            {
                                num2++;
                            }
                        }
                        if (num2 == view.Rows.Count)
                        {
                            for (int k = 0; k < view.Rows.Count; k++)
                            {
                                DropDownList list2 = (DropDownList)view.Rows[k].FindControl("drptna");
                                Label label4 = (Label)view.Rows[k].FindControl("lblLot");
                                string[] strArray3 = new string[] { "@Styleid", "@Lot", "@buyerid", "@customname", "@entby" };
                                string[] strArray4 = new string[] { label2.Text.Trim(), label4.Text.Trim(), label3.Text.Trim(), list2.SelectedValue, this.drpMerchant.SelectedValue };
                                mc.MC_Save_nodt_tr("Sp_Smt_TNA_POwise_save", specFoCon, tr, strArray3, strArray4);
                            }
                        }
                    }
                }
            }
            tr.Commit();
            label.Text = "Saved Successfully";
            this.drpBuyer.SelectedIndex = 0;
            this.grdStyle.DataSource = null;
            this.grdStyle.DataBind();
            this.drpMerchant.SelectedIndex = 0;
        }
        catch (Exception exception)
        {
            tr.Rollback();
            label.Text = exception.Message;
        }
        finally
        {
            specFoCon.Close();
        }
    }

    protected void drpBuyer_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        label.Text = "";
        this.grdStyle.DataSource = "";
        this.grdStyle.DataBind();
        if (!string.IsNullOrEmpty(this.drpBuyer.SelectedValue))
        {
            this.grdStyle.DataSource = this._bll.get_InformationdataTable("Sp_Smt_StyleMaster_StyleTransfer '" + this.Session["Uid"].ToString() + "'," + this.drpBuyer.SelectedValue);
            this.grdStyle.DataBind();
        }
    }

    protected void grdStyle_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label label = (Label)e.Row.FindControl("lblstyle");
            GridView view = (GridView)e.Row.FindControl("grdpptna");
            view.DataSource = this._bll.get_InformationdataTable("Sp_Smt_StyleMaster_StyleTF_getPO " + label.Text.Trim());
            view.DataBind();
            e.Row.Cells[4].Width = 300;
            for (int i = 0; i < view.Rows.Count; i++)
            {
                Label label2 = (Label)view.Rows[i].FindControl("lblLot");
                DropDownList list = (DropDownList)view.Rows[i].FindControl("drptna");
                DataTable table = this._bll.get_InformationdataTable("Sp_Smt_TNA_Custom_getcustomname");
                list.DataSource = table;
                list.DataTextField = "CustomName";
                list.DataValueField = "CustomName";
                list.DataBind();
                list.Items.Insert(0, new ListItem(string.Empty, string.Empty));
                list.SelectedIndex = 0;
                DataTable table2 = this._bll.get_InformationdataTable("Sp_Smt_StyleMaster_StyleTransfergettna " + label.Text.Trim() + ",'" + label2.Text.Trim() + "'");
                if (table2.Rows.Count > 0)
                {
                    list.SelectedValue = table2.Rows[0]["customname"].ToString();
                    list.Enabled = false;
                    view.Rows[i].Cells[1].BackColor = Color.FromName("#FBA8D1");
                    view.Rows[i].Cells[0].BackColor = Color.FromName("#FBA8D1");
                }
            }
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!base.IsPostBack)
        {
            this.bind();
            this.bindbuyer();
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
