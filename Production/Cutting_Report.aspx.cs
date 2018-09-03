﻿using AjaxControlToolkit;
using ASP;
using System;
using System.Text;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Production_Cutting_Report : System.Web.UI.Page
{
    //protected Button btnGeneraterpt;
    //protected ImageButton cal;
    //protected ImageButton cal2;
    //protected DropDownList drpcompany;
    //protected Label lblinfo;
    private DAL mycls = new DAL();
    //protected RequiredFieldValidator rdcompany;
    //protected ValidatorCalloutExtender rdcompany_ValidatorCalloutExtender;
    //protected ValidatorCalloutExtender rdcompany_ValidatorCalloutExtender2;
    //protected RadioButton rdCuttingd2d;
    //protected RadioButton rdDailycutsummery;
    //protected RequiredFieldValidator rqFormdt;
    //protected ValidatorCalloutExtender rqFormdt_ValidatorCalloutExtender;
    //protected RequiredFieldValidator rqTodate;
    //protected ValidatorCalloutExtender rqTodate_ValidatorCalloutExtender;
    //protected ValidatorCalloutExtender rqTodate_ValidatorCalloutExtender2;
    //protected TextBox txtFormdate;
    //protected CalendarExtender txtFormdate_CalendarExtender;
    //protected CalendarExtender txtFormdate_CalendarExtender2;
    //protected TextBox txtTodate;
    //protected CalendarExtender txtTodate_CalendarExtender;
    //protected CalendarExtender txtTodate_CalendarExtender2;
    //protected UpdatePanel UpdatePanel4;

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (this.rdDailycutsummery.Checked)
        {
            this.Session["param"] = "DailyCut";
            this.Session["dt1"] = this.txtFormdate.Text;
            this.Session["com"] = this.drpcompany.SelectedValue;
            this.Session["comname"] = this.drpcompany.SelectedItem.ToString();
        }
        if (this.rdCuttingd2d.Checked)
        {
            this.Session["param"] = "DailyCutD2D";
            this.Session["dt1"] = this.txtFormdate.Text;
            this.Session["dt2"] = this.txtTodate.Text;
        }
        this.runjQueryCode("window.open('showreport.aspx','popup','location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')");
    }

    private string getjQueryCode(string jsCodetoRun)
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine("$(document).ready(function() {");
        builder.AppendLine(jsCodetoRun);
        builder.AppendLine(" });");
        return builder.ToString();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!base.IsPostBack)
        {
            this.mycls.drp_Company(this.drpcompany);
        }
    }

    protected void rdCuttingd2d_CheckedChanged(object sender, EventArgs e)
    {
        this.rqFormdt.Enabled = true;
        this.rqTodate.Enabled = true;
        this.rdcompany.Enabled = false;
        this.btnGeneraterpt.Enabled = true;
        this.cal.Enabled = true;
        this.cal2.Enabled = true;
        this.txtFormdate.Text = "";
        this.txtTodate.Text = "";
        this.drpcompany.Enabled = false;
        this.drpcompany.SelectedIndex = 0;
        this.lblinfo.Text = "Information : </br></br>1.Enter Form Date.</br>2.Enter To Date.</br></br>-Click Generate Report Button";
    }

    protected void rdDailycutsummery_CheckedChanged(object sender, EventArgs e)
    {
        this.rqFormdt.Enabled = true;
        this.rqTodate.Enabled = false;
        this.btnGeneraterpt.Enabled = true;
        this.cal.Enabled = true;
        this.cal2.Enabled = false;
        this.drpcompany.SelectedIndex = 0;
        this.txtFormdate.Text = "";
        this.txtTodate.Text = "";
        this.rdcompany.Enabled = true;
        this.drpcompany.Enabled = true;
        this.lblinfo.Text = "Information : </br></br>1.Enter Form Date.</br>2.Select Company.</br></br>-Click Generate Report Button";
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
