<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory/MasterPage.master" AutoEventWireup="true" CodeFile="Smt_Inv_GoodIssuing.aspx.cs" Inherits="Inventory_Smt_Inv_GoodIssuing" %>

<%@ Register Assembly="C1.Web.UI.Controls.4" Namespace="C1.Web.UI.Controls.C1GridView" TagPrefix="cc3" %>
<%@ Register assembly="C1.Web.UI.Controls.4" namespace="C1.Web.UI.Controls.C1TabControl" tagprefix="cc2" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style="text-align:left">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>


      <cc2:C1TabControl ID="C1TabControl1" runat="server" width="100%"                    
                TextImageRelation="ImageBeforeText" onclienttabmouseenter="clr">
               <TabPages>
                <cc2:C1TabPage ID="C1TabPage1" TabIndex="0" Text="Goods Issue" CssClass="tab">
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                        <ContentTemplate>
                        
                        <div style="padding:7px; border:1px solid silver"><table style="width:100%;"><tr><td class="label" style="text-align: center">
                        <asp:TextBox ID="txtIssueparam" style="display:none" runat="server" Width="30px">
                        </asp:TextBox><asp:TextBox ID="txtunitid" style="display:none" runat="server" Width="30px"></asp:TextBox>Company</td><td class="label" style="text-align: center">Department </td><td class="label" style="text-align: center">Section<asp:TextBox ID="txtunitparam" style="display:none" runat="server" Width="50px"></asp:TextBox></td><td class="label" style="text-align: center">&nbsp;Style<asp:TextBox ID="txtItemid" style="display:none" runat="server" Width="50px"></asp:TextBox></td><td></td><td class="label" style="text-align: center">Issue Note No</td></tr><tr><td style="text-align: center">&nbsp;&nbsp;<asp:DropDownList ID="drpCompany" runat="server" AutoPostBack="True" 
                        CssClass="textbox" OnSelectedIndexChanged="drpCompany_SelectedIndexChanged" 
                        Width="180px"></asp:DropDownList><asp:RequiredFieldValidator ID="drpCompany_RequiredFieldValidator5" 
                        runat="server" ControlToValidate="drpCompany" Display="None" 
                        ErrorMessage="Select Company." ValidationGroup="a">*</asp:RequiredFieldValidator><asp:ValidatorCalloutExtender ID="RequiredFieldValidator5_ValidatorCalloutExtender" 
                        runat="server" Enabled="True"  
                        TargetControlID="drpCompany_RequiredFieldValidator5"></asp:ValidatorCalloutExtender></td><td style="text-align: center">&nbsp;&nbsp;<asp:DropDownList ID="drpdept" runat="server" AutoPostBack="True" 
                        CssClass="textbox" OnSelectedIndexChanged="drpdept_SelectedIndexChanged" 
                        Width="160px"></asp:DropDownList><asp:RequiredFieldValidator ID="drpdept_RequiredFieldValidator1" runat="server" 
                        ControlToValidate="drpdept" Display="None" ErrorMessage="Select Department" 
                        ValidationGroup="a">*</asp:RequiredFieldValidator><asp:ValidatorCalloutExtender ID="drpdept_ValidatorCalloutExtender1" 
                        runat="server" Enabled="True"  
                        TargetControlID="drpdept_RequiredFieldValidator1"></asp:ValidatorCalloutExtender></td><td style="text-align: center"><asp:DropDownList ID="drpSection" runat="server" CssClass="textbox" 
                        Width="150px"></asp:DropDownList><asp:RequiredFieldValidator ID="drpSection_RequiredFieldValidator1" 
                        runat="server" ControlToValidate="drpSection" Display="None" 
                        ErrorMessage="Select Section" ValidationGroup="a">*</asp:RequiredFieldValidator><asp:ValidatorCalloutExtender ID="ValidatorCalloutExtender1" runat="server" 
                        Enabled="True"  
                        TargetControlID="drpSection_RequiredFieldValidator1"></asp:ValidatorCalloutExtender></td><td style="text-align: center"><asp:DropDownList ID="drpStyle" runat="server" AutoPostBack="True" 
                        CssClass="textbox" OnSelectedIndexChanged="drpStyle_SelectedIndexChanged" 
                        Width="180px"></asp:DropDownList></td><td>&nbsp;&nbsp;<asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" 
                        OnCheckedChanged="CheckBox1_CheckedChanged" Text="Filter by Style No" 
                        CssClass="label" /></td><td><asp:TextBox ID="txtIssuenote" runat="server" CssClass="textbox" Width="120px"></asp:TextBox></td></tr></table></div>
                        
                        
                        <div style="padding:7px; border:1px solid silver; margin-top:5px"><table style="width: 100%;"><tr><td style="text-align: right; font-size: 10px; font-family: Tahoma">Main Category</td><td style="width:230px" align="left"><asp:DropDownList ID="drpMaincat" runat="server" AutoPostBack="True" 
                        CssClass="textbox" OnSelectedIndexChanged="drpMaincat_SelectedIndexChanged" 
                        Width="200px"></asp:DropDownList><asp:RequiredFieldValidator ID="drpMaincat_RequiredFieldValidator1" 
                        runat="server" ControlToValidate="drpMaincat" Display="None" 
                        ErrorMessage="Select Main Category" ValidationGroup="a">*</asp:RequiredFieldValidator><asp:ValidatorCalloutExtender ID="drpMaincat_ValidatorCalloutExtender2" 
                        runat="server" Enabled="True"  
                        TargetControlID="drpMaincat_RequiredFieldValidator1"></asp:ValidatorCalloutExtender></td><td style="text-align: right; font-size: 10px; font-family: Tahoma; width: 60px;">&nbsp;Size </td><td align="left"><asp:TextBox ID="txtSize" runat="server" CssClass="textbox" Enabled="False" 
                        Width="170px"></asp:TextBox></td><td style="text-align: right; font-size: 10px; font-family: Tahoma">Article</td><td align="left"><asp:TextBox ID="txtArticle" runat="server" CssClass="textbox" Enabled="False" 
                        Width="180px"></asp:TextBox></td><td style="text-align: right; font-size: 10px; font-family: Tahoma">Issue Qty</td><td align="left">
                        
                        <asp:TextBox ID="txtQty" onkeyup="CalculateIssueValue();" runat="server" Width="70px" CssClass="textbox"></asp:TextBox><asp:FilteredTextBoxExtender ID="txtQty_FilteredTextBoxExtender" runat="server" 
                        Enabled="True" TargetControlID="txtQty" ValidChars=".1234567890"></asp:FilteredTextBoxExtender><asp:RequiredFieldValidator ID="txtQty_RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtQty" Display="None" ErrorMessage="Enter Quantity" 
                        ValidationGroup="a">*</asp:RequiredFieldValidator><asp:ValidatorCalloutExtender ID="txtQty_ValidatorCalloutExtender2" 
                        runat="server" Enabled="True"  
                        TargetControlID="txtQty_RequiredFieldValidator1">
                        </asp:ValidatorCalloutExtender></td></tr><tr><td style="text-align: right; font-size: 10px; font-family: Tahoma">Sub Category</td><td align="left"><asp:DropDownList ID="drpSubcat" runat="server" AutoPostBack="True" 
                        CssClass="textbox" OnSelectedIndexChanged="drpSubcat_SelectedIndexChanged" 
                        Width="200px"></asp:DropDownList><asp:RequiredFieldValidator ID="drpSubcat_RequiredFieldValidator1" 
                        runat="server" ControlToValidate="drpSubcat" Display="None" 
                        ErrorMessage="Select Sub Category" ValidationGroup="a">*</asp:RequiredFieldValidator>
                        <asp:ValidatorCalloutExtender ID="drpSubcat_ValidatorCalloutExtender2" 
                        runat="server" Enabled="True"  
                        TargetControlID="drpSubcat_RequiredFieldValidator1"></asp:ValidatorCalloutExtender><input ID="btnstockdtl" runat="server" onclick="vdtlreq();" 
                        style="background-position: center center; font-size: 10px; background-image: url('../gridimage/src.png'); border: none; cursor: pointer" 
                        title="Find Item Stock Details" type="button" value="." />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</input></td>
                    <td style="text-align: right; font-size: 10px; font-family: Tahoma">&nbsp; Color</td><td align="left">
                    <asp:TextBox ID="TxtColor" runat="server" CssClass="textbox" Enabled="False" 
                        Width="170px"></asp:TextBox></td><td style="text-align: right; font-size: 10px; font-family: Tahoma">Dimension</td><td align="left"><asp:TextBox ID="txtDimension" runat="server" CssClass="textbox" 
                        Enabled="False" Width="180px"></asp:TextBox></td><td style="text-align: right; font-size: 10px; font-family: Tahoma">Stock</td><td align="left"><asp:TextBox ID="txtStock" runat="server" CssClass="textbox" Enabled="False" 
                        style="border:1px solid red" Width="70px"></asp:TextBox></td></tr><tr><td style="text-align: right; font-size: 10px; font-family: Tahoma">Item Unit</td><td align="left"><asp:TextBox ID="txtItemunit" runat="server" CssClass="textbox" Enabled="False" 
                        Width="100px"></asp:TextBox></td><td style="text-align: right; font-size: 10px; font-family: Tahoma">Brand</td><td align="left"><asp:TextBox ID="txtBrand" runat="server" CssClass="textbox" Enabled="False" 
                        Width="170px"></asp:TextBox></td><td style="text-align: right; font-size: 10px; font-family: Tahoma">Issue Unit</td><td align="left"><asp:DropDownList ID="drpIssueunit" runat="server" AutoPostBack="True" 
                        CssClass="textbox" OnSelectedIndexChanged="drpIssueunit_SelectedIndexChanged" 
                        Width="120px"></asp:DropDownList><asp:TextBox ID="txtStcheck" style="display:none" runat="server" CssClass="textbox" Width="50px"></asp:TextBox></td><td>&nbsp;</td><td align="left"><asp:Button ID="btnAddItem" style="margin-left:5px" runat="server" Font-Size="10px" 
                        OnClick="btnAddItem_Click" Text="Add" ValidationGroup="a" Width="60px" /></td></tr></table></div>
                        
                        <div style="padding:3px; border:1px solid silver; margin-top:5px; height:310px; overflow:auto"><asp:GridView ID="grdIssuedetails" runat="server" AutoGenerateColumns="False" 
            CssClass="mGrid"><AlternatingRowStyle BackColor="#CAEEFF" /><Columns><asp:BoundField DataField="styleno" HeaderText="Style No" /><asp:TemplateField HeaderText="Maincategory"><ItemTemplate><asp:Label ID="lblMaincatid" runat="server" Text='<%# Eval("Maincatcode") %>' 
                            Visible="false"></asp:Label><asp:Label ID="lblSubcatid" runat="server" Text='<%# Eval("Subcatcode") %>' 
                            Visible="false"></asp:Label><asp:Label ID="lblItemid" runat="server" Text='<%# Eval("ItemCode") %>' 
                            Visible="false"></asp:Label><asp:Label ID="lblUnitid" runat="server" Text='<%# Eval("unitID") %>' 
                            Visible="false"></asp:Label><asp:Label ID="lblunit" runat="server" Text='<%# Eval("Unit") %>' 
                            Visible="false"></asp:Label><asp:Label ID="lblunitparam" runat="server" Text='<%# Eval("unitparam") %>' 
                            Visible="false"></asp:Label><asp:Label ID="lblStyle" runat="server" Text='<%# Eval("styleid") %>' 
                            Visible="false"></asp:Label><asp:Label ID="lblMaincat" runat="server" Text='<%# Eval("Maincat") %>'></asp:Label></ItemTemplate></asp:TemplateField><asp:BoundField DataField="Subcat" HeaderText="Subcategory" /><asp:BoundField DataField="brnd" HeaderText="Brand" /><asp:BoundField DataField="Size" HeaderText="Size" /><asp:BoundField DataField="Color" HeaderText="Color" /><asp:BoundField DataField="Article" HeaderText="Article" /><asp:BoundField DataField="Dimension" HeaderText="Dimension" /><asp:BoundField DataField="Unit" HeaderText="Unit" /><asp:TemplateField HeaderText="Qty"><ItemTemplate><asp:Label ID="lblqty" runat="server" Text='<%# Eval("Qty") %>'></asp:Label></ItemTemplate></asp:TemplateField></Columns><HeaderStyle BackColor="#0086C6" Font-Names="Tahoma" Font-Size="12px" 
                ForeColor="White" Height="22px" /><RowStyle Font-Names="Tahoma" Font-Size="11px" Height="22px" /></asp:GridView></div>
                <div style="text-align:right;"><table style="width:100%;"><tr><td style="width: 380px;">&nbsp;</td><td>Remarks </td><td style="text-align:left"><asp:TextBox ID="txtRemarks" runat="server" CssClass="textbox" MaxLength="200" 
                            TextMode="MultiLine" Width="280px"></asp:TextBox></td><td style="vertical-align:top"><asp:Button ID="btnClear" runat="server" CssClass="button" 
                            OnClick="btnClear_Click" Text="Cancel" Width="100px" /><asp:Button ID="btnSave" runat="server" CssClass="button" 
                            OnClick="btnSave_Click" Text="Save" Width="100px" /><asp:ConfirmButtonExtender ID="btnGeneratesingle_ConfirmButtonExtender" 
                            runat="server" ConfirmText="Do you want to save" Enabled="True" 
                            TargetControlID="btnSave"></asp:ConfirmButtonExtender></td></tr></table><asp:Button ID="btnppadd" style="display:none" runat="server" Text="Button" /><asp:ModalPopupExtender ID="btnppadd_ModalPopupExtender" runat="server" 
                                            DynamicServicePath="" BackgroundCssClass="ModalPopupBG" BehaviorID="ppadditm" CancelControlID="cnclitmpdt" 
                                            OkControlID="cnclitmpdt" Enabled="True" PopupControlID="ppgenpo" 
                                            TargetControlID="btnppadd"></asp:ModalPopupExtender></div>

                        </ContentTemplate>
                    </asp:UpdatePanel>                  
                </cc2:C1TabPage>
                <cc2:C1TabPage ID="C1TabPage2"  TabIndex="1" Text="View Details"  CssClass="tab">                         
                            <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                            <ContentTemplate>                          
                                    <div style="height:520px; overflow:auto"><cc3:C1GridView ID="grdIssuegetAll" runat="server" AllowPaging="True" 
                                        AutoGenerateColumns="False" PageSize="24" 
                                        ShowFilter="True" VisualStylePath="~/C1WebControls/VisualStyles" 
                                        AllowSorting="True" 
                                        VisualStyle="Office2007Blue" DefaultColumnWidth="" CellPadding="0" 
                                             CellSpacing="0" 
                                             Width="100%" 
                                         AllowColSizing="True" onfiltering="grdIssuegetAll_Filtering" 
                                           onpageindexchanging="grdIssuegetAll_PageIndexChanging" 
                                           onsorting="grdIssuegetAll_Sorting"><Columns><cc3:C1TemplateField HeaderText="Report"><ItemTemplate><a onclick="issuerpt('<%# Eval("nIssNo") %>');" style="padding:4px; text-decoration:none" href="#">Report</a></ItemTemplate></cc3:C1TemplateField><cc3:C1TemplateField HeaderText="Issue No" Visible="false"><ItemTemplate><asp:Label ID="lblIssueNo" runat="server" Text='<%# Eval("nIssNo") %>'></asp:Label></ItemTemplate></cc3:C1TemplateField><cc3:C1BoundField DataField="nIssNo" HeaderText="Issued No" 
                                                SortExpression="nIssNo"></cc3:C1BoundField><cc3:C1BoundField DataField="cDeptname" HeaderText="Department Name" 
                                                SortExpression="cDeptname"></cc3:C1BoundField><cc3:C1BoundField DataField="cSection_Description"  HeaderText="Section Name" 
                                                SortExpression="cSection_Description"></cc3:C1BoundField><cc3:C1BoundField DataField="dEntDAte" 
                                                ShowFilter="false" DataFormatString="{0:dd-MMM-yyyy}" HtmlEncode="false" HeaderText="Issued Date" 
                                                SortExpression="dEntDAte"></cc3:C1BoundField><cc3:C1BoundField DataField="cuser" HeaderText="Created By" 
                                                SortExpression="cuser"></cc3:C1BoundField></Columns><PagerSettings PageButtonCount="25" Mode="NextPrevious" /><HeaderStyle Wrap="False" /><RowStyle Wrap="False" Height="18px" /><PagerStyle HorizontalAlign="Center" VerticalAlign="Middle" /></cc3:C1GridView></div>                               
                        </ContentTemplate>
                    </asp:UpdatePanel>                     
                               
                </cc2:C1TabPage>
               
               
              
            </TabPages>
                </cc2:C1TabControl>









 
    
    
   
    
    </ContentTemplate>
    </asp:UpdatePanel>
    </div>

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

   
      <script type="text/javascript">

          function CalculateIssueValue() {
              var Stock = $("[id$='txtStock']").val();
              var ItmPrm = $("[id$='txtunitparam']").val();
              var IssuPrm = $("[id$='txtIssueparam']").val();
              var issueQty = $("[id$='txtQty']").val();
              
              var IssueQuantity = 0;
              var Stk = 0;
              var Balance = 0;

              var totalalue = 0;

              if (Stock.length > 0) {
                  Stk = Stock;
              }
              if (issueQty.length > 0) {
                  if (IssuPrm.length > 0) {

                      IssueQuantity = (parseFloat(issueQty) * parseFloat(IssuPrm)) / parseFloat(ItmPrm);
                     
                  }
                  else {
                      IssueQuantity = parseFloat(issueQty);
                  }
                  if (parseFloat(IssueQuantity) > parseFloat(Stk)) {
                      //alert(issueQty);
                     // $("[id$='txtStock']").style.background = '#E60000';
                      alert("Quantity Cannot Exceed Stock");
                      $("[id$='txtQty']").val('');
                      //$("[id$='txtStock']").style.background = '';
                      $("[id$='txtStock']").focus();
                  }
              }
          }




          function vdtlreq() {
              var compid = $("[id*='drpCompany'] :selected").val();
              var Styleid = $("[id*='drpStyle'] :selected").val();
              var Subcatid = $("[id*='drpSubcat'] :selected").val();
              var Maincat = $("[id*='drpMaincat'] :selected").val();
              var stchk = $("[id*='txtStcheck']").val();
              

              var stl = "0";
              if (Styleid.length > 0) {
                  if (Styleid != "1") {
                      stl = Styleid;
                  }
              }
              if (compid.length > 0) {
                  if (Maincat.length > 0) {
                      if (Subcatid.length > 0) {
                          onunload();
                          var param = compid + "/" + stl + "/" + Subcatid + "/" + Maincat + "/" + stchk;
                          document.getElementById("txtchkjv").value = "0";
                          $("#hdrtxt").html("Items Stock Details");
                          $("#ifupldfile").attr("src", "IssueItm1.aspx?x=" + param + "");
                          var bid = $find('ppadditm');
                          bid.show();
                      }
                  }
              }
              //alert(param);
          }
          function issuerpt(issurno) {
              window.open('IssueRpt.aspx?x=' + issurno + '', 'popup', 'location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')
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

