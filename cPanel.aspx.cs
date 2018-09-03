using AjaxControlToolkit;
using ASP;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cPanel : System.Web.UI.Page
{
    private BLL _bll = new BLL();
    //protected Button btnMsgtype;
    //protected Button btnSaveEmailconfig;
    //protected ConfirmButtonExtender btnSaveEmailconfig_ConfirmButtonExtender;
    //protected Button btnUpload;
    //protected Button btnuploadusersig;
    //protected Button Button2;
    //protected ModalPopupExtender Button2_ModalPopupExtender;
    //protected ConfirmButtonExtender ConfirmButtonExtender1;
    //protected DropDownList drpuser;
    //protected FileUpload FileUpload1;
    //protected System.Web.UI.WebControls.Image Image2;
    //protected System.Web.UI.WebControls.Image imgsignature;
    //protected Label lblErrmsg;
    private DAL mycls = new DAL();
    //protected RadioButton rdmsgtpnormal;
    //protected RadioButton rdmsgtppp;
    //protected RegularExpressionValidator RegularExpressionValidator1;
    //protected ValidatorCalloutExtender RegularExpressionValidator1_ValidatorCalloutExtender;
    //protected RequiredFieldValidator RequiredFieldValidator9;
    //protected ValidatorCalloutExtender RequiredFieldValidator9_ValidatorCalloutExtender;
    //protected TextBox txtbody;
    //protected TextBox txtDomainname;
    //protected TextBox txtEmail;
    //protected RequiredFieldValidator txtEmail_RequiredFieldValidator1;
    //protected TextBox txtPassword;
    //protected RequiredFieldValidator txtPassword_RequiredFieldValidator1;
    //protected TextBox txtport;
    //protected RequiredFieldValidator txtport_RequiredFieldValidator1;
    //protected TextBox txtSubject;
    //protected TextBox txtuserid;
    //protected UpdatePanel UpdatePanel1;
    //protected FileUpload uplsign;
    //protected ValidatorCalloutExtender ValidatorCalloutExtender1;
    //protected ValidatorCalloutExtender ValidatorCalloutExtender2;
    //protected ValidatorCalloutExtender ValidatorCalloutExtender3;

    public void bind()
    {
        this.drpuser.DataSource = this._bll.get_InformationdataTable("select cUserName,cUserFullname from Smt_Users order by cUserFullname");
        this.drpuser.DataTextField = "cUserFullname";
        this.drpuser.DataValueField = "cUserName";
        this.drpuser.DataBind();
        this.drpuser.Items.Insert(0, new ListItem(string.Empty, string.Empty));
        this.drpuser.SelectedIndex = 0;
    }

    protected void btnMsgtype_Click(object sender, EventArgs e)
    {
    }

    protected void btnSaveEmailconfig_Click(object sender, EventArgs e)
    {
        string statement = "";
        string[] prClm = new string[] { "@Domain_Name", "@Domain_Port", "@D_Emailid", "@D_Emailpassword", "@Createby", "@Msg_body", "@Msg_subject" };
        string[] prvl = new string[] { this.txtDomainname.Text.Trim(), this.txtport.Text.Trim(), this.txtEmail.Text.Trim(), this.txtPassword.Text.Trim(), this.Session["Uid"].ToString(), this.txtbody.Text, this.txtSubject.Text };
        this.mycls.Save_All(statement, "Sp_Smt_Econfig_Save", prClm, prvl, this.lblErrmsg);
        this.txtDomainname.Text = "";
        this.txtEmail.Text = "";
        this.txtPassword.Text = "";
        this.txtport.Text = "";
        this.txtSubject.Text = "";
        this.txtbody.Text = "";
    }

    protected void btnUpload_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        string str = base.Server.MapPath("rptsv/");
        int num = 0;
        if (this.FileUpload1.FileContent.Length > 0L)
        {
            string extension = Path.GetExtension(this.FileUpload1.FileName);
            string str4 = extension.ToUpper();
            string str5 = "CIMG";
            string path = str + str5 + extension;
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            switch (str4)
            {
                case ".PDF":
                case ".JPG":
                case ".PNG":
                case ".GIF":
                    {
                        this.FileUpload1.SaveAs(path);
                        num++;
                        this.mycls.updtlgo(str5 + extension);
                        DataTable table = this._bll.get_InformationdataTable("SELECT lgo FROM Smt_Company where Display_AS_Header=1");
                        if (table.Rows.Count > 0)
                        {
                            this.Image2.ImageUrl = "rptsv/" + table.Rows[0]["lgo"].ToString();
                        }
                        this.Image2.Visible = true;
                        return;
                    }
            }
            label.Text = "Invalid Image format";
        }
    }

    protected void btnuploadusersig_Click(object sender, EventArgs e)
    {
        Label label = (Label)base.Master.FindControl("lbltotalinfo");
        string str = base.Server.MapPath("imgsign/");
        int num = 0;
        if (this.uplsign.FileContent.Length > 0L)
        {
            Bitmap bitmap = new Bitmap(this.uplsign.FileContent);
            int width = bitmap.Width;
            int height = bitmap.Height;
            int num4 = width / height;
            int num5 = 100;
            int num1 = num5 / num4;
            if (width > 250)
            {
                label.Text = "Width can not be more then 250px";
            }
            else if (height > 70)
            {
                label.Text = "Height can not be more then 70px";
            }
            else
            {
                string extension = Path.GetExtension(this.uplsign.FileName);
                string str4 = extension.ToUpper();
                string selectedValue = this.drpuser.SelectedValue;
                string path = str + selectedValue + extension;
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                switch (str4)
                {
                    case ".JPG":
                    case ".PNG":
                    case ".GIF":
                        {
                            this.uplsign.SaveAs(path);
                            num++;
                            this.mycls.uploadsign(selectedValue + extension, this.drpuser.SelectedValue);
                            DataTable table = this._bll.get_InformationdataTable("SELECT signtr FROM Smt_Users where cUserName='" + this.drpuser.SelectedValue + "'");
                            if (table.Rows.Count > 0)
                            {
                                this.imgsignature.ImageUrl = "imgsign/" + table.Rows[0]["signtr"].ToString();
                            }
                            this.imgsignature.Visible = true;
                            label.Text = "Uploaded Successfully";
                            return;
                        }
                }
                label.Text = "Invalid Image format";
            }
        }
        else
        {
            label.Text = "No file selected";
        }
    }

    protected void drpuser_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.imgsignature.Visible = false;
        this.txtuserid.Text = "";
        this.imgsignature.ImageUrl = null;
        if (!string.IsNullOrEmpty(this.drpuser.SelectedValue))
        {
            this.txtuserid.Text = this.drpuser.SelectedValue;
            DataTable table = this._bll.get_InformationdataTable("SELECT signtr FROM Smt_Users where cUserName='" + this.drpuser.SelectedValue + "'");
            if (table.Rows.Count > 0)
            {
                this.imgsignature.ImageUrl = "imgsign/" + table.Rows[0]["signtr"].ToString();
                this.imgsignature.Visible = true;
            }
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!base.IsPostBack)
        {
            this.bind();
            DataTable table = this._bll.get_InformationdataTable("select Domain_Name,Domain_Port,D_Emailid,D_Emailpassword,Msg_body,Msg_subject from Smt_Econfig");
            if (table.Rows.Count > 0)
            {
                this.txtbody.Text = table.Rows[0]["Msg_body"].ToString();
                this.txtDomainname.Text = table.Rows[0]["Domain_Name"].ToString();
                this.txtEmail.Text = table.Rows[0]["D_Emailid"].ToString();
                this.txtPassword.Text = table.Rows[0]["D_Emailpassword"].ToString();
                this.txtport.Text = table.Rows[0]["Domain_Port"].ToString();
                this.txtSubject.Text = table.Rows[0]["Msg_subject"].ToString();
                DataTable table2 = this._bll.get_InformationdataTable("SELECT lgo FROM Smt_Company where Display_AS_Header=1");
                if (table2.Rows.Count > 0)
                {
                    this.Image2.ImageUrl = "rptsv/" + table2.Rows[0]["lgo"].ToString();
                    this.Image2.Visible = true;
                }
                else
                {
                    this.Image2.ImageUrl = "~/rptsv/lgonoimg.png";
                }
            }
        }
    }

    //protected global_asax ApplicationInstance =>
    //    ((global_asax)this.Context.ApplicationInstance);

    //protected DefaultProfile Profile =>
    //    ((DefaultProfile)this.Context.Profile);
}
