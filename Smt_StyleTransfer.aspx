<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Smt_StyleTransfer.aspx.cs" Inherits="Smt_StyleTransfer" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
body
{
    margin-bottom:40px;   
 }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
    <div style="padding-bottom:100px;">
<div style="padding:10px; text-align:center; font-family:Arial; font-size:16px; border-bottom:1px solid #3895B6">STYLE TRANSFER</div>
<div style="margin-top:10px;">
<div style="float:left; width:800px; min-height:500px">
<div style=" padding:10px; border-bottom:1px solid #3895B6">
    <table style="width:100%;">
        <tr>
            <td>
                Buyer Name</td>
            <td>
                <asp:DropDownList ID="drpBuyer" runat="server" Width="250px" 
                    AutoPostBack="True" onselectedindexchanged="drpBuyer_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="drpBuyer" Display="None" ErrorMessage="Select Buyer" 
                    ValidationGroup="v">*</asp:RequiredFieldValidator>
                <asp:ValidatorCalloutExtender ID="RequiredFieldValidator1_ValidatorCalloutExtender" 
                    runat="server" Enabled="True" TargetControlID="RequiredFieldValidator1">
                </asp:ValidatorCalloutExtender>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </div>
    <asp:GridView ID="grdStyle" AutoGenerateColumns="false" runat="server" 
        CssClass="mGrid" ShowFooter="True" 
        onrowdatabound="grdStyle_RowDataBound">
    <Columns>
    <asp:TemplateField>
    <ItemTemplate>
        <asp:CheckBox ID="chkselect" runat="server" />
         <asp:Label ID="lblstyle" Visible="false" runat="server" Text='<%# Eval("nStyleID") %>'></asp:Label>
         <asp:Label ID="lblBuyer" Visible="false" runat="server" Text='<%# Eval("nBuyer_ID") %>'></asp:Label>         
    </ItemTemplate>
    </asp:TemplateField>
    <asp:BoundField DataField="cStyleNo" HeaderText="Style No" />    
    <asp:BoundField DataField="cInputDate" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Created Date" />
    <asp:BoundField DataField="cBuyer_Name" HeaderText="Buyer Name" />
    <asp:TemplateField HeaderText="PO NO/T And A">      
    <ItemTemplate>
        <asp:GridView ID="grdpptna" Width="300px" ShowHeader="false" AutoGenerateColumns="false" CssClass="mGrid" runat="server">
        <Columns>
        <asp:BoundField DataField="cPoNum" ItemStyle-Width="200" HeaderText="PO No" />
        <asp:TemplateField>
        <ItemTemplate>
            <asp:DropDownList ID="drptna" CssClass="textboxforgridview" Width="100px" runat="server">
            </asp:DropDownList>
            <asp:Label ID="lblLot" Visible="false" runat="server" Text='<%# Eval("cOrderNu") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        </Columns>
        </asp:GridView>        
    </ItemTemplate>
    </asp:TemplateField>
    </Columns>
        <HeaderStyle CssClass="gridheader" />
        <RowStyle Font-Names="Arial" Font-Size="11px" />
    </asp:GridView>

</div>
<div style="float:right; width:215px;">
<div style="position:fixed; top:100px; border:2px solid #3997B9; width:210px;-webkit-border-radius: 5px;
    -moz-border-radius: 5px;
    border-radius: 5px; background:#EFF7FA">
    <table style="width:100%;">
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="text-align:center;">
                Merchandiser Name</td>
        </tr>
        <tr>
            <td style="text-align:center;">
                <asp:DropDownList ID="drpMerchant" runat="server" CssClass="textbox" 
                    Width="180px">
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="drpMerchant" Display="None" 
                    ErrorMessage="Select Merchandiser" ValidationGroup="v">*</asp:RequiredFieldValidator>
                <asp:ValidatorCalloutExtender ID="RequiredFieldValidator3_ValidatorCalloutExtender" 
                    runat="server" Enabled="True" 
                    TargetControlID="RequiredFieldValidator3">
                </asp:ValidatorCalloutExtender>
            </td>
        </tr>
        <tr>
            <td style="text-align:center;">
                <asp:Button ID="btnSave" runat="server" Text="Transfer" 
                    onclick="btnSave_Click" ValidationGroup="v" />
                <asp:ConfirmButtonExtender ID="btnSave_ConfirmButtonExtender" runat="server" 
                    ConfirmText="Are you sure ?" Enabled="True" TargetControlID="btnSave">
                </asp:ConfirmButtonExtender>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
    </table>

    <div style="position:fixed; top:280px; border:2px solid #F1BAF1; width:195px;-webkit-border-radius: 5px;
    -moz-border-radius: 5px;
    border-radius: 5px; background:#FAE6FA; padding:8px;font-family:Arial; font-size:12px">First Select a Style and than select Merchandiser</div>
    <div style="position:fixed; top:350px; border:2px solid #F1BAF1; width:195px;-webkit-border-radius: 5px;
    -moz-border-radius: 5px;
    border-radius: 5px; background:#FAE6FA; padding:8px; font-family:Arial; font-size:12px">For Setting Time and Action,Select Custom T & A Name For All PO's For a specific style no.</div>
    </div>
  
    </div>
</div>
</div>
    </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>

