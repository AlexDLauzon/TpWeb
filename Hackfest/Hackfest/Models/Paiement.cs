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
        public decimal? Montant { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateRéceptionPaiement { get; set; }
        [ForeignKey("IdParticipantNavigation")]
        public int IdParticipant { get; set; } 
        public Participant IdParticipantNavigation { get; set; }
    }
}
