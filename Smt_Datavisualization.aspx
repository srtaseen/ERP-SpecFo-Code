<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Smt_Datavisualization.aspx.cs" Inherits="Smt_Datavisualization" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
    <div>
        <table style="width:100%;">
            <tr>
                <td style="width: 50px;">
                    &nbsp;</td>
                <td style="vertical-align: middle; text-align: center">


                    <%--<asp:Chart ID="Chart2" runat="server">
                        <Series>
                            <asp:Series Name="Series1"></asp:Series>
                        </Series>
                        <ChartAreas>
                            <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                        </ChartAreas>
                    </asp:Chart>--%>

      <asp:Chart ID="Chart1" runat="server" Width="500px"  
           Palette="Pastel" >                 

    <Series>              
        <asp:Series Name="Series1" IsVisibleInLegend="true" 
          LegendToolTip="asd" IsXValueIndexed="true" IsValueShownAsLabel="true" XValueMember="cBuyer_Name" YValueMembers="nOrdQty">
        </asp:Series>
    </Series>

    <ChartAreas>
        <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
    </ChartAreas>

</asp:Chart>
                </td>
                <td style="width: 130px; vertical-align: top; text-align: left;">
                <table style="width: 100%;">
                    <tr>
                        <td colspan="2">
                            CHART TYPE</td>
                    </tr>
                    <tr>
                        <td colspan="2">
                <hr class="hr" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButton ID="rdarea" runat="server" Text="Area" GroupName="c" 
                                ValidationGroup="c" AutoPostBack="True" 
                                oncheckedchanged="rdarea_CheckedChanged" />
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButton ID="rdbar" runat="server" Text="Bar" GroupName="c" 
                                ValidationGroup="c" Checked="True" AutoPostBack="True" 
                                oncheckedchanged="rdbar_CheckedChanged" />
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButton ID="rdbubble" runat="server" Text="Bubble" GroupName="c" 
                                ValidationGroup="c" AutoPostBack="True" 
                                oncheckedchanged="rdbubble_CheckedChanged" />
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButton ID="rdcolumn" runat="server" Text="Column" GroupName="c" 
                                ValidationGroup="c" AutoPostBack="True" 
                                oncheckedchanged="rdcolumn_CheckedChanged" />
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButton ID="rdfast" runat="server" Text="FastLine" 
                                GroupName="c" ValidationGroup="c" AutoPostBack="True" 
                                oncheckedchanged="rdfast_CheckedChanged" />
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButton ID="rdfunnel" runat="server" Text="Funnel" GroupName="c" 
                                ValidationGroup="c" AutoPostBack="True" 
                                oncheckedchanged="rdfunnel_CheckedChanged" />
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButton ID="rdline" runat="server" Text="Line" GroupName="c" 
                                ValidationGroup="c" AutoPostBack="True" 
                                oncheckedchanged="rdline_CheckedChanged" />
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButton ID="rdpie" runat="server" Text="Pie" GroupName="c" 
                                ValidationGroup="c" AutoPostBack="True" 
                                oncheckedchanged="rdpie_CheckedChanged" />
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButton ID="rdpoint" runat="server" Text="Point" GroupName="c" 
                                ValidationGroup="c" AutoPostBack="True" 
                                oncheckedchanged="rdpoint_CheckedChanged" />
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButton ID="rdpointandfigr" runat="server" Text="PointAndFigure" 
                                GroupName="c" ValidationGroup="c" AutoPostBack="True" 
                                oncheckedchanged="rdpointandfigr_CheckedChanged" />
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButton ID="rdpolar" runat="server" Text="Polar" GroupName="c" 
                                ValidationGroup="c" AutoPostBack="True" 
                                oncheckedchanged="rdpolar_CheckedChanged" />
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButton ID="rdpyramid" runat="server" Text="Pyramid" GroupName="c" 
                                ValidationGroup="c" AutoPostBack="True" 
                                oncheckedchanged="rdpyramid_CheckedChanged" />
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
                </td>
            </tr>
        </table>
        </div>
        <div>
            <hr />
        </div>
        <div>
            <table style="width:100%;">
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                            <asp:RadioButton ID="rdbuyer" runat="server" Text="Buyer Wise" GroupName="a" />
                            <asp:RadioButton ID="rdCmpany" runat="server" 
                            Text="Company Order Utilization" GroupName="a" />
                        </td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </div>
        <div>
            <hr />
        </div>
        <div>
            <table style="width:100%;">
                <tr>
                    <td>
                        &nbsp;</td>
                    <td style="text-align: right">
                        From Date&nbsp;
                       <asp:TextBox ID="txtFormdate" runat="server"></asp:TextBox>
                    <asp:CalendarExtender ID="txtFormdate_CalendarExtender" runat="server" 
                         Enabled="True" 
                         Format="dd-MMM-yyyy" PopupButtonID="cal1" 
                         TargetControlID="txtFormdate"></asp:CalendarExtender>
                        
                    <asp:ImageButton ID="cal1" runat="server" 
                        ImageUrl="~/images/calendar.gif" />
                        <asp:TextBox ID="txtTodate" runat="server"></asp:TextBox>
                     <asp:CalendarExtender ID="txtTodate_CalendarExtender1" runat="server" 
                         Enabled="True" 
                         Format="dd-MMM-yyyy" PopupButtonID="cal2" 
                         TargetControlID="txtTodate"></asp:CalendarExtender>
                        
                    <asp:ImageButton ID="cal2" runat="server" 
                        ImageUrl="~/images/calendar.gif" />
&nbsp;<asp:Button ID="btnview" runat="server" Text="View Chart" onclick="btnview_Click" />
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </div>
</div>
</asp:Content>

