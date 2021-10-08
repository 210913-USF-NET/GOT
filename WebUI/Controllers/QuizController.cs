using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class QuizController : Controller
    {
        // GET: QuizController
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Question question)
        {
            try
            {
                
                House house = new House();
                List<int> list = new List<int>();

                list.Add(question.Question1);
                list.Add(question.Question2);
                list.Add(question.Question3);
                list.Add(question.Question4);
                list.Add(question.Question5);
                list.Add(question.Question6);
                list.Add(question.Question7);
                list.Add(question.Question8);
                list.Add(question.Question9);
                list.Add(question.Question10);

                Quiz(house, list);

                Dictionary<string, int> dict = new Dictionary<string, int>();

                dict.Add("Stark", house.Stark);
                dict.Add("Targaryen", house.Targaryen);
                dict.Add("Tully", house.Tully);
                dict.Add("Bolton", house.Bolton);
                dict.Add("Lannister", house.Lannister);
                //you need to sort it first

                CookieOptions op = new CookieOptions();
                op.Expires = DateTime.Now.AddSeconds(5);

                var sortedDict = from entry in dict orderby entry.Value descending select entry;

                Response.Cookies.Append("name", dict.ElementAt(0).Key, op);

                return RedirectToAction("Result", "Quiz");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Result()
        {
            if (Request.Cookies["name"] != null && Request.Cookies["name"] == "Stark")
            {
                ViewBag.message = Request.Cookies["name"];
                ViewBag.image = "https://wallpaperaccess.com/full/1307540.jpg";
            }
            else if (Request.Cookies["name"] != null && Request.Cookies["name"] == "Lannister")
            {
                ViewBag.message = Request.Cookies["name"];
                ViewBag.image = "https://i.ytimg.com/vi/rcgBNyy2Pls/maxresdefault.jpg";
            }
            else if (Request.Cookies["name"] != null && Request.Cookies["name"] == "Tully")
            {
                ViewBag.message = Request.Cookies["name"];
                ViewBag.image = "https://i.ytimg.com/vi/33BpR8rjrp0/maxresdefault.jpg";
            }
            else if (Request.Cookies["name"] != null && Request.Cookies["name"] == "Targaryen")
            {
                ViewBag.message = Request.Cookies["name"];
                ViewBag.image = "https://i.ytimg.com/vi/D6EDrPC3oeA/maxresdefault.jpg";
            }
            else if (Request.Cookies["name"] != null && Request.Cookies["name"] == "Bolton")
            {
                ViewBag.message = Request.Cookies["name"];
                ViewBag.image = "https://i.imgur.com/2YaWx0q.jpeg";
            }

            return View();
        }

        // GET: QuizController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QuizController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuizController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: QuizController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QuizController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: QuizController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QuizController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [NonAction]
        private void Quiz(House house, List<int> list)
        {
            foreach(int num in list)
            {
                switch (num)
                {
                    case 1:
                        house.Tully++;
                        break;
                    case 2:
                        house.Lannister++;
                        break;
                    case 3:
                        house.Targaryen++;
                        break;
                    case 4:
                        house.Stark++;
                        break;
                    case 5:
                        house.Bolton++;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
