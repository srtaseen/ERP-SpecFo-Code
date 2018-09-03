<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmSection.aspx.cs" Inherits="Master_Setup_frmSection" %>

<%@ Register assembly="C1.Web.UI.Controls.4" namespace="C1.Web.UI.Controls.C1GridView" tagprefix="cc1" %>
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
<body onload="blinkColor()">
    <form id="form1" runat="server">
      <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
       <div style="width: 750px">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table style="width: 100%;">
                <tr>
                    <td valign="top">
                        <div style="border:1px solid silver; height:500px">
                        <table style="width:100%;">
                             <tr>
                                 <td align="center" colspan="2" height="22px">
                                     <asp:Label ID="lblsectid" runat="server" Visible="False"></asp:Label>
                                     <asp:Label ID="lblErrormsg" runat="server"></asp:Label>
                                 </td>
                             </tr>
                             <tr>
                                 <td align="right" width="120">
                                     &nbsp;</td>
                                 <td align="left">
                                     &nbsp;</td>
                             </tr>
                             <tr>
                                 <td align="right" width="120">
                                     <asp:Label ID="Label7" runat="server" CssClass="label" Text="Company Name"></asp:Label>
                                 </td>
                                 <td align="left">
                                     <asp:DropDownList ID="drpCompany" runat="server" AutoPostBack="True" 
                                         CssClass="textbox" onselectedindexchanged="drpCompany_SelectedIndexChanged" 
                                         Width="150px">
                                     </asp:DropDownList>
                                     <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                         ControlToValidate="drpCompany" Display="None" ErrorMessage="Select Company" 
                                         ValidationGroup="a">*</asp:RequiredFieldValidator>
                                     <asp:ValidatorCalloutExtender ID="RequiredFieldValidator5_ValidatorCalloutExtender" 
                                         runat="server" Enabled="True" TargetControlID="RequiredFieldValidator5">
                                     </asp:ValidatorCalloutExtender>
                                 </td>
                             </tr>
                             <tr>
                                 <td align="right">
                                     <asp:Label ID="Label6" runat="server" CssClass="label" Text="Department"></asp:Label>
                                 </td>
                                 <td align="left">
                                     <asp:DropDownList ID="drpDepartment" runat="server" CssClass="textbox" 
                                         Width="150px">
                                     </asp:DropDownList>
                                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                         ControlToValidate="drpDepartment" Display="None" 
                                         ErrorMessage="Select Department" ValidationGroup="a">*</asp:RequiredFieldValidator>
                                     <asp:ValidatorCalloutExtender ID="RequiredFieldValidator1_ValidatorCalloutExtender" 
                                         runat="server" Enabled="True" TargetControlID="RequiredFieldValidator1">
                                     </asp:ValidatorCalloutExtender>
                                 </td>
                             </tr>
                             <tr>
                                 <td align="right">
                                     <asp:Label ID="Label1" runat="server" CssClass="label" 
                                         Text="Section Description"></asp:Label>
                                 </td>
                                 <td align="left">
                                     <asp:TextBox ID="txtSection" runat="server" CssClass="textbox" MaxLength="50" 
                                         Width="150px"></asp:TextBox>
                                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                         ControlToValidate="txtSection" Display="None" 
                                         ErrorMessage="Enter Section Description" ValidationGroup="a">*</asp:RequiredFieldValidator>
                                     <asp:ValidatorCalloutExtender ID="RequiredFieldValidator2_ValidatorCalloutExtender" 
                                         runat="server" Enabled="True" TargetControlID="RequiredFieldValidator2">
                                     </asp:ValidatorCalloutExtender>
                                 </td>
                             </tr>
                             <tr>
                                 <td align="right">
                                     &nbsp;<asp:Label ID="Label2" runat="server" CssClass="label" Text="Superviser Name"></asp:Label>
                                 </td>
                                 <td align="left">
                                     <asp:TextBox ID="txtSupervisor" runat="server" CssClass="textbox" 
                                         MaxLength="50" Width="150px"></asp:TextBox>
                                     <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                         ControlToValidate="txtSupervisor" Display="None" 
                                         ErrorMessage="Enter Supervisor Name" ValidationGroup="a">*</asp:RequiredFieldValidator>
                                     <asp:ValidatorCalloutExtender ID="RequiredFieldValidator3_ValidatorCalloutExtender" 
                                         runat="server" Enabled="True" TargetControlID="RequiredFieldValidator3">
                                     </asp:ValidatorCalloutExtender>
                                 </td>
                             </tr>
                             <tr>
                                 <td align="right">
                                     <asp:Label ID="Label3" runat="server" CssClass="label" Text="Carder No"></asp:Label>
                                 </td>
                                 <td align="left">
                                     <asp:TextBox ID="txtCarder" runat="server" CssClass="textbox" MaxLength="6" 
                                         Width="150px"></asp:TextBox>
                                     <asp:FilteredTextBoxExtender ID="txtCarder_FilteredTextBoxExtender" 
                                         runat="server" Enabled="True" TargetControlID="txtCarder" 
                                         ValidChars="0123456789">
                                     </asp:FilteredTextBoxExtender>
                                     <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                         ControlToValidate="txtCarder" Display="None" ErrorMessage="Enter Carder No" 
                                         ValidationGroup="a">*</asp:RequiredFieldValidator>
                                     <asp:ValidatorCalloutExtender ID="RequiredFieldValidator4_ValidatorCalloutExtender" 
                                         runat="server" Enabled="True" TargetControlID="RequiredFieldValidator4">
                                     </asp:ValidatorCalloutExtender>
                                 </td>
                             </tr>
                             <tr>
                                 <td align="right">
                                     &nbsp;</td>
                                 <td align="left">
                                     &nbsp;</td>
                             </tr>
                             <tr>
                                 <td align="right">
                                     &nbsp;</td>
                                 <td align="left">
                                     &nbsp;</td>
                             </tr>
                             <tr>
                                 <td align="right">
                                     &nbsp;</td>
                                 <td align="left">
                                     <asp:Button ID="btnSave" runat="server" CssClass="button" 
                                         onclick="btnSave_Click" Text="Save" ValidationGroup="a" Width="80px" />
                                     <asp:ConfirmButtonExtender ID="btnSave_ConfirmButtonExtender" runat="server" 
                                         ConfirmText="Are you sure?" Enabled="True" TargetControlID="btnSave">
                                     </asp:ConfirmButtonExtender>
                                     <asp:Button ID="btnClear" runat="server" CssClass="button" 
                                         onclick="btnClear_Click" Text="Clear" ToolTip="Clear" Width="80px" />
                                 </td>
                             </tr>
                         </table>
                        </div>
                    </td>
                    <td valign="top">
                        <div style="border:1px solid silver;height:500px; width:430px; overflow:auto">
                            <cc1:C1GridView ID="C1GridView1" runat="server" AllowColMoving="True" 
                                AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" 
                                AutoGenerateSelectButton="True" DataKeyNames="nSectionID" 
                                onrowcommand="C1GridView1_RowCommand" 
                                onrowdatabound="C1GridView1_RowDataBound" PageSize="20" ShowFilter="True" 
                                UseEmbeddedVisualStyles="True" VisualStyle="Office2007Blue" 
                                VisualStylePath="~/C1WebControls/VisualStyles" Width="100%" 
                                onpageindexchanging="C1GridView1_PageIndexChanging">
                                <Columns>
                                    <cc1:C1TemplateField Visible="false">
                                        <ItemTemplate>
                                            <asp:Label ID="lblid" runat="server" Text='<%# Eval("nSectionID") %>'></asp:Label>
                                        </ItemTemplate>
                                    </cc1:C1TemplateField>
                                    <cc1:C1BoundField DataField="cSection_Description" HeaderText="Section" 
                                        SortExpression="Section">
                                    </cc1:C1BoundField>
                                    <cc1:C1BoundField DataField="cDeptname" HeaderText="Department" 
                                        SortExpression="cDeptname">
                                    </cc1:C1BoundField>
                                    <cc1:C1BoundField DataField="cCmpName" HeaderText="Company" 
                                        SortExpression="cCmpName">
                                    </cc1:C1BoundField>
                                    <cc1:C1BoundField DataField="cSupervisor" HeaderText="Supervisor" 
                                        SortExpression="cSupervisor">
                                    </cc1:C1BoundField>
                                </Columns>
                                <PagerSettings PageButtonCount="20" />
                                <HeaderStyle Wrap="False" />
                                <RowStyle Wrap="False" />
                            </cc1:C1GridView>
                           
                        </div>
                    </td>
                </tr>
            </table>

        </ContentTemplate>
        </asp:UpdatePanel>
       </div>
    
    </div>
    </form>
</body>
</html>
