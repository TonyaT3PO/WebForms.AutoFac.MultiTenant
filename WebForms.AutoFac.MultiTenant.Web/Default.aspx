<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForms.AutoFac.MultiTenant.Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col">
            <asp:GridView ID="tenantsGrid" runat="server"
                CssClass="table table-striped">
        
            </asp:GridView>
        </div>
    </div>

</asp:Content>
