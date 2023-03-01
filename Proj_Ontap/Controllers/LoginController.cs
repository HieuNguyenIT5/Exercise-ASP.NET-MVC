using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proj_Ontap.Models;

namespace Proj_Ontap.Controllers
{
    public class LoginController : Controller
    {
        private ModelDB db = new ModelDB();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            var user = db.tblUser.SingleOrDefault(p=>p.username == username && p.password == password);
            if(user == null)
            {
                ViewBag.errLogin = "Tên đăng nhập hoặc mật khẩu sai!";
                return View("Login");
            }
            else
            {
                Session["username"] = username;
                return RedirectToAction("index", "NhanViens");
            }
        }
        public ActionResult Logout()
        {
            Session["username"] = null;
            return RedirectToAction("index", "NhanViens");
        }
    }
}