<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory/MasterPage.master" AutoEventWireup="true" CodeFile="Smt_Inv_FactoryPurchase.aspx.cs" Inherits="Inventory_Smt_Inv_FactoryPurchase" %>

<%@ Register Assembly="C1.Web.UI.Controls.4" Namespace="C1.Web.UI.Controls.C1GridView"
    TagPrefix="cc3" %>
    <%@ Register assembly="C1.Web.UI.Controls.4" namespace="C1.Web.UI.Controls.C1TabControl" tagprefix="cc2" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <script type="text/javascript">
        function chkgrd() {
            var gt = document.getElementById('<%= GridView1.ClientID %>');
            var ttl = "";
            var tval = "";
            for (i = 1; i < gt.rows.length; i++) {
                var l00pcell = gt.rows[i].cells;
                var loopcellvalue = l00pcell[2].getElementsByTagName("input")[0];
                if (loopcellvalue.type == 'checkbox' && loopcellvalue.checked) {
                    var val = l00pcell[3].innerText;
                    if (tval == "") {
                        tval = val;
                    }
                    else {
                        tval = tval + "/" + val;
                    }
                }
            }
            if (tval == "") {
                alert("Select Request First");
            }
            else {
                onunload();
                document.getElementById("txtchkjv").value = "4";
                $("#ifupldfile").attr("src", "fpgenpo.aspx?x=" + tval + "");
                var bid = $find('ppadditm');
                bid.show();
            }
        }
    function refreshgpo() {
        var val=document.getElementById("txtchkjv").value;       
        if (val == "3") {
            document.getElementById('<%=btnReloadForapp.ClientID %>').click();
        }
        if (val == "4") {
            document.getElementById('<%=btnRefreshGpotb.ClientID %>').click();
        }
        onunload();    
    }

    function vdtlreq(tval) {
        onunload(); 
        document.getElementById("txtchkjv").value = "1";
        $("#hdrtxt").html("Request Details");
        $("#ifupldfile").attr("src", "ViewReqstdtl.aspx?x=" + tval + "");
        var bid = $find('ppadditm');
        bid.show();
    }

    function REqreport(tval) {
//        onunload();
//        document.getElementById("txtchkjv").value = "1";
//        $("#hdrtxt").html("Request Report");
//        $("#ifupldfile").attr("src", "FPReqReport.aspx?x=" + tval + "");
//        var bid = $find('ppadditm');
        //        bid.show();
        window.open('FPReqReport.aspx?x=' + tval + '', 'popup', 'location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600');
    }
    function FPPOReport(tval) {
//        onunload();
//        document.getElementById("txtchkjv").value = "1";
//        $("#hdrtxt").html("Purchase Order Report");
//        $("#ifupldfile").attr("src", "FPPOREPORT.aspx?x=" + tval + "");
//        var bid = $find('ppadditm');
        //        bid.show();
        window.open('FPPOREPORT.aspx?x=' + tval + '', 'popup', 'location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600');
    }


    


    function REQDTL(tval) {
        onunload();
        document.getElementById("txtchkjv").value = "1";
        $("#hdrtxt").html("Request Report");
        $("#ifupldfile").attr("src", "FPREqdtl.aspx?x=" + tval + "");
        var bid = $find('ppadditm');
        bid.show();
    }

    

    function vdtlreq1(tval) {
        onunload(); 
        document.getElementById("txtchkjv").value = "2";
        $("#hdrtxt").html("PO Details");
        $("#ifupldfile").attr("src", "Vwpodtl.aspx?x=" + tval + "");
        var bid = $find('ppadditm');
        bid.show();
    }
    function POedt(tval) {
        onunload(); 
        document.getElementById("txtchkjv").value = "3";
        $("#hdrtxt").html("Edit/Update Purchase Order");
        $("#ifupldfile").attr("src", "Edtpo.aspx?x=" + tval + "");
        var bid = $find('ppadditm');
        bid.show();
    }
    function getQueryStrings() {
        var assoc = {};
        var decode = function (s) { return decodeURIComponent(s.replace(/\+/g, " ")); };
        var queryString = location.search.substring(1);
        var keyValues = queryString.split('&');
        for (var i in keyValues) {
            var key = keyValues[i].split('=');
            if (key.length > 1) {
                assoc[decode(key[0])] = decode(key[1]);
            }
        }
        return assoc;
    }
    function calcval(txtReqQty, txtUprice, txtValue) {
        var ReqQty = document.getElementById(txtReqQty).value;
        var Uprice = document.getElementById(txtUprice).value;
        var RQty = 0;
        var UnitPrice = 0;
        var Total = 0;
        if (ReqQty.length > 0) {
            RQty = ReqQty;
        }
        if (Uprice.length > 0) {
            UnitPrice = Uprice;
        }
        Total = parseFloat(RQty) * parseFloat(UnitPrice);
        document.getElementById(txtValue).value = Total.toFixed(2);
    }

</script>
   <script type="text/javascript">
       function hideLoading() {
           document.getElementById('divLoading').style.display = "none";
           document.getElementById('divFrameHolder').style.display = "block";
       }
       function onunload() {
           document.getElementById('divLoading').style.display = "block";
           document.getElementById('divFrameHolder').style.display = "none";
       }
        </script> 
<style type="text/css">

</style>
    <asp:UpdatePanel ID="updfp" runat="server">
    <ContentTemplate>
    
   
       <cc2:C1TabControl ID="C1TabControl1" runat="server" width="100%"                    
                TextImageRelation="ImageBeforeText" onclienttabmouseenter="clr">
               <TabPages>
                <cc2:C1TabPage ID="C1TabPage1" TabIndex="0" Text="Item Request" CssClass="tab">                    
                <div id="dvtp" runat="server" class="pnlmain" style="padding:5px; margin-left:5px; margin-right:5px;background-color:#F0F8FD">
                             <table style="width: 100%;">
                                 <tr>
                                     <td align="center">
                                         <asp:Label ID="Label19" runat="server" CssClass="label" Text="Company"></asp:Label>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator23" runat="server" 
                                             ControlToValidate="drpFactory" Display="None" ErrorMessage="Select Company" 
                                             ValidationGroup="p">*</asp:RequiredFieldValidator>
                                         <asp:ValidatorCalloutExtender ID="RequiredFieldValidator23_ValidatorCalloutExtender" 
                                             runat="server" Enabled="True" TargetControlID="RequiredFieldValidator23">
                                         </asp:ValidatorCalloutExtender>
                                     </td>
                                     <td align="center">
                                         &nbsp;
                                         <asp:Label ID="Label5" runat="server" CssClass="label" Text="Department"></asp:Label>
                                     </td>
                                     <td align="center">
                                         &nbsp;
                                         <asp:Label ID="Label6" runat="server" CssClass="label" Text="Section"></asp:Label>
                                     </td>
                                     <td align="center">
                                         <asp:Label ID="Label7" runat="server" CssClass="label" Text="Style No" 
                                             Visible="False"></asp:Label>
                                     </td>
                                     <td align="center">
                                         <asp:Label ID="Label8" runat="server" CssClass="label" Text="Currency Type"></asp:Label>
                                     </td>
                                     <td align="center">
                                         &nbsp;
                                         <asp:Label ID="Label9" runat="server" CssClass="label" Text="Request No"></asp:Label>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <asp:DropDownList ID="drpFactory" runat="server" CssClass="dropdownlist" 
                                             Width="200px" AutoPostBack="True" 
                                             onselectedindexchanged="drpFactory_SelectedIndexChanged">
                                         </asp:DropDownList>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                             ControlToValidate="drpFactory" Display="None" ErrorMessage="Select Company." 
                                             ValidationGroup="a">*</asp:RequiredFieldValidator>
                                         <asp:ValidatorCalloutExtender ID="RequiredFieldValidator4_ValidatorCalloutExtender" 
                                             runat="server" Enabled="True" TargetControlID="RequiredFieldValidator4">
                                         </asp:ValidatorCalloutExtender>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                             ControlToValidate="drpFactory" Display="None" ErrorMessage="Select Company." 
                                             ValidationGroup="b">*</asp:RequiredFieldValidator>
                                         <asp:ValidatorCalloutExtender ID="RequiredFieldValidator5_ValidatorCalloutExtender" 
                                             runat="server" Enabled="True" TargetControlID="RequiredFieldValidator5">
                                         </asp:ValidatorCalloutExtender>
                                     </td>
                                     <td>
                                         &nbsp;
                                         <asp:DropDownList ID="drpDepartment" runat="server" AutoPostBack="True" 
                                             CssClass="dropdownlist" 
                                             onselectedindexchanged="drpDepartment_SelectedIndexChanged" Width="200px">
                                         </asp:DropDownList>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                             ControlToValidate="drpDepartment" Display="Dynamic" 
                                             ErrorMessage="Select Department." InitialValue="-" ValidationGroup="a">*</asp:RequiredFieldValidator>
                                         <asp:ValidatorCalloutExtender ID="RequiredFieldValidator1_ValidatorCalloutExtender" 
                                             runat="server" Enabled="True" TargetControlID="RequiredFieldValidator1">
                                         </asp:ValidatorCalloutExtender>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                             ControlToValidate="drpDepartment" Display="Dynamic" 
                                             ErrorMessage="Select Department." InitialValue="-" ValidationGroup="b">*</asp:RequiredFieldValidator>
                                         <asp:ValidatorCalloutExtender ID="RequiredFieldValidator6_ValidatorCalloutExtender" 
                                             runat="server" Enabled="True" TargetControlID="RequiredFieldValidator6">
                                         </asp:ValidatorCalloutExtender>
                                     </td>
                                     <td>
                                         &nbsp;
                                         <asp:DropDownList ID="drpsection" runat="server" CssClass="dropdownlist" 
                                             Width="200px">
                                         </asp:DropDownList>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                             ControlToValidate="drpsection" Display="None" ErrorMessage="Select Section." 
                                             ValidationGroup="a">*</asp:RequiredFieldValidator>
                                         <asp:ValidatorCalloutExtender ID="RequiredFieldValidator2_ValidatorCalloutExtender" 
                                             runat="server" Enabled="True" TargetControlID="RequiredFieldValidator2">
                                         </asp:ValidatorCalloutExtender>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                             ControlToValidate="drpsection" Display="None" ErrorMessage="Select Section." 
                                             ValidationGroup="b">*</asp:RequiredFieldValidator>
                                         <asp:ValidatorCalloutExtender ID="RequiredFieldValidator7_ValidatorCalloutExtender" 
                                             runat="server" Enabled="True" TargetControlID="RequiredFieldValidator7">
                                         </asp:ValidatorCalloutExtender>
                                     </td>
                                     <td>
                                         <asp:DropDownList ID="drpStyle" Visible="false" runat="server" CssClass="dropdownlist" 
                                             Width="30px" >
                                         </asp:DropDownList>
                                     </td>
                                     <td>
                                         <asp:DropDownList ID="drpcurrency" runat="server" CssClass="dropdownlist" 
                                             Width="80px">
                                         </asp:DropDownList>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                             ControlToValidate="drpcurrency" Display="None" ErrorMessage="Select</br> Currency</br>Type." 
                                             ValidationGroup="a">*</asp:RequiredFieldValidator>
                                         <asp:ValidatorCalloutExtender ID="RequiredFieldValidator3_ValidatorCalloutExtender" 
                                             runat="server" Enabled="True" TargetControlID="RequiredFieldValidator3">
                                         </asp:ValidatorCalloutExtender>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                                             ControlToValidate="drpcurrency" Display="None" 
                                             ErrorMessage="Select Currency Type" ValidationGroup="b">*</asp:RequiredFieldValidator>
                                         <asp:ValidatorCalloutExtender ID="RequiredFieldValidator8_ValidatorCalloutExtender" 
                                             runat="server" Enabled="True" TargetControlID="RequiredFieldValidator8">
                                         </asp:ValidatorCalloutExtender>
                                     </td>
                                     <td>
                                         &nbsp;
                                         <asp:TextBox ID="txtReqNo" runat="server" CssClass="textbox" Enabled="False" 
                                             BorderColor="Red" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" 
                                             ForeColor="Black" Width="120px"></asp:TextBox>
                                     </td>
                                 </tr>
                             </table>
                         </div>    
                         <div class="pnlmain" style="padding:5px; margin-left:5px; margin-right:5px;background-color:#F0F8FD">
                             <table style="width: 100%;">
                                 <tr>
                                     <td class="label">
                                         &nbsp;Main Category</td>
                                     <td>
                                         <asp:DropDownList ID="drpmncat" runat="server" AutoPostBack="True" 
                                             CssClass="textboxforgridview" 
                                             OnSelectedIndexChanged="drpmncat_SelectedIndexChanged" Width="200px">
                                         </asp:DropDownList>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                                             ControlToValidate="drpmncat" Display="None" ErrorMessage="Select Main category" 
                                             ValidationGroup="b">*</asp:RequiredFieldValidator>
                                         <asp:ValidatorCalloutExtender ID="RequiredFieldValidator9_ValidatorCalloutExtender" 
                                             runat="server" Enabled="True"
                                             TargetControlID="RequiredFieldValidator9">
                                         </asp:ValidatorCalloutExtender>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator24" runat="server" 
                                             ControlToValidate="drpmncat" Display="None" ErrorMessage="Select Main Category" 
                                             ValidationGroup="p">*</asp:RequiredFieldValidator>
                                         <asp:ValidatorCalloutExtender ID="RequiredFieldValidator24_ValidatorCalloutExtender" 
                                             runat="server" Enabled="True" TargetControlID="RequiredFieldValidator24">
                                         </asp:ValidatorCalloutExtender>
                                     </td>
                                     <td class="label">
                                         Color</td>
                                     <td>
                                         <asp:DropDownList ID="drpclr" runat="server" CssClass="textboxforgridview" 
                                             Width="100px">
                                         </asp:DropDownList>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" 
                                             ControlToValidate="drpclr" Display="None" ErrorMessage="Select Color" 
                                             ValidationGroup="b">*</asp:RequiredFieldValidator>
                                         <asp:ValidatorCalloutExtender ID="RequiredFieldValidator18_ValidatorCalloutExtender" 
                                             runat="server" Enabled="True" 
                                             TargetControlID="RequiredFieldValidator18">
                                         </asp:ValidatorCalloutExtender>
                                     </td>
                                     <td class="label">
                                         Article</td>
                                     <td style="text-align: left;">
                                         <asp:DropDownList ID="drpartcl" runat="server" CssClass="textboxforgridview" 
                                             Width="120px">
                                         </asp:DropDownList>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" 
                                             ControlToValidate="drpartcl" Display="None" ErrorMessage="Select Article" 
                                             ValidationGroup="b">*</asp:RequiredFieldValidator>
                                         <asp:ValidatorCalloutExtender ID="RequiredFieldValidator20_ValidatorCalloutExtender" 
                                             runat="server" Enabled="True" 
                                             TargetControlID="RequiredFieldValidator20">
                                         </asp:ValidatorCalloutExtender>
                                     </td>
                                     <td class="label">
                                         Unit</td>
                                     <td>
                                         <asp:DropDownList ID="drpunit" runat="server" CssClass="textboxforgridview" 
                                             Width="80px">
                                         </asp:DropDownList>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" 
                                             ControlToValidate="txtqty" Display="None" ErrorMessage="Enter Quantity" 
                                             ValidationGroup="b">*</asp:RequiredFieldValidator>
                                         <asp:ValidatorCalloutExtender ID="RequiredFieldValidator16_ValidatorCalloutExtender" 
                                             runat="server" Enabled="True" 
                                             TargetControlID="RequiredFieldValidator16">
                                         </asp:ValidatorCalloutExtender>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator22" runat="server" 
                                             ControlToValidate="drpunit" Display="None" ErrorMessage="Select Unit" 
                                             ValidationGroup="b">*</asp:RequiredFieldValidator>
                                         <asp:ValidatorCalloutExtender ID="RequiredFieldValidator22_ValidatorCalloutExtender" 
                                             runat="server" Enabled="True"  
                                             TargetControlID="RequiredFieldValidator22">
                                         </asp:ValidatorCalloutExtender>
                                     </td>
                                     <td class="label">
                                         U.Price</td>
                                     <td>
                                         <asp:TextBox ID="txtprce" runat="server" CssClass="textboxforgridview" 
                                             MaxLength="6" Width="60px"></asp:TextBox>
                                         <asp:FilteredTextBoxExtender ID="txtprce_FilteredTextBoxExtender" 
                                             runat="server" Enabled="True" TargetControlID="txtprce" 
                                             ValidChars=".0123456789">
                                         </asp:FilteredTextBoxExtender>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" 
                                             ControlToValidate="txtprce" Display="None" ErrorMessage="Enter Unit Price" 
                                             ValidationGroup="b">*</asp:RequiredFieldValidator>
                                         <asp:ValidatorCalloutExtender ID="RequiredFieldValidator17_ValidatorCalloutExtender" 
                                             runat="server" Enabled="True" 
                                             TargetControlID="RequiredFieldValidator17">
                                         </asp:ValidatorCalloutExtender>
                                     </td>
                                     <td style="text-align: right">
                                         <asp:Button ID="btnrf" runat="server" Font-Size="10px" OnClick="btnrf_Click" 
                                             Text="Refresh" Width="50px" />
                                     </td>
                                 </tr>
                                 <tr>
                                     <td class="label">
                                         Sub Category</td>
                                     <td>
                                         <asp:DropDownList ID="drpsubcat" runat="server" AutoPostBack="True" 
                                             CssClass="textboxforgridview" 
                                             OnSelectedIndexChanged="drpsubcat_SelectedIndexChanged" Width="200px">
                                         </asp:DropDownList>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                                             ControlToValidate="drpsubcat" Display="None" ErrorMessage="Select Sub Category" 
                                             ValidationGroup="b">*</asp:RequiredFieldValidator>
                                         <asp:ValidatorCalloutExtender ID="RequiredFieldValidator10_ValidatorCalloutExtender" 
                                             runat="server" Enabled="True"
                                             TargetControlID="RequiredFieldValidator10">
                                         </asp:ValidatorCalloutExtender>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator25" runat="server" 
                                             ControlToValidate="drpsubcat" Display="None" ErrorMessage="Select Sub Category" 
                                             ValidationGroup="p">*</asp:RequiredFieldValidator>
                                         <asp:ValidatorCalloutExtender ID="RequiredFieldValidator25_ValidatorCalloutExtender" 
                                             runat="server" Enabled="True" TargetControlID="RequiredFieldValidator25">
                                         </asp:ValidatorCalloutExtender>
                                     </td>
                                     <td class="label">
                                         Size</td>
                                     <td>
                                         <asp:DropDownList ID="drpsz" runat="server" CssClass="textboxforgridview" 
                                             Width="100px">
                                         </asp:DropDownList>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" 
                                             ControlToValidate="drpsz" Display="None" ErrorMessage="Select Size" 
                                             ValidationGroup="b">*</asp:RequiredFieldValidator>
                                         <asp:ValidatorCalloutExtender ID="RequiredFieldValidator19_ValidatorCalloutExtender" 
                                             runat="server" Enabled="True" 
                                             TargetControlID="RequiredFieldValidator19">
                                         </asp:ValidatorCalloutExtender>
                                     </td>
                                     <td class="label">
                                         Dimension</td>
                                     <td style="text-align: left;">
                                         <asp:DropDownList ID="drpdimnsn" runat="server" CssClass="textboxforgridview" 
                                             Width="120px">
                                         </asp:DropDownList>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" 
                                             ControlToValidate="drpdimnsn" Display="None" ErrorMessage="Select Dimension" 
                                             ValidationGroup="b">*</asp:RequiredFieldValidator>
                                         <asp:ValidatorCalloutExtender ID="RequiredFieldValidator21_ValidatorCalloutExtender" 
                                             runat="server" Enabled="True" 
                                             TargetControlID="RequiredFieldValidator21">
                                         </asp:ValidatorCalloutExtender>
                                     </td>
                                     <td class="label">
                                         Req.Qty</td>
                                     <td>
                                         <asp:TextBox ID="txtqty" runat="server" CssClass="textboxforgridview" 
                                             MaxLength="6" Width="80px"></asp:TextBox>
                                         <asp:FilteredTextBoxExtender ID="txtqty_FilteredTextBoxExtender" runat="server" 
                                             Enabled="True" TargetControlID="txtqty" ValidChars=".0123456789">
                                         </asp:FilteredTextBoxExtender>
                                     </td>
                                     <td class="label">
                                         Value</td>
                                     <td>
                                         <asp:TextBox ID="txtvalue" runat="server" CssClass="textboxforgridview" 
                                             Enabled="False" Width="60px"></asp:TextBox>
                                     </td>
                                     <td style="text-align: right" rowspan="2">
                                         <asp:Button ID="btnAdd" runat="server" Font-Size="10px" OnClick="btnAdd_Click" 
                                             Text="Add" ValidationGroup="b" Width="50px" Height="40px" />
                                     </td>
                                 </tr>
                                 <tr>
                                     <td class="label">
                                         Brand</td>
                                     <td>
                                         <asp:DropDownList ID="drpBrand" runat="server" 
                                             CssClass="textboxforgridview" Width="200px">
                                         </asp:DropDownList>
                                     </td>
                                     <td class="label">
                                         &nbsp;</td>
                                     <td colspan="7" style="text-align: left;">
                                         <asp:Button ID="btnshowstock" runat="server" Font-Size="10px" 
                                             OnClick="btnshowstock_Click" Text="View Stock &amp; Price" 
                                             ValidationGroup="p" />
                                         &nbsp;&nbsp;
                                         <asp:Label ID="lblStock" runat="server" Font-Size="14px" ForeColor="#FF33CC"></asp:Label>
                                         <asp:Label ID="txtStock" runat="server" Font-Size="14px" ForeColor="#FF33CC"></asp:Label>
                                     </td>
                                 </tr>
                             </table>
                         </div>                     
                <div class="pnlmain" 
                                style="margin-left:5px; margin-right:5px; margin-bottom:5px" 
                                align="left">                               
                                  <asp:Panel ID="pnlfp" Height="320px" Width="1005px" ScrollBars="Auto" runat="server">                                 
                                     <asp:GridView ID="grdLocalpurchase" CssClass="mGrid" AutoGenerateColumns="false" runat="server" Width="100%" 
                                            ShowFooter="True" OnRowDataBound="grdLocalpurchase_RowDataBound">
          <AlternatingRowStyle CssClass="gridrowAlternaterow" />
          <Columns>
        
         <asp:TemplateField HeaderText="Main Category">
         <ItemTemplate>
             <asp:Label ID="lblMnct" runat="server" Text='<%# Eval("cMainCategory") %>'></asp:Label>
             <asp:Label ID="lblrqmcatid" Visible="false" runat="server" Text='<%# Eval("nMainCat_ID") %>'></asp:Label>
             <asp:Label ID="lblresubctid" Visible="false" runat="server" Text='<%# Eval("nSubCat_ID") %>'></asp:Label>
             <asp:Label ID="lblreqcolid" Visible="false" runat="server" Text='<%# Eval("nColor_ID") %>'></asp:Label>
             <asp:Label ID="lblreqszid" Visible="false" runat="server" Text='<%# Eval("SizeID") %>'></asp:Label>
             <asp:Label ID="lblreqartid" Visible="false" runat="server" Text='<%# Eval("nArticle_ID") %>'></asp:Label>
             <asp:Label ID="lblreqdimnid" Visible="false" runat="server" Text='<%# Eval("nDimension_ID") %>'></asp:Label>
             <asp:Label ID="lblrequnitid" Visible="false" runat="server" Text='<%# Eval("nUnit_ID") %>'></asp:Label>
             <asp:Label ID="lblbrandid" Visible="false" runat="server" Text='<%# Eval("BrandCode") %>'></asp:Label>
         </ItemTemplate>         
         </asp:TemplateField>
           <asp:TemplateField HeaderText="Sub Category">
         <ItemTemplate>
             <asp:Label ID="lblrqsubcat" runat="server" Text='<%# Eval("cDes") %>'></asp:Label>
         </ItemTemplate>
         
         </asp:TemplateField>
          <asp:TemplateField HeaderText="Brand">
         <ItemTemplate>
             <asp:Label ID="lblbrand" runat="server" Text='<%# Eval("cBrand_Name") %>'></asp:Label>
         </ItemTemplate>
         
         </asp:TemplateField>
           <asp:TemplateField HeaderText="Color">
         <ItemTemplate>
             <asp:Label ID="lblrqcolor" runat="server" Text='<%# Eval("cColour") %>'></asp:Label>
         </ItemTemplate>
        
         </asp:TemplateField>
           <asp:TemplateField HeaderText="Size">
         <ItemTemplate>
             <asp:Label ID="lblrqsize" runat="server" Text='<%# Eval("cSize1") %>'></asp:Label>
         </ItemTemplate>
        
         </asp:TemplateField>
           <asp:TemplateField HeaderText="Article">
         <ItemTemplate>
             <asp:Label ID="lblrqarticle" runat="server" Text='<%# Eval("cArticle") %>'></asp:Label>
         </ItemTemplate>
        
       
         </asp:TemplateField>
           <asp:TemplateField HeaderText="Dimension">
         <ItemTemplate>
             <asp:Label ID="lblrqdimn" runat="server" Text='<%# Eval("cDimen") %>'></asp:Label>
         </ItemTemplate>
        
         </asp:TemplateField>
           <asp:TemplateField HeaderText="Unit">
         <ItemTemplate>
             <asp:Label ID="lblreunit" runat="server" Text='<%# Eval("cUnitDes") %>'></asp:Label>
         </ItemTemplate>
        
         </asp:TemplateField>
           <asp:TemplateField HeaderText="Req Qty">
         <ItemTemplate>
             <asp:Label ID="lblrqqty" runat="server" Text='<%# Eval("dReqQty") %>'></asp:Label>
         </ItemTemplate>        
         </asp:TemplateField>
           <asp:TemplateField HeaderText="U.Price">
         <ItemTemplate>
             <asp:Label ID="lblrqunprice" runat="server" Text='<%# Eval("dUnitPrice") %>'></asp:Label>
         </ItemTemplate>
         
         </asp:TemplateField>
           <asp:TemplateField HeaderText="Value">
         <ItemTemplate>         
             <asp:Label ID="lblrqval" runat="server" Text='<%# Eval("dValue") %>'></asp:Label>
         </ItemTemplate>
       
         </asp:TemplateField>
          
         <asp:TemplateField HeaderText="">
         <ItemTemplate>
             <asp:ImageButton ID="btnEdit" ToolTip="Edit Item" runat="server" ImageUrl="~/gridimage/edit.png" 
                 onclick="btnEdit_Click" />
         </ItemTemplate>
      
         </asp:TemplateField>
         <asp:TemplateField HeaderText="">
         <ItemTemplate>
             <asp:ImageButton ID="btnRemove" ToolTip="Remove Item" runat="server" 
                 ImageUrl="~/gridimage/grdRemove.png" onclick="btnRemove_Click" />
         </ItemTemplate>       
         </asp:TemplateField>         
          </Columns>         
          
              <HeaderStyle CssClass="gridheader" />
              <RowStyle CssClass="gridrow" />
          
          
          </asp:GridView>      
                                 </asp:Panel>
                            
                            </div>
                <div class="pnlmain" style="height:35px; margin-left:5px; margin-right:5px; margin-bottom:5px; padding-top:5px">
                             <table width="100%">
                             <tr>
                             <td>
                                 <asp:Button ID="btnAddsubcat" Width="80px" runat="server" CssClass="btPOPUP" Text="Sub Category" />
                                <asp:Button ID="btnaddarticle" Width="80px" runat="server" CssClass="btPOPUP" Text="Article" />
                                <asp:Button ID="btnadddimension" Width="80px" runat="server" CssClass="btPOPUP" Text="Dimension" />
                                <asp:Button ID="btnaddcolor" Width="80px" runat="server" CssClass="btPOPUP" Text="Color" />


                              
                             
                             </td>
                             <td>  <div align="right" style="padding-right:10px">
                                  
                                 Remarks
                                 <asp:TextBox ID="txtRemarks" runat="server" CssClass="textboxforgridview" 
                                     MaxLength="100" Width="300px"></asp:TextBox>
                                  
                                 <asp:Button ID="btnClear" runat="server" CssClass="button" 
                                     OnClick="btnClear_Click" Text="Clear" Width="100px" />
                                 <asp:Button ID="btnSave" runat="server" CssClass="button" Text="Save" 
                                     Width="100px" OnClick="btnSave_Click" ValidationGroup="a" />
                                  
                                 <asp:ConfirmButtonExtender ID="btnSave_ConfirmButtonExtender" runat="server" 
                                     ConfirmText="Do you want to save this data?" Enabled="True" 
                                     TargetControlID="btnSave">
                                 </asp:ConfirmButtonExtender>
                                  
                                 <asp:Button ID="btnUpdate" runat="server" CssClass="button" 
                                     OnClick="btnUpdate_Click" Text="Update" Width="100px" Visible="False" />
                                  
                                 <asp:ConfirmButtonExtender ID="btnUpdate_ConfirmButtonExtender" runat="server" 
                                     ConfirmText="Do you want to Update this data?" Enabled="True" 
                                     TargetControlID="btnUpdate">
                                 </asp:ConfirmButtonExtender>
                                  
                             </div></td>
                             </tr>
                             </table>

                           
                             </div>    
                            
                </cc2:C1TabPage>

                 <cc2:C1TabPage ID="C1TabPage6" TabIndex="0" Text="Request Approval" CssClass="tab">                    
              <div style=" padding-bottom:4px">
              <div style="height:460px">
                 <cc3:C1GridView ID="grdNewreq" Width="100%" runat="server" AllowPaging="True" 
                                        AutoGenerateColumns="False" PageSize="20" 
                                        ShowFilter="True" VisualStylePath="~/C1WebControls/VisualStyles" 
                                        AllowSorting="True" AllowColSizing="true" 
                                        VisualStyle="Office2007Blue" DefaultColumnWidth="" 
                                        UseEmbeddedVisualStyles="True" AllowRowHover="False" 
                      OnFiltering="grdNewreq_Filtering" OnSelectedIndexChanging="grdNewreq_SelectedIndexChanging" 
                                     
                                         
                                        >
                                        <Columns>       
                                        <cc3:C1TemplateField HeaderText="Edit">
                                        <ItemTemplate>
                                         <asp:LinkButton ID="lnkedit" style="text-decoration:none; padding-left:4px; padding-right:4px" runat="server" CommandArgument='<%# Eval("nRequest_No") %>' onclick="lnkedit_Click">Edit</asp:LinkButton>
                                        </ItemTemplate>
                                        </cc3:C1TemplateField>                                                                  
                                        <cc3:C1TemplateField HeaderText="Report">
                                        <ItemTemplate>
                                        <a class="link" style="padding-left:4px; padding-right:6px" href="javascript:REqreport('<%# Eval("nRequest_No") %>')">Report</a>
                                        </ItemTemplate>
                                        </cc3:C1TemplateField>
                                         <cc3:C1TemplateField HeaderText="View">
                                        <ItemTemplate>
                                        <a class="link" style="padding-left:4px; padding-right:6px" href="javascript:REQDTL('<%# Eval("nRequest_No") %>')">View</a>
                                       
                                        </ItemTemplate>
                                        </cc3:C1TemplateField>
                                        <cc3:C1TemplateField HeaderText="Select">
                                            <ItemTemplate>                                           
                                            <asp:CheckBox ID="chkSelect" Width="25px" runat="server" />                                           
                                             <asp:Label ID="lblRequestno" Visible="false" runat="server" Text='<%# Eval("nRequest_No") %>'></asp:Label>                                             
                                            </ItemTemplate>
                                            </cc3:C1TemplateField>
                                             <cc3:C1BoundField DataField="dValue" ShowFilter="false" HeaderText="Value" 
                                                SortExpression="dValue">
                                            </cc3:C1BoundField>  
                                             <cc3:C1BoundField DataField="cCurType" ShowFilter="false" HeaderText="Currency" 
                                                SortExpression="cCurType">
                                            </cc3:C1BoundField>  
                                            <cc3:C1BoundField DataField="nRequest_No" AllowSizing="true" HeaderText="Req No" SortExpression="nRequest_No">
                                            </cc3:C1BoundField>
                                            <cc3:C1BoundField DataField="cDeptname" AllowSizing="true" HeaderText="Department" SortExpression="cDeptname">
                                            </cc3:C1BoundField>
                                             <cc3:C1BoundField DataField="cSection_Description" HeaderText="Section" 
                                                SortExpression="cSection_Description">
                                            </cc3:C1BoundField>   
                                            
                                            <cc3:C1BoundField DataField="Reqcrtdby" HeaderText="Requested By" 
                                                SortExpression="Reqcrtdby">
                                            </cc3:C1BoundField> 
                                            <cc3:C1BoundField DataField="Req_Crdt" HeaderText="Requested Date" 
                                                SortExpression="Req_Crdt">
                                            </cc3:C1BoundField> 
                                                                                                                                                            
                                                        
                                                           
                                        </Columns>
                                        <PagerSettings PageButtonCount="20" Mode="NextPreviousFirstLast" />
                                               <HeaderStyle Wrap="False" />
                                               <RowStyle Wrap="False" Height="18px" />
                                    </cc3:C1GridView>     
               </div>
               <div style="text-align:right; padding:5px; border-top:1px solid silver; vertical-align:middle">
               Remarks :
                   <asp:TextBox ID="txtreqappremrk" CssClass="textbox" Width="200px" runat="server" TextMode="SingleLine"></asp:TextBox>
                   <asp:Button ID="btnReqApprove" Width="130px" runat="server" Text="Request Approve" 
                       OnClick="btnReqApprove_Click" />
                       <asp:ConfirmButtonExtender ID="btnReqApprove_ConfirmButtonExtender1" 
                                                 runat="server" ConfirmText="Are you sure you want to approve?" 
                               Enabled="True" TargetControlID="btnReqApprove"></asp:ConfirmButtonExtender>
               </div>
              
              </div>
                            
                </cc2:C1TabPage>
                  
                <cc2:C1TabPage ID="C1TabPage5" TabIndex="1" Text="Generate PO" CssClass="tab">                 
                       
                     <div class="pnlmain" style="height:480px; margin-left:5px; margin:5px">      
          <div style="padding:5px; margin-bottom:3px; border-bottom:1px solid silver">
          
              <table style="width:100%;">
                  <tr>
                      <td>
                          Company</td>
                      <td>
                          <asp:TextBox ID="txtcompany" MaxLength="20" Width="120px" CssClass="textbox" runat="server"></asp:TextBox>
                        </td>
                      <td>
                          Department</td>
                          <td><asp:TextBox ID="txtdept" MaxLength="20" Width="120px" CssClass="textbox" runat="server"></asp:TextBox>
                         </td>
                          <td>
                         Section</td>
                          <td>
                         <asp:TextBox ID="txtsection" MaxLength="20" Width="120px" CssClass="textbox" runat="server"></asp:TextBox></td>
                          <td>
                          Date</td>
                          <td>
                          <asp:TextBox ID="txtDate" Enabled="false" Width="90px" CssClass="textbox" runat="server"></asp:TextBox>
                          <asp:ImageButton ID="cal1" onfocus="ShowCalendar()" CssClass="Caaldr" runat="server" Height="13px" 
                                ImageUrl="~/images/calendar.gif" TabIndex="12" />
                                 <asp:CalendarExtender ID="txtoriginalrcvd_CalendarExtender" runat="server" 
                                                                      Enabled="True" Format="dd/MM/yyyy" PopupButtonID="cal1" 
                                                                      TargetControlID="txtDate" PopupPosition="TopLeft">
                                 </asp:CalendarExtender>
                          </td>                         
                          <td>
                          Request No</td>
                          <td>
                          <asp:TextBox ID="txtReqNosrc" MaxLength="6" Width="60px" CssClass="textbox" runat="server"></asp:TextBox>
                              <asp:FilteredTextBoxExtender ID="txtReqNosrc_FilteredTextBoxExtender" 
                                  runat="server" Enabled="True" TargetControlID="txtReqNosrc" 
                                  ValidChars="0123456789">
                              </asp:FilteredTextBoxExtender>
                      </td>
                          <td>
                              <asp:Button ID="btnSearchReq" runat="server" Text="Search" 
                                  OnClick="btnSearchReq_Click" />
                          </td>
                  </tr>
              </table>
          
          </div>    
          <div style="height:430px; overflow:auto">         
          <asp:GridView ID="GridView1" CssClass="mGrid" AutoGenerateColumns="false"  runat="server" 
                                  onrowdatabound="GridView1_RowDataBound" Width="100%">
          <AlternatingRowStyle CssClass="gridrowAlternaterow" />
          <Columns>
          <asp:TemplateField>
           <ItemTemplate>
             <a class="link" style="padding-left:4px; padding-right:6px" href="javascript:REqreport('<%# Eval("nRequest_No") %>')">Report</a>
           </ItemTemplate>
          </asp:TemplateField>
          <asp:TemplateField>         
           <ItemTemplate>
              <a class="link" style="padding-left:4px; padding-right:6px" href="javascript:REQDTL('<%# Eval("nRequest_No") %>')">View</a>
           </ItemTemplate>
          </asp:TemplateField>
          <asp:TemplateField>
           <ItemTemplate>
               <asp:CheckBox ID="CheckBox1" runat="server" />
           </ItemTemplate>
          </asp:TemplateField>
          <asp:BoundField DataField="nRequest_No" HeaderText="Request No" />
          <asp:BoundField DataField="dValue" HeaderText="Value" />
          <asp:BoundField DataField="cCurType" HeaderText="Currency" />
          <asp:BoundField DataField="cDeptname" HeaderText="Department" />
          <asp:BoundField DataField="cSection_Description" HeaderText="Section" />
          <asp:BoundField DataField="Reqcrtdby" HeaderText="Requested By" />
          <asp:BoundField DataField="Req_Crdt" HeaderText="Requested Date" />
          <asp:BoundField DataField="reqappby" HeaderText="Approved By" />
          <asp:BoundField DataField="Req_Appdt" HeaderText="Approved By" />
          <asp:BoundField DataField="Req_Appbyremrk" HeaderText="Approved By Remarks" />

          
         
          </Columns>
                   
          <HeaderStyle CssClass="gridheader" />
         <%-- <RowStyle CssClass="gridrow" />        --%>
          </asp:GridView>     
          </div>      
      
          <asp:Button ID="btnppgntpo" style="display:none" runat="server" Text="Button" />                                     
          <asp:ModalPopupExtender ID="Button2_ModalPopupExtender" runat="server" 
           DynamicServicePath="" BackgroundCssClass="ModalPopupBG" BehaviorID="ppadditm" CancelControlID="cnclitmpdt" 
           OkControlID="cnclitmpdt" Enabled="True" PopupControlID="ppgenpo" 
           TargetControlID="btnppgntpo">
                             </asp:ModalPopupExtender>
                         </div>
                     <div style="text-align:right">
                             <input id="btnGenpo" runat="server" type="button" onclick="chkgrd()" class="button" value="Generate PO" />
                             <asp:Button ID="btnRefreshGpotb" runat="server" style="display:none" 
                                 Text="Button" OnClick="btnRefreshGpotb_Click" />
                         </div>   
                                   
                </cc2:C1TabPage>    
                         
                <cc2:C1TabPage ID="C1TabPage2"  TabIndex="3" Text="PO Approval"  CssClass="tab">                 
                      <div style="height:480px; margin:5px">
                          <cc3:C1GridView ID="grdForApproval" Width="100%" runat="server" AllowPaging="True" 
                                        AutoGenerateColumns="False" PageSize="22" 
                                        ShowFilter="True" VisualStylePath="~/C1WebControls/VisualStyles" 
                                        AllowSorting="True" AllowColSizing="true" 
                                        VisualStyle="Office2007Blue" DefaultColumnWidth="" 
                                        UseEmbeddedVisualStyles="True" AllowRowHover="False" 
                                        OnFiltering="grdForApproval_Filtering" 
                                        OnPageIndexChanging="grdForApproval_PageIndexChanging" 
                              OnSorting="grdForApproval_Sorting" >
                                        <Columns>       
                                        <cc3:C1TemplateField HeaderText="Edit">
                                        <ItemTemplate>
                                        <a class="link" href="javascript:POedt('<%# Eval("PO_No") %>')">Edit</a>
                                        </ItemTemplate>
                                        </cc3:C1TemplateField>                                                                  
                                        <cc3:C1TemplateField HeaderText="Report">
                                        <ItemTemplate>
                                        <%--<asp:LinkButton ID="lnkprint" ToolTip="Generate Report" CssClass="link" 
                                                runat="server" CommandArgument='<%# Eval("PO_No") %>' onclick="lnkprint_Click" 
                                        >Report</asp:LinkButton>--%>
                                        <a class="link" style="padding-left:4px; padding-right:6px" href="javascript:FPPOReport('<%# Eval("PO_No") %>')">Report</a>
                                        
                                        </ItemTemplate>
                                        </cc3:C1TemplateField>
                                         <cc3:C1TemplateField HeaderText="View">
                                        <ItemTemplate>
                                        <a class="link" href="javascript:vdtlreq1('<%# Eval("PO_No") %>')">View</a>
                                       
                                        </ItemTemplate>
                                        </cc3:C1TemplateField>
                                        <cc3:C1TemplateField HeaderText="Select">
                                            <ItemTemplate>                                           
                                            <asp:CheckBox ID="chkSelect" Width="25px" runat="server" />
                                            <asp:Label ID="lblPOforEdit" Visible="false" runat="server" Text='<%# Eval("PO_No") %>'></asp:Label>
                                             <asp:Label ID="lblRequestno" Visible="false" runat="server" Text='<%# Eval("PO_No") %>'></asp:Label>
                                            </ItemTemplate>
                                            </cc3:C1TemplateField>
                                            <cc3:C1BoundField DataField="PO_No" AllowSizing="true" HeaderText="PO No" SortExpression="PO_No">
                                            </cc3:C1BoundField>
                                            <cc3:C1BoundField DataField="nRequest_No" AllowSizing="true" HeaderText="Request No" SortExpression="nRequest_No">
                                            </cc3:C1BoundField>

                                            
                                            <cc3:C1BoundField DataField="cSupName" HeaderText="Supplier" SortExpression="cSupName"></cc3:C1BoundField>                                                                                  
                                            <cc3:C1BoundField DataField="dValue" ShowFilter="false" HeaderText="Request Value" 
                                                SortExpression="dValue">
                                            </cc3:C1BoundField>
                                             <cc3:C1BoundField DataField="cCurType" ShowFilter="false" HeaderText="Currency Type" 
                                                SortExpression="cCurType">
                                            </cc3:C1BoundField>
                                             <cc3:C1BoundField DataField="PO_CreatedDate" HeaderText="Created Date" 
                                                SortExpression="Created_Date">
                                            </cc3:C1BoundField>
                                              <cc3:C1BoundField DataField="PO_CreatedBy" HeaderText="Created By" 
                                                SortExpression="Created_User">
                                            </cc3:C1BoundField> 
                                            <cc3:C1BoundField DataField="PO_CreatedByremrk" HeaderText="Remarks" 
                                                SortExpression="PO_CreatedByremrk">
                                            </cc3:C1BoundField>           
                                            
                                                                             
                                                           
                                        </Columns>
                                        <PagerSettings PageButtonCount="25" Mode="NextPreviousFirstLast" />
                                               <HeaderStyle Wrap="False" />
                                               <RowStyle Wrap="False" Height="18px" />
                                    </cc3:C1GridView>                                     
                                         </div>  
                                            <div style="text-align:right; border-top:1px solid silver; padding:3px">
                                             Remarks : 
                           <asp:TextBox ID="txtremarkspoapprove" CssClass="textbox" Width="200px" runat="server"></asp:TextBox>
                                             <asp:Button ID="btnPOApprove" Width="100px" CssClass="button" runat="server" 
                                                 Text="Approve" OnClick="btnPOApprove_Click" />
                                                 <asp:ConfirmButtonExtender ID="btnPOApprove_ConfirmButtonExtender" 
                                                 runat="server" ConfirmText="Do you want to save this data?" Enabled="True" TargetControlID="btnPOApprove">
                                             </asp:ConfirmButtonExtender>
                                                 <asp:Button ID="btnReviseforapp" Width="100px" CssClass="button" runat="server" 
                                                 Text="Re-Work" OnClick="btnReviseforapp_Click" />
                                                   <asp:ConfirmButtonExtender ID="btnReviseforapp_ConfirmButtonExtender1" 
                                                 runat="server" ConfirmText="Are you sure?" Enabled="True" TargetControlID="btnReviseforapp">
                                             </asp:ConfirmButtonExtender>
                                                 <asp:Button ID="btnPOCancel" Width="100px" CssClass="button" runat="server" 
                                                 Text="Cancel" OnClick="btnPOCancel_Click"  />
                                                 <asp:ConfirmButtonExtender ID="btnPOCancel_ConfirmButtonExtender" 
                                                 runat="server" ConfirmText="Do you want to Cancel?" Enabled="True" 
                                                 TargetControlID="btnPOCancel">
                                             </asp:ConfirmButtonExtender>
                       <asp:Button ID="btnReloadForapp" style="display:none" runat="server" Text="Reload" onclick="btnReloadForapp_Click" />
                                         </div>
                 
                </cc2:C1TabPage>
                <cc2:C1TabPage ID="C1TabPage3"  TabIndex="4" Text="Approved"  CssClass="tab">
                
                     <div class="pnlmain" style="height:480px; margin:5px">
                     <cc3:C1GridView ID="grdGetApproved" Width="100%" runat="server" AllowPaging="True" 
                                        AutoGenerateColumns="False" PageSize="22" 
                                        ShowFilter="True" VisualStylePath="~/C1WebControls/VisualStyles" 
                                        AllowSorting="True" 
                                        VisualStyle="Office2007Blue" DefaultColumnWidth="" 
                                        UseEmbeddedVisualStyles="True" 
                                        onpageindexchanging="grdGetApproved_PageIndexChanging" 
                                        OnFiltering="grdGetApproved_Filtering" AllowColSizing="True" 
                                        OnSorting="grdGetApproved_Sorting" 
                                        OnRowDataBound="grdGetApproved_RowDataBound">
                                        <Columns>                                 
                                        <cc3:C1TemplateField HeaderText="Report">
                                        <ItemTemplate>
                                       <%-- <asp:LinkButton ID="lnkprintApproved"  ToolTip="Generate Report" CssClass="link" runat="server" CommandArgument='<%# Eval("PO_No") %>' 
                                              onclick="lnkprintApproved_Click">Report</asp:LinkButton> --%>  
                                              <a class="link" style="padding-left:4px; padding-right:6px" href="javascript:FPPOReport('<%# Eval("PO_No") %>')">Report</a>
                                                                                   
                                        </ItemTemplate>
                                        </cc3:C1TemplateField>
                                         <cc3:C1TemplateField HeaderText="View">
                                        <ItemTemplate>
                                        <a class="link" href="javascript:vdtlreq1('<%# Eval("PO_No") %>')">View</a>  
                                         <asp:Label ID="lblPOforEdit" Visible="false" runat="server" Text='<%# Eval("PO_No") %>'></asp:Label>  
                                           <asp:Label ID="lblRequestno" Visible="false" runat="server" Text='<%# Eval("PO_No") %>'></asp:Label>                                    
                                        </ItemTemplate>
                                        </cc3:C1TemplateField>                                      
                                      
                                        <cc3:C1TemplateField HeaderText="">
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkforRevise" style="padding:5px" runat="server" />
                                        </ItemTemplate>
                                        </cc3:C1TemplateField>  
                                         <cc3:C1BoundField DataField="PO_No" HeaderText="PO No" SortExpression="PO_No">
                                            </cc3:C1BoundField> 
                                             <cc3:C1BoundField DataField="nRequest_No" HeaderText="Request No" SortExpression="nRequest_No">
                                            </cc3:C1BoundField>     
                                                
                                            
                                                                                                                                                                                                                                   
                                                                                 
                                            <cc3:C1BoundField DataField="cSupName"   HeaderText="Supplier" 
                                                SortExpression="cSupName">
                                            </cc3:C1BoundField>
                                            <cc3:C1BoundField DataField="dValue" ShowFilter="false" HeaderText="Request Value" 
                                                SortExpression="dValue">
                                            </cc3:C1BoundField>
                                             <cc3:C1BoundField DataField="cCurType" ShowFilter="false" HeaderText="Currency" 
                                                SortExpression="cCurType">
                                            </cc3:C1BoundField>
                                             <cc3:C1BoundField DataField="PO_CreatedDate" HeaderText="Created Date" 
                                                SortExpression="PO_CreatedDate">
                                            </cc3:C1BoundField>
                                              <cc3:C1BoundField DataField="PO_CreatedBy" HeaderText="Created By" 
                                                SortExpression="PO_CreatedBy">
                                            </cc3:C1BoundField> 
                                             <cc3:C1BoundField DataField="PO_Approve_Date"  HeaderText="Approved Date" 
                                                SortExpression="PO_Approve_Date">
                                            </cc3:C1BoundField>
                                              <cc3:C1BoundField DataField="poApprovedby" HeaderText="Approved By" 
                                                SortExpression="poApprovedby">
                                            </cc3:C1BoundField> 
                                              <cc3:C1BoundField DataField="PO_Approved_Byremrk" HeaderText="Remarks(Approved By)" 
                                                SortExpression="PO_Approved_Byremrk">
                                            </cc3:C1BoundField> 
                                            
                                                                                       
                                                           
                                        </Columns>
                                        <PagerSettings PageButtonCount="25" Mode="NextPreviousFirstLast" />
                                               <HeaderStyle Wrap="False" />
                                               <RowStyle Wrap="False" Height="18px" />
                                    </cc3:C1GridView>  
                                   
                                     
                        
                        </div>
                    <div style="text-align:right; border-top:1px solid silver; padding:3px">
                       <div style="float:left; text-align:left; width:200px">
                       <table>
                       <tr>
                       <td><div style="height:10px; width:30px; border:1px solid #C2EF72; background-color:#F5FCE8"></div></td>
                       <td>GRN Completed</td>
                       </tr>
                       </table>
                       </div>
                       <div style="float:right">
                      
                         <asp:Button ID="btnReviseApprove" Width="100px" CssClass="button" runat="server" 
                                                 Text="Re-Work" OnClick="btnReviseApprove_Click" />
                                                 <asp:ConfirmButtonExtender ID="btnReviseApprove_ConfirmButtonExtender" 
                                                 runat="server" ConfirmText="Are you sure?" 
                               Enabled="True" TargetControlID="btnReviseApprove">
                                             </asp:ConfirmButtonExtender>
                                                 <asp:Button ID="btnCancelapp" Width="100px" 
                                CssClass="button" runat="server" 
                                                 Text="Cancel" OnClick="btnCancelapp_Click"  />
                                                 <asp:ConfirmButtonExtender ID="btnCancelapp_ConfirmButtonExtender1" 
                                                 runat="server" ConfirmText="Do you want to cancel?" Enabled="True" TargetControlID="btnCancelapp">
                                             </asp:ConfirmButtonExtender>
                       </div>
                         </div>
                                                 
                </cc2:C1TabPage>
                <cc2:C1TabPage ID="C1TabPage4"  TabIndex="5" Text="Canceled"  CssClass="tab">
                 
                     <div class="pnlmain" style="height:520px; margin:5px">
                  <cc3:C1GridView ID="grdPOCanceled" Width="100%" runat="server" AllowPaging="True" 
                                        AutoGenerateColumns="False" PageSize="24" 
                                        ShowFilter="True" VisualStylePath="~/C1WebControls/VisualStyles" 
                                        AllowSorting="True" 
                                        VisualStyle="Office2007Blue" DefaultColumnWidth="" 
                                        UseEmbeddedVisualStyles="True" 
                                        onpageindexchanging="grdPOCanceled_PageIndexChanging" 
                        OnFiltering="grdPOCanceled_Filtering" AllowColSizing="True" 
                             OnSorting="grdPOCanceled_Sorting">
                                        <Columns>                                     
                                       <cc3:C1TemplateField HeaderText="Print">
                                        <ItemTemplate>
                                        <%--<a style="text-decoration:none;color:Black; padding-left:7px; padding-right:7px" href="javascript:openPopupfull('Smt_Inv_ReportDisplay.aspx?ppno=<%# Eval("PO_No") %>&Param=PONO')">Print</a>--%>
                                         <asp:LinkButton ID="lnkcancelpo"  ToolTip="Generate Report" CssClass="link" runat="server" CommandArgument='<%# Eval("PO_No") %>' 
                                                onclick="lnkcancelpo_Click">Report</asp:LinkButton>  
                                        </ItemTemplate>
                                        </cc3:C1TemplateField>
                                         <cc3:C1TemplateField HeaderText="View">
                                        <ItemTemplate>
                                        <a class="link" href="javascript:vdtlreq1('<%# Eval("PO_No") %>')">View</a>

                                        </ItemTemplate>
                                        </cc3:C1TemplateField>          
                                          <cc3:C1BoundField DataField="PO_No" HeaderText="PO No" SortExpression="PO_No">
                                            </cc3:C1BoundField>                                                                                                                                                            
                                         
                                              <cc3:C1BoundField DataField="cSupName" HeaderText="Supplier" SortExpression="cSupName">
                                            </cc3:C1BoundField>                                                                                  
                                          
                                            <cc3:C1BoundField DataField="dValue" ShowFilter="false" HeaderText="Request Value" 
                                                SortExpression="dValue">
                                            </cc3:C1BoundField>
                                             <cc3:C1BoundField DataField="cCurType" ShowFilter="false" HeaderText="Currency Type" 
                                                SortExpression="cCurType">
                                            </cc3:C1BoundField>
                                            
                                              <cc3:C1BoundField DataField="POCancledby" ShowFilter="false" HeaderText="Cancelled By" 
                                                SortExpression="Created_User">
                                            </cc3:C1BoundField>   

                                             <cc3:C1BoundField DataField="PO_CancelDate" HeaderText="Cancelled Date" 
                                                SortExpression="PO_CancelDate">
                                            </cc3:C1BoundField>                                                
                                        </Columns>
                                        <PagerSettings PageButtonCount="24" Mode="NextPreviousFirstLast" />
                                               <HeaderStyle Wrap="False" />
                                               <RowStyle Wrap="False" Height="18px" />
                                    </cc3:C1GridView>  
                </div>    
                                                     
                </cc2:C1TabPage>      
                             
            </TabPages>
            </cc2:C1TabControl> 

          

                  
    </ContentTemplate>
    </asp:UpdatePanel>
    <div id="ppgenpo" style="height:530px; width:910px; display:none; border:5px solid #64AFEA;background-color:#e9f0fb;-webkit-border-radius: 5px; -moz-border-radius: 5px;border-radius: 5px;">
    <div class="pppnlhdr">
    <div id="hdrtxt" style="float:left; padding-left:20px; color:White">Generate PO</div>
    <div style="float:right; padding-top:2px; padding-right:2px"> 
        <input id="txtchkjv" style="display:none" type="text" />
        <img id="cnclitmpdt" onclick="refreshgpo();" style="cursor:pointer" alt="" src="../gridimage/grdRemove.png" />
    </div>
    </div>
     <div id="divLoading" style="width:600px; text-align:center; vertical-align:bottom; margin-top:200px"> 
       <img src="../images/loader.gif" alt="" /> 
     </div>
     <div id="divFrameHolder" style="display:none">
    <iframe id="ifupldfile" onload="hideLoading()" src="" style="border:none" width="900px" height="500px"></iframe>
    </div>
    </div>
     <div id="D1" class="POPUPPanel">
                                    <div id="POPUPHDR">
                                        <div class="POPUPHeaderText">Add New Buyer</div>
                                        <div class="POPUPClose"></div>      
                                    </div>
                                <iframe id="POPUPIFrame" width="800px" height="550px" src=""></iframe>
                            </div> 
                              <script type="text/javascript">
                                  $(document).ready(function () {
                                      $(".btPOPUP").live("click", function () {
                                          $(".POPUPPanel").hide();
                                          var v = $(this).val();
                                          if (v == "Sub Category") {
                                              $(".POPUPHeaderText").html("Create Sub Category");
                                              $("#POPUPIFrame").attr("src", "../Master_Setup/frmSupCategory.aspx?C=L");
                                          }
                                          if (v == "Article") {
                                              $(".POPUPHeaderText").html("Create New Article");
                                              $("#POPUPIFrame").attr("src", "../Master_Setup/frmArticle.aspx?C=L");
                                          }
                                          if (v == "Dimension") {
                                              $(".POPUPHeaderText").html("Create New Dimension");
                                              $("#POPUPIFrame").attr("src", "../Master_Setup/frmDimension.aspx?C=L");
                                          }
                                          if (v == "Color") {
                                              $(".POPUPHeaderText").html("Create New Color");
                                              $("#POPUPIFrame").attr("src", "../Master_Setup/frmColor.aspx");
                                          }
                                          if (v == "Supplier") {
                                              $(".POPUPHeaderText").html("Create New Supplier");
                                              $("#POPUPIFrame").attr("src", "../Master_Setup/frmSupplier.aspx");
                                          }

                                          $(".POPUPPanel").toggle("slow");
                                          return false;
                                      });

                                      $(".POPUPClose").click(function () {
                                          //$(this).parents(".pnldv").animate({ opacity: 'hide' }, "slow");
                                          $(".POPUPPanel").toggle("slow");
                                      });
                                  });
    </script>

   


</asp:Content>

