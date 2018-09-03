<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Smt_Mer_Costing_Apprv.aspx.cs" Inherits="Smt_Mer_Costing_Apprv" %>

<%@ Register Assembly="C1.Web.UI.Controls.4" Namespace="C1.Web.UI.Controls.C1GridView"
    TagPrefix="cc3" %>
    <%@ Register assembly="C1.Web.UI.Controls.4" namespace="C1.Web.UI.Controls.C1TabControl" tagprefix="cc2" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="height:5px"></div>
    <asp:UpdatePanel ID="updcostappv" runat="server">
    <ContentTemplate>    
            <cc2:C1TabControl ID="C1TabControl1" runat="server" width="100%"                    
                TextImageRelation="ImageBeforeText" onclienttabmouseenter="clr">
                    <TabPages>
                            <cc2:C1TabPage ID="C1TabPage1" TabIndex="0" Text="For Approval" CssClass="tab">
                           <div class="pnlmain" style="margin:5px;">
                            <div style="height:480px;">
                             <cc3:C1GridView ID="grdForapp" runat="server" AllowPaging="True" 
                                        AutoGenerateColumns="False" PageSize="22" 
                                        ShowFilter="True" VisualStylePath="~/C1WebControls/VisualStyles" 
                                        AllowSorting="True" AllowColMoving="True" 
                                        VisualStyle="Office2007Blue" DefaultColumnWidth="" CellPadding="0" 
                                             CellSpacing="0" 
                                             Width="100%" AllowColSizing="True" EnableTheming="False" 
                                    OnFiltering="grdForapp_Filtering" OnPageIndexChanging="grdForapp_PageIndexChanging" 
                                            
                                              >
                                        <Columns>
                                        <cc3:C1TemplateField HeaderText="Report">
                                        <ItemTemplate>
                                           <a style="text-decoration:none; padding-left:5px; padding-right:5px" onclick="nzrptcst(<%# Eval("StyleID") %>)" href="#">Report</a>                                        
                                        </ItemTemplate>
                                        </cc3:C1TemplateField>
                                       
                                        <cc3:C1TemplateField HeaderText="Edit">
                                        <ItemTemplate>
                                                     <a style="text-decoration:none; padding-left:5px; padding-right:5px" href="NazCostsheet.aspx?x=<%# Eval("StyleID") %>" style="text-decoration:none; padding-right:5px" href="NazCostsheet.aspx" >Edit</a>                         
                                        </ItemTemplate>
                                        </cc3:C1TemplateField>
                                        
                                        <cc3:C1TemplateField HeaderText="Select">
                                            <ItemTemplate>
                                            <asp:CheckBox ID="chkSelectforappv" Width="25px" runat="server" />
                                                <asp:Label ID="lblponoforapp" Visible="false" runat="server" Text='<%# Eval("StyleID") %>'></asp:Label>                                            
                                            </ItemTemplate>
                                            </cc3:C1TemplateField>
                                             <cc3:C1BoundField DataField="cStyleNo" ShowFilter="true" HeaderText="Style No" 
                                                SortExpression="cStyleNo">
                                            </cc3:C1BoundField>
                                                                                
                                            <cc3:C1BoundField DataField="Orderno" HeaderText="Order No" 
                                                SortExpression="Orderno">
                                            </cc3:C1BoundField>
                                            <cc3:C1BoundField DataField="OrdQty" HeaderText="Order Qty" 
                                                SortExpression="OrdQty">
                                            </cc3:C1BoundField>                                           
                                            <cc3:C1BoundField DataField="UnitPrice"  HeaderText="Unit Price" 
                                                SortExpression="UnitPrice">
                                            </cc3:C1BoundField>
                                            <cc3:C1BoundField DataField="Entdt" DataFormatString="{0:dd-MMM-yyyy}" ShowFilter="false" HeaderText="Created Date" 
                                                SortExpression="Entdt">
                                            </cc3:C1BoundField>
                                             <cc3:C1BoundField DataField="Entby" ShowFilter="false" HeaderText="Created By" 
                                                SortExpression="Entby">
                                            </cc3:C1BoundField>
                                           
                                                                                   
                                        </Columns>
                                        <PagerSettings PageButtonCount="25" Mode="NextPreviousFirstLast" />
                                               <HeaderStyle Wrap="False" />
                                               <RowStyle Wrap="False" Height="18px" />
                                           <PagerStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    </cc3:C1GridView>  
                            </div>
                           </div>
                           <div class="pnlmain" style="margin:5px; text-align:right; padding:5px;">
                               <asp:Button ID="btnReject" runat="server" Text="Reject" CssClass="button" 
                                   Width="100px" OnClick="btnReject_Click" />
                               <asp:Button ID="btnApprove" runat="server" CssClass="button" 
                                   OnClick="btnApprove_Click" Text="Approve" Width="100px" />
                           </div>
                  
                            </cc2:C1TabPage>
                            <cc2:C1TabPage ID="C1TabPage2"  TabIndex="1" Text="Approved"  CssClass="tab">
                                 <div class="pnlmain" style="margin:5px;">
                            <div style="height:480px;">
                             <cc3:C1GridView ID="grdApproved" runat="server" AllowPaging="True" 
                                        AutoGenerateColumns="False" PageSize="22" 
                                        ShowFilter="True" VisualStylePath="~/C1WebControls/VisualStyles" 
                                        AllowSorting="True" AllowColMoving="True" 
                                        VisualStyle="Office2007Blue" DefaultColumnWidth="" CellPadding="0" 
                                             CellSpacing="0" 
                                             Width="100%" AllowColSizing="True" EnableTheming="False" 
                                    OnFiltering="grdApproved_Filtering" OnPageIndexChanging="grdApproved_PageIndexChanging" 
                                            
                                              >
                                        <Columns>
                                        <cc3:C1TemplateField HeaderText="Report">
                                        <ItemTemplate>
                                            <a style="text-decoration:none; padding-left:5px; padding-right:5px" onclick="nzrptcst(<%# Eval("StyleID") %>)" href="#">Report</a> 
                                                                                   
                                        </ItemTemplate>
                                        </cc3:C1TemplateField>
                                        
                                        <cc3:C1TemplateField HeaderText="Select">
                                            <ItemTemplate>
                                            <asp:CheckBox ID="chkSelectapv" Width="25px" runat="server" />
                                                <asp:Label ID="lblstlidappv" Visible="false" runat="server" Text='<%# Eval("StyleID") %>'></asp:Label>
                                            
                                            </ItemTemplate>
                                            </cc3:C1TemplateField>
                                             <cc3:C1BoundField DataField="cStyleNo" ShowFilter="true" HeaderText="Style No" 
                                                SortExpression="cStyleNo">
                                            </cc3:C1BoundField>
                                                                                
                                            <cc3:C1BoundField DataField="Orderno" HeaderText="Order No" 
                                                SortExpression="Orderno">
                                            </cc3:C1BoundField>
                                            <cc3:C1BoundField DataField="OrdQty" HeaderText="Order Qty" 
                                                SortExpression="OrdQty">
                                            </cc3:C1BoundField>                                           
                                            <cc3:C1BoundField DataField="UnitPrice"  HeaderText="Unit Price" 
                                                SortExpression="UnitPrice">
                                            </cc3:C1BoundField>
                                            <cc3:C1BoundField DataField="Entdt" DataFormatString="{0:dd-MMM-yyyy}" ShowFilter="false" HeaderText="Created Date" 
                                                SortExpression="Entdt">
                                            </cc3:C1BoundField>
                                             <cc3:C1BoundField DataField="Entby" ShowFilter="false" HeaderText="Created By" 
                                                SortExpression="Entby">
                                            </cc3:C1BoundField>

                                            <cc3:C1BoundField DataField="App_dt" DataFormatString="{0:dd-MMM-yyyy}" ShowFilter="false" HeaderText="Approved Date" 
                                                SortExpression="App_dt">
                                            </cc3:C1BoundField>
                                             <cc3:C1BoundField DataField="App_by" ShowFilter="false" HeaderText="Approved By" 
                                                SortExpression="App_by">
                                            </cc3:C1BoundField>
                                           
                                                                                   
                                        </Columns>
                                        <PagerSettings PageButtonCount="25" Mode="NextPreviousFirstLast" />
                                               <HeaderStyle Wrap="False" />
                                               <RowStyle Wrap="False" Height="18px" />
                                           <PagerStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    </cc3:C1GridView>  
                            </div>
                           </div>
                           <div class="pnlmain" style="margin:5px; text-align:right; padding:5px;">
                               <asp:Button ID="btnrework" runat="server" Text="Rework" CssClass="button" 
                                   Width="100px" OnClick="btnrework_Click" />
                           </div>
                                  
                </cc2:C1TabPage>
                            <cc2:C1TabPage ID="C1TabPage3"  TabIndex="2"  Text="Rejected" CssClass="tab">
                       <div class="pnlmain" style="margin:5px;">
                            <div style="height:480px;">
                             <cc3:C1GridView ID="grdCncl" runat="server" AllowPaging="True" 
                                        AutoGenerateColumns="False" PageSize="22" 
                                        ShowFilter="True" VisualStylePath="~/C1WebControls/VisualStyles" 
                                        AllowSorting="True" AllowColMoving="True" 
                                        VisualStyle="Office2007Blue" DefaultColumnWidth="" CellPadding="0" 
                                             CellSpacing="0" 
                                             Width="100%" AllowColSizing="True" EnableTheming="False" 
                                    OnFiltering="grdCncl_Filtering" OnPageIndexChanging="grdCncl_PageIndexChanging" 
                                            
                                              >
                                        <Columns>
                                        <cc3:C1TemplateField HeaderText="Report">
                                        <ItemTemplate>
                                           <a style="text-decoration:none; padding-left:5px; padding-right:5px" onclick="nzrptcst(<%# Eval("StyleID") %>)" href="#">Report</a> 
                                            <asp:Label ID="lblcnclstyle" Visible="false" runat="server" Text='<%# Eval("StyleID") %>'></asp:Label>                            
                                        </ItemTemplate>
                                        </cc3:C1TemplateField>
                                                                              
                                             <cc3:C1BoundField DataField="cStyleNo" ShowFilter="true" HeaderText="Style No" 
                                                SortExpression="cStyleNo">
                                            </cc3:C1BoundField>
                                                                                
                                            <cc3:C1BoundField DataField="Orderno" HeaderText="Order No" 
                                                SortExpression="Orderno">
                                            </cc3:C1BoundField>
                                            <cc3:C1BoundField DataField="OrdQty" HeaderText="Order Qty" 
                                                SortExpression="OrdQty">
                                            </cc3:C1BoundField>                                           
                                            <cc3:C1BoundField DataField="UnitPrice"  HeaderText="Unit Price" 
                                                SortExpression="UnitPrice">
                                            </cc3:C1BoundField>
                                            <cc3:C1BoundField DataField="Entdt" DataFormatString="{0:dd-MMM-yyyy}" ShowFilter="false" HeaderText="Created Date" 
                                                SortExpression="Entdt">
                                            </cc3:C1BoundField>
                                             <cc3:C1BoundField DataField="Entby" ShowFilter="false" HeaderText="Created By" 
                                                SortExpression="Entby">
                                            </cc3:C1BoundField>

                                            <cc3:C1BoundField DataField="App_dt" DataFormatString="{0:dd-MMM-yyyy}" ShowFilter="false" HeaderText="Approved Date" 
                                                SortExpression="App_dt">
                                            </cc3:C1BoundField>
                                             <cc3:C1BoundField DataField="App_by" ShowFilter="false" HeaderText="Approved By" 
                                                SortExpression="App_by">
                                            </cc3:C1BoundField>
                                            
                                           
                                                                                   
                                        </Columns>
                                        <PagerSettings PageButtonCount="25" Mode="NextPreviousFirstLast" />
                                               <HeaderStyle Wrap="False" />
                                               <RowStyle Wrap="False" Height="18px" />
                                           <PagerStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    </cc3:C1GridView>  
                            </div>
                           </div>
                          
                </cc2:C1TabPage>                 
              
                    </TabPages>
                </cc2:C1TabControl>
    </ContentTemplate>
    </asp:UpdatePanel>


    <script type="text/javascript">
        function nzrptcst(stl) {
            window.open('Report_Merchandising/NZCSTRPT.aspx?x=' + stl + '', 'popup', 'location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')
              }
    </script>

</asp:Content>




