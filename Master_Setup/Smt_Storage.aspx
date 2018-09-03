<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Smt_Storage.aspx.cs" Inherits="Master_Setup_Smt_Storage" %>

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
           
                <table style="width: 750px;">
                <tr>
                <td>
                    <table style="width:100%;">
                        <tr>
                            <td valign="top" width="300px" style="margin:5px; padding:5px; border:1px solid #99ccff; background-color:#F9F9F9">
                                <table style="width: 100%;">
                                    <tr>
                                        <td align="right">
                                            Storage Name</td>
                                        <td>
                                            <asp:TextBox ID="txtStorageName" runat="server" CssClass="textbox" 
                                                Width="170px" MaxLength="50"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" 
                                                                      ControlToValidate="txtStorageName" Display="None" ErrorMessage="Enter Storage Name " 
                                                                      ValidationGroup="s">* </asp:RequiredFieldValidator>
                                                                  <asp:ValidatorCalloutExtender ID="RequiredFieldValidator21_ValidatorCalloutExtender" 
                                                                      runat="server" Enabled="True" TargetControlID="RequiredFieldValidator21">
                                                                  </asp:ValidatorCalloutExtender>

                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            No. Of Block</td>
                                        <td>
                                            <asp:TextBox ID="txtBlock" runat="server" CssClass="textbox" Width="170px" 
                                                MaxLength="5"></asp:TextBox>
                                                 <asp:FilteredTextBoxExtender ID="txtBlock_FilteredTextBoxExtender" 
                                                                      runat="server" Enabled="True" TargetControlID="txtBlock" 
                                                                      ValidChars="0123456789">
                                                                  </asp:FilteredTextBoxExtender>

                                                                  <asp:RequiredFieldValidator ID="txtBlock_RequiredFieldValidator1" runat="server" 
                                                                      ControlToValidate="txtBlock" Display="None" ErrorMessage="Enter No. of Block " 
                                                                      ValidationGroup="s">* </asp:RequiredFieldValidator>
                                                                  <asp:ValidatorCalloutExtender ID="txtBlock_ValidatorCalloutExtender1" 
                                                                      runat="server" Enabled="True" TargetControlID="txtBlock_RequiredFieldValidator1">
                                                                  </asp:ValidatorCalloutExtender>

                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            No. Of Rack</td>
                                        <td>
                                            <asp:TextBox ID="txtRack" runat="server" CssClass="textbox" Width="170px" 
                                                MaxLength="5"></asp:TextBox>
                                                <asp:FilteredTextBoxExtender ID="txtRack_FilteredTextBoxExtender1" 
                                                                      runat="server" Enabled="True" TargetControlID="txtRack" 
                                                                      ValidChars="0123456789">
                                                                  </asp:FilteredTextBoxExtender>

                                                                  <asp:RequiredFieldValidator ID="txtRack_RequiredFieldValidator1" runat="server" 
                                                                      ControlToValidate="txtRack" Display="None" ErrorMessage="Enter No. of Rack " 
                                                                      ValidationGroup="s">* </asp:RequiredFieldValidator>
                                                                  <asp:ValidatorCalloutExtender ID="txtRack_ValidatorCalloutExtender1" 
                                                                      runat="server" Enabled="True" TargetControlID="txtRack_RequiredFieldValidator1">
                                                                  </asp:ValidatorCalloutExtender>


                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            No. Of Cell</td>
                                        <td>
                                            <asp:TextBox ID="txtCell" runat="server" CssClass="textbox" Width="170px" 
                                                MaxLength="5"></asp:TextBox>
                                                  <asp:FilteredTextBoxExtender ID="txtCell_FilteredTextBoxExtender1" 
                                                                      runat="server" Enabled="True" TargetControlID="txtCell" 
                                                                      ValidChars="0123456789">
                                                                  </asp:FilteredTextBoxExtender>

                                                                  <asp:RequiredFieldValidator ID="txtCell_RequiredFieldValidator1" runat="server" 
                                                                      ControlToValidate="txtCell" Display="None" ErrorMessage="Enter No. of Cell " 
                                                                      ValidationGroup="s">* </asp:RequiredFieldValidator>
                                                                  <asp:ValidatorCalloutExtender ID="txtCell_ValidatorCalloutExtender1" 
                                                                      runat="server" Enabled="True" TargetControlID="txtCell_RequiredFieldValidator1">
                                                                  </asp:ValidatorCalloutExtender>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" colspan="2">
                                            <asp:Label ID="lblErrormsg" runat="server"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="lblStoreID" runat="server" Visible="False"></asp:Label>
                                        </td>
                                        <td style="padding-left:5px">
                                            <asp:Button ID="btnSave" runat="server" CssClass="button" Text="Save" 
                                                Width="70px" onclick="btnSave_Click" ValidationGroup="s" />
                                                <asp:ConfirmButtonExtender ID="btnSave_ConfirmButtonExtender" runat="server" 
                                                                             ConfirmText="Do you want to save this data?" Enabled="True" 
                                                                             TargetControlID="btnSave">
                                                                         </asp:ConfirmButtonExtender>
                                            <asp:Button ID="btnClear" runat="server" CssClass="button" Text="Clear" 
                                                Width="70px" onclick="btnClear_Click" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td style="border:1px solid #99ccff; background-color:#F9F9F9" 
                                height="450px" valign="top">
                               

                               <div style="height:440px; overflow:auto">
                                   <asp:GridView ID="grdStorage" runat="server" Width="100%" 
                                       AutoGenerateColumns="False" CssClass="mGrid" DataKeyNames="Storage_Sl" 
                                       AutoGenerateSelectButton="True" 
                                       onrowcommand="grdStorage_RowCommand" 
                                       onpageindexchanging="grdStorage_PageIndexChanging">
                                       <AlternatingRowStyle CssClass="grdAltr" />
                                       <Columns>
                                       <asp:TemplateField Visible="false">
                                       <ItemTemplate>
                                        <asp:Label ID="lblid" runat="server" Text='<%# Eval("Storage_Sl") %>'></asp:Label>
                                       </ItemTemplate>
                                       </asp:TemplateField>                                          
                                           <asp:BoundField DataField="Storage_Name" HeaderText="Storage Name" 
                                               SortExpression="Storage_Name" />
                                           <asp:BoundField DataField="Storage_Block" HeaderText="Block" 
                                               SortExpression="Storage_Block" />
                                           <asp:BoundField DataField="Storage_Rack" HeaderText="Rack" 
                                               SortExpression="Storage_Rack" />
                                           <asp:BoundField DataField="Storage_Cell" HeaderText="Cell" 
                                               SortExpression="Storage_Cell" />
                                       </Columns>
                                       <HeaderStyle CssClass="grdHdr" />
                                       <RowStyle CssClass="grdRow" />
                                   </asp:GridView>
                                 
                               </div>
                               
                           
                               
                               </td>
                        </tr>
                    </table>
                    </td>
                </tr>
                </table>
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>

