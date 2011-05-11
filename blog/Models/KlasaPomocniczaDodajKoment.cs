using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace blog.Models
{
    [MetadataType(typeof(KomentarzObjectValidate))]
    public class KlasaPomocniczaDodajKoment
    {
        public int id { get; set; }
        public int id_posta { get; set; }
        public string tresc { get; set; }
        public string autor { get; set; }
        public DateTime data_dodania { get; set; }
        public int status { get; set; }

    }
    [Bind(Exclude = "id, status")]
    public class KomentarzObjectValidate
    {
        [RegularExpression(@"[A-za-z ]{3,100}", ErrorMessage = "nie mozna liczb")]
        [Required(ErrorMessage = "Pole jest wymagane")]
        public string tresc { get; set; }

        [RegularExpression(@"[A-za-z ]{3,100}", ErrorMessage = "nie mozna liczb")]
        [Required(ErrorMessage = "Pole jest wymagane")]
        public string autor { get; set; }

        //    [RegularExpression(@"[0-9][0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9]", ErrorMessage = "data w formacie dd-mm-yyyy")]
        [Required(ErrorMessage = "Pole jest wymagane")]
        public DateTime data_dodania { get; set; }

    }
}
