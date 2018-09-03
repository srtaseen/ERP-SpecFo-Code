<%@ Page Title="" Language="C#" MasterPageFile="~/Production/MasterPage.master" AutoEventWireup="true" CodeFile="Cutting_Report.aspx.cs" Inherits="Production_Cutting_Report" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<style type="text/css">

#talkbubble {
 margin-top: 15px;
 margin-left:20px;
 width: 260px;
 background: #FBEDFB;
 position: relative;
 border:1px solid #F8DEF8;
 -moz-border-radius: 14px;
 -webkit-border-radius: 14px; 
 border-radius: 14px;
 padding-top:15px;
 padding-left:30px;
 padding-bottom:15px;
 padding-right:10px;
}
#talkbubble:before {
 content:"";
 position: absolute;
 right: 100%;
 top: 35px;
 width: 0;
 height: 0;
 border-top: 20px solid transparent;
 border-right: 30px solid #FBEDFB;
 border-bottom: 20px solid transparent;
}

#lst {
 margin-top: 5px;
 margin-left:100px;
 width: 400px;

 background: #F3FAFE;
 position: relative;
 border:1px solid #BAE4FA;
 -moz-border-radius: 14px;
 -webkit-border-radius: 14px; 
 border-radius: 14px;
 padding-top:20px;
 padding-left:30px;
 padding-bottom:7px;
}
#lst:before {
 content:"";
 position: absolute;
 left: 80%;
 top:-20px;
 width: 0;
 height: 0;
 border-left: 20px solid transparent;
 border-right: 20px solid transparent;
 border-bottom: 20px solid #F3FAFE;
}
.bx
{
 margin-top: 5px;
 margin-left:100px;
 width: 400px;
 background:#F3FAFE;
 position: relative;
 border:1px solid #BAE4FA;
 -moz-border-radius: 14px;
 -webkit-border-radius: 14px; 
 border-radius: 14px;
 padding-top:20px;
 padding-left:30px;
 padding-bottom:7px;
}
 
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

      <asp:UpdatePanel ID="UpdatePanel4" runat="server">
    <ContentTemplate>
  
     <div style="padding:10px; text-align:center; color:#1EA7EE;">
     <b>Cutting Reports</b>
     </div>
     <div>
         <table style="width:100%;">
             <tr>
                 <td style="vertical-align:top; width:500px;">
                     <div ID="lst">
                         <table style="width: 100%;">
                             <tr>
                                 <td align="left">
                                     &nbsp;</td>
                             </tr>
                             <tr>
                                 <td align="left">
                                     <asp:RadioButton ID="rdDailycutsummery" runat="server" AutoPostBack="True" 
                                         Font-Names="Arial" Font-Size="10px" GroupName="a" 
                                         oncheckedchanged="rdDailycutsummery_CheckedChanged" Text="Daily Cut Summery" />
                                 </td>
                             </tr>
                             <tr>
                                 <td align="left">
                                     <asp:RadioButton ID="rdCuttingd2d" runat="server" AutoPostBack="True" 
                                         Font-Names="Arial" Font-Size="10px" GroupName="a" 
                                         oncheckedchanged="rdCuttingd2d_CheckedChanged" 
                                         Text="Cutting Summery Date To Date" />
                                 </td>
                             </tr>
                             <tr>
                                 <td align="left">
                                     &nbsp;</td>
                             </tr>
                             <tr>
                                 <td align="left">
                                     &nbsp;</td>
                             </tr>
                             <tr>
                                 <td align="left">
                                     &nbsp;</td>
                             </tr>
                         </table>
                     </div>
                     </td>
                 <td style="vertical-align:center">
                 <div id="talkbubble">
                
                     <asp:Label ID="lblinfo" runat="server" 
                         Text="Information : </br></br>1.Select Report List.</br>2.Set parameter's Value.</br></br>-Click Generate Report Button" 
                         ForeColor="#E06DE1"></asp:Label>
                             </div>
                     </td>
             </tr>
         </table>
        </div>
    
    
   
       <div style="margin-top:7px; padding-top:5px">   
           <table style="width:100%;">
               <tr>
                   <td style="width:500px;">
                       <div class="bx">
                           <table style="width: 100%;">
                               <tr>
                                   <td style="text-align: right; font-family: Arial; font-size: 10px;" 
                                       class="label">
                                       From Date</td>
                                   <td style="text-align: left;">
                                       <asp:TextBox ID="txtFormdate" runat="server" CssClass="textbox" Enabled="False" 
                                           Width="80px"></asp:TextBox>
                                       <asp:CalendarExtender ID="txtFormdate_CalendarExtender" runat="server" 
                                           Enabled="True" Format="dd/MM/yyyy" PopupButtonID="cal1" 
                                           TargetControlID="txtFormdate">
                                       </asp:CalendarExtender>
                                       <asp:CalendarExtender ID="txtFormdate_CalendarExtender2" runat="server" 
                                           Enabled="True" Format="dd-MMM-yyyy" PopupButtonID="cal" 
                                           TargetControlID="txtFormdate">
                                       </asp:CalendarExtender>
                                       <asp:ImageButton ID="cal" runat="server" Enabled="False" Height="12px" 
                                           ImageUrl="~/images/calendar.gif" />
                                       <asp:RequiredFieldValidator ID="rqFormdt" runat="server" 
                                           ControlToValidate="txtFormdate" Display="None" ErrorMessage="Enter From Date" 
                                           ValidationGroup="a">*</asp:RequiredFieldValidator>
                                       <asp:ValidatorCalloutExtender ID="rqFormdt_ValidatorCalloutExtender" 
                                           runat="server" Enabled="True" TargetControlID="rqFormdt">
                                       </asp:ValidatorCalloutExtender>
                                   </td>
                                   <td>
                                       &nbsp;</td>
                               </tr>
                               <tr>
                                   <td class="label" 
                                       style="text-align: right; font-family: Arial; font-size: 10px;">
                                       To Date</td>
                                   <td style="text-align: left;">
                                       <asp:TextBox ID="txtTodate" runat="server" CssClass="textbox" Enabled="False" 
                                           Width="80px"></asp:TextBox>
                                       <asp:CalendarExtender ID="txtTodate_CalendarExtender" runat="server" 
                                           Enabled="True" Format="dd/MM/yyyy" PopupButtonID="cal2" 
                                           TargetControlID="txtTodate">
                                       </asp:CalendarExtender>
                                       <asp:CalendarExtender ID="txtTodate_CalendarExtender2" runat="server" 
                                           Enabled="True" Format="dd-MMM-yyyy" PopupButtonID="cal2" 
                                           TargetControlID="txtTodate">
                                       </asp:CalendarExtender>
                                       <asp:ImageButton ID="cal2" runat="server" Enabled="False" Height="12px" 
                                           ImageUrl="~/images/calendar.gif" />
                                       <asp:RequiredFieldValidator ID="rqTodate" runat="server" 
                                           ControlToValidate="txtTodate" Display="None" ErrorMessage="Enter To Date" 
                                           ValidationGroup="a">*</asp:RequiredFieldValidator>
                                       <asp:ValidatorCalloutExtender ID="rqTodate_ValidatorCalloutExtender" 
                                           runat="server" Enabled="True" TargetControlID="rqTodate">
                                       </asp:ValidatorCalloutExtender>
                                       <asp:ValidatorCalloutExtender ID="rqTodate_ValidatorCalloutExtender2" 
                                           runat="server" Enabled="True" TargetControlID="rqTodate">
                                       </asp:ValidatorCalloutExtender>
                                   </td>
                                   <td>
                                       &nbsp;</td>
                               </tr>
                               <tr>
                                   <td class="label" 
                                       style="text-align: right; font-family: Arial; font-size: 10px;">
                                       Company</td>
                                   <td style="text-align: left;">
                                       <asp:DropDownList ID="drpcompany" runat="server" CssClass="textbox" 
                                           Width="200px">
                                       </asp:DropDownList>
                                       <asp:RequiredFieldValidator ID="rdcompany" runat="server" 
                                           ControlToValidate="drpcompany" Display="None" ErrorMessage="Select Company." 
                                           ValidationGroup="a">*</asp:RequiredFieldValidator>
                                       <asp:ValidatorCalloutExtender ID="rdcompany_ValidatorCalloutExtender" 
                                           runat="server" Enabled="True" TargetControlID="rdcompany">
                                       </asp:ValidatorCalloutExtender>
                                       <asp:ValidatorCalloutExtender ID="rdcompany_ValidatorCalloutExtender2" 
                                           runat="server" Enabled="True" TargetControlID="rdcompany">
                                       </asp:ValidatorCalloutExtender>
                                   </td>
                                   <td>
                                       &nbsp;</td>
                               </tr>
                               <tr>
                               <td></td>
                               <td></td>
                               </tr>
                               <tr>
                                   <td>
                                       &nbsp;</td>
                                   <td>
                                       &nbsp;</td>
                               </tr>
                           </table>
                       </div>
                   </td>
                   <td style="text-align: center;">
                       &nbsp;</td>
                
               </tr>
               <tr>
               <td>&nbsp;</td>
               <td>&nbsp;</td>
               </tr>
               <tr>
                   <td style="text-align:center">
                       <asp:Button ID="btnGeneraterpt" runat="server" Enabled="False" Height="40px" 
                           onclick="Button1_Click" Text="Generate Report" ValidationGroup="a" 
                           Width="150px" />
                   </td>
                   <td>
                   </td>
               </tr>
           </table>
      </div>
    
    
   
    </ContentTemplate>
    </asp:UpdatePanel>












    </asp:Content>



