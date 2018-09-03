<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmLine.aspx.cs" Inherits="Master_Setup_frmLine" %>

<%@ Register assembly="C1.Web.UI.Controls.4" namespace="C1.Web.UI.Controls.C1GridView" tagprefix="cc1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<%@ Register assembly="C1.Web.UI.Controls.4" namespace="C1.Web.UI.Controls.C1TabControl" tagprefix="cc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="../css/Master_Setup.css" rel="stylesheet" type="text/css" />
</head>
<body onload="blinkColor('lblErrormsg')" onkeydown = "return (event.keyCode!=13)">
    <form id="form1" runat="server">
      <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
       <div style="width: 750px">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>                  
                    <table style="width:100%;">
                        <tr>
                            <td valign="top">                             
                             <table style="width:100%;">
                                 <tr>
                                     <td align="right">
                                      <div class="pnlmain">
                                      <div class="pnlheader">Define Line</div>
                                      <table style="width:100%;">
                                       <tr>
                                           <td align="right">
                                               <asp:Label ID="Label1" runat="server" CssClass="label" Text="Company"></asp:Label>
                                           </td>
                                           <td>
                                               <asp:DropDownList ID="drpCompany" runat="server" AutoPostBack="True" 
                                                   CssClass="textbox" onclick="clearlabel('lbltotalinfo');" TabIndex="1" 
                                                   Width="160px" onselectedindexchanged="drpCompany_SelectedIndexChanged">
                                               </asp:DropDownList>
                                               <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                   ControlToValidate="drpCompany" Display="None" ErrorMessage="Select Company" 
                                                   ValidationGroup="a">*</asp:RequiredFieldValidator>
                                                   <asp:ValidatorCalloutExtender ID="RequiredFieldValidator1_ValidatorCalloutExtender" 
                                                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator1">
                                                    </asp:ValidatorCalloutExtender>
                                           </td>
                                           <td align="right">
                                               <asp:Label ID="Label2" runat="server" CssClass="label" Text="Section"></asp:Label>
                                           </td>
                                           <td>
                                               <asp:DropDownList ID="drpSection" runat="server" AutoPostBack="True" 
                                                   CssClass="textbox" onclick="clearlabel('lbltotalinfo');" TabIndex="1" 
                                                   Width="140px">
                                               </asp:DropDownList>
                                               <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                   ControlToValidate="drpSection" Display="None" ErrorMessage="Select Section" 
                                                   ValidationGroup="a">*</asp:RequiredFieldValidator>
                                                   <asp:ValidatorCalloutExtender ID="RequiredFieldValidator3_ValidatorCalloutExtender1" 
                                                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator3">
                                                    </asp:ValidatorCalloutExtender>
                                           </td>
                                           <td align="right">
                                               <asp:Label ID="Label3" runat="server" CssClass="label" Text="Floor"></asp:Label>
                                           </td>
                                           <td>
                                               <asp:DropDownList ID="drpFloor" runat="server" AutoPostBack="True" 
                                                   CssClass="textbox" onclick="clearlabel('lbltotalinfo');" TabIndex="1" 
                                                   Width="100px">
                                               </asp:DropDownList>
                                               <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                                   ControlToValidate="drpFloor" Display="None" ErrorMessage="Select Floor" 
                                                   ValidationGroup="a">*</asp:RequiredFieldValidator>
                                                    <asp:ValidatorCalloutExtender ID="RequiredFieldValidator5_ValidatorCalloutExtender1" 
                                                        runat="server" Enabled="True" 
                                                   TargetControlID="RequiredFieldValidator5" >
                                                    </asp:ValidatorCalloutExtender>
                                           </td>
                                           <td align="right">
                                               <asp:Label ID="Label4" runat="server" CssClass="label" Text="Machine Operator"></asp:Label>
                                           </td>
                                           <td>
                                               <asp:TextBox ID="txtOperator" runat="server" CssClass="textbox" MaxLength="5" 
                                                   onclick="clearlabel('lbltotalinfo');" TabIndex="6" Width="30px"></asp:TextBox>
                                               <asp:FilteredTextBoxExtender ID="txtOperator_FilteredTextBoxExtender" 
                                                   runat="server" Enabled="True" TargetControlID="txtOperator" 
                                                   ValidChars=".0123456789">
                                               </asp:FilteredTextBoxExtender>
                                           </td>
                                       </tr>
                                       <tr>
                                           <td align="right">
                                               <asp:Label ID="Label5" runat="server" CssClass="label" Text="Department"></asp:Label>
                                           </td>
                                           <td>
                                               <asp:DropDownList ID="drpDepartment" runat="server" AutoPostBack="True" 
                                                   CssClass="textbox" onclick="clearlabel('lbltotalinfo');" TabIndex="1" 
                                                   Width="160px" onselectedindexchanged="drpDepartment_SelectedIndexChanged">
                                               </asp:DropDownList>
                                               <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                   ControlToValidate="drpDepartment" Display="None" 
                                                   ErrorMessage="Select Department" ValidationGroup="a">*</asp:RequiredFieldValidator>
                                                   <asp:ValidatorCalloutExtender ID="RequiredFieldValidator2_ValidatorCalloutExtender1" 
                                                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator2">
                                                    </asp:ValidatorCalloutExtender>
                                           </td>
                                           <td align="right">
                                               <asp:Label ID="Label6" runat="server" CssClass="label" Text="Unit"></asp:Label>
                                           </td>
                                           <td>
                                               <asp:DropDownList ID="DrpUnit" runat="server" AutoPostBack="True" 
                                                   CssClass="textbox" onclick="clearlabel('lbltotalinfo');" TabIndex="1" 
                                                   Width="140px" onselectedindexchanged="DrpUnit_SelectedIndexChanged">
                                               </asp:DropDownList>
                                               <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                                   ControlToValidate="DrpUnit" Display="None" ErrorMessage="Select Unit" 
                                                   ValidationGroup="a">*</asp:RequiredFieldValidator>
                                                    <asp:ValidatorCalloutExtender ID="RequiredFieldValidator4_ValidatorCalloutExtender1" 
                                                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator4">
                                                    </asp:ValidatorCalloutExtender>
                                           </td>
                                           <td align="right">
                                               <asp:Label ID="Label7" runat="server" CssClass="label" Text="Line"></asp:Label>
                                           </td>
                                           <td>
                                               <asp:TextBox ID="txtLine" style="text-transform:uppercase" runat="server" CssClass="textbox" MaxLength="30" 
                                                   onclick="clearlabel('lbltotalinfo');" TabIndex="6" Width="98px"></asp:TextBox>
                                               
                                               <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                                   ControlToValidate="txtLine" Display="None" ErrorMessage="Enter Line" 
                                                   ValidationGroup="a">*</asp:RequiredFieldValidator>
                                                   <asp:ValidatorCalloutExtender ID="RequiredFieldValidator6_ValidatorCalloutExtender1" 
                                                        runat="server" Enabled="True" 
                                                   TargetControlID="RequiredFieldValidator6" >
                                                    </asp:ValidatorCalloutExtender>
                                               
                                           </td>
                                           <td align="right">
                                               <asp:Label ID="Label8" runat="server" CssClass="label" Text="NO of Helpers"></asp:Label>
                                           </td>
                                           <td>
                                               <asp:TextBox ID="txtHelper" runat="server" CssClass="textbox" MaxLength="5" 
                                                   onclick="clearlabel('lbltotalinfo');" TabIndex="6" Width="30px"></asp:TextBox>
                                               <asp:FilteredTextBoxExtender ID="txtHelper_FilteredTextBoxExtender" 
                                                   runat="server" Enabled="True" TargetControlID="txtHelper" 
                                                   ValidChars=".0123456789">
                                               </asp:FilteredTextBoxExtender>
                                           </td>
                                       </tr>
                                       <tr>
                                           <td align="right" colspan="4">
                                               <asp:Label ID="lbllineid" runat="server" Visible="False"></asp:Label>
                                               <asp:Label ID="lblErrormsg" runat="server"></asp:Label>
                                           </td>
                                           <td align="right" colspan="4">
                                               <asp:Button ID="btnClear" runat="server" CssClass="button" TabIndex="50" 
                                                   Text="Clear" Width="100px" onclick="btnClear_Click" />
                                               <asp:Button ID="btnSave" runat="server" CssClass="button" TabIndex="10" 
                                                   Text="Save" ValidationGroup="a" Width="100px" onclick="btnSave_Click" />
                                               <asp:ConfirmButtonExtender ID="btnSave_ConfirmButtonExtender" runat="server" 
                                                   ConfirmText="Do you want to save this data?" Enabled="True" 
                                                   TargetControlID="btnSave">
                                               </asp:ConfirmButtonExtender>
                                           </td>
                                       </tr>
                                   </table>

                                      </div>
                                      </td>
                                 </tr>
                           <tr>
                               <td>
                                  <div class="pnlmain" style="height:360px">
                                  <div class="pnlheader">Line List</div>
                                  <div style="height:325px; overflow:auto">
                                      <asp:GridView ID="GridView1" CssClass="mGrid" runat="server" AutoGenerateColumns="False" 
                                          DataKeyNames="Line_Code"  
                                          AutoGenerateSelectButton="True" onrowcommand="GridView1_RowCommand" 
                                          onpageindexchanging="GridView1_PageIndexChanging" >
                                          <Columns>
                                              <asp:TemplateField Visible="false">
                                              <ItemTemplate>
                                              <asp:Label ID="lblLineID" runat="server" Text='<%# Eval("Line_Code") %>'></asp:Label>
                                              </ItemTemplate>
                                              </asp:TemplateField>
                                              <asp:BoundField DataField="Line_No" HeaderText="Line" 
                                                  SortExpression="Line_No" />   
                                                   <asp:BoundField DataField="cCmpName" HeaderText="Company" 
                                                  SortExpression="cCmpName" />  
                                                   <asp:BoundField DataField="cDeptname" HeaderText="Department" 
                                                  SortExpression="cDeptname" />    
                                                        <asp:BoundField DataField="cSection_Description" 
                                                  HeaderText="Section" SortExpression="cSection_Description" />   
                                                    <asp:BoundField DataField="cFloor_Descriptin" HeaderText="Floor" 
                                                  SortExpression="cFloor_Descriptin" />   
                                                     <asp:BoundField DataField="Unit_Name" HeaderText="Building Unit" 
                                                  SortExpression="Unit_Name" />                               
                                              <asp:BoundField DataField="nMachineOp" HeaderText="Operator" 
                                                  SortExpression="nMachineOp" />
                                              <asp:BoundField DataField="nHelper" HeaderText="Helper" 
                                                  SortExpression="nHelper" />                                          
                                          </Columns>
                                          <PagerSettings FirstPageImageUrl="~/gridimage/_fst.png"
                                      LastPageImageUrl="~/gridimage/_lst.png" Mode="NextPreviousFirstLast" 
                                      NextPageImageUrl="~/gridimage/_next.png" 
                                      PreviousPageImageUrl="~/gridimage/_Prev.png" FirstPageText="First" 
                                      LastPageText="Last" NextPageText="Next" PreviousPageText="Previous" />
                                  <PagerStyle CssClass="grdHdr" Height="18px" Width="22px" />
                                          <HeaderStyle CssClass="grdHdr" />
                                          <AlternatingRowStyle CssClass="grdAltr" />
                                          <SelectedRowStyle CssClass="SelectedRow" />
                                          <RowStyle CssClass="grdRow" />
                                      </asp:GridView>
                                      
                                      </div>
                                  </div>
                                  </td>
                           </tr>
                       </table>
                           
                             
                             </td>
                            
                        </tr>
                    </table>
             
                  
             
        </div>
        </ContentTemplate>
        </asp:UpdatePanel>
       </div>
    
    </div>
    </form>
</body>
</html>

