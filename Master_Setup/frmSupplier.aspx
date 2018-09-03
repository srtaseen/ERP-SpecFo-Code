<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmSupplier.aspx.cs" Inherits="Master_Setup_frmSupplier" %>

<%@ Register assembly="C1.Web.UI.Controls.4" namespace="C1.Web.UI.Controls.C1GridView" tagprefix="cc1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<%@ Register assembly="C1.Web.UI.Controls.4" namespace="C1.Web.UI.Controls.C1TabControl" tagprefix="cc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="../css/total.css" rel="stylesheet" type="text/css" />
    <link href="../css/Master_Setup.css" rel="stylesheet" type="text/css" />
</head>
<body style="margin:0px" onkeydown = "return (event.keyCode!=13)">
    <form id="form1" runat="server">
      <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
       <div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>     
                 <cc2:C1TabControl ID="C1TabControl1" runat="server" width="100%"                    
                TextImageRelation="ImageBeforeText" onclienttabmouseenter="clr">
               <TabPages>
                <cc2:C1TabPage ID="C1TabPage1" TabIndex="0" Text="Add New Supplier" CssClass="tab">             
                   <table style="width:100%;">
                        <tr>
                            <td valign="top" width="450px">
                             <div class="pnlmain" style="height:380px">
                             <div class="pnlheader"></div>
                             <table style="width:100%;">
                                 <tr>
                                     <td align="right">
                                         <asp:Label ID="Label7" runat="server" CssClass="label" Text="Type"></asp:Label>
                                     </td>
                                     <td>
                                         <asp:DropDownList ID="drpSuppliertype" runat="server" AutoPostBack="True" 
                                             CssClass="textbox" onclick="clearlabel('lbltotalinfo');" 
                                             OnSelectedIndexChanged="drpSuppliertype_SelectedIndexChanged" TabIndex="1" 
                                             Width="200px">
                                         </asp:DropDownList>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                             ControlToValidate="drpSuppliertype" Display="None" ErrorMessage="Select Type" 
                                             ValidationGroup="v">*</asp:RequiredFieldValidator>
                                         <asp:ValidatorCalloutExtender ID="RequiredFieldValidator1_ValidatorCalloutExtender" 
                                             runat="server" Enabled="True" TargetControlID="RequiredFieldValidator1">
                                         </asp:ValidatorCalloutExtender>
                                         <asp:Label ID="lblsuplierid" runat="server" Visible="False"></asp:Label>
                                          
                                     </td>
                                 </tr>
                           <tr>
                               <td align="right">
                                   <asp:Label ID="Label4" runat="server" CssClass="label" Text="Code"></asp:Label>
                               </td>
                               <td>
                                   <asp:TextBox ID="txtCode" runat="server" CssClass="textbox" Enabled="False" 
                                       TabIndex="2" Width="200px"></asp:TextBox>
                               </td>
                           </tr>
                           <tr>
                               <td align="right">
                                   <asp:Label ID="Label8" runat="server" CssClass="label" Text="Name"></asp:Label>
                               </td>
                               <td>
                                   <asp:TextBox ID="txtName" runat="server" CssClass="textbox" MaxLength="50" 
                                       onclick="clearlabel('lbltotalinfo');" TabIndex="3" Width="200px"></asp:TextBox>
                                   <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                       ControlToValidate="txtName" Display="None" ErrorMessage="Enter Name" 
                                       ValidationGroup="v">*</asp:RequiredFieldValidator>
                                   <asp:ValidatorCalloutExtender ID="RequiredFieldValidator2_ValidatorCalloutExtender" 
                                       runat="server" Enabled="True" TargetControlID="RequiredFieldValidator2">
                                   </asp:ValidatorCalloutExtender>
                               </td>
                           </tr>
                           <tr>
                               <td align="right">
                                   <asp:Label ID="Label9" runat="server" CssClass="label" Text="Address"></asp:Label>
                               </td>
                               <td rowspan="2" valign="top">
                                   <asp:TextBox ID="txtAddress" runat="server" CssClass="textbox" MaxLength="50" 
                                       onclick="clearlabel('lbltotalinfo');" TabIndex="4" TextMode="MultiLine" 
                                       Width="198px"></asp:TextBox>
                               </td>
                           </tr>
                           <tr>
                               <td>
                                   &nbsp;</td>
                           </tr>
                           <tr>
                               <td align="right">
                                   <asp:Label ID="Label10" runat="server" CssClass="label" Text="Country"></asp:Label>
                               </td>
                               <td>
                                   <asp:DropDownList ID="drpCountry" runat="server" CssClass="textbox" 
                                       DataTextField="cConDes" DataValueField="cCntcd" 
                                       onclick="clearlabel('lbltotalinfo');" TabIndex="5" Width="203px">
                                   </asp:DropDownList>
                               </td>
                           </tr>
                           <tr>
                               <td align="right">
                                   <asp:Label ID="Label11" runat="server" CssClass="label" Text="Contact No"></asp:Label>
                               </td>
                               <td>
                                   <asp:TextBox ID="txtContact" runat="server" CssClass="textbox" MaxLength="30" 
                                       onclick="clearlabel('lbltotalinfo');" TabIndex="6" Width="200px"></asp:TextBox>
                               </td>
                           </tr>
                           <tr>
                               <td align="right">
                                   <asp:Label ID="Label12" runat="server" CssClass="label" Text="Attention"></asp:Label>
                               </td>
                               <td>
                                   <asp:TextBox ID="txtAttention" runat="server" CssClass="textbox" MaxLength="30" 
                                       onclick="clearlabel('lbltotalinfo');" TabIndex="7" Width="200px"></asp:TextBox>
                               </td>
                           </tr>
                           <tr>
                               <td align="right">
                                   <asp:Label ID="Label13" runat="server" CssClass="label" Text="E-Mail"></asp:Label>
                               </td>
                               <td>
                                   <asp:TextBox ID="txtEmail" runat="server" CssClass="textbox" MaxLength="30" 
                                       onclick="clearlabel('lbltotalinfo');" TabIndex="8" Width="200px"></asp:TextBox>
                                   <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                       ControlToValidate="txtEmail" Display="None" 
                                       ErrorMessage="Enter Valid Email Address." 
                                       ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                                       ValidationGroup="v">*</asp:RegularExpressionValidator>
                                   <asp:ValidatorCalloutExtender ID="RegularExpressionValidator1_ValidatorCalloutExtender" 
                                       runat="server" Enabled="True" TargetControlID="RegularExpressionValidator1">
                                   </asp:ValidatorCalloutExtender>
                               </td>
                           </tr>
                           <tr>
                               <td align="right">
                                   <asp:Label ID="Label14" runat="server" CssClass="label" Text="Supplier ValtNo"></asp:Label>
                               </td>
                               <td>
                                   <asp:TextBox ID="txtCod" runat="server" CssClass="textbox" MaxLength="10" 
                                       onclick="clearlabel('lbltotalinfo');" TabIndex="9" Width="200px"></asp:TextBox>
                               </td>
                           </tr>
                           <tr>
                               <td align="right">
                                   Supplier Account No</td>
                               <td>
                                   <asp:TextBox ID="txtAcntno" runat="server" CssClass="textbox" MaxLength="20" 
                                       TabIndex="9" Width="200px"></asp:TextBox>
                               </td>
                           </tr>
                                 <tr>
                                     <td>
                                         &nbsp;</td>
                                     <td>
                                         <asp:Label ID="lblErrmsg" runat="server"></asp:Label>
                                     </td>
                                 </tr>
                           <tr>
                               <td>
                                   &nbsp;</td>
                               <td>
                                   <asp:Button ID="btnClear" runat="server" CssClass="button" 
                                       onclick="btnClear_Click" TabIndex="50" Text="Clear" Width="100px" />
                                   <asp:Button ID="btnSave" runat="server" CssClass="button" 
                                       onclick="btnSave_Click" TabIndex="10" Text="Save" ValidationGroup="v" 
                                       Width="100px" />
                                   <asp:ConfirmButtonExtender ID="btnSave_ConfirmButtonExtender" runat="server" 
                                       ConfirmText="Do you want to Save?" Enabled="True" TargetControlID="btnSave">
                                   </asp:ConfirmButtonExtender>
                                   <asp:Button ID="btnUpdate" runat="server" CssClass="button" 
                                       onclick="btnUpdate_Click" TabIndex="11" Text="Update" ValidationGroup="v" 
                                       Visible="False" Width="100px" />
                                   <asp:ConfirmButtonExtender ID="btnUpdate_ConfirmButtonExtender" runat="server" 
                                       ConfirmText="Do you want to Update?" Enabled="True" TargetControlID="btnUpdate">
                                   </asp:ConfirmButtonExtender>
                                     
                               </td>
                           </tr>
                       </table>
                             </div>
                             
                             </td>
                            <td valign="top">
                             
                              <table width="100%">
                              <tr class="pnlheader">
                              <td>
                              <table>
                              <tr>
                              <td>Select</td>
                              <td>Main Category</td>
                              </tr>
                              </table>
                              </td>
                              </tr>
                               <tr>
                              <td>
                               <div style="border:1px solid silver; height:360px; overflow:auto">
                                 <asp:GridView ID="GridView1" ShowHeader="false" runat="server" AutoGenerateColumns="False" 
                             CssClass="mGrid" DataKeyNames="nMainCategory_ID" 
                             ShowFooter="True" Width="98%">
                             <AlternatingRowStyle CssClass="grdAltr" />
                             <Columns>
                                 <asp:TemplateField HeaderText="Select">
                                     <ItemTemplate>
                                         <asp:CheckBox ID="chkslect" runat="server" />

                                              <asp:ToggleButtonExtender ID="CheckBox1_ToggleButtonExtender" runat="server" 
                                                                Enabled="True" CheckedImageUrl="~/gridimage/CheckbCheck.png" ImageHeight="19" ImageWidth="19"
                                                                 UncheckedImageUrl="~/gridimage/CheckBuncheck.gif" TargetControlID="chkslect">
                                                          </asp:ToggleButtonExtender>

                                         <asp:Label ID="lblid" runat="server" Text='<%# Eval("nMainCategory_ID") %>' 
                                             Visible="false"></asp:Label>
                                     </ItemTemplate>
                                 </asp:TemplateField>
                                 <asp:BoundField DataField="cMainCategory" HeaderText="Main Caetegroy" 
                                     SortExpression="cMainCategory" />
                             </Columns>
                             <FooterStyle CssClass="grdHdr" />
                             <HeaderStyle CssClass="grdHdr" />
                             <RowStyle CssClass="grdRow" />
                         </asp:GridView>
                       
                              </td>
                              </tr>
                            

                              </table>

                      
                      
                              
                              </td>
                        </tr>
                    </table>
             
                  
                </cc2:C1TabPage>
                <cc2:C1TabPage ID="C1TabPage2"  TabIndex="1" Text="Edit/View"  CssClass="tab">
                <div class="pnlmain" style="height:400px">
                   <cc1:C1GridView ID="C1GridView1" runat="server" AllowColMoving="True" 
                              AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" 
                              AutoGenerateSelectButton="True"  
                              onrowcommand="C1GridView1_RowCommand" onrowdatabound="C1GridView1_RowDataBound" 
                              ShowFilter="True" VisualStyle="Office2007Blue" 
                              VisualStylePath="~/C1WebControls/VisualStyles" Width="100%" 
                        PageSize="23" OnFiltering="C1GridView1_Filtering" OnPageIndexChanging="C1GridView1_PageIndexChanging" 
                        >
                              <Columns>
                                  <cc1:C1BoundField DataField="cSupCode" HeaderText="Supplier Code">
                                  </cc1:C1BoundField>
                                  <cc1:C1BoundField DataField="cSupName" HeaderText="Name">
                                  </cc1:C1BoundField>
                                  <cc1:C1BoundField DataField="cSupAdd1" HeaderText="Address 1" 
                                      ShowFilter="false">
                                  </cc1:C1BoundField>
                              </Columns>
                              <PagerSettings PageButtonCount="25" />
                          </cc1:C1GridView>
                          
                                      
                    <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:mconinventory %>" 
                        SelectCommand="SELECT [nCode], [cSupCode], [cSupName], [cSupAdd1], [cSupAdd2] FROM [Smt_Suppliers] ORDER BY [cSupName]">
                    </asp:SqlDataSource>--%>
                          
                                      
                </div>                          
                </cc2:C1TabPage>      
            </TabPages>
                </cc2:C1TabControl>  
        
        
        
        
        
        
        </div>
       

                               <%--     <asp:updateprogress ID="updateProgress1" runat="server" 
                                     associatedupdatepanelid="UpdatePanel1">
                                     <progresstemplate>
                                     <img alt="Loading" height="22px" width="22px" src="../gridimage/loading19.gif" /><br />
                                      </progresstemplate>
                                     </asp:updateprogress> --%>
                                
           


        </ContentTemplate>
        </asp:UpdatePanel>
       </div>
    
    </div>
    </form>
</body>
</html>

