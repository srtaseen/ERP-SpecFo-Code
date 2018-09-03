<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory/MasterPage.master" AutoEventWireup="true" CodeFile="Smt_Inv_ItemTraker.aspx.cs" Inherits="Inventory_Smt_Inv_ItemTraker" %>

<%@ Register Assembly="C1.Web.UI.Controls.4" Namespace="C1.Web.UI.Controls.C1GridView"
    TagPrefix="cc3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
    <table style="width:100%">
    <tr>
    <td style="width:165px; vertical-align:top;">
    <div style="border:1px solid #77d2ff; margin-top:8px; border-radius:5px; font-family:Tahoma; font-size:11px;">
    <div style="padding:5px; border-bottom:1px solid #77d2ff; background-color:#06aeff;">Search Item</div>
    <div style="padding:5px;">
        <table style="width:100%;">
            <tr>
                <td>
                    Company</td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="drpComp" runat="server" AutoPostBack="True" 
                        onselectedindexchanged="drpComp_SelectedIndexChanged" Width="150px">
                    </asp:DropDownList>
                    </td>
            </tr>
            <tr>
                <td>
                    Main Category</td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="drpMaincat" runat="server" AutoPostBack="True" 
                        onselectedindexchanged="drpMaincat_SelectedIndexChanged" Width="150px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    Sub Category</td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="drpSubCat" runat="server" AutoPostBack="True" 
                        onselectedindexchanged="drpSubCat_SelectedIndexChanged" Width="150px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="height: 220px;">
                    &nbsp;</td>
            </tr>
        </table>
        </div>
    </div>
    </td>
    <td style="vertical-align:top;">
    <div class="pnlmain" style="height:530px; overflow:auto">
<div class="pnlheader">Item Tracker</div>
  <cc3:C1GridView ID="grdItemTracker" runat="server" AllowPaging="True" 
                                        AutoGenerateColumns="False" 
                                        PageSize="24" 
                                        ShowFilter="True" VisualStylePath="~/C1WebControls/VisualStyles" 
                                        AllowSorting="True" AllowColMoving="True" 
                                        VisualStyle="Office2007Blue" 
                                        DefaultColumnWidth="" CellPadding="0" 
                                        CellSpacing="0" Width="100%" AllowColSizing="True" 
                                        onfiltering="grdItemTracker_Filtering" 
                                        
            onpageindexchanging="grdItemTracker_PageIndexChanging" 
            onrowdatabound="grdItemTracker_RowDataBound" >
                                        <Columns> 
                                        <cc3:C1TemplateField HeaderText="E-BIN">
                                        <ItemTemplate>
                                        <asp:LinkButton ID="lnkEBIN" CssClass="link" 
                                                CommandArgument='<%# Eval("nItemCode") %>' runat="server" Text="E-BIN" 
                                                onclick="lnkEBIN_Click"></asp:LinkButton>
                                        </ItemTemplate>
                                        </cc3:C1TemplateField> 
                                         <cc3:C1TemplateField HeaderText="GRN">
                                        <ItemTemplate>
                                        <asp:LinkButton ID="lnkGrn" CssClass="link" 
                                                CommandArgument='<%# Eval("nItemCode") %>' runat="server" Text="GRN" 
                                                onclick="lnkGrn_Click"></asp:LinkButton>
                                        </ItemTemplate>
                                        </cc3:C1TemplateField>  
                                         <cc3:C1TemplateField HeaderText="Issue">
                                        <ItemTemplate>
                                        <asp:LinkButton ID="lnkIssue" CssClass="link" 
                                                CommandArgument='<%# Eval("nItemCode") %>' runat="server" Text="Issue" 
                                                onclick="lnkIssue_Click"></asp:LinkButton>
                                        </ItemTemplate>
                                        </cc3:C1TemplateField>    
                                         <cc3:C1TemplateField  HeaderText="Re-Order">
                                        <ItemTemplate>
                                       <a onclick="getreorder(<%# Eval("nItemCode") %>);" style="text-decoration:none; color:Blue" href="#">Re-order</a>
                                        </ItemTemplate>
                                        </cc3:C1TemplateField>                                                          
                                            <cc3:C1BoundField DataField="cMainCategory" HeaderText="Main Category" 
                                                SortExpression="cMainCategory">
                                            </cc3:C1BoundField>
                                              <cc3:C1BoundField DataField="cDes" ShowFilter="true" HeaderText="Item Description" 
                                                SortExpression="cDes">
                                            </cc3:C1BoundField>                                                                           
                                            <cc3:C1BoundField DataField="cArticle"  HeaderText="Article" 
                                                SortExpression="cArticle">
                                            </cc3:C1BoundField>
                                            <cc3:C1BoundField DataField="cDimen"  HeaderText="Dimension" 
                                                SortExpression="cDimen">
                                            </cc3:C1BoundField>
                                             <cc3:C1BoundField DataField="cSize1"  HeaderText="Size" 
                                                SortExpression="cSize1">
                                            </cc3:C1BoundField>
                                            <cc3:C1BoundField DataField="cColour"  HeaderText="Color" 
                                                SortExpression="cColour">
                                            </cc3:C1BoundField>
                                             <cc3:C1TemplateField HeaderText="Unit">
                                            <ItemTemplate>
                                            <asp:Label ID="lblUnit" style="padding-left:3px; padding-right:3px" runat="server" Text='<%# Eval("cUnitDes") %>'></asp:Label>
                                            </ItemTemplate>
                                            </cc3:C1TemplateField>
                                             <cc3:C1TemplateField HeaderText="Balance">
                                            <ItemTemplate>
                                            <asp:Label ID="lblBalance" style="padding-left:3px; padding-right:3px; color:#119FFF; font-weight:bold; text-align:right" runat="server" Text='<%# Eval("nItemBalQty") %>'></asp:Label>
                                            </ItemTemplate>
                                            </cc3:C1TemplateField>
                                            <%--<cc3:C1BoundField DataField="cCmpName" HeaderText="Company" 
                                                SortExpression="cCmpName">
                                            </cc3:C1BoundField>    --%>                  
                                        </Columns>
                                        <PagerSettings PageButtonCount="25" Mode="NextPrevious" />
                                               <HeaderStyle Wrap="False" />
                                               <RowStyle Wrap="True" Height="18px" />
                                           <PagerStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    </cc3:C1GridView>  
                                       

</div>
    </td>
    </tr>
    </table>

    
    </ContentTemplate>
    </asp:UpdatePanel>
    <script type="text/javascript">
        function getreorder(itmcode) {
            window.open('Reorder.aspx?x=' + itmcode + '', 'popup', 'location=1,status=1;resizable=no,left=0,top=0,scrollbars=1,width=400,height=400')
        }
    </script>
    
</asp:Content>


