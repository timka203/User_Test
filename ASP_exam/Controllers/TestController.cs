using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_exam.Controllers
{
    public class TestController : Controller
    {
        public static Game game = new Game();
        public ActionResult Index()
        {
            game.test_Info.Test_Date = DateTime.Now;
            return View(new Test_info());
        }
        public ActionResult test(FormCollection collection)
        {

            string str = collection["FirstName"];
            game.test_Info.Test_start = DateTime.Now;

            game.test_Info.FirstName = collection["FirstName"];
            game.test_Info.LastName = collection["LastName"];


            return View();
        }
        public ActionResult result(FormCollection collection)
        {
            game.test_Info.Test_end = DateTime.Now;
            string str = collection[0];
            game.ans.Add(collection[0]);
            game.ans.Add(collection[1]);
            game.ans.Add(collection[2]);
            game.ans.Add(collection[3]);
            game.ans.Add(collection[4]);
            int game_int = 0;
            if (game.ans[0] == "6")
            {
                game_int++;

            }
            if (game.ans[1] == "8")
            {
                game_int++;
            }
            if (game.ans[2] == "Moon")
            {
                game_int++;
            }
            if (game.ans[3] == "1")
            {
                game_int++;
            }
            if (game.ans[4] == "Gagarin")
            {
                game_int++;
            }
            game.test_Info.Right_ans = game_int;

            DB_model dB_Model = new DB_model();
            dB_Model.Test_info.Add(game.test_Info);
            dB_Model.SaveChanges();

            return View(game);
        }
        public ActionResult Report()
        {

            return View(game);
        }
    }
}