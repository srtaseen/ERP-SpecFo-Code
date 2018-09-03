<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory/MasterPage.master" AutoEventWireup="true" CodeFile="Smt_Inv_Factoryreturn.aspx.cs" Inherits="Inventory_Smt_Inv_Factoryreturn" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<%@ Register assembly="C1.Web.UI.Controls.4" namespace="C1.Web.UI.Controls.C1TabControl" tagprefix="cc2" %>
<%@ Register Assembly="C1.Web.UI.Controls.4" Namespace="C1.Web.UI.Controls.C1GridView" TagPrefix="cc3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="../jquery/Inventory.js" type="text/javascript"></script>
<script type="text/javascript">
    function vdtlreq() {
        onunload();
        var compid = $("[id*='drpCompany'] :selected").val();
        var maincat = $("[id*='drpMaincat'] :selected").val();
        var Subcatid = $("[id*='drpSubcat'] :selected").val();
        var param = compid + "/" + maincat + "/" + Subcatid;
        document.getElementById("txtchkjv").value = "0";
        $("#hdrtxt").html("Items Stock Details");
        $("#ifupldfile").attr("src", "ReturnItem.aspx?x=" + param + "");
        var bid = $find('ppadditm');
        bid.show();        
    }
    function vw(tval) {
        onunload();
        document.getElementById("txtchkjv").value = "0";
        $("#hdrtxt").html("Factory Return Details");
        $("#ifupldfile").attr("src", "Smt_Inv_Factoryreturnviewdtl.aspx?x=" + tval + "");
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

</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>

     <cc2:C1TabControl ID="C1Tabcontrol1" OnClientTabUnSelect="clearlabel" 
            runat="server" width="100%"                    
                TextImageRelation="ImageBeforeText" UseEmbeddedVisualStyles="True" 
            VisualStyle="ArcticFox" Animation="Fade">
               <TabPages>
                <cc2:C1TabPage ID="C1Tabpage1" TabIndex="0" Text="Return Note" CssClass="tab">
                    <div class="pnlmain" id="dvtp" runat="server"  style="background-color:#F0F8FD; margin:3px">   
    <div style="padding:7px">
      <table style="width: 100%;">
            <tr>
                <td style="text-align: center" class="label">
                    &nbsp; Company<asp:TextBox ID="txtIssueparam" style="display:none" runat="server" Width="30px"  ></asp:TextBox>

                    <asp:TextBox ID="txtunitid" runat="server" style="display:none" Width="30px" ></asp:TextBox>
                </td>
                <td style="text-align: center" class="label">
                    Department<asp:TextBox ID="txtCalcqty" style="display:none" runat="server" Width="70px" ></asp:TextBox>
                </td>
                <td style="text-align: center" class="label">
                    Section<asp:TextBox ID="txtunitparam" style="display:none" runat="server" Width="50px" ></asp:TextBox>
                </td>
                <td style="text-align: center" class="label">
                    &nbsp;Style<asp:TextBox ID="txtItemid" style="display:none" runat="server" Width="50px" ></asp:TextBox>
                </td>
                <td style="text-align: center" class="label">
                    Return Note No</td>
                <td rowspan="2" style="text-align: center; vertical-align:top">
                   
                </td>
            </tr>
            <tr>
                <td style="text-align: center">
                    &nbsp;
                    <asp:DropDownList ID="drpCompany" runat="server" CssClass="textbox" 
                        Width="200px" AutoPostBack="True" 
                        onselectedindexchanged="drpCompany_SelectedIndexChanged">
                    </asp:DropDownList>
                     <asp:RequiredFieldValidator ID="drpCompany_RequiredFieldValidator5" runat="server" 
                                             ControlToValidate="drpCompany" Display="None" ErrorMessage="Select Company." 
                                             ValidationGroup="a">*</asp:RequiredFieldValidator>
                                         <asp:ValidatorCalloutExtender ID="RequiredFieldValidator5_ValidatorCalloutExtender" 
                                             runat="server" Enabled="True" TargetControlID="drpCompany_RequiredFieldValidator5">
                                         </asp:ValidatorCalloutExtender>
                </td>
                <td style="text-align: center">
                    &nbsp;
                    <asp:DropDownList ID="drpdept" runat="server" CssClass="textbox" 
                        Width="200px" AutoPostBack="True" 
                        onselectedindexchanged="drpdept_SelectedIndexChanged">
                    </asp:DropDownList>
                     <asp:RequiredFieldValidator ID="drpdept_RequiredFieldValidator1" runat="server" 
                                             ControlToValidate="drpdept" Display="None" ErrorMessage="Select Department" 
                                             ValidationGroup="a">*</asp:RequiredFieldValidator>
                                         <asp:ValidatorCalloutExtender ID="drpdept_ValidatorCalloutExtender1" 
                                             runat="server" Enabled="True" TargetControlID="drpdept_RequiredFieldValidator1">
                                         </asp:ValidatorCalloutExtender>
                </td>
                <td style="text-align: center">
                    <asp:DropDownList ID="drpSection" runat="server" CssClass="textbox" 
                        Width="200px">
                    </asp:DropDownList>
                     <asp:RequiredFieldValidator ID="drpSection_RequiredFieldValidator1" runat="server" 
                                             ControlToValidate="drpSection" Display="None" ErrorMessage="Select Section" 
                                             ValidationGroup="a">*</asp:RequiredFieldValidator>
                                         <asp:ValidatorCalloutExtender ID="ValidatorCalloutExtender1" 
                                             runat="server" Enabled="True" TargetControlID="drpSection_RequiredFieldValidator1">
                                         </asp:ValidatorCalloutExtender>
                </td>
                <td style="text-align: center">
                    <asp:DropDownList ID="drpStyle" runat="server" CssClass="textbox" 
                        Width="150px">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:TextBox ID="txtReturnNo" runat="server" CssClass="textbox" Width="80px"></asp:TextBox>
                </td>
            </tr>
        </table>
    </div>
    
    </div>
     <div class="pnlmain" style="background-color:#F0F8FD; margin:3px" >
   
    <div style="padding:7px">
      <table style="width: 100%;">
            <tr>
                <td style="text-align: right; font-size: 10px; font-family: Tahoma">
                    Main Category</td>
                <td>
                    &nbsp;
                    <asp:DropDownList ID="drpMaincat" runat="server" CssClass="textbox" 
                        Width="177px" AutoPostBack="True" 
                        onselectedindexchanged="drpMaincat_SelectedIndexChanged">
                    </asp:DropDownList>
                      <asp:RequiredFieldValidator ID="drpMaincat_RequiredFieldValidator1" runat="server" 
                                             ControlToValidate="drpMaincat" Display="None" ErrorMessage="Select Main Category" 
                                             ValidationGroup="a">*</asp:RequiredFieldValidator>
                                         <asp:ValidatorCalloutExtender ID="drpMaincat_ValidatorCalloutExtender2" 
                                             runat="server" Enabled="True" TargetControlID="drpMaincat_RequiredFieldValidator1" >
                                         </asp:ValidatorCalloutExtender>
                </td>
                <td style="text-align: right; font-size: 10px; font-family: Tahoma">
                    &nbsp;Size
                </td>
                <td>
                    <asp:TextBox ID="txtSize" runat="server" CssClass="textbox" Width="110px" 
                        Enabled="False"></asp:TextBox>
                </td>
                <td style="text-align: right; font-size: 10px; font-family: Tahoma">
                    Article</td>
                <td>
                    <asp:TextBox ID="txtArticle" runat="server" CssClass="textbox" Width="135px" 
                        Enabled="False"></asp:TextBox>
                </td>
                <td style="text-align: right; font-size: 10px; font-family: Tahoma">
                    Item Unit</td>
                <td>
                    <asp:TextBox ID="txtItemunit" runat="server" CssClass="textbox" Width="70px" 
                        Enabled="False"></asp:TextBox>
                </td>
                <td style="text-align: right; font-size: 10px; font-family: Tahoma">
                    Qty</td>
                <td>
                    <asp:TextBox ID="txtQty" runat="server" CssClass="textbox" Width="50px"></asp:TextBox>
                    <asp:FilteredTextBoxExtender ID="txtQty_FilteredTextBoxExtender" runat="server" 
                                      Enabled="True" TargetControlID="txtQty" ValidChars=".0123456789">
                                  </asp:FilteredTextBoxExtender>
                     <asp:RequiredFieldValidator ID="txtQty_RequiredFieldValidator1" runat="server" 
                                             ControlToValidate="txtQty" Display="None" ErrorMessage="Enter Quantity" 
                                             ValidationGroup="a">*</asp:RequiredFieldValidator>
                                         <asp:ValidatorCalloutExtender ID="txtQty_ValidatorCalloutExtender2" 
                                             runat="server" Enabled="True" TargetControlID="txtQty_RequiredFieldValidator1">
                                         </asp:ValidatorCalloutExtender>
                </td>
                <td style="text-align: right; font-size: 10px; font-family: Tahoma">
                   </td>
                <td>
                    
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: right; font-size: 10px; font-family: Tahoma">
                    Sub Category</td>
                <td>
                    &nbsp;
                    <asp:DropDownList ID="drpSubcat" AutoPostBack="true" OnSelectedIndexChanged="drpSubcat_SelectedIndexChanged" runat="server" CssClass="textbox" 
                        Width="155px">
                    </asp:DropDownList>
                     <asp:RequiredFieldValidator ID="drpSubcat_RequiredFieldValidator1" runat="server" 
                                             ControlToValidate="drpSubcat" Display="None" ErrorMessage="Select Sub Category" 
                                             ValidationGroup="a">*</asp:RequiredFieldValidator>
                                         <asp:ValidatorCalloutExtender ID="drpSubcat_ValidatorCalloutExtender2" 
                                             runat="server" Enabled="True" TargetControlID="drpSubcat_RequiredFieldValidator1">
                                         </asp:ValidatorCalloutExtender>
                    <input id="btnstockdtl" runat="server" type="button" onclick="vdtlreq();" title="Find Item Stock Details" value="." style="background-position: center center; font-size: 10px; background-image: url('../gridimage/src.png'); border:none; cursor:pointer"  />
                </td>
                <td style="text-align: right; font-size: 10px; font-family: Tahoma">
                    &nbsp; Color</td>
                <td>
                    <asp:TextBox ID="TxtColor" runat="server" CssClass="textbox" Width="110px" 
                        Enabled="False"></asp:TextBox>
                </td>
                <td style="text-align: right; font-size: 10px; font-family: Tahoma">
                    Dimension</td>
                <td>
                    <asp:TextBox ID="txtDimension" runat="server" CssClass="textbox" Width="135px" 
                        Enabled="False"></asp:TextBox>
                </td>
                <td style="text-align: right; font-size: 10px; font-family: Tahoma">
                    Issue Unit</td>
                <td>
                    <asp:DropDownList ID="drpIssueunit" runat="server" CssClass="textbox" 
                        Width="70px"  
                       >
                    </asp:DropDownList>
                </td>
                <td style="text-align: right; font-size: 10px; font-family: Tahoma">
                    Stock</td>
                <td>
                    <asp:TextBox ID="txtStock" runat="server"  CssClass="textbox" 
                        style="border:1px solid red" Width="50px" Enabled="False"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="txtStock_RequiredFieldValidator1" runat="server" 
                                             ControlToValidate="txtStock" Display="None" ErrorMessage="Enter Quantity" 
                                             ValidationGroup="a">*</asp:RequiredFieldValidator>
                                         <asp:ValidatorCalloutExtender ID="ValidatorCalloutExtender2" 
                                             runat="server" Enabled="True" TargetControlID="txtStock_RequiredFieldValidator1">
                                         </asp:ValidatorCalloutExtender>
                </td>
                <td style="text-align: right; font-size: 10px; font-family: Tahoma">
                   </td>
                <td style="text-align:center">
                   
                </td>
                <td style="text-align:center">
                    <asp:Button ID="btnAddItem" ValidationGroup="a" runat="server" Font-Size="10px" Text="Add" 
                        onclick="btnAddItem_Click" />
                </td>
            </tr>
        </table>
    </div>
    
    </div>
    <div class="pnlmain" style="height:350px; margin:3px">
    <div class="pnlheader"></div>
    <div style="height:330px; overflow:auto">
        <asp:GridView ID="grdIssuedetails" AutoGenerateColumns="false" runat="server" CssClass="mGrid">
            <AlternatingRowStyle CssClass="gridrowAlternaterow" />
            <HeaderStyle CssClass="gridheader" />
            <RowStyle CssClass="gridrow" />
            <Columns>
            <asp:TemplateField HeaderText="Maincategory">
            <ItemTemplate>
            <asp:Label ID="lblstyleID" Visible="false"  runat="server" Text='<%# Eval("stlID") %>'></asp:Label>
                <asp:Label ID="lblMaincatid" Visible="false"  runat="server" Text='<%# Eval("Maincatcode") %>'></asp:Label>
                <asp:Label ID="lblSubcatid" Visible="false"  runat="server" Text='<%# Eval("Subcatcode") %>'></asp:Label>
                <asp:Label ID="lblItemid" Visible="false"  runat="server" Text='<%# Eval("ItemCode") %>'></asp:Label>
                <asp:Label ID="lblMaincat" runat="server" Text='<%# Eval("Maincat") %>'></asp:Label>
                <asp:Label ID="lblUnitid" Visible="false"  runat="server" Text='<%# Eval("unitID") %>'></asp:Label>
                <asp:Label ID="lblunit" Visible="false"  runat="server" Text='<%# Eval("Unit") %>'></asp:Label>
                 
               
            </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Subcat" HeaderText="Subcategory" />
            <asp:BoundField DataField="Size" HeaderText="Size" />
            <asp:BoundField DataField="Color" HeaderText="Color" />
            <asp:BoundField DataField="Article" HeaderText="Article" />
            <asp:BoundField DataField="Dimension" HeaderText="Dimension" />
            <asp:BoundField DataField="Unit" HeaderText="Unit" />             
               <asp:TemplateField HeaderText="Qty">
                <ItemTemplate>
                <asp:Label ID="lblqty" runat="server" Text='<%# Eval("Qty") %>'></asp:Label>                
                </ItemTemplate>
                </asp:TemplateField>
                  
           
            </Columns>
        </asp:GridView>
    </div>
    </div>
    <div style="text-align:right; margin:3px">
    <asp:Button ID="btnClear" runat="server" CssClass="button" Width="100px" 
            Text="Cancel" onclick="btnClear_Click" />
        <asp:Button ID="btnSave" runat="server" CssClass="button" Width="100px" 
            Text="Save" onclick="btnSave_Click" />
             <asp:ConfirmButtonExtender ID="btnGeneratesingle_ConfirmButtonExtender" 
                 runat="server" ConfirmText="Do you want to save" Enabled="True" 
                 TargetControlID="btnSave">
             </asp:ConfirmButtonExtender>
    </div>
     <asp:Button ID="btnppadd" style="display:none" runat="server" Text="Button" />
     <asp:ModalPopupExtender ID="btnppadd_ModalPopupExtender" runat="server" 
                                            DynamicServicePath="" BackgroundCssClass="ModalPopupBG" BehaviorID="ppadditm" CancelControlID="cnclitmpdt" 
                                            OkControlID="cnclitmpdt" Enabled="True" PopupControlID="ppgenpo" 
                                            TargetControlID="btnppadd">
                                            </asp:ModalPopupExtender>
                  
                </cc2:C1TabPage>
                
                 <cc2:C1TabPage ID="C1Tabpage2"  TabIndex="1" Text="View Details"  CssClass="tab">
                             <div class="pnlmain" style="height:520px;margin:5px">                                           
                             <div style="height:500px; width:1010px; overflow:auto">
                                  <cc3:C1GridView ID="grdIssuegetAll" runat="server" AllowPaging="True" 
                                        AutoGenerateColumns="False" PageSize="21" 
                                        ShowFilter="True" VisualStylePath="~/C1WebControls/VisualStyles" 
                                        AllowSorting="True" AllowColMoving="True" 
                                        VisualStyle="Office2007Blue" DefaultColumnWidth="" CellPadding="0" 
                                             CellSpacing="0" 
                                             Width="100%" AllowColSizing="True" >
                                        <Columns>
                                        <cc3:C1TemplateField HeaderText="Report">
                                        <ItemTemplate>
                                        <asp:Button ID="btnPrintpoconfirm"  style="cursor:pointer" 
                                                ToolTip="Generate Report" OnClick="btnPrintpoconfirm_Click" Width="50px" runat="server" Text="Report" 
                                                />
                                        </ItemTemplate>
                                        </cc3:C1TemplateField>  
                                        <cc3:C1TemplateField HeaderText="View">
                                        <ItemTemplate>
                                        <a class="link" title="Factory Return Details" href="javascript:vw('<%# Eval("GoodsReturnNo") %>')">Details</a>
                                        </ItemTemplate>
                                        </cc3:C1TemplateField>    
                                                                        
                                        <cc3:C1TemplateField HeaderText="Return No" Visible="false">
                                        <ItemTemplate>
                                        <asp:Label ID="lblIssueNo" runat="server" Text='<%# Eval("GoodsReturnNo") %>'></asp:Label>
                                        </ItemTemplate>
                                        </cc3:C1TemplateField>  
                                         <cc3:C1BoundField DataField="GoodsReturnNo" HeaderText="Return No" 
                                                SortExpression="GoodsReturnNo">
                                            </cc3:C1BoundField> 
                                         <cc3:C1BoundField DataField="cReturn_NoteNO" HeaderText="Return Note No" 
                                                SortExpression="cReturn_NoteNO">
                                            </cc3:C1BoundField>                                         
                                            <cc3:C1BoundField DataField="dReturn_Qty" ShowFilter="false" HeaderText="Return Quantity" 
                                                SortExpression="dReturn_Qty">
                                            </cc3:C1BoundField>
                                            <cc3:C1BoundField DataField="dReturn_Value" ShowFilter="false" HeaderText="Total Value" 
                                                SortExpression="dReturn_Value">
                                            </cc3:C1BoundField>                                           
                                            <cc3:C1BoundField DataField="cCmpName"  HeaderText="Company Name" 
                                                SortExpression="cCmpName">
                                            </cc3:C1BoundField>
                                             <cc3:C1BoundField DataField="cDeptname"  HeaderText="Department" 
                                                SortExpression="cDeptname">
                                            </cc3:C1BoundField>
                                             <cc3:C1BoundField DataField="cSection_Description"  HeaderText="Section" 
                                                SortExpression="cSection_Description">
                                            </cc3:C1BoundField>
                                             <cc3:C1BoundField DataField="cStyleNo"  HeaderText="Style No" 
                                                SortExpression="cStyleNo">
                                            </cc3:C1BoundField>
                                            <cc3:C1BoundField DataField="dEntDAte" ShowFilter="false" DataFormatString="{0:dd/MM/yyyy}" HtmlEncode="false" HeaderText="Issued Date" 
                                                SortExpression="dEntDAte">
                                            </cc3:C1BoundField>
                                            <cc3:C1BoundField DataField="cuser" HeaderText="Created By" 
                                                SortExpression="cuser">
                                            </cc3:C1BoundField>
                                            <cc3:C1BoundField DataField="cReturn_Type"  HeaderText="Type" 
                                                SortExpression="cReturn_Type">
                                            </cc3:C1BoundField>                                          
                                                                                                                   
                                        </Columns>
                                        <PagerSettings PageButtonCount="25" Mode="NextPrevious" />
                                               <HeaderStyle Wrap="False" />
                                               <RowStyle Wrap="False" Height="18px" />
                                           <PagerStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    </cc3:C1GridView>
                                      
                                         
                                        </div>
                          </div>
                                  
                </cc2:C1TabPage>      
            </TabPages>
                </cc2:C1TabControl>





   
     </ContentTemplate>
    </asp:UpdatePanel>
     <div id="ppgenpo" style="height:530px; width:910px; display:none; border:5px solid #64AFEA;background-color:#e9f0fb;-webkit-border-radius: 5px; -moz-border-radius: 5px;border-radius: 5px;">
    <div class="pppnlhdr">
    <div id="hdrtxt" style="float:left; padding-left:20px; color:White">Stock Balance</div>
    <div style="float:right; padding-top:2px; padding-right:2px"> 
        <input id="txtchkjv" style="display:none" type="text" />
        <img id="cnclitmpdt" style="cursor:pointer" alt="" src="../gridimage/grdRemove.png" />
    </div>
    </div>
     <div id="divLoading" style="width:600px; text-align:center; vertical-align:bottom; margin-top:200px"> 
       <img src="../images/loader.gif" alt="" /> 
     </div>
     <div id="divFrameHolder" style="display:none">
    <iframe id="ifupldfile" onload="hideLoading()" src="" style="border:none" width="900px" height="500px"></iframe>
    </div>
    </div>
</asp:Content>

