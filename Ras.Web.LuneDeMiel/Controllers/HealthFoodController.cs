using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ras.Web.LuneDeMiel.Controllers
{
    /// <summary>
    /// 健康食品 機能のコントローラ
    /// </summary>
    public class HealthFoodController : Controller
    {
        // GET: HealthyFood
        public ActionResult Index()
        {
            return View();
        }
    }
}