<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForms.AutoFac.MultiTenant.Web.Tenant2.Default" %>

<%@ Register Src="~/Controls/CourseList.ascx" TagPrefix="uc1" TagName="CourseList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <uc1:CourseList runat="server" id="CourseList" />
</asp:Content>
