<%@ Page Title="" Language="C#" MasterPageFile="~/Production/MasterPage.master" AutoEventWireup="true" CodeFile="Exports.aspx.cs" Inherits="Production_Exports" %>

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
                   <div style="border-right:1px solid #51B5E3; padding-right:3px; min-height:500px; padding-top:22px">
                   <table style="width:100%">
                        <tr><td style="border-bottom:3px solid pink; padding-bottom:3px; font-family:Tahoma; font-size:14px; color:blue">Menu</td></tr>
                        <tr><td><a onclick="addqty();" class="lnlmn" href="#">Add Export Qty</a></td></tr>                        
                        <tr><td><a class="lnlmn" onclick="reports();" href="#">Print gate Pass</a></td></tr>
                        <tr><td><a class="lnlmn" onclick="reportexp();" href="#">Export Report</a></td></tr>
                        <tr><td></td></tr>
                        <tr><td></td></tr>
                        <tr><td>Export Date</td></tr>
                        <tr><td>
                            <asp:TextBox ID="txtExpdate" Width="120px" runat="server" Enabled="False"></asp:TextBox>
                            <asp:CalendarExtender ID="txtExpdate_CalendarExtender" runat="server" 
                                                                      Enabled="True" Format="dd-MMM-yyyy" PopupButtonID="cal2" 
                                                                      TargetControlID="txtExpdate">
                                                                  </asp:CalendarExtender>
                            <asp:ImageButton ID="cal2" runat="server" Height="10px" 
                                ImageUrl="~/images/calendar.gif" onfocus="ShowCalendar2()" TabIndex="13" />
                            </td></tr>
                       
                       

                   </table>
                    </div>
                </td>
                <td style="vertical-align:top;"">
                 <div style="padding-left:5px; border-bottom:1px solid #51B5E3; padding-bottom:8px; margin-bottom:5px">
                     <table style="width:100%;">
                         <tr>
                             <td class="label" style="width: 80px;">
                                 Company</td>
                             <td style="text-align: left">
                                 <asp:DropDownList ID="drpCompany" runat="server" AutoPostBack="True" 
                                     CssClass="textboxforgridview" Width="250px" 
                                     onselectedindexchanged="drpCompany_SelectedIndexChanged">
                                 </asp:DropDownList>
                             </td>
                             <td>
                                 &nbsp;</td>
                         </tr>
                     </table>
                 </div>
                <div style="padding-left:5px; border-bottom:1px solid #51B5E3; padding-bottom:8px">
                    <table style="width:100%;">
                        <tr>
                            <td class="label" style="width: 80px;">
                                Style No</td>
                            <td style="text-align: left">
                                <asp:DropDownList ID="drpstyle" runat="server" AutoPostBack="True" 
                                    CssClass="textboxforgridview" 
                                    onselectedindexchanged="drpstyle_SelectedIndexChanged" Width="224px">
                                </asp:DropDownList>
                                &nbsp;</td>
                            <td class="label">
                                Brand</td>
                            <td>
                                <asp:TextBox ID="txtBrand" runat="server" CssClass="textboxforgridview" 
                                    Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td class="label">
                                Gmt Type</td>
                            <td>
                                <asp:TextBox ID="txtGmttype" runat="server" CssClass="textboxforgridview" 
                                    Enabled="False" Width="160px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="label">
                                Buyer
                                <div id="dvstldtl" class="dvstl">
                                <iframe id="ifrmst" src="" style="border:none" width="840px" height="500px"></iframe>
                                </div>
                                </td>
                            <td style="text-align: left">
                                <asp:TextBox ID="txtBuyer" runat="server" CssClass="textboxforgridview" 
                                    Width="220px" Enabled="False"></asp:TextBox>
                                <asp:TextBox ID="txtLot" style="display:none" runat="server" Width="20px"></asp:TextBox>
                            </td>
                            <td class="label">
                                Season</td>
                            <td>
                                <asp:TextBox ID="txtSeason" runat="server" CssClass="textboxforgridview" 
                                    Width="200px" Enabled="False"></asp:TextBox>
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
        <img id="cnclitmpdt" onclick="refreshgpo();" style="cursor:pointer" alt="" src="../gridimage/grdRemove.png" />
    </div>
    </div>
     <div id="divLoading" style="width:600px; text-align:center; vertical-align:bottom; margin-top:200px"> 
       <img src="../images/loader.gif" alt="" /> 
     </div>
     <div id="divFrameHolder" style="display:none">
    <iframe id="ifupldfile" onload="hideLoading()" src="" style="border:none" width="840px" height="500px"></iframe>
    </div>
    </div>

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

        function addqty() {
            var stl = $("[id*='drpstyle'] :selected").val();
            var lot = $("[id$='txtLot']").val();
            if (stl.length > 0) {
                if (lot.length > 0) {
                    onunload();
                    document.getElementById("txtchkjv").value = "1";
                    $("#hdrtxt").html("Add/Edit Quantity");
                    $("#ifupldfile").attr("src", "Expqtysave.aspx?x=" + stl + "&y=" + lot + "");
                    var bid = $find('ppadditm');
                    bid.show();
                }
                else {
                    alert("Select PO No");
                }
            }
            else {
                alert("First Select Style");
            }
        }

        function reports() {
            var stl = $("[id*='drpstyle'] :selected").val();
            var comp = $("[id*='drpCompany'] :selected").text();
            var lot = $("[id$='txtLot']").val();
            if (stl.length > 0) {
                if (lot.length > 0) {
                    onunload();
                    document.getElementById("txtchkjv").value = "1";
                    $("#hdrtxt").html("Export Reports");
                    $("#ifupldfile").attr("src", "Rptgatepass.aspx?x=" + stl + "&y=" + lot + "&z=" + comp + "");
                    var bid = $find('ppadditm');
                    bid.show();
                }
                else {
                    alert("Select PO No");
                }
            }
            else {
                alert("First Select Style");
            }
        }

        function reportexp() {

            var expdate = $("[id$='txtExpdate']").val();
            if (expdate.length > 0) {          
                    onunload();
                    document.getElementById("txtchkjv").value = "1";
                    $("#hdrtxt").html("Export Reports");
                    $("#ifupldfile").attr("src", "RptExport.aspx?x='" + expdate + "'");
                    var bid = $find('ppadditm');
                    bid.show();
                }
                else {
                    $("[id$='txtExpdate']").attr("style", "background-color:red;width:120px");
                    alert("First Select Export Date");
                    $("[id$='txtExpdate']").attr("style", "background-color:white;width:120px");
            }
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


