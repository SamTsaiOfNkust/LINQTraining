using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LINQTraining.Controllers
{
    public class HomeController : Controller
    {
        int[] Sources = new int[] { 49, 10, -10, 90, 80, 99, -20 };
        public ActionResult Index()
        {
            #region 傳統寫法
            /*
            var Result = new List<int>();
            foreach (var Row in Sources)
            {
                if (Row > 0)
                    Result.Add(Row);
            }
            */
            #endregion
            // 使用LINQ
            var Result = Sources.Where(s => s > 0).ToList();


            ViewBag.SOURCE = Sources;
            ViewBag.RESULT = Result;
            return View();
        }
        public ActionResult IndexWithSort()
        {
            #region 傳統寫法
            /*
            var Result = new List<int>();
            foreach (var Row in Sources)
            {
                if (Row > 0)
                    Result.Add(Row);
            }
            Comparison<int> comparison = delegate (int a, int b)
            {
                return b - a;
            };
            Result.Sort(comparison);
            */
            #endregion
            // 使用LINQ
            
            var Result = Sources.Where(s => s > 0).OrderBy(s => s).ToList();
            // or 
            /*
            var Result = 
                from s in Sources
                     where s > 0
                     orderby s
                     select s;
                     */
            ViewBag.SOURCE = Sources;
            ViewBag.RESULT = Result;
            return View("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}