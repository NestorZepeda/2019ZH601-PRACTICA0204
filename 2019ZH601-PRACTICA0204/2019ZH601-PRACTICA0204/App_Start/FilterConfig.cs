using System.Web;
using System.Web.Mvc;

namespace _2019ZH601_PRACTICA0204
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
