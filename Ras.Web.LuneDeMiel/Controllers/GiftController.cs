using PagedList;
using Ras.Web.LuneDeMiel.Helpers;
using Ras.Web.LuneDeMiel.Logics;
using Ras.Web.LuneDeMiel.ViewModels.Gift;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ras.Web.LuneDeMiel.Controllers
{
    /// <summary>
    /// ギフト 機能のコントローラ
    /// </summary>
    public class GiftController : Controller
    {
        // GET: Gift
        // GET: Gift/{page}
        public ActionResult Index(int page)
        {
            /*
             * For Mockup
             */

            var logic = new GiftLogic();
            var gifts = logic.SelectGift();

            var listViewModel = new GiftListViewModel
            {
                SearchCondition = new GiftSearchConditionViewModel
                {
                    CountrySelectList = new SelectList(
                        new Dictionary<int, string>
                        {
                            { 0, "選択してください" },
                            { 1, "日本" },
                            { 2, "フランス" }
                        },
                        "Key",
                        "Value",
                        0)
                },
                Gifts = PagedListHelper.NewInstance(gifts, page)
            };

            return View(listViewModel);
        }
    }
}