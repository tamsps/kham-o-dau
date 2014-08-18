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

        public ActionResult Edit(int id)
        {
            var userList = _userRepository.GetById(id);
            List<SelectListItem> newList = new List<SelectListItem>();
            newList.Add(new SelectListItem() { Value = "Nam", Text = "Nam", Selected = true });
            newList.Add(new SelectListItem() { Value = "Nữ", Text = "Nữ", Selected = false });
            newList.Add(new SelectListItem() { Value = "Khác", Text = "Khác", Selected = false });

            ViewBag.Sex = (IEnumerable<SelectListItem>)newList;
            return View(userList);
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult Edit(User user, string Sex)
        {
            try
            {
                user.GioiTinh = Sex;
                _userRepository.Update(user);
                _userRepository.Save();
            }
            catch (Exception ex)
            {
                Logger.FrameworkLogger.Error("Edit benh nhan error: ",ex);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Details()
        {
            var userList = _userRepository.GetAll();
            return View(userList);
        }

        public ActionResult Delete(int id)
        {
            var userList = _userRepository.GetById(id);
            _userRepository.Delete(userList);
            _userRepository.Save();
            return RedirectToAction("Index");
        }
        public ActionResult Create()
        {
            List<SelectListItem> newList = new List<SelectListItem>();
            newList.Add(new SelectListItem() { Value = "Nam", Text = "Nam", Selected = true });
            newList.Add(new SelectListItem() { Value = "Nữ", Text = "Nữ", Selected = false });
            newList.Add(new SelectListItem() { Value = "Khác", Text = "Khác", Selected = false });

            ViewBag.Sex = (IEnumerable<SelectListItem>)newList;
            return View();
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult Create(User user, string Sex)
        {
            try {
                user.GioiTinh = Sex;
                _userRepository.Insert(user);
                _userRepository.Save();
            }
            catch (Exception ex)
            {
                Logger.FrameworkLogger.Error("Create Benh Nhan error: ",ex);
            }
            return RedirectToAction("Index");
        }
    }
}
