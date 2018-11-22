using System.Linq;

namespace Hackfest.Models
{
    public sealed class DépôtBD : IDépôt
    {
        private ContexteBD contexte;
        public DépôtBD(ContexteBD p_contexte)
        {
            contexte = p_contexte;
        }
        public IQueryable<Réponse> Réponses() => contexte.Réponses;

        public void AjouterRéponse(Réponse p_réponse)
        {
            if (p_réponse.Id == 0)
            {
                contexte.Réponses.Add(p_réponse);
            }
            else
            {
                Réponse maRéponse = contexte.Réponses
                .FirstOrDefault(r => r.Id == p_réponse.Id);  
                if (maRéponse != null)
                {
                    maRéponse.Prénom = p_réponse.Prénom;
                    maRéponse.Nom = p_réponse.Nom;
                    maRéponse.Courriel = p_réponse.Courriel;
                    maRéponse.Affiliation = p_réponse.Affiliation;
                    maRéponse.DateInscription = p_réponse.DateInscription;
                    maRéponse.Montant = p_réponse.Montant;
                    maRéponse.SeraPrésent = p_réponse.SeraPrésent;
                }
            }
            contexte.SaveChanges();
        }

        public Réponse RetireRéponse(int p_idRéponse)
        {
            Réponse maRéponse = contexte.Réponses
            .FirstOrDefault(r => r.Id == p_idRéponse);
            if (maRéponse != null)
            {
                contexte.Réponses.Remove(maRéponse);
                contexte.SaveChanges();
            }
            return maRéponse;
        }

        public Réponse ObtientAvecNom(string p_nom)
        {
            // TODO
            // Méthode bidon
            return new Réponse() { Nom = p_nom};
        }

        public void SoumettreChangements()
        {
            // TODO
        }

    }
}
