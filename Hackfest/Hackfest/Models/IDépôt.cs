using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackfest.Models
{
    public interface IDépôt
    {
        IQueryable<Participant> Réponses();

        void AjouterParticipant(Participant p_réponse);
        Participant RetireParticipant(int p_idRéponse);
        Participant ObtientAvecNom(string p_nom);
        void SoumettreChangements();
    }
}
