<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Smt_Mer_BOM.aspx.cs" Inherits="Smt_Mer_BOM" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<style type="text/css">
.lnlmn
{
    display:block;
    padding-bottom:5px; 
    border-bottom:1px solid #58B6D8; 
    text-decoration:none; 
    width:100%;
    text-align: left; 
    font-family: Arial, Helvetica, sans-serif; 
    font-size: 12px; 
    color: black;
    
    }
    .lnlmn:hover
    {
        color:Red;
        border-bottom:1px solid red; 
       
        }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
    <div>
        <table style="width: 100%;">
            <tr>
                <td style="width:140px; vertical-align:top">
                   <div style="border-right:1px solid #58B6D8; height:550px">


                       <table style="width:100%;">
                           <tr>
                               <td>
                                   &nbsp;</td>
                           </tr>
                           <tr>
                               <td style="color: #0066CC; text-align: left;">
                                   Bill Of Material</td>
                           </tr>
                           <tr>
                               <td>
                                   &nbsp;</td>
                           </tr>
                           <tr>
                               <td class="label">
                                   &nbsp;</td>
                           </tr>
                           <tr>
                               <td>
                                   <a id="acolsen" runat="server" onclick="Colsen();" href="#" class="lnlmn">Color Sensitivity</a>                                   
                                  </td>
                           </tr>
                           <tr>
                               <td >
                                    <a id="asizesen" runat="server" onclick="SizeSen();" href="#" class="lnlmn">Size Sensitivity</a>
                                   </td>
                           </tr>
                           <tr>
                               <td >
                                   <a id="aposen" runat="server" onclick="addpo();" href="#" class="lnlmn">PO Sensitivity</a>
                                  </td>
                           </tr>

                            <tr>
                               <td >
                                    <a onclick="countrysen();" id="acontry" runat="server" href="#" class="lnlmn">Country Sensitivity</a>
                                   </td>
                           </tr>


                           <tr>
                               <td >
                                    <a id="asuppo" runat="server" onclick="stylestatus();" href="#" class="lnlmn">Style PO Status</a>
                                   </td>
                           </tr>
                           <tr>
                               <td >
                                    <a onclick="stylestatusrpt();" href="#" class="lnlmn"">Report</a>
                                   </td>
                           </tr>
                           <tr>
                               <td class="label">
                               <div style="height:120px">
                                   <asp:Label ID="Label1" runat="server" Font-Size="8px"></asp:Label>
                                   </div>
                               </td>
                           </tr>
                           
                          
                           
                         
                           
                          
                           
                           <tr>
                               <td>
                                   &nbsp;</td>
                           </tr>
                           <tr>
                               <td>
                                   <a id="adsubcat" runat="server" onclick="Subcat();" href="#" class="lnlmn">Add Subcategory</a>
                                   </td>
                           </tr>
                           <tr>
                               <td>
                                    <a id="adcons" runat="server" onclick="Construction();" href="#" class="lnlmn">Add Construction</a>
                                   </td>
                           </tr>
                           <tr>
                               <td>
                                   <a id="addimn" runat="server" onclick="Dimension();" href="#" class="lnlmn">Add Dimension</a>
                                  </td>
                           </tr>
                           <tr>
                               <td>
                                    <a id="addsuppl" runat="server" onclick="Supplier();" href="#" class="lnlmn">Add Supplier</a>
                                   </td>
                           </tr>
                       </table>
                    </div>
                </td>
                <td style="vertical-align:top;"">
                    <asp:Panel ID="Panel1" runat="server" style="border-bottom:1px solid #58B6D8; padding-bottom:5px">
                  
                    <table style="width:100%;">
                        <tr>
                            <td class="label" style="width: 80px;">
                                Style No</td>
                            <td>
                                <asp:DropDownList ID="drpstyle" runat="server" 
                                    CssClass="textboxforgridview" Width="180px" AutoPostBack="True" 
                                    onselectedindexchanged="drpstyle_SelectedIndexChanged">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                    ControlToValidate="drpstyle" Display="None" ErrorMessage="Select Style First." 
                                    ValidationGroup="D">*</asp:RequiredFieldValidator>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                    ControlToValidate="drpstyle" Display="None" ErrorMessage="Select Style First." 
                                    ValidationGroup="S">*</asp:RequiredFieldValidator>
                                <asp:ValidatorCalloutExtender ID="RequiredFieldValidator7_ValidatorCalloutExtender" 
                                    runat="server" Enabled="True" TargetControlID="RequiredFieldValidator7">
                                </asp:ValidatorCalloutExtender>
                                <asp:ValidatorCalloutExtender ID="RequiredFieldValidator6_ValidatorCalloutExtender" 
                                    runat="server" Enabled="True" TargetControlID="RequiredFieldValidator6">
                                </asp:ValidatorCalloutExtender>
                                <asp:Label ID="lblversion" runat="server" Visible="False"></asp:Label>
                                 <asp:Button ID="btnStyleref" style="width:50px; display:none" runat="server" onclick="btnStyleref_Click" 
                                    Text="Button" />
                            </td>
                            <td class="label">
                                Brand</td>
                            <td>
                                <asp:TextBox ID="txtBrand" runat="server" CssClass="textboxforgridview" 
                                    Width="160px" Enabled="False"></asp:TextBox>
                            </td>
                            <td class="label">
                                Gmt Type</td>
                            <td>
                                <asp:TextBox ID="txtGmttype" runat="server" CssClass="textboxforgridview" 
                                    Width="160px" Enabled="False"></asp:TextBox>
                            </td>
                            <td class="label">
                                Quantity</td>
                            <td style="text-align: right">
                                <asp:TextBox ID="txtordQty" runat="server" CssClass="textboxforgridview" 
                                    Width="67px" Enabled="False"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="label">
                                Buyer</td>
                            <td>
                                <asp:TextBox ID="txtBuyer" runat="server" CssClass="textboxforgridview" 
                                    Width="180px" Enabled="False"></asp:TextBox>
                                <asp:TextBox ID="txtLot" style="display:none" runat="server" Width="20px"></asp:TextBox>
                            </td>
                            <td class="label">
                                Season</td>
                            <td>
                                <asp:TextBox ID="txtSEason" runat="server" CssClass="textboxforgridview" 
                                    Width="160px" Enabled="False"></asp:TextBox>
                            </td>
                            <td class="label">
                                Gmt Dept</td>
                            <td>
                                <asp:TextBox ID="txtGmtdept" runat="server" CssClass="textboxforgridview" 
                                    Width="160px" Enabled="False"></asp:TextBox>
                            </td>
                            <td class="label">
                                Currency</td>
                            <td style="text-align: right">
                                <asp:DropDownList ID="drpCurrency" runat="server" CssClass="textboxforgridview" 
                                    Width="70px">
                                </asp:DropDownList>
                            </td>
                        </tr>
                    </table>
                    </asp:Panel>
                     <asp:Panel ID="dvNewitem" Enabled="false" runat="server" style="border-bottom:1px solid #58B6D8">
                        <table style="width:100%;">
                            <tr>
                                <td class="label" style="width: 80px;">
                                    Main Category</td>
                                <td style="width: 220px">
                                    <asp:DropDownList ID="drpMaincat" runat="server" CssClass="textboxforgridview" 
                                        Width="180px" AutoPostBack="True" 
                                        onselectedindexchanged="drpMaincat_SelectedIndexChanged">
                                    </asp:DropDownList>
                                    <asp:ImageButton ID="btnLoadmaincat" runat="server" Height="10px" 
                                        ImageUrl="~/images/LoadDta.png" ToolTip="Refresh Main Category" 
                                        onclick="btnLoadmaincat_Click" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                                        ControlToValidate="drpMaincat" Display="None" 
                                        ErrorMessage="Select Main Category" ValidationGroup="S">*</asp:RequiredFieldValidator>
                                    <asp:ValidatorCalloutExtender ID="RequiredFieldValidator8_ValidatorCalloutExtender" 
                                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator8">
                                    </asp:ValidatorCalloutExtender>
                                </td>
                                <td class="label" style="width: 60px;">
                                    Cons Unit</td>
                                <td style="width: 100px;">
                                    <asp:DropDownList ID="drpconsmunit" runat="server" 
                                        CssClass="textboxforgridview" onchange="bomreqment();" Width="70px">
                                        <asp:ListItem>PCS</asp:ListItem>
                                        <asp:ListItem>DOZ</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td class="label" style="width: 70px;">
                                    Req Qty</td>
                                <td style="width: 45px;">
                                    <asp:TextBox ID="txtRequirement" runat="server" CssClass="textboxforgridview" 
                                        Enabled="False" Width="60px"></asp:TextBox>
                                </td>
                                <td class="label" style="text-align: right; width: 55px;">
                                    Supplier</td>
                                <td style="text-align: right">
                                    <asp:DropDownList ID="drpSupplier" runat="server" CssClass="textboxforgridview" 
                                        Width="148px">
                                    </asp:DropDownList>
                                    <asp:ImageButton ID="btnLoadsupplier" runat="server" Height="10px" 
                                        ImageUrl="~/images/LoadDta.png" ToolTip="Refresh Supplier" 
                                        onclick="btnLoadsupplier_Click" />
                                </td>
                            </tr>
                            <tr>
                                <td class="label">
                                    Sub Category</td>
                                <td>
                                    <asp:DropDownList ID="drpSubcat" runat="server" CssClass="textboxforgridview" 
                                        Width="180px" AutoPostBack="True" 
                                        onselectedindexchanged="drpSubcat_SelectedIndexChanged">
                                    </asp:DropDownList>
                                    <asp:ImageButton ID="btnLoadsubcat" runat="server" Height="10px" 
                                        ImageUrl="~/images/LoadDta.png" ToolTip="Refresh subcategory" 
                                        onclick="btnLoadsubcat_Click" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                                        ControlToValidate="drpSubcat" Display="None" ErrorMessage="Select Subcategory" 
                                        ValidationGroup="S">*</asp:RequiredFieldValidator>
                                    <asp:ValidatorCalloutExtender ID="RequiredFieldValidator9_ValidatorCalloutExtender" 
                                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator9">
                                    </asp:ValidatorCalloutExtender>
                                </td>
                                <td class="label">
                                    Consumption</td>
                                <td>
                                    <asp:TextBox ID="txtConsumption" runat="server" CssClass="textboxforgridview" 
                                        onkeyup="bomreqment();" Width="66px"></asp:TextBox>
                                         <asp:FilteredTextBoxExtender ID="txtOrderqty_FilteredTextBoxExtender" 
                                                                      runat="server" Enabled="True" TargetControlID="txtConsumption" 
                                                                      ValidChars=".0123456789">
                                                                  </asp:FilteredTextBoxExtender>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" 
                                        ControlToValidate="txtConsumption" Display="None" 
                                        ErrorMessage="Enter Consumption" ValidationGroup="S">*</asp:RequiredFieldValidator>
                                    <asp:ValidatorCalloutExtender ID="RequiredFieldValidator13_ValidatorCalloutExtender" 
                                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator13">
                                    </asp:ValidatorCalloutExtender>
                                </td>
                                <td class="label">
                                    Color Sen</td>
                                <td>
                                    <asp:CheckBox ID="chkcolor" runat="server" AutoPostBack="True" CssClass="label" 
                                        oncheckedchanged="chkcolor_CheckedChanged" />
                                </td>
                                <td class="label" style="text-align: right">
                                    Placement</td>
                                <td style="text-align: right">
                                    <asp:TextBox ID="txtPlacement" runat="server" CssClass="textboxforgridview" 
                                        Width="160px" MaxLength="50"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="label">
                                    Construction</td>
                                <td>
                                    <asp:DropDownList ID="drpcosntruction" runat="server" CssClass="textboxforgridview" 
                                        Width="180px">
                                    </asp:DropDownList>
                                    <asp:ImageButton ID="btnLoadconstruction" runat="server" Height="10px" 
                                        ImageUrl="~/images/LoadDta.png" ToolTip="Refresh Construction" 
                                        onclick="btnLoadconstruction_Click" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                                        ControlToValidate="drpcosntruction" Display="None" 
                                        ErrorMessage="Select Construction" ValidationGroup="S">*</asp:RequiredFieldValidator>
                                    <asp:ValidatorCalloutExtender ID="RequiredFieldValidator10_ValidatorCalloutExtender" 
                                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator10">
                                    </asp:ValidatorCalloutExtender>
                                </td>
                                <td class="label">
                                    Wastage</td>
                                <td>
                                    <asp:TextBox ID="txtWstg" runat="server" CssClass="textboxforgridview" 
                                        onkeyup="bomreqment();" Width="66px"></asp:TextBox>
                                         <asp:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" 
                                                                      runat="server" Enabled="True" TargetControlID="txtWstg" 
                                                                      ValidChars=".0123456789">
                                                                  </asp:FilteredTextBoxExtender>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" 
                                        ControlToValidate="txtWstg" Display="None" ErrorMessage="Enter Wastages" 
                                        ValidationGroup="S">*</asp:RequiredFieldValidator>
                                    <asp:ValidatorCalloutExtender ID="RequiredFieldValidator14_ValidatorCalloutExtender" 
                                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator14">
                                    </asp:ValidatorCalloutExtender>
                                </td>
                                <td class="label">
                                    Size Sen</td>
                                <td>
                                    <asp:CheckBox ID="chksz" runat="server" AutoPostBack="True" CssClass="label" 
                                        oncheckedchanged="chksz_CheckedChanged" />
                                </td>
                                <td class="label" style="text-align: right">
                                    Remarks</td>
                                <td style="text-align: right">
                                    <asp:TextBox ID="txtRemarks" runat="server" CssClass="textboxforgridview" 
                                        Width="160px" MaxLength="100"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="label">
                                    Dimension</td>
                                <td>
                                    <asp:DropDownList ID="drpDimension" runat="server" CssClass="textboxforgridview" 
                                        Width="180px">
                                    </asp:DropDownList>
                                    <asp:ImageButton ID="btnLoadDimension" runat="server" Height="10px" 
                                        ImageUrl="~/images/LoadDta.png" ToolTip="Refresh Dimension" 
                                        onclick="btnLoadDimension_Click" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                                        ControlToValidate="drpDimension" Display="None" ErrorMessage="Select Dimension" 
                                        ValidationGroup="S">*</asp:RequiredFieldValidator>
                                    <asp:ValidatorCalloutExtender ID="RequiredFieldValidator11_ValidatorCalloutExtender" 
                                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator11">
                                    </asp:ValidatorCalloutExtender>
                                </td>
                                <td class="label">
                                    Rate</td>
                                <td>
                                    <asp:TextBox ID="txtRate" runat="server" CssClass="textboxforgridview" 
                                        onkeyup="bomreqment();" Width="66px"></asp:TextBox>
                                         <asp:FilteredTextBoxExtender ID="FilteredTextBoxExtender2" 
                                                                      runat="server" Enabled="True" TargetControlID="txtRate" 
                                                                      ValidChars=".0123456789">
                                                                  </asp:FilteredTextBoxExtender>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" 
                                        ControlToValidate="txtRate" Display="None" ErrorMessage="Enter Rate" 
                                        ValidationGroup="S">*</asp:RequiredFieldValidator>
                                    <asp:ValidatorCalloutExtender ID="RequiredFieldValidator15_ValidatorCalloutExtender" 
                                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator15">
                                    </asp:ValidatorCalloutExtender>
                                </td>
                                <td class="label">
                                    Country Sen</td>
                                <td style="text-align: left">
                                    <asp:CheckBox ID="chkcountry" runat="server" AutoPostBack="True" 
                                        CssClass="label" oncheckedchanged="chkcountry_CheckedChanged" />
                                </td>
                                <td style="text-align: left">
                                    &nbsp;</td>
                                <td style="text-align: right">
                                    <asp:Label ID="lblRowid" runat="server" Visible="False"></asp:Label>
                                    &nbsp;<asp:Button ID="btnitmclr" runat="server" Text="Clear" 
                                        Width="60px" Height="22px" onclick="btnitmclr_Click" />
                                    <asp:Button ID="btnSave" runat="server" onclick="btnSave_Click" Text="Save" 
                                        Width="60px" Height="22px" ValidationGroup="S" />
                                        <asp:ConfirmButtonExtender ID="btnSave_ConfirmButtonExtender" runat="server" 
                                                                             ConfirmText="Do you want to Save?" Enabled="True" 
                                                                             TargetControlID="btnSave">
                                                                         </asp:ConfirmButtonExtender>
                                    <asp:Button ID="btnEdit" runat="server" Text="Update" Visible="False" 
                                        Width="60px" onclick="btnEdit_Click" Height="22px" ValidationGroup="S" />
                                         <asp:ConfirmButtonExtender ID="btnEdit_ConfirmButtonExtender1" runat="server" 
                                                                             ConfirmText="Do you want to Update?" Enabled="True" 
                                                                             TargetControlID="btnEdit">
                                                                         </asp:ConfirmButtonExtender>
                                </td>
                            </tr>
                            <tr>
                                <td class="label">
                                    Order Unit</td>
                                <td>
                                    <asp:DropDownList ID="drpOrderunit" runat="server" AutoPostBack="True" 
                                        CssClass="textboxforgridview" 
                                        onselectedindexchanged="drpOrderunit_SelectedIndexChanged" Width="70px">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" 
                                        ControlToValidate="drpOrderunit" Display="None" 
                                        ErrorMessage="Select Order Unit" ValidationGroup="S">*</asp:RequiredFieldValidator>
                                    <asp:ValidatorCalloutExtender ID="RequiredFieldValidator12_ValidatorCalloutExtender" 
                                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator12">
                                    </asp:ValidatorCalloutExtender>
                                </td>
                                <td class="label">
                                    Value</td>
                                <td>
                                    <asp:TextBox ID="txtValue" runat="server" CssClass="textboxforgridview" 
                                        Enabled="False" Width="66px"></asp:TextBox>
                                </td>
                                <td class="label">
                                    <asp:Label ID="lblszsl" runat="server" Visible="False"></asp:Label>
                                </td>
                                <td style="text-align: left">
                                    <asp:TextBox ID="txtUnitparam" style="display:none" runat="server" Font-Size="10px" Width="20px"></asp:TextBox>
                                    <asp:Label ID="lblcolsensl" runat="server" Visible="False"></asp:Label>
                                </td>
                                <td style="text-align: left">
                                    <asp:Label ID="lblcountrysensl" runat="server" Visible="False"></asp:Label>
                                </td>
                                <td style="text-align: right">
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel>
                <div style="height:330px; overflow:auto">
                    <asp:GridView ID="grdBOMitm" runat="server" AutoGenerateColumns="false" 
                         CssClass="mGrid" onrowdatabound="grdBOMitm_RowDataBound" 
                        ForeColor="Black" onprerender="grdBOMitm_PreRender">
                        <Columns>                       
                            <asp:BoundField DataField="cMainCategory"  HeaderText="Main Category" />
                             <asp:BoundField DataField="cDes"  HeaderText="Sub Category" />
                            <asp:BoundField DataField="cArticle"  HeaderText="Article" />
                            <asp:BoundField DataField="cDimen"  HeaderText="Dimension" />
                            <asp:BoundField DataField="cUnitDes"  HeaderText="Ord. Unit" />
                            <asp:BoundField DataField="ctype"  HeaderText="Cons Unit" />
                           <asp:BoundField DataField="nCom" HeaderText="Cons." />
                            <asp:BoundField DataField="nWst" HeaderText="Wstg" />
                            <asp:BoundField DataField="nUprice" HeaderText="Rate" />
                            <asp:BoundField DataField="nValue"  HeaderText="Value" />
                            <asp:TemplateField HeaderText="Col. Sen">
                            <ItemTemplate>
                                <asp:CheckBox ID="chkcol" Enabled="false" Checked='<%# Eval("bColSen") %>' runat="server" />
                            </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Size Sen">
                            <ItemTemplate>
                                <asp:CheckBox ID="chksz" Enabled="false" Checked='<%# Eval("bszSen") %>' runat="server" />
                            </ItemTemplate>
                            </asp:TemplateField>   
                             <asp:TemplateField HeaderText="Country Sen">
                            <ItemTemplate>
                                <asp:CheckBox ID="chkcn" Enabled="false" Checked='<%# Eval("Countrysen") %>' runat="server" />
                            </ItemTemplate>
                            </asp:TemplateField>                       
                            <asp:BoundField DataField="cSupName"  HeaderText="Supplier" />
                            <asp:BoundField DataField="cPlsmnt"  HeaderText="Placement" />
                            <asp:TemplateField>
                            <ItemTemplate>
                                <asp:ImageButton ID="btnEdit" OnClick="btEditItem" CommandArgument='<%# Eval("nid") %>' Height="12px" ToolTip="Edit" runat="server" ImageUrl="~/gridimage/edit.png" />
                            </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Label ID="lblmaincat" Visible="false" runat="server" Text='<%# Eval("MainCatCode") %>'></asp:Label>
                                <asp:Label ID="lblsubcat" Visible="false" runat="server" Text='<%# Eval("SubCatID") %>'></asp:Label>
                                <asp:Label ID="lblconst" Visible="false" runat="server" Text='<%# Eval("ConstructionID") %>'></asp:Label>
                                <asp:Label ID="lbldimn" Visible="false" runat="server" Text='<%# Eval("DimensionID") %>'></asp:Label>
                                <asp:Label ID="lblplacement" Visible="false" runat="server" Text='<%# Eval("cPlsmnt") %>'></asp:Label>
                                <asp:ImageButton ID="btnDelete" OnClick="btDltItem" CommandArgument='<%# Eval("nid") %>' Height="12px" ToolTip="Delete" runat="server" ImageUrl="~/gridimage/grdRemove.png" />
                                 <asp:ConfirmButtonExtender ID="btnDelete_ConfirmButtonExtender" runat="server" 
                                                                             ConfirmText="Do you want to Delete?" Enabled="True" 
                                                                             TargetControlID="btnDelete">
                                                                         </asp:ConfirmButtonExtender>
                            </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <HeaderStyle BackColor="#007BB7" Font-Size="10px" ForeColor="White" 
                            Font-Names="Tahoma" />
                        <RowStyle Font-Size="10px" />
                    </asp:GridView>
                    <div id="dvposen" runat="server" visible="false" style="text-align:left; padding-left:100px; padding-top:100px; width:500px">
                    
                        <table style="width: 100%;">
                            <tr>
                                <td rowspan="5" style="width: 50px; vertical-align:top">
                                 <img alt="" src="gridimage/Info.png" />
                                </td>
                                <td>                                  
                                    <asp:Label ID="lblermsg" runat="server" Font-Bold="True" Font-Size="18px" 
                                        ForeColor="#DE40C3" Text=""></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>                               
                                    <hr class="hr" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                  <a href="#" onclick="addpo();" style="text-decoration:none; font-family:Tahoma; font-size:12px; color:Blue">
                                   Add PO Sensitivity</a>
                                  </td>
                            </tr>
                            <tr>
                                <td>
                                    <hr class="hr" />
                                </td>
                            </tr>                          
                        </table>            
                    </div>
                    </div>
                    <div style="text-align:right; border-top:1px solid #58B6D8;">
                    <table style="width:100%">
                    <tr>
                    <td style="text-align:left">
                        <input id="Button1" style="background-color:#E9A2E9; border:1px solid #D46EE4; color:Teal" type="button" value="PO Raised" disabled="disabled" />
                        </td>
                    <td></td>
                     <td style="text-align:right">
                     <asp:Button ID="btnClear" runat="server" Text="Clear" Width="100px" 
                            onclick="btnClear_Click" Font-Size="10px" />
                        <asp:Button ID="btnDatagenerate" runat="server" Text="Data Generate" 
                            onclick="btnDatagenerate_Click" Font-Size="10px" ValidationGroup="D" />
                     </td>
                    </tr>
                    </table>
                        
                    </div>
                   
                </td>
            </tr>
        </table>
        </div>

      <asp:Button ID="btnppgntpo" style="display:none" runat="server" Text="Button" />                                     
          <asp:ModalPopupExtender ID="Button2_ModalPopupExtender" runat="server" 
           DynamicServicePath="" BackgroundCssClass="ModalPopupBG" BehaviorID="ppadditm" CancelControlID="cnclitmpdt" 
           OkControlID="cnclitmpdt" Enabled="True" PopupControlID="ppgenpo" 
           TargetControlID="btnppgntpo">
      </asp:ModalPopupExtender>
      

    </ContentTemplate>
    </asp:UpdatePanel>


     <div id="ppgenpo" style="height:530px; width:850px; display:none; border:5px solid #64AFEA;background-color:#e9f0fb;-webkit-border-radius: 5px; -moz-border-radius: 5px;border-radius: 5px;">
    <div class="pppnlhdr">
    <div id="hdrtxt" style="float:left; padding-left:20px; color:White">Generate PO</div>
    <div style="float:right; padding-top:2px; padding-right:2px"> 
        <input id="txtchkjv" style="display:none"  type="text" />
        <input id="txtimgsrc1" style="display:none"  type="text" />
        <img id="cnclitmpdt" onclick="rfsh();" style="cursor:pointer" alt="" src="gridimage/grdRemove.png" />
    </div>
    </div>
     <div id="divLoading" style="width:600px; text-align:center; vertical-align:bottom; margin-top:200px"> 
       <img src="images/loader.gif" alt="" /> 
     </div>
     <div id="divFrameHolder" style="display:none">
    <iframe id="ifupldfile" onload="hideLoading()" src="" style="border:none" width="840px" height="500px"></iframe>
    </div>
    </div>
   

       <script type="text/javascript">
           $(document).ready(function () {
               var ht = $(window).height();
               var wt = $(window).width();
               if (parseFloat(wt) < 1050) {
                   $("#dvedt").toggle("medium");
               }
           });
           function rfsh() {
               var x = $("[id$='txtchkjv']").val();
               if (x.length > 0) {
                   if (x = "1") {
                       $("[id$='btnStyleref']").click();
                   }
               }
           }
           function itmedt() {
               $("#dvedt").toggle("slow");
           }
           function AddItem() {
               $("[id$='txtchkjv']").val('');
               var stl = $("[id*='drpstyle'] :selected").val();
               if (stl.length > 0) {
                   onunload();
                   $("#hdrtxt").html("Add New Item");
                   $("#ifupldfile").attr("src", "Merchandising/BOM/AddItem.aspx?x=" + stl + "");
                   var bid = $find('ppadditm');
                   bid.show();
               }
               else {
                   alert("Select Style First");
               }
           }
           function addpo() {
               $("[id$='txtchkjv']").val('');
               var stl = $("[id*='drpstyle'] :selected").val();
               if (stl.length > 0) {
                   onunload();
                   document.getElementById("txtchkjv").value = "1";
                   $("#hdrtxt").html("PO Sensitivity");
                   $("#ifupldfile").attr("src", "Merchandising/BOM/POSen.aspx?x=" + stl + "");
                   var bid = $find('ppadditm');
                   bid.show();
               }
               else {
                   alert("Select Style First");
               }
           }
           function countrysen() {
               $("[id$='txtchkjv']").val('');
               var stl = $("[id*='drpstyle'] :selected").val();
               if (stl.length > 0) {
                   onunload();
                   $("#hdrtxt").html("Country Sensitivity");
                   $("#ifupldfile").attr("src", "Merchandising/BOM/Countrysen.aspx?x=" + stl + "");
                   var bid = $find('ppadditm');
                   bid.show();
               }
               else {
                   alert("Select Style First");
               }
           }

           function datagenerate() {
               var stl = $("[id*='drpstyle'] :selected").val();
               $("#hdrtxt").html("Data Generate");
               $("#ifupldfile").attr("src", "Merchandising/BOM/Datagenerate.aspx?x=" + stl + "");
               var bid = $find('ppadditm');
               bid.show();

           }
           function Colsen() {
               $("[id$='txtchkjv']").val('');
               var stl = $("[id*='drpstyle'] :selected").val();
               if (stl.length > 0) {
                   onunload();

                   $("#hdrtxt").html("Color Sensintivity");
                   $("#ifupldfile").attr("src", "Merchandising/BOM/ColorSen.aspx?x=" + stl + "");
                   var bid = $find('ppadditm');
                   bid.show();
               }
               else {
                   alert("Select Style First");
               }
           }
           function SizeSen() {
               $("[id$='txtchkjv']").val('');
               var stl = $("[id*='drpstyle'] :selected").val();
               if (stl.length > 0) {
                   onunload();

                   $("#hdrtxt").html("Size Sensitivity");
                   $("#ifupldfile").attr("src", "Merchandising/BOM/Sizesen.aspx?x=" + stl + "");
                   var bid = $find('ppadditm');
                   bid.show();
               }
               else {
                   alert("Select Style First");
               }
           }
           function stylestatus() {
               $("[id$='txtchkjv']").val('');
               var stl = $("[id*='drpstyle'] :selected").val();
               if (stl.length > 0) {
                   onunload();
                   $("#hdrtxt").html("Style Status");
                   $("#ifupldfile").attr("src", "Merchandising/BOM/Stylestatus.aspx?x=" + stl + "");
                   var bid = $find('ppadditm');
                   bid.show();
               }
               else {
                   alert("Select Style First");
               }

           }
           function stylestatusrpt() {
               $("[id$='txtchkjv']").val('');
               var stl = $("[id*='drpstyle'] :selected").val();
               if (stl.length > 0) {
                   onunload();
                   $("#hdrtxt").html("Style Status Report");
                   $("#ifupldfile").attr("src", "Merchandising/BOM/Report.aspx?x=" + stl + "");
                   var bid = $find('ppadditm');
                   bid.show();
               }
               else {
                   alert("Select Style First");
               }
           }

           function maincat() {
               onunload();
               // document.getElementById("txtchkjv").value = "1";
               $("#hdrtxt").html("Add Main Category");
               $("#ifupldfile").attr("src", "Master_Setup/frmMainCategory.aspx");
               var bid = $find('ppadditm');
               bid.show();
           }
           function Subcat() {
               onunload();
               // document.getElementById("txtchkjv").value = "1";
               $("#hdrtxt").html("Add Sub Category");
               $("#ifupldfile").attr("src", "Master_Setup/frmSupCategory.aspx");
               var bid = $find('ppadditm');
               bid.show();
           }
           function Construction() {
               onunload();
               // document.getElementById("txtchkjv").value = "1";
               $("#hdrtxt").html("Add Construction");
               $("#ifupldfile").attr("src", "Master_Setup/frmArticle.aspx");
               var bid = $find('ppadditm');
               bid.show();
           }
           function Dimension() {
               onunload();
               // document.getElementById("txtchkjv").value = "1";
               $("#hdrtxt").html("Add Dimension");
               $("#ifupldfile").attr("src", "Master_Setup/frmDimension.aspx");
               var bid = $find('ppadditm');
               bid.show();
           }
           function Supplier() {
               onunload();
               // document.getElementById("txtchkjv").value = "1";
               $("#hdrtxt").html("Add Supplier");
               $("#ifupldfile").attr("src", "Master_Setup/frmSupplier.aspx");
               var bid = $find('ppadditm');
               bid.show();
           }

           function hideLoading() {
               document.getElementById('divLoading').style.display = "none";
               document.getElementById('divFrameHolder').style.display = "block";
           }
           function onunload() {
               document.getElementById('divLoading').style.display = "block";
               document.getElementById('divFrameHolder').style.display = "none";
           }

           function bomreqment() {
               var SelVal = $("[id*='drpconsmunit'] :selected").val();
               var param = "1";
               if (SelVal == "DOZ") {
                   param = "12";
               }
               var UnitParam = $("[id$='txtUnitparam']").val();
               var com = $("[id$='txtConsumption']").val();
               var ordqty = $("[id$='txtordQty']").val();
               var wast = $("[id$='txtWstg']").val();
               var comord = eval(com) * eval(ordqty);
               var Wastage;
               var withwast;
               var tl;
               var witt;
               if (parseFloat(wast) > 0) {
                   Wastage = eval(wast);
                   withwast = eval(comord) * eval(Wastage);
                   tl = eval(withwast) / eval(100);
                   witt = Math.round(eval(tl) + eval(comord), 4);
               }
               else {
                   withwast = eval(comord);
                   tl = eval(withwast);
                   witt = Math.round(eval(tl), 4);
               }
               var tt = eval(witt) / eval(UnitParam);
               var totalReq = parseFloat(tt) / parseFloat(eval(param));
               var roundtotal = totalReq.toFixed(2);
               if (!isNaN(totalReq)) {
                   $("[id$='txtRequirement']").val(roundtotal);
               }
               var rate = $("[id$='txtRate']").val();
               var _Uprice = 0;
               if (rate.length > 0) {
                   _Uprice = rate;
               }
               var req = $("[id$='txtRequirement']").val();
               var WithoutFixed = (eval(totalReq) * eval(_Uprice));
               var val = WithoutFixed.toFixed(2);
               if (!isNaN(val)) {
                   $("[id$='txtValue']").val(val);
               }
           }

           function CheckOtherIsCheckedByGVID(spanChk) {
               var IsChecked = spanChk.checked;
               var CurrentRdbID = spanChk.id;
               var Chk = spanChk;
               Parent = document.getElementById("<%=grdBOMitm.ClientID%>");
               var items = Parent.getElementsByTagName('input');
               for (i = 0; i < items.length; i++) {
                   if (items[i].id != CurrentRdbID && items[i].type == "radio") {
                       if (items[i].checked) {
                           items[i].checked = false;

                       }
                   }
               }
               var gt = document.getElementById('<%= grdBOMitm.ClientID %>');
               var tval = "";
               for (i = 1; i < gt.rows.length; i++) {
                   gt.rows[i].style.background = '';
                   gt.rows[i].style.color = 'black';
                   var l00pcell = gt.rows[i].cells;
                   var loopcellvalue = l00pcell[0].getElementsByTagName("input")[0];
                   var slnoval = l00pcell[0].getElementsByTagName("input")[1].value;
                   if (loopcellvalue.type == "radio" && loopcellvalue.checked) {
                       tval = l00pcell[1].innerText;
                       $("[id$='txtLot']").val(slnoval);
                       gt.rows[i].style.background = '#23A9BF';
                       gt.rows[i].style.color = 'white';
                   }
               }
           }        
    </script>

</asp:Content>


