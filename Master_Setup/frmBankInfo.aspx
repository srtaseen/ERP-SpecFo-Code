<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmBankInfo.aspx.cs" Inherits="Master_Setup_frmBankInfo" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="../css/Master_Setup.css" rel="stylesheet" type="text/css" />
    <script src="../jquery/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script src="../jquery/Master_SetupFolder.js" type="text/javascript"></script>
</head>
<body onload="blinkColor('lblErrormsg')">
    <form id="form1" runat="server">
      <div>    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <table style="width: 700px;">
                    <tr>
                        <td  align="right" 
                            style="margin:5px; padding:5px; border:1px solid #99ccff; background-color:#F9F9F9">
                            <table style="width: 100%;">
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="Label8" runat="server" CssClass="label" Text="Bank Name"></asp:Label>
                                    </td>
                                    <td align="left" width="230px">
                                        <asp:TextBox ID="txtBankName" runat="server" CssClass="textbox" 
                                            MaxLength="100" onclick="clearlabel('lblErrormsg');" Width="200px"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                            ControlToValidate="txtBankName" Display="None" ErrorMessage="Enter Bank Name" 
                                            ValidationGroup="a">*</asp:RequiredFieldValidator>
                                        <asp:ValidatorCalloutExtender ID="RequiredFieldValidator4_ValidatorCalloutExtender" 
                                            runat="server" Enabled="True" TargetControlID="RequiredFieldValidator4">
                                        </asp:ValidatorCalloutExtender>
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="Label9" runat="server" CssClass="label" Text="Address"></asp:Label>
                                    </td>
                                    <td align="left" rowspan="2" valign="top">
                                      
                                        <asp:TextBox ID="txtAddress" runat="server" CssClass="textbox" MaxLength="200" 
                                            onclick="clearlabel('lblErrormsg');" TextMode="MultiLine" Width="200px"></asp:TextBox>
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="Label10" runat="server" CssClass="label" Text="Telephone No"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtTelephone" runat="server" CssClass="textbox" MaxLength="15" 
                                            onclick="clearlabel('lblErrormsg');" Width="200px"></asp:TextBox>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="Label11" runat="server" CssClass="label" Text="Fax No"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtFax" runat="server" CssClass="textbox" MaxLength="50" 
                                            onclick="clearlabel('lblErrormsg');" Width="200px"></asp:TextBox>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="Label12" runat="server" CssClass="label" Text="Country"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:DropDownList ID="drpcountry" runat="server" CssClass="textbox" 
                                            Width="200px">
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                            ControlToValidate="drpcountry" Display="None" ErrorMessage="Select Country" 
                                            ValidationGroup="a">*</asp:RequiredFieldValidator>
                                        <asp:ValidatorCalloutExtender ID="RequiredFieldValidator5_ValidatorCalloutExtender" 
                                            runat="server" Enabled="True" TargetControlID="RequiredFieldValidator5">
                                        </asp:ValidatorCalloutExtender>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="Label13" runat="server" CssClass="label" Text="Bank Swift Code"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtSwiftCode" runat="server" CssClass="textbox" MaxLength="50" 
                                            onclick="clearlabel('lblErrormsg');" Width="200px"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                            ControlToValidate="txtSwiftCode" Display="None" ErrorMessage="Enter Swift Code" 
                                            ValidationGroup="a">*</asp:RequiredFieldValidator>
                                        <asp:ValidatorCalloutExtender ID="RequiredFieldValidator6_ValidatorCalloutExtender" 
                                            runat="server" Enabled="True" TargetControlID="RequiredFieldValidator6">
                                        </asp:ValidatorCalloutExtender>
                                    </td>
                                    <td align="left">
                                        <asp:Button ID="btnSave" runat="server" CssClass="button" 
                                            onclick="btnSave_Click" Text="Save" ValidationGroup="a" Width="90px" />
                                        <asp:Button ID="btnClear" runat="server" CssClass="button" 
                                            onclick="btnClear_Click" Text="Clear" Width="90px" />
                                        <asp:ConfirmButtonExtender ID="btnSave_ConfirmButtonExtender" runat="server" 
                                            ConfirmText="Do you want to save this Bank?" Enabled="True" 
                                            TargetControlID="btnSave">
                                        </asp:ConfirmButtonExtender>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="lblBankCode" runat="server" Visible="False"></asp:Label>
                                    </td>
                                    <td align="left" colspan="2">
                                        <asp:Label ID="lblErrormsg" runat="server"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                         
                         </td>
                    </tr>
                    <tr>
                        <td  valign="top">
                            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                                AutoGenerateColumns="False" AutoGenerateSelectButton="True" CssClass="mGrid" 
                                DataKeyNames="Bank_Code"  
                                onrowcommand="GridView1_RowCommand" PageSize="12" Width="100%" 
                                onpageindexchanging="GridView1_PageIndexChanging">
                                <AlternatingRowStyle CssClass="grdAltr" />
                                <Columns>
                                    <asp:TemplateField Visible="false">
                                        <ItemTemplate>
                                            <asp:Label ID="lblBcode" runat="server" Text='<%# Eval("Bank_Code") %>'>
                                </asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="Bank_Name" HeaderText="Bank Name" 
                                        SortExpression="Bank_Name" />
                                    <asp:BoundField DataField="Bank_Address" HeaderText="Address" 
                                        SortExpression="Bank_Address" />
                                    <asp:BoundField DataField="Telephone_No" HeaderText="Telephone" 
                                        SortExpression="Telephone_No" />
                                    <asp:BoundField DataField="Fax" HeaderText="Fax" SortExpression="Fax" />
                                    <asp:BoundField DataField="Swift_Code" HeaderText="Swift Code" 
                                        SortExpression="Swift_Code" />
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


