using LinqToDB;
using LINQTraining.Codes;
using LINQTraining.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LINQTraining.Controllers
{
    public class SqlController : Controller
    {
        // GET: Sql
        public ActionResult Index()
        {
            Helper.CheckDB(Server.MapPath("~/App_Data/Test.sqlite"));
            return View();
        }
        public ActionResult Insert()
        {
            using (var Context = new DataContext("SQLiteConnection"))
            {
                var model = new Student();
                model.StudentId = "10000";
                model.Name = "張三";
                model.Indate = DateTime.Now;
                model.Score = 60;
                Context.Insert(model);
                model.StudentId = "10001";
                model.Name = "菜國文";
                model.Indate = DateTime.Now;
                model.Score = 59;
                Context.Insert(model);
                ViewBag.MESSAGE = "新增成功";
            }

            return View("Index");
        }
        public ActionResult Update()
        {
            using (var Context = new DataContext("SQLiteConnection"))
            {
                var model = Context.GetTable<Student>().FirstOrDefault(s => s.StudentId == "10001");
                model.Score = 60;
                ViewBag.MESSAGE = "修改成功";
                Context.Update(model);
            }
            return View("Index");
        }
        public ActionResult Delete()
        {
            using (var Context = new DataContext("SQLiteConnection"))
            {
                var model = Context.GetTable<Student>().FirstOrDefault(s => s.StudentId == "10001");
                Context.Delete(model);
                ViewBag.MESSAGE = "刪除成功";
            }
            return View("Index");
        }
    }
}