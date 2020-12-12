<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tenants.aspx.cs" Inherits="WebForms.AutoFac.MultiTenant.Web.Tenants" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="tenantsGrid" runat="server"
        CssClass="table table-striped">
        
    </asp:GridView>
</asp:Content>
