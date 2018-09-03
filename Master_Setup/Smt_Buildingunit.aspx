<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Smt_Buildingunit.aspx.cs" Inherits="Master_Setup_Smt_Buildingunit" %>

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
                                    <td align="right">
                                        <asp:Label ID="Label2" runat="server" CssClass="label" Text="Company"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:DropDownList ID="drpSection" runat="server" CssClass="textbox" 
                                            Width="170px" AutoPostBack="True" 
                                            onselectedindexchanged="drpSection_SelectedIndexChanged">
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                            ControlToValidate="drpSection" Display="None" ErrorMessage="Select Company" 
                                            ValidationGroup="a">*</asp:RequiredFieldValidator>
                                        <asp:ValidatorCalloutExtender ID="RequiredFieldValidator2_ValidatorCalloutExtender" 
                                            runat="server" Enabled="True" TargetControlID="RequiredFieldValidator2">
                                        </asp:ValidatorCalloutExtender>
                                    </td>
                                    <td align="right">
                                        <asp:Label ID="Label3" runat="server" CssClass="label" Text="Building Unit"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtBuildingUnit" runat="server" style="text-transform:uppercase" CssClass="textbox" 
                                            MaxLength="30" onclick="clearlabel('lblErrormsg');" Width="150px"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Button ID="btnSave" runat="server" onclick="btnSave_Click" Text="Save" 
                                            ValidationGroup="a" Width="90px" CssClass="button" />
                                        <asp:ConfirmButtonExtender ID="btnSave_ConfirmButtonExtender" runat="server" 
                                            ConfirmText="Do you want to save this color?" Enabled="True" 
                                            TargetControlID="btnSave">
                                        </asp:ConfirmButtonExtender>
                                    </td>
                                    <td>
                                        <asp:Button ID="btnClear" runat="server" onclick="btnClear_Click" Text="Clear" 
                                            Width="90px" CssClass="button" />
                                    </td>
                                    <td>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                            ControlToValidate="txtBuildingUnit" Display="None" ErrorMessage="Enter Unit" 
                                            ValidationGroup="a">*</asp:RequiredFieldValidator>
                                        <asp:ValidatorCalloutExtender ID="RequiredFieldValidator1_ValidatorCalloutExtender" 
                                            runat="server" Enabled="True" TargetControlID="RequiredFieldValidator1">
                                        </asp:ValidatorCalloutExtender>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="7" height="22PX">
                                        <asp:Label ID="lblErrormsg" runat="server"></asp:Label>
                                        <asp:Label ID="lblColorid" runat="server" Visible="False"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                         
                         </td>
                    </tr>
                    <tr>
                        <td height="350px" valign="top">
                            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                                AutoGenerateColumns="False" AutoGenerateSelectButton="True" 
                                DataKeyNames="Unit_Code"
                                onrowcommand="GridView1_RowCommand" PageSize="20" Width="100%" 
                                CssClass="mGrid" onpageindexchanging="GridView1_PageIndexChanging">
                                <AlternatingRowStyle CssClass="grdAltr" />
                                <Columns>
                                    <asp:TemplateField Visible="false">
                                        <ItemTemplate>
                                            <asp:Label ID="lblid" runat="server" Text='<%# Eval("Unit_Code") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="Unit_Name" HeaderText="Building Unit" 
                                        SortExpression="Unit_Name" />
                                    <asp:BoundField DataField="cCmpName" HeaderText="Company" 
                                        SortExpression="cCmpName" />
                                    <asp:BoundField DataField="CreatedBy" HeaderText="Created User" 
                                        SortExpression="CreatedBy" />
                                    <asp:BoundField DataField="Createddt" HeaderText="Created Date" 
                                        SortExpression="Createddt" />
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


