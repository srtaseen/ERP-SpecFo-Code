<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Smt_Mer_BOMEstimate.aspx.cs" Inherits="Smt_Mer_BOMEstimate" %>
<%@ Register Assembly="C1.Web.UI.Controls.4" Namespace="C1.Web.UI.Controls.C1GridView"
    TagPrefix="cc3" %>
<%@ Register assembly="C1.Web.UI.Controls.4" namespace="C1.Web.UI.Controls.C1ComboBox" tagprefix="cc1" %>
<%@ Register assembly="C1.Web.UI.Controls.4" namespace="C1.Web.UI.Controls.C1TabControl" tagprefix="cc2" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
        {
            margin-left: 160px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
    <table width="100%">
    <tr>
    <td valign="top">
     <div class="pnlmain">
     <div class="pnlheader">Style Information</div>
    <table style="width:100%;">
                        <tr>
                            <td align="right">
                                <asp:Label ID="Label1" runat="server" Text="Style No" Font-Size="10pt"></asp:Label>
                            </td>
                            <td align="left">
                                <asp:DropDownList ID="drpStyleno" runat="server" 
                                    Width="200px" AutoPostBack="True"                                      
                                    CssClass="dropdownlist" TabIndex="1" 
                                    onselectedindexchanged="drpStyleno_SelectedIndexChanged">
                                </asp:DropDownList>
                                <asp:Button ID="btnClearall" TabIndex="200" runat="server" Font-Size="8px" 
                                    Text="..." ToolTip="Clear All" Width="15px" onclick="btnClearall_Click" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                    ControlToValidate="drpStyleno" Display="None" ErrorMessage="Select Style No" 
                                    ValidationGroup="s">*</asp:RequiredFieldValidator>
                                <asp:ValidatorCalloutExtender ID="RequiredFieldValidator1_ValidatorCalloutExtender" 
                                    runat="server" Enabled="True" TargetControlID="RequiredFieldValidator1">
                                </asp:ValidatorCalloutExtender>
                            </td>
                            <td align="right">
                                <asp:Label ID="Label5" runat="server" Text="Brand" Font-Size="10pt"></asp:Label>
                            </td>
                            <td style="margin-left: 40px">
                                <asp:TextBox ID="txtBrand" runat="server" Width="200px" 
                                    Enabled="False" CssClass="textbox"></asp:TextBox>
                            </td>
                            <td style="margin-left: 40px" align="right">
                                <asp:Label ID="Label7" runat="server" Font-Size="10pt" Text="Garment Division"></asp:Label>
                            </td>
                            <td style="margin-left: 40px">
                                <asp:TextBox ID="txtGarmentDpt" runat="server" CssClass="textbox" 
                                    Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:Label ID="Label2" runat="server" Text="Buyer" Font-Size="10pt"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtBuyer" runat="server" Width="200px" 
                                    Enabled="False" CssClass="textbox"></asp:TextBox>
                            </td>
                            <td align="right">
                                <asp:Label ID="Label6" runat="server" Text="Garment Type" Font-Size="10pt"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtGarmenttype" runat="server" Width="200px" 
                                    Enabled="False" CssClass="textbox"></asp:TextBox>
                            </td>
                            <td align="right">
                                <asp:Label ID="Label17" runat="server" Font-Size="10pt" Text="Currency"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="drpCurrencytype" runat="server" CssClass="dropdownlist" 
                                    TabIndex="2" Width="100px">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:Label ID="Label3" runat="server" Text="Season" Font-Size="10pt"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtSeason" runat="server" Width="200px" Enabled="False" 
                                    CssClass="textbox"></asp:TextBox>
                            </td>
                            <td align="right">
                                <asp:Label ID="Label4" runat="server" Font-Size="10pt" Text="Store"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtStore" runat="server" CssClass="textbox" Enabled="False" 
                                    Width="200px"></asp:TextBox>
                            </td>
                            <td align="right">
                                <asp:Label ID="Label15" runat="server" Font-Bold="True" Font-Size="10pt" 
                                    ForeColor="#339966" Text="Ordered Qty"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtOrdqtysum" runat="server" BorderColor="#2C8558" 
                                    BorderStyle="Solid" BorderWidth="1px" CssClass="textbox" Enabled="False" 
                                    Font-Bold="True" Font-Size="12px" Width="100px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                    ControlToValidate="drpCurrencytype" Display="None" 
                                    ErrorMessage="Select Currency" ValidationGroup="s">*</asp:RequiredFieldValidator>
                                <asp:ValidatorCalloutExtender ID="RequiredFieldValidator3_ValidatorCalloutExtender" 
                                    runat="server" Enabled="True" TargetControlID="RequiredFieldValidator3">
                                </asp:ValidatorCalloutExtender>
                            </td>
                        </tr>
                    </table>
    </div>
    </td>
    </tr>
    </table>
   
  
  <div style="height:3px"></div>
  <div class="pnlmain">
      <div style="height:380px; width:1022px; overflow:auto">
                        <asp:GridView ID="grdBOM" runat="server" AutoGenerateColumns="false" 
                           GridLines="None" Width="100%" onrowdatabound="grdBOM_RowDataBound">
                           <HeaderStyle CssClass="gridheader" />
                           <RowStyle Height="18px" />
                           <Columns> 
                              <asp:TemplateField>
                           <ItemTemplate>                      
                           <asp:ImageButton ID="btnRemoveBOM" TabIndex="25" Height="13px" runat="server" ToolTip="Delete" 
                                   ImageUrl="~/gridimage/grdRemove.png"  onclick="btnRemoveBOM_Click" />
                               <asp:ConfirmButtonExtender ID="btnRemoveBOM_ConfirmButtonExtender" 
                                   runat="server" ConfirmText="Do you want to delete this item?" Enabled="True" 
                                   TargetControlID="btnRemoveBOM">
                               </asp:ConfirmButtonExtender>
                           </ItemTemplate>
                           <HeaderTemplate>
                            <asp:ImageButton ID="btnAddnewBOMRow" ValidationGroup="I" TabIndex="24" Height="13px" 
                                   runat="server" ToolTip="Add New Item" 
                                   ImageUrl="~/images/plus.png" onclick="btnAddnewBOMRow_Click" />
                           </HeaderTemplate>
                           </asp:TemplateField>  
                           <asp:TemplateField>
                           <ItemTemplate>                      
                           <asp:ImageButton ID="btnLoadBOM" TabIndex="25" Height="13px" Width="13px" runat="server" ToolTip="Load Data" 
                                   ImageUrl="~/gridimage/ref1.png" onclick="btnLoadBOM_Click" />
                           </ItemTemplate>
                          
                           </asp:TemplateField>    
                                                  
                           <asp:TemplateField HeaderText="Main Category">
                           <ItemTemplate>
                           <asp:DropDownList ID="drpBommaincategory" AutoPostBack="true" CssClass="textboxforgridview" 
                                   runat="server" Width="100px" 
                                   onselectedindexchanged="drpBommaincategory_SelectedIndexChanged"></asp:DropDownList>
                               <asp:RequiredFieldValidator ID="Req_MainCat" runat="server" 
                                   ControlToValidate="drpBommaincategory" Display="None" 
                                   ErrorMessage="Select Main Category" ValidationGroup="I">*</asp:RequiredFieldValidator>
                               <asp:ValidatorCalloutExtender ID="Req_MainCat_ValidatorCalloutExtender" 
                                   runat="server" Enabled="True" TargetControlID="Req_MainCat">
                               </asp:ValidatorCalloutExtender>
                           </ItemTemplate>
                           </asp:TemplateField>
                           <asp:TemplateField HeaderText="Sub Category">
                           <ItemTemplate>
                           <asp:DropDownList ID="drpItemdesc"  CssClass="textboxforgridview" runat="server" 
                                   Width="150px" AutoPostBack="True" 
                                   onselectedindexchanged="drpItemdesc_SelectedIndexChanged"></asp:DropDownList>
                               <asp:RequiredFieldValidator ID="Req_Item" runat="server" 
                                   ControlToValidate="drpItemdesc" Display="None" ErrorMessage="Select Item" 
                                   ValidationGroup="I">*</asp:RequiredFieldValidator>
                               <asp:ValidatorCalloutExtender ID="Req_Item_ValidatorCalloutExtender" 
                                   runat="server" Enabled="True" TargetControlID="Req_Item">
                               </asp:ValidatorCalloutExtender>
                           </ItemTemplate>
                           </asp:TemplateField>                         
                           <asp:TemplateField HeaderText="Construction">
                           <ItemTemplate>
                           <asp:DropDownList ID="drpBOmconstruction" CssClass="textboxforgridview" 
                                   runat="server" Width="110px"></asp:DropDownList>
                           </ItemTemplate>
                           </asp:TemplateField>       
                           
                            <asp:TemplateField HeaderText="Dimension">
                           <ItemTemplate>
                           <asp:DropDownList ID="drpBOMDimension" CssClass="textboxforgridview" 
                                   runat="server" Width="110px"></asp:DropDownList>
                           </ItemTemplate>
                           </asp:TemplateField>     
                                           
                           <asp:TemplateField HeaderText="Unit">
                           <ItemTemplate>
                           <asp:DropDownList ID="drpBomUnit" CssClass="textboxforgridview" runat="server" 
                                   Width="60px" AutoPostBack="true"
                                   onselectedindexchanged="drpBomUnit_SelectedIndexChanged"></asp:DropDownList>
                                    <asp:TextBox ID="txtUnitparam" style="display:none" CssClass="textboxforgridview" runat="server" Width="30px"></asp:TextBox>
                           </ItemTemplate>
                           </asp:TemplateField>
                          
                           <asp:TemplateField HeaderText="type">
                           <ItemTemplate>
                           <asp:DropDownList ID="drpbomtype"  CssClass="textboxforgridview" runat="server" Width="50px">
                               <asp:ListItem></asp:ListItem>
                               <asp:ListItem>PCS</asp:ListItem>
                               <asp:ListItem>DOZ</asp:ListItem>
                               </asp:DropDownList>
                               <asp:RequiredFieldValidator ID="Req_BOMType" runat="server" 
                                   ControlToValidate="drpbomtype" Display="None" 
                                   ErrorMessage="Select Type" ValidationGroup="I">*</asp:RequiredFieldValidator>
                               <asp:ValidatorCalloutExtender ID="Req_bomtype_ValidatorCalloutExtender" 
                                   runat="server" Enabled="True" TargetControlID="Req_BOMType">
                               </asp:ValidatorCalloutExtender>
                               <asp:TextBox ID="txtParam" Width="20px"  CssClass="textbox" style="display:none" runat="server"></asp:TextBox>
                           </ItemTemplate>
                           </asp:TemplateField>
                           <asp:TemplateField HeaderText="Consm.">
                           <ItemTemplate>
                           <asp:TextBox ID="txtBOMconsumption"  CssClass="textboxforgridviewNumeric" runat="server" Width="50px" MaxLength="10"></asp:TextBox>
                               <asp:FilteredTextBoxExtender ID="txtBOMconsumption_FilteredTextBoxExtender" 
                                   runat="server" Enabled="True" TargetControlID="txtBOMconsumption" 
                                   ValidChars=".0123456789">
                               </asp:FilteredTextBoxExtender>
                           </ItemTemplate>
                           </asp:TemplateField>
                           <asp:TemplateField HeaderText="WST%">
                           <ItemTemplate>
                           <asp:TextBox ID="txtbomwst"  CssClass="textboxforgridviewNumeric" runat="server" Width="40px" MaxLength="10"></asp:TextBox>
                               <asp:FilteredTextBoxExtender ID="txtbomwst_FilteredTextBoxExtender" 
                                   runat="server" Enabled="True" TargetControlID="txtbomwst" 
                                   ValidChars=".0123456789">
                               </asp:FilteredTextBoxExtender>
                           </ItemTemplate>
                           </asp:TemplateField>
                           <asp:TemplateField HeaderText="Rate">
                           <ItemTemplate>
                           <asp:TextBox ID="txtbomrate"  CssClass="textboxforgridviewNumeric" runat="server" Width="50px" MaxLength="10"></asp:TextBox>
                               <asp:FilteredTextBoxExtender ID="txtbomrate_FilteredTextBoxExtender" 
                                   runat="server" Enabled="True" TargetControlID="txtbomrate" 
                                   ValidChars=".0123456789">
                               </asp:FilteredTextBoxExtender>
                           </ItemTemplate>
                           </asp:TemplateField>
                           <asp:TemplateField HeaderText="Value">
                           <ItemTemplate>
                           <asp:TextBox ID="txtbomvalue"  CssClass="textboxforgridviewNumeric" runat="server" Width="60px" MaxLength="10" Enabled="False"></asp:TextBox>
                           </ItemTemplate>
                           </asp:TemplateField>
                        
                           <asp:TemplateField HeaderText="GMTQty">
                           <ItemTemplate>
                           <asp:TextBox ID="txtbomgmtqty"  CssClass="textboxforgridviewNumeric" runat="server" Width="50px" Enabled="False"></asp:TextBox>
                           </ItemTemplate>
                           </asp:TemplateField>
                           <asp:TemplateField HeaderText="Requirement">
                           <ItemTemplate>
                           <asp:TextBox ID="txtbomrequirement" CssClass="textboxforgridviewNumeric" runat="server" Width="70px" MaxLength="8" Enabled="False"></asp:TextBox>
                           </ItemTemplate>
                           </asp:TemplateField>                                               
                           <asp:TemplateField HeaderText="Placement">
                           <ItemTemplate>
                           <asp:TextBox ID="txtBomplacement" CssClass="textboxforgridview" runat="server" Width="50px" MaxLength="50"></asp:TextBox>
                           </ItemTemplate>
                           </asp:TemplateField>                      
                           </Columns>
                       </asp:GridView>
                        </div>
                        </div>
                        <div class="pnlmain">                      
                                <table style="width: 100%;">
                                <tr>
                                    <td>
                                   
                                    <asp:Button ID="btnaddsubcat" Width="100px" ToolTip="Add Sub Category" runat="server" CssClass="btPOPUP" Text="Sub Category" />
                                    <asp:Button ID="btnaddarticle" Width="100px" ToolTip="Add Article" runat="server" CssClass="btPOPUP" Text="Construction" />
                                    <asp:Button ID="btnadddimension" Width="100px" ToolTip="Add Dimension" runat="server" CssClass="btPOPUP" Text="Dimension" />
                                    <asp:Button ID="btnCopy" Visible="false" Width="100px" ToolTip="Add Dimension" runat="server" CssClass="btPOPUP" Text="Copy Estimate BOM" />
                                    
                                    </td>
                                    <td align="right">                            
                                      <div align="right" style="padding:5px;width:300px">
                                        <asp:Button ID="btnClear" runat="server" Text="Clear" Width="130px" 
                                        onclick="btnClear_Click" CssClass="button" />
                                        <asp:Button ID="btnSave" runat="server" Text="Save"  Width="130px" 
                                        onclick="btnSave_Click" ValidationGroup="s" CssClass="button" />
                                          <asp:ConfirmButtonExtender ID="btnSave_ConfirmButtonExtender" runat="server" 
                                              ConfirmText="Do you want to save this data?" Enabled="True" 
                                              TargetControlID="btnSave">
                                          </asp:ConfirmButtonExtender>
                                    </div>
                                    </td>
                                   
                                </tr>
                                
                            </table>
                        </div>
                           </ContentTemplate>
    </asp:UpdatePanel>
      <div id="D1" class="POPUPPanel">
        <div id="POPUPHDR">
        <div class="POPUPHeaderText">Add New Buyer</div>
        <div class="POPUPClose"></div>      
        </div>
          <iframe id="POPUPIFrame" width="800px" height="550px" src=""></iframe>
        </div>   
    <script src="jquery/BOM.js" type="text/javascript"></script>
    
</asp:Content>


