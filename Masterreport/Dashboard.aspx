<%@ Page Title="" Language="C#" MasterPageFile="~/Masterreport/MasterPage.master" AutoEventWireup="true" CodeFile="Dashboard.aspx.cs" Inherits="Masterreport_Dashboard" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
    <div></div>
    <div>
        <hr class="hr" />
        </div>
        <div>
            <table style="width:100%;">
                <tr>
                    <td style="text-align: right; font-family: Arial; font-size: 10px; ">
                        X-Factory Date From </td>
                    <td style="text-align: left; font-family: Arial; font-size: 10px;">
                        <asp:TextBox ID="txtFormdate" runat="server" CssClass="textbox" Enabled="False" 
                            Width="80px"></asp:TextBox>
                        <asp:CalendarExtender ID="txtFormdate_CalendarExtender" runat="server" 
                            Enabled="True" Format="dd-MMM-yyyy" PopupButtonID="cal" 
                            TargetControlID="txtFormdate">
                        </asp:CalendarExtender>
                        <asp:ImageButton ID="cal" runat="server" Height="12px" 
                            ImageUrl="~/images/calendar.gif" />
                        <asp:RequiredFieldValidator ID="rqFormdt" runat="server" 
                            ControlToValidate="txtFormdate" Display="None" ErrorMessage="Enter From Date" 
                            ValidationGroup="a">*</asp:RequiredFieldValidator>
                        <asp:ValidatorCalloutExtender ID="RequiredFieldValidator1_ValidatorCalloutExtender" 
                            runat="server" Enabled="True" TargetControlID="rqFormdt">
                        </asp:ValidatorCalloutExtender>
                        &nbsp;To&nbsp;
                        <asp:TextBox ID="txtTodate" runat="server" CssClass="textbox" Enabled="False" 
                            Width="80px"></asp:TextBox>
                        <asp:CalendarExtender ID="txtTodate_CalendarExtender" runat="server" 
                            Enabled="True" Format="dd-MMM-yyyy" PopupButtonID="cal2" 
                            TargetControlID="txtTodate">
                        </asp:CalendarExtender>
                        <asp:ImageButton ID="cal2" runat="server" Height="12px" 
                            ImageUrl="~/images/calendar.gif" />
                        <asp:RequiredFieldValidator ID="rqTodate" runat="server" 
                            ControlToValidate="txtTodate" Display="None" ErrorMessage="Enter To Date" 
                            ValidationGroup="a">*</asp:RequiredFieldValidator>
                        <asp:ValidatorCalloutExtender ID="RequiredFieldValidator2_ValidatorCalloutExtender" 
                            runat="server" Enabled="True" TargetControlID="rqTodate">
                        </asp:ValidatorCalloutExtender>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        Buyer 
                        <asp:DropDownList ID="drpBuyer" CssClass="textbox" Width="200px" runat="server">
                        </asp:DropDownList>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnSearch" runat="server" Font-Size="10px" 
                            onclick="btnSearch_Click" Text="Search" Width="100px" />
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                
            </table>
        </div>
        <div>
                    <hr class="hr" />
                </div>
                <div style="text-align:center">
                <div style="max-height:450px; text-align:center; overflow:auto;">
                    <asp:GridView ID="GridView1" AutoGenerateColumns="False" 
                        runat="server" onrowdatabound="GridView1_RowDataBound" 
                        onprerender="GridView1_PreRender" CssClass="mGrid"                        
                     >
                        <AlternatingRowStyle Wrap="False" BackColor="#ECF5FF" Font-Size="9px" />
                    <Columns>
                     <asp:TemplateField Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="lblstyle" runat="server" Text='<%# Eval("nStyleID") %>'></asp:Label>
                    </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="cBuyer_Name" HeaderText="BUYER NAME" HeaderStyle-Font-Names="Tahoma" HeaderStyle-Font-Size="9px" HeaderStyle-ForeColor="#63676F" />
                    <asp:BoundField DataField="cStyleNo" HeaderText="STYLE NO" HeaderStyle-Font-Names="Tahoma" HeaderStyle-Font-Size="9px" HeaderStyle-ForeColor="#63676F" />
                    <asp:BoundField DataField="cPoNum" HeaderText="PO NO" HeaderStyle-Font-Names="Tahoma" HeaderStyle-Font-Size="9px" HeaderStyle-ForeColor="#63676F" />
                    <asp:BoundField DataField="nOrdQty" HeaderText="ORD. QTY" HeaderStyle-Font-Names="Tahoma" HeaderStyle-Font-Size="9px" HeaderStyle-ForeColor="#63676F" >
                      
                        </asp:BoundField>
                    <asp:BoundField DataField="ShipDt" HeaderStyle-Font-Names="Tahoma" HeaderStyle-Font-Size="9px" HeaderStyle-ForeColor="#63676F" DataFormatString="{0:dd-MMM-yyyy}" 
                            HeaderText="X-FTY" >
                      
                        </asp:BoundField>
                    <asp:BoundField DataField="cGmetDis" HeaderText="GMT TYPE" HeaderStyle-Font-Names="Tahoma" HeaderStyle-Font-Size="9px" HeaderStyle-ForeColor="#63676F" />
                    <asp:BoundField DataField="cStyleType" HeaderText="STYLE TYPE" HeaderStyle-Font-Names="Tahoma" HeaderStyle-Font-Size="9px" HeaderStyle-ForeColor="#63676F" />    
                    <asp:BoundField DataField="nfob" HeaderText="FOB" HeaderStyle-Font-Names="Tahoma" HeaderStyle-Font-Size="9px" HeaderStyle-ForeColor="#63676F">
                    
                    </asp:BoundField>
                                    
                    <asp:BoundField DataField="nCm" HeaderText="CM" HeaderStyle-Font-Names="Tahoma" HeaderStyle-Font-Size="9px" HeaderStyle-ForeColor="#63676F" />
                    <asp:BoundField DataField="NSMV" HeaderStyle-Font-Names="Tahoma" HeaderStyle-Font-Size="9px" HeaderStyle-ForeColor="#63676F"                      
                           HeaderText="SMV">
                     
                        <ItemStyle BackColor="#FFF0E1" />
                           </asp:BoundField>
                    <asp:BoundField DataField="" HeaderText="FAB REQ." HeaderStyle-Font-Names="Tahoma" HeaderStyle-Font-Size="9px" HeaderStyle-ForeColor="#63676F" >                  
                        </asp:BoundField>
                    <asp:BoundField DataField="yrnrcv" HeaderStyle-Font-Names="Tahoma" HeaderStyle-Font-Size="9px" HeaderStyle-ForeColor="#63676F" HeaderText="YARN RECEIVED" >                     
                        </asp:BoundField>
                    <asp:BoundField DataField="kp_quantity" HeaderStyle-Font-Names="Tahoma" HeaderStyle-Font-Size="9px" HeaderStyle-ForeColor="#63676F" HeaderText="KNITTING" ></asp:BoundField>
                    <asp:BoundField DataField=""  HeaderText="DYEING" HeaderStyle-Font-Names="Tahoma" HeaderStyle-Font-Size="9px" HeaderStyle-ForeColor="#63676F" ></asp:BoundField>                     
                    <asp:TemplateField HeaderText="Fabric Received" ItemStyle-HorizontalAlign="Center"  ItemStyle-VerticalAlign="Middle" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Font-Names="Tahoma" HeaderStyle-Font-Size="9px" HeaderStyle-ForeColor="#63676F">
                    <ItemTemplate>
                    <a onclick="fabrpt('<%# Eval("nStyleID") %>');" style="text-decoration:none" href="#"><%# Eval("Rcvqty") %></a>
                    </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:TemplateField>


                    
                    <asp:TemplateField HeaderText="REPORTS" ItemStyle-HorizontalAlign="Center"  ItemStyle-VerticalAlign="Middle" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Font-Names="Tahoma" HeaderStyle-Font-Size="9px" HeaderStyle-ForeColor="#63676F">
                    <ItemTemplate>
                    <a onclick="accessories('<%# Eval("nStyleID") %>');" style="text-decoration:none" href="#">REPORT</a>
                    </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="CUT QTY" HeaderStyle-Font-Names="Tahoma" HeaderStyle-Font-Size="9px" HeaderStyle-ForeColor="#63676F">
                    <ItemTemplate>
                    <a onclick="proddtl('<%# Eval("nStyleID") %>');" href="#"><%# Eval("CutQty")%></a>
                    </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="CUT BALANCE" HeaderStyle-Font-Names="Tahoma" HeaderStyle-Font-Size="9px" HeaderStyle-ForeColor="#63676F">
                    <ItemTemplate>
                        <asp:Label ID="LBLcUTBLANCE" runat="server" Text=""></asp:Label>
                    </ItemTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField HeaderText="PRINT QTY" HeaderStyle-Font-Names="Tahoma" HeaderStyle-Font-Size="9px" HeaderStyle-ForeColor="#63676F">
                    <ItemTemplate>
                    <a onclick="proddtl('<%# Eval("nStyleID") %>');" href="#"><%# Eval("printqty")%></a>
                    </ItemTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField HeaderText="EMB QTY" HeaderStyle-Font-Names="Tahoma" HeaderStyle-Font-Size="9px" HeaderStyle-ForeColor="#63676F">
                    <ItemTemplate>
                    <a onclick="proddtl('<%# Eval("nStyleID") %>');" href="#"><%# Eval("embqty")%></a>
                    </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="TTL INPUT" HeaderStyle-Font-Names="Tahoma" HeaderStyle-Font-Size="9px" HeaderStyle-ForeColor="#63676F">
                    <ItemTemplate>
                    <a onclick="proddtl('<%# Eval("nStyleID") %>');" href="#"><%# Eval("INPUTQTY")%></a>
                    </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="INPUT BALANCE" HeaderStyle-Font-Names="Tahoma" HeaderStyle-Font-Size="9px" HeaderStyle-ForeColor="#63676F">
                    <ItemTemplate>                   
                    <asp:Label ID="LBLINPUTBLNCE" runat="server" Text=""></asp:Label>
                    </ItemTemplate>
                    </asp:TemplateField>                    

                     <asp:TemplateField HeaderText="QC Out" HeaderStyle-Font-Names="Tahoma" HeaderStyle-Font-Size="9px" HeaderStyle-ForeColor="#63676F">
                    <ItemTemplate>
                    <a onclick="proddtl('<%# Eval("nStyleID") %>');" href="#"><%# Eval("sewqty")%></a>
                    </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Finish Goods" HeaderStyle-Font-Names="Tahoma" HeaderStyle-Font-Size="9px" HeaderStyle-ForeColor="#63676F">
                    <ItemTemplate>
                    <a onclick="proddtl('<%# Eval("nStyleID") %>');" href="#"><%# Eval("shpqty")%></a>
                    </ItemTemplate>
                    </asp:TemplateField>                  
                           
                   </Columns>
                        <HeaderStyle Wrap="False" BackColor="#D5E9FF" Font-Size="10px" 
                            ForeColor="Black" Height="22px" Font-Names="Tahoma" />
                        <RowStyle Wrap="False" Font-Size="9px" />
                    </asp:GridView>
                    </div>
                </div>
      
        <div style="height:20px;"></div>
    </ContentTemplate>
    </asp:UpdatePanel>

     <script type="text/javascript">
         function accessories(styleid) {
             window.open('fabdtlrpt.aspx?x=' + styleid + '', 'popup', 'location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600');
             //alert("asdlkfj");
         }
         function proddtl(styleid) {
             window.open('Proddtlrpt.aspx?x=' +styleid +'', 'popup', 'location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600');
         }
         function tna(tnaname, style) {
             window.open('tna.aspx?x=' + tnaname + '&x1=' + style + '', 'popup', 'location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600');
         }
         function fabrpt(styleid) {
             window.open('fabrciv.aspx?x=' + styleid + '', 'popup', 'location=1,status=1,left=0,top=0,scrollbars=1,width=970,height=600');
             //alert("asdlkfj");
         }

         
        
    </script>
</asp:Content>

