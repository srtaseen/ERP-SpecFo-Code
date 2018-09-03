<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Smt_Dashboards.aspx.cs" Inherits="Smt_Dashboards" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
            margin-left: 120px;
        }
        .bt
        {
            margin-left:10px;
            -moz-border-radius-topright: 20px;
-webkit-border-top-right-radius: 20px;
-moz-border-radius-bottomright: 20px;
-webkit-border-bottom-right-radius: 20px;
-moz-border-radius-topleft: 20px;
-webkit-border-top-left-radius: 20px;
-moz-border-radius-bottomleft: 20px;
-webkit-border-bottom-left-radius: 20px;
box-shadow: 4px 4px 4px 4px gray;
 
             }
             .bt:hover
        {
            margin-left:10px;
            -moz-border-radius-topright: 20px;
-webkit-border-top-right-radius: 20px;
-moz-border-radius-bottomright: 20px;
-webkit-border-bottom-right-radius: 20px;
-moz-border-radius-topleft: 20px;
-webkit-border-top-left-radius: 20px;
-moz-border-radius-bottomleft: 20px;
-webkit-border-bottom-left-radius: 20px;
box-shadow: 4px 4px 4px 4px green;
background-color:#E1F5FF;
 
             }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel4" runat="server">
        <ContentTemplate>
            <asp:Timer ID="Timer1" runat="server" Interval="30000" OnTick="Timer1_Tick"></asp:Timer>
            <table style="width:100%;">
                <tr>
                    <td>
                        &nbsp;
                    </td>
                     <td>
                        &nbsp;
                    </td>
                     <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td align="center" class="style5">
                        <asp:Button ID="btnMerchantPurchasePO" CssClass="bt" style="cursor:pointer" runat="server" Font-Bold="false" Height="100px" Text="Merchant Purchase Pending PO" Width="250px" PostBackUrl="~/Smt_Mer_POApproval.aspx?tb=2" />
                        <asp:Button ID="btnFactoryPurchasePO" CssClass="bt" style="cursor:pointer" runat="server" Font-Bold="false" Height="100px" Text="Local Purchase Pending PO" Width="250px" PostBackUrl="~/Inventory/Smt_Inv_FactoryPurchase.aspx?tb=2" />
                        <asp:Button ID="btnTna" CssClass="bt" style="cursor:pointer" runat="server" Font-Bold="false" Height="100px" Text="Pending Time &amp; Action List" Width="250px" PostBackUrl="~/Smt_TNAPending.aspx" />
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

