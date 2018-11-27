using System.Collections.Generic;

namespace Hackfest.Models
{
    public static class Dépôt
    {
        private static List<Participant> participants = new List<Participant>();

        public static IEnumerable<Participant> Participants // Changer IEnum pour IQueryable (quand on va avoir la bd)
        {
            get { return participants; }
        }

        public static void AjouterParticipant(Participant p_réponse)
        {
            participants.Add(p_réponse);
        }
    }
}
