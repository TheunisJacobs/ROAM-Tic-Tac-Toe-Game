using System.Web;
using System.Web.Mvc;

namespace ROAM_TicTacToe_Game.SPA
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
