using System.Linq;

namespace Hackfest.Models
{
    public sealed class DépôtBD : IDépôt
    {
        private ContexteTP contexte;
        public DépôtBD(ContexteTP p_contexte)
        {
            contexte = p_contexte;
        }
        public IQueryable<Participant> Réponses() => contexte.Participant;

        public void AjouterParticipant(Participant p_réponse)
        {
            if (p_réponse.Id == 0)
            {
                contexte.Participant.Add(p_réponse);
            }
            else
            {
                Participant maRéponse = contexte.Participant
                .FirstOrDefault(r => r.Id == p_réponse.Id);  
                if (maRéponse != null)
                {
                    maRéponse.Prénom = p_réponse.Prénom;
                    maRéponse.Nom = p_réponse.Nom;
                    maRéponse.Courriel = p_réponse.Courriel;
                    maRéponse.Affiliation = p_réponse.Affiliation;
                    maRéponse.DateInscription = p_réponse.DateInscription;
                }
            }
            contexte.SaveChanges();
        }

        public Participant RetireParticipant(int p_idRéponse)
        {
            Participant maRéponse = contexte.Participant
            .FirstOrDefault(r => r.Id == p_idRéponse);
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
            return new Participant() { Nom = p_nom};
        }

        public void SoumettreChangements()
        {
            // TODO
        }

    }
}
