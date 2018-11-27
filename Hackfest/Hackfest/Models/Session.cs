using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hackfest.Models
{
    public sealed class Session
    {
        [Key, ForeignKey("IdArticleNavigation")]
        public int IdArticle { get; set; }
        public Article IdArticleNavigation { get; set; }
        [Key, ForeignKey("IdMembreNavigation")]
        public int IdMembre { get; set; }
        public Membre IdMembreNavigation { get; set; }
        [Required(ErrorMessage = "SVP entrez le titre")]
        public string TitreSession { get; set; }
        [Required(ErrorMessage = "SVP entrez la date de session")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "0:MM-dd-yyyy", ApplyFormatInEditMode = true)]
        public DateTime DateSession { get; set; }
        [Required(ErrorMessage = "SVP entrez l'heure de la session")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "0:H:mm:ss", ApplyFormatInEditMode = true)]
        public DateTime Heure { get; set; }
    }
}
