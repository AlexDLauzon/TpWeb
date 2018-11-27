using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hackfest.Models
{
    public sealed class VersionArticle
    {
        [Key]
        public int IdVersionArticle { get; set; }
        [Required(ErrorMessage = "SVP entrez l'URL")]
        public string Url { get; set; }
        [Required(ErrorMessage = "SVP entrez le numéro de version")]
        public int NoVersion { get; set; }
        [Required(ErrorMessage = "SVP entrez la date de soumission")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "0:MM-dd-yyyy", ApplyFormatInEditMode = true)]
        public DateTime DateSoumission { get; set; }
        [ForeignKey("IdArticleNavigation")]
        public int IdArticle { get; set; }
        public Article IdArticleNavigation { get; set; }
    }
}
