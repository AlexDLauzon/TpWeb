using System.Collections.Generic;
using System.Linq;

namespace BonAnniversaireToto.Models
{
    public static class Dépôt
    {
        private static List<Invitation> réponses = new List<Invitation>();

        // IEnumerable -> IQueryable
        public static IEnumerable<Invitation> Réponses
        {
            get { return réponses; }
        }

        public static void AjouterRéponse(Invitation p_réponse)
        {
            réponses.Add(p_réponse);
        }
    }
}
