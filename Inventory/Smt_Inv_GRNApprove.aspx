<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory/MasterPage.master" AutoEventWireup="true" CodeFile="Smt_Inv_GRNApprove.aspx.cs" Inherits="Inventory_Smt_Inv_GRNApprove" %>

<%@ Register Assembly="C1.Web.UI.Controls.4" Namespace="C1.Web.UI.Controls.C1GridView"
    TagPrefix="cc3" %>
<%@ Register assembly="C1.Web.UI.Controls.4" namespace="C1.Web.UI.Controls.C1ComboBox" tagprefix="cc1" %>
<%@ Register assembly="C1.Web.UI.Controls.4" namespace="C1.Web.UI.Controls.C1TabControl" tagprefix="cc2" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script type="text/javascript">   
    function vdtlreq(tval) {
        onunload();
        document.getElementById("txtchkjv").value = "1"; 
        $("#hdrtxt").html("Edit GRN");
        $("#ifupldfile").attr("src", "Smt_Inv_GRNDtl.aspx?x=" + tval + "");
        var bid = $find('ppadditm');
        bid.show();
    }
    function vw(tval) {
        onunload();
        document.getElementById("txtchkjv").value = "0"; 
        $("#hdrtxt").html("View GRN");
        $("#ifupldfile").attr("src", "grnvwdtl.aspx?x=" + tval + "");
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
       function refreshgpo() {
           var val = document.getElementById("txtchkjv").value;
           if (val == "1") {
               document.getElementById('<%=btnRefreshforapp.ClientID %>').click();
           }          
           onunload();
       }
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="height:10px"></div>
    <asp:UpdatePanel ID="UpdatePanel4" runat="server">
    <ContentTemplate>
    
     <asp:Button ID="btnppgntpo" style="display:none" runat="server" Text="Button" />                                     
        <asp:ModalPopupExtender ID="Button2_ModalPopupExtender" runat="server" 
           DynamicServicePath="" BackgroundCssClass="ModalPopupBG" BehaviorID="ppadditm" CancelControlID="cnclitmpdt" 
           OkControlID="cnclitmpdt" Enabled="True" PopupControlID="ppgenpo" 
           TargetControlID="btnppgntpo">
       </asp:ModalPopupExtender>
      
   
  <cc2:C1TabControl ID="C1TabControl1" runat="server" width="100%"                    
                TextImageRelation="ImageBeforeText" onclienttabmouseenter="clr">
               <TabPages>
                <cc2:C1TabPage ID="C1TabPage1" TabIndex="0" Text="For Approval" CssClass="tab">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                           <table style="width: 100%;">
                                <tr>
                                    <td align="left" valign="top">
                                     <div class="pnlmain" style="height:470px;  padding:3px">
                                     <div class="pnlheader">
                                    
                                     </div>
                                       <cc3:C1GridView ID="grdApproveGrn" runat="server" AllowPaging="True" 
                                        AutoGenerateColumns="False"  PageSize="20" 
                                        ShowFilter="True" VisualStylePath="~/C1WebControls/VisualStyles" 
                                        AllowSorting="True" 
                                        VisualStyle="Office2007Blue" DefaultColumnWidth="" Width="100%" 
                                             UseEmbeddedVisualStyles="True" AllowRowHover="False" 
                                             onrowdatabound="grdApproveGrn_RowDataBound" AllowColSizing="True" 
                                             onfiltering="grdApproveGrn_Filtering" 
                                             onpageindexchanging="grdApproveGrn_PageIndexChanging" 
                                             onsorting="grdApproveGrn_Sorting">
                                        <Columns>                                     
                                        <cc3:C1TemplateField HeaderText="Report">
                                        <ItemTemplate>
                                         <asp:LinkButton ID="lnkprint" CssClass="link" OnClick="lnkprint_Click" ToolTip="Generate Report" runat="server" CommandArgument='<%# Eval("nGrnNo") %>'>Report</asp:LinkButton>
                                         </ItemTemplate>
                                        </cc3:C1TemplateField>
                                         <cc3:C1TemplateField HeaderText="View">
                                        <ItemTemplate>
                                        <a class="link" href="javascript:vdtlreq('<%# Eval("nGrnNo") %>')">Edit</a>                                        
                                        </ItemTemplate>
                                        </cc3:C1TemplateField>
                                        <cc3:C1TemplateField HeaderText="Select">
                                            <ItemTemplate>
                                            <asp:CheckBox ID="chkSelect" Width="25px" runat="server" />
                                            </ItemTemplate>
                                            </cc3:C1TemplateField>
                                        <cc3:C1TemplateField HeaderText="GRN NO" Visible="false">
                                        <ItemTemplate>
                                        <asp:Label ID="lblGrnno" runat="server" Text='<%# Eval("nGrnNo") %>'></asp:Label>
                                        <asp:Label ID="lblPONO" Visible="false" runat="server" Text='<%# Eval("nPoNum") %>'></asp:Label>
                                        <asp:Label ID="lblgrnvalforapp" Visible="false" runat="server" Text='<%# Eval("nValue") %>'></asp:Label>
                                        </ItemTemplate>
                                        </cc3:C1TemplateField> 
                                         <cc3:C1BoundField DataField="nGrnNo" HeaderText="GRN No" SortExpression="nGrnNo">
                                            </cc3:C1BoundField>                     
                                            <cc3:C1BoundField DataField="nPoNum" HeaderText="PO No" SortExpression="nPoNum">
                                            </cc3:C1BoundField>
                                            <cc3:C1BoundField DataField="cInVoice" ShowFilter="false" HeaderText="Challan No" 
                                                SortExpression="cInVoice">
                                            </cc3:C1BoundField>                                           
                                            <cc3:C1BoundField DataField="nValue"  HeaderText="GRN Amount" 
                                                SortExpression="nValue">
                                            </cc3:C1BoundField>
                                            <cc3:C1BoundField DataField="NewSupplier" HeaderText="Supplier Name" 
                                                SortExpression="NewSupplier">
                                            </cc3:C1BoundField>
                                             <cc3:C1BoundField DataField="cUserFullname" HeaderText="Created By" 
                                                SortExpression="cUserFullname">
                                            </cc3:C1BoundField>
                                             <cc3:C1BoundField DataField="dEntDate" DataFormatString="{0:dd/MM/yyyy}" HtmlEncode="false" HeaderText="Created Date" 
                                                SortExpression="dEntDate">
                                            </cc3:C1BoundField>                                            
                                                           
                                        </Columns>
                                        <PagerSettings PageButtonCount="25" Mode="NextPrevious" />
                                               <HeaderStyle Wrap="False" />
                                               <RowStyle Wrap="False" Height="18px" />
                                    </cc3:C1GridView>                                        
                                   </div>
                                    </td>
                                   
                                </tr>
                                <tr>
                                    <td>
                                      <div class="pnlmain">
                                      <table style="width: 100%;">
                                              <tr>
                                                  <td width="30px">
                                                     <div style="background-color:green; width:25px; height:14px"></div>
                                                  </td>
                                                  <td width="100px">
                                                     Factory GRN
                                                  </td>
                                                  <td width="30px">
                                                     <div style="background-color:black; width:25px; height:14px"></div>
                                                  </td>
                                                  <td width="100px">
                                                     Merchant GRN
                                                  </td>
                                                  <td>
                                                     
                                                  </td>
                                                  <td valign="top" align="right" style="padding-right:10px">                                        
                                                      <asp:Button ID="btnRefreshforapp" style="display:none" runat="server" 
                                                          onclick="btnRefreshforapp_Click" Text="Button" />                                                  
                                                      <asp:Button ID="btnCancel" Width="100px" CssClass="button" runat="server" 
                                                          Text="Cancel" onclick="btnCancel_Click"  />
                                                      <asp:ConfirmButtonExtender ID="btnCancel_ConfirmButtonExtender" 
                                                          runat="server" ConfirmText="Do you want to Cancel this GRN No?" Enabled="True" 
                                                          TargetControlID="btnCancel">
                                                      </asp:ConfirmButtonExtender>                       
                                                      <asp:Button ID="btnApprove" runat="server" CssClass="button" 
                                                          onclick="btnApprove_Click" Text="Approve" Width="100px" />
                                                      <asp:ConfirmButtonExtender ID="btnApprove_ConfirmButtonExtender" runat="server" 
                                                          ConfirmText="Do you want to approve this GRN No?" Enabled="True" 
                                                          TargetControlID="btnApprove">
                                                      </asp:ConfirmButtonExtender>
                                                  </td>
                                                  
                                              </tr>                                              
                                          </table>
                                     </div>
                                    </td>
                                   
                                </tr>
                               
                            </table>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                  
                </cc2:C1TabPage>
                <cc2:C1TabPage ID="C1TabPage2"  TabIndex="1" Text="Approved"  CssClass="tab">
                                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                        <ContentTemplate>
                           <table style="width: 100%;">
                                <tr>
                                    <td align="left" valign="top">
                                     <div class="pnlmain" style="height:465px;">
                                     <div class="pnlheader">                                    
                                     </div>
                                       <cc3:C1GridView ID="C1GridView1" runat="server" AllowPaging="True" 
                                        AutoGenerateColumns="False" PageSize="20" 
                                        ShowFilter="True" VisualStylePath="~/C1WebControls/VisualStyles" 
                                        AllowSorting="True" AllowColMoving="True" 
                                        VisualStyle="Office2007Blue" DefaultColumnWidth="" Width="100%" AllowRowHover="False" 
                                             onrowdatabound="C1GridView1_RowDataBound" AllowColSizing="True" 
                                             onfiltering="C1GridView1_Filtering" 
                                             onpageindexchanging="C1GridView1_PageIndexChanging" 
                                             onsorting="C1GridView1_Sorting" 
                                            >
                                        <Columns>
                                        <cc3:C1TemplateField HeaderText="Report">
                                        <ItemTemplate>                                            
                                        <asp:LinkButton ID="lnkprintapproved" OnClick="lnkprintapproved_Click" CssClass="link" ToolTip="Generate Report" runat="server" CommandArgument='<%# Eval("nGrnNo") %>'>Report</asp:LinkButton>
                                        </ItemTemplate>
                                        </cc3:C1TemplateField>
                                         <cc3:C1TemplateField HeaderText="View">
                                        <ItemTemplate>
                                        <a class="link" href="javascript:vw('<%# Eval("nGrnNo") %>')">View</a>
                                        
                                         <asp:Label ID="lblgrnvalappv" Visible="false" runat="server" Text='<%# Eval("nValue") %>'></asp:Label>                                   
                                        </ItemTemplate>
                                        </cc3:C1TemplateField>
                                        <cc3:C1TemplateField HeaderText="Select">
                                          <ItemTemplate>
                                          <asp:CheckBox ID="chkSelect" Width="25px" runat="server" />
                                          </ItemTemplate>
                                          </cc3:C1TemplateField>
                                        <cc3:C1TemplateField HeaderText="GRN NO" Visible="false">
                                        <ItemTemplate>
                                        <asp:Label ID="lblGrnnoApproved" runat="server" Text='<%# Eval("nGrnNo") %>'></asp:Label>
                                        <asp:Label ID="lblpoappv" Visible="false" runat="server" Text='<%# Eval("nPoNum") %>'></asp:Label>  
                                        </ItemTemplate>
                                        </cc3:C1TemplateField> 
                                                         <cc3:C1BoundField DataField="nGrnNo" HeaderText="GRN No" SortExpression="nGrnNo">
                                            </cc3:C1BoundField>                       
                                            <cc3:C1BoundField DataField="nPoNum" HeaderText="PO No" SortExpression="nPoNum">
                                            </cc3:C1BoundField>
                                                                                      
                                            <cc3:C1BoundField DataField="NewSupplier"  HeaderText="Supplier" 
                                                SortExpression="NewSupplier">
                                            </cc3:C1BoundField>
                                            <cc3:C1BoundField DataField="nValue" ShowFilter="false" HeaderText="GRN Amount" 
                                                SortExpression="nValue">
                                            </cc3:C1BoundField>
                                             <cc3:C1BoundField DataField="cUserFullname" HeaderText="Created By" 
                                                SortExpression="cUserFullname">
                                            </cc3:C1BoundField>
                                             <cc3:C1BoundField DataField="dEntDate" DataFormatString="{0:dd/MM/yyyy}" HtmlEncode="false" ShowFilter="false"  HeaderText="Created Date" 
                                                SortExpression="dEntDate">
                                            </cc3:C1BoundField>
                                             <cc3:C1BoundField DataField="ApprovedBy"  HeaderText="Approved By" 
                                                SortExpression="ApprovedBy">
                                            </cc3:C1BoundField>
                                              <cc3:C1BoundField DataField="dAppdate" DataFormatString="{0:dd/MM/yyyy}" HtmlEncode="false"  HeaderText="Approved Date" 
                                                SortExpression="dAppdate">
                                            </cc3:C1BoundField>
                                                           
                                        </Columns>
                                        <PagerSettings PageButtonCount="23" Mode="NextPrevious" />
                                               <HeaderStyle Wrap="False" />
                                               <RowStyle Wrap="False" Height="18px" />
                                    </cc3:C1GridView>  
                                   
                                       
                                   
                                     </div>
                                    </td>
                                   
                                </tr>
                                <tr>
                                    <td>
                                   
                                      <table style="width: 100%;">
                                              <tr>
                                                  <td width="30px">
                                                     <div style="background-color:#EDFAEB; width:25px; height:14px; border:1px solid #B8E9AF"></div>
                                                  </td>
                                                  <td width="100px">
                                                     Factory GRN
                                                  </td>
                                                  <td width="30px">
                                                     <div style="background-color:black; width:25px; height:14px"></div>
                                                  </td>
                                                  <td width="100px">
                                                     Merchant GRN
                                                  </td>
                                                  <td>
                                                     
                                                  </td>
                                                  <td valign="top" align="right" style="padding-right:15px">                                                    
                                                  
                                                      <asp:Button ID="btnRevise" Width="100px" ToolTip="Revise" CssClass="button" runat="server" 
                                                          Text="Re-work" onclick="btnRevise_Click"   />                                                               
                                                 
                                                       
                                                      <asp:ConfirmButtonExtender ID="btnRevise_ConfirmButtonExtender" runat="server" 
                                                          ConfirmText="Do you want to revise ?" Enabled="True" TargetControlID="btnRevise">
                                                      </asp:ConfirmButtonExtender>
                                                 
                                                       
                                                  </td>
                                                  
                                              </tr>                                              
                                          </table>
                                   
                                    </td>
                                   
                                </tr>
                               
                            </table>
                        </ContentTemplate>
                    </asp:UpdatePanel>
               
                                  
                </cc2:C1TabPage>      
                  <cc2:C1TabPage ID="C1TabPage3"  TabIndex="1" Text="Cancelled"  CssClass="tab">
                                <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                        <ContentTemplate>
                           <table style="width: 100%;">
                                <tr>
                                    <td align="left" valign="top">
                                     <div class="pnlmain" style="height:465px;">
                                     <div class="pnlheader">                                    
                                     </div>
                                       <cc3:C1GridView ID="grdCancel" runat="server" AllowPaging="True" 
                                        AutoGenerateColumns="False" PageSize="20" 
                                        ShowFilter="True" VisualStylePath="~/C1WebControls/VisualStyles" 
                                        AllowSorting="True" AllowColMoving="True" 
                                        VisualStyle="Office2007Blue" DefaultColumnWidth="" Width="100%" AllowRowHover="False" 
                                             onrowdatabound="grdCancel_RowDataBound" AllowColSizing="True" 
                                             onfiltering="grdCancel_Filtering" 
                                             onpageindexchanging="grdCancel_PageIndexChanging" 
                                             onsorting="grdCancel_Sorting" 
                                            >
                                        <Columns>
                                        <cc3:C1TemplateField HeaderText="Report">
                                        <ItemTemplate>                                            
                                        <asp:LinkButton ID="lnkprintapproved" OnClick="lnkprintapproved_Click" CssClass="link" ToolTip="Generate Report" runat="server" CommandArgument='<%# Eval("nGrnNo") %>'>Report</asp:LinkButton>
                                        </ItemTemplate>
                                        </cc3:C1TemplateField>
                                         <cc3:C1TemplateField HeaderText="View">
                                        <ItemTemplate>
                                        <a class="link" href="javascript:vw('<%# Eval("nGrnNo") %>')">View</a>
                                        
                                         <asp:Label ID="lblgrnvalappv" Visible="false" runat="server" Text='<%# Eval("nValue") %>'></asp:Label>                                   
                                        </ItemTemplate>
                                        </cc3:C1TemplateField>
                                        <cc3:C1TemplateField HeaderText="Select">
                                          <ItemTemplate>
                                          <asp:CheckBox ID="chkSelect" Width="25px" runat="server" />
                                          </ItemTemplate>
                                          </cc3:C1TemplateField>
                                        <cc3:C1TemplateField HeaderText="GRN NO" Visible="false">
                                        <ItemTemplate>
                                        <asp:Label ID="lblGrnnoApproved" runat="server" Text='<%# Eval("nGrnNo") %>'></asp:Label>
                                        <asp:Label ID="lblpoappv" Visible="false" runat="server" Text='<%# Eval("nPoNum") %>'></asp:Label>  
                                        </ItemTemplate>
                                        </cc3:C1TemplateField> 
                                                         <cc3:C1BoundField DataField="nGrnNo" HeaderText="GRN No" SortExpression="nGrnNo">
                                            </cc3:C1BoundField>                       
                                            <cc3:C1BoundField DataField="nPoNum" HeaderText="PO No" SortExpression="nPoNum">
                                            </cc3:C1BoundField>                                                                                     
                                          <cc3:C1BoundField DataField="nValue" ShowFilter="false" HeaderText="GRN Amount" 
                                                SortExpression="nValue">
                                            </cc3:C1BoundField>
                                             <cc3:C1BoundField DataField="cUserFullname" HeaderText="Created By" 
                                                SortExpression="cUserFullname">
                                            </cc3:C1BoundField>
                                             <cc3:C1BoundField DataField="CancelDate" DataFormatString="{0:dd/MM/yyyy}" HtmlEncode="false" ShowFilter="false"  HeaderText="Cancelled Date" 
                                                SortExpression="CancelDate">
                                            </cc3:C1BoundField>
                                             <cc3:C1BoundField DataField="CancelledBy"  HeaderText="Cancelled By" 
                                                SortExpression="CancelledBy">
                                            </cc3:C1BoundField>
                                            
                                        </Columns>
                                        <PagerSettings PageButtonCount="23" Mode="NextPrevious" />
                                               <HeaderStyle Wrap="False" />
                                               <RowStyle Wrap="False" Height="18px" />
                                    </cc3:C1GridView>  
                                   
                                       
                                   
                                     </div>
                                    </td>
                                   
                                </tr>
                                <tr>
                                    <td>
                                   
                                 
                                   
                                    </td>
                                   
                                </tr>
                               
                            </table>
                        </ContentTemplate>
                    </asp:UpdatePanel>
               
                                  
                </cc2:C1TabPage>       
                
              
               
              
            </TabPages>
                </cc2:C1TabControl>
    </ContentTemplate>
    </asp:UpdatePanel>


    <div id="ppgenpo" style="height:530px; width:900px; display:none; border:5px solid #64AFEA;background-color:#e9f0fb;-webkit-border-radius: 5px; -moz-border-radius: 5px;border-radius: 5px;">
    <div class="pppnlhdr">
    <div id="hdrtxt" style="float:left; padding-left:20px; color:White">
       Generate PO</div>
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

   
 


</asp:Content>

