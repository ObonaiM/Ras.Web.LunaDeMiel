using Ras.Web.LuneDeMiel.Helpers;
using Ras.Web.LuneDeMiel.ViewModels.Mariage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ras.Web.LuneDeMiel.Controllers
{
    /// <summary>
    /// 食べ合わせ 機能のコントローラ
    /// </summary>
    public class MariageController : Controller
    {
        // GET: /Mariage
        // GET: /Mariage/Index?page={page}
        public ActionResult Index(int? page)
        {
            var countries = new SelectList(
                    new Dictionary<int, string>
                    {
                        { 0, string.Empty },
                        { 1, "日本" },
                        { 2, "中国" },
                        { 3, "ギリシャ" }
                    },
                    "Key",
                    "Value"
                );

            var categories = new SelectList(
                    new Dictionary<int, string>
                    {
                        { 0, string.Empty },
                        { 1, "フルーツ" },
                        { 2, "草花" },
                        { 3, "樹木" }
                    },
                    "Key",
                    "Value"
                );

            var mariages = Enumerable.Range(1, 500)
                                     .Select(x => new MariageRowViewModel
                                     {
                                         Id = x,
                                         ProductName = "JA青森りんご",
                                         HaneyCategory = "フルーツ",
                                         Area = "日本 青森県",
                                         FoodName = "ロシアンティー",
                                         Content = "説明...",
                                         Comment = "感想..."
                                     });

            var vm = new MariageListViewModel
            {
                Countries = countries,
                HoneyCategories = categories,
                SearchCond = new MariageSearchCondViewModel(),
                Rows = PagedListHelper.NewInstance(mariages, page ?? 1)
            };

            return View(vm);
        }

        // GET: /Mariage/Detail?id={id}
        public ActionResult Detail(int id)
        {
            var vm = new MariageDetailViewModel
            {
                Id = id,
                ProductName = "JA青森りんご",
                HoneyCategory = "フルーツ",
                Country = "日本",
                MunicipalName = "青森県",
                FoodName = "ロシアンティー",
                Content = "説明<br />説明<br />説明",
                Comment = "感想<br />感想<br />感想"
            };

            return View(vm);
        }
    }
}