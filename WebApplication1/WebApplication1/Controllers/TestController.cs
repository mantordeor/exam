using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Exam()
        {
            return View(new ExamData());
        }
        [HttpPost]
        public ActionResult Exam(ExamData data)
        {
            if (data.Name!="")
            {
                data.NameMessage = data.Name;
            }
            if (data.Number == "1")
            {
                data.NumberMessage = "do";
            }
            if (data.Number == "2")
            {
                data.NumberMessage = "re";
            }
            if (data.Number == "3")
            {
                data.NumberMessage = "me";
            }
            if (data.Number == "4")
            {
                data.NumberMessage = "fa";
            }
            if (data.Number == "5")
            {
                data.NumberMessage = "so";
            }
            if (data.Number == "6")
            {
                data.NumberMessage = "la";
            }
            if (data.Number == "7")
            {
                data.NumberMessage = "si";
            }
            if(data.Number != "1" && data.Number != "2" && data.Number != "3" && data.Number != "4" && data.Number != "5" && data.Number != "6" && data.Number != "7")
            {
                data.NumberMessage = "請輸入1~7";
            }
            return View(data);
        }
    }
}