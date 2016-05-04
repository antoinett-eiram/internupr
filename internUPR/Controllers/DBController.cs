using internUPR.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//This class makes it easier to call the database
namespace internUPR.Controllers
{
    [Authorize]
    public class DBController : Controller
    {
        public ApplicationDbContext db = new ApplicationDbContext();
        private ApplicationUserManager _userManager;

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string userId = User.Identity.GetUserId();
            ViewBag.UserName = UserManager.FindById(userId).fullName;
            base.OnActionExecuting(filterContext);
        }
        ////Uses the procedure
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Internship>().MapToStoredProcedures();
        //}
    }
}