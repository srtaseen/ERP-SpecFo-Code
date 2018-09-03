using AjaxControlToolkit;
using ASP;
using System;
using System.Data;
using System.Threading;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Master_Setup_frmUserGroup : System.Web.UI.Page
{
    //protected Button btnClear;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    //protected HtmlForm form1;
    //protected GridView grdPermission;
    //protected GridView GridView2;
    //protected HtmlHead Head1;
    //protected Label Label5;
    //protected Label lblErrormsg;
    //protected Label lblgrpid;
    private BLL mybll = new BLL();
    private DAL mycls = new DAL();
    //protected RequiredFieldValidator RequiredFieldValidator1;
    //protected ValidatorCalloutExtender RequiredFieldValidator1_ValidatorCalloutExtender;
    //protected ScriptManager ScriptManager1;
    //protected TextBox txtGroup;
    //protected UpdatePanel UpdatePanel1;

    public void bindgrid()
    {
        this.grdPermission.DataSource = this.mybll.get_InformationdataTable("SELECT [Form_Name],Url, [Form_Desc], [Module_Name], [slno] FROM [Smt_Userpermission] ORDER BY [Module_Name], [Form_Name]");
        this.grdPermission.DataBind();
    }

    public void bindsv()
    {
        this.GridView2.DataSource = this.mybll.get_InformationdataTable("SELECT [nUgroup], [cGrpDescription], [cEntUser], [dEntdt] FROM [Smt_UserGroups] ORDER BY [cGrpDescription]");
        this.GridView2.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.lblErrormsg.Text = "";
        this.txtGroup.Text = "";
        this.txtGroup.Focus();
        this.lblgrpid.Text = "";
        this.lblErrormsg.Text = "";
        this.btnSave.Text = "Save";
        this.btnSave.Enabled = true;
        this.bindgrid();
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(this.lblgrpid.Text))
        {
            this.mycls.Save_Usergroup(this.txtGroup.Text.Trim(), this.Session["Uid"].ToString(), this.lblErrormsg);
            DataSet set = this.mybll.get_Informationdataset("select nUgroup from Smt_UserGroups where cGrpDescription='" + this.txtGroup.Text.Trim() + "'");
            this.lblgrpid.Text = set.Tables[0].Rows[0]["nUgroup"].ToString();
            this.txtGroup.Text = "";
        }
        else
        {
            this.mycls.Update_Usergroup(int.Parse(this.lblgrpid.Text), this.txtGroup.Text.Trim(), this.Session["Uid"].ToString(), this.lblErrormsg);
            this.txtGroup.Text = "";
        }
        this.mycls.Delete_grouppermission(int.Parse(this.lblgrpid.Text));
        for (int i = 0; i < this.grdPermission.Rows.Count; i++)
        {
            CheckBox box = (CheckBox)this.grdPermission.Rows[i].FindControl("chkselect");
            string text = this.grdPermission.Rows[i].Cells[1].Text;
            Label label = (Label)this.grdPermission.Rows[i].FindControl("lblformurl");
            if (box.Checked)
            {
                this.mycls.Save_grouppermission(this.lblgrpid.Text, text, label.Text.Trim(), "G", this.Session["Uid"].ToString(), this.lblErrormsg);
            }
        }
        this.lblgrpid.Text = "";
        this.btnSave.Text = "Save";
        this.bindgrid();
        this.bindsv();
        this.txtGroup.Focus();
    }

    protected void grdPermission_PreRender(object sender, EventArgs e)
    {
        MergeRows(this.grdPermission);
    }

    protected void grdPermission_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Cells[0].Attributes.Add("style", "text-align:center");
        }
    }

    protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        this.GridView2.PageIndex = e.NewPageIndex;
        this.bindsv();
    }

    protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Select")
        {
            int num = int.Parse(e.CommandArgument.ToString());
            Label label = (Label)this.GridView2.Rows[num].FindControl("lblid");
            DataTable table = this.mycls.get_Usergroupbyid(int.Parse(label.Text));
            this.txtGroup.Text = table.Rows[0]["cGrpDescription"].ToString();
            this.lblgrpid.Text = table.Rows[0]["nUgroup"].ToString();
            this.btnSave.Text = "Update";
            DataTable table2 = this.mybll.get_InformationdataTable("select Form_Name from Smt_UserPermittedform where nUgroup='" + int.Parse(this.lblgrpid.Text) + "'");
            if (this.txtGroup.Text == "Admin")
            {
                this.btnSave.Enabled = false;
            }
            else
            {
                this.btnSave.Enabled = true;
            }
            foreach (GridViewRow row in this.grdPermission.Rows)
            {
                CheckBox box = (CheckBox)row.FindControl("chkselect");
                box.Checked = false;
            }
            foreach (DataRow row2 in table2.Rows)
            {
                foreach (GridViewRow row3 in this.grdPermission.Rows)
                {
                    if (row3.Cells[1].Text == row2[0].ToString())
                    {
                        CheckBox box2 = (CheckBox)row3.FindControl("chkselect");
                        box2.Checked = true;
                    }
                }
            }
        }
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
            base.Response.Redirect("Smt_Login.aspx", false);
        }
        else
        {
            if (!base.IsPostBack)
            {
                this.bindgrid();
                this.bindsv();
            }
            Thread.Sleep(200);
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
