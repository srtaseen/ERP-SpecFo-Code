<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory/MasterPage.master" AutoEventWireup="true" CodeFile="GoodsTrnsfr.aspx.cs" Inherits="Inventory_GoodsTrnsfr" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
    
        <table style="width:100%;">
            <tr>
                <td style="width: 205px; vertical-align:top;">
                <div style="border:1px solid #0093d9; border-radius:5px; padding:5px; font-family:Tahoma; font-size:11px;">
                    <table style="width:100%;">
                        <tr><td>Company</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:DropDownList ID="drpComp" runat="server" AutoPostBack="True" 
                                    onselectedindexchanged="drpComp_SelectedIndexChanged" Width="200px">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td> Main Category</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:DropDownList ID="drpMaincat" runat="server" AutoPostBack="True" 
                                    onselectedindexchanged="drpMaincat_SelectedIndexChanged" Width="200px">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>Sub Category</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:DropDownList ID="drpSubCat" runat="server" AutoPostBack="True" 
                                    onselectedindexchanged="drpSubCat_SelectedIndexChanged" Width="200px">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="height: 220px;">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                Transfer To</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:DropDownList ID="drpCompTo" runat="server" Width="200px">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td style="height: 20px;">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="btnSave" runat="server" onclick="btnSave_Click" 
                                    Text="Transfer" />
                            </td>
                        </tr>
                    </table>
                    </div>
                </td>
                <td style="vertical-align:top; text-align:left;">
                <div style="height:520px; overflow:auto;border:1px solid #0093d9; border-radius:5px; padding:5px;">
                    <asp:GridView ID="GridView1" AutoGenerateColumns="false" runat="server" 
                        CssClass="mGrid" onprerender="GridView1_PreRender">
                    <Columns>
                    <asp:BoundField DataField="cMainCategory" HeaderText="Main Category" />
                    <asp:BoundField DataField="cDes" HeaderText="Sub Category" />
                    <asp:BoundField DataField="cArticle" HeaderText="Article" />
                    <asp:BoundField DataField="cDimen" HeaderText="Dimension" />
                    <asp:BoundField DataField="cColour" HeaderText="Color" />
                    <asp:BoundField DataField="cSize1" HeaderText="Size" />
                    <asp:BoundField DataField="nItemBalQty" HeaderText="Qty" />
                    <asp:TemplateField HeaderText="Trns.Qty">
                    <ItemTemplate>
                        <asp:TextBox ID="txtTrnsQty" Width="45px" runat="server"></asp:TextBox>
                        <asp:Label ID="lblItmcode" Visible="false" runat="server" Text='<%# Eval("nItemCode") %>'></asp:Label>
                    </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="cUnitDes" HeaderText="Unit" />
                    <asp:TemplateField>
                    <ItemTemplate>
                        <asp:CheckBox ID="chkItem" runat="server" />
                    </ItemTemplate>
                    </asp:TemplateField>
                    </Columns>
                        <HeaderStyle BackColor="#0097DF" Font-Names="Tahoma" Font-Size="11px" 
                            ForeColor="White" Height="22px" />
                        <RowStyle Font-Names="Tahoma" Font-Size="10px" Height="20px" />
                    </asp:GridView>
                    </div>
                </td>
            </tr>
        </table>
    
    </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>



