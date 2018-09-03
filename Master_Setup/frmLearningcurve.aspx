<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmLearningcurve.aspx.cs" Inherits="Master_Setup_frmLearningcurve" %>

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
                        <td width="120px" 
                            style="margin:5px; padding:5px; border:1px solid #99ccff; background-color:#F9F9F9">
                       
                            <table style="width:100%;">
                                <tr>
                                    <td align="center">
                                        <asp:Label ID="Label2" runat="server" CssClass="label" Text="Curve Name"></asp:Label>
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="Label6" runat="server" CssClass="label" Text="Day 1(%)"></asp:Label>
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="Label7" runat="server" CssClass="label" Text="Day 2(%)"></asp:Label>
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="Label8" runat="server" CssClass="label" Text="Day 3(%)"></asp:Label>
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="Label9" runat="server" CssClass="label" Text="Day 4(%)"></asp:Label>
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="Label10" runat="server" CssClass="label" Text="Day 5(%)"></asp:Label>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td align="center" width="90px">
                                        <asp:TextBox ID="txtCurvename" runat="server" CssClass="textbox" MaxLength="50" 
                                            onclick="clearlabel('lblErrormsg');" Width="150px"></asp:TextBox>
                                    </td>
                                    <td align="center">
                                        <asp:TextBox ID="txtD1" runat="server" CssClass="textbox" MaxLength="3" 
                                            onclick="clearlabel('lblErrormsg');" Width="50px"></asp:TextBox>
                                            <asp:FilteredTextBoxExtender ID="txtD1_FilteredTextBoxExtender" 
                                                runat="server" Enabled="True" TargetControlID="txtD1" 
                                                ValidChars="0123456789.">
                                            </asp:FilteredTextBoxExtender>
                                    </td>
                                    <td align="center">
                                        <asp:TextBox ID="txtD2" runat="server" CssClass="textbox" MaxLength="3" 
                                            onclick="clearlabel('lblErrormsg');" Width="50px"></asp:TextBox>
                                             <asp:FilteredTextBoxExtender ID="txtD2_FilteredTextBoxExtender1" 
                                                runat="server" Enabled="True" TargetControlID="txtD2" 
                                                ValidChars="0123456789.">
                                            </asp:FilteredTextBoxExtender>
                                    </td>
                                    <td align="center">
                                        <asp:TextBox ID="txtD3" runat="server" CssClass="textbox" MaxLength="3" 
                                            onclick="clearlabel('lblErrormsg');" Width="50px"></asp:TextBox>
                                            <asp:FilteredTextBoxExtender ID="txtD3_FilteredTextBoxExtender1" 
                                                runat="server" Enabled="True" TargetControlID="txtD3" 
                                                ValidChars="0123456789.">
                                            </asp:FilteredTextBoxExtender>
                                    </td>
                                    <td align="center">
                                        <asp:TextBox ID="txtD4" runat="server" CssClass="textbox" MaxLength="3" 
                                            onclick="clearlabel('lblErrormsg');" Width="50px"></asp:TextBox>
                                            <asp:FilteredTextBoxExtender ID="txtD4_FilteredTextBoxExtender1" 
                                                runat="server" Enabled="True" TargetControlID="txtD4" 
                                                ValidChars="0123456789.">
                                            </asp:FilteredTextBoxExtender>
                                    </td>
                                    <td align="center">
                                        <asp:TextBox ID="txtD5" runat="server" CssClass="textbox" MaxLength="3" 
                                            onclick="clearlabel('lblErrormsg');" Width="50px"></asp:TextBox>
                                             <asp:FilteredTextBoxExtender ID="txtD5_FilteredTextBoxExtender1" 
                                                runat="server" Enabled="True" TargetControlID="txtD5" 
                                                ValidChars="0123456789.">
                                            </asp:FilteredTextBoxExtender>
                                    </td>
                                    <td>
                                        <asp:Button ID="btnSave" runat="server" CssClass="button" 
                                            onclick="btnSave_Click" Text="Save" ValidationGroup="a" Width="90px" />
                                        <asp:ConfirmButtonExtender ID="btnSave_ConfirmButtonExtender" runat="server" 
                                            ConfirmText="Do you want to save this color?" Enabled="True" 
                                            TargetControlID="btnSave">
                                        </asp:ConfirmButtonExtender>
                                    </td>
                                    <td>
                                        <asp:Button ID="btnClear" runat="server" CssClass="button" 
                                            onclick="btnClear_Click" Text="Clear" Width="90px" />
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="7" height="22px">
                                        <asp:Label ID="lblErrormsg" runat="server"></asp:Label>
                                        <asp:Label ID="lblColorid" runat="server" Visible="False"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                            ControlToValidate="txtCurvename" Display="None" ErrorMessage="Enter Curve Name" 
                                            ValidationGroup="a">*</asp:RequiredFieldValidator>
                                        <asp:ValidatorCalloutExtender ID="RequiredFieldValidator3_ValidatorCalloutExtender" 
                                            runat="server" Enabled="True" TargetControlID="RequiredFieldValidator3">
                                        </asp:ValidatorCalloutExtender>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                            ControlToValidate="txtD1" Display="None" ErrorMessage="Enter Day 1 Quantity" 
                                            ValidationGroup="a">*</asp:RequiredFieldValidator>
                                        <asp:ValidatorCalloutExtender ID="RequiredFieldValidator4_ValidatorCalloutExtender" 
                                            runat="server" Enabled="True" TargetControlID="RequiredFieldValidator4">
                                        </asp:ValidatorCalloutExtender>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                            ControlToValidate="txtD2" Display="None" ErrorMessage="Enter Day 2 Quantity" 
                                            ValidationGroup="a">*</asp:RequiredFieldValidator>
                                        <asp:ValidatorCalloutExtender ID="RequiredFieldValidator5_ValidatorCalloutExtender" 
                                            runat="server" Enabled="True" TargetControlID="RequiredFieldValidator5">
                                        </asp:ValidatorCalloutExtender>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                            ControlToValidate="txtD3" Display="None" ErrorMessage="Enter Day 3 Quantity" 
                                            ValidationGroup="a">*</asp:RequiredFieldValidator>
                                        <asp:ValidatorCalloutExtender ID="RequiredFieldValidator6_ValidatorCalloutExtender" 
                                            runat="server" Enabled="True" TargetControlID="RequiredFieldValidator6">
                                        </asp:ValidatorCalloutExtender>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                            ControlToValidate="txtD4" Display="None" ErrorMessage="Enter Day 4 Quantity" 
                                            ValidationGroup="a">*</asp:RequiredFieldValidator>
                                        <asp:ValidatorCalloutExtender ID="RequiredFieldValidator7_ValidatorCalloutExtender" 
                                            runat="server" Enabled="True" TargetControlID="RequiredFieldValidator7">
                                        </asp:ValidatorCalloutExtender>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                                            ControlToValidate="txtD5" Display="None" ErrorMessage="Enter Day 5 Quantity" 
                                            ValidationGroup="a">*</asp:RequiredFieldValidator>
                                        <asp:ValidatorCalloutExtender ID="RequiredFieldValidator8_ValidatorCalloutExtender" 
                                            runat="server" Enabled="True" TargetControlID="RequiredFieldValidator8">
                                        </asp:ValidatorCalloutExtender>
                                    </td>
                                </tr>
                            </table>
                         
                         </td>
                    </tr>
                    <tr>
                        <td height="350px" valign="top">
                            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                                AutoGenerateColumns="False" 
                                DataKeyNames="Curve_ID"  
                                Width="100%" 
                                CssClass="mGrid" PageSize="20" 
                                onpageindexchanging="GridView1_PageIndexChanging">
                                <AlternatingRowStyle CssClass="grdAltr" />
                                <Columns>
                                 <asp:TemplateField Visible="false">
                                        <ItemTemplate>
                                            <asp:Label ID="lblid" runat="server" Text='<%# Eval("Curve_ID") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="Curve_Name" HeaderText="Curve" 
                                        SortExpression="Curve_Name" />
                                    <asp:BoundField DataField="Day_1" HeaderText="Day 1" 
                                        SortExpression="Day_1" />
                                    <asp:BoundField DataField="Day_2" HeaderText="Day 2" SortExpression="Day_2" />
                                    <asp:BoundField DataField="Day_3" HeaderText="Day 3" SortExpression="Day_3" />
                                    <asp:BoundField DataField="Day_4" HeaderText="Day 4" SortExpression="Day_4" />
                                    <asp:BoundField DataField="Day_5" HeaderText="Day 5" SortExpression="Day_5" />
                                </Columns>
                               <HeaderStyle CssClass="grdHdr" />
                                  <PagerSettings FirstPageImageUrl="~/gridimage/_fst.png"
                                      LastPageImageUrl="~/gridimage/_lst.png" Mode="NextPreviousFirstLast" 
                                      NextPageImageUrl="~/gridimage/_next.png" 
                                      PreviousPageImageUrl="~/gridimage/_Prev.png" FirstPageText="First" 
                                      LastPageText="Last" NextPageText="Next" PreviousPageText="Previous" />
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


