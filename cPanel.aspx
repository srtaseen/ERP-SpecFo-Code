<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="cPanel.aspx.cs" Inherits="cPanel" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script type="text/javascript">
        function adexpns() {
            onunload();   
        $("#hdrtxt").html("Update Item Quantity");
        $("#ifupldfile").attr("src", "Master_Setup/MnchngItmqty.aspx");
       // $("#hdrtxt").html("Add Expanse");
        var bid = $find('ppadditm');
        bid.show();
    }
   
    function stlcncl() {
        onunload();
        //document.getElementById("txtchkjv").value = "3";
        $("#hdrtxt").html("Cancel Style");
        $("#ifupldfile").attr("src", "Master_Setup/StyleCancel.aspx");
        var bid = $find('ppadditm');
        bid.show();
    }
    function hideLoading() {
        document.getElementById('divLoading').style.display = "none";
        document.getElementById('divFrameHolder').style.display = "block";
    }
    function onunload() {
        document.getElementById('divLoading').style.display = "block";
        document.getElementById('divFrameHolder').style.display = "none";
    }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
    <ContentTemplate>
        <table style="width: 100%;">
            <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td width="150px">
                  <div class="pnlmain" style="height:265px">
                  <div class="pnlheader">Message Type</div>
                      <table style="width: 100%;">
                          <tr>
                              <td>
                                  &nbsp;
                              </td>
                          </tr>
                          <tr>
                              <td>
                                  &nbsp;
                                  <asp:RadioButton ID="rdmsgtpnormal" runat="server" Checked="True" GroupName="m" 
                                      Text="Normal" />
                              </td>
                          </tr>
                          <tr>
                              <td>
                                  &nbsp;
                                  <asp:RadioButton ID="rdmsgtppp" runat="server" GroupName="m" Text="Alert Box" />
                              </td>
                          </tr>
                          <tr>
                              <td>
                                  &nbsp;</td>
                          </tr>
                          <tr>
                              <td>
                                  &nbsp;</td>
                          </tr>
                          <tr>
                              <td align="center">
                                  <asp:Button ID="btnMsgtype" runat="server" CssClass="button" Text="Save" 
                                      Width="80px" onclick="btnMsgtype_Click" />
                              </td>
                          </tr>
                      </table>
                  </div>
                </td>
                <td width="400px">
                   <div class="pnlmain" style="height:265px">
                  <div class="pnlheader">Email Configuration</div>
                  <div style="padding:5px">
                       <table style="width: 100%;">
                           <tr>
                               <td align="right" class="label">
                                   Domain Name</td>
                               <td>
                                   <asp:TextBox ID="txtDomainname" runat="server" CssClass="textbox" Width="200px" 
                                       MaxLength="50"></asp:TextBox>
                                   <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                                                        ControlToValidate="txtDomainname" ErrorMessage="Enter Domain Name" 
                                                        ValidationGroup="a" Display="None">*</asp:RequiredFieldValidator>
                                                    <asp:ValidatorCalloutExtender ID="RequiredFieldValidator9_ValidatorCalloutExtender" 
                                                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator9">
                                                    </asp:ValidatorCalloutExtender>
                               </td>
                           </tr>
                           <tr>
                               <td align="right" class="label">
                                 Domain Port No</td>
                               <td>
                                 
                                   <asp:TextBox ID="txtport" runat="server" CssClass="textbox" Width="200px" 
                                       MaxLength="5"></asp:TextBox>                                   
                                   <asp:RequiredFieldValidator ID="txtport_RequiredFieldValidator1" runat="server" 
                                                        ControlToValidate="txtport" ErrorMessage="Enter Port No" 
                                                        ValidationGroup="a" Display="None">*</asp:RequiredFieldValidator>
                                                    <asp:ValidatorCalloutExtender ID="ValidatorCalloutExtender1" 
                                                        runat="server" Enabled="True" TargetControlID="txtport_RequiredFieldValidator1">
                                                    </asp:ValidatorCalloutExtender>
                               </td>
                           </tr>
                           <tr>
                               <td align="right" class="label">
                                   Domain Email Address</td>
                               <td>
                                 
                                   <asp:TextBox ID="txtEmail" runat="server" CssClass="textbox" Width="200px" 
                                       MaxLength="50"></asp:TextBox>
                                   <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                                        ControlToValidate="txtEmail" ErrorMessage="Enter Valid Email ID" 
                                                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                                                        ValidationGroup="a" Display="None">*</asp:RegularExpressionValidator>
                                                    <asp:ValidatorCalloutExtender ID="RegularExpressionValidator1_ValidatorCalloutExtender" 
                                                        runat="server" Enabled="True" TargetControlID="RegularExpressionValidator1">
                                                    </asp:ValidatorCalloutExtender>                                                   
                                                    <asp:RequiredFieldValidator ID="txtEmail_RequiredFieldValidator1" runat="server" 
                                                        ControlToValidate="txtEmail" ErrorMessage="Enter Email Address" 
                                                        ValidationGroup="a" Display="None">*</asp:RequiredFieldValidator>
                                                    <asp:ValidatorCalloutExtender ID="ValidatorCalloutExtender2" 
                                                        runat="server" Enabled="True" TargetControlID="txtEmail_RequiredFieldValidator1">
                                                    </asp:ValidatorCalloutExtender>
                               </td>
                           </tr>
                           <tr>
                               <td align="right" class="label">
                                   Email Password</td>
                               <td>
                                   <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" CssClass="textbox" 
                                    MaxLength="10" Width="200px"></asp:TextBox>
                                  <%-- <asp:PasswordStrength ID="txtPassword_PasswordStrength" runat="server" 
                                       Enabled="True" TargetControlID="txtPassword">
                                   </asp:PasswordStrength>--%>
                                   <asp:RequiredFieldValidator ID="txtPassword_RequiredFieldValidator1" runat="server" 
                                                        ControlToValidate="txtPassword" ErrorMessage="Enter Email Password" 
                                                        ValidationGroup="a" Display="None">*</asp:RequiredFieldValidator>
                                                    <asp:ValidatorCalloutExtender ID="ValidatorCalloutExtender3" 
                                                        runat="server" Enabled="True" TargetControlID="txtPassword_RequiredFieldValidator1">
                                                    </asp:ValidatorCalloutExtender>
                               </td>
                           </tr>
                           <tr>
                               <td align="right" class="label">
                                   Message Subject</td>
                               <td>
                                   <asp:TextBox ID="txtSubject" runat="server" CssClass="textbox" MaxLength="20" 
                                       Width="200px"></asp:TextBox>
                               </td>
                           </tr>
                           <tr>
                               <td align="right" class="label">
                                   Message Body</td>
                               <td rowspan="2" valign="top">
                                   <asp:TextBox ID="txtbody" runat="server" CssClass="textbox" MaxLength="20" 
                                       TextMode="MultiLine" Width="200px"></asp:TextBox>
                               </td>
                           </tr>
                           <tr>
                               <td align="right">
                                   &nbsp;</td>
                           </tr>
                           <tr>
                               <td align="right">
                                   &nbsp;</td>
                               <td>
                                   <asp:Button ID="btnSaveEmailconfig" runat="server" CssClass="button" 
                                       onclick="btnSaveEmailconfig_Click" Text="Save" ValidationGroup="a" 
                                       Width="80px" />
                                   <asp:ConfirmButtonExtender ID="btnSaveEmailconfig_ConfirmButtonExtender" 
                                       runat="server" ConfirmText="Do you want to save this data?" Enabled="True" 
                                       TargetControlID="btnSaveEmailconfig">
                                   </asp:ConfirmButtonExtender>
                               </td>
                           </tr>
                       </table>
                       </div>
                  </div>
                </td>
                <td>
                  <div class="pnlmain" style="height:265px">
                  <div class="pnlheader">Company Logo</div>
                  <div style="padding:5px">
                       <table style="width: 100%;">
                           <tr>
                               <td align="right" class="label" style="vertical-align:top; text-align:left;">                                  
                                  <asp:Image ID="Image2" ToolTip="Company Logo" style="border:5px solid silver" 
                                       runat="server" Height="130px" Width="130px" />
                               </td>
                           </tr>
                           <tr>
                               <td align="right" style="text-align:left">
                                   <asp:ConfirmButtonExtender ID="ConfirmButtonExtender1" runat="server" 
                                       ConfirmText="Do you want to save this data?" Enabled="True" 
                                       TargetControlID="btnSaveEmailconfig">
                                   </asp:ConfirmButtonExtender>
                                   <asp:FileUpload ID="FileUpload1" runat="server" />
                               </td>
                           </tr>
                           <tr>
                               <td align="right" style="text-align:left">
                                   <asp:Button ID="btnUpload" runat="server" onclick="btnUpload_Click" 
                                       Text="Upload" CssClass="button" />
                               </td>
                           </tr>
                           <tr>
                              <td style="color:green;">*File format(jpg,gif,png,pdf)</td>
                           </tr>
                       </table>
                       </div>
                  </div>
                </td>
                <td>
                  <div class="pnlmain" style="height:265px; width:230px">
                  <div class="pnlheader">Add User Signature</div>
                      <table style="width: 100%;">
                          <tr>
                              <td style="text-align: center">
                                   User Name</td>
                          </tr>
                          <tr>
                              <td>
                                
                                  <asp:DropDownList ID="drpuser" runat="server" Width="200px" AutoPostBack="True" 
                                      CssClass="textbox" onselectedindexchanged="drpuser_SelectedIndexChanged">
                                  </asp:DropDownList>
                              </td>
                          </tr>
                          <tr>
                              <td style="text-align: center">
                                 User ID</td>
                          </tr>
                          <tr>
                              <td>
                                  <asp:TextBox ID="txtuserid" runat="server" Width="200px" CssClass="textbox" 
                                      Enabled="False"></asp:TextBox>
                              </td>
                          </tr>
                          <tr>
                              <td>
                                  <asp:FileUpload ID="uplsign" runat="server" />
                              </td>
                          </tr>
                          <tr>
                              <td>
                                  <asp:Button ID="btnuploadusersig" runat="server" CssClass="button" 
                                      Text="Upload" onclick="btnuploadusersig_Click" />
                              </td>
                          </tr>
                          <tr>
                              <td style="height: 40px">
                                  <asp:Image ID="imgsignature" runat="server" Height="40px" Width="130px" 
                                      Visible="False" />
                              </td>
                          </tr>
                          <tr>
                             <td style="color:green;">*File format(jpg,gif,png)<br />
                             *File Size(250x70px)
                             </td>
                          </tr>
                      </table>
                  </div>
                  </td>
            </tr>
            <tr>
                <td>
                    <input id="Button1" onclick="adexpns();" type="button" value="Update Item Quantity" style="width: 160px" class="button" />
                    <asp:Button ID="Button2" style="display:none" runat="server" Text="Button" />
                    <asp:ModalPopupExtender ID="Button2_ModalPopupExtender" runat="server" 
                        DynamicServicePath="" CancelControlID="cnclitmpdt" OkControlID="cnclitmpdt" 
                        BackgroundCssClass="ModalPopupBG" 
                        BehaviorID="ppadditm" 
                        PopupControlID="ppgenpo" 
                        Enabled="True" 
                        TargetControlID="Button2">
                    </asp:ModalPopupExtender>
                    </td>
                <td>
                  
                   </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>                 
                    <input id="Button3" onclick="stlcncl();" type="button" 
                        value="Style Cancel" style="width: 160px" class="button" />
                </td>
                <td>
                    &nbsp;
                    <asp:Label ID="lblErrmsg" runat="server"></asp:Label>
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="btnUpload" />
            <asp:PostBackTrigger ControlID="btnuploadusersig" />
        </Triggers>
    </asp:UpdatePanel>
     <div id="ppgenpo" style="height:530px; width:910px; display:none; border:5px solid #64AFEA;background-color:#e9f0fb;-webkit-border-radius: 5px; -moz-border-radius: 5px;border-radius: 5px;">
    <div class="pppnlhdr">
    <div id="hdrtxt" style="float:left; padding-left:20px; color:White">Generate PO</div>
    <div style="float:right; padding-top:2px; padding-right:2px"> 
        <input id="txtchkjv" style="display:none" type="text" />
        <img id="cnclitmpdt" onclick="refreshgpo();" style="cursor:pointer" alt="" src="gridimage/grdRemove.png" />
    </div>
    </div>
     <div id="divLoading" style="width:600px; text-align:center; vertical-align:bottom; margin-top:200px"> 
       <img src="images/loader.gif" alt="" /> 
     </div>
     <div id="divFrameHolder" style="display:none">
    <iframe id="ifupldfile" onload="hideLoading()" src="" style="border:none" width="900px" height="500px"></iframe>
    </div>
    </div>


    <%--<div id="Itmqtyupdt" style="height:550px; width:800px; border:1px solid #64AFEA;background-color:#F2F9FF; display:none">
    <div class="pppnlhdr" style="height:20px; width:100%" >
    <div style="float:left; padding-left:10px; color:white">Edit Item Quantity</div>
    <div style="float:right; padding-right:5px">
        <img id="cnclitmpdt" alt="" src="../gridimage/grdRemove.png" /></div>
    </div>
    <iframe id="ifadditm" height="500px" width="750px" style="border:none"></iframe>
    </div>--%>

</asp:Content>

