<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Smt_StylemasterOMS.aspx.cs" Inherits="Smt_StylemasterOMS" %>
<%@ Register Assembly="C1.Web.UI.Controls.4" Namespace="C1.Web.UI.Controls.C1GridView"
    TagPrefix="cc3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="margin-top:7px">
 <cc3:C1GridView ID="grdConfirmToApprove" runat="server" AllowPaging="True" 
                                        AutoGenerateColumns="False" PageSize="25" 
                                        ShowFilter="True" VisualStylePath="~/C1WebControls/VisualStyles" 
                                        AllowSorting="True" AllowColMoving="True" 
                                        VisualStyle="Office2007Blue" 
            DefaultColumnWidth="" CellPadding="0" 
                                             CellSpacing="0" 
                                             Width="100%" AllowColSizing="True" 
            EnableTheming="False" onfiltering="grdConfirmToApprove_Filtering" onpageindexchanging="grdConfirmToApprove_PageIndexChanging"                                               
                                            >
                                        <Columns> 
                                         <cc3:C1BoundField DataField="cBuyer_Name" HeaderText="Buyer Name" 
                                                SortExpression="cBuyer_Name">
                                            </cc3:C1BoundField> 
                                        <cc3:C1BoundField DataField="cDispStyleNo"  HeaderText="Contact No" 
                                                SortExpression="Style No">
                                            </cc3:C1BoundField> 
                                            <cc3:C1BoundField DataField="cStyleNo" HeaderText="Style No" 
                                                SortExpression="Style No">
                                            </cc3:C1BoundField>                                                                                  
                                             <cc3:C1BoundField DataField="cPoNum" ShowFilter="true" HeaderText="PO No" 
                                                SortExpression="cPoNum">
                                            </cc3:C1BoundField>                                       
                                            <cc3:C1BoundField DataField="nOrdQty" ShowFilter="false" HeaderText="Ord.Qty" 
                                                SortExpression="nOrdQty">
                                            </cc3:C1BoundField>    
                                            <cc3:C1BoundField DataField="DXfty" HeaderText="Ship Date" DataFormatString="{0:dd/MM/yyyy}" 
                                                SortExpression="DXfty">
                                            </cc3:C1BoundField>                                          
                                                                             
                                        </Columns>
                                        <PagerSettings PageButtonCount="25" Mode="NextPreviousFirstLast" />
                                               <HeaderStyle Wrap="False" />
                                               <RowStyle Wrap="False" Height="18px" />
                                           <PagerStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    </cc3:C1GridView>  
                                       
                                       <%--  <asp:SqlDataSource ID="DSCNF" runat="server" 
                                             ConnectionString="<%$ ConnectionStrings:mconuser %>" 
                                             SelectCommand="Sp_Smt_StyleMaster_OMS" 
                                             SelectCommandType="StoredProcedure">                                            
                                         </asp:SqlDataSource>--%>
                                       
</div>
</asp:Content>


