using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hackfest.Models
{
    public sealed class Participant
    {

        public Participant()
        {
            //Article = new HashSet<Article>();
            //Membre = new HashSet<Membre>();
            //Organisateur = new HashSet<Organisateur>();
            Paiement = new HashSet<Paiement>();
        }

        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "SVP entrez votre prénom")]
        public string Prénom { get; set; }

        [Required(ErrorMessage = "SVP entrez votre nom")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "SVP entrez votre courriel")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Veuillez entrer un courriel valide SVP.")] // Pour faire un mot de passe de 8 caractère, majuscule, 1 caractère entre !@#$%%?, etc...
        public string Courriel { get; set; }

        [Required(ErrorMessage = "SVP faites un choix")]
        public string Affiliation { get; set; }

        [Required(ErrorMessage = "SVP entrez la date d'inscription")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "0:MM-dd-yyyy", ApplyFormatInEditMode = true)]
        public DateTime DateInscription { get; set; }
        //public ICollection<Article> Article { get; set; }
        //public Membre IdMembreNavigation { get; set; }
        //public Organisateur organisateur { get; set; }
        public ICollection<Paiement> Paiement { get; set; }
    }
}
