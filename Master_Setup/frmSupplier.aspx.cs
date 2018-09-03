using AjaxControlToolkit;
using ASP;
using C1.Web.UI.Controls.C1GridView;
using C1.Web.UI.Controls.C1TabControl;
using System;
using System.Data;
using System.Threading;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Master_Setup_frmSupplier : System.Web.UI.Page
{
    private BLLInventory blinventory = new BLLInventory();
    //protected Button btnClear;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    //protected Button btnUpdate;
    //protected ConfirmButtonExtender btnUpdate_ConfirmButtonExtender;
    //protected C1.Web.UI.Controls.C1GridView.C1GridView C1GridView1;
    //protected C1.Web.UI.Controls.C1TabControl.C1TabControl C1TabControl1;
    //protected C1TabPage C1TabPage1;
    //protected C1TabPage C1TabPage2;
    private DALInventory dlinventory = new DALInventory();
    //protected DropDownList drpCountry;
    //protected DropDownList drpSuppliertype;
    //protected HtmlForm form1;
    //protected GridView GridView1;
    //protected HtmlHead Head1;
    //protected Label Label10;
    //protected Label Label11;
    //protected Label Label12;
    //protected Label Label13;
    //protected Label Label14;
    //protected Label Label4;
    //protected Label Label7;
    //protected Label Label8;
    //protected Label Label9;
    //protected Label lblErrmsg;
    //protected Label lblsuplierid;
    private BLL mybll = new BLL();
    private DAL mycls = new DAL();
    //protected RegularExpressionValidator RegularExpressionValidator1;
    //protected ValidatorCalloutExtender RegularExpressionValidator1_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator1;
    //protected ValidatorCalloutExtender RequiredFieldValidator1_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator2;
    //protected ValidatorCalloutExtender RequiredFieldValidator2_ValidatorCalloutExtender;
    //protected ScriptManager ScriptManager1;
    //protected TextBox txtAcntno;
    //protected TextBox txtAddress;
    //protected TextBox txtAttention;
    //protected TextBox txtCod;
    //protected TextBox txtCode;
    //protected TextBox txtContact;
    //protected TextBox txtEmail;
    //protected TextBox txtName;
    //protected UpdatePanel UpdatePanel1;

    public void bindgrid()
    {
        this.GridView1.DataSource = this.blinventory.get_InformationdataTable("SELECT [nMainCategory_ID], [cMainCategory], [nMasterCategory_ID] FROM [Smt_MainCategory] ORDER BY [cMainCategory]");
        this.GridView1.DataBind();
    }

    public void bindview()
    {
        this.C1GridView1.DataSource = this.blinventory.get_InformationdataTable("SELECT [cSupCode], [cSupName], [cSupAdd1], [cSupAdd2] FROM [Smt_Suppliers] ORDER BY [cSupName]");
        this.C1GridView1.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.btnSave.Visible = true;
        this.btnUpdate.Visible = false;
        this.drpCountry.SelectedItem.Text = "";
        this.drpSuppliertype.SelectedValue = "";
        this.drpSuppliertype.Enabled = true;
        this.txtAddress.Text = "";
        this.txtAttention.Text = "";
        this.txtCod.Text = "";
        this.txtCode.Text = "";
        this.txtContact.Text = "";
        this.txtEmail.Text = "";
        this.txtName.Text = "";
        this.drpSuppliertype.Focus();
        this.bindgrid();
        this.C1GridView1.DataBind();
        this.lblErrmsg.Text = "";
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        string s = null;
        string code = this.txtName.Text.Substring(0, 3);
        this.dlinventory.Save_Suppliers(this.txtCode.Text.Trim(), this.txtName.Text.Trim(), this.txtAddress.Text.Trim(), this.drpCountry.SelectedItem.ToString(), this.txtContact.Text, this.txtCod.Text, this.drpSuppliertype.SelectedValue, this.Session["Uid"].ToString(), this.txtAttention.Text, this.txtEmail.Text, code, this.txtAcntno.Text, this.lblErrmsg);
        DataTable table = this.blinventory.get_InformationdataTable("select nCode from Smt_Suppliers where cSupName='" + this.txtName.Text.Trim() + "'");
        if (table.Rows.Count > 0)
        {
            s = table.Rows[0]["nCode"].ToString();
        }
        if (this.lblErrmsg.Text != "Supplier Name Already Exist")
        {
            for (int i = 0; i < this.GridView1.Rows.Count; i++)
            {
                CheckBox box = (CheckBox)this.GridView1.Rows[i].FindControl("chkslect");
                string text = this.GridView1.Rows[i].Cells[1].Text;
                Label label = (Label)this.GridView1.Rows[i].FindControl("lblid");
                if (box.Checked)
                {
                    this.dlinventory.Save_Suppliermaincategory(this.txtCode.Text, text, int.Parse(s), int.Parse(label.Text));
                }
            }
            this.drpCountry.SelectedValue = "";
            this.drpSuppliertype.SelectedValue = "";
            this.txtAddress.Text = "";
            this.txtAttention.Text = "";
            this.txtCod.Text = "";
            this.txtCode.Text = "";
            this.txtContact.Text = "";
            this.txtEmail.Text = "";
            this.txtName.Text = "";
            this.drpSuppliertype.Focus();
            this.bindgrid();
            this.bindview();
            this.btnSave.Visible = true;
            this.btnUpdate.Visible = false;
        }
        else
        {
            this.txtName.Focus();
        }
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        string code = this.txtName.Text.Substring(0, 3);
        this.dlinventory.Update_Suppliers(this.txtCode.Text.Trim(), this.txtName.Text.Trim(), this.txtAddress.Text.Trim(), this.drpCountry.SelectedItem.ToString(), this.txtContact.Text, this.txtCod.Text, this.drpSuppliertype.SelectedValue, this.Session["Uid"].ToString(), this.txtAttention.Text, this.txtEmail.Text, code, this.txtAcntno.Text, this.lblErrmsg);
        this.dlinventory.Delete_Suppliermaincategory(this.txtCode.Text);
        for (int i = 0; i < this.GridView1.Rows.Count; i++)
        {
            CheckBox box = (CheckBox)this.GridView1.Rows[i].FindControl("chkslect");
            string text = this.GridView1.Rows[i].Cells[1].Text;
            Label label = (Label)this.GridView1.Rows[i].FindControl("lblid");
            if (box.Checked)
            {
                this.dlinventory.Save_Suppliermaincategory(this.txtCode.Text, text, int.Parse(this.lblsuplierid.Text), int.Parse(label.Text));
            }
        }
        this.drpCountry.SelectedItem.Text = "";
        this.drpSuppliertype.SelectedValue = "";
        this.drpSuppliertype.Enabled = true;
        this.txtAddress.Text = "";
        this.txtAttention.Text = "";
        this.txtCod.Text = "";
        this.txtCode.Text = "";
        this.txtContact.Text = "";
        this.txtEmail.Text = "";
        this.txtName.Text = "";
        this.drpSuppliertype.Focus();
        this.bindgrid();
        this.bindview();
        this.btnSave.Visible = false;
        this.btnUpdate.Visible = true;
    }

    protected void C1GridView1_Filtering(object sender, C1GridViewFilterEventArgs e)
    {
        this.bindview();
    }

    protected void C1GridView1_PageIndexChanging(object sender, C1GridViewPageEventArgs e)
    {
        this.C1GridView1.PageIndex = e.NewPageIndex;
        this.bindview();
    }

    protected void C1GridView1_RowCommand(object sender, C1GridViewCommandEventArgs e)
    {
        this.lblErrmsg.Text = "";
        if (e.CommandName == "Select")
        {
            int num = int.Parse(e.CommandArgument.ToString());
            string text = this.C1GridView1.Rows[num].Cells[1].Text;
            string statement = "select * from Smt_Suppliers where cSupCode='" + text + "'";
            DataTable table = this.dlinventory.get_Alltbl(statement);
            this.txtCode.Text = table.Rows[0]["cSupCode"].ToString();
            string str4 = this.txtCode.Text.Substring(2, 2);
            this.drpSuppliertype.SelectedValue = str4;
            this.txtName.Text = table.Rows[0]["cSupName"].ToString();
            this.txtAddress.Text = table.Rows[0]["cSupAdd1"].ToString();
            this.drpCountry.SelectedItem.Text = table.Rows[0]["cSupAdd2"].ToString();
            this.txtContact.Text = table.Rows[0]["cSupContNo"].ToString();
            this.txtCod.Text = table.Rows[0]["cSupValtNo"].ToString();
            this.txtAttention.Text = table.Rows[0]["cAtt"].ToString();
            this.txtEmail.Text = table.Rows[0]["cEmail"].ToString();
            this.lblsuplierid.Text = table.Rows[0]["nCode"].ToString();
            this.txtAcntno.Text = table.Rows[0]["suplierAccount"].ToString();
            this.btnSave.Visible = false;
            this.btnUpdate.Visible = true;
            this.drpSuppliertype.Enabled = false;
            foreach (GridViewRow row in this.GridView1.Rows)
            {
                CheckBox box = (CheckBox)row.FindControl("chkslect");
                box.Checked = false;
            }
            foreach (DataRow row2 in this.blinventory.get_InformationdataTable("select cManCat from Smt_SupSupManCat where cSupCode='" + text + "'").Rows)
            {
                foreach (GridViewRow row3 in this.GridView1.Rows)
                {
                    if (row3.Cells[1].Text == row2[0].ToString())
                    {
                        CheckBox box2 = (CheckBox)row3.FindControl("chkslect");
                        box2.Checked = true;
                    }
                }
            }
            this.C1TabControl1.MoveFirst();
        }
    }

    protected void C1GridView1_RowDataBound(object sender, C1GridViewRowEventArgs e)
    {
        e.Row.Cells[0].Width = 50;
    }

    protected void drpSuppliertype_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(this.drpSuppliertype.SelectedValue))
        {
            string str2 = (int.Parse(this.blinventory.get_Informationdataset("select nSubTot from Smt_SuppliersType where cSupTypeCode='" + this.drpSuppliertype.SelectedValue + "'").Tables[0].Rows[0]["nSubTot"].ToString()) + 1).ToString();
            if (str2.Length < 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    string str = "0" + str2;
                    str2 = str;
                    if (str.Length == 5)
                    {
                        this.txtCode.Text = "SU" + this.drpSuppliertype.SelectedValue + str2;
                    }
                }
            }
        }
        else
        {
            this.txtCode.Text = "";
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!base.IsPostBack)
        {
            this.dlinventory.drp_Suppliertype(this.drpSuppliertype);
            this.mycls.drp_Counrys(this.drpCountry);
            this.bindgrid();
            this.bindview();
        }
        Thread.Sleep(200);
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}