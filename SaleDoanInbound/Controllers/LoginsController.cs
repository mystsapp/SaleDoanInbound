﻿using Data.Dtos;
using Data.Models_IB;
using Data.Repository;
using Data.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaleDoanInbound.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SaleDoanInbound.Controllers
{
    public class LoginsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public LoginsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var result = _unitOfWork.userRepository.login(model.Username, "015");
                if (result == null)
                {
                    ModelState.AddModelError("", "Tài khoản này không tồn tại");
                }
                else
                {
                    if (!result.Trangthai)
                    {
                        ModelState.AddModelError("", "Tài khoản này đã bị khóa");
                    }
                    string modelPass = MaHoaSHA1.EncodeSHA1(model.Password);
                    if (result.Password != modelPass)
                    {
                        ModelState.AddModelError("", "Mật khẩu không đúng");
                    }
                    if (result.Password == modelPass)
                    {
                        //var user = _userRepository.GetById(model.Username);
                        var user = await _unitOfWork.userRepository.FindIncludeOneAsync(x => x.Role, x => x.Username == model.Username);
                        HttpContext.Session.Set("loginUser", user);

                        //HttpContext.Session.SetString("username", model.Username);
                        //HttpContext.Session.SetString("password", model.Password);
                        //HttpContext.Session.SetString("hoten", result.Hoten);
                        //HttpContext.Session.SetString("phong", result.Maphong);
                        //HttpContext.Session.SetString("chinhanh", user.chinhanh);
                        //HttpContext.Session.SetString("dienthoai", String.IsNullOrEmpty(result.Dienthoai) ? "" : result.Dienthoai);
                        //HttpContext.Session.SetString("macode", result.Macode);
                        //HttpContext.Session.SetString("roleId", string.IsNullOrEmpty(result.RoleId) ? "" : result.RoleId);
                        //HttpContext.Session.SetString("Newtour", user.Newtour.ToString());
                        //HttpContext.Session.SetString("Dongtour", user.Dongtour.ToString());
                        //HttpContext.Session.SetString("Danhmuc", user.Catalogue.ToString());
                        //HttpContext.Session.SetString("Booking", user.Booking.ToString());
                        //HttpContext.Session.SetString("Report", user.Report.ToString());
                        //HttpContext.Session.SetString("Showprice", user.Showprice.ToString());
                        //HttpContext.Session.SetString("Print", user.Print.ToString());
                        //HttpContext.Session.SetString("Doixe", user.Doixe.ToString());
                        //HttpContext.Session.SetString("Maybay", user.Maybay.ToString());
                        //HttpContext.Session.SetString("Huongdan", user.Huongdan.ToString());
                        //HttpContext.Session.SetString("Sales", user.Sales.ToString());
                        //HttpContext.Session.SetString("Vetq", user.Vetq.ToString());
                        //HttpContext.Session.SetString("Admin", user.Admin.ToString());
                        //HttpContext.Session.SetString("khachle", user.khachle.ToString());
                        //HttpContext.Session.SetString("khachdoan", user.khachdoan.ToString());

                            //if (!string.IsNullOrEmpty(user.Email))
                            //{
                            //    HttpContext.Session.SetString("Email", user.Email.ToString());
                            //}

                            //DateTime ngaydoimk = Convert.ToDateTime(result.Ngaydoimk);
                            //int kq = (DateTime.Now.Month - ngaydoimk.Month) + 12 * (DateTime.Now.Year - ngaydoimk.Year);
                            //if (kq >= 3)
                            //{
                            //    return View("changepass");
                            //}
                        if (result.Doimk)
                        {
                            return View("changepass");
                        }
                        else
                        {
                            return RedirectToAction("Index", "Home");
                        }
                    }
                }
            }
            return View();
        }

        public IActionResult changepass()
        {
            var user = HttpContext.Session.Gets<User>("loginUser").SingleOrDefault();
            
            changepassModel changpassmodel = new changepassModel
            {
                Username = user.Username
            };
            return View(changpassmodel);
        }
        [HttpPost]
        public IActionResult changepass(changepassModel model)
        {
            if (ModelState.IsValid)
            {
                string oldpass = HttpContext.Session.GetString("password");
                if (MaHoaSHA1.EncodeSHA1(oldpass) != MaHoaSHA1.EncodeSHA1(model.Password))
                {
                    ModelState.AddModelError("", "Mật khẩu cũ không đúng");
                }
                else if (model.Newpassword != model.Confirmpassword)
                {
                    ModelState.AddModelError("", "Mật khẩu nhập lại không đúng.");
                }
                else
                {
                    int result = _unitOfWork.userRepository.changepass(model.Username, MaHoaSHA1.EncodeSHA1(model.Newpassword));
                    if (result > 0)
                    {
                        return RedirectToAction("Index", "home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Không thể đổi mật khẩu.");
                    }
                }

            }
            return View();
        }

        public IActionResult logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

    }
}