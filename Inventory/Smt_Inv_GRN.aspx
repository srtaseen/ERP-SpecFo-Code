<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory/MasterPage.master" AutoEventWireup="true" CodeFile="Smt_Inv_GRN.aspx.cs" Inherits="Inventory_Smt_Inv_GRN" %>

<%@ Register Assembly="C1.Web.UI.Controls.4" Namespace="C1.Web.UI.Controls.C1GridView" TagPrefix="cc3" %>
<%@ Register assembly="C1.Web.UI.Controls.4" namespace="C1.Web.UI.Controls.C1ComboBox" tagprefix="cc1" %>
<%@ Register assembly="C1.Web.UI.Controls.4" namespace="C1.Web.UI.Controls.C1TabControl" tagprefix="cc2" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style1
        {
            height: 23px;
        }
    </style>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="height:10px"></div>
 <asp:UpdatePanel ID="UpdatePanel4" runat="server">
    <ContentTemplate>  
   
          
                  
                <cc2:C1TabControl ID="C1TabControl2" runat="server" width="100%"                    
                TextImageRelation="ImageBeforeText" onclienttabmouseenter="clr" 
                    Animation="Fade">
               <TabPages>
                <cc2:C1TabPage ID="C1TabPage3" TabIndex="0" Text="Goods Receive Note" CssClass="tab">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <table style="width:100%;">
                                <tr>
                                    <td>
                                    <div class="pnlmain">
                                        <table style="width:100%;">
                                            <tr>
                                                <td class="style1" align="right">
                                                    <asp:Label ID="Label5" runat="server" CssClass="label" Text="Buyer"></asp:Label>
                                                </td>
                                                <td align="left" class="style1" width="220">
                                                    <asp:DropDownList ID="drpBuyer" runat="server" CssClass="dropdownlist" 
                                                        Width="200px" AutoPostBack="True" 
                                                        onselectedindexchanged="drpBuyer_SelectedIndexChanged">
                                                    </asp:DropDownList>
                                                </td>
                                                <td align="right" class="style1" width="150">
                                                    <asp:Label ID="Label11" runat="server" CssClass="label" Text="Style Number"></asp:Label>
                                                </td>
                                                <td class="style1" width="230">
                                                    <asp:DropDownList ID="drpStyleNumber" runat="server" CssClass="dropdownlist" 
                                                        Width="202px" AutoPostBack="True" 
                                                        onselectedindexchanged="drpStyleNumber_SelectedIndexChanged">
                                                    </asp:DropDownList>
                                                </td>
                                                <td align="center">
                                                    <asp:RadioButton ID="rdMerchantgrn" runat="server" AutoPostBack="True" 
                                                        Checked="True" GroupName="a" oncheckedchanged="rdMerchantgrn_CheckedChanged" 
                                                        Text="Merchant GRN" />
                                                    &nbsp;
                                                    <asp:RadioButton ID="rdFactorygrn" runat="server" AutoPostBack="True" 
                                                        GroupName="a" oncheckedchanged="rdFactorygrn_CheckedChanged" 
                                                        Text="Factory GRN" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right">
                                                    <asp:Label ID="Label6" runat="server" CssClass="label" Text="Supplier"></asp:Label>
                                                </td>
                                                <td align="left">
                                                    <asp:DropDownList ID="drpSupplier" runat="server" CssClass="dropdownlist" 
                                                        Width="200px" AutoPostBack="True" 
                                                        onselectedindexchanged="drpSupplier_SelectedIndexChanged">
                                                    </asp:DropDownList>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                        ControlToValidate="drpSupplier" Display="None" ErrorMessage="Select Supplier" 
                                                        ValidationGroup="a">*</asp:RequiredFieldValidator>
                                                    <asp:ValidatorCalloutExtender ID="RequiredFieldValidator2_ValidatorCalloutExtender" 
                                                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator2">
                                                    </asp:ValidatorCalloutExtender>
                                                </td>
                                                <td align="right">
                                                    <asp:Label ID="Label10" runat="server" CssClass="label" 
                                                        Text="Invoice/chalan Number"></asp:Label>
                                                </td>
                                                <td width="230">
                                                    <asp:TextBox ID="txtChallan" runat="server" CssClass="textbox" Width="200px" 
                                                        MaxLength="20"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                                        ControlToValidate="txtChallan" Display="None" ErrorMessage="Enter Challan No." 
                                                        ValidationGroup="a">*</asp:RequiredFieldValidator>
                                                    <asp:ValidatorCalloutExtender ID="RequiredFieldValidator4_ValidatorCalloutExtender" 
                                                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator4">
                                                    </asp:ValidatorCalloutExtender>
                                                </td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td align="right">
                                                    <asp:Label ID="Label7" runat="server" CssClass="label" 
                                                        Text="Pending P.O number"></asp:Label>
                                                </td>
                                                <td align="left">
                                                    <asp:DropDownList ID="drpPendingPO" runat="server" CssClass="dropdownlist" 
                                                        Width="200px" AutoPostBack="True" 
                                                        onselectedindexchanged="drpPendingPO_SelectedIndexChanged">
                                                    </asp:DropDownList>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                        ControlToValidate="drpPendingPO" Display="None" ErrorMessage="Select PO No." 
                                                        ValidationGroup="a">*</asp:RequiredFieldValidator>
                                                    <asp:ValidatorCalloutExtender ID="RequiredFieldValidator3_ValidatorCalloutExtender" 
                                                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator3">
                                                    </asp:ValidatorCalloutExtender>
                                                </td>
                                                <td align="right">
                                                    <asp:Label ID="Label12" runat="server" CssClass="label" Text="G.R.N number"></asp:Label>
                                                </td>
                                                <td align="left" width="230">
                                                    <asp:TextBox ID="txtGRNNo" runat="server" CssClass="textbox" Width="200px" 
                                                        Enabled="False"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label13" runat="server" CssClass="label" Text="Currency"></asp:Label>
                                                    <asp:TextBox ID="drpCurrenct" runat="server" CssClass="textbox" Width="150px" 
                                                        Enabled="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                      <div class="pnlmain">
                                      <div id="dva" class="pnlheader">Pending PO Details</div>              
                                          <asp:Panel ID="Panel1" Height="345px" ScrollBars="Auto" runat="server">                                     
                                          <asp:GridView ID="grdPurchaseOrderDtl" AutoGenerateColumns="false" runat="server" 
                                                  onrowdatabound="grdPurchaseOrderDtl_RowDataBound" ShowFooter="True" 
                                                  CssClass="mGrid">
                                          <Columns>                                         
                                           <asp:TemplateField HeaderText="Style No">
                                          <ItemTemplate>
                                          <asp:Label ID="lblStyleno" runat="server" Text='<%# Eval("cStyleNo") %>'></asp:Label>
                                          <asp:Label ID="lblStyleID" runat="server" Visible="false" Text='<%# Eval("nstyCode") %>'></asp:Label>
                                          </ItemTemplate>
                                          </asp:TemplateField>
                                          <asp:TemplateField HeaderText="Item Description">
                                          <ItemTemplate>
                                          <asp:Label ID="lblitmdesc" runat="server" Text='<%# Eval("cItemdes") %>'></asp:Label>
                                          <asp:Label ID="lblItemCode" runat="server" style="display:none" Text='<%# Eval("cItemCode") %>'></asp:Label>
                                          </ItemTemplate>
                                          </asp:TemplateField>

                                          <asp:TemplateField HeaderText="Brand">
                                          <ItemTemplate>
                                          <asp:Label ID="lblbrand" runat="server" Text='<%# Eval("cBrand_Name") %>'></asp:Label>
                                          <asp:Label ID="lblbrandcode" runat="server" style="display:none" Text='<%# Eval("nBrand_ID") %>'></asp:Label>
                                          </ItemTemplate>
                                          </asp:TemplateField>

                                          <asp:TemplateField HeaderText="Size">
                                          <ItemTemplate>
                                          <asp:Label ID="lblSlno" runat="server" Visible="false" Text='<%# Eval("nLnNo") %>'></asp:Label>
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
                                          <asp:Label ID="lblArt" runat="server" Text='<%# Eval("cArt") %>'></asp:Label>
                                          </ItemTemplate>
                                          </asp:TemplateField>
                                          <asp:TemplateField HeaderText="Dimension">
                                          <ItemTemplate>
                                          <asp:Label ID="lblDimn" runat="server" Text='<%# Eval("cDimec") %>'></asp:Label>
                                          </ItemTemplate>
                                          </asp:TemplateField>
                                          <asp:TemplateField HeaderText="Unit">
                                          <ItemTemplate>
                                          <asp:Label ID="lblUnit" runat="server" Text='<%# Eval("cUnit") %>'></asp:Label>
                                          </ItemTemplate>
                                          </asp:TemplateField>
                                          <asp:TemplateField HeaderText="Ord Qty">
                                          <ItemTemplate>
                                          <asp:Label ID="lblQty" runat="server" Text='<%# Eval("nQty") %>'></asp:Label>
                                          </ItemTemplate>
                                          </asp:TemplateField>
                                          <asp:TemplateField HeaderText="Price">
                                          <ItemTemplate>
                                          <asp:TextBox ID="lblPrice" CssClass="textboxforgridviewNumeric" Width="40px" 
                                                  runat="server" Text='<%# Eval("nPrice") %>' MaxLength="8"></asp:TextBox>                                           
                                          <asp:FilteredTextBoxExtender ID="lblPrice_FilteredTextBoxExtender" 
                                                  runat="server" Enabled="True" TargetControlID="lblPrice" 
                                                  ValidChars=".0123456789">
                                              </asp:FilteredTextBoxExtender>                                           
                                          </ItemTemplate>
                                          </asp:TemplateField>                                         
                                           <asp:TemplateField HeaderText="Value">
                                          <ItemTemplate>
                                          <asp:Label ID="lblValue" runat="server" Text='<%# Eval("nVal") %>'></asp:Label>
                                          </ItemTemplate>
                                          </asp:TemplateField>
                                           <asp:TemplateField HeaderText="Rest Qty">
                                          <ItemTemplate>
                                         <asp:Label ID="lblRest" Text='<%# Eval("nQty") %>' runat="server"></asp:Label>
                                          </ItemTemplate>
                                          </asp:TemplateField>                                        
                                           <asp:TemplateField HeaderText="GRN Qty">
                                          <ItemTemplate>
                                          <asp:TextBox ID="txtGrnQty" CssClass="textboxforgridview" Width="50px" runat="server" 
                                                  MaxLength="8"></asp:TextBox>
                                              <asp:FilteredTextBoxExtender ID="txtGrnQty_FilteredTextBoxExtender" 
                                                  runat="server" Enabled="True" TargetControlID="txtGrnQty" 
                                                  ValidChars=".0123456789">
                                              </asp:FilteredTextBoxExtender>
                                          </ItemTemplate>
                                          </asp:TemplateField>
                                           <asp:TemplateField HeaderText="FOC Qty">
                                          <ItemTemplate>
                                          <asp:TextBox ID="txtFocqty" Enabled="false" Width="50px" CssClass="textboxforgridview" runat="server" MaxLength="6"></asp:TextBox>
                                          </ItemTemplate>
                                          </asp:TemplateField>
                                           <asp:TemplateField HeaderText="GRN Value">
                                          <ItemTemplate>
                                         <asp:TextBox ID="txtGRNValue" Enabled="false" Width="60px" CssClass="textboxforgridview" runat="server"></asp:TextBox>
                                          </ItemTemplate>
                                          </asp:TemplateField>
                                          <asp:TemplateField HeaderText="Supplier">
                                          <ItemTemplate>
                                          <asp:DropDownList ID="drpnSupplier" Enabled="false" runat="server" CssClass="textboxforgridview" Width="150px"></asp:DropDownList>
                                          <asp:Label ID="lblMcatid" Visible="false" runat="server"></asp:Label>
                                          </ItemTemplate>
                                          </asp:TemplateField>
                                          <asp:TemplateField HeaderText="">
                                            <ItemTemplate>
                                            <asp:ImageButton ID="btnlodsup" Width="13px" Height="13px" runat="server" 
                                                    ImageUrl="~/gridimage/ref1.png" onclick="btnlodsup_Click" />
                                            </ItemTemplate>
                                            </asp:TemplateField>
                                           <asp:TemplateField HeaderText="">
                                          <ItemTemplate>
                                          <a title="Set Item Location" id="ancpp" runat="server" style="padding-left:1px; background-color:#40C8BF; padding-right:3px; border:2px solid #C6E3F6; color:White" href="#">L</a>
                                          <%--<asp:Button ID="btnLocation" style="cursor:pointer" OnClick="btnLocation_Click" ToolTip="Location" runat="server" Text="." Font-Size="9px" />--%>
                                          </ItemTemplate>
                                          </asp:TemplateField>
                                          </Columns>
                                              <FooterStyle CssClass="gridheader" />
                                              <HeaderStyle CssClass="gridheader" />
                                          </asp:GridView>
                                      
                                       </asp:Panel>
                                      </div>
                                     
                                      </td>
                                </tr>
                                <tr>
                                    <td>
                                      <div >
                                      <div style="float:left">
                                        <input id="btnAddsupplier" runat="server" onclick="vdtlreq();" class="button" type="button" value="Add Supplier" />
                                          <asp:Button ID="btnppadd" style="display:none" runat="server" Text="Button" />
                                          <asp:ModalPopupExtender ID="btnppadd_ModalPopupExtender" runat="server" 
                                            DynamicServicePath="" BackgroundCssClass="ModalPopupBG" BehaviorID="ppadditm" CancelControlID="cnclitmpdt" 
                                            OkControlID="cnclitmpdt" Enabled="True" PopupControlID="ppgenpo" 
                                            TargetControlID="btnppadd">
                                            </asp:ModalPopupExtender>
                                        </div>
                                        <div align="right" style="padding:3px 10px;float:right">
                                              <asp:Button ID="btnClear" runat="server" Text="Clear" Width="100px" 
                                              CssClass="button" onclick="btnClear_Click" />
                                          <asp:Button ID="btnSave" runat="server" Text="Save" Width="100px" 
                                              CssClass="button" onclick="btnSave_Click" ValidationGroup="a" />
                                              <asp:ConfirmButtonExtender ID="btnSave_ConfirmButtonExtender" 
                                              runat="server" ConfirmText="Do you want to save?" Enabled="True" 
                                              TargetControlID="btnSave">
                                          </asp:ConfirmButtonExtender>
                                              </div>
                                      </div>
                                      </td>
                                </tr>
                            </table>
                        </ContentTemplate>
                    </asp:UpdatePanel>                  
                </cc2:C1TabPage>
                <cc2:C1TabPage ID="C1TabPage4"  TabIndex="1" Text="View Details"  CssClass="tab">
                                <asp:UpdatePanel ID="UpdatePanddd" runat="server">
                        <ContentTemplate>
                          <div class="pnlmain" style="height:518px; margin:5px">
                          <div class="pnlheader"></div>
                          <div style="height:490px; overflow:auto">
                       <cc3:C1GridView ID="grdConfirmToApprove" runat="server" Width="100%" AllowPaging="True" 
                                        AutoGenerateColumns="False" PageSize="22" 
                                        ShowFilter="True" VisualStylePath="~/C1WebControls/VisualStyles" 
                                        AllowSorting="True" AllowColSizing="true"
                                        VisualStyle="Office2007Blue" DefaultColumnWidth="" 
                                  onsorting="grdConfirmToApprove_Sorting" 
                                  onfiltering="grdConfirmToApprove_Filtering" 
                                  onpageindexchanging="grdConfirmToApprove_PageIndexChanging" onrowdatabound="grdConfirmToApprove_RowDataBound" 
                                         >
                                        <Columns>                                      
                                       <cc3:C1TemplateField HeaderText="Report">
                                        <ItemTemplate>
                                        <asp:LinkButton ID="lnkprint" ToolTip="Generate Report" style="text-decoration:none; padding-left:5px; padding-right:4px" CommandArgument='<%# Eval("nGrnNo") %>' runat="server" onclick="lnkprint_Click">Report</asp:LinkButton>
                                        <asp:Label ID="lblGrnNo" style="display:none" runat="server" Text='<%# Eval("nGrnNo") %>'></asp:Label>
                                        </ItemTemplate>
                                        </cc3:C1TemplateField>
                                        <cc3:C1TemplateField HeaderText="View">
                                        <ItemTemplate>
                                        <a href="#" runat="server" style="text-decoration:none" id="ancvw" title="Edit/View GRN">View</a>
                                        </ItemTemplate>
                                        </cc3:C1TemplateField>                              
                                          <cc3:C1BoundField DataField="nGrnNo" HeaderText="GRN No" 
                                                SortExpression="nGrnNo">
                                            </cc3:C1BoundField> 
                                          <cc3:C1BoundField DataField="nPoNum" HeaderText="PO No" 
                                                SortExpression="nPoNum">
                                            </cc3:C1BoundField>                                                                        
                                            <cc3:C1BoundField DataField="cInVoice" HeaderText="Challan No" 
                                                SortExpression="cInVoice">
                                            </cc3:C1BoundField>
                                             <cc3:C1BoundField DataField="nValue" ShowFilter="false" HeaderText="GRN Amount" 
                                                SortExpression="nValue">
                                            </cc3:C1BoundField>
                                             <cc3:C1BoundField DataField="cUserFullname" HeaderText="Created By" 
                                                SortExpression="cUserFullname">
                                            </cc3:C1BoundField>
                                             <cc3:C1BoundField DataField="dEntDate" DataFormatString="{0:dd/MM/yyyy}" ShowFilter="false" HeaderText="Created Date" 
                                                SortExpression="dEntDate">
                                            </cc3:C1BoundField>                                                                               
                                        </Columns>
                                        <PagerSettings PageButtonCount="25" Mode="NextPrevious" />
                                               <HeaderStyle Wrap="False" />
                                               <RowStyle Wrap="False" Height="18px" />
                                    </cc3:C1GridView>  
                                   
                          </div>
                              <asp:Button ID="btnReloadForapp" OnClick="refGRN" style="display:none" runat="server" Text="Button" />
                                                              
                          
                          </div>
                        </ContentTemplate>
                        </asp:UpdatePanel>     
               
                                  
                </cc2:C1TabPage>  
                
            </TabPages>
                </cc2:C1TabControl>
             

              <div id="dvRenameStyle" style="height:400px; width:300px; display:none;border:1px solid silver">
   
        
    </div>
               
    </ContentTemplate>
    </asp:UpdatePanel>


     <div id="ppgenpo" style="height:530px; width:910px; display:none; border:5px solid #64AFEA;background-color:#e9f0fb;-webkit-border-radius: 5px; -moz-border-radius: 5px;border-radius: 5px;">
    <div class="pppnlhdr">
    <div id="hdrtxt" style="float:left; padding-left:20px; color:White">Generate PO</div>
    <div style="float:right; padding-top:2px; padding-right:2px"> 
        <input id="txtchkjv" style="display:none" type="text" />
        <img id="cnclitmpdt" onclick="refreshgpo();" style="cursor:pointer" alt="" src="../gridimage/grdRemove.png" />
    </div>
    </div>
     <div id="divLoading" style="width:600px; text-align:center; vertical-align:bottom; margin-top:200px"> 
       <img src="../images/loader.gif" alt="" /> 
     </div>
     <div id="divFrameHolder" style="display:none">
    <iframe id="ifupldfile" onload="hideLoading()" src="" style="border:none" width="900px" height="500px"></iframe>
    </div>
    </div>
   
    <script src="../jquery/scrollsaver.min.js" type="text/javascript"></script>
    <script src="../jquery/Inventory.js" type="text/javascript"></script>
   <%-- <script type="text/javascript">
        function s() {
            var t = document.getElementById("<%=grdPurchaseOrderDtl.ClientID%>");
            var t2 = t.cloneNode(true);
            for (i = t2.rows.length - 1; i > 0; i--)
                t2.deleteRow(i);
            t.deleteRow(0);
            dva.appendChild(t2);

        }
        window.onload = s;
    </script>    --%>
    <script type="text/javascript">
        function vdtlreq() {
            onunload();
            document.getElementById("txtchkjv").value = "0";        
            $("#hdrtxt").html("Add New Supplier");
            $("#ifupldfile").attr("src", "../Master_Setup/frmSupplier.aspx");
            var bid = $find('ppadditm');
            bid.show();
        }
        function viewgrndtl(GRNNO) {
            onunload();
            document.getElementById("txtchkjv").value = "1";   
            $("#hdrtxt").html("Edit/View GRN Details");
            $("#ifupldfile").attr("src", "Smt_Inv_GRNDtl.aspx?x="+GRNNO+"");
            var bid = $find('ppadditm');
            bid.show();
        }
        function showItmloct(Itemcode, txtgrnval) {
            var grnqty = document.getElementById(txtgrnval).value;
            if (grnqty.length > 0) {
                onunload();
                document.getElementById("txtchkjv").value = "0";
                $("#hdrtxt").html("Set Item Location");
                $("#ifupldfile").attr("src", "Smt_Inv_ItmLocation.aspx?x=" + Itemcode + "");
                var bid = $find('ppadditm');
                bid.show();
            }
            else {
                document.getElementById(txtgrnval).style.background = "red";
                alert("First Enter GRN Quantity");
                document.getElementById(txtgrnval).style.background = "";
            }
        }
        function hideLoading() {
            document.getElementById('divLoading').style.display = "none";
            document.getElementById('divFrameHolder').style.display = "block";
        }
        function onunload() {
            document.getElementById('divLoading').style.display = "block";
            document.getElementById('divFrameHolder').style.display = "none";
        }
        function refreshgpo() {
            var val = document.getElementById("txtchkjv").value;
            if (val == "1") {
                document.getElementById('<%=btnReloadForapp.ClientID %>').click();
            }           
            onunload();
        }



        function LocationPP() {
//           var left = (screen.width - 475) / 2;
//           tp = (screen.height - 300) / 2;
//           window.open('Smt_Inv_ItmLocation.aspx', 'popup', 'location=1,status=1,right=0,top=100,scrollbars=1,width=400,height=550');

//           var viewportwidth = document.documentElement.clientWidth;
//           var viewportheight = document.documentElement.clientHeight;
//           window.resizeBy(-300, 0);
//           window.moveTo(0, 0);
//           window.open("Smt_Inv_ItmLocation.aspx", "mywindow", "width=300, height=" + viewportheight + ", right=" + (viewportwidth - 300) + ", top=0, screenX=0, screenY=0");
        //    window.open("Smt_Inv_ItmLocation.aspx","mywindow","width=300,left=" + (viewportwidth - 300) + ",top=0");

         

       }
      

    </script>
    
   
</asp:Content>

