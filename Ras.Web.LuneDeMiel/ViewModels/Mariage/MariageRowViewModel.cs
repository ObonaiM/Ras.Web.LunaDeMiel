using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ras.Web.LuneDeMiel.ViewModels.Mariage
{
    /// <summary>
    /// 食べ合わせ一覧における一行のデータを表します。
    /// </summary>
    public class MariageRowViewModel
    {
        /// <summary> ID </summary>
		public int Id { get; set; }

        /// <summary> 画像(BLOB文字列) </summary>
        public string Image { get; set; }

        /// <summary> 商品名 </summary>
        public string ProductName { get; set; }

        /// <summary> 分類 </summary>
        public string HaneyCategory { get; set; }

        /// <summary> 地域 </summary>
        public string Area { get; set; }

        /// <summary> 食品名 </summary>
        public string FoodName { get; set; }

        /// <summary> 説明 </summary>
        public string Content { get; set; }

        /// <summary> コメント </summary>
        public string Comment { get; set; }
    }
}