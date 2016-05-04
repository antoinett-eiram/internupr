using Microsoft.AspNet.Identity;
using System.Data.Entity;
using System.Data;
using internUPR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using internUPR.ViewModels;

namespace internUPR.Controllers
{
    public class InternshipController : DBController
    {   //GET: Returns whatever information is identified by the request
        public ActionResult Create()
        {
            return View();
        }

        //POST: Posts new information or updates existing information
        //Creates an internship object
        [HttpPost]
        public ActionResult Create(Internship model) 
        {
            string userID = User.Identity.GetUserId();
          //  ViewBag.DptSelection = db.Internships.Select(x => new SelectListItem){      
            //}
            if(db.Users.Where(x=> x.Id == userID).Any())
            {
                model.userId = userID;
                db.Internships.Add(model);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult Index()
        {

            return View(getInternship());
        }
        //Searches in the database
        private InternshipListViewModel getInternship()
        {
            string userId = User.Identity.GetUserId();
            List<Internship> internshipList = db.Internships.Where(x => x.userId == userId).ToList();
            InternshipListViewModel ivm = new InternshipListViewModel();
            ivm.Internships = new List<Internship>();
            foreach (Internship item in internshipList)
            {
                ivm.Internships.Add(item);
            }
            return ivm;
        }

        //GET:Internship/Edit
        public ActionResult Edit(int internshipId)
        {
            Internship newInternship = db.Internships.First(x => x.internID == internshipId);

            return View(newInternship);
        }

        //POST:Internship/Edit
        //Calls method that lets edit the intership object & saves them
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Internship internshipId)
        {
            string userid = User.Identity.GetUserId();
           // Internship newInternship = db.Internships.First(x => x.internID == internshipId.internID && x.userId == userid);
            if(ModelState.IsValid)
            {
                db.Entry(internshipId).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Index");
        }

        //GET: Internship/Delete/5
        //Llama a metodo para eliminar un internado
        //public ActionResult Delete(int id)
        //{
        //   // Internship newintern = db.Internships.Find(id);
        //    Internship id2BDel = db.Internships.Find(id);
        //    db.Internships.Remove(id2BDel);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //POST: Internship/Delete/5
       // [HttpPost, ActionName("Delete")]
       // [ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int internId)
        //{
        //    Internship id2BDel = db.Internships.Find(internId);
        //    db.Internships.Remove(id2BDel);
        //    db.SaveChanges();

        //    return RedirectToAction("Index");
        //}

        //GET:Internship/Delete
        /*public ActionResult Delete(int internshipId)
        {
            Internship newInternship = db.Internships.First(x => x.internID == internshipId);

            return View(newInternship);
        }*/

        //POST:Internship/Delete
        /*[HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Internship internshipId)
        {
            string userid = User.Identity.GetUserId();
           // Internship newInternship = db.Internships.First(x => x.internID == internshipId.internID && x.userId == userid);
            if(ModelState.IsValid)
            {
                db.Internships.Remove(internshipId);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Index");
        }*/

        ////////////////////////////////////////////////////details/////////////////////////////////////////////


        //GET:Internship/Details
        //Calls method that displays the internship details
        public ActionResult Details(int internshipId)
        {
            Internship newInternship = db.Internships.First(x => x.internID == internshipId);

            return View(newInternship);
        }

        //POST:Internship/Details
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Details(Internship internshipId)
        //{
        //    string userid = User.Identity.GetUserId();
        //   // Internship newInternship = db.Internships.First(x => x.internID == internshipId.internID && x.userId == userid);
        //    if(ModelState.IsValid)
        //    {
        //        db.Internships.Remove(internshipId);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View("Index");
        //}


        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        //SEARCH ENGINE FOR INTERNSHIPS
        //public ActionResult Index(string searchString)
        //{
        //    var internados = from x in db.Internships
        //                     select x;
        //    if(!String.IsNullOrEmpty(searchString))
        //    {
        //        internados = internados.Where(s => s.name.Contains(searchString));
        //    }
        //    return View(internados);
        //}

        //[HttpPost]
        //public string Index(FormCollection fc, string searchString)
        //{
        //    return "<h3>From [HttpPost]Index" + searchString + "</h3>";
        //}

    }
}