<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmCurrencyType.aspx.cs" Inherits="Master_Setup_frmCurrencyType" %>


<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
      <script src="../jquery/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script src="../jquery/Master_SetupFolder.js" type="text/javascript"></script>
    <link href="../css/Master_Setup.css" rel="stylesheet" type="text/css" />
</head>
<body onload="blinkColor();">
    <form id="form1" runat="server">
      <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <table style="width: 700px;">
                    <tr>
                        <td style="margin:5px; padding:5px; border:1px solid #99ccff; background-color:#F9F9F9">
                            <table style="width: 100%;">
                                <tr>
                                    <td align="right">
                                        &nbsp;
                                        <asp:Label ID="Label1" runat="server" CssClass="label" Text="Currency Code"></asp:Label>
                                    </td>
                                    <td width="230px">
                                        &nbsp;
                                        <asp:TextBox ID="txtCode" runat="server" CssClass="textbox" MaxLength="20" 
                                            onclick="clearlabel('lblErrormsg');" Width="200px"></asp:TextBox>                                            

                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                            ControlToValidate="txtCode" Display="None" ErrorMessage="Enter Currency Code" 
                                            ValidationGroup="a">*</asp:RequiredFieldValidator>
                                        <asp:ValidatorCalloutExtender ID="RequiredFieldValidator1_ValidatorCalloutExtender" 
                                            runat="server" Enabled="True" TargetControlID="RequiredFieldValidator1">
                                        </asp:ValidatorCalloutExtender>
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        &nbsp;
                                        <asp:Label ID="Label2" runat="server" CssClass="label" Text="Description"></asp:Label>
                                    </td>
                                    <td>
                                        &nbsp;
                                        <asp:TextBox ID="txtType" runat="server" CssClass="textbox" MaxLength="20" 
                                            onclick="clearlabel('lblErrormsg');" Width="200px"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                            ControlToValidate="txtType" Display="None" ErrorMessage="Enter Description" 
                                            ValidationGroup="a">*</asp:RequiredFieldValidator>
                                        <asp:ValidatorCalloutExtender ID="RequiredFieldValidator3_ValidatorCalloutExtender" 
                                            runat="server" Enabled="True" TargetControlID="RequiredFieldValidator3">
                                        </asp:ValidatorCalloutExtender>
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        &nbsp;
                                        <asp:Label ID="Label3" runat="server" CssClass="label" Text="Exchange Rate"></asp:Label>
                                    </td>
                                    <td>
                                        &nbsp;
                                        <asp:TextBox ID="txtrate" runat="server" CssClass="textbox" MaxLength="5" 
                                            onclick="clearlabel('lblErrormsg');" Width="100px"></asp:TextBox>
                                            <asp:FilteredTextBoxExtender ID="txtrate_FilteredTextBoxExtender" 
                                                                      runat="server" Enabled="True" TargetControlID="txtrate" 
                                                                      ValidChars="0123456789.">
                                                                  </asp:FilteredTextBoxExtender>
                                    </td>
                                    <td>
                                        &nbsp;
                                        <asp:Button ID="btnSave" runat="server" CssClass="button" 
                                            onclick="btnSave_Click" Text="Save" ValidationGroup="a" Width="90px" />
                                        <asp:ConfirmButtonExtender ID="btnSave_ConfirmButtonExtender" runat="server" 
                                            ConfirmText="Do you want to Save this data?" Enabled="True" 
                                            TargetControlID="btnSave">
                                        </asp:ConfirmButtonExtender>
                                        <asp:Button ID="btnClear" runat="server" CssClass="button" 
                                            onclick="btnClear_Click" Text="Clear" Width="90px" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        <asp:Label ID="lblErrormsg" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                           </td>
                    </tr>
                    <tr>
                        <td height="350px" valign="top">
                            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                                AutoGenerateColumns="False" AutoGenerateSelectButton="True" CssClass="mGrid" 
                                DataKeyNames="cCurCode" 
                                onrowcommand="GridView1_RowCommand" PageSize="20" Width="100%">
                                <AlternatingRowStyle CssClass="grdAltr" />
                                <Columns>
                                    <asp:BoundField DataField="cCurCode" HeaderText="Currency Code" ReadOnly="True" 
                                        SortExpression="cCurCode" />
                                    <asp:BoundField DataField="cCurdes" HeaderText="Description" 
                                        SortExpression="cCurdes" />
                                    <asp:BoundField DataField="nExgRate" HeaderText="Exchange Rate" 
                                        SortExpression="nExgRate" />
                                </Columns>
                                <HeaderStyle CssClass="grdHdr" />
                                <PagerSettings FirstPageImageUrl="~/gridimage/_fst.png" FirstPageText="First" 
                                    LastPageImageUrl="~/gridimage/_lst.png" LastPageText="Last" 
                                    Mode="NextPreviousFirstLast" NextPageImageUrl="~/gridimage/_next.png" 
                                    NextPageText="Next" PreviousPageImageUrl="~/gridimage/_Prev.png" 
                                    PreviousPageText="Previous" />
                                <PagerStyle CssClass="grdHdr" Height="18px" Width="22px" />
                                <RowStyle CssClass="grdRow" />
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

