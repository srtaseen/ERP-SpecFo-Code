<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="NazCostsheet.aspx.cs" Inherits="NazCostsheet" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
            padding-right: 5px;
            font-size: 11px;
            font-family: Calibri;
            height: 22px;
        }
        .style6
        {
            height: 22px;
        }
        .dvshdo {
-moz-box-shadow: 0 0 5px 5px #71B5E1;
-webkit-box-shadow: 0 0 5px 5px #71B5E1;
box-shadow: 0 0 5px 5px #71B5E1;
border-left:3px solid #3A9DC1; 
border-right:3px solid #3A9DC1; 
padding:5px
}

#podtl 
{
    	-webkit-border-radius: 3px;
    -moz-border-radius: 3px;
    border-radius: 3px;
    border:3px solid #7BDCEF;
    background-color:#DBF5FB;

padding:5px;
display:none;
top:195px; 
position:fixed;
min-width:200px;

}

.tbl {   
     width: 100%;   
     background-color: #fff;   
     margin: 0px 0 2px 0; 
     border: solid 1px #99ccff;   
     border-collapse:collapse;
     
        
 } 
 .tbl td  {   
     text-decoration:none;
     color:Black;
     font-family:Calibri;
     padding-left:5px;
 }  
        .style7
        {
            width: 85px;
        }
        .style8
        {
            height: 22px;
            width: 85px;
        }
        .style9
        {
            padding-right: 5px;
            font-size: 11px;
            font-family: Calibri;
            width: 85px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">&nbsp;<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
    <div class="dvshdo">
    <div>
        <table border="1" class="mGrid" style="width:100%;">
            <tr>
                <td class="label">
                    LC No</td>
                <td>
                    <asp:TextBox ID="tLCNO" runat="server" CssClass="textboxforgridview" Width="170px" 
                        MaxLength="50"></asp:TextBox>
                    &nbsp;</td>
                <td class="label">
                    Style No</td>
                <td>
                    <asp:DropDownList ID="drpStyle" runat="server" CssClass="textboxforgridview" 
                        Width="160px" AutoPostBack="True" 
                        onselectedindexchanged="drpStyle_SelectedIndexChanged">
                    </asp:DropDownList>
                    <input id="btncpy" onclick="cpyitm();" runat="server" visible="false" title="Copy" style="font-size:10px" type="button" value="C" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="drpStyle" Display="None" ErrorMessage="Select Style" 
                        ValidationGroup="v">*</asp:RequiredFieldValidator>
                    <asp:ValidatorCalloutExtender ID="RequiredFieldValidator4_ValidatorCalloutExtender" 
                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator4">
                    </asp:ValidatorCalloutExtender>
                </td>
                <td class="label">
                    Item</td>
                <td>
                    <asp:TextBox ID="tItem" runat="server" CssClass="textboxforgridview" 
                        Width="170px"></asp:TextBox></td>
                <td class="label">
                    Order Unit<asp:RequiredFieldValidator ID="RequiredFieldValidator5" 
                        runat="server" ControlToValidate="txtOrdqty" Display="None" 
                        ErrorMessage="Enter Order Qty" ValidationGroup="v">*</asp:RequiredFieldValidator>
                    <asp:ValidatorCalloutExtender ID="RequiredFieldValidator5_ValidatorCalloutExtender" 
                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator5">
                    </asp:ValidatorCalloutExtender>
                </td>
                <td class="label">
                    <asp:DropDownList ID="drpOrderunit" runat="server" 
                        CssClass="textboxforgridview" Width="80px">
                        <asp:ListItem Selected="True" Text="" Value=""></asp:ListItem>
                        <asp:ListItem Text="PCS" Value="PCS"></asp:ListItem>
                        <asp:ListItem Text="PACK" Value="PACK"></asp:ListItem>
                        <asp:ListItem Text="SET" Value="SET"></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="label">
                    Order Qty</td>
                <td class="label">
                    <asp:TextBox ID="txtOrdqty" runat="server" CssClass="textboxforgridview" 
                        MaxLength="8" ondblclick="javascript:gmtqty();" onkeyup="Allinone();" 
                        Width="60px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="label">
                    Buyer Name</td>
                <td>
                    <asp:TextBox ID="tBuyer" runat="server" CssClass="textboxforgridview" Enabled="False" 
                        Width="170px"></asp:TextBox>
                </td>
                <td class="label">
                    order No</td>
                <td>
                    <asp:TextBox ID="tOrderno" runat="server" CssClass="textboxforgridview" 
                        Width="160px"></asp:TextBox>
                    </td>
                <td class="label">Fabrication
                    </td>
                <td>
                    <asp:TextBox ID="tFabrication" runat="server" CssClass="textboxforgridview" 
                        Width="170px"></asp:TextBox>
                   
                   </td>
                <td class="label">
                    Currency</td>
                <td class="label">
                    <asp:DropDownList ID="drpCurrency" runat="server" CssClass="textboxforgridview" 
                        Width="80px">
                        <asp:ListItem Selected="True" Text="" Value=""></asp:ListItem>
                        <asp:ListItem Text="PCS" Value="PCS"></asp:ListItem>
                        <asp:ListItem Text="PACK" Value="PACK"></asp:ListItem>
                        <asp:ListItem Text="SET" Value="SET"></asp:ListItem>
                    </asp:DropDownList>
                   </td>
                <td class="label">
                    Unit Price</td>
                <td class="label">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" 
                        ControlToValidate="tUnitprice" Display="None" ErrorMessage="Enter Unit Price" 
                        ValidationGroup="v">*</asp:RequiredFieldValidator>
                    <asp:ValidatorCalloutExtender ID="RequiredFieldValidator13_ValidatorCalloutExtender" 
                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator13">
                    </asp:ValidatorCalloutExtender>
                    <asp:TextBox ID="tUnitprice" runat="server" CssClass="textboxforgridview" 
                        MaxLength="8" onkeyup="Allinone();" Width="60px"></asp:TextBox>
                    <asp:FilteredTextBoxExtender ID="tUnitprice_FilteredTextBoxExtender" 
                        runat="server" Enabled="True" TargetControlID="tUnitprice" 
                        ValidChars=".0123456789">
                    </asp:FilteredTextBoxExtender>
                </td>
            </tr>
            
        </table>
        </div>
    <div>
        <hr class="hr" />
    </div>
    <div>
        <table style="width:100%;">
            <tr>
                <td style="padding: 3px; background-color: #42ACD3; font-weight: bold; text-align: center; font-family: Arial, Helvetica, sans-serif; font-size: 10px; color: #FFFFFF;">
                    Material Type<asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
                        runat="server" ControlToValidate="drpType" Display="None" 
                        ErrorMessage="Select Type" ValidationGroup="v">*</asp:RequiredFieldValidator>
                    <asp:ValidatorCalloutExtender ID="RequiredFieldValidator1_ValidatorCalloutExtender" 
                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator1">
                    </asp:ValidatorCalloutExtender>
                </td>
                <td style="padding: 3px; background-color: #42ACD3; font-weight: bold; text-align: center; font-family: Arial, Helvetica, sans-serif; font-size: 10px; color: #FFFFFF;">
                    Material Description<asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
                        runat="server" ControlToValidate="txtDescription" Display="None" 
                        ErrorMessage="Enter Description" ValidationGroup="v">*</asp:RequiredFieldValidator>
                    <asp:ValidatorCalloutExtender ID="RequiredFieldValidator2_ValidatorCalloutExtender" 
                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator2">
                    </asp:ValidatorCalloutExtender>
                </td>
                <td style="padding: 3px; background-color: #42ACD3; font-weight: bold; text-align: center; font-family: Arial, Helvetica, sans-serif; font-size: 10px; color: #FFFFFF;">
                    Gmt.Qty</td>
                <td style="padding: 3px; background-color: #42ACD3; font-weight: bold; text-align: center; font-family: Arial, Helvetica, sans-serif; font-size: 10px; color: #FFFFFF;">
                    Consumption<asp:RequiredFieldValidator ID="RequiredFieldValidator3" 
                        runat="server" ControlToValidate="txtConsumption" Display="None" 
                        ErrorMessage="Enter Consumption" ValidationGroup="v">*</asp:RequiredFieldValidator>
                    <asp:ValidatorCalloutExtender ID="RequiredFieldValidator3_ValidatorCalloutExtender" 
                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator3">
                    </asp:ValidatorCalloutExtender>
                </td>
                <td style="padding: 3px; background-color: #42ACD3; font-weight: bold; text-align: center; font-family: Arial, Helvetica, sans-serif; font-size: 10px; color: #FFFFFF;">
                    %</td>
                <td style="padding: 3px; background-color: #42ACD3; font-weight: bold; text-align: center; font-family: Arial, Helvetica, sans-serif; font-size: 10px; color: #FFFFFF;">
                    Req Qty</td>
                <td style="padding: 3px; background-color: #42ACD3; font-weight: bold; text-align: center; font-family: Arial, Helvetica, sans-serif; font-size: 10px; color: #FFFFFF;">
                    Cons.Unit</td>
                <td style="padding: 3px; background-color: #42ACD3; font-weight: bold; text-align: center; font-family: Arial, Helvetica, sans-serif; font-size: 10px; color: #FFFFFF;">
                    Unit Price</td>
                <td style="padding: 3px; background-color: #42ACD3; font-weight: bold; text-align: center; font-family: Arial, Helvetica, sans-serif; font-size: 10px; color: #FFFFFF;">
                    Amount/Dz</td>
                <td style="padding: 3px; background-color: #42ACD3; font-weight: bold; text-align: center; font-family: Arial, Helvetica, sans-serif; font-size: 10px; color: #FFFFFF;">
                    Total Cost</td>
                <td style="padding: 3px; background-color: #42ACD3; font-weight: bold; text-align: center; font-family: Arial, Helvetica, sans-serif; font-size: 10px; color: #FFFFFF;">
                    Supplier Type</td>
                <td style="padding: 3px; background-color: #42ACD3; font-weight: bold; text-align: center; font-family: Arial, Helvetica, sans-serif; font-size: 10px; color: #FFFFFF;">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="background-color: #B2DDED">
                    <asp:DropDownList ID="drpType" runat="server" CssClass="textboxforgridview" 
                        Width="100px">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem Text="YARN" Value="YARN"></asp:ListItem>
                        <asp:ListItem Text="KNITTING" Value="KNITTING"></asp:ListItem>
                         <asp:ListItem Text="DYEING" Value="DYEING"></asp:ListItem>
                        <asp:ListItem Text="FABRIC" Value="FABRIC"></asp:ListItem>      
                        <asp:ListItem Text="PRINT & EMBROIDARY" Value="PRINT & EMBROIDARY"></asp:ListItem>                  
                        <asp:ListItem Text="ACCESSORIES" Value="ACCESSORIES"></asp:ListItem>
                        
                    </asp:DropDownList>
                </td>
                <td style="background-color: #B2DDED">
                    <asp:TextBox ID="txtDescription" runat="server" CssClass="textboxforgridview" 
                        Width="180px"></asp:TextBox>
                </td>
                <td style="background-color: #B2DDED">
                    <asp:TextBox ID="txtGmtQty" runat="server" CssClass="textbox" 
                        Width="40px" Enabled="false" ></asp:TextBox>
                    <img alt="" onclick="podtltgl();"  width="13px" height="13px" src="gridimage/src.png" />  
                    <div id="podtl" style="display:none; width:300px; min-height:200px; max-height:400px; overflow:auto; border:1px solid silver;">
                        <asp:GridView ID="grdcolqty" Width="100%" AutoGenerateColumns="false" runat="server">
                            <AlternatingRowStyle BackColor="#0099CC" ForeColor="White" Font-Names="Arial" Font-Size="10px" />
                        <Columns>
                        <asp:TemplateField HeaderText="Color Name">
                        <ItemTemplate>
                            <asp:Label ID="lblcolname" runat="server" Text='<%# Eval("cColour") %>'></asp:Label>
                        </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Qty">
                        <ItemTemplate>
                            <asp:Label ID="lblqty" runat="server" Text='<%# Eval("ntot") %>'></asp:Label>
                        </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Select">
                        <ItemTemplate>
                            <asp:CheckBox ID="chkcol" onclick="javascript:chkgrd();" runat="server" />
                        </ItemTemplate>
                        </asp:TemplateField>
                        </Columns>
                            <HeaderStyle BackColor="#0085B0" Font-Names="Arial" Font-Size="13px" 
                                ForeColor="White" />
                            <RowStyle Font-Names="Arial" Font-Size="10px" />
                        </asp:GridView>
                    </div>                
                </td>
                <td style="background-color: #B2DDED">
                    <asp:TextBox ID="txtConsumption" runat="server" CssClass="textbox" 
                        onkeyup="Calculateamount();" Width="70px" MaxLength="6"></asp:TextBox>
                    <asp:FilteredTextBoxExtender ID="txtConsumption_FilteredTextBoxExtender" 
                        runat="server" Enabled="True" TargetControlID="txtConsumption" 
                        ValidChars=".0123456789">
                    </asp:FilteredTextBoxExtender>
                </td>
                <td style="background-color: #B2DDED">
                    <asp:TextBox ID="txtPercent" onkeyup="Calculateamount();" runat="server" 
                        Width="30px" CssClass="textbox" MaxLength="5"></asp:TextBox>
                    <asp:FilteredTextBoxExtender ID="txtPercent_FilteredTextBoxExtender" 
                        runat="server" Enabled="True" TargetControlID="txtPercent" 
                        ValidChars=".0123456789">
                    </asp:FilteredTextBoxExtender>
                </td>
                <td style="background-color: #B2DDED">
                    <asp:TextBox ID="txtReqqty" runat="server" Width="60px" CssClass="textbox" 
                        Enabled="False"></asp:TextBox>
                </td>
                <td style="background-color: #B2DDED">
                    <asp:DropDownList ID="drpConsunit" runat="server" CssClass="textboxforgridview" 
                        Width="70px">
                    </asp:DropDownList>
                </td>
                <td style="background-color: #B2DDED">
                    <asp:TextBox ID="txtUnitprice" onkeyup="Calculateamount();" runat="server" 
                        Width="60px" CssClass="textbox" MaxLength="5"></asp:TextBox>
                    <asp:FilteredTextBoxExtender ID="txtUnitprice_FilteredTextBoxExtender" 
                        runat="server" Enabled="True" TargetControlID="txtUnitprice" 
                        ValidChars=".0123456789">
                    </asp:FilteredTextBoxExtender>
                </td>
                <td style="background-color: #B2DDED">
                    <asp:TextBox ID="txtAmount" runat="server" Width="60px" CssClass="textbox" 
                        Enabled="False"></asp:TextBox>
                </td>
                <td style="background-color: #B2DDED">
                    <asp:TextBox ID="txtTotalcost" runat="server" Width="80px" CssClass="textbox" 
                        Enabled="False"></asp:TextBox>
                </td>
                <td style="background-color: #B2DDED">
                    <asp:DropDownList ID="drpSuppliertype" runat="server" 
                        CssClass="textboxforgridview" Width="100px">
                        
                        <asp:ListItem Selected="True" Text="Inside" Value="Inside"></asp:ListItem>
                        <asp:ListItem Text="Outside" Value="Outside"></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td style="background-color: #B2DDED">
                    <asp:Button ID="btnAdditem" runat="server" Font-Size="9px" Text="Add" 
                        onclick="btnAdditem_Click" ValidationGroup="v" />
                </td>
            </tr>
        </table>
        </div>
    <div>
        <asp:GridView ID="grdcost" runat="server" AutoGenerateColumns="false" 
            CssClass="mGrid"  Width="100%" onrowdatabound="grdcost_RowDataBound">
            <AlternatingRowStyle BackColor="#D1E0EF" Font-Names="Arial" Font-Size="9px" 
                ForeColor="#666666" />
            <Columns>
                
                <asp:TemplateField HeaderText="Type">
                    <ItemTemplate>
                        <asp:Label ID="lblType" runat="server" Text='<%# Eval("MatType") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Item Description">
                    <ItemTemplate>
                        <asp:Label ID="lblitem" runat="server" Text='<%# Eval("MatDesc") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Gmt Qty">
                    <ItemTemplate>
                        <asp:Label ID="lblGmtqty" runat="server" Text='<%# Eval("GmtQty") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Cons.">
                    <ItemTemplate>
                        <asp:Label ID="lblConsumption" runat="server" Text='<%# Eval("Comnsmption") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="%">
                    <ItemTemplate>
                        <asp:Label ID="lblfabprcnt" runat="server" Text='<%# Eval("Prcent") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Req Qty">
                    <ItemTemplate>
                        <asp:Label ID="lblReqqty" runat="server" Text='<%# Eval("Reqqty") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Cons. Unit">
                    <ItemTemplate>
                        <asp:Label ID="lblconsmptunit" Visible="false" runat="server"  Width="20px"
                            Text='<%# Eval("ConsUnit") %>'></asp:Label>
                        <asp:Label ID="lblconsmptunitdesc" runat="server" 
                            Text='<%# Eval("cUnitDes") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="U.Price">
                    <ItemTemplate>
                        <asp:Label ID="lbluprice" runat="server" Text='<%# Eval("Unitprice") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Amount/Dz">
                    <ItemTemplate>
                        <asp:Label ID="lblamnt" runat="server" Text='<%# Eval("Amntdz") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Total Cost">
                    <ItemTemplate>
                        <asp:Label ID="lblTotalcost" runat="server" Text='<%# Eval("Costttl") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Supplier Type">
                    <ItemTemplate>
                        <asp:Label ID="lblsupatype" runat="server" Text='<%# Eval("SupplierType") %>'></asp:Label>
                    
                    </ItemTemplate>
                </asp:TemplateField>
               <%-- <asp:TemplateField HeaderText="">
                    <ItemTemplate>
                        <img width="13" height="13" style="cursor:pointer" id="btnEdt" title="Edit" runat="server" alt="Edit" src="gridimage/edit.png" />
                    </ItemTemplate>
                </asp:TemplateField>--%>
                <asp:TemplateField HeaderText="">
                    <ItemTemplate>
                        <asp:ImageButton ID="btnDelete" runat="server" 
                            ImageUrl="~/gridimage/grdRemove.png" Width="13px" 
                            onclick="btnDelete_Click" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <%--  <AlternatingRowStyle CssClass="gridrowAlternaterow" />
        <HeaderStyle CssClass="gridheader" />
        <RowStyle CssClass="gridrow" />--%>
            <HeaderStyle BackColor="#1DC4D9" ForeColor="White" Font-Names="Arial" 
                Font-Size="11px" />
            <RowStyle BackColor="#CCEEFF" Font-Names="Arial" Font-Size="9px" 
                ForeColor="#0066CC" />
        </asp:GridView>
        </div>
    <div>
        <hr class="hr" />
        </div>
    <div>
        <table style="width:100%;">
            <tr>
                <td style="width:230px; vertical-align:top;">
                    <table style="width:100%;" >
                        <tr>
                            <td colspan="2" style="background-color: #F2F2F2; border-top:1px solid #E2CAF3; border-bottom:1px solid #E2CAF3;">
                                Yarn </td>
                        </tr>
                        <tr>
                            <td class="label" 
                                style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: right;">
                                Yarn Cost/Dz</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="tYarncostdz" runat="server" CssClass="textbox" Width="60px" 
                                    Enabled="False"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="label" 
                                style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: right;">
                                Total Yarn Cost</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="tYarncostttl" runat="server" CssClass="textbox" Width="60px" 
                                    Enabled="False"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="label" 
                                style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: right;">
                                Inside Total</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="tYarninside" runat="server" CssClass="textbox" Width="60px" 
                                    Enabled="False"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="label" 
                                style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: right;">
                                Outside Total</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="tYarnoutside" runat="server" CssClass="textbox" Width="60px" 
                                    Enabled="False"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="background-color: #F2F2F2; border-top:1px solid #E2CAF3; border-bottom:1px solid #E2CAF3;">
                                Knitting</td>
                        </tr>
                        <tr>
                            <td class="label" 
                                style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: right;">
                                Knitting Charge/dz</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="tknDz" runat="server" CssClass="textbox" Width="60px" 
                                    Enabled="False"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="label" 
                                style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: right;">
                                Total Knitting Charge</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="tKnttl" runat="server" CssClass="textbox" Width="60px" 
                                    Enabled="False"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="label" 
                                style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: right;">
                                Inside Total</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="tknInside" runat="server" CssClass="textbox" Width="60px" 
                                    Enabled="False"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="label" 
                                style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: right;">
                                Outside Total</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="tknoutside" runat="server" CssClass="textbox" Width="60px" 
                                    Enabled="False"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                  </td>
               <td style="width:230px; vertical-align:top;">
                    <table style="width:100%;">
                        <tr>
                            <td colspan="2" style="background-color: #F2F2F2; border-top:1px solid #E2CAF3; border-bottom:1px solid #E2CAF3;">
                                Dyeing</td>
                        </tr>
                        <tr>
                            <td class="label" 
                                style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: right;">
                                Dyeing charge/Dz</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;" 
                                class="style7">
                                <asp:TextBox ID="tdyndz" runat="server" CssClass="textbox" Width="60px" 
                                    Enabled="False"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="label" 
                                style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: right;">
                                Total Dyeing Charge</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;" 
                                class="style7">
                                <asp:TextBox ID="tdynttl" runat="server" CssClass="textbox" Width="60px" 
                                    Enabled="False"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="label" 
                                style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: right;">
                                Inside Total</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;" 
                                class="style7">
                                <asp:TextBox ID="tdyninside" runat="server" CssClass="textbox" Width="60px" 
                                    Enabled="False"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style5" 
                                style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: right;">
                                Outside Total</td>
                            <td class="style8" 
                                
                                style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="tdynoutside" runat="server" CssClass="textbox" Width="60px" 
                                    Enabled="False"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="label" style="font-weight: bold;" colspan="2">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="label" 
                                
                                style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: right; font-weight: 700;">
                                Total Cost (Yarn+Knitting+Dyeing)</td>
                            <td class="style9" 
                                
                                style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="tTtlgray" runat="server" CssClass="textbox" Enabled="False" 
                                    Width="60px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="label" 
                                style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: right;">
                                Dyed Fabric/Dz</td>
                            <td class="style9" 
                                
                                style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="tdyedfabdz" runat="server" CssClass="textbox" Width="60px" 
                                    Enabled="False"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="label" 
                                style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: right;">
                                Fabric Consumption</td>
                            <td class="style9" 
                                
                                style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="tFabconsumption" onkeyup="dyedfabkg();" runat="server" CssClass="textbox" 
                                    Width="60px" MaxLength="5"></asp:TextBox>
                                <asp:FilteredTextBoxExtender ID="tFabconsumption_FilteredTextBoxExtender" 
                                    runat="server" Enabled="True" TargetControlID="tFabconsumption" 
                                    ValidChars=".0123456789">
                                </asp:FilteredTextBoxExtender>
                            </td>
                        </tr>
                        <tr>
                            <td class="label" 
                                style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: right;">
                                Dyed Fabric/KG</td>
                            <td class="style9" 
                                style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="tDyedfabkg" runat="server" CssClass="textbox" Enabled="False" 
                                    Width="60px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="label" 
                                
                                style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: right; font-weight: 700;">
                            Total Cost Of Dyed Fabric
                            </td>
                            <td class="style9" 
                                
                                style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                            <asp:TextBox ID="tTotalcostdyedfab" runat="server" CssClass="textbox" Width="60px" 
                                    Enabled="False"></asp:TextBox>
                               </td>
                        </tr>
                    </table>
                    </td>
               <td style="width:230px; vertical-align:top;">
                   <table style="width:100%;">
                       <tr>
                           <td colspan="2" style="background-color: #F2F2F2; border-top:1px solid #E2CAF3; border-bottom:1px solid #E2CAF3;">
                               Fabric</td>
                       </tr>
                       <tr>
                           <td class="label" 
                               style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: right; width: 140px;">
                               Fabric Cost/Dz</td>
                           <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                               <asp:TextBox ID="tfabdz" runat="server" CssClass="textbox" Width="60px" 
                                   Enabled="False"></asp:TextBox>
                           </td>
                       </tr>
                       <tr>
                           <td class="label" 
                               style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: right;">
                               Total Fabric Cost</td>
                           <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                               <asp:TextBox ID="tfabttl" runat="server" CssClass="textbox" Width="60px" 
                                   Enabled="False"></asp:TextBox>
                           </td>
                       </tr>
                       <tr>
                           <td class="label" 
                               style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: right;">
                               Inside Total</td>
                           <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                               <asp:TextBox ID="tfabinside" runat="server" CssClass="textbox" Width="60px" 
                                   Enabled="False"></asp:TextBox>
                           </td>
                       </tr>
                       <tr>
                           <td class="label" 
                               style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: right;">
                               Outside Total</td>
                           <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                               <asp:TextBox ID="tfabout" runat="server" CssClass="textbox" Width="60px" 
                                   Enabled="False"></asp:TextBox>
                           </td>
                       </tr>
                       <tr>
                           <td colspan="2">
                               <table style="width:100%;">
                                   <tr>
                                       <td colspan="2" style="background-color: #F2F2F2; border-top:1px solid #E2CAF3; border-bottom:1px solid #E2CAF3;">
                                           Print &amp; Embroidary</td>
                                   </tr>
                                   <tr>
                                       <td class="label" 
                                           style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: right; width: 150px;">
                                           Print &amp; Emb Charge/Dz</td>
                                       <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                           <asp:TextBox ID="tembdz" runat="server" CssClass="textbox" Width="60px" 
                                               Enabled="False"></asp:TextBox>
                                       </td>
                                   </tr>
                                   <tr>
                                       <td class="label" 
                                           style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: right;">
                                           Total Print &amp; Emb Charge</td>
                                       <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                           <asp:TextBox ID="tembttl" runat="server" CssClass="textbox" Width="60px" 
                                               Enabled="False"></asp:TextBox>
                                       </td>
                                   </tr>
                                   <tr>
                                       <td class="label" 
                                           style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: right;">
                                           Inside Total</td>
                                       <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                           <asp:TextBox ID="tembinside" runat="server" CssClass="textbox" Width="60px" 
                                               Enabled="False"></asp:TextBox>
                                       </td>
                                   </tr>
                                   <tr>
                                       <td class="label" 
                                           style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: right;">
                                           Outside Total</td>
                                       <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                           <asp:TextBox ID="temboutside" runat="server" CssClass="textbox" Width="60px" 
                                               Enabled="False"></asp:TextBox>
                                       </td>
                                   </tr>
                               </table>
                           </td>
                       </tr>
                   </table>
                   </td>
                <td style="vertical-align:top;">
                    <table style="width:100%;">
                        <tr>
                            <td colspan="2" style="background-color: #F2F2F2; border-top:1px solid #E2CAF3; border-bottom:1px solid #E2CAF3;">
                                Accessories</td>
                        </tr>
                        <tr>
                            <td class="label" 
                                style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: right;">
                                Accessories Cost/Dz</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="taccdz" runat="server" CssClass="textbox" Width="120px" 
                                    Enabled="False"></asp:TextBox>
                                </td>
                        </tr>
                        <tr>
                            <td class="label" 
                                style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: right;">
                                Total Accessories Cost</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="taccttl" runat="server" CssClass="textbox" Width="120px" 
                                    Enabled="False"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="label" 
                                style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: right;">
                                Inside Total</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="taccinside" runat="server" CssClass="textbox" Width="120px" 
                                    Enabled="False"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="label" 
                                style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: right;">
                                Outside Total</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="taccoutside" runat="server" CssClass="textbox" Width="120px" 
                                    Enabled="False"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="label" 
                                style="border: 1px solid #C4C4C4; font-size: 9px; font-family: Arial, Helvetica, sans-serif; color: #333333; text-align: right;">
                                Total Cost</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="Tfinaltotalcost" runat="server" CssClass="textbox" Enabled="False" 
                                    Width="120px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="label" 
                                style="border: 1px solid #C4C4C4; font-size: 9px; font-family: Arial, Helvetica, sans-serif; color: #333333; text-align: right;">
                                Total Cost/dz</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="tTotalcostdz" runat="server" CssClass="textbox" Width="120px" 
                                    Enabled="False"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="label" colspan="2" style="font-weight: bold; font-size: 14px;">
                                <hr class="hr" />
                            </td>
                        </tr>
                        <tr>
                            <td class="label" 
                                
                                style="border: 1px solid #C4C4C4; font-size: 9px; font-family: Arial, Helvetica, sans-serif; color: #333333; text-align: right; font-weight: 700;">
                                Total Inside Cost</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="tTotalinside" runat="server" CssClass="textbox" Width="60px" 
                                    Enabled="False"></asp:TextBox>
                                <asp:TextBox ID="tTotalinsideprcnt" runat="server" CssClass="textbox" 
                                    Width="40px" Enabled="False"></asp:TextBox>
                                (%)</td>
                        </tr>
                        <tr>
                            <td class="label" 
                                
                                style="border: 1px solid #C4C4C4; font-size: 9px; font-family: Arial, Helvetica, sans-serif; color: #333333; text-align: right; font-weight: 700;">
                                Total Outside Cost</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="tTotaloutside" runat="server" CssClass="textbox" Width="60px" 
                                    Enabled="False"></asp:TextBox>
                                <asp:TextBox ID="tTotaloutsideprcnt" runat="server" CssClass="textbox" 
                                    Width="40px" Enabled="False"></asp:TextBox>
                                (%)</td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        </div>
    <div>
        <hr class="hr" />
    </div>
    <div>
    
        <table style="width:100%;">
            <tr>
                <td style="vertical-align:top; width:240px;">
                   
                    <table style="width:100%;">
                        <tr>
                            <td colspan="2" style="background-color: #EAEAEA; height:22px">
                               OTHER'S
                               </td>
                        </tr>
                        <tr>
                            <td style="border: 1px solid #C4C4C4; text-align: right; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333;">
                                Extra Fabric Cost(%)</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="tExfabcost" onkeyup="Allinone();" runat="server" CssClass="textbox" 
                                    Width="50px" MaxLength="8"></asp:TextBox>
                                <asp:FilteredTextBoxExtender ID="tExfabcost_FilteredTextBoxExtender" 
                                    runat="server" Enabled="True" TargetControlID="tExfabcost" 
                                    ValidChars=".0123456789">
                                </asp:FilteredTextBoxExtender>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: 1px solid #C4C4C4; text-align: right; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333;">
                                Extra Accessories Cost</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="tExacccost" onkeyup="Allinone();" runat="server" CssClass="textbox" 
                                    Width="50px" MaxLength="8"></asp:TextBox>
                                <asp:FilteredTextBoxExtender ID="tExacccost_FilteredTextBoxExtender" 
                                    runat="server" Enabled="True" TargetControlID="tExacccost" 
                                    ValidChars=".0123456789">
                                </asp:FilteredTextBoxExtender>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: 1px solid #C4C4C4; text-align: right; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333;">
                                Cost of Material/Dz</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="tCostofmacking" onkeyup="Allinone();" runat="server" CssClass="textbox" 
                                    Width="50px" MaxLength="8" Enabled="False"></asp:TextBox>
                                <asp:FilteredTextBoxExtender ID="tCostofmacking_FilteredTextBoxExtender" 
                                    runat="server" Enabled="True" TargetControlID="tCostofmacking" 
                                    ValidChars=".0123456789">
                                </asp:FilteredTextBoxExtender>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: 1px solid #C4C4C4; text-align: right; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333;">
                                Commercial &amp; Bank</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="tCommercialbnkamt" onkeyup="Allinone();" runat="server" CssClass="textbox" 
                                    Width="50px" MaxLength="8"></asp:TextBox>
                                <asp:FilteredTextBoxExtender ID="tCommercialbnkamt_FilteredTextBoxExtender" 
                                    runat="server" Enabled="True" TargetControlID="tCommercialbnkamt" 
                                    ValidChars=".0123456789">
                                </asp:FilteredTextBoxExtender>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: 1px solid #C4C4C4; text-align: right; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333;">
                                &nbsp;</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="tCommercialbnkamtttl" runat="server" CssClass="textbox" 
                                    Enabled="False" Width="50px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: 1px solid #C4C4C4; text-align: right; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333;">
                                Buying Commission %</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="tBuyercommission" onkeyup="Allinone();" runat="server" CssClass="textbox" 
                                    Width="50px" MaxLength="8"></asp:TextBox>
                                <asp:FilteredTextBoxExtender ID="tBuyercommission_FilteredTextBoxExtender" 
                                    runat="server" Enabled="True" TargetControlID="tBuyercommission" 
                                    ValidChars=".0123456789">
                                </asp:FilteredTextBoxExtender>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: 1px solid #C4C4C4; text-align: right; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333;">
                                &nbsp;</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="tBuyercommissionttl" runat="server" CssClass="textbox" 
                                    Enabled="False" Width="50px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: 1px solid #C4C4C4; text-align: right; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333;">
                                Testing Charge (SGS/MTL/ITS)</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="tTestingchargeamt" onkeyup="Allinone();" runat="server" CssClass="textbox" 
                                    Width="50px" MaxLength="8"></asp:TextBox>
                                <asp:FilteredTextBoxExtender ID="tTestingchargeamt_FilteredTextBoxExtender" 
                                    runat="server" Enabled="True" TargetControlID="tTestingchargeamt" 
                                    ValidChars=".0123456789">
                                </asp:FilteredTextBoxExtender>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: 1px solid #C4C4C4; text-align: right; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333;">
                                &nbsp;</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="tTestingchargettl" runat="server" CssClass="textbox" 
                                    Enabled="False" Width="50px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: 1px solid #C4C4C4; text-align: right; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333;">
                                CNF Cost</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="tCnfamt" onkeyup="Allinone();" runat="server" CssClass="textbox" 
                                    Width="50px" MaxLength="8"></asp:TextBox>
                                <asp:FilteredTextBoxExtender ID="tCnfamt_FilteredTextBoxExtender" 
                                    runat="server" Enabled="True" TargetControlID="tCnfamt" 
                                    ValidChars=".0123456789">
                                </asp:FilteredTextBoxExtender>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: 1px solid #C4C4C4; text-align: right; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333;">
                                &nbsp;</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="tCnfttl" runat="server" CssClass="textbox" 
                                    Enabled="False" Width="50px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: 1px solid #C4C4C4; text-align: right; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; font-weight: 700;">
                                FOB Value Per Dozen</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="tCnfperdz" runat="server" CssClass="textbox" Enabled="False" 
                                    Width="50px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: 1px solid #C4C4C4; text-align: right; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; font-weight: 700;">
                                Other Charges
                                </td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="txtOtherchngs" runat="server" CssClass="textbox" Width="50px" 
                                    MaxLength="10"></asp:TextBox>
                                <asp:FilteredTextBoxExtender ID="txtOtherchngs_FilteredTextBoxExtender1" 
                                    runat="server" Enabled="True" TargetControlID="txtOtherchngs" 
                                    ValidChars=".0123456789">
                                </asp:FilteredTextBoxExtender>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: 1px solid #C4C4C4; text-align: right; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; font-weight: 700;">
                                CM/Unit</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="txtCmDzmanual" runat="server" CssClass="textbox" 
                                    MaxLength="10" Width="50px"></asp:TextBox>
                                <asp:FilteredTextBoxExtender ID="txtCmDzmanual_FilteredTextBoxExtender" 
                                    runat="server" Enabled="True" TargetControlID="txtCmDzmanual" 
                                    ValidChars=".0123456789">
                                </asp:FilteredTextBoxExtender>
                            </td>
                        </tr>
                    </table>
                   
                   </td>
                <td style="vertical-align:top; width:530px;">
                    <table style="width:100%;">
                        <tr>
                            <td>
                                <table style="width:100%;">
                                    <tr>
                                        <td style="background-color: #F3F3F3">
                                            MASTER L/C VALUE</td>
                                        <td style="background-color: #F3F3F3">
                                            <asp:TextBox ID="tMasterlcval" runat="server" CssClass="textbox" Enabled="False" 
                                                Width="70px"></asp:TextBox>
                                        </td>
                                        <td style="background-color: #F3F3F3">
                                            % of BBLC</td>
                                    </tr>
                                    <tr>
                                        <td class="label" 
                                            style="border: 1px solid #C4C4C4; text-align: right; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333;">
                                            Value/Percentage of BBL/C for Yarn</td>
                                        <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                            <asp:TextBox ID="tLcyarn" runat="server" CssClass="textbox" 
                                                Enabled="False" Width="70px"></asp:TextBox>
                                        </td>
                                        <td style="border: 1px solid #C4C4C4; text-align: left; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333;" 
                                            class="label">
                                            <asp:TextBox ID="tLcyarnprcnt" runat="server" CssClass="textbox" 
                                                Enabled="False" Width="60px"></asp:TextBox>
                                            (%)</td>
                                    </tr>
                                    <tr>
                                        <td class="label" 
                                            style="border: 1px solid #C4C4C4; text-align: right; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333;">
                                            Value/Percentage of BBL/C for Knitting</td>
                                        <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                            <asp:TextBox ID="tLcknit" runat="server" CssClass="textbox" 
                                                Enabled="False" Width="70px"></asp:TextBox>
                                        </td>
                                        <td style="border: 1px solid #C4C4C4; text-align: left; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333;" 
                                            class="label">
                                            <asp:TextBox ID="tLcknitprcnt" runat="server" CssClass="textbox" 
                                                Enabled="False" Width="60px"></asp:TextBox>
                                            (%)</td>
                                    </tr>
                                    <tr>
                                        <td class="label" 
                                            style="border: 1px solid #C4C4C4; text-align: right; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333;">
                                            Value/Percentage of BBL/C for Accessories</td>
                                        <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                            <asp:TextBox ID="tLCaccessories" runat="server" CssClass="textbox" 
                                                Enabled="False" Width="70px"></asp:TextBox>
                                        </td>
                                        <td style="border: 1px solid #C4C4C4; text-align: left; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333;" 
                                            class="label">
                                            <asp:TextBox ID="tLCaccessoriesprcnt" runat="server" CssClass="textbox" 
                                                Enabled="False" Width="60px"></asp:TextBox>
                                            (%)</td>
                                    </tr>
                                    <tr>
                                        <td class="label" 
                                            style="border: 1px solid #C4C4C4; text-align: right; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333;">
                                            Value/Percentage of B/B Dyes &amp; Chemical &amp; ETP (Dyeing Inside)</td>
                                        <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                            <asp:TextBox ID="tLCdyinginside" runat="server" CssClass="textbox" 
                                                Enabled="False" Width="70px"></asp:TextBox>
                                        </td>
                                        <td style="border: 1px solid #C4C4C4; text-align: left; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333;" 
                                            class="label">
                                            <asp:TextBox ID="tLCdyinginsideprcnt" runat="server" CssClass="textbox" 
                                                Enabled="False" Width="60px"></asp:TextBox>
                                            (%)</td>
                                    </tr>
                                    <tr>
                                        <td class="label" 
                                            style="border: 1px solid #C4C4C4; text-align: right; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333;">
                                            Value/Percentage of B/BLC for Dyeing Outside (AOP, Yarn Dyeing,
                                            <br />
                                            Pigment Dyeing &amp; etc.)</td>
                                        <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                            <asp:TextBox ID="tLcdyingoutside" runat="server" CssClass="textbox" 
                                                Enabled="False" Width="70px"></asp:TextBox>
                                        </td>
                                        <td style="border: 1px solid #C4C4C4; text-align: left; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333;" 
                                            class="label">
                                            <asp:TextBox ID="tLcdyingoutsideprcnt" runat="server" CssClass="textbox" 
                                                Enabled="False" Width="60px"></asp:TextBox>
                                            (%)</td>
                                    </tr>
                                    <tr>
                                        <td class="label" 
                                            style="border: 1px solid #C4C4C4; text-align: right; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333;">
                                            Value/Percentage of BBL/C for Fabric</td>
                                        <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                            <asp:TextBox ID="tLcFabric" runat="server" CssClass="textbox" Enabled="False" 
                                                Width="70px"></asp:TextBox>
                                        </td>
                                        <td style="border: 1px solid #C4C4C4; text-align: left; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333;" 
                                            class="label">
                                            <asp:TextBox ID="tLcFabricprcent" runat="server" CssClass="textbox" 
                                                Enabled="False" Width="60px"></asp:TextBox>
                                            (%)</td>
                                    </tr>
                                    <tr>
                                        <td class="label" 
                                            style="border: 1px solid #C4C4C4; text-align: right; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333;">
                                            Value/Percentage of BBL/C for Print &amp; Embroydary</td>
                                        <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                            <asp:TextBox ID="tLCprintembdry" runat="server" CssClass="textbox" 
                                                Enabled="False" Width="70px"></asp:TextBox>
                                        </td>
                                        <td class="label" 
                                            style="border: 1px solid #C4C4C4; text-align: left; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333;">
                                            <asp:TextBox ID="tLCprintembdryprcnt" runat="server" CssClass="textbox" 
                                                Enabled="False" Width="60px"></asp:TextBox>
                                            (%)</td>
                                    </tr>
                                    <tr>
                                        <td class="label" 
                                            style="border: 1px solid #C4C4C4; text-align: right; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333;">
                                            Value/Percentage of BBL/C for Testing Charge</td>
                                        <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                            <asp:TextBox ID="tLctstingcharge" runat="server" CssClass="textbox" 
                                                Enabled="False" Width="70px"></asp:TextBox>
                                        </td>
                                        <td style="border: 1px solid #C4C4C4; text-align: left; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333;" 
                                            class="label">
                                            <asp:TextBox ID="tLctstingchargeprcnt" runat="server" CssClass="textbox" 
                                                Enabled="False" Width="60px"></asp:TextBox>
                                            (%)</td>
                                    </tr>
                                    <tr>
                                        <td class="label" 
                                            style="border: 1px solid #C4C4C4; text-align: right; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333;">
                                            Value/Percentage of BBL/C for CNF Cost</td>
                                        <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                            <asp:TextBox ID="tLCcnf" runat="server" CssClass="textbox" 
                                                Enabled="False" Width="70px"></asp:TextBox>
                                        </td>
                                        <td style="border: 1px solid #C4C4C4; text-align: left; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333;" 
                                            class="label">
                                            <asp:TextBox ID="tLCcnfprcnt" runat="server" CssClass="textbox" 
                                                Enabled="False" Width="60px"></asp:TextBox>
                                            (%)</td>
                                    </tr>
                                    <tr>
                                        <td class="label" 
                                            style="border: 1px solid #C4C4C4; text-align: right; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333;">
                                            Value/Percentage of BBL/C for Buying Commission</td>
                                        <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                            <asp:TextBox ID="tLcbuyercommission" runat="server" CssClass="textbox" 
                                                Enabled="False" Width="70px"></asp:TextBox>
                                        </td>
                                        <td style="border: 1px solid #C4C4C4; text-align: left; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333;" 
                                            class="label">
                                            <asp:TextBox ID="tLcbuyercommissionprcnt" runat="server" CssClass="textbox" 
                                                Enabled="False" Width="60px"></asp:TextBox>
                                            (%)</td>
                                    </tr>
                                    <tr>
                                        <td class="label" 
                                            style="border: 1px solid #C4C4C4; text-align: right; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333;">
                                            Value/Percentage of BBL/C for Commercial &amp; Bank</td>
                                        <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                            <asp:TextBox ID="tLCcommercialbnk" runat="server" CssClass="textbox" 
                                                Enabled="False" Width="70px"></asp:TextBox>
                                        </td>
                                        <td style="border: 1px solid #C4C4C4; text-align: left; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333;" 
                                            class="label">
                                            <asp:TextBox ID="tLCcommercialbnkprcnt" runat="server" CssClass="textbox" 
                                                Enabled="False" Width="60px"></asp:TextBox>
                                            (%)</td>
                                    </tr>
                                    <tr>
                                        <td class="label" 
                                            
                                            style="border: 1px solid #C4C4C4; text-align: right; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; font-weight: 700;">
                                            Total Value/Percentage of BBL/C</td>
                                        <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                            <asp:TextBox ID="tbblcttlval" runat="server" CssClass="textbox" 
                                                Enabled="False" Width="70px"></asp:TextBox>
                                        </td>
                                        <td style="border: 1px solid #C4C4C4; text-align: left; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333;" 
                                            class="label">
                                            <asp:TextBox ID="tbblcttlvalprcnt" runat="server" CssClass="textbox" 
                                                Enabled="False" Width="60px"></asp:TextBox>
                                            (%)</td>
                                    </tr>
                                    <tr>
                                        <td class="label" 
                                            
                                            style="border: 1px solid #C4C4C4; text-align: right; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; font-weight: 700;">
                                            Total Inhand Value &amp; Percentage of Master LC</td>
                                        <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                            <asp:TextBox ID="tbblcinhand" runat="server" CssClass="textbox" 
                                                Enabled="False" Width="70px"></asp:TextBox>
                                        </td>
                                        <td style="border: 1px solid #C4C4C4; text-align: left; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333;" 
                                            class="label">
                                            <asp:TextBox ID="tbblcinhandprcnt" runat="server" CssClass="textbox" 
                                                Enabled="False" Width="60px"></asp:TextBox>
                                            (%)</td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                  </td>
                <td>
                    <table style="width:100%;">
                        <tr>
                            <td class="label" 
                                
                                style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: right; font-weight: 700;">
                                Unit Price Per Dz</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="tUpriceperdz" runat="server" CssClass="textbox" 
                                    Enabled="False" Width="80px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="label" 
                                
                                style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: right; font-weight: 700;">
                                <strong>Cost</strong> Per Dz</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="tcostperdz" runat="server" CssClass="textbox" 
                                    Enabled="False" Width="80px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style5" 
                                
                                style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: right; font-weight: 700;">
                                CM Per Dz</td>
                            <td class="style6" 
                                style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="tcmperdz" runat="server" CssClass="textbox" 
                                    Enabled="False" Width="80px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="label" 
                                
                                style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: right; font-weight: 700;">
                                CM Per Set/Pcs in USD</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="tcmperset" runat="server" CssClass="textbox" 
                                    Enabled="False" Width="80px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="label" 
                                
                                style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: right; font-weight: 700;">
                                CM Per Set/Pcs in Tk</td>
                            <td style="border: 1px solid #C4C4C4; font-family: Arial, Helvetica, sans-serif; font-size: 9px; color: #333333; text-align: left;">
                                <asp:TextBox ID="ttk" runat="server" onkeyup="tk();" CssClass="textbox" 
                                    Width="20px" MaxLength="5"></asp:TextBox>
                                <asp:FilteredTextBoxExtender ID="ttk_FilteredTextBoxExtender" runat="server" 
                                    Enabled="True" TargetControlID="ttk" ValidChars=".0123456789">
                                </asp:FilteredTextBoxExtender>
                                <asp:TextBox ID="ttkttl" runat="server" CssClass="textbox" 
                                    Enabled="False" Width="50px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <hr class="hr" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="height:180px; vertical-align:top;">
                                <asp:Image ID="imgStyle" runat="server" Width="150px" />
                              </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <hr class="hr" />
                             </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="text-align:center;">
                                <a href="#" onclick="Mcs_addimg();">Add Sketch</a>
                                <asp:TextBox ID="txtimgslno" style="display:none"  runat="server" Width="60px"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    
    </div>
    <div>
        <hr class="hr" />
    </div>
    <div>
    <table style="width:100%">
    <tr>
    <td style="vertical-align:top;">
    <div style="border:1px solid silver;">
      <table style="width: 100%;">
                                    <tr>
                                        <td style="font-family: Arial, Helvetica, sans-serif; text-align: center; font-size: 10px; background-color: #CCCCCC;" 
                                            colspan="7">
                                            BTB Status</td>
                                    </tr>
                                    <tr>
                                        <td style="font-family: Arial, Helvetica, sans-serif; text-align: center; font-size: 10px">
                                            Item<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                                ControlToValidate="drpStyle" ErrorMessage="Select Style" ForeColor="Red" 
                                                ValidationGroup="b">*</asp:RequiredFieldValidator>
                                            <asp:ValidatorCalloutExtender ID="RequiredFieldValidator7_ValidatorCalloutExtender" 
                                                runat="server" Enabled="True" TargetControlID="RequiredFieldValidator7">
                                            </asp:ValidatorCalloutExtender>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                                                ControlToValidate="titmfab" ErrorMessage="Enter Item Name" ForeColor="Red" 
                                                ValidationGroup="b">*</asp:RequiredFieldValidator>
                                            <asp:ValidatorCalloutExtender ID="RequiredFieldValidator8_ValidatorCalloutExtender" 
                                                runat="server" Enabled="True" TargetControlID="RequiredFieldValidator8">
                                            </asp:ValidatorCalloutExtender>
                                        </td>
                                        <td style="font-family: Arial, Helvetica, sans-serif; text-align: center; font-size: 10px">
                                            Budget Cost<asp:RequiredFieldValidator ID="RequiredFieldValidator9" 
                                                runat="server" ControlToValidate="titmfabtcost" 
                                                ErrorMessage="Enter Budget Cost" ForeColor="Red" ValidationGroup="b">*</asp:RequiredFieldValidator>
                                            <asp:ValidatorCalloutExtender ID="RequiredFieldValidator9_ValidatorCalloutExtender" 
                                                runat="server" Enabled="True" TargetControlID="RequiredFieldValidator9">
                                            </asp:ValidatorCalloutExtender>
                                        </td>
                                        <td style="font-family: Arial, Helvetica, sans-serif; text-align: center; font-size: 10px">
                                            Actual Cost<asp:RequiredFieldValidator ID="RequiredFieldValidator10" 
                                                runat="server" ControlToValidate="titemfabactcst" 
                                                ErrorMessage="Enter Actual Cost" ForeColor="Red" ValidationGroup="b">*</asp:RequiredFieldValidator>
                                            <asp:ValidatorCalloutExtender ID="RequiredFieldValidator10_ValidatorCalloutExtender" 
                                                runat="server" Enabled="True" TargetControlID="RequiredFieldValidator10">
                                            </asp:ValidatorCalloutExtender>
                                        </td>
                                        <td style="font-family: Arial, Helvetica, sans-serif; text-align: center; font-size: 10px">
                                            Favourable<asp:RequiredFieldValidator ID="RequiredFieldValidator11" 
                                                runat="server" ControlToValidate="titemfabfab" ErrorMessage="Enter Cost" 
                                                ForeColor="Red" ValidationGroup="b">*</asp:RequiredFieldValidator>
                                            <asp:ValidatorCalloutExtender ID="RequiredFieldValidator11_ValidatorCalloutExtender" 
                                                runat="server" Enabled="True" TargetControlID="RequiredFieldValidator11">
                                            </asp:ValidatorCalloutExtender>
                                        </td>
                                        <td style="font-family: Arial, Helvetica, sans-serif; text-align: center; font-size: 10px">
                                            Unfavourable<asp:RequiredFieldValidator ID="RequiredFieldValidator12" 
                                                runat="server" ControlToValidate="titmfabunfab" ErrorMessage="Enter Cost" 
                                                ForeColor="Red" ValidationGroup="b">*</asp:RequiredFieldValidator>
                                            <asp:ValidatorCalloutExtender ID="RequiredFieldValidator12_ValidatorCalloutExtender" 
                                                runat="server" Enabled="True" TargetControlID="RequiredFieldValidator12">
                                            </asp:ValidatorCalloutExtender>
                                        </td>
                                        <td style="font-family: Arial, Helvetica, sans-serif; text-align: center; font-size: 10px">
                                            Remarks</td>
                                        <td style="font-family: Arial, Helvetica, sans-serif; text-align: center; font-size: 10px">
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center">
                                            <asp:TextBox ID="titmfab" runat="server" CssClass="textbox" 
                                                MaxLength="100" Width="200px"></asp:TextBox>
                                        </td>
                                        <td style="text-align: center">
                                            <asp:TextBox ID="titmfabtcost" runat="server" CssClass="textbox" 
                                                MaxLength="6" Width="80px"></asp:TextBox>
                                            <asp:FilteredTextBoxExtender ID="titmfabtcost_FilteredTextBoxExtender" 
                                                runat="server" Enabled="True" TargetControlID="titmfabtcost" 
                                                ValidChars=".0123456789">
                                            </asp:FilteredTextBoxExtender>
                                        </td>
                                        <td style="text-align: center">
                                            <asp:TextBox ID="titemfabactcst" runat="server" CssClass="textbox" 
                                                MaxLength="6" Width="80px"></asp:TextBox>
                                            <asp:FilteredTextBoxExtender ID="titemfabactcst_FilteredTextBoxExtender" 
                                                runat="server" Enabled="True" TargetControlID="titemfabactcst" 
                                                ValidChars=".0123456789">
                                            </asp:FilteredTextBoxExtender>
                                        </td>
                                        <td style="text-align: center">
                                            <asp:TextBox ID="titemfabfab" runat="server" CssClass="textbox" 
                                                MaxLength="6" Width="80px"></asp:TextBox>
                                            <asp:FilteredTextBoxExtender ID="titemfabfab_FilteredTextBoxExtender" 
                                                runat="server" Enabled="True" TargetControlID="titemfabfab" 
                                                ValidChars=".0123456789">
                                            </asp:FilteredTextBoxExtender>
                                        </td>
                                        <td style="text-align: center">
                                            <asp:TextBox ID="titmfabunfab" runat="server" CssClass="textbox" 
                                                MaxLength="6" Width="80px"></asp:TextBox>
                                            <asp:FilteredTextBoxExtender ID="titmfabunfab_FilteredTextBoxExtender" 
                                                runat="server" Enabled="True" TargetControlID="titmfabunfab" 
                                                ValidChars=".0123456789">
                                            </asp:FilteredTextBoxExtender>
                                        </td>
                                        <td style="text-align: center">
                                            <asp:TextBox ID="txtRemarks" runat="server" CssClass="textbox" MaxLength="50" 
                                                Width="130px"></asp:TextBox>
                                        </td>
                                        <td style="text-align: center">
                                            <asp:Button ID="btnAddbtbstatus" runat="server" Font-Size="10px" 
                                                onclick="btnAddbtbstatus_Click" Text="Add" ValidationGroup="b" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="7" style="vertical-align: bottom">
                                            <hr class="hr" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="7">
                                            <asp:GridView ID="grdBtbstatus" AutoGenerateColumns="false" runat="server" CssClass="mGrid">
                                                <AlternatingRowStyle CssClass="gridrowAlternaterow" />
                                            <Columns>
                                            <asp:TemplateField HeaderText="Item Description">
                                            <ItemTemplate>
                                                <asp:Label ID="lblItm" runat="server" Text='<%# Eval("Itemd") %>'></asp:Label>
                                            </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Tagret Cost">
                                            <ItemTemplate>
                                                <asp:Label ID="lbltcst" runat="server" Text='<%# Eval("Tcst") %>'></asp:Label>
                                            </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Actual Cost">
                                            <ItemTemplate>
                                                <asp:Label ID="lblactcst" runat="server" Text='<%# Eval("Actcst") %>'></asp:Label>
                                            </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Fabourable">
                                            <ItemTemplate>
                                                <asp:Label ID="lblfab" runat="server" Text='<%# Eval("Fabcst") %>'></asp:Label>
                                            </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Unfabourable">
                                            <ItemTemplate>
                                                <asp:Label ID="lblunfab" runat="server" Text='<%# Eval("unfabcst") %>'></asp:Label>
                                            </ItemTemplate>
                                            </asp:TemplateField>

                                              <asp:TemplateField HeaderText="Remarks">
                                            <ItemTemplate>
                                                <asp:Label ID="lbremark" runat="server" Text='<%# Eval("rmrk") %>'></asp:Label>
                                            </ItemTemplate>
                                            </asp:TemplateField>
                                            

                                             <asp:TemplateField HeaderText="">
                                            <ItemTemplate>
                                                <asp:ImageButton ID="btndltbtn" runat="server" 
                                                 ImageUrl="~/gridimage/grdRemove.png" Width="13px" onclick="btndltbtn_Click" />
                                            </ItemTemplate>
                                            </asp:TemplateField>
                                            </Columns>
                                                <HeaderStyle CssClass="gridheader" />
                                                <RowStyle CssClass="gridrow" />
                                            </asp:GridView>
                                        </td>
                                    </tr>
                                </table>
                                </div>
    </td>
     <td style="vertical-align:top; width:200px">
         <table style="width:100%;">
             <tr>
                 <td>
                     &nbsp;</td>
             </tr>
             <tr>
                 <td>
                     <asp:Button ID="btnSave" runat="server" onclick="btnSave_Click" Text="Save" 
                         Width="100px" />
                     <asp:ConfirmButtonExtender ID="btnSave_ConfirmButtonExtender" runat="server" 
                         ConfirmText="Are you want to save?" Enabled="True" TargetControlID="btnSave">
                     </asp:ConfirmButtonExtender>
                 </td>
             </tr>
             <tr>
                 <td>
                     <asp:Button ID="btnClear" runat="server" onclick="btnClear_Click" Text="Clear" 
                         Width="100px" />
                 </td>
             </tr>
             <tr>
                 <td>
                     <input id="Button1" onclick="nzrptcst();" style="width:100px" type="button" value="Report" />
                 </td>
             </tr>
         </table>
        </td>
    
    </tr>
    </table>
  
    </div>
    
    <div style="height:30px;">
        
    </div>
    </div>

      <asp:Button ID="btnppgntpo" style="display:none" runat="server" Text="Button" />                                     
          <asp:ModalPopupExtender ID="Button2_ModalPopupExtender" runat="server" 
           DynamicServicePath="" BackgroundCssClass="ModalPopupBG" BehaviorID="ppadditm" CancelControlID="cnclitmpdt" 
           OkControlID="cnclitmpdt" Enabled="True" PopupControlID="ppgenpo" 
           TargetControlID="btnppgntpo">
                             </asp:ModalPopupExtender>

    </ContentTemplate>
    </asp:UpdatePanel>

     <div id="ppgenpo" style="height:530px; width:910px; display:none; border:5px solid #64AFEA;background-color:#e9f0fb;-webkit-border-radius: 5px; -moz-border-radius: 5px;border-radius: 5px;">
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
    <iframe id="ifupldfile" onload="hideLoading()" src="" style="border:none" width="900px" height="500px"></iframe>
    </div>
    </div>
    
    <script src="jquery/nznewcost.js" type="text/javascript"></script>
    <script type="text/javascript">
        function nzrptcst() {
            var stl = $("[id*='drpStyle'] :selected").val();
            if (stl.length > 0) {
                window.open('Report_Merchandising/NZCSTRPT.aspx?x=' + stl + '', 'popup', 'location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600')
            }
            else {
                alert("Select Style first");
            }
        }
        function podtltgl() {
            var gt = document.getElementById('<%= grdcolqty.ClientID %>');         
            for (i = 1; i < gt.rows.length; i++) {
                var l00pcell = gt.rows[i].cells;
                var loopcellvalue = l00pcell[2].getElementsByTagName("input")[0];
                if (loopcellvalue.type == 'checkbox' && loopcellvalue.checked) {
                    loopcellvalue.checked = false;
                }
            }
            $("#podtl").toggle();
        }
        function chkgrd() {
            $("[id$='txtGmtQty']").val('');
            var gt = document.getElementById('<%= grdcolqty.ClientID %>');
            var ttl = "0";
            for (i = 1; i < gt.rows.length; i++) {
                var l00pcell = gt.rows[i].cells;
                var loopcellvalue = l00pcell[2].getElementsByTagName("input")[0];
                if (loopcellvalue.type == 'checkbox' && loopcellvalue.checked) {
                    var val = l00pcell[1].getElementsByTagName("span")[0].innerHTML;
                    if (val.length>0) {
                        ttl = parseFloat(ttl)+parseFloat(val);
                    }                    
                }
            }
            //alert(ttl);
            if (parseFloat(ttl) > 0) {
                $("[id$='txtGmtQty']").val(ttl);
                Calculateamount();             
            }
            //$("#txtGmtQty").val(ttl);
        }
        function gmtqty() {
            //alert("alsjd");
            var ordqty = $("[id$='txtOrdqty']").val();         
            if (ordqty.length > 0) {
                $("[id$='txtGmtQty']").val(ordqty);
                Calculateamount();
              }
        }
        function cpyitm() {
            onunload();
            var styleid = $("[id*='drpStyle'] :selected").val();
            if (styleid.length > 0) {
                document.getElementById("txtchkjv").value = "1";
                $("#hdrtxt").html("Copy Costing");
                $("#ifupldfile").attr("src", "Master_Setup/copycosting.aspx?x=" + styleid + "");
                var bid = $find('ppadditm');
                bid.show();
            }
            else {
                alert("Select Style First");
            }
        }
    </script>
 <%--     <script type="text/javascript">
          var pageUrl = '<%=ResolveUrl("~/Default4.aspx")%>'
          function PopulateContinents() {
              $("[id$='txtunitparam']").val('');
              $("[id$='txtAmount']").val('');
              if ($('#<%=drpConsunit.ClientID%>').val() == "0") {
              }
              else {

                  $.ajax({
                      type: "POST",
                      url: pageUrl + '/PopulateCountries',
                      data: '{continentId: ' + $('#<%=drpConsunit.ClientID%>').val() + '}',
                      contentType: "application/json; charset=utf-8",
                      dataType: "json",
                      //success: OnCountriesPopulated,
                      success: function (data) {
                          var unittst = $("[id*='drpConsunit'] :selected").text();
                          if (unittst != '-') {
                              $("[id$='txtunitparam']").val(data.d);
                              var cons = $("[id$='txtConsumption']").val();
                              var uprce = $("[id$='txtuprice']").val();
                              var prm = $("[id$='txtunitparam']").val();
                              if ((cons.length) > 0 & (uprce.length) > 0) {
                                  $("[id$='txtAmount']").val(parseFloat(cons) * parseFloat(uprce) * parseFloat(prm));
                                  var ttl = parseFloat(cons) * parseFloat(uprce) * parseFloat(prm);
                                  var ordqty = $("[id$='txtordqty']").val();
                                  var ttcost = (parseFloat(ordqty) / 12) * parseFloat(ttl) * 1.05;
                                  $("[id$='txtTotalcost']").val(ttcost.toFixed(2));
                              }
                          }
                          //                    else { 
                          //                    
                          //                    }

                          //  alert(data.d)
                      },
                      failure: function (response) {
                          alert(response.d);
                      }
                  });
              }
          }
       
   </script>--%>
</asp:Content>

