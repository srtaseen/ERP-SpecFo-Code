<%@ Page Title="" Language="C#" MasterPageFile="~/Commercial/MasterPage.master" AutoEventWireup="true" CodeFile="Smt_Com_PerfomaInvoice.aspx.cs" Inherits="Commercial_Smt_Com_PerfomaInvoice" %>

<%@ Register Assembly="C1.Web.UI.Controls.4" Namespace="C1.Web.UI.Controls.C1GridView"
    TagPrefix="cc3" %>
<%@ Register assembly="C1.Web.UI.Controls.4" namespace="C1.Web.UI.Controls.C1ComboBox" tagprefix="cc1" %>
<%@ Register assembly="C1.Web.UI.Controls.4" namespace="C1.Web.UI.Controls.C1TabControl" tagprefix="cc2" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align="left" style="margin-top:5px">
        <asp:UpdatePanel ID="updMain" runat="server">
        <ContentTemplate>
          <cc2:C1TabControl ID="C1TabControl1" runat="server" width="100%"                    
                TextImageRelation="ImageBeforeText" onclienttabmouseenter="clr">
               <TabPages>
                <cc2:C1TabPage ID="C1TabPage1" TabIndex="0" Text="Create New Invoice" CssClass="tab">
                   <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <table style="width: 100%;">
                    <tr>
                        <td valign="top" style="width:350px">
                         <div class="pnlmain">
                         <div class="pnlheader"></div>
                             <table style="width: 100%;">
                                 <tr>
                                     <td align="right">
                                         <asp:Label ID="Label4" runat="server" CssClass="label" Text="P.I No"></asp:Label>
                                     </td>
                                     <td>
                                         <asp:TextBox ID="txtPIno" runat="server" AutoPostBack="True" CssClass="textbox" 
                                             MaxLength="25" ontextchanged="txtPIno_TextChanged" Width="230px" 
                                             TabIndex="1"></asp:TextBox>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                             ControlToValidate="txtPIno" Display="None" ErrorMessage="Enter P.I No" 
                                             ValidationGroup="a">*</asp:RequiredFieldValidator>
                                         <asp:ValidatorCalloutExtender ID="RequiredFieldValidator7_ValidatorCalloutExtender" 
                                             runat="server" Enabled="True" TargetControlID="RequiredFieldValidator7">
                                         </asp:ValidatorCalloutExtender>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td align="right">
                                         <asp:Label ID="Label1" runat="server" CssClass="label" Text="Supplier"></asp:Label>
                                     </td>
                                     <td>
                                         <asp:DropDownList ID="drpSupplier" runat="server" AutoPostBack="True" 
                                             CssClass="dropdownlist" 
                                             onselectedindexchanged="drpSupplier_SelectedIndexChanged" Width="230px" 
                                             TabIndex="2">
                                         </asp:DropDownList>
                                         &nbsp;
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                             ControlToValidate="drpSupplier" Display="None" ErrorMessage="Select Supplier" 
                                             ValidationGroup="a">*</asp:RequiredFieldValidator>
                                         <asp:ValidatorCalloutExtender ID="RequiredFieldValidator1_ValidatorCalloutExtender" 
                                             runat="server" Enabled="True" TargetControlID="RequiredFieldValidator1">
                                         </asp:ValidatorCalloutExtender>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td align="right">
                                         <asp:Label ID="Label13" runat="server" CssClass="label" Text="P.I Date"></asp:Label>
                                     </td>
                                     <td>
                                         <asp:TextBox ID="txtPIDate" runat="server" CssClass="textbox" Width="120px" 
                                             Enabled="False"></asp:TextBox>
                                         <asp:MaskedEditExtender ID="txtPIDate_MaskedEditExtender" runat="server" 
                                             CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                             CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                             CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                             Mask="99/99/9999" MaskType="Date" TargetControlID="txtPIDate">
                                         </asp:MaskedEditExtender>
                                         <asp:CalendarExtender ID="txtPIDate_CalendarExtender" runat="server" 
                                             Enabled="True" Format="dd/MM/yyyy" PopupButtonID="cal1" 
                                             TargetControlID="txtPIDate">
                                         </asp:CalendarExtender>
                                         <asp:ImageButton ID="cal1" runat="server" Height="13px" 
                                             ImageUrl="~/images/calendar.gif" onfocus="ShowCalendar2()" TabIndex="3" />
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                             ControlToValidate="txtPIDate" Display="None" ErrorMessage="Enter P.I Date" 
                                             ValidationGroup="a">*</asp:RequiredFieldValidator>
                                         <asp:ValidatorCalloutExtender ID="RequiredFieldValidator5_ValidatorCalloutExtender" 
                                             runat="server" Enabled="True" TargetControlID="RequiredFieldValidator5">
                                         </asp:ValidatorCalloutExtender>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td align="right">
                                         <asp:Label ID="Label14" runat="server" CssClass="label" Text="Shipment Date"></asp:Label>
                                     </td>
                                     <td>
                                         <asp:TextBox ID="txtShipmentDate" runat="server" CssClass="textbox" 
                                             Width="120px" Enabled="False"></asp:TextBox>
                                         <asp:MaskedEditExtender ID="txtShipmentDate_MaskedEditExtender" runat="server" 
                                             CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                             CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                             CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                             Mask="99/99/9999" MaskType="Date" TargetControlID="txtShipmentDate">
                                         </asp:MaskedEditExtender>
                                         <asp:CalendarExtender ID="txtShipmentDate_CalendarExtender" runat="server" 
                                             Enabled="True" Format="dd/MM/yyyy" PopupButtonID="cal2" 
                                             TargetControlID="txtShipmentDate">
                                         </asp:CalendarExtender>
                                         <asp:ImageButton ID="cal2" runat="server" Height="13px" 
                                             ImageUrl="~/images/calendar.gif" onfocus="ShowCalendar2()" TabIndex="4" />
                                     </td>
                                 </tr>
                                 <tr>
                                     <td align="right">
                                         <asp:Label ID="Label15" runat="server" CssClass="label" Text="Currency Type"></asp:Label>
                                     </td>
                                     <td>
                                         <asp:DropDownList ID="drpCurrencyType" runat="server" CssClass="dropdownlist" 
                                             Width="140px" TabIndex="5">
                                         </asp:DropDownList>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                             ControlToValidate="drpCurrencyType" Display="None" 
                                             ErrorMessage="Select Currency Type" ValidationGroup="a">*</asp:RequiredFieldValidator>
                                         <asp:ValidatorCalloutExtender ID="RequiredFieldValidator6_ValidatorCalloutExtender" 
                                             runat="server" Enabled="True" TargetControlID="RequiredFieldValidator6">
                                         </asp:ValidatorCalloutExtender>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td align="right">
                                         <asp:Label ID="Label16" runat="server" CssClass="label" Text="Total Value"></asp:Label>
                                     </td>
                                     <td>
                                         <asp:TextBox ID="txtTotalvalue" Enabled="false" runat="server" CssClass="textbox" 
                                             MaxLength="12" Width="120px" TabIndex="6"></asp:TextBox>
                                         <asp:FilteredTextBoxExtender ID="txtTotalvalue_FilteredTextBoxExtender" 
                                             runat="server" Enabled="True" TargetControlID="txtTotalvalue" 
                                             ValidChars=".0123456789">
                                         </asp:FilteredTextBoxExtender>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td align="right" colspan="2">
                                         <table style="width:100%;">
                                             <tr>
                                                 <td>
                                                   <div class="pnlmain">
                                                   <div class="pnlheader">Available PO</div>
                                                       <asp:Panel ID="pnlAvailablePO" Height="275px" ScrollBars="Auto" runat="server">                                                   
                                                   
                                                       <asp:GridView ID="grdAvailablePO" AutoGenerateColumns="false" Width="100%" 
                                                               runat="server" onrowdatabound="grdAvailablePO_RowDataBound" 
                                                               CssClass="mGrid">
                                                       <Columns>
                                                       <asp:TemplateField HeaderText="Select">
                                                       <ItemTemplate>
                                                       <asp:CheckBox ID="chkSelectAvailablePO" runat="server" AutoPostBack="true" 
                                                               oncheckedchanged="chkSelectAvailablePO_CheckedChanged" TabIndex="7" />
                                                       </ItemTemplate>
                                                       </asp:TemplateField>
                                                       <asp:TemplateField HeaderText="PO No">
                                                       <ItemTemplate>
                                                       <asp:Label ID="lblPOAvailable" runat="server" Text='<%# Eval("nPoNum") %>'></asp:Label>
                                                       </ItemTemplate>
                                                       </asp:TemplateField>
                                                       </Columns>
                                                           <HeaderStyle CssClass="gridheader" />
                                                       </asp:GridView>
                                                   </asp:Panel>
                                                   </div>
                                                   </td>
                                                  
                                                 <td>
                                                    <div class="pnlmain">
                                                   <div class="pnlheader">Selected PO</div>
                                                     <asp:Panel ID="pnlSelectedPO" Height="275px" ScrollBars="Auto" runat="server">
                                                       <asp:GridView ID="grdSelectedPO" Width="100%" AutoGenerateColumns="false" 
                                                             runat="server" onrowdatabound="grdSelectedPO_RowDataBound" 
                                                             CssClass="mGrid">
                                                       <Columns>
                                                       <asp:TemplateField HeaderText="PO No">
                                                       <ItemTemplate>
                                                       <asp:Label ID="lblSelectedPO" runat="server" Text='<%# Eval("nPoNum") %>'></asp:Label>
                                                       </ItemTemplate>
                                                       </asp:TemplateField>
                                                       <asp:TemplateField HeaderText="Remove">
                                                       <ItemTemplate>
                                                       <asp:ImageButton ID="btnRemoveSelected" runat="server" 
                                                               ImageUrl="~/gridimage/grdRemove.png" onclick="btnRemoveSelected_Click" 
                                                               ToolTip="Remove From List" />
                                                       </ItemTemplate>
                                                       </asp:TemplateField>
                                                       </Columns>
                                                           <HeaderStyle CssClass="gridheader" />
                                                       </asp:GridView>
                                                      </asp:Panel>
                                                   </div>
                                                   </td>
                                             </tr>
                                         </table>
                                     </td>
                                 </tr>
                             </table>
                         </div>
                        </td>
                        <td valign="top">
                          <div class="pnlmain" style="height:480px">
                         <div class="pnlheader">Selected PO Details                        
                         </div>
                         <div align="left" style="height:455px; overflow:auto">
                         
                             <asp:GridView ID="grdItemDetail" runat="server" Width="100%" 
                                 onprerender="grdItemDetail_PreRender" AutoGenerateColumns="false" 
                                 onrowdatabound="grdItemDetail_RowDataBound" ShowFooter="True" 
                                 CssClass="mGrid">
                                 <AlternatingRowStyle CssClass="gridrowAlternaterow" />
                                 <Columns>
                                 <asp:TemplateField HeaderText="PO No">
                                 <ItemTemplate>
                                <asp:Label ID="lblPONO" runat="server" Text='<%# Eval("nPoNum") %>'></asp:Label>
                               
                                 </ItemTemplate>
                                 </asp:TemplateField>
                                  <asp:TemplateField HeaderText="Item Name">
                                 <ItemTemplate>
                                <asp:Label ID="lblItemname" runat="server" Text='<%# Eval("cItemdes") %>'></asp:Label>
                                 </ItemTemplate>
                                 </asp:TemplateField>
                                  <asp:TemplateField HeaderText="Size">
                                 <ItemTemplate>
                                <asp:Label ID="lblSize" runat="server" Text='<%# Eval("cSize") %>'></asp:Label>
                                 </ItemTemplate>
                                 </asp:TemplateField>
                                  <asp:TemplateField HeaderText="Color">
                                 <ItemTemplate>
                                <asp:Label ID="lblColor" runat="server" Text='<%# Eval("cColour") %>'></asp:Label>
                                 </ItemTemplate>
                                 </asp:TemplateField>
                                  <asp:TemplateField HeaderText="Article">
                                 <ItemTemplate>
                                <asp:Label ID="lblArticle" runat="server" Text='<%# Eval("cArt") %>'></asp:Label>
                                 </ItemTemplate>
                                 </asp:TemplateField>
                                  <asp:TemplateField HeaderText="Dimension">
                                 <ItemTemplate>
                                <asp:Label ID="lblDimension" runat="server" Text='<%# Eval("cDimec") %>'></asp:Label>
                                 </ItemTemplate>
                                 </asp:TemplateField>
                                  <asp:TemplateField HeaderText="Unit">
                                 <ItemTemplate>
                                <asp:Label ID="lblUnit" runat="server" Text='<%# Eval("cUnit") %>'></asp:Label>
                                 </ItemTemplate>
                                 </asp:TemplateField>
                                  <asp:TemplateField HeaderText="Quantity">
                                 <ItemTemplate>
                                <asp:Label ID="lblQuantity" runat="server" Text='<%# Eval("nQty") %>'></asp:Label>
                                 </ItemTemplate>
                                 </asp:TemplateField>
                                  <asp:TemplateField HeaderText="Price">
                                 <ItemTemplate>
                                <asp:Label ID="lblPrice" runat="server" Text='<%# Eval("nPrice") %>'></asp:Label>
                                 </ItemTemplate>
                                 </asp:TemplateField>
                                  <asp:TemplateField HeaderText="Value">
                                 <ItemTemplate>
                                <asp:Label ID="lblValue" runat="server" Text='<%# Eval("nVal") %>'></asp:Label>
                                 </ItemTemplate>
                                 </asp:TemplateField>                               
                                   <asp:TemplateField Visible="false">
                                   <ItemTemplate>
                                   <asp:Label ID="lblItemID" runat="server" Text='<%# Eval("cItemCode") %>'></asp:Label>
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
                            &nbsp;
                        </td>
                        <td align="right">
                            &nbsp;
                            <asp:Button ID="btnClear" runat="server" Text="Clear" Width="100px" 
                                onclick="btnClear_Click" CssClass="button" />
                            <asp:Button ID="btnSave" runat="server" onclick="btnSave_Click" TabIndex="8" 
                                Text="Save" ValidationGroup="a" Width="100px" CssClass="button" />
                            <asp:ConfirmButtonExtender ID="btnSave_ConfirmButtonExtender" runat="server" 
                                ConfirmText="Do you want to save this data?" Enabled="True" 
                                TargetControlID="btnSave">
                            </asp:ConfirmButtonExtender>
                        </td>
                    </tr>
                </table>
            </ContentTemplate>
            </asp:UpdatePanel>
                  
                </cc2:C1TabPage>
                <cc2:C1TabPage ID="C1TabPage2"  TabIndex="1" Text="Edit/View"  CssClass="tab">
                <div class="pnlmain" style="height:520px; margin:5px">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                     <cc3:C1GridView ID="grdEditview" runat="server" AllowPaging="True"  Width="100%"
                                        AutoGenerateColumns="False" PageSize="22" 
                                        ShowFilter="True" VisualStylePath="~/C1WebControls/VisualStyles" 
                                        AllowSorting="True" AllowColMoving="True" 
                                        VisualStyle="Office2007Blue" DefaultColumnWidth="" CellPadding="0" 
                                        CellSpacing="0" DataKeyNames="PI_ID" 
                                        AutoGenerateSelectButton="True" OnRowDataBound="grdEditview_RowDataBound" 
                                        OnRowCommand="grdEditview_RowCommand" 
                            onfiltering="grdEditview_Filtering" onpageindexchanging="grdEditview_PageIndexChanging" 
                                        >
                                        
                                        <Columns>                                          
                                          
                                            <cc3:C1BoundField DataField="PI_No" HeaderText="P.I No" SortExpression="PI_No">
                                            </cc3:C1BoundField>
                                            <cc3:C1BoundField DataField="PI_date" DataFormatString="{0:dd/MM/yyyy}" ShowFilter="false" HeaderText="P.I Date" 
                                                SortExpression="PI_date">
                                            </cc3:C1BoundField>
                                            <cc3:C1BoundField DataField="Shipment_Date" DataFormatString="{0:dd/MM/yyyy}" ShowFilter="false" HeaderText="Shipment Date" 
                                                SortExpression="Shipment_Date">
                                            </cc3:C1BoundField>
                                                <cc3:C1BoundField DataField="cSupName" HeaderText="Supplier Name" 
                                                SortExpression="cSupName">
                                            </cc3:C1BoundField>
                                            <cc3:C1BoundField DataField="Currency" ShowFilter="false" HeaderText="Currency" 
                                                SortExpression="Currency">
                                            </cc3:C1BoundField>
                                             <cc3:C1BoundField DataField="TotalVaue" ShowFilter="false" HeaderText="Total Value" ReadOnly="True" 
                                                SortExpression="TotalVaue">
                                            </cc3:C1BoundField>
                                            <cc3:C1BoundField DataField="Create_Date" DataFormatString="{0:dd/MM/yyyy}" ShowFilter="false" HeaderText="Created Date" 
                                                SortExpression="Create_Date">
                                            </cc3:C1BoundField>
                                            <cc3:C1BoundField DataField="Create_User" HeaderText="Created By" 
                                                SortExpression="Create_User">
                                            </cc3:C1BoundField>
                                            <cc3:C1CheckBoxField DataField="BBLC_Status" ShowFilter="false" HeaderText="BBLC Status" 
                                                SortExpression="BBLC_Status">
                                            </cc3:C1CheckBoxField>
                                        
                                           
                                        </Columns>
                                        
                                        <PagerSettings PageButtonCount="25" />
                                               <HeaderStyle Wrap="False" />
                                               <RowStyle Wrap="False" Height="18px" />
                                           <PagerStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    </cc3:C1GridView>  
                                      
                   
                     <%--   <asp:SqlDataSource ID="DSPIMSTR" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:mconinventory %>" 
                            SelectCommand="Sp_Smt_PIMaster_GetAll" SelectCommandType="StoredProcedure">
                        </asp:SqlDataSource>--%>
                                      
                   
                    </ContentTemplate>
                    </asp:UpdatePanel>
                                      
                </div>                          
                </cc2:C1TabPage>      
            </TabPages>
                </cc2:C1TabControl>   
        </ContentTemplate>
        </asp:UpdatePanel>
 


    
    </div>
    <script src="../jquery/scrollsaver.min.js" type="text/javascript"></script>
</asp:Content>

