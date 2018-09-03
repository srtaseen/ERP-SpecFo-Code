<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UnitGroup.aspx.cs" Inherits="Master_Setup_UnitGroup" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
   <link href="../css/Master_Setup.css" rel="stylesheet" type="text/css" />
    <script src="../jquery/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script src="../jquery/Master_SetupFolder.js" type="text/javascript"></script>
</head>
<body onload="blinkColor()">
    <form id="form1" runat="server">
      <div>    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
            <div style="width:730px">
                <table style="width:100%;">
                    <tr>
                        <td style="width: 300px; vertical-align:top">
                            
                            <table style="width:100%;">
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        <asp:Label ID="lblErrmsg" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                                        Group Name</td>
                                    <td>
                                        <asp:TextBox ID="txtGroup" style="text-transform:uppercase" runat="server" 
                                            MaxLength="20" Width="120px"></asp:TextBox>
                                        <asp:Button ID="btnSave" runat="server" onclick="btnSave_Click" Text="Save" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="vertical-align:top">
                                        Unit List</td>
                                    <td>
                                        <div style="height:450px; overflow:auto">
                                            <asp:GridView ID="grdUnitlist" Width="170px" AutoGenerateColumns="false" runat="server">
                                            <Columns>
                                                <asp:TemplateField>
                                                <ItemTemplate>
                                                    <asp:CheckBox ID="chkselect" runat="server" />
                                                    <asp:Label ID="lblUnitcode" Visible="false" runat="server" Text='<%# Eval("nUnitID") %>'></asp:Label>
                                                </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:BoundField DataField="cUnitDes" HeaderText="Unit" />
                                            </Columns>
                                                <RowStyle Font-Names="Tahoma" Font-Size="11px" Height="22px" />
                                            </asp:GridView>
                                        </div>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                            
                            </td>
                        <td style="vertical-align:top">
                           <div style="margin-top:25px; width:300px; height:440px; border:1px solid silver; overflow:auto">
                           <div style="padding:5px; border-bottom:1px solid silver">Group List</div>
                               <asp:GridView ID="grdsaved" Width="100%" AutoGenerateColumns="false" 
                                   runat="server" onprerender="grdsaved_PreRender">
                               <Columns>
                               
                               <asp:BoundField DataField="UNitGRoupName" HeaderText="Group Name" />
                                <asp:BoundField DataField="cUnitDes" HeaderText="Unit Name" />
                                 <asp:BoundField DataField="nConPara" HeaderText="Conv. param" />
                               </Columns>
                                   <HeaderStyle BackColor="#006699" Font-Names="Tahoma" Font-Size="13px" 
                                       ForeColor="White" Height="23px" />
                                   <RowStyle Font-Names="Tahoma" Font-Size="11px" Height="20px" />
                               </asp:GridView>
                           </div>
                           </td>
                    </tr>
                </table>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>

    <script type="text/javascript">
//        function getunit() {
//            var x = 0;
//            var gvDrv = document.getElementById("grdUnitlist");
//            var rows = gvDrv.rows;
//	        for(var index=1;index<rows.length;index++)
//	            {
//	                var checkBox = rows[index].cells[0].childNodes[0];
//	                if (checkBox.type == 'checkbox') {
//	                    if (checkBox.Checked) {
//	                        x = eval(x) + 1;
//	                    }
//	                }
//		        }
//		        alert(x);
//		    }
//		    var x = 0;
//            var gridView = document.getElementById("<%=grdUnitlist.ClientID %>");
//            var checkBoxes = gridView.getElementsByTagName("input");
//            for (var i = 0; i < checkBoxes.length; i++) {
//            if (checkBoxes[i].type == "checkbox" && checkBoxes[i].checked) {
//                x = eval(x) + 1;
//            }
        //}

       
    </script>

    </form>
</body>
</html>



