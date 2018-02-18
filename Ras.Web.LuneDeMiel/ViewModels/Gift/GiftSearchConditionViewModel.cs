using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ras.Web.LuneDeMiel.ViewModels.Gift
{
    /// <summary>
    /// ギフト 検索条件ViewModel
    /// </summary>
    public class GiftSearchConditionViewModel
    {
        /// <summary> 商品名 </summary>
        public string Name { get; set; }

        /// <summary> 内訳商品名(～を含む) </summary>
        public string ProductName { get; set; }

        /// <summary> 原産国選択リスト </summary>
        public SelectList CountrySelectList { get; set; }

        /// <summary> 内訳商品原産国 </summary>
        public int CountryId { get; set; }

        /// <summary> 内訳商品地域(～を含む) </summary>
        public string Municipal { get; set; }

        /// <summary> 価格(最小) </summary>
        public int PriceMin { get; set; }

        /// <summary> 価格(最大) </summary>
        public int PriceMax { get; set; }
    }
}