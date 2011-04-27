<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/szablon.Master" Inherits="System.Web.Mvc.ViewPage<blog.Models.KlasaPomocniczaDodajKoment>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 <%blog.Models.Post post = (blog.Models.Post)ViewData["post"]; %>
    <h2>DodajKoment</h2>
 <%//Request.QueryString("id"); %>
 <%//Response.Write(idp); %>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Fields</legend>
             
          <div class="editor-label">
                <%: Html.Label("id posta") %>
            </div>
            <div class="editor-field">
                <%: Html.TextBox("id posta"  )%>
                <%: Html.ValidationMessageFor(model => model.id_posta) %>
            </div>
            <div class="editor-label">
                <%: Html.LabelFor(model => model.tresc) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.tresc) %>
                <%: Html.ValidationMessageFor(model => model.tresc) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.autor) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.autor) %>
                <%: Html.ValidationMessageFor(model => model.autor) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.data_dodania) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.data_dodania) %>
                <%: Html.ValidationMessageFor(model => model.data_dodania) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.status) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.status) %>
                <%: Html.ValidationMessageFor(model => model.status) %>
            </div>
            
                   
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

