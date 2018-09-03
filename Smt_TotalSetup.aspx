<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Smt_TotalSetup.aspx.cs" Inherits="Smt_TotalSetup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
    
     <table style="width:100%;">
        <tr>
            <td width="50">
                &nbsp;</td>

            <td>
                &nbsp;</td>

            <td align="center" colspan="3">
            <div 
                    class="MasterSetupHeader">
                <asp:Label ID="Label5" runat="server" 
                   Text="All Master Setup Form"></asp:Label></div>
            </td>

            <td>
                &nbsp;</td>

            <td width="100" height="60">
                &nbsp;</td>

        </tr>
        <tr>
            <td align="right">
                <img alt="" src="gridimage/Direction1.png" title="Direction -->" height="35" />
            </td>

            <td>
                <input id="Button27" type="button" class="MasterSetupBTN" value="Article" />
            </td>
             <td>
                 <input id="ABrand0" type="button" class="MasterSetupBTN" value="Brand" />
            </td>
              <td>
                  <input id="ABuyer0" type="button" class="MasterSetupBTN" value="Buyer" />
            </td>
               <td>
                   <input id="Button28" type="button" class="MasterSetupBTN" value="Bank Info"/>
            </td>
                <td>
                    <input id="AColor0" type="button" class="MasterSetupBTN" value="Color" />
            </td>              
                <td> &nbsp;</td>

        </tr>
         <tr>
             <td>
                 &nbsp;</td>
             <td>
                 <input id="AShade0" type="button" class="MasterSetupBTN" value="Company" />
             </td>
             <td>
                 <input id="Button29" type="button" class="MasterSetupBTN" value="Country" />
             </td>
             <td>
                 <input id="Button30" type="button" class="MasterSetupBTN" value="Currency Type" />
             </td>
             <td>
                 <input id="Button31" type="button" class="MasterSetupBTN" value="Designation" />
             </td>
             <td>
                 <input id="Button32" type="button" class="MasterSetupBTN" value="Department" />
             </td>
             <td>
                 &nbsp;</td>
         </tr>
         <tr>
             <td>
                 &nbsp;</td>
             <td>
                 <input id="Button16" type="button" class="MasterSetupBTN" value="Dimension" />
             </td>
             <td>
                 <input id="Button33" type="button" class="MasterSetupBTN" value="Floor" />
             </td>
             <td>
                 <input id="Button35" type="button" class="MasterSetupBTN" value="Garment Type" />
             </td>
             <td>
                 <input id="Button34" type="button" class="MasterSetupBTN" value="Gmt. Department" />
             </td>
             <td>
                 <input id="Button40" type="button" class="MasterSetupBTN" value="Master Category" 
                        disabled="disabled" />
             </td>
             <td>
                 &nbsp;</td>
         </tr>
         <tr>
             <td>
                 &nbsp;</td>
             <td>
                 <input id="Button41" type="button" class="MasterSetupBTN" value="Main Category" />
             </td>
             <td>
                 <input id="Button47" type="button" class="MasterSetupBTN" value="Payment Mode" />
             </td>
             <td>
                 <input id="Button48" type="button" class="MasterSetupBTN" value="Payment Term" /></td>
             <td>
                <input id="ASeason0" type="button" class="MasterSetupBTN" value="Season" /></td>
             <td>
                <input id="Button52" type="button" class="MasterSetupBTN" value="Style Type" disabled="disabled" /></td>
             <td>
                 &nbsp;</td>
         </tr>
         <tr>
             <td>
                 &nbsp;</td>
             <td>
                 <input id="Button49" type="button" class="MasterSetupBTN" value="Section" />
             </td>
             <td>
                 <input id="Button50" type="button" class="MasterSetupBTN" value="Shade" />
             </td>
             <td>
                 <input id="AStore" type="button" class="MasterSetupBTN" value="Store" />
             </td>
             <td>
                 <input id="Button51" type="button" class="MasterSetupBTN" value="Sub Category" />
             </td>
             <td>
                <input id="Button56" type="button" class="MasterSetupBTN" value="Storage Plan" /></td>
             <td>
                 &nbsp;</td>
         </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <input id="Button53" type="button" class="MasterSetupBTN" value="Supplier" />
            </td>
            <td>
                <input id="Button54" type="button" class="MasterSetupBTN" value="Unit" />
            </td>
            <td valign="top">
              
                <input id="Button61" type="button" class="MasterSetupBTN" value="Line" />
              
            </td>
            <td valign="top">
                <input id="Button62" type="button" class="MasterSetupBTN" value="Building Unit" />
            </td>
            <td valign="top">
                <input id="Button63" type="button" class="MasterSetupBTN" value="Learning Curve" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="vertical-align:top">
                <input id="Button64" type="button" class="MasterSetupBTN" value="Buyer Account" />
            </td>
            <td style="vertical-align:top">
                <input id="Button65" class="MasterSetupBTN" type="button" 
                    value="Unit Group" />
            </td>
            <td valign="top">
            </td>
            <td valign="top" align="left" colspan="2">
                <input id="Button57" type="button" class="MasterSetupBTN" value="New User" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <input id="Button59" type="button" class="MasterSetupBTN" value="User Group" />
                <br />
                <input id="Button58" type="button" class="MasterSetupBTN" value="Button Permission" />
                &nbsp;
                <br />
                <br />
            </td>
            <td height="130"> &nbsp;</td>
        </tr>
    </table>

    
    
    </ContentTemplate>
    </asp:UpdatePanel>
   
    
    
<%--    <script src="jquery/jquery-ui.min.js" type="text/javascript"></script>--%>
    <script src="jquery/Master_Setup.js" type="text/javascript"></script>
    
    <div id="DByuer" class="POPUPPanel">
    <div id="POPUPHDR">
    <div class="POPUPHeaderText">Add Buyer</div>
    <div class="POPUPClose"></div>
    </div>  
       <iframe id="POPUPIFrame" width="800px" height="530px" src=""></iframe> 
    </div>   
     

</asp:Content>
