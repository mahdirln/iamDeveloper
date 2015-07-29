using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using iamDeveloper.DA;
using iamDeveloper.Model;

namespace iamDeveloper.Controllers
{
    public class AcountController : Controller
    {
        // GET: Acount
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register(User mUser)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var users = new Users
                    {
                        ID = mUser.Id,
                        FName = mUser.FName,
                        LName = mUser.LName,
                        E_Mail = mUser.EMail,
                        Username = mUser.Username,
                        Password = mUser.Password
                    };

                    ModelsContainer db = new ModelsContainer();
                    db.Users.Add(users);
                    db.SaveChanges();
                    User u = new User();
                    
                    
                    return RedirectToAction("OperationResult");
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("OperationResult");
            }
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult OperationResult()
        {
            return View();
        }
    }
}