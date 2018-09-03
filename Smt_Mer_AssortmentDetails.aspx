<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Smt_Mer_AssortmentDetails.aspx.cs" Inherits="Smt_Mer_AssortmentDetails_New" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
.dvstl
{
    width:830px; 
    background-color:#AEE4F5; 
    height:460px; 
    border:3px solid #3A9DC1; 
    display:none; 
    position:absolute;
    -webkit-border-radius: 3px;
    -moz-border-radius: 3px;
    border-radius: 3px;
    background-color:#AEE4F5;
	/*filter: alpha(opacity=50);
	opacity: 0.5;*/
	top:115px;
	
   
    }
    .menu 
{
    margin: 0;
	padding: 0;
	list-style: none;
	width: auto;
	height: auto;

}
.menu > li > a {
	
	border-bottom: 1px solid #77C6E9;	
	width: 100%;
	
	font-size:12px;
	display: block;
	padding-left:6px;
	padding-top:3px;
	padding-bottom:3px;
	position: relative;
	font-family: "Helvetica Neue", Helvetica, Arial, sans-serif;
	text-decoration:none;
	color:#1C80AE;
	
}

.menu ul li:last-child a {
	border-bottom: 1px solid #33373d;
}
.menu > li > a:hover, .menu > li > a.active {
	background-color:#F3D6F2;
	            border-bottom: 1px solid #D56CD0;   
	            border-top: 1px solid #D56CD0;                
                color: #AE31A8;
                padding-top:2px;
	
                
            }
.menu > li > a.active {
	border-bottom: 1px solid #D56CD0;
	 border-top: 1px solid #D56CD0;  
}
.hdr
{
    -webkit-border-radius: 3px;
    -moz-border-radius: 3px;
    border-radius: 3px;
    background-color:#27A3DD; color:White; padding-top:2px;
    padding-bottom:2px;
    padding-left:10px;
    font-family:Tahoma;
    font-size:14px;
    }
        #Button1
        {
            width: 105px;
        }
        #Button2
        {
            width: 105px;
        }
        #Button3
        {
            width: 105px;
        }
        .btnind
        {
    -webkit-border-radius: 3px;
    -moz-border-radius: 3px;
    border-radius: 3px;
    width:140px; padding:3px;
    font-family:Tahoma;
    font-size:9px;
    
            }
           
.lnlmn
{
    display:block;
    padding-bottom:4px; 
    border-bottom:1px solid #58B6D8; 
    text-decoration:none; 
    width:100%;
    text-align: left; 
    font-family:Tahoma;
    font-size: 12px; 
    color: black;
    
    }
    .lnlmn:hover
    {
        color:Red;
        border-bottom:1px solid red; 
       
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <table style="width: 100%;">
            <tr>
                <td style="width:170px; vertical-align:top">
                   <div style="border-right:1px solid #51B5E3; padding-right:3px">
                   <table style="width:100%">
                        <tr><td style="height:24px;background-image: url('images/cl.png'); background-repeat: no-repeat;"></td></tr>
                        <tr><td><a onclick="addcolor();" class="lnlmn" href="#">Add/Edit Color</a></td></tr>
                        <tr><td><a onclick="Addsize();" style="border-bottom:none" class="lnlmn" href="#">Add/Edit Size</a></td></tr>
                        <tr><td style="height:24px;background-image: url('images/pk.png'); background-repeat: no-repeat;"></td></tr>

                        <tr><td><a class="lnlmn" onclick="addqty();" href="#">Add Pack Qty </a></td></tr>
                        <tr><td><a class="lnlmn" onclick="viewpackwise();" href="#">View Pack Qty</a></td></tr>
                        <tr><td><a class="lnlmn" onclick="packwiserpt();" href="#">Pack Wise Report</a></td></tr>
                        <tr><td><a class="lnlmn" onclick="countrywiserpt();" href="#">Country Wise Report</a></td></tr>
                        <tr><td><a class="lnlmn" onclick="colsizewiseprice();" href="#">Color/Size Wise Price</a></td></tr>
                        <tr><td><a class="lnlmn" style="border-bottom:none" onclick="colsizewisepricerpt();" href="#">Color/Size Wise Price Rpt</a></td></tr>

                        <tr><td style="height:24px;background-image: url('images/insm.png'); background-repeat: no-repeat;"></td></tr>
                        <tr><td><a class="lnlmn" onclick="addinseamsize();" href="#">Add/Edit Inseam Size </a></td></tr>
                        <tr><td><a class="lnlmn" onclick="insmqty();" href="#">Inseam Qty</a></td></tr>
                        <tr><td><a class="lnlmn" style="border-bottom:none" onclick="insmrpt();" href="#">Inseam Report</a></td></tr>

                        <tr><td style="height:24px;background-image: url('images/brkdn.png'); background-repeat: no-repeat;"></td></tr>
                        <tr><td><a class="lnlmn" onclick="breakdown();" href="#">View Breakdown </a></td></tr>
                        <tr><td><a class="lnlmn" style="border-bottom:none" onclick="breakdwonrpt();" href="#">Breakdown Report</a></td></tr>

                         <tr><td style="height:24px;background-image: url('images/stlsm.png'); background-repeat: no-repeat;"></td></tr>
                        <tr><td><a class="lnlmn" onclick="stylestatus();" href="#">View Style Summery </a></td></tr>
                        <tr><td><a class="lnlmn" onclick="stlsum();" href="#">Style Summery Report</a></td></tr>
                       
                       

                   </table>
                    </div>
                </td>
                <td style="vertical-align:top;"">
                <div style="padding-left:5px; border-bottom:1px solid #51B5E3; padding-bottom:8px">
                    <table style="width:100%;">
                        <tr>
                            <td class="label">
                                Style No</td>
                            <td>
                                <asp:DropDownList ID="drpstyle" runat="server" 
                                    CssClass="textboxforgridview" Width="180px" AutoPostBack="True" 
                                    onselectedindexchanged="drpstyle_SelectedIndexChanged">
                                </asp:DropDownList>
                                <img alt="View Style Details" title="View Style Details" id="btnsrc" onclick="itmedt();" visible="false" runat="server" src="gridimage/src.png" style="width: 13px; cursor:pointer;" />
                                
                            </td>
                            <td class="label">
                                Brand</td>
                            <td>
                                <asp:TextBox ID="txtBrand" runat="server" CssClass="textboxforgridview" 
                                    Width="160px" Enabled="False"></asp:TextBox>
                            </td>
                            <td class="label">
                                Gmt Type</td>
                            <td>
                                <asp:TextBox ID="txtGmttype" runat="server" CssClass="textboxforgridview" 
                                    Width="160px" Enabled="False"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="label">
                                Buyer
                                <div id="dvstldtl" class="dvstl">
                                <iframe id="ifrmst" src="" style="border:none" width="840px" height="500px"></iframe>
                                </div>
                                </td>
                            <td>
                                <asp:TextBox ID="txtBuyer" runat="server" CssClass="textboxforgridview" 
                                    Width="180px" Enabled="False"></asp:TextBox>
                                <asp:TextBox ID="txtLot" style="display:none" runat="server" Width="20px"></asp:TextBox>
                            </td>
                            <td class="label">
                                Season</td>
                            <td>
                                <asp:TextBox ID="txtSeason" runat="server" CssClass="textboxforgridview" 
                                    Width="160px" Enabled="False"></asp:TextBox>
                            </td>
                            <td class="label">
                                Gmt Dept</td>
                            <td>
                                <asp:TextBox ID="txtGmtdept" runat="server" CssClass="textboxforgridview" 
                                    Width="160px" Enabled="False"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                    </div>
                <div style="text-align: left; padding-left:5px; margin-top:10px">
                 
                    <table style="width:100%;">
                        <tr>
                            <td style="width: 570px; vertical-align:top">
                               <div style="height:440px; overflow:auto">
                                  <asp:GridView ID="grdpodtl" runat="server" AutoGenerateColumns="false" 
                                       CssClass="mGrid" onrowdatabound="grdpodtl_RowDataBound" 
                        >
                        <Columns>
                        <asp:TemplateField HeaderText="Select">
                            <ItemTemplate>
                                <asp:RadioButton ID="rdChk" runat="server" GroupName="c" onclick="javascript:CheckOtherIsCheckedByGVID(this);" />
                                <asp:TextBox ID="txtslno" runat="server" style="display:none" 
                                    Text='<%# Eval("cOrderNu") %>'></asp:TextBox>
                            </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="cOrderNu" HeaderText="Lot" />
                            <asp:BoundField DataField="cPoNum" HeaderText="PO No" />
                            <asp:BoundField DataField="nOrdQty" HeaderText="Order Qty" />
                            <asp:BoundField DataField="ntot" HeaderText="Assorted Qty" />
                            <asp:BoundField DataField="Rest" HeaderText="Rest Qty" />
                            <asp:BoundField DataField="DXfty" DataFormatString="{0:dd-MMM-yyyy}" 
                                HeaderText="FOB Date" />
                        </Columns>
                        <HeaderStyle BackColor="#007BB7" Font-Size="13px" ForeColor="White" />
                        <RowStyle Font-Size="11px" />
                    </asp:GridView>
                    <div id="Dvnull" runat="server" visible="false" style=" margin-top:20px; text-align:left;">
                        <table style="width: 100%;">
                            <tr>
                                <td rowspan="5" style="width: 50px; vertical-align:top">
                                 <img alt="" src="gridimage/Info.png" />
                                </td>
                                <td>
                                  
                                    <asp:Label ID="lbleliverydtl" runat="server" Font-Bold="True" Font-Size="18px" 
                                        ForeColor="#DE40C3" Text=""></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                               
                                    <hr class="hr" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                  <a href="#" onclick="viewstyledtl();" style="text-decoration:none; font-family:Tahoma; font-size:12px; color:Blue">
                                    Check Style Details</a>
                                  </td>
                            </tr>
                            <tr>
                                <td>
                                    <hr class="hr" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                             
                                <a href="#" onclick="addnewpo();" style="text-decoration:none; font-family:Tahoma; font-size:12px; color:Blue">
                                    Add Delivery Informations</a>
                                    </td>
                            </tr>
                        </table>
                       
                        
                        </div>
                               </div>
                               
                               </td>
                            <td style="vertical-align: top; text-align: left; padding-left:15px">
                                <table style="width:100%;">
                                    <tr>
                                        <td style="height: 250px">
                                            <asp:ImageButton ID="imgstyle" runat="server" Enabled="False" Height="220px" 
                                                Visible="False" Width="200px" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="text-align:right">
                                            <asp:Panel ID="pnlindication" Enabled="false" Visible="false" runat="server">
                                                <table style="width:100%;">
                                                    <tr>
                                                        <td>
                                                            Indications:</td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                             <input id="btcompleted0" disabled="disabled" title="Assortment Completed" runat="server" type="button" class="btnind" 
                                             style="background-color:#E5A0EF; border:1px solid #D159E3; color:#B322C8"   value="Assort. Completed" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                             <input id="btpartil0" class="btnind" title="Assortment partially Completed" disabled="disabled" runat="server" 
                                              style="background-color:#E1F2B1; border:1px solid #C3E461; color:#D86A27" type="button" value="Assort. Partially Completed " />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                             <input id="btnotstrt0" class="btnind" title="Assortment Not Started" disabled="disabled" runat="server" 
                                                style="background-color:#ACF7F6; border:1px solid #22EAE7; color:#228E92" type="button" value="Assort. Not Started" />
                                                        </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                 
                    </div>
                   
                </td>
            </tr>
        </table>

          <asp:Button ID="btnppgntpo" style="display:none" runat="server" Text="Button" />                                     
          <asp:ModalPopupExtender ID="Button2_ModalPopupExtender" runat="server" 
           DynamicServicePath="" BackgroundCssClass="ModalPopupBG" BehaviorID="ppadditm" CancelControlID="cnclitmpdt" 
           OkControlID="cnclitmpdt" Enabled="True" PopupControlID="ppgenpo" 
           TargetControlID="btnppgntpo">
                             </asp:ModalPopupExtender>

    </ContentTemplate>
    </asp:UpdatePanel>


     <div id="ppgenpo" style="height:530px; width:850px; display:none; border:5px solid #64AFEA;background-color:#e9f0fb;-webkit-border-radius: 5px; -moz-border-radius: 5px;border-radius: 5px;">
    <div class="pppnlhdr">
    <div id="hdrtxt" style="float:left; padding-left:20px; color:White">Generate PO</div>
    <div style="float:right; padding-top:2px; padding-right:2px"> 
        <input id="txtchkjv" style="display:none"  type="text" />
        <input id="txtimgsrc1" style="display:none"  type="text" />
        <img id="cnclitmpdt" onclick="refreshgpo();" style="cursor:pointer" alt="" src="gridimage/grdRemove.png" />
    </div>
    </div>
     <div id="divLoading" style="width:600px; text-align:center; vertical-align:bottom; margin-top:200px"> 
       <img src="images/loader.gif" alt="" /> 
     </div>
     <div id="divFrameHolder" style="display:none">
    <iframe id="ifupldfile" onload="hideLoading()" src="" style="border:none" width="840px" height="500px"></iframe>
    </div>
    </div>

    <script src="jquery/AssrtN.js" type="text/javascript"></script>
    <script type="text/javascript">
        function CheckOtherIsCheckedByGVID(spanChk) {
            var IsChecked = spanChk.checked;
            var CurrentRdbID = spanChk.id;
            var Chk = spanChk;
            Parent = document.getElementById("<%=grdpodtl.ClientID%>");
            var items = Parent.getElementsByTagName('input');
            for (i = 0; i < items.length; i++) {
                if (items[i].id != CurrentRdbID && items[i].type == "radio") {
                    if (items[i].checked) {
                        items[i].checked = false;

                    }
                }
            }
            var gt = document.getElementById('<%= grdpodtl.ClientID %>');
            var tval = "";
            for (i = 1; i < gt.rows.length; i++) {
                gt.rows[i].style.background = '';
                gt.rows[i].style.color = 'black';
                var l00pcell = gt.rows[i].cells;
                var loopcellvalue = l00pcell[0].getElementsByTagName("input")[0];
                var slnoval = l00pcell[0].getElementsByTagName("input")[1].value;
                if (loopcellvalue.type == "radio" && loopcellvalue.checked) {
                    tval = l00pcell[1].innerText;
                    $("[id$='txtLot']").val(slnoval);
                    gt.rows[i].style.background = '#23A9BF';
                    gt.rows[i].style.color = 'white';
                }
            }
        }        
    </script>

</asp:Content>


