using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Domain.Entities;

namespace MvcProject.Helpers
{
    public static class FeedbackHelper
    {
        public static MvcHtmlString FeedbackFor(this HtmlHelper html,
           List<Feedback> feedbacks, String Name)
        {
            TagBuilder br = new TagBuilder("br");

            TagBuilder hr = new TagBuilder("hr");

            TagBuilder feedbackSet = new TagBuilder("div");
            feedbackSet.InnerHtml += hr.ToString();
            feedbackSet.MergeAttribute("name", Name);

            TagBuilder text = new TagBuilder("article");
            text.MergeAttribute("class", "text");

            TagBuilder date = new TagBuilder("span");
            date.MergeAttribute("class", "date");

            TagBuilder author = new TagBuilder("span");
            author.MergeAttribute("class", "author");

            for (int i = 0; i < feedbacks.Count; i++)
            {
                text.SetInnerText(feedbacks[i].Text);

                date.SetInnerText(feedbacks[i].Date.ToLocalTime().ToString());

                author.SetInnerText(feedbacks[i].User.FirstName +" "+ feedbacks[i].User.FirstName);

                feedbackSet.InnerHtml += text + br.ToString() + date + author + hr;

            }
            return new MvcHtmlString(feedbackSet.ToString());
        }
    }
}