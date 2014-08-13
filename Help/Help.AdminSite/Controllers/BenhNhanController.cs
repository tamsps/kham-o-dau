using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Help.DAL;
using Help.Model;

namespace Help.AdminSite.Controllers
{
    public class BenhNhanController : Controller
    {
        //
        // GET: /BenhNhan/
        private GenericRepository<User> _userRepository;

        public BenhNhanController()
        {
            _userRepository = new GenericRepository<User>();
        }

        public BenhNhanController(GenericRepository<User> userContext)
        {
            _userRepository = userContext;
        }
        public ActionResult Index()
        {
            var userList = _userRepository.GetAll();
            return View(userList);
        }

        public ActionResult Edit()
        {
            var userList = _userRepository.GetAll();
            return View(userList);
        }

        public ActionResult Details()
        {
            var userList = _userRepository.GetAll();
            return View(userList);
        }

        public ActionResult Delete()
        {
            var userList = _userRepository.GetAll();
            return View(userList);
        }
        public ActionResult Create()
        {
            var userList = _userRepository.GetAll();
            return View();
        }
    }
}
