<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/szablon.Master" Inherits="System.Web.Mvc.ViewPage<blog.Models.Post>" %>
<%@ Import Namespace = "blog.Models" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<%Post post = (Post)ViewData["post"]; %>

    <h2>edytuj</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
       <%if (ViewData["alert"] != null)
         {  %>
         <%: ViewData["alert"]%>
         <%} %>

        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%: Html.Label("id") %>
            </div>
            <div class="editor-field">
                <%: Html.TextBox("id", post.id) %>
                <%: Html.ValidationMessageFor(model => model.id) %>
            </div>
            
            <div class="editor-label">
                <%: Html.Label("tytul") %>
            </div>
            <div class="editor-field">
                <%: Html.TextBox("tytul", post.tytul) %>
                <%: Html.ValidationMessageFor(model => model.data_dodania) %>
            </div>
           
                       
            <div class="editor-label">
                <%: Html.Label("tresc") %>
            </div>
            <div class="editor-field">
                <%: Html.TextBox("tresc", post.tresc) %>
                <%: Html.ValidationMessageFor(model => model.tresc) %>
            </div>
            
            <div class="editor-label">
                <%: Html.Label("status") %>
            </div>
            <div class="editor-field">
                <%: Html.TextBox("status", post.status) %>
                <%: Html.ValidationMessageFor(model => model.status) %>
            </div>
            
            <div class="editor-label">
                <%: Html.Label("data_modyfikacji") %>
            </div>
            <div class="editor-field">
                <%: Html.TextBox("data_modyfikacji", post.data_modyfikacji) %>
                <%: Html.ValidationMessageFor(model => model.data_modyfikacji) %>
            </div>
            
            <p>
                <input type="submit" value="Save" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

