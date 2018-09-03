<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmFloor.aspx.cs" Inherits="Master_Setup_frmFloor" %>

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
                        <td  align="right"  
                            style="margin:5px; padding:5px; border:1px solid #99ccff; background-color:#F9F9F9">
                            <table style="width: 100%;">
                                <tr>
                                    <td align="center">
                                        <asp:Label ID="Label2" runat="server" CssClass="label" Text="Company"></asp:Label>
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="Label5" runat="server" CssClass="label" Text="Building Unit"></asp:Label>
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="Label6" runat="server" CssClass="label" Text="Floor Name"></asp:Label>
                                    </td>
                                    <td align="left">
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td align="center">
                                        <asp:DropDownList ID="drpCompany" runat="server" AutoPostBack="True" 
                                            CssClass="textbox" onselectedindexchanged="drpCompany_SelectedIndexChanged" 
                                            Width="120px">
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                            ControlToValidate="drpCompany" Display="None" ErrorMessage="Select Company" 
                                            ValidationGroup="a">*</asp:RequiredFieldValidator>
                                        <asp:ValidatorCalloutExtender ID="RequiredFieldValidator3_ValidatorCalloutExtender" 
                                            runat="server" Enabled="True" 
                                            TargetControlID="RequiredFieldValidator3">
                                        </asp:ValidatorCalloutExtender>
                                    </td>
                                    <td align="center">
                                        <asp:DropDownList ID="drpUnit" runat="server" CssClass="textbox" Width="120px">
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                            ControlToValidate="drpUnit" Display="None" ErrorMessage="Select Building Unit" 
                                            ValidationGroup="a">*</asp:RequiredFieldValidator>
                                        <asp:ValidatorCalloutExtender ID="RequiredFieldValidator4_ValidatorCalloutExtender" 
                                            runat="server" Enabled="True" 
                                            TargetControlID="RequiredFieldValidator4">
                                        </asp:ValidatorCalloutExtender>
                                    </td>
                                    <td align="center">
                                        <asp:TextBox ID="txtFloor" runat="server" CssClass="textbox" MaxLength="20" 
                                            Width="150px"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                            ControlToValidate="txtFloor" Display="None" ErrorMessage="Enter Brand Name" 
                                            ValidationGroup="a">*</asp:RequiredFieldValidator>
                                        <asp:ValidatorCalloutExtender ID="RequiredFieldValidator2_ValidatorCalloutExtender" 
                                            runat="server" Enabled="True" TargetControlID="RequiredFieldValidator2">
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
                                        &nbsp;</td>
                                    <td>
                                        <asp:Label ID="lblFloorid" runat="server" Visible="False"></asp:Label>
                                    </td>
                                    <td align="left" colspan="2" height="22px">
                                        <asp:Label ID="lblErrormsg" runat="server"></asp:Label>
                                        &nbsp;
                                    </td>
                                </tr>
                            </table>
                           </td>
                    </tr>
                    <tr>
                        <td height="350px" valign="top">
                            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                                AutoGenerateColumns="False" AutoGenerateSelectButton="True" CssClass="mGrid" 
                                DataKeyNames="nFloor" 
                                onrowcommand="GridView1_RowCommand" PageSize="20" Width="100%" 
                                onpageindexchanging="GridView1_PageIndexChanging">
                                <AlternatingRowStyle CssClass="grdAltr" />
                                <Columns>
                                    <asp:TemplateField Visible="false">
                                        <ItemTemplate>
                                            <asp:Label ID="lblid" runat="server" Text='<%# Eval("nFloor") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="cFloor_Descriptin" HeaderText="Floor" 
                                        SortExpression="cFloor_Descriptin" />
                                        <asp:BoundField DataField="Unit_Name" HeaderText="Building Unit" 
                                        SortExpression="Unit_Name" />
                                         <asp:BoundField DataField="cCmpName" HeaderText="Company" 
                                        SortExpression="cCmpName" />
                                    <asp:BoundField DataField="cEntUser" HeaderText="Created User" 
                                        SortExpression="cEntUser" />
                                    <asp:BoundField DataField="dEntdt" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Created Date" 
                                        SortExpression="dEntdt" />
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

