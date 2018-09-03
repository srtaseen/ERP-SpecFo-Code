<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmSupCategory.aspx.cs" Inherits="Master_Setup_frmSupCategory" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
   <link href="../css/Master_Setup.css" rel="stylesheet" type="text/css" />
    <script src="../jquery/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script src="../jquery/Master_SetupFolder.js" type="text/javascript"></script>   
<script type="text/javascript">
    function toggleSelection(source) {
        $("#GridView1 input[name$='cbSelect']").each(function (index) {
            $(this).attr('checked', source.checked);
        });
    }
    function clearSelection() {
        if ($("#GridView1 input[name$='cbSelect']").length == $("#GridView1 input[name$='cbSelect']:checked").length) {
            $("#GridView1 input[name$='cbSelectAll']").first().attr('checked', true);

        }
        else {
            $("#GridView1 input[name$='cbSelectAll']").first().attr('checked', false);
        }
    }           
    </script>
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
                        <td  align="right" 
                            style="margin:5px; padding:5px; border:1px solid #99ccff; background-color:#F9F9F9">
                            <table style="width: 100%;">
                                <tr>
                                    <td>
                                        <asp:Label ID="Label3" runat="server" CssClass="label" Text="Main Category"></asp:Label>
                                    </td>
                                    <td align="left" width="230px">
                                        <asp:DropDownList ID="drpmaincategory" runat="server" AutoPostBack="True" 
                                            CssClass="textbox" onclick="clearlabel('lblErrormsg');" 
                                            onselectedindexchanged="drpmaincategory_SelectedIndexChanged" TabIndex="1" 
                                            Width="200px">
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                            ControlToValidate="drpmaincategory" Display="None" 
                                            ErrorMessage="Select Main Category" ValidationGroup="a">*</asp:RequiredFieldValidator>
                                        <asp:ValidatorCalloutExtender ID="RequiredFieldValidator4_ValidatorCalloutExtender" 
                                            runat="server" Enabled="True" TargetControlID="RequiredFieldValidator4">
                                        </asp:ValidatorCalloutExtender>
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label4" runat="server" CssClass="label" Text="Sub Category"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtItemname" runat="server" CssClass="textbox" MaxLength="150" 
                                            onclick="clearlabel('lblErrormsg');" TabIndex="2" Width="200px"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                            ControlToValidate="txtItemname" Display="None" 
                                            ErrorMessage="Enter Sub Category" ValidationGroup="a">*</asp:RequiredFieldValidator>
                                        <asp:ValidatorCalloutExtender ID="RequiredFieldValidator5_ValidatorCalloutExtender" 
                                            runat="server" Enabled="True" TargetControlID="RequiredFieldValidator5">
                                        </asp:ValidatorCalloutExtender>
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label5" runat="server" CssClass="label" Text="Unit Name"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:DropDownList ID="drpUnit" runat="server" CssClass="textbox" 
                                            onclick="clearlabel('lblErrormsg');" TabIndex="3" Width="200px">
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                            ControlToValidate="drpUnit" Display="None" ErrorMessage="Select Unit" 
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
                                            ConfirmText="Do you want to save this data?" Enabled="True" 
                                            TargetControlID="btnSave">
                                        </asp:ConfirmButtonExtender>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblColorid" runat="server" Visible="False"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:Label ID="lblErrormsg" runat="server"></asp:Label>
                                    </td>
                                    <td style="text-align:left">
                                        <asp:Button ID="btnhide" runat="server" CssClass="button" 
                                            onclick="btnhide_Click" Text="Hide/Unhide Items" Width="120px" />
                                        <asp:ConfirmButtonExtender ID="btnhide_ConfirmButtonExtender" runat="server" 
                                            ConfirmText="Do you want to save this data?" Enabled="True" 
                                            TargetControlID="btnhide">
                                        </asp:ConfirmButtonExtender>
                                    </td>
                                </tr>
                            </table>
                           </td>
                    </tr>
                    <tr>
                        <td height="350px" valign="top">
                        <div style="height:350px; overflow:auto">
                            <asp:GridView ID="GridView1" runat="server" 
                                AutoGenerateColumns="False" CssClass="mGrid" DataKeyNames="cCode" 
                               onpageindexchanging="GridView1_PageIndexChanging" 
                                PageSize="19" Width="100%" onrowdatabound="GridView1_RowDataBound">
                                <AlternatingRowStyle CssClass="grdAltr" />
                                <Columns>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:CheckBox ID="cbSelect" onclick="clearSelection();" Text="" Checked='<%# Eval("Act_sts") %>' runat="server" />
                                            <asp:Label ID="lblid" Visible="false" runat="server" Text='<%# Eval("cCode") %>'></asp:Label>
                                        </ItemTemplate>
                                        <HeaderTemplate>
                                         <asp:CheckBox ID="cbSelectAll" onclick="toggleSelection(this);" Text="Hide" runat="server" />
                                        </HeaderTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="cDes" HeaderText="Sub Category" 
                                        SortExpression="cDes" />
                                    <asp:BoundField DataField="cMainCategory" HeaderText="Main Category" 
                                        SortExpression="cMainCategory" />
                                    <asp:BoundField DataField="cUnitCode" HeaderText="Unit" 
                                        SortExpression="cUnitCode" />
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
                            </div>
                            
                        </td>
                    </tr>
                </table>
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>

