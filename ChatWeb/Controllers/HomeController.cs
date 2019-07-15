using ChatWeb.Business;
using ChatWeb.Models.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChatWeb;
using UtilitiesChat.Models.WS;
using UtilitiesChat.Tools;

namespace ChatWeb.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public ActionResult Login()
        {
            UserAccessViewModel model = new UserAccessViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Login(UserAccessViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            AccessRequest oAR = new AccessRequest();
            oAR.Email = model.Email;
            oAR.Password = Encrypt.GetSHA256(model.Password);

            RequestUtil oRequestUtil = new RequestUtil();

            Reply oReply = oRequestUtil.Execute<AccessRequest>(Constants.Url.ACCESS, "post", oAR);

            UserResponse oUserReponse = JsonConvert.DeserializeObject<UserResponse>(JsonConvert.SerializeObject(oReply.data));

            if (oReply.result == 1)
            {
                Session["User"] = oUserReponse;
                return RedirectToAction("Index", "Lobby");
            }

            ViewBag.error = "Datos Incorrectos";

            return View(model);
        }



        [HttpGet]
        public ActionResult Register()
        {
            RegisterViewModel model = new RegisterViewModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            Models.Request.User oUser = new Models.Request.User();
            oUser.Name = model.Name;
            oUser.Email = model.Email;
            oUser.City = model.City;
            oUser.Password = model.Password;

            RequestUtil oRequestUtil = new RequestUtil();

            Reply oReply = oRequestUtil.Execute<Models.Request.User>(Constants.Url.REGISTER, "post", oUser);

            return View();
        }

    }
}