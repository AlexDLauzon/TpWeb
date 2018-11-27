using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hackfest.Models
{
    public sealed class Spécialité
    {
        [Key]
        public int IdSpécialité { get; set; }
        [ForeignKey("IdMembreNavigation")]
        public int IdMembre { get; set; }
        public Membre IdMembreNavigation { get; set; }
        [Required(ErrorMessage = "SVP entrez la spécialité")]
        public string DescriptionSpécialité { get; set; }

    }
}
