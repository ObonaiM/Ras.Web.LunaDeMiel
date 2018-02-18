using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ras.Web.LuneDeMiel.Controllers
{
    /// <summary>
    /// 養蜂家 機能のコントローラ
    /// </summary>
    public class CreatorController : Controller
    {
        // GET: Beekeeper
        public ActionResult Index()
        {
            return View();
        }
    }
}