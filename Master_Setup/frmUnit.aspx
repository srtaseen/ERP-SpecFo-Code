<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmUnit.aspx.cs" Inherits="Master_Setup_frmUnit" %>


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
                        <td align="center" 
                            style="margin:5px; padding:5px; border:1px solid #99ccff; background-color:#F9F9F9">
                           
                            <table style="width: 100%;">
                                <tr>
                                    <td align="right">
                                        &nbsp;
                                        <asp:Label ID="Label2" runat="server" CssClass="label" Text="Unit Code"></asp:Label>
                                    </td>
                                    <td align="left" width="150px">
                                        <asp:TextBox ID="txtCode" runat="server" CssClass="textbox" MaxLength="5" 
                                            onclick="clearlabel('lblErrormsg');" Width="40px"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                            ControlToValidate="txtCode" Display="None" ErrorMessage="Enter Unit Code" 
                                            ValidationGroup="a">*</asp:RequiredFieldValidator>
                                        <asp:ValidatorCalloutExtender ID="RequiredFieldValidator5_ValidatorCalloutExtender" 
                                            runat="server" Enabled="True" TargetControlID="RequiredFieldValidator5">
                                        </asp:ValidatorCalloutExtender>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                            ControlToValidate="txtName" Display="None" 
                                            ErrorMessage="Enter Unit Description" ValidationGroup="a">*</asp:RequiredFieldValidator>
                                        <asp:ValidatorCalloutExtender ID="RequiredFieldValidator6_ValidatorCalloutExtender" 
                                            runat="server" Enabled="True" TargetControlID="RequiredFieldValidator6">
                                        </asp:ValidatorCalloutExtender>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                            ControlToValidate="txtParameter" Display="None" ErrorMessage="Enter Parameter" 
                                            ValidationGroup="a">*</asp:RequiredFieldValidator>
                                        <asp:ValidatorCalloutExtender ID="RequiredFieldValidator7_ValidatorCalloutExtender" 
                                            runat="server" Enabled="True" TargetControlID="RequiredFieldValidator7">
                                        </asp:ValidatorCalloutExtender>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        &nbsp;
                                        <asp:Label ID="Label5" runat="server" CssClass="label" Text="Unit Description"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtName" runat="server" CssClass="textbox" MaxLength="30" 
                                            onclick="clearlabel('lblErrormsg');" Width="100px"></asp:TextBox>
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        &nbsp;
                                        <asp:Label ID="Label6" runat="server" CssClass="label" Text="Parameter"></asp:Label>
                                    </td>
                                    <td align="left">
                                       <asp:TextBox ID="txtParameter" runat="server" CssClass="textbox" 
                                            MaxLength="5" onclick="clearlabel('lblErrormsg');" Width="50px"></asp:TextBox>
                                             <asp:FilteredTextBoxExtender ID="txtParameter_FilteredTextBoxExtender" 
                                                                      runat="server" Enabled="True" TargetControlID="txtParameter" 
                                                                      ValidChars="0123456789">
                                                                  </asp:FilteredTextBoxExtender>
                                        </td>
                                    <td align="left">
                                        &nbsp;
                                        <asp:Button ID="btnSave" runat="server" onclick="btnSave_Click" Text="Save" 
                                            ValidationGroup="a" Width="90px" CssClass="button" />
                                        <asp:ConfirmButtonExtender ID="btnSave_ConfirmButtonExtender" runat="server" 
                                            ConfirmText="Do you want to save this data?" Enabled="True" 
                                            TargetControlID="btnSave">
                                        </asp:ConfirmButtonExtender>
                                        <asp:Button ID="btnClear" runat="server" onclick="btnClear_Click" Text="Clear" 
                                            Width="90px" CssClass="button" />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="lblunitid" runat="server" Visible="False"></asp:Label>
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
                                DataKeyNames="nUnitID" 
                                onrowcommand="GridView1_RowCommand" PageSize="20" Width="100%" 
                                onpageindexchanging="GridView1_PageIndexChanging">
                                <AlternatingRowStyle CssClass="grdAltr" />
                                <Columns>
                                    <asp:TemplateField Visible="false">
                                        <ItemTemplate>
                                            <asp:Label ID="lblid" runat="server" Text='<%# Eval("nUnitID") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="cUnitCode" HeaderText="Unit Code" 
                                        SortExpression="cUnitCode" />
                                    <asp:BoundField DataField="cUnitDes" HeaderText="Unit Description" 
                                        SortExpression="cUnitDes" />
                                    <asp:BoundField DataField="nConPara" HeaderText="Convert Parameter" 
                                        SortExpression="nConPara" />
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


