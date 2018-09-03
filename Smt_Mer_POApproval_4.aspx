<%@ Page Title="Canceled" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Smt_Mer_POApproval_4.aspx.cs" Inherits="Smt_Mer_POApproval_4" %>
<%@ Register Assembly="C1.Web.UI.Controls.4" Namespace="C1.Web.UI.Controls.C1GridView"
    TagPrefix="cc3" %>
    <%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>

    <div>

    <table style="width:100%;">
        <tr>
            <td style="width:160px; vertical-align:top">
          <div style="height:220px; border:1px solid #2A89B5;-webkit-border-radius: 5px;-moz-border-radius: 5px;border-radius: 5px;">
            <div style="border-bottom:1px solid #2A89B5; background-color:#3EA4D2; color:White; text-align:center; padding:3px">
            Cancelled
            </div>
            <div style="padding-left:8px; padding-right:8px">
               <table style="width:100%;">
                    <tr>
                        <td>
                            </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                           <a  class="newmenualink" style="color:Red" href="Smt_Mer_POApproval_New.aspx">Confirm To Approve</a>
                           </td>
                    </tr>
                    <tr>
                        <td>
                             <a class="newmenualink" href="Smt_Mer_POApproval_2.aspx">For Approval</a>
                            </td>
                    </tr>
                    <tr>
                        <td>
                           <a class="newmenualink" href="Smt_Mer_POApproval_3.aspx">Approved</a>
                          </td>
                    </tr>
                    <tr>
                        <td>
                           <a class="newmenualink" href="Smt_Mer_POApproval_4.aspx">Cancelled</a>
                          </td>
                    </tr>
                    <tr>
                        <td>
                            <a class="newmenualink" href="Smt_Mer_POApproval_5.aspx">Revised</a>
                           </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                    </tr>
                    </table>
                </div>
                </div>

            </td>
            <td style="vertical-align:top">
               <div style="border:1px solid #2A89B5; height:560px;-webkit-border-radius: 5px;-moz-border-radius: 5px;border-radius: 5px;">
               <div style="height:530px; overflow:auto">
               
                   <cc3:C1GridView ID="grdCanceled" runat="server" AllowColMoving="True" 
                       AllowColSizing="True" AllowPaging="True" AllowSorting="True" 
                       AutoGenerateColumns="False" DefaultColumnWidth="" 
                       onfiltering="grdCanceled_Filtering" 
                       onpageindexchanging="grdCanceled_PageIndexChanging" 
                       onrowdatabound="grdCanceled_RowDataBound" PageSize="21" ShowFilter="True" 
                       UseEmbeddedVisualStyles="True" VisualStyle="Office2007Blue" 
                       VisualStylePath="~/C1WebControls/VisualStyles" Width="100%">
                       <Columns>
                           <cc3:C1TemplateField>
                               <ItemTemplate>
                                  <a style="text-decoration:none; padding:0px 3px" onclick="rptshow('<%# Eval("nPoNum") %>')" href="#">Report</a>
                               </ItemTemplate>
                           </cc3:C1TemplateField>
                           <cc3:C1TemplateField>
                               <ItemTemplate>
                                    <a style="text-decoration:none; padding:0px 3px" onclick="viewdata('<%# Eval("nPoNum") %>')" href="#">View</a>
                               </ItemTemplate>
                           </cc3:C1TemplateField>
                           <cc3:C1BoundField DataField="nPoNum" HeaderText="PO NO" SortExpression="nPoNum">
                           </cc3:C1BoundField>
                           <cc3:C1BoundField DataField="cSeason_Name" HeaderText="Season" 
                               SortExpression="Season">
                           </cc3:C1BoundField>
                           <cc3:C1BoundField DataField="cStyleNo" HeaderText="Style No" 
                               SortExpression="Style No">
                           </cc3:C1BoundField>
                           <cc3:C1BoundField DataField="cSupName" HeaderText="Supplier" 
                               SortExpression="Supplier">
                           </cc3:C1BoundField>
                          
                           <cc3:C1BoundField DataField="nAmot" HeaderText="Amount" ShowFilter="false" 
                               SortExpression="Amount">
                           </cc3:C1BoundField>
                           <cc3:C1BoundField DataField="cCurType" HeaderText="Currency Type" 
                               ShowFilter="false" SortExpression="Currency Type">
                           </cc3:C1BoundField>                    
                          
                           
                          
                       </Columns>
                       <PagerSettings Mode="NextPreviousFirstLast" PageButtonCount="15" />
                       <HeaderStyle Wrap="False" />
                       <RowStyle Height="18px" Wrap="False" />
                   </cc3:C1GridView>
               
               </div>  
               <div style="border-top:1px solid #2A89B5"></div>             
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
        <img id="cnclitmpdt" onclick="refreshgpo();" style="cursor:pointer" alt="" src="gridimage/grdRemove.png" />
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
        function hideLoading() {
            document.getElementById('divLoading').style.display = "none";
            document.getElementById('divFrameHolder').style.display = "block";
        }
        function onunload() {
            document.getElementById('divLoading').style.display = "block";
            document.getElementById('divFrameHolder').style.display = "none";
        }
        function rptshow(PONO) {
//            onunload();
//            document.getElementById("txtchkjv").value = "1";
//            $("#hdrtxt").html("PO Report");
//            $("#ifupldfile").attr("src", "Merchandising/PO/POReport.aspx?x=" + PONO + "");
//            var bid = $find('ppadditm');
//                        bid.show();
            window.open('Merchandising/PO/POReport.aspx?x=' + PONO + '', 'popup', 'location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600');
        }
        function viewdata(PONO) {
            onunload();
            document.getElementById("txtchkjv").value = "1";
            $("#hdrtxt").html("PO Details");
            $("#ifupldfile").attr("src", "Merchandising/PO/ViewPO.aspx?x=" + PONO + "");
            var bid = $find('ppadditm');
            bid.show();
        }
    </script>
</asp:Content>



