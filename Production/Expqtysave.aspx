<%@ Page Title="" Language="C#" MasterPageFile="~/Production/MasterPage.master" AutoEventWireup="true" CodeFile="Expqtysave.aspx.cs" Inherits="Production_Expqtysave" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/total.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
    <div>
    <div>
    <table>
    <tr>
    <td class="label">
    Style No
        <asp:Label ID="lblStyleID" Visible="false" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblPO" runat="server" Visible="false" Text=""></asp:Label></td>
    <td>
        <asp:TextBox ID="txtStyle" Enabled="false" Width="250px" runat="server" 
            CssClass="textbox"></asp:TextBox></td>
     <td class="label">PO NO</td>
      <td><asp:TextBox ID="txtPO" Width="200px" Enabled="false" runat="server" 
              CssClass="textbox"></asp:TextBox></td>
       <td class="label">PO Qty</td>
        <td><asp:TextBox ID="txtPOQty" Enabled="false" Width="100px" runat="server" 
                CssClass="textbox"></asp:TextBox></td>
    </tr>
    </table>
    </div>
    <div class="label">Color&nbsp;&nbsp;&nbsp;&nbsp; :
        <asp:DropDownList ID="drpColor" runat="server" AutoPostBack="True" 
            onselectedindexchanged="drpColor_SelectedIndexChanged" Width="200px" 
            CssClass="textbox">
        </asp:DropDownList>
        <asp:Label ID="lblerrmsg" runat="server" Font-Bold="True" Font-Names="Tahoma" 
            Font-Size="14px" ForeColor="Red"></asp:Label>
        </div>
    <div style="height:380px; margin-top:5px; width:400px; overflow:auto; border:1px solid silver">
    
        <asp:GridView ID="GridView1" CssClass="mGrid" AutoGenerateColumns="false" 
            runat="server" onrowdatabound="GridView1_RowDataBound">
        <Columns>
        <asp:BoundField DataField="OrgSize" HeaderText="Order Size" />
        <asp:TemplateField HeaderText="QC Out Qty">
        <ItemTemplate>
            <asp:Label ID="lblSizeid" runat="server" Visible="false" Text='<%# Eval("nCode") %>'></asp:Label>
            <asp:Label ID="lblsize" runat="server" Visible="false" Text='<%# Eval("OrgSize") %>'></asp:Label>
             <asp:TextBox ID="txtQCqty" Enabled="false" CssClass="textbox" Width="80px" runat="server"></asp:TextBox>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Cumullative Qty">
        <ItemTemplate>
            <asp:TextBox ID="txtQqty" Enabled="false" CssClass="textbox" Width="100px" runat="server"></asp:TextBox>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Export Qty">
        <ItemTemplate>
            <asp:TextBox ID="txtInputqty" CssClass="textbox" Width="100px" runat="server"></asp:TextBox>
        </ItemTemplate>
        </asp:TemplateField>
        </Columns>
            <HeaderStyle CssClass="gridheader" />
        </asp:GridView>
    
    </div>
    <div>
        <asp:Button ID="btnSave" Visible="false" Width="100px" runat="server" 
            Text="Save" onclick="btnSave_Click" />
    </div>
    </div>
    </ContentTemplate>
    </asp:UpdatePanel>
    </form>
</body>
</html>

