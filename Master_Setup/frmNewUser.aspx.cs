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

public partial class Master_Setup_frmNewUser : System.Web.UI.Page
{
    //protected Button btnClear;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    //protected C1.Web.UI.Controls.C1GridView.C1GridView C1GridView1;
    //protected C1.Web.UI.Controls.C1TabControl.C1TabControl C1TabControl1;
    //protected C1TabPage C1TabPage1;
    //protected C1TabPage C1TabPage2;
    //protected CompareValidator CompareValidator1;
    //protected ValidatorCalloutExtender CompareValidator1_ValidatorCalloutExtender;
    //protected DropDownList drpCompany;
    //protected DropDownList drpDepartment;
    //protected DropDownList drpSection;
    //protected DropDownList drpUsergroup;
    //protected HtmlForm form1;
    //protected GridView grdFormlist;
    //protected HtmlHead Head1;
    //protected Label Label10;
    //protected Label Label11;
    //protected Label Label12;
    //protected Label Label13;
    //protected Label Label14;
    //protected Label Label15;
    //protected Label Label16;
    //protected Label Label2;
    //protected Label Label6;
    //protected Label Label8;
    //protected Label Label9;
    //protected Label lblErrmsg;
    //protected Label lblUserid;
    private BLL mybll = new BLL();
    private DAL mycls = new DAL();
    //protected RadioButton rdActive;
    //protected RadioButton rdGroupwise;
    //protected RadioButton rdInactive;
    //protected RadioButton rdUserwise;
    //protected RegularExpressionValidator RegularExpressionValidator1;
    //protected ValidatorCalloutExtender RegularExpressionValidator1_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator1;
    //protected ValidatorCalloutExtender RequiredFieldValidator1_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator2;
    //protected ValidatorCalloutExtender RequiredFieldValidator2_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator3;
    //protected ValidatorCalloutExtender RequiredFieldValidator3_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator4;
    //protected ValidatorCalloutExtender RequiredFieldValidator4_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator6;
    //protected ValidatorCalloutExtender RequiredFieldValidator6_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator7;
    //protected ValidatorCalloutExtender RequiredFieldValidator7_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator8;
    //protected ValidatorCalloutExtender RequiredFieldValidator8_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator9;
    //protected ValidatorCalloutExtender RequiredFieldValidator9_ValidatorCalloutExtender;
    //protected ScriptManager ScriptManager1;
    //protected TextBox txtconfirmpassword;
    //protected TextBox txtEmail;
    //protected TextBox txtfullname;
    //protected TextBox txtPassword;
    //protected PasswordStrength txtPassword_PasswordStrength;
    //protected TextBox txtUserid;
    //protected UpdatePanel UpdatePanel1;
    //protected UpdatePanel UpdatePanel2;
    //protected UpdatePanel UpdatePanel3;

    public void bindgrid()
    {
        this.grdFormlist.DataSource = this.mybll.get_InformationdataTable("SELECT [Form_Name], [Url], [Form_Desc], [Module_Name] FROM [Smt_Userpermission] ORDER BY [Module_Name], [Form_Name]");
        this.grdFormlist.DataBind();
    }

    public void binsv()
    {
        this.C1GridView1.DataSource = this.mybll.get_InformationdataTable("SELECT * FROM [View_Smt_User] order by cUserFullname");
        this.C1GridView1.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.C1GridView1.DataBind();
        this.txtconfirmpassword.Text = "";
        this.txtEmail.Text = "";
        this.txtfullname.Text = "";
        this.txtPassword.Text = "";
        this.txtUserid.Text = "";
        this.drpCompany.SelectedValue = "";
        this.drpUsergroup.SelectedValue = "";
        this.rdActive.Checked = true;
        this.rdInactive.Checked = false;
        this.lblUserid.Text = "";
        this.txtUserid.Focus();
        this.bindgrid();
        this.txtPassword.Attributes["value"] = "";
        this.txtconfirmpassword.Attributes["value"] = "";
        this.btnSave.Text = "Save";
        this.btnSave.ToolTip = "Save";
        this.drpDepartment.Items.Clear();
        this.drpDepartment.DataSource = null;
        this.drpDepartment.DataBind();
        this.drpSection.Items.Clear();
        this.drpSection.DataSource = null;
        this.drpSection.DataBind();
        this.txtUserid.Enabled = true;
        this.drpUsergroup.Enabled = true;
        this.rdInactive.Enabled = true;
        this.rdUserwise.Enabled = true;
        this.rdGroupwise.Enabled = true;
        this.rdActive.Enabled = true;
        this.lblErrmsg.Text = "";
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        string str;
        string str2;
        if (this.rdActive.Checked)
        {
            str = "Active";
        }
        else
        {
            str = "Inactive";
        }
        if (this.rdGroupwise.Checked)
        {
            str2 = "G";
        }
        else
        {
            str2 = "U";
        }
        if (string.IsNullOrEmpty(this.lblUserid.Text))
        {
            this.mycls.Save_Newuser(this.txtUserid.Text.Trim().ToUpper(), this.txtfullname.Text.Trim(), this.txtPassword.Text.Trim(), 1, int.Parse(this.drpDepartment.SelectedValue), int.Parse(this.drpSection.SelectedValue), this.txtEmail.Text.Trim(), int.Parse(this.drpCompany.SelectedValue), this.drpUsergroup.SelectedValue, str2, str, this.lblErrmsg);
        }
        else
        {
            this.mycls.Update_Newuser(int.Parse(this.lblUserid.Text), this.txtUserid.Text.Trim().ToUpper(), this.txtfullname.Text.Trim(), this.txtPassword.Text.Trim(), "1", this.drpDepartment.SelectedValue, this.drpSection.SelectedValue, this.txtEmail.Text.Trim(), this.drpCompany.SelectedValue, this.drpUsergroup.SelectedValue, str2, str, this.lblErrmsg);
        }
        if (this.lblErrmsg.Text != "Already Exist")
        {
            if (str2 == "U")
            {
                this.C1GridView1.DataBind();
                this.mycls.Delete_grouppermissionupdate(this.txtUserid.Text.Trim());
                for (int i = 0; i < this.grdFormlist.Rows.Count; i++)
                {
                    CheckBox box = (CheckBox)this.grdFormlist.Rows[i].FindControl("chkSelect");
                    string text = this.grdFormlist.Rows[i].Cells[1].Text;
                    Label label = (Label)this.grdFormlist.Rows[i].FindControl("lblUrl");
                    if (box.Checked)
                    {
                        this.mycls.Save_grouppermission(this.drpUsergroup.SelectedValue, text, label.Text, "U", this.txtUserid.Text, this.lblErrmsg);
                    }
                }
            }
            this.C1GridView1.DataBind();
            this.txtconfirmpassword.Text = "";
            this.txtEmail.Text = "";
            this.txtfullname.Text = "";
            this.txtPassword.Text = "";
            this.txtUserid.Text = "";
            this.drpCompany.SelectedValue = "";
            this.drpUsergroup.SelectedValue = "";
            this.rdActive.Checked = true;
            this.rdInactive.Checked = false;
            this.txtUserid.Focus();
            this.txtPassword.Attributes["value"] = "";
            this.txtconfirmpassword.Attributes["value"] = "";
            this.bindgrid();
            this.binsv();
            this.lblUserid.Text = "";
            this.btnSave.Text = "Save";
            this.btnSave.ToolTip = "Save";
            this.drpDepartment.Items.Clear();
            this.drpSection.Items.Clear();
            this.txtUserid.Enabled = true;
        }
    }

    protected void C1GridView1_Filtering(object sender, C1GridViewFilterEventArgs e)
    {
        this.binsv();
    }

    protected void C1GridView1_PageIndexChanging(object sender, C1GridViewPageEventArgs e)
    {
        this.C1GridView1.PageIndex = e.NewPageIndex;
        this.binsv();
    }

    protected void C1GridView1_RowCommand(object sender, C1GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Select")
        {
            this.drpDepartment.Items.Clear();
            this.drpSection.Items.Clear();
            this.drpCompany.SelectedValue = "";
            this.drpUsergroup.Enabled = true;
            int num = int.Parse(e.CommandArgument.ToString());
            Label label = (Label)this.C1GridView1.Rows[num].Cells[1].FindControl("lblid");
            DataSet set = this.mycls.get_Userbyid(label.Text);
            this.lblUserid.Text = set.Tables[0].Rows[0]["nUserID"].ToString();
            this.txtUserid.Text = set.Tables[0].Rows[0]["cUserName"].ToString();
            this.txtfullname.Text = set.Tables[0].Rows[0]["cUserFullname"].ToString();
            this.txtEmail.Text = set.Tables[0].Rows[0]["Email"].ToString();
            this.drpCompany.SelectedValue = set.Tables[0].Rows[0]["nCompanyID"].ToString();
            DataSet set2 = this.mybll.get_Informationdataset("select nUserDept,cDeptname from Smt_Department where nCompanyID=" + this.drpCompany.SelectedValue);
            this.drpDepartment.DataSource = set2;
            this.drpDepartment.DataTextField = "cDeptname";
            this.drpDepartment.DataValueField = "nUserDept";
            this.drpDepartment.DataBind();
            this.txtUserid.Enabled = false;
            this.drpDepartment.SelectedValue = set.Tables[0].Rows[0]["nUserDept"].ToString();
            DataSet set3 = this.mybll.get_Informationdataset("select nSectionID,cSection_Description from Smt_Section where nUserDept=" + this.drpDepartment.SelectedValue);
            this.drpSection.DataSource = set3;
            this.drpSection.DataTextField = "cSection_Description";
            this.drpSection.DataValueField = "nSectionID";
            this.drpSection.DataBind();
            this.drpSection.SelectedValue = set.Tables[0].Rows[0]["nSectionID"].ToString();
            if (set.Tables[0].Rows[0]["nUgroup"].ToString() != "99")
            {
                this.drpUsergroup.SelectedValue = set.Tables[0].Rows[0]["nUgroup"].ToString();
            }
            this.txtPassword.Attributes["value"] = set.Tables[0].Rows[0]["cPassWord"].ToString();
            this.txtconfirmpassword.Attributes["value"] = set.Tables[0].Rows[0]["cPassWord"].ToString();
            string str2 = set.Tables[0].Rows[0]["Permission_status"].ToString();
            if (set.Tables[0].Rows[0]["Activity_status"].ToString() == "A")
            {
                this.rdActive.Checked = true;
                this.rdInactive.Checked = false;
            }
            else
            {
                this.rdInactive.Checked = true;
                this.rdActive.Checked = false;
            }
            this.btnSave.Text = "Update";
            this.btnSave.ToolTip = "Update";
            foreach (GridViewRow row in this.grdFormlist.Rows)
            {
                CheckBox box = (CheckBox)row.FindControl("chkSelect");
                box.Checked = false;
            }
            if (str2 == "U")
            {
                this.rdGroupwise.Checked = false;
                this.RequiredFieldValidator9.Enabled = false;
                this.rdUserwise.Checked = true;
                this.drpUsergroup.SelectedValue = "";
                this.drpUsergroup.Enabled = false;
                foreach (GridViewRow row2 in this.grdFormlist.Rows)
                {
                    CheckBox box2 = (CheckBox)row2.FindControl("chkSelect");
                    box2.Enabled = true;
                }
                foreach (DataRow row3 in this.mybll.get_InformationdataTable("select Form_Name from Smt_UserPermittedform where User_ID='" + label.Text + "'").Rows)
                {
                    foreach (GridViewRow row4 in this.grdFormlist.Rows)
                    {
                        if (row4.Cells[1].Text == row3[0].ToString())
                        {
                            CheckBox box3 = (CheckBox)row4.FindControl("chkSelect");
                            box3.Checked = true;
                        }
                    }
                }
            }
            else
            {
                this.rdGroupwise.Checked = true;
                this.RequiredFieldValidator9.Enabled = true;
                this.rdUserwise.Checked = false;
                this.drpUsergroup.Enabled = true;
                foreach (GridViewRow row5 in this.grdFormlist.Rows)
                {
                    CheckBox box4 = (CheckBox)row5.FindControl("chkSelect");
                    box4.Enabled = false;
                    box4.Checked = false;
                }
            }
            if (this.txtUserid.Text == "Admin")
            {
                this.drpUsergroup.Enabled = false;
                this.rdInactive.Enabled = false;
                this.rdUserwise.Enabled = false;
                this.rdGroupwise.Enabled = false;
                this.rdActive.Enabled = false;
            }
            this.C1TabControl1.MoveFirst();
        }
    }

    protected void C1GridView1_RowDataBound(object sender, C1GridViewRowEventArgs e)
    {
        e.Row.Cells[0].Width = 50;
    }

    protected void drpCompany_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataSet set = this.mybll.get_Informationdataset("select nUserDept,cDeptname from Smt_Department where nCompanyID='" + this.drpCompany.SelectedValue + "' order by cDeptname");
        this.drpDepartment.DataSource = set;
        this.drpDepartment.DataTextField = "cDeptname";
        this.drpDepartment.DataValueField = "nUserDept";
        this.drpDepartment.DataBind();
        this.drpDepartment.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpDepartment.SelectedIndex = 0;
        this.drpDepartment.Focus();
    }

    protected void drpDepartment_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataSet set = this.mybll.get_Informationdataset("select nSectionID,cSection_Description from Smt_Section where nUserDept='" + this.drpDepartment.SelectedValue + "' order by cSection_Description");
        this.drpSection.DataSource = set;
        this.drpSection.DataTextField = "cSection_Description";
        this.drpSection.DataValueField = "nSectionID";
        this.drpSection.DataBind();
        this.drpSection.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpSection.SelectedIndex = 0;
        this.drpSection.Focus();
    }

    protected void grdFormlist_PreRender(object sender, EventArgs e)
    {
        MergeRows(this.grdFormlist);
    }

    protected void grdFormlist_RowDataBound(object sender, GridViewRowEventArgs e)
    {
    }

    public static void MergeRows(GridView gridView)
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
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.Session["Uid"] == null)
        {
            base.Response.Redirect("../Smt_Login.aspx", false);
        }
        else
        {
            if (!base.IsPostBack)
            {
                this.mycls.drp_Company(this.drpCompany);
                this.mycls.drp_usergroup(this.drpUsergroup);
                this.txtUserid.Focus();
                this.bindgrid();
                this.binsv();
            }
            this.txtPassword.Attributes["value"] = this.txtPassword.Text;
            this.txtconfirmpassword.Attributes["value"] = this.txtconfirmpassword.Text;
            Thread.Sleep(200);
        }
    }

    protected void rdGroupwise_CheckedChanged(object sender, EventArgs e)
    {
        for (int i = 0; i < this.grdFormlist.Rows.Count; i++)
        {
            CheckBox box = (CheckBox)this.grdFormlist.Rows[i].FindControl("chkSelect");
            box.Enabled = false;
            box.Checked = false;
        }
        this.drpUsergroup.Enabled = true;
        this.RequiredFieldValidator9.Enabled = true;
        this.drpUsergroup.Focus();
    }

    protected void rdUserwise_CheckedChanged(object sender, EventArgs e)
    {
        for (int i = 0; i < this.grdFormlist.Rows.Count; i++)
        {
            CheckBox box = (CheckBox)this.grdFormlist.Rows[i].FindControl("chkSelect");
            box.Enabled = true;
            box.Checked = false;
        }
        this.drpUsergroup.SelectedValue = "";
        this.RequiredFieldValidator9.Enabled = false;
        this.drpUsergroup.Enabled = false;
        this.txtEmail.Focus();
    }

    protected void txtUserid_TextChanged(object sender, EventArgs e)
    {
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
