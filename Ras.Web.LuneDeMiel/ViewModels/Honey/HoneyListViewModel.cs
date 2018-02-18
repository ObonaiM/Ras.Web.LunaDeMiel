using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ras.Web.LuneDeMiel.ViewModels.Honey
{
    /// <summary>
    /// はちみつ の画面表示項目を表します。
    /// </summary>
    public class HoneyListViewModel
    {
		/// <summary>
		/// 検索条件ViewModel
		/// </summary>
		public HoneySearchConditionViewModel SearchCondition { get; set; }

		/// <summary>
		/// はちみつ一覧表示リスト
		/// </summary>
		public IPagedList<HoneyListItemViewModel> Honeys { get; set; }
	}
}