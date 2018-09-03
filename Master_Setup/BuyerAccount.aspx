<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BuyerAccount.aspx.cs" Inherits="Master_Setup_BuyerAccount" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="../css/Master_Setup.css" rel="stylesheet" type="text/css" />
    <script src="../jquery/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script src="../jquery/Master_SetupFolder.js" type="text/javascript"></script>
    <style type="text/css">
       
        
 
        .style1
        {
            height: 23px;
        }
       
        
 
        </style>
</head>
<body onload="blinkColor()">
    <form id="form1" runat="server">
      <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <table style="width: 680px;">
                    <tr>
                        <td width="320px" valign="top">
                      <div style="margin:5px; padding:5px; border:1px solid #99ccff; height:452px; background-color:#F9F9F9">
                          <table style="width:100%;">
                              <tr>
                                  <td align="right" width="120px" colspan="2" height="25px">
                                      <asp:Label ID="lblErrormsg" runat="server"></asp:Label>
                                  </td>
                              </tr>
                              <tr>
                                  <td align="right" width="115px" class="label">
                                      Buyer Name</td>
                                  <td align="left">
                                      <asp:DropDownList ID="drpBuyer" runat="server" CssClass="textbox" Width="160px" 
                                          AutoPostBack="True" onselectedindexchanged="drpBuyer_SelectedIndexChanged">
                                      </asp:DropDownList>
                                  </td>
                              </tr>
                              <tr>
                                  <td align="right" class="label">
                                      Brand</td>
                                  <td align="left" valign="top">
                                      <asp:DropDownList ID="drpBrand" runat="server" CssClass="textbox" Width="160px">
                                      </asp:DropDownList>
                                  </td>
                              </tr>
                              <tr>
                                  <td align="right" class="label">
                                      Account Name</td>
                                  <td align="left">
                                      <asp:TextBox ID="txtuserid" runat="server" Width="150px" CssClass="textbox"></asp:TextBox>
                                  </td>
                              </tr>
                              <tr>
                                  <td align="right" class="label">
                                      Password</td>
                                  <td align="left">
                                      <asp:TextBox ID="txtpass" runat="server" Width="150px" CssClass="textbox" 
                                          TextMode="Password"></asp:TextBox>
                                  </td>
                              </tr>
                              <tr>
                                  <td align="right" class="label">
                                      Confirm Password</td>
                                  <td align="left">
                                      <asp:TextBox ID="txtConfirmpass" runat="server" Width="150px" 
                                          CssClass="textbox" TextMode="Password"></asp:TextBox>
                                  </td>
                              </tr>
                              <tr>
                                  <td align="right">
                                      &nbsp;</td>
                                  <td align="left">
                                      <asp:Button ID="btnClear" runat="server" CssClass="button" 
                                          onclick="btnClear_Click" Text="Clear" Width="60px" />
                                      <asp:Button ID="btnSave" runat="server" onclick="btnSave_Click" Text="Save" 
                                          ValidationGroup="a" Width="60px" CssClass="button" />
                                      <asp:ConfirmButtonExtender ID="btnSave_ConfirmButtonExtender" runat="server" 
                                          ConfirmText="Do you want to Save this data?" Enabled="True" 
                                          TargetControlID="btnSave">
                                      </asp:ConfirmButtonExtender>
                                      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                          ControlToValidate="drpBuyer" Display="None" ErrorMessage="Select Buyer Name" 
                                          ValidationGroup="a">*</asp:RequiredFieldValidator>
                                      <asp:ValidatorCalloutExtender ID="RequiredFieldValidator2_ValidatorCalloutExtender" 
                                          runat="server" Enabled="True" TargetControlID="RequiredFieldValidator2">
                                      </asp:ValidatorCalloutExtender>
                                      <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                          ControlToValidate="drpBrand" Display="None" ErrorMessage="Select Brand" 
                                          ValidationGroup="a">*</asp:RequiredFieldValidator>
                                      <asp:ValidatorCalloutExtender ID="RequiredFieldValidator3_ValidatorCalloutExtender" 
                                          runat="server" Enabled="True" TargetControlID="RequiredFieldValidator3">
                                      </asp:ValidatorCalloutExtender>
                                      <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                          ControlToValidate="txtuserid" Display="None" ErrorMessage="Enter Account Name" 
                                          ValidationGroup="a">*</asp:RequiredFieldValidator>
                                      <asp:ValidatorCalloutExtender ID="RequiredFieldValidator4_ValidatorCalloutExtender" 
                                          runat="server" Enabled="True" TargetControlID="RequiredFieldValidator4">
                                      </asp:ValidatorCalloutExtender>
                                      <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                          ControlToValidate="txtpass" Display="None" ErrorMessage="Enter Password" 
                                          ValidationGroup="a">*</asp:RequiredFieldValidator>
                                      <asp:ValidatorCalloutExtender ID="RequiredFieldValidator5_ValidatorCalloutExtender" 
                                          runat="server" Enabled="True" TargetControlID="RequiredFieldValidator5">
                                      </asp:ValidatorCalloutExtender>
                                      <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                          ControlToValidate="txtConfirmpass" Display="None" 
                                          ErrorMessage="Enter Confirm Password" ValidationGroup="a">*</asp:RequiredFieldValidator>
                                      <asp:ValidatorCalloutExtender ID="RequiredFieldValidator6_ValidatorCalloutExtender" 
                                          runat="server" Enabled="True" TargetControlID="RequiredFieldValidator6">
                                      </asp:ValidatorCalloutExtender>
                                  </td>
                              </tr>
                              <tr>
                                  <td align="right">
                                      &nbsp;</td>
                                  <td align="left">
                                      <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                          ControlToCompare="txtpass" ControlToValidate="txtConfirmpass" 
                                          ErrorMessage="Password Mismatch" Display="None">*</asp:CompareValidator>
                                          <asp:ValidatorCalloutExtender ID="CompareValidator1_ValidatorCalloutExtender1" 
                                          runat="server" Enabled="True" TargetControlID="CompareValidator1">
                                      </asp:ValidatorCalloutExtender>
                                  </td>
                              </tr>
                              <tr>
                                  <td align="right" class="style1">
                                      </td>
                                  <td align="left" class="style1">
                                      </td>
                              </tr>
                              <tr>
                                  <td align="right">
                                      &nbsp;</td>
                                  <td align="left">
                                      &nbsp;</td>
                              </tr>
                          </table>
                            </div>
                        </td>
                        <td valign="top">
                          <div style="margin:5px; padding:5px; border:1px solid #99ccff; background-color:#F9F9F9">
                          <div style="height:450px; overflow:auto">
                            
                              <asp:GridView ID="GridView1" runat="server" CssClass="mGrid">
                              </asp:GridView>
                            
                              </div>
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
