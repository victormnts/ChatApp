﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UtilitiesChat.Models.WS;

namespace ChatWeb.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        public UserResponse oUserSession;

        public BaseController()
        {
            GetSession();
        }
        protected void GetSession()
        {
            oUserSession = (UserResponse)Session["User"];

        }
    }
}