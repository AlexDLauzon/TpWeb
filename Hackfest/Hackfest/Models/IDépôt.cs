using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackfest.Models
{
    public interface IDépôt
    {
        IQueryable<Réponse> Réponses();

        void AjouterRéponse(Réponse p_réponse);
        Réponse RetireRéponse(int p_idRéponse);
        Réponse ObtientAvecNom(string p_nom);
        void SoumettreChangements();
    }
}
