<%@ Page Title="Dodaj Post" Language="C#" MasterPageFile="~/Views/Shared/szablon.Master" Inherits="System.Web.Mvc.ViewPage<blog.Models.KlasaPomocnicza>" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Dodaj Post</h2>

     <% Html.EnableClientValidation(); %>
    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>      
        

        <fieldset>
            <legend>Fields</legend>
                      
            <div class="editor-label">
                <%: Html.LabelFor(model => model.data_dodania) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.data_dodania) %>
                <%: Html.ValidationMessageFor(model => model.data_dodania) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.tytul) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.tytul) %>
                <%: Html.ValidationMessageFor(model => model.tytul) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.tresc) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.tresc) %>
                <%: Html.ValidationMessageFor(model => model.tresc) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.status) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.status) %>
                <%: Html.ValidationMessageFor(model => model.status) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.data_modyfikacji) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.data_modyfikacji) %>
                <%: Html.ValidationMessageFor(model => model.data_modyfikacji) %>
            </div>



             <div class="editor-label">
                <%: Html.LabelFor(model => model.description) %>
            </div>
             <div class="editor-field">
                <%: Html.TextBoxFor(model => model.description) %>
                <%: Html.ValidationMessageFor(model => model.description) %>

             <div class="editor-label">
                <%: Html.LabelFor(model => model.keywords) %>
            </div>
            </div> <div class="editor-field">
                <%: Html.TextBoxFor(model => model.keywords) %>
                <%: Html.ValidationMessageFor(model => model.keywords) %>
            </div>

            
            <p>
                <input type="submit" value="DODAJ POSTA" />
            </p>
        </fieldset>

    <% } %>



</asp:Content>

