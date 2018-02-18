using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ras.Web.LuneDeMiel.Controllers
{
    /// <summary>
    /// ギフトボックス機能 のコントローラ
    /// </summary>
    public class GiftBoxController : Controller
    {
        // GET: GiftBox
        public ActionResult Index()
        {
            return View();
        }
    }
}