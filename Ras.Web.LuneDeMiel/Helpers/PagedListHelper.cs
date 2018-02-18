using PagedList;
using Ras.Web.LuneDeMiel.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ras.Web.LuneDeMiel.Helpers
{
    /// <summary>
    /// <see cref="PagedList{T}"/> を補助します。
    /// </summary>
    public static class PagedListHelper
    {
        public static PagedList<T> NewInstance<T>(IEnumerable<T> source, int page)
        {
            return new PagedList<T>(source, page, SystemConst.DefaultPageSize);
        }
    }
}