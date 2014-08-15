using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Help.DAL;
using Help.Model;
using Help.Model.ViewModel;
using Help.Ultilities;

namespace Help.AdminSite.Controllers
{
    public class PhongKhamController : Controller
    {
        //
        // GET: /PhongKham/

        private GenericRepository<CoSoKhamBenh> _coSoKhamBenhRepository;
        private GenericRepository<LoaiCoSoKhamBenh> _loaiCoSoRepository;
        private GenericRepository<LoaiDieuTri> _loaiDieuTriRepository;

        public PhongKhamController()
        {
            this._coSoKhamBenhRepository = new GenericRepository<CoSoKhamBenh>(new HelpContext());
            this._loaiCoSoRepository = new GenericRepository<LoaiCoSoKhamBenh>(new HelpContext());
            this._loaiDieuTriRepository = new GenericRepository<LoaiDieuTri>(new HelpContext());
        }

        public PhongKhamController(GenericRepository<CoSoKhamBenh> Tgeneric)
        {
            this._coSoKhamBenhRepository = Tgeneric;
        }
        public PhongKhamController(GenericRepository<LoaiCoSoKhamBenh> Tgeneric)
        {
            this._loaiCoSoRepository = Tgeneric;
        }
        public PhongKhamController(GenericRepository<LoaiDieuTri> Tgeneric)
        {
            this._loaiDieuTriRepository = Tgeneric;
        }


        public ActionResult Index()
        {
            var listCoSoKhamBenh = _coSoKhamBenhRepository.GetAll().ToList();
            return View(listCoSoKhamBenh);
        }

        public ActionResult Create()
        {
            var listCoSo = _coSoKhamBenhRepository.GetAll().ToList();

            ViewBag.LoaiCoSo = (IEnumerable<SelectListItem>)_loaiCoSoRepository.GetAll().Select(b => new SelectListItem { Value = b.Id.ToString(), Text = b.Ten });
            ViewBag.LoaiDieuTri = (IEnumerable<SelectListItem>)_loaiDieuTriRepository.GetAll().Select(b => new SelectListItem { Value = b.Id.ToString(), Text = b.Ten });

            var listCoSoViewModel = new CoSoKhamBenhViewModel();
            listCoSoViewModel.CoSoKham = new CoSoKhamBenh();
            listCoSoViewModel.LoaiCoSoKham = _loaiCoSoRepository.GetAll();
            listCoSoViewModel.LoaiDieuTri = _loaiDieuTriRepository.GetAll();


            return View();
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult Create(CoSoKhamBenh coSoKhamBenh, int LoaiCoSo, int LoaiDieuTri)
        {
            try
            {
                ViewBag.LoaiCoSo = (IEnumerable<SelectListItem>)_loaiCoSoRepository.GetAll().Select(b => new SelectListItem { Value = b.Id.ToString(), Text = b.Ten });
                ViewBag.LoaiDieuTri = (IEnumerable<SelectListItem>)_loaiDieuTriRepository.GetAll().Select(b => new SelectListItem { Value = b.Id.ToString(), Text = b.Ten });
                coSoKhamBenh.LoaiCoSo = LoaiCoSo;
                coSoKhamBenh.LoaiDieuTri = LoaiDieuTri;
                coSoKhamBenh.NgayTao = DateTime.Now;
                coSoKhamBenh.NgayChinhSua = DateTime.Now;

                _coSoKhamBenhRepository.Insert(coSoKhamBenh);
                _coSoKhamBenhRepository.Save();
            }
            catch (Exception exception)
            {
                Logger.FrameworkLogger.Error("Create Phong Kham error: ",exception);
            }
            
            return View();
        }

        public ActionResult Edit(int id)
        {
            ViewBag.LoaiCoSo = (IEnumerable<SelectListItem>)_loaiCoSoRepository.GetAll().Select(b => new SelectListItem { Value = b.Id.ToString(), Text = b.Ten });
            ViewBag.LoaiDieuTri = (IEnumerable<SelectListItem>)_loaiDieuTriRepository.GetAll().Select(b => new SelectListItem { Value = b.Id.ToString(), Text = b.Ten });
            
            var phongKhamDetail = _coSoKhamBenhRepository.GetById(id);
            return View(phongKhamDetail);
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult Edit(CoSoKhamBenh coSoKhamBenh, int LoaiCoSo, int LoaiDieuTri)
        {
            try
            {
                ViewBag.LoaiCoSo = (IEnumerable<SelectListItem>)_loaiCoSoRepository.GetAll().Select(b => new SelectListItem { Value = b.Id.ToString(), Text = b.Ten });
                ViewBag.LoaiDieuTri = (IEnumerable<SelectListItem>)_loaiDieuTriRepository.GetAll().Select(b => new SelectListItem { Value = b.Id.ToString(), Text = b.Ten });
                coSoKhamBenh.LoaiCoSo = LoaiCoSo;
                coSoKhamBenh.LoaiDieuTri = LoaiDieuTri;
                coSoKhamBenh.NgayTao = DateTime.Now;
                coSoKhamBenh.NgayChinhSua = DateTime.Now;

                _coSoKhamBenhRepository.Update(coSoKhamBenh);
                _coSoKhamBenhRepository.Save();
            }
            catch (Exception ex)
            {
                Logger.FrameworkLogger.Error("Update Phong Kham error: ", ex);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            try
            {
                var cosoKhamBenh = _coSoKhamBenhRepository.GetById(id);
                if(cosoKhamBenh!=null)
                {
                    _coSoKhamBenhRepository.Delete(cosoKhamBenh);
                    _coSoKhamBenhRepository.Save();
                }
            }
            catch (Exception ex)
            {
                Logger.FrameworkLogger.Error("Delete Phong Kham error: ", ex);
            }
            return RedirectToAction("Index");
        }

    }
}
