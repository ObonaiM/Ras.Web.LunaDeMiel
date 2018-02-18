using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ras.Web.LuneDeMiel.ViewModels.Honey
{
	/// <summary>
	/// はちみつ一覧検索条件ViewModel
	/// </summary>
	public class HoneySearchConditionViewModel
	{
		/// <summary> 商品名 </summary>
		public string Name { get; set; }
		/// <summary> 花の名前 </summary>
		public string FlowerName { get; set; }
		/// <summary> 地域名 </summary>
		public string CountryName { get; set; }
		/// <summary> 値段_From </summary>
		public int? PriceFrom { get; set; }
		/// <summary> 値段_To </summary>
		public int? PriceTo { get; set; }
		/// <summary> 分類 </summary>
		public int HoneyCategory { get; set; }
	}
}