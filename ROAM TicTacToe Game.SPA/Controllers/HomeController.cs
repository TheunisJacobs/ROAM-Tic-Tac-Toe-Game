using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ROAM_TicTacToe_Game.SPA.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PlayerIndex([FromBody]Player player)
        {
            this.addPlayer(player);
            return View();
        }
    }
}