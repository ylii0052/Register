using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FIT5032_project.Models;

namespace FIT5032_project.Controllers
{
    public class AccountController : Controller
    {
        // GET: User
        public ActionResult AddOrEdit(int id=0)
        {
            Account account = new Account();
            return View(account);
        }
        [HttpPost]
        public ActionResult AddOrEdit(Account account)
        {
            using (DBModels db = new DBModels())
            {
                db.Accounts.Add(account);
                db.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful";
            return View("AddOrEdit",new Account());
        }
    }
}