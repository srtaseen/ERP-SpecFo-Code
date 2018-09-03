<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Smt_PORename.aspx.cs" Inherits="Smt_PORename" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel4" runat="server">
        <ContentTemplate>
        <div style="margin-top:100px;">
          <iframe style="width:600px; border:none" src="Master_Setup/porename.aspx"></iframe>
           </div>
          </ContentTemplate>
         
    </asp:UpdatePanel>
</asp:Content>



