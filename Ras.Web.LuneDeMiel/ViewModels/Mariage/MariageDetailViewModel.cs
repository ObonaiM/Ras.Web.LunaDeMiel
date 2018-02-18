using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ras.Web.LuneDeMiel.ViewModels.Mariage
{
    /// <summary>
    /// 食べ合わせ詳細のViewModelです。
    /// </summary>
    public class MariageDetailViewModel
    {
        /// <summary> ID </summary>
        public int Id { get; set; }

        /// <summary> 画像(BLOB文字列) </summary>
        public string Image { get; set; }

        /// <summary> 商品名 </summary>
        public string ProductName { get; set; }

        /// <summary> はちみつ分類 </summary>
        public string HoneyCategory { get; set; }

        /// <summary> 産地(国) </summary>
        public string Country { get; set; }

        /// <summary> 産地(地域名) </summary>
        public string MunicipalName { get; set; }

        /// <summary> 食品名 </summary>
        public string FoodName { get; set; }

        /// <summary> 説明 </summary>
        public string Content { get; set; }

        /// <summary> コメント </summary>
        public string Comment { get; set; }
    }
}