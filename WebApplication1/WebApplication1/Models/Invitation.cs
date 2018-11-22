using System.ComponentModel.DataAnnotations;

namespace BonAnniversaireToto.Models
{
    public sealed class Invitation
    {
        [Required(ErrorMessage = "SVP entrez votre nom")]
        public string Nom { get; set; }
        [Required(ErrorMessage = "SVP entrez votre courriel")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Courriel valide SVP.")]
        public string Courriel { get; set; }
        [Required(ErrorMessage = "SVP entrez votre téléphone")]
        public string Téléphone { get; set; }
        [Required(ErrorMessage = "SVP faites un choix")]
        public bool? SeraPrésent { get; set; }
    }
}
