<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmDepartment.aspx.cs" Inherits="Master_Setup_frmDepartment" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <script src="../jquery/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script src="../jquery/Master_SetupFolder.js" type="text/javascript"></script>
    <link href="../css/Master_Setup.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {}
    </style>
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
                                    <td align="right">
                                        <asp:Label ID="Label2" runat="server" CssClass="label" Text="Company Name"></asp:Label>
                                    </td>
                                    <td align="left" width="230px">
                                        <asp:DropDownList ID="drpcompany" runat="server" AutoPostBack="True" 
                                            CssClass="textbox" onselectedindexchanged="drpcompany_SelectedIndexChanged" 
                                            Width="200px">
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                            ControlToValidate="drpcompany" Display="None" ErrorMessage="Select Company" 
                                            ValidationGroup="a">*</asp:RequiredFieldValidator>
                                        <asp:ValidatorCalloutExtender ID="RequiredFieldValidator2_ValidatorCalloutExtender" 
                                            runat="server" Enabled="True" TargetControlID="RequiredFieldValidator2">
                                        </asp:ValidatorCalloutExtender>
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="Label1" runat="server" CssClass="label" Text="Department Name"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtDepartment" runat="server" CssClass="textbox" 
                                            MaxLength="50" Width="200px"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                            ControlToValidate="txtDepartment" Display="None" 
                                            ErrorMessage="Enter Department Name" ValidationGroup="a">*</asp:RequiredFieldValidator>
                                        <asp:ValidatorCalloutExtender ID="RequiredFieldValidator1_ValidatorCalloutExtender" 
                                            runat="server" Enabled="True" TargetControlID="RequiredFieldValidator1">
                                        </asp:ValidatorCalloutExtender>
                                    </td>
                                    <td align="left">
                                        <asp:Button ID="btnSave" runat="server" CssClass="button" 
                                            onclick="btnSave_Click" Text="Save" ValidationGroup="a" Width="90px" />
                                        <asp:Button runat="server" CssClass="button" onclick="btnClear_Click" 
                                            Text="Clear" Width="90px" />
                                        <asp:ConfirmButtonExtender ID="btnSave_ConfirmButtonExtender" runat="server" 
                                            ConfirmText="Do you want to save this data?" Enabled="True" 
                                            TargetControlID="btnSave">
                                        </asp:ConfirmButtonExtender>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lbldeptid" runat="server" CssClass="label" Visible="False"></asp:Label>
                                    </td>
                                    <td align="left" colspan="2">
                                        <asp:Label ID="lblErrormsg" runat="server"></asp:Label>
                                        &nbsp;
                                    </td>
                                </tr>
                            </table>
                           </td>
                    </tr>
                    <tr>
                        <td valign="top">
                            <div>
                                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                                    AutoGenerateColumns="False" AutoGenerateSelectButton="True" CssClass="mGrid" 
                                    DataKeyNames="nUserDept" onrowcommand="GridView1_RowCommand" PageSize="19" 
                                    Width="100%" onpageindexchanging="GridView1_PageIndexChanging">
                                    <AlternatingRowStyle CssClass="grdAltr" />
                                    <Columns>
                                        <asp:TemplateField Visible="false">
                                            <ItemTemplate>
                                                <asp:Label ID="lblid" runat="server" Text='<%# Eval("nUserDept") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="cDeptname" HeaderText="Department Name" 
                                            SortExpression="cDeptname" />
                                        <asp:BoundField DataField="cCmpName" HeaderText="Company Name" 
                                            SortExpression="cCmpName" />
                                        <asp:BoundField DataField="cEntUser" HeaderText="Created User" 
                                            SortExpression="cEntUser" />
                                        <asp:BoundField DataField="dEntdt" HeaderText="Created Date" 
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
                                <%-- <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:mycon %>" 
                                
                                
                                SelectCommand="SELECT [nUserDept], [cDeptname], [cCmpName], [cEntUser], [dEntdt] FROM [View_Smt_Department] ORDER BY [nUserDept] DESC">
                            </asp:SqlDataSource>--%>
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

