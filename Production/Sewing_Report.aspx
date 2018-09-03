<%@ Page Title="" Language="C#" MasterPageFile="~/Production/MasterPage.master" AutoEventWireup="true" CodeFile="Sewing_Report.aspx.cs" Inherits="Production_Sewing_Report" %>

<%@ Register assembly="C1.Web.UI.Controls.4" namespace="C1.Web.UI.Controls.C1TabControl" tagprefix="cc2" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 
        
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="margin-bottom:50px">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>

    <cc2:C1TabControl ID="C1TabControl1" runat="server" width="100%"                    
                TextImageRelation="ImageBeforeText">
               <TabPages>
                <cc2:C1TabPage ID="C1TabPage1" TabIndex="0" Text="Hourly Production Report" CssClass="tab">
                   <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                       <ContentTemplate>
                       <div style="min-height:500px">
                      <div style="padding-top:6px">Hourly Production Report</div>
    <div><hr class="hr" /></div>
    <div class="label" style="margin-top:10px">Company Name
        <asp:DropDownList ID="drpcompany" runat="server" 
            CssClass="textboxforgridview" Width="250px">
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="drpcompany" Display="None" ErrorMessage="Select Company" 
            ValidationGroup="v">*</asp:RequiredFieldValidator>
             <asp:ValidatorCalloutExtender ID="RequiredFieldValidator1_ValidatorCalloutExtender" 
                                    runat="server" Enabled="True" TargetControlID="RequiredFieldValidator1">
                                </asp:ValidatorCalloutExtender>
        &nbsp;&nbsp;&nbsp;&nbsp; Date
        <asp:TextBox ID="txtDate" runat="server" CssClass="textboxforgridview" 
            Width="100px" Enabled="False"></asp:TextBox>
            <asp:CalendarExtender ID="txtDate_CalendarExtender" runat="server" 
                                                                      Enabled="True" Format="dd-MMM-yyyy" PopupButtonID="cal1" 
                                                                      TargetControlID="txtDate" PopupPosition="TopLeft">
                                                                  </asp:CalendarExtender>
        <asp:ImageButton ID="cal1" runat="server" Height="13px" 
            ImageUrl="~/images/calendar.gif" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnsrc" runat="server" Font-Size="11px" onclick="btnsrc_Click" 
            Text="Search" Width="100px" ValidationGroup="v" />
        <input id="Button1" type="button" style="font-size:11px; width:70px" class="print" rel="pntdv" value="Print" />
      

       
        </div>
    <div>
        <hr class="hr" />
        </div>
    <div id="pntdv">
  
  
        <asp:GridView ID="GridView1" AutoGenerateColumns="false" runat="server" 
            CssClass="mGrid" onprerender="GridView1_PreRender" 
            onrowdatabound="GridView1_RowDataBound" ShowFooter="True">
            
        <Columns>
        <asp:BoundField DataField="aLine" HeaderText="Line" />
        <asp:BoundField DataField="LMo" HeaderText="MO" />
        <asp:BoundField DataField="LHlp" HeaderText="Helper" />
        <asp:BoundField DataField="cBuyer_Name" HeaderText="Buyer" />
        <asp:BoundField DataField="cStyleNo" HeaderText="Style" />
        <asp:BoundField DataField="cGmetDis" HeaderText="Item" />
        <asp:BoundField DataField="LDayTgt" HeaderText="Target" />
        <asp:BoundField DataField="aHr1" HeaderText="1" />
        <asp:BoundField DataField="aHr2" HeaderText="2" />
        <asp:BoundField DataField="aHr3" HeaderText="3" />
        <asp:BoundField DataField="aHr4" HeaderText="4" />
        <asp:BoundField DataField="aHr5" HeaderText="5" />
        <asp:BoundField DataField="aHr6" HeaderText="6" />
        <asp:BoundField DataField="aHr7" HeaderText="7" />
        <asp:BoundField DataField="aHr8" HeaderText="8" />
        <asp:BoundField DataField="aHr9" HeaderText="9" />
        <asp:BoundField DataField="aHr10" HeaderText="10" />
        <asp:BoundField DataField="aHr11" HeaderText="11" />
        <asp:BoundField DataField="aHr12" HeaderText="12" />
        <asp:BoundField DataField="totqty" HeaderText="Total Qty" />
        <asp:BoundField DataField="shortqty" HeaderText="S/E" />
        <asp:BoundField DataField="FobVal" HeaderText="Fob" />
        <asp:BoundField DataField="Rundays" HeaderText="Run Days" />
        <asp:BoundField DataField="Remarks" HeaderText="Remarks" />
        <asp:TemplateField Visible="false">
        <ItemTemplate>
            <asp:Label ID="lbllineid" runat="server" Text='<%# Eval("aLineID") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>     
        
        
       
        </Columns>
            <AlternatingRowStyle BackColor="#DDF7FF" Font-Size="11px" ForeColor="#333333" />
            <FooterStyle BackColor="#009BE6" Font-Size="11px" ForeColor="White" />
            <HeaderStyle BackColor="#0083C1" Font-Size="13px" ForeColor="White" />
            <RowStyle BackColor="#F7F7F7" Font-Size="11px" />
        </asp:GridView>
       
        </div>
        </div>
                       </ContentTemplate>
                   </asp:UpdatePanel>                  
                </cc2:C1TabPage>

                 <cc2:C1TabPage ID="C1TabPage2" TabIndex="0" Text="RMG Group Summery" CssClass="tab">
                   <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                       <ContentTemplate>
                        <asp:Timer ID="Timer1" runat="server" Interval="200000" ontick="Timer1_Tick">
            </asp:Timer>
                       <div >
                      <div style="min-height:500px">
                      <div style="padding:6px; border-bottom:1px solid silver;">RMG Group Summery<asp:Label 
                              ID="Label5" runat="server" Text="Label"></asp:Label>
                          </div>
                      <div style="padding:5px; border-bottom:1px solid silver; background-color:#f7f7f7">
                       <asp:TextBox ID="txtDatermg" runat="server" CssClass="textboxforgridview" 
            Width="100px" Enabled="False"></asp:TextBox>
            <asp:CalendarExtender ID="CalendarExtender1" runat="server" 
                                                                      Enabled="True" Format="dd-MMM-yyyy" PopupButtonID="cal2" 
                                                                      TargetControlID="txtDatermg" PopupPosition="TopLeft">
                                                                  </asp:CalendarExtender>
        <asp:ImageButton ID="cal2" runat="server" Height="13px" 
            ImageUrl="~/images/calendar.gif" />
                          &nbsp;&nbsp;&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                              ControlToValidate="txtDatermg" ErrorMessage="Enter Date" ValidationGroup="r">*</asp:RequiredFieldValidator>
                          <asp:ValidatorCalloutExtender ID="RequiredFieldValidator2_ValidatorCalloutExtender" 
                              runat="server" Enabled="True" TargetControlID="RequiredFieldValidator2">
                          </asp:ValidatorCalloutExtender>
                          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnsrcrmg" runat="server" Font-Size="11px"  
            Text="Search" Width="100px" ValidationGroup="r" onclick="btnsrcrmg_Click" />        
                      </div>
                      <div >
                       <asp:GridView ID="GridView2" AutoGenerateColumns="false" runat="server" 
            CssClass="mGrid"  
            ShowFooter="True" onrowdatabound="GridView2_RowDataBound">
            
        <Columns>
       
       <asp:TemplateField>
       <ItemTemplate>
           <asp:Label ID="lblcompname" runat="server" Text=""></asp:Label>
           <asp:Label ID="lblCompid" Visible="false" runat="server" Text='<%# Eval("nCompanyID") %>'></asp:Label>
       </ItemTemplate>
       </asp:TemplateField>
        <asp:BoundField DataField="" HeaderText="Target" />
        <asp:BoundField DataField="CutTtl" HeaderText="Achive" />

        <asp:BoundField DataField="" HeaderText="Target" />
        <asp:BoundField DataField="Input" HeaderText="Achive" />

        <asp:BoundField DataField="SewTgt" HeaderText="Target" />
        <asp:BoundField DataField="QcOut" HeaderText="Achive" />


        <asp:BoundField DataField="" HeaderText="Target" />
        <asp:BoundField DataField="SMV" HeaderText="SMV" />

        <asp:BoundField DataField="" HeaderText="Target" />
        <asp:BoundField DataField="FinAchvQty" HeaderText="Achive" />       
        <asp:BoundField DataField="FOB" HeaderText="FOB" />
        <asp:BoundField DataField="Mo" HeaderText="Mo" />
        <asp:BoundField DataField="Hlp" HeaderText="Helper" />
         <%--<asp:BoundField DataField="QcOut" HeaderText="QcOut" />--%>
        </Columns>
            <AlternatingRowStyle BackColor="#DDF7FF" Font-Size="11px" ForeColor="#333333" />
            <FooterStyle BackColor="#009BE6" Font-Size="11px" ForeColor="White" />
            <HeaderStyle BackColor="#0083C1" Font-Size="14px" ForeColor="White" />
            <RowStyle BackColor="#F7F7F7" Font-Size="13px" />
        </asp:GridView>
                      </div>
                      </div>
                      </div>
                       </ContentTemplate>
                   </asp:UpdatePanel>                  
                </cc2:C1TabPage>
             
              
              
            </TabPages>
                </cc2:C1TabControl>


















    
    </ContentTemplate>

    </asp:UpdatePanel>
    </div>
    <script src="../jquery/Print.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $('.print').live("click", function () {
                var container = $(this).attr('rel');
                $('#' + container).printArea();
                return false;
            });

          

        });
    </script>
</asp:Content>
