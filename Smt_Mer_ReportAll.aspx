<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Smt_Mer_ReportAll.aspx.cs" Inherits="Smt_Mer_ReportAll" %>

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
<script type="text/javascript">
    function datevalidation(sender, args) {
        var str1 = document.getElementById('<%=txtFormdate.ClientID %>').value;
        var str2 = document.getElementById('<%=txtTodate.ClientID %>').value;
        var dt1 = parseInt(str1.substring(0, 2), 10);
        var mon1 = parseInt(str1.substring(3, 5), 10);
        var yr1 = parseInt(str1.substring(6, 10), 10);
        var dt2 = parseInt(str2.substring(0, 2), 10);
        var mon2 = parseInt(str2.substring(3, 5), 10);
        var yr2 = parseInt(str2.substring(6, 10), 10);
        var date1 = new Date(yr1, mon1, dt1);
        var date2 = new Date(yr2, mon2, dt2);
        if (str1 != '' && str2 != '') {

        //month difference
//            var d1Y = date1.getFullYear();
//            var d2Y = date2.getFullYear();
//            var d1M = date1.getMonth();
//            var d2M = date2.getMonth();
//            var dff = (d2M + 12 * d2Y) - (d1M + 12 * d1Y);

            var t2 = date2.getTime();
            var t1 = date1.getTime();

            var dydif= parseInt((t2 - t1) / (24 * 3600 * 1000));
            if (date2 < date1) {
                alert(" To Date cannot be smaller than  From Date");
                document.getElementById('<%=txtTodate.ClientID %>').value='';            
                return false;
            }
            if (parseInt(dydif) > 365) {
                alert(" You cann't select more than a year.");
                document.getElementById('<%=txtTodate.ClientID %>').value = '';
                return false;
            }
          }

//        var one_day = 1000 * 60 * 60 * 24;

//        // Convert both dates to milliseconds
//        var date1_ms = date1.getTime();
//        var date2_ms = date2.getTime();

//        // Calculate the difference in milliseconds
//       var difference_ms = date2_ms - date1_ms;

//        // Convert back to days and return
//        //alert(Math.round(difference_ms / one_day));
//       alert(difference_ms / one_day);



    }
</script>
    <asp:UpdatePanel ID="updmerrpt" runat="server">
    <ContentTemplate>
    <div style="padding:10px; margin-top:5px; text-align:center; color:#1EA7EE; border-bottom:1px solid #98D7F7">
     <b>MERCHANDISING REPORTS</b>
     </div>
    
      <div style="border-bottom:1px solid #98D7F7">
         <table style="width: 100%;">
             <tr>
                 <td width="100px">
                     &nbsp;
                 </td>
                 <td align="center">
                     &nbsp;
                     
                 </td>
                 <td align="center">
                     &nbsp;</td>
                 <td align="center">
                     &nbsp;</td>
                 <td>
                     &nbsp;
                 </td>
             </tr>
             <tr>
                 <td align="right">
                     &nbsp;</td>
                 <td align="left">
                   
                     <asp:RadioButton ID="rdStyleNO" runat="server" AutoPostBack="True" GroupName="a" 
                       
                         Text="Style No" oncheckedchanged="rdStyleNO_CheckedChanged" 
                         CssClass="chkbx" />
                 </td>
                 <td align="left">
                     <asp:RadioButton ID="rdGmtTypeWise" runat="server" AutoPostBack="True" 
                         CssClass="chkbx" GroupName="a" oncheckedchanged="rdGmtTypeWise_CheckedChanged" 
                         Text="Gmt Type Wise Delivery Forcast" Visible="False" />
                 </td>
                 <td align="left">
                     <asp:RadioButton ID="rdMbuyerorder" runat="server" AutoPostBack="True" 
                         CssClass="chkbx" GroupName="a" oncheckedchanged="rdMbuyerorder_CheckedChanged" 
                         Text="Monthwise Buyer Order" />
                 </td>
                 <td>
                     &nbsp;
                 </td>
             </tr>
             <tr>
                 <td align="right">
                     &nbsp;</td>
                 <td align="left">
                     <asp:RadioButton ID="rdD2D" runat="server" AutoPostBack="True" 
                         GroupName="a" Text="Buyer And Gmt Type Wise Delivery Forcast" 
                         oncheckedchanged="rdD2D_CheckedChanged" CssClass="chkbx" />
                 </td>
                 <td align="left">
                     <asp:RadioButton ID="rdActionStatus" runat="server" AutoPostBack="True" 
                         CssClass="chkbx" GroupName="a" oncheckedchanged="rdActionStatus_CheckedChanged" 
                         Text="Action Status Report" />
                 </td>
                 <td align="left">
                     <asp:RadioButton ID="rdWeeklybuyerorder" runat="server" AutoPostBack="True" 
                         CssClass="chkbx" GroupName="a" Text="Weekly Buyer Order" 
                         oncheckedchanged="rdWeeklybuyerorder_CheckedChanged" />
                 </td>
                 <td>
                 </td>
             </tr>
             <tr>
                 <td align="right">
                     &nbsp;</td>
                 <td align="left">
                     <asp:RadioButton ID="rdBuyerWise" runat="server" AutoPostBack="True" 
                         GroupName="a" Text="Buyer Wise Delivery Forcast" 
                         oncheckedchanged="rdBuyerWise_CheckedChanged" CssClass="chkbx" />
                 </td>
                 <td align="left">
                     <asp:RadioButton ID="rdOrderInhand" runat="server" AutoPostBack="True" 
                         CssClass="chkbx" GroupName="a" oncheckedchanged="rdOrderInhand_CheckedChanged" 
                         Text="Order in Hand Report" />
                 </td>
                 <td align="left">
                     <asp:RadioButton ID="rdCostingsummery" runat="server" AutoPostBack="True" 
                         CssClass="chkbx" GroupName="a" 
                         oncheckedchanged="rdCostingsummery_CheckedChanged" 
                         Text="Projected Order Summery" Visible="False" />
                 </td>
                 <td>
                     &nbsp;</td>
             </tr>
             <tr>
                 <td align="right">
                     &nbsp;</td>
                 <td align="left">
                     &nbsp;</td>
                 <td align="left">
                     &nbsp;</td>
                 <td align="left">
                     &nbsp;</td>
                 <td>
                     &nbsp;</td>
             </tr>
             <tr>
                 <td>
                     &nbsp;</td>
                 <td align="left">
                     &nbsp;</td>
                 <td align="left">
                     &nbsp;</td>
                 <td align="left">
                     &nbsp;</td>
                 <td>
                     &nbsp;</td>
             </tr>
         </table>
  
  </div>
      <div style="border-bottom:1px solid #98D7F7">
         <table style="width: 100%;">
             <tr>
                 <td align="right" width="200px">
                     &nbsp;</td>
                 <td align="left" style="width:300px">
                     &nbsp;</td>
                 <td align="left">
                    <%-- <asp:updateprogress ID="updateProgress1" runat="server" 
                                                                    associatedupdatepanelid="updmerrpt">
                                                                    <progresstemplate>
                                                                        <img alt="Loading" height="30px" src="images/activity.gif" /><br />
                                                                        Please wait...
                                                                    </progresstemplate>
                                                                </asp:updateprogress>--%> 
                                                                  </td>
                 <td>
                     &nbsp;</td>
             </tr>
             <tr>
                 <td align="right" width="200px">
                     <asp:Label ID="Label6" runat="server" Text="From Date" CssClass="label"></asp:Label>
                 </td>
                 <td align="left">
                     <asp:TextBox ID="txtFormdate" runat="server" CssClass="textbox" Enabled="False"></asp:TextBox>
                     <asp:CalendarExtender ID="txtFormdate_CalendarExtender" runat="server" 
                         Enabled="True" 
                         Format="dd-MMM-yyyy" PopupButtonID="cal1" 
                         TargetControlID="txtFormdate">
                        
                     </asp:CalendarExtender>
                     <asp:ImageButton ID="cal1" runat="server" CssClass="Caaldr" Enabled="False" 
                         Height="13px" ImageUrl="~/images/calendar.gif" onfocus="ShowCalendar()" 
                         TabIndex="12" />
                     <asp:RequiredFieldValidator ID="RQFormdate" runat="server" 
                         ControlToValidate="txtFormdate" Display="None" Enabled="False" 
                         ErrorMessage="Enter From Date." ValidationGroup="a">*</asp:RequiredFieldValidator>
                     <asp:ValidatorCalloutExtender ID="RQFormdate_ValidatorCalloutExtender" 
                         runat="server" Enabled="True" TargetControlID="RQFormdate">
                     </asp:ValidatorCalloutExtender>
                 </td>
                 <td align="left">
                     &nbsp;</td>
                 <td>
                     &nbsp;
                 </td>
             </tr>
             <tr>
                 <td align="right">
                     <asp:Label ID="Label7" runat="server" Text="To Date" CssClass="label"></asp:Label>
                 </td>
                 <td align="left">
                 
                     <asp:TextBox ID="txtTodate" runat="server" Enabled="False" CssClass="textbox"></asp:TextBox>
                     <asp:CalendarExtender ID="txtTodate_CalendarExtender" runat="server" 
                         Enabled="True" Format="dd-MMM-yyyy" PopupButtonID="cal2" 
                         TargetControlID="txtTodate">
                     </asp:CalendarExtender>
                     <asp:ImageButton ID="cal2" runat="server" CssClass="Caaldr" Enabled="False" 
                         Height="13px" ImageUrl="~/images/calendar.gif" onfocus="ShowCalendar()" 
                         TabIndex="12" />
                 
                     <asp:RequiredFieldValidator ID="RQTodate" runat="server" 
                         ControlToValidate="txtTodate" Display="None" Enabled="False" 
                         ErrorMessage=" Enter To Date" ValidationGroup="a">*</asp:RequiredFieldValidator>
                     <asp:ValidatorCalloutExtender ID="RQTodate_ValidatorCalloutExtender" 
                         runat="server" Enabled="True" TargetControlID="RQTodate">
                     </asp:ValidatorCalloutExtender>
                 
                 </td>
                 <td align="left">
                     &nbsp;</td>
                 <td>
                     &nbsp;
                 </td>
             </tr>
             <tr>
                 <td align="right">
                     <asp:Label ID="Label8" runat="server" Text="Style No" CssClass="label"></asp:Label>
                 </td>
                 <td align="left">
                  
                     <asp:DropDownList ID="drpStyle" runat="server" Enabled="False" Width="250px" 
                         CssClass="textbox">
                     </asp:DropDownList>
                     <asp:RequiredFieldValidator ID="RQStyleNo" runat="server" 
                         ControlToValidate="drpStyle" Display="None" Enabled="False" 
                         ErrorMessage="Select Style No" ValidationGroup="a">*</asp:RequiredFieldValidator>
                     <asp:ValidatorCalloutExtender ID="RQStyleNo_ValidatorCalloutExtender" 
                         runat="server" Enabled="True" TargetControlID="RQStyleNo">
                     </asp:ValidatorCalloutExtender>
                 </td>
                 <td align="left">
                     &nbsp;</td>
                 <td>
                     &nbsp;
                 </td>
             </tr>
             <tr>
                 <td align="right">
                     <asp:Label ID="Label12" runat="server" Text="Buyer" CssClass="label"></asp:Label>
                 </td>
                 <td align="left">
                     <asp:DropDownList ID="drpBuyer" runat="server" CssClass="textbox" 
                         Enabled="False" Width="250px">
                     </asp:DropDownList>
                 </td>
                 <td align="left">
                     &nbsp;</td>
                 <td>
                     &nbsp;</td>
             </tr>
             <tr>
                 <td align="right" class="style1">
                     &nbsp;</td>
                 <td align="left" class="style1">
                     &nbsp;</td>
                 <td align="left" class="style1">
                     &nbsp;</td>
                 <td class="style1">
                     </td>
             </tr>
             <tr>
                 <td align="right">
                     &nbsp;</td>
                 <td align="left">
                     &nbsp;</td>
                 <td align="left">
                     &nbsp;</td>
                 <td>
                     &nbsp;</td>
             </tr>
         </table>
    </div>
  
  <div style="text-align:right; padding-right:10px; padding-top:5px">
         <asp:Button ID="btnClear" runat="server" Width="100px" Text="Clear" 
           onclick="btnClear_Click" CssClass="button" />
         <asp:Button ID="btnGenerate" runat="server" 
             onclick="btnGenerate_Click" Text="Generate Report" ValidationGroup="a" 
             Width="150px" CssClass="button" />
  
   </div>
    </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

