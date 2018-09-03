using AjaxControlToolkit;
using C1.Web.UI.Controls.C1ComboBox;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Web.UI.Design;
using System.Design;

public class BLLInventory
{
    private SqlConnection cn = GetWay.SpecFo_Inventorycon;

    public void c1combobox(C1.Web.UI.Controls.C1ComboBox.C1ComboBox drp, string selectstatement, int txt, int val)
    {
        SqlDataAdapter adapter = new SqlDataAdapter(selectstatement, this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet);
        drp.DataSource = dataSet;
        drp.DataTextField = dataSet.Tables[0].Columns[txt].ToString();
        drp.DataValueField = dataSet.Tables[0].Columns[val].ToString();
        drp.DataBind();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void dropdown(DropDownList drp, string table, string OrderBy, int txt, int val)
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select * from " + table + " Order By " + OrderBy, this.cn);
        if (this.cn.State == ConnectionState.Closed)
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

    public void dropdownnotnull(DropDownList drp, string table, int txt, int val)
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select * from " + table, this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet, table);
        drp.DataSource = dataSet;
        drp.DataTextField = dataSet.Tables[0].Columns[txt].ToString();
        drp.DataValueField = dataSet.Tables[0].Columns[val].ToString();
        drp.DataBind();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public void drpcombo(DropDownList drp, string table, int txt, int val)
    {
        SqlDataAdapter adapter = new SqlDataAdapter("select * from " + table, this.cn);
        if (this.cn.State == ConnectionState.Closed)
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

    public void drpwithstatement(DropDownList drp, string selectstatement, int txt, int val)
    {
        SqlDataAdapter adapter = new SqlDataAdapter(selectstatement, this.cn);
        if (this.cn.State == ConnectionState.Closed)
        {
            this.cn.Open();
        }
        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet);
        drp.DataSource = dataSet;
        drp.DataTextField = dataSet.Tables[0].Columns[txt].ToString();
        drp.DataValueField = dataSet.Tables[0].Columns[val].ToString();
        drp.DataBind();
        if (this.cn.State == ConnectionState.Open)
        {
            this.cn.Close();
        }
    }

    public DataSet get_Informationdataset(string sqlstatement)
    {
        SqlDataAdapter adapter = new SqlDataAdapter(sqlstatement, this.cn);
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

    public DataTable get_InformationdataTable(string sqlstatement)
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand command = this.cn.CreateCommand();
        command.CommandText = sqlstatement;
        adapter.SelectCommand = command;
        command.CommandTimeout = 800;
        DataTable dataTable = new DataTable();
        this.cn.Open();
        adapter.Fill(dataTable);
        this.cn.Close();
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
}
