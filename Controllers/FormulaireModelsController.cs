using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TPLOCAL1.Data;
using TPLOCAL1.Models;

namespace TPLOCAL1.Controllers
{
    public class FormulaireModelsController : Controller
    {
        private TPLOCAL1Context db = new TPLOCAL1Context();

        // GET: FormulaireModels
        public ActionResult Index()
        {
            return View(db.FormulaireModels.ToList());
        }

        // GET: FormulaireModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FormulaireModel formulaireModel = db.FormulaireModels.Find(id);
            if (formulaireModel == null)
            {
                return HttpNotFound();
            }
            return View(formulaireModel);
        }

        // GET: FormulaireModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FormulaireModels/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nom,Prenom,Sexe,Adresse,Codepostal,Ville,Adressemail,DateFormation,Formation,Cobol,Objet")] FormulaireModel formulaireModel)
        {
            if (ModelState.IsValid)
            {
                db.FormulaireModels.Add(formulaireModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(formulaireModel);
        }

        // GET: FormulaireModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FormulaireModel formulaireModel = db.FormulaireModels.Find(id);
            if (formulaireModel == null)
            {
                return HttpNotFound();
            }
            return View(formulaireModel);
        }

        // POST: FormulaireModels/Edit/5
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nom,Prenom,Sexe,Adresse,Codepostal,Ville,Adressemail,DateFormation,Formation,Cobol,Objet")] FormulaireModel formulaireModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(formulaireModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(formulaireModel);
        }

        // GET: FormulaireModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FormulaireModel formulaireModel = db.FormulaireModels.Find(id);
            if (formulaireModel == null)
            {
                return HttpNotFound();
            }
            return View(formulaireModel);
        }

        // POST: FormulaireModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FormulaireModel formulaireModel = db.FormulaireModels.Find(id);
            db.FormulaireModels.Remove(formulaireModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
