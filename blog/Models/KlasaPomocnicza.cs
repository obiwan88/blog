using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace blog.Models
{
   [MetadataType (typeof(PostObjectValidate))]
    public class KlasaPomocnicza
    {
        public int id { get; set; }
        public string tresc { get; set; }
        public string tytul { get; set; }
        public DateTime data_dodania { get; set; }
        public int status { get; set; }
        public DateTime data_modyfikacji { get; set; }

        public string keywords { set; get; }
        public string description { set; get; }
        
        
    }

    [Bind (Exclude = "id, status")] 
    public class PostObjectValidate 
    {
        [RegularExpression(@"[A-za-z ]{3,100}", ErrorMessage = "nie mozna liczb")]
        [Required (ErrorMessage = "Pole jest wymagane")]
        public string tytul { get; set; }

     //   [RegularExpression(@"[0-9][0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9]", ErrorMessage = "data w formacie yyyy-mm-dd")]
        [Required(ErrorMessage = "Pole jest wymagane")]
        public DateTime data_dodania { get; set; }

      //  [RegularExpression(@"[0-9][0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9]", ErrorMessage = "data w formacie yyyy-mm-dd")]
        [Required(ErrorMessage = "Pole jest wymagane")]
        public DateTime data_modyfikacji { get; set; }
        
    }
}