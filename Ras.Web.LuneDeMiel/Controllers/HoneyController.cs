using PagedList;
using Ras.Web.LuneDeMiel.Helpers;
using Ras.Web.LuneDeMiel.ViewModels;
using Ras.Web.LuneDeMiel.ViewModels.Honey;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;

namespace Ras.Web.LuneDeMiel.Controllers
{
    /// <summary>
    /// はちみつ 機能のコントローラ
    /// </summary>
    public class HoneyController : Controller
    {
		// GET: Honey
		public ActionResult Index(int? page)
		{
			ViewBag.honeyCategory = new List<KeyValuePair<int, string>>()
			{
				new KeyValuePair<int, string>(1, "フルーツ"),
				new KeyValuePair<int, string>(2, "草花"),
				new KeyValuePair<int, string>(3, "樹木"),
				new KeyValuePair<int, string>(4, "ハーブ"),
				new KeyValuePair<int, string>(5, "百花蜜"),
				new KeyValuePair<int, string>(6, "ナッツ"),
				new KeyValuePair<int, string>(7, "甘露蜜")
			};
			var viewModel = new HoneyListViewModel();

			var honeys = new List<HoneyListItemViewModel>();

			for (var i = 0; i < 1000; i++)
			{
				honeys.Add(new HoneyListItemViewModel()
				{
					Id = i,
					Name = "JA青森りんご",
					Municipal = "日本 青森県",
					FlowerName = "りんご",
					SizePriceDictionary = new Dictionary<int, int>()
					{
						{100, 1404},
						{250, 2592}
					},
					imageBytes = null
				});
			}

			viewModel.Honeys = PagedListHelper.NewInstance(honeys, page.HasValue ? page.Value : 1);

			return View(viewModel);
        }

        // GET: Honey/Detail?id={id}
        public ActionResult Detail(int? id)
        {
			if(!id.HasValue)
			{
				// TODO エラー

				id = 1;
			}

			var viewModel = new HoneyListItemViewModel()
			{
				Id = id.Value,
				Name = "JA青森りんご",
				Municipal = "日本 青森県",
				FlowerName = "りんご",
				SizePriceDictionary = new Dictionary<int, int>()
					{
						{100, 1404},
						{250, 2592}
					},
				imageBytes = null
			};

			return View();
        }

        // GET: Honey/Edit?id={id}
        public ActionResult Edit()
        {
            return View();
        }

        // GET: Honey/BulkEdit
        public ActionResult BulkEdit()
        {
            return View();
        }

        // GET: Honey/Study
        public ActionResult Study()
        {
            return View();
        }
    }
}