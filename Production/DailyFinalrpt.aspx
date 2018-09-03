<%@ Page Title="" Language="C#" MasterPageFile="~/Production/MasterPage.master" AutoEventWireup="true" CodeFile="DailyFinalrpt.aspx.cs" Inherits="Production_DailyFinalrpt" %>


<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="padding:8px; font-family:Tahoma; font-size:15px; margin-bottom:20px; 
    margin-top:10px; border-bottom:1px solid silver; border-top:1px solid silver; background-color:#f4f4f4">FINISHING REPORT</div>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
    <div style="height:420px; border-bottom:1px solid silver">
        <table style="width:100%;">
            <tr>
                <td style="width: 120px;">
                    Company</td>
                <td style="width: 350px;" align="left">
                    <asp:DropDownList ID="drpCompany" runat="server" Width="300px">
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="drpCompany" Display="None" ErrorMessage="Select Company" 
                        ValidationGroup="v">*</asp:RequiredFieldValidator>
                    <asp:ValidatorCalloutExtender ID="RequiredFieldValidator1_ValidatorCalloutExtender" 
                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator1">
                    </asp:ValidatorCalloutExtender>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Date</td>
                <td align="left">
                    <asp:TextBox ID="txtDate" runat="server" Enabled="False" Width="120px"></asp:TextBox>
                    <asp:CalendarExtender ID="txtDate_CalendarExtender" runat="server" 
                        Enabled="True" Format="dd-MMM-yyyy" PopupButtonID="cal1" 
                        TargetControlID="txtDate">
                    </asp:CalendarExtender>
                    <img alt="" src="../images/calendar.gif" id="cal1" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtDate" Display="None" ErrorMessage="Enter Production Date" 
                        ValidationGroup="v">*</asp:RequiredFieldValidator>
                    <asp:ValidatorCalloutExtender ID="RequiredFieldValidator2_ValidatorCalloutExtender" 
                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator2">
                    </asp:ValidatorCalloutExtender>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td align="left">
                   
                    <asp:Button ID="btnreport" runat="server" onclick="btnreport_Click" 
                        Text="Daily Finishing Report" ValidationGroup="v" />
                   
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </div>
    <div style="text-align:center; padding-top:4px">
    </div>
    </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

