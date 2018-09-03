<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmArticle.aspx.cs" Inherits="Master_Setup_frmArticle" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="../css/Master_Setup.css" rel="stylesheet" type="text/css" />
    <script src="../jquery/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script src="../jquery/Master_SetupFolder.js" type="text/javascript"></script>
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
                        <td align="right" 
                            style="margin:5px; padding:5px; border:1px solid #99ccff; background-color:#F9F9F9">
                            <table style="width: 100%;">
                                <tr>
                                    <td>
                                        <asp:Label ID="Label2" runat="server" CssClass="label" Text="Main Category"></asp:Label>
                                    </td>
                                    <td align="left" width="230px">
                                        <asp:DropDownList ID="drpMaincategoryArticle" runat="server" 
                                            AutoPostBack="True" CssClass="textbox" 
                                            onselectedindexchanged="drpMaincategoryArticle_SelectedIndexChanged" 
                                            Width="200px">
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                            ControlToValidate="drpMaincategoryArticle" Display="None" 
                                            ErrorMessage="Select Main Category" ValidationGroup="a">*</asp:RequiredFieldValidator>
                                        <asp:ValidatorCalloutExtender ID="RequiredFieldValidator3_ValidatorCalloutExtender" 
                                            runat="server" Enabled="True" TargetControlID="RequiredFieldValidator3">
                                        </asp:ValidatorCalloutExtender>
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label1" runat="server" CssClass="label" 
                                            Text="Construction/Article"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtArticle" runat="server" CssClass="textbox" MaxLength="50" 
                                            Width="200px"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                            ControlToValidate="txtArticle" Display="None" ErrorMessage="Enter Article" 
                                            ValidationGroup="a">*</asp:RequiredFieldValidator>
                                        <asp:ValidatorCalloutExtender ID="RequiredFieldValidator1_ValidatorCalloutExtender" 
                                            runat="server" Enabled="True" TargetControlID="RequiredFieldValidator1">
                                        </asp:ValidatorCalloutExtender>
                                        <asp:FilteredTextBoxExtender ID="txtArticle_FilteredTextBoxExtender" runat="server" 
                           Enabled="True" FilterMode="InvalidChars" 
                           InvalidChars="'`~^$#@!" 
                           TargetControlID="txtArticle">
                       </asp:FilteredTextBoxExtender>


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
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblArticleID" runat="server" CssClass="label" Visible="False"></asp:Label>
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
                                DataKeyNames="nArtCode"  
                                onpageindexchanging="GridView1_PageIndexChanging" 
                                onrowcommand="GridView1_RowCommand" PageSize="20" Width="100%">
                                <AlternatingRowStyle CssClass="grdAltr" />
                                <Columns>
                                    <asp:TemplateField Visible="false">
                                        <ItemTemplate>
                                            <asp:Label ID="lblid" runat="server" Text='<%# Eval("nArtCode") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="cArticle" HeaderText="Article" 
                                        SortExpression="cArticle" />
                                    <asp:BoundField DataField="cMainCategory" HeaderText="Main Category" 
                                        SortExpression="cMainCategory" />
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

