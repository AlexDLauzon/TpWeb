using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Hackfest.Models;

namespace Hackfest.Controllers
{
    public sealed class HomeController : Controller
    {
        private IDépôt dépôt;

        public HomeController(IDépôt p_dépôt) => this.dépôt = p_dépôt;

        public ViewResult Index() // Page par défaut
        {
            return View();
        }

        [HttpGet]
        public ViewResult FormulaireRSVP() => View();
        [HttpPost]
        public ViewResult FormulaireRSVP(Réponse p_réponse)
        {
            if (ModelState.IsValid)
            {
                dépôt.AjouterRéponse(p_réponse);
                return View("Merci", p_réponse);
            }
            else
            {
                // Si erreur de validation
                return View();
            }
        }

        public ViewResult AfficherRSVP()
        {
            return View(dépôt.Réponses().Where(r => r.SeraPrésent == true));
        }
        // Même méthode écrite différemment.
        // public ViewResult AfficherRSVP() => View(dépôt.Réponses.Where(r => r.SeraPrésent == true));

        public ActionResult MettreÀJourNom(string p_ancienNom, string p_nouveauNom)
        {
            Réponse uneRéponse = dépôt.ObtientAvecNom(p_ancienNom);
            uneRéponse.Nom = p_nouveauNom;
            dépôt.SoumettreChangements();
            // TODO contruire une vue
            return View();
        }
    }
}
