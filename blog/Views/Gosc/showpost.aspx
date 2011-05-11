<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/szablon.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<blog.Models.GoscRepository>>" %>
<%@ Import Namespace = "blog.Models" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>showpost</h2>

   <form id="form1" runat = "server">
        <p>
        <p><h1><%: ((IEnumerable<Post>)ViewData["post"]).FirstOrDefault<Post>().tytul %></h1> <br />
               <%: ((IEnumerable<Post>)ViewData["post"]).FirstOrDefault<Post>().tresc %> <br />
        </p>
        <%foreach (Komentarz item in (IEnumerable<Komentarz>)ViewData["komentarze"])
          {%>
           <p><%=item.autor %> <%=item.data_dodania %><br />
           <p><%=item.tresc %><a href= "../../Admin/UsunKomentarz/<%:item.id %>"> Usuwanko komcia</a> <br /></p>
           <%} %>   
    </p>
    </form>
</asp:Content>

