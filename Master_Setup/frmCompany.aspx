<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmCompany.aspx.cs" Inherits="Master_Setup_frmCompany" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
   <link href="../css/Master_Setup.css" rel="stylesheet" type="text/css" />
    <script src="../jquery/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script src="../jquery/Master_SetupFolder.js" type="text/javascript"></script>
</head>
<body onload="blinkColor()">
    <form id="form1" runat="server">
      <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <table style="width: 700px;">
                    <tr>
                        <td align="right"  
                            style="margin:5px; padding:5px; border:1px solid #99ccff; background-color:#F9F9F9">
                            <table style="width: 100%;">
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="Label1" runat="server" CssClass="label" Text="Company Name"></asp:Label>
                                    </td>
                                    <td align="left" width="230px">
                                        <asp:TextBox ID="txtCompanyname" runat="server" CssClass="textbox" 
                                            MaxLength="40" onclick="clearlabel('lblErrormsg');" Width="200px"></asp:TextBox>
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="Label2" runat="server" CssClass="label" Text="Address 1"></asp:Label>
                                    </td>
                                    <td align="left" rowspan="2" valign="top">
                                        <asp:TextBox ID="txtAddress1" runat="server" CssClass="textbox" Height="40px" 
                                            MaxLength="100" onclick="clearlabel('lblErrormsg');" TextMode="MultiLine" 
                                            Width="196px"></asp:TextBox>
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="Label4" runat="server" CssClass="label" Text="Address 2"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtAddress2" runat="server" CssClass="textbox" MaxLength="50" 
                                            onclick="clearlabel('lblErrormsg');" Width="200px"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                            ControlToValidate="txtCompanyname" Display="None" 
                                            ErrorMessage="Enter Company Name" ValidationGroup="a">*</asp:RequiredFieldValidator>
                                        <asp:ValidatorCalloutExtender ID="RequiredFieldValidator1_ValidatorCalloutExtender" 
                                            runat="server" Enabled="True" TargetControlID="RequiredFieldValidator1">
                                        </asp:ValidatorCalloutExtender>
                                    </td>
                                    <td align="left">
                                        <asp:Button ID="btnSave" runat="server" CssClass="button" 
                                            onclick="btnSave_Click" Text="Save" ValidationGroup="a" Width="90px" />
                                        <asp:Button ID="btnClear" runat="server" CssClass="button" 
                                            onclick="btnClear_Click" Text="Clear" Width="90px" />
                                        <asp:ConfirmButtonExtender ID="btnSave_ConfirmButtonExtender" runat="server" 
                                            ConfirmText="Do you want to save this data?" Enabled="True" 
                                            TargetControlID="btnSave">
                                        </asp:ConfirmButtonExtender>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblid" runat="server" Visible="False"></asp:Label>
                                    </td>
                                    <td align="left" colspan="2">
                                        <asp:Label ID="lblErrormsg" runat="server"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                            </td>
                    </tr>
                    <tr>
                        <td height="350px" valign="top">
                            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                                AutoGenerateColumns="False" AutoGenerateSelectButton="True" CssClass="mGrid" 
                                DataKeyNames="nCompanyID" 
                                onrowcommand="GridView1_RowCommand" PageSize="18" Width="100%" 
                                onpageindexchanging="GridView1_PageIndexChanging">
                                <AlternatingRowStyle CssClass="grdAltr" />
                                <Columns>
                                    <asp:TemplateField Visible="false">
                                        <ItemTemplate>
                                            <asp:Label ID="lblid" runat="server" Text='<%# Eval("nCompanyID") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="cCmpName" HeaderText="Company Name" 
                                        SortExpression="cCmpName" />
                                    <asp:BoundField DataField="cAdd1" HeaderText="Address 1" 
                                        SortExpression="cAdd1" />
                                    <asp:BoundField DataField="cAdd2" HeaderText="Address 2" 
                                        SortExpression="cAdd2" />
                                </Columns>
                                <HeaderStyle CssClass="grdHdr" />
                                <PagerSettings FirstPageImageUrl="~/gridimage/_fst.png" FirstPageText="First" 
                                    LastPageImageUrl="~/gridimage/_lst.png" LastPageText="Last" 
                                    Mode="NextPreviousFirstLast" NextPageImageUrl="~/gridimage/_next.png" 
                                    NextPageText="Next" PreviousPageImageUrl="~/gridimage/_Prev.png" 
                                    PreviousPageText="Previous" />
                                <PagerStyle CssClass="grdHdr" Height="18px" Width="22px" />
                                <RowStyle CssClass="grdRow" />
                                <SelectedRowStyle CssClass="SelectedRow" />
                            </asp:GridView>
                           
                        </td>
                    </tr>
                </table>
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>

