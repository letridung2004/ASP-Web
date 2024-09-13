﻿using BaiThucHanh03.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiThucHanh03.Controllers
{
    public class TaiKhoanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DangKy(TaiKhoanModel taikhoan)
        {
            if (taikhoan == null && taikhoan.Password != null && taikhoan.Password.Length > 0)
            {
                taikhoan.Password = taikhoan.Password + "_da_ma_hoa";
            }
            return View(taikhoan);
        }
    }
}
