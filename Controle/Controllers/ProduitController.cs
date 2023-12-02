using BLL;
using Microsoft.AspNetCore.Mvc;

namespace Controle.Controllers
{
    public class ProduitController : Controller
    {
        private readonly ServiceProduit _serviceProduit;

        public ProduitController()
        {
            ServiceProduit serviceProduit = new ServiceProduit();
            _serviceProduit = serviceProduit;
        }


        
        public IActionResult Index()
        {
            List<Produit> produits = _serviceProduit.All();
           
            return View(produits);
        }

        public IActionResult Detail(int id)
        {
            List<Produit> produits = _serviceProduit.All();
            Produit produit=_serviceProduit.Read(id);
            if (produit == null)
            {
                return NotFound();
            }


            return View(produit);
        }


    }
}
