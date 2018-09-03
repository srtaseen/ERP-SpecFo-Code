<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmUserGroup.aspx.cs" Inherits="Master_Setup_frmUserGroup" %>

<%@ Register assembly="C1.Web.UI.Controls.4" namespace="C1.Web.UI.Controls.C1GridView" tagprefix="cc3" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<%@ Register assembly="C1.Web.UI.Controls.4" namespace="C1.Web.UI.Controls.C1TabControl" tagprefix="cc2" %>
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
       <div style="width: 750px">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table style="width: 100%;">
                <tr>
                    <td width="450px">
                      
                        <asp:Label ID="Label5" runat="server" CssClass="label" Text="Group Name"></asp:Label>
                        <asp:TextBox ID="txtGroup" runat="server" MaxLength="20" 
                            onclick="clearlabel('lblErrormsg');" Width="200px" CssClass="textbox"></asp:TextBox>
                        <asp:Button ID="btnSave" runat="server" onclick="btnSave_Click" Text="Save" 
                            ValidationGroup="a" Width="70px" CssClass="button" />
                        <asp:ConfirmButtonExtender ID="btnSave_ConfirmButtonExtender" runat="server" 
                            ConfirmText="Are you sure you want to save this data?" Enabled="True" 
                            TargetControlID="btnSave">
                        </asp:ConfirmButtonExtender>
                        <asp:Button ID="btnClear" runat="server" onclick="btnClear_Click" Text="Clear" 
                            ToolTip="Clear text" Width="70px" CssClass="button" />
                      
                    </td>
                    <td rowspan="3" valign="top">
                    <div style="height:500px; border:1px solid silver; overflow:auto">
                        <asp:GridView ID="GridView2" runat="server" AllowPaging="True" 
                            AutoGenerateColumns="False" AutoGenerateSelectButton="True" 
                            DataKeyNames="nUgroup" 
                            onrowcommand="GridView2_RowCommand" Width="98%" CssClass="mGrid" 
                            PageSize="20" 
                            onpageindexchanging="GridView2_PageIndexChanging">
                            <AlternatingRowStyle CssClass="grdAltr" />
                            <Columns>
                                <asp:TemplateField Visible="false">
                                    <ItemTemplate>
                                        <asp:Label ID="lblid" runat="server" Text='<%# Eval("nUgroup") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="cGrpDescription" HeaderText="Group Name" 
                                    SortExpression="cGrpDescription" />                               
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
                       
                     <%--   <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:mconuser %>" 
                            SelectCommand="SELECT [nUgroup], [cGrpDescription], [cEntUser], [dEntdt] FROM [Smt_UserGroups] ORDER BY [cGrpDescription]">
                        </asp:SqlDataSource>--%>
                       
                        </div>
                    
                    </td>
                </tr>
             
               
                <tr>
                    <td width="450px" height="22px">
                        <asp:Label ID="lblErrormsg" runat="server"></asp:Label>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="txtGroup" Display="None" ErrorMessage="Enter Group Name" 
                            ValidationGroup="a">*</asp:RequiredFieldValidator>
                        <asp:ValidatorCalloutExtender ID="RequiredFieldValidator1_ValidatorCalloutExtender" 
                            runat="server" Enabled="True" TargetControlID="RequiredFieldValidator1">
                        </asp:ValidatorCalloutExtender>
                        <asp:Label ID="lblgrpid" runat="server" Visible="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td width="450px" valign="top">
                     <div style="height:444px; border:1px solid silver; overflow:auto">
                        <asp:GridView ID="grdPermission" runat="server" 
                            AutoGenerateColumns="False" DataKeyNames="slno" 
                            onprerender="grdPermission_PreRender" 
                            onrowdatabound="grdPermission_RowDataBound" Width="98%" CssClass="mGrid">
                            <AlternatingRowStyle CssClass="grdAltr" />
                            <Columns>
                                <asp:BoundField DataField="Module_Name" HeaderText="Module Name" 
                                    SortExpression="Module_Name" />
                                <asp:BoundField DataField="Form_Name" HeaderText="Form Name" 
                                    SortExpression="Form_Name" />
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="chkselect" runat="server" />
                                          <asp:ToggleButtonExtender ID="CheckBox1_ToggleButtonExtender" runat="server" 
                                                                Enabled="True" CheckedImageUrl="~/gridimage/CheckbCheck.png" ImageHeight="19" ImageWidth="19"
                                                                 UncheckedImageUrl="~/gridimage/CheckBuncheck.gif" TargetControlID="chkselect">
                                                          </asp:ToggleButtonExtender>

                                        <asp:Label ID="lblformurl" runat="server" Text='<%# Eval("Url") %>' 
                                            Visible="false"></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                </asp:TemplateField>
                                <asp:BoundField DataField="Form_Desc" HeaderText="Form Description" 
                                    SortExpression="Form_Desc" />
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
                        
                        </div>
                    </td>
                </tr>
             
               
            </table>


        </ContentTemplate>
        </asp:UpdatePanel>
       </div>
    
    </div>
    </form>
</body>
</html>

