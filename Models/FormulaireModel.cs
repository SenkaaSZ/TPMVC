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

        [Required(ErrorMessage = "The field 'Nom' is required")]
        public string Nom { get; set; }

        [Display(Name = "Prénom")]
        [Required(ErrorMessage = "The field 'Prenom' is required")]
        public string Prenom { get; set; }

        [Required(ErrorMessage = "The field 'Sexe' is required")]
        public string Sexe { get; set; }

        [Required(ErrorMessage = "The field 'Adresse' is required")]
        public string Adresse { get; set; }

        [Display(Name = "Code postal")]
        [RegularExpression(@"[0-9]{5}")]
        public int Codepostal { get; set; }

        [Required(ErrorMessage = "The field 'Ville' is required")]
        public string Ville { get; set; }

        [Display(Name = "Adresse mail")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "The field 'Adresse mail' is required")]
        public string Adressemail { get; set; }

        [Display(Name = "Date début formation")]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "", "1/1/2021")]
        public DateTime Dateformation { get; set; }

        [Required(ErrorMessage = "The field 'Formation' is required")]
        public string Formation { get; set; }

        [Required(ErrorMessage = "The field 'Cobol' is required")]
        public string Cobol { get; set; }

        [Required(ErrorMessage = "The field 'Objet' is required")]
        public string Objet { get; set; }
    }
}