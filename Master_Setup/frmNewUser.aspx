<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmNewUser.aspx.cs" Inherits="Master_Setup_frmNewUser" %>

<%@ Register assembly="C1.Web.UI.Controls.4" namespace="C1.Web.UI.Controls.C1GridView" tagprefix="cc3" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<%@ Register assembly="C1.Web.UI.Controls.4" namespace="C1.Web.UI.Controls.C1TabControl" tagprefix="cc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="../css/Master_Setup.css" rel="stylesheet" type="text/css" />
    <script src="../jquery/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script src="../jquery/Master_SetupFolder.js" type="text/javascript"></script>
</head>
<body onkeydown = "return (event.keyCode!=13)" onload="blinkColor('lblErrormsg')">
    <form id="form1" runat="server">
      <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
       <div style="width: 700px">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
         <cc2:C1TabControl ID="C1TabControl1" runat="server" width="100%"                    
                TextImageRelation="ImageBeforeText">
               <TabPages>
                <cc2:C1TabPage ID="C1TabPage1" TabIndex="0" Text="Add New User" CssClass="tab">
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                        <ContentTemplate>
                            <table style="width:100%;">
                                <tr>
                                    <td valign="top">
                                    <div class="pnlmain">
                                    <div class="pnlheader">Add/Edit User</div>
                                  <div style="height:420px; overflow:auto">
                                        <table style="width: 100%;">
                                            <tr>
                                                <td align="center" colspan="2" height="25px">
                                                    <asp:Label ID="lblErrmsg" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right">
                                                    <asp:Label ID="Label16" runat="server" CssClass="label" Text="User ID"></asp:Label>
                                                </td>
                                                <td align="left">
                                                    <asp:TextBox ID="txtUserid" runat="server" CssClass="textbox" 
                                                        onclick="clearlabel('lbltotalinfo');" Width="200px" MaxLength="10" 
                                                        ontextchanged="txtUserid_TextChanged"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                        ControlToValidate="txtUserid" ErrorMessage="Enter User ID" ValidationGroup="a">*</asp:RequiredFieldValidator>
                                                    <asp:ValidatorCalloutExtender ID="RequiredFieldValidator1_ValidatorCalloutExtender" 
                                                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator1">
                                                    </asp:ValidatorCalloutExtender>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right">
                                                    <asp:Label ID="Label12" runat="server" CssClass="label" Text="User Full Name"></asp:Label>
                                                </td>
                                                <td align="left">
                                                    <asp:TextBox ID="txtfullname" runat="server" CssClass="textbox" 
                                                        onclick="clearlabel('lbltotalinfo');" Width="200px"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                        ControlToValidate="txtfullname" ErrorMessage="Enter Full Name" 
                                                        ValidationGroup="a">*</asp:RequiredFieldValidator>
                                                    <asp:ValidatorCalloutExtender ID="RequiredFieldValidator2_ValidatorCalloutExtender" 
                                                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator2">
                                                    </asp:ValidatorCalloutExtender>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right">
                                                    <asp:Label ID="Label2" runat="server" CssClass="label" Text="Password"></asp:Label>
                                                </td>
                                                <td align="left">
                                                    <asp:TextBox ID="txtPassword" runat="server" CssClass="textbox" MaxLength="8" 
                                                        onclick="clearlabel('lbltotalinfo');" TextMode="Password" Width="200px"></asp:TextBox>
                                                    <asp:PasswordStrength ID="txtPassword_PasswordStrength" runat="server" 
                                                        Enabled="True" MinimumUpperCaseCharacters="1" 
                                                        RequiresUpperAndLowerCaseCharacters="True" StrengthIndicatorType="BarIndicator" 
                                                        TargetControlID="txtPassword">
                                                    </asp:PasswordStrength>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                        ControlToValidate="txtPassword" Display="None" ErrorMessage="Enter password" 
                                                        ValidationGroup="a">*</asp:RequiredFieldValidator>
                                                    <asp:ValidatorCalloutExtender ID="RequiredFieldValidator3_ValidatorCalloutExtender" 
                                                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator3">
                                                    </asp:ValidatorCalloutExtender>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right">
                                                    <asp:Label ID="Label6" runat="server" CssClass="label" Text="Confirm Password"></asp:Label>
                                                </td>
                                                <td align="left">
                                                    <asp:TextBox ID="txtconfirmpassword" runat="server" CssClass="textbox" 
                                                        onclick="clearlabel('lbltotalinfo');" TextMode="Password" Width="200px"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                                        ControlToValidate="txtconfirmpassword" Display="None" 
                                                        ErrorMessage="Enter Confirm password" ValidationGroup="a">*</asp:RequiredFieldValidator>
                                                    <asp:ValidatorCalloutExtender ID="RequiredFieldValidator4_ValidatorCalloutExtender" 
                                                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator4">
                                                    </asp:ValidatorCalloutExtender>
                                                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                                        ControlToCompare="txtPassword" ControlToValidate="txtconfirmpassword" 
                                                        Display="None" ErrorMessage="Password Mismatch" ValidationGroup="a">*</asp:CompareValidator>
                                                    <asp:ValidatorCalloutExtender ID="CompareValidator1_ValidatorCalloutExtender" 
                                                        runat="server" Enabled="True" TargetControlID="CompareValidator1">
                                                    </asp:ValidatorCalloutExtender>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right">
                                                    <asp:Label ID="Label8" runat="server" CssClass="label" Text="Company Name"></asp:Label>
                                                </td>
                                                <td align="left">
                                                    <asp:DropDownList ID="drpCompany" runat="server" CssClass="textbox" 
                                                        onclick="clearlabel('lbltotalinfo');" Width="200px" AutoPostBack="True" 
                                                        onselectedindexchanged="drpCompany_SelectedIndexChanged">
                                                    </asp:DropDownList>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                                        ControlToValidate="drpCompany" ErrorMessage="Select Company Name" 
                                                        ValidationGroup="a">*</asp:RequiredFieldValidator>
                                                    <asp:ValidatorCalloutExtender ID="RequiredFieldValidator6_ValidatorCalloutExtender" 
                                                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator6">
                                                    </asp:ValidatorCalloutExtender>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right">
                                                    <asp:Label ID="Label13" runat="server" CssClass="label" Text="Department"></asp:Label>
                                                </td>
                                                <td align="left">
                                                    <asp:DropDownList ID="drpDepartment" runat="server" CssClass="textbox" 
                                                        onclick="clearlabel('lbltotalinfo');" Width="200px" AutoPostBack="True" 
                                                        onselectedindexchanged="drpDepartment_SelectedIndexChanged">
                                                    </asp:DropDownList>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                                        ControlToValidate="drpDepartment" ErrorMessage="Select Department" 
                                                        ValidationGroup="a">*</asp:RequiredFieldValidator>
                                                    <asp:ValidatorCalloutExtender ID="RequiredFieldValidator7_ValidatorCalloutExtender" 
                                                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator7">
                                                    </asp:ValidatorCalloutExtender>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right">
                                                    <asp:Label ID="Label9" runat="server" CssClass="label" Text="Section"></asp:Label>
                                                </td>
                                                <td align="left">
                                                    <asp:DropDownList ID="drpSection" runat="server" CssClass="textbox" 
                                                        onclick="clearlabel('lbltotalinfo');" Width="200px">
                                                    </asp:DropDownList>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                                                        ControlToValidate="drpSection" ErrorMessage="Select Section" 
                                                        ValidationGroup="a">*</asp:RequiredFieldValidator>
                                                    <asp:ValidatorCalloutExtender ID="RequiredFieldValidator8_ValidatorCalloutExtender" 
                                                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator8">
                                                    </asp:ValidatorCalloutExtender>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right">
                                                    <asp:Label ID="Label15" runat="server" CssClass="label" 
                                                        Text="Permission Status"></asp:Label>
                                                </td>
                                                <td align="left">
                                                    <asp:RadioButton ID="rdGroupwise" runat="server" AutoPostBack="True" 
                                                        Checked="True" GroupName="b" oncheckedchanged="rdGroupwise_CheckedChanged" 
                                                        Text="Group wise" />
                                                    <asp:RadioButton ID="rdUserwise" runat="server" AutoPostBack="True" 
                                                        GroupName="b" 
                                                        Text="User wise" oncheckedchanged="rdUserwise_CheckedChanged" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right">
                                                    <asp:Label ID="Label10" runat="server" CssClass="label" Text="User Group"></asp:Label>
                                                </td>
                                                <td align="left">
                                                    <asp:DropDownList ID="drpUsergroup" runat="server" CssClass="textbox" 
                                                        onclick="clearlabel('lbltotalinfo');" Width="200px">
                                                    </asp:DropDownList>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                                                        ControlToValidate="drpUsergroup" ErrorMessage="Select User Group" 
                                                        ValidationGroup="a">*</asp:RequiredFieldValidator>
                                                    <asp:ValidatorCalloutExtender ID="RequiredFieldValidator9_ValidatorCalloutExtender" 
                                                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator9">
                                                    </asp:ValidatorCalloutExtender>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right">
                                                    <asp:Label ID="Label14" runat="server" CssClass="label" Text="Email"></asp:Label>
                                                </td>
                                                <td align="left">
                                                    <asp:TextBox ID="txtEmail" runat="server" CssClass="textbox" 
                                                        onclick="clearlabel('lbltotalinfo');" Width="200px"></asp:TextBox>
                                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                                        ControlToValidate="txtEmail" ErrorMessage="Enter Valid Email ID" 
                                                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                                                        ValidationGroup="a">*</asp:RegularExpressionValidator>
                                                    <asp:ValidatorCalloutExtender ID="RegularExpressionValidator1_ValidatorCalloutExtender" 
                                                        runat="server" Enabled="True" TargetControlID="RegularExpressionValidator1">
                                                    </asp:ValidatorCalloutExtender>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right">
                                                    <asp:Label ID="Label11" runat="server" CssClass="label" Text="Status"></asp:Label>
                                                </td>
                                                <td align="left">
                                                    <asp:RadioButton ID="rdActive" runat="server" Checked="True" GroupName="t" 
                                                        onclick="clearlabel('lbltotalinfo');" Text="Active" />
                                                    <asp:RadioButton ID="rdInactive" runat="server" GroupName="t" 
                                                        onclick="clearlabel('lbltotalinfo');" Text="Inactive" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                   <asp:Label ID="lblUserid" runat="server" Visible="False"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right">
                                                    &nbsp;</td>
                                                <td align="left" valign="top">
                                                    <asp:Button ID="btnClear" runat="server" CssClass="button" 
                                                        onclick="btnClear_Click" Text="Clear" ToolTip="Clear text" Width="80px" />
                                                    <asp:Button ID="btnSave" runat="server" CssClass="button" 
                                                        onclick="btnSave_Click" Text="Save" ValidationGroup="a" Width="80px" />
                                                    <asp:ConfirmButtonExtender ID="btnSave_ConfirmButtonExtender" runat="server" 
                                                        ConfirmText="Do you want to save this data?" Enabled="True" 
                                                        TargetControlID="btnSave">
                                                    </asp:ConfirmButtonExtender>
                                                </td>
                                            </tr>
                                        </table>
                                        </div>
                                          </div>
                                    </td>
                                    <td valign="top" width="360px">
                                     <div class="pnlmain">                                     
                                    <div class="pnlheader">Select Form for permission</div>
                                    <div style="height:420px; overflow:auto">
                                        <asp:GridView ID="grdFormlist" runat="server" 
                                            AutoGenerateColumns="False"
                                            onprerender="grdFormlist_PreRender" onrowdatabound="grdFormlist_RowDataBound" 
                                            Width="98%" CssClass="mGrid">
                                            <AlternatingRowStyle CssClass="grdAltr" />
                                            <Columns>
                                                <asp:BoundField DataField="Module_Name" HeaderText="Module Name" 
                                                    SortExpression="Module_Name" />
                                                <asp:BoundField DataField="Form_Name" HeaderText="Form Name" 
                                                    SortExpression="Form_Name" />                                             
                                                <asp:TemplateField>
                                                    <ItemTemplate>
                                                        <asp:CheckBox ID="chkSelect" runat="server" Enabled="false" Height="16px" />
                                                         <asp:ToggleButtonExtender ID="CheckBox1_ToggleButtonExtender" runat="server" 
                                                                Enabled="True" CheckedImageUrl="~/gridimage/CheckbCheck.png" ImageHeight="19" ImageWidth="19"
                                                                 UncheckedImageUrl="~/gridimage/CheckBuncheck.gif" TargetControlID="chkSelect">
                                                          </asp:ToggleButtonExtender>
                                                        <asp:Label ID="lblUrl" runat="server" Text='<%# Eval("Url") %>' Visible="false"></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                            </Columns>
                                            <HeaderStyle CssClass="grdHdr" />
                                            <RowStyle CssClass="grdRow" />
                                        </asp:GridView>
                                       
                                        </div>
                                        </div>
                                    </td>
                                </tr>
                            </table>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                  
                </cc2:C1TabPage>
                <cc2:C1TabPage ID="C1TabPage2"  TabIndex="1" Text="Edit/View"  CssClass="tab">
                   <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                   <ContentTemplate>
                   <div class="pnlmain" style="height:450px">
                    <div class="pnlheader"> </div>
                         <div style="height:445px; overflow:auto">
                        <cc3:C1GridView ID="C1GridView1" runat="server" AllowColMoving="True" 
                            AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" 
                            AutoGenerateSelectButton="True" DataKeyNames="nUserID" 
                            onrowcommand="C1GridView1_RowCommand" 
                            onrowdatabound="C1GridView1_RowDataBound" PageSize="20" ShowFilter="True" 
                            VisualStyle="Office2007Blue" VisualStylePath="~/C1WebControls/VisualStyles" 
                            Width="100%" 
                            AllowColSizing="True" 
                            onfiltering="C1GridView1_Filtering" 
                            onpageindexchanging="C1GridView1_PageIndexChanging">
                            <Columns>
                                <cc3:C1TemplateField Visible="false">
                                    <ItemTemplate>
                                        <asp:Label ID="lblid" runat="server" Text='<%# Eval("cUserName") %>'></asp:Label>
                                    </ItemTemplate>
                                </cc3:C1TemplateField>
                                <cc3:C1BoundField DataField="cUserName" HeaderText="User ID" 
                                    SortExpression="cUserName">
                                </cc3:C1BoundField>
                                <cc3:C1BoundField DataField="cUserFullname" HeaderText="Full Name" 
                                    SortExpression="cUserFullname">
                                </cc3:C1BoundField>
                                <cc3:C1BoundField DataField="cDeptname" HeaderText="Department" 
                                    SortExpression="cDeptname">
                                </cc3:C1BoundField>
                                <cc3:C1BoundField DataField="cCmpName" HeaderText="Company" 
                                    SortExpression="cCmpName">
                                </cc3:C1BoundField>
                                <cc3:C1BoundField DataField="cGrpDescription" HeaderText="Group" 
                                    ShowFilter="true" SortExpression="">
                                </cc3:C1BoundField>
                                <cc3:C1BoundField DataField="Permission_status" HeaderText="Permission" 
                                    ShowFilter="false" SortExpression="Permission_status">
                                </cc3:C1BoundField>
                            </Columns>
                            <PagerSettings PageButtonCount="20" Mode="NextPrevious" />
                        </cc3:C1GridView>
                                                
              
                 
                          <%--   <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                 ConnectionString="<%$ ConnectionStrings:mconuser %>" 
                                 SelectCommand="SELECT * FROM [View_Smt_User] order by cUserFullname"></asp:SqlDataSource>--%>
                                                
              
                 
                  </div>
                  </div>
                        </ContentTemplate>
                        </asp:UpdatePanel>     
               
                                  
                </cc2:C1TabPage>
             
              
            </TabPages>
                </cc2:C1TabControl>
        </ContentTemplate>
        </asp:UpdatePanel>
       </div>
    
    </div>
    </form>
</body>
</html>

