using System.Web;
using System.Web.Mvc;

namespace Lab_MVC_med_Javascript_och_Ajax
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
