using System.Collections.Generic;

namespace Hackfest.Models
{
    public static class Dépôt
    {
        private static List<Invitation> réponses = new List<Invitation>();

        public static IEnumerable<Invitation> Réponses // Changer IEnum pour IQueryable (quand on va avoir la bd)
        {
            get { return réponses; }
        }

        public static void AjouterRéponse(Invitation p_réponse)
        {
            réponses.Add(p_réponse);
        }
    }
}
