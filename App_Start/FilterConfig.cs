using System.Web;
using System.Web.Mvc;

namespace TestingGitHubGCD0803
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
