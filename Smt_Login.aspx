<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Smt_Login.aspx.cs" Inherits="Smt_Login" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/total.css" rel="stylesheet" type="text/css" />
    <script src="jquery/jquery-1.3.2.min.js" type="text/javascript"></script>
    <title>Log In</title>

   <style type="text/css">
        body
        {
           background-image:url(gridimage/bg_site2.jpg);
            /*background-image:url(gridimage/sp1.png);	   */
            }
     .tr
            {
              border:solid 1px silver;
                margin-left:5px;
                height:20px;
                text-transform: uppercase;
                	background: -moz-linear-gradient(top, #EDEFF1, #F3F4F6);
                    background : -webkit-gradient(linear, left top, left bottom, from(#EDEFF1), to(#F3F4F6));
                    background-color:#EDEFF1;
                     -webkit-border-radius: 5px;
                -moz-border-radius: 5px;
                border-radius: 5px;
              
                }
               
                    	 	
    	.login
		{
		     height:430px;
		     width:886px;		   
		     background-color:white;
		     background:url(images/homes.png);
		     vertical-align:middle;
		     text-align:center;
		    }
		    .foot
		    {
		        height:30px;
		        bottom:0px;
		        left:0px;
		        background-color:Blue;
		        position:fixed;
		        width:100%;
		        border-top:3px solid white;
		        -webkit-border-radius: 2px;
                -moz-border-radius: 2px;
                border-radius: 2px;
		        background-image:url(gridimage/mH.jpg);		   
		        color:#93C8E3;     
		        
		        
		        }
        </style>  

    <script type="text/javascript">
        function preventBack() { window.history.forward(); }
        setTimeout("preventBack()", 0);
        window.onunload = function () { null };
    </script>
</head>
<body style="margin:0px">
    <form id="form1" runat="server">
    <div align="center">
        <div class="headerContainer">
            <div class="header" align="center">
                <table style="width:100%;">
                    <tr>
                        <td align="right" valign="top" width="60">

                        &nbsp;&nbsp;</td>
                 
                        <td align="left" valign="top" class="style4">
                            &nbsp;
                            <asp:Label ID="Label3" runat="server" Font-Size="18px" Text="SRT RMG System For" Font-Names="Microsoft Sans Serif" Font-Italic="false" ForeColor="#93C8E3"></asp:Label>
                            <asp:Label ID="lblComName" runat="server" Font-Names="Microsoft Sans Serif" Font-Size="18px" ForeColor="#93C8E3"></asp:Label>
                        &nbsp;
                        </td>
                    <td align="right" valign="middle" width="100px">
                        <asp:Label ID="Label4" runat="server" Text="Login Form" ForeColor="#93C8E3"></asp:Label>
                    </td>
                    <td align="left" valign="middle" width="200">

                    </td>
                           </tr>
                </table>
            </div>
        </div>

        <div align="center">
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <table style="width:100%;">
                        <tr>
                            <td align="center">
                                <table style="width:100%;" align="center">
                                    <tr>
                                        <td align="center" height="60px" valign="middle">
                                            <marquee>
                                                <asp:Label ID="lblJs" runat="server" Font-Bold="True" Font-Italic="True" 
                                      Font-Names="Tahoma" Font-Size="15pt" ForeColor="#51BF7E"></asp:Label></marquee>
                                            <br />
                                        </td> 
                                    </tr>
                                    <tr>
                                        <td align="center" height="100" valign="top">
                                            <table style="width:400px; height:350px;background-image:url('gridimage/MGL2.png')">
                                                <tr>
                                                      <td width="160px">
                                                          &nbsp;</td>
                                                      <td>
                                                          &nbsp;</td>
                                                  </tr>
                                                  <tr>
                                                      <td colspan="2" style="text-align:center; padding-bottom:7px">
                                                          <asp:Label ID="lblcname" runat="server" ForeColor="#ACACAC"></asp:Label>
                                                      </td>
                                                  </tr>
                                                  <tr>
                                                      <td align="center" valign="top">
                                                          &nbsp;</td>
                                                      <td align="left" 
                                                          style="padding-left:7px; padding-top:7px;vertical-align: middle;" rowspan="3" 
                                                          valign="top">
                                                      <asp:Label ID="lblErrormsg" runat="server" Font-Bold="True" ForeColor="#F9F900" 
                                                              Font-Names="Tahoma" Font-Size="14px" Width="170px">Enter valid User ID and Password For Login</asp:Label>

                                                             

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
                                                      <td align="right">
                                                          &nbsp;</td>
                                                      <td align="left" valign="top">
                                                          &nbsp;</td>
                                                  </tr>
                                                <tr>
                                                    <td align="right">
                                                        &nbsp;
                                                    </td>
                                                    <td align="left" style="padding-left:4px" height="25px">
                                                        <asp:UpdateProgress ID="updateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                                                            <ProgressTemplate>
                                                                <img alt="Loading" height="22px" src="images/loader.gif" /><br />
                                                            </ProgressTemplate>
                                                        </asp:UpdateProgress>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="right">
                                                      <asp:Label ID="Label1" runat="server"  Font-Names="Tahoma" 
                                                          Font-Size="10pt" Text="User ID" ForeColor="White"></asp:Label>
                                                      </td>
                                                     <td align="left">
                                                      <asp:TextBox ID="txtUserid" runat="server" CssClass="tr"  MaxLength="10" 
                                                          Width="150px"></asp:TextBox>
                                                      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                          ControlToValidate="txtUserid" Display="None" ErrorMessage="Enter User ID" 
                                                          ValidationGroup="a">*</asp:RequiredFieldValidator>
                                                      <asp:ValidatorCalloutExtender ID="RequiredFieldValidator1_ValidatorCalloutExtender" 
                                                          runat="server" Enabled="True" TargetControlID="RequiredFieldValidator1">
                                                      </asp:ValidatorCalloutExtender>
                                                       
                                                      </td>
                                                </tr>
                                                <tr>
                                                      <td align="right">
                                                      <asp:Label ID="Label2" runat="server" Font-Names="Tahoma" Font-Size="10pt" 
                                                          Text="Password" ForeColor="White"></asp:Label>
                                                      </td>
                                                      <td align="left">
                                                      <asp:TextBox ID="txtPassword" runat="server" CssClass="tr" MaxLength="10" TextMode="Password" 
                                                          Width="150px"></asp:TextBox>
                                                      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                          ControlToValidate="txtPassword" Display="None" ErrorMessage="Enter Password" 
                                                          ValidationGroup="a">*</asp:RequiredFieldValidator>
                                                      <asp:ValidatorCalloutExtender ID="RequiredFieldValidator2_ValidatorCalloutExtender" 
                                                          runat="server" Enabled="True" TargetControlID="RequiredFieldValidator2">
                                                      </asp:ValidatorCalloutExtender>
                                                      </td>
                                                  </tr>
                                                <tr>
                                                      <td>
                                                          &nbsp;</td>
                                                      <td align="left" style="padding-left:6px">
                                                      <asp:Button ID="btnLogin" runat="server" onclick="btnLogin_Click" Text="Log In" 
                                                          Width="74px" ValidationGroup="a" CssClass="button" />
                                                      <input id="Button1" type="button" style="width:74px" onclick="window.close()" value="Exit" class="button" /></td>
                                                  </tr>
                                                  <tr>
                                                      <td>
                                                          &nbsp;</td>
                                                      <td>
                                                          &nbsp;</td>
                                                  </tr>
                                            </table> 
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" height="100" valign="middle">
                                            <asp:Label ID="lblBrowserinfo" runat="server" Font-Bold="True" Font-Italic="True" 
                                      Font-Names="Tahoma" Font-Size="15pt" ForeColor="Red"></asp:Label>
                                    <br />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        <div class="foot">
            SRTASEEN INFOSOFT LTD.
        </div>
    </div>
    </form>
</body>
</html>
