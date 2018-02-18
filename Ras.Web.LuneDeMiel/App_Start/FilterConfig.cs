using System.Web;
using System.Web.Mvc;

namespace Ras.Web.LuneDeMiel
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
