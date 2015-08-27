using System.Collections.Generic;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class FormController : Controller
    {
        List<Question> questions = new List<Question>();
        [HttpGet]
        public ActionResult Index()
        {
            for (int i = 0; i < 5; i++)
            {
                Question q = new Question();
                q.Text = "Question" + (i+1);
                q.answers.Add("Answer1");
                q.answers.Add("Answer2");
                q.answers.Add("Answer3");
                questions.Add(q);
            }
            ViewBag.Questions = questions;
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            return View();
        }
    }

    public class Question
    {
        public List<string> answers = new List<string>();
        public string Text { get; set; }
    }
}