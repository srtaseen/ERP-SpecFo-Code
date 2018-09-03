<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmGmttype.aspx.cs" Inherits="Master_Setup_frmGmttype" %>

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
                <table style="width: 600px;">
                    <tr>
                        <td style="margin:5px; padding:5px; border:1px solid #99ccff; background-color:#F9F9F9">
                            <table style="width: 100%;">
                                <tr>
                                    <td align="right">
                                        &nbsp;
                                        <asp:Label ID="Label1" runat="server" CssClass="label" Text="Garment Type"></asp:Label>
                                    </td>
                                    <td align="left" width="250px">
                                        &nbsp;
                                        <asp:TextBox ID="txtType" runat="server" CssClass="textbox" MaxLength="25" 
                                            onclick="clearlabel('lblErrormsg');" Width="180px"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                            ControlToValidate="txtType" Display="None" ErrorMessage="Enter Season" 
                                            ValidationGroup="a">*</asp:RequiredFieldValidator>
                                        <asp:ValidatorCalloutExtender ID="RequiredFieldValidator2_ValidatorCalloutExtender" 
                                            runat="server" Enabled="True" TargetControlID="RequiredFieldValidator2">
                                        </asp:ValidatorCalloutExtender>
                                    </td>
                                    <td>
                                        &nbsp;<asp:Button ID="btnSave" runat="server" CssClass="button" 
                                            onclick="btnSave_Click" Text="Save" ValidationGroup="a" Width="80px" />
                                        <asp:ConfirmButtonExtender ID="btnSave_ConfirmButtonExtender" runat="server" 
                                            ConfirmText="Do you want to save this data?" Enabled="True" 
                                            TargetControlID="btnSave">
                                        </asp:ConfirmButtonExtender>
                                        <asp:Button ID="btnClear" runat="server" CssClass="button" 
                                            onclick="btnClear_Click" Text="Clear" Width="80px" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;
                                        <asp:Label ID="lblTypeID" runat="server" Visible="False"></asp:Label>
                                    </td>
                                    <td align="left" colspan="2">
                                        &nbsp; &nbsp;
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
                                DataKeyNames="nGmtCode"
                                onrowcommand="GridView1_RowCommand" PageSize="20" Width="100%" 
                                onpageindexchanging="GridView1_PageIndexChanging">
                                <AlternatingRowStyle CssClass="grdAltr" />
                                <Columns>
                                    <asp:TemplateField Visible="false">
                                        <ItemTemplate>
                                            <asp:Label ID="lblid" runat="server" Text='<%# Eval("nGmtCode") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="cGmetDis" HeaderText="Garment Type" 
                                        SortExpression="cGmetDis" />
                                    <asp:BoundField DataField="cEntUser" HeaderText="Created User" 
                                        SortExpression="cEntUser" />
                                    <asp:BoundField DataField="dEntDate" HeaderText="Created Date" 
                                        SortExpression="dEntDate" />
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
