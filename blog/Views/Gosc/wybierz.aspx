<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/szablon.Master" Inherits="System.Web.Mvc.ViewPage<blog.Models.GoscRepository>" %>
<%@ Import Namespace = "blog.Models" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <h2>wybierz</h2>
    <% Post p = ((IEnumerable<Post>) ViewData["post"]).First();  %>
    <%: p.tytul%><br />

</asp:Content>
