using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hackfest.Models
{
    public sealed class MembreArticle
    {
        [Key, ForeignKey("IdArticleNavigation")]
        public int IdArticle { get; set; }
        public Article IdArticleNavigation { get; set; }
        [Key, ForeignKey("IdMembreNavigation")]
        public int IdMembre { get; set; }
        public Membre IdMembreNavigation { get; set; }
        [Required(ErrorMessage = "SVP entrez une note")]
        public string Note { get; set; }

    }
}
