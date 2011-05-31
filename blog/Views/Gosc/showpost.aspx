<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/szablon.Master" Inherits="System.Web.Mvc.ViewPage<blog.Models.HomeRepository>" %>
<%@ Import Namespace = "blog.Models" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Detale postu</h2>
    <%Post p = (Post)ViewData["post"]; %>
       <table border="0" style="width: 498px">
          
              <tr bgcolor="#66FFFF">
                <td bgcolor="#0033CC">
                     Data dodania:  <%:p.data_dodania %><br />
                     Data modyfikacji: <%:p.data_modyfikacji %>
                </td>     
           </tr>    
           <tr>
                <td bgcolor="#0066FF">
                    Tytul:  <%:p.tytul %>
                </td>
              
           </tr>
            <tr>
                <td bgcolor="#99CCFF">
                    Tre&#347;&#263;: <%: p.tresc %>
                </td>                
           </tr>
           <tr>
                <td>
                   <a href="/Gosc/DodajKoment/?id=<%:p.id%>">Dodaj komentarz</a>
                   |
                   <a href="/admin/edytuj/?id=<%:p.id%>">Edytuj post</a>
                   |
                   <a href="/admin/UsunPost/?id=<%:p.id%>">Usun post</a>
                   |
                   

                </td>
                
           </tr>
       </table><hr /><br />
       
          <% foreach (Komentarz k in (IEnumerable)ViewData["klista"])
             { %>
        <%   if (p.id == k.id_posta)
             {%>
       <table border="0" style="width: 423px" align="right">
          
              <tr bgcolor="#FFFF66">
                <td bgcolor="Yellow">
                     Data dodania Komentarza:  <%:k.data_dodania%><br />
                </td>     
           </tr>    
           <tr>
                <td bgcolor="#FFFF66">
                    Autor:  <%:k.autor%>
                </td>
              
           </tr>
            <tr>
                <td bgcolor="#FFFF99">
                    Tre&#347;&#263;: <%: k.tresc%>
                </td>                
           </tr>
           <tr>
           <td>
           <a href="/admin/UsunKomentarz/?id=<%:p.id%>">usun komentarz</a> | 
           <a href="/gosc/showKoment/?id=<%:p.id%>">Wybierz komentarz</a>
           </td>
           </tr>
       </table><br />
       <%}
             } %>
</asp:Content>

