<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Smt_Mer_OtherBooking.aspx.cs" Inherits="Smt_Mer_OtherBooking" %>

<%@ Register assembly="C1.Web.UI.Controls.4" namespace="C1.Web.UI.Controls.C1TabControl" tagprefix="cc2" %>
<%@ Register Assembly="C1.Web.UI.Controls.4" Namespace="C1.Web.UI.Controls.C1GridView"
    TagPrefix="cc3" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
     <cc2:C1TabControl ID="C1TabControl1" runat="server" width="100%"                    
                TextImageRelation="ImageBeforeText">
               <TabPages>
                <cc2:C1TabPage ID="C1TabPage1" TabIndex="0" Text="Other Booking" CssClass="tab">
                
               
                
        <div style="padding:7px;">
             <div>
        <table border="1" class="mGrid" style="width:100%;">
            <tr>
                <td class="label">
                    Order Type<asp:RequiredFieldValidator ID="RQORDERTP0" runat="server" 
                        ControlToValidate="drpOrderType" Display="None" 
                        ErrorMessage="Select Order Type" ValidationGroup="s">*</asp:RequiredFieldValidator>
                    <asp:ValidatorCalloutExtender ID="RQORDERTP0_ValidatorCalloutExtender" 
                        runat="server" Enabled="True" 
                        TargetControlID="RQORDERTP0">
                    </asp:ValidatorCalloutExtender>
                </td>
                <td>
                    <asp:DropDownList ID="drpOrderType" runat="server" CssClass="textboxforgridview" 
                                                   Width="140px">
                                                   <asp:ListItem>ADDITIONAL</asp:ListItem>
                                                   <asp:ListItem>COMPENSATION</asp:ListItem>
                                                   <asp:ListItem>NEGO</asp:ListItem>
                                                   <asp:ListItem>SAMPLE</asp:ListItem>
                                                   <asp:ListItem>STOCK</asp:ListItem>
                                               </asp:DropDownList>
                </td>
                <td class="label">
                    Delivery On or Before</td>
                <td>
                    <asp:TextBox ID="txtDeliverydt" runat="server" CssClass="textboxforgridview" 
                        Width="100px" Enabled="False"></asp:TextBox>
                    <asp:CalendarExtender ID="txtDeliverydt_CalendarExtender" runat="server" 
                        Enabled="True" Format="dd-MMM-yyyy" PopupButtonID="cal1" 
                        TargetControlID="txtDeliverydt">
                    </asp:CalendarExtender>
                    <asp:ImageButton ID="cal1" runat="server" Height="12px" 
                        ImageUrl="~/images/calendar.gif" />
                    <asp:RequiredFieldValidator ID="REDLDT" runat="server" 
                        ControlToValidate="txtDeliverydt" Display="None" 
                        ErrorMessage="Enter Delivery Date" ValidationGroup="s">*</asp:RequiredFieldValidator>
                    <asp:ValidatorCalloutExtender ID="REDLDT_ValidatorCalloutExtender" 
                        runat="server" Enabled="True"  
                        TargetControlID="REDLDT">
                    </asp:ValidatorCalloutExtender>
                </td>
                <td class="label">
                    Delivery To<asp:RequiredFieldValidator ID="rqdeliveryto" runat="server" 
                        ControlToValidate="drpDeliveryTo" Display="None" 
                        ErrorMessage="Select Delivery To" ValidationGroup="s">*</asp:RequiredFieldValidator>
                    <asp:ValidatorCalloutExtender ID="rqdeliveryto_ValidatorCalloutExtender" 
                        runat="server" Enabled="True" 
                        TargetControlID="rqdeliveryto">
                    </asp:ValidatorCalloutExtender>
                </td>
                <td>
                    <asp:DropDownList ID="drpDeliveryTo" runat="server" 
                        CssClass="textboxforgridview" Width="150px">
                    </asp:DropDownList>
                </td>
                <td class="label">
                    Currency<asp:RequiredFieldValidator ID="rqcrncy" runat="server" 
                        ControlToValidate="drpCurrencytype" Display="None" 
                        ErrorMessage="Select Currency" ValidationGroup="s">*</asp:RequiredFieldValidator>
                    <asp:ValidatorCalloutExtender ID="rqcrncy_ValidatorCalloutExtender" 
                        runat="server" Enabled="True"  
                        TargetControlID="rqcrncy">
                    </asp:ValidatorCalloutExtender>
                </td>
                <td>
                    <asp:DropDownList ID="drpCurrencytype" runat="server" 
                        CssClass="textboxforgridview" Width="100px">
                    </asp:DropDownList>
                </td>
                <td style="text-align: center">
                    PO No</td>
            </tr>
            <tr>
                <td class="label">
                    Supplier</td>
                <td>
                    <asp:DropDownList ID="drpSupplier" runat="server" 
                        CssClass="textboxforgridview" Width="140px" AutoPostBack="True" 
                        onselectedindexchanged="drpSupplier_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td class="label">
                    Attention</td>
                <td>
                    <asp:TextBox ID="txtAttention" runat="server" CssClass="textboxforgridview" 
                        Width="130px" Enabled="False"></asp:TextBox>
                </td>
                <td class="label">
                    PI Issue To<asp:RequiredFieldValidator ID="rqissueto" runat="server" 
                        ControlToValidate="drpPIIssue" Display="None" ErrorMessage="Select Issue To" 
                        ValidationGroup="s">*</asp:RequiredFieldValidator>
                    <asp:ValidatorCalloutExtender ID="rqissueto_ValidatorCalloutExtender" 
                        runat="server" Enabled="True"  
                        TargetControlID="rqissueto">
                    </asp:ValidatorCalloutExtender>
                </td>
                <td>
                    <asp:DropDownList ID="drpPIIssue" runat="server" 
                        CssClass="textboxforgridview" Width="150px">
                    </asp:DropDownList>
                </td>
                <td class="label">
                    Credit Days<asp:RequiredFieldValidator ID="rqcreditda" runat="server" 
                        ControlToValidate="txtCreditDays" Display="None" 
                        ErrorMessage="Enter Credit Days" ValidationGroup="s">*</asp:RequiredFieldValidator>
                    <asp:ValidatorCalloutExtender ID="rqcreditda_ValidatorCalloutExtender" 
                        runat="server" Enabled="True" 
                        TargetControlID="rqcreditda">
                    </asp:ValidatorCalloutExtender>
                </td>
                <td>
                    <asp:TextBox ID="txtCreditDays" runat="server" CssClass="textboxforgridview" 
                        Width="100px" MaxLength="5"></asp:TextBox>
                    <asp:FilteredTextBoxExtender ID="txtCreditDays_FilteredTextBoxExtender" 
                        runat="server" Enabled="True" TargetControlID="txtCreditDays" 
                        ValidChars="0123456789">
                    </asp:FilteredTextBoxExtender>
                </td>
                <td>
                    <asp:TextBox ID="txtPOno" runat="server" CssClass="textbox" Enabled="False" 
                        Width="120px"></asp:TextBox>
                </td>
            </tr>
        </table>
        </div>
             <div style="margin-top:10px">
        
            <table border="1" class="mGrid" style="width:100%;">
                <tr>
                    <td style="width:280px; vertical-align:top">
                        <table style="width:100%;">
                            <tr>
                                <td class="label" style="text-align: right">
                                    <asp:Label ID="lblrowindx" runat="server" Visible="False"></asp:Label>
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="RQSupplier" runat="server" 
                                        ControlToValidate="drpSupplier" Display="None" ErrorMessage="Select Supplier" 
                                        ValidationGroup="a">*</asp:RequiredFieldValidator>
                                    <asp:ValidatorCalloutExtender ID="RQSupplier_ValidatorCalloutExtender" 
                                        runat="server" Enabled="True" TargetControlID="RQSupplier">
                                    </asp:ValidatorCalloutExtender>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="label" style="text-align: right">
                                    Style No</td>
                                <td style="text-align: right">
                                    <asp:DropDownList ID="drpStyle" runat="server" 
                                        CssClass="textboxforgridview" Width="165px" AutoPostBack="True" 
                                        onselectedindexchanged="drpStyle_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="label" style="text-align: right">
                                    PO No</td>
                                <td style="text-align: right">
                                    <asp:DropDownList ID="drpPONo" runat="server" 
                                        CssClass="textboxforgridview" Width="165px">
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="label" style="text-align: right">
                                    <asp:RequiredFieldValidator ID="RQMAINCAT0" runat="server" 
                                        ControlToValidate="drpMainCat" Display="None" 
                                        ErrorMessage="Select Maincategory" ValidationGroup="a">*</asp:RequiredFieldValidator>
                                    <asp:ValidatorCalloutExtender ID="RQMAINCAT0_ValidatorCalloutExtender" 
                                        runat="server" Enabled="True" TargetControlID="RQMAINCAT0">
                                    </asp:ValidatorCalloutExtender>
                                    Main Category</td>
                                <td style="text-align: right">
                                    <asp:DropDownList ID="drpMainCat" runat="server" 
                                        CssClass="textboxforgridview" Width="165px" AutoPostBack="True" 
                                        onselectedindexchanged="drpMainCat_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    <asp:ImageButton ID="btnLoadMainCat" runat="server" Height="12px" 
                                        ImageUrl="~/gridimage/ref1.png" onclick="btnLoadMainCat_Click" 
                                        ToolTip="Refresh Main Category" />
                                </td>
                            </tr>
                            <tr>
                                <td class="label" style="text-align: right">
                                    <asp:RequiredFieldValidator ID="RQSUBCAT0" runat="server" 
                                        ControlToValidate="drpSubcategory" Display="None" 
                                        ErrorMessage="Select Sub Category" ValidationGroup="a">*</asp:RequiredFieldValidator>
                                    <asp:ValidatorCalloutExtender ID="RQSUBCAT0_ValidatorCalloutExtender" 
                                        runat="server" Enabled="True" TargetControlID="RQSUBCAT0">
                                    </asp:ValidatorCalloutExtender>
                                    Sub Category</td>
                                <td style="text-align: right">
                                    <asp:DropDownList ID="drpSubcategory" runat="server" 
                                        CssClass="textboxforgridview" Width="165px" AutoPostBack="True" 
                                        onselectedindexchanged="drpSubcategory_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    <asp:ImageButton ID="btnLoadItem" runat="server" Height="12px" 
                                        ImageUrl="~/gridimage/ref1.png" onclick="btnLoadItem_Click" 
                                        ToolTip="Refresh Sub Category" />
                                </td>
                            </tr>
                            <tr>
                                <td class="label" style="text-align: right">
                                    Construction<asp:RequiredFieldValidator ID="RQARTICLE0" runat="server" 
                                        ControlToValidate="drpArticle" Display="None" 
                                        ErrorMessage="Select Construction" ValidationGroup="a">*</asp:RequiredFieldValidator>
                                    <asp:ValidatorCalloutExtender ID="RQARTICLE0_ValidatorCalloutExtender" 
                                        runat="server" Enabled="True" TargetControlID="RQARTICLE0">
                                    </asp:ValidatorCalloutExtender>
                                </td>
                                <td style="text-align: right">
                                    <asp:DropDownList ID="drpArticle" runat="server" 
                                        CssClass="textboxforgridview" Width="165px">
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    <asp:ImageButton ID="btnLoadArticle" runat="server" Height="12px" 
                                        ImageUrl="~/gridimage/ref1.png" onclick="btnLoadArticle_Click" 
                                        ToolTip="Refresh Construction" />
                                </td>
                            </tr>
                            <tr>
                                <td class="label" style="text-align: right">
                                    <asp:RequiredFieldValidator ID="RQDIMENSION0" runat="server" 
                                        ControlToValidate="drpDimension" Display="None" ErrorMessage="Select Dimension" 
                                        ValidationGroup="a">*</asp:RequiredFieldValidator>
                                    <asp:ValidatorCalloutExtender ID="RQDIMENSION0_ValidatorCalloutExtender" 
                                        runat="server" Enabled="True" TargetControlID="RQDIMENSION0">
                                    </asp:ValidatorCalloutExtender>
                                    Dimension</td>
                                <td style="text-align: right">
                                    <asp:DropDownList ID="drpDimension" runat="server" 
                                        CssClass="textboxforgridview" Width="165px">
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    <asp:ImageButton ID="btnLoadDimension" runat="server" Height="12px" 
                                        ImageUrl="~/gridimage/ref1.png" onclick="btnLoadDimension_Click" 
                                        ToolTip="Refresh Dimension" />
                                </td>
                            </tr>
                            <tr>
                                <td class="label" style="text-align: right">
                                    Unit</td>
                                <td style="text-align: right">
                                    <asp:DropDownList ID="drpUnit" runat="server" 
                                        CssClass="textboxforgridview" Width="165px">
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="RQUNIT0" runat="server" 
                                        ControlToValidate="drpUnit" Display="None" ErrorMessage="Select Unit" 
                                        ValidationGroup="a">*</asp:RequiredFieldValidator>
                                    <asp:ValidatorCalloutExtender ID="RQUNIT0_ValidatorCalloutExtender" 
                                        runat="server" Enabled="True" TargetControlID="RQUNIT0">
                                    </asp:ValidatorCalloutExtender>
                                </td>
                            </tr>
                            <tr>
                                <td class="label" style="text-align: right">
                                    <asp:RequiredFieldValidator ID="RQCOLOR0" runat="server" 
                                        ControlToValidate="drpcolor" Display="None" ErrorMessage="Select Color" 
                                        ValidationGroup="a">*</asp:RequiredFieldValidator>
                                    <asp:ValidatorCalloutExtender ID="RQCOLOR0_ValidatorCalloutExtender" 
                                        runat="server" Enabled="True" TargetControlID="RQCOLOR0">
                                    </asp:ValidatorCalloutExtender>
                                    Color</td>
                                <td style="text-align: right">
                                    <asp:DropDownList ID="drpcolor" runat="server" 
                                        CssClass="textboxforgridview" Width="165px">
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    <asp:ImageButton ID="btnLoadColor" runat="server" Height="12px" 
                                        ImageUrl="~/gridimage/ref1.png" onclick="btnLoadColor_Click" 
                                        ToolTip="Refresh Color" />
                                </td>
                            </tr>
                            <tr>
                                <td class="label" style="text-align: right">
                                    Size</td>
                                <td style="text-align: right">
                                    <asp:DropDownList ID="drpSize" runat="server" 
                                        CssClass="textboxforgridview" Width="165px">
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="RQSIZE0" runat="server" 
                                        ControlToValidate="drpSize" Display="None" ErrorMessage="Select Size" 
                                        ValidationGroup="a">*</asp:RequiredFieldValidator>
                                    <asp:ValidatorCalloutExtender ID="RQSIZE0_ValidatorCalloutExtender" 
                                        runat="server" Enabled="True" TargetControlID="RQSIZE0">
                                    </asp:ValidatorCalloutExtender>
                                </td>
                            </tr>
                            <tr>
                                <td class="label" style="text-align: right">
                                    Quantity</td>
                                <td style="text-align: right">
                                    <asp:TextBox ID="txtQuantity" onkeyup="clcamnt();" runat="server" CssClass="textboxforgridview" 
                                        Width="162px" MaxLength="8"></asp:TextBox>
                                    <asp:FilteredTextBoxExtender ID="txtQuantity_FilteredTextBoxExtender" 
                                        runat="server" Enabled="True" TargetControlID="txtQuantity" 
                                        ValidChars=".0123456789">
                                    </asp:FilteredTextBoxExtender>
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="RQQTY" runat="server" 
                                        ControlToValidate="txtQuantity" Display="None" ErrorMessage="Enter Quantity" 
                                        ValidationGroup="a">*</asp:RequiredFieldValidator>
                                    <asp:ValidatorCalloutExtender ID="RQQTY_ValidatorCalloutExtender" 
                                        runat="server" Enabled="True" TargetControlID="RQQTY">
                                    </asp:ValidatorCalloutExtender>
                                </td>
                            </tr>
                            <tr>
                                <td class="label" style="text-align: right">
                                    Rate</td>
                                <td style="text-align: right">
                                    <asp:TextBox ID="txtRate" onkeyup="clcamnt();" runat="server" CssClass="textboxforgridview" 
                                        Width="162px" MaxLength="8"></asp:TextBox>
                                    <asp:FilteredTextBoxExtender ID="txtRate_FilteredTextBoxExtender" 
                                        runat="server" Enabled="True" TargetControlID="txtRate" 
                                        ValidChars=".0123456789">
                                    </asp:FilteredTextBoxExtender>
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="RQRATE" runat="server" 
                                        ControlToValidate="txtRate" Display="None" ErrorMessage="Select Rate" 
                                        ValidationGroup="a">*</asp:RequiredFieldValidator>
                                    <asp:ValidatorCalloutExtender ID="RQRATE_ValidatorCalloutExtender" 
                                        runat="server" Enabled="True" TargetControlID="RQRATE">
                                    </asp:ValidatorCalloutExtender>
                                </td>
                            </tr>
                            <tr>
                                <td class="label" style="text-align: right">
                                    Value</td>
                                <td style="text-align: right">
                                    <asp:TextBox ID="txtValue" runat="server" CssClass="textboxforgridview" 
                                        Width="162px" Enabled="False"></asp:TextBox>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="label" style="text-align: right" colspan="3">
                                    <hr />
                                </td>
                            </tr>
                            <tr>
                                <td class="label" style="text-align: right">
                                    &nbsp;</td>
                                <td>
                                    <asp:Button ID="btnAdd" runat="server" CssClass="button" Text="Add" 
                                        Width="150px" onclick="btnAdd_Click" ValidationGroup="a" />
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td style="text-align: right">
                                    &nbsp;</td>
                                <td rowspan="3" style="text-align: left">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td style="text-align: right">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td style="text-align: right">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </td>
                    <td style="vertical-align:top;">
                       <div style="height:430px; width:745px; overflow:auto;">
                           <asp:GridView ID="grdBookingDtl" runat="server" AutoGenerateColumns="false" 
                               CssClass="mGrid" onrowdatabound="grdBookingDtl_RowDataBound" Width="100%">
                               <AlternatingRowStyle BackColor="#EAFAFF" />
                               <Columns>
                                   <asp:TemplateField HeaderText="SL" Visible="false">
                                       <ItemTemplate>
                                           <asp:Label ID="lblSerial" runat="server"></asp:Label>
                                       </ItemTemplate>
                                   </asp:TemplateField>
                                   <asp:TemplateField HeaderText="Main Category">
                                       <ItemTemplate>
                                           <asp:Label ID="lblMainct" runat="server" Text='<%# Eval("cMainCategory") %>'></asp:Label>
                                       </ItemTemplate>
                                   </asp:TemplateField>
                                   <asp:TemplateField HeaderText="Item Description">
                                       <ItemTemplate>
                                           <asp:Label ID="lblitem" runat="server" Text='<%# Eval("cItemdes") %>'></asp:Label>
                                       </ItemTemplate>
                                   </asp:TemplateField>
                                   <asp:TemplateField HeaderText="Color">
                                       <ItemTemplate>
                                           <asp:Label ID="lblColor" runat="server" Text='<%# Eval("cColour") %>'></asp:Label>
                                       </ItemTemplate>
                                   </asp:TemplateField>
                                   <asp:TemplateField HeaderText="Size">
                                       <ItemTemplate>
                                           <asp:Label ID="lblSize" runat="server" Text='<%# Eval("cSize") %>'></asp:Label>
                                       </ItemTemplate>
                                   </asp:TemplateField>
                                   <asp:TemplateField HeaderText="Construction">
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
                                           <asp:Label ID="lblQty" runat="server" Text='<%# Eval("nQty") %>'></asp:Label>
                                       </ItemTemplate>
                                   </asp:TemplateField>
                                   <asp:TemplateField HeaderText="Rate">
                                       <ItemTemplate>
                                           <asp:Label ID="lblrate" runat="server" Text='<%# Eval("nPrice") %>'></asp:Label>
                                       </ItemTemplate>
                                   </asp:TemplateField>
                                   <asp:TemplateField HeaderText="Value">
                                       <ItemTemplate>
                                           <asp:Label ID="lblValue" runat="server" Text='<%# Eval("nVal") %>'></asp:Label>
                                       </ItemTemplate>
                                   </asp:TemplateField>
                                   <asp:TemplateField HeaderText="Style No">
                                       <ItemTemplate>
                                           <asp:Label ID="lblStyleNo" runat="server" Text='<%# Eval("cStyleNo") %>'></asp:Label>
                                       </ItemTemplate>
                                   </asp:TemplateField>
                                   <asp:TemplateField HeaderText="PO No">
                                       <ItemTemplate>
                                           <asp:Label ID="lblPOno" runat="server" Text='<%# Eval("cPo") %>'></asp:Label>
                                       </ItemTemplate>
                                   </asp:TemplateField>
                                   <asp:TemplateField>
                                   <ItemTemplate>
                                   <asp:ImageButton ID="btnEdit" runat="server" Height="13px" 
                                               ImageUrl="~/gridimage/edit.png"  
                                               ToolTip="Edit Item" Width="13px" onclick="btnEdit_Click" />
                                   </ItemTemplate>
                                   </asp:TemplateField>
                                   <asp:TemplateField HeaderText="">
                                       <ItemTemplate>
                                           <asp:Label ID="lblStyleID" runat="server" Text='<%# Eval("nstyCode") %>' 
                                               Visible="false"></asp:Label>
                                           <asp:Label ID="lblArticleID" runat="server" Text='<%# Eval("ArticleID") %>' 
                                               Visible="false"></asp:Label>
                                           <asp:Label ID="lblDimensionID" runat="server" Text='<%# Eval("DimensionID") %>' 
                                               Visible="false"></asp:Label>
                                           <asp:Label ID="lblmcatid" runat="server" Text='<%# Eval("MCatID") %>' 
                                               Visible="false"></asp:Label>
                                           <asp:Label ID="lblsubcatid" runat="server" Text='<%# Eval("SubcatID") %>' 
                                               Visible="false"></asp:Label>
                                           <asp:Label ID="lbllot" runat="server" Text='<%# Eval("clots") %>' 
                                               Visible="false"></asp:Label>
                                                <asp:Label ID="lblpodtlsl" runat="server" Text='<%# Eval("nDtlCode") %>' 
                                               Visible="false"></asp:Label>                                                                                           
                                                
                                           <asp:ImageButton ID="btnRemove" runat="server" OnClick="Rowremove" Height="13px" 
                                               ImageUrl="~/gridimage/grdRemove.png"  
                                               ToolTip="Remove item from list" Width="13px" />
                                           <asp:ConfirmButtonExtender ID="btnRemove_ConfirmButtonExtender" runat="server" 
                                               ConfirmText="Do you want to remove item from list?" Enabled="True" 
                                               TargetControlID="btnRemove">
                                           </asp:ConfirmButtonExtender>
                                       </ItemTemplate>
                                   </asp:TemplateField>
                               </Columns>
                               <HeaderStyle BackColor="#0097DF" Font-Size="12px" ForeColor="White" />
                               <RowStyle Font-Size="10px" />
                           </asp:GridView>
                       </div>
                       </td>
                </tr>
            </table>
        
        </div>
             <div style=" text-align:right">
        <table style="width: 100%;">
            <tr>
                <td style="text-align:left;">
                    <div>
                        <asp:Button ID="btnMaincat" runat="server" CssClass="btPOPUP" 
                            Text="Main Category" Width="80px" />
                        <asp:Button ID="btnItem" runat="server" CssClass="btPOPUP" Text="Sub Category" 
                            Width="80px" />
                        <asp:Button ID="btnArticle" runat="server" CssClass="btPOPUP" Text="Construction" 
                            Width="80px" />
                        <asp:Button ID="btnDimension" runat="server" CssClass="btPOPUP" 
                            Text="Dimension" Width="80px" />
                        <asp:Button ID="btncolor" runat="server" CssClass="btPOPUP" Text="Color" 
                            Width="80px" />
                    </div>
                </td>
                <td>
                  <div>
                   <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="#0066CC" 
            Text="Remarks"></asp:Label>
        <asp:TextBox ID="txtRemarks" runat="server" CssClass="textboxforgridview" 
            Height="22px" Width="200px"></asp:TextBox>
        <asp:TextBoxWatermarkExtender ID="txtRemarks_TextBoxWatermarkExtender" 
            runat="server" Enabled="True" TargetControlID="txtRemarks" 
            WatermarkText="Enter your remarks here">
        </asp:TextBoxWatermarkExtender>
        <asp:Button ID="btnClear" runat="server" CssClass="button" Text="Clear" 
            Width="80px" onclick="btnClear_Click" />
        <asp:Button ID="btnSave" runat="server" CssClass="button" Text="Save" 
            Width="80px" onclick="btnSave_Click" ValidationGroup="s" />
                      <asp:ConfirmButtonExtender ID="btnSave_ConfirmButtonExtender" runat="server" 
                          ConfirmText="Do you want to save?" Enabled="True" TargetControlID="btnSave">
                      </asp:ConfirmButtonExtender>
                  </div>
                </td>
                
            </tr>
            
        </table>
        </div>
        </div>
         </cc2:C1TabPage>
         <cc2:C1TabPage ID="C1TabPage2" TabIndex="0" Text="Edit/View" CssClass="tab">
                 <div style="height:540px; width:100%; overflow:auto">
                                       <cc3:C1GridView ID="grdView" runat="server" AllowPaging="True" 
                                        AutoGenerateColumns="False" PageSize="18" 
                                        ShowFilter="True" VisualStylePath="~/C1WebControls/VisualStyles" 
                                        AllowSorting="True" AllowColMoving="True" 
                                        VisualStyle="Office2007Blue" DefaultColumnWidth="" CellPadding="0" 
                                             CellSpacing="0" Width="100%" 
                                             onpageindexchanging="grdView_PageIndexChanging" onfiltering="grdView_Filtering" 
                                             >
                                        <Columns>
                                        <cc3:C1TemplateField HeaderText="Report">
                                       <ItemTemplate>
                                            <asp:LinkButton ID="btnPrintpoconfirm" onclick="btnPrintpoconfirm_Click" ToolTip="Generate Report" CssClass="link" runat="server">Report</asp:LinkButton>
                                       </ItemTemplate>
                                        </cc3:C1TemplateField>  
                                         <cc3:C1TemplateField HeaderText="Edit">
                                       <ItemTemplate>
                                            <asp:LinkButton ID="btnEdit" CommandArgument='<%# Eval("nPoNum") %>' OnClick="Editpo" ToolTip="Generate Report" CssClass="link" runat="server">Edit</asp:LinkButton>
                                       </ItemTemplate>
                                        </cc3:C1TemplateField>  
                                        <cc3:C1TemplateField>
                                        <ItemTemplate>
                                        <a class="link" href="javascript:vdtlreq1('<%# Eval("nPoNum") %>')">View</a>  
                                        </ItemTemplate>
                                        </cc3:C1TemplateField>    
                                                                         
                                        <cc3:C1TemplateField HeaderText="PO No">
                                        <ItemTemplate>
                                        <asp:Label ID="lblPONO" runat="server" Text='<%# Eval("nPoNum") %>'></asp:Label>
                                        </ItemTemplate>
                                        </cc3:C1TemplateField>                                           
                                            <cc3:C1BoundField DataField="cSeason_Name" HeaderText="Season" 
                                                SortExpression="Season">
                                            </cc3:C1BoundField>
                                        
                                                                                  
                                            <cc3:C1BoundField DataField="cSupName"  HeaderText="Supplier" 
                                                SortExpression="Supplier">
                                            </cc3:C1BoundField>
                                            <cc3:C1BoundField DataField="cAtt" ShowFilter="false" HeaderText="Attention" 
                                                SortExpression="Attention">
                                            </cc3:C1BoundField>
                                             <cc3:C1BoundField DataField="nAmot" ShowFilter="false" HeaderText="Amount" 
                                                SortExpression="Amount">
                                            </cc3:C1BoundField>
                                            <cc3:C1BoundField DataField="cCurType" ShowFilter="false" HeaderText="Currency" 
                                                SortExpression="Currency Type">
                                            </cc3:C1BoundField>
                                            <cc3:C1BoundField DataField="dDelevey" DataFormatString="{0:dd/MM/yyyy}" HtmlEncode="false" HeaderText="Delivery Date" 
                                                SortExpression="Delivery Date">
                                            </cc3:C1BoundField>
                                            <cc3:C1BoundField DataField="cCredtDay" ShowFilter="false" HeaderText="Credit Days" 
                                                SortExpression="Credit Days">
                                            </cc3:C1BoundField>
                                             <cc3:C1BoundField DataField="dEntdate" DataFormatString="{0:dd/MM/yyyy}" HtmlEncode="false" HeaderText="Created Date" 
                                                SortExpression="Created Date">
                                            </cc3:C1BoundField>
                                            
                                            <cc3:C1BoundField DataField="cUserFullname" HeaderText="User Name"
                                                SortExpression="Remarks">
                                            </cc3:C1BoundField>    
                                             <cc3:C1BoundField DataField="cRemark" ShowFilter="false" HeaderText="Remarks" 
                                                SortExpression="Remarks">
                                            </cc3:C1BoundField>                                           
                                        </Columns>
                                        <PagerSettings PageButtonCount="25" />
                                               <HeaderStyle Wrap="False" />
                                               <RowStyle Wrap="False" Height="18px" />
                                           <PagerStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    </cc3:C1GridView>  
                           </div>         
                </cc2:C1TabPage>
                  </TabPages>
                </cc2:C1TabControl>



                <asp:Button ID="btnshowpp" style="display:none" runat="server" Text="Button" />                                     
          <asp:ModalPopupExtender ID="btnshowpp_ModalPopupExtender" runat="server" 
           DynamicServicePath="" BackgroundCssClass="ModalPopupBG" BehaviorID="ppadditm" CancelControlID="cnclitmpdt" 
           OkControlID="cnclitmpdt" Enabled="True" PopupControlID="ppgenpo" 
           TargetControlID="btnshowpp">
                             </asp:ModalPopupExtender>

    </ContentTemplate>
    </asp:UpdatePanel>




     <div id="ppgenpo" style="height:530px; width:910px; display:none; border:5px solid #64AFEA;background-color:#e9f0fb;-webkit-border-radius: 5px; -moz-border-radius: 5px;border-radius: 5px;">
    <div class="pppnlhdr">
    <div id="hdrtxt" style="float:left; padding-left:20px; color:White">Generate PO</div>
    <div style="float:right; padding-top:2px; padding-right:2px"> 
        <input id="txtchkjv" style="display:none" type="text" />
        <img id="cnclitmpdt" onclick="refreshgpo();" style="cursor:pointer" alt="" src="gridimage/grdRemove.png" />
    </div>
    </div>
     <div id="divLoading" style="width:600px; text-align:center; vertical-align:bottom; margin-top:200px"> 
       <img src="images/loader.gif" alt="" /> 
     </div>
     <div id="divFrameHolder" style="display:none">
    <iframe id="ifupldfile" onload="hideLoading()" src="" style="border:none" width="900px" height="500px"></iframe>
    </div>
    </div>
    
    
     
    
 <div id="D1" class="POPUPPanel">
        <div id="POPUPHDR">
        <div class="POPUPHeaderText">Add New Buyer</div>
        <div class="POPUPClose"></div>      
        </div>
          <iframe id="POPUPIFrame" width="800px" height="550px" src=""></iframe>
        </div>   
 <script type="text/javascript">


     function hideLoading() {
         document.getElementById('divLoading').style.display = "none";
         document.getElementById('divFrameHolder').style.display = "block";
     }
     function onunload() {
         document.getElementById('divLoading').style.display = "block";
         document.getElementById('divFrameHolder').style.display = "none";
     }

     function vdtlreq1(tval) {
         onunload();
         document.getElementById("txtchkjv").value = "2";
         $("#hdrtxt").html("PO Details");
         $("#ifupldfile").attr("src", "Report_Merchandising/viewotherbooking.aspx?x=" + tval + "");
         var bid = $find('ppadditm');
         bid.show();
     }



     $(document).ready(function () {
         $(".btPOPUP").live("click", function () {
             $(".POPUPPanel").hide();
             var v = $(this).val();
             if (v == "Company") {
                 $(".POPUPHeaderText").html("Company information");
                 $("#POPUPIFrame").attr("src", "Master_Setup/frmCompany.aspx");
             }
             if (v == "Main Category") {
                 $(".POPUPHeaderText").html("Create Main Category");
                 $("#POPUPIFrame").attr("src", "Master_Setup/frmMainCategory.aspx");
             }
             if (v == "Item") {
                 $(".POPUPHeaderText").html("Item");
                 $("#POPUPIFrame").attr("src", "Master_Setup/frmSupCategory.aspx");
             }
             if (v == "Color") {
                 $(".POPUPHeaderText").html("Color");
                 $("#POPUPIFrame").attr("src", "Master_Setup/frmColor.aspx");
             }

             if (v == "Construction") {
                 $(".POPUPHeaderText").html("Construction");
                 $("#POPUPIFrame").attr("src", "Master_Setup/frmArticle.aspx");
             }
             if (v == "Dimension") {
                 $(".POPUPHeaderText").html("Dimension");
                 $("#POPUPIFrame").attr("src", "Master_Setup/frmDimension.aspx");
             }
             $(".POPUPPanel").toggle("slow");
             return false;
         });
         $(".POPUPClose").click(function () {
             $(".POPUPPanel").toggle("slow");
         });
     });

     function clcamnt() {
         $("[id$='txtValue']").val('');
         var gmtqty = $("[id$='txtQuantity']").val();
         var rat = $("[id$='txtRate']").val();       
         if (gmtqty.length > 0) {
             if (rat.length > 0) {
                 var val = parseFloat(gmtqty) * parseFloat(rat);
                 $("[id$='txtValue']").val(val.toFixed(2));
             }
         }     
     }

</script>


</asp:Content>


