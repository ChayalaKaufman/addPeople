using System.Web;
using System.Web.Mvc;

namespace classwork_032519_addPeople
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
