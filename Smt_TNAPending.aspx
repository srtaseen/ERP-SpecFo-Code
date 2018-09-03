<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Smt_TNAPending.aspx.cs" Inherits="Smt_TNAPending" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
.headerText
{
display:block;
height:128px;
width:128px;
vertical-align:bottom;
-webkit-transform: rotate(-90deg); 
-moz-transform: rotate(-90deg); 
-o-transform: rotate(-90deg); 
filter: progid:DXImageTransform.Microsoft.BasicImage(rotation=3); 
}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel4" runat="server">
        <ContentTemplate>
        <div >
            <table style="width:100%;">
                <tr>
                    <td>
                       <div style="margin-top:5px; border-bottom:1px solid silver; padding-bottom:10px">
      X-Fty Date From
        <asp:TextBox ID="txtFromdate" runat="server" CssClass="textbox" Enabled="False" 
            Width="80px"></asp:TextBox>
         <asp:CalendarExtender ID="txtoriginalrcvd_CalendarExtender" runat="server" 
                                                                      Enabled="True" Format="dd-MMM-yyyy" PopupButtonID="cal5" 
                                                                      TargetControlID="txtFromdate" PopupPosition="TopLeft">
                                                                  </asp:CalendarExtender>
        <asp:ImageButton ID="cal5" runat="server" CssClass="Caaldr" Height="10px" ImageUrl="~/images/calendar.gif" TabIndex="12" />
        &nbsp;to
        <asp:TextBox ID="txtTodate" runat="server" CssClass="textbox" Enabled="False" 
            Width="80px"></asp:TextBox>
         <asp:CalendarExtender ID="CalendarExtender1" runat="server" 
                                                                      Enabled="True" Format="dd-MMM-yyyy" PopupButtonID="cal6" 
                                                                      TargetControlID="txtTodate" PopupPosition="TopLeft">
                                                                  </asp:CalendarExtender>
        <asp:ImageButton ID="cal6" runat="server" CssClass="Caaldr" Height="10px" 
            ImageUrl="~/images/calendar.gif" TabIndex="12" />
                           &nbsp; Action Type
                           <asp:DropDownList ID="drpActionType" runat="server" CssClass="textbox" 
                               Width="200px">
                           </asp:DropDownList>
                           &nbsp;
        <asp:Button ID="btnSearch" runat="server" Text="Search" onclick="btnSearch_Click" CssClass="button" Width="70px" />
       
         <a href="#" style="padding:1px 15px; background-color:#87DED8; text-decoration:none; width:70px; border:1px solid silver;" class="print" rel="dvprnt">Print</a>
        <asp:TextBox ID="txtdeptid" runat="server" Visible="False"></asp:TextBox>
</div>
                       </td>
                </tr>
                <tr>
                    <td>
                    <div style="position:fixed; width:100%; left:7px; right:10px; text-align:center; margin-right:10px; overflow:auto">
                    <div id="dvprnt" style="height:400px; overflow:auto; text-align:center">

                        <asp:GridView ID="grdstatus" AutoGenerateColumns="false" 
                            runat="server"  onrowdatabound="grdstatus_RowDataBound" 
                            onprerender="grdstatus_PreRender" >
                            <AlternatingRowStyle Font-Size="9px" />
                        <Columns>
                        <asp:BoundField DataField="cStyleNo" HeaderText="Style No" />
                        <asp:BoundField DataField="cPoNum" HeaderText="PO No" />
                        <asp:TemplateField>
                        <ItemTemplate>
                            <table style="width:100%">
                            <tr>
                            <td style="text-align:left; border-right:1px solid black; width:50%"><asp:Label ID="lbl1" runat="server" Text="" Font-Bold="True"></asp:Label></td>
                            <td style="text-align:right; width:50%"><asp:Label ID="lbla1" Font-Bold="True" runat="server" Text=""></asp:Label>
                                
                                <asp:Label ID="lblStyleid" Visible="false" runat="server" Text='<%# Eval("Styleid") %>'></asp:Label>
                                <asp:Label ID="lblLot" Visible="false" runat="server" Text='<%# Eval("Lot") %>'></asp:Label>

                            </td>
                            </tr>
                            </table>
                        </ItemTemplate>                        
                        </asp:TemplateField>
                         <asp:TemplateField>
                        <ItemTemplate>
                            <table style="width:100%">
                            <tr>
                            <td style="text-align:left; border-right:1px solid black; width:50%">
                            <asp:Label ID="lbl2" runat="server" Font-Bold="True" Text=""></asp:Label></td>
                            <td style="text-align:right;"><asp:Label ID="lbla2" Font-Bold="True" runat="server" Text=""></asp:Label>
                            
                            </td>
                            </tr>
                            </table>
                        </ItemTemplate>
                       
                        </asp:TemplateField>
                        <asp:TemplateField>
                        <ItemTemplate>
                            <table style="width:100%">
                            <tr>
                            <td style="text-align:left; border-right:1px solid black; width:50%"><asp:Label ID="lbl3" runat="server" Text=""></asp:Label></td>
                            <td style="text-align:right;"><asp:Label ID="lbla3" Font-Bold="True" runat="server" Text=""></asp:Label>
                           
                            </td>
                            </tr>
                            </table>
                        </ItemTemplate>                       
                        </asp:TemplateField>


                        <asp:TemplateField>
                        <ItemTemplate>
                            <table style="width:100%">
                            <tr>
                            <td style="text-align:left; border-right:1px solid black; width:50%"><asp:Label ID="lbl4" Font-Bold="True" runat="server" Text=""></asp:Label></td>
                            <td style="text-align:right;"><asp:Label ID="lbla4" Font-Bold="True" runat="server" Text=""></asp:Label>
                            
                            </td>
                            </tr>
                            </table>
                        </ItemTemplate>                       
                        </asp:TemplateField>


                        <asp:TemplateField>
                        <ItemTemplate>
                            <table style="width:100%">
                            <tr>
                            <td style="text-align:left; border-right:1px solid black; width:50%"><asp:Label ID="lbl5" Font-Bold="True" runat="server" Text=""></asp:Label></td>
                            <td style="text-align:right;"><asp:Label ID="lbla5" Font-Bold="True" runat="server" Text=""></asp:Label>
                            
                            </td>
                            </tr>
                            </table>
                        </ItemTemplate>                       
                        </asp:TemplateField>


                        <asp:TemplateField>
                        <ItemTemplate>
                            <table style="width:100%">
                            <tr>
                            <td style="text-align:left; border-right:1px solid black; width:50%"><asp:Label ID="lbl6" runat="server" Text=""></asp:Label></td>
                            <td style="text-align:right;"><asp:Label ID="lbla6" runat="server" Text=""></asp:Label>
                            
                            </td>
                            </tr>
                            </table>
                        </ItemTemplate>                       
                        </asp:TemplateField>


                        <asp:TemplateField>
                        <ItemTemplate>
                            <table style="width:100%">
                            <tr>
                            <td style="text-align:left; border-right:1px solid black; width:50%"><asp:Label ID="lbl7" runat="server" Text=""></asp:Label></td>
                            <td style="text-align:right;"><asp:Label ID="lbla7" runat="server" Text=""></asp:Label>
                             
                            </td>
                            </tr>
                            </table>
                        </ItemTemplate>                       
                        </asp:TemplateField>


                        <asp:TemplateField>
                        <ItemTemplate>
                            <table style="width:100%">
                            <tr>
                            <td style="text-align:left; border-right:1px solid black; width:50%"><asp:Label ID="lbl8" runat="server" Text=""></asp:Label></td>
                            <td style="text-align:right;"><asp:Label ID="lbla8" runat="server" Text=""></asp:Label>
                            </td>
                            </tr>
                            </table>
                        </ItemTemplate>                       
                        </asp:TemplateField>


                         <asp:TemplateField>
                        <ItemTemplate>
                            <table style="width:100%">
                            <tr>
                            <td style="text-align:left; border-right:1px solid black; width:50%"><asp:Label ID="lbl9" runat="server" Text=""></asp:Label></td>
                            <td style="text-align:right;"><asp:Label ID="lbla9" runat="server" Text=""></asp:Label>
                            </td>
                            </tr>
                            </table>
                        </ItemTemplate>                       
                        </asp:TemplateField>

                         <asp:TemplateField>
                        <ItemTemplate>
                            <table style="width:100%">
                            <tr>
                            <td style="text-align:left; border-right:1px solid black; width:50%"><asp:Label ID="lbl10" runat="server" Text=""></asp:Label></td>
                            <td style="text-align:right;"><asp:Label ID="lbla10" runat="server" Text=""></asp:Label>
                            </td>
                            </tr>
                            </table>
                        </ItemTemplate>                       
                        </asp:TemplateField>

                         <asp:TemplateField>
                        <ItemTemplate>
                            <table style="width:100%">
                            <tr>
                            <td style="text-align:left; border-right:1px solid black; width:50%"><asp:Label ID="lbl11" runat="server" Text=""></asp:Label></td>
                            <td style="text-align:right;"><asp:Label ID="lbla11" runat="server" Text=""></asp:Label>
                            </td>
                            </tr>
                            </table>
                        </ItemTemplate>                       
                        </asp:TemplateField>

                         <asp:TemplateField>
                        <ItemTemplate>
                            <table style="width:100%">
                            <tr>
                            <td style="text-align:left; border-right:1px solid black; width:50%"><asp:Label ID="lbl12" runat="server" Text=""></asp:Label></td>
                            <td style="text-align:right;"><asp:Label ID="lbla12" runat="server" Text=""></asp:Label>
                            </td>
                            </tr>
                            </table>
                        </ItemTemplate>                       
                        </asp:TemplateField>

                         <asp:TemplateField>
                        <ItemTemplate>
                            <table style="width:100%">
                            <tr>
                            <td style="text-align:left; border-right:1px solid black; width:50%"><asp:Label ID="lbl13" runat="server" Text=""></asp:Label></td>
                            <td style="text-align:right;"><asp:Label ID="lbla13" runat="server" Text=""></asp:Label>
                            </td>
                            </tr>
                            </table>
                        </ItemTemplate>                       
                        </asp:TemplateField>

                         <asp:TemplateField>
                        <ItemTemplate>
                            <table style="width:100%">
                            <tr>
                            <td style="text-align:left; border-right:1px solid black; width:50%"><asp:Label ID="lbl14" runat="server" Text=""></asp:Label></td>
                            <td style="text-align:right;"><asp:Label ID="lbla14" runat="server" Text=""></asp:Label>
                            </td>
                            </tr>
                            </table>
                        </ItemTemplate>                       
                        </asp:TemplateField>

                         <asp:TemplateField>
                        <ItemTemplate>
                            <table style="width:100%">
                            <tr>
                            <td style="text-align:left;"><asp:Label ID="lbl15" runat="server" Text=""></asp:Label></td>
                            <td style="text-align:right;"><asp:Label ID="lbla15" runat="server" Text=""></asp:Label>
                            </td>
                            </tr>
                            </table>
                        </ItemTemplate>                       
                        </asp:TemplateField>

                         <asp:TemplateField>
                        <ItemTemplate>
                            <table style="width:100%">
                            <tr>
                            <td style="text-align:left; border-right:1px solid black; width:50%"><asp:Label ID="lbl16" runat="server" Text=""></asp:Label></td>
                            <td style="text-align:right;"><asp:Label ID="lbla16" runat="server" Text=""></asp:Label>
                            </td>
                            </tr>
                            </table>
                        </ItemTemplate>                       
                        </asp:TemplateField>

                         <asp:TemplateField>
                        <ItemTemplate>
                            <table style="width:100%">
                            <tr>
                            <td style="text-align:left; border-right:1px solid black; width:50%"><asp:Label ID="lbl17" runat="server" Text=""></asp:Label></td>
                            <td style="text-align:right;"><asp:Label ID="lbla17" runat="server" Text=""></asp:Label>
                            </td>
                            </tr>
                            </table>
                        </ItemTemplate>                       
                        </asp:TemplateField>

                         <asp:TemplateField>
                        <ItemTemplate>
                            <table style="width:100%">
                            <tr>
                            <td style="text-align:left; border-right:1px solid black; width:50%"><asp:Label ID="lbl18" runat="server" Text=""></asp:Label></td>
                            <td style="text-align:right;"><asp:Label ID="lbla18" runat="server" Text=""></asp:Label>
                            </td>
                            </tr>
                            </table>
                        </ItemTemplate>                       
                        </asp:TemplateField>

                         <asp:TemplateField>
                        <ItemTemplate>
                            <table style="width:100%">
                            <tr>
                            <td style="text-align:left; border-right:1px solid black; width:50%"><asp:Label ID="lbl19" runat="server" Text=""></asp:Label></td>
                            <td style="text-align:right;"><asp:Label ID="lbla19" runat="server" Text=""></asp:Label>
                            </td>
                            </tr>
                            </table>
                        </ItemTemplate>                       
                        </asp:TemplateField>

                         <asp:TemplateField>
                        <ItemTemplate>
                            <table style="width:100%">
                            <tr>
                            <td style="text-align:left; border-right:1px solid black; width:50%"><asp:Label ID="lbl20" runat="server" Text=""></asp:Label></td>
                            <td style="text-align:right;"><asp:Label ID="lbla20" runat="server" Text=""></asp:Label>
                            </td>
                            </tr>
                            </table>
                        </ItemTemplate>                       
                        </asp:TemplateField>




                         <asp:TemplateField>
                        <ItemTemplate>
                            <table style="width:100%">
                            <tr>
                            <td style="text-align:left; border-right:1px solid black; width:50%"><asp:Label ID="lbl21" runat="server" Text=""></asp:Label></td>
                            <td style="text-align:right;"><asp:Label ID="lbla21" runat="server" Text=""></asp:Label>
                            </td>
                            </tr>
                            </table>
                        </ItemTemplate>                       
                        </asp:TemplateField>
                         <asp:TemplateField>
                        <ItemTemplate>
                            <table style="width:100%">
                            <tr>
                            <td style="text-align:left; border-right:1px solid black; width:50%"><asp:Label ID="lbl22" runat="server" Text=""></asp:Label></td>
                            <td style="text-align:right;"><asp:Label ID="lbla22" runat="server" Text=""></asp:Label>
                            </td>
                            </tr>
                            </table>
                        </ItemTemplate>                       
                        </asp:TemplateField>
                         <asp:TemplateField>
                        <ItemTemplate>
                            <table style="width:100%">
                            <tr>
                            <td style="text-align:left; border-right:1px solid black; width:50%"><asp:Label ID="lbl23" runat="server" Text=""></asp:Label></td>
                            <td style="text-align:right;"><asp:Label ID="lbla23" runat="server" Text=""></asp:Label>
                            </td>
                            </tr>
                            </table>
                        </ItemTemplate>                       
                        </asp:TemplateField>
                         <asp:TemplateField>
                        <ItemTemplate>
                            <table style="width:100%">
                            <tr>
                            <td style="text-align:left; border-right:1px solid black; width:50%"><asp:Label ID="lbl24" runat="server" Text=""></asp:Label></td>
                            <td style="text-align:right;"><asp:Label ID="lbla24" runat="server" Text=""></asp:Label>
                            </td>
                            </tr>
                            </table>
                        </ItemTemplate>                       
                        </asp:TemplateField>
                         <asp:TemplateField>
                        <ItemTemplate>
                            <table style="width:100%">
                            <tr>
                            <td style="text-align:left; border-right:1px solid black; width:50%"><asp:Label ID="lbl25" runat="server" Text=""></asp:Label></td>
                            <td style="text-align:right;"><asp:Label ID="lbla25" runat="server" Text=""></asp:Label>
                            </td>
                            </tr>
                            </table>
                        </ItemTemplate>                       
                        </asp:TemplateField>
                         <asp:TemplateField>
                        <ItemTemplate>
                            <table style="width:100%">
                            <tr>
                            <td style="text-align:left; border-right:1px solid black; width:50%"><asp:Label ID="lbl26" runat="server" Text=""></asp:Label></td>
                            <td style="text-align:right;"><asp:Label ID="lbla26" runat="server" Text=""></asp:Label>
                            </td>
                            </tr>
                            </table>
                        </ItemTemplate>                       
                        </asp:TemplateField>
                         <asp:TemplateField>
                        <ItemTemplate>
                            <table style="width:100%">
                            <tr>
                            <td style="text-align:left; border-right:1px solid black; width:50%"><asp:Label ID="lbl27" runat="server" Text=""></asp:Label></td>
                            <td style="text-align:right;"><asp:Label ID="lbla27" runat="server" Text=""></asp:Label>
                            </td>
                            </tr>
                            </table>
                        </ItemTemplate>                       
                        </asp:TemplateField>
                         <asp:TemplateField>
                        <ItemTemplate>
                            <table style="width:100%">
                            <tr>
                            <td style="text-align:left; border-right:1px solid black; width:50%"><asp:Label ID="lbl28" runat="server" Text=""></asp:Label></td>
                            <td style="text-align:right;"><asp:Label ID="lbla28" runat="server" Text=""></asp:Label>
                            </td>
                            </tr>
                            </table>
                        </ItemTemplate>                       
                        </asp:TemplateField>
                         <asp:TemplateField>
                        <ItemTemplate>
                            <table style="width:100%">
                            <tr>
                            <td style="text-align:left; border-right:1px solid black; width:50%"><asp:Label ID="lbl29" runat="server" Text=""></asp:Label></td>
                            <td style="text-align:right;"><asp:Label ID="lbla29" runat="server" Text=""></asp:Label>
                            </td>
                            </tr>
                            </table>
                        </ItemTemplate>                       
                        </asp:TemplateField>
                         <asp:TemplateField>
                        <ItemTemplate>
                            <table style="width:100%">
                            <tr>
                            <td style="text-align:left; border-right:1px solid black; width:50%"><asp:Label ID="lbl30" runat="server" Text=""></asp:Label></td>
                            <td style="text-align:right;"><asp:Label ID="lbla30" runat="server" Text=""></asp:Label>
                            </td>
                            </tr>
                            </table>
                        </ItemTemplate>                       
                        </asp:TemplateField>




                        </Columns>
                            <HeaderStyle BackColor="#006699" Font-Size="10px" ForeColor="White" 
                                Height="22px" />
                            <RowStyle BackColor="#DFF4FF" Font-Size="9px" Wrap="False" />
                        </asp:GridView>
                        </div>
                        <div style="text-align:left">
                        <b style="color:black; background-color:Red">Total Red : </b><asp:Label ID="txtpending" runat="server" Text=""></asp:Label><br />
                        <b style="color:black; background-color:Yellow"> Total Yellow :</b><asp:Label ID="lblyellow" runat="server" Text=""></asp:Label>
                        </div>
                        </div>
                        
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    <script src="jquery/Print.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $('.print').live("click", function () {
                var container = $(this).attr('rel');
                $('#' + container).printArea();
                return false;
            });

        });
    </script>
</asp:Content>


