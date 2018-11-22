using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BonAnniversaireToto.Models;

namespace BonAnniversaireToto.Controllers
{
    public sealed class HomeController : Controller
        //public HomeController(IDépot p_dépôt) => this.dépôt = p_dépôt;
    {
        // GET: Home
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult FormulaireRSVP()
        {
            return View();
        }

        [HttpPost]
        public ViewResult FormulaireRSVP(Invitation p_invitation)
        {
            if (ModelState.IsValid)
            {
                Dépôt.AjouterRéponse(p_invitation);
                return View("Merci", p_invitation);
            }
            else
            {
                return View();
            }
        }

        public ViewResult AfficherRSVP()
        {
            return View(Dépôt.Réponses.Where(i => i.SeraPrésent == true));
        }
        // public 
    }
}
