using internUPR.Models;
using internUPR.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//Class that contains the call to the getInternship()  method.
namespace internUPR.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(getInternship());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Descripción de la página.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Página de contacto.";

            return View();
        }
        //busca en la base de datos los internados
        private InternshipListViewModel getInternship()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<Internship> internshipList = db.Internships.ToList();
            InternshipListViewModel ivm = new InternshipListViewModel();
            ivm.Internships = new List<Internship>();
            foreach (Internship item in internshipList)
            {
                ivm.Internships.Add(item);
            }
            return ivm;
        }
    }
}