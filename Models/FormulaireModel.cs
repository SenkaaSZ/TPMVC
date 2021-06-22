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

        [Required(ErrorMessage = "Le champ Nom est requis")]
        public string Nom { get; set; }

        [Display(Name = "Prénom")]
        [Required(ErrorMessage = "Le champ Prénom est requis")]
        public string Prenom { get; set; }

        [Required(ErrorMessage = "Le champ Sexe est requis")]
        public string Sexe { get; set; }

        [Required(ErrorMessage = "Le champ Adresse est requis")]
        public string Adresse { get; set; }

        [Display(Name = "Code postal")]
        [Required(ErrorMessage = "Le champ Code postal est requis")]
        [RegularExpression(@"[0-9]{5}", ErrorMessage = "Le champ Code postal doit contenir 5 caractères numériques")]
        public string Codepostal { get; set; }

        [Required(ErrorMessage = "Le champ Ville est requis")]
        public string Ville { get; set; }

        [Display(Name = "Adresse mail")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Le champ Adresse mail est requis")]
        public string Adressemail { get; set; }

        [Display(Name = "Date début formation")]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "01/01/0001", "01/01/2021",
                   ErrorMessage = "La date doit être inférieure au 01-01-2021")]
        public DateTime Dateformation { get; set; }

        [Required(ErrorMessage = "Le champ Formation est requis")]
        public string Formation { get; set; }

        [Required(ErrorMessage = "Le champ Cobol est requis")]
        public string Cobol { get; set; }

        [Required(ErrorMessage = "Le champ Objet est requis")]
        public string Objet { get; set; }
    }
}