using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hackfest.Models
{
    public class Paiement
    {
        [Key]
        public int IdPaiement { get; set; }
        [Required(ErrorMessage = "SVP entrez le montant")]
        [Range(1, 9000)]
        [DataType(DataType.Currency)]
        public decimal? Montant { get; set; }
        [Required(ErrorMessage = "SVP entrez la date de réception")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateRéceptionPaiement { get; set; }
        [ForeignKey("IdParticipantNavigation")]
        public int IdParticipant { get; set; } 
        public Participant IdParticipantNavigation { get; set; }
    }
}
