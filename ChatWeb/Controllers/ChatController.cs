using ChatWeb.Business;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UtilitiesChat.Models.WS;
using UtilitiesChat.Tools;

namespace ChatWeb.Controllers
{
    public class ChatController : BaseController
    {
        // GET: Chat
        public ActionResult Messages(int id)
        {
            GetSession();
            List<MessagesResponse> lst = new List<MessagesResponse>();

            MessagesRequest oMessagesRequest = new MessagesRequest();
            oMessagesRequest.AccessToken = oUserSession.AccessToken;
            oMessagesRequest.IdRoom = oUserSession.Id;

            RequestUtil oRequestUtil = new RequestUtil();

            Reply oReply = oRequestUtil.Execute<MessagesRequest>(Constants.Url.MESSAGES, "post", oMessagesRequest);

            lst = JsonConvert.DeserializeObject<List<MessagesResponse>>(JsonConvert.SerializeObject(oReply.data));

            lst = lst.OrderBy(d => d.DateCreated).ToList();

            return View(lst);
        }
    }
}