using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ras.Web.LuneDeMiel.ViewModels.Mariage
{
    /// <summary>
    /// 食べ合わせ一覧のViewModelです。
    /// </summary>
    public class MariageListViewModel
    {
        /// <summary> はちみつ分類セレクトリスト </summary>
        public SelectList HoneyCategories { get; set; }

        /// <summary> 国リスト </summary>
        public SelectList Countries { get; set; }

        /// <summary> 検索条件 </summary>
        public MariageSearchCondViewModel SearchCond { get; set; }

        /// <summary> 一覧 </summary>
        public IPagedList<MariageRowViewModel> Rows { get; set; }
    }
}