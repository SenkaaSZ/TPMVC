using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TPLOCAL1.Models
{
    public class FormulaireModel
    {
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        public string Sexe { get; set; }
        [Required]
        public string Adresse { get; set; }
        [RegularExpression(@"[0-9]{5}")]
        public int Codepostal { get; set; }
        [Required]
        public string Ville { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Adressemail { get; set; }

        [DataType(DataType.Date)]
        //[Range(typeof(DateTime), "", "1/1/2021")]
        public DateTime Dateformation { get; set; }

        [Required]
        public string Formation { get; set; }

        [Required]
        public string Cobol { get; set; }
        [Required]
        public string Objet { get; set; }
    }
}