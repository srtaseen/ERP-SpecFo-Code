using AjaxControlToolkit;
//using C1.Web.UI.Controls.C1ComboBox;
//using C1.Web.UI.Controls.C1TabControl;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using System.Windows.Forms;

public class BLL
{
    private SqlConnection cn = GetWay.SpecFoCon;

    //public void c1combobox(C1.Web.UI.Controls.C1ComboBox.C1ComboBox drp, string selectstatement, int txt, int val)
    //{
    //    SqlDataAdapter adapter = new SqlDataAdapter(selectstatement, this.cn);
    //    if (this.cn.State == ConnectionState.Closed)
    //    {
    //        this.cn.Open();
    //    }
    //    DataSet dataSet = new DataSet();
    //    adapter.Fill(dataSet);
    //    drp.DataSource = dataSet;
    //    drp.DataTextField = dataSet.Tables[0].Columns[txt].ToString();
    //    drp.DataValueField = dataSet.Tables[0].Columns[val].ToString();
    //    drp.DataBind();
    //    if (this.cn.State == ConnectionState.Open)
    //    {
    //        this.cn.Close();
    //    }
    //}

    //public void ClearAllcontrol(System.Web.UI.Control parent)
    //{
    //    foreach (System.Web.UI.Control control in parent.Controls)
    //    {
    //        if (control.Controls.Count > 0)
    //        {
    //            this.ClearAllcontrol(control);
    //        }
    //        else
    //        {
    //            if (control is System.Web.UI.WebControls.TextBox)
    //            {
    //                ((System.Web.UI.WebControls.TextBox)control).Text = "";
    //            }
    //            if (control is DropDownList)
    //            {
    //                ((DropDownList)control).DataSource = null;
    //            }
    //            if (control is System.Web.UI.WebControls.CheckBox)
    //            {
    //                ((System.Web.UI.WebControls.CheckBox)control).Checked = false;
    //            }
    //            if (control is System.Web.UI.WebControls.RadioButton)
    //            {
    //                ((System.Web.UI.WebControls.RadioButton)control).Checked = false;
    //            }
    //            if (control is GridView)
    //            {
    //                ((GridView)control).DataSource = null;
    //            }
    //        }
    //    }
    //}

    public void ClearErrormsg(System.Web.UI.Control parent, System.Web.UI.WebControls.Label lbl)
    {
        foreach (System.Web.UI.Control control in parent.Controls)
        {
            if (control.Controls.Count > 0)
            {
                this.ClearErrormsg(control, lbl);
            }
            else
            {
                if (control is System.Web.UI.WebControls.TextBox)
                {
                    ((System.Web.UI.WebControls.TextBox)control).Attributes.Add("onclick", "javascript:clearlabel('" + lbl.ClientID + "')");
                }
                if (control is DropDownList)
                {
                    ((DropDownList)control).Attributes.Add("onclick", "javascript:clearlabel('" + lbl.ClientID + "')");
                }
                if (control is System.Web.UI.WebControls.CheckBox)
                {
                    ((System.Web.UI.WebControls.CheckBox)control).Attributes.Add("onclick", "javascript:clearlabel('" + lbl.ClientID + "')");
                }
                if (control is System.Web.UI.WebControls.RadioButton)
                {
                    ((System.Web.UI.WebControls.RadioButton)control).Attributes.Add("onclick", "javascript:clearlabel('" + lbl.ClientID + "')");
                }
                if (control is GridView)
                {
                    ((GridView)control).Attributes.Add("onclick", "javascript:clearlabel('" + lbl.ClientID + "')");
                }
                if (control is TabContainer)
                {
                    ((TabContainer)control).Attributes.Add("onclick", "javascript:clearlabel('" + lbl.ClientID + "')");
                }
                if (control is TabContainer)
                {
                    ((TabContainer)control).Attributes.Add("onclick", "javascript:clearlabel('" + lbl.ClientID + "')");
                }
                if (control is C1.Web.UI.Controls.C1TabControl.C1TabControl)
                {
                    ((C1.Web.UI.Controls.C1TabControl.C1TabControl)control).Attributes.Add("onclick", "javascript:clearlabel('" + lbl.ClientID + "')");
                }
                if (control is System.Web.UI.WebControls.Button)
                {
                    ((System.Web.UI.WebControls.Button)control).Attributes.Add("onclick", "javascript:clearlabel('" + lbl.ClientID + "')");
                }
                if (control is System.Web.UI.WebControls.CheckBox)
                {
                    ((System.Web.UI.WebControls.CheckBox)control).Attributes.Add("onclick", "javascript:clearlabel('" + lbl.ClientID + "')");
                }
                if (control is System.Web.UI.WebControls.RadioButton)
                {
                    ((System.Web.UI.WebControls.RadioButton)control).Attributes.Add("onclick", "javascript:clearlabel('" + lbl.ClientID + "')");
                }
            }
        }
    }

    //public string Decrypt(string cipherString)
    //{
    //    cipherString = cipherString.Replace("azbycx", "");
    //    char[] chArray = cipherString.ToCharArray();
    //    cipherString = "";
    //    for (int i = chArray.Length; i > 0; i--)
    //    {
    //        cipherString = cipherString + chArray[i - 1].ToString();
    //    }
    //    return cipherString;
    //}

    public void dropdown(DropDownList drp, string table, string OrderBy, int txt, int val)
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select * from " + table + " order by " + OrderBy, this.cn);
        if ((this.cn.State == ConnectionState.Closed) || (this.cn.State == ConnectionState.Broken))
        {
            this.cn.Open();
        }
        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet, table);
        drp.Items.Add(new ListItem("", ""));
        drp.DataSource = dataSet;
        drp.DataTextField = dataSet.Tables[0].Columns[txt].ToString();
        drp.DataValueField = dataSet.Tables[0].Columns[val].ToString();
        drp.DataBind();
        drp.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        drp.SelectedIndex = 0;
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    //public void dropdownnotnull(DropDownList drp, string table, int txt, int val)
    //{
    //    SqlDataAdapter adapter = new SqlDataAdapter("select * from " + table, this.cn);
    //    if (this.cn.State == ConnectionState.Closed)
    //    {
    //        this.cn.Open();
    //    }
    //    DataSet dataSet = new DataSet();
    //    adapter.Fill(dataSet, table);
    //    drp.DataSource = dataSet;
    //    drp.DataTextField = dataSet.Tables[0].Columns[txt].ToString();
    //    drp.DataValueField = dataSet.Tables[0].Columns[val].ToString();
    //    drp.DataBind();
    //    if (this.cn.State == ConnectionState.Open)
    //    {
    //        this.cn.Close();
    //    }
    //}

    //public void drpcombo(AjaxControlToolkit.ComboBox drp, string table, int txt, int val)
    //{
    //    SqlDataAdapter adapter = new SqlDataAdapter("select * from " + table, this.cn);
    //    if (this.cn.State == ConnectionState.Closed)
    //    {
    //        this.cn.Open();
    //    }
    //    DataSet dataSet = new DataSet();
    //    adapter.Fill(dataSet, table);
    //    drp.Items.Add(new ListItem("", ""));
    //    drp.DataSource = dataSet;
    //    drp.DataTextField = dataSet.Tables[0].Columns[txt].ToString();
    //    drp.DataValueField = dataSet.Tables[0].Columns[val].ToString();
    //    drp.DataBind();
    //    drp.Items.Insert(0, new ListItem(string.Empty, string.Empty));
    //    drp.SelectedIndex = 0;
    //    if (this.cn.State == ConnectionState.Open)
    //    {
    //        this.cn.Close();
    //    }
    //}

    //public void drpwithstatement(DropDownList drp, string selectstatement, int txt, int val)
    //{
    //    SqlDataAdapter adapter = new SqlDataAdapter(selectstatement, this.cn);
    //    if (this.cn.State == ConnectionState.Closed)
    //    {
    //        this.cn.Open();
    //    }
    //    DataSet dataSet = new DataSet();
    //    adapter.Fill(dataSet);
    //    drp.DataSource = dataSet;
    //    drp.DataTextField = dataSet.Tables[0].Columns[txt].ToString();
    //    drp.DataValueField = dataSet.Tables[0].Columns[val].ToString();
    //    drp.DataBind();
    //    if (this.cn.State == ConnectionState.Open)
    //    {
    //        this.cn.Close();
    //    }
    //}

    //public string Encrypt(string cipherString)
    //{
    //    char[] chArray = cipherString.ToCharArray();
    //    cipherString = "";
    //    for (int i = chArray.Length; i > 0; i--)
    //    {
    //        cipherString = cipherString + chArray[i - 1].ToString() + "***";
    //    }
    //    return cipherString;
    //}

    public DataSet get_Informationdataset(string sqlstatement)
    {
        SqlDataAdapter adapter = new SqlDataAdapter(sqlstatement, this.cn);
        if ((this.cn.State == ConnectionState.Closed) || (this.cn.State == ConnectionState.Broken))
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

    public DataTable get_InformationdataTable(string sqlstatement)
{
    SqlDataAdapter adapter = new SqlDataAdapter();
    SqlCommand command = this.cn.CreateCommand();
    command.CommandText = sqlstatement;
    adapter.SelectCommand = command;
    command.CommandTimeout = 600;
    DataTable dataTable = new DataTable();
    if (this.cn.State == ConnectionState.Closed)
    {
        this.cn.Open();
    }
    adapter.Fill(dataTable);
    if (this.cn.State == ConnectionState.Open)
    {
        this.cn.Close();
    }
    return dataTable;
}


    public DataTable get_InformationdataTable1(string sqlstatement)
    {
        DataTable dataTable = new DataTable();
        using (SqlConnection connection = GetWay.SpecFoCon)
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter(sqlstatement, connection))
            {
                connection.Open();
                adapter.Fill(dataTable);
            }
        }
        return dataTable;
    }

    public DataTable get_InformationdataTabletst(string sesion)
    {
        SqlDataAdapter adapter = new SqlDataAdapter("Sp_Smt_StyleMaster_GetAllbyUserGroup '" + sesion + "'", this.cn);
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

    public DataSet mastersearch_exectvalue(string selectfield, string tablename, string[] searchfield, string[] searchvalue)
    {
        string str = "select " + selectfield + " from " + tablename;
        bool flag = true;
        for (int i = 0; i <= (searchfield.Length - 1); i++)
        {
            if (!string.IsNullOrEmpty(searchvalue[i]))
            {
                if (flag)
                {
                    string str2 = str;
                    str = str2 + " where " + searchfield[i] + " = '" + searchvalue[i] + "'";
                    flag = false;
                }
                else
                {
                    str = str + " and " + searchfield[i] + " = '" + searchvalue[i] + "'";
                }
            }
        }
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        SqlCommand selectCommand = new SqlCommand("", this.cn)
        {
            CommandText = str
        };
        SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);
        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet);
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
        return dataSet;
    }

    public void Show(string message)
    {
        string str = message.Replace("'", "'");
        string script = "<script type=text/javascript>alert('" + str + "');</script>";
        Page currentHandler = HttpContext.Current.CurrentHandler as Page;
        if ((currentHandler != null) && !currentHandler.ClientScript.IsClientScriptBlockRegistered("alert"))
        {
            //currentHandler.ClientScript.RegisterClientScriptBlock(typeof(MessageBox), "alert", script);
        }
    }
}
