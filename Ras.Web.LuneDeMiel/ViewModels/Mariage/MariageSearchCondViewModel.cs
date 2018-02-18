using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ras.Web.LuneDeMiel.ViewModels.Mariage
{
    /// <summary>
    /// 食べ合わせ検索条件
    /// </summary>
    public class MariageSearchCondViewModel
    {
        /// <summary> 商品名 </summary>
        public string ProductName { get; set; }

        /// <summary> 分類ID </summary>
        public int? HoneyCategory { get; set; }

        /// <summary> 国ID </summary>
        public int? Country { get; set; }

        /// <summary> 地域名 </summary>
        public string MunicipalName { get; set; }

        /// <summary> 食品名 </summary>
        public string FoodName { get; set; }

        /// <summary> 説明 </summary>
        public string Content { get; set; }
    }
}