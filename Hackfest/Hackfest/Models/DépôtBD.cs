using System.Linq;

namespace Hackfest.Models
{
    public sealed class DépôtBD : IDépôt
    {
        private ContexteTP contexte = new ContexteTP();
        public DépôtBD(ContexteTP p_contexte)
        {
            contexte = p_contexte;
        }
        public IQueryable<Participant> Réponses() => contexte.Participant;

        public void AjouterParticipant(Participant p_réponse)
        {
            if (p_réponse.IdParticipant == 0)
            {
                contexte.Participant.Add(p_réponse);
            }
            else
            {
                Participant maRéponse = contexte.Participant
                .FirstOrDefault(r => r.IdParticipant == p_réponse.IdParticipant);  
                if (maRéponse != null)
                {
                    maRéponse.PrénomParticipant = p_réponse.PrénomParticipant;
                    maRéponse.NomParticipant = p_réponse.NomParticipant;
                    maRéponse.CourrielParticipant = p_réponse.CourrielParticipant;
                    maRéponse.Affiliation = p_réponse.Affiliation;
                    maRéponse.DateInscription = p_réponse.DateInscription;
                }
            }
            contexte.SaveChanges();
        }

        public Participant RetireParticipant(int p_idRéponse)
        {
            Participant maRéponse = contexte.Participant
            .FirstOrDefault(r => r.IdParticipant == p_idRéponse);
            if (maRéponse != null)
            {
                contexte.Participant.Remove(maRéponse);
                contexte.SaveChanges();
            }
            return maRéponse;
        }

        public Participant ObtientAvecNom(string p_nom)
        {
            // TODO
            // Méthode bidon
            return new Participant() { NomParticipant = p_nom};
        }

        public void SoumettreChangements()
        {
            // TODO
        }

    }
}
