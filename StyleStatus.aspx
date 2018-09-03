<%@ Page Title="" maintainscrollpositiononpostback="true" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="StyleStatus.aspx.cs" Inherits="StyleStatus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style type="text/css">
body
{
    margin-bottom:40px;   
 }
</style>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
    <div style="text-align:right; margin-right:20px">
     <a href="#" class="print" rel="pntdv">Print</a>
    </div>
    <div id="pntdv">
    
    <div class="pnlmain">
    <div class="pnlheader">Style Information</div>
    <div>
    <table style="width:100%;">
                        <tr>
                            <td align="right">
                                <asp:Label ID="Label1" runat="server" Text="Style No" Font-Size="10pt"></asp:Label>
                            </td>
                            <td align="left">
                                <asp:DropDownList ID="drpStyleno" runat="server" 
                                    Width="200px" AutoPostBack="True" 
                                    onselectedindexchanged="drpStyleno_SelectedIndexChanged" 
                                    CssClass="dropdownlist" TabIndex="1">
                                </asp:DropDownList>                     
                               
                            </td>
                            <td align="right">
                                <asp:Label ID="Label5" runat="server" Text="Brand" Font-Size="10pt"></asp:Label>
                            </td>
                            <td style="margin-left: 40px">
                                <asp:TextBox ID="txtBrand" runat="server" Width="200px" 
                                    Enabled="False" CssClass="textbox"></asp:TextBox>
                            </td>
                            <td align="right">
                                &nbsp;</td>
                            <td style="text-align:left; width: 100px;">
                                <asp:CheckBox ID="chkassort" runat="server" Enabled="False" Text="Assortment" />
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:Label ID="Label2" runat="server" Text="Buyer" Font-Size="10pt"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtBuyer" runat="server" Width="200px" 
                                    Enabled="False" CssClass="textbox"></asp:TextBox>
                            </td>
                            <td align="right">
                                <asp:Label ID="Label6" runat="server" Text="Garment Type" Font-Size="10pt"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtGarmenttype" runat="server" Width="200px" 
                                    Enabled="False" CssClass="textbox"></asp:TextBox>
                            </td>
                            <td align="right">
                                &nbsp;</td>
                            <td style="text-align: left; width: 100px;">
                                
                                <asp:CheckBox ID="chkbom" runat="server" Enabled="False" Text="BOM" />
                                
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:Label ID="Label3" runat="server" Text="Season" Font-Size="10pt"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtSeason" runat="server" Width="200px" Enabled="False" 
                                    CssClass="textbox"></asp:TextBox>
                            </td>
                            <td align="right">
                                <asp:Label ID="Label7" runat="server" Text="Garment Division" Font-Size="10pt"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtGarmentDpt" runat="server" Width="200px" 
                                    Enabled="False" CssClass="textbox"></asp:TextBox>
                            </td>
                            <td align="right">&nbsp;</td>
                            <td style="text-align: left; width: 100px;">
                                <asp:CheckBox ID="chkpo" runat="server" Enabled="False" Text="PO" />
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:Label ID="Label4" runat="server" Text="Store" Font-Size="10pt"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtStore" runat="server" Width="150px" 
                                    Enabled="False" CssClass="textbox"></asp:TextBox>
                            </td>
                            <td align="right">
                                <asp:Label ID="Label15" runat="server" Font-Size="10pt" Text="Ord Qty"></asp:Label>
                            </td>
                            <td valign="middle">
                                <asp:TextBox ID="txtOrdqtysum" runat="server" CssClass="textbox" 
                                    Enabled="False" Width="60px"></asp:TextBox>
                            </td>
                            <td align="center">
                           
                            </td>
                            <td style="text-align: left; width: 100px;">
                                <asp:CheckBox ID="chkgrn" runat="server" Enabled="False" Text="GRN" />
                            </td>
                        </tr>
                    </table>
    </div>
  </div>
    <div>
    <div style="float:left; width:350px">
     <asp:Panel ID="pnlDelivery" Visible="false" CssClass="pnlmain" runat="server">
    <div class="pnlheader">Delivery Details</div>
    <div style="min-height:30px; max-height:600px; width:350px; overflow:auto">
    <asp:GridView ID="grdDelivery" runat="server" AutoGenerateColumns="false"                             
                             ShowFooter="True" Width="100%" 
                             CssClass="mGrid">
                             <AlternatingRowStyle CssClass="gridrowAlternaterow" />
                         <Columns>
                         <asp:BoundField DataField="cPoNum" HeaderText="PO NO" />
                          <asp:BoundField DataField="cOrderNu" HeaderText="Lot" />                          
                           <asp:BoundField DataField="nOrdQty" HeaderText="Qty" />
                           <asp:BoundField DataField="Cmode" HeaderText="Ship Mode" />
                           <asp:BoundField DataField="ShipDt" HtmlEncode="false" DataFormatString="{0:dd/MM/yyyy}" HeaderText="X-Fty Date" />
                         </Columns>
                             <FooterStyle CssClass="gridheader" />
                             <HeaderStyle CssClass="gridheader" Wrap="False" />
                             <RowStyle Wrap="False" CssClass="gridrow" />
                         </asp:GridView>
                     
    </div>    
   
     </asp:Panel>



  <asp:Panel ID="pnlassortment" Visible="false" CssClass="pnlmain" runat="server">
    <div class="pnlheader">Assortment Details</div>
    <div style="min-height:30px; max-height:600px; width:350px; overflow:auto">
    <asp:GridView ID="grdStylesummery" runat="server" AutoGenerateColumns="false" 
                             OnRowDataBound="grdStylesummery_RowDataBound" 
                             OnPreRender="grdStylesummery_PreRender" ShowFooter="True" Width="100%" 
                             CssClass="mGrid">
                             <AlternatingRowStyle CssClass="gridrowAlternaterow" />
                         <Columns>
                         <asp:BoundField DataField="cPoNum" HeaderText="PO NO" />
                          <asp:BoundField DataField="cShiId" HeaderText="Lot" />
                          <asp:BoundField DataField="cColour" HeaderText="Color" />
                           <asp:BoundField DataField="ntot" HeaderText="Total Qty" />
                         </Columns>
                             <FooterStyle CssClass="gridheader" />
                             <HeaderStyle CssClass="gridheader" Wrap="False" />
                             <RowStyle Wrap="False" CssClass="gridrow" />
                         </asp:GridView>
                     
    </div>    
   
     </asp:Panel>




    
    </div>
    <div style="float:right; width:670px; padding-bottom:20px">

     <asp:Panel ID="pnlBOM" Visible="false" CssClass="pnlmain" runat="server">    
    <div class="pnlheader">BOM Details</div>
    <div style="min-height:30px; max-height:1000px; width:668px; overflow:auto">
   <asp:GridView ID="grdBOM" AutoGenerateColumns="false" 
                          runat="server" ShowFooter="True" Width="100%" CssClass="mGrid"                         
                          >
                      <Columns>
                      <asp:BoundField DataField="cMainCategory" HeaderText="Main Category" />
                      <asp:BoundField DataField="cItemDes" HeaderText="Item" />
                      <asp:BoundField DataField="cArticle" HeaderText="Article" />
                      <asp:BoundField DataField="cDimen" HeaderText="Dimension" />                      
                      <asp:BoundField DataField="nCom" HeaderText="Consumption" />
                      <asp:BoundField DataField="nWst" HeaderText="Wastage" />
                      <asp:BoundField DataField="nUprice" HeaderText="Rate" />
                      <asp:BoundField DataField="nValue" HeaderText="Value"  />
                      </Columns>
                      <AlternatingRowStyle CssClass="gridrowAlternaterow" />
                          <FooterStyle CssClass="gridheader" />
                          <RowStyle Wrap="False" CssClass="gridrow" />
                          <HeaderStyle CssClass="gridheader" />
                      </asp:GridView>
                     
    </div>    
      </asp:Panel>

    
    <asp:Panel ID="pnlPOdtl" Visible="false" CssClass="pnlmain" runat="server">    
    <div class="pnlheader">PO Details</div>
    <div style="min-height:30px; max-height:1000px; width:668px; overflow:auto">
   <asp:GridView ID="grdPOPrintingDetail" AutoGenerateColumns="false" 
                          runat="server" ShowFooter="True" Width="100%" CssClass="mGrid" 
                          onprerender="grdPOPrintingDetail_PreRender" 
                          onrowdatabound="grdPOPrintingDetail_RowDataBound">
                      <Columns>
                      <asp:BoundField DataField="nPO" HeaderText="Supplier PO" />
                      <asp:BoundField DataField="cPoNum" HeaderText="Buyer PO" />
                      <asp:BoundField DataField="cMmCat" HeaderText="Main Category" />
                      <asp:BoundField DataField="cDes" HeaderText="Sub Category" />                      
                      <asp:BoundField DataField="cLot" HeaderText="Lot" />
                      <asp:BoundField DataField="cSupName" HeaderText="Supplier" />
                      <asp:BoundField DataField="cUserFullname" HeaderText="Created By" />
                      <asp:BoundField DataField="dEntdate" HeaderText="Created Date" HtmlEncode="false" DataFormatString="{0:dd/MM/yyyy}" />
                      </Columns>
                      <AlternatingRowStyle CssClass="gridrowAlternaterow" />
                          <FooterStyle CssClass="gridheader" />
                          <RowStyle Wrap="False" CssClass="gridrow" />
                          <HeaderStyle CssClass="gridheader" />
                      </asp:GridView>
                     
    </div>    
      </asp:Panel>
    <asp:Panel ID="pnlGRN" Visible="false" CssClass="pnlmain" runat="server">
       
  <div class="pnlheader">Goods Received</div>
  <div style="min-height:30px; max-height:500px; width:668px; overflow:auto">
  
  <asp:GridView ID="grdgrn" AutoGenerateColumns="false" 
                          runat="server" ShowFooter="True" Width="668px" CssClass="mGrid">
                      <Columns>
                      <asp:BoundField DataField="nGrnNo" HeaderText="GRN NO" />
                      <asp:BoundField DataField="nValue" HeaderText="Value" />
                      <asp:BoundField DataField="cSupName" HeaderText="Supplier" />
                      
                      </Columns>
                      <AlternatingRowStyle CssClass="gridrowAlternaterow" />
                          <FooterStyle CssClass="gridheader" />
                          <RowStyle Wrap="False" CssClass="gridrow" />
                          <HeaderStyle CssClass="gridheader" />
                      </asp:GridView>
  
  
  </div>
   </asp:Panel>
    </div>
    </div>

    </div>
  
    </ContentTemplate>
    </asp:UpdatePanel>

    <script src="jquery/Print.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $('.print').live("click",function () {
                var container = $(this).attr('rel');
                $('#' + container).printArea();
                return false;
            });

        });
    </script>
</asp:Content>
