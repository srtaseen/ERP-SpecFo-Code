<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Smt_Mer_EstimateCosting.aspx.cs" Inherits="Smt_Mer_EstimateCosting" %>

<%@ Register Assembly="C1.Web.UI.Controls.4" Namespace="C1.Web.UI.Controls.C1GridView"
    TagPrefix="cc3" %>
<%@ Register assembly="C1.Web.UI.Controls.4" namespace="C1.Web.UI.Controls.C1ComboBox" tagprefix="cc1" %>
<%@ Register assembly="C1.Web.UI.Controls.4" namespace="C1.Web.UI.Controls.C1TabControl" tagprefix="cc2" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<style type="text/css">
.table { border-spacing:0; border:1px solid gray;}
.table.tablesorter thead tr .header {
	background-image: url(images/bg.png);
	background-repeat: no-repeat;
	background-position: center right;
	cursor: pointer;
}
.table.tablesorter tbody td {
	color: #3D3D3D;
	padding-left:4px;
	padding-right:4px;
	padding-bottom:2px;
	padding-top:2px;
	background-color: #FFF;
	vertical-align: top;
	font-size:10px;
	font-family:Verdana;
}
.table td { border-spacing:0; border:1px solid silver;}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
    <div class="pnlmain" style="padding:5px">
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
                                <asp:Button ID="btnClearall" TabIndex="200" runat="server" Font-Size="9px" 
                                   Text="..." ToolTip="Clear All" Width="15px" 
                                    CssClass="tr" onclick="btnClearall_Click" />
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
                            <td align="right">
                                <asp:Label ID="Label15" runat="server" Font-Size="10pt" Text="Ord Qty"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtOrdqtysum" runat="server" CssClass="textbox" Enabled="False" 
                                    Width="60px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:Label ID="Label2" runat="server" Text="Buyer" Font-Size="10pt"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtBuyer" runat="server" Width="200px" 
                                    Enabled="False" CssClass="textbox"></asp:TextBox>
                                <asp:TextBox ID="txtrowMat" style="display:none" runat="server" CssClass="textbox" Width="60px"></asp:TextBox>
                            </td>
                            <td align="right">
                                <asp:Label ID="Label6" runat="server" Text="Garment Type" Font-Size="10pt"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtGarmenttype" runat="server" Width="200px" 
                                    Enabled="False" CssClass="textbox"></asp:TextBox>
                            </td>
                            <td align="right">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
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
                                <asp:Label ID="Label7" runat="server" Text="Garment Division" Font-Size="10pt"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtGarmentDpt" runat="server" Width="200px" 
                                    Enabled="False" CssClass="textbox"></asp:TextBox>
                            </td>
                            <td align="right">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:Label ID="Label4" runat="server" Text="Store" Font-Size="10pt"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtStore" runat="server" Width="150px" 
                                    Enabled="False" CssClass="textbox"></asp:TextBox>
                            </td>
                            <td align="right">
                                &nbsp;</td>
                            <td valign="middle">                              
                               
                            </td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
    </div>
   
    <div style="height:4px"></div>
     <cc2:C1TabControl ID="C1TabControl1" runat="server" width="100%"                    
                TextImageRelation="ImageBeforeText" onclienttabmouseenter="clr">
               <TabPages>
                <cc2:C1TabPage ID="C1TabPage1" TabIndex="0" Text="Estimate Costing" CssClass="tab">
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                        <ContentTemplate>
                      <div>
                          <table style="width: 100%;">
                              <tr>
                                  <td valign="top" align="left" width="205px">
                                  <div class="pnlmain" style="width:300px">
                                  <div class="pnlheader">Base on Estimate BOM</div>
                                  <div style="height:85px; overflow:auto" align="left">
                                      <asp:GridView ID="grdMastercat" AutoGenerateColumns="false" Width="100%" 
                                          runat="server" onrowdatabound="grdMastercat_RowDataBound" CssClass="mGrid">
                                          <AlternatingRowStyle CssClass="gridrowAlternaterow" />
                                      <Columns>
                                      <asp:BoundField DataField="cMasterCategory" HeaderText="Master Category" />                                      
                                      <asp:TemplateField HeaderText="Total Value">
                                      <ItemTemplate>
                                      <asp:Label ID="lblid" Visible="false" runat="server" Text='<%# Eval("nMasterCategory_ID") %>'></asp:Label>
                                      <asp:Label ID="lblVal" runat="server" Text='<%# Eval("TotalValue") %>'></asp:Label>
                                      </ItemTemplate>
                                      </asp:TemplateField>
                                      <asp:TemplateField>
                                      <ItemTemplate>
                                      <asp:CheckBox ID="chkSelect" runat="server" Text="" />
                                      </ItemTemplate>
                                      </asp:TemplateField>
                                      </Columns>
                                          <HeaderStyle CssClass="gridheader" />
                                          <RowStyle CssClass="gridrow" />
                                      </asp:GridView>
                                  </div>
                                  </div>
                                  </td>
                                  <td valign="top">
                                    <div class="pnlmain" style="height:108px; width:100%; background-color:#eeeeee">
                                  <div class="pnlheader"></div>
                                        <table style="width: 100%;">
                                            <tr>
                                                <td align="right">
                                                    &nbsp;
                                                    <asp:Label ID="Label18" runat="server" CssClass="label" 
                                                        Text="Raw Materials($/Doz)"></asp:Label>
                                                </td>
                                                <td>
                                                    &nbsp;
                                                    <asp:TextBox ID="txtRawmaterial" runat="server" CssClass="textbox" 
                                                        Width="100px" MaxLength="10" TabIndex="1"></asp:TextBox>
                                                    <asp:FilteredTextBoxExtender ID="txtRawmaterial_FilteredTextBoxExtender" 
                                                        runat="server" Enabled="True" TargetControlID="txtRawmaterial" 
                                                        ValidChars=".0123456789">
                                                    </asp:FilteredTextBoxExtender>
                                                </td>
                                                <td align="right">
                                                    &nbsp;
                                                    <asp:Label ID="Label21" runat="server" CssClass="label" Text="Washing($/Doz)"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="txtWashing" runat="server" CssClass="textbox" 
                                                        Width="100px" MaxLength="10" TabIndex="4"></asp:TextBox>
                                                    <asp:FilteredTextBoxExtender ID="txtWashing_FilteredTextBoxExtender" 
                                                        runat="server" Enabled="True" TargetControlID="txtWashing" 
                                                        ValidChars=".0123456789">
                                                    </asp:FilteredTextBoxExtender>
                                                </td>
                                                <td align="right">
                                                    <asp:Label ID="Label24" runat="server" CssClass="label" Text="Print Type"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="txtPrinttype" runat="server" CssClass="textbox" 
                                                        Width="150px" MaxLength="50" TabIndex="7"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right">
                                                    &nbsp;
                                                    <asp:Label ID="Label19" runat="server" CssClass="label" Text="Embroidry($/Doz)"></asp:Label>
                                                </td>
                                                <td>
                                                    &nbsp;
                                                    <asp:TextBox ID="txtembroidry" runat="server" CssClass="textbox" 
                                                        Width="100px" MaxLength="10" TabIndex="2"></asp:TextBox>
                                                    <asp:FilteredTextBoxExtender ID="txtembroidry_FilteredTextBoxExtender" 
                                                        runat="server" Enabled="True" TargetControlID="txtembroidry" 
                                                        ValidChars=".0123456789">
                                                    </asp:FilteredTextBoxExtender>
                                                </td>
                                                <td align="right">
                                                    &nbsp;
                                                    <asp:Label ID="Label22" runat="server" CssClass="label" Text="Other($/Dz)"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="txtOther" runat="server" CssClass="textbox" 
                                                        Width="100px" MaxLength="10" TabIndex="5"></asp:TextBox>
                                                    <asp:FilteredTextBoxExtender ID="txtOther_FilteredTextBoxExtender" 
                                                        runat="server" Enabled="True" TargetControlID="txtOther" 
                                                        ValidChars=".0123456789">
                                                    </asp:FilteredTextBoxExtender>
                                                </td>
                                                <td align="right">
                                                    <asp:Label ID="Label25" runat="server" CssClass="label" Text="Wash Type"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="txtWashtype" runat="server" CssClass="textbox" 
                                                        Width="150px" MaxLength="50" TabIndex="8"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right">
                                                    &nbsp;
                                                    <asp:TextBox ID="txtCheckRow" Visible="false" runat="server" Height="18px" Width="20px" 
                                                        Font-Size="8px"></asp:TextBox>
                                                    <asp:Label ID="Label20" runat="server" CssClass="label" Text="Printing($/Doz)"></asp:Label>
                                                </td>
                                                <td>
                                                    &nbsp;
                                                    <asp:TextBox ID="txtPrinting" runat="server" CssClass="textbox" 
                                                        Width="100px" MaxLength="10" TabIndex="3"></asp:TextBox>
                                                    <asp:FilteredTextBoxExtender ID="txtPrinting_FilteredTextBoxExtender" 
                                                        runat="server" Enabled="True" TargetControlID="txtPrinting" 
                                                        ValidChars=".0123456789">
                                                    </asp:FilteredTextBoxExtender>
                                                </td>
                                                <td align="right">
                                                    &nbsp;
                                                    <asp:Label ID="Label23" runat="server" Visible="false" CssClass="label" Text="Rate($/Unit)"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="txtRate" Visible="false" runat="server" CssClass="textbox" 
                                                        Width="100px" MaxLength="10" TabIndex="6"></asp:TextBox>
                                                    <asp:FilteredTextBoxExtender ID="txtRate_FilteredTextBoxExtender" 
                                                        runat="server" Enabled="True" TargetControlID="txtRate" 
                                                        ValidChars=".0123456789">
                                                    </asp:FilteredTextBoxExtender>
                                                </td>
                                                <td align="right">
                                                    <asp:Label ID="Label26" runat="server" CssClass="label" Text="Stich/GMT"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="txtGMT" runat="server" CssClass="textbox" 
                                                        Width="150px" MaxLength="50" TabIndex="9"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                  </div>
                                  </td>
                                
                              </tr>
                             
                          </table>
                      </div>
                      <div>
                          <table style="width: 100%;">
                              <tr>
                                  <td align="left" width="700px" valign="top">
                                 <div class="pnlmain" style="height:235px">
                                     <table id="tblDtl" class="mGrid" border="1" runat="server" style="width: 100%;">
                                         <tr class="pnlheader">
                                             <td>
                                                 &nbsp;</td>
                                             <td align="center" >
                                                 %</td>
                                             <td align="center" >
                                                 US $/Pcs</td>
                                             <td align="center" >
                                                 US $/Dz</td>
                                             <td align="center" >
                                                 Total(US $)</td>
                                         </tr>
                                         <tr>
                                             <td align="right" width="120px">
                                             
                                                 <asp:Label ID="Label27" runat="server" CssClass="label" 
                                                     Text="Sub Total($/Doz)"></asp:Label>
                                             </td>
                                             <td align="center">
                                               
                                                 <asp:TextBox ID="txtSubtotalpercntg" runat="server" CssClass="textbox" 
                                                     Width="120px" MaxLength="10" Enabled="False"></asp:TextBox>
                                             </td>
                                             <td align="center" >
                                              <asp:TextBox ID="txtSubttlperpcs" runat="server" CssClass="textbox" 
                                                     Width="100px" Enabled="False"></asp:TextBox>
                                             </td>
                                             <td align="center" >
                                                 <asp:TextBox ID="txtSubttlDzn" runat="server" CssClass="textbox" 
                                                     Width="100px" Enabled="False"></asp:TextBox>
                                             </td>
                                             <td align="center" >
                                                 <asp:TextBox ID="txtSubttlTtl" runat="server" CssClass="textbox" 
                                                     Width="120px" Enabled="False"></asp:TextBox>
                                             </td>
                                         </tr>
                                         <tr>
                                             <td align="right" >
                                             
                                                 <asp:Label ID="Label28" runat="server" CssClass="label" 
                                                     Text="FOB"></asp:Label>
                                             </td>
                                             <td align="center" >
                                              
                                                 <asp:TextBox ID="txtfobpercntg" runat="server" CssClass="textbox" 
                                                     Width="120px" MaxLength="10" Enabled="False">100</asp:TextBox>
                                             </td>
                                             <td align="center">
                                              
                                                 <asp:TextBox ID="txtFobperpcs" runat="server" CssClass="textbox" 
                                                     Width="100px" BorderColor="#6699FF" BorderStyle="Solid" BorderWidth="1px" 
                                                     MaxLength="5" TabIndex="10"></asp:TextBox>
                                                 <asp:FilteredTextBoxExtender ID="txtFobperpcs_FilteredTextBoxExtender" 
                                                     runat="server" Enabled="True" TargetControlID="txtFobperpcs" 
                                                     ValidChars=".0123456789">
                                                 </asp:FilteredTextBoxExtender>
                                             </td>
                                             <td align="center" >
                                                 <asp:TextBox ID="txtFobdzn" runat="server" CssClass="textbox" 
                                                     Width="100px" Enabled="False"></asp:TextBox>
                                                 <asp:FilteredTextBoxExtender ID="txtFobdzn_FilteredTextBoxExtender" 
                                                     runat="server" Enabled="True" TargetControlID="txtFobdzn" 
                                                     ValidChars=".0123456789">
                                                 </asp:FilteredTextBoxExtender>
                                             </td>
                                             <td align="center"  >
                                                 <asp:TextBox ID="txtFobttl" runat="server" CssClass="textbox" 
                                                     Width="120px" Enabled="False"></asp:TextBox>
                                             </td>
                                         </tr>
                                         <tr style="display:none">
                                             <td align="right" >
                                                
                                                 <asp:Label ID="Label29" runat="server" CssClass="label" 
                                                     Text="Gross CM"></asp:Label>
                                             </td>
                                             <td align="center" >
                                             
                                                 <asp:TextBox ID="txtGrosscmpercntg" runat="server" CssClass="textbox" 
                                                     Width="120px" MaxLength="10" Enabled="False"></asp:TextBox>
                                                 <asp:FilteredTextBoxExtender ID="txtGrosscmpercntg_FilteredTextBoxExtender" 
                                                     runat="server" Enabled="True" TargetControlID="txtGrosscmpercntg" 
                                                     ValidChars=".0123456789">
                                                 </asp:FilteredTextBoxExtender>
                                             </td>
                                             <td align="center" >
                                               
                                                 <asp:TextBox ID="txtgrossperpcs" runat="server" CssClass="textbox" 
                                                     Width="100px" Enabled="False"></asp:TextBox>
                                                 <asp:FilteredTextBoxExtender ID="txtgrossperpcs_FilteredTextBoxExtender" 
                                                     runat="server" Enabled="True" TargetControlID="txtgrossperpcs" 
                                                     ValidChars=".0123456789">
                                                 </asp:FilteredTextBoxExtender>
                                             </td>
                                             <td align="center" >
                                                 <asp:TextBox ID="txtGrossdzn" runat="server" CssClass="textbox" 
                                                     Width="100px" Enabled="False"></asp:TextBox>
                                                 <asp:FilteredTextBoxExtender ID="txtGrossdzn_FilteredTextBoxExtender" 
                                                     runat="server" Enabled="True" TargetControlID="txtGrossdzn" 
                                                     ValidChars=".0123456789">
                                                 </asp:FilteredTextBoxExtender>
                                             </td>
                                             <td align="center" >
                                                 <asp:TextBox ID="txtGrossttl" runat="server" CssClass="textbox" 
                                                     Width="120px" Enabled="False"></asp:TextBox>
                                             </td>
                                         </tr>
                                         <tr>
                                             <td align="right" >
                                                 <asp:Label ID="Label30" runat="server" CssClass="label" 
                                                     Text="Mfg. Cost"></asp:Label>
                                             </td>
                                             <td align="center" >
                                                 <asp:TextBox ID="txtmfgcostpercntg" runat="server" CssClass="textbox" 
                                                     Width="120px" MaxLength="10" Enabled="False"></asp:TextBox>
                                                 <asp:FilteredTextBoxExtender ID="txtmfgcostpercntg_FilteredTextBoxExtender" 
                                                     runat="server" Enabled="True" TargetControlID="txtmfgcostpercntg" 
                                                     ValidChars=".0123456789">
                                                 </asp:FilteredTextBoxExtender>
                                             </td>
                                             <td align="center" >
                                                 <asp:TextBox ID="txtmfgperpcs" runat="server" CssClass="textbox" 
                                                     Width="100px" Enabled="False"></asp:TextBox>
                                                 <asp:FilteredTextBoxExtender ID="txtmfgperpcs_FilteredTextBoxExtender" 
                                                     runat="server" Enabled="True" TargetControlID="txtmfgperpcs" 
                                                     ValidChars=".0123456789">
                                                 </asp:FilteredTextBoxExtender>
                                             </td>
                                             <td align="center" >
                                                 <asp:TextBox ID="txtMfgdzn" runat="server" CssClass="textbox" 
                                                     Width="100px" BorderColor="#6699FF" BorderStyle="Solid" BorderWidth="1px" 
                                                     TabIndex="18" MaxLength="4"></asp:TextBox>
                                                 <asp:FilteredTextBoxExtender ID="txtMfgdzn_FilteredTextBoxExtender" 
                                                     runat="server" Enabled="True" TargetControlID="txtMfgdzn" 
                                                     ValidChars=".0123456789">
                                                 </asp:FilteredTextBoxExtender>
                                             </td>
                                             <td align="center" >
                                                 <asp:TextBox ID="txtMfgttl" runat="server" CssClass="textbox" 
                                                     Width="120px" Enabled="False"></asp:TextBox>
                                             </td>
                                         </tr>
                                         <tr>
                                             <td align="right" >
                                                 <asp:Label ID="Label31" runat="server" CssClass="label" 
                                                     Text="OverHead"></asp:Label>
                                             </td>
                                             <td align="center" >
                                                 <asp:TextBox ID="txtOverheadpercntg" runat="server" CssClass="textbox" 
                                                     Width="120px" MaxLength="10" Enabled="False"></asp:TextBox>
                                                 <asp:FilteredTextBoxExtender ID="txtOverheadpercntg_FilteredTextBoxExtender" 
                                                     runat="server" Enabled="True" TargetControlID="txtOverheadpercntg" 
                                                     ValidChars=".0123456789">
                                                 </asp:FilteredTextBoxExtender>
                                             </td>
                                             <td align="center" >
                                                 <asp:TextBox ID="txtOverheadperpcs" runat="server" CssClass="textbox" 
                                                     Width="100px" BorderColor="#6699FF" BorderStyle="Solid" BorderWidth="1px" 
                                                     TabIndex="11" MaxLength="4"></asp:TextBox>
                                                 <asp:FilteredTextBoxExtender ID="txtOverheadperpcs_FilteredTextBoxExtender" 
                                                     runat="server" Enabled="True" TargetControlID="txtOverheadperpcs" 
                                                     ValidChars=".0123456789">
                                                 </asp:FilteredTextBoxExtender>
                                             </td>
                                             <td align="center" >
                                                 <asp:TextBox ID="txtOverheaddzn" runat="server" CssClass="textbox" 
                                                     Width="100px" Enabled="False"></asp:TextBox>
                                                 <asp:FilteredTextBoxExtender ID="txtOverheaddzn_FilteredTextBoxExtender" 
                                                     runat="server" Enabled="True" TargetControlID="txtOverheaddzn" 
                                                     ValidChars=".0123456789">
                                                 </asp:FilteredTextBoxExtender>
                                             </td>
                                             <td align="center" >
                                                 <asp:TextBox ID="txtOverheadttl" runat="server" CssClass="textbox" 
                                                     Width="120px" Enabled="False"></asp:TextBox>
                                             </td>
                                         </tr>
                                         <tr >
                                             <td align="right" >
                                                 <asp:Label ID="Label32" runat="server" CssClass="label" 
                                                     Text="Commission"></asp:Label>
                                             </td>
                                             <td align="center">
                                                 <asp:TextBox ID="txtComissionpercntg" runat="server" CssClass="textbox" 
                                                     Width="120px" MaxLength="3" BorderColor="#6699FF" BorderStyle="Solid" 
                                                     BorderWidth="1px" TabIndex="12"></asp:TextBox>
                                                 <asp:FilteredTextBoxExtender ID="txtComissionpercntg_FilteredTextBoxExtender" 
                                                     runat="server" Enabled="True" TargetControlID="txtComissionpercntg" 
                                                     ValidChars=".0123456789">
                                                 </asp:FilteredTextBoxExtender>
                                             </td>
                                             <td align="center">
                                                 <asp:TextBox ID="txtcomissionpcs" runat="server" CssClass="textbox" 
                                                     Width="100px" Enabled="False"></asp:TextBox>
                                                 <asp:FilteredTextBoxExtender ID="txtcomissionpcs_FilteredTextBoxExtender" 
                                                     runat="server" Enabled="True" TargetControlID="txtcomissionpcs" 
                                                     ValidChars=".0123456789">
                                                 </asp:FilteredTextBoxExtender>
                                             </td>
                                             <td align="center">
                                                 <asp:TextBox ID="txtcomissionDzn" runat="server" CssClass="textbox" 
                                                     Width="100px" Enabled="False"></asp:TextBox>
                                                 <asp:FilteredTextBoxExtender ID="txtcomissionDzn_FilteredTextBoxExtender" 
                                                     runat="server" Enabled="True" TargetControlID="txtcomissionDzn" 
                                                     ValidChars=".0123456789">
                                                 </asp:FilteredTextBoxExtender>
                                             </td>
                                             <td align="center" >
                                                 <asp:TextBox ID="txtComissionttl" runat="server" CssClass="textbox" 
                                                     Width="120px" Enabled="False"></asp:TextBox>
                                             </td>
                                         </tr>
                                         <tr>
                                             <td align="right" >
                                                 <asp:Label ID="Label33" runat="server" CssClass="label" 
                                                     Text="Total Cost" Font-Bold="True" Font-Size="12px" ForeColor="Black"></asp:Label>
                                             </td>
                                             <td align="center" >
                                                 <asp:TextBox ID="txtTotalcostpercntg" runat="server" CssClass="textbox" 
                                                     Width="120px" MaxLength="10" BorderColor="#6699FF" BorderStyle="Solid" 
                                                     BorderWidth="1px" Enabled="False"></asp:TextBox>
                                                 <asp:FilteredTextBoxExtender ID="txtTotalcostpercntg_FilteredTextBoxExtender" 
                                                     runat="server" Enabled="True" TargetControlID="txtTotalcostpercntg" 
                                                     ValidChars=".0123456789">
                                                 </asp:FilteredTextBoxExtender>
                                             </td>
                                             <td align="center" >
                                                 <asp:TextBox ID="txtTotalcostpcs" runat="server" CssClass="textbox" 
                                                     Width="100px" BorderColor="#6699FF" BorderStyle="Solid" BorderWidth="1px" 
                                                     Enabled="False"></asp:TextBox>
                                                 <asp:FilteredTextBoxExtender ID="txtTotalcostpcs_FilteredTextBoxExtender" 
                                                     runat="server" Enabled="True" TargetControlID="txtTotalcostpcs" 
                                                     ValidChars=".0123456789">
                                                 </asp:FilteredTextBoxExtender>
                                             </td>
                                             <td align="center" >
                                                 <asp:TextBox ID="txtTotalCostDzn" runat="server" CssClass="textbox" 
                                                     Width="100px" Enabled="False"></asp:TextBox>
                                                 <asp:FilteredTextBoxExtender ID="txtTotalCostDzn_FilteredTextBoxExtender" 
                                                     runat="server" Enabled="True" TargetControlID="txtTotalCostDzn" 
                                                     ValidChars=".0123456789">
                                                 </asp:FilteredTextBoxExtender>
                                             </td>
                                             <td align="center" >
                                                 <asp:TextBox ID="txtTotalcostttl" runat="server" CssClass="textbox" 
                                                     Width="120px" Enabled="False"></asp:TextBox>
                                             </td>
                                         </tr>
                                         <tr>
                                             <td align="right" >
                                                 <asp:Label ID="Label34" runat="server" CssClass="label" 
                                                     Text="Profit Margin" Font-Bold="True" ForeColor="Black"></asp:Label>
                                             </td>
                                             <td align="center" >
                                                 <asp:TextBox ID="txtProfitmarginpercntg" runat="server" CssClass="textbox" 
                                                     Width="120px" MaxLength="10" BorderColor="#6699FF" BorderStyle="Solid" 
                                                     BorderWidth="1px" Enabled="False"></asp:TextBox>
                                                 <asp:FilteredTextBoxExtender ID="txtProfitmarginpercntg_FilteredTextBoxExtender" 
                                                     runat="server" Enabled="True" TargetControlID="txtProfitmarginpercntg" 
                                                     ValidChars="-.0123456789">
                                                 </asp:FilteredTextBoxExtender>
                                             </td>
                                             <td align="center" >
                                                 <asp:TextBox ID="txtProfitmarginpcs" runat="server" CssClass="textbox" 
                                                     Width="100px" BorderColor="#6699FF" BorderStyle="Solid" BorderWidth="1px" 
                                                     Enabled="False"></asp:TextBox>
                                                 <asp:FilteredTextBoxExtender ID="txtProfitmarginpcs_FilteredTextBoxExtender" 
                                                     runat="server" Enabled="True" TargetControlID="txtProfitmarginpcs" 
                                                     ValidChars="-.0123456789">
                                                 </asp:FilteredTextBoxExtender>
                                             </td>
                                             <td align="center" >
                                                 <asp:TextBox ID="txtProfitmargindzn" runat="server" CssClass="textbox" 
                                                     Width="100px" Enabled="False"></asp:TextBox>
                                                 <asp:FilteredTextBoxExtender ID="txtProfitmargindzn_FilteredTextBoxExtender" 
                                                     runat="server" Enabled="True" TargetControlID="txtProfitmargindzn" 
                                                     ValidChars="-.0123456789">
                                                 </asp:FilteredTextBoxExtender>
                                             </td>
                                             <td align="center" >
                                                 <asp:TextBox ID="txtProfitmarginttl" runat="server" CssClass="textbox" 
                                                     Width="120px" Enabled="False"></asp:TextBox>
                                             </td>
                                         </tr>
                                     </table>
                                 </div>
                                  </td>
                                  <td valign="top">
                   <div class="pnlmain" style="height:235px; background-color:#eeeeee">
                    <div class="pnlheader">Cost of Manufacturing Calculation</div>
                        <cc2:C1TabControl ID="C1TabControl2" runat="server" width="100%" Height="185px"  TextImageRelation="ImageBeforeText" onclienttabmouseenter="clr">
                           <TabPages>
                            <cc2:C1TabPage ID="C1TabPage3" TabIndex="0" Text="First Method" CssClass="tab">
                                <table style="width:100%;">
                                    <tr>
                                        <td align="right">
                                            SMV</td>
                                        <td align="left">
                                            <asp:TextBox ID="txtSmv" onkeyup="CmFirstmethod();" runat="server" CssClass="textbox" 
                                                MaxLength="10" Width="120px" TabIndex="13"></asp:TextBox>
                                            <asp:FilteredTextBoxExtender ID="txtSmv_FilteredTextBoxExtender" 
                                                runat="server" Enabled="True" TargetControlID="txtSmv" 
                                                ValidChars=".0123456789">
                                            </asp:FilteredTextBoxExtender>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            Cost Per Minuter@Effeciency</td>
                                        <td align="left">
                                            <asp:TextBox ID="txtCostPerminutesPrcnt" onkeyup="CmFirstmethod();" 
                                                runat="server" CssClass="textbox" 
                                                MaxLength="3" Width="35px" TabIndex="14"></asp:TextBox>
                                            %<asp:FilteredTextBoxExtender ID="txtCostPerminutesPrcnt_FilteredTextBoxExtender" 
                                                runat="server" Enabled="True" TargetControlID="txtCostPerminutesPrcnt" 
                                                ValidChars=".0123456789">
                                            </asp:FilteredTextBoxExtender>
                                            <asp:TextBox ID="txtCostPerminutesDollar" onkeyup="CmFirstmethod();" 
                                                runat="server" CssClass="textbox" 
                                                MaxLength="10" Width="63px" TabIndex="15"></asp:TextBox>
                                            <asp:FilteredTextBoxExtender ID="txtCostPerminutesDollar_FilteredTextBoxExtender" 
                                                runat="server" Enabled="True" TargetControlID="txtCostPerminutesDollar" 
                                                ValidChars=".0123456789">
                                            </asp:FilteredTextBoxExtender>
                                            $</td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            Plan Style Effeciency</td>
                                        <td align="left">
                                            <asp:TextBox ID="txtPlaneffPercnt" onkeyup="CmFirstmethod();" runat="server" CssClass="textbox" 
                                                MaxLength="3" Width="35px" TabIndex="16"></asp:TextBox>
                                            %<asp:FilteredTextBoxExtender ID="txtPlaneffPercnt_FilteredTextBoxExtender" 
                                                runat="server" Enabled="True" TargetControlID="txtPlaneffPercnt" 
                                                ValidChars=".0123456789">
                                            </asp:FilteredTextBoxExtender>
                                            <asp:TextBox ID="txtPlaneffDollar" runat="server" CssClass="textbox" 
                                                MaxLength="10" Width="63px" Enabled="False"></asp:TextBox>
                                            $</td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            Profit Margin(%)</td>
                                        <td align="left">
                                            <asp:TextBox ID="txtProfitMargin" onkeyup="CmFirstmethod();" runat="server" CssClass="textbox" 
                                                MaxLength="10" Width="120px" TabIndex="17"></asp:TextBox>
                                            <asp:FilteredTextBoxExtender ID="txtProfitMargin_FilteredTextBoxExtender" 
                                                runat="server" Enabled="True" TargetControlID="txtProfitMargin" 
                                                ValidChars=".0123456789">
                                            </asp:FilteredTextBoxExtender>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            Cost of Manufacturing(Dz/$)</td>
                                        <td align="left">
                                            <asp:TextBox ID="txtCMDz" runat="server" CssClass="textbox" 
                                                MaxLength="10" Width="120px" Enabled="False"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            Profit (Dz)</td>
                                        <td align="left">
                                            <asp:TextBox ID="txtProfitDz" runat="server" CssClass="textbox" 
                                                MaxLength="10" Width="120px" Enabled="False"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            Manufacturing Cost</td>
                                        <td align="left">
                                            <asp:TextBox ID="txtCMwithProfit" runat="server" CssClass="textbox" 
                                                MaxLength="10" Width="120px" ReadOnly="True"></asp:TextBox>
                                            &nbsp;</td>
                                    </tr>
                                </table>
                            </cc2:C1TabPage>
                            <cc2:C1TabPage ID="C1TabPage4"  TabIndex="1" Text="Second Method"  CssClass="tab">
                                <table style="width:100%;">
                                    <tr>
                                        <td align="right">
                                            &nbsp;</td>
                                        <td align="left">
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            Production Pcs/Hour</td>
                                        <td align="left">
                                            <asp:TextBox ID="txtProdperhour" runat="server" MaxLength="8" Width="120px" 
                                                CssClass="textbox"></asp:TextBox>
                                            <asp:FilteredTextBoxExtender ID="txtProdperhour_FilteredTextBoxExtender" 
                                                runat="server" Enabled="True" TargetControlID="txtProdperhour" 
                                                ValidChars=".0123456789">
                                            </asp:FilteredTextBoxExtender>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            No. Of Machine Req.</td>
                                        <td align="left">
                                            <asp:TextBox ID="txtnoOfmachineReq" runat="server" MaxLength="8" Width="120px" 
                                                CssClass="textbox"></asp:TextBox>
                                            <asp:FilteredTextBoxExtender ID="txtnoOfmachineReq_FilteredTextBoxExtender" 
                                                runat="server" Enabled="True" TargetControlID="txtnoOfmachineReq" 
                                                ValidChars=".0123456789">
                                            </asp:FilteredTextBoxExtender>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            Machine Cost/Hour</td>
                                        <td align="left">
                                            <asp:TextBox ID="txtMachinecostperHour" runat="server" MaxLength="8" 
                                                Width="120px" CssClass="textbox"></asp:TextBox>
                                            <asp:FilteredTextBoxExtender ID="txtMachinecostperHour_FilteredTextBoxExtender" 
                                                runat="server" Enabled="True" TargetControlID="txtMachinecostperHour" 
                                                ValidChars=".0123456789">
                                            </asp:FilteredTextBoxExtender>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            Manufacturing Cost/Dz</td>
                                        <td align="left">
                                            <asp:TextBox ID="txtmanufactCostDz" runat="server" 
                                                Width="120px" BackColor="#F2F2F2" CssClass="textbox" ReadOnly="True"></asp:TextBox>
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
                                </table>
                            </cc2:C1TabPage>             
              
                        </TabPages>
                     </cc2:C1TabControl>
                   </div>
                                  </td>
                                
                              </tr>
                             
                             
                          </table>
                      </div>
                      <div class="pnlmain" style="margin:3px">
                      <div align="right" style="padding:3px">
                        <asp:Button ID="btnClear" runat="server" Text="Clear" Width="100px" 
                              onclick="btnClear_Click" CssClass="button" />
                          <asp:Button ID="btnSave" runat="server" Text="Save" Width="100px" 
                              onclick="btnSave_Click" CssClass="button" />
                              <asp:ConfirmButtonExtender ID="btnSave_ConfirmButtonExtender" runat="server" 
                                     ConfirmText="Do you want to save this data?" Enabled="True" 
                                     TargetControlID="btnSave">
                              </asp:ConfirmButtonExtender>

                      </div>
                      </div>
                    
                        </ContentTemplate>
                    </asp:UpdatePanel>
                  
                </cc2:C1TabPage>
                <cc2:C1TabPage ID="C1TabPage2"  TabIndex="1" Text="Edit/View"  CssClass="tab">
                                <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                        <ContentTemplate>
                         <div style="height:405px">
                   
                               <cc3:C1GridView ID="grdEstimateCosting" runat="server" AllowPaging="True"  Width="100%"
                                        AutoGenerateColumns="False" PageSize="18" 
                                        ShowFilter="True" VisualStylePath="~/C1WebControls/VisualStyles" 
                                        AllowSorting="True" AllowColMoving="True" 
                                        VisualStyle="Office2007Blue" DefaultColumnWidth="" CellPadding="0" 
                                        CellSpacing="0" DataKeyNames="EC_Slno" 
                                        AutoGenerateSelectButton="True"             
                                        AccessKeyUseEmbeddedVisualStyles="True" 
                                        onrowcommand="grdEstimateCosting_RowCommand" 
                                        onpageindexchanging="grdEstimateCosting_PageIndexChanging" >                                        
                                        <Columns>
                                        <cc3:C1TemplateField HeaderText="Report">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lbkrpt" style="text-decoration:none" 
                                                CommandArgument='<%# Eval("nStyleId") %>' runat="server" onclick="lbkrpt_Click">Report</asp:LinkButton>
                                         </ItemTemplate>                                    
                                        </cc3:C1TemplateField>                 
                                            <cc3:C1BoundField DataField="cStyleNo" ShowFilter="false" HeaderText="Style No" SortExpression="cStyleNo">
                                            </cc3:C1BoundField>
                                            <cc3:C1BoundField DataField="Row_Material"  ShowFilter="false" HeaderText="Row_Material" 
                                                SortExpression="Row_Material">
                                            </cc3:C1BoundField>
                                            <cc3:C1BoundField DataField="Embroidary"  ShowFilter="false" HeaderText="Embroidary" 
                                                SortExpression="Embroidary">
                                            </cc3:C1BoundField>
                                                <cc3:C1BoundField DataField="Printing" ShowFilter="false" HeaderText="Printing" 
                                                SortExpression="Printing">
                                            </cc3:C1BoundField>
                                            <cc3:C1BoundField DataField="Washing" ShowFilter="false" HeaderText="Washing" 
                                                SortExpression="Washing">
                                            </cc3:C1BoundField>
                                             <cc3:C1BoundField DataField="Rate" ShowFilter="false" HeaderText="Rate" 
                                                SortExpression="Rate">
                                            </cc3:C1BoundField>
                                            <cc3:C1BoundField DataField="Print_Type" ShowFilter="false" HeaderText="Print_Type" 
                                                SortExpression="Print_Type">
                                            </cc3:C1BoundField>
                                            <cc3:C1TemplateField Visible="false">
                                            <ItemTemplate>
                                            <asp:Label ID="lblStyleid" runat="server" Text='<%# Eval("nStyleId") %>'></asp:Label>
                                            </ItemTemplate>
                                            </cc3:C1TemplateField>   
                                                                                                                               
                                           
                                        </Columns>                                        
                                        <PagerSettings PageButtonCount="18" />
                                               <HeaderStyle Wrap="False" />
                                               <RowStyle Wrap="False" Height="18px" />
                                           <PagerStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    </cc3:C1GridView>  
                     </div>
                  
                        </ContentTemplate>
                        </asp:UpdatePanel>     
               
                                  
                </cc2:C1TabPage>
              
               
              
            </TabPages>
                </cc2:C1TabControl>

                 </ContentTemplate>
    </asp:UpdatePanel>

    <script src="jquery/_EC.js" type="text/javascript"></script>
 <%--  <script type="text/javascript">
       function Mm(txtMFCostdz, txtTotCm,txtMFPc) {
           document.getElementById(txtMFCostdz).value = document.getElementById(txtTotCm).value
           var t = document.getElementById(txtMFCostdz).value;
           document.getElementById(txtMFPc).value = parseFloat(t) * 12;

       
       }
   </script>--%>
    
</asp:Content>

