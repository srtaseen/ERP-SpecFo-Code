using AjaxControlToolkit;
using ASP;
using System;
using System.Data;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Master_Setup_Smt_Storage : System.Web.UI.Page
{
    private BLLInventory _blInventory = new BLLInventory();
    private DALInventory _dalInventory = new DALInventory();
    //protected Button btnClear;
    //protected Button btnSave;
    //protected ConfirmButtonExtender btnSave_ConfirmButtonExtender;
    //protected HtmlForm form1;
    //protected GridView grdStorage;
    //protected HtmlHead Head1;
    //protected Label lblErrormsg;
    //protected Label lblStoreID;
    //protected RequiredFieldValidator RequiredFieldValidator21;
    //protected ValidatorCalloutExtender RequiredFieldValidator21_ValidatorCalloutExtender;
    //protected ScriptManager ScriptManager1;
    //protected TextBox txtBlock;
    //protected FilteredTextBoxExtender txtBlock_FilteredTextBoxExtender;
    //protected RequiredFieldValidator txtBlock_RequiredFieldValidator1;
    //protected ValidatorCalloutExtender txtBlock_ValidatorCalloutExtender1;
    //protected TextBox txtCell;
    //protected FilteredTextBoxExtender txtCell_FilteredTextBoxExtender1;
    //protected RequiredFieldValidator txtCell_RequiredFieldValidator1;
    //protected ValidatorCalloutExtender txtCell_ValidatorCalloutExtender1;
    //protected TextBox txtRack;
    //protected FilteredTextBoxExtender txtRack_FilteredTextBoxExtender1;
    //protected RequiredFieldValidator txtRack_RequiredFieldValidator1;
    //protected ValidatorCalloutExtender txtRack_ValidatorCalloutExtender1;
    //protected TextBox txtStorageName;
    //protected UpdatePanel UpdatePanel1;

    public void bindgrid()
    {
        this.grdStorage.DataSource = this._blInventory.get_InformationdataTable("SELECT [Storage_Sl], [Storage_Name], [Storage_Block], [Storage_Rack], [Storage_Cell] FROM [Smt_StorageMasterPlane]");
        this.grdStorage.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.txtBlock.Text = "";
        this.txtCell.Text = "";
        this.txtRack.Text = "";
        this.txtStorageName.Text = "";
        this.lblStoreID.Text = "";
        this.bindgrid();
        this.txtStorageName.Enabled = true;
        this.txtStorageName.Focus();
        this.btnSave.Text = "Save";
        this.btnSave.ToolTip = "Save";
        this.lblErrormsg.Text = "";
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(this.lblStoreID.Text))
        {
            this._dalInventory.Update_StoragePlane(int.Parse(this.lblStoreID.Text), int.Parse(this.txtBlock.Text), int.Parse(this.txtRack.Text), int.Parse(this.txtCell.Text), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        else
        {
            this._dalInventory.Save_StoragePlane(this.txtStorageName.Text, int.Parse(this.txtBlock.Text), int.Parse(this.txtRack.Text), int.Parse(this.txtCell.Text), this.Session["Uid"].ToString(), this.lblErrormsg);
        }
        if (this.lblErrormsg.Text != "Already Exist")
        {
            this.txtBlock.Text = "";
            this.txtCell.Text = "";
            this.txtRack.Text = "";
            this.txtStorageName.Text = "";
            this.lblStoreID.Text = "";
            this.bindgrid();
            this.txtStorageName.Enabled = true;
            this.txtStorageName.Focus();
        }
    }

    protected void grdStorage_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        this.grdStorage.PageIndex = e.NewPageIndex;
        this.bindgrid();
    }

    protected void grdStorage_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Select")
        {
            int num = int.Parse(e.CommandArgument.ToString());
            Label label = (Label)this.grdStorage.Rows[num].FindControl("lblid");
            DataTable table = this._blInventory.get_InformationdataTable("select Storage_Sl,Storage_Name,Storage_Block,Storage_Rack,Storage_Cell from Smt_StorageMasterPlane where Storage_Sl=" + int.Parse(label.Text));
            this.txtStorageName.Text = table.Rows[0]["Storage_Name"].ToString();
            this.txtBlock.Text = table.Rows[0]["Storage_Block"].ToString();
            this.txtRack.Text = table.Rows[0]["Storage_Rack"].ToString();
            this.txtCell.Text = table.Rows[0]["Storage_Cell"].ToString();
            this.lblStoreID.Text = table.Rows[0]["Storage_Sl"].ToString();
            this.txtStorageName.Enabled = false;
            this.btnSave.Text = "Update";
            this.btnSave.ToolTip = "Update";
            this.lblErrormsg.Text = "";
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!base.IsPostBack)
        {
            this.txtStorageName.Focus();
            this.bindgrid();
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
