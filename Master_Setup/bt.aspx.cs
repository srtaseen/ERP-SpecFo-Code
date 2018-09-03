using AjaxControlToolkit;
using ASP;
using System;
using System.Collections;
using System.Data;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Master_Setup_bt : System.Web.UI.Page
{
    private DAL _dlSpecFo = new DAL();
    private BLL _mybl = new BLL();
    //protected Button btnClear;
    //protected Button Button1;
    //protected DropDownList DropDownList1;
    //protected HtmlForm form1;
    //protected GridView GridView1;
    //protected Label Label1;
    //protected Label Label2;
    //protected Label Label3;
    //protected Label lblErrormsg;
    //protected Panel pnlbtnsc;
    //protected RequiredFieldValidator RequiredFieldValidator1;
    //protected ValidatorCalloutExtender RequiredFieldValidator1_ValidatorCalloutExtender;
    //protected ScriptManager ScriptManager1;
    //protected UpdatePanel UpdatePanel1;

    public void bind()
    {
        this.DropDownList1.DataSource = this._mybl.get_InformationdataTable("select cUserName,cUserFullname from Smt_Users order by cUserFullname");
        this.DropDownList1.DataTextField = "cUserFullname";
        this.DropDownList1.DataValueField = "cUserName";
        this.DropDownList1.DataBind();
        this.DropDownList1.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.DropDownList1.SelectedIndex = 0;
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.GridView1.DataSource = null;
        this.GridView1.DataBind();
        this.DropDownList1.SelectedIndex = 0;
        this.lblErrormsg.Text = "";
        this.Label2.Text = "";
        this.Label3.Text = "";
        this.Button1.Enabled = false;
        this.Button1.CssClass = "";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(this.DropDownList1.SelectedValue))
        {
            this._dlSpecFo.Delete_btnperm(this.DropDownList1.SelectedValue);
            if (this.GridView1.Rows.Count > 0)
            {
                for (int i = 0; i < this.GridView1.Rows.Count; i++)
                {
                    CheckBox box = (CheckBox)this.GridView1.Rows[i].FindControl("chkModule");
                    if (box.Checked)
                    {
                        Label label = (Label)this.GridView1.Rows[i].FindControl("lblModule");
                        GridView view = (GridView)this.GridView1.Rows[i].FindControl("grdFormName");
                        for (int j = 0; j < view.Rows.Count; j++)
                        {
                            CheckBox box2 = (CheckBox)view.Rows[j].FindControl("chkForm");
                            if (box2.Checked)
                            {
                                Label label2 = (Label)view.Rows[j].FindControl("lblformurl");
                                GridView view2 = (GridView)view.Rows[j].FindControl("grdButton");
                                for (int k = 0; k < view2.Rows.Count; k++)
                                {
                                    CheckBox box3 = (CheckBox)view2.Rows[k].FindControl("chkButton");
                                    if (box3.Checked)
                                    {
                                        Label label3 = (Label)view2.Rows[k].FindControl("lblbtn");
                                        this._dlSpecFo.Save_btnperm(this.DropDownList1.SelectedValue, label2.Text, label3.Text, "", "1", label.Text, this.lblErrormsg);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            this.GridView1.DataSource = null;
            this.GridView1.DataBind();
            this.DropDownList1.SelectedIndex = 0;
            this.Label2.Text = "";
            this.Label3.Text = "";
        }
    }

    protected void chkForm_CheckedChanged(object sender, EventArgs e)
    {
        GridViewRow parent = ((CheckBox)sender).Parent.Parent as GridViewRow;
        CheckBox box = (CheckBox)parent.FindControl("chkForm");
        Label label = (Label)parent.FindControl("lblformurl");
        GridView view = (GridView)parent.FindControl("grdButton");
        view.DataSource = null;
        view.DataBind();
        if (box.Checked)
        {
            DataSet set = this._mybl.get_Informationdataset("select Btn_Name,Btn_Text from tst_Button where Form_Name='" + label.Text.Trim() + "' order by Btn_Text");
            view.DataSource = set;
            view.DataBind();
        }
    }

    protected void chkModule_CheckedChanged(object sender, EventArgs e)
    {
        GridViewRow parent = ((CheckBox)sender).Parent.Parent as GridViewRow;
        CheckBox box = (CheckBox)parent.FindControl("chkModule");
        Label label = (Label)parent.FindControl("lblModule");
        GridView view = (GridView)parent.FindControl("grdFormName");
        view.DataSource = null;
        view.DataBind();
        if (box.Checked)
        {
            DataSet set = this._mybl.get_Informationdataset("Sp_Smt_Smt_Userpermissionbtnformname '" + this.DropDownList1.SelectedValue + "'," + this.Label3.Text + ",'" + this.Label2.Text + "','" + label.Text + "'");
            view.DataSource = set;
            view.DataBind();
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.Button1.Enabled = false;
        this.Button1.CssClass = "";
        this.GridView1.DataSource = null;
        this.GridView1.DataBind();
        if (!string.IsNullOrEmpty(this.DropDownList1.SelectedValue))
        {
            DataTable table = this._mybl.get_InformationdataTable("select Permission_status,nUgroup from Smt_Users where cUserName='" + this.DropDownList1.SelectedValue + "'");
            string str = table.Rows[0]["Permission_status"].ToString();
            string str2 = table.Rows[0]["nUgroup"].ToString();
            this.Label2.Text = str;
            this.Label3.Text = str2;
            if (!string.IsNullOrEmpty(str))
            {
                DataTable table2 = this._mybl.get_InformationdataTable("Sp_Smt_Smt_Userpermissionbtn '" + this.DropDownList1.SelectedValue + "'," + str2 + ",'" + str + "'");
                this.GridView1.DataSource = table2;
                this.GridView1.DataBind();
                if (this.GridView1.Rows.Count > 0)
                {
                    foreach (DataRow row in table2.Rows)
                    {
                        foreach (GridViewRow row2 in this.GridView1.Rows)
                        {
                            Label label = (Label)row2.FindControl("lblModule");
                            if (label.Text.Trim() == row[0].ToString())
                            {
                                CheckBox box = (CheckBox)row2.FindControl("chkModule");
                                box.Checked = true;
                                GridView view = (GridView)row2.FindControl("grdFormName");
                                DataTable table3 = this._mybl.get_InformationdataTable("Sp_Smt_Smt_Userpermissionbtnformname '" + this.DropDownList1.SelectedValue + "'," + this.Label3.Text + ",'" + this.Label2.Text + "','" + label.Text + "'");
                                view.DataSource = table3;
                                view.DataBind();
                                using (IEnumerator enumerator3 = table2.Rows.GetEnumerator())
                                {
                                    while (enumerator3.MoveNext())
                                    {
                                        DataRow current = (DataRow)enumerator3.Current;
                                        foreach (GridViewRow row3 in view.Rows)
                                        {
                                            CheckBox box2 = (CheckBox)row3.FindControl("chkForm");
                                            box2.Checked = true;
                                            GridView view2 = (GridView)row3.FindControl("grdButton");
                                            Label label2 = (Label)row3.FindControl("lblformurl");
                                            DataTable table4 = this._mybl.get_InformationdataTable("select Btn_Name,Btn_Text from tst_Button where Form_Name='" + label2.Text.Trim() + "' order by Btn_Text");
                                            view2.DataSource = table4;
                                            view2.DataBind();
                                            if (this._mybl.get_InformationdataTable("select UserName from tst_permitterbtn where UserName='" + this.DropDownList1.SelectedValue + "'").Rows.Count > 0)
                                            {
                                                DataTable table6 = this._mybl.get_InformationdataTable("select ButtonName from tst_permitterbtn where FormName='" + label2.Text + "' and UserName='" + this.DropDownList1.SelectedValue + "'");
                                                if (table6.Rows.Count > 0)
                                                {
                                                    foreach (DataRow row4 in table6.Rows)
                                                    {
                                                        foreach (GridViewRow row5 in view2.Rows)
                                                        {
                                                            Label label3 = (Label)row5.FindControl("lblbtn");
                                                            if (label3.Text.Trim() == row4[0].ToString())
                                                            {
                                                                CheckBox box3 = (CheckBox)row5.FindControl("chkButton");
                                                                box3.Checked = true;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                foreach (GridViewRow row6 in view2.Rows)
                                                {
                                                    CheckBox box4 = (CheckBox)row6.FindControl("chkButton");
                                                    box4.Checked = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        if (this.GridView1.Rows.Count > 0)
        {
            this.Button1.Enabled = true;
            this.Button1.CssClass = "button";
        }
    }

    protected void grdButton_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Cells[0].Width = 0x19;
        }
    }

    protected void grdFormName_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Cells[0].Width = 0x19;
            e.Row.Cells[1].Width = 0xaf;
        }
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Cells[0].Width = 30;
            e.Row.Cells[1].Width = 130;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!base.IsPostBack)
        {
            this.bind();
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
