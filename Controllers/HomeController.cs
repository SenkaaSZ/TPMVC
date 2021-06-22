using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TPLOCAL1.Data;
using TPLOCAL1.Models;

//L'énoncé du tp et le logo hn sont livrés dans le répertoire /ressources de la solution
//--------------------------------------------------------------------------------------
//Attention, le modèle MVC est un modèle dit de convention plutot que configuration, 
//Le controller doit donc obligatoirement se nommer avec "Controller" à la fin!!!
namespace TPLOCAL1.Controllers
{
    public class HomeController : Controller
    {
        private readonly TPLOCAL1Context db = new TPLOCAL1Context();

        // méthode appelée par la routeur "naturellement"
        public ActionResult Index(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                //renvoie vers la vue Index (voir routage dans RouteConfig.cs)
                return View();
            else
            {
                //en fonction du paramètre id, on appelle les différentes pages
                switch (id)
                {
                    case "ListeAvis":
                        //reste à faire : coder la lecture du fichier xml fourni
                        ListeAvis AvisList = new ListeAvis();
                        List<Avis> dataXML = AvisList.GetAvis("C:/Users/2jume/source/repos/TPLOCAL1-base/FichierXML/DataAvis.xml");
                        return View(id, dataXML);
                    case "Formulaire":
                        //reste à faire : appeler la vue Formulaire avec le modèle de données vide
                        FormulaireModel formulaireModel = new FormulaireModel();
                        if (formulaireModel.Nom == null)
                        {
                            ModelState.AddModelError("", "Le champ 'Nom' est exigé");
                        }

                        if (formulaireModel.Adresse == null || formulaireModel.Adresse.Length < 5)
                        {
                            ModelState.AddModelError("", "adresse trop courte");
                        }
                        return View(id, formulaireModel);
                    default:
                        //renvoie vers Index (voir routage dans RouteConfig.cs)
                        return View();
                }
            }
        }


        //méthode pour envoyer les données du formulaire vers la page de validation
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ValidationFormulaire([Bind(Include = "Id,Nom,Prenom,Sexe,Adresse,Codepostal,Ville,Adressemail,DateFormation,Formation,Cobol,Objet")] FormulaireModel formulaireModel)
        {
            //reste à faire : tester de si les champs du modele sont bien remplis
            //s'ils ne sont pas bien remplis, afficher une erreur et rester sur la page formulaire
            //sinon, appeler la page ValidationFormulaire avec les données remplies par l'utilisateur
            if (ModelState.IsValid)
            {
                db.FormulaireModels.Add(formulaireModel);
                db.SaveChanges();
                return View(formulaireModel);
            }
            /*else
            {
                if (formulaireModel.Nom == null)
                {
                    ModelState.AddModelError("", "Le champ 'Nom' est exigé");
                }

                if (formulaireModel.Adresse == null || formulaireModel.Adresse.Length < 5)
                {
                    ModelState.AddModelError("", "adresse trop courte");
                }
            }*/
            return RedirectToAction("Index/Formulaire");
        }
    }
}