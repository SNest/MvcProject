using System;
using System.Collections.Generic;
using System.Web.Mvc;
using MvcProject.Controllers;

namespace MvcProject.Helpers
{
    public static class TestHelper
    {
        public static MvcHtmlString TestFor(this HtmlHelper html,
           List<Question> questions, String Name)
        {
            TagBuilder br = new TagBuilder("br");

            TagBuilder hr = new TagBuilder("hr");

            //TagBuilder questionForm = new TagBuilder("form");
            //questionForm.InnerHtml += hr.ToString();
            //questionForm.MergeAttribute("name", Name);
            //questionForm.MergeAttribute("action", "/Form/Index");
            //questionForm.MergeAttribute("method", "post");

            TagBuilder questionList = new TagBuilder("ol");
            questionList.MergeAttribute("class", "question-list");

            TagBuilder questionListItem = new TagBuilder("li");

            TagBuilder answerList = new TagBuilder("ol");
            answerList.MergeAttribute("class", "answer-list");

            TagBuilder answerListItem = new TagBuilder("li");

            for (int i = 0; i < questions.Count; i++)
            {
                for (int j = 0; j < questions[i].answers.Count; j++)
                {
                    TagBuilder questionVariant = new TagBuilder("radio");
                    questionVariant.SetInnerText(questions[i].answers[j]);
                    answerListItem.InnerHtml = questionVariant.ToString();
                    answerList.InnerHtml += answerListItem.ToString();
                }

                questionList.InnerHtml += answerList.ToString();


                //questionForm.InnerHtml += text.ToString() + br.ToString() + date.ToString() + author.ToString() + hr.ToString();

            }
            return new MvcHtmlString(questionList.ToString());
        }
    }
}