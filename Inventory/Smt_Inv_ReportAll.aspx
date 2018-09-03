<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory/MasterPage.master" AutoEventWireup="true" CodeFile="Smt_Inv_ReportAll.aspx.cs" Inherits="Inventory_Smt_Inv_ReportAll" %>


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
     <b>Inventory Reports</b>
     </div>
     <div>
         <table style="width:100%;">
             <tr>
                 <td style="vertical-align:top; width:500px;">
                     <div id="lst">
                         <table style="width: 100%;">
                             <tr>
                                 <td align="left">
                                     <asp:RadioButton ID="rdStylewise" runat="server" AutoPostBack="True" 
                                         Font-Size="13px" GroupName="a" oncheckedchanged="rdStylewise_CheckedChanged" 
                                         Text="Style Wise Inventory Status" />
                                 </td>
                             </tr>
                             <tr>
                                 <td align="left">
                                     <asp:RadioButton ID="rdMainCatwise" runat="server" AutoPostBack="True" 
                                         Font-Size="13px" GroupName="a" oncheckedchanged="rdMainCatwise_CheckedChanged" 
                                         Text="Stock Balance" />
                                 </td>
                             </tr>
                             <tr>
                                 <td align="left">
                                     <asp:RadioButton ID="rdRowmaterial" runat="server" AutoPostBack="True" 
                                         Font-Size="13px" GroupName="a" oncheckedchanged="rdRowmaterial_CheckedChanged" 
                                         Text="Style Wise Garment Accessories Receiving Details" />
                                 </td>
                             </tr>
                             <tr>
                                 <td align="left">
                                     <asp:RadioButton ID="rdRowmaterialSupplierWise" runat="server" 
                                         AutoPostBack="True" Font-Size="13px" GroupName="a" 
                                         oncheckedchanged="rdRowmaterialSupplierWise_CheckedChanged" 
                                         Text="Supplier Wise Garment Accessories Receiving Details" />
                                 </td>
                             </tr>
                             <tr>
                                 <td align="left">
                                     <asp:RadioButton ID="rdFactoryPurchase" runat="server" AutoPostBack="True" 
                                         Font-Size="13px" GroupName="a" 
                                         oncheckedchanged="rdFactoryPurchase_CheckedChanged" 
                                         Text="Factory Purchase Receiving Details" />
                                 </td>
                             </tr>
                             <tr>
                                 <td align="left">
                                     <asp:RadioButton ID="rdGoodissued2d" runat="server" AutoPostBack="True" 
                                         Font-Size="13px" GroupName="a" oncheckedchanged="rdGoodissued2d_CheckedChanged" 
                                         Text="Goods Issue Note Details" />
                                 </td>
                             </tr>
                             <tr>
                                 <td align="left">
                                     <asp:RadioButton ID="grCmwisegrn" runat="server" AutoPostBack="True" 
                                         Font-Size="13px" GroupName="a" oncheckedchanged="grCmwisegrn_CheckedChanged" 
                                         Text="Company Wise GRN" />
                                 </td>
                             </tr>
                             <tr>
                                 <td align="left">
                                     <asp:RadioButton ID="rdMonwisefabreq" runat="server" AutoPostBack="True" 
                                         Font-Size="13px" GroupName="a" 
                                         oncheckedchanged="rdMonwisefabreq_CheckedChanged" 
                                         Text="Month Wise Fabric Requirement" />
                                 </td>
                             </tr>
                             <tr>
                                 <td align="left">
                                     <asp:RadioButton ID="rdDtwiseacrsrecvdtl" runat="server" AutoPostBack="True" 
                                         Font-Size="13px" GroupName="a" 
                                         
                                         Text="Date wise Fabric Receiving Details." 
                                         oncheckedchanged="rdDtwiseacrsrecvdtl_CheckedChanged" />
                                 </td>
                             </tr>
                             <tr>
                                 <td align="left">
                                     <asp:RadioButton ID="rdReorder" runat="server" AutoPostBack="True" 
                                         Font-Size="13px" GroupName="a" oncheckedchanged="rdReorder_CheckedChanged" 
                                         Text="Item Re-Order Report" />
                                 </td>
                             </tr>
                         </table>
                     </div>
                     </td>
                 <td style="vertical-align:center">
                 <div id="talkbubble">
                
                     <asp:Label ID="lblinfo" runat="server" 
                         Text="Information : </br></br>1.Select Report List.</br>2.Set parameter's Value.</br>3.Click Generate Report Button" 
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
                                   <td align="right" style="text-align: left; width: 100px;">
                                       <asp:Label ID="Label6" runat="server" Font-Size="12px" Text="From Date"></asp:Label>
                                   </td>
                                   <td align="left">
                                       <asp:TextBox ID="txtFormdate" runat="server" CssClass="textbox" Enabled="False"></asp:TextBox>
                                       <asp:CalendarExtender ID="txtFormdate_CalendarExtender" runat="server" 
                                           Enabled="True" Format="dd/MM/yyyy" PopupButtonID="cal1" 
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
                                   <td>
                                       &nbsp;
                                   </td>
                               </tr>
                               <tr>
                                   <td align="right" style="text-align: left">
                                       <asp:Label ID="Label7" runat="server" Font-Size="12px" Text="To Date"></asp:Label>
                                   </td>
                                   <td align="left">
                                       <asp:TextBox ID="txtTodate" runat="server" CssClass="textbox" Enabled="False"></asp:TextBox>
                                       <asp:CalendarExtender ID="txtTodate_CalendarExtender" runat="server" 
                                           Enabled="True" Format="dd/MM/yyyy" PopupButtonID="cal2" 
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
                                   <td>
                                       &nbsp;
                                   </td>
                               </tr>
                               <tr>
                                   <td align="right" style="text-align: left">
                                       <asp:Label ID="Label11" runat="server" Font-Size="12px" Text="Company Name"></asp:Label>
                                   </td>
                                   <td align="left">
                                       <asp:DropDownList ID="drpCompany" runat="server" CssClass="dropdownlist" 
                                           Enabled="False" Width="250px">
                                       </asp:DropDownList>
                                   </td>
                                   <td>
                                       &nbsp;</td>
                               </tr>
                               <tr>
                                   <td align="right" style="text-align: left">
                                       <asp:Label ID="Label8" runat="server" Font-Size="12px" Text="Style No"></asp:Label>
                                   </td>
                                   <td align="left">
                                       <asp:DropDownList ID="drpStyle" runat="server" CssClass="textbox" 
                                           Enabled="False" Width="250px">
                                       </asp:DropDownList>
                                       <asp:RequiredFieldValidator ID="RQStyleNo" runat="server" 
                                           ControlToValidate="drpStyle" Display="None" Enabled="False" 
                                           ErrorMessage="Select Style No" ValidationGroup="a">*</asp:RequiredFieldValidator>
                                       <asp:ValidatorCalloutExtender ID="RQStyleNo_ValidatorCalloutExtender" 
                                           runat="server" Enabled="True" TargetControlID="RQStyleNo">
                                       </asp:ValidatorCalloutExtender>
                                   </td>
                                   <td>
                                       &nbsp;
                                   </td>
                               </tr>
                               <tr>
                                   <td align="right" style="text-align: left">
                                       <asp:Label ID="Label9" runat="server" Font-Size="12px" Text="Main Category"></asp:Label>
                                   </td>
                                   <td align="left">
                                       <asp:DropDownList ID="drpMainCat" runat="server" AutoPostBack="True" 
                                           CssClass="dropdownlist" Enabled="False" 
                                           onselectedindexchanged="drpMainCat_SelectedIndexChanged" Width="250px">
                                       </asp:DropDownList>
                                       <asp:RequiredFieldValidator ID="RQMaincat" runat="server" 
                                           ControlToValidate="drpMainCat" Display="None" Enabled="False" 
                                           ErrorMessage="Select Main Category" ValidationGroup="a">*</asp:RequiredFieldValidator>
                                       <asp:ValidatorCalloutExtender ID="RQMaincat_ValidatorCalloutExtender" 
                                           runat="server" Enabled="True" TargetControlID="RQMaincat">
                                       </asp:ValidatorCalloutExtender>
                                   </td>
                                   <td>
                                       &nbsp;</td>
                               </tr>
                               <tr>
                                   <td align="right" class="style1" style="text-align: left">
                                       <asp:Label ID="Label10" runat="server" Font-Size="12px" Text="Sub Category"></asp:Label>
                                   </td>
                                   <td align="left" class="style1">
                                       <asp:DropDownList ID="drpSubcat" runat="server" CssClass="dropdownlist" 
                                           Enabled="False" Width="250px">
                                       </asp:DropDownList>
                                   </td>
                                   <td class="style1">
                                   </td>
                               </tr>
                               <tr>
                                   <td align="right">
                                       &nbsp;</td>
                                   <td align="left">
                                       &nbsp;</td>
                                   <td>
                                       &nbsp;</td>
                               </tr>
                           </table>
                       </div>
                   </td>
                   <td style="text-align: center;">
                       <asp:Button ID="btnClear" runat="server" CssClass="button" 
                           onclick="btnClear_Click" Text="Clear" Width="100px" />
                       <asp:Button ID="btnGenerate" runat="server" CssClass="button" 
                           onclick="btnGenerate_Click" Text="Generate Report" ValidationGroup="a" 
                           Width="150px" />
                   </td>
                
               </tr>
           </table>
      </div>
    
    
   
    </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

