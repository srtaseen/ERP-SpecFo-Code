<%@ Page Language="C#" AutoEventWireup="true" CodeFile="bt.aspx.cs" Inherits="Master_Setup_bt" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
  <link href="../css/Master_Setup.css" rel="stylesheet" type="text/css" />
    <script src="../jquery/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script src="../jquery/Master_SetupFolder.js" type="text/javascript"></script>
    <link href="../css/total.css" rel="stylesheet" type="text/css" />
</head>
<body onload="blinkColor('lblErrormsg')">
    <form id="form1" runat="server">
    <div align="left">
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>             
               
                
               
                <table>
                <tr>
                <td><asp:Label ID="Label1" runat="server" Text="User Name "></asp:Label></td>
                 <td> <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="DropDownList1_SelectedIndexChanged" Width="200px" 
                    CssClass="textbox">
                </asp:DropDownList>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                            ControlToValidate="DropDownList1" Display="None" ErrorMessage="Select User" 
                                            ValidationGroup="a">*</asp:RequiredFieldValidator>
                                        <asp:ValidatorCalloutExtender ID="RequiredFieldValidator1_ValidatorCalloutExtender" 
                                            runat="server" Enabled="True" TargetControlID="RequiredFieldValidator1">
                                        </asp:ValidatorCalloutExtender>
                    </td>
                  <td><asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Save" 
                          Width="100px" Enabled="False" /></td>
                   <td> 
                       <asp:Button ID="btnClear" runat="server" CssClass="button" Text="Clear" 
                    Width="100px" onclick="btnClear_Click" /></td>
                </tr>
                 <tr>
                <td align="center" colspan="4" height="22px">
                    <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
                    <asp:Label ID="Label3" runat="server" Text="Label" Visible="False"></asp:Label>
                    <asp:Label ID="lblErrormsg" runat="server"></asp:Label>
                     </td>
                </tr>
                </table>

                <table width="600px" style="border:1px solid silver">
                 <tr class="pnlheader">
                <td width="30px"></td>
                <td align="center" width="130px">Module Name</td>
                <td align="center" width="205px">Form Name/Button Name</td>
                    <td align="center">
                        Button Name</td>
                </tr>
                    <tr>
                        <td colspan="4" valign="top">                        
                            <asp:Panel ID="pnlbtnsc" Height="430px" ScrollBars="Auto" runat="server">                         
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" 
                                CssClass="mGrid" ShowHeader="False" Width="100%" 
                                onrowdatabound="GridView1_RowDataBound">
                                <AlternatingRowStyle CssClass="gridrowAlternaterow" />
                                <Columns>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkModule" runat="server" AutoPostBack="True" 
                                                oncheckedchanged="chkModule_CheckedChanged" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Module">
                                        <ItemTemplate>
                                            <asp:Label ID="lblModule" runat="server" Text='<%# Eval("Module_Name") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Form Name">
                                        <ItemTemplate>
                                            <asp:GridView ID="grdFormName" runat="server" 
                                                AlternatingRowStyle-BackColor="#D8E1F5" AutoGenerateColumns="false" 
                                                CssClass="mGrid" onrowdatabound="grdFormName_RowDataBound" 
                                                RowStyle-Wrap="False" ShowHeader="false" Width="100%">
                                                <AlternatingRowStyle BackColor="#D8E1F5" />
                                                <Columns>
                                                    <asp:TemplateField>
                                                        <ItemTemplate>
                                                            <asp:CheckBox ID="chkForm" runat="server" AutoPostBack="True" 
                                                                oncheckedchanged="chkForm_CheckedChanged" />
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField>
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblform" runat="server" Text='<%# Eval("Form_Name") %>'></asp:Label>
                                                            <asp:Label ID="lblformurl" runat="server" Text='<%# Eval("Url") %>' 
                                                                Visible="false"></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Button">
                                                        <ItemTemplate>
                                                            <asp:GridView ID="grdButton" runat="server" AutoGenerateColumns="false" 
                                                                CssClass="mGrid" onrowdatabound="grdButton_RowDataBound" RowStyle-Wrap="False" 
                                                                ShowHeader="false" Width="100%">
                                                                <Columns>
                                                                    <asp:TemplateField>
                                                                        <ItemTemplate>
                                                                            <asp:CheckBox ID="chkButton" runat="server" />
                                                                        </ItemTemplate>
                                                                    </asp:TemplateField>
                                                                    <asp:TemplateField HeaderText="Button">
                                                                        <ItemTemplate>
                                                                            <asp:Label ID="lblbtn" runat="server" Text='<%# Eval("Btn_Name") %>' 
                                                                                Visible="false"></asp:Label>
                                                                            <asp:Label ID="lblbtntext" runat="server" Text='<%# Eval("Btn_Text") %>'></asp:Label>
                                                                        </ItemTemplate>
                                                                    </asp:TemplateField>
                                                                </Columns>
                                                            </asp:GridView>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                </Columns>
                                                <RowStyle Wrap="False" />
                                            </asp:GridView>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <HeaderStyle CssClass="gridheader" Wrap="False" />
                                <RowStyle CssClass="gridrow" Wrap="False" />
                            </asp:GridView>
                             </asp:Panel>
                           
                        </td>
                    </tr>
                </table>
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
    </form>

    <script src="../jquery/scrollsaver.min.js" type="text/javascript"></script>
</body>
</html>
