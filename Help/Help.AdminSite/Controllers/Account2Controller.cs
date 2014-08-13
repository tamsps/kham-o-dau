using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Help.DAL;
using Help.Model;
using Help.Ultilities;

namespace Help.AdminSite.Controllers
{
    public class Account2Controller : Controller
    {
        //
        // GET: /Account2/
        private GenericRepository<UserAdmin> accountRepository;

        public Account2Controller()
        {
            this.accountRepository = new GenericRepository<UserAdmin>(new HelpContext());
        }

        public Account2Controller(GenericRepository<UserAdmin> Tgeneric)
        {
            this.accountRepository = Tgeneric;
        }
    

        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult LogIn()
        {
            ViewBag.ErrorMsg = string.Empty;
            return View();
        }
        [HttpPost]
        public ActionResult LogIn([Bind(Include = "Username, Password")]UserAdmin userAdmin)
        {
            var listOfUer = accountRepository.GetAll().ToList();
            if(listOfUer.Any())  //Count>0
            {
                var existAcc =listOfUer.FirstOrDefault(d =>string.Equals(d.Username, userAdmin.Username) && string.Equals(d.Password, userAdmin.Password));
                if(existAcc!=null) //Exist account
                {
                    Session[SessionEnum.UserAdmin.ToString()] = existAcc;
                    return RedirectToAction("Index","Home");
                }
            }
            ViewBag.ErrorMsg = "Invalid username or password";
            return View();
        }
    }
}
