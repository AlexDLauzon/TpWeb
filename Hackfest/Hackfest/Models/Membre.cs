using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hackfest.Models
{
    public sealed class Membre
    {
        public Membre()
        {
            Spécialités = new HashSet<Spécialité>();
            MembreArticles = new HashSet<MembreArticle>();
            Sessions = new HashSet<Session>();
        }

        [Key]
        public int IdMembre { get; set; }

        [ForeignKey("IdParticipantNavigation")]
        public int IdParticipant { get; set; }
        public Participant IdParticipantNavigation { get; set; }
        public ICollection<Spécialité> Spécialités { get; set; }
        public ICollection<MembreArticle> MembreArticles { get; set; }
        public ICollection<Session> Sessions { get; set; }
    }
}
