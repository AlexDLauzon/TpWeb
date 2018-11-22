using System;
using System.ComponentModel.DataAnnotations;

namespace Hackfest.Models
{
    public sealed class Invitation // Sealed = empêche d'overwrite.
    {
        [Required(ErrorMessage = "SVP entrez votre prénom")]
        public string Prénom { get; set; }

        [Required(ErrorMessage = "SVP entrez votre nom")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "SVP entrez votre courriel")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Veuillez entrer un courriel valide SVP.")] // Pour faire un mot de passe de 8 caractère, majuscule, 1 caractère entre !@#$%%?, etc...
        public string Courriel { get; set; }

        [Required(ErrorMessage = "SVP entrez votre affiliation")]
        public string Affiliation { get; set; }

        [Required(ErrorMessage = "SVP entrez la date d'inscription")]
        public DateTime DateInscription { get; set; }

        [Required(ErrorMessage = "SVP entrez le montant à payer")]
        public decimal Montant { get; set; }

        [Required(ErrorMessage = "SVP faites un choix")]
        public bool? SeraPrésent { get; set; }
    }
}
