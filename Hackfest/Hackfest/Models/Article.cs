using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hackfest.Models
{
    public sealed class Article
    {
        public Article()
        {
            MembreArticles = new HashSet<MembreArticle>();
            Sessions = new HashSet<Session>();
            VersionArticles = new HashSet<VersionArticle>();
        }

        [Key]
        public int IdArticle { get; set; }
        [ForeignKey("IdParticipantNavigation")]
        public int IdParticipant { get; set; }
        [Required(ErrorMessage = "SVP entrez le titre de l'article")]
        public string TitreArticle { get; set; }
        public ICollection<MembreArticle> MembreArticles { get; set; }
        public ICollection<Session> Sessions { get; set; }
        public ICollection<VersionArticle> VersionArticles { get; set; }
        public Participant IdParticipantNavigation { get; set; }
    }
}
