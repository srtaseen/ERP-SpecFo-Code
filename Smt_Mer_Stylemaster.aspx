<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Smt_Mer_Stylemaster.aspx.cs" Inherits="Smt_Mer_Stylemaster" %>

<%@ Register Assembly="C1.Web.UI.Controls.4" Namespace="C1.Web.UI.Controls.C1GridView"
    TagPrefix="cc1" %>
<%@ Register assembly="C1.Web.UI.Controls.4" namespace="C1.Web.UI.Controls.C1TabControl" tagprefix="cc2" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .bt{	
	border: 1px solid #004C9B;
    border-radius: 3px 3px 3px 3px;
    box-shadow: 0 1px 0 rgba(255, 255, 255, 0.3) inset, 0 1px 1px rgba(0, 0, 0, 0.3);
    color: #D3EBFF;
    cursor: pointer;
    display: block;
    font: bold 24px Cambria,"Hoefler Text",serif;
    margin: 190px auto 0;
    padding: 10px;
    text-shadow: 0 -1px 0 #444444;
    width: 410px;    
	background-color:#0496DA;	
	background-image: linear-gradient(top, #0496DA 0%, #0067CD 100%);
	background-image: -o-linear-gradient(top, #0496DA 0%, #0067CD 100%);
	background-image: -moz-linear-gradient(top, #0496DA 0%, #0067CD 100%);
	background-image: -webkit-linear-gradient(top, #0496DA 0%, #0067CD 100%);
	background-image: -ms-linear-gradient(top, #0496DA 0%, #0067CD 100%);
}
.bt:hover{
	
	background-color:#0383d3;
	
	background-image: linear-gradient(top, #0383d3 0%, #004c9b 100%);
	background-image: -o-linear-gradient(top, #0383d3 0%, #004c9b 100%);
	background-image: -moz-linear-gradient(top, #0383d3 0%, #004c9b 100%);
	background-image: -webkit-linear-gradient(top, #0383d3 0%, #004c9b 100%);
	background-image: -ms-linear-gradient(top, #0383d3 0%, #004c9b 100%);
}

.bt:active{
	
	background-color:#026fcb;	
	background-image: linear-gradient(top, #026fcb 0%, #004c9b 100%);
	background-image: -o-linear-gradient(top, #026fcb 0%, #004c9b 100%);
	background-image: -moz-linear-gradient(top, #026fcb 0%, #004c9b 100%);
	background-image: -webkit-linear-gradient(top, #026fcb 0%, #004c9b 100%);
	background-image: -ms-linear-gradient(top, #026fcb 0%, #004c9b 100%);
}
.bbcp
{
    margin-left:5px;
   background-color:#D2E4EE;	
	
    display:none;
    position:fixed;
    border: 1px solid #4FB5E9;
    border-radius: 3px 3px 3px 3px;
    
    }
    .btcp
    {
        font-size:11px;
        font-family:Tahoma;
        
        }
    
   
    </style>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="margin-top:2px"></div>
    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>
                <cc2:C1TabControl ID="C1TabControl1" style="position:relative" OnClientTabUnSelect="clearlabel" runat="server" width="100%"                    
                TextImageRelation="ImageBeforeText">
               <TabPages>
                <cc2:C1TabPage ID="C1TabPage1" TabIndex="0" Text="Add New Style" CssClass="tab">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <table style="width: 100%;">
                                <tr>
                                    <td valign="top" width="370px">
                                        <table style="width: 100%;">
                                            <tr>
                                                <td>
                                                  <div class="pnlmain" style=" padding:2px">
                                              
                                                      <table style="width: 100%;">
                                                          <tr>
                                                              <td style="width:125px" align="right">
                                                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" 
                                                                      ControlToValidate="drpBuyer" Display="None" ErrorMessage="Select Buyer" 
                                                                      ForeColor="#CC3300" ValidationGroup="s">*</asp:RequiredFieldValidator>
                                                                  <asp:ValidatorCalloutExtender ID="RequiredFieldValidator19_ValidatorCalloutExtender" 
                                                                      runat="server" Enabled="True" TargetControlID="RequiredFieldValidator19">
                                                                  </asp:ValidatorCalloutExtender>
                                                               <asp:Label ID="Label1" runat="server" CssClass="label" Text="Buyer"></asp:Label>
                                                              </td>
                                                              <td>
                                                            <asp:DropDownList ID="drpBuyer" runat="server" CssClass="dropdownlist" Width="200px" 
                                                                      TabIndex="1"></asp:DropDownList>

                                                              </td>
                                                              <td>
                                                                  <asp:ImageButton ID="btnLoadbyer" style="display:none" runat="server" Height="15px" 
                                                                      ImageUrl="~/gridimage/ref1.png" onclick="btnLoadbyer_Click" 
                                                                      ToolTip="Refresh Buyer" />
                                                              </td>
                                                          </tr>
                                                          <tr>
                                                              <td align="right">
                                                              
                                                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" 
                                                                      ControlToValidate="drpStore" Display="None" ErrorMessage="Select Store" 
                                                                      ForeColor="#CC3300" ValidationGroup="s">*</asp:RequiredFieldValidator>
                                                                  <asp:ValidatorCalloutExtender ID="RequiredFieldValidator20_ValidatorCalloutExtender" 
                                                                      runat="server" Enabled="True" TargetControlID="RequiredFieldValidator20">
                                                                  </asp:ValidatorCalloutExtender>
                                                                  <asp:Label ID="Label2" runat="server" CssClass="label" Text="Store"></asp:Label>
                                                              
                                                              </td>
                                                              <td>
                                                                <asp:DropDownList ID="drpStore" runat="server" CssClass="dropdownlist" TabIndex="2" 
                                                                      Width="200px">
                                                                  </asp:DropDownList>
                                                              </td>
                                                              <td>                                                              
                                                                  <asp:ImageButton ID="btnLoadStore" style="display:none" runat="server" Height="15px" 
                                                                      ImageUrl="~/gridimage/ref1.png" onclick="btnLoadStore_Click" 
                                                                      ToolTip="Refresh Store" />
                                                              </td>
                                                          </tr>
                                                          <tr>
                                                              <td align="right">
                                                             
                                                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                                      ControlToValidate="drpSeason" Display="None" ErrorMessage="Select Season" 
                                                                      ValidationGroup="s">*</asp:RequiredFieldValidator>
                                                                  <asp:ValidatorCalloutExtender ID="RequiredFieldValidator3_ValidatorCalloutExtender" 
                                                                      runat="server" Enabled="True" TargetControlID="RequiredFieldValidator3">
                                                                  </asp:ValidatorCalloutExtender>
                                                                  <asp:Label ID="Label3" runat="server" CssClass="label" Text="Season"></asp:Label>
                                                             
                                                              </td>
                                                              <td>                                                              
                                                                  <asp:DropDownList ID="drpSeason" runat="server" CssClass="dropdownlist" TabIndex="3" 
                                                                      Width="200px">
                                                                  </asp:DropDownList>
                                                              </td>
                                                              <td>
                                                                
                                                                  <asp:ImageButton ID="btnLoadseason" style="display:none" runat="server" Height="15px" 
                                                                      ImageUrl="~/gridimage/ref1.png" onclick="btnLoadseason_Click" 
                                                                      ToolTip="Refresh Season" />
                                                                
                                                              </td>
                                                          </tr>
                                                          <tr>
                                                              <td align="right">
                                                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                                                      ControlToValidate="drpBrand" Display="None" ErrorMessage="Select Brand" 
                                                                      ValidationGroup="s">*</asp:RequiredFieldValidator>
                                                                  <asp:ValidatorCalloutExtender ID="RequiredFieldValidator4_ValidatorCalloutExtender" 
                                                                      runat="server" Enabled="True" TargetControlID="RequiredFieldValidator4">
                                                                  </asp:ValidatorCalloutExtender>
                                                                  <asp:Label ID="Label4" runat="server" CssClass="label" Text="Brand"></asp:Label>
                                                               </td>
                                                              <td>
                                                                  <asp:DropDownList ID="drpBrand"  runat="server" CssClass="dropdownlist" TabIndex="4" 
                                                                      Width="200px">
                                                                  </asp:DropDownList>
                                                              </td>
                                                              <td>
                                                                  <asp:ImageButton ID="btnLoadBrand" style="display:none" runat="server" Height="15px" 
                                                                      ImageUrl="~/gridimage/ref1.png" onclick="btnLoadBrand_Click" 
                                                                      ToolTip="Refresh Brand" />
                                                              </td>
                                                          </tr>
                                                          <tr>
                                                              <td align="right">
                                                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                                                      ControlToValidate="drpDivision" Display="None" ErrorMessage="Select Division" 
                                                                      ValidationGroup="s">*</asp:RequiredFieldValidator>
                                                                  <asp:ValidatorCalloutExtender ID="RequiredFieldValidator5_ValidatorCalloutExtender" 
                                                                      runat="server" Enabled="True" TargetControlID="RequiredFieldValidator5">
                                                                  </asp:ValidatorCalloutExtender>
                                                                  <asp:Label ID="Label5" runat="server" CssClass="label" Text="Garment Dept"></asp:Label>
                                                                 </td>
                                                              <td>
                                                                  <asp:DropDownList ID="drpDivision" runat="server" CssClass="dropdownlist" 
                                                                      TabIndex="5" Width="200px">
                                                                  </asp:DropDownList>
                                                              </td>
                                                              <td>
                                                                  <asp:ImageButton ID="btnLoadgmtdept" style="display:none" runat="server" Height="15px" 
                                                                      ImageUrl="~/gridimage/ref1.png" onclick="btnLoadgmtdept_Click" 
                                                                      ToolTip="Refresh Garment Department" />
                                                                </td>
                                                          </tr>
                                                          <tr>
                                                              <td align="right">
                                                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                                                      ControlToValidate="drpGarmenttype" Display="None" 
                                                                      ErrorMessage="Select Garment Type" ValidationGroup="s">*</asp:RequiredFieldValidator>
                                                                  <asp:ValidatorCalloutExtender ID="RequiredFieldValidator6_ValidatorCalloutExtender" 
                                                                      runat="server" Enabled="True" TargetControlID="RequiredFieldValidator6">
                                                                  </asp:ValidatorCalloutExtender>
                                                                  <asp:Label ID="Label39" runat="server" CssClass="label" Text="Garment Type"></asp:Label>
                                                                </td>
                                                              <td>
                                                                  <asp:DropDownList ID="drpGarmenttype" runat="server" CssClass="dropdownlist" 
                                                                      TabIndex="6" Width="200px">
                                                                  </asp:DropDownList>
                                                              </td>
                                                              <td>
                                                                  <asp:ImageButton ID="btnLoadGmttype" style="display:none" runat="server" Height="15px" 
                                                                      ImageUrl="~/gridimage/ref1.png" onclick="btnLoadGmttype_Click" 
                                                                      ToolTip="Refresh Garment Type" />
                                                                </td>
                                                          </tr>
                                                          <tr>
                                                              <td align="right">
                                                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                                                      ControlToValidate="drpStyle" Display="None" ErrorMessage="Select Style Type" 
                                                                      ValidationGroup="s">* </asp:RequiredFieldValidator>
                                                                  <asp:ValidatorCalloutExtender ID="RequiredFieldValidator7_ValidatorCalloutExtender" 
                                                                      runat="server" Enabled="True" TargetControlID="RequiredFieldValidator7">
                                                                  </asp:ValidatorCalloutExtender>
                                                                  <asp:Label ID="Label8" runat="server" CssClass="label" Text="Style Type"></asp:Label>
                                                               </td>
                                                              <td>
                                                                  <asp:DropDownList ID="drpStyle" runat="server" CssClass="dropdownlist" TabIndex="7" 
                                                                      Width="200px">
                                                                  </asp:DropDownList>
                                                              </td>
                                                              <td>
                                                                  &nbsp;</td>
                                                          </tr>
                                                          <tr>
                                                              <td align="right">
                                                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                                                                      ControlToValidate="txtContact" Display="None" ErrorMessage="Enter Contract No." 
                                                                      ValidationGroup="s">*</asp:RequiredFieldValidator>
                                                                  <asp:ValidatorCalloutExtender ID="RequiredFieldValidator8_ValidatorCalloutExtender" 
                                                                      runat="server" Enabled="True" TargetControlID="RequiredFieldValidator8">
                                                                  </asp:ValidatorCalloutExtender>
                                                                  <asp:Label ID="Label6" runat="server" CssClass="label" Text="Contract No"></asp:Label>
                                                               </td>
                                                              <td colspan="2">
                                                                  <asp:TextBox ID="txtContact" runat="server" CssClass="textbox" MaxLength="30" 
                                                                      TabIndex="8" Width="200px"></asp:TextBox>
                                                              </td>
                                                          </tr>
                                                          <tr>
                                                              <td align="right" style="vertical-align:top">
                                                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                                                                      ControlToValidate="txtStyle" Display="None" ErrorMessage="Enter Style Number" 
                                                                      ValidationGroup="s">*</asp:RequiredFieldValidator>
                                                                  <asp:ValidatorCalloutExtender ID="RequiredFieldValidator9_ValidatorCalloutExtender" 
                                                                      runat="server" Enabled="True" TargetControlID="RequiredFieldValidator9">
                                                                  </asp:ValidatorCalloutExtender>
                                                                  <asp:Label ID="Label27" runat="server" CssClass="label" Text="Style No"></asp:Label>
                                                              </td>
                                                              <td colspan="2" style="text-align:left">
                                                                  <asp:TextBox ID="txtStyle" runat="server" AutoPostBack="True" 
                                                                      CssClass="textbox" MaxLength="30" onkeypress="return validatespace(event)" OnTextChanged="txtStyle_TextChanged" 
                                                                      TabIndex="9" Width="172px"></asp:TextBox>
                                                                  <asp:TextBox ID="txtStid" style="display:none" runat="server"></asp:TextBox>
                                                                                                                                
                                                                  <input id="btncpy" title="Copy Style" class="btcp" disabled="disabled" type="button" value="C" />
                                                                 <div class="bbcp">
                                                                <iframe id="ifdd" style="border:none" width="210px" src=""></iframe>
                                                                  </div>
                                                                  
                                                                 </td>
                                                          </tr>
                                                          <tr>
                                                              <td align="right">
                                                                  <asp:Label ID="Label12" runat="server" CssClass="label" 
                                                                      Text="Total Order Qty(Pcs)"></asp:Label>
                                                               </td>
                                                              <td colspan="2">
                                                                  <asp:TextBox ID="txtOrderqty" runat="server" CssClass="textbox" 
                                                                      Font-Bold="True" ForeColor="Black" TabIndex="10" Width="80px" 
                                                                      MaxLength="9"></asp:TextBox>
                                                                  <asp:FilteredTextBoxExtender ID="txtOrderqty_FilteredTextBoxExtender" 
                                                                      runat="server" Enabled="True" TargetControlID="txtOrderqty" 
                                                                      ValidChars="0123456789">
                                                                  </asp:FilteredTextBoxExtender>
                                                                  &nbsp;&nbsp;
                                                                  <asp:DropDownList ID="drpfob" runat="server" 
                                                                      CssClass="textboxforgridview" Width="50px">
                                                                      <asp:ListItem Selected="True">FOB</asp:ListItem>
                                                                      <asp:ListItem>CNF</asp:ListItem>
                                                                      <asp:ListItem>CMPW</asp:ListItem>
                                                                      <asp:ListItem>CM</asp:ListItem>
                                                                      <asp:ListItem>CIF</asp:ListItem>
                                                                      <asp:ListItem>CMT</asp:ListItem>
                                                                      <asp:ListItem>FCA</asp:ListItem>
                                                                      <asp:ListItem>FCR</asp:ListItem>
                                                                  </asp:DropDownList>
                                                                  <asp:TextBox ID="txtfob" runat="server" CssClass="textbox" MaxLength="7" 
                                                                      TabIndex="11" Width="50px"></asp:TextBox>
                                                                  <asp:FilteredTextBoxExtender ID="fltrfob" runat="server" Enabled="True" 
                                                                      TargetControlID="txtfob" ValidChars="0123456789.">
                                                                  </asp:FilteredTextBoxExtender>
                                                              </td>
                                                          </tr>
                                                          <tr>
                                                              <td align="right">
                                                                  <asp:Label ID="Label31" runat="server" CssClass="label" 
                                                                      Text="Plan Efficiency %"></asp:Label>
                                                               </td>
                                                              <td colspan="2">
                                                                  <asp:TextBox ID="txtplanefficiency" runat="server" CssClass="textbox" 
                                                                      Enabled="False" Font-Bold="True" ForeColor="Black" MaxLength="3" TabIndex="12" 
                                                                      Width="80px"></asp:TextBox>
                                                                  <asp:FilteredTextBoxExtender ID="fltrefficiency" runat="server" Enabled="True" 
                                                                      TargetControlID="txtplanefficiency" ValidChars="0123456789">
                                                                  </asp:FilteredTextBoxExtender>
                                                                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                                  <asp:Label ID="Label32" runat="server" CssClass="label" Text="S.M.V"></asp:Label>
                                                                  <asp:TextBox ID="txtsmv" runat="server" CssClass="textbox" Enabled="False" 
                                                                      Font-Bold="True" ForeColor="Black" MaxLength="5" TabIndex="13" 
                                                                      Width="50px"></asp:TextBox>
                                                                  <asp:FilteredTextBoxExtender ID="fltr" runat="server" Enabled="True" 
                                                                      TargetControlID="txtsmv" ValidChars="0123456789.">
                                                                  </asp:FilteredTextBoxExtender>
                                                              </td>
                                                          </tr>
                                                          <tr>
                                                              <td align="right">
                                                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" 
                                                                      ControlToValidate="txtoriginalrcvd" Display="None" 
                                                                      ErrorMessage="Enter Original Order Receiv Date" ValidationGroup="s">*</asp:RequiredFieldValidator>
                                                                  <asp:ValidatorCalloutExtender ID="RequiredFieldValidator13_ValidatorCalloutExtender" 
                                                                      runat="server" Enabled="True" TargetControlID="RequiredFieldValidator13">
                                                                  </asp:ValidatorCalloutExtender>
                                                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" 
                                                                      ControlToValidate="txtBpcd" Display="None" 
                                                                      ErrorMessage="Enter Best Possible Cut Date" ValidationGroup="s">*</asp:RequiredFieldValidator>
                                                                  <asp:ValidatorCalloutExtender ID="RequiredFieldValidator12_ValidatorCalloutExtender" 
                                                                      runat="server" Enabled="True" TargetControlID="RequiredFieldValidator12">
                                                                  </asp:ValidatorCalloutExtender>
                                                                  <asp:Label ID="Label10" runat="server" CssClass="label" 
                                                                      Text="Original Order RCVD"></asp:Label>
                                                                </td>
                                                              <td>
                                                                  <asp:TextBox ID="txtoriginalrcvd" runat="server" CssClass="textbox" 
                                                                      Enabled="False" ForeColor="Black" Width="80px"></asp:TextBox>
                                                                  
                                                                  <asp:CalendarExtender ID="txtoriginalrcvd_CalendarExtender" runat="server" 
                                                                      Enabled="True" Format="dd-MMM-yyyy" PopupButtonID="cal1" 
                                                                      TargetControlID="txtoriginalrcvd" PopupPosition="TopLeft">
                                                                  </asp:CalendarExtender>
                                                                  <asp:ImageButton ID="cal1" onfocus="ShowCalendar()" CssClass="Caaldr" 
                                                                      runat="server" Height="10px" 
                                                                      ImageUrl="~/images/calendar.gif" TabIndex="12" />
                                                                  <asp:Label ID="lblstyleid" runat="server" style="display:none"></asp:Label>
                                                              </td>
                                                              <td>
                                                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" 
                                                                      ControlToValidate="txtfob" Display="None" ErrorMessage="Enter FOB " 
                                                                      ValidationGroup="s">* </asp:RequiredFieldValidator>
                                                                  <asp:ValidatorCalloutExtender ID="RequiredFieldValidator21_ValidatorCalloutExtender" 
                                                                      runat="server" Enabled="True" TargetControlID="RequiredFieldValidator21">
                                                                  </asp:ValidatorCalloutExtender>
                                                              </td>
                                                          </tr>
                                                          <tr>
                                                              <td align="right">
                                                                  <asp:Label ID="Label33" runat="server" CssClass="label" Text="BPCD"></asp:Label>
                                                              </td>
                                                              <td>
                                                                  <asp:TextBox ID="txtBpcd" runat="server" CssClass="textbox" Enabled="False" 
                                                                      ForeColor="Black" Width="80px"></asp:TextBox>
                                                                 
                                                                  <asp:CalendarExtender ID="txtBpcd_CalendarExtender" runat="server" 
                                                                      Enabled="True" Format="dd-MMM-yyyy" OnClientDateSelectionChanged="checkbpcddate" 
                                                                      PopupButtonID="cal2" TargetControlID="txtBpcd" PopupPosition="TopLeft">
                                                                  </asp:CalendarExtender>
                                                                  <asp:ImageButton ID="cal2" onfocus="ShowCalendar2()" runat="server" Height="10px" 
                                                                      ImageUrl="~/images/calendar.gif" TabIndex="13" />
                                                                  <input id="Text1" type="text" style="width:50px; display:none" />
                                                              </td><asp:TextBox ID="txtTesttotal" style="display:none"  runat="server" Width="50px">0</asp:TextBox>
                                                              <td>
                                                                  &nbsp;</td>
                                                          </tr>
                                                          <tr>
                                                              <td align="right">
                                                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" 
                                                                      ControlToValidate="txtconfirmrcvd" Display="None" 
                                                                      ErrorMessage="Enter Confirm Order Date" ValidationGroup="s">* </asp:RequiredFieldValidator>
                                                                  <asp:ValidatorCalloutExtender ID="RequiredFieldValidator14_ValidatorCalloutExtender" 
                                                                      runat="server" Enabled="True" TargetControlID="RequiredFieldValidator14">
                                                                  </asp:ValidatorCalloutExtender>
                                                                  <asp:Label ID="Label13" runat="server" CssClass="label" 
                                                                      Text="Confirm Order RCVD"></asp:Label>
                                                              </td>
                                                              <td>
                                                                  <asp:TextBox ID="txtconfirmrcvd" runat="server" CssClass="textbox" 
                                                                      Enabled="False" ForeColor="Black" Width="80px"></asp:TextBox>
                                                                 
                                                                  <asp:CalendarExtender ID="txtconfirmrcvd_CalendarExtender" runat="server" 
                                                                      Enabled="True" Format="dd-MMM-yyyy" PopupButtonID="cal3" 
                                                                      TargetControlID="txtconfirmrcvd" PopupPosition="TopLeft">
                                                                  </asp:CalendarExtender>
                                                                  <asp:ImageButton ID="cal3" onfocus="ShowCalendar3()" runat="server" Height="10px" 
                                                                      ImageUrl="~/images/calendar.gif" TabIndex="14" />
                                                              </td>
                                                              <td>
                                                                  &nbsp;</td>
                                                          </tr>
                                                          <tr>
                                                              <td align="right">
                                                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" 
                                                                      ControlToValidate="drpFactory" Display="None" ErrorMessage="Select Factory" 
                                                                      ValidationGroup="s">* </asp:RequiredFieldValidator>
                                                                  <asp:ValidatorCalloutExtender ID="RequiredFieldValidator16_ValidatorCalloutExtender" 
                                                                      runat="server" Enabled="True" TargetControlID="RequiredFieldValidator16">
                                                                  </asp:ValidatorCalloutExtender>
                                                                  <asp:Label ID="Label25" runat="server" CssClass="label" Text="Factory"></asp:Label>
                                                              </td>
                                                              <td>
                                                                  <asp:DropDownList ID="drpFactory" runat="server" CssClass="dropdownlist" 
                                                                      TabIndex="15" Width="200px">
                                                                  </asp:DropDownList>
                                                              </td>
                                                              <td>
                                                                  <asp:ImageButton ID="btnLoadFactory" style="display:none" runat="server" Height="15px" 
                                                                      ImageUrl="~/gridimage/ref1.png" onclick="btnLoadFactory_Click" 
                                                                      ToolTip="Refresh Factory" />
                                                              </td>
                                                          </tr>
                                                          <tr>
                                                              <td align="right">
                                                                  &nbsp;</td>
                                                              <td valign="top" style="padding-left:5px">
                                                                  <asp:CheckBox ID="chkConfirmation" runat="server" Text="Confirm Style" />
                                                                    <asp:ToggleButtonExtender ID="CheckBox1_ToggleButtonExtender" runat="server" 
                                                                Enabled="True" CheckedImageUrl="gridimage/CheckbCheck.png" ImageHeight="19" ImageWidth="19"
                                                                 UncheckedImageUrl="gridimage/CheckBuncheck.gif" TargetControlID="chkConfirmation">
                                                          </asp:ToggleButtonExtender>
                                                              </td>
                                                              <td>
                                                                  &nbsp;</td>
                                                          </tr>
                                                          <tr>
                                                              <td align="right">
                                                                  &nbsp;OTS Custom Name</td>
                                                              <td valign="top">
                                                                  <asp:DropDownList ID="drpOts" runat="server" CssClass="dropdownlist" 
                                                                      TabIndex="15" Width="200px">
                                                                  </asp:DropDownList>
                                                              </td>
                                                              <td>
                                                                  &nbsp;</td>
                                                          </tr>
                                                      </table>
                                                  </div>
                                                </td>
                                               
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div class="pnlmain" style=" height:53px; padding:4px">
                                              
                                                        <table style="width: 100%;">
                                                            <tr>
                                                                <td>
                                                                 <asp:Button ID="btnAddbuyer" Width="100px" ToolTip="Add New buyer" runat="server" CssClass="btPOPUP" 
                                                                                            Text="Buyer" />
                                                                </td>
                                                                <td>
                                                                 <asp:Button ID="btnAddgmtdept" ToolTip="Add Garment dept" runat="server" CssClass="btPOPUP" 
                                                                                            Text="Garment Dept" Width="130px" />
                                                                </td>
                                                                <td>
                                                                  <asp:Button ID="btnAddseason" Width="100px" ToolTip="Add Season" runat="server" CssClass="btPOPUP" 
                                                                                            Text="Season" />
                                                                </td>
                                                                 <td>
                                                                     &nbsp;</td>
                                                            </tr>
                                                             <tr>
                                                                <td>
                                                                 <asp:Button ID="btnAddbrand" Width="100px" ToolTip="Add New Brand" runat="server" CssClass="btPOPUP" 
                                                                                            Text="Brand" />
                                                                </td>
                                                                <td>
                                                                 <asp:Button ID="btnAddgmttype" ToolTip="Add Garment Type" runat="server" CssClass="btPOPUP" 
                                                                                            Text="Garment Type" Width="130px" />
                                                                </td>
                                                                <td>
                                                                  <asp:Button ID="btnAddstore" Width="100px" ToolTip="Add New Store" runat="server" CssClass="btPOPUP" 
                                                                                            Text="Store" />
                                                                </td>
                                                                 <td>
                                                                     &nbsp;</td>
                                                            </tr>
                                                            
                                                        </table>


                                                  </div>
                                                  <div style="padding:5px; text-align:right" id="dvalrt" runat="server" visible="false">
                                                  <input id="Reset1" type="reset" value="" disabled="disabled" style="border: 1px solid #C0C0C0; width: 35px; height: 10px; background-color:pink" />
                                                     PO Raised For this Lot
                                                   </div>
                                                </td>
                                              
                                            </tr>
                                           
                                        </table>
                                    </td>
                                    <td valign="top">
          <table style="width: 100%;">
            <tr>
              <td>
                 <div class="pnlmain" style="height:337px" align="left">
                 <div class="pnlheader">
                 <div style="float:left">Delivery Information    <b style="color:#F082BF">(***All Fields Are Mandatory)</b></div>
                 <div style="float:right">
                    <asp:ImageButton ID="btnaddtop" TabIndex="28" runat="server" Height="18px" 
                   ImageUrl="~/images/plus.png" onclick="btnAdd_Click" ToolTip="Add New Row" 
                   Width="18px" ValidationGroup="N" />
                    
                    </div>
                 </div>
                 <div style="height:320px; overflow:auto">
                 <asp:GridView ID="grdDelivery" Width="100%" runat="server" AutoGenerateColumns="False" 
                     onrowdatabound="grdDelivery_RowDataBound" CssClass="mGrid" ShowFooter="True">
                   <Columns>
                   <asp:TemplateField HeaderText="Lot">
                   <ItemTemplate>
                   <asp:TextBox ID="txtlot" Text='<%# Eval("cOrderNu") %>' style="text-transform:uppercase" runat="server" 
                   CssClass="textboxforgridview" Width="30px" MaxLength="2"> </asp:TextBox>

                       <asp:FilteredTextBoxExtender ID="txtlot_FilteredTextBoxExtender" runat="server" 
                           Enabled="True" FilterMode="InvalidChars" 
                           InvalidChars="./*-+`!@#$%^&amp;()_+=|\&lt;&gt;/?~`" 
                           TargetControlID="txtlot">
                       </asp:FilteredTextBoxExtender>

                   <asp:RequiredFieldValidator ID="ReqLot" runat="server" 
                   ControlToValidate="txtlot" Display="None" ErrorMessage="Enter Lot" 
                   ValidationGroup="N">*</asp:RequiredFieldValidator>

                   <asp:ValidatorCalloutExtender ID="ReqLot_ValidatorCalloutExtender" 
                   runat="server" Enabled="True" TargetControlID="ReqLot">
                   </asp:ValidatorCalloutExtender>
                   </ItemTemplate>
                   </asp:TemplateField>
                   <asp:TemplateField HeaderText="P.O No">
                   <ItemTemplate><asp:TextBox ID="txtpono" Text='<%# Eval("cPoNum") %>' runat="server" CssClass="textboxforgridview" Width="150px" 
                   MaxLength="20"> </asp:TextBox>
                   <asp:FilteredTextBoxExtender ID="txtpono_FilteredTextBoxExtender" 
                   runat="server" Enabled="True" FilterMode="InvalidChars" InvalidChars=" /" 
                   TargetControlID="txtpono"></asp:FilteredTextBoxExtender>                   
                   <asp:RequiredFieldValidator ID="ReqPO" runat="server" 
                   ControlToValidate="txtpono" Display="None" ErrorMessage="Enter PO No" 
                   ValidationGroup="N">*</asp:RequiredFieldValidator>
                   <asp:ValidatorCalloutExtender ID="ReqPO_ValidatorCalloutExtender" 
                   runat="server" Enabled="True" TargetControlID="ReqPO">
                   </asp:ValidatorCalloutExtender>
                   </ItemTemplate>
                   </asp:TemplateField>                   
                   <asp:TemplateField HeaderText="Total Qty">
                   <ItemTemplate>
                   <asp:TextBox ID="txtttlqty" Text='<%# Eval("nOrdQty") %>' runat="server" CssClass="textboxforgridview" MaxLength="10" Width="60px"> </asp:TextBox>
                   <asp:Label ID="lblttqty" Text='<%# Eval("nOrdQty") %>' style="display:none"  runat="server"></asp:Label>
                   <asp:Label ID="lblInseamQty" style="display:none"  runat="server" Text="0"></asp:Label>
                   <asp:FilteredTextBoxExtender ID="fltrtqty" runat="server" Enabled="True" TargetControlID="txtttlqty" ValidChars="0123456789">
                   </asp:FilteredTextBoxExtender>
                   </ItemTemplate>
                   
                   </asp:TemplateField>
                   <asp:TemplateField HeaderText="Ship Mode">
                   <ItemTemplate>
                   <asp:DropDownList ID="drpshipmode" SelectedValue='<%# Eval("Cmode") %>' TabIndex="24" runat="server" CssClass="textboxforgridview" 
                   Width="60px">
                   <asp:ListItem Selected="True"></asp:ListItem>
                   <asp:ListItem>Sea</asp:ListItem>
                   <asp:ListItem>Air</asp:ListItem>
                   <asp:ListItem>Sea-Air</asp:ListItem>
                   </asp:DropDownList>
                   </ItemTemplate>
                   </asp:TemplateField>
                     <asp:TemplateField HeaderText="FOB Date">
                   <ItemTemplate>
                       <asp:TextBox ID="txtFobdate" Text='<%# Eval("DXfty") %>' Enabled="false" CssClass="textboxforgridview" Width="60px" runat="server"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="txtshpdt_Reqshipdate" runat="server" 
                   ControlToValidate="txtFobdate" Display="None" ErrorMessage="Enter FOB Date" 
                   ValidationGroup="N">*</asp:RequiredFieldValidator>
                   <asp:ValidatorCalloutExtender ID="txtFobdate_ValidatorCalloutExtender" 
                   runat="server" Enabled="True" TargetControlID="txtshpdt_Reqshipdate">
                   </asp:ValidatorCalloutExtender>


                      
                   <asp:CalendarExtender ID="txtFobdate_CalendarExtender" runat="server" 
                   Enabled="True" OnClientDateSelectionChanged="SkSfdtshpdat1" Format="dd-MMM-yyyy" TargetControlID="txtFobdate" 
                   PopupButtonID="calshdt">
                   </asp:CalendarExtender>
                   <asp:ImageButton ID="calshdt" CommandArgument='<%#Container.DataItemIndex+1 %>'
                    runat="server" Height="13px" ImageUrl="~/images/calendar.gif" />
                   </ItemTemplate>
                   </asp:TemplateField>
                   <asp:TemplateField HeaderText="X-Fty Date">
                   <ItemTemplate>
                   <asp:TextBox ID="txtXftydate" Text='<%# Eval("ShipDt") %>' runat="server" CssClass="textboxforgridview" 
                   ForeColor="Black" Width="70px" Enabled="False"> </asp:TextBox>
                  
                   <asp:CalendarExtender ID="txtshipdate_CalendarExtender" runat="server" 
                   Enabled="True" OnClientDateSelectionChanged="SkSfdt1" Format="dd-MMM-yyyy" TargetControlID="txtXftydate" 
                   PopupButtonID="cal4">
                   </asp:CalendarExtender>
                   <asp:ImageButton ID="cal4" runat="server" Height="13px" ImageUrl="~/images/calendar.gif" />
                   <asp:RequiredFieldValidator ID="Reqshipdate" runat="server" 
                   ControlToValidate="txtXftydate" Display="None" ErrorMessage="Enter X-Fty date" 
                   ValidationGroup="N">*</asp:RequiredFieldValidator>
                   <asp:ValidatorCalloutExtender ID="Reqshipdate_ValidatorCalloutExtender" 
                   runat="server" Enabled="True" TargetControlID="Reqshipdate">
                   </asp:ValidatorCalloutExtender>
                   </ItemTemplate>
                   </asp:TemplateField>
                 
                   <asp:TemplateField HeaderText="U.Price">
                   <ItemTemplate>
                   <asp:TextBox ID="txtprice" Text='<%# Eval("nfob") %>' runat="server" CssClass="textboxforgridview" Width="60px" 
                   MaxLength="10" ></asp:TextBox>
                   <asp:FilteredTextBoxExtender ID="txtprice_FilteredTextBoxExtender" 
                   runat="server" Enabled="True" TargetControlID="txtprice" 
                   ValidChars="1234567890.">
                   </asp:FilteredTextBoxExtender>
                   </ItemTemplate>
                   </asp:TemplateField>
                   <asp:TemplateField>
                   <HeaderTemplate>
                
                   </HeaderTemplate>
                   <ItemTemplate>
                   <asp:ImageButton ID="btnRemove" TabIndex="29" Width="13px" runat="server" 
                   ImageUrl="~/gridimage/grdRemove.png" onclick="btnRemove_Click" 
                           ToolTip="Remove Row from list" />
                       <asp:ConfirmButtonExtender ID="btnRemove_ConfirmButtonExtender" runat="server" 
                           ConfirmText="Are you sure you want to delete?" Enabled="True" TargetControlID="btnRemove">
                       </asp:ConfirmButtonExtender>
                   </ItemTemplate>
                   </asp:TemplateField>
                   </Columns>
                     <FooterStyle CssClass="gridheader" />
                   <HeaderStyle CssClass="gridheader" />
                   </asp:GridView>
                   </div>
                   </div>
              </td>        
            </tr>
            <tr>
              <td>
                <table style="width: 100%;">
                   <tr>
                     <td>
                       <div class="pnlmain" style="height:140px">
                       <div class="pnlheader">Special Operation</div>
                       <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                               Width="100%" PageSize="4" CssClass="mGrid">
                           <AlternatingRowStyle BackColor="#EEEEEE" />
                       <Columns>
                       <asp:TemplateField HeaderText="Code" Visible="False">
                        <ItemTemplate>
                        <asp:Label ID="lblid" runat="server" Text='<%# Eval("nID") %>'></asp:Label>
                        </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Code">
                        <ItemTemplate>
                        <asp:Label ID="lblcode" runat="server" Text='<%# Eval("cCode") %>' Font-Size="9px"></asp:Label>
                        </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Description">
                        <ItemTemplate>
                        <asp:Label ID="lbldescription" Font-Size="9px" runat="server" Text='<%# Eval("cDescription") %>'></asp:Label>
                        </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Select">
                        <ItemTemplate>
                        <asp:CheckBox ID="chkSelect" TabIndex="28" runat="server" />
                          <asp:ToggleButtonExtender ID="CheckBox1_ToggleButtonExtender" runat="server" 
                                                                Enabled="True" CheckedImageUrl="gridimage/CheckbCheck.png" ImageHeight="19" ImageWidth="19"
                                                                 UncheckedImageUrl="gridimage/CheckBuncheck.gif" TargetControlID="chkSelect">
                                                          </asp:ToggleButtonExtender>
                        
                        
                        </ItemTemplate>
                        </asp:TemplateField>
                        </Columns>
                        <HeaderStyle CssClass="gridheader" />
                           <PagerSettings PageButtonCount="4" />
                        </asp:GridView>
                   </div>
                </td>
                <td width="250px">
                   <div class="pnlmain" style="height:140px">
                      <div class="pnlheader">Actions</div>
                      <table style="width: 100%;">
                                                                 <tr>
                                                                     <td align="center">
                                                                         &nbsp;</td>
                                                                     <td align="center">
                                                                         &nbsp;</td>
                                                                 </tr>
                                                                 <tr>
                                                                     <td align="center">
                                                                         <asp:Button ID="btnSave" runat="server" CssClass="button" 
                                                                             OnClick="btnSave_Click" TabIndex="30" Text="Save" ToolTip="Save" 
                                                                             ValidationGroup="s" Width="100px" />
                                                                         <asp:ConfirmButtonExtender ID="btnSave_ConfirmButtonExtender" runat="server" 
                                                                             ConfirmText="Do you want to save this data?" Enabled="True" 
                                                                             TargetControlID="btnSave">
                                                                         </asp:ConfirmButtonExtender>
                                                                     </td>
                                                                     <td align="center">
                                                                         <asp:Button ID="btnReport" runat="server" CssClass="button" 
                                                                             OnClick="btnReport_Click" TabIndex="32" Text="Style Report" 
                                                                             ToolTip="Generate Report" Width="100px" />
                                                                     </td>
                                                                 </tr>
                                                                 <tr>
                                                                 <td align="center">
                                                                     <asp:Button ID="btnRename" runat="server" CssClass="button" TabIndex="32" 
                                                                         Text="Rename Style" ToolTip="Rename Style No" Width="100px" />
                                                                     <asp:ModalPopupExtender ID="btnRename_ModalPopupExtender" runat="server" 
                                                                         BackgroundCssClass="ModalPopupBG" CancelControlID="btnOK" DropShadow="True" 
                                                                         DynamicServicePath="" Enabled="True" OkControlID="btnOK" 
                                                                         PopupControlID="dvRenameStyle" TargetControlID="btnRename">
                                                                     </asp:ModalPopupExtender>
                                                                </td>
                                                                     <td align="center">
                                                                         <asp:Button ID="btnReportPI" runat="server" CssClass="button" 
                                                                             OnClick="btnReportPI_Click" TabIndex="32" Text="PI Report" 
                                                                             ToolTip="Generate Report" Width="100px" />
                                                                     </td>
                                                                </tr>
                                                                <tr>
                                                                <td align="center" style="margin-left: 40px">
                                                                    <asp:Button ID="btnClear" runat="server" CssClass="button" 
                                                                        OnClick="btnClear_Click" TabIndex="32" Text="Clear" ToolTip="Clear" 
                                                                        Width="100px" />
                                                                 </td>
                                                                    <td align="center" style="margin-left: 40px">
                                                                        
                                                                     
                                                                        <asp:Button ID="btnRename0" runat="server" CssClass="button" TabIndex="32" 
                                                                            Text="Rename PO" ToolTip="Rename PO" Width="100px" />
                                                                        <asp:ModalPopupExtender ID="btnRename0_ModalPopupExtender" runat="server" 
                                                                            BackgroundCssClass="ModalPopupBG" CancelControlID="btnOK" DropShadow="True" 
                                                                            DynamicServicePath="" Enabled="True" OkControlID="btnOK" 
                                                                            PopupControlID="dvrenmpo" TargetControlID="btnRename0">
                                                                        </asp:ModalPopupExtender>
                                                                    </td>
                                                                 </tr>
                                                                 <tr>
                                                                     <td align="center" style="margin-left: 40px" colspan="2">
                                                                         &nbsp;</td>
                          </tr>
                                                                 </table>
                                                                </div>
                                                            </td>
                                                           
                                                        </tr>
                                                       
                                                    </table>
                                                </td>
                                              
                                            </tr>
                                           
           </table>
                                    </td>
                                    
                                </tr>
                               
                            </table>
                          
                        </ContentTemplate>
                    </asp:UpdatePanel>
                  
                </cc2:C1TabPage>
                <cc2:C1TabPage ID="C1TabPage2"  TabIndex="1" Text="Edit/View"  CssClass="tab">
                                  
                  <asp:UpdatePanel ID="updViewEdit" runat="server">
                        <ContentTemplate>
                        <div style="height:520px">
                        <cc1:C1GridView ID="C1GridView1" runat="server" AllowPaging="True" 
                                        AutoGenerateColumns="False"
                                        onrowcommand="C1GridView1_RowCommand" PageSize="30" 
                                        ShowFilter="True" VisualStylePath="~/C1WebControls/VisualStyles" 
                                        Width="100%" AllowSorting="True" AllowColMoving="True" 
                                        VisualStyle="Office2007Blue" DefaultColumnWidth="" 
                                        CssClass="mGrid" onrowdatabound="C1GridView1_RowDataBound" 
                                onfiltering="C1GridView1_Filtering" 
                                onpageindexchanging="C1GridView1_PageIndexChanging" 
                                onsorting="C1GridView1_Sorting">
                                        <Columns>
                                            <cc1:C1CommandField ShowSelectButton="True">
                                            </cc1:C1CommandField>
                                            <cc1:C1BoundField DataField="nStyleID" HeaderText="Style ID" 
                                                SortExpression="Style ID" Visible="false">
                                            </cc1:C1BoundField>
                                            <cc1:C1BoundField DataField="cStyleNo" HeaderText="Style No" 
                                                SortExpression="cStyleNo">
                                            </cc1:C1BoundField>
                                            <cc1:C1BoundField DataField="nTotOrdQty" ShowFilter="false" HeaderText="Total Qty" 
                                                SortExpression="nTotOrdQty">
                                            </cc1:C1BoundField>                                           
                                            <cc1:C1BoundField DataField="cBuyer_Name"  HeaderText="Buyer Name" 
                                                SortExpression="cBuyer_Name">
                                            </cc1:C1BoundField>
                                            <cc1:C1BoundField DataField="cSeason_Name" HeaderText="Season Name" 
                                                SortExpression="cSeason_Name">
                                            </cc1:C1BoundField>
                                            <cc1:C1BoundField DataField="cBrand_Name" HeaderText="Brand Name" 
                                                SortExpression="cBrand_Name">
                                            </cc1:C1BoundField>
                                            <cc1:C1BoundField DataField="cStore_Name" HeaderText="Store Name" 
                                                SortExpression="cStore_Name">
                                            </cc1:C1BoundField>
                                            <cc1:C1BoundField DataField="cGmt_Dept_Description" HeaderText="Gmt. Dept" 
                                                SortExpression="cDeptname">
                                            </cc1:C1BoundField>
                                             <cc1:C1BoundField DataField="cInputDate" DataFormatString="{0:dd/MM/yyyy}" HtmlEncode="false" HeaderText="Created Date" 
                                                SortExpression="cInputDate">
                                            </cc1:C1BoundField>
                                            
                                            <cc1:C1BoundField DataField="cUserFullname" HeaderText="User Name"></cc1:C1BoundField>
                                        </Columns>
                                        <PagerSettings PageButtonCount="25" />
                                        <HeaderStyle Wrap="False" />
                                        <RowStyle Wrap="False" />
                                    </cc1:C1GridView>               
                                                        
                        </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                                  
                </cc2:C1TabPage>

                 <cc2:C1TabPage ID="C1TabPage4"  TabIndex="1" Text="View PO Details" Visible="false"  CssClass="tab">
                                  
                  <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                        <ContentTemplate>
                        <div style="height:520px">
                        <cc1:C1GridView ID="grdPODtl" runat="server" AllowPaging="True" 
                                        AutoGenerateColumns="False" PageSize="30" 
                                        ShowFilter="True" VisualStylePath="~/C1WebControls/VisualStyles" 
                                        Width="100%" AllowSorting="True" AllowColMoving="True" 
                                        VisualStyle="Office2007Blue" DefaultColumnWidth="" 
                                CssClass="mGrid" AllowKeyboardNavigation="True" 
                                onprerender="grdPODtl_PreRender" onrowcommand="grdPODtl_RowCommand" 
                                onrowdatabound="grdPODtl_RowDataBound" onfiltering="grdPODtl_Filtering" 
                                onpageindexchanging="grdPODtl_PageIndexChanging" 
                                onsorting="grdPODtl_Sorting">
                                        <Columns>
                                            <cc1:C1CommandField ShowSelectButton="True">
                                            </cc1:C1CommandField>
                                            <cc1:C1BoundField DataField="nStyleID" HeaderText="Style ID" 
                                                SortExpression="Style ID" Visible="false">
                                            </cc1:C1BoundField>
                                            <cc1:C1BoundField DataField="cStyleNo" HeaderText="Style No" 
                                                SortExpression="cStyleNo">
                                            </cc1:C1BoundField>
                                            <cc1:C1BoundField DataField="nTotOrdQty" ShowFilter="false" HeaderText="Total Qty" 
                                                SortExpression="nTotOrdQty">
                                            </cc1:C1BoundField>                                           
                                            <cc1:C1BoundField DataField="cBuyer_Name"  HeaderText="Buyer Name" 
                                                SortExpression="cBuyer_Name">
                                            </cc1:C1BoundField>
                                            <cc1:C1BoundField DataField="cSeason_Name" HeaderText="Season Name" 
                                                SortExpression="cSeason_Name">
                                            </cc1:C1BoundField>
                                            <cc1:C1BoundField DataField="cOrderNu" HeaderText="Lot" 
                                                SortExpression="cOrderNu">
                                            </cc1:C1BoundField>
                                            <cc1:C1BoundField DataField="cPoNum" HeaderText="PO No" 
                                                SortExpression="cPoNum">
                                            </cc1:C1BoundField>
                                            <cc1:C1BoundField DataField="nOrdQty" ShowFilter="false" HeaderText="PO qty" 
                                                SortExpression="nOrdQty">
                                            </cc1:C1BoundField>
                                             <cc1:C1BoundField DataField="DXfty" DataFormatString="{0:dd/MM/yyyy}" HtmlEncode="false" HeaderText="Ship Date" 
                                                SortExpression="DXfty">
                                            </cc1:C1BoundField>                                            
                                            <cc1:C1BoundField DataField="cUserFullname" HeaderText="User Name"></cc1:C1BoundField>
                                        </Columns>
                                        <PagerSettings PageButtonCount="25" />
                                        <HeaderStyle Wrap="False" />
                                        <RowStyle Wrap="False" />
                                    </cc1:C1GridView> 
                                     
                                                        
                        </div>
                        <div>
                            
                        </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                                  
                </cc2:C1TabPage>

                 <cc2:C1TabPage ID="C1TabPage3"  TabIndex="1" Text="Upload File"  CssClass="tab">
                     <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                    <ContentTemplate>          
                       <div class="pnlmain" style="height:500px; margin:5px">
                       <div class="pnlheader">Upload File</div>
                       <div>
                           <table style="width: 100%;">
                               <tr>
                                   <td>
                                     <asp:Button ID="btnUplod" style="display:none"  runat="server" Text="Upload Files/View Files" 
                                           CssClass="bt" />
                                       <input id="Button1" type="button" onclick="flfld();"  class="bt" value="Upload Files/View Files" />
                                        <asp:ModalPopupExtender ID="btnUplod_ModalPopupExtender1" runat="server" 
                                         BackgroundCssClass="ModalPopupBG" CancelControlID="btnupldcls" DropShadow="True" 
                                         DynamicServicePath="" Enabled="True" OkControlID="btnupldcls" 
                                         PopupControlID="uplod" BehaviorID="ppadditm" 
                                         TargetControlID="btnUplod">
                                       </asp:ModalPopupExtender>
                                   </td>
                               </tr>
                               <tr>
                                   <td align="left">
                                   
                                       &nbsp;</td>
                               </tr>
                               <tr>
                                   <td>
                                       &nbsp;
                                   </td>
                               </tr>
                           </table>
                           </div>
                       </div>
                     
                    </ContentTemplate>
                     
                    </asp:UpdatePanel>   
                      
                                  
                </cc2:C1TabPage>

               
               
            </TabPages>
                </cc2:C1TabControl>
                </ContentTemplate>
               
                </asp:UpdatePanel>
                  <div id="uplod" style="height:400px; width:750px; border:1px solid teal; display:none">
                       <div class="pnlheader">
                       <div style="float:left">File Upload/Display File</div>
                        <div style="float:right; width:50px" align="right">
                            <asp:ImageButton ID="btnupldcls" runat="server" ImageUrl="~/gridimage/Cols.png" />
                         </div>
                       </div>
                       <iframe id="ifupldfile" width="740px" height="390px" style="border:none" src=""></iframe>                       
                       </div>
            <div id="dvRenameStyle" class="pnlmain" style="border:1px solid Gray; background-color:#E6F7FF; display:none">
                <div  class="pnlheader" >
                <div style="float:left">
                <div>Rename Style No</div>
                </div>
                <div style="float: right; margin-right:10px">
                    <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                    <ContentTemplate>
                      <asp:ImageButton ID="btnOK" OnClientClick="clr()" runat="server" 
                            ImageUrl="~/gridimage/cancelgridrowedit1.png" onclick="btnOK_Click" />
                    </ContentTemplate>
                     
                    </asp:UpdatePanel>
                </div>
                </div>
                 <iframe src="Smt_StyleMasterRename.aspx" width="550px" height="250px"></iframe>               
                
                </div>



                <div id="dvrenmpo" class="pnlmain" style="border:1px solid Gray; background-color:#E6F7FF; display:none">
                <div  class="pnlheader" >
                <div style="float:left">
                <div>Rename Style No</div>
                </div>
                <div style="float: right; margin-right:10px">
                    <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                    <ContentTemplate>
                      <asp:ImageButton ID="ImageButton1" OnClientClick="clr()" runat="server" 
                            ImageUrl="~/gridimage/cancelgridrowedit1.png" onclick="btnOK_Click" />
                    </ContentTemplate>
                     
                    </asp:UpdatePanel>
                </div>
                </div>
                 <iframe src="Master_Setup/porename.aspx" width="550px" height="250px"></iframe>               
                
                </div>


    <div id="D1" class="POPUPPanel">
                                <div id="POPUPHDR">
                                     <div class="POPUPHeaderText">Add New Buyer</div>
                                     <div class="POPUPClose"></div>      
                                </div>
                                <iframe id="POPUPIFrame" width="800px" height="550px" src=""></iframe>
                            </div>   
                           
                             
    <asp:UpdatePanel ID="UpdatePanel4" runat="server">
    <ContentTemplate>

                           <div id="MsgBOx" class="pnlmain" style="height:250px; width:450px; border:1px solid teal; background-color:HighlightText; display:none">
                           <div class="pnlheader">
                           <div style="float:left; width:200px">Information</div>
                           <div style="float:right; text-align:right; color:Blue">SPECFO</div>
                           </div>
                           <div style="width:420px; height:200px">
                           <div style="float:left; width:60px; margin-top:20px">
                           <img src="gridimage/Info.png" alt="Information" />
                           </div>
                           <div style="float:right; width:330px; margin-top:20px; padding-left:10px; text-align:center">
                            <asp:Label ID="lblAlertmsg" runat="server" Font-Names="Tahoma" Font-Size="14px" 
                                   ForeColor="#3366FF"></asp:Label>
                           </div>
                           </div>
                           <div align="right" style="padding-right:10px">
                               <input id="btnAlertmsgOk" style="width:50px; border:1px solid silver; cursor:pointer" type="button" value="ok" />
                           </div>
                               
                            
                            </div>
    <asp:Button ID="btntestmsg" style="display:none" runat="server" Text="Button" />
    <asp:ModalPopupExtender ID="mdlAlertmsg" BackgroundCssClass="ModalPopupBG" TargetControlID="btntestmsg" PopupControlID="MsgBOx" CancelControlID="btnAlertmsgOk" PopupDragHandleControlID="MsgBOx"  runat="server">
    </asp:ModalPopupExtender>
    </ContentTemplate>
    </asp:UpdatePanel>                       



    <script src="jquery/StyleMaster.js" type="text/javascript"></script>

    <script type="text/javascript">     
        function ShowCalendar() {
            $find('<%=txtoriginalrcvd_CalendarExtender.ClientID %>').show();
        }
        function ShowCalendar2() {
            $find('<%=txtBpcd_CalendarExtender.ClientID %>').show();
        }
        function ShowCalendar3() {
            $find('<%=txtconfirmrcvd_CalendarExtender.ClientID %>').show();
        }
        function ShowCalendar4(cal) {
            $find(cal).show();
        }
        function clr() {
            document.getElementById("ContentPlaceHolder1_C1TabControl1_C1TabPage1_btnClear").click();
        }       
       
                



</script>
           
</asp:Content>
