using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ras.Web.LuneDeMiel.ViewModels.Gift
{
    /// <summary>
    /// ギフトViewModel
    /// </summary>
    public class GiftViewModel
    {
        /// <summary> ID </summary>
        public string Id { get; set; }

        /// <summary> 商品名 </summary>
        public string Name { get; set; }

        /// <summary> 値段 </summary>
        public int Price { get; set; }

        /// <summary> 内訳 </summary>
        public IList<GiftItemViewModel> Items { get; set; }

        /// <summary>
        /// 値段表示用のラベル
        /// </summary>
        public string PriceLabel
        {
            get
            {
                return string.Format("{0:#,0}円", this.Price);
            }
        }

        /// <summary>
        /// 内訳表示用のラベル
        /// </summary>
        public string ItemsLabel
        {
            get
            {
                return string.Join("・", this.Items.Select(i => i.Name));
            }
        }
    }
}