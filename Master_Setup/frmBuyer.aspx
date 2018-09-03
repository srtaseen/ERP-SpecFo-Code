<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmBuyer.aspx.cs" Inherits="Master_Setup_frmBuyer" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
                                  <td align="right" width="115px">
                                      <asp:Label ID="Label1" runat="server" CssClass="label" Text="Buyer Name"></asp:Label>
                                  </td>
                                  <td align="left">
                                      <asp:TextBox ID="txtBName" runat="server" Width="180px" CssClass="textbox"></asp:TextBox>
                                  </td>
                              </tr>
                              <tr>
                                  <td align="right">
                                      <asp:Label ID="Label2" runat="server" CssClass="label" Text="Address 1"></asp:Label>
                                  </td>
                                  <td align="left" rowspan="2" valign="top">
                                      <asp:TextBox ID="txtAd1" runat="server" TextMode="MultiLine" Width="177px" 
                                          CssClass="textbox"></asp:TextBox>
                                  </td>
                              </tr>
                              <tr>
                                  <td align="right">
                                      &nbsp;</td>
                              </tr>
                              <tr>
                                  <td align="right">
                                      <asp:Label ID="Label3" runat="server" CssClass="label" Text="Address 2"></asp:Label>
                                  </td>
                                  <td align="left">
                                      <asp:TextBox ID="txtAd2" runat="server" Width="180px" CssClass="textbox"></asp:TextBox>
                                  </td>
                              </tr>
                              <tr>
                                  <td align="right">
                                      <asp:Label ID="Label4" runat="server" CssClass="label" Text="Phone"></asp:Label>
                                  </td>
                                  <td align="left">
                                      <asp:TextBox ID="txtPh" runat="server" Width="180px" CssClass="textbox"></asp:TextBox>
                                  </td>
                              </tr>
                              <tr>
                                  <td align="right">
                                      <asp:Label ID="Label5" runat="server" CssClass="label" Text="Fax"></asp:Label>
                                  </td>
                                  <td align="left">
                                      <asp:TextBox ID="txtFx" runat="server" Width="180px" CssClass="textbox"></asp:TextBox>
                                  </td>
                              </tr>
                              <tr>
                                  <td align="right">
                                      <asp:Label ID="Label6" runat="server" CssClass="label" Text="Contact Person"></asp:Label>
                                  </td>
                                  <td align="left">
                                      <asp:TextBox ID="txtCont" runat="server" Width="180px" CssClass="textbox"></asp:TextBox>
                                  </td>
                              </tr>
                              <tr>
                                  <td align="right">
                                      <asp:Label ID="Label7" runat="server" CssClass="label" Text="Email"></asp:Label>
                                  </td>
                                  <td align="left">
                                      <asp:TextBox ID="txtEmail" runat="server" Width="180px" CssClass="textbox"></asp:TextBox>
                                  </td>
                              </tr>
                              <tr>
                                  <td align="right">
                                      &nbsp;</td>
                                  <td align="left">
                                      <asp:Label ID="lblBuyerID" runat="server" Visible="False">0</asp:Label>
                                  </td>
                              </tr>
                              <tr>
                                  <td align="right">
                                      &nbsp;</td>
                                  <td align="left">
                                      <asp:Button ID="btnSave" runat="server" onclick="btnSave_Click" Text="Save" 
                                          ValidationGroup="a" Width="80px" CssClass="button" />
                                      <asp:ConfirmButtonExtender ID="btnSave_ConfirmButtonExtender" runat="server" 
                                          ConfirmText="Do you want to Save this data?" Enabled="True" 
                                          TargetControlID="btnSave">
                                      </asp:ConfirmButtonExtender>
                                      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                          ControlToValidate="txtBName" Display="None" ErrorMessage="Enter Buyer Name" 
                                          ValidationGroup="a">*</asp:RequiredFieldValidator>
                                      <asp:ValidatorCalloutExtender ID="RequiredFieldValidator2_ValidatorCalloutExtender" 
                                          runat="server" Enabled="True" TargetControlID="RequiredFieldValidator2">
                                      </asp:ValidatorCalloutExtender>
                                  </td>
                              </tr>
                              <tr>
                                  <td align="right">
                                      &nbsp;</td>
                                  <td align="left">
                                      <asp:Button ID="btnClear" runat="server" onclick="btnClear_Click" Text="Clear" 
                                          Width="80px" CssClass="button" />
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
                              <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                                  DataKeyNames="nBuyer_ID"  AllowPaging="True" 
                                  PageSize="21" Width="100%" CssClass="mGrid" onpageindexchanging="GridView2_PageIndexChanging" 
                                 >
                                  <AlternatingRowStyle CssClass="grdAltr" />
                                  <Columns>
                                  <asp:TemplateField>
                                  <ItemTemplate>
                                  <asp:LinkButton ID="lnkSelect" ToolTip="Edit Buyer" runat="server" Text="Edit" 
                                          CommandArgument='<%# Eval("nBuyer_ID") %>'  CssClass="grdSelect"
                                          onclick="lnkSelect_Click"></asp:LinkButton>
                                  </ItemTemplate>
                                  </asp:TemplateField>
                                      <asp:BoundField DataField="nBuyer_ID" HeaderText="Sl No" 
                                          InsertVisible="False" ReadOnly="True" SortExpression="nBuyer_ID" />
                                      <asp:BoundField DataField="cBuyer_Name" HeaderText="Buyer Name" 
                                          SortExpression="cBuyer_Name" />
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
