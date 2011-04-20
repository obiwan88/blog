<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/szablon.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace ="blog.Models" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Zaakceptowane Posty Uzytkowników:</h2>
    
    <% foreach (Post p in (IEnumerable)ViewData["lista"])
       { %>
       <table border="0" style="width: 498px">
          
              <tr bgcolor="#66FFFF">
                <td>
                     Data dodania:  <%:p.data_dodania %><br />
                     Data modyfikacji: <%:p.data_modyfikacji %>
                </td>     
           </tr>    
           <tr>
                <td bgcolor="#FFCCCC">
                    Tytul:  <%:p.tytul %>
                </td>
              
           </tr>
            <tr>
                <td bgcolor="#FFFF99">
                    Tre&#347;&#263;: <%: p.tresc %>
                </td>                
           </tr>
           <tr>
                <td>
                   <a href="../Gosc/DodajKoment/?id=<%:p.id%>">dodaj komentarz</a>
                </td>
           </tr>
       </table><hr /><br />
       
          <% foreach (Komentarz k in (IEnumerable)ViewData["klista"])
       { %>
        <%   if(p.id == k.id_posta) {%>
       <table border="0" style="width: 423px" align="right">
          
              <tr bgcolor="#66FFFF">
                <td bgcolor="Black">
                     Data dodania Komentarza:  <%:k.data_dodania %><br />
                </td>     
           </tr>    
           <tr>
                <td bgcolor="#333333">
                    Autor:  <%:k.autor %>
                </td>
              
           </tr>
            <tr>
                <td bgcolor="#CCCCCC">
                    Tre&#347;&#263;: <%: k.tresc %>
                </td>                
           </tr>
       </table><hr /><br />
           <%} %>
           <%} %>
           <%} %>

         

</asp:Content>
