﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace ChatWeb.Business
{
    public class Constants
    {
        public static string URL_API
        {
            get
            {
                return ConfigurationManager.AppSettings["url_ws"];
            }
        }

        public class Url
        {

            public static string REGISTER
            {
                get
                {
                    return URL_API + "/api/User/";
                }
            }

            public static string ACCESS
            {
                get
                {
                    return URL_API + "/api/Access/";
                }
            }

            public static string ROOMS
            {
                get
                {
                    return URL_API + "/api/Room/";
                }
            }

            public static string MESSAGES
            {
                get
                {
                    return URL_API + "/api/Messages/";
                }
            }

            public static string SignalR
            {
                get
                {
                    return URL_API + "signalr/";
                }
            }

            public static string SignalRHub
            {
                get
                {
                    return URL_API + "signalr/hubs";
                }
            }
        }
    }
}